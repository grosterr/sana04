namespace Sana04;

public class MyDate
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