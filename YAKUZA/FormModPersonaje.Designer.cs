namespace YAKUZA
{
    partial class FormModPersonaje
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
            this.textBoxLocatie = new System.Windows.Forms.TextBox();
            this.textBoxBani = new System.Windows.Forms.TextBox();
            this.textBoxNvl = new System.Windows.Forms.TextBox();
            this.buttonMod = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonChoosePhoto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonDel = new System.Windows.Forms.Button();
            this.comboBoxFam = new System.Windows.Forms.ComboBox();
            this.familiiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yakuzaDataSet = new YAKUZA.yakuzaDataSet();
            this.comboBoxStil = new System.Windows.Forms.ComboBox();
            this.stiluriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.familiiTableAdapter = new YAKUZA.yakuzaDataSetTableAdapters.FamiliiTableAdapter();
            this.stiluriTableAdapter = new YAKUZA.yakuzaDataSetTableAdapters.StiluriTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familiiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yakuzaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stiluriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxLocatie
            // 
            this.textBoxLocatie.Font = new System.Drawing.Font("Edo SZ", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLocatie.Location = new System.Drawing.Point(112, 60);
            this.textBoxLocatie.Name = "textBoxLocatie";
            this.textBoxLocatie.Size = new System.Drawing.Size(196, 27);
            this.textBoxLocatie.TabIndex = 25;
            // 
            // textBoxBani
            // 
            this.textBoxBani.Font = new System.Drawing.Font("Edo SZ", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBani.Location = new System.Drawing.Point(112, 255);
            this.textBoxBani.Name = "textBoxBani";
            this.textBoxBani.Size = new System.Drawing.Size(196, 27);
            this.textBoxBani.TabIndex = 24;
            this.textBoxBani.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBani_KeyPress);
            // 
            // textBoxNvl
            // 
            this.textBoxNvl.Font = new System.Drawing.Font("Edo SZ", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNvl.Location = new System.Drawing.Point(112, 206);
            this.textBoxNvl.Name = "textBoxNvl";
            this.textBoxNvl.Size = new System.Drawing.Size(196, 27);
            this.textBoxNvl.TabIndex = 23;
            this.textBoxNvl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNvl_KeyPress);
            // 
            // buttonMod
            // 
            this.buttonMod.Font = new System.Drawing.Font("Edo SZ", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMod.Location = new System.Drawing.Point(21, 323);
            this.buttonMod.Name = "buttonMod";
            this.buttonMod.Size = new System.Drawing.Size(496, 34);
            this.buttonMod.TabIndex = 21;
            this.buttonMod.Text = "MODIFICA PERSONAJ";
            this.buttonMod.UseVisualStyleBackColor = true;
            this.buttonMod.Click += new System.EventHandler(this.buttonMod_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Edo SZ", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(112, 12);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(196, 27);
            this.textBoxName.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Edo SZ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 26);
            this.label5.TabIndex = 19;
            this.label5.Text = "Locatie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Edo SZ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 26);
            this.label4.TabIndex = 18;
            this.label4.Text = "Bani";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Edo SZ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 26);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nivel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Edo SZ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 26);
            this.label2.TabIndex = 16;
            this.label2.Text = "Stil";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Edo SZ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nume";
            // 
            // buttonChoosePhoto
            // 
            this.buttonChoosePhoto.Font = new System.Drawing.Font("Edo SZ", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChoosePhoto.Location = new System.Drawing.Point(416, 288);
            this.buttonChoosePhoto.Name = "buttonChoosePhoto";
            this.buttonChoosePhoto.Size = new System.Drawing.Size(100, 29);
            this.buttonChoosePhoto.TabIndex = 14;
            this.buttonChoosePhoto.Text = "Alege Foto";
            this.buttonChoosePhoto.UseVisualStyleBackColor = true;
            this.buttonChoosePhoto.Click += new System.EventHandler(this.buttonChoosePhoto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(314, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 270);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Edo SZ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 26);
            this.label6.TabIndex = 26;
            this.label6.Text = "Familie";
            // 
            // buttonDel
            // 
            this.buttonDel.Font = new System.Drawing.Font("Edo SZ", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDel.Location = new System.Drawing.Point(314, 288);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(102, 29);
            this.buttonDel.TabIndex = 28;
            this.buttonDel.Text = "Sterge Foto";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // comboBoxFam
            // 
            this.comboBoxFam.DataSource = this.familiiBindingSource;
            this.comboBoxFam.DisplayMember = "Nume";
            this.comboBoxFam.FormattingEnabled = true;
            this.comboBoxFam.Location = new System.Drawing.Point(112, 115);
            this.comboBoxFam.Name = "comboBoxFam";
            this.comboBoxFam.Size = new System.Drawing.Size(196, 24);
            this.comboBoxFam.TabIndex = 29;
            this.comboBoxFam.ValueMember = "Cod_Familie";
            // 
            // familiiBindingSource
            // 
            this.familiiBindingSource.DataMember = "Familii";
            this.familiiBindingSource.DataSource = this.yakuzaDataSet;
            // 
            // yakuzaDataSet
            // 
            this.yakuzaDataSet.DataSetName = "yakuzaDataSet";
            this.yakuzaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxStil
            // 
            this.comboBoxStil.DataSource = this.stiluriBindingSource;
            this.comboBoxStil.DisplayMember = "Nume";
            this.comboBoxStil.FormattingEnabled = true;
            this.comboBoxStil.Location = new System.Drawing.Point(112, 159);
            this.comboBoxStil.Name = "comboBoxStil";
            this.comboBoxStil.Size = new System.Drawing.Size(196, 24);
            this.comboBoxStil.TabIndex = 30;
            this.comboBoxStil.ValueMember = "Cod_Stil";
            // 
            // stiluriBindingSource
            // 
            this.stiluriBindingSource.DataMember = "Stiluri";
            this.stiluriBindingSource.DataSource = this.yakuzaDataSet;
            // 
            // familiiTableAdapter
            // 
            this.familiiTableAdapter.ClearBeforeFill = true;
            // 
            // stiluriTableAdapter
            // 
            this.stiluriTableAdapter.ClearBeforeFill = true;
            // 
            // FormModPersonaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(528, 366);
            this.Controls.Add(this.comboBoxStil);
            this.Controls.Add(this.comboBoxFam);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxLocatie);
            this.Controls.Add(this.textBoxBani);
            this.Controls.Add(this.textBoxNvl);
            this.Controls.Add(this.buttonMod);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonChoosePhoto);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormModPersonaje";
            this.Text = "COMANDA: MODIFICARE PERSONAJE";
            this.Load += new System.EventHandler(this.FormModPersonaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familiiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yakuzaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stiluriBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLocatie;
        private System.Windows.Forms.TextBox textBoxBani;
        private System.Windows.Forms.TextBox textBoxNvl;
        private System.Windows.Forms.Button buttonMod;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonChoosePhoto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.ComboBox comboBoxFam;
        private System.Windows.Forms.ComboBox comboBoxStil;
        private yakuzaDataSet yakuzaDataSet;
        private System.Windows.Forms.BindingSource familiiBindingSource;
        private yakuzaDataSetTableAdapters.FamiliiTableAdapter familiiTableAdapter;
        private System.Windows.Forms.BindingSource stiluriBindingSource;
        private yakuzaDataSetTableAdapters.StiluriTableAdapter stiluriTableAdapter;
    }
}