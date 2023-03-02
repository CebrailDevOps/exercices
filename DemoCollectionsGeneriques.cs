using Logique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercices
{
    public class DemoCollectionsGeneriques : iCommand
    {
        public string Name => "02_DemoCollections";

        public void Execute()
        {
            List<string> list = new List<string>();
            list.Add("Coucou");
            list.Add("les Devops");
            list.Add("ça boum ?");
            list.Add("ttt");
            
            Console.WriteLine(list[3]);
            Console.WriteLine("\n______\n");
            foreach (string s in list)
            {
                Console.Write(s+" ");
            }
            Console.WriteLine("\n______\n");

            Dictionary<int,string> dict = new Dictionary<int,string>();
            dict.Add(1, "Coucou");
            dict.Add(3, "Salut");
            dict.Add(5, "Salam");
            Console.WriteLine(dict[3]);
            foreach (KeyValuePair<int,string> kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} : {kvp.Value}");
            }

            Stack<string> stack = new Stack<string>();
            stack.Push("Un");
            stack.Push("Deux");
            stack.Push("Trois");
            foreach (string s in stack)
            {
                Console.WriteLine(s);
            }
        }
    }
}
