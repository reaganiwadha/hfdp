namespace c10_GumballMachine;

public class NoQuarterState : IGumballMachineState
{
    private readonly GumballMachine _gumballMachine;

    public NoQuarterState(GumballMachine gumballMachine)
    {
        _gumballMachine = gumballMachine;
    }

    public void InsertQuarter()
    {
        Console.WriteLine("Thank you for the money");
        _gumballMachine._currentState = _gumballMachine._hasQuarterState;
    }

    public void EjectQuarter()
    {
        Console.WriteLine("There is no quarter");
    }

    public void TurnCrank()
    {
        Console.WriteLine("Good luck with that");
    }

    public void Dispense()
    {
        Console.WriteLine("Ah yes, free gumball, if only life is so good");
    }
}