using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11
{
    //Day12 yapıldı ve program güncellendi
    class Program
    {
        static void Main(string[] args)
        {         
            /*
             * Ask user to how many input they want to calculate together
             * Take number one by one with operations
             * Make calculation with these operators and show them on the screen
             * operators are +, -, * and / .
             * Not : except parentheses, and calculation order not imprior.
             * 
             * Number Count : 3
             * 1. Number : 5
             * Operator : *
             * 2. Number : 4
             * Operator2 : +
             * 3. Number : 2
             * 
             * "Calculation Result : 5 * 4 + 2 = 22"
             */

            Console.WriteLine("Kaç sayı üzerinde işlem yapılacagını giriniz: ");
            int numberCount = Convert.ToInt32(Console.ReadLine());

            if (numberCount == 0)
            {
                Console.WriteLine("İşlem sayısı 0 girilemez");
                Console.ReadKey();
            }

            else
            {
                int[] numbers = new int[numberCount];
                char[] operators = new char[numberCount - 1];

                int index = 0;

                // Kullanıcı Sayı ve  Operator Girişleri Alınacak
                for (int i = 1; i <= numberCount; i++)
                {
                    index = i - 1;
                    Console.WriteLine("{0}. sayıyı giriniz: ", i);
                    numbers[index] = Convert.ToInt32(Console.ReadLine());

                    if (i < numberCount)
                    {
                        // Ödev : Yanlış Operator Girildiğinde doğrusu girilene kadar yeniden girişi sağlanacak
                        Console.WriteLine("Operatörü giriniz: ");
                        

                        if (OperatorIsValid())
                        {
                            operators[index] = Convert.ToChar(Console.ReadLine());
                        }
                    }
                }

                int total = numbers[0];
                StringBuilder sbMessage = new StringBuilder();
                sbMessage.Append(numbers[0]); // 5

                for (int i = 1; i < numberCount; i++)
                {
                    index = i - 1;

                    char oprt = operators[index];
                    int nextNumber = numbers[index + 1];
                    sbMessage.Append(oprt);
                    sbMessage.Append(nextNumber);


                    switch (oprt)
                    {
                        case '+': total += nextNumber; break;
                        case '-': total -= nextNumber; break;
                        case '*': total *= nextNumber; break;
                        case '/': total /= nextNumber; break;
                    }

                    //String Builder incele
                }
                sbMessage.Append("=");
                sbMessage.Append(total);
                Console.WriteLine(sbMessage.ToString());

                Console.ReadKey();
            }
        }
    }
}
