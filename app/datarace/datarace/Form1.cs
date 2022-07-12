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

        private void button1_Click(object sender, EventArgs e)
        {
            using (DataraceDataContext ctx = new DataraceDataContext())
            {
                var pilota = new Piloti();
                pilota.IdPilota = "000153";
                pilota.Nome = textBoxNomePilota.Text;
                pilota.Cognome = textBoxCognomePilota.Text;
                pilota.LuogoDiNascita = textBoxLuogoDiNascita.Text;
                pilota.Nazionalita = comboBoxNazionalita.Text;
                pilota.DataDiNascita = dataDiNascitaPicker.Value.Date.ToString("yyyy/MM/dd");
                dataGridViewPiloti.DataSource = null;
                ctx.Piloti.InsertOnSubmit(pilota);
                ctx.SubmitChanges();
                dataGridViewPiloti.DataSource = pilotiBindingSource;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataraceDataSet.team' table. You can move, or remove it, as needed.
            this.teamTableAdapter.Fill(this.dataraceDataSet.team);
            // TODO: This line of code loads data into the 'dataraceDataSet.piloti' table. You can move, or remove it, as needed.
            this.pilotiTableAdapter.Fill(this.dataraceDataSet.piloti);
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
    }
}
