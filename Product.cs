namespace Sana04;

public class Product
{
        protected string Name;
        protected double Price;
        protected Currency Cost;
        protected int Quantity;
        protected string Producer;
        protected double Weight;


        public Product(string name, double price, Currency cost, int quantity, string producer, double weight)
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
        public double GetPrice()
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
            return Price * Cost.GetExRate();
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
            double total;
            total = Price * Quantity * Cost.GetExRate();
            return total;
        }
        public double GetTotalWeight()
        {
            double total;
            total = Weight * Quantity;
            return total;
        }
}   