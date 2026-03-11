using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppSenAgriculture.Helpers;
using AppSenAgriculture.Models;
using Region = AppSenAgriculture.Models.Region;

namespace AppSenAgriculture.Views.Parametre
{
	public partial class frmLieu : Form
	{
		BdSenAgricultureContext db = new BdSenAgricultureContext();

		public frmLieu()
		{
			InitializeComponent();
		}

		// ============================================================
		//  CHARGEMENT DU FORMULAIRE
		// ============================================================
		private void frmLieu_Load(object sender, EventArgs e)
		{
			ChargerRegions();
			ChargerDepartements();
			ChargerCommunes();
		}

		private void tabControlLieu_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Rafraîchir les données quand on change d'onglet
			if (tabControlLieu.SelectedIndex == 0) ChargerRegions();
			else if (tabControlLieu.SelectedIndex == 1) ChargerDepartements();
			else if (tabControlLieu.SelectedIndex == 2) ChargerCommunes();
		}

		// ============================================================
		//  ==================== RÉGION ====================
		// ============================================================

		private void ChargerRegions()
		{
			txtCodeRegion.Text = string.Empty;
			txtLibelleRegion.Text = string.Empty;

			dgRegion.DataSource = db.regions.Select(r => new
			{
				r.IdRegion,
				r.CodeRegion,
				r.LibelleRegion
			}).ToList();

			// Rafraîchir aussi la ComboBox des régions dans l'onglet Département
			ChargerComboRegions();
			txtCodeRegion.Focus();
		}

		private void ChargerComboRegions()
		{
			var liste = new List<ListItem>();
			liste.Add(new ListItem { Value = null, Text = "Sélectionner..." });
			foreach (var r in db.regions.ToList())
			{
				liste.Add(new ListItem
				{
					Value = r.IdRegion.ToString(),
					Text = r.LibelleRegion
				});
			}
			cbbRegionDepartement.DataSource = liste;
			cbbRegionDepartement.DisplayMember = "Text";
			cbbRegionDepartement.ValueMember = "Value";
		}

		private void btnAjouterRegion_Click(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrWhiteSpace(txtCodeRegion.Text))
				{
					MessageBox.Show("Le code région est obligatoire.", "Validation",
						MessageBoxButtons.OK, MessageBoxIcon.Warning);
					txtCodeRegion.Focus();
					return;
				}
				if (string.IsNullOrWhiteSpace(txtLibelleRegion.Text))
				{
					MessageBox.Show("Le libellé région est obligatoire.", "Validation",
						MessageBoxButtons.OK, MessageBoxIcon.Warning);
					txtLibelleRegion.Focus();
					return;
				}

