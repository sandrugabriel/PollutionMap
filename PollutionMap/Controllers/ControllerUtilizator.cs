using PollutionMap.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PollutionMap.Controllers
{
    internal class ControllerUtilizator
    {

        private List<Utilizator> utilizatorii;

        public ControllerUtilizator()
        {

            utilizatorii = new List<Utilizator>();

            load();

        }

        public void load()
        {

            string path = Application.StartupPath + @"/data/utilizatori.txt";

            StreamReader streamReader = new StreamReader(path);

            string text;

            while ((text = streamReader.ReadLine()) != null)
            {

                Utilizator a = new Utilizator(text);
                utilizatorii.Add(a);

            }

            streamReader.Close();
        }

        public bool verification(string pass, string name)
        {
            for (int i = 0; i < utilizatorii.Count; i++)
            {

                if (utilizatorii[i].getPassword().Equals(pass) && utilizatorii[i].getName().Equals(name))
                {
                    return true;
                }

            }

            return false;
        
        }

        public bool verificationPassword(string password)
        {

            if (password.Count() <= 8)
            {
                return false;
            }

            int semn = 0;
            int semn1 = 0;
            for (int i = 0; i < password.Count(); i++)
            {
                if ((int)password[i] >= 65 && (int)password[i] <= 90)
                {

                    semn = 1;

                }

                if ((int)password[i] >= 48 && (int)password[i] <= 57)
                {
                    semn1 = 1;

                }


            }

            if (semn == 1 && semn1 == 1)
            {
                return true;
            }


            return false;

        }


        public string namebyid(int id)
        {

            for (int i = 0; i < utilizatorii.Count; i++)
            {
                if (utilizatorii[i].getId() == id)
                {
                    return utilizatorii[i].getName();
                }
            }
            return null;
        }

        public int idBynamePass(string pass, string name)
        {
            for (int i = 0; i < utilizatorii.Count; i++)
            {

                if (utilizatorii[i].getPassword().Equals(pass) && utilizatorii[i].getName().Equals(name))
                {
                    return utilizatorii[i].getId();
                }

            }


            return -1;
        }

        public string emailBynamePass(string pass, string name)
        {
            for (int i = 0; i < utilizatorii.Count; i++)
            {

                if (utilizatorii[i].getPassword().Equals(pass) && utilizatorii[i].getName().Equals(name))
                {
                    return utilizatorii[i].getemail();
                }

            }


            return null;
        }

        public Utilizator getClientById(int id)
        {

            for (int i = 0; i < utilizatorii.Count; i++)
            {
                if (utilizatorii[i].getId() == id)
                {
                    return utilizatorii[i];
                }
            }

            return null;
        }

        public int generareId()
        {
            Random random = new Random();

            int id = random.Next();
            while (this.getClientById(id) != null)
            {

                id = random.Next();

            }


            return id;

        }

        public void save(string textul)
        {

            string text = textul;
            string path = Application.StartupPath + @"/data/utilizatori.txt";
            File.AppendAllText(path, text + "\n");


        }


        public string toSaveFisier()
        {

            string t = "";

            for (int i = 0; i < utilizatorii.Count; i++)
            {
                t += utilizatorii[i].toSave() + "\n";
            }

            return t;
        }

        public void update()
        {
            String path = Application.StartupPath + @"/data/utilizatori.txt";
            StreamWriter streamWriter = new StreamWriter(path);

            streamWriter.Write(this.toSaveFisier());

            streamWriter.Close();
        }

        public void setDateTime(int id, DateTime dateTime)
        {

            for (int i = 0; i < utilizatorii.Count; i++)
            {
                if (utilizatorii[i].getId() == id)
                {
                    utilizatorii[i].setDateTime(dateTime);
                }
            }


        }


        public Utilizator utilizatorbyId(int id)
        {

            for(int i=0;i<utilizatorii.Count;i++)
            {
                if (utilizatorii[i].getId() == id)
                {
                    return utilizatorii[i];
                }
            }

            return null;
        }

    }
}
