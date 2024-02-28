namespace YAKUZA
{
    partial class FormVizFamilii
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVizFamilii));
            this.treeViewFamily = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonMod = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.labelNume = new System.Windows.Forms.Label();
            this.labelLider = new System.Windows.Forms.Label();
            this.labelMembri = new System.Windows.Forms.Label();
            this.labelAfiliere = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treeViewFamily
            // 
            this.treeViewFamily.BackColor = System.Drawing.Color.Black;
            this.treeViewFamily.Font = new System.Drawing.Font("Edo SZ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewFamily.ForeColor = System.Drawing.Color.White;
            this.treeViewFamily.LineColor = System.Drawing.Color.White;
            this.treeViewFamily.Location = new System.Drawing.Point(12, 12);
            this.treeViewFamily.Name = "treeViewFamily";
            this.treeViewFamily.Size = new System.Drawing.Size(270, 426);
            this.treeViewFamily.TabIndex = 0;
            this.treeViewFamily.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewFamily_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Edo SZ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(288, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nume:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Edo SZ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(288, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lider:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Edo SZ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(288, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Membri:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Edo SZ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(288, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Afiliere:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Edo SZ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(626, 410);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(158, 29);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Adaugare Familie";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonMod
            // 
            this.buttonMod.Font = new System.Drawing.Font("Edo SZ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMod.Location = new System.Drawing.Point(462, 410);
            this.buttonMod.Name = "buttonMod";
            this.buttonMod.Size = new System.Drawing.Size(158, 29);
            this.buttonMod.TabIndex = 10;
            this.buttonMod.Text = "Modificare Familie";
            this.buttonMod.UseVisualStyleBackColor = true;
            this.buttonMod.Click += new System.EventHandler(this.buttonMod_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Font = new System.Drawing.Font("Edo SZ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDel.Location = new System.Drawing.Point(298, 410);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(158, 29);
            this.buttonDel.TabIndex = 11;
            this.buttonDel.Text = "Stergere Familie";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // labelNume
            // 
            this.labelNume.AutoSize = true;
            this.labelNume.BackColor = System.Drawing.Color.Transparent;
            this.labelNume.Font = new System.Drawing.Font("Edo SZ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNume.ForeColor = System.Drawing.Color.White;
            this.labelNume.Location = new System.Drawing.Point(290, 80);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(23, 26);
            this.labelNume.TabIndex = 12;
            this.labelNume.Text = "-";
            // 
            // labelLider
            // 
            this.labelLider.AutoSize = true;
            this.labelLider.BackColor = System.Drawing.Color.Transparent;
            this.labelLider.Font = new System.Drawing.Font("Edo SZ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLider.ForeColor = System.Drawing.Color.White;
            this.labelLider.Location = new System.Drawing.Point(290, 170);
            this.labelLider.Name = "labelLider";
            this.labelLider.Size = new System.Drawing.Size(23, 26);
            this.labelLider.TabIndex = 13;
            this.labelLider.Text = "-";
            // 
            // labelMembri
            // 
            this.labelMembri.AutoSize = true;
            this.labelMembri.BackColor = System.Drawing.Color.Transparent;
            this.labelMembri.Font = new System.Drawing.Font("Edo SZ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMembri.ForeColor = System.Drawing.Color.White;
            this.labelMembri.Location = new System.Drawing.Point(292, 269);
            this.labelMembri.Name = "labelMembri";
            this.labelMembri.Size = new System.Drawing.Size(23, 26);
            this.labelMembri.TabIndex = 14;
            this.labelMembri.Text = "-";
            // 
            // labelAfiliere
            // 
            this.labelAfiliere.AutoSize = true;
            this.labelAfiliere.BackColor = System.Drawing.Color.Transparent;
            this.labelAfiliere.Font = new System.Drawing.Font("Edo SZ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAfiliere.ForeColor = System.Drawing.Color.White;
            this.labelAfiliere.Location = new System.Drawing.Point(292, 370);
            this.labelAfiliere.Name = "labelAfiliere";
            this.labelAfiliere.Size = new System.Drawing.Size(23, 26);
            this.labelAfiliere.TabIndex = 15;
            this.labelAfiliere.Text = "-";
            // 
            // FormVizFamilii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelAfiliere);
            this.Controls.Add(this.labelMembri);
            this.Controls.Add(this.labelLider);
            this.Controls.Add(this.labelNume);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonMod);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeViewFamily);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormVizFamilii";
            this.Text = "MENIU: FAMILII";
            this.Load += new System.EventHandler(this.FormVizFamilii_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewFamily;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonMod;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Label labelNume;
        private System.Windows.Forms.Label labelLider;
        private System.Windows.Forms.Label labelMembri;
        private System.Windows.Forms.Label labelAfiliere;
    }
}