namespace AppSenAgriculture.Views.Parametre
{
    partial class frmProduit
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtLibelle = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrixUMin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrixUMax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbUniteMesure = new System.Windows.Forms.ComboBox();
            this.cbbCategorie = new System.Windows.Forms.ComboBox();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSelectionner = new System.Windows.Forms.Button();
            this.dgProduit = new System.Windows.Forms.DataGridView();
            this.Rechercher = new System.Windows.Forms.GroupBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.txtRPrixUMin = new System.Windows.Forms.TextBox();
            this.txtRDescription = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRLibelle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduit)).BeginInit();
            this.Rechercher.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Libelle";
            // 
            // txtLibelle
            // 
            this.txtLibelle.Location = new System.Drawing.Point(16, 41);
            this.txtLibelle.Name = "txtLibelle";
            this.txtLibelle.Size = new System.Drawing.Size(264, 20);
            this.txtLibelle.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(16, 104);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(264, 20);
            this.txtDescription.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // txtPrixUMin
            // 
            this.txtPrixUMin.Location = new System.Drawing.Point(16, 167);
            this.txtPrixUMin.Name = "txtPrixUMin";
            this.txtPrixUMin.Size = new System.Drawing.Size(264, 20);
            this.txtPrixUMin.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prix Unitaire Minimale";
            // 
            // txtPrixUMax
            // 
            this.txtPrixUMax.Location = new System.Drawing.Point(16, 230);
            this.txtPrixUMax.Name = "txtPrixUMax";
            this.txtPrixUMax.Size = new System.Drawing.Size(264, 20);
            this.txtPrixUMax.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Prix Unitaire Maximale";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Unite De Mesure";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Categorie";
            // 
            // cbbUniteMesure
            // 
            this.cbbUniteMesure.FormattingEnabled = true;
            this.cbbUniteMesure.Location = new System.Drawing.Point(16, 293);
            this.cbbUniteMesure.Name = "cbbUniteMesure";
            this.cbbUniteMesure.Size = new System.Drawing.Size(261, 21);
            this.cbbUniteMesure.TabIndex = 12;
            // 
            // cbbCategorie
            // 
            this.cbbCategorie.FormattingEnabled = true;
            this.cbbCategorie.Location = new System.Drawing.Point(16, 357);
            this.cbbCategorie.Name = "cbbCategorie";
            this.cbbCategorie.Size = new System.Drawing.Size(261, 21);
            this.cbbCategorie.TabIndex = 13;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(191, 423);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 16;
            this.btnModifier.Text = "&Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(191, 452);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 15;
            this.btnSupprimer.Tag = "";
            this.btnSupprimer.Text = "&Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(191, 394);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 14;
            this.btnAjouter.Text = "&Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnSelectionner
            // 
            this.btnSelectionner.Location = new System.Drawing.Point(202, 7);
            this.btnSelectionner.Name = "btnSelectionner";
            this.btnSelectionner.Size = new System.Drawing.Size(75, 23);
            this.btnSelectionner.TabIndex = 17;
            this.btnSelectionner.Text = "&Selectionner";
            this.btnSelectionner.UseVisualStyleBackColor = true;
            this.btnSelectionner.Click += new System.EventHandler(this.btnSelectionner_Click);
            // 
            // dgProduit
            // 
            this.dgProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProduit.Location = new System.Drawing.Point(309, 76);
            this.dgProduit.Name = "dgProduit";
            this.dgProduit.RowHeadersWidth = 92;
            this.dgProduit.Size = new System.Drawing.Size(841, 438);
            this.dgProduit.TabIndex = 18;
            // 
            // Rechercher
            // 
            this.Rechercher.BackColor = System.Drawing.Color.Silver;
            this.Rechercher.Controls.Add(this.btnRechercher);
            this.Rechercher.Controls.Add(this.txtRPrixUMin);
            this.Rechercher.Controls.Add(this.txtRDescription);
            this.Rechercher.Controls.Add(this.label9);
            this.Rechercher.Controls.Add(this.txtRLibelle);
            this.Rechercher.Controls.Add(this.label8);
            this.Rechercher.Controls.Add(this.label7);
            this.Rechercher.Location = new System.Drawing.Point(300, 7);
            this.Rechercher.Name = "Rechercher";
            this.Rechercher.Size = new System.Drawing.Size(841, 63);
            this.Rechercher.TabIndex = 19;
            this.Rechercher.TabStop = false;
            this.Rechercher.Text = "Recherche";
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(577, 31);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(75, 23);
            this.btnRechercher.TabIndex = 20;
            this.btnRechercher.Text = "&Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // txtRPrixUMin
            // 
            this.txtRPrixUMin.Location = new System.Drawing.Point(415, 37);
            this.txtRPrixUMin.Name = "txtRPrixUMin";
            this.txtRPrixUMin.Size = new System.Drawing.Size(110, 20);
            this.txtRPrixUMin.TabIndex = 21;
            // 
            // txtRDescription
            // 
            this.txtRDescription.Location = new System.Drawing.Point(229, 37);
            this.txtRDescription.Name = "txtRDescription";
            this.txtRDescription.Size = new System.Drawing.Size(110, 20);
            this.txtRDescription.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(411, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Prix Unitaire Minimale";
            // 
            // txtRLibelle
            // 
            this.txtRLibelle.Location = new System.Drawing.Point(43, 37);
            this.txtRLibelle.Name = "txtRLibelle";
            this.txtRLibelle.Size = new System.Drawing.Size(110, 20);
            this.txtRLibelle.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(214, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Description";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Libelle";
            // 
            // frmProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 654);
            this.ControlBox = false;
            this.Controls.Add(this.Rechercher);
            this.Controls.Add(this.dgProduit);
            this.Controls.Add(this.btnSelectionner);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.cbbCategorie);
            this.Controls.Add(this.cbbUniteMesure);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrixUMax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrixUMin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLibelle);
            this.Controls.Add(this.label1);
            this.Name = "frmProduit";
            this.Text = "Produit";
            this.Load += new System.EventHandler(this.frmProduit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProduit)).EndInit();
            this.Rechercher.ResumeLayout(false);
            this.Rechercher.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLibelle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrixUMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrixUMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbUniteMesure;
        private System.Windows.Forms.ComboBox cbbCategorie;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSelectionner;
        private System.Windows.Forms.DataGridView dgProduit;
        private System.Windows.Forms.GroupBox Rechercher;
        private System.Windows.Forms.TextBox txtRLibelle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRPrixUMin;
        private System.Windows.Forms.TextBox txtRDescription;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRechercher;
    }
}