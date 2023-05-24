using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PollutionMap.Models
{
    internal class Harta
    {

        private int id;
        private string nameHarta;
        private string nameFisier;

        public Harta(int id, string nameHarta, string nameFisier)
        {
            this.id = id;
            this.nameHarta = nameHarta;
            this.nameFisier = nameFisier;
        }

        public Harta(string text)
        {
            string[] prop = text.Split('#');

            this.id = int.Parse(prop[0]);
            this.nameHarta = prop[1];
            this.nameFisier = prop[2];
        }

        public int getId()
        {
            return id;
        }

        public string getNameHarta()
        {
            return nameHarta;
        }

        public string getNameFisier()
        {
            return nameFisier;
        }

    }
}
