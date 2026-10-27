class Car:IVehicle
{
    int gasoline;
    public Car(int gasoline)
    {
        this.gasoline = gasoline;
    }
    public void Drive()
    {
        if (gasoline > 0)
        {
            Console.WriteLine("Вождение");
        }
    }
    public bool Refuel(int amount)
    {
        gasoline += amount;
        return true;
    }
}