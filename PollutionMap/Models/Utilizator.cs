using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PollutionMap.Models
{
    internal class Utilizator
    {

        private int id;
        private string name;
        private string password;
        private string email;
        private DateTime dateTime;

        public Utilizator(int id, string name, string password, string email, DateTime dateTime)
        {
            this.id = id;
            this.name = name;
            this.password = password;
            this.email = email;
            this.dateTime = dateTime;
        }

        public Utilizator(string text)
        {
            string[] prop = text.Split('#');

            this.id = int.Parse(prop[0]);
            this.name = prop[1];
            this.password = prop[2];
            this.email = prop[3];
            this.dateTime = DateTime.Parse(prop[4]);

        }

        public int getId()
        {
            return id;
        }

        public string getName()
        {
            return name;
        }

        public string getPassword()
        {
            return password;
        }

        public string getemail()
        {
            return email;
        }

        public DateTime getDateTime()
        {
            return dateTime;
        }


    }
}
