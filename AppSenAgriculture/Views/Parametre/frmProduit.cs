using AppSenAgriculture.Helpers;
using AppSenAgriculture.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppSenAgriculture.Helpers;
namespace AppSenAgriculture.Views.Parametre
{
    public partial class frmProduit : Form
    {
        public frmProduit()
        {
            InitializeComponent();
        }

        BdSenAgricultureContext db = new BdSenAgricultureContext();

        FillList fillList = new FillList();

        private void ResetForm()
        {
            cbbUniteMesure.DataSource = fillList.fillUniteMesure();
            cbbUniteMesure.DisplayMember = "Text";
            cbbUniteMesure.ValueMember = "Value";

            cbbCategorie.DataSource = fillList.fillCategorie();
            cbbCategorie.DisplayMember = "Text";
            cbbCategorie.ValueMember = "Value";

            dgProduit.DataSource = db.produits.Select(u => new
            {
                u.IdProduit,
                u.LibelleProduit,
                u.DescriptionProduit,
                u.PrixUnitaireMin,
                u.PrixUnitaireMax,
               Categorie = u.Categorie.DescriptionCategorie,
                UniteMesure = u.UniteMesure.LibelleUnite
            }).ToList();
           
            txtDescription.Text = String.Empty;
            txtLibelle.Text = String.Empty;
            txtPrixUMax.Text = String.Empty;
            txtPrixUMin.Text = String.Empty;

            txtLibelle.Focus();

        }

        private void frmProduit_Load(object sender, EventArgs e)
        {
            ResetForm();

        }

