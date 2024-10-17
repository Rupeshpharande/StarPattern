using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal class Pattern9
    {
        //    ab
        //  ababab
        //ababababab

        static void Main(string[] args)
        {
            int n = 3;
            
            for (int i =1; i <= n; i++)
            {
                for (int j = i; j < n; j++)
                { 
                    Console.Write("");

                }
                for (int k = i; k <= n; k++)

                {
                    Console.Write(" ab");

                }

                Console.WriteLine();
            }
            }

        }
    }

