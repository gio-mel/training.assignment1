namespace Assignment1;

public interface IVehicle
{
    void Drive();
    bool Refuel(int gasolineAmount);
}

public class Car : IVehicle
{
    private int _gasolineInitialAmount;

    public Car(int gasolineInitialAmount)
    {
        _gasolineInitialAmount = gasolineInitialAmount;
    }
    
    public void Drive()
    {
        if(_gasolineInitialAmount > 0) Console.WriteLine("Car is driving");
        Console.WriteLine("Gasoline amount: " + _gasolineInitialAmount);
    }

    public bool Refuel(int gasolineAmount)
    {
        _gasolineInitialAmount += gasolineAmount;
        return true;
    }
}

public class MainProgram
{
    public static void Main()
    {
        var car = new Car(0);
        Console.WriteLine("Give amount of gasoline to refuel");
        var amount = Console.ReadLine();
        car.Refuel(Convert.ToInt32(amount));
        car.Drive();
    }
}