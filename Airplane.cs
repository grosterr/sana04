namespace Sana04;

public class Airplane
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
            StartDate = new MyDate(startdate);
            FinishDate = new MyDate(finishdate);
        }
        public string GetStartCity()
        { return StartCity; }
        public string GetFinishCity()
        { return FinishCity; }
        public MyDate GetStartDate()
        { return new MyDate(StartDate); }
        public MyDate GetFinishDate()
        { return new MyDate(FinishDate); }
        public void SetStartCity(string startCity) { StartCity = startCity; }
        public void SetFinishCity(string finishCity) { FinishCity = finishCity; }
        public void SetStartDate(MyDate startDate) { StartDate = new MyDate(startDate); }
        public void SetFinishDate(MyDate finishDate) { FinishDate = new MyDate(finishDate); }
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