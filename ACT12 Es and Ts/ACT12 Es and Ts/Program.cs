using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT12_Es_and_Ts
{
    internal class Program
    {

        static void Main(string[] args)
        {
        string str = System.IO.File.ReadAllText("C:/Users/grigg/Desktop/test.txt");

            int EorT = 0;
            
            // separating each word
            String[] arr = str.Split(' ', '.');

            // looping for the amount of words
            for (int i = 0; i < arr.Length; i++)
            {

                // Condition to check if the
                // array element is present
                // the hash-map
                if (arr[i].EndsWith("e") || arr[i].EndsWith("t"))
                {
                    EorT ++;
                }
                
            }

            
            
            {
                Console.WriteLine("There are " + EorT + " words that end with 'e' or 't'. ");
            }
        }

        
        
    }
    }
    