				// Vérifier doublon
				var existe = db.regions.Where(r => r.CodeRegion == txtCodeRegion.Text.Trim()).FirstOrDefault();
				if (existe != null)
				{
					MessageBox.Show("Ce code région existe déjà.", "Doublon",
						MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				Region r2 = new Region();
				r2.CodeRegion = txtCodeRegion.Text.Trim();
				r2.LibelleRegion = txtLibelleRegion.Text.Trim();
				db.regions.Add(r2);
				db.SaveChanges();

				MessageBox.Show("Région ajoutée avec succès !", "Succès",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				ChargerRegions();
			}
			catch (Exception ex)
			{
				Utils.GererErreur("Ajout région", ex);
			}
		}

		private void btnSelectionnerRegion_Click(object sender, EventArgs e)
		{
			try
			{
				if (dgRegion.CurrentRow == null)
				{
					MessageBox.Show("Veuillez sélectionner une région.",
						"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}

				int id = int.Parse(dgRegion.CurrentRow.Cells[0].Value.ToString());
				var r = db.regions.Find(id);
				if (r == null)
				{
					MessageBox.Show("Région introuvable.", "Erreur",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				txtCodeRegion.Text = r.CodeRegion;
				txtLibelleRegion.Text = r.LibelleRegion;
			}
			catch (Exception ex)
			{
				Utils.GererErreur("Sélection région", ex);
			}
		}

		private void btnModifierRegion_Click(object sender, EventArgs e)
		{
			try
			{
				if (dgRegion.CurrentRow == null)
				{
					MessageBox.Show("Veuillez sélectionner une région à modifier.",
						"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}

				if (string.IsNullOrWhiteSpace(txtCodeRegion.Text) || string.IsNullOrWhiteSpace(txtLibelleRegion.Text))
				{
					MessageBox.Show("Tous les champs sont obligatoires.", "Validation",
						MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				int id = int.Parse(dgRegion.CurrentRow.Cells[0].Value.ToString());
				var r = db.regions.Find(id);
				if (r == null)
				{
					MessageBox.Show("Région introuvable.", "Erreur",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				r.CodeRegion = txtCodeRegion.Text.Trim();
				r.LibelleRegion = txtLibelleRegion.Text.Trim();
				db.SaveChanges();

				MessageBox.Show("Région modifiée avec succès !", "Succès",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				ChargerRegions();
			}
			catch (Exception ex)
			{
				Utils.GererErreur("Modification région", ex);
			}
		}

		private void btnSupprimerRegion_Click(object sender, EventArgs e)
		{
			try
			{
				if (dgRegion.CurrentRow == null)
				{
					MessageBox.Show("Veuillez sélectionner une région à supprimer.",
						"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}

				DialogResult confirmation = MessageBox.Show(
					"Êtes-vous sûr de vouloir supprimer cette région ?\nLes départements et communes liés seront aussi affectés.",
					"Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (confirmation == DialogResult.No) return;

				int id = int.Parse(dgRegion.CurrentRow.Cells[0].Value.ToString());
				var r = db.regions.Find(id);
				if (r == null)
				{
					MessageBox.Show("Région introuvable.", "Erreur",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				db.regions.Remove(r);
				db.SaveChanges();

				MessageBox.Show("Région supprimée avec succès !", "Succès",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				ChargerRegions();
			}
			catch (Exception ex)
			{
				Utils.GererErreur("Suppression région", ex);
			}
		}

		// ============================================================
		//  ==================== DÉPARTEMENT ====================
		// ============================================================

		private void ChargerDepartements()
		{
			txtCodeDepartement.Text = string.Empty;
			txtLibelleDepartement.Text = string.Empty;

			dgDepartement.DataSource = db.departements.Select(d => new
			{
				d.IdDepartement,
				d.CodeDepartement,
				d.LibelleDepartement,
				Region = d.Region.LibelleRegion
			}).ToList();

			ChargerComboRegions();
			ChargerComboDepartements();
			txtCodeDepartement.Focus();
		}

		private void ChargerComboDepartements()
		{
			var liste = new List<ListItem>();
			liste.Add(new ListItem { Value = null, Text = "Sélectionner..." });
			foreach (var d in db.departements.ToList())
			{
				liste.Add(new ListItem
				{
					Value = d.IdDepartement.ToString(),
					Text = d.LibelleDepartement
				});
			}
			cbbDepartementCommune.DataSource = liste;
			cbbDepartementCommune.DisplayMember = "Text";
			cbbDepartementCommune.ValueMember = "Value";
		}

		private void btnAjouterDepartement_Click(object sender, EventArgs e)
		{
			try
			{
				if (cbbRegionDepartement.SelectedValue == null || cbbRegionDepartement.SelectedValue.ToString() == "")
				{
					MessageBox.Show("Veuillez sélectionner une région.", "Validation",
						MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				if (string.IsNullOrWhiteSpace(txtCodeDepartement.Text))
				{
					MessageBox.Show("Le code département est obligatoire.", "Validation",
						MessageBoxButtons.OK, MessageBoxIcon.Warning);
					txtCodeDepartement.Focus();
					return;
				}
				if (string.IsNullOrWhiteSpace(txtLibelleDepartement.Text))
				{
					MessageBox.Show("Le libellé département est obligatoire.", "Validation",
						MessageBoxButtons.OK, MessageBoxIcon.Warning);
					txtLibelleDepartement.Focus();
					return;
				}

				Departement d = new Departement();
				d.CodeDepartement = txtCodeDepartement.Text.Trim();
				d.LibelleDepartement = txtLibelleDepartement.Text.Trim();
				d.RegionId = int.Parse(cbbRegionDepartement.SelectedValue.ToString());
				db.departements.Add(d);
				db.SaveChanges();

				MessageBox.Show("Département ajouté avec succès !", "Succès",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				ChargerDepartements();
			}
			catch (Exception ex)
			{
				Utils.GererErreur("Ajout département", ex);
			}
		}

		private void btnSelectionnerDepartement_Click(object sender, EventArgs e)
		{
			try
			{
				if (dgDepartement.CurrentRow == null)
				{
					MessageBox.Show("Veuillez sélectionner un département.",
						"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}

				int id = int.Parse(dgDepartement.CurrentRow.Cells[0].Value.ToString());
				var d = db.departements.Find(id);
				if (d == null)
				{
					MessageBox.Show("Département introuvable.", "Erreur",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				txtCodeDepartement.Text = d.CodeDepartement;
				txtLibelleDepartement.Text = d.LibelleDepartement;
				cbbRegionDepartement.SelectedValue = d.RegionId.ToString();
			}
			catch (Exception ex)
			{
				Utils.GererErreur("Sélection département", ex);
			}
		}

		private void btnModifierDepartement_Click(object sender, EventArgs e)
		{
			try
			{
				if (dgDepartement.CurrentRow == null)
				{
					MessageBox.Show("Veuillez sélectionner un département à modifier.",
						"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}

				if (cbbRegionDepartement.SelectedValue == null || cbbRegionDepartement.SelectedValue.ToString() == "")
				{
					MessageBox.Show("Veuillez sélectionner une région.", "Validation",
						MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				if (string.IsNullOrWhiteSpace(txtCodeDepartement.Text) || string.IsNullOrWhiteSpace(txtLibelleDepartement.Text))
				{
					MessageBox.Show("Tous les champs sont obligatoires.", "Validation",
						MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				int id = int.Parse(dgDepartement.CurrentRow.Cells[0].Value.ToString());
				var d = db.departements.Find(id);
				if (d == null)
				{
					MessageBox.Show("Département introuvable.", "Erreur",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				d.CodeDepartement = txtCodeDepartement.Text.Trim();
				d.LibelleDepartement = txtLibelleDepartement.Text.Trim();
				d.RegionId = int.Parse(cbbRegionDepartement.SelectedValue.ToString());
				db.SaveChanges();

				MessageBox.Show("Département modifié avec succès !", "Succès",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				ChargerDepartements();
			}
			catch (Exception ex)
			{
				Utils.GererErreur("Modification département", ex);
			}
		}

		private void btnSupprimerDepartement_Click(object sender, EventArgs e)
		{
			try
			{
				if (dgDepartement.CurrentRow == null)
				{
					MessageBox.Show("Veuillez sélectionner un département à supprimer.",
						"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}

				DialogResult confirmation = MessageBox.Show(
					"Êtes-vous sûr de vouloir supprimer ce département ?",
					"Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (confirmation == DialogResult.No) return;

				int id = int.Parse(dgDepartement.CurrentRow.Cells[0].Value.ToString());
				var d = db.departements.Find(id);
				if (d == null)
				{
					MessageBox.Show("Département introuvable.", "Erreur",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				db.departements.Remove(d);
				db.SaveChanges();

				MessageBox.Show("Département supprimé avec succès !", "Succès",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				ChargerDepartements();
			}
			catch (Exception ex)
			{
				Utils.GererErreur("Suppression département", ex);
			}
		}

		// ============================================================
		//  ==================== COMMUNE ====================
		// ============================================================

		private void ChargerCommunes()
		{
			txtCodeCommune.Text = string.Empty;
			txtLibelleCommune.Text = string.Empty;

			dgCommune.DataSource = db.communes.Select(c => new
			{
				c.IdCommune,
				c.CodeCommune,
				c.LibelleCommune,
				Departement = c.Departement.LibelleDepartement
			}).ToList();

			ChargerComboDepartements();
			txtCodeCommune.Focus();
		}

		private void btnAjouterCommune_Click(object sender, EventArgs e)
		{
			try
			{
				if (cbbDepartementCommune.SelectedValue == null || cbbDepartementCommune.SelectedValue.ToString() == "")
				{
					MessageBox.Show("Veuillez sélectionner un département.", "Validation",
						MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				if (string.IsNullOrWhiteSpace(txtCodeCommune.Text))
				{
					MessageBox.Show("Le code commune est obligatoire.", "Validation",
						MessageBoxButtons.OK, MessageBoxIcon.Warning);
					txtCodeCommune.Focus();
					return;
				}
				if (string.IsNullOrWhiteSpace(txtLibelleCommune.Text))
				{
					MessageBox.Show("Le libellé commune est obligatoire.", "Validation",
						MessageBoxButtons.OK, MessageBoxIcon.Warning);
					txtLibelleCommune.Focus();
					return;
				}

				Commune c = new Commune();
				c.CodeCommune = txtCodeCommune.Text.Trim();
				c.LibelleCommune = txtLibelleCommune.Text.Trim();
				c.DepartementId = int.Parse(cbbDepartementCommune.SelectedValue.ToString());
				db.communes.Add(c);
				db.SaveChanges();

				MessageBox.Show("Commune ajoutée avec succès !", "Succès",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				ChargerCommunes();
			}
			catch (Exception ex)
			{
				Utils.GererErreur("Ajout commune", ex);
			}
		}

		private void btnSelectionnerCommune_Click(object sender, EventArgs e)
		{
			try
			{
				if (dgCommune.CurrentRow == null)
				{
					MessageBox.Show("Veuillez sélectionner une commune.",
						"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}

				int id = int.Parse(dgCommune.CurrentRow.Cells[0].Value.ToString());
				var c = db.communes.Find(id);
				if (c == null)
				{
					MessageBox.Show("Commune introuvable.", "Erreur",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				txtCodeCommune.Text = c.CodeCommune;
				txtLibelleCommune.Text = c.LibelleCommune;
				cbbDepartementCommune.SelectedValue = c.DepartementId.ToString();
			}
			catch (Exception ex)
			{
				Utils.GererErreur("Sélection commune", ex);
			}
		}

		private void btnModifierCommune_Click(object sender, EventArgs e)
		{
			try
			{
				if (dgCommune.CurrentRow == null)
				{
					MessageBox.Show("Veuillez sélectionner une commune à modifier.",
						"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}

				if (cbbDepartementCommune.SelectedValue == null || cbbDepartementCommune.SelectedValue.ToString() == "")
				{
					MessageBox.Show("Veuillez sélectionner un département.", "Validation",
						MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				if (string.IsNullOrWhiteSpace(txtCodeCommune.Text) || string.IsNullOrWhiteSpace(txtLibelleCommune.Text))
				{
					MessageBox.Show("Tous les champs sont obligatoires.", "Validation",
						MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				int id = int.Parse(dgCommune.CurrentRow.Cells[0].Value.ToString());
				var c = db.communes.Find(id);
				if (c == null)
				{
					MessageBox.Show("Commune introuvable.", "Erreur",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				c.CodeCommune = txtCodeCommune.Text.Trim();
				c.LibelleCommune = txtLibelleCommune.Text.Trim();
				c.DepartementId = int.Parse(cbbDepartementCommune.SelectedValue.ToString());
				db.SaveChanges();

				MessageBox.Show("Commune modifiée avec succès !", "Succès",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				ChargerCommunes();
			}
			catch (Exception ex)
			{
				Utils.GererErreur("Modification commune", ex);
			}
		}

		private void btnSupprimerCommune_Click(object sender, EventArgs e)
		{
			try
			{
				if (dgCommune.CurrentRow == null)
				{
					MessageBox.Show("Veuillez sélectionner une commune à supprimer.",
						"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}

				DialogResult confirmation = MessageBox.Show(
					"Êtes-vous sûr de vouloir supprimer cette commune ?",
					"Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (confirmation == DialogResult.No) return;

				int id = int.Parse(dgCommune.CurrentRow.Cells[0].Value.ToString());
				var c = db.communes.Find(id);
				if (c == null)
				{
					MessageBox.Show("Commune introuvable.", "Erreur",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				db.communes.Remove(c);
				db.SaveChanges();

				MessageBox.Show("Commune supprimée avec succès !", "Succès",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				ChargerCommunes();
			}
			catch (Exception ex)
			{
				Utils.GererErreur("Suppression commune", ex);
			}
		}
	}
}
