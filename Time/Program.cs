
public class Time
{
    private int hours;
    private int minutes;
    private int seconds ;

    public Time(int hours, int minutes, int seconds)
    {
        Hours = hours;
        Minutes = minutes;
        Seconds = seconds;
    }
    public Time() : this(12, 11, 21)
    {

    }
    public int Hours
    {
        get => hours; 
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

        get => minutes;
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
        get => seconds;
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
            this.seconds %= 60;
        }
       this.minutes += minutes ;
        if (this.minutes >= 60)
        {
            this.hours += this.minutes / 60;
            this.minutes %= 60;
        }
        this.hours += hours;
        if  (this.hours >= 24)
        {
             this.hours %= 24;
        }
    }
    public override string ToString()
    {
        return $"Seconds: {Seconds::00}, Minutes: {Minutes::00}, Hours: {Hours::00}";
    }
    static void Main(string[] args)
    {
        Time time = null, time1 = null;
        try
        {
             time = new Time(21, 23, 21);
             time1 = new Time(25, 23, 20);
        }
        catch(ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
        try
        {
            time.AddTime(1, 30, 1);
            time1.AddTime(1, 40, 1);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
        Console.WriteLine(time);
        Console.WriteLine(time1);
        Console.ReadKey();
    }
}


