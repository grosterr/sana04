namespace Sana04;

public class Currency
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