namespace Abstraction.Models;

abstract class Appliance
{
    public abstract string Name { get; }

    public abstract double CalculatePowerConsumption(int hours);

    public void ShowName()
    {
        Console.WriteLine($"Qurilma: {Name}");
    }

    public double CalculateWeeklyConsumption(int hoursPerDay)
    {
        return CalculatePowerConsumption(hoursPerDay) * 7;
    }

    public static void RunTest()
    {
        Appliance[] appliances =
        {
            new WashingMachine(),
            new AirHeater(),
            new ElectricKettle()
        };

        foreach (Appliance appliance in appliances)
        {
            Console.WriteLine(FormattableString.Invariant($"{appliance.Name}: {appliance.CalculatePowerConsumption(3)} kVt"));
            Console.WriteLine(FormattableString.Invariant($"Haftalik sarf (kuniga 3 soat, 7 kun): {appliance.CalculateWeeklyConsumption(3)} kVt-soat"));
            Console.WriteLine();
        }
    }
}

class WashingMachine : Appliance
{
    public override string Name => "WashingMachine";

    public override double CalculatePowerConsumption(int hours)
    {
        return hours * 1.0;
    }
}

class AirHeater : Appliance
{
    public override string Name => "AirHeater";

    public override double CalculatePowerConsumption(int hours)
    {
        return hours * 2.0;
    }
}

class ElectricKettle : Appliance
{
    public override string Name => "ElectricKettle";

    public override double CalculatePowerConsumption(int hours)
    {
        return hours * 1.5;
    }
}
