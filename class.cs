using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Sana04
{
    internal class Airplane
    {
        protected string StartCity;
        protected string FinishCity;
        protected MyDate StartDate;
        protected MyDate FinishDate;
        public Airplane()
        {
            StartCity = "Не вказано";
            FinishCity = "Не вказано";
            StartDate = new MyDate();
            FinishDate = new MyDate();
        }
        public Airplane(Airplane obj)
        {
            StartCity = obj.StartCity;
            FinishCity = obj.FinishCity;
            StartDate = new MyDate(obj.StartDate);
            FinishDate = new MyDate(obj.FinishDate);
        }
        public Airplane(string startcity, string finishcity, MyDate startdate, MyDate finishdate)
        {
            StartCity = startcity;
            FinishCity = finishcity;
            StartDate = startdate;
            FinishDate = finishdate;
        }
        public string GetStartCity()
        { return StartCity; }
        public string GetFinishCity()
        { return FinishCity; }
        public MyDate GetStartDate()
        { return StartDate; }
        public MyDate GetFinishDate()
        { return FinishDate; }
        public void SetStartCity(string startCity) { StartCity = startCity; }
        public void SetFinishCity(string finishCity) { FinishCity = finishCity; }
        public void SetStartDate(MyDate startDate) { StartDate = startDate; }
        public void SetFinishDate(MyDate finishDate) { FinishDate = finishDate; }
        public long GetTotalTime()
        {
            long startMinutes = StartDate.ToMinutes();
            long finishMinutes = FinishDate.ToMinutes();
            return finishMinutes - startMinutes;

        }
        public bool IsArrivingToday()
        {
            if (StartDate.GetYear() == FinishDate.GetYear() &&
                   StartDate.GetMonth() == FinishDate.GetMonth() &&
                   StartDate.GetDay() == FinishDate.GetDay())
                return true;
            else
                return false;
        }
    }

    internal class MyDate
    {
        protected int Year;
        protected int Month;
        protected int Day;
        protected int Hours;
        protected int Minutes;
        public MyDate()
        {
            Year = 2025;
            Month = 1;
            Day = 1;
            Hours = 0;
            Minutes = 0;
        }
        public MyDate(MyDate obj)
        {
            Year = obj.Year;
            Month = obj.Month;
            Day = obj.Day;
            Hours = obj.Hours;
            Minutes = obj.Minutes;
        }
        public MyDate(int year, int month, int day, int hours, int minutes)
        {
            Year = year;
            Month = month;
            Day = day;
            Hours = hours;
            Minutes = minutes;
        }

        public int GetYear()
        {
            return Year;
        }
        public int GetMonth()
        {
            return Month;
        }
        public int GetDay()
        {
            return Day;
        }
        public int GetHours()
        {
            return Hours;
        }
        public int GetMinutes()
        {
            return Minutes;
        }

        public long ToMinutes()
        {
            return Day * 24 * 60 + Hours * 60 + Minutes;
        }

    }
    internal class Product
    {
        protected string Name;
        protected int Price;
        protected Currency Cost;
        protected int Quantity;
        protected string Producer;
        protected double Weight;


        public Product(string name, int price, Currency cost, int quantity, string producer, double weight)
        {
            Name = name;
            Price = price;
            Cost = cost;
            Quantity = quantity;
            Producer = producer;
            Weight = weight;
        }
        public Product()
        {
            Name = "Товар";
            Price = 0;
            Cost = new Currency();
            Quantity = 0;
            Producer = "Невідомо";
            Weight = 0;
        }
        public Product(Product obj)
        {
            Name = obj.Name;
            Price = obj.Price;
            Cost =  new Currency(obj.Cost);
            Quantity = obj.Quantity;
            Producer = obj.Producer;
            Weight = obj.Weight;
        }
        public string GetName()
        { return Name; }
        public int GetPrice()
        { return Price; }
        public Currency GetCost()
        {
            return Cost;
        }
        public int GetQuantity()
        {
            return Quantity;
        }
        public string GetProducer()
        {
            return Producer;
        }
        public double GetWeight()
        {
            return Weight;
        }
        public double GetPriceInUAH()
        {
            return Price;
        }
        public void SetName(string name)
        {
            Name = name;
        }

        public void SetPrice(int price)
        {
            Price = price;
        }

        public void SetCost(Currency cost)
        {
            Cost = cost;
        }

        public void SetQuantity(int quantity)
        {
            Quantity = quantity;
        }

        public void SetProducer(string producer)
        {
            Producer = producer;
        }

        public void SetWeight(double weight)
        {
            Weight = weight;
        }
        public double GetTotalPriceInUAH()
        {
            int total;
            total = Price * Quantity;
            return total;
        }
        public double GetTotalWeight()
        {
            double total;
            total = Weight * Quantity;
            return total;
        }
    }
    internal class Currency
    {
        protected string Name;
        protected double ExRate;
        public Currency(string name, double exrate)
        {
            Name = name;
            ExRate = exrate;
        }
        public Currency()
        {
            Name = "UAH";
            ExRate = 1.0;
        }
        public Currency(Currency obj)
        {
            Name = obj.Name;
            ExRate = obj.ExRate;
        }
        public string GetName()
        {
            return Name;
        }
        public double GetExRate()
        {
            return ExRate;
        }
        public void SetName(string name) 
        { Name = name; }
        public void SetExRate(double exRate) 
        { ExRate = exRate; }
    }
}
