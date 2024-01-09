using System;

    class Program
    {
    static void Hello()
    {
        Console.WriteLine("Hello");
    }
    static void Math(int x,int y)
    {
        Console.WriteLine(x + y);
        Console.WriteLine(x - y);
        Console.WriteLine(x * y);
        Console.WriteLine(x / y);
    }
    static void Math1()
    {
        char c = Convert.ToChar( Console.ReadLine());
        switch(c)
        {
            case '+': Console.WriteLine(2 + 3);
                break;
            case '-': Console.WriteLine(2 - 3);
                break;
            case '*': Console.WriteLine(2 * 3);
                break;
            case '/': Console.WriteLine(2 / 4);
                break;
                default: Console.WriteLine("Wrong Operation");
                break;
        }
    }
            static void Name()
    {
        for(int i = 0; i < 10; i++)
        {
            Console.WriteLine("Saurav Tandon");
        }
    }
    static void Even() {
        for(int i = 0; i <= 20; i++)
        {
            if(i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
    static void Even1()
    {
        int i = 0;
        while (i <= 20)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
            i++;
        }
    }
    static void Odd()
    {
        for (int i = 0; i <= 20; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
            }
        }
    }
    static void Odd1()
    {
        int i = 0;
        while (i <= 20)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
            }
            i++;
        }
    }
    static void Table()
    {
        int t = 2;
        for(int i = 1; i <= 10; i++)
        {
            Console.WriteLine(t * i);        }
    }

    static void Display()
    {
        for (int i = 100; i >= 5; i -= 3)
        {
            Console.WriteLine(i);
        }
    }

    static void Variable(int a, double b, char c)
    {
        Console.Write(a);
        Console.Write(b);
        Console.Write(c);
    }
    static void Variable1 (int a, double b, char c)
    {
        Console.Write(a);
        Console.Write(b);
        Console.Write(c);
    }





    static void Main(string[] args)
        {
        Hello();
        Math(1,2);
        Math1();
        Name();
        Even();
        Even1();
        Odd();
        Odd1();
        Table();
        Display();
        Variable(5,5.5,'a');
        Variable1(5, 5.5, 'a');
       
    }
    }

