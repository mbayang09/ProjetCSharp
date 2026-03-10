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
using AppSenAgriculture.Models;

namespace AppSenAgriculture.Views.Parametre
{
    public partial class frmCategorie : Form
    {
        public frmCategorie()
        {
            InitializeComponent();
        }
        BdSenAgricultureContext db=new BdSenAgricultureContext();
        private void Effacer()
        {
            txtCode.Text=string.Empty;
            txtLibelle.Text=string.Empty;
            dgCategorie.DataSource = db.categories.ToList();
        }
        
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                Categorie c = new Categorie();
                c.LibelleCategorie = txtCode.Text;
                c.DescriptionCategorie= txtLibelle.Text;
                db.categories.Add(c);
                db.SaveChanges();
                Effacer();
                
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            if (dgCategorie.CurrentRow != null)
            {
                var row = dgCategorie.CurrentRow;
                txtCode.Text = (row.Cells.Count > 1 && row.Cells[1].Value != null) ? row.Cells[1].Value.ToString() : string.Empty;
                txtLibelle.Text = (row.Cells.Count > 2 && row.Cells[2].Value != null) ? row.Cells[2].Value.ToString() : string.Empty;
            }
            else
            {
                MessageBox.Show("Aucune ligne sélectionnée.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgCategorie.CurrentRow == null)
                {
                    MessageBox.Show("Aucune ligne sélectionnée.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int id = int.Parse(dgCategorie.CurrentRow.Cells[0].Value.ToString());
                Categorie c = db.categories.Find(id);
                if (c == null)
                {
                    MessageBox.Show("Catégorie introuvable.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                c.LibelleCategorie = txtCode.Text;
                c.DescriptionCategorie = txtLibelle.Text;
                // No Add here: entity is tracked after Find
                db.SaveChanges();
                Effacer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }

        private void frmCategorie_Load(object sender, EventArgs e)
        {
            Effacer();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                int? id = int.Parse(dgCategorie.CurrentRow.Cells[0].Value.ToString());
                Categorie c = db.categories.Find(id);
                db.categories.Remove(c);
                db.SaveChanges();
                Effacer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
