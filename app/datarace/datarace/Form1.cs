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
using Devart.Data.Linq;

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
            // TODO: This line of code loads data into the 'dataraceDataSet.prove' table. You can move, or remove it, as needed.
            this.proveTableAdapter.Fill(this.dataraceDataSet.prove);
            // TODO: This line of code loads data into the 'dataraceDataSet.gran_premi' table. You can move, or remove it, as needed.
            gran_premiTableAdapter.Fill(dataraceDataSet.gran_premi);
            // loads data into the tables
            costruttoriTableAdapter.Fill(dataraceDataSet.costruttori);
            teamTableAdapter.Fill(dataraceDataSet.team);
            pilotiTableAdapter.Fill(dataraceDataSet.piloti);
            // differentiate autosize mode for columns in table dataGridViewGranPremi
            dataGridViewGranPremi.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewGranPremi.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            // sets values of many view items
            LoadOrRefreshViewItems();
        }

        private void LoadOrRefreshViewItems()
        {
            // manages some buttons' enabling based on the state of the current season
            using (DataraceDataContext ctx = new DataraceDataContext())
            {
                var currentYear = ctx.StagioneCorrente.Select(sc => sc.Anno).Single();
                var events = ctx.Stagioni.Where(s => s.Anno == currentYear).Select(s => s.NumeroProve).Single();
                // if the current season is over...
                bool isOver = ctx.Iscrizioni.Where(i => i.Anno == currentYear && i.PosizioneCalendario == events &&
                                         i.Risultato != null).Any();
                buttonQueryTeam.Enabled = !isOver;
                buttonInserisciStagione.Enabled = isOver;
                textBoxNumeroProve.Enabled = isOver;
                comboBoxNomeGPQueryStagione.Enabled = isOver;
                comboBoxNomeCircuitoQueryStagione.Enabled = isOver;
                dateTimePickerDataInizioGP.Enabled = isOver;
                dateTimePickerDataFineGP.Enabled = isOver;
                buttonInserisciProva.Enabled = isOver;
            }
            comboBoxNazionalita.Items.Clear();
            comboBoxNazionalita.Items.AddRange(GetCountryList().ToArray());
            comboBoxPaeseTeam.Items.Clear();
            comboBoxPaeseTeam.Items.AddRange(GetCountryList().ToArray());
            comboBoxPaeseCostruttore.Items.Clear();
            comboBoxPaeseCostruttore.Items.AddRange(GetCountryList().ToArray());
            comboBoxNomeRicercaTeam.Items.Clear();
            comboBoxNomeRicercaTeam.Items.AddRange(GetAllTeams().ToArray());
            checkedListBoxClassiTeam.Items.Clear();
            checkedListBoxClassiTeam.Items.AddRange(GetAllClasses().ToArray());
            comboBoxNomeRicercaCostruttore.Items.Clear();
            comboBoxNomeRicercaCostruttore.Items.AddRange(GetAllConstructors().ToArray());
            comboBoxNomeInserimentoCostruttore.Items.Clear();
            comboBoxNomeInserimentoCostruttore.Items.AddRange(GetAllConstructors().ToArray());
            comboBoxRicercaGP.Items.Clear();
            comboBoxRicercaGP.Items.AddRange(GetAllGPs().ToArray());
            comboBoxRicercaClasse.Items.Clear();
            comboBoxRicercaClasse.Items.AddRange(GetAllClasses().ToArray());
            comboBoxSelezioneStagione.Items.Clear();
            comboBoxSelezioneStagione.Items.AddRange(GetAllSeasons().ToArray());
            ShowCurrentSeasonCalendar();
        }

        private void ShowCurrentSeasonCalendar()
        {
            using (DataraceDataContext ctx = new DataraceDataContext())
            {
                var query = from sc in ctx.StagioneCorrente
                            select sc.Anno;
                ShowSeasonCalendar(query.Single());
            }
        }

        private void ShowSeasonCalendar(int season)
        {
            using (DataraceDataContext ctx = new DataraceDataContext())
            {
                var query = from p in ctx.Prove
                            join c in ctx.Circuiti on p.Circuito equals c.IdCircuito
                            where p.Anno == season
                            select new
                            {
                                prova = p.PosizioneCalendario,
                                GP = p.NomeUfficiale,
                                circuito = c.Nome,
                                dataInizio = p.DataInizio,
                                dataFine = p.DataFine,
                                numeroEdizione = p.NumeroEdizione
                            };
                ShowResultsOnGrid(query, dataGridViewCalendario);
            }
        }

        private List<string> GetAllSeasons()
        {
            using (DataraceDataContext ctx = new DataraceDataContext())
            {
                var query = ctx.Stagioni.Select(s => s.Anno.ToString());
                var list = query.ToList();
                list.Reverse();
                return list;
            }
        }

        private List<string> GetAllGPs()
        {
            using (DataraceDataContext ctx = new DataraceDataContext())
            {
                var query = ctx.GranPremi.Select(t => t.Denominazione);
                return query.ToList();
            }
        }

        private List<string> GetAllConstructors()
        {
            using (DataraceDataContext ctx = new DataraceDataContext())
            {
                var query = ctx.Costruttori.Select(t => t.Nome);
                return query.ToList();
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
                    // refreshes view items
                    LoadOrRefreshViewItems();
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
                        query = ctx.Piloti
                                    .Where(p => p.Nome == textBoxNomeRicercaPiloti.Text &&
                                            p.Cognome == textBoxCognomeRicercaPiloti.Text)
                                    .Select(p => new {
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
                    else
                    {
                        query = from p in ctx.Piloti
                                join pp in ctx.PartecipazioniPilota on p.IdPilota equals pp.Pilota
                                where p.Nome == textBoxNomeRicercaPiloti.Text &&
                                        p.Cognome == textBoxCognomeRicercaPiloti.Text
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
                    ShowResultsOnGrid(query, dataGridViewQueryPiloti);
                }
            }
        }

        private void ButtonAggiungiTeam_Click(object sender, EventArgs e)
        {
            using (DataraceDataContext ctx = new DataraceDataContext())
            {
                var currentMaxId = ctx.Teams.Select(p => p.IdTeam).Max();
                var team = new Team
                {
                    IdTeam = AutoIncrement(currentMaxId, 3),
                    Nome = textBoxNomeTeam.Text,
                    Paese = comboBoxPaeseTeam.Text,
                    Tipo = comboBoxTipoTeam.Text
                };
                if (CheckDataValidity(new List<string> { team.IdTeam, team.Nome, team.Paese, team.Tipo }))
                {
                    dataGridViewTeam.DataSource = null;
                    ctx.Teams.InsertOnSubmit(team);
                    ctx.SubmitChanges();
                    dataGridViewTeam.DataSource = teamBindingSource;
                    // clears data after update
                    textBoxNomeTeam.Text = string.Empty;
                    comboBoxPaeseTeam.Text = string.Empty;
                    comboBoxTipoTeam.Text = string.Empty;
                    // refreshes view items
                    LoadOrRefreshViewItems();
                }
            }
        }

        private void ButtonQueryTeam_Click(object sender, EventArgs e)
        {
            using (DataraceDataContext ctx = new DataraceDataContext())
            {
                // first we need to create a new instance of StagioniTeam
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

        private void ButtonAggiungiCostruttore_Click(object sender, EventArgs e)
        {
            using (DataraceDataContext ctx = new DataraceDataContext())
            {
                var currentMaxId = ctx.Costruttori.Select(p => p.IdCostruttore).Max();
                var costruttore = new Costruttori
                {
                    IdCostruttore = AutoIncrement(currentMaxId, 3),
                    Nome = textBoxNomeCostruttore.Text,
                    Paese = comboBoxPaeseCostruttore.Text,
                    AnnoDiEsordio = int.TryParse(textBoxAnnoDiEsordioCostruttore.Text, out int annoDiEsordio) ?
                                        annoDiEsordio : -1
                };
                if (CheckDataValidity(new List<string> { costruttore.Nome, costruttore.Paese }) &&
                    costruttore.AnnoDiEsordio > 0)
                {
                    dataGridViewCostruttori.DataSource = null;
                    ctx.Costruttori.InsertOnSubmit(costruttore);
                    ctx.SubmitChanges();
                    dataGridViewCostruttori.DataSource = costruttoriBindingSource;
                    // clears data after update
                    textBoxNomeCostruttore.Text = string.Empty;
                    comboBoxPaeseCostruttore.Text = string.Empty;
                    textBoxAnnoDiEsordioCostruttore.Text = string.Empty;
                    // refreshes view items
                    LoadOrRefreshViewItems();
                }
            }
        }

        private void ButtonRicercaModelli_Click(object sender, EventArgs e)
        {
            using (DataraceDataContext ctx = new DataraceDataContext())
            {
                var query = from c in ctx.Costruttori
                            join m in ctx.Modelli on c.IdCostruttore equals m.Costruttore
                            where c.Nome == comboBoxNomeRicercaCostruttore.Text
                            select new
                            {
                                m.NomeModello
                            };
                ShowResultsOnGrid(query, dataGridViewQueryCostruttori);
            }
        }

        private void ButtonRegistraModello_Click(object sender, EventArgs e)
        {
            using (DataraceDataContext ctx = new DataraceDataContext())
            {
                var idCostruttore = from c in ctx.Costruttori
                                    join m in ctx.Modelli on c.IdCostruttore equals m.Costruttore
                                    where c.Nome == comboBoxNomeInserimentoCostruttore.Text
                                    select c.IdCostruttore;
                var modello = new Modelli
                {
                    Costruttore = idCostruttore.First(),
                    NomeModello = textBoxQueryModello.Text
                };
                if (CheckDataValidity(new List<string> { modello.NomeModello }))
                {
                    ctx.Modelli.InsertOnSubmit(modello);
                    ctx.SubmitChanges();
                    // clears data after update
                    comboBoxNomeInserimentoCostruttore.Text = string.Empty;
                    textBoxQueryModello.Text = string.Empty;
                    // refreshes view items
                    LoadOrRefreshViewItems();
                }
            }
        }

        private void ButtonAggiungiGP_Click(object sender, EventArgs e)
        {
            using (DataraceDataContext ctx = new DataraceDataContext())
            {
                var currentMaxId = ctx.GranPremi.Select(p => p.IdGranPremio).Max();
                int stagioneCorrente = ctx.StagioneCorrente.Select(sc => sc.Anno).Single();
                // current season may be over (and a new one may not be up yet)
                var query = from s in ctx.Stagioni join sc in ctx.StagioneCorrente on s.Anno equals sc.Anno
                            join i in ctx.Iscrizioni on s.Anno equals i.Anno
                            where i.PosizioneCalendario == s.NumeroProve
                            select i.Pilota;
                // if that is the case, the year of the first edition has to be the next one
                if (query.Count() != 0)
                {
                    stagioneCorrente++;
                }
                var gp = new GranPremi
                {
                    IdGranPremio = AutoIncrement(currentMaxId, 3),
                    Denominazione = textBoxDenominazioneGP.Text,
                    AnnoPrimaEdizione = stagioneCorrente
                };
                if (CheckDataValidity(new List<string> { gp.Denominazione }))
                {
                    dataGridViewGranPremi.DataSource = null;
                    ctx.GranPremi.InsertOnSubmit(gp);
                    ctx.SubmitChanges();
                    dataGridViewGranPremi.DataSource = granpremiBindingSource;
                    // clears data after update
                    textBoxDenominazioneGP.Text = string.Empty;
                    // refreshes view items
                    LoadOrRefreshViewItems();
                }
            }
        }

        private void ButtonRicercaGP_Click(object sender, EventArgs e)
        {
            using (DataraceDataContext ctx = new DataraceDataContext())
            {
                var query = from i in ctx.Iscrizioni
                            join r in ctx.Risultati on i.Risultato equals r.IdRisultato
                            join pil in ctx.Piloti on i.Pilota equals pil.IdPilota
                            join c in ctx.Costruttori on i.Costruttore equals c.IdCostruttore
                            join p in ctx.Prove on new
                            {
                                i.PosizioneCalendario,
                                i.Anno
                            }
                            equals new
                            {
                                p.PosizioneCalendario,
                                p.Anno
                            }
                            join gp in ctx.GranPremi on p.GranPremio equals gp.IdGranPremio
                            where r.PosizioneArrivo == 1 && i.Classe == comboBoxRicercaClasse.Text
                                    && gp.Denominazione == comboBoxRicercaGP.Text
                            select new
                            {
                                i.Anno,
                                NomePilota = pil.Nome,
                                CognomePilota = pil.Cognome,
                                i.Team,
                                Costruttore = c.Nome,
                                i.Modello
                            };
                ShowResultsOnGrid(query, dataGridViewQueryGP);
            }
        }

        private void ButtonInserisciStagione_Click(object sender, EventArgs e)
        {
            using (DataraceDataContext ctx = new DataraceDataContext())
            {
                int stagioneCorrente = ctx.StagioneCorrente.Select(sc => sc.Anno).Single();
                var newSeason = new Stagioni
                {
                    Anno = ++stagioneCorrente,
                    NumeroProve = int.TryParse(textBoxNumeroProve.Text, out int np) ? np : -1
                };
                if (newSeason.NumeroProve > 0)
                {
                    ctx.Stagioni.InsertOnSubmit(newSeason);
                    ctx.SubmitChanges();
                    // clears data after update
                    textBoxNumeroProve.Text = string.Empty;
                    // refreshes view items
                    LoadOrRefreshViewItems();
                }
            }
        }

        private void ButtonSelezioneStagioneCalendario_Click(object sender, EventArgs e)
        {
            dataGridViewCalendario.DataSource = null;
            ShowSeasonCalendar(int.TryParse(comboBoxSelezioneStagione.Text, out int season) ? season : -1);
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
    }
}
