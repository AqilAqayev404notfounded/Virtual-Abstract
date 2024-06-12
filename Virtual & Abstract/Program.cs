using Virtual___Abstract;

Vehicle[] vehicles = new Vehicle[2];
vehicles[0] = new Car("bmw", "f10", 180, "Qara", 2020);
vehicles[1] = new Bus(50, "qirmizi", 2018);

foreach (var vehicle in vehicles)
{
    vehicle.ShowInfo();
    Console.WriteLine();
}