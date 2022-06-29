using System;

class ClassSimple
{
    static void Main(string[] args)
    {
        /*
        //Console.WriteLine("Hello World!");
        //Console.Write("줄 바꿈 없음");
        //Console.WriteLine("줄 바꿈 포함");
        //Console.WriteLine("줄\n바''꿈");
        //Console.WriteLine("{0}", "Hello, C#");
        //Console.WriteLine("{0} {1}", "Hello,", "C#");
        //Console.WriteLine("{1}   {0}", "Hello,", "C#");


        int number;
        number = 7;
        Console.WriteLine(number);

        Console.WriteLine(1234);
        Console.WriteLine(3.14F);
        Console.WriteLine('A');
        Console.WriteLine("Hello");
        */

        /*
        int num1, num2, num3;
        num1 = 1;
        num2 = 2;
        num3 = 3;
        Console.WriteLine("{0}-{1}-{2}", num1, num2, num3);
        */

        /*
        int min = -2147483648;
        int max = +2147483647;

        Console.WriteLine("int 변수의 최소값 {0}",min);
        Console.WriteLine("int 변수의 최대값 {0}",max);
        */

        double PI = 3.141592;
        Console.WriteLine("{0}", PI);

        float PI2 = 3.141592F;
        Console.WriteLine("{0}", PI);

        double i1 = 2.185;
        double i2 = 1.153;
        Console.WriteLine(Convert.ToDecimal(i1-i2));

        decimal i = 3.14m;

    }
}