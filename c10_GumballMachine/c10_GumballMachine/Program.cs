using c10_GumballMachine;

public class Program
{
    public static void Main()
    {
        var gm = new GumballMachine(5);

        gm.InsertQuarter();
        gm.TurnCrank();

        Console.WriteLine(gm);

        gm.InsertQuarter();
        gm.EjectQuarter();
        gm.TurnCrank();

        Console.WriteLine(gm);

        gm.InsertQuarter();
        gm.TurnCrank();
        gm.InsertQuarter();
        gm.TurnCrank();
        gm.EjectQuarter();

        Console.WriteLine(gm);

        gm.InsertQuarter();
        gm.InsertQuarter();
        gm.TurnCrank();
        gm.InsertQuarter();
        gm.TurnCrank();
        gm.InsertQuarter();
        gm.TurnCrank();

        Console.WriteLine(gm);
    }
}