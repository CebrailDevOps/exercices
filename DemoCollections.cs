using Logique;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercices
{
    public class DemoCollections : iCommand
    {
        public string Name => "01_DemoCollections";

        public void Execute()
        {
            ArrayList arraylist = new ArrayList();
            arraylist.Add(1);
            arraylist.Add("Toto");
            arraylist.Add(true);

            foreach (var item in arraylist)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine("\n______\n");
            Hashtable htable = new Hashtable();
            htable.Add(1, "Coucou");
            htable.Add("Salut", "Bob");
            foreach (DictionaryEntry item in htable)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
        }
        
    }
}
