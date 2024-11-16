using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ayyyy
{
    class Article
    {
        public person person;
        public string statia;
        public double rate;

        public string ToFullString()
        {
            return $"person: {person}\nStatia: {statia}\nrate: {rate}";
        }

        public Article()
        {
            person = new person();
            statia = "aaaa";
            rate = 52;


        }
    }
}
