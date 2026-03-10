using AppSenAgriculture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSenAgriculture.Helpers
{
    public class FillList
    {
        BdSenAgricultureContext db = new BdSenAgricultureContext();

        /// <summary>
        /// chargemnt sur une  liste de tous les unites de mesure
        /// </summary>
        /// <returns></returns>

        public List<ListItem> fillUniteMesure()
        {
            List<ListItem> laListe = new List<ListItem>();
            var liste = db.unitemesures.ToList();
            laListe.Add(new ListItem 
            { 
                Value = null,
                Text = "Selectionner...."
            });
            foreach (var t in liste)
            {
               var item = new ListItem
                {
                    Value = t.IdUnite.ToString(),
                    Text = t.LibelleUnite.ToString()
               };
                laListe.Add(item);
            }
            return laListe;
        }


        /// <summary>
        /// chargemnt sur une  liste dez categories de produits
        /// </summary>
        /// <returns></returns>

        public List<ListItem> fillCategorie()
        {
            List<ListItem> laListe = new List<ListItem>();
            var liste = db.categories.ToList();
            laListe.Add(new ListItem
            {
                Value = null,
                Text = "Selectionner...."
            });
            foreach (var t in liste)
            {
                var item = new ListItem
                {
                    Value = t.IdCategorie.ToString(),
                    Text = t.DescriptionCategorie.ToString()
                };
                laListe.Add(item);
            }
            return laListe;
        }
    }
}
