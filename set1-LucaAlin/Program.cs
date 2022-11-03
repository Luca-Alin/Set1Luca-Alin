using System;
using System.Numerics;
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
            {p = Convert.ToInt32(Console.ReadLine()); }
            catch (Exception e)
            {
                Console.WriteLine("Introduceti un *numar* de la 1 la 21 pentru a activa o problema: ");
                continue;}
        }


        
        switch(p)
        {
            case 1: P1(); break;
            case 2: P2(); break;
            case 3: P3(); break;
            case 4: P4(); break;
            case 5: P5(); break;
            case 6: P6(); break;
            case 7: P7(); break;
            case 8: P8(); break;
            case 9: P9(); break;
            case 10: P10(); break;
            case 11: P11(); break;
            case 12: P12(); break;
            case 13: P13(); break;
            case 14: P14(); break;
            case 15: P15(); break;
            case 16: P16(); break;
            case 17: P17(); break;
            case 18: P18(); break;
            case 19: P19(); break;
            case 20: P20(); break;
            case 21: P21(); break;
        }
    }

    static public void P1() {
        Console.WriteLine("Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare.");
        string[] tokens = Console.ReadLine().Split(' ');
        
        double a = Double.Parse(tokens[0]);
        double b = Double.Parse(tokens[1]);

        Console.WriteLine("x = " + (-b / a));
    }
    static public void P2() {
        Console.WriteLine("Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, " +
                          "unde a, b si c sunt date de intrare. Tratati toate cazurile posibile.");
        string[] tokens = Console.ReadLine().Split(' ');

        double a, b, c, delta;
        a = Double.Parse(tokens[0]);
        b = Double.Parse(tokens[1]);
        c = Double.Parse(tokens[2]);
        delta = b * b - 4 * a * c;

        if (delta > 0)
            Console.WriteLine(  "x1 = " + ((-b + Math.Sqrt(delta)) / (2 * a)) + "\n" +
                                "x2 = " + ((-b - Math.Sqrt(delta)) / (2 * a)));
        else if (delta == 0)
            Console.WriteLine("x = " + ((-b + Math.Sqrt(delta)) / (2 * a)));
        else
            Console.WriteLine("Ecuatia nu are solutii reale");

    }
    static public void P3() {
        Console.WriteLine("Determinati daca n se divide cu k, unde n si k sunt date de intrare.");
        string[] tokens = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(tokens[0]);
        int k = Convert.ToInt32(tokens[1]);

        if (n % k == 0) Console.WriteLine(n + " este divizibil cu " + k);
        else Console.WriteLine(n + " nu este divizibil cu " + k);
    }
    static public void P4() {
        Console.WriteLine("Detreminati daca un an y este an bisect.");
        int y = Convert.ToInt32(Console.ReadLine());

        if (y % 400 == 0 || (y % 4 == 0 && y % 100 != 0))
            Console.WriteLine(y + " este an bisect");
        else
            Console.WriteLine(y + " nu este an bisect");
    }
    static public void P5() {
        Console.WriteLine("Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga.");
        string[] tokens = Console.ReadLine().Split(' ');

        string n = tokens[0];
        int k = Convert.ToInt32(tokens[1]);

        Console.WriteLine(n.Substring(n.Length - k, 1));

    }
    static public void P6() {
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
    static public void P7() {
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
    static public void P8() {
        Console.WriteLine("(Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. " +
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
    static public void P9() {
        Console.WriteLine("Afisati toti divizorii numarului n. ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= n; i++) {
            if (n % i == 0)
                Console.Write(i + " ");
        }

        /* for (int i = 1; i * i <= n; i++) {
            if (n % i == 0) {
                Console.Write(i + " ");
                if (i * i < n) {
                    Console.Write(n / i + " ");
                }
            }
        }*/
    }
    static public void P10() {
        Console.WriteLine("Test de primalitate: determinati daca un numar n este prim.");
        int n = Convert.ToInt32(Console.ReadLine());
        bool isPrime = true;

        for (int i = 2; i * i <= n; i++) {
            if (n % i == 0) {
                isPrime = false;
            }
        }

        if (isPrime) Console.WriteLine("Numarul este prim");
        else Console.WriteLine("Numarul nu este prim");
    }
    static public void P11() {
         
        Console.WriteLine("//Afisati in ordine inversa cifrele unui numar n.");
        string n = Console.ReadLine();
        for (int i = n.Length - 1; i >= 0; i--) {
            Console.Write(n.Substring(i, 1));
        }
    }
    static public void P12()
    {
         
        Console.WriteLine("Determinati cate numere integi divizibile cu n se afla in intervalul [a, b].");
        string[] tokens = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens[0]);
        int a = Convert.ToInt32(tokens[1]);
        int b = Convert.ToInt32(tokens[2]);
        int counter = 0;

        for (int i = a; i <= b; i++)
            if (n % i == 0)
                counter++;

        Console.WriteLine("In intervalul [a, b] sunt: " + counter + " divizori");
    }
    static public void P13() {
        
        Console.WriteLine("Determianti cati ani bisecti sunt intre anii y1 si y2.");
        string[] tokens = Console.ReadLine().Split(' ');
        int y1 = Convert.ToInt32(tokens[0]);
        int y2 = Convert.ToInt32(tokens[1]);
        int counter = 0;
        for (int i = y1; i <= y2; i++) {
            if (i % 400 == 0 || (i % 4 == 0 && i % 100 != 0))
                counter++;
        }
        Console.WriteLine("Ani bisecti: " + counter);
    }
    static public void P14() {
        Console.WriteLine("Determianti daca un numar n este palindrom. (un numar este palindrom daca citit " +
                          "invers obtinem un numar egal cu el, de ex. 121 sau 12321.");
        string n = Console.ReadLine();
        string nReversed = "";
        for (int i = n.Length - 1; i >= 0; i--) 
            nReversed += n.Substring(i, 1);
        
        if (n.Equals(nReversed))
            Console.WriteLine("Numarul este palindrom");
        else
            Console.WriteLine("Numarul nu este palindrom");

    }
    static public void P15() {
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
    static public void P16() {
        Console.WriteLine("Se dau 5 numere. Sa se afiseze in ordine crescatoare. (nu folositi tablouri)");
        string[] tokens = Console.ReadLine().Split(' ');
        int a = Convert.ToInt32(tokens[0]);
        int b = Convert.ToInt32(tokens[1]);
        int c = Convert.ToInt32(tokens[2]);
        int d = Convert.ToInt32(tokens[3]);
        int e = Convert.ToInt32(tokens[4]);
        //variabila "min" salveaza cel mai mic numar din lista
        //pointer-ul "ptr" retine ce variabila are cea mai mica valoare
        //cea mai mica variabila primeste valoarea 2147483647 => devine cea mai mare variabila
        //numerele sunt scrise in ordine crescatoare
        unsafe {
            for (int i = 0; i < 5; i++) {
                int min = Int32.MaxValue;
                int* ptr = &min;
                if (a < min) { min = a; ptr = &a;}
                if (b < min) { min = b; ptr = &b; }
                if (c < min) { min = c; ptr = &c; }
                if (d < min) { min = d; ptr = &d; }
                if (e < min) { min = e; ptr = &e; }
                *ptr = Int32.MaxValue;
                Console.Write(min + " ");
            }
        }
    }
    static public void P17() {
        Console.WriteLine("Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. Folositi algoritmul lui Euclid.");
        string[] tokens = Console.ReadLine().Split(' ');
        int a = Convert.ToInt32(tokens[0]);
        int b = Convert.ToInt32(tokens[1]);

        int m = a, n = b;
        while (m != n) {
            if (m > n)
                m = m - n;
            else if (n > m)
                n = n - m;
        }

        Console.WriteLine("Cel mai mare divizor comun: " + n);
        Console.WriteLine("Cel mai mic multiplu comun: " + (a * b) / n);
    }
    static public void P18() {
        Console.WriteLine("Afisati descompunerea in factori primi ai unui numar n.  " +
                          "De ex. pentru n = 1176 afisati 2^3 x 3^1 x 7^2. ");
        int n = Convert.ToInt32(Console.ReadLine());

        bool[] prime = new bool[n + 1];
        for (int i = 0; i < prime.Length; i++) prime[i] = true;
 
        for (int i = 2; i * i < prime.Length; i++) { 
            if (prime[i] == true) {
                for (int j = i * 2; j < prime.Length; j += i)
                    prime[j] = false;
            }
        }

        bool aux = false;
        for (int i = 2; i < prime.Length; i++) {
            if (prime[i] == true && n > 0 && n % i == 0) {
                int counter = 0;
                while (n % i == 0) {counter++; n /= i; }
                if (aux) {Console.Write("x" + i + "^" + counter); }
                else {Console.Write(i + "^" + counter); aux = true; }
               
            }
            
        }
        
    }
    static public void P19() {
        Console.WriteLine("Determinati daca un numar e format doar cu 2 cifre care se pot repeta. " +
                          "De ex. 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt.");
        
        string n = Console.ReadLine();
        string t = "";
        for (int i = 0; i < n.Length; i++)
            if (!t.Contains(n.Substring(i, 1)))
                t += n.Substring(i, 1);
        if (t.Length > 2) Console.WriteLine("Numarul are >2 cifre");
        else Console.WriteLine("Numarul are <= 2 cifre");
    }
    static public void P20() {
        Console.WriteLine("Afisati fractia m/n in format zecimal, cu perioada intre paranteze (daca e cazul). Exemplu: 13/30 = 0.4(3).");
        String[] tokens = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens[0]);
        int m = Convert.ToInt32(tokens[1]);
        double numitor = n;
        double numarator = m;
        while(n != m)
            if(n > m) n -= m;
            else m -= n;
        
        numitor /= n;
        numarator /= n;
        
        //generam numere prime de la 2 la numarator
        bool[] isPrime = new bool[(int)numarator];
        for (int i = 0; i < isPrime.Length; i++)
            isPrime[i] = true;
        for (int i = 2; i < isPrime.Length; i++) 
           if (isPrime[i] == true)
               for (int j = 2 * i; j < isPrime.Length; j += i)
                   isPrime[j] = false;
        
        for (int i = 2; i < isPrime.Length; i++)
            if (i != 2 && i != 5 && isPrime[i] == true && numitor % i == 0)
                Console.WriteLine("ok " + i);




    }
    static public void P21() {
        
        int n = new Random().Next(1, 1025);
        int guess = -1;
        Console.WriteLine("Ghiciti un numar intre 1 si 1024 prin intrebari de forma \"numarul este mai mare sau egal decat x?\".");
        while (n != guess) {
            guess = Convert.ToInt32(Console.ReadLine());
            if (guess == n) Console.WriteLine("Ati ghicit! Numarul este " + n);
            else if (guess < n) Console.WriteLine("Numarul este mai mare");
            else Console.WriteLine("Numarul este mai mic");
        } 
    }
}
