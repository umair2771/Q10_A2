using System;
using System.Linq;



namespace A2_Q10
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Write Number of elements to be entered in an array !");
                int Number = Convert.ToInt32(Console.ReadLine());

                int[] A = new int[Number];     // input array 
                int[] even = new int[Number]; // even array 
                int[] odd = new int[Number];  //odd array

                Console.WriteLine("Write elements to be entered in an array !\n");

                for (int i = 0; i < Number; i++)
                {
                    Console.Write("Number at Index  " + i + " = ");
                    A[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("Entered Array is (A) \n ");

                for (int m = 0; m < Number; m++)
                {
                    Console.Write(" " + A[m] + " ");

                    if (A[m] % 2 == 0)
                    {
                        even[m] = A[m];
                    }
                    else
                    {
                        odd[m] = A[m];
                    }
                }

                odd = even.Concat(odd).ToArray();

                Console.WriteLine("\nFinal Array  (even numbers first and odd numbers second)is\n ");
                odd = odd.Where(e => e != 0).ToArray();
                Console.WriteLine(String.Join(" ", odd));


            }
        }
    }

    

