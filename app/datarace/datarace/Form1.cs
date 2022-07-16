using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
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
            // TODO: This line of code loads data into the 'dataraceDataSet.circuiti' table. You can move, or remove it, as needed.
            this.circuitiTableAdapter.Fill(this.dataraceDataSet.circuiti);
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
            // differentiates on if the current season is over or not
            var isOver = IsCurrentSeasonOver();
            buttonQueryTeam.Enabled = !isOver;
            buttonInserisciStagione.Enabled = isOver;
            textBoxNumeroProve.Enabled = isOver;
            comboBoxPilotaQueryIscrizione.Enabled = !isOver;
            comboBoxTeamQueryIscrizione.Enabled = !isOver;
            comboBoxModelloQueryIscrizione.Enabled = !isOver;
            comboBoxTipoIscrizioneQueryIscrizione.Enabled = !isOver;
            textBoxNumeroDiGaraQueryIscrizione.Enabled = !isOver;
            comboBoxCostruttoreQueryIscrizione.Enabled = !isOver;
            comboBoxClasseQueryIscrizione.Enabled = !isOver;
            buttonQueryIscrizione.Enabled = !isOver;
            // differentiates on if the current season has started or not
            var hasStarted = IsCurrentSeasonStarted();
            comboBoxNomeGPQueryStagione.Enabled = !hasStarted;
            comboBoxNomeCircuitoQueryStagione.Enabled = !hasStarted;
            textBoxNomeUfficialeGPQueryStagione.Enabled = !hasStarted;
            dateTimePickerDataInizioGP.Enabled = !hasStarted;
            dateTimePickerDataFineGP.Enabled = !hasStarted;
            buttonInserisciProva.Enabled = !hasStarted;
            // sets up combo boxes and check boxes
            comboBoxNazionalita.Items.Clear();
            comboBoxNazionalita.Items.AddRange(GetCountryList().ToArray());
            comboBoxNomePilotaQueryPiloti.Items.Clear();
            comboBoxNomePilotaQueryPiloti.Items.AddRange(GetAllRiders().ToArray());
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
            comboBoxNomeCircuitoQuery.Items.Clear();
            comboBoxNomeCircuitoQuery.Items.AddRange(GetAllCircuits().ToArray());
            comboBoxNomePilotaQueryCircuito.Items.Clear();
            comboBoxNomePilotaQueryCircuito.Items.AddRange(GetAllRiders().ToArray());
            comboBoxNomeClasseQueryCircuito.Items.Clear();
            comboBoxNomeClasseQueryCircuito.Items.AddRange(GetAllClasses().ToArray());
            comboBoxSceltaClasseQueryCampionato.Items.Clear();
            comboBoxSceltaClasseQueryCampionato.Items.AddRange(GetAllClasses().ToArray());
            comboBoxSceltaClasseAlbodOro.Items.Clear();
            comboBoxSceltaClasseAlbodOro.Items.AddRange(GetAllClasses().ToArray());
            comboBoxSceltaAnnoQueryGare.Items.Clear();
            comboBoxSceltaAnnoQueryGare.Items.AddRange(GetAllSeasons().ToArray());
            comboBoxSceltaGPQueryGare.Items.Clear();
            comboBoxSceltaGPQueryGare.Items.AddRange(GetAllGPs().ToArray());
            comboBoxSceltaClasseQueryGare.Items.Clear();
            comboBoxSceltaClasseQueryGare.Items.AddRange(GetAllClasses().ToArray());
            comboBoxPilotaQueryIscrizione.Items.Clear();
            comboBoxPilotaQueryIscrizione.Items.AddRange(GetAllRiders().ToArray());
            comboBoxClasseQueryIscrizione.Items.Clear();
            comboBoxClasseQueryIscrizione.Items.AddRange(GetAllClasses().ToArray());
            comboBoxTeamQueryIscrizione.Items.Clear();
            comboBoxTeamQueryIscrizione.Items.AddRange(GetCurrentSeasonTeams().ToArray());
            comboBoxTipoIscrizioneQueryIscrizione.Items.Clear();
            comboBoxTipoIscrizioneQueryIscrizione.Items.AddRange(new string[] { "Titolare", "Sostituto", "Wildcard" });
            comboBoxClasseQueryRisultati.Items.Clear();
            comboBoxClasseQueryRisultati.Items.AddRange(GetAllClasses().ToArray());
            comboBoxClasseQueryInserimentoGare.Items.Clear();
            comboBoxClasseQueryInserimentoGare.Items.AddRange(GetAllClasses().ToArray());
            comboBoxCondizioniTracciatoQueryInserimentoGare.Items.Clear();
            comboBoxCondizioniTracciatoQueryInserimentoGare.Items.AddRange(new string[] { "Dry", "Wet" });
            ShowCurrentSeasonCalendar();
        }

        private bool IsCurrentSeasonOver()
        {
            using (DataraceDataContext ctx = new DataraceDataContext())
            {
                var currentYear = ctx.StagioneCorrente.Select(sc => sc.Anno).Single();
                var events = ctx.Stagioni.Where(s => s.Anno == currentYear).Select(s => s.NumeroProve).Single();
                return ctx.Iscrizioni.Where(i => i.Anno == currentYear && i.PosizioneCalendario == events &&
                                         i.Risultato != null).Any();
            }
        }

        private bool IsCurrentSeasonStarted()
        {
            using (DataraceDataContext ctx = new DataraceDataContext())
            {
                var currentYear = ctx.StagioneCorrente.Select(sc => sc.Anno).Single();
                return ctx.Iscrizioni.Where(i => i.Anno == currentYear && i.PosizioneCalendario == 1).Any();
            }
        }

        private List<string> GetAllRiders()
        {
            using (DataraceDataContext ctx = new DataraceDataContext())
            {
                var query = ctx.Piloti.Select(p => p.Nome + " " + p.Cognome);
                return query.ToList();
            }
        }

        private List<string> GetAllCircuits()
        {
            using (DataraceDataContext ctx = new DataraceDataContext())
            {
                var query = ctx.Circuiti.Select(s => s.Nome);
                return query.ToList();
            }
        }

        private void ShowCurrentSeasonCalendar()
        {
            using (DataraceDataContext ctx = new DataraceDataContext())
            {
                var currentSeason = ctx.StagioneCorrente.Select(sc => sc.Anno).Single();
                ShowSeasonCalendar(currentSeason);
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
                                gp = p.NomeUfficiale,
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

        private List<string> GetCurrentSeasonTeams()
        {
            using (DataraceDataContext ctx = new DataraceDataContext())
            {
                var currentYear = ctx.StagioneCorrente.Select(sc => sc.Anno).Single();
                var query = ctx.StagioniTeam.Where(st => st.Anno == currentYear).Select(t => t.NomeUfficiale);
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
                    ctx.Piloti.InsertOnSubmit(pilota);
                    ctx.SubmitChanges();
                    // clears data after update
                    dataGridViewPiloti.DataSource = ctx.Piloti.ToList();
                    textBoxNomePilota.Text = string.Empty;
                    textBoxCognomePilota.Text = string.Empty;
                    textBoxLuogoDiNascita.Text = string.Empty;
                    comboBoxNazionalita.Text = string.Empty;
                    dataDiNascitaPicker.Value = DateTime.Today;
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
                    var riderNameAndSurname = comboBoxNomePilotaQueryPiloti.Text.Split(new char[] { ' ' });
                    var riderName = riderNameAndSurname[0];
                    var riderSurname = riderNameAndSurname[1];
                    if (comboBoxSceltaQueryPiloti.SelectedItem == comboBoxSceltaQueryPiloti.Items[0])
                    {
                        query = ctx.Piloti
                                    .Where(p => p.Nome == riderName && p.Cognome == riderSurname)
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
                                where p.Nome == riderName && p.Cognome == riderSurname
                                select new
                                {
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
                    ctx.Teams.InsertOnSubmit(team);
                    ctx.SubmitChanges();
                    dataGridViewTeam.DataSource = ctx.Teams.ToList();
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
                    ctx.Costruttori.InsertOnSubmit(costruttore);
                    ctx.SubmitChanges();
                    dataGridViewCostruttori.DataSource = ctx.Costruttori.ToList();
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
                                modelli = m.NomeModello
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
                    ctx.GranPremi.InsertOnSubmit(gp);
                    ctx.SubmitChanges();
                    dataGridViewGranPremi.DataSource = ctx.GranPremi.ToList();
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
                                anno = i.Anno,
                                prova = p.PosizioneCalendario,
                                pilota = pil.Nome + " " + pil.Cognome,
                                team = i.Team,
                                costruttore = c.Nome,
                                modello = i.Modello
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

        private void ButtonAggiungiCircuito_Click(object sender, EventArgs e)
        {
            using (DataraceDataContext ctx = new DataraceDataContext())
            {
                var currentMaxId = ctx.Circuiti.Select(p => p.IdCircuito).Max();
                var circuito = new Circuiti
                {
                    IdCircuito = AutoIncrement(currentMaxId, 3),
                    Nome = textBoxNomeCircuito.Text,
                    Localita = textBoxLocalitaCircuito.Text,
                    LunghezzaInMetri = int.TryParse(textBoxLunghezzaCircuito.Text, out int len) ? len : -1,
                    NumeroCurveSinistra = int.TryParse(textBoxCurveASinistraCircuito.Text, out int left) ? left : -1,
                    NumeroCurveDestra = int.TryParse(textBoxCurveADestraCircuito.Text, out int right) ? right : -1,
                    LunghezzaRettilineoInMetri = int.TryParse(textBoxLunghezzaRettilineoCircuito.Text, out int str) ? str : -1
                };
                if (CheckDataValidity(new List<string> { circuito.Localita }) && new List<int> {
                        circuito.LunghezzaInMetri, circuito.NumeroCurveSinistra,
                        circuito.NumeroCurveDestra, circuito.LunghezzaRettilineoInMetri
                    }.Where(i => i < 0).Count() == 0)
                {
                    ctx.Circuiti.InsertOnSubmit(circuito);
                    ctx.SubmitChanges();
                    dataGridViewCircuiti.DataSource = ctx.Circuiti.ToList();
                    // clears data after update
                    textBoxNomeCircuito.Text = string.Empty;
                    textBoxLocalitaCircuito.Text = string.Empty;
                    textBoxCurveASinistraCircuito.Text = string.Empty;
                    textBoxCurveADestraCircuito.Text = string.Empty;
                    textBoxLunghezzaCircuito.Text = string.Empty;
                    textBoxLunghezzaRettilineoCircuito.Text = string.Empty;
                    // refreshes view items
                    LoadOrRefreshViewItems();
                }
            }
        }

        private void ButtonEseguiQueryCircuito_Click(object sender, EventArgs e)
        {
            using (DataraceDataContext ctx = new DataraceDataContext())
            {
                IQueryable query;
                if (comboBoxSceltaOperazioneCircuiti.Text != null)
                {
                    // Finds the winningest rider in this circuit (all classes)
                    if (comboBoxSceltaOperazioneCircuiti.SelectedItem == comboBoxSceltaOperazioneCircuiti.Items[0])
                    {
                        List<string> winningRidersIds = (from i in ctx.Iscrizioni
                                             join r in ctx.Risultati on i.Risultato equals r.IdRisultato
                                             join pil in ctx.Piloti on i.Pilota equals pil.IdPilota
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
                                             join c in ctx.Circuiti on p.Circuito equals c.IdCircuito
                                             where r.PosizioneArrivo == 1 && c.Nome == comboBoxNomeCircuitoQuery.Text
                                                         select pil.IdPilota).ToList();
                        var winningRidersIdAndWins = winningRidersIds.Select(i => (i, CountOccurences(winningRidersIds, i)));
                        IEnumerable<(string id, int wins)> winningestRiders = winningRidersIdAndWins.Where(i => 
                                i.Item2 == winningRidersIdAndWins.OrderByDescending(j => j.Item2).Take(1).Single().Item2);
                        query = from p in ctx.Piloti
                                where winningestRiders.Select(r => r.id).Contains(p.IdPilota)
                                select new
                                {
                                    pilota = p.Nome + " " + p.Cognome,
                                    vittorie = winningestRiders.Select(r => r.wins).First()
                                };
                        dataGridViewQueryCircuito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                    // All selected riders' results in the given class
                    else
                    {
                        var riderNameAndSurname = comboBoxNomePilotaQueryCircuito.Text.Split(new char[] { ' ' });
                        var riderName = riderNameAndSurname[0];
                        var riderSurname = riderNameAndSurname[1];
                        query = from i in ctx.Iscrizioni
                                join r in ctx.Risultati on i.Risultato equals r.IdRisultato
                                join pil in ctx.Piloti on i.Pilota equals pil.IdPilota
                                join cos in ctx.Costruttori on i.Costruttore equals cos.IdCostruttore
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
                                join c in ctx.Circuiti on p.Circuito equals c.IdCircuito
                                join cl in ctx.Classi on i.Classe equals cl.Nome
                                where pil.Nome == riderName && pil.Cognome == riderSurname &&
                                      c.Nome == comboBoxNomeCircuitoQuery.Text &&
                                      cl.Nome == comboBoxNomeClasseQueryCircuito.Text
                                select new
                                {
                                    anno = p.Anno,
                                    gp = gp.Denominazione,
                                    risultato = r.PosizioneArrivo,
                                    partenza = r.PosizionePartenza,
                                    team = i.Team,
                                    costruttore = cos.Nome,
                                    modello = i.Modello
                                };
                        dataGridViewQueryCircuito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                    }
                    ShowResultsOnGrid(query, dataGridViewQueryCircuito);
                }
            }
        }

        private int CountOccurences<T>(List<T> list, T value) 
        {
            int count = 0;
            foreach (var elem in list)
            {
                if (elem.Equals(value))
                {
                    count++;
                }
            }
            return count;
        }

        private void ComboBoxSceltaOpCircuiti_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isFirstSelected = comboBoxSceltaOperazioneCircuiti.SelectedIndex == 0;
            comboBoxNomePilotaQueryCircuito.Enabled = !isFirstSelected;
            comboBoxNomeClasseQueryCircuito.Enabled = !isFirstSelected;
        }

        private void ButtonInserisciProva_Click(object sender, EventArgs e)
        {
            using (DataraceDataContext ctx = new DataraceDataContext())
            {
                var currentSeason = ctx.StagioneCorrente.Select(sc => sc.Anno).Single();
                var mostRecentEdition = ctx.EdizionePiuRecente.Where(ed => ctx.GranPremi
                    .Where(gp => gp.Denominazione == comboBoxNomeGPQueryStagione.Text).Select(gp => gp.IdGranPremio)
                    .Single() == ed.GranPremio).Select(ed => ed.NumeroEdizione).Single();
                var circuit = ctx.Circuiti.Where(c => c.Nome == comboBoxNomeCircuitoQueryStagione.Text)
                    .Select(c => c.IdCircuito).Single();
                var calendarPos = ctx.Prove.Where(p => p.Anno == currentSeason)
                    .OrderByDescending(i => i.PosizioneCalendario).Take(1).Select(i => i.PosizioneCalendario).Single() + 1;
                var grandPrix = ctx.GranPremi.Where(gp => gp.Denominazione == comboBoxNomeGPQueryStagione.Text)
                    .Select(gp => gp.IdGranPremio).Single();
                var prova = new Prove()
                {
                    Anno = currentSeason,
                    PosizioneCalendario = calendarPos,
                    GranPremio = grandPrix,
                    NomeUfficiale = textBoxNomeUfficialeGPQueryStagione.Text,
                    NumeroEdizione = ++mostRecentEdition,
                    DataInizio = dateTimePickerDataInizioGP.Value.Date,
                    DataFine = dateTimePickerDataFineGP.Value.Date,
                    Circuito = circuit
                };
                if (CheckDataValidity(new List<string>{ prova.NomeUfficiale }))
                {
                    ctx.Prove.InsertOnSubmit(prova);
                    ctx.SubmitChanges();
                    // clears data after update
                    textBoxNomeUfficialeGPQueryStagione.Text = string.Empty;
                    comboBoxNomeCircuitoQueryStagione.Text = string.Empty;
                    comboBoxNomeGPQueryStagione.Text = string.Empty;
                    // refreshes view items
                    LoadOrRefreshViewItems();
                }
            }
        }

        private void ButtonQueryCampionato_Click(object sender, EventArgs e)
        {
            using (DataraceDataContext ctx = new DataraceDataContext())
            {
                if (comboBoxSceltaCampionatoQueryCampionato.Text != string.Empty &&
                    comboBoxSceltaClasseQueryCampionato.Text != string.Empty)
                {
                    IQueryable query;
                    int stagioneCorrente = ctx.StagioneCorrente.Select(sc => sc.Anno).Single();
                    if (comboBoxSceltaCampionatoQueryCampionato.SelectedIndex == 0)
                    {
                        query = from pp in ctx.PartecipazioniPilota
                                join p in ctx.Piloti on pp.Pilota equals p.IdPilota
                                where pp.Classe == comboBoxSceltaClasseQueryCampionato.Text && pp.Anno == stagioneCorrente
                                orderby pp.PuntiValidi descending
                                select new
                                {
                                    posizione = pp.PosizioneClassifica,
                                    pilota = p.Nome + " " + p.Cognome,
                                    età = pp.Eta,
                                    punti = pp.PuntiValidi
                                };
                    }
                    else if (comboBoxSceltaCampionatoQueryCampionato.SelectedIndex == 1)
                    {
                        query = from pt in ctx.PartecipazioniTeam
                                join st in ctx.StagioniTeam on new
                                {
                                    pt.Anno,
                                    pt.Team
                                }
                                equals new
                                {
                                    st.Anno,
                                    Team = st.NomeUfficiale
                                }
                                where pt.Classe == comboBoxSceltaClasseQueryCampionato.Text && pt.Anno == stagioneCorrente
                                orderby pt.Punti descending
                                select new
                                {
                                    posizione = pt.PosizioneClassifica,
                                    team = st.NomeUfficiale,
                                    punti = pt.Punti
                                };
                    }
                    else
                    {
                        query = from pc in ctx.PartecipazioniCostruttore
                                join c in ctx.Costruttori on pc.Costruttore equals c.IdCostruttore
                                where pc.Classe == comboBoxSceltaClasseQueryCampionato.Text && pc.Anno == stagioneCorrente
                                orderby pc.Punti descending
                                select new
                                {
                                    posizione = pc.PosizioneClassifica,
                                    costruttore = c.Nome,
                                    punti = pc.Punti
                                };
                    }
                    ShowResultsOnGrid(query, dataGridViewCampionati);
                }
            }
        }

        private void ComboBoxSceltaClasseAlbodOro_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (DataraceDataContext ctx = new DataraceDataContext())
            {
                bool isOver = IsCurrentSeasonOver();
                var query = ctx.PartecipazioniPilota.Where(pp => !isOver ?
                    pp.Anno != ctx.StagioneCorrente.Select(sc => sc.Anno).Single() &&
                    pp.Classe == comboBoxSceltaClasseAlbodOro.Text &&
                    pp.PosizioneClassifica == 1 : pp.Classe == comboBoxSceltaClasseAlbodOro.Text &&
                    pp.PosizioneClassifica == 1).Select(pp => new
                    {
                        anno = pp.Anno,
                        pilota = pp.Piloti.Nome + " " + pp.Piloti.Cognome,
                        età = pp.Eta,
                        punti = pp.PuntiValidi
                    });
                ShowResultsOnGrid(query, dataGridViewAlbodOro);
            }
        }

        private void ButtonMostraRisultatiGare_Click(object sender, EventArgs e)
        {
            using (DataraceDataContext ctx = new DataraceDataContext())
            {
                var query = from r in ctx.Risultati
                            join i in ctx.Iscrizioni on r.IdRisultato equals i.Risultato
                            join pil in ctx.Piloti on i.Pilota equals pil.IdPilota
                            join c in ctx.Costruttori on i.Costruttore equals c.IdCostruttore
                            join g in ctx.Gare on r.Gara equals g.IdGara
                            join p in ctx.Prove on new
                            {
                                g.Anno,
                                g.PosizioneCalendario
                            }
                            equals new
                            {
                                p.Anno,
                                p.PosizioneCalendario
                            }
                            join gp in ctx.GranPremi on p.GranPremio equals gp.IdGranPremio
                            where g.Anno == int.Parse(comboBoxSceltaAnnoQueryGare.Text) &&
                                  g.Classe == comboBoxSceltaClasseQueryGare.Text &&
                                  gp.Denominazione == comboBoxSceltaGPQueryGare.Text
                            select new
                            {
                                risultato = r.Ritiro ? "Retired" : (r.PosizioneArrivo == -1 ? "Disqualified" :
                                                                    r.PosizioneArrivo.ToString()),
                                pilota = pil.Nome + " " + pil.Cognome,
                                team = i.Team,
                                costruttore = c.Nome,
                                modello = i.Modello
                            };
                ShowResultsOnGrid(query, dataGridViewGare);
            }
        }

        private void ButtonQueryIscrizione_Click(object sender, EventArgs e)
        {
            using (DataraceDataContext ctx = new DataraceDataContext())
            {
                // automatize next event position in the calendar
                int nextEvent = ctx.Gare.Where(i => i.Anno == ctx.StagioneCorrente.Select(sc => sc.Anno).Single())
                                          .OrderByDescending(i => i.PosizioneCalendario)
                                          .Select(i => i.PosizioneCalendario).Take(1).Single() + 1;
                var riderId = ctx.Piloti.Where(p => p.Nome == comboBoxPilotaQueryIscrizione.Text.Split(' ')[0] &&
                                                p.Cognome == comboBoxPilotaQueryIscrizione.Text.Split(' ')[1])
                                        .Select(p => p.IdPilota).Single();
                var constructorId = ctx.Costruttori.Where(c => c.Nome == comboBoxCostruttoreQueryIscrizione.Text)
                                        .Select(c => c.IdCostruttore).Single();
                var iscrizione = new Iscrizioni()
                {
                    Pilota = riderId,
                    NumeroDiGara = int.TryParse(textBoxNumeroDiGaraQueryIscrizione.Text, out int ndg) ? ndg : -1,
                    Classe = comboBoxClasseQueryIscrizione.Text,
                    Team = comboBoxTeamQueryIscrizione.Text,
                    TipoIscrizione = comboBoxTipoIscrizioneQueryIscrizione.Text,
                    Costruttore = constructorId,
                    Modello = comboBoxModelloQueryIscrizione.Text,
                    Anno = ctx.StagioneCorrente.Select(sc => sc.Anno).Single(),
                    PosizioneCalendario = nextEvent
                };
                if (iscrizione.NumeroDiGara > 0)
                {
                    ctx.Iscrizioni.InsertOnSubmit(iscrizione);
                    ctx.SubmitChanges();
                    // clears data after update
                    comboBoxPilotaQueryIscrizione.Text = string.Empty;
                    textBoxNumeroDiGaraQueryIscrizione.Text = string.Empty;
                    comboBoxCostruttoreQueryIscrizione.Text = string.Empty;
                    comboBoxModelloQueryIscrizione.Text = string.Empty;
                    // refreshes view items
                    LoadOrRefreshViewItems();
                }
            }
        }

        private void ComboBoxTeamQueryIscrizione_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (DataraceDataContext ctx = new DataraceDataContext())
            {
                var teams = ctx.Affiliazioni.Where(a => a.Team == comboBoxTeamQueryIscrizione.Text && a.Anno == 
                                                ctx.StagioneCorrente.Select(sc => sc.Anno).Single())
                                            .Select(a => a.Costruttori.Nome).ToArray();
                comboBoxCostruttoreQueryIscrizione.Items.Clear();
                comboBoxCostruttoreQueryIscrizione.Items.AddRange(teams);
            }
        }

        private void ComboBoxCostruttoreQueryIscrizione_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (DataraceDataContext ctx = new DataraceDataContext())
            {
                var modelli = ctx.Costruttori.Where(c => c.Nome == comboBoxCostruttoreQueryIscrizione.Text).Single()
                                .Modelli.Select(m => m.NomeModello).ToArray();
                comboBoxModelloQueryIscrizione.Items.Clear();
                comboBoxModelloQueryIscrizione.Items.AddRange(modelli);
            }
        }

        private void ButtonAggiungiGara_Click(object sender, EventArgs e)
        {
            using (DataraceDataContext ctx = new DataraceDataContext())
            {
                var currentMaxId = ctx.Gare.Select(g => g.IdGara).Max();
                var currentSeason = ctx.StagioneCorrente.Select(sc => sc.Anno).Single();
                var gara = new Gare()
                {
                    IdGara = AutoIncrement(currentMaxId, 6),
                    Classe = comboBoxClasseQueryInserimentoGare.Text,
                    PosizioneCalendario = LatestRaceNumber(comboBoxClasseQueryInserimentoGare.Text) + 1,
                    Anno = currentSeason,
                    Data = dateTimePickerDataQueryInserimentoGare.Value.Date,
                    OraInizio = dateTimePickerOraInizioQueryInserimentoGare.Value.TimeOfDay,
                    NumeroGiri = int.TryParse(textBoxNumeroDiGiriQueryInserimentoGare.Text, out int ng) ? ng : -1,
                    CondizioniTracciato = comboBoxCondizioniTracciatoQueryInserimentoGare.Text
                };
                if (gara.NumeroGiri > 0)
                {
                    ctx.Gare.InsertOnSubmit(gara);
                    ctx.SubmitChanges();
                    // clears data after update
                    comboBoxClasseQueryInserimentoGare.Text = string.Empty;
                    textBoxNumeroDiGiriQueryInserimentoGare.Text = string.Empty;
                    // refreshes view items
                    LoadOrRefreshViewItems();
                }
            }
        }

        private void ButtonInserisciRisultato_Click(object sender, EventArgs e)
        {
            using (DataraceDataContext ctx = new DataraceDataContext())
            {
                // finds the latest race that has been held for the selected class
                var latestRaceNumber = LatestRaceNumber(comboBoxClasseQueryRisultati.Text);
                var currentSeason = ctx.StagioneCorrente.Select(sc => sc.Anno).Single();
                // this query must change when multiple races for class in a GP will be allowed
                var raceId = ctx.Gare.Where(g => g.Anno == currentSeason && g.PosizioneCalendario == latestRaceNumber &&
                                            g.Classe == comboBoxClasseQueryRisultati.Text)
                                     .Select(g => g.IdGara).Single();
                // these variables are needed for the following table updates
                var riderName = comboBoxPilotaQueryRisultati.Text.Split(' ')[0];
                var riderSurname = comboBoxPilotaQueryRisultati.Text.Split(' ')[1];
                var riderId = ctx.Piloti.Where(p => p.Nome == riderName && p.Cognome == riderSurname).Select(p => p.IdPilota).Single();
                var iscrizione = ctx.Iscrizioni.Where(i => i.Anno == currentSeason &&
                            i.PosizioneCalendario == latestRaceNumber && i.Classe == comboBoxClasseQueryRisultati.Text &&
                            i.Piloti.IdPilota == ctx.Piloti.Where(p => p.IdPilota == riderId).Select(p => p.IdPilota).Single()).Single();
                var team = ctx.Iscrizioni.Where(i => i == iscrizione).Select(i => i.Team).Single();
                var classe = comboBoxClasseQueryRisultati.Text;
                var idCostruttore = ctx.Iscrizioni.Where(i => i == iscrizione).Select(i => i.Costruttore).Single();
                var currentMaxId = ctx.Risultati.Select(g => g.IdRisultato).Max();
                var risultato = new Risultati()
                {
                    IdRisultato = AutoIncrement(currentMaxId, 7),
                    Gara = raceId,
                    PosizioneArrivo = int.TryParse(textBoxPosizioneArrivoQueryRisultati.Text, out int pa) ? pa : -1,
                    PosizionePartenza = textBoxPosizionePartenzaQueryRisultati.Text,
                    Ritiro = checkBoxRitiroQueryRisultati.Checked,
                    // empty data
                    TempoTotale = new TimeSpan(0, 0, 0),
                    GiroVeloce = new TimeSpan(0, 0, 0)
                };
                // starting position can be either a positive numerical value or the string "Pit lane"
                if (((int.TryParse(risultato.PosizionePartenza, out int pp) && pp > 0) || 
                    risultato.PosizionePartenza == "Pit lane") && risultato.PosizioneArrivo > 0)
                {
                    if (checkBoxSqualificaQueryRisultati.Checked)
                    {
                        var squalificati = ctx.Risultati.Where(r => r.PosizioneArrivo < 0)
                                                        .Select(r => r.Gare)
                                                        .Where(g => g.Anno == currentSeason &&
                                                               g.PosizioneCalendario == latestRaceNumber &&
                                                               g.Classe == classe)
                                                        .Count();
                        risultato.PosizioneArrivo = -(squalificati + 1);
                    }
                    ctx.Risultati.InsertOnSubmit(risultato);
                    ctx.SubmitChanges();
                    // update the registration that is associated with the new result
                    iscrizione.Risultato = risultato.IdRisultato;
                    // update the current season's points tables with the points gained by the rider
                    var gainedPoints = ctx.Campionati.Where(c => c.Anno == currentSeason && c.Classe == classe)
                            .Select(c => (risultato.Ritiro || checkBoxSqualificaQueryRisultati.Checked) ? 0 : 
                                ctx.Punteggi.Where(p => p.IdPunteggio == c.Punteggio && p.Risultato == risultato.PosizioneArrivo).Select(p => p.PuntiAssegnati).Single())
                            .Single();
                    var partecipazionePilota = ctx.PartecipazioniPilota.Where(p => p.Anno == currentSeason &&
                            p.Classe == classe && p.Pilota == riderId).Single();
                    partecipazionePilota.PuntiTotali += gainedPoints;
                    partecipazionePilota.PuntiValidi += gainedPoints;
                    var partecipazioneTeam = ctx.PartecipazioniTeam.Where(t => t.Anno == currentSeason && t.Classe == classe && t.Team == team).Single();
                    partecipazioneTeam.Punti += gainedPoints;
                    ctx.SubmitChanges();
                    // update rankings after point updates
                    foreach (var elem in ctx.PartecipazioniPilota)
                    {
                        elem.PosizioneClassifica = ctx.PartecipazioniPilota.Where(p => p.Anno == currentSeason && p.Classe == classe && p.PuntiValidi > elem.PuntiValidi).Count() + 1;
                    }
                    foreach (var elem in ctx.PartecipazioniTeam)
                    {
                        elem.PosizioneClassifica = ctx.PartecipazioniTeam.Where(p => p.Anno == currentSeason && p.Classe == classe && p.Punti > elem.Punti).Count() + 1;
                    }
                    ctx.SubmitChanges();
                    /* FEATURE NOT CURRENTLY IMPLEMENTED
                    // update rider's statistics -- pole positions cannot be automatically updated due to possible penalties
                    var statistichePilota = ctx.StatistichePiloti.Where(p => p.Pilota == riderId).Single();
                    statistichePilota.GareDisputate++;
                    statistichePilota.Vittorie += (risultato.PosizioneArrivo == 1) ? 1 : 0;
                    statistichePilota.Podi += (risultato.PosizioneArrivo == 1 || risultato.PosizioneArrivo == 2 || risultato.PosizioneArrivo == 3) ? 1 : 0;
                    */
                    // clears data after update
                    comboBoxClasseQueryRisultati.Text = string.Empty;
                    comboBoxPilotaQueryRisultati.Text = string.Empty;
                    textBoxPosizionePartenzaQueryRisultati.Text = string.Empty;
                    textBoxPosizioneArrivoQueryRisultati.Text = string.Empty;
                    checkBoxRitiroQueryRisultati.Checked = false;
                    checkBoxSqualificaQueryRisultati.Checked = false;
                    // refreshes view items
                    LoadOrRefreshViewItems();
                }
            }
        }

        private void ComboBoxClasseQueryRisultati_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (DataraceDataContext ctx = new DataraceDataContext())
            {
                var classe = comboBoxClasseQueryRisultati.Text;
                var riders = ctx.Iscrizioni.Where(i => i.Anno == ctx.StagioneCorrente.Select(sc => sc.Anno).Single() && 
                                    i.PosizioneCalendario == LatestRaceNumber(classe) && i.Classe == classe && 
                                    i.Risultato == null).Select(i => i.Piloti.Nome + " " + i.Piloti.Cognome).ToArray(); 
                comboBoxPilotaQueryRisultati.Items.Clear();
                comboBoxPilotaQueryRisultati.Items.AddRange(riders);
            }
        }

        private int LatestRaceNumber(string className)
        {
            using (DataraceDataContext ctx = new DataraceDataContext())
            {
                return ctx.Gare.Where(i => i.Anno == ctx.StagioneCorrente.Select(sc => sc.Anno).Single() && 
                                            i.Classe == className).OrderByDescending(i => i.PosizioneCalendario)
                                            .Select(i => i.PosizioneCalendario).Take(1).Single();
            }
        }

        private void ShowResultsOnGrid(IQueryable queryResult, DataGridView dataGrid)
        {
            try
            {
                dataGrid.DataSource = queryResult;
            }
            catch (InvalidOperationException) 
            {
            }
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
