
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace datarace
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.separatoreViewPiloti = new System.Windows.Forms.Label();
            this.comboBoxNazionalita = new System.Windows.Forms.ComboBox();
            this.dataDiNascitaPicker = new System.Windows.Forms.DateTimePicker();
            this.comboBoxSceltaQueryPiloti = new System.Windows.Forms.ComboBox();
            this.dataGridViewQueryPiloti = new System.Windows.Forms.DataGridView();
            this.buttonRicercaPiloti = new System.Windows.Forms.Button();
            this.textBoxCognomeRicercaPiloti = new System.Windows.Forms.TextBox();
            this.textBoxNomeRicercaPiloti = new System.Windows.Forms.TextBox();
            this.labelNomeRicercaPilota = new System.Windows.Forms.Label();
            this.labelCognomeRicercaPilota = new System.Windows.Forms.Label();
            this.labelDataDiNascita = new System.Windows.Forms.Label();
            this.labelNazionalitaPilota = new System.Windows.Forms.Label();
            this.textBoxLuogoDiNascita = new System.Windows.Forms.TextBox();
            this.labelLuogoDiNascita = new System.Windows.Forms.Label();
            this.textBoxCognomePilota = new System.Windows.Forms.TextBox();
            this.labelCognomePilota = new System.Windows.Forms.Label();
            this.labelNomePilota = new System.Windows.Forms.Label();
            this.buttonAggiungiPilota = new System.Windows.Forms.Button();
            this.textBoxNomePilota = new System.Windows.Forms.TextBox();
            this.dataGridViewPiloti = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cognomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luogoDiNascitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazionalitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDiNascitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pilotiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataraceDataSet = new datarace.dataraceDataSet();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonQueryTeam = new System.Windows.Forms.Button();
            this.labelClassiTeam = new System.Windows.Forms.Label();
            this.checkedListBoxClassiTeam = new System.Windows.Forms.CheckedListBox();
            this.textBoxTeamManager = new System.Windows.Forms.TextBox();
            this.labelTeamManager = new System.Windows.Forms.Label();
            this.labelNomeUfficialeTeam = new System.Windows.Forms.Label();
            this.separatoreViewTeam = new System.Windows.Forms.Label();
            this.comboBoxNomeRicercaTeam = new System.Windows.Forms.ComboBox();
            this.buttonAggiungiTeam = new System.Windows.Forms.Button();
            this.labelSpiegazioneQueryTeam = new System.Windows.Forms.Label();
            this.comboBoxTipoTeam = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxPaeseTeam = new System.Windows.Forms.ComboBox();
            this.labelPaeseTeam = new System.Windows.Forms.Label();
            this.textBoxNomeTeam = new System.Windows.Forms.TextBox();
            this.labelNomeTeam = new System.Windows.Forms.Label();
            this.textBoxNomeUfficialeTeam = new System.Windows.Forms.TextBox();
            this.labelNomeRicercaTeam = new System.Windows.Forms.Label();
            this.dataGridViewTeam = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paese = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonRicercaModelli = new System.Windows.Forms.Button();
            this.buttonRegistraModello = new System.Windows.Forms.Button();
            this.textBoxQueryModello = new System.Windows.Forms.TextBox();
            this.labelNomeModello = new System.Windows.Forms.Label();
            this.comboBoxNomeInserimentoCostruttore = new System.Windows.Forms.ComboBox();
            this.labelNomeInserimentoCostruttore = new System.Windows.Forms.Label();
            this.labelQueryInserimentoModelli = new System.Windows.Forms.Label();
            this.dataGridViewQueryCostruttori = new System.Windows.Forms.DataGridView();
            this.comboBoxNomeRicercaCostruttore = new System.Windows.Forms.ComboBox();
            this.labelNomeRicercaCostruttore = new System.Windows.Forms.Label();
            this.labelQueryVisualizzazioneModelli = new System.Windows.Forms.Label();
            this.separatoreViewCostruttori = new System.Windows.Forms.Label();
            this.buttonAggiungiCostruttore = new System.Windows.Forms.Button();
            this.textBoxAnnoDiEsordioCostruttore = new System.Windows.Forms.TextBox();
            this.labelAnnoDiEsordioCostruttore = new System.Windows.Forms.Label();
            this.comboBoxPaeseCostruttore = new System.Windows.Forms.ComboBox();
            this.labelPaeseCostruttore = new System.Windows.Forms.Label();
            this.textBoxNomeCostruttore = new System.Windows.Forms.TextBox();
            this.labelNomeCostruttore = new System.Windows.Forms.Label();
            this.dataGridViewCostruttori = new System.Windows.Forms.DataGridView();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paeseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.annoDiEsordioGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costruttoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridViewQueryGP = new System.Windows.Forms.DataGridView();
            this.comboBoxRicercaClasse = new System.Windows.Forms.ComboBox();
            this.labelNomeRicercaClasse = new System.Windows.Forms.Label();
            this.buttonRicercaGP = new System.Windows.Forms.Button();
            this.comboBoxRicercaGP = new System.Windows.Forms.ComboBox();
            this.labelNomeRicercaGP = new System.Windows.Forms.Label();
            this.labelRicercaGP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAggiungiGP = new System.Windows.Forms.Button();
            this.textBoxDenominazioneGP = new System.Windows.Forms.TextBox();
            this.labelDenominazioneGP = new System.Windows.Forms.Label();
            this.dataGridViewGranPremi = new System.Windows.Forms.DataGridView();
            this.denominazioneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.annoPrimaEdizioneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.granpremiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.buttonEseguiQueryCircuito = new System.Windows.Forms.Button();
            this.textBoxCognomePilotaQueryCircuito = new System.Windows.Forms.TextBox();
            this.labelCognomePilotaQueryCIrcuito = new System.Windows.Forms.Label();
            this.textBoxNomePilotaQueryCircuito = new System.Windows.Forms.TextBox();
            this.labelNomePilotaQueryCircuito = new System.Windows.Forms.Label();
            this.comboBoxNomeClasseQueryCircuito = new System.Windows.Forms.ComboBox();
            this.labelNomeClasseQueryCircuito = new System.Windows.Forms.Label();
            this.labelNomeCircuitoQuery = new System.Windows.Forms.Label();
            this.comboBoxNomeCircuitoQuery = new System.Windows.Forms.ComboBox();
            this.comboBoxSceltaOperazioneCircuiti = new System.Windows.Forms.ComboBox();
            this.dataGridViewQueryCircuito = new System.Windows.Forms.DataGridView();
            this.separatoreCircuiti = new System.Windows.Forms.Label();
            this.buttonAggiungiCircuito = new System.Windows.Forms.Button();
            this.textBoxLunghezzaRettilineoCircuito = new System.Windows.Forms.TextBox();
            this.labelLunghezzaRettilineoCircuito = new System.Windows.Forms.Label();
            this.labelCurveADestraCircuito = new System.Windows.Forms.Label();
            this.textBoxCurveADestraCircuito = new System.Windows.Forms.TextBox();
            this.textBoxCurveASinistraCircuito = new System.Windows.Forms.TextBox();
            this.labelCurveASinistraCircuito = new System.Windows.Forms.Label();
            this.textBoxLunghezzaCircuito = new System.Windows.Forms.TextBox();
            this.labelLunghezzaCircuito = new System.Windows.Forms.Label();
            this.textBoxLocalitaCircuito = new System.Windows.Forms.TextBox();
            this.textBoxNomeCircuito = new System.Windows.Forms.TextBox();
            this.labelLocalitaCircuito = new System.Windows.Forms.Label();
            this.labelNomeCircuito = new System.Windows.Forms.Label();
            this.dataGridViewCircuiti = new System.Windows.Forms.DataGridView();
            this.nomeCircuito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lunghezzaInMetri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroCurveSinistra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroCurveDestra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lunghezzaRettilineoInMetri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.circuitiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.buttonInserisciProva = new System.Windows.Forms.Button();
            this.dateTimePickerDataFineGP = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDataInizioGP = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxNomeCircuitoQueryStagione = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxNomeGPQueryStagione = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.separatoreCalendario = new System.Windows.Forms.Label();
            this.buttonInserisciStagione = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNumeroProve = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSelezioneStagioneCalendario = new System.Windows.Forms.Button();
            this.comboBoxSelezioneStagione = new System.Windows.Forms.ComboBox();
            this.labelSelezioneStagione = new System.Windows.Forms.Label();
            this.dataGridViewCalendario = new System.Windows.Forms.DataGridView();
            this.proveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pilotiTableAdapter = new datarace.dataraceDataSetTableAdapters.pilotiTableAdapter();
            this.teamTableAdapter = new datarace.dataraceDataSetTableAdapters.teamTableAdapter();
            this.costruttoriTableAdapter = new datarace.dataraceDataSetTableAdapters.costruttoriTableAdapter();
            this.gran_premiTableAdapter = new datarace.dataraceDataSetTableAdapters.gran_premiTableAdapter();
            this.idGranPremioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveTableAdapter = new datarace.dataraceDataSetTableAdapters.proveTableAdapter();
            this.annoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.granPremioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroSpettatoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.circuitiTableAdapter = new datarace.dataraceDataSetTableAdapters.circuitiTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQueryPiloti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPiloti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataraceDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQueryCostruttori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCostruttori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costruttoriBindingSource)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQueryGP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGranPremi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.granpremiBindingSource)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQueryCircuito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCircuiti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circuitiBindingSource)).BeginInit();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalendario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Location = new System.Drawing.Point(4, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1334, 487);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.separatoreViewPiloti);
            this.tabPage1.Controls.Add(this.comboBoxNazionalita);
            this.tabPage1.Controls.Add(this.dataDiNascitaPicker);
            this.tabPage1.Controls.Add(this.comboBoxSceltaQueryPiloti);
            this.tabPage1.Controls.Add(this.dataGridViewQueryPiloti);
            this.tabPage1.Controls.Add(this.buttonRicercaPiloti);
            this.tabPage1.Controls.Add(this.textBoxCognomeRicercaPiloti);
            this.tabPage1.Controls.Add(this.textBoxNomeRicercaPiloti);
            this.tabPage1.Controls.Add(this.labelNomeRicercaPilota);
            this.tabPage1.Controls.Add(this.labelCognomeRicercaPilota);
            this.tabPage1.Controls.Add(this.labelDataDiNascita);
            this.tabPage1.Controls.Add(this.labelNazionalitaPilota);
            this.tabPage1.Controls.Add(this.textBoxLuogoDiNascita);
            this.tabPage1.Controls.Add(this.labelLuogoDiNascita);
            this.tabPage1.Controls.Add(this.textBoxCognomePilota);
            this.tabPage1.Controls.Add(this.labelCognomePilota);
            this.tabPage1.Controls.Add(this.labelNomePilota);
            this.tabPage1.Controls.Add(this.buttonAggiungiPilota);
            this.tabPage1.Controls.Add(this.textBoxNomePilota);
            this.tabPage1.Controls.Add(this.dataGridViewPiloti);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1326, 458);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "piloti";
            // 
            // separatoreViewPiloti
            // 
            this.separatoreViewPiloti.BackColor = System.Drawing.Color.Black;
            this.separatoreViewPiloti.Location = new System.Drawing.Point(401, 6);
            this.separatoreViewPiloti.Name = "separatoreViewPiloti";
            this.separatoreViewPiloti.Size = new System.Drawing.Size(1, 447);
            this.separatoreViewPiloti.TabIndex = 26;
            // 
            // comboBoxNazionalita
            // 
            this.comboBoxNazionalita.FormattingEnabled = true;
            this.comboBoxNazionalita.Location = new System.Drawing.Point(411, 204);
            this.comboBoxNazionalita.Name = "comboBoxNazionalita";
            this.comboBoxNazionalita.Size = new System.Drawing.Size(147, 24);
            this.comboBoxNazionalita.TabIndex = 4;
            // 
            // dataDiNascitaPicker
            // 
            this.dataDiNascitaPicker.CustomFormat = "yyyy/MM/dd";
            this.dataDiNascitaPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataDiNascitaPicker.Location = new System.Drawing.Point(411, 261);
            this.dataDiNascitaPicker.Name = "dataDiNascitaPicker";
            this.dataDiNascitaPicker.Size = new System.Drawing.Size(147, 22);
            this.dataDiNascitaPicker.TabIndex = 5;
            // 
            // comboBoxSceltaQueryPiloti
            // 
            this.comboBoxSceltaQueryPiloti.AllowDrop = true;
            this.comboBoxSceltaQueryPiloti.DropDownHeight = 100;
            this.comboBoxSceltaQueryPiloti.FormattingEnabled = true;
            this.comboBoxSceltaQueryPiloti.IntegralHeight = false;
            this.comboBoxSceltaQueryPiloti.Items.AddRange(new object[] {
            "Statistiche di carriera di un pilota",
            "Campionati disputati da un pilota nel corso della carriera"});
            this.comboBoxSceltaQueryPiloti.Location = new System.Drawing.Point(9, 6);
            this.comboBoxSceltaQueryPiloti.Name = "comboBoxSceltaQueryPiloti";
            this.comboBoxSceltaQueryPiloti.Size = new System.Drawing.Size(386, 24);
            this.comboBoxSceltaQueryPiloti.TabIndex = 7;
            this.comboBoxSceltaQueryPiloti.Text = "Scegli operazione";
            // 
            // dataGridViewQueryPiloti
            // 
            this.dataGridViewQueryPiloti.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewQueryPiloti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQueryPiloti.Location = new System.Drawing.Point(9, 143);
            this.dataGridViewQueryPiloti.Name = "dataGridViewQueryPiloti";
            this.dataGridViewQueryPiloti.RowHeadersVisible = false;
            this.dataGridViewQueryPiloti.RowHeadersWidth = 51;
            this.dataGridViewQueryPiloti.RowTemplate.Height = 24;
            this.dataGridViewQueryPiloti.Size = new System.Drawing.Size(386, 309);
            this.dataGridViewQueryPiloti.TabIndex = 22;
            // 
            // buttonRicercaPiloti
            // 
            this.buttonRicercaPiloti.Location = new System.Drawing.Point(288, 99);
            this.buttonRicercaPiloti.Name = "buttonRicercaPiloti";
            this.buttonRicercaPiloti.Size = new System.Drawing.Size(107, 30);
            this.buttonRicercaPiloti.TabIndex = 10;
            this.buttonRicercaPiloti.Text = "Cerca";
            this.buttonRicercaPiloti.UseVisualStyleBackColor = true;
            this.buttonRicercaPiloti.Click += new System.EventHandler(this.ButtonRicercaPiloti_Click);
            // 
            // textBoxCognomeRicercaPiloti
            // 
            this.textBoxCognomeRicercaPiloti.Location = new System.Drawing.Point(153, 103);
            this.textBoxCognomeRicercaPiloti.Name = "textBoxCognomeRicercaPiloti";
            this.textBoxCognomeRicercaPiloti.Size = new System.Drawing.Size(124, 22);
            this.textBoxCognomeRicercaPiloti.TabIndex = 9;
            // 
            // textBoxNomeRicercaPiloti
            // 
            this.textBoxNomeRicercaPiloti.Location = new System.Drawing.Point(9, 103);
            this.textBoxNomeRicercaPiloti.Name = "textBoxNomeRicercaPiloti";
            this.textBoxNomeRicercaPiloti.Size = new System.Drawing.Size(124, 22);
            this.textBoxNomeRicercaPiloti.TabIndex = 8;
            // 
            // labelNomeRicercaPilota
            // 
            this.labelNomeRicercaPilota.AutoSize = true;
            this.labelNomeRicercaPilota.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelNomeRicercaPilota.Location = new System.Drawing.Point(6, 78);
            this.labelNomeRicercaPilota.Name = "labelNomeRicercaPilota";
            this.labelNomeRicercaPilota.Size = new System.Drawing.Size(45, 17);
            this.labelNomeRicercaPilota.TabIndex = 16;
            this.labelNomeRicercaPilota.Text = "Nome";
            // 
            // labelCognomeRicercaPilota
            // 
            this.labelCognomeRicercaPilota.AutoSize = true;
            this.labelCognomeRicercaPilota.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelCognomeRicercaPilota.Location = new System.Drawing.Point(150, 78);
            this.labelCognomeRicercaPilota.Name = "labelCognomeRicercaPilota";
            this.labelCognomeRicercaPilota.Size = new System.Drawing.Size(68, 17);
            this.labelCognomeRicercaPilota.TabIndex = 15;
            this.labelCognomeRicercaPilota.Text = "Cognome";
            // 
            // labelDataDiNascita
            // 
            this.labelDataDiNascita.AutoSize = true;
            this.labelDataDiNascita.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelDataDiNascita.Location = new System.Drawing.Point(408, 241);
            this.labelDataDiNascita.Name = "labelDataDiNascita";
            this.labelDataDiNascita.Size = new System.Drawing.Size(102, 17);
            this.labelDataDiNascita.TabIndex = 11;
            this.labelDataDiNascita.Text = "Data di nascita";
            // 
            // labelNazionalitaPilota
            // 
            this.labelNazionalitaPilota.AutoSize = true;
            this.labelNazionalitaPilota.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelNazionalitaPilota.Location = new System.Drawing.Point(408, 184);
            this.labelNazionalitaPilota.Name = "labelNazionalitaPilota";
            this.labelNazionalitaPilota.Size = new System.Drawing.Size(78, 17);
            this.labelNazionalitaPilota.TabIndex = 9;
            this.labelNazionalitaPilota.Text = "Nazionalita";
            // 
            // textBoxLuogoDiNascita
            // 
            this.textBoxLuogoDiNascita.Location = new System.Drawing.Point(411, 143);
            this.textBoxLuogoDiNascita.Name = "textBoxLuogoDiNascita";
            this.textBoxLuogoDiNascita.Size = new System.Drawing.Size(147, 22);
            this.textBoxLuogoDiNascita.TabIndex = 3;
            // 
            // labelLuogoDiNascita
            // 
            this.labelLuogoDiNascita.AutoSize = true;
            this.labelLuogoDiNascita.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelLuogoDiNascita.Location = new System.Drawing.Point(408, 123);
            this.labelLuogoDiNascita.Name = "labelLuogoDiNascita";
            this.labelLuogoDiNascita.Size = new System.Drawing.Size(112, 17);
            this.labelLuogoDiNascita.TabIndex = 6;
            this.labelLuogoDiNascita.Text = "Luogo di nascita";
            // 
            // textBoxCognomePilota
            // 
            this.textBoxCognomePilota.Location = new System.Drawing.Point(411, 89);
            this.textBoxCognomePilota.Name = "textBoxCognomePilota";
            this.textBoxCognomePilota.Size = new System.Drawing.Size(147, 22);
            this.textBoxCognomePilota.TabIndex = 2;
            // 
            // labelCognomePilota
            // 
            this.labelCognomePilota.AutoSize = true;
            this.labelCognomePilota.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelCognomePilota.Location = new System.Drawing.Point(408, 69);
            this.labelCognomePilota.Name = "labelCognomePilota";
            this.labelCognomePilota.Size = new System.Drawing.Size(68, 17);
            this.labelCognomePilota.TabIndex = 4;
            this.labelCognomePilota.Text = "Cognome";
            // 
            // labelNomePilota
            // 
            this.labelNomePilota.AutoSize = true;
            this.labelNomePilota.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelNomePilota.Location = new System.Drawing.Point(408, 15);
            this.labelNomePilota.Name = "labelNomePilota";
            this.labelNomePilota.Size = new System.Drawing.Size(45, 17);
            this.labelNomePilota.TabIndex = 3;
            this.labelNomePilota.Text = "Nome";
            // 
            // buttonAggiungiPilota
            // 
            this.buttonAggiungiPilota.Location = new System.Drawing.Point(465, 306);
            this.buttonAggiungiPilota.Name = "buttonAggiungiPilota";
            this.buttonAggiungiPilota.Size = new System.Drawing.Size(93, 32);
            this.buttonAggiungiPilota.TabIndex = 6;
            this.buttonAggiungiPilota.Text = "Aggiungi";
            this.buttonAggiungiPilota.UseVisualStyleBackColor = true;
            this.buttonAggiungiPilota.Click += new System.EventHandler(this.ButtonAggungiPilota_Click);
            // 
            // textBoxNomePilota
            // 
            this.textBoxNomePilota.Location = new System.Drawing.Point(411, 35);
            this.textBoxNomePilota.Name = "textBoxNomePilota";
            this.textBoxNomePilota.Size = new System.Drawing.Size(147, 22);
            this.textBoxNomePilota.TabIndex = 1;
            // 
            // dataGridViewPiloti
            // 
            this.dataGridViewPiloti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPiloti.AutoGenerateColumns = false;
            this.dataGridViewPiloti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPiloti.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewPiloti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPiloti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.cognomeDataGridViewTextBoxColumn,
            this.luogoDiNascitaDataGridViewTextBoxColumn,
            this.nazionalitaDataGridViewTextBoxColumn,
            this.dataDiNascitaDataGridViewTextBoxColumn});
            this.dataGridViewPiloti.DataSource = this.pilotiBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPiloti.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPiloti.Location = new System.Drawing.Point(564, 6);
            this.dataGridViewPiloti.Name = "dataGridViewPiloti";
            this.dataGridViewPiloti.RowHeadersVisible = false;
            this.dataGridViewPiloti.RowHeadersWidth = 51;
            this.dataGridViewPiloti.RowTemplate.Height = 24;
            this.dataGridViewPiloti.Size = new System.Drawing.Size(756, 447);
            this.dataGridViewPiloti.TabIndex = 0;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // cognomeDataGridViewTextBoxColumn
            // 
            this.cognomeDataGridViewTextBoxColumn.DataPropertyName = "cognome";
            this.cognomeDataGridViewTextBoxColumn.HeaderText = "cognome";
            this.cognomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cognomeDataGridViewTextBoxColumn.Name = "cognomeDataGridViewTextBoxColumn";
            // 
            // luogoDiNascitaDataGridViewTextBoxColumn
            // 
            this.luogoDiNascitaDataGridViewTextBoxColumn.DataPropertyName = "luogoDiNascita";
            this.luogoDiNascitaDataGridViewTextBoxColumn.HeaderText = "luogo di nascita";
            this.luogoDiNascitaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.luogoDiNascitaDataGridViewTextBoxColumn.Name = "luogoDiNascitaDataGridViewTextBoxColumn";
            // 
            // nazionalitaDataGridViewTextBoxColumn
            // 
            this.nazionalitaDataGridViewTextBoxColumn.DataPropertyName = "nazionalita";
            this.nazionalitaDataGridViewTextBoxColumn.HeaderText = "nazionalita";
            this.nazionalitaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nazionalitaDataGridViewTextBoxColumn.Name = "nazionalitaDataGridViewTextBoxColumn";
            // 
            // dataDiNascitaDataGridViewTextBoxColumn
            // 
            this.dataDiNascitaDataGridViewTextBoxColumn.DataPropertyName = "dataDiNascita";
            this.dataDiNascitaDataGridViewTextBoxColumn.HeaderText = "data di nascita";
            this.dataDiNascitaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataDiNascitaDataGridViewTextBoxColumn.Name = "dataDiNascitaDataGridViewTextBoxColumn";
            // 
            // pilotiBindingSource
            // 
            this.pilotiBindingSource.DataMember = "piloti";
            this.pilotiBindingSource.DataSource = this.dataraceDataSet;
            // 
            // dataraceDataSet
            // 
            this.dataraceDataSet.DataSetName = "dataraceDataSet";
            this.dataraceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonQueryTeam);
            this.tabPage2.Controls.Add(this.labelClassiTeam);
            this.tabPage2.Controls.Add(this.checkedListBoxClassiTeam);
            this.tabPage2.Controls.Add(this.textBoxTeamManager);
            this.tabPage2.Controls.Add(this.labelTeamManager);
            this.tabPage2.Controls.Add(this.labelNomeUfficialeTeam);
            this.tabPage2.Controls.Add(this.separatoreViewTeam);
            this.tabPage2.Controls.Add(this.comboBoxNomeRicercaTeam);
            this.tabPage2.Controls.Add(this.buttonAggiungiTeam);
            this.tabPage2.Controls.Add(this.labelSpiegazioneQueryTeam);
            this.tabPage2.Controls.Add(this.comboBoxTipoTeam);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.comboBoxPaeseTeam);
            this.tabPage2.Controls.Add(this.labelPaeseTeam);
            this.tabPage2.Controls.Add(this.textBoxNomeTeam);
            this.tabPage2.Controls.Add(this.labelNomeTeam);
            this.tabPage2.Controls.Add(this.textBoxNomeUfficialeTeam);
            this.tabPage2.Controls.Add(this.labelNomeRicercaTeam);
            this.tabPage2.Controls.Add(this.dataGridViewTeam);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1326, 458);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "team";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonQueryTeam
            // 
            this.buttonQueryTeam.Location = new System.Drawing.Point(261, 356);
            this.buttonQueryTeam.Name = "buttonQueryTeam";
            this.buttonQueryTeam.Size = new System.Drawing.Size(93, 32);
            this.buttonQueryTeam.TabIndex = 29;
            this.buttonQueryTeam.Text = "Registra";
            this.buttonQueryTeam.UseVisualStyleBackColor = true;
            this.buttonQueryTeam.Click += new System.EventHandler(this.ButtonQueryTeam_Click);
            // 
            // labelClassiTeam
            // 
            this.labelClassiTeam.AutoSize = true;
            this.labelClassiTeam.Location = new System.Drawing.Point(6, 262);
            this.labelClassiTeam.Name = "labelClassiTeam";
            this.labelClassiTeam.Size = new System.Drawing.Size(45, 17);
            this.labelClassiTeam.TabIndex = 44;
            this.labelClassiTeam.Text = "Classi";
            // 
            // checkedListBoxClassiTeam
            // 
            this.checkedListBoxClassiTeam.FormattingEnabled = true;
            this.checkedListBoxClassiTeam.Location = new System.Drawing.Point(9, 282);
            this.checkedListBoxClassiTeam.Name = "checkedListBoxClassiTeam";
            this.checkedListBoxClassiTeam.Size = new System.Drawing.Size(187, 106);
            this.checkedListBoxClassiTeam.TabIndex = 28;
            // 
            // textBoxTeamManager
            // 
            this.textBoxTeamManager.Location = new System.Drawing.Point(9, 225);
            this.textBoxTeamManager.Name = "textBoxTeamManager";
            this.textBoxTeamManager.Size = new System.Drawing.Size(231, 22);
            this.textBoxTeamManager.TabIndex = 27;
            // 
            // labelTeamManager
            // 
            this.labelTeamManager.AutoSize = true;
            this.labelTeamManager.Location = new System.Drawing.Point(6, 205);
            this.labelTeamManager.Name = "labelTeamManager";
            this.labelTeamManager.Size = new System.Drawing.Size(104, 17);
            this.labelTeamManager.TabIndex = 41;
            this.labelTeamManager.Text = "Team manager";
            // 
            // labelNomeUfficialeTeam
            // 
            this.labelNomeUfficialeTeam.AutoSize = true;
            this.labelNomeUfficialeTeam.Location = new System.Drawing.Point(6, 146);
            this.labelNomeUfficialeTeam.Name = "labelNomeUfficialeTeam";
            this.labelNomeUfficialeTeam.Size = new System.Drawing.Size(97, 17);
            this.labelNomeUfficialeTeam.TabIndex = 40;
            this.labelNomeUfficialeTeam.Text = "Nome ufficiale";
            // 
            // separatoreViewTeam
            // 
            this.separatoreViewTeam.BackColor = System.Drawing.Color.Black;
            this.separatoreViewTeam.Location = new System.Drawing.Point(363, 5);
            this.separatoreViewTeam.Name = "separatoreViewTeam";
            this.separatoreViewTeam.Size = new System.Drawing.Size(1, 447);
            this.separatoreViewTeam.TabIndex = 39;
            // 
            // comboBoxNomeRicercaTeam
            // 
            this.comboBoxNomeRicercaTeam.FormattingEnabled = true;
            this.comboBoxNomeRicercaTeam.Location = new System.Drawing.Point(9, 108);
            this.comboBoxNomeRicercaTeam.Name = "comboBoxNomeRicercaTeam";
            this.comboBoxNomeRicercaTeam.Size = new System.Drawing.Size(345, 24);
            this.comboBoxNomeRicercaTeam.TabIndex = 25;
            // 
            // buttonAggiungiTeam
            // 
            this.buttonAggiungiTeam.Location = new System.Drawing.Point(465, 190);
            this.buttonAggiungiTeam.Name = "buttonAggiungiTeam";
            this.buttonAggiungiTeam.Size = new System.Drawing.Size(93, 32);
            this.buttonAggiungiTeam.TabIndex = 23;
            this.buttonAggiungiTeam.Text = "Aggiungi";
            this.buttonAggiungiTeam.UseVisualStyleBackColor = true;
            this.buttonAggiungiTeam.Click += new System.EventHandler(this.ButtonAggiungiTeam_Click);
            // 
            // labelSpiegazioneQueryTeam
            // 
            this.labelSpiegazioneQueryTeam.AutoSize = true;
            this.labelSpiegazioneQueryTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpiegazioneQueryTeam.Location = new System.Drawing.Point(6, 6);
            this.labelSpiegazioneQueryTeam.Name = "labelSpiegazioneQueryTeam";
            this.labelSpiegazioneQueryTeam.Size = new System.Drawing.Size(328, 68);
            this.labelSpiegazioneQueryTeam.TabIndex = 36;
            this.labelSpiegazioneQueryTeam.Text = "Registra un team per la prossima stagione di gare \r\ninserendo il suo nome ufficia" +
    "le per la stagione, il \r\nteam manager e scegliendo la/le classe/i alle quali \r\np" +
    "arteciperà:";
            // 
            // comboBoxTipoTeam
            // 
            this.comboBoxTipoTeam.FormattingEnabled = true;
            this.comboBoxTipoTeam.Items.AddRange(new object[] {
            "Ufficiale",
            "Privato"});
            this.comboBoxTipoTeam.Location = new System.Drawing.Point(373, 146);
            this.comboBoxTipoTeam.Name = "comboBoxTipoTeam";
            this.comboBoxTipoTeam.Size = new System.Drawing.Size(185, 24);
            this.comboBoxTipoTeam.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(370, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 17);
            this.label11.TabIndex = 33;
            this.label11.Text = "Tipo";
            // 
            // comboBoxPaeseTeam
            // 
            this.comboBoxPaeseTeam.FormattingEnabled = true;
            this.comboBoxPaeseTeam.Location = new System.Drawing.Point(373, 88);
            this.comboBoxPaeseTeam.Name = "comboBoxPaeseTeam";
            this.comboBoxPaeseTeam.Size = new System.Drawing.Size(185, 24);
            this.comboBoxPaeseTeam.TabIndex = 21;
            // 
            // labelPaeseTeam
            // 
            this.labelPaeseTeam.AutoSize = true;
            this.labelPaeseTeam.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelPaeseTeam.Location = new System.Drawing.Point(370, 67);
            this.labelPaeseTeam.Name = "labelPaeseTeam";
            this.labelPaeseTeam.Size = new System.Drawing.Size(48, 17);
            this.labelPaeseTeam.TabIndex = 30;
            this.labelPaeseTeam.Text = "Paese";
            // 
            // textBoxNomeTeam
            // 
            this.textBoxNomeTeam.Location = new System.Drawing.Point(373, 33);
            this.textBoxNomeTeam.Name = "textBoxNomeTeam";
            this.textBoxNomeTeam.Size = new System.Drawing.Size(185, 22);
            this.textBoxNomeTeam.TabIndex = 20;
            // 
            // labelNomeTeam
            // 
            this.labelNomeTeam.AutoSize = true;
            this.labelNomeTeam.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelNomeTeam.Location = new System.Drawing.Point(370, 13);
            this.labelNomeTeam.Name = "labelNomeTeam";
            this.labelNomeTeam.Size = new System.Drawing.Size(45, 17);
            this.labelNomeTeam.TabIndex = 28;
            this.labelNomeTeam.Text = "Nome";
            // 
            // textBoxNomeUfficialeTeam
            // 
            this.textBoxNomeUfficialeTeam.Location = new System.Drawing.Point(9, 166);
            this.textBoxNomeUfficialeTeam.Name = "textBoxNomeUfficialeTeam";
            this.textBoxNomeUfficialeTeam.Size = new System.Drawing.Size(231, 22);
            this.textBoxNomeUfficialeTeam.TabIndex = 26;
            // 
            // labelNomeRicercaTeam
            // 
            this.labelNomeRicercaTeam.AutoSize = true;
            this.labelNomeRicercaTeam.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelNomeRicercaTeam.Location = new System.Drawing.Point(6, 88);
            this.labelNomeRicercaTeam.Name = "labelNomeRicercaTeam";
            this.labelNomeRicercaTeam.Size = new System.Drawing.Size(44, 17);
            this.labelNomeRicercaTeam.TabIndex = 26;
            this.labelNomeRicercaTeam.Text = "Team";
            // 
            // dataGridViewTeam
            // 
            this.dataGridViewTeam.AutoGenerateColumns = false;
            this.dataGridViewTeam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTeam.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.paese,
            this.tipo});
            this.dataGridViewTeam.DataSource = this.teamBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTeam.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTeam.Location = new System.Drawing.Point(564, 6);
            this.dataGridViewTeam.Name = "dataGridViewTeam";
            this.dataGridViewTeam.RowHeadersVisible = false;
            this.dataGridViewTeam.RowHeadersWidth = 51;
            this.dataGridViewTeam.RowTemplate.Height = 24;
            this.dataGridViewTeam.Size = new System.Drawing.Size(756, 446);
            this.dataGridViewTeam.TabIndex = 24;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "nome";
            this.dataGridViewTextBoxColumn1.HeaderText = "nome";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // paese
            // 
            this.paese.DataPropertyName = "paese";
            this.paese.HeaderText = "paese";
            this.paese.MinimumWidth = 6;
            this.paese.Name = "paese";
            // 
            // tipo
            // 
            this.tipo.DataPropertyName = "tipo";
            this.tipo.HeaderText = "tipo";
            this.tipo.MinimumWidth = 6;
            this.tipo.Name = "tipo";
            // 
            // teamBindingSource
            // 
            this.teamBindingSource.DataMember = "team";
            this.teamBindingSource.DataSource = this.dataraceDataSet;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonRicercaModelli);
            this.tabPage3.Controls.Add(this.buttonRegistraModello);
            this.tabPage3.Controls.Add(this.textBoxQueryModello);
            this.tabPage3.Controls.Add(this.labelNomeModello);
            this.tabPage3.Controls.Add(this.comboBoxNomeInserimentoCostruttore);
            this.tabPage3.Controls.Add(this.labelNomeInserimentoCostruttore);
            this.tabPage3.Controls.Add(this.labelQueryInserimentoModelli);
            this.tabPage3.Controls.Add(this.dataGridViewQueryCostruttori);
            this.tabPage3.Controls.Add(this.comboBoxNomeRicercaCostruttore);
            this.tabPage3.Controls.Add(this.labelNomeRicercaCostruttore);
            this.tabPage3.Controls.Add(this.labelQueryVisualizzazioneModelli);
            this.tabPage3.Controls.Add(this.separatoreViewCostruttori);
            this.tabPage3.Controls.Add(this.buttonAggiungiCostruttore);
            this.tabPage3.Controls.Add(this.textBoxAnnoDiEsordioCostruttore);
            this.tabPage3.Controls.Add(this.labelAnnoDiEsordioCostruttore);
            this.tabPage3.Controls.Add(this.comboBoxPaeseCostruttore);
            this.tabPage3.Controls.Add(this.labelPaeseCostruttore);
            this.tabPage3.Controls.Add(this.textBoxNomeCostruttore);
            this.tabPage3.Controls.Add(this.labelNomeCostruttore);
            this.tabPage3.Controls.Add(this.dataGridViewCostruttori);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1326, 458);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "costruttori";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonRicercaModelli
            // 
            this.buttonRicercaModelli.Location = new System.Drawing.Point(254, 100);
            this.buttonRicercaModelli.Name = "buttonRicercaModelli";
            this.buttonRicercaModelli.Size = new System.Drawing.Size(100, 30);
            this.buttonRicercaModelli.TabIndex = 47;
            this.buttonRicercaModelli.Text = "Cerca";
            this.buttonRicercaModelli.UseVisualStyleBackColor = true;
            this.buttonRicercaModelli.Click += new System.EventHandler(this.ButtonRicercaModelli_Click);
            // 
            // buttonRegistraModello
            // 
            this.buttonRegistraModello.Location = new System.Drawing.Point(261, 387);
            this.buttonRegistraModello.Name = "buttonRegistraModello";
            this.buttonRegistraModello.Size = new System.Drawing.Size(93, 32);
            this.buttonRegistraModello.TabIndex = 46;
            this.buttonRegistraModello.Text = "Registra";
            this.buttonRegistraModello.UseVisualStyleBackColor = true;
            this.buttonRegistraModello.Click += new System.EventHandler(this.ButtonRegistraModello_Click);
            // 
            // textBoxQueryModello
            // 
            this.textBoxQueryModello.Location = new System.Drawing.Point(9, 422);
            this.textBoxQueryModello.Name = "textBoxQueryModello";
            this.textBoxQueryModello.Size = new System.Drawing.Size(232, 22);
            this.textBoxQueryModello.TabIndex = 45;
            // 
            // labelNomeModello
            // 
            this.labelNomeModello.AutoSize = true;
            this.labelNomeModello.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelNomeModello.Location = new System.Drawing.Point(6, 402);
            this.labelNomeModello.Name = "labelNomeModello";
            this.labelNomeModello.Size = new System.Drawing.Size(57, 17);
            this.labelNomeModello.TabIndex = 44;
            this.labelNomeModello.Text = "Modello";
            // 
            // comboBoxNomeInserimentoCostruttore
            // 
            this.comboBoxNomeInserimentoCostruttore.FormattingEnabled = true;
            this.comboBoxNomeInserimentoCostruttore.Location = new System.Drawing.Point(9, 363);
            this.comboBoxNomeInserimentoCostruttore.Name = "comboBoxNomeInserimentoCostruttore";
            this.comboBoxNomeInserimentoCostruttore.Size = new System.Drawing.Size(232, 24);
            this.comboBoxNomeInserimentoCostruttore.TabIndex = 43;
            // 
            // labelNomeInserimentoCostruttore
            // 
            this.labelNomeInserimentoCostruttore.AutoSize = true;
            this.labelNomeInserimentoCostruttore.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelNomeInserimentoCostruttore.Location = new System.Drawing.Point(6, 343);
            this.labelNomeInserimentoCostruttore.Name = "labelNomeInserimentoCostruttore";
            this.labelNomeInserimentoCostruttore.Size = new System.Drawing.Size(78, 17);
            this.labelNomeInserimentoCostruttore.TabIndex = 42;
            this.labelNomeInserimentoCostruttore.Text = "Costruttore";
            // 
            // labelQueryInserimentoModelli
            // 
            this.labelQueryInserimentoModelli.AutoSize = true;
            this.labelQueryInserimentoModelli.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQueryInserimentoModelli.Location = new System.Drawing.Point(6, 291);
            this.labelQueryInserimentoModelli.Name = "labelQueryInserimentoModelli";
            this.labelQueryInserimentoModelli.Size = new System.Drawing.Size(288, 34);
            this.labelQueryInserimentoModelli.TabIndex = 41;
            this.labelQueryInserimentoModelli.Text = "Registra un nuovo modello per il costruttore \r\nselezionato";
            // 
            // dataGridViewQueryCostruttori
            // 
            this.dataGridViewQueryCostruttori.AllowUserToAddRows = false;
            this.dataGridViewQueryCostruttori.AllowUserToDeleteRows = false;
            this.dataGridViewQueryCostruttori.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewQueryCostruttori.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewQueryCostruttori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQueryCostruttori.Location = new System.Drawing.Point(9, 143);
            this.dataGridViewQueryCostruttori.Name = "dataGridViewQueryCostruttori";
            this.dataGridViewQueryCostruttori.ReadOnly = true;
            this.dataGridViewQueryCostruttori.RowHeadersVisible = false;
            this.dataGridViewQueryCostruttori.RowHeadersWidth = 51;
            this.dataGridViewQueryCostruttori.RowTemplate.Height = 24;
            this.dataGridViewQueryCostruttori.Size = new System.Drawing.Size(345, 110);
            this.dataGridViewQueryCostruttori.TabIndex = 40;
            // 
            // comboBoxNomeRicercaCostruttore
            // 
            this.comboBoxNomeRicercaCostruttore.FormattingEnabled = true;
            this.comboBoxNomeRicercaCostruttore.Location = new System.Drawing.Point(9, 104);
            this.comboBoxNomeRicercaCostruttore.Name = "comboBoxNomeRicercaCostruttore";
            this.comboBoxNomeRicercaCostruttore.Size = new System.Drawing.Size(232, 24);
            this.comboBoxNomeRicercaCostruttore.TabIndex = 39;
            // 
            // labelNomeRicercaCostruttore
            // 
            this.labelNomeRicercaCostruttore.AutoSize = true;
            this.labelNomeRicercaCostruttore.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelNomeRicercaCostruttore.Location = new System.Drawing.Point(6, 84);
            this.labelNomeRicercaCostruttore.Name = "labelNomeRicercaCostruttore";
            this.labelNomeRicercaCostruttore.Size = new System.Drawing.Size(78, 17);
            this.labelNomeRicercaCostruttore.TabIndex = 38;
            this.labelNomeRicercaCostruttore.Text = "Costruttore";
            // 
            // labelQueryVisualizzazioneModelli
            // 
            this.labelQueryVisualizzazioneModelli.AutoSize = true;
            this.labelQueryVisualizzazioneModelli.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQueryVisualizzazioneModelli.Location = new System.Drawing.Point(6, 6);
            this.labelQueryVisualizzazioneModelli.Name = "labelQueryVisualizzazioneModelli";
            this.labelQueryVisualizzazioneModelli.Size = new System.Drawing.Size(324, 51);
            this.labelQueryVisualizzazioneModelli.TabIndex = 37;
            this.labelQueryVisualizzazioneModelli.Text = "Visualizza tutti i modelli prodotti dal costruttore\r\nselezionato che hanno partec" +
    "ipato ad almeno una\r\nprova nella storia:";
            // 
            // separatoreViewCostruttori
            // 
            this.separatoreViewCostruttori.BackColor = System.Drawing.Color.Black;
            this.separatoreViewCostruttori.Location = new System.Drawing.Point(363, 6);
            this.separatoreViewCostruttori.Name = "separatoreViewCostruttori";
            this.separatoreViewCostruttori.Size = new System.Drawing.Size(1, 447);
            this.separatoreViewCostruttori.TabIndex = 40;
            // 
            // buttonAggiungiCostruttore
            // 
            this.buttonAggiungiCostruttore.Location = new System.Drawing.Point(465, 199);
            this.buttonAggiungiCostruttore.Name = "buttonAggiungiCostruttore";
            this.buttonAggiungiCostruttore.Size = new System.Drawing.Size(93, 32);
            this.buttonAggiungiCostruttore.TabIndex = 36;
            this.buttonAggiungiCostruttore.Text = "Aggiungi";
            this.buttonAggiungiCostruttore.UseVisualStyleBackColor = true;
            this.buttonAggiungiCostruttore.Click += new System.EventHandler(this.ButtonAggiungiCostruttore_Click);
            // 
            // textBoxAnnoDiEsordioCostruttore
            // 
            this.textBoxAnnoDiEsordioCostruttore.Location = new System.Drawing.Point(373, 152);
            this.textBoxAnnoDiEsordioCostruttore.Name = "textBoxAnnoDiEsordioCostruttore";
            this.textBoxAnnoDiEsordioCostruttore.Size = new System.Drawing.Size(185, 22);
            this.textBoxAnnoDiEsordioCostruttore.TabIndex = 35;
            // 
            // labelAnnoDiEsordioCostruttore
            // 
            this.labelAnnoDiEsordioCostruttore.AutoSize = true;
            this.labelAnnoDiEsordioCostruttore.Location = new System.Drawing.Point(370, 132);
            this.labelAnnoDiEsordioCostruttore.Name = "labelAnnoDiEsordioCostruttore";
            this.labelAnnoDiEsordioCostruttore.Size = new System.Drawing.Size(107, 17);
            this.labelAnnoDiEsordioCostruttore.TabIndex = 34;
            this.labelAnnoDiEsordioCostruttore.Text = "Anno di esordio";
            // 
            // comboBoxPaeseCostruttore
            // 
            this.comboBoxPaeseCostruttore.FormattingEnabled = true;
            this.comboBoxPaeseCostruttore.Location = new System.Drawing.Point(373, 93);
            this.comboBoxPaeseCostruttore.Name = "comboBoxPaeseCostruttore";
            this.comboBoxPaeseCostruttore.Size = new System.Drawing.Size(185, 24);
            this.comboBoxPaeseCostruttore.TabIndex = 33;
            // 
            // labelPaeseCostruttore
            // 
            this.labelPaeseCostruttore.AutoSize = true;
            this.labelPaeseCostruttore.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelPaeseCostruttore.Location = new System.Drawing.Point(370, 73);
            this.labelPaeseCostruttore.Name = "labelPaeseCostruttore";
            this.labelPaeseCostruttore.Size = new System.Drawing.Size(48, 17);
            this.labelPaeseCostruttore.TabIndex = 32;
            this.labelPaeseCostruttore.Text = "Paese";
            // 
            // textBoxNomeCostruttore
            // 
            this.textBoxNomeCostruttore.Location = new System.Drawing.Point(373, 35);
            this.textBoxNomeCostruttore.Name = "textBoxNomeCostruttore";
            this.textBoxNomeCostruttore.Size = new System.Drawing.Size(185, 22);
            this.textBoxNomeCostruttore.TabIndex = 31;
            // 
            // labelNomeCostruttore
            // 
            this.labelNomeCostruttore.AutoSize = true;
            this.labelNomeCostruttore.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelNomeCostruttore.Location = new System.Drawing.Point(370, 15);
            this.labelNomeCostruttore.Name = "labelNomeCostruttore";
            this.labelNomeCostruttore.Size = new System.Drawing.Size(45, 17);
            this.labelNomeCostruttore.TabIndex = 30;
            this.labelNomeCostruttore.Text = "Nome";
            // 
            // dataGridViewCostruttori
            // 
            this.dataGridViewCostruttori.AutoGenerateColumns = false;
            this.dataGridViewCostruttori.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCostruttori.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewCostruttori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCostruttori.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.paeseDataGridViewTextBoxColumn,
            this.annoDiEsordioGridViewTextBoxColumn});
            this.dataGridViewCostruttori.DataSource = this.costruttoriBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCostruttori.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewCostruttori.Location = new System.Drawing.Point(564, 6);
            this.dataGridViewCostruttori.Name = "dataGridViewCostruttori";
            this.dataGridViewCostruttori.RowHeadersVisible = false;
            this.dataGridViewCostruttori.RowHeadersWidth = 51;
            this.dataGridViewCostruttori.RowTemplate.Height = 24;
            this.dataGridViewCostruttori.Size = new System.Drawing.Size(756, 446);
            this.dataGridViewCostruttori.TabIndex = 37;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "nome";
            this.nome.MinimumWidth = 6;
            this.nome.Name = "nome";
            // 
            // paeseDataGridViewTextBoxColumn
            // 
            this.paeseDataGridViewTextBoxColumn.DataPropertyName = "paese";
            this.paeseDataGridViewTextBoxColumn.HeaderText = "paese";
            this.paeseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paeseDataGridViewTextBoxColumn.Name = "paeseDataGridViewTextBoxColumn";
            // 
            // annoDiEsordioGridViewTextBoxColumn
            // 
            this.annoDiEsordioGridViewTextBoxColumn.DataPropertyName = "annoDiEsordio";
            this.annoDiEsordioGridViewTextBoxColumn.HeaderText = "anno di esordio";
            this.annoDiEsordioGridViewTextBoxColumn.MinimumWidth = 6;
            this.annoDiEsordioGridViewTextBoxColumn.Name = "annoDiEsordioGridViewTextBoxColumn";
            // 
            // costruttoriBindingSource
            // 
            this.costruttoriBindingSource.DataMember = "costruttori";
            this.costruttoriBindingSource.DataSource = this.dataraceDataSet;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridViewQueryGP);
            this.tabPage4.Controls.Add(this.comboBoxRicercaClasse);
            this.tabPage4.Controls.Add(this.labelNomeRicercaClasse);
            this.tabPage4.Controls.Add(this.buttonRicercaGP);
            this.tabPage4.Controls.Add(this.comboBoxRicercaGP);
            this.tabPage4.Controls.Add(this.labelNomeRicercaGP);
            this.tabPage4.Controls.Add(this.labelRicercaGP);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.buttonAggiungiGP);
            this.tabPage4.Controls.Add(this.textBoxDenominazioneGP);
            this.tabPage4.Controls.Add(this.labelDenominazioneGP);
            this.tabPage4.Controls.Add(this.dataGridViewGranPremi);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1326, 458);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "gran premi";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridViewQueryGP
            // 
            this.dataGridViewQueryGP.AllowUserToAddRows = false;
            this.dataGridViewQueryGP.AllowUserToDeleteRows = false;
            this.dataGridViewQueryGP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewQueryGP.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewQueryGP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQueryGP.Location = new System.Drawing.Point(9, 181);
            this.dataGridViewQueryGP.Name = "dataGridViewQueryGP";
            this.dataGridViewQueryGP.ReadOnly = true;
            this.dataGridViewQueryGP.RowHeadersVisible = false;
            this.dataGridViewQueryGP.RowHeadersWidth = 51;
            this.dataGridViewQueryGP.RowTemplate.Height = 24;
            this.dataGridViewQueryGP.Size = new System.Drawing.Size(580, 270);
            this.dataGridViewQueryGP.TabIndex = 51;
            // 
            // comboBoxRicercaClasse
            // 
            this.comboBoxRicercaClasse.FormattingEnabled = true;
            this.comboBoxRicercaClasse.Location = new System.Drawing.Point(9, 140);
            this.comboBoxRicercaClasse.Name = "comboBoxRicercaClasse";
            this.comboBoxRicercaClasse.Size = new System.Drawing.Size(232, 24);
            this.comboBoxRicercaClasse.TabIndex = 50;
            // 
            // labelNomeRicercaClasse
            // 
            this.labelNomeRicercaClasse.AutoSize = true;
            this.labelNomeRicercaClasse.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelNomeRicercaClasse.Location = new System.Drawing.Point(6, 120);
            this.labelNomeRicercaClasse.Name = "labelNomeRicercaClasse";
            this.labelNomeRicercaClasse.Size = new System.Drawing.Size(50, 17);
            this.labelNomeRicercaClasse.TabIndex = 49;
            this.labelNomeRicercaClasse.Text = "Classe";
            // 
            // buttonRicercaGP
            // 
            this.buttonRicercaGP.Location = new System.Drawing.Point(257, 136);
            this.buttonRicercaGP.Name = "buttonRicercaGP";
            this.buttonRicercaGP.Size = new System.Drawing.Size(98, 30);
            this.buttonRicercaGP.TabIndex = 48;
            this.buttonRicercaGP.Text = "Cerca";
            this.buttonRicercaGP.UseVisualStyleBackColor = true;
            this.buttonRicercaGP.Click += new System.EventHandler(this.ButtonRicercaGP_Click);
            // 
            // comboBoxRicercaGP
            // 
            this.comboBoxRicercaGP.FormattingEnabled = true;
            this.comboBoxRicercaGP.Location = new System.Drawing.Point(9, 75);
            this.comboBoxRicercaGP.Name = "comboBoxRicercaGP";
            this.comboBoxRicercaGP.Size = new System.Drawing.Size(346, 24);
            this.comboBoxRicercaGP.TabIndex = 45;
            // 
            // labelNomeRicercaGP
            // 
            this.labelNomeRicercaGP.AutoSize = true;
            this.labelNomeRicercaGP.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelNomeRicercaGP.Location = new System.Drawing.Point(6, 55);
            this.labelNomeRicercaGP.Name = "labelNomeRicercaGP";
            this.labelNomeRicercaGP.Size = new System.Drawing.Size(28, 17);
            this.labelNomeRicercaGP.TabIndex = 44;
            this.labelNomeRicercaGP.Text = "GP";
            // 
            // labelRicercaGP
            // 
            this.labelRicercaGP.AutoSize = true;
            this.labelRicercaGP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRicercaGP.Location = new System.Drawing.Point(6, 7);
            this.labelRicercaGP.Name = "labelRicercaGP";
            this.labelRicercaGP.Size = new System.Drawing.Size(442, 17);
            this.labelRicercaGP.TabIndex = 43;
            this.labelRicercaGP.Text = "Seleziona un gran premio e una classe per visualizzarne l\'albo d\'oro:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(597, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1, 447);
            this.label1.TabIndex = 42;
            // 
            // buttonAggiungiGP
            // 
            this.buttonAggiungiGP.Location = new System.Drawing.Point(699, 81);
            this.buttonAggiungiGP.Name = "buttonAggiungiGP";
            this.buttonAggiungiGP.Size = new System.Drawing.Size(93, 32);
            this.buttonAggiungiGP.TabIndex = 41;
            this.buttonAggiungiGP.Text = "Aggiungi";
            this.buttonAggiungiGP.UseVisualStyleBackColor = true;
            this.buttonAggiungiGP.Click += new System.EventHandler(this.ButtonAggiungiGP_Click);
            // 
            // textBoxDenominazioneGP
            // 
            this.textBoxDenominazioneGP.Location = new System.Drawing.Point(607, 34);
            this.textBoxDenominazioneGP.Name = "textBoxDenominazioneGP";
            this.textBoxDenominazioneGP.Size = new System.Drawing.Size(185, 22);
            this.textBoxDenominazioneGP.TabIndex = 40;
            // 
            // labelDenominazioneGP
            // 
            this.labelDenominazioneGP.AutoSize = true;
            this.labelDenominazioneGP.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelDenominazioneGP.Location = new System.Drawing.Point(604, 14);
            this.labelDenominazioneGP.Name = "labelDenominazioneGP";
            this.labelDenominazioneGP.Size = new System.Drawing.Size(130, 17);
            this.labelDenominazioneGP.TabIndex = 39;
            this.labelDenominazioneGP.Text = "Denominazione GP";
            // 
            // dataGridViewGranPremi
            // 
            this.dataGridViewGranPremi.AutoGenerateColumns = false;
            this.dataGridViewGranPremi.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewGranPremi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGranPremi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.denominazioneDataGridViewTextBoxColumn,
            this.annoPrimaEdizioneDataGridViewTextBoxColumn});
            this.dataGridViewGranPremi.DataSource = this.granpremiBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewGranPremi.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewGranPremi.Location = new System.Drawing.Point(798, 7);
            this.dataGridViewGranPremi.Name = "dataGridViewGranPremi";
            this.dataGridViewGranPremi.RowHeadersVisible = false;
            this.dataGridViewGranPremi.RowHeadersWidth = 51;
            this.dataGridViewGranPremi.RowTemplate.Height = 24;
            this.dataGridViewGranPremi.Size = new System.Drawing.Size(522, 446);
            this.dataGridViewGranPremi.TabIndex = 38;
            // 
            // denominazioneDataGridViewTextBoxColumn
            // 
            this.denominazioneDataGridViewTextBoxColumn.DataPropertyName = "denominazione";
            this.denominazioneDataGridViewTextBoxColumn.HeaderText = "denominazione";
            this.denominazioneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.denominazioneDataGridViewTextBoxColumn.Name = "denominazioneDataGridViewTextBoxColumn";
            this.denominazioneDataGridViewTextBoxColumn.Width = 377;
            // 
            // annoPrimaEdizioneDataGridViewTextBoxColumn
            // 
            this.annoPrimaEdizioneDataGridViewTextBoxColumn.DataPropertyName = "annoPrimaEdizione";
            this.annoPrimaEdizioneDataGridViewTextBoxColumn.HeaderText = "anno prima edizione";
            this.annoPrimaEdizioneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.annoPrimaEdizioneDataGridViewTextBoxColumn.Name = "annoPrimaEdizioneDataGridViewTextBoxColumn";
            this.annoPrimaEdizioneDataGridViewTextBoxColumn.Width = 376;
            // 
            // granpremiBindingSource
            // 
            this.granpremiBindingSource.DataMember = "gran_premi";
            this.granpremiBindingSource.DataSource = this.dataraceDataSet;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.buttonEseguiQueryCircuito);
            this.tabPage5.Controls.Add(this.textBoxCognomePilotaQueryCircuito);
            this.tabPage5.Controls.Add(this.labelCognomePilotaQueryCIrcuito);
            this.tabPage5.Controls.Add(this.textBoxNomePilotaQueryCircuito);
            this.tabPage5.Controls.Add(this.labelNomePilotaQueryCircuito);
            this.tabPage5.Controls.Add(this.comboBoxNomeClasseQueryCircuito);
            this.tabPage5.Controls.Add(this.labelNomeClasseQueryCircuito);
            this.tabPage5.Controls.Add(this.labelNomeCircuitoQuery);
            this.tabPage5.Controls.Add(this.comboBoxNomeCircuitoQuery);
            this.tabPage5.Controls.Add(this.comboBoxSceltaOperazioneCircuiti);
            this.tabPage5.Controls.Add(this.dataGridViewQueryCircuito);
            this.tabPage5.Controls.Add(this.separatoreCircuiti);
            this.tabPage5.Controls.Add(this.buttonAggiungiCircuito);
            this.tabPage5.Controls.Add(this.textBoxLunghezzaRettilineoCircuito);
            this.tabPage5.Controls.Add(this.labelLunghezzaRettilineoCircuito);
            this.tabPage5.Controls.Add(this.labelCurveADestraCircuito);
            this.tabPage5.Controls.Add(this.textBoxCurveADestraCircuito);
            this.tabPage5.Controls.Add(this.textBoxCurveASinistraCircuito);
            this.tabPage5.Controls.Add(this.labelCurveASinistraCircuito);
            this.tabPage5.Controls.Add(this.textBoxLunghezzaCircuito);
            this.tabPage5.Controls.Add(this.labelLunghezzaCircuito);
            this.tabPage5.Controls.Add(this.textBoxLocalitaCircuito);
            this.tabPage5.Controls.Add(this.textBoxNomeCircuito);
            this.tabPage5.Controls.Add(this.labelLocalitaCircuito);
            this.tabPage5.Controls.Add(this.labelNomeCircuito);
            this.tabPage5.Controls.Add(this.dataGridViewCircuiti);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1326, 458);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "circuiti";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // buttonEseguiQueryCircuito
            // 
            this.buttonEseguiQueryCircuito.Location = new System.Drawing.Point(261, 196);
            this.buttonEseguiQueryCircuito.Name = "buttonEseguiQueryCircuito";
            this.buttonEseguiQueryCircuito.Size = new System.Drawing.Size(93, 32);
            this.buttonEseguiQueryCircuito.TabIndex = 67;
            this.buttonEseguiQueryCircuito.Text = "Cerca";
            this.buttonEseguiQueryCircuito.UseVisualStyleBackColor = true;
            this.buttonEseguiQueryCircuito.Click += new System.EventHandler(this.ButtonEseguiQueryCircuito_Click);
            // 
            // textBoxCognomePilotaQueryCircuito
            // 
            this.textBoxCognomePilotaQueryCircuito.Location = new System.Drawing.Point(192, 147);
            this.textBoxCognomePilotaQueryCircuito.Name = "textBoxCognomePilotaQueryCircuito";
            this.textBoxCognomePilotaQueryCircuito.Size = new System.Drawing.Size(162, 22);
            this.textBoxCognomePilotaQueryCircuito.TabIndex = 66;
            // 
            // labelCognomePilotaQueryCIrcuito
            // 
            this.labelCognomePilotaQueryCIrcuito.AutoSize = true;
            this.labelCognomePilotaQueryCIrcuito.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelCognomePilotaQueryCIrcuito.Location = new System.Drawing.Point(189, 127);
            this.labelCognomePilotaQueryCIrcuito.Name = "labelCognomePilotaQueryCIrcuito";
            this.labelCognomePilotaQueryCIrcuito.Size = new System.Drawing.Size(106, 17);
            this.labelCognomePilotaQueryCIrcuito.TabIndex = 65;
            this.labelCognomePilotaQueryCIrcuito.Text = "Cognome pilota";
            // 
            // textBoxNomePilotaQueryCircuito
            // 
            this.textBoxNomePilotaQueryCircuito.Location = new System.Drawing.Point(9, 147);
            this.textBoxNomePilotaQueryCircuito.Name = "textBoxNomePilotaQueryCircuito";
            this.textBoxNomePilotaQueryCircuito.Size = new System.Drawing.Size(161, 22);
            this.textBoxNomePilotaQueryCircuito.TabIndex = 64;
            // 
            // labelNomePilotaQueryCircuito
            // 
            this.labelNomePilotaQueryCircuito.AutoSize = true;
            this.labelNomePilotaQueryCircuito.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelNomePilotaQueryCircuito.Location = new System.Drawing.Point(6, 127);
            this.labelNomePilotaQueryCircuito.Name = "labelNomePilotaQueryCircuito";
            this.labelNomePilotaQueryCircuito.Size = new System.Drawing.Size(83, 17);
            this.labelNomePilotaQueryCircuito.TabIndex = 63;
            this.labelNomePilotaQueryCircuito.Text = "Nome pilota";
            // 
            // comboBoxNomeClasseQueryCircuito
            // 
            this.comboBoxNomeClasseQueryCircuito.AllowDrop = true;
            this.comboBoxNomeClasseQueryCircuito.DropDownHeight = 100;
            this.comboBoxNomeClasseQueryCircuito.FormattingEnabled = true;
            this.comboBoxNomeClasseQueryCircuito.IntegralHeight = false;
            this.comboBoxNomeClasseQueryCircuito.Items.AddRange(new object[] {
            "Statistiche di carriera di un pilota",
            "Campionati disputati da un pilota nel corso della carriera"});
            this.comboBoxNomeClasseQueryCircuito.Location = new System.Drawing.Point(9, 201);
            this.comboBoxNomeClasseQueryCircuito.Name = "comboBoxNomeClasseQueryCircuito";
            this.comboBoxNomeClasseQueryCircuito.Size = new System.Drawing.Size(173, 24);
            this.comboBoxNomeClasseQueryCircuito.TabIndex = 62;
            // 
            // labelNomeClasseQueryCircuito
            // 
            this.labelNomeClasseQueryCircuito.AutoSize = true;
            this.labelNomeClasseQueryCircuito.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelNomeClasseQueryCircuito.Location = new System.Drawing.Point(6, 181);
            this.labelNomeClasseQueryCircuito.Name = "labelNomeClasseQueryCircuito";
            this.labelNomeClasseQueryCircuito.Size = new System.Drawing.Size(50, 17);
            this.labelNomeClasseQueryCircuito.TabIndex = 61;
            this.labelNomeClasseQueryCircuito.Text = "Classe";
            // 
            // labelNomeCircuitoQuery
            // 
            this.labelNomeCircuitoQuery.AutoSize = true;
            this.labelNomeCircuitoQuery.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelNomeCircuitoQuery.Location = new System.Drawing.Point(6, 70);
            this.labelNomeCircuitoQuery.Name = "labelNomeCircuitoQuery";
            this.labelNomeCircuitoQuery.Size = new System.Drawing.Size(55, 17);
            this.labelNomeCircuitoQuery.TabIndex = 60;
            this.labelNomeCircuitoQuery.Text = "Circuito";
            // 
            // comboBoxNomeCircuitoQuery
            // 
            this.comboBoxNomeCircuitoQuery.AllowDrop = true;
            this.comboBoxNomeCircuitoQuery.DropDownHeight = 100;
            this.comboBoxNomeCircuitoQuery.FormattingEnabled = true;
            this.comboBoxNomeCircuitoQuery.IntegralHeight = false;
            this.comboBoxNomeCircuitoQuery.Location = new System.Drawing.Point(9, 90);
            this.comboBoxNomeCircuitoQuery.Name = "comboBoxNomeCircuitoQuery";
            this.comboBoxNomeCircuitoQuery.Size = new System.Drawing.Size(345, 24);
            this.comboBoxNomeCircuitoQuery.TabIndex = 59;
            // 
            // comboBoxSceltaOperazioneCircuiti
            // 
            this.comboBoxSceltaOperazioneCircuiti.AllowDrop = true;
            this.comboBoxSceltaOperazioneCircuiti.DropDownHeight = 100;
            this.comboBoxSceltaOperazioneCircuiti.FormattingEnabled = true;
            this.comboBoxSceltaOperazioneCircuiti.IntegralHeight = false;
            this.comboBoxSceltaOperazioneCircuiti.Items.AddRange(new object[] {
            "Cerca il pilota più vincente sul circuito selezionato",
            "Tutti i risultati del pilota scelto nella data classe"});
            this.comboBoxSceltaOperazioneCircuiti.Location = new System.Drawing.Point(9, 5);
            this.comboBoxSceltaOperazioneCircuiti.Name = "comboBoxSceltaOperazioneCircuiti";
            this.comboBoxSceltaOperazioneCircuiti.Size = new System.Drawing.Size(345, 24);
            this.comboBoxSceltaOperazioneCircuiti.TabIndex = 58;
            this.comboBoxSceltaOperazioneCircuiti.Text = "Scegli operazione";
            this.comboBoxSceltaOperazioneCircuiti.SelectedIndexChanged += new System.EventHandler(ComboBoxSceltaOpCircuiti_SelectedIndexChanged);
            // 
            // dataGridViewQueryCircuito
            // 
            this.dataGridViewQueryCircuito.AllowUserToAddRows = false;
            this.dataGridViewQueryCircuito.AllowUserToDeleteRows = false;
            this.dataGridViewQueryCircuito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewQueryCircuito.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewQueryCircuito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQueryCircuito.Location = new System.Drawing.Point(9, 238);
            this.dataGridViewQueryCircuito.Name = "dataGridViewQueryCircuito";
            this.dataGridViewQueryCircuito.ReadOnly = true;
            this.dataGridViewQueryCircuito.RowHeadersVisible = false;
            this.dataGridViewQueryCircuito.RowHeadersWidth = 51;
            this.dataGridViewQueryCircuito.RowTemplate.Height = 24;
            this.dataGridViewQueryCircuito.Size = new System.Drawing.Size(345, 214);
            this.dataGridViewQueryCircuito.TabIndex = 55;
            // 
            // separatoreCircuiti
            // 
            this.separatoreCircuiti.BackColor = System.Drawing.Color.Black;
            this.separatoreCircuiti.Location = new System.Drawing.Point(363, 6);
            this.separatoreCircuiti.Name = "separatoreCircuiti";
            this.separatoreCircuiti.Size = new System.Drawing.Size(1, 447);
            this.separatoreCircuiti.TabIndex = 54;
            // 
            // buttonAggiungiCircuito
            // 
            this.buttonAggiungiCircuito.Location = new System.Drawing.Point(465, 382);
            this.buttonAggiungiCircuito.Name = "buttonAggiungiCircuito";
            this.buttonAggiungiCircuito.Size = new System.Drawing.Size(93, 32);
            this.buttonAggiungiCircuito.TabIndex = 53;
            this.buttonAggiungiCircuito.Text = "Aggiungi";
            this.buttonAggiungiCircuito.UseVisualStyleBackColor = true;
            this.buttonAggiungiCircuito.Click += new System.EventHandler(this.ButtonAggiungiCircuito_Click);
            // 
            // textBoxLunghezzaRettilineoCircuito
            // 
            this.textBoxLunghezzaRettilineoCircuito.Location = new System.Drawing.Point(373, 328);
            this.textBoxLunghezzaRettilineoCircuito.Name = "textBoxLunghezzaRettilineoCircuito";
            this.textBoxLunghezzaRettilineoCircuito.Size = new System.Drawing.Size(185, 22);
            this.textBoxLunghezzaRettilineoCircuito.TabIndex = 52;
            // 
            // labelLunghezzaRettilineoCircuito
            // 
            this.labelLunghezzaRettilineoCircuito.AutoSize = true;
            this.labelLunghezzaRettilineoCircuito.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelLunghezzaRettilineoCircuito.Location = new System.Drawing.Point(370, 308);
            this.labelLunghezzaRettilineoCircuito.Name = "labelLunghezzaRettilineoCircuito";
            this.labelLunghezzaRettilineoCircuito.Size = new System.Drawing.Size(181, 17);
            this.labelLunghezzaRettilineoCircuito.TabIndex = 51;
            this.labelLunghezzaRettilineoCircuito.Text = "Lunghezza rettilineo (metri)";
            // 
            // labelCurveADestraCircuito
            // 
            this.labelCurveADestraCircuito.AutoSize = true;
            this.labelCurveADestraCircuito.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelCurveADestraCircuito.Location = new System.Drawing.Point(370, 247);
            this.labelCurveADestraCircuito.Name = "labelCurveADestraCircuito";
            this.labelCurveADestraCircuito.Size = new System.Drawing.Size(101, 17);
            this.labelCurveADestraCircuito.TabIndex = 50;
            this.labelCurveADestraCircuito.Text = "Curve a destra";
            // 
            // textBoxCurveADestraCircuito
            // 
            this.textBoxCurveADestraCircuito.Location = new System.Drawing.Point(373, 267);
            this.textBoxCurveADestraCircuito.Name = "textBoxCurveADestraCircuito";
            this.textBoxCurveADestraCircuito.Size = new System.Drawing.Size(185, 22);
            this.textBoxCurveADestraCircuito.TabIndex = 49;
            // 
            // textBoxCurveASinistraCircuito
            // 
            this.textBoxCurveASinistraCircuito.Location = new System.Drawing.Point(373, 207);
            this.textBoxCurveASinistraCircuito.Name = "textBoxCurveASinistraCircuito";
            this.textBoxCurveASinistraCircuito.Size = new System.Drawing.Size(185, 22);
            this.textBoxCurveASinistraCircuito.TabIndex = 48;
            // 
            // labelCurveASinistraCircuito
            // 
            this.labelCurveASinistraCircuito.AutoSize = true;
            this.labelCurveASinistraCircuito.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelCurveASinistraCircuito.Location = new System.Drawing.Point(370, 187);
            this.labelCurveASinistraCircuito.Name = "labelCurveASinistraCircuito";
            this.labelCurveASinistraCircuito.Size = new System.Drawing.Size(106, 17);
            this.labelCurveASinistraCircuito.TabIndex = 47;
            this.labelCurveASinistraCircuito.Text = "Curve a sinistra";
            // 
            // textBoxLunghezzaCircuito
            // 
            this.textBoxLunghezzaCircuito.Location = new System.Drawing.Point(373, 149);
            this.textBoxLunghezzaCircuito.Name = "textBoxLunghezzaCircuito";
            this.textBoxLunghezzaCircuito.Size = new System.Drawing.Size(185, 22);
            this.textBoxLunghezzaCircuito.TabIndex = 44;
            // 
            // labelLunghezzaCircuito
            // 
            this.labelLunghezzaCircuito.AutoSize = true;
            this.labelLunghezzaCircuito.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelLunghezzaCircuito.Location = new System.Drawing.Point(370, 129);
            this.labelLunghezzaCircuito.Name = "labelLunghezzaCircuito";
            this.labelLunghezzaCircuito.Size = new System.Drawing.Size(123, 17);
            this.labelLunghezzaCircuito.TabIndex = 43;
            this.labelLunghezzaCircuito.Text = "Lunghezza (metri)";
            // 
            // textBoxLocalitaCircuito
            // 
            this.textBoxLocalitaCircuito.Location = new System.Drawing.Point(373, 92);
            this.textBoxLocalitaCircuito.Name = "textBoxLocalitaCircuito";
            this.textBoxLocalitaCircuito.Size = new System.Drawing.Size(185, 22);
            this.textBoxLocalitaCircuito.TabIndex = 42;
            // 
            // textBoxNomeCircuito
            // 
            this.textBoxNomeCircuito.Location = new System.Drawing.Point(373, 35);
            this.textBoxNomeCircuito.Name = "textBoxNomeCircuito";
            this.textBoxNomeCircuito.Size = new System.Drawing.Size(185, 22);
            this.textBoxNomeCircuito.TabIndex = 41;
            // 
            // labelLocalitaCircuito
            // 
            this.labelLocalitaCircuito.AutoSize = true;
            this.labelLocalitaCircuito.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelLocalitaCircuito.Location = new System.Drawing.Point(370, 71);
            this.labelLocalitaCircuito.Name = "labelLocalitaCircuito";
            this.labelLocalitaCircuito.Size = new System.Drawing.Size(57, 17);
            this.labelLocalitaCircuito.TabIndex = 40;
            this.labelLocalitaCircuito.Text = "Località";
            // 
            // labelNomeCircuito
            // 
            this.labelNomeCircuito.AutoSize = true;
            this.labelNomeCircuito.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelNomeCircuito.Location = new System.Drawing.Point(370, 15);
            this.labelNomeCircuito.Name = "labelNomeCircuito";
            this.labelNomeCircuito.Size = new System.Drawing.Size(45, 17);
            this.labelNomeCircuito.TabIndex = 39;
            this.labelNomeCircuito.Text = "Nome";
            // 
            // dataGridViewCircuiti
            // 
            this.dataGridViewCircuiti.AutoGenerateColumns = false;
            this.dataGridViewCircuiti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewCircuiti.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewCircuiti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCircuiti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeCircuito,
            this.localita,
            this.lunghezzaInMetri,
            this.numeroCurveSinistra,
            this.numeroCurveDestra,
            this.lunghezzaRettilineoInMetri});
            this.dataGridViewCircuiti.DataSource = this.circuitiBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCircuiti.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewCircuiti.Location = new System.Drawing.Point(564, 6);
            this.dataGridViewCircuiti.Name = "dataGridViewCircuiti";
            this.dataGridViewCircuiti.RowHeadersVisible = false;
            this.dataGridViewCircuiti.RowHeadersWidth = 51;
            this.dataGridViewCircuiti.RowTemplate.Height = 24;
            this.dataGridViewCircuiti.Size = new System.Drawing.Size(756, 446);
            this.dataGridViewCircuiti.TabIndex = 38;
            // 
            // nomeCircuito
            // 
            this.nomeCircuito.DataPropertyName = "nome";
            this.nomeCircuito.HeaderText = "nome";
            this.nomeCircuito.MinimumWidth = 6;
            this.nomeCircuito.Name = "nomeCircuito";
            this.nomeCircuito.Width = 72;
            // 
            // localita
            // 
            this.localita.DataPropertyName = "localita";
            this.localita.HeaderText = "località";
            this.localita.MinimumWidth = 6;
            this.localita.Name = "localita";
            this.localita.Width = 81;
            // 
            // lunghezzaInMetri
            // 
            this.lunghezzaInMetri.DataPropertyName = "lunghezzaInMetri";
            this.lunghezzaInMetri.HeaderText = "lunghezza (metri)";
            this.lunghezzaInMetri.MinimumWidth = 6;
            this.lunghezzaInMetri.Name = "lunghezzaInMetri";
            this.lunghezzaInMetri.Width = 135;
            // 
            // numeroCurveSinistra
            // 
            this.numeroCurveSinistra.DataPropertyName = "numeroCurveSinistra";
            this.numeroCurveSinistra.HeaderText = "curve a sinistra";
            this.numeroCurveSinistra.MinimumWidth = 6;
            this.numeroCurveSinistra.Name = "numeroCurveSinistra";
            this.numeroCurveSinistra.Width = 122;
            // 
            // numeroCurveDestra
            // 
            this.numeroCurveDestra.DataPropertyName = "numeroCurveDestra";
            this.numeroCurveDestra.HeaderText = "curve a destra";
            this.numeroCurveDestra.MinimumWidth = 6;
            this.numeroCurveDestra.Name = "numeroCurveDestra";
            this.numeroCurveDestra.Width = 118;
            // 
            // lunghezzaRettilineoInMetri
            // 
            this.lunghezzaRettilineoInMetri.DataPropertyName = "lunghezzaRettilineoInMetri";
            this.lunghezzaRettilineoInMetri.HeaderText = "lunghezza rettilineo principale (metri)";
            this.lunghezzaRettilineoInMetri.MinimumWidth = 6;
            this.lunghezzaRettilineoInMetri.Name = "lunghezzaRettilineoInMetri";
            this.lunghezzaRettilineoInMetri.Width = 208;
            // 
            // circuitiBindingSource
            // 
            this.circuitiBindingSource.DataMember = "circuiti";
            this.circuitiBindingSource.DataSource = this.dataraceDataSet;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1326, 458);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "gare";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(1326, 458);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "campionati";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.buttonInserisciProva);
            this.tabPage8.Controls.Add(this.dateTimePickerDataFineGP);
            this.tabPage8.Controls.Add(this.dateTimePickerDataInizioGP);
            this.tabPage8.Controls.Add(this.label8);
            this.tabPage8.Controls.Add(this.comboBoxNomeCircuitoQueryStagione);
            this.tabPage8.Controls.Add(this.label7);
            this.tabPage8.Controls.Add(this.label6);
            this.tabPage8.Controls.Add(this.comboBoxNomeGPQueryStagione);
            this.tabPage8.Controls.Add(this.label5);
            this.tabPage8.Controls.Add(this.separatoreCalendario);
            this.tabPage8.Controls.Add(this.buttonInserisciStagione);
            this.tabPage8.Controls.Add(this.label4);
            this.tabPage8.Controls.Add(this.textBoxNumeroProve);
            this.tabPage8.Controls.Add(this.label3);
            this.tabPage8.Controls.Add(this.buttonSelezioneStagioneCalendario);
            this.tabPage8.Controls.Add(this.comboBoxSelezioneStagione);
            this.tabPage8.Controls.Add(this.labelSelezioneStagione);
            this.tabPage8.Controls.Add(this.dataGridViewCalendario);
            this.tabPage8.Location = new System.Drawing.Point(4, 25);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(1326, 458);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "calendario gare";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // buttonInserisciProva
            // 
            this.buttonInserisciProva.Location = new System.Drawing.Point(316, 413);
            this.buttonInserisciProva.Name = "buttonInserisciProva";
            this.buttonInserisciProva.Size = new System.Drawing.Size(43, 32);
            this.buttonInserisciProva.TabIndex = 60;
            this.buttonInserisciProva.Text = "+";
            this.buttonInserisciProva.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerDataFineGP
            // 
            this.dateTimePickerDataFineGP.CustomFormat = "yyyy/MM/dd";
            this.dateTimePickerDataFineGP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDataFineGP.Location = new System.Drawing.Point(169, 416);
            this.dateTimePickerDataFineGP.Name = "dateTimePickerDataFineGP";
            this.dateTimePickerDataFineGP.Size = new System.Drawing.Size(127, 22);
            this.dateTimePickerDataFineGP.TabIndex = 59;
            // 
            // dateTimePickerDataInizioGP
            // 
            this.dateTimePickerDataInizioGP.CustomFormat = "yyyy/MM/dd";
            this.dateTimePickerDataInizioGP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDataInizioGP.Location = new System.Drawing.Point(9, 416);
            this.dateTimePickerDataInizioGP.Name = "dateTimePickerDataInizioGP";
            this.dateTimePickerDataInizioGP.Size = new System.Drawing.Size(127, 22);
            this.dateTimePickerDataInizioGP.TabIndex = 58;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 396);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 17);
            this.label8.TabIndex = 57;
            this.label8.Text = "Data inizio";
            // 
            // comboBoxNomeCircuitoQueryStagione
            // 
            this.comboBoxNomeCircuitoQueryStagione.FormattingEnabled = true;
            this.comboBoxNomeCircuitoQueryStagione.Location = new System.Drawing.Point(9, 358);
            this.comboBoxNomeCircuitoQueryStagione.Name = "comboBoxNomeCircuitoQueryStagione";
            this.comboBoxNomeCircuitoQueryStagione.Size = new System.Drawing.Size(350, 24);
            this.comboBoxNomeCircuitoQueryStagione.TabIndex = 56;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label7.Location = new System.Drawing.Point(6, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 55;
            this.label7.Text = "Circuito";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(166, 396);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 54;
            this.label6.Text = "Data fine";
            // 
            // comboBoxNomeGPQueryStagione
            // 
            this.comboBoxNomeGPQueryStagione.FormattingEnabled = true;
            this.comboBoxNomeGPQueryStagione.Location = new System.Drawing.Point(9, 296);
            this.comboBoxNomeGPQueryStagione.Name = "comboBoxNomeGPQueryStagione";
            this.comboBoxNomeGPQueryStagione.Size = new System.Drawing.Size(350, 24);
            this.comboBoxNomeGPQueryStagione.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label5.Location = new System.Drawing.Point(6, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 52;
            this.label5.Text = "Gran Premio";
            // 
            // separatoreCalendario
            // 
            this.separatoreCalendario.BackColor = System.Drawing.Color.Black;
            this.separatoreCalendario.Location = new System.Drawing.Point(8, 103);
            this.separatoreCalendario.Name = "separatoreCalendario";
            this.separatoreCalendario.Size = new System.Drawing.Size(358, 1);
            this.separatoreCalendario.TabIndex = 51;
            // 
            // buttonInserisciStagione
            // 
            this.buttonInserisciStagione.Location = new System.Drawing.Point(219, 233);
            this.buttonInserisciStagione.Name = "buttonInserisciStagione";
            this.buttonInserisciStagione.Size = new System.Drawing.Size(142, 32);
            this.buttonInserisciStagione.TabIndex = 50;
            this.buttonInserisciStagione.Text = "Inserisci stagione";
            this.buttonInserisciStagione.UseVisualStyleBackColor = true;
            this.buttonInserisciStagione.Click += new System.EventHandler(this.ButtonInserisciStagione_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 49;
            this.label4.Text = "Numero prove";
            // 
            // textBoxNumeroProve
            // 
            this.textBoxNumeroProve.Location = new System.Drawing.Point(9, 238);
            this.textBoxNumeroProve.Name = "textBoxNumeroProve";
            this.textBoxNumeroProve.Size = new System.Drawing.Size(192, 22);
            this.textBoxNumeroProve.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(341, 85);
            this.label3.TabIndex = 47;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // buttonSelezioneStagioneCalendario
            // 
            this.buttonSelezioneStagioneCalendario.Location = new System.Drawing.Point(268, 58);
            this.buttonSelezioneStagioneCalendario.Name = "buttonSelezioneStagioneCalendario";
            this.buttonSelezioneStagioneCalendario.Size = new System.Drawing.Size(93, 32);
            this.buttonSelezioneStagioneCalendario.TabIndex = 46;
            this.buttonSelezioneStagioneCalendario.Text = "Mostra";
            this.buttonSelezioneStagioneCalendario.UseVisualStyleBackColor = true;
            this.buttonSelezioneStagioneCalendario.Click += new System.EventHandler(this.ButtonSelezioneStagioneCalendario_Click);
            // 
            // comboBoxSelezioneStagione
            // 
            this.comboBoxSelezioneStagione.FormattingEnabled = true;
            this.comboBoxSelezioneStagione.Location = new System.Drawing.Point(9, 63);
            this.comboBoxSelezioneStagione.Name = "comboBoxSelezioneStagione";
            this.comboBoxSelezioneStagione.Size = new System.Drawing.Size(243, 24);
            this.comboBoxSelezioneStagione.TabIndex = 45;
            // 
            // labelSelezioneStagione
            // 
            this.labelSelezioneStagione.AutoSize = true;
            this.labelSelezioneStagione.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelezioneStagione.Location = new System.Drawing.Point(6, 6);
            this.labelSelezioneStagione.Name = "labelSelezioneStagione";
            this.labelSelezioneStagione.Size = new System.Drawing.Size(325, 51);
            this.labelSelezioneStagione.TabIndex = 44;
            this.labelSelezioneStagione.Text = "La tabella a lato mostra tutte le rimanenti prove \r\nper la stagione corrente. Sel" +
    "ezionare un anno nel \r\nbox sottostante per cambiare stagione:";
            // 
            // dataGridViewCalendario
            // 
            this.dataGridViewCalendario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewCalendario.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewCalendario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCalendario.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewCalendario.Location = new System.Drawing.Point(376, 6);
            this.dataGridViewCalendario.Name = "dataGridViewCalendario";
            this.dataGridViewCalendario.RowHeadersVisible = false;
            this.dataGridViewCalendario.RowHeadersWidth = 51;
            this.dataGridViewCalendario.RowTemplate.Height = 24;
            this.dataGridViewCalendario.Size = new System.Drawing.Size(944, 446);
            this.dataGridViewCalendario.TabIndex = 25;
            // 
            // proveBindingSource
            // 
            this.proveBindingSource.DataMember = "prove";
            this.proveBindingSource.DataSource = this.dataraceDataSet;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "paese";
            this.dataGridViewTextBoxColumn3.HeaderText = "paese";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "tipo";
            this.dataGridViewTextBoxColumn4.HeaderText = "tipo";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // pilotiTableAdapter
            // 
            this.pilotiTableAdapter.ClearBeforeFill = true;
            // 
            // teamTableAdapter
            // 
            this.teamTableAdapter.ClearBeforeFill = true;
            // 
            // costruttoriTableAdapter
            // 
            this.costruttoriTableAdapter.ClearBeforeFill = true;
            // 
            // gran_premiTableAdapter
            // 
            this.gran_premiTableAdapter.ClearBeforeFill = true;
            // 
            // idGranPremioDataGridViewTextBoxColumn
            // 
            this.idGranPremioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idGranPremioDataGridViewTextBoxColumn.Name = "idGranPremioDataGridViewTextBoxColumn";
            this.idGranPremioDataGridViewTextBoxColumn.Width = 125;
            // 
            // proveTableAdapter
            // 
            this.proveTableAdapter.ClearBeforeFill = true;
            // 
            // annoDataGridViewTextBoxColumn
            // 
            this.annoDataGridViewTextBoxColumn.DataPropertyName = "anno";
            this.annoDataGridViewTextBoxColumn.HeaderText = "anno";
            this.annoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.annoDataGridViewTextBoxColumn.Name = "annoDataGridViewTextBoxColumn";
            this.annoDataGridViewTextBoxColumn.Width = 125;
            // 
            // granPremioDataGridViewTextBoxColumn
            // 
            this.granPremioDataGridViewTextBoxColumn.DataPropertyName = "granPremio";
            this.granPremioDataGridViewTextBoxColumn.HeaderText = "granPremio";
            this.granPremioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.granPremioDataGridViewTextBoxColumn.Name = "granPremioDataGridViewTextBoxColumn";
            this.granPremioDataGridViewTextBoxColumn.Width = 125;
            // 
            // numeroSpettatoriDataGridViewTextBoxColumn
            // 
            this.numeroSpettatoriDataGridViewTextBoxColumn.DataPropertyName = "numeroSpettatori";
            this.numeroSpettatoriDataGridViewTextBoxColumn.HeaderText = "numeroSpettatori";
            this.numeroSpettatoriDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeroSpettatoriDataGridViewTextBoxColumn.Name = "numeroSpettatoriDataGridViewTextBoxColumn";
            this.numeroSpettatoriDataGridViewTextBoxColumn.Width = 125;
            // 
            // circuitiTableAdapter
            // 
            this.circuitiTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 491);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQueryPiloti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPiloti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataraceDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQueryCostruttori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCostruttori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costruttoriBindingSource)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQueryGP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGranPremi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.granpremiBindingSource)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQueryCircuito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCircuiti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circuitiBindingSource)).EndInit();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalendario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveBindingSource)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxNomePilota;
        private System.Windows.Forms.DataGridView dataGridViewPiloti;
        private System.Windows.Forms.Button buttonAggiungiPilota;
        private dataraceDataSet dataraceDataSet;
        private System.Windows.Forms.BindingSource pilotiBindingSource;
        private dataraceDataSetTableAdapters.pilotiTableAdapter pilotiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cognomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn luogoDiNascitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazionalitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDiNascitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridViewTeam;
        private System.Windows.Forms.BindingSource teamBindingSource;
        private dataraceDataSetTableAdapters.teamTableAdapter teamTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn paese;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.Label labelNomePilota;
        private System.Windows.Forms.Label labelDataDiNascita;
        private System.Windows.Forms.Label labelNazionalitaPilota;
        private System.Windows.Forms.TextBox textBoxLuogoDiNascita;
        private System.Windows.Forms.Label labelLuogoDiNascita;
        private System.Windows.Forms.TextBox textBoxCognomePilota;
        private System.Windows.Forms.Label labelCognomePilota;
        private System.Windows.Forms.Button buttonRicercaPiloti;
        private System.Windows.Forms.TextBox textBoxCognomeRicercaPiloti;
        private System.Windows.Forms.TextBox textBoxNomeRicercaPiloti;
        private System.Windows.Forms.Label labelNomeRicercaPilota;
        private System.Windows.Forms.Label labelCognomeRicercaPilota;
        private System.Windows.Forms.DataGridView dataGridViewQueryPiloti;
        private System.Windows.Forms.ComboBox comboBoxSceltaQueryPiloti;
        private System.Windows.Forms.DateTimePicker dataDiNascitaPicker;
        private System.Windows.Forms.TextBox textBoxNomeUfficialeTeam;
        private System.Windows.Forms.Label labelNomeRicercaTeam;
        private System.Windows.Forms.ComboBox comboBoxPaeseTeam;
        private System.Windows.Forms.Label labelPaeseTeam;
        private System.Windows.Forms.TextBox textBoxNomeTeam;
        private System.Windows.Forms.Label labelNomeTeam;
        private System.Windows.Forms.ComboBox comboBoxNazionalita;
        private System.Windows.Forms.ComboBox comboBoxTipoTeam;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label separatoreViewPiloti;
        private System.Windows.Forms.Label labelClassiTeam;
        private System.Windows.Forms.CheckedListBox checkedListBoxClassiTeam;
        private System.Windows.Forms.TextBox textBoxTeamManager;
        private System.Windows.Forms.Label labelTeamManager;
        private System.Windows.Forms.Label labelNomeUfficialeTeam;
        private System.Windows.Forms.Label separatoreViewTeam;
        private System.Windows.Forms.ComboBox comboBoxNomeRicercaTeam;
        private System.Windows.Forms.Button buttonAggiungiTeam;
        private System.Windows.Forms.Label labelSpiegazioneQueryTeam;
        private System.Windows.Forms.Button buttonQueryTeam;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.DataGridView dataGridViewCostruttori;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn paeseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn annoDiEsordioGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource costruttoriBindingSource;
        private dataraceDataSetTableAdapters.costruttoriTableAdapter costruttoriTableAdapter;
        private System.Windows.Forms.Label separatoreViewCostruttori;
        private System.Windows.Forms.Button buttonAggiungiCostruttore;
        private System.Windows.Forms.TextBox textBoxAnnoDiEsordioCostruttore;
        private System.Windows.Forms.Label labelAnnoDiEsordioCostruttore;
        private System.Windows.Forms.ComboBox comboBoxPaeseCostruttore;
        private System.Windows.Forms.Label labelPaeseCostruttore;
        private System.Windows.Forms.TextBox textBoxNomeCostruttore;
        private System.Windows.Forms.Label labelNomeCostruttore;
        private System.Windows.Forms.Label labelNomeModello;
        private System.Windows.Forms.ComboBox comboBoxNomeInserimentoCostruttore;
        private System.Windows.Forms.Label labelNomeInserimentoCostruttore;
        private System.Windows.Forms.Label labelQueryInserimentoModelli;
        private System.Windows.Forms.DataGridView dataGridViewQueryCostruttori;
        private System.Windows.Forms.ComboBox comboBoxNomeRicercaCostruttore;
        private System.Windows.Forms.Label labelNomeRicercaCostruttore;
        private System.Windows.Forms.Label labelQueryVisualizzazioneModelli;
        private System.Windows.Forms.Button buttonRegistraModello;
        private System.Windows.Forms.TextBox textBoxQueryModello;
        private System.Windows.Forms.Button buttonRicercaModelli;
        private System.Windows.Forms.DataGridView dataGridViewGranPremi;
        private System.Windows.Forms.BindingSource granpremiBindingSource;
        private dataraceDataSetTableAdapters.gran_premiTableAdapter gran_premiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGranPremioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denominazioneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn annoPrimaEdizioneDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label labelRicercaGP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAggiungiGP;
        private System.Windows.Forms.TextBox textBoxDenominazioneGP;
        private System.Windows.Forms.Label labelDenominazioneGP;
        private System.Windows.Forms.DataGridView dataGridViewQueryGP;
        private System.Windows.Forms.ComboBox comboBoxRicercaClasse;
        private System.Windows.Forms.Label labelNomeRicercaClasse;
        private System.Windows.Forms.Button buttonRicercaGP;
        private System.Windows.Forms.ComboBox comboBoxRicercaGP;
        private System.Windows.Forms.Label labelNomeRicercaGP;
        private System.Windows.Forms.Label labelSelezioneStagione;
        private System.Windows.Forms.DataGridView dataGridViewCalendario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label separatoreCalendario;
        private System.Windows.Forms.Button buttonInserisciStagione;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNumeroProve;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSelezioneStagioneCalendario;
        private System.Windows.Forms.ComboBox comboBoxSelezioneStagione;
        private System.Windows.Forms.Button buttonInserisciProva;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataFineGP;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataInizioGP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxNomeCircuitoQueryStagione;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxNomeGPQueryStagione;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource proveBindingSource;
        private dataraceDataSetTableAdapters.proveTableAdapter proveTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn annoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn granPremioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroSpettatoriDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource circuitiBindingSource;
        private dataraceDataSetTableAdapters.circuitiTableAdapter circuitiTableAdapter;
        private DataGridView dataGridViewCircuiti;
        private DataGridViewTextBoxColumn nomeCircuito;
        private DataGridViewTextBoxColumn localita;
        private DataGridViewTextBoxColumn lunghezzaInMetri;
        private DataGridViewTextBoxColumn numeroCurveSinistra;
        private DataGridViewTextBoxColumn numeroCurveDestra;
        private DataGridViewTextBoxColumn lunghezzaRettilineoInMetri;
        private DataGridView dataGridViewQueryCircuito;
        private Label separatoreCircuiti;
        private Button buttonAggiungiCircuito;
        private TextBox textBoxLunghezzaRettilineoCircuito;
        private Label labelLunghezzaRettilineoCircuito;
        private Label labelCurveADestraCircuito;
        private TextBox textBoxCurveADestraCircuito;
        private TextBox textBoxCurveASinistraCircuito;
        private Label labelCurveASinistraCircuito;
        private TextBox textBoxLunghezzaCircuito;
        private Label labelLunghezzaCircuito;
        private TextBox textBoxLocalitaCircuito;
        private TextBox textBoxNomeCircuito;
        private Label labelLocalitaCircuito;
        private Label labelNomeCircuito;
        private Label labelNomeCircuitoQuery;
        private ComboBox comboBoxNomeCircuitoQuery;
        private ComboBox comboBoxSceltaOperazioneCircuiti;
        private Button buttonEseguiQueryCircuito;
        private TextBox textBoxCognomePilotaQueryCircuito;
        private Label labelCognomePilotaQueryCIrcuito;
        private TextBox textBoxNomePilotaQueryCircuito;
        private Label labelNomePilotaQueryCircuito;
        private ComboBox comboBoxNomeClasseQueryCircuito;
        private Label labelNomeClasseQueryCircuito;
    }
}

