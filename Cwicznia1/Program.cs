using System;

namespace Cwicznia1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[] { 2, 3, 4, 5, 6, 3, 3, 31, 4 };

            for(int i = 0; i<=8; i++)
            {
                Console.Write(tab[i] + ",");
            }

            Console.WriteLine();
            // porównywanie liczb 

            int l1, l2, l3;
            Console.WriteLine("Podaj liczbę ");
            l1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę ");
            l2 = Int32.Parse(Console.ReadLine());

           

            if(l1<l2)
            {
                Console.WriteLine("Liczba " + l2 + " jest większa od liczby " + l1);
            }else if (l2<l1)
            {
                Console.WriteLine("Liczba " + l2 + " jest większa od liczby " + l1);
            }else
            {
                Console.WriteLine("Liczby sa równe ");
            }

            // Sprawdzanie warunku istnienia trójkąta 

            Console.WriteLine();
            Console.WriteLine("Warunek trójkąta");
            Console.WriteLine();

            int bok1, bok2, bok3;
            Console.WriteLine("Podaj długość boku trójkąta");
            bok1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj długość boku trójkąta");
            bok2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj długość boku trójkąta");
            bok3 = Int32.Parse(Console.ReadLine());

            // sprawdanie który z boków jest najdłuższy i przypisanie go do zmiennej 


            int longer, sh1, sh2;
            if (bok1 > bok2)
            {
                sh1 = bok2;
                if (bok1 > bok3)
                {
                    longer = bok1;
                    sh2 = bok3;
                }
                else
                {
                    longer = bok3;
                    sh2 = bok1;
                }
            }
            else
            {
                sh1 = bok1;
                if (bok2 > bok3)
                {
                    longer = bok2;
                    sh2 = bok3;

                }
                else
                {
                    longer = bok3;
                    sh2 = bok2;
                }
            }
           

            if (sh1 + sh2 > longer)
            {
                Console.Write("Z tych boków da się zbuować trójkąt ");
               
            }else
                {
                    Console.Write("Z tych boków NIE da się zbuować trójkąt ");
                }



            // Program wczytujący liczbę ograniczona z góry i dołu do następnie odejmowł 1 i wypisywał ja 


            Console.WriteLine("podaj liczbe z przedziały <5 15>");
            int liczba = Int32.Parse(Console.ReadLine());

            if(liczba >15 | liczba<5)
            {
                Console.WriteLine("Podana liczba nie mieści sie w przedzaile ");

            }else
            {
                while(liczba>0)
                {
                    Console.WriteLine(liczba);
                    liczba--;
                }
            }

            //Program sprawdzajacy wykorzystujacy do while 
            /*
               Stwórz program, który będzie wczytywał liczbę podaną przez użytkownika.
               Następnie sprawdź czy liczba spełnia podane wymagania(np. > 4, < 7, != 10 itp.).
               Jeśli liczba 

                  wyświetl komunikat kończący, jeśli nie, wyświetl prośbę o wczytanie liczby. 
               Użyj do tego pętli do ...while.
            */

            Console.WriteLine();
            Console.WriteLine("Podaj liczbe ");
            liczba = Int32.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("Podaj liczbe spełniającą warunke  ");
                liczba = Int32.Parse(Console.ReadLine());


                if (liczba < 4 | liczba > 7 & liczba != 10)
                {
                    Console.WriteLine("Liczba spełniła warunek  ");
                    break;
                }

            } while (true);

        }
    }
}
