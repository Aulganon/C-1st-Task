using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace graf1
{
    internal class Program
    {

        static void SubMain(List<List<int>> Array)
        {

            Console.WriteLine("Select graph's vertex \nNote that position " +
                "of 0 graph is restrincted");
            int counter = 1;
            int vertex_number = Int32.Parse(Console.ReadLine());

            if (vertex_number > 0 && vertex_number <= Array.Count)
            {
                
                foreach (var sublists in Array)
                {

                    //Searching for the right row in matrix
                    if (counter == vertex_number)
                    {
                        int element_counter = 1;
                        // On selected row(graph's vertex means) check what 
                        // positions are equal to zero
                        // self adjacency to vertex is a possibility
                        foreach (var element in sublists) {
                           
                            if (element == 0 && vertex_number != element_counter)
                            {
                                Console.WriteLine(String.Format("Vertex {0} is non-adjacted",
                                    element_counter)); 
                            }
                            element_counter++;
                        }
                        break;
                    }
                    else
                    {
                        counter++;
                        continue;
                    }
                }
            }
            // exceptions only 
            else if (vertex_number > Array.Count)
            {
                Console.WriteLine("Are you OK? You require numbers that isn't stated in adjacency matrix." +
                    "\n Change the number of vertex or add some more rows&collumns " +
                    "into adjacency matrix.");
            }
            else
            {
                Console.WriteLine("Wrong vertex number. " +
                    "Plaese try another");
            }
        }


        static void Main(string[] args)
        {
            
            string path = Matrix.GetPath();
            List<List<int>> Array = Matrix.ExtractFromFile(path);
            SubMain(Array);
            Console.WriteLine("\n\n\n\nPress ANY KEY to EXIT");
            Console.ReadKey();
        }
    }
}
