using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gitflow_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<person> list = new List<person>();

            //Add Name under this line
            list.Add(new Sebastian());
            //Add Name above this line

            foreach (person person in list) {
                Console.WriteLine(person.getName());
            }
        }
    }
}
