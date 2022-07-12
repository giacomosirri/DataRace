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

        private void ButtonAggungiPilota_Click(object sender, EventArgs e)
        {
            using (DataraceDataContext ctx = new DataraceDataContext())
            {
                var currentMaxId = ctx.Piloti.Select(p => p.IdPilota).Max();
                var pilota = new Piloti {
                    IdPilota = this.AutoIncrement(currentMaxId, 6),
                    Nome = textBoxNomePilota.Text,
                    Cognome = textBoxCognomePilota.Text,
                    LuogoDiNascita = textBoxLuogoDiNascita.Text,
                    Nazionalita = comboBoxNazionalita.Text,
                    DataDiNascita = dataDiNascitaPicker.Value.Date.ToString("yyyy/MM/dd")
            };
                if (this.CheckDataValidity(new List<string> { pilota.IdPilota, pilota.Nome, pilota.Cognome,
                    pilota.LuogoDiNascita, pilota.Nazionalita, pilota.DataDiNascita }))
                {
                    dataGridViewPiloti.DataSource = null;
                    ctx.Piloti.InsertOnSubmit(pilota);
                    ctx.SubmitChanges();
                    dataGridViewPiloti.DataSource = pilotiBindingSource;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataraceDataSet.team' table. You can move, or remove it, as needed.
            this.teamTableAdapter.Fill(this.dataraceDataSet.team);
            // TODO: This line of code loads data into the 'dataraceDataSet.piloti' table. You can move, or remove it, as needed.
            this.pilotiTableAdapter.Fill(this.dataraceDataSet.piloti);
            this.comboBoxNazionalita.Items.AddRange(this.GetCountryList().ToArray());
            this.comboBoxPaeseTeam.Items.AddRange(this.GetCountryList().ToArray());
        }

        private void button2_Click(object sender, EventArgs e)
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
    }
}
