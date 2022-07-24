namespace c10_GumballMachine;

public class HasQuarterState : IGumballMachineState
{
    private readonly GumballMachine _gumballMachine;

    public HasQuarterState(GumballMachine gumballMachine)
    {
        _gumballMachine = gumballMachine;
    }

    public void InsertQuarter()
    {
        Console.WriteLine("You have already inserted a quarter");
    }

    public void EjectQuarter()
    {
        Console.WriteLine("Ejecting quarter");
        _gumballMachine._currentState = _gumballMachine._noQuarterState;
    }

    public void TurnCrank()
    {
        _gumballMachine._currentState = _gumballMachine._soldState;
        _gumballMachine._currentState.Dispense();
    }

    public void Dispense()
    {
        Console.WriteLine("You need to turn the crank");
    }
}