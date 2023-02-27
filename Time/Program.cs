using System.Xml.Linq;

public class Time
{
    private int hours;
    private int minutes;
    private int seconds;

        public Time(int hours, int minutes, int seconds)
    {
       
        Hours = hours;
        Minutes = minutes;
        Seconds = seconds;
    }
    public Time()
    {
        Seconds = 30;
        Minutes = 32;
        Hours = 21;
    }

    public int Hours
    {
        get { return hours; }
        set
        {
            if (value < 0 || value > 23)
            {
                throw new ArgumentException("Invalid hours value");
            }

            hours = value;
        }
    }

    public int Minutes
    {
        get { return minutes; }
        set
        {
            if (value < 0 || value > 59)
            {
                throw new ArgumentException("Invalid minutes value");
            }

            minutes = value;
        }
    }

    public int Seconds
    {
        get { return seconds; }
        set
        {
            if (value < 0 || value > 59)
            {
                throw new ArgumentException("Invalid seconds value");
            }

            seconds = value;
        }
    }

    public void AddTime(int hours, int minutes, int seconds)
    {
       this.seconds += seconds;
        if (this.seconds >= 60)
        {
            this.minutes += this.seconds / 60;
            this.seconds -= 60;
        }
       this.minutes += minutes ;
        if (this.minutes >= 60)
        {
            this.hours += this.minutes / 60;
            this.minutes -= 60;
        }
        this.hours += hours;
         if(this.hours>=24)
            {
             this.hours -= 24;
            }

      
    }
    public override string ToString()
    {
        return $"\nSeconds: {Seconds}, Minutes: {Minutes}, Hours: {Hours}";
    }
    static void Main(string[] args)
    {
        Time time1 = new Time(21,23,21);
        Time time2 = new Time(25, 23, 20);
        Time time3 = new Time();
        time1.AddTime(1,30,1);
        time2.AddTime(1, 40, 1);
        time3.AddTime(2, 30, 34);
        Console.WriteLine(time1.ToString());
        Console.WriteLine(time2.ToString());
        Console.WriteLine(time3.ToString());
        Console.ReadLine();
    }
}


