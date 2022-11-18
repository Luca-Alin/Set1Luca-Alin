using System;
using System.Numerics;
using System.Runtime.Intrinsics.Arm;
using static System.Net.Mime.MediaTypeNames;

class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Introduceti un numar de la 1 la 21 pentru a activa o problema: ");
        int p = -1;
        while (!(p >= 1 && p <= 21))
        {
            try
            {
                p = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Introduceti un *numar* de la 1 la 21 pentru a activa o problema: ");
                continue;
            }
        }


        switch (p)
        {
            case 1:
                P1();
                break;
            case 2:
                P2();
                break;
            case 3:
                P3();
                break;
            case 4:
                P4();
                break;
            case 5:
                P5();
                break;
            case 6:
                P6();
                break;
            case 7:
                P7();
                break;
            case 8:
                P8();
                break;
            case 9:
                P9();
                break;
            case 10:
                P10();
                break;
            case 11:
                P11();
                break;
            case 12:
                P12();
                break;
            case 13:
                P13();
                break;
            case 14:
                P14();
                break;
            case 15:
                P15();
                break;
            case 16:
                P16();
                break;
            case 17:
                P17();
                break;
            case 18:
                P18();
                break;
            case 19:
                P19();
                break;
            case 20:
                P20();
                break;
            case 21:
                P21();
                break;
        }
    }

    static public void P1()
    {
        Console.WriteLine(
            "Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare.");
        string[] tokens = Console.ReadLine().Split(' ');

        double a = Double.Parse(tokens[0]);
        double b = Double.Parse(tokens[1]);

        Console.WriteLine("x = " + (-b / a));
    }

    static public void P2()
    {
        Console.WriteLine("Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, " +
                          "unde a, b si c sunt date de intrare. Tratati toate cazurile posibile.");
        string[] tokens = Console.ReadLine().Split(' ');

        double a, b, c, delta;
        a = Double.Parse(tokens[0]);
        b = Double.Parse(tokens[1]);
        c = Double.Parse(tokens[2]);
        delta = b * b - 4 * a * c;

        if (delta > 0)
            Console.WriteLine("x1 = " + ((-b + Math.Sqrt(delta)) / (2 * a)) + "\n" +
                              "x2 = " + ((-b - Math.Sqrt(delta)) / (2 * a)));
        else if (delta == 0)
            Console.WriteLine("x = " + ((-b + Math.Sqrt(delta)) / (2 * a)));
        else
            Console.WriteLine("Ecuatia nu are solutii reale");
    }

    static public void P3()
    {
        Console.WriteLine("Determinati daca n se divide cu k, unde n si k sunt date de intrare.");
        string[] tokens = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(tokens[0]);
        int k = Convert.ToInt32(tokens[1]);

        if (n % k == 0) Console.WriteLine(n + " este divizibil cu " + k);
        else Console.WriteLine(n + " nu este divizibil cu " + k);
    }

    static public void P4()
    {
        Console.WriteLine("Detreminati daca un an y este an bisect.");
        int y = Convert.ToInt32(Console.ReadLine());

        if (y % 400 == 0 || (y % 4 == 0 && y % 100 != 0))
            Console.WriteLine(y + " este an bisect");
        else
            Console.WriteLine(y + " nu este an bisect");
    }

    static public void P5()
    {
        Console.WriteLine(
            "Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga.");
        string[] tokens = Console.ReadLine().Split(' ');

        string n = tokens[0];
        int k = Convert.ToInt32(tokens[1]);

        Console.WriteLine(n[n.Length - k]);
    }

    static public void P6()
    {
        Console.WriteLine("Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi.");
        string[] tokens = Console.ReadLine().Split(' ');
        int a = Convert.ToInt32(tokens[0]);
        int b = Convert.ToInt32(tokens[1]);
        int c = Convert.ToInt32(tokens[2]);

        if (a + b > c &&
            a + c > b &&
            b + c > a)
            Console.WriteLine("Numerele pot forma un triunghi");
        else
            Console.WriteLine("Numerele nu pot forma un triunghi");
    }

    static public void P7()
    {
        Console.WriteLine("(Swap) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. " +
                          "Se cere sa se inverseze valorile lor.");
        string[] tokens = Console.ReadLine().Split(' ');

        int a = Convert.ToInt32(tokens[0]);
        int b = Convert.ToInt32(tokens[1]);
        Console.WriteLine("inainte: a = " + a + "; b = " + b);

        int aux = a;
        a = b;
        b = aux;

        Console.WriteLine("dupa: a = " + a + "; b = " + b);
    }

    static public void P8()
    {
        Console.WriteLine(
            "(Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. " +
            "Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.  ");
        string[] tokens = Console.ReadLine().Split(' ');

        int a = Convert.ToInt32(tokens[0]);
        int b = Convert.ToInt32(tokens[1]);
        Console.WriteLine("inainte: a = " + a + "; b = " + b);

        a = a + b;
        b = a - b;
        a = a - b;

        Console.WriteLine("dupa: a = " + a + "; b = " + b);
    }

    static public void P9()
    {
        Console.WriteLine("Afisati toti divizorii numarului n. ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= n; i++)
            if (n % i == 0)
                Console.Write(i + " ");
    }

    static public void P10()
    {
        Console.WriteLine("Test de primalitate: determinati daca un numar n este prim.");
        int n = Convert.ToInt32(Console.ReadLine());
        bool isPrime = true;

        for (int i = 2; i * i <= n; i++)
            if (n % i == 0)
                isPrime = false;
            
        

        if (isPrime) Console.WriteLine("Numarul este prim");
        else Console.WriteLine("Numarul nu este prim");
    }

    static public void P11()
    {
        
        Console.WriteLine("Afisati in ordine inversa cifrele unui numar n.");
        
        
        int numar = Convert.ToInt32(Console.ReadLine());
        int semn = 1;
        if (numar < 0) semn = -1;
        numar = Math.Abs(numar);
        
        int numarIntors = 0;
        while (numar > 0)
        {
            numarIntors = numarIntors * 10 + numar % 10;
            numar /= 10;
        }

        Console.WriteLine(semn * numarIntors);
    }

    static public void P12()
    {
        Console.WriteLine("Determinati cate numere integi divizibile cu n se afla in intervalul [a, b].");
        string[] tokens = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens[0]);
        int a = Convert.ToInt32(tokens[1]);
        int b = Convert.ToInt32(tokens[2]);
        int divisibleNumbersCount = 0;

        for (int i = a; i <= b; i++)
            if (i % n == 0)
                divisibleNumbersCount++;

        Console.WriteLine("In intervalul [a, b] sunt: " + divisibleNumbersCount + " divizori ai lui n");
    }

    static public void P13()
    {
        Console.WriteLine("Determianti cati ani bisecti sunt intre anii y1 si y2.");
        string[] tokens = Console.ReadLine().Split(' ');
        int y1 = Convert.ToInt32(tokens[0]);
        int y2 = Convert.ToInt32(tokens[1]);
        int counter = 0;
        for (int i = y1; i <= y2; i++)
        {
            if (i % 400 == 0 || (i % 4 == 0 && i % 100 != 0))
                counter++;
        }

        Console.WriteLine("Ani bisecti: " + counter);
    }

    static public void P14()
    {
        Console.WriteLine("Determianti daca un numar n este palindrom. (un numar este palindrom daca citit " +
                          "invers obtinem un numar egal cu el, de ex. 121 sau 12321.");
        
        //Metoda 1
        /*
        string n = Console.ReadLine();
        string nReversed = "";
        for (int i = n.Length - 1; i >= 0; i--)
            nReversed += n[i];

        if (n.Equals(nReversed))
            Console.WriteLine("Numarul este palindrom");
        else
            Console.WriteLine("Numarul nu este palindrom");    
        */

        
        //Metoda 2
        int n = Convert.ToInt32(Console.ReadLine());
        int nCopy = n;
        int nIntors = 0;
        
        while (nCopy > 0)
        {
            nIntors = nIntors * 10 + nCopy % 10;
            nCopy /= 10;
        }

        if (n == nIntors)
            Console.WriteLine("Numarul este palindrom");
        else
            Console.WriteLine("Numarul nu este palindrom"); 

    }

    static public void P15()
    {
        Console.WriteLine("Se dau 3 numere. Sa se afiseze in ordine crescatoare.");
        string[] tokens = Console.ReadLine().Split(' ');
        int a = Convert.ToInt32(tokens[0]);
        int b = Convert.ToInt32(tokens[1]);
        int c = Convert.ToInt32(tokens[2]);

        int min = Math.Min(Math.Min(a, b), Math.Min(b, c));
        int max = Math.Max(Math.Max(a, b), Math.Max(b, c));
        int med = (a + b + c) - min - max;

        Console.WriteLine(min + " " + med + " " + max);
    }

    static public void P16()
    {
        Console.WriteLine("Se dau 5 numere. Sa se afiseze in ordine crescatoare. (nu folositi tablouri)");
        string[] tokens = Console.ReadLine().Split(' ');
        int a = Convert.ToInt32(tokens[0]);
        int b = Convert.ToInt32(tokens[1]);
        int c = Convert.ToInt32(tokens[2]);
        int d = Convert.ToInt32(tokens[3]);
        int e = Convert.ToInt32(tokens[4]);

        //variabila "a" va lua valoarea numarului minim din sir
        if (b < a)
        {
            int aux = a;
            a = b;
            b = aux;
        }

        if (c < a)
        {
            int aux = a;
            a = c;
            c = aux;
        }

        if (d < a)
        {
            int aux = a;
            a = d;
            d = aux;
        }

        if (e < a)
        {
            int aux = a;
            a = e;
            e = aux;
        }

        //variabila "e" va lua valoarea numarului maxim din sir
        if (a > e)
        {
            int aux = e;
            e = a;
            a = aux;
        }

        if (b > e)
        {
            int aux = e;
            e = b;
            b = aux;
        }

        if (c > e)
        {
            int aux = e;
            e = c;
            c = aux;
        }

        if (d > e)
        {
            int aux = e;
            e = d;
            d = aux;
        }

        //ordonam variabilele b, c, d cu algoritmul de la ex. 15
        int min = Math.Min(Math.Min(b, c), Math.Min(c, d));
        int max = Math.Max(Math.Max(b, c), Math.Max(c, d));
        int med = (b + c + d) - min - max;
        b = min;
        c = med;
        d = max;

        Console.WriteLine(a + " " + b + " " + c + " " + d + " " + e);
    }

    static public void P17()
    {
        Console.WriteLine(
            "Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. Folositi algoritmul lui Euclid.");
        string[] tokens = Console.ReadLine().Split(' ');
        int a = Convert.ToInt32(tokens[0]);
        int b = Convert.ToInt32(tokens[1]);

        int m = a, n = b;
        while (m != 0)
        {
            int r = n % m;
            n = m;
            m = r;
        }

        Console.WriteLine("Cel mai mare divizor comun: " + n);
        Console.WriteLine("Cel mai mic multiplu comun: " + (a * b) / n);
    }

    static public void P18()
    {
        Console.WriteLine("Afisati descompunerea in factori primi ai unui numar n.  " +
                          "De ex. pentru n = 1176 afisati 2^3 x 3^1 x 7^2. ");
        int n = Convert.ToInt32(Console.ReadLine());

        bool[] prime = new bool[n + 1];
        for (int i = 0; i < prime.Length; i++) prime[i] = true;

        //Generam numere prime cu Ciurul lui Eratestone
        for (int i = 2; i * i < prime.Length; i++)
            if (prime[i])
                for (int j = i * 2; j < prime.Length; j += i)
                    prime[j] = false;
            
        

        bool trebuiePusSemnulInmultirii = false;
        for (int i = 2; i < prime.Length; i++)
        {
            if (prime[i] && n > 0 && n % i == 0)
            {
                int putereaFactoruluiPrim = 0;
                while (n % i == 0)
                {
                    putereaFactoruluiPrim++;
                    n /= i;
                }

                if (trebuiePusSemnulInmultirii) Console.Write(" x " + i + "^" + putereaFactoruluiPrim);
                else
                {
                    Console.Write(i + "^" + putereaFactoruluiPrim);
                    trebuiePusSemnulInmultirii = true;
                }
            }
        }
    }

    static public void P19()
    {
        Console.WriteLine("Determinati daca un numar e format doar cu 2 cifre care se pot repeta. " +
                          "De ex. 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt.");

        string n = Console.ReadLine();
        string t = "";
        for (int i = 0; i < n.Length; i++)
            if (!t.Contains(n[i]))
                t += n[i];
        if (t.Length > 2) Console.WriteLine("Numarul are >2 cifre");
        else Console.WriteLine("Numarul are <= 2 cifre");
    }

    static public void P20()
    {
        Console.WriteLine(
            "Afisati fractia m/n in format zecimal, cu perioada intre paranteze (daca e cazul). Exemplu: 13/30 = 0.4(3).");
        String[] tokens = Console.ReadLine().Split(' ');

        int numarator = Convert.ToInt32(tokens[0]);
        int numitor = Convert.ToInt32(tokens[1]);


        List<int> listaCaturi = new List<int>();
        List<int> listaResturi = new List<int>();

        int rest = numarator % numitor;
        listaResturi.Add(rest);

        bool periodica = false;
        do
        {
            listaCaturi.Add(rest * 10 / numitor);
            rest = rest * 10 % numitor;

            if (!listaResturi.Contains(rest)) listaResturi.Add(rest);
            else periodica = true;
        } while (rest != 0 && periodica == false);

        String numarFinal = (numarator / numitor) + ".";

        if (!periodica)
            foreach (int i in listaCaturi)
                numarFinal += i;
        else
        {
            for (int i = 0; i < listaCaturi.Count; i++)
            {
                if (listaResturi[i] == rest) numarFinal += "(";
                numarFinal += listaCaturi[i];
            }

            numarFinal += ")";
        }

        Console.WriteLine(numarFinal);
    }

    static public void P21()
    {
        int n = new Random().Next(1, 1025);
        int guess = -1;
        Console.WriteLine(
            "Ghiciti un numar intre 1 si 1024 prin intrebari de forma \"numarul este mai mare sau egal decat x?\".");
        while (n != guess)
        {
            guess = Convert.ToInt32(Console.ReadLine());
            if (guess == n) Console.WriteLine("Ati ghicit! Numarul este " + n);
            else if (guess < n) Console.WriteLine("Numarul este mai mare");
            else Console.WriteLine("Numarul este mai mic");
        }
    }
}