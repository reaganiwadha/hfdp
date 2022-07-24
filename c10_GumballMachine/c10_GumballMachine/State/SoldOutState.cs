namespace c10_GumballMachine;

public class SoldOutState : IGumballMachineState
{
    private readonly GumballMachine _gumballMachine;

    public SoldOutState(GumballMachine gumballMachine)
    {
        _gumballMachine = gumballMachine;
    }

    public void InsertQuarter()
    {
        Console.WriteLine("We are sold out, please eject quarter");
    }

    public void EjectQuarter()
    {
        Console.WriteLine("Ejecting quarter...");
    }

    public void TurnCrank()
    {
        Console.WriteLine("Can't you see it's empty?");
    }

    public void Dispense()
    {
        Console.WriteLine("Good luck with that");
    }
}