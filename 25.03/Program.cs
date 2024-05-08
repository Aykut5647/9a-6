using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolko danni shte vivejdash?: ");
            int n =int.Parse(Console.ReadLine());
            string[] pitie = new string[n];
            double[] kolicestvo=new double[n];
            int[] broyka=new int[n];         

            for(int i=0; i<n; i++)
            {
                Console.WriteLine("Pitieta: ");
                pitie[i] = Console.ReadLine();
                Console.WriteLine("Kolicestvo: ");
                kolicestvo[i]=double.Parse(Console.ReadLine());
                Console.WriteLine("Broy: ");
                broyka[i] = int.Parse(Console.ReadLine());
            }
            //Izhod 1
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Ti piesh ", pitie[i],"samo ", broyka[i],"broyka");
            }
            //Izhod 2
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Tvoite ", kolicestvo[i],"litri sa ", (kolicestvo[i] * 100),"mililitri");
            }
            //Izhod 3
            for (int i = 0; i < n; i++)
            {
                if (broyka[i] >= 2) 
                {
                    Console.Write("");
                }
            }
            //Izhod 4
            for(int i = 0; i < n -1;i++)
            {
                for(int j = i; j < n-1-i;j++)
                {
                    if (broyka[j] < broyka[j+1])
                    {
                        int swapInt = broyka[j];
                        broyka[j] = broyka[j+1];
                        broyka[j+1] = swapInt;
                    }
                }
            }
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(broyka[i] + " ");
            }
            //Izhod 5
            for(int i = 0; i < n; i++)
            {
                if (pitie[i] == pitie[i])
                {
                    for (int j = 0; j < n - 1; j++)
                    {
                        for (int k = j; k < n - 1 - j; k++)
                        {
                            if (broyka[j] < broyka[j + 1])
                            {
                                int swapInt2 = broyka[j];
                                broyka[j] = broyka[j + 1];
                                broyka[j + 1] = swapInt2;
                            }
                        }
                    }
                    for (int j = 0; j < n - 1; j++)
                    {
                        Console.Write(broyka[j] + " ");
                    }
                }
            }
            //Izhod 6-
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i; j < n - 1 - i; j++)
                {
                    if (String.Compare(pitie[j], pitie[j+1])>0) 
                    {
                        int swapInt3 = broyka[j];
                        broyka[j] = broyka[j + 1];
                        broyka[j + 1] = swapInt3;
                    }
                }
            }
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(broyka[i] + " ");
            }
        }
    }
}
