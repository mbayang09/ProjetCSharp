using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSenAgriculture.Views.Parametre
{
	partial class frmLieu
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
			this.tabControlLieu = new System.Windows.Forms.TabControl();
			// ====== TAB REGION ======
			this.tabRegion = new System.Windows.Forms.TabPage();
			this.dgRegion = new System.Windows.Forms.DataGridView();
			this.lblCodeRegion = new System.Windows.Forms.Label();
			this.txtCodeRegion = new System.Windows.Forms.TextBox();
			this.lblLibelleRegion = new System.Windows.Forms.Label();
			this.txtLibelleRegion = new System.Windows.Forms.TextBox();
			this.btnAjouterRegion = new System.Windows.Forms.Button();
			this.btnModifierRegion = new System.Windows.Forms.Button();
			this.btnSupprimerRegion = new System.Windows.Forms.Button();
			this.btnSelectionnerRegion = new System.Windows.Forms.Button();
			// ====== TAB DEPARTEMENT ======
			this.tabDepartement = new System.Windows.Forms.TabPage();
			this.dgDepartement = new System.Windows.Forms.DataGridView();
			this.lblCodeDepartement = new System.Windows.Forms.Label();
			this.txtCodeDepartement = new System.Windows.Forms.TextBox();
			this.lblLibelleDepartement = new System.Windows.Forms.Label();
			this.txtLibelleDepartement = new System.Windows.Forms.TextBox();
			this.lblRegionDepartement = new System.Windows.Forms.Label();
			this.cbbRegionDepartement = new System.Windows.Forms.ComboBox();
			this.btnAjouterDepartement = new System.Windows.Forms.Button();
			this.btnModifierDepartement = new System.Windows.Forms.Button();
			this.btnSupprimerDepartement = new System.Windows.Forms.Button();
			this.btnSelectionnerDepartement = new System.Windows.Forms.Button();
			// ====== TAB COMMUNE ======
			this.tabCommune = new System.Windows.Forms.TabPage();
			this.dgCommune = new System.Windows.Forms.DataGridView();
			this.lblCodeCommune = new System.Windows.Forms.Label();
			this.txtCodeCommune = new System.Windows.Forms.TextBox();
			this.lblLibelleCommune = new System.Windows.Forms.Label();
			this.txtLibelleCommune = new System.Windows.Forms.TextBox();
			this.lblDepartementCommune = new System.Windows.Forms.Label();
			this.cbbDepartementCommune = new System.Windows.Forms.ComboBox();
			this.btnAjouterCommune = new System.Windows.Forms.Button();
			this.btnModifierCommune = new System.Windows.Forms.Button();
			this.btnSupprimerCommune = new System.Windows.Forms.Button();
			this.btnSelectionnerCommune = new System.Windows.Forms.Button();

			this.tabControlLieu.SuspendLayout();
			this.tabRegion.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgRegion)).BeginInit();
			this.tabDepartement.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgDepartement)).BeginInit();
			this.tabCommune.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgCommune)).BeginInit();
			this.SuspendLayout();

			// ============================================================
			//  TAB CONTROL
			// ============================================================
			this.tabControlLieu.Controls.Add(this.tabRegion);
			this.tabControlLieu.Controls.Add(this.tabDepartement);
			this.tabControlLieu.Controls.Add(this.tabCommune);
			this.tabControlLieu.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControlLieu.Location = new System.Drawing.Point(0, 0);
			this.tabControlLieu.Name = "tabControlLieu";
			this.tabControlLieu.SelectedIndex = 0;
			this.tabControlLieu.Size = new System.Drawing.Size(900, 550);
			this.tabControlLieu.TabIndex = 0;
			this.tabControlLieu.SelectedIndexChanged += new System.EventHandler(this.tabControlLieu_SelectedIndexChanged);

			// ============================================================
			//  TAB REGION
			// ============================================================
			this.tabRegion.Controls.Add(this.dgRegion);
			this.tabRegion.Controls.Add(this.lblCodeRegion);
			this.tabRegion.Controls.Add(this.txtCodeRegion);
			this.tabRegion.Controls.Add(this.lblLibelleRegion);
			this.tabRegion.Controls.Add(this.txtLibelleRegion);
			this.tabRegion.Controls.Add(this.btnAjouterRegion);
			this.tabRegion.Controls.Add(this.btnModifierRegion);
			this.tabRegion.Controls.Add(this.btnSupprimerRegion);
			this.tabRegion.Controls.Add(this.btnSelectionnerRegion);
			this.tabRegion.Location = new System.Drawing.Point(4, 25);
			this.tabRegion.Name = "tabRegion";
			this.tabRegion.Padding = new System.Windows.Forms.Padding(3);
			this.tabRegion.Size = new System.Drawing.Size(892, 521);
			this.tabRegion.TabIndex = 0;
			this.tabRegion.Text = "Région";
			this.tabRegion.UseVisualStyleBackColor = true;

			// lblCodeRegion
			this.lblCodeRegion.AutoSize = true;
			this.lblCodeRegion.Location = new System.Drawing.Point(20, 20);
			this.lblCodeRegion.Name = "lblCodeRegion";
			this.lblCodeRegion.Size = new System.Drawing.Size(80, 16);
			this.lblCodeRegion.Text = "Code Région";
			// txtCodeRegion
			this.txtCodeRegion.Location = new System.Drawing.Point(20, 45);
			this.txtCodeRegion.Name = "txtCodeRegion";
			this.txtCodeRegion.Size = new System.Drawing.Size(250, 22);
			// lblLibelleRegion
			this.lblLibelleRegion.AutoSize = true;
			this.lblLibelleRegion.Location = new System.Drawing.Point(20, 85);
			this.lblLibelleRegion.Name = "lblLibelleRegion";
			this.lblLibelleRegion.Size = new System.Drawing.Size(90, 16);
			this.lblLibelleRegion.Text = "Libellé Région";
			// txtLibelleRegion
			this.txtLibelleRegion.Location = new System.Drawing.Point(20, 110);
			this.txtLibelleRegion.Name = "txtLibelleRegion";
			this.txtLibelleRegion.Size = new System.Drawing.Size(250, 22);
			// btnAjouterRegion
			this.btnAjouterRegion.Location = new System.Drawing.Point(20, 155);
			this.btnAjouterRegion.Name = "btnAjouterRegion";
			this.btnAjouterRegion.Size = new System.Drawing.Size(100, 28);
			this.btnAjouterRegion.Text = "&Ajouter";
			this.btnAjouterRegion.UseVisualStyleBackColor = true;
			this.btnAjouterRegion.Click += new System.EventHandler(this.btnAjouterRegion_Click);
			// btnModifierRegion
			this.btnModifierRegion.Location = new System.Drawing.Point(130, 155);
			this.btnModifierRegion.Name = "btnModifierRegion";
			this.btnModifierRegion.Size = new System.Drawing.Size(100, 28);
			this.btnModifierRegion.Text = "&Modifier";
			this.btnModifierRegion.UseVisualStyleBackColor = true;
			this.btnModifierRegion.Click += new System.EventHandler(this.btnModifierRegion_Click);
			// btnSupprimerRegion
			this.btnSupprimerRegion.Location = new System.Drawing.Point(20, 195);
			this.btnSupprimerRegion.Name = "btnSupprimerRegion";
			this.btnSupprimerRegion.Size = new System.Drawing.Size(100, 28);
			this.btnSupprimerRegion.Text = "&Supprimer";
			this.btnSupprimerRegion.UseVisualStyleBackColor = true;
			this.btnSupprimerRegion.Click += new System.EventHandler(this.btnSupprimerRegion_Click);
			// btnSelectionnerRegion
			this.btnSelectionnerRegion.Location = new System.Drawing.Point(130, 195);
			this.btnSelectionnerRegion.Name = "btnSelectionnerRegion";
			this.btnSelectionnerRegion.Size = new System.Drawing.Size(100, 28);
			this.btnSelectionnerRegion.Text = "&Selectionner";
			this.btnSelectionnerRegion.UseVisualStyleBackColor = true;
			this.btnSelectionnerRegion.Click += new System.EventHandler(this.btnSelectionnerRegion_Click);
			// dgRegion
			this.dgRegion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgRegion.Location = new System.Drawing.Point(300, 20);
			this.dgRegion.Name = "dgRegion";
			this.dgRegion.RowHeadersWidth = 50;
			this.dgRegion.Size = new System.Drawing.Size(570, 480);
			this.dgRegion.TabIndex = 0;
			this.dgRegion.ReadOnly = true;
			this.dgRegion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

			// ============================================================
			//  TAB DEPARTEMENT
			// ============================================================
			this.tabDepartement.Controls.Add(this.dgDepartement);
			this.tabDepartement.Controls.Add(this.lblCodeDepartement);
			this.tabDepartement.Controls.Add(this.txtCodeDepartement);
			this.tabDepartement.Controls.Add(this.lblLibelleDepartement);
			this.tabDepartement.Controls.Add(this.txtLibelleDepartement);
			this.tabDepartement.Controls.Add(this.lblRegionDepartement);
			this.tabDepartement.Controls.Add(this.cbbRegionDepartement);
			this.tabDepartement.Controls.Add(this.btnAjouterDepartement);
			this.tabDepartement.Controls.Add(this.btnModifierDepartement);
			this.tabDepartement.Controls.Add(this.btnSupprimerDepartement);
			this.tabDepartement.Controls.Add(this.btnSelectionnerDepartement);
			this.tabDepartement.Location = new System.Drawing.Point(4, 25);
			this.tabDepartement.Name = "tabDepartement";
			this.tabDepartement.Padding = new System.Windows.Forms.Padding(3);
			this.tabDepartement.Size = new System.Drawing.Size(892, 521);
			this.tabDepartement.TabIndex = 1;
			this.tabDepartement.Text = "Département";
			this.tabDepartement.UseVisualStyleBackColor = true;

			// lblRegionDepartement
			this.lblRegionDepartement.AutoSize = true;
			this.lblRegionDepartement.Location = new System.Drawing.Point(20, 20);
			this.lblRegionDepartement.Name = "lblRegionDepartement";
			this.lblRegionDepartement.Size = new System.Drawing.Size(50, 16);
			this.lblRegionDepartement.Text = "Région";
			// cbbRegionDepartement
			this.cbbRegionDepartement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbRegionDepartement.Location = new System.Drawing.Point(20, 45);
			this.cbbRegionDepartement.Name = "cbbRegionDepartement";
			this.cbbRegionDepartement.Size = new System.Drawing.Size(250, 24);
			// lblCodeDepartement
			this.lblCodeDepartement.AutoSize = true;
			this.lblCodeDepartement.Location = new System.Drawing.Point(20, 85);
			this.lblCodeDepartement.Name = "lblCodeDepartement";
			this.lblCodeDepartement.Size = new System.Drawing.Size(120, 16);
			this.lblCodeDepartement.Text = "Code Département";
			// txtCodeDepartement
			this.txtCodeDepartement.Location = new System.Drawing.Point(20, 110);
			this.txtCodeDepartement.Name = "txtCodeDepartement";
			this.txtCodeDepartement.Size = new System.Drawing.Size(250, 22);
			// lblLibelleDepartement
			this.lblLibelleDepartement.AutoSize = true;
			this.lblLibelleDepartement.Location = new System.Drawing.Point(20, 150);
			this.lblLibelleDepartement.Name = "lblLibelleDepartement";
			this.lblLibelleDepartement.Size = new System.Drawing.Size(130, 16);
			this.lblLibelleDepartement.Text = "Libellé Département";
			// txtLibelleDepartement
			this.txtLibelleDepartement.Location = new System.Drawing.Point(20, 175);
			this.txtLibelleDepartement.Name = "txtLibelleDepartement";
			this.txtLibelleDepartement.Size = new System.Drawing.Size(250, 22);
			// btnAjouterDepartement
			this.btnAjouterDepartement.Location = new System.Drawing.Point(20, 220);
			this.btnAjouterDepartement.Name = "btnAjouterDepartement";
			this.btnAjouterDepartement.Size = new System.Drawing.Size(100, 28);
			this.btnAjouterDepartement.Text = "&Ajouter";
			this.btnAjouterDepartement.UseVisualStyleBackColor = true;
			this.btnAjouterDepartement.Click += new System.EventHandler(this.btnAjouterDepartement_Click);
			// btnModifierDepartement
			this.btnModifierDepartement.Location = new System.Drawing.Point(130, 220);
			this.btnModifierDepartement.Name = "btnModifierDepartement";
			this.btnModifierDepartement.Size = new System.Drawing.Size(100, 28);
			this.btnModifierDepartement.Text = "&Modifier";
			this.btnModifierDepartement.UseVisualStyleBackColor = true;
			this.btnModifierDepartement.Click += new System.EventHandler(this.btnModifierDepartement_Click);
			// btnSupprimerDepartement
			this.btnSupprimerDepartement.Location = new System.Drawing.Point(20, 260);
			this.btnSupprimerDepartement.Name = "btnSupprimerDepartement";
			this.btnSupprimerDepartement.Size = new System.Drawing.Size(100, 28);
			this.btnSupprimerDepartement.Text = "&Supprimer";
			this.btnSupprimerDepartement.UseVisualStyleBackColor = true;
			this.btnSupprimerDepartement.Click += new System.EventHandler(this.btnSupprimerDepartement_Click);
			// btnSelectionnerDepartement
			this.btnSelectionnerDepartement.Location = new System.Drawing.Point(130, 260);
			this.btnSelectionnerDepartement.Name = "btnSelectionnerDepartement";
			this.btnSelectionnerDepartement.Size = new System.Drawing.Size(100, 28);
			this.btnSelectionnerDepartement.Text = "&Selectionner";
			this.btnSelectionnerDepartement.UseVisualStyleBackColor = true;
			this.btnSelectionnerDepartement.Click += new System.EventHandler(this.btnSelectionnerDepartement_Click);
			// dgDepartement
			this.dgDepartement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgDepartement.Location = new System.Drawing.Point(300, 20);
			this.dgDepartement.Name = "dgDepartement";
			this.dgDepartement.RowHeadersWidth = 50;
			this.dgDepartement.Size = new System.Drawing.Size(570, 480);
			this.dgDepartement.TabIndex = 0;
			this.dgDepartement.ReadOnly = true;
			this.dgDepartement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

			// ============================================================
			//  TAB COMMUNE
			// ============================================================
			this.tabCommune.Controls.Add(this.dgCommune);
			this.tabCommune.Controls.Add(this.lblCodeCommune);
			this.tabCommune.Controls.Add(this.txtCodeCommune);
			this.tabCommune.Controls.Add(this.lblLibelleCommune);
			this.tabCommune.Controls.Add(this.txtLibelleCommune);
			this.tabCommune.Controls.Add(this.lblDepartementCommune);
			this.tabCommune.Controls.Add(this.cbbDepartementCommune);
			this.tabCommune.Controls.Add(this.btnAjouterCommune);
			this.tabCommune.Controls.Add(this.btnModifierCommune);
			this.tabCommune.Controls.Add(this.btnSupprimerCommune);
			this.tabCommune.Controls.Add(this.btnSelectionnerCommune);
			this.tabCommune.Location = new System.Drawing.Point(4, 25);
			this.tabCommune.Name = "tabCommune";
			this.tabCommune.Padding = new System.Windows.Forms.Padding(3);
			this.tabCommune.Size = new System.Drawing.Size(892, 521);
			this.tabCommune.TabIndex = 2;
			this.tabCommune.Text = "Commune";
			this.tabCommune.UseVisualStyleBackColor = true;

			// lblDepartementCommune
			this.lblDepartementCommune.AutoSize = true;
			this.lblDepartementCommune.Location = new System.Drawing.Point(20, 20);
			this.lblDepartementCommune.Name = "lblDepartementCommune";
			this.lblDepartementCommune.Size = new System.Drawing.Size(80, 16);
			this.lblDepartementCommune.Text = "Département";
			// cbbDepartementCommune
			this.cbbDepartementCommune.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbDepartementCommune.Location = new System.Drawing.Point(20, 45);
			this.cbbDepartementCommune.Name = "cbbDepartementCommune";
			this.cbbDepartementCommune.Size = new System.Drawing.Size(250, 24);
			// lblCodeCommune
			this.lblCodeCommune.AutoSize = true;
			this.lblCodeCommune.Location = new System.Drawing.Point(20, 85);
			this.lblCodeCommune.Name = "lblCodeCommune";
			this.lblCodeCommune.Size = new System.Drawing.Size(100, 16);
			this.lblCodeCommune.Text = "Code Commune";
			// txtCodeCommune
			this.txtCodeCommune.Location = new System.Drawing.Point(20, 110);
			this.txtCodeCommune.Name = "txtCodeCommune";
			this.txtCodeCommune.Size = new System.Drawing.Size(250, 22);
			// lblLibelleCommune
			this.lblLibelleCommune.AutoSize = true;
			this.lblLibelleCommune.Location = new System.Drawing.Point(20, 150);
			this.lblLibelleCommune.Name = "lblLibelleCommune";
			this.lblLibelleCommune.Size = new System.Drawing.Size(110, 16);
			this.lblLibelleCommune.Text = "Libellé Commune";
			// txtLibelleCommune
			this.txtLibelleCommune.Location = new System.Drawing.Point(20, 175);
			this.txtLibelleCommune.Name = "txtLibelleCommune";
			this.txtLibelleCommune.Size = new System.Drawing.Size(250, 22);
			// btnAjouterCommune
			this.btnAjouterCommune.Location = new System.Drawing.Point(20, 220);
			this.btnAjouterCommune.Name = "btnAjouterCommune";
			this.btnAjouterCommune.Size = new System.Drawing.Size(100, 28);
			this.btnAjouterCommune.Text = "&Ajouter";
			this.btnAjouterCommune.UseVisualStyleBackColor = true;
			this.btnAjouterCommune.Click += new System.EventHandler(this.btnAjouterCommune_Click);
			// btnModifierCommune
			this.btnModifierCommune.Location = new System.Drawing.Point(130, 220);
			this.btnModifierCommune.Name = "btnModifierCommune";
			this.btnModifierCommune.Size = new System.Drawing.Size(100, 28);
			this.btnModifierCommune.Text = "&Modifier";
			this.btnModifierCommune.UseVisualStyleBackColor = true;
			this.btnModifierCommune.Click += new System.EventHandler(this.btnModifierCommune_Click);
			// btnSupprimerCommune
			this.btnSupprimerCommune.Location = new System.Drawing.Point(20, 260);
			this.btnSupprimerCommune.Name = "btnSupprimerCommune";
			this.btnSupprimerCommune.Size = new System.Drawing.Size(100, 28);
			this.btnSupprimerCommune.Text = "&Supprimer";
			this.btnSupprimerCommune.UseVisualStyleBackColor = true;
			this.btnSupprimerCommune.Click += new System.EventHandler(this.btnSupprimerCommune_Click);
			// btnSelectionnerCommune
			this.btnSelectionnerCommune.Location = new System.Drawing.Point(130, 260);
			this.btnSelectionnerCommune.Name = "btnSelectionnerCommune";
			this.btnSelectionnerCommune.Size = new System.Drawing.Size(100, 28);
			this.btnSelectionnerCommune.Text = "&Selectionner";
			this.btnSelectionnerCommune.UseVisualStyleBackColor = true;
			this.btnSelectionnerCommune.Click += new System.EventHandler(this.btnSelectionnerCommune_Click);
			// dgCommune
			this.dgCommune.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgCommune.Location = new System.Drawing.Point(300, 20);
			this.dgCommune.Name = "dgCommune";
			this.dgCommune.RowHeadersWidth = 50;
			this.dgCommune.Size = new System.Drawing.Size(570, 480);
			this.dgCommune.TabIndex = 0;
			this.dgCommune.ReadOnly = true;
			this.dgCommune.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

			// ============================================================
			//  FORM frmLieu
			// ============================================================
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(900, 550);
			this.ControlBox = false;
			this.Controls.Add(this.tabControlLieu);
			this.Name = "frmLieu";
			this.Text = "Gestion des Lieux";
			this.Load += new System.EventHandler(this.frmLieu_Load);

			this.tabControlLieu.ResumeLayout(false);
			this.tabRegion.ResumeLayout(false);
			this.tabRegion.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgRegion)).EndInit();
			this.tabDepartement.ResumeLayout(false);
			this.tabDepartement.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgDepartement)).EndInit();
			this.tabCommune.ResumeLayout(false);
			this.tabCommune.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgCommune)).EndInit();
			this.ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.TabControl tabControlLieu;
		// Region
		private System.Windows.Forms.TabPage tabRegion;
		private System.Windows.Forms.DataGridView dgRegion;
		private System.Windows.Forms.Label lblCodeRegion;
		private System.Windows.Forms.TextBox txtCodeRegion;
		private System.Windows.Forms.Label lblLibelleRegion;
		private System.Windows.Forms.TextBox txtLibelleRegion;
		private System.Windows.Forms.Button btnAjouterRegion;
		private System.Windows.Forms.Button btnModifierRegion;
		private System.Windows.Forms.Button btnSupprimerRegion;
		private System.Windows.Forms.Button btnSelectionnerRegion;
		// Departement
		private System.Windows.Forms.TabPage tabDepartement;
		private System.Windows.Forms.DataGridView dgDepartement;
		private System.Windows.Forms.Label lblCodeDepartement;
		private System.Windows.Forms.TextBox txtCodeDepartement;
		private System.Windows.Forms.Label lblLibelleDepartement;
		private System.Windows.Forms.TextBox txtLibelleDepartement;
		private System.Windows.Forms.Label lblRegionDepartement;
		private System.Windows.Forms.ComboBox cbbRegionDepartement;
		private System.Windows.Forms.Button btnAjouterDepartement;
		private System.Windows.Forms.Button btnModifierDepartement;
		private System.Windows.Forms.Button btnSupprimerDepartement;
		private System.Windows.Forms.Button btnSelectionnerDepartement;
		// Commune
		private System.Windows.Forms.TabPage tabCommune;
		private System.Windows.Forms.DataGridView dgCommune;
		private System.Windows.Forms.Label lblCodeCommune;
		private System.Windows.Forms.TextBox txtCodeCommune;
		private System.Windows.Forms.Label lblLibelleCommune;
		private System.Windows.Forms.TextBox txtLibelleCommune;
		private System.Windows.Forms.Label lblDepartementCommune;
		private System.Windows.Forms.ComboBox cbbDepartementCommune;
		private System.Windows.Forms.Button btnAjouterCommune;
		private System.Windows.Forms.Button btnModifierCommune;
		private System.Windows.Forms.Button btnSupprimerCommune;
		private System.Windows.Forms.Button btnSelectionnerCommune;
	}
}
