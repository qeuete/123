using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace mtest
{
    internal class Conditerskaya
    {
        static void Main(string[] args)
        {
            {
                ZakazTorta();
                int pos = Menu.Show(3, 9);
                Console.Clear();

                while (true)
                {
                    if (pos == 3)
                    {
                        FormaTorta();
                    }
                    if (pos == 4)
                    {
                        RazmerTorta();
                    }
                    else if (pos == 5)
                    {
                        NachinkaTorta();
                    }
                    else if (pos == 6)
                    {
                        YarusiTorta();
                    }
                    else if (pos == 7)
                    {
                        PokritieTorta();
                    }
                    else if (pos == 8)
                    {
                        DekorTorta();
                    }
                    else if (pos == 9)
                    {
                        ZavershenieZakaza();                     
                    }
                }
            }


        }
        static void ZakazTorta()
        {
            Console.WriteLine("Добрый день! \nЕсли вы готовы сделать заказ, выберите следующие параметры:");
            Console.WriteLine();
            Console.WriteLine("   1. Форма");
            Console.WriteLine("   2. Размер");
            Console.WriteLine("   3. Начинка");
            Console.WriteLine("   4. Ярусы");
            Console.WriteLine("   5. Покрытие");
            Console.WriteLine("   6. Декор");
            Console.WriteLine("   7. Завершить заказ");
        }
        static void FormaTorta()
        {
            Console.WriteLine("Форма:");
            Console.WriteLine();
            Console.WriteLine("   Круг - 400");
            Console.WriteLine("   Квадрат - 600");
            Console.WriteLine("   3D - 1300");
            int pos2 = Menu.Show(2, 4);
        }
        static void RazmerTorta()
        {
            Console.WriteLine("Размер:");
            Console.WriteLine();
            Console.WriteLine("   Бенто   (Диаметр - 14см, 6 порций) - 900 ");
            Console.WriteLine("   Обычный (Диаметр - 18см, 12 порций) - 1100");
            Console.WriteLine("   Большой (Диаметр - 24см, 20 порций) - 1800");
            int pos2 = Menu.Show(2, 4);
        }
        static void NachinkaTorta()
        {
            Console.WriteLine("Начинка:");
            Console.WriteLine();
            Console.WriteLine("   Красный бархат - 1100");
            Console.WriteLine("   Рафаэло - 1400");
            Console.WriteLine("   Наполеон - 1000");
            Console.WriteLine("   Медовик - 1000");
            Console.WriteLine("   Манго-маракуйа - 1400");
            Console.WriteLine("   Клубника-банан - 1200");
            int pos2 = Menu.Show(2, 7);

        }
        static void YarusiTorta()
        {
            Console.WriteLine("Ярусы:");
            Console.WriteLine();
            Console.WriteLine("   1 ярус - 1000");
            Console.WriteLine("   2 яруса - 1400");
            Console.WriteLine("   3 яруса - 1600");
            Console.WriteLine("   4 яруса - 1900");
            int pos2 = Menu.Show(2, 5);
        }
        static void PokritieTorta()
        {
            Console.WriteLine("Покрытие:");
            Console.WriteLine();
            Console.WriteLine("   Ганаш");
            Console.WriteLine("   Крем-чиз на сливках");
            Console.WriteLine("   Крем-чиз на масле");
            Console.WriteLine("   Белково-масляный крем");
            Console.WriteLine("   Велюр");
            int pos2 = Menu.Show(2, 6);
        }
        static void DekorTorta()
        {
            Console.WriteLine("Декор:");
            Console.WriteLine();
            Console.WriteLine("   Сезонные ягоды - 800");
            Console.WriteLine("   Шоколадные подтеки - 400");
            Console.WriteLine("   Вафельные украшения - 500");
            Console.WriteLine("   Топер - 200");
            Console.WriteLine("   Без декора");
            int pos2 = Menu.Show(2, 6);
        }
        static void ZavershenieZakaza()
        {
            Console.WriteLine("Спасибо за заказ.\nДля оформления нового заказажа нажмите Escape");
        }
        static void VihodVMenu()
        {
            ConsoleKeyInfo vihod = Console.ReadKey();
            Console.WriteLine();
            vihod = Escape;
            if (vihod.Key == ConsoleKey.Escape)
            {
                ZakazTorta();
                int pos = Menu.Show(3, 9);
            }
        }
    }
}
        
            
          

   

