namespace YAKUZA
{
    partial class FormStartAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStartAdmin));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageTools = new System.Windows.Forms.TabPage();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttonSite = new System.Windows.Forms.Button();
            this.buttonLoc = new System.Windows.Forms.Button();
            this.buttonString = new System.Windows.Forms.Button();
            this.buttonPath = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.tabPageAP = new System.Windows.Forms.TabPage();
            this.buttonPhotoOpen = new System.Windows.Forms.Button();
            this.buttonUpdatePers = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDPersonajDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Locatie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_Familie = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.familiiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yakuzaDataSet1 = new YAKUZA.yakuzaDataSet();
            this.Cod_Stil = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.stiluriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Nivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bani = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Path_Poza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personajeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yakuzaDataSet = new YAKUZA.yakuzaDataSet();
            this.tabPageAS = new System.Windows.Forms.TabPage();
            this.buttonUpdateSty = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.codStilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vitezaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.putereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stiluriBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageAF = new System.Windows.Forms.TabPage();
            this.buttonUpdateFam = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.codFamilieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.liderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrMembriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.afiliereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familiiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.personajeTableAdapter = new YAKUZA.yakuzaDataSetTableAdapters.PersonajeTableAdapter();
            this.stiluriTableAdapter = new YAKUZA.yakuzaDataSetTableAdapters.StiluriTableAdapter();
            this.familiiTableAdapter = new YAKUZA.yakuzaDataSetTableAdapters.FamiliiTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPageTools.SuspendLayout();
            this.tabPageAP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familiiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yakuzaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stiluriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personajeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yakuzaDataSet)).BeginInit();
            this.tabPageAS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stiluriBindingSource1)).BeginInit();
            this.tabPageAF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familiiBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageTools);
            this.tabControl1.Controls.Add(this.tabPageAP);
            this.tabControl1.Controls.Add(this.tabPageAS);
            this.tabControl1.Controls.Add(this.tabPageAF);
            this.tabControl1.Location = new System.Drawing.Point(14, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1292, 758);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageTools
            // 
            this.tabPageTools.BackColor = System.Drawing.Color.DimGray;
            this.tabPageTools.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPageTools.BackgroundImage")));
            this.tabPageTools.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageTools.Controls.Add(this.buttonInfo);
            this.tabPageTools.Controls.Add(this.buttonSite);
            this.tabPageTools.Controls.Add(this.buttonLoc);
            this.tabPageTools.Controls.Add(this.buttonString);
            this.tabPageTools.Controls.Add(this.buttonPath);
            this.tabPageTools.Controls.Add(this.buttonReset);
            this.tabPageTools.Location = new System.Drawing.Point(28, 4);
            this.tabPageTools.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageTools.Name = "tabPageTools";
            this.tabPageTools.Size = new System.Drawing.Size(1260, 750);
            this.tabPageTools.TabIndex = 4;
            this.tabPageTools.Text = "Unelte Speciale";
            this.tabPageTools.Click += new System.EventHandler(this.tabPageTools_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.Font = new System.Drawing.Font("Edo SZ", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInfo.Location = new System.Drawing.Point(0, 250);
            this.buttonInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(583, 59);
            this.buttonInfo.TabIndex = 7;
            this.buttonInfo.Text = "Vezi Informatii Aplicatie";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // buttonSite
            // 
            this.buttonSite.Font = new System.Drawing.Font("Edo SZ", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSite.Location = new System.Drawing.Point(3, 316);
            this.buttonSite.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSite.Name = "buttonSite";
            this.buttonSite.Size = new System.Drawing.Size(583, 59);
            this.buttonSite.TabIndex = 6;
            this.buttonSite.Text = "Site Fotografii Yakuza";
            this.buttonSite.UseVisualStyleBackColor = true;
            this.buttonSite.Click += new System.EventHandler(this.buttonSite_Click);
            // 
            // buttonLoc
            // 
            this.buttonLoc.Font = new System.Drawing.Font("Edo SZ", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoc.Location = new System.Drawing.Point(3, 382);
            this.buttonLoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLoc.Name = "buttonLoc";
            this.buttonLoc.Size = new System.Drawing.Size(583, 59);
            this.buttonLoc.TabIndex = 5;
            this.buttonLoc.Text = "Deschide locatia aplicatiei";
            this.buttonLoc.UseVisualStyleBackColor = true;
            this.buttonLoc.Click += new System.EventHandler(this.buttonLoc_Click);
            // 
            // buttonString
            // 
            this.buttonString.Font = new System.Drawing.Font("Edo SZ", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonString.Location = new System.Drawing.Point(0, 515);
            this.buttonString.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonString.Name = "buttonString";
            this.buttonString.Size = new System.Drawing.Size(586, 59);
            this.buttonString.TabIndex = 2;
            this.buttonString.Text = "Vezi Connection String-ul";
            this.buttonString.UseVisualStyleBackColor = true;
            this.buttonString.Click += new System.EventHandler(this.buttonString_Click);
            // 
            // buttonPath
            // 
            this.buttonPath.Font = new System.Drawing.Font("Edo SZ", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPath.Location = new System.Drawing.Point(3, 449);
            this.buttonPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonPath.Name = "buttonPath";
            this.buttonPath.Size = new System.Drawing.Size(586, 59);
            this.buttonPath.TabIndex = 1;
            this.buttonPath.Text = "Vezi Path-ul Aplicatiei";
            this.buttonPath.UseVisualStyleBackColor = true;
            this.buttonPath.Click += new System.EventHandler(this.buttonPath_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Edo SZ", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(0, 581);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(586, 166);
            this.buttonReset.TabIndex = 0;
            this.buttonReset.Text = "RESETEAZA \r\nBAZA DE DATE";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // tabPageAP
            // 
            this.tabPageAP.Controls.Add(this.buttonPhotoOpen);
            this.tabPageAP.Controls.Add(this.buttonUpdatePers);
            this.tabPageAP.Controls.Add(this.dataGridView1);
            this.tabPageAP.Location = new System.Drawing.Point(28, 4);
            this.tabPageAP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageAP.Name = "tabPageAP";
            this.tabPageAP.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageAP.Size = new System.Drawing.Size(1260, 750);
            this.tabPageAP.TabIndex = 0;
            this.tabPageAP.Text = "Admin - Personaje";
            this.tabPageAP.UseVisualStyleBackColor = true;
            // 
            // buttonPhotoOpen
            // 
            this.buttonPhotoOpen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonPhotoOpen.Location = new System.Drawing.Point(3, 652);
            this.buttonPhotoOpen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonPhotoOpen.Name = "buttonPhotoOpen";
            this.buttonPhotoOpen.Size = new System.Drawing.Size(1254, 50);
            this.buttonPhotoOpen.TabIndex = 2;
            this.buttonPhotoOpen.Text = "Deschide PersPhotoResources";
            this.buttonPhotoOpen.UseVisualStyleBackColor = true;
            this.buttonPhotoOpen.Click += new System.EventHandler(this.buttonPhotoOpen_Click);
            // 
            // buttonUpdatePers
            // 
            this.buttonUpdatePers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonUpdatePers.Location = new System.Drawing.Point(3, 702);
            this.buttonUpdatePers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonUpdatePers.Name = "buttonUpdatePers";
            this.buttonUpdatePers.Size = new System.Drawing.Size(1254, 44);
            this.buttonUpdatePers.TabIndex = 1;
            this.buttonUpdatePers.Text = "UPDATE";
            this.buttonUpdatePers.UseVisualStyleBackColor = true;
            this.buttonUpdatePers.Click += new System.EventHandler(this.buttonUpdatePers_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPersonajDataGridViewTextBoxColumn,
            this.numeDataGridViewTextBoxColumn,
            this.Locatie,
            this.Cod_Familie,
            this.Cod_Stil,
            this.Nivel,
            this.Bani,
            this.Path_Poza});
            this.dataGridView1.DataSource = this.personajeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 8);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1245, 585);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDPersonajDataGridViewTextBoxColumn
            // 
            this.iDPersonajDataGridViewTextBoxColumn.DataPropertyName = "ID_Personaj";
            this.iDPersonajDataGridViewTextBoxColumn.HeaderText = "ID_Personaj";
            this.iDPersonajDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDPersonajDataGridViewTextBoxColumn.Name = "iDPersonajDataGridViewTextBoxColumn";
            this.iDPersonajDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDPersonajDataGridViewTextBoxColumn.Width = 125;
            // 
            // numeDataGridViewTextBoxColumn
            // 
            this.numeDataGridViewTextBoxColumn.DataPropertyName = "Nume";
            this.numeDataGridViewTextBoxColumn.HeaderText = "Nume";
            this.numeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
            this.numeDataGridViewTextBoxColumn.Width = 125;
            // 
            // Locatie
            // 
            this.Locatie.DataPropertyName = "Locatie";
            this.Locatie.HeaderText = "Locatie";
            this.Locatie.MinimumWidth = 6;
            this.Locatie.Name = "Locatie";
            this.Locatie.Width = 125;
            // 
            // Cod_Familie
            // 
            this.Cod_Familie.DataPropertyName = "Cod_Familie";
            this.Cod_Familie.DataSource = this.familiiBindingSource;
            this.Cod_Familie.DisplayMember = "Nume";
            this.Cod_Familie.HeaderText = "Cod_Familie";
            this.Cod_Familie.MinimumWidth = 6;
            this.Cod_Familie.Name = "Cod_Familie";
            this.Cod_Familie.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Cod_Familie.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Cod_Familie.ValueMember = "Cod_Familie";
            this.Cod_Familie.Width = 125;
            // 
            // familiiBindingSource
            // 
            this.familiiBindingSource.DataMember = "Familii";
            this.familiiBindingSource.DataSource = this.yakuzaDataSet1;
            // 
            // yakuzaDataSet1
            // 
            this.yakuzaDataSet1.DataSetName = "yakuzaDataSet";
            this.yakuzaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Cod_Stil
            // 
            this.Cod_Stil.DataPropertyName = "Cod_Stil";
            this.Cod_Stil.DataSource = this.stiluriBindingSource;
            this.Cod_Stil.DisplayMember = "Nume";
            this.Cod_Stil.HeaderText = "Cod_Stil";
            this.Cod_Stil.MinimumWidth = 6;
            this.Cod_Stil.Name = "Cod_Stil";
            this.Cod_Stil.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Cod_Stil.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Cod_Stil.ValueMember = "Cod_Stil";
            this.Cod_Stil.Width = 125;
            // 
            // stiluriBindingSource
            // 
            this.stiluriBindingSource.DataMember = "Stiluri";
            this.stiluriBindingSource.DataSource = this.yakuzaDataSet1;
            // 
            // Nivel
            // 
            this.Nivel.DataPropertyName = "Nivel";
            this.Nivel.HeaderText = "Nivel";
            this.Nivel.MinimumWidth = 6;
            this.Nivel.Name = "Nivel";
            this.Nivel.Width = 125;
            // 
            // Bani
            // 
            this.Bani.DataPropertyName = "Bani";
            this.Bani.HeaderText = "Bani";
            this.Bani.MinimumWidth = 6;
            this.Bani.Name = "Bani";
            this.Bani.Width = 125;
            // 
            // Path_Poza
            // 
            this.Path_Poza.DataPropertyName = "Path_Poza";
            this.Path_Poza.HeaderText = "Path_Poza";
            this.Path_Poza.MinimumWidth = 6;
            this.Path_Poza.Name = "Path_Poza";
            this.Path_Poza.Width = 125;
            // 
            // personajeBindingSource
            // 
            this.personajeBindingSource.DataMember = "Personaje";
            this.personajeBindingSource.DataSource = this.yakuzaDataSet;
            // 
            // yakuzaDataSet
            // 
            this.yakuzaDataSet.DataSetName = "yakuzaDataSet";
            this.yakuzaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPageAS
            // 
            this.tabPageAS.Controls.Add(this.buttonUpdateSty);
            this.tabPageAS.Controls.Add(this.dataGridView2);
            this.tabPageAS.Location = new System.Drawing.Point(28, 4);
            this.tabPageAS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageAS.Name = "tabPageAS";
            this.tabPageAS.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageAS.Size = new System.Drawing.Size(1260, 750);
            this.tabPageAS.TabIndex = 1;
            this.tabPageAS.Text = "Admin - Stiluri";
            this.tabPageAS.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateSty
            // 
            this.buttonUpdateSty.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonUpdateSty.Location = new System.Drawing.Point(3, 707);
            this.buttonUpdateSty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonUpdateSty.Name = "buttonUpdateSty";
            this.buttonUpdateSty.Size = new System.Drawing.Size(1254, 39);
            this.buttonUpdateSty.TabIndex = 1;
            this.buttonUpdateSty.Text = "UPDATE";
            this.buttonUpdateSty.UseVisualStyleBackColor = true;
            this.buttonUpdateSty.Click += new System.EventHandler(this.buttonUpdateSty_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codStilDataGridViewTextBoxColumn,
            this.numeDataGridViewTextBoxColumn1,
            this.vitezaDataGridViewTextBoxColumn,
            this.putereDataGridViewTextBoxColumn,
            this.rankDataGridViewTextBoxColumn,
            this.procentDataGridViewTextBoxColumn,
            this.descriereDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.stiluriBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(7, 8);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1245, 584);
            this.dataGridView2.TabIndex = 0;
            // 
            // codStilDataGridViewTextBoxColumn
            // 
            this.codStilDataGridViewTextBoxColumn.DataPropertyName = "Cod_Stil";
            this.codStilDataGridViewTextBoxColumn.HeaderText = "Cod_Stil";
            this.codStilDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codStilDataGridViewTextBoxColumn.Name = "codStilDataGridViewTextBoxColumn";
            this.codStilDataGridViewTextBoxColumn.ReadOnly = true;
            this.codStilDataGridViewTextBoxColumn.Width = 125;
            // 
            // numeDataGridViewTextBoxColumn1
            // 
            this.numeDataGridViewTextBoxColumn1.DataPropertyName = "Nume";
            this.numeDataGridViewTextBoxColumn1.HeaderText = "Nume";
            this.numeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.numeDataGridViewTextBoxColumn1.Name = "numeDataGridViewTextBoxColumn1";
            this.numeDataGridViewTextBoxColumn1.Width = 125;
            // 
            // vitezaDataGridViewTextBoxColumn
            // 
            this.vitezaDataGridViewTextBoxColumn.DataPropertyName = "Viteza";
            this.vitezaDataGridViewTextBoxColumn.HeaderText = "Viteza";
            this.vitezaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vitezaDataGridViewTextBoxColumn.Name = "vitezaDataGridViewTextBoxColumn";
            this.vitezaDataGridViewTextBoxColumn.Width = 125;
            // 
            // putereDataGridViewTextBoxColumn
            // 
            this.putereDataGridViewTextBoxColumn.DataPropertyName = "Putere";
            this.putereDataGridViewTextBoxColumn.HeaderText = "Putere";
            this.putereDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.putereDataGridViewTextBoxColumn.Name = "putereDataGridViewTextBoxColumn";
            this.putereDataGridViewTextBoxColumn.Width = 125;
            // 
            // rankDataGridViewTextBoxColumn
            // 
            this.rankDataGridViewTextBoxColumn.DataPropertyName = "Rank";
            this.rankDataGridViewTextBoxColumn.HeaderText = "Rank";
            this.rankDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rankDataGridViewTextBoxColumn.Name = "rankDataGridViewTextBoxColumn";
            this.rankDataGridViewTextBoxColumn.Width = 125;
            // 
            // procentDataGridViewTextBoxColumn
            // 
            this.procentDataGridViewTextBoxColumn.DataPropertyName = "Procent";
            this.procentDataGridViewTextBoxColumn.HeaderText = "Procent";
            this.procentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.procentDataGridViewTextBoxColumn.Name = "procentDataGridViewTextBoxColumn";
            this.procentDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriereDataGridViewTextBoxColumn
            // 
            this.descriereDataGridViewTextBoxColumn.DataPropertyName = "Descriere";
            this.descriereDataGridViewTextBoxColumn.HeaderText = "Descriere";
            this.descriereDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriereDataGridViewTextBoxColumn.Name = "descriereDataGridViewTextBoxColumn";
            this.descriereDataGridViewTextBoxColumn.Width = 125;
            // 
            // stiluriBindingSource1
            // 
            this.stiluriBindingSource1.DataMember = "Stiluri";
            this.stiluriBindingSource1.DataSource = this.yakuzaDataSet1;
            // 
            // tabPageAF
            // 
            this.tabPageAF.Controls.Add(this.buttonUpdateFam);
            this.tabPageAF.Controls.Add(this.dataGridView3);
            this.tabPageAF.Location = new System.Drawing.Point(28, 4);
            this.tabPageAF.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageAF.Name = "tabPageAF";
            this.tabPageAF.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageAF.Size = new System.Drawing.Size(1260, 750);
            this.tabPageAF.TabIndex = 2;
            this.tabPageAF.Text = "Admin - Familii";
            this.tabPageAF.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateFam
            // 
            this.buttonUpdateFam.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonUpdateFam.Location = new System.Drawing.Point(3, 702);
            this.buttonUpdateFam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonUpdateFam.Name = "buttonUpdateFam";
            this.buttonUpdateFam.Size = new System.Drawing.Size(1254, 44);
            this.buttonUpdateFam.TabIndex = 1;
            this.buttonUpdateFam.Text = "UPDATE";
            this.buttonUpdateFam.UseVisualStyleBackColor = true;
            this.buttonUpdateFam.Click += new System.EventHandler(this.buttonUpdateFam_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codFamilieDataGridViewTextBoxColumn,
            this.numeDataGridViewTextBoxColumn2,
            this.liderDataGridViewTextBoxColumn,
            this.nrMembriDataGridViewTextBoxColumn,
            this.afiliereDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.familiiBindingSource1;
            this.dataGridView3.Location = new System.Drawing.Point(7, 8);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(1245, 562);
            this.dataGridView3.TabIndex = 0;
            // 
            // codFamilieDataGridViewTextBoxColumn
            // 
            this.codFamilieDataGridViewTextBoxColumn.DataPropertyName = "Cod_Familie";
            this.codFamilieDataGridViewTextBoxColumn.HeaderText = "Cod_Familie";
            this.codFamilieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codFamilieDataGridViewTextBoxColumn.Name = "codFamilieDataGridViewTextBoxColumn";
            this.codFamilieDataGridViewTextBoxColumn.ReadOnly = true;
            this.codFamilieDataGridViewTextBoxColumn.Width = 125;
            // 
            // numeDataGridViewTextBoxColumn2
            // 
            this.numeDataGridViewTextBoxColumn2.DataPropertyName = "Nume";
            this.numeDataGridViewTextBoxColumn2.HeaderText = "Nume";
            this.numeDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.numeDataGridViewTextBoxColumn2.Name = "numeDataGridViewTextBoxColumn2";
            this.numeDataGridViewTextBoxColumn2.Width = 125;
            // 
            // liderDataGridViewTextBoxColumn
            // 
            this.liderDataGridViewTextBoxColumn.DataPropertyName = "Lider";
            this.liderDataGridViewTextBoxColumn.HeaderText = "Lider";
            this.liderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.liderDataGridViewTextBoxColumn.Name = "liderDataGridViewTextBoxColumn";
            this.liderDataGridViewTextBoxColumn.Width = 125;
            // 
            // nrMembriDataGridViewTextBoxColumn
            // 
            this.nrMembriDataGridViewTextBoxColumn.DataPropertyName = "Nr_Membri";
            this.nrMembriDataGridViewTextBoxColumn.HeaderText = "Nr_Membri";
            this.nrMembriDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nrMembriDataGridViewTextBoxColumn.Name = "nrMembriDataGridViewTextBoxColumn";
            this.nrMembriDataGridViewTextBoxColumn.Width = 125;
            // 
            // afiliereDataGridViewTextBoxColumn
            // 
            this.afiliereDataGridViewTextBoxColumn.DataPropertyName = "Afiliere";
            this.afiliereDataGridViewTextBoxColumn.HeaderText = "Afiliere";
            this.afiliereDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.afiliereDataGridViewTextBoxColumn.Name = "afiliereDataGridViewTextBoxColumn";
            this.afiliereDataGridViewTextBoxColumn.Width = 125;
            // 
            // familiiBindingSource1
            // 
            this.familiiBindingSource1.DataMember = "Familii";
            this.familiiBindingSource1.DataSource = this.yakuzaDataSet1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Edo SZ", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1010, 771);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Facut de Razvan-Fabian Budasu, cca. 2022";
            // 
            // personajeTableAdapter
            // 
            this.personajeTableAdapter.ClearBeforeFill = true;
            // 
            // stiluriTableAdapter
            // 
            this.stiluriTableAdapter.ClearBeforeFill = true;
            // 
            // familiiTableAdapter
            // 
            this.familiiTableAdapter.ClearBeforeFill = true;
            // 
            // FormStartAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 788);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormStartAdmin";
            this.Text = "MENIU: COMENZI ADMINISTRATOR";
            this.Load += new System.EventHandler(this.FormStartAdmin_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageTools.ResumeLayout(false);
            this.tabPageAP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familiiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yakuzaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stiluriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personajeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yakuzaDataSet)).EndInit();
            this.tabPageAS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stiluriBindingSource1)).EndInit();
            this.tabPageAF.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familiiBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAP;
        private System.Windows.Forms.TabPage tabPageAS;
        private System.Windows.Forms.TabPage tabPageAF;
        private System.Windows.Forms.TabPage tabPageTools;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonString;
        private System.Windows.Forms.Button buttonPath;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.DataGridView dataGridView1;
        private yakuzaDataSet yakuzaDataSet;
        private System.Windows.Forms.BindingSource personajeBindingSource;
        private yakuzaDataSetTableAdapters.PersonajeTableAdapter personajeTableAdapter;
        private System.Windows.Forms.Button buttonUpdatePers;
        private yakuzaDataSet yakuzaDataSet1;
        private System.Windows.Forms.BindingSource stiluriBindingSource;
        private yakuzaDataSetTableAdapters.StiluriTableAdapter stiluriTableAdapter;
        private System.Windows.Forms.BindingSource familiiBindingSource;
        private yakuzaDataSetTableAdapters.FamiliiTableAdapter familiiTableAdapter;
        private System.Windows.Forms.Button buttonPhotoOpen;
        private System.Windows.Forms.Button buttonUpdateSty;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn codStilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vitezaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn putereDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rankDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn procentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriereDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource stiluriBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPersonajDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Locatie;
        private System.Windows.Forms.DataGridViewComboBoxColumn Cod_Familie;
        private System.Windows.Forms.DataGridViewComboBoxColumn Cod_Stil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bani;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path_Poza;
        private System.Windows.Forms.Button buttonSite;
        private System.Windows.Forms.Button buttonLoc;
        private System.Windows.Forms.Button buttonUpdateFam;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn codFamilieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn liderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrMembriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn afiliereDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource familiiBindingSource1;
        private System.Windows.Forms.Button buttonInfo;
    }
}