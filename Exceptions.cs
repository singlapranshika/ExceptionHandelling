using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class SubtractionResultNegativeException : Exception
    {
        public SubtractionResultNegativeException(string mssg)
        {
            Console.WriteLine(mssg);
        }

    }
   
    class Exceptions
    {
        public double result;
        public double Add(double number1, double number2)
        {
            result = number1 + number2;
            return result;
        }
        public double Subtract(double number1, double number2)
        {
            result = number1 - number2;
            if (result < 0)
            {
                throw (new SubtractionResultNegativeException("number2 is greater than number1"));
            }
            else
            {
                return result;
            }
        }
        public double Multiply(double number1, double number2)
        {
            result = number1 * number2;
            return result;
        }
        public int Divide(int number1, int number2)
        {
            int res = 0;
            try
            {
                res = number1 / number2;

            }     
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return res;
        }
        static void Main(string[] args)
            {
            Exceptions m = new Exceptions();
            double number1, number2,result=0;
            int res = 0;
            Console.WriteLine("enter number1");
                number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter number2");
            number2 = Convert.ToDouble(Console.ReadLine());
                String ch;
            Console.WriteLine("enter operation");
            ch = Console.ReadLine();
                switch (ch)
                {
                    case "+":
                        result = m.Add(number1, number2);
                        break;
                    case "-":
                    try
                    {
                        result = m.Subtract(number1, number2);
                    }
                    catch(SubtractionResultNegativeException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                        break;
                    case "*":
                        result = m.Multiply(number1, number2);
                        break;

                    case "/":
                    int num1 = (int)number1;
                    int num2 = (int)number2;
                     res= m.Divide(num1, num2);
                    break;

                }
                Console.WriteLine(res);
            }

        }
    }

        