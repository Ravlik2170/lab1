using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ayyyy
{
    class Program
    {
        static void Main(string[] args)
        {

            person person1 = new person();

            person1.Name = "Pavel";
            person1.familia = "Deev";
            person1.dateofbirth = new DateTime(2002, 04, 26);
            person1.frequency = Frequency.Yearly;

            Article article1 = new Article();

            article1.person = person1;

            Console.WriteLine(person1.Name);
            Console.WriteLine(person1.familia);
            Console.WriteLine(person1.dateofbirth);
            Console.WriteLine(person1.frequency);
            Console.WriteLine(article1.person);



        }
    }
}
