namespace AppSenAgriculture.Views.Account
{
	partial class frmClient
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
			this.dgClient = new System.Windows.Forms.DataGridView();
			this.btnSelectionner = new System.Windows.Forms.Button();
			this.btnModifier = new System.Windows.Forms.Button();
			this.btnSupprimer = new System.Windows.Forms.Button();
			this.btnAjouter = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtTela = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtAdresse = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNomComplet = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtIdentifiiant = new System.Windows.Forms.TextBox();
			this.txtProfession = new System.Windows.Forms.TextBox();
			this.btnBloquer = new System.Windows.Forms.Button();
			this.btnDebloquer = new System.Windows.Forms.Button();
			this.btnReInitialise = new System.Windows.Forms.Button();
			this.btnImprimer = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgClient)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(119, 105);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 16);
			this.label1.TabIndex = 0;
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// dgClient
			// 
			this.dgClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgClient.Location = new System.Drawing.Point(443, 102);
			this.dgClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dgClient.Name = "dgClient";
			this.dgClient.RowHeadersWidth = 92;
			this.dgClient.Size = new System.Drawing.Size(527, 620);
			this.dgClient.TabIndex = 35;
			// 
			// btnSelectionner
			// 
			this.btnSelectionner.Location = new System.Drawing.Point(443, 46);
			this.btnSelectionner.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnSelectionner.Name = "btnSelectionner";
			this.btnSelectionner.Size = new System.Drawing.Size(100, 28);
			this.btnSelectionner.TabIndex = 34;
			this.btnSelectionner.Text = "&Selectionner";
			this.btnSelectionner.UseVisualStyleBackColor = true;
			this.btnSelectionner.Click += new System.EventHandler(this.btnSelectionner_Click);
			// 
			// btnModifier
			// 
			this.btnModifier.Location = new System.Drawing.Point(256, 577);
			this.btnModifier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnModifier.Name = "btnModifier";
			this.btnModifier.Size = new System.Drawing.Size(100, 28);
			this.btnModifier.TabIndex = 33;
			this.btnModifier.Text = "&Modifier";
			this.btnModifier.UseVisualStyleBackColor = true;
			this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
			// 
			// btnSupprimer
			// 
			this.btnSupprimer.Location = new System.Drawing.Point(256, 613);
			this.btnSupprimer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnSupprimer.Name = "btnSupprimer";
			this.btnSupprimer.Size = new System.Drawing.Size(100, 28);
			this.btnSupprimer.TabIndex = 32;
			this.btnSupprimer.Tag = "";
			this.btnSupprimer.Text = "&Supprimer";
			this.btnSupprimer.UseVisualStyleBackColor = true;
			this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
			// 
			// btnAjouter
			// 
			this.btnAjouter.Location = new System.Drawing.Point(256, 542);
			this.btnAjouter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnAjouter.Name = "btnAjouter";
			this.btnAjouter.Size = new System.Drawing.Size(100, 28);
			this.btnAjouter.TabIndex = 31;
			this.btnAjouter.Text = "&Ajouter";
			this.btnAjouter.UseVisualStyleBackColor = true;
			this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(23, 462);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(71, 16);
			this.label6.TabIndex = 28;
			this.label6.Text = "Profession";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(23, 383);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(63, 16);
			this.label5.TabIndex = 27;
			this.label5.Text = "Identifiant";
			// 
			// txtTela
			// 
			this.txtTela.Location = new System.Drawing.Point(23, 340);
			this.txtTela.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtTela.Name = "txtTela";
			this.txtTela.Size = new System.Drawing.Size(351, 22);
			this.txtTela.TabIndex = 26;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(23, 305);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(73, 16);
			this.label4.TabIndex = 25;
			this.label4.Text = "Telephone";
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(23, 262);
			this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(351, 22);
			this.txtEmail.TabIndex = 24;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(23, 228);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 16);
			this.label3.TabIndex = 23;
			this.label3.Text = "Email";
			// 
			// txtAdresse
			// 
			this.txtAdresse.Location = new System.Drawing.Point(23, 185);
			this.txtAdresse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtAdresse.Name = "txtAdresse";
			this.txtAdresse.Size = new System.Drawing.Size(351, 22);
			this.txtAdresse.TabIndex = 22;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(23, 150);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 16);
			this.label2.TabIndex = 21;
			this.label2.Text = "Adresse";
			// 
			// txtNomComplet
			// 
			this.txtNomComplet.Location = new System.Drawing.Point(23, 107);
			this.txtNomComplet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtNomComplet.Name = "txtNomComplet";
			this.txtNomComplet.Size = new System.Drawing.Size(351, 22);
			this.txtNomComplet.TabIndex = 20;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(23, 73);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(86, 16);
			this.label7.TabIndex = 19;
			this.label7.Text = "Nom Prenom";
			// 
			// txtIdentifiiant
			// 
			this.txtIdentifiiant.Location = new System.Drawing.Point(27, 416);
			this.txtIdentifiiant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtIdentifiiant.Name = "txtIdentifiiant";
			this.txtIdentifiiant.Size = new System.Drawing.Size(351, 22);
			this.txtIdentifiiant.TabIndex = 36;
			// 
			// txtProfession
			// 
			this.txtProfession.Location = new System.Drawing.Point(23, 492);
			this.txtProfession.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtProfession.Name = "txtProfession";
			this.txtProfession.Size = new System.Drawing.Size(351, 22);
			this.txtProfession.TabIndex = 37;
			// 
			// btnBloquer
			// 
			this.btnBloquer.Location = new System.Drawing.Point(583, 46);
			this.btnBloquer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnBloquer.Name = "btnBloquer";
			this.btnBloquer.Size = new System.Drawing.Size(100, 28);
			this.btnBloquer.TabIndex = 38;
			this.btnBloquer.Text = "&Bloquer";
			this.btnBloquer.UseVisualStyleBackColor = true;
			this.btnBloquer.Click += new System.EventHandler(this.btnBloquer_Click);
			// 
			// btnDebloquer
			// 
			this.btnDebloquer.Location = new System.Drawing.Point(723, 46);
			this.btnDebloquer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnDebloquer.Name = "btnDebloquer";
			this.btnDebloquer.Size = new System.Drawing.Size(100, 28);
			this.btnDebloquer.TabIndex = 39;
			this.btnDebloquer.Text = "&Debloquer";
			this.btnDebloquer.UseVisualStyleBackColor = true;
			this.btnDebloquer.Click += new System.EventHandler(this.btnDebloquer_Click);
			// 
			// btnReInitialise
			// 
			this.btnReInitialise.Location = new System.Drawing.Point(863, 46);
			this.btnReInitialise.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnReInitialise.Name = "btnReInitialise";
			this.btnReInitialise.Size = new System.Drawing.Size(100, 28);
			this.btnReInitialise.TabIndex = 40;
			this.btnReInitialise.Text = "&ReInitialiser";
			this.btnReInitialise.UseVisualStyleBackColor = true;
			this.btnReInitialise.Click += new System.EventHandler(this.btnReInitialise_Click);
			// 
			// btnImprimer
			// 
			this.btnImprimer.Location = new System.Drawing.Point(256, 649);
			this.btnImprimer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnImprimer.Name = "btnImprimer";
			this.btnImprimer.Size = new System.Drawing.Size(100, 28);
			this.btnImprimer.TabIndex = 41;
			this.btnImprimer.Tag = "";
			this.btnImprimer.Text = "&Imprimer";
			this.btnImprimer.UseVisualStyleBackColor = true;
			this.btnImprimer.Click += new System.EventHandler(this.btnImprimer_Click);
			// 
			// frmClient
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1080, 834);
			this.Controls.Add(this.btnImprimer);
			this.Controls.Add(this.btnReInitialise);
			this.Controls.Add(this.btnDebloquer);
			this.Controls.Add(this.btnBloquer);
			this.Controls.Add(this.txtProfession);
			this.Controls.Add(this.txtIdentifiiant);
			this.Controls.Add(this.dgClient);
			this.Controls.Add(this.btnSelectionner);
			this.Controls.Add(this.btnModifier);
			this.Controls.Add(this.btnSupprimer);
			this.Controls.Add(this.btnAjouter);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtTela);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtAdresse);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtNomComplet);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "frmClient";
			this.Text = "frmClient";
			this.Load += new System.EventHandler(this.frmClient_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgClient)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dgClient = new System.Windows.Forms.DataGridView();
            this.btnSelectionner = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTela = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomComplet = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdentifiiant = new System.Windows.Forms.TextBox();
            this.txtProfession = new System.Windows.Forms.TextBox();
            this.btnBloquer = new System.Windows.Forms.Button();
            this.btnDebloquer = new System.Windows.Forms.Button();
            this.btnReInitialise = new System.Windows.Forms.Button();
            this.btnImprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgClient)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgClient
            // 
            this.dgClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClient.Location = new System.Drawing.Point(332, 83);
            this.dgClient.Name = "dgClient";
            this.dgClient.RowHeadersWidth = 92;
            this.dgClient.Size = new System.Drawing.Size(395, 504);
            this.dgClient.TabIndex = 35;
            this.dgClient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgClient_CellContentClick);
            // 
            // btnSelectionner
            // 
            this.btnSelectionner.Location = new System.Drawing.Point(332, 37);
            this.btnSelectionner.Name = "btnSelectionner";
            this.btnSelectionner.Size = new System.Drawing.Size(75, 23);
            this.btnSelectionner.TabIndex = 34;
            this.btnSelectionner.Text = "&Selectionner";
            this.btnSelectionner.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(192, 469);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 33;
            this.btnModifier.Text = "&Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(192, 498);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 32;
            this.btnSupprimer.Tag = "";
            this.btnSupprimer.Text = "&Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(192, 440);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 31;
            this.btnAjouter.Text = "&Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Profession";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Identifiant";
            // 
            // txtTela
            // 
            this.txtTela.Location = new System.Drawing.Point(17, 276);
            this.txtTela.Name = "txtTela";
            this.txtTela.Size = new System.Drawing.Size(264, 20);
            this.txtTela.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Telephone";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(17, 213);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(264, 20);
            this.txtEmail.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Email";
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(17, 150);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(264, 20);
            this.txtAdresse.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Adresse";
            // 
            // txtNomComplet
            // 
            this.txtNomComplet.Location = new System.Drawing.Point(17, 87);
            this.txtNomComplet.Name = "txtNomComplet";
            this.txtNomComplet.Size = new System.Drawing.Size(264, 20);
            this.txtNomComplet.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Nom Prenom";
            // 
            // txtIdentifiiant
            // 
            this.txtIdentifiiant.Location = new System.Drawing.Point(20, 338);
            this.txtIdentifiiant.Name = "txtIdentifiiant";
            this.txtIdentifiiant.Size = new System.Drawing.Size(264, 20);
            this.txtIdentifiiant.TabIndex = 36;
            // 
            // txtProfession
            // 
            this.txtProfession.Location = new System.Drawing.Point(17, 400);
            this.txtProfession.Name = "txtProfession";
            this.txtProfession.Size = new System.Drawing.Size(264, 20);
            this.txtProfession.TabIndex = 37;
            // 
            // btnBloquer
            // 
            this.btnBloquer.Location = new System.Drawing.Point(437, 37);
            this.btnBloquer.Name = "btnBloquer";
            this.btnBloquer.Size = new System.Drawing.Size(75, 23);
            this.btnBloquer.TabIndex = 38;
            this.btnBloquer.Text = "&Bloquer";
            this.btnBloquer.UseVisualStyleBackColor = true;
            this.btnBloquer.Click += new System.EventHandler(this.btnBloquer_Click);
            // 
            // btnDebloquer
            // 
            this.btnDebloquer.Location = new System.Drawing.Point(542, 37);
            this.btnDebloquer.Name = "btnDebloquer";
            this.btnDebloquer.Size = new System.Drawing.Size(75, 23);
            this.btnDebloquer.TabIndex = 39;
            this.btnDebloquer.Text = "&Debloquer";
            this.btnDebloquer.UseVisualStyleBackColor = true;
            this.btnDebloquer.Click += new System.EventHandler(this.btnDebloquer_Click);
            // 
            // btnReInitialise
            // 
            this.btnReInitialise.Location = new System.Drawing.Point(647, 37);
            this.btnReInitialise.Name = "btnReInitialise";
            this.btnReInitialise.Size = new System.Drawing.Size(75, 23);
            this.btnReInitialise.TabIndex = 40;
            this.btnReInitialise.Text = "&ReInitialiser";
            this.btnReInitialise.UseVisualStyleBackColor = true;
            this.btnReInitialise.Click += new System.EventHandler(this.btnReInitialise_Click);
            // 
            // btnImprimer
            // 
            this.btnImprimer.Location = new System.Drawing.Point(192, 527);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Size = new System.Drawing.Size(75, 23);
            this.btnImprimer.TabIndex = 41;
            this.btnImprimer.Tag = "";
            this.btnImprimer.Text = "&Imprimer";
            this.btnImprimer.UseVisualStyleBackColor = true;
            this.btnImprimer.Click += new System.EventHandler(this.btnImprimer_Click);
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 678);
            this.Controls.Add(this.btnImprimer);
            this.Controls.Add(this.btnReInitialise);
            this.Controls.Add(this.btnDebloquer);
            this.Controls.Add(this.btnBloquer);
            this.Controls.Add(this.txtProfession);
            this.Controls.Add(this.txtIdentifiiant);
            this.Controls.Add(this.dgClient);
            this.Controls.Add(this.btnSelectionner);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTela);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomComplet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "frmClient";
            this.Text = "frmClient";
            ((System.ComponentModel.ISupportInitialize)(this.dgClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgClient;
		private System.Windows.Forms.Button btnSelectionner;
		private System.Windows.Forms.Button btnModifier;
		private System.Windows.Forms.Button btnSupprimer;
		private System.Windows.Forms.Button btnAjouter;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtTela;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtAdresse;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNomComplet;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtIdentifiiant;
		private System.Windows.Forms.TextBox txtProfession;
		private System.Windows.Forms.Button btnBloquer;
		private System.Windows.Forms.Button btnDebloquer;
		private System.Windows.Forms.Button btnReInitialise;
		private System.Windows.Forms.Button btnImprimer;
	}
}