		private void btnAjouter_Click(object sender, EventArgs e)
		{
			try
			{
				// Validation des champs
				if (string.IsNullOrWhiteSpace(txtLibelle.Text))
				{
					MessageBox.Show("Le libellé est obligatoire.", "Validation",
						MessageBoxButtons.OK, MessageBoxIcon.Warning);
					txtLibelle.Focus();
					return;
				}

				if (string.IsNullOrWhiteSpace(txtDescription.Text))
				{
					MessageBox.Show("La description est obligatoire.", "Validation",
						MessageBoxButtons.OK, MessageBoxIcon.Warning);
					txtDescription.Focus();
					return;
				}

				if (cbbUniteMesure.SelectedValue == null || cbbUniteMesure.SelectedValue.ToString() == "")
				{
					MessageBox.Show("Veuillez sélectionner une unité de mesure.", "Validation",
						MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				if (cbbCategorie.SelectedValue == null || cbbCategorie.SelectedValue.ToString() == "")
				{
					MessageBox.Show("Veuillez sélectionner une catégorie.", "Validation",
						MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				if (string.IsNullOrWhiteSpace(txtPrixUMin.Text) || string.IsNullOrWhiteSpace(txtPrixUMax.Text))
				{
					MessageBox.Show("Les prix sont obligatoires.", "Validation",
						MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				Produit p = new Produit();
				p.IdUniteMesure = int.Parse(cbbUniteMesure.SelectedValue.ToString());
				p.CategorieId = int.Parse(cbbCategorie.SelectedValue.ToString());
				p.LibelleProduit = txtLibelle.Text.Trim();
				p.DescriptionProduit = txtDescription.Text.Trim();
				p.PrixUnitaireMin = double.Parse(txtPrixUMin.Text);
				p.PrixUnitaireMax = double.Parse(txtPrixUMax.Text);

				db.produits.Add(p);
				db.SaveChanges();

				MessageBox.Show("Produit ajouté avec succès !", "Succès",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				ResetForm();
			}
			catch (Exception ex)
			{
				Utils.GererErreur("Ajout produit", ex);
			}
		}

		private void btnSelectionner_Click(object sender, EventArgs e)
		{
			try
			{
				if (dgProduit.CurrentRow == null)
				{
					MessageBox.Show("Veuillez sélectionner un produit.",
						"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}

				int id = int.Parse(dgProduit.CurrentRow.Cells[0].Value.ToString());
				var p = db.produits.Find(id);

				if (p == null)
				{
					MessageBox.Show("Produit introuvable.",
						"Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				txtDescription.Text = p.DescriptionProduit;
				txtLibelle.Text = p.LibelleProduit;
				txtPrixUMax.Text = p.PrixUnitaireMax.ToString();
				txtPrixUMin.Text = p.PrixUnitaireMin.ToString();
				cbbCategorie.SelectedValue = p.CategorieId.ToString();
				cbbUniteMesure.SelectedValue = p.IdUniteMesure.ToString();
			}
			catch (Exception ex)
			{
				Utils.GererErreur("Sélection produit", ex);
			}
		}

		private void btnSupprimer_Click(object sender, EventArgs e)
		{
			try
			{
				if (dgProduit.CurrentRow == null)
				{
					MessageBox.Show("Veuillez sélectionner un produit.",
						"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}

				DialogResult confirmation = MessageBox.Show(
					"Êtes-vous sûr de vouloir supprimer ce produit ?",
					"Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (confirmation == DialogResult.No) return;

				int id = int.Parse(dgProduit.CurrentRow.Cells[0].Value.ToString());
				var p = db.produits.Find(id);

				if (p == null)
				{
					MessageBox.Show("Produit introuvable.",
						"Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				db.produits.Remove(p);
				db.SaveChanges();
				MessageBox.Show("Produit supprimé avec succès !", "Succès",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				ResetForm();
			}
			catch (Exception ex)
			{
				Utils.GererErreur("Suppression produit", ex);
			}
		}

		private void btnModifier_Click(object sender, EventArgs e)
		{
			try
			{
				if (dgProduit.CurrentRow == null)
				{
					MessageBox.Show("Veuillez sélectionner un produit.",
						"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}

				int id = int.Parse(dgProduit.CurrentRow.Cells[0].Value.ToString());
				var p = db.produits.Find(id);

				if (p == null)
				{
					MessageBox.Show("Produit introuvable.",
						"Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				p.IdUniteMesure = int.Parse(cbbUniteMesure.SelectedValue.ToString());
				p.CategorieId = int.Parse(cbbCategorie.SelectedValue.ToString());
				p.LibelleProduit = txtLibelle.Text;
				p.DescriptionProduit = txtDescription.Text;
				p.PrixUnitaireMin = double.Parse(txtPrixUMin.Text);
				p.PrixUnitaireMax = double.Parse(txtPrixUMax.Text);

				db.SaveChanges();
				MessageBox.Show("Produit modifié avec succès !", "Succès",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				ResetForm();
			}
			catch (Exception ex)
			{
				Utils.GererErreur("Modification produit", ex);
			}
		}


        private void btnRechercher_Click(object sender, EventArgs e)
        {
            var liste = db.produits.ToList();
            if(!String.IsNullOrEmpty(txtRLibelle.Text))
            {
                liste = liste.Where(p => p.LibelleProduit.ToUpper().Contains(txtRLibelle.Text.ToUpper())).ToList();
            }
            if (!String.IsNullOrEmpty(txtRDescription.Text))
            {
                liste = liste.Where(p => p.DescriptionProduit.ToUpper().Contains(txtRDescription.Text.ToUpper())).ToList();
            }
            if (!String.IsNullOrEmpty(txtRPrixUMin.Text))
            {
                int prixMin = int.Parse(txtRPrixUMin.Text);
                liste = liste.Where(p => p.PrixUnitaireMin >= prixMin).ToList();
            }

            dgProduit.DataSource = liste.Select(u => new
            {
                u.IdProduit,
                u.LibelleProduit,
                u.DescriptionProduit,
                u.PrixUnitaireMin,
                u.PrixUnitaireMax,
                Categorie = db.categories.Find(u.CategorieId).DescriptionCategorie,
                UniteMesure = db.unitemesures.Find(u.IdUniteMesure).LibelleUnite
            }).ToList();
        }
    }
}
