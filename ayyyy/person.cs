using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ayyyy
{
    class person
    {


        public Frequency frequency;
        public string Name;
        public string familia;
        public DateTime dateofbirth;

        Article[] disciplines = new Article[5];

        public person()
        {
            Name = "Pavel";
            familia = "Deev";
            dateofbirth = new DateTime(2002, 04, 26);
        }   

        public string GetName()
        {
            return Name;
        }

        public void SetName(string value)
        {
            Name = value;
        }

        public string GetFamilia()
        {
            return familia;
        }

        public void SetFamilia(string value)
        {
            familia = value;
        }

        public DateTime dateofvirth()
        {
            return dateofbirth;
        }

        public void SetDate(DateTime value)
        {
            dateofbirth = value;
        }



    }




}
