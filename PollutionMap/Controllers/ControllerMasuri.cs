using PollutionMap.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PollutionMap.Controllers
{
    internal class ControllerMasuri
    {

        private List<Masurare> masurari;

        public ControllerMasuri()
        {

            masurari = new List<Masurare>();

            load();


        }

        public void load()
        {

            string path = Application.StartupPath + @"/data/masurari.txt";
            StreamReader streamReader = new StreamReader(path);

            string t;

            while((t = streamReader.ReadLine()) != null)
            {
                Masurare masurare = new Masurare(t);
                masurari.Add(masurare);
            }

            streamReader.Close();
        }


        public List<Masurare> getMasurare(int idHarta, DateTime dateTime)
        {

            List<Masurare> list = new List<Masurare>();

            for(int i=0;i<masurari.Count;i++)
            {

                if (masurari[i].getIdHarta() == idHarta && masurari[i].getDatemasurare() == dateTime)
                {
                    list.Add(masurari[i]);
                }

            }


            return list;
        }

        public List<Masurare> getMasurareVal20(int idHarta, DateTime dateTime)
        {

            List<Masurare> list = new List<Masurare>();

            for (int i = 0; i < masurari.Count; i++)
            {

                if (masurari[i].getIdHarta() == idHarta && masurari[i].getDatemasurare() == dateTime && masurari[i].getValoaremasurare()<20 )
                {
                    list.Add(masurari[i]);
                }

            }


            return list;
        }

        public List<Masurare> getMasurareVal2040(int idHarta, DateTime dateTime)
        {

            List<Masurare> list = new List<Masurare>();

            for (int i = 0; i < masurari.Count; i++)
            {

                if (masurari[i].getIdHarta() == idHarta && masurari[i].getDatemasurare() == dateTime && masurari[i].getValoaremasurare() >= 20 && masurari[i].getValoaremasurare() <= 40)
                {
                    list.Add(masurari[i]);
                }

            }


            return list;
        }

        public List<Masurare> getMasurareVal40(int idHarta, DateTime dateTime)
        {

            List<Masurare> list = new List<Masurare>();

            for (int i = 0; i < masurari.Count; i++)
            {

                if (masurari[i].getIdHarta() == idHarta && masurari[i].getDatemasurare() == dateTime && masurari[i].getValoaremasurare() > 40)
                {
                    list.Add(masurari[i]);
                }

            }


            return list;
        }

        public Masurare getMasurareById(int id)
        {

            for (int i = 0; i < masurari.Count; i++)
            {
                if (masurari[i].getId() == id)
                {
                    return masurari[i];
                }
            }

            return null;
        }

        public int generareId()
        {
            Random random = new Random();

            int id = random.Next();
            while (this.getMasurareById(id) != null)
            {

                id = random.Next();

            }


            return id;

        }

        public void save(string textul)
        {

            string text = textul;
            string path = Application.StartupPath + @"/data/masurari.txt";
            File.AppendAllText(path, text + "\n");


        }



    }
}
