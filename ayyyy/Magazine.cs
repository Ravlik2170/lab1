using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ayyyy
{
    class Magazine
    {
        public string Name;
        public Frequency frequency;
        public DateTime data_vihoda;
        public int tiraj;
        public Article[] spisok;

        public Magazine()
        {
            Name = "ooo";
            data_vihoda = new DateTime(2024, 05, 18);
            tiraj = 55;
            spisok = new Article[0];
        }

        public string GetName()
        {
            return Name;
        }
        public void SetName(string value)
        {
            Name = value;
        }



    }
}
