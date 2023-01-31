using System;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            {
                //Veirlmiş iki ədədi toplayıb console-a yazdıran metod
                var result = Topla(70, 35);


                Console.WriteLine(result);
            }
            static int Topla(int num1, int num2)
            {
                int topla = num1 + num2;
                return topla;

            }




            // Verilmiş iki ədədi toplayıb qaytaran metod
            static void Main1(string[] args)
            {
                var result = Topla1(70, 35);

            }
            static int Topla1(int num1, int num2)
            {
                int topla = num1 + num2;
                return topla;

            }
            {
                //Verilmiş ədədlər siyahısındaki ədədlərin cəmini console-a yazdıran metod
                var result = ObsiCem(10, 11, 12, 13);

                Console.WriteLine(result);
            }
            static int medhod3()
            { 
            
                string numberStr = Console.ReadLine();
                int number = Convert.ToInt32(numberStr);
                return number;
            }

            static int ObsiCem (int number1, int number2, int number3, int number4)

            {

                number1 = medhod3();
                number2 = medhod3();
                number3 = medhod3();
                number4 = medhod3();
                var result = number1 + number2 + number3 + number4;
                Console.WriteLine(result);
                  return result;
            }



            //Verilmiş yazını əks şəkildə qaytaran metod

            {
                Console.WriteLine("sozu yazin");
                string input = Console.ReadLine();

                string reverseInput = "";
               for (int i = input.Length - 1; i >= 0; i--)
                {
                    reverseInput += input[i];
                } Console.WriteLine(reverseInput);
            }
        }
    }
}
