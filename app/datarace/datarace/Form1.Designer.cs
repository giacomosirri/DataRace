
using System;
using System.Collections.Generic;
using System.Globalization;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.pilotiTableAdapter = new datarace.dataraceDataSetTableAdapters.pilotiTableAdapter();
            this.teamTableAdapter = new datarace.dataraceDataSetTableAdapters.teamTableAdapter();
            this.costruttoriTableAdapter = new datarace.dataraceDataSetTableAdapters.costruttoriTableAdapter();
            this.gran_premiTableAdapter = new datarace.dataraceDataSetTableAdapters.gran_premiTableAdapter();
            this.idGranPremioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPiloti.DefaultCellStyle = dataGridViewCellStyle6;
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
    "arteciperà ";
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTeam.DefaultCellStyle = dataGridViewCellStyle7;
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
    "ipato ad almeno una\r\nprova nella storia";
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
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCostruttori.DefaultCellStyle = dataGridViewCellStyle8;
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
            this.labelRicercaGP.Size = new System.Drawing.Size(438, 17);
            this.labelRicercaGP.TabIndex = 43;
            this.labelRicercaGP.Text = "Seleziona un gran premio e una classe per visualizzarne l\'albo d\'oro";
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewGranPremi.DefaultCellStyle = dataGridViewCellStyle5;
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
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1326, 458);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "circuiti";
            this.tabPage5.UseVisualStyleBackColor = true;
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
            this.tabPage8.Location = new System.Drawing.Point(4, 25);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(1326, 458);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "calendario";
            this.tabPage8.UseVisualStyleBackColor = true;
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
    }
}

