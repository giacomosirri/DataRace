
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.label14 = new System.Windows.Forms.Label();
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
            this.pilotiTableAdapter = new datarace.dataraceDataSetTableAdapters.pilotiTableAdapter();
            this.teamTableAdapter = new datarace.dataraceDataSetTableAdapters.teamTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQueryPiloti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPiloti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataraceDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
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
            this.comboBoxNazionalita.TabIndex = 25;
            // 
            // dataDiNascitaPicker
            // 
            this.dataDiNascitaPicker.CustomFormat = "yyyy/MM/dd";
            this.dataDiNascitaPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataDiNascitaPicker.Location = new System.Drawing.Point(411, 261);
            this.dataDiNascitaPicker.Name = "dataDiNascitaPicker";
            this.dataDiNascitaPicker.Size = new System.Drawing.Size(147, 22);
            this.dataDiNascitaPicker.TabIndex = 24;
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
            this.comboBoxSceltaQueryPiloti.Size = new System.Drawing.Size(379, 24);
            this.comboBoxSceltaQueryPiloti.TabIndex = 23;
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
            this.dataGridViewQueryPiloti.Size = new System.Drawing.Size(379, 309);
            this.dataGridViewQueryPiloti.TabIndex = 22;
            // 
            // buttonRicercaPiloti
            // 
            this.buttonRicercaPiloti.Location = new System.Drawing.Point(288, 99);
            this.buttonRicercaPiloti.Name = "buttonRicercaPiloti";
            this.buttonRicercaPiloti.Size = new System.Drawing.Size(100, 30);
            this.buttonRicercaPiloti.TabIndex = 21;
            this.buttonRicercaPiloti.Text = "Cerca";
            this.buttonRicercaPiloti.UseVisualStyleBackColor = true;
            this.buttonRicercaPiloti.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxCognomeRicercaPiloti
            // 
            this.textBoxCognomeRicercaPiloti.Location = new System.Drawing.Point(153, 103);
            this.textBoxCognomeRicercaPiloti.Name = "textBoxCognomeRicercaPiloti";
            this.textBoxCognomeRicercaPiloti.Size = new System.Drawing.Size(124, 22);
            this.textBoxCognomeRicercaPiloti.TabIndex = 20;
            // 
            // textBoxNomeRicercaPiloti
            // 
            this.textBoxNomeRicercaPiloti.Location = new System.Drawing.Point(9, 103);
            this.textBoxNomeRicercaPiloti.Name = "textBoxNomeRicercaPiloti";
            this.textBoxNomeRicercaPiloti.Size = new System.Drawing.Size(124, 22);
            this.textBoxNomeRicercaPiloti.TabIndex = 17;
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
            this.textBoxLuogoDiNascita.TabIndex = 8;
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
            this.textBoxCognomePilota.TabIndex = 5;
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
            this.buttonAggiungiPilota.TabIndex = 2;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPiloti.DefaultCellStyle = dataGridViewCellStyle4;
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
            this.tabPage2.Controls.Add(this.label14);
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
            this.buttonQueryTeam.Location = new System.Drawing.Point(264, 407);
            this.buttonQueryTeam.Name = "buttonQueryTeam";
            this.buttonQueryTeam.Size = new System.Drawing.Size(93, 32);
            this.buttonQueryTeam.TabIndex = 45;
            this.buttonQueryTeam.Text = "Aggiungi";
            this.buttonQueryTeam.UseVisualStyleBackColor = true;
            // 
            // labelClassiTeam
            // 
            this.labelClassiTeam.AutoSize = true;
            this.labelClassiTeam.Location = new System.Drawing.Point(12, 259);
            this.labelClassiTeam.Name = "labelClassiTeam";
            this.labelClassiTeam.Size = new System.Drawing.Size(45, 17);
            this.labelClassiTeam.TabIndex = 44;
            this.labelClassiTeam.Text = "Classi";
            // 
            // checkedListBoxClassiTeam
            // 
            this.checkedListBoxClassiTeam.FormattingEnabled = true;
            this.checkedListBoxClassiTeam.Location = new System.Drawing.Point(12, 282);
            this.checkedListBoxClassiTeam.Name = "checkedListBoxClassiTeam";
            this.checkedListBoxClassiTeam.Size = new System.Drawing.Size(231, 157);
            this.checkedListBoxClassiTeam.TabIndex = 43;
            // 
            // textBoxTeamManager
            // 
            this.textBoxTeamManager.Location = new System.Drawing.Point(12, 225);
            this.textBoxTeamManager.Name = "textBoxTeamManager";
            this.textBoxTeamManager.Size = new System.Drawing.Size(231, 22);
            this.textBoxTeamManager.TabIndex = 42;
            // 
            // labelTeamManager
            // 
            this.labelTeamManager.AutoSize = true;
            this.labelTeamManager.Location = new System.Drawing.Point(9, 205);
            this.labelTeamManager.Name = "labelTeamManager";
            this.labelTeamManager.Size = new System.Drawing.Size(104, 17);
            this.labelTeamManager.TabIndex = 41;
            this.labelTeamManager.Text = "Team manager";
            // 
            // labelNomeUfficialeTeam
            // 
            this.labelNomeUfficialeTeam.AutoSize = true;
            this.labelNomeUfficialeTeam.Location = new System.Drawing.Point(9, 146);
            this.labelNomeUfficialeTeam.Name = "labelNomeUfficialeTeam";
            this.labelNomeUfficialeTeam.Size = new System.Drawing.Size(97, 17);
            this.labelNomeUfficialeTeam.TabIndex = 40;
            this.labelNomeUfficialeTeam.Text = "Nome ufficiale";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(363, 5);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(1, 447);
            this.label14.TabIndex = 39;
            // 
            // comboBoxNomeRicercaTeam
            // 
            this.comboBoxNomeRicercaTeam.FormattingEnabled = true;
            this.comboBoxNomeRicercaTeam.Location = new System.Drawing.Point(12, 109);
            this.comboBoxNomeRicercaTeam.Name = "comboBoxNomeRicercaTeam";
            this.comboBoxNomeRicercaTeam.Size = new System.Drawing.Size(345, 24);
            this.comboBoxNomeRicercaTeam.TabIndex = 38;
            // 
            // buttonAggiungiTeam
            // 
            this.buttonAggiungiTeam.Location = new System.Drawing.Point(465, 197);
            this.buttonAggiungiTeam.Name = "buttonAggiungiTeam";
            this.buttonAggiungiTeam.Size = new System.Drawing.Size(93, 32);
            this.buttonAggiungiTeam.TabIndex = 37;
            this.buttonAggiungiTeam.Text = "Aggiungi";
            this.buttonAggiungiTeam.UseVisualStyleBackColor = true;
            // 
            // labelSpiegazioneQueryTeam
            // 
            this.labelSpiegazioneQueryTeam.AutoSize = true;
            this.labelSpiegazioneQueryTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpiegazioneQueryTeam.Location = new System.Drawing.Point(9, 6);
            this.labelSpiegazioneQueryTeam.Name = "labelSpiegazioneQueryTeam";
            this.labelSpiegazioneQueryTeam.Size = new System.Drawing.Size(327, 68);
            this.labelSpiegazioneQueryTeam.TabIndex = 36;
            this.labelSpiegazioneQueryTeam.Text = resources.GetString("labelSpiegazioneQueryTeam.Text");
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
            this.comboBoxTipoTeam.TabIndex = 34;
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
            this.comboBoxPaeseTeam.TabIndex = 32;
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
            this.textBoxNomeTeam.TabIndex = 29;
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
            this.textBoxNomeUfficialeTeam.Location = new System.Drawing.Point(12, 166);
            this.textBoxNomeUfficialeTeam.Name = "textBoxNomeUfficialeTeam";
            this.textBoxNomeUfficialeTeam.Size = new System.Drawing.Size(231, 22);
            this.textBoxNomeUfficialeTeam.TabIndex = 27;
            // 
            // labelNomeRicercaTeam
            // 
            this.labelNomeRicercaTeam.AutoSize = true;
            this.labelNomeRicercaTeam.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelNomeRicercaTeam.Location = new System.Drawing.Point(9, 88);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTeam.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTeam.Location = new System.Drawing.Point(564, 6);
            this.dataGridViewTeam.Name = "dataGridViewTeam";
            this.dataGridViewTeam.RowHeadersVisible = false;
            this.dataGridViewTeam.RowHeadersWidth = 51;
            this.dataGridViewTeam.RowTemplate.Height = 24;
            this.dataGridViewTeam.Size = new System.Drawing.Size(756, 446);
            this.dataGridViewTeam.TabIndex = 1;
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
            // pilotiTableAdapter
            // 
            this.pilotiTableAdapter.ClearBeforeFill = true;
            // 
            // teamTableAdapter
            // 
            this.teamTableAdapter.ClearBeforeFill = true;
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
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBoxNomeRicercaTeam;
        private System.Windows.Forms.Button buttonAggiungiTeam;
        private System.Windows.Forms.Label labelSpiegazioneQueryTeam;
        private System.Windows.Forms.Button buttonQueryTeam;
    }
}

