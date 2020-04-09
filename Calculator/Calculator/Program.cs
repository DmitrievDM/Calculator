using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Объявление переменных
            String inputString = "";
            
            Console.WriteLine("Добро пожаловать на карантин! \nСегодня мы будем делать (велосипед) калькулятор!");
            
            inputString = Console.ReadLine();

            Console.WriteLine(inputString);
            Console.ReadLine();

            
        }

        public static string GetShortString(string arg) {
            String paterrn = @"/(\()((\d+\.\d+)|(\d+))((\+|\-|\*|\/)((\d+\.\d+)|(\d+)))*(\))/";    //выдёргиваем часть выражения в скобках
            String substring = Regex.Match(arg, paterrn).Value;
            if (String.IsNullOrEmpty(substring))
            {

            }
            else
            {
                List<String> args = new List<String>();
                for (var m = Regex.Match(substring, @"/((\d+\.\d+)|(\d+))|(\+|\-|\*|\/)/"); m.Success; m = m.NextMatch()) //записываем все числа и знаки в список
                {
                    args.Add(m.Value);
                }
            }
            return arg;
        }

        public static double GetResult(double arg1, double arg2, char oper, double result = 0)    //вычисление операций между двумя переменными
        {
            switch (oper)
            {
                case '+':
                    Console.WriteLine("Складываем " + arg1 + " и " + arg2);
                    result += arg1 + arg2;
                    break;
                case '-':
                    Console.WriteLine("Складываем " + arg1 + " и " + arg2);
                    result += arg1 - arg2;
                    break;
                case '*':
                    Console.WriteLine("Складываем " + arg1 + " и " + arg2);
                    result += arg1 * arg2;
                    break;
                case '/':
                    Console.WriteLine("Складываем " + arg1 + " и " + arg2);
                    result += arg1 / arg2;
                    break;
                default:
                    Console.WriteLine("Ну и какая тут операция между " + arg1 + " и " + arg2 + "?");
                    break;
            }

            return result;
        }
    }
}
