namespace YAKUZA
{
    partial class FormVizPersonaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVizPersonaje));
            this.pictureBoxChar = new System.Windows.Forms.PictureBox();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.textBoxCnt = new System.Windows.Forms.TextBox();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonAddPers = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelNume = new System.Windows.Forms.Label();
            this.labelLocatie = new System.Windows.Forms.Label();
            this.labelFamilie = new System.Windows.Forms.Label();
            this.labelBani = new System.Windows.Forms.Label();
            this.labelNivel = new System.Windows.Forms.Label();
            this.labelStil = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxChar
            // 
            this.pictureBoxChar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxChar.Location = new System.Drawing.Point(352, 15);
            this.pictureBoxChar.Name = "pictureBoxChar";
            this.pictureBoxChar.Size = new System.Drawing.Size(407, 541);
            this.pictureBoxChar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxChar.TabIndex = 0;
            this.pictureBoxChar.TabStop = false;
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(16, 565);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(393, 27);
            this.buttonPrev.TabIndex = 1;
            this.buttonPrev.Text = "<";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.AllButtonAdv_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Edo SZ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nume:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Edo SZ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(15, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Stil:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Edo SZ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(13, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nivel:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Edo SZ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(12, 487);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bani:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Edo SZ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(16, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Locatie:";
            // 
            // textBoxID
            // 
            this.textBoxID.Enabled = false;
            this.textBoxID.Font = new System.Drawing.Font("Edo SZ", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(324, 22);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(22, 27);
            this.textBoxID.TabIndex = 12;
            this.textBoxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(531, 565);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(393, 27);
            this.buttonNext.TabIndex = 13;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.AllButtonAdv_Click);
            // 
            // textBoxCnt
            // 
            this.textBoxCnt.Enabled = false;
            this.textBoxCnt.Font = new System.Drawing.Font("Edo SZ", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCnt.Location = new System.Drawing.Point(414, 565);
            this.textBoxCnt.Name = "textBoxCnt";
            this.textBoxCnt.ReadOnly = true;
            this.textBoxCnt.Size = new System.Drawing.Size(111, 27);
            this.textBoxCnt.TabIndex = 14;
            this.textBoxCnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonModify
            // 
            this.buttonModify.Font = new System.Drawing.Font("Edo SZ", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModify.Location = new System.Drawing.Point(765, 347);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(159, 56);
            this.buttonModify.TabIndex = 15;
            this.buttonModify.Text = "MODIFICARE\r\nPERSONAJ";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // buttonAddPers
            // 
            this.buttonAddPers.Font = new System.Drawing.Font("Edo SZ", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddPers.Location = new System.Drawing.Point(765, 416);
            this.buttonAddPers.Name = "buttonAddPers";
            this.buttonAddPers.Size = new System.Drawing.Size(159, 60);
            this.buttonAddPers.TabIndex = 16;
            this.buttonAddPers.Text = "Adaugare\r\nPersonaj";
            this.buttonAddPers.UseVisualStyleBackColor = true;
            this.buttonAddPers.Click += new System.EventHandler(this.buttonAddPers_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Edo SZ", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(765, 491);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(159, 60);
            this.buttonDelete.TabIndex = 17;
            this.buttonDelete.Text = "Stergere\r\nPersonaj";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Edo SZ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(15, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 22);
            this.label6.TabIndex = 18;
            this.label6.Text = "Familie:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Edo SZ", 66F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(378, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(370, 123);
            this.label7.TabIndex = 20;
            this.label7.Text = "N  /  A";
            // 
            // labelNume
            // 
            this.labelNume.AutoSize = true;
            this.labelNume.BackColor = System.Drawing.Color.Transparent;
            this.labelNume.Font = new System.Drawing.Font("Edo SZ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNume.ForeColor = System.Drawing.Color.White;
            this.labelNume.Location = new System.Drawing.Point(14, 52);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(82, 33);
            this.labelNume.TabIndex = 21;
            this.labelNume.Text = "Nume";
            // 
            // labelLocatie
            // 
            this.labelLocatie.AutoSize = true;
            this.labelLocatie.BackColor = System.Drawing.Color.Transparent;
            this.labelLocatie.Font = new System.Drawing.Font("Edo SZ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocatie.ForeColor = System.Drawing.Color.White;
            this.labelLocatie.Location = new System.Drawing.Point(16, 127);
            this.labelLocatie.Name = "labelLocatie";
            this.labelLocatie.Size = new System.Drawing.Size(117, 33);
            this.labelLocatie.TabIndex = 22;
            this.labelLocatie.Text = "Locatie";
            // 
            // labelFamilie
            // 
            this.labelFamilie.AutoSize = true;
            this.labelFamilie.BackColor = System.Drawing.Color.Transparent;
            this.labelFamilie.Font = new System.Drawing.Font("Edo SZ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFamilie.ForeColor = System.Drawing.Color.White;
            this.labelFamilie.Location = new System.Drawing.Point(16, 267);
            this.labelFamilie.Name = "labelFamilie";
            this.labelFamilie.Size = new System.Drawing.Size(110, 33);
            this.labelFamilie.TabIndex = 24;
            this.labelFamilie.Text = "Familie";
            // 
            // labelBani
            // 
            this.labelBani.AutoSize = true;
            this.labelBani.BackColor = System.Drawing.Color.Transparent;
            this.labelBani.Font = new System.Drawing.Font("Edo SZ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBani.ForeColor = System.Drawing.Color.White;
            this.labelBani.Location = new System.Drawing.Point(14, 509);
            this.labelBani.Name = "labelBani";
            this.labelBani.Size = new System.Drawing.Size(77, 33);
            this.labelBani.TabIndex = 25;
            this.labelBani.Text = "Bani";
            // 
            // labelNivel
            // 
            this.labelNivel.AutoSize = true;
            this.labelNivel.BackColor = System.Drawing.Color.Transparent;
            this.labelNivel.Font = new System.Drawing.Font("Edo SZ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNivel.ForeColor = System.Drawing.Color.White;
            this.labelNivel.Location = new System.Drawing.Point(13, 425);
            this.labelNivel.Name = "labelNivel";
            this.labelNivel.Size = new System.Drawing.Size(87, 33);
            this.labelNivel.TabIndex = 26;
            this.labelNivel.Text = "Nivel";
            // 
            // labelStil
            // 
            this.labelStil.AutoSize = true;
            this.labelStil.BackColor = System.Drawing.Color.Transparent;
            this.labelStil.Font = new System.Drawing.Font("Edo SZ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStil.ForeColor = System.Drawing.Color.White;
            this.labelStil.Location = new System.Drawing.Point(16, 344);
            this.labelStil.Name = "labelStil";
            this.labelStil.Size = new System.Drawing.Size(65, 33);
            this.labelStil.TabIndex = 27;
            this.labelStil.Text = "Stil";
            // 
            // FormVizPersonaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(936, 604);
            this.Controls.Add(this.labelStil);
            this.Controls.Add(this.labelNivel);
            this.Controls.Add(this.labelBani);
            this.Controls.Add(this.labelFamilie);
            this.Controls.Add(this.labelLocatie);
            this.Controls.Add(this.labelNume);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAddPers);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.textBoxCnt);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.pictureBoxChar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormVizPersonaje";
            this.Text = "MENIU: PERSONAJE";
            this.Load += new System.EventHandler(this.FormVizPersonaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxChar;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.TextBox textBoxCnt;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonAddPers;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelNume;
        private System.Windows.Forms.Label labelLocatie;
        private System.Windows.Forms.Label labelFamilie;
        private System.Windows.Forms.Label labelBani;
        private System.Windows.Forms.Label labelNivel;
        private System.Windows.Forms.Label labelStil;
    }
}