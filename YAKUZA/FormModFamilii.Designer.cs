namespace YAKUZA
{
    partial class FormModFamilii
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
            this.checkBoxTOP = new System.Windows.Forms.CheckBox();
            this.buttonMod = new System.Windows.Forms.Button();
            this.comboBoxAfil = new System.Windows.Forms.ComboBox();
            this.familiiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yakuzaDataSet = new YAKUZA.yakuzaDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownMem = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLider = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.familiiTableAdapter = new YAKUZA.yakuzaDataSetTableAdapters.FamiliiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.familiiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yakuzaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMem)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxTOP
            // 
            this.checkBoxTOP.AutoSize = true;
            this.checkBoxTOP.Font = new System.Drawing.Font("Edo SZ", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTOP.Location = new System.Drawing.Point(147, 138);
            this.checkBoxTOP.Name = "checkBoxTOP";
            this.checkBoxTOP.Size = new System.Drawing.Size(136, 19);
            this.checkBoxTOP.TabIndex = 20;
            this.checkBoxTOP.Text = "Organizatie Mama";
            this.checkBoxTOP.UseVisualStyleBackColor = true;
            this.checkBoxTOP.CheckedChanged += new System.EventHandler(this.checkBoxTOP_CheckedChanged);
            // 
            // buttonMod
            // 
            this.buttonMod.Font = new System.Drawing.Font("Edo SZ", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMod.Location = new System.Drawing.Point(16, 166);
            this.buttonMod.Name = "buttonMod";
            this.buttonMod.Size = new System.Drawing.Size(269, 28);
            this.buttonMod.TabIndex = 19;
            this.buttonMod.Text = "MODIFICA FAMILIE";
            this.buttonMod.UseVisualStyleBackColor = true;
            this.buttonMod.Click += new System.EventHandler(this.buttonMod_Click);
            // 
            // comboBoxAfil
            // 
            this.comboBoxAfil.DataSource = this.familiiBindingSource;
            this.comboBoxAfil.DisplayMember = "Nume";
            this.comboBoxAfil.Font = new System.Drawing.Font("Edo SZ", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAfil.FormattingEnabled = true;
            this.comboBoxAfil.Location = new System.Drawing.Point(95, 105);
            this.comboBoxAfil.Name = "comboBoxAfil";
            this.comboBoxAfil.Size = new System.Drawing.Size(190, 27);
            this.comboBoxAfil.TabIndex = 18;
            this.comboBoxAfil.ValueMember = "Cod_Familie";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Edo SZ", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "Afiliere:";
            // 
            // numericUpDownMem
            // 
            this.numericUpDownMem.Font = new System.Drawing.Font("Edo SZ", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownMem.Location = new System.Drawing.Point(95, 72);
            this.numericUpDownMem.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownMem.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMem.Name = "numericUpDownMem";
            this.numericUpDownMem.Size = new System.Drawing.Size(190, 27);
            this.numericUpDownMem.TabIndex = 16;
            this.numericUpDownMem.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Edo SZ", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Membri:";
            // 
            // textBoxLider
            // 
            this.textBoxLider.Font = new System.Drawing.Font("Edo SZ", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLider.Location = new System.Drawing.Point(95, 39);
            this.textBoxLider.Name = "textBoxLider";
            this.textBoxLider.Size = new System.Drawing.Size(190, 27);
            this.textBoxLider.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Edo SZ", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Lider:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Edo SZ", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nume:";
            // 
            // textBoxNume
            // 
            this.textBoxNume.Font = new System.Drawing.Font("Edo SZ", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNume.Location = new System.Drawing.Point(95, 6);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(190, 27);
            this.textBoxNume.TabIndex = 11;
            // 
            // familiiTableAdapter
            // 
            this.familiiTableAdapter.ClearBeforeFill = true;
            // 
            // FormModFamilii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(297, 202);
            this.Controls.Add(this.checkBoxTOP);
            this.Controls.Add(this.buttonMod);
            this.Controls.Add(this.comboBoxAfil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownMem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxLider);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNume);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormModFamilii";
            this.Text = "COMANDA: MODIFICARE FAMILII";
            this.Load += new System.EventHandler(this.FormModFamilii_Load);
            ((System.ComponentModel.ISupportInitialize)(this.familiiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yakuzaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxTOP;
        private System.Windows.Forms.Button buttonMod;
        private System.Windows.Forms.ComboBox comboBoxAfil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownMem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLider;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNume;
        private yakuzaDataSet yakuzaDataSet;
        private System.Windows.Forms.BindingSource familiiBindingSource;
        private yakuzaDataSetTableAdapters.FamiliiTableAdapter familiiTableAdapter;
    }
}