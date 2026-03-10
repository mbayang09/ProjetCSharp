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
            Produit p = new Produit();
            {
                p.IdUniteMesure = int.Parse(cbbUniteMesure.SelectedValue.ToString());
                p.CategorieId = int.Parse(cbbCategorie.SelectedValue.ToString());
                p.LibelleProduit = txtLibelle.Text;
                p.DescriptionProduit = txtDescription.Text;
                p.PrixUnitaireMin=double.Parse(txtPrixUMin.Text);
                p.PrixUnitaireMax = double.Parse(txtPrixUMax.Text);
                db.produits.Add(p);
                db.SaveChanges();
                ResetForm();
            }
            ;
        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgProduit.CurrentRow.Cells[0].Value.ToString());
            var p = db.produits.Find(id);
           txtDescription.Text = p.DescriptionProduit;
            txtLibelle.Text = p.LibelleProduit;
            txtPrixUMax.Text = p.PrixUnitaireMax.ToString();
            txtPrixUMin.Text = p.PrixUnitaireMin.ToString();
            cbbCategorie.SelectedIndex = p.CategorieId;
            cbbUniteMesure.SelectedIndex = p.IdUniteMesure;
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgProduit.CurrentRow.Cells[0].Value.ToString());
            var p = db.produits.Find(id);
            db.produits.Remove(p);
            db.SaveChanges();
            ResetForm();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgProduit.CurrentRow.Cells[0].Value.ToString());
            var p = db.produits.Find(id);
            p.IdUniteMesure = int.Parse(cbbUniteMesure.SelectedValue.ToString());
            p.CategorieId = int.Parse(cbbCategorie.SelectedValue.ToString());
            p.LibelleProduit = txtLibelle.Text;
            p.DescriptionProduit = txtDescription.Text;
            p.PrixUnitaireMin = double.Parse(txtPrixUMin.Text);
            p.PrixUnitaireMax = double.Parse(txtPrixUMax.Text);
            db.SaveChanges();
            ResetForm();
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
