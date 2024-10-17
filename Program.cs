using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekurziós_Feladatok
{
    internal class Program
    {

        static int lepcso(int n, int k)
        {
            if (n == 0)
            {
                return 1;
            }

            int L = 0;

            for (int i = 1; i <= k; i++)
            {
                if (n - i >= 0)
                {
                    L += lepcso(n - i, k);
                }
            }

            return L;
        }

        static void hatvanyok(int k, int m)
        {
            if (k <= m)
            {
                Console.WriteLine(k);
                hatvanyok(2 * k, m);
            }

        }

        static int bin(int n, int k)
        {
            if (k == 0 || k == n)
            {
                return 1;
            }

            return bin(n, k - 1) * (n - k + 1) / k;
        }

        static int szoszam(string szoveg, int jobb)
        {
            if (jobb == 0)
            {
                return 0;
            }
            else
            {
                if (szoveg[jobb] == ' ')
                {
                    return 1 + szoszam(szoveg, jobb - 1);
                }
                else
                {
                    return szoszam(szoveg, jobb - 1);
                }
            }
        }

        static bool Eldönt(int n, int[] mag)
        {
            if (n == 0)
            {
                return false;
            }
            if (mag[n] > 200)
            {
                return true;
            }
            else
            {
                return Eldönt(n - 1, mag);
            }
        }

        static bool palindrome(string text)
        {
            if (text.Length <= 1)
                return true;
            else
            {
                if (text[0] != text[text.Length - 1])
                    return false;
                else
                    return palindrome(text.Substring(1, text.Length - 2));
            }
        }

        static int szamjegyek(int n)
        {
            if (n == 0)
                return 0;
            else
                return 1 + szamjegyek(n / 10);
        }

        static string fordit(string text)
        {
            if (text.Length <= 1)
            {
                return text;
            }

            char elsoBetu = text[0];
            string maradek = text.Substring(1);

            return fordit(maradek) + elsoBetu;
        }

        static int szamjegyekOsszege(int n)
        {
            if (n < 10)
                return n;

            return (n % 10) + szamjegyekOsszege(n / 10);
        }

        static int tombOsszegzes(int[] arr, int n)
        {
            // Alapeset: Ha n eléri a 0-t, visszatér 0-val
            if (n == 0)
                return 0;

            // Rekurzió: Az utolsó elem összege a többi elem összegével
            return arr[n - 1] + tombOsszegzes(arr, n - 1);
        }

        static void Main(string[] args)

        {

            //Console.WriteLine("Hány lépcsőfok van: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Hány fokot tudunk egyszerre lépni: ");
            //int k = Convert.ToInt32(Console.ReadLine());

            //int eredmeny = lepcso(n,k);
            //Console.WriteLine(eredmeny);


            //Console.WriteLine("k: ");
            //int k = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("m: ");
            //int m = Convert.ToInt32(Console.ReadLine());

            //hatvanyok(k,m);
            //int eredmeny = hatvanyok(k, m);
            //Console.WriteLine(eredmeny);

            //Console.WriteLine("n: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("k: ");
            //int k = Convert.ToInt32(Console.ReadLine());

            //int eredmeny = bin(n, k);
            //Console.WriteLine(eredmeny);

            //Console.WriteLine("Kérek egy szöveget!");
            //string beker = Console.ReadLine();
            //int eredmeny = szoszam(beker, beker.Length - 1);
            //Console.WriteLine(eredmeny + 1);

            //int[] magas = new int[11] { 180, 170, 190, 155, 188, 199, 200, 200, 192, 188 ,201};
            //Console.WriteLine(Eldönt(magas.Length - 1, magas));

            //Console.Write("Írj be egy szöveget : ");
            //string str1 = Console.ReadLine();

            //bool eredmeny = palindrome(str1);


            //if (eredmeny == true)
            //{
            //    Console.WriteLine("Ez a szöveg palindrome.\n");
            //}
            //else
            //{
            //    Console.WriteLine("Ez a szöveg nem palindrome.\n");
            //}

            //Console.WriteLine("Adj meg egy számot: ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //int eredmeny = szamjegyek(n);
            //Console.WriteLine("Az adott számban "+eredmeny+" számjegy van.");

            //Console.WriteLine("adj meg egy szoveget: ");
            //string szoveg = Console.ReadLine();

            //Console.WriteLine(fordit(szoveg));

            //Console.WriteLine("Adj meg egy számot: ");
            //int szam = Convert.ToInt32(Console.ReadLine());
            //int eredmeny = szamjegyekOsszege(szam);
            //Console.WriteLine(eredmeny);

            int[] tomb = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int eredmeny = tombOsszegzes(tomb, tomb.Length);
            Console.WriteLine(eredmeny);
        }
    }
}