using Sana04;
using System;
using System.Collections.Generic;
using System.Text;

internal class Program
{
    private static Airplane person1;
    private static Airplane person2;
    private static MyDate date1;
    private static MyDate date2;
    private static MyDate date3;
    private static MyDate date4;
    private static Product product1;
    private static Product product2;
    private static Currency currency1;
    private static Currency currency2;

    private static void Main(string[] arg)
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;
    date1 = new MyDate(2025, 11, 7, 8, 0);
        date2 = new MyDate(2025, 11, 7, 16, 0);
        person1 = new Airplane("Zhytomyr", "Rotterdam", date1, date2);
        Console.WriteLine($"Приблизний час польоту рейсу {person1.GetStartCity()}-{person1.GetFinishCity()}: {person1.GetTotalTime()} хвилин");

        date3 = new MyDate(2025, 12, 7, 8, 0);
        date4 = new MyDate(2025, 12, 8, 3, 0);
        person2 = new Airplane("Riga", "New_York", date3, date4);
        Console.WriteLine($"Приблизний час польоту рейсу {person2.GetStartCity()}-{person2.GetFinishCity()}: {person2.GetTotalTime()} хвилин");

        Currency uah = new Currency("UAH", 1.0);
        product1 = new Product("Шоколад", 70, uah, 35, "Шоколадна фабрика", 95.50);
        Console.WriteLine($"Продукту {product1.GetName()} на складі {product1.GetQuantity()} штук, на суму: {product1.GetTotalPriceInUAH()} грн");

        product2 = new Product("Чашка", 220, uah, 20, "Порцелянова фабрика", 120.50);
        Console.WriteLine($"Продукту {product2.GetName()} на складі {product2.GetQuantity()} штук, на суму: {product2.GetTotalPriceInUAH()} грн");

        currency1 = new Currency("Долар", 41.97);
        Console.Write($"За один {currency1.GetName()} ви отримаєте {currency1.GetExRate()} грн");

        currency2 = new Currency("Ліра", 1.01);
        Console.Write($"\nЗа одну {currency2.GetName()} ви отримаєте {currency2.GetExRate()} грн");

    }
}