using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //prints line asking for frist number
            Console.WriteLine(" intput frist number ");

            //collects number and converts it to double
            double number1 = Convert.ToDouble(Console.ReadLine());

            //prints line asking for second number
            Console.WriteLine(" input second number ");

            //collects number and converts it to double
            double number2 = Convert.ToDouble(Console.ReadLine());

            //prints line asking for third number
            Console.WriteLine(" input third number ");

            //collects and converts it to double
            double number3 = Convert.ToDouble(Console.ReadLine());


            if ( number1 > number2 )
            {
                number1 > number3;

                double largestnumber = number1;
            }
            else if (number2 > number1) 
            {
                number2 > number3

               double largestnumber = number2

            }
            else if(number3 > number1)
            {
                number
            }

             //calulates the largest number out of the frist two input
            //double largetsnumber1 = Math.Max(number1, number2);

            //calulates the largest number out of the largest of the frist two inputs and the third input
            //double largetsnumber2 = Math.Max(largetsnumber1, number3);

            //prints line oputing and showing user the largest number
            Console.WriteLine(" the largets number is " + largestnumber );

            //lest user see the final output
            Console.ReadLine();
            

        }
    }
}
