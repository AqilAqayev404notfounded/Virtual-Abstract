namespace Virtual___Abstract;

abstract class Vehicle
{
    public string Color { get; set; }
    public int Year { get; }

    public Vehicle(int year)
    {
        Year = year;
    }

    public abstract void ShowInfo();
}

