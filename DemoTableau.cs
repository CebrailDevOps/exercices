using Logique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercices
{
    public class DemoTableau : iCommand
    {
        public string Name => "01_DemoTableau";

        public void Execute()
        {
            //int[] tab1Dim = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] tab1Dim = new int[10];
            for (int i = 0; i < tab1Dim.Length; i++)
            {
                tab1Dim[i] = i;
                Console.Write(tab1Dim[i]+" ");
            }
            Console.WriteLine("\n______\n");
            //int[,] tab2Dim = { { 0, 1, 2, 3, 4 },{ 5,6,7,8,9} };
            int[,] tab2Dim = new int[2, 5];
            int cpt = 0;
            for (int i = 0;i < tab2Dim.GetLength(0); i++)
            {
                for (int j = 0;j < tab2Dim.GetLength(1); j++)
                {
                    tab2Dim[i,j] = cpt++;
                    Console.Write(tab2Dim[i,j]+" ");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine("______\n");
            int[][] tabTest = new int[2][];
            tabTest[0] = new int[] {3,4,5};
            tabTest[1] = new int[] { 6, 7, 8, 20};
            foreach (var item in tabTest)
            {
                foreach (var item1 in item)
                {
                    Console.Write(item1+" ");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine("______\n");
        }
    }
}
