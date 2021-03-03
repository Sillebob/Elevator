using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int sal = 0;
            string valg = "X";
            
            do
            {
                Console.WriteLine("Du er på {0} sal.", sal);//skal stå variablen sal og ikke 0 da den skal ændrer sig
                Console.WriteLine("Tast hvilken sal der skal køres til, denne elevator kører fra 0. til 8. sal");
                int salValg = int.Parse(Console.ReadLine());
                if (salValg > 8 || salValg < 0)//fejlmeddelelse hvis man vælger en sal der ikke findes
                {
                    Console.WriteLine("Denne sal findes ikke.");
                }else if (salValg < sal && salValg>=0)//sørger for at løkken kun kører hvis tallet er mellem 0 og det indtastede
                {
                    for (int i = sal; i >= salValg; i--)//kører nedad
                    {
                        System.Threading.Thread.Sleep(1000);//gør at der ventes 1 sekund før der udskrives
                        Console.WriteLine(i);
                        sal = i;//gemmer den sal man er på i i, så elevatoren starter derfra næste gang
                    }
                }
                if (salValg > sal && salValg<9) //sørger for at løkken kun kører fra det indtastede og til 8

                {
                    for (int i = sal; i <= salValg; i++)//kører opad
                    {
                        System.Threading.Thread.Sleep(1000);//gør at der ventes 1 sekund før der udskrives
                        Console.WriteLine(i);
                        sal = i;

                    }
                }
                
                Console.WriteLine("Tryk på en tast hvis du vil fortsætte ellers tast X for at afslutte.");
                valg = (Console.ReadLine()).ToUpper();//laver det til stor skrift så man kan indtaste både lille x og stort X
                
            } while (valg != "X");//den skal blive ved så længe brugeren ikke taster X

    {

            }

        }
       
        
    }
    
}
