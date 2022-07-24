namespace c10_GumballMachine;

public class GumballMachine
{
    public IGumballMachineState _noQuarterState;
    public IGumballMachineState _hasQuarterState;
    public IGumballMachineState _soldState;
    public IGumballMachineState _soldOutState;

    public IGumballMachineState _currentState { get; set; }

    public int _count;

    public GumballMachine(int count)
    {
        _count = count;

        _noQuarterState = new NoQuarterState(this);
        _hasQuarterState = new HasQuarterState(this);
        _soldState = new SoldState(this);
        _soldOutState = new SoldOutState(this);
        
        _currentState = _noQuarterState;
    }

    public void InsertQuarter() => _currentState.InsertQuarter();

    public void EjectQuarter() => _currentState.EjectQuarter();

    public void TurnCrank() => _currentState.TurnCrank();

    public void Dispense() => _currentState.Dispense();

    public override string ToString()
    {
        return $"Count: ${_count} | Current State : ${_currentState.GetType().Name}";
    }
}