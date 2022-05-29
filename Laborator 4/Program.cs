using System;

namespace Laborator_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Laborator 4 - Exercitii

            //Exercitiu1();
            //Exercitiu2();
            //Exercitiu3();
            //Exercitiu4();
            //Exercitiu5a();
            //Exercitiu5b();
            //Exercitiu6();
            //Exercitiu7();

            // Sa nu uitati sa salvati in mod frecvent (Ctrl+S) pentru a nu pierde munca
            Console.ReadLine();
        }

        static void Exercitiu1()
        {
            //Scrieti un program care va citi un vector de intregi de dimensiune n de la tastaura. Scrieti o
            //functie care va inversa elementele vectorului, apelati-o si afisati-I rezultatul.

            int i, n;
            int[] vectorIntregi = new int[100];

            Console.Write("Introduceti numarul de elemente stocate in matrice: ");
            n = int.Parse(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                Console.Write("Elementul - {0} : ", i);
                vectorIntregi[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("\nValorile matritei sunt: \n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0} ", vectorIntregi[i]);
            }

            Console.Write("\n\nValorile inverse sunt: \n");
            for (i = n - 1; i >= 0; i--)
            {
                Console.Write("{0} ", vectorIntregi[i]);
            }
            Console.Write("\n\n");
        }

        static void Exercitiu2()
        {
            //Cititi de la tastatura continutul unei matrici de intregi cu 3 dimensiuni avand lungimile n, m, k.
            //Lungimile celor trei dimensiuni ale matricii, n, m si k, vor fi citite de la tastaura.
            // 1. Scrieti o functie care va calcula suma elementelor unei astfel de matrici , apelati-o si afisati-i rezultatul.
            // 2. Scrieti o functie care va determina elementul cu valoare maxima, apelati-o si afisati-i rezultatul.

            Console.WriteLine("Introduceti n");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti m");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti k");
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti elementele primei matrici");
            int[,,] matrice1 = CitesteMatrice(n, m, k);

            Console.WriteLine("Introduceti elementele celei de-a doua matrici");
            int[,,] matrice2 = CitesteMatrice(n, m, k);

            Console.WriteLine("Introduceti elementele celei de-al treilea matrici");
            int[,,] matrice3 = CitesteMatrice(n, m, k);

            AfiseazaMatricea(matrice1);
            Console.WriteLine();

            AfiseazaMatricea(matrice2);
            Console.WriteLine();

            AfiseazaMatricea(matrice3);
            Console.WriteLine();

            Console.WriteLine("Rezultatul adunarii este: ");
        }
        static int[,,] CitesteMatrice(int n, int m, int k)
        {
            int[,,] matrix = new int[n, m, k];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    for (int z = 0; z < k; z++)
                    {
                        Console.WriteLine("Introduceti Numarul");
                        matrix[i, j, z] = int.Parse(Console.ReadLine());
                    }
                }
            }
            return matrix;
        }
        static void AfiseazaMatricea(int[,,] matrice)
        {
            foreach (int element in matrice)
            {
                Console.Write(element);
            }
        }
        static void Exercitiu3()
        {
            //Cititi de la tastatura continutul unei matrici de intregi cu 2 dimensiuni avand lungimile n m, respectiv n, m.
            //Lungimile celor doua dimensiuni ale matricii, m si n, vor fi citite de la 
            //tastaura.Scrieti o functie care va calcula produsul celor doua matrici, apelati-o si afisati-I rezultatul.

            Console.WriteLine("Introduceti n");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti m");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti elementele primei matrici");
            int[,] matrice1 = CitesteMatrice2(n, m);

            Console.WriteLine("Introduceti elementele celei de-a doua matrici");
            int[,] matrice2 = CitesteMatrice2(n, m);

            AfiseazaMatricea1(matrice1);
            Console.WriteLine();

            AfiseazaMatricea1(matrice2);
            Console.WriteLine();

            ProdusulMatricei();
            Console.WriteLine();
        }
        static int[,] CitesteMatrice2(int n, int m)
        {
            int[,] matrix1 = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine("Introduceti Numarul");
                    matrix1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return matrix1;
        }

        static void ProdusulMatricei()
        {

            int rand1, coloana1, rand2, coloana2, n, m;

            int[,] matrice1 = CitesteMatrice2(n, m);
            int[,] matrice2 = CitesteMatrice2(n, m);

            //Calculam numarul de randuri si coloane din prima matrita

            rand1 = matrice1.GetLength(0);
            coloana1 = matrice1.GetLength(1);

            //Calculam numarul de randuri si coloane din a doua matrita

            rand2 = matrice2.GetLength(0);
            coloana2 = matrice2.GetLength(1);

            //Pentru ca cele doua matrite sa fie multiplicate, numarul coloanelor din prima matrita trebuie sa fie egale cu numarul randurilor in matrita a doua

            if (coloana1 != rand2)
            {
                Console.WriteLine("Matritele nu pot fi multiplicate!");
            }
            else
            {
                //Matrita Produs va tine rezultatul
                int[,] produs = new int[rand1, coloana1];

                //Realizează produsul matricelor matrice1 si matrice2. Stocam rezultatul în matrice produs
                for (int i = 0; i < rand1; i++)
                {
                    for (int j = 0; j < coloana2; j++)
                    {
                        for (int k = 0; k < rand2; k++)
                        {
                            produs[i, j] = produs[i, j] + matrice1[i, k] * matrice2[k, j];
                        }
                    }
                }
                Console.WriteLine("Produsul a celor doua matrite este: ");
                for (int i = 0; i < rand1; i++)
                {
                    for (int j = 0; j < coloana2; j++)
                    {
                        Console.Write(produs[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }

        static void AfiseazaMatricea1(int[,] matrita)
        {
            foreach (int element in matrita)
            {
                Console.Write(element);
            }
        }
        static void Exercitiu4()
        {
            //Scrieti o functie recursiva care va afisa in ordine elementele unui vector de intregi.
            {
                static void SortareBubble(int[] matrice, int n)
                {
                    // Daca dimensiunea matricei = 1, facem return
                    if (n == 1)
                        return;

                    // O trecere de tip bula
                    // Dupa aceasta trecere,
                    // cel mai mare element
                    // este miscat (sau bubbled)
                    // la sfarsit.
                    for (int i = 0; i < n - 1; i++)
                        if (matrice[i] > matrice[i + 1])
                        {
                            // schimb arr[i], arr[i+1]
                            int temp = matrice[i];
                            matrice[i] = matrice[i + 1];
                            matrice[i + 1] = temp;
                        }

                    // Cel mai mare element este fixat,
                    // recure pentru matricea ramasa
                    SortareBubble(matrice, n - 1);
                }
                {
                    int[] matrice = { 64, 34, 25, 12, 22, 11, 90 };
                    foreach (var item in matrice)
                        Console.WriteLine("Numerele Sunt: " + item);

                    SortareBubble(matrice, matrice.Length);

                    Console.WriteLine("Matrita sorta este: ");
                    for (int i = 0; i < matrice.Length; i++)
                        Console.Write(matrice[i] + " ");
                }
            }
        }
        static void Exercitiu5a()
        {
            //Scrieti o functie recursiva care va afisa suma numerelor de la 1 pana la n, apelati - o si afisati-i rezultatul.

            Console.WriteLine("Introduceti numarul");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Suma primelor {0} numere naturale este: {1}\n\n", n, SumaDeZece(1, n));
        }
        static int SumaDeZece(int minim, int maxim)
        {
            return CalculSuma(minim, maxim);
        }
        static int CalculSuma(int minim, int valoare)
        {
            if (valoare == minim)
                return valoare;
            return valoare + CalculSuma(minim, valoare - 1);
        }

        static void Exercitiu5b()
        {
            ////Scrieti o functie recursiva care va afisa suma numerelor de la 1 pana la n, apelati - o si afisati-i rezultatul.

            Console.WriteLine("Introduceti un Numar");
            int n = int.Parse(Console.ReadLine());

            int Raspuns = SumaDeCifre(n);

            Console.WriteLine("Suma numarului introdus este: " + Raspuns);
        }
        static int SumaDeCifre(int n)
        {
            //Daca valoare n este 0, atunci returnam 0.
            if (n == 0)
                return 0;

            // Daca valoarea nui 0, atunci returnam ultima cifra + recursiv apelam la n/10.
            return (n % 10 + SumaDeCifre(n / 10));
        }

        static void Exercitiu6()
        {
            //Scrieti o functie recursiva care va afisa al n-lea element din sirul lui Fibonacci, n fiind citit de la tastatura.

            int numar1 = 0, numar2 = 1, numar3, i, numarElemente;

            Console.WriteLine("Introduceti numarul de elemente: ");
            numarElemente = int.Parse(Console.ReadLine());

            // Scriem 0 si 1
            Console.Write(numar1 + "" + numar2 + "");

            //Bucla incepe de la 2 pentru ca avem 0 si 1 deja scris
            for (i = 2; i < numarElemente; ++i)
            {
                numar3 = numar1 + numar2;
                Console.Write(numar3 + "");
                numar1 = numar2;
                numar2 = numar3;
            }
        }
        static void Exercitiu7()
        {
            //Scrieti o functie recursiva care pentru un numar “n” primit ca parametru, va afisa urmatoarea piramida a numerelor.

            Console.WriteLine("Introduceti numarul de randuri");
            int randuri = int.Parse(Console.ReadLine());

            int i, j;

            for (i = 1; i <= randuri; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
    
    