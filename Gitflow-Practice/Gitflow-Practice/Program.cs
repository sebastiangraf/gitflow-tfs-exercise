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

            //Add Name over here
            list.Add(new Sebastian());

            foreach (person person in list) {
                Console.WriteLine(person.getName());
            }
        }
    }
}
