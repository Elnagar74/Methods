using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter Number1: ");
            //int x = int.Parse(Console.ReadLine());
            //Console.Write("Enter Number2: ");
            //int y = int.Parse(Console.ReadLine());
            //Console.Write("The Summation is : " + Add(x, y));    //Calling OR Invoking Method
            //Console.WriteLine();

            //----------------------------------------------------------

            //Console.Write("Enter The Reduis: ");
            //double redius = double.Parse(Console.ReadLine());
            //Console.Write("Area is : " + Area(redius));
            //Console.WriteLine();

            //----------------------------------------------------------

            //double salary, Net_Salary, tax_rate;
            //Console.WriteLine("Enter The Salary: ");
            //salary = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter The TaxRate: ");
            //tax_rate = double.Parse(Console.ReadLine());
            //Console.WriteLine("the Net Salary is : " + NetSalary(salary,tax_rate));

            //----------------------------------------------------------

            //Console.Write("Enter Number1: ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter Number2: ");
            //int num2 = int.Parse(Console.ReadLine()) ;
            //Console.WriteLine("The Maximum : {0}",max(num1,num2));

            //----------------------------------------------------------

            //Console.Write("Enter The End Number: ");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine("the Summation : {0} ",Sum(num));

            //----------------------------------------------------------

            //Console.Write("Enter The Factor Number: ");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine("The Factorial of Number : {0}" , Fact(num));

            //----------------------------------------------------------

            //Console.Write("Enter Number1: ");
            //int x = int.Parse(Console.ReadLine());
            //Console.Write("Enter Number2: ");
            //int y = int.Parse(Console.ReadLine());
            //Console.WriteLine("The Power of First Number : {0}",power(x,y));

            //----------------------------------------------------------

            //Console.WriteLine("Using OverLoading");
            //Console.WriteLine("The Result of Add ({0},{1}): {2}", 2,3,Add(2,3));
            //Console.WriteLine("The Result of Add ({0},{1}): {2}", 2.5,3.5,Add(2.5, 3.5));
            //Console.WriteLine("The Result of Add ({0},{1}): {2}", 2.5,3,Add(2.5, 3));
            //Console.WriteLine("The Result of Add ({0},{1}): {2}", 2,3.5,Add(2, 3.5));
            //Console.WriteLine("The Result of Add ({0},{1},{2}): {3}", 2,3,4,Add(2, 3, 4));

            //----------------------------------------------------------

            //Recursion

            //Console.WriteLine("The Fastorial of 5 = {0} " , Fact(5));

            //----------------------------------------------------------

            //Recursion

            //Console.WriteLine("The Power 5 of 3 = {0} ", Power(5,3));

            //----------------------------------------------------------

            /* PirntShape(5);     */   //SquareShape

            //----------------------------------------------------------

            /* PirntShape(5,3);   */      //RectangleShape

            //----------------------------------------------------------


        }
        //Method Decleretion 
        //static int Add (int n1 , int n2)      //Header
        //{
        //    return n1 + n2;                  //Body
        //}

        //------------------------------------------------------------

        //static double Area(double n1)
        //{
        //     double area = Math.PI * n1 * n1;
        //    return area;
        //}

        //-------------------------------------------------------------

        //static double NetSalary (double salary , double tax_rate)
        //{
        //    double tax = tax_rate * salary;
        //    return salary - tax;   
        //}

        //-------------------------------------------------------------

        //static int max(int n1 ,int n2)
        //{
        //    if (n1> n2)
        //        return n1;
        //    else 
        //        return n2;
        //}

        //----------------------------------------------------------

        //static int Sum (int n1)
        //{
        //    int sum = 0;
        //    for(int i = 1; i <= n1; i++)
        //    {
        //        sum += i;
        //    }
        //    return sum;
        //}

        //----------------------------------------------------------

        //static int Fact (int n)
        //{ 
        //    int f = 1;
        //    for(int i = 1 ; i <= n; i++)
        //    {
        //        f *= i;
        //    }
        //    return f;
        //}

        //----------------------------------------------------------

        //static int power (int x , int y)
        //{
        //    int z = 1;
        //    for (int i = 1; i <= y; i++)
        //    {
        //        z *= x;
        //    }
        //    return z;
        //}

        //----------------------------------------------------------

        //Method OverLoading

        //static double Add(int x , int y)
        //{
        //    return x + y;
        //}
        //static double Add(double x, double y)
        //{
        //    return x + y;
        //}
        //static double Add(double x, int y)
        //{
        //    return x + y;
        //}
        //static double Add(int x, double y)
        //{
        //    return x + y;
        //}
        //static double Add(int x, int y,int z)
        //{
        //    return x + y + z;
        //}

        //----------------------------------------------------------

        //Recursion

        //static int Fact (int n)
        //{

        //    if (n <= 1)
        //        return 1;
        //    else
        //        return n * Fact(n - 1);
        //}

        //----------------------------------------------------------

        //Recursion

        //static int Power (int x,int y)
        //{
        //    if (y == 0) return 1;
        //    else return x * Power(x, y - 1);
        //}

        //----------------------------------------------------------

        //static void PirntShape (int n)     //SquareShape
        //{
        //    for (int i = 1; i <= n; i++)
        //    {
        //        for(int j = 1; j <= n; j++)
        //        {
        //            Console.Write('*');
        //        }
        //        Console.WriteLine();
        //    }
        //}

        //----------------------------------------------------------

        //static void PirntShape(int n,int m)     //SquareShape
        //{
        //    for (int i = 1; i <= n; i++)
        //    {
        //        for (int j = 1; j <= m; j++)
        //        {
        //            Console.Write('*');
        //        }
        //        Console.WriteLine();
        //    }
        //}

        //----------------------------------------------------------


    }
}
