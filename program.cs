UNE LIGNE AJOUTEE PAR ELENA
LIGNE AJOUTEE PAR VIVIEN
/*-----------------------
----- Program.cs --------
-----------------------*/

C'est une ligne s�rieuse �crite par Elena


/* Nouvelle ligne exemple modification */

/* Nouvelle ligne uniquement dans la branche test */

Une autre modification sur la meme ligne
Une modification sur cette ligne

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesDifferentsTris
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = new string[] { "toto" , "titi", "tutu" };
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write(data[i] + " ");
            }
            data = SortingAlgortihms.ComputeArray(data, SortingAlgortihms.SortingTypes.InsertionSort);

            for(int i = 0; i < data.Length; i++)
            {
                Console.Write(data[i]+ " "); 
            }

            data = new string[] { "toto", "titi", "tutu" };
            data = SortingAlgortihms.ComputeArray(data, SortingAlgortihms.SortingTypes.BubbleSort);

            for (int i = 0; i < data.Length; i++)
            {
                Console.Write(data[i] + " ");
            }

            data = new string[] { "toto", "titi", "tutu" };
            data = SortingAlgortihms.ComputeArray(data, SortingAlgortihms.SortingTypes.BubbleSort);

            for (int i = 0; i < data.Length; i++)
            {
                Console.Write(data[i] + " ");
            }


            Console.ReadLine();
        }
    }
}
