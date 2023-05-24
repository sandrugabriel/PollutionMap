using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace PollutionMap.Models
{
    internal class Masurare
    {

        private int id;
        private int idHarta;
        private int pozX;
        private int pozY;
        private double valuareMasurare;
        private DateTime dataMasurare;

        public Masurare(int id, int idHarta, int pozX, int pozY, double valuareMasurare, DateTime dataMasurare)
        {
            this.id = id;
            this.idHarta = idHarta;
            this.pozX = pozX;
            this.pozY = pozY;
            this.valuareMasurare = valuareMasurare;
            this.dataMasurare = dataMasurare;
        }

        public Masurare(string text)
        {

            string[] prop = text.Split('#');

            this.id = int.Parse(prop[0]);
            this.idHarta = int.Parse(prop[1]);
            this.pozX = int.Parse(prop[2]);
            this.pozY = int.Parse(prop[3]);
            this.valuareMasurare = double.Parse(prop[4]);
            this.dataMasurare = DateTime.Parse(prop[5]);

        }

        public int getId()
        {
            return id;
        }


        public int getIdHarta()
        {
            return this.idHarta;
        }

        public int getPozX()
        {
            return this.pozX;
        }

        public int getPozY()
        {
            return this.pozY;
        }
        
        public double getValoaremasurare()
        {
            return valuareMasurare;
        }

        public DateTime getDatemasurare()
        {
            return dataMasurare;
        }

    }
}
