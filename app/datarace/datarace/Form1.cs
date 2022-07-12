using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataraceContext;

namespace datarace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataraceDataSet.team' table. You can move, or remove it, as needed.
            teamTableAdapter.Fill(this.dataraceDataSet.team);
            // TODO: This line of code loads data into the 'dataraceDataSet.piloti' table. You can move, or remove it, as needed.
            pilotiTableAdapter.Fill(this.dataraceDataSet.piloti);
            comboBoxNazionalita.Items.AddRange(this.GetCountryList().ToArray());
            comboBoxPaeseTeam.Items.AddRange(this.GetCountryList().ToArray());
            comboBoxNomeRicercaTeam.Items.AddRange(this.GetAllTeams().ToArray());
            checkedListBoxClassiTeam.Items.AddRange(this.GetAllClasses().ToArray());
            // disables the "Registra" button if the current season is over
            using (DataraceDataContext ctx = new DataraceDataContext())
            {
                var currentYear = ctx.StagioneCorrente.Select(sc => sc.Anno).Single();
                var events = ctx.Stagioni.Where(s => s.Anno == currentYear).Select(s => s.NumeroProve).Single();
                if (ctx.Iscrizioni.Where(i => i.Risultato != null && i.Anno == currentYear 
                    && i.PosizioneCalendario == events).Any()) {
                    buttonQueryTeam.Enabled = false;
                }
            }
        }

        private List<string> GetAllTeams()
        {
            using (DataraceDataContext ctx = new DataraceDataContext())
            {
                var query = ctx.Teams.Select(t => t.Nome);
                return query.ToList();
            }
        }

        private List<string> GetAllClasses()
        {
            using (DataraceDataContext ctx = new DataraceDataContext())
            {
                var query = ctx.Classi.Select(t => t.Nome);
                return query.ToList();
            }
        }

        private void ButtonAggungiPilota_Click(object sender, EventArgs e)
        {
            using (DataraceDataContext ctx = new DataraceDataContext())
            {
                var currentMaxId = ctx.Piloti.Select(p => p.IdPilota).Max();
                var pilota = new Piloti
                {
                    IdPilota = this.AutoIncrement(currentMaxId, 6),
                    Nome = textBoxNomePilota.Text,
                    Cognome = textBoxCognomePilota.Text,
                    LuogoDiNascita = textBoxLuogoDiNascita.Text,
                    Nazionalita = comboBoxNazionalita.Text,
                    DataDiNascita = dataDiNascitaPicker.Value.Date.ToString("yyyy/MM/dd")
                };
                if (CheckDataValidity(new List<string> { pilota.IdPilota, pilota.Nome, pilota.Cognome,
                    pilota.LuogoDiNascita, pilota.Nazionalita, pilota.DataDiNascita }))
                {
                    dataGridViewPiloti.DataSource = null;
                    ctx.Piloti.InsertOnSubmit(pilota);
                    ctx.SubmitChanges();
                    dataGridViewPiloti.DataSource = pilotiBindingSource;
                    // clears data after update
                    textBoxNomePilota.Text = string.Empty;
                    textBoxCognomePilota.Text = string.Empty;
                    textBoxLuogoDiNascita.Text = string.Empty;
                    comboBoxNazionalita.Text = string.Empty;
                }
            }
        }

        private void ButtonRicercaPiloti_Click(object sender, EventArgs e)
        {
            using (DataraceDataContext ctx = new DataraceDataContext())
            {
                IQueryable query;
                if (comboBoxSceltaQueryPiloti.SelectedItem != null)
                {
                    if (comboBoxSceltaQueryPiloti.SelectedItem.Equals("Statistiche di carriera di un pilota"))
                    {
                        query = QueryV7(ctx);
                    }
                    else
                    {
                        query = QueryV3(ctx);
                    }
                    ShowResultsOnGrid(query, dataGridViewQueryPiloti);
                }
            }
        }

        private IQueryable QueryV3(DataraceDataContext ctx)
        {
            return from p in ctx.Piloti
                   join pp in ctx.PartecipazioniPilota on p.IdPilota equals pp.Pilota
                   where p.Nome == textBoxNomeRicercaPiloti.Text && p.Cognome == textBoxCognomeRicercaPiloti.Text
                   select new
                   {
                       nome = p.Nome,
                       cognome = p.Cognome,
                       classe = pp.Classe,
                       anno = pp.Anno,
                       eta = pp.Eta,
                       esperienza = pp.Esperienza,
                       punti = pp.PuntiValidi,
                       posizioneClassifica = pp.PosizioneClassifica
                   };
        }

        private IQueryable QueryV7(DataraceDataContext ctx)
        {
            return ctx.Piloti
                .Where(p => p.Nome == textBoxNomeRicercaPiloti.Text && p.Cognome == textBoxCognomeRicercaPiloti.Text)
                .Select(p => 
                new {
                    nome = p.Nome,
                    cognome = p.Cognome,
                    gareDisputate = p.StatistichePiloti.GareDisputate,
                    vittorie = p.StatistichePiloti.Vittorie,
                    polePositions = p.StatistichePiloti.PolePositions,
                    podi = p.StatistichePiloti.Podi,
                    giriVeloci = p.StatistichePiloti.GiriVeloci,
                    mondialiVinti = p.StatistichePiloti.MondialiVinti
                });
        }

        private void ShowResultsOnGrid(IQueryable queryResult, DataGridView dataGrid)
        {
            dataGrid.DataSource = queryResult;
        }

        private bool CheckDataValidity<T>(List<T> items)
        {
            return !items.Where(i => i == null).Any();
        }

        private string AutoIncrement(string currentValue, int size)
        {
            int autoincrement = int.Parse(currentValue) + 1;
            string autoincrementString = autoincrement.ToString();
            if (autoincrementString.Length > size)
            {
                return "";
            }
            while (autoincrementString.Length != size)
            {
                autoincrementString = "0" + autoincrementString;
            }
            return autoincrementString;
        }

        private List<string> GetCountryList()
        {
            List<string> cultureList = new List<string>();
            CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
            foreach (CultureInfo culture in cultures)
            {
                RegionInfo region = new RegionInfo(culture.LCID);
                if (!(cultureList.Contains(region.DisplayName)))
                {
                    cultureList.Add(region.DisplayName);
                }
            }
            cultureList.Sort();
            return cultureList;
        }

        private void ButtonAggiungiTeam_Click(object sender, EventArgs e)
        {
            using (DataraceDataContext ctx = new DataraceDataContext())
            {
                var currentMaxId = ctx.Teams.Select(p => p.IdTeam).Max();
                var team = new Team
                {
                    IdTeam = this.AutoIncrement(currentMaxId, 3),
                    Nome = textBoxNomeTeam.Text,
                    Paese = comboBoxPaeseTeam.Text,
                    Tipo = comboBoxTipoTeam.Text
                };
                if (CheckDataValidity(new List<string> { team.IdTeam, team.Nome, team.Paese, team.Tipo }))
                {
                    dataGridViewPiloti.DataSource = null;
                    ctx.Teams.InsertOnSubmit(team);
                    ctx.SubmitChanges();
                    dataGridViewPiloti.DataSource = pilotiBindingSource;
                }
            }
        }

        private void ButtonQueryTeam_Click(object sender, EventArgs e)
        {
            using (DataraceDataContext ctx = new DataraceDataContext())
            {
                // first it is needed to create a new instance of StagioniTeam
                var stagioneTeam = new StagioniTeam()
                {
                    Anno = ctx.StagioneCorrente.Select(sc => sc.Anno).Single(),
                    NomeUfficiale = textBoxNomeUfficialeTeam.Text,
                    Team = ctx.Teams.Where(t => t.Nome.Equals(comboBoxNomeRicercaTeam.Text)).Select(t => t.IdTeam).Single(),
                    TeamManager = textBoxTeamManager.Text
                };
                if (CheckDataValidity(new List<string>() { stagioneTeam.NomeUfficiale, stagioneTeam.TeamManager, 
                    stagioneTeam.Team }) && CheckDataValidity(new List<int> { stagioneTeam.Anno }))
                {
                    // then if data is valid the team can be registered to the championships
                    ctx.StagioniTeam.InsertOnSubmit(stagioneTeam);
                    var partecipazioniTeam = new List<PartecipazioniTeam>();
                    for (int i = 0; i < checkedListBoxClassiTeam.CheckedItems.Count; i++)
                    {
                        var pt = new PartecipazioniTeam()
                        {
                            Classe = checkedListBoxClassiTeam.CheckedItems[i] as string,
                            Anno = stagioneTeam.Anno,
                            Team = stagioneTeam.NomeUfficiale,
                            Punti = 0,
                            PosizioneClassifica = 0
                        };
                        if (CheckDataValidity(new List<string>() { pt.Classe }))
                        {
                            partecipazioniTeam.Add(pt);
                        }
                    }
                    ctx.PartecipazioniTeam.InsertAllOnSubmit(partecipazioniTeam);
                }
                ctx.SubmitChanges();
                // clears data after update
                textBoxNomeUfficialeTeam.Text = string.Empty;
                comboBoxNomeRicercaTeam.Text = string.Empty;
                textBoxTeamManager.Text = string.Empty;
                for (int i = 0; i < checkedListBoxClassiTeam.Items.Count; i++)
                {
                    checkedListBoxClassiTeam.SetItemChecked(i, false);
                }
            }
        }
    }
}
