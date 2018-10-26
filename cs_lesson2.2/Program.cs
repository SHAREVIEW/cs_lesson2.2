using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_lesson2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 编写一个控制台应用程序，要求用户输入4个int值，并显示它们的乘积。
             * 提示：可以考虑使用Convert.ToDouble()命令，
             * 该命令可以把用户在控制台上输入的数转换为double；
             * 从string转为int的命令是Convert.ToInt32()。
             */
            double firstNumber, secondNumber, thirdNumber, forthNumber;
            string userName;
            Console.WriteLine("Please enter your name : ");
            userName = Console.ReadLine();
            Console.WriteLine("Welcome {0} ! Then you will give me four numbers.",userName);
            Console.WriteLine("Now give me a number: ");
            firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Now give me a number: ");
            secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Now give me a number: ");
            thirdNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Now give me a number: ");
            forthNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The product of {0}, {1}, {2} and {3} is {4}",
               firstNumber, secondNumber, thirdNumber, forthNumber,
               firstNumber*secondNumber*thirdNumber*forthNumber);
            Console.ReadKey();

        }
    }
}
