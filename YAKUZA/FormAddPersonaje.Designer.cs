namespace YAKUZA
{
    partial class FormAddPersonaje
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonChoosePhoto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxNvl = new System.Windows.Forms.TextBox();
            this.textBoxBani = new System.Windows.Forms.TextBox();
            this.textBoxLocatie = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxFam = new System.Windows.Forms.ComboBox();
            this.familiiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yakuzaDataSet = new YAKUZA.yakuzaDataSet();
            this.familiiTableAdapter = new YAKUZA.yakuzaDataSetTableAdapters.FamiliiTableAdapter();
            this.comboBoxStil = new System.Windows.Forms.ComboBox();
            this.stiluriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stiluriTableAdapter = new YAKUZA.yakuzaDataSetTableAdapters.StiluriTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familiiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yakuzaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stiluriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(310, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 270);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonChoosePhoto
            // 
            this.buttonChoosePhoto.Font = new System.Drawing.Font("Edo SZ", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChoosePhoto.Location = new System.Drawing.Point(310, 288);
            this.buttonChoosePhoto.Name = "buttonChoosePhoto";
            this.buttonChoosePhoto.Size = new System.Drawing.Size(203, 29);
            this.buttonChoosePhoto.TabIndex = 1;
            this.buttonChoosePhoto.Text = "Alege Fotografie";
            this.buttonChoosePhoto.UseVisualStyleBackColor = true;
            this.buttonChoosePhoto.Click += new System.EventHandler(this.buttonChoosePhoto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Edo SZ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Edo SZ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stil";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Edo SZ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nivel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Edo SZ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Bani";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Edo SZ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 26);
            this.label5.TabIndex = 6;
            this.label5.Text = "Locatie";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Edo SZ", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(108, 12);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(196, 27);
            this.textBoxName.TabIndex = 7;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Edo SZ", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(17, 323);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(496, 34);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "ADAUGA PERSONAJ";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxNvl
            // 
            this.textBoxNvl.Font = new System.Drawing.Font("Edo SZ", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNvl.Location = new System.Drawing.Point(108, 208);
            this.textBoxNvl.Name = "textBoxNvl";
            this.textBoxNvl.Size = new System.Drawing.Size(196, 27);
            this.textBoxNvl.TabIndex = 10;
            this.textBoxNvl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNvl_KeyPress);
            // 
            // textBoxBani
            // 
            this.textBoxBani.Font = new System.Drawing.Font("Edo SZ", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBani.Location = new System.Drawing.Point(108, 255);
            this.textBoxBani.Name = "textBoxBani";
            this.textBoxBani.Size = new System.Drawing.Size(196, 27);
            this.textBoxBani.TabIndex = 11;
            this.textBoxBani.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBani_KeyPress);
            // 
            // textBoxLocatie
            // 
            this.textBoxLocatie.Font = new System.Drawing.Font("Edo SZ", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLocatie.Location = new System.Drawing.Point(108, 57);
            this.textBoxLocatie.Name = "textBoxLocatie";
            this.textBoxLocatie.Size = new System.Drawing.Size(196, 27);
            this.textBoxLocatie.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Edo SZ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 26);
            this.label6.TabIndex = 13;
            this.label6.Text = "Familie";
            // 
            // comboBoxFam
            // 
            this.comboBoxFam.DataSource = this.familiiBindingSource;
            this.comboBoxFam.DisplayMember = "Nume";
            this.comboBoxFam.FormattingEnabled = true;
            this.comboBoxFam.Location = new System.Drawing.Point(108, 118);
            this.comboBoxFam.Name = "comboBoxFam";
            this.comboBoxFam.Size = new System.Drawing.Size(196, 24);
            this.comboBoxFam.TabIndex = 14;
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
            // familiiTableAdapter
            // 
            this.familiiTableAdapter.ClearBeforeFill = true;
            // 
            // comboBoxStil
            // 
            this.comboBoxStil.DataSource = this.stiluriBindingSource;
            this.comboBoxStil.DisplayMember = "Nume";
            this.comboBoxStil.FormattingEnabled = true;
            this.comboBoxStil.Location = new System.Drawing.Point(108, 161);
            this.comboBoxStil.Name = "comboBoxStil";
            this.comboBoxStil.Size = new System.Drawing.Size(196, 24);
            this.comboBoxStil.TabIndex = 15;
            this.comboBoxStil.ValueMember = "Cod_Stil";
            // 
            // stiluriBindingSource
            // 
            this.stiluriBindingSource.DataMember = "Stiluri";
            this.stiluriBindingSource.DataSource = this.yakuzaDataSet;
            // 
            // stiluriTableAdapter
            // 
            this.stiluriTableAdapter.ClearBeforeFill = true;
            // 
            // FormAddPersonaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(527, 362);
            this.Controls.Add(this.comboBoxStil);
            this.Controls.Add(this.comboBoxFam);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxLocatie);
            this.Controls.Add(this.textBoxBani);
            this.Controls.Add(this.textBoxNvl);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonChoosePhoto);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormAddPersonaje";
            this.Text = "COMANDA: ADAUGARE PERSONAJE";
            this.Load += new System.EventHandler(this.FormAddPersonaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familiiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yakuzaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stiluriBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonChoosePhoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxNvl;
        private System.Windows.Forms.TextBox textBoxBani;
        private System.Windows.Forms.TextBox textBoxLocatie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxFam;
        private yakuzaDataSet yakuzaDataSet;
        private System.Windows.Forms.BindingSource familiiBindingSource;
        private yakuzaDataSetTableAdapters.FamiliiTableAdapter familiiTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxStil;
        private System.Windows.Forms.BindingSource stiluriBindingSource;
        private yakuzaDataSetTableAdapters.StiluriTableAdapter stiluriTableAdapter;
    }
}