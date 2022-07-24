namespace c10_GumballMachine;

public class SoldState : IGumballMachineState
{
    private readonly GumballMachine _gumballMachine;

    public SoldState(GumballMachine gumballMachine)
    {
        _gumballMachine = gumballMachine;
    }

    public void InsertQuarter()
    {
        Console.WriteLine("...");
    }

    public void EjectQuarter()
    {
        Console.WriteLine("...");
    }

    public void TurnCrank()
    {
        Console.WriteLine("...");
    }

    public void Dispense()
    {
        Console.WriteLine("Dispensing...");

        if (_gumballMachine._count < 1)
        {
            _gumballMachine._currentState = _gumballMachine._soldOutState;
            Console.WriteLine("We are out of it... please eject");
            return;
        }

        _gumballMachine._count--;

        Console.WriteLine("Have a nice day!");

        _gumballMachine._currentState = _gumballMachine._count < 1
            ? _gumballMachine._soldOutState
            : _gumballMachine._noQuarterState;
    }
}