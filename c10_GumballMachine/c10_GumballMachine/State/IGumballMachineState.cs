namespace c10_GumballMachine;

public interface IGumballMachineState
{
    void InsertQuarter();
    void EjectQuarter();
    void TurnCrank();
    void Dispense();
}