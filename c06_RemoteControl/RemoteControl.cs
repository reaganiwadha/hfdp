namespace c06_RemoteControl.Commands
{
    public class RemoteControl
    {
        private readonly (ICommand OffCommand, ICommand OnCommand)[] _commands;

        public RemoteControl(int slotSize = 7)
        {
            _commands = new (ICommand OffCommand, ICommand OnCommand)[slotSize];
            for (var i = 0; i < slotSize; i++)
            {
                _commands[i].OffCommand = new NoCommand();
                _commands[i].OnCommand = new NoCommand();
            }
        }

        public void SetCommand(int slot, ICommand offCommand, ICommand onCommand)
        {
            _commands[slot].OffCommand = offCommand;
            _commands[slot].OnCommand = onCommand;
        }

        public void OnButtonWasPushed(int slot)
            => _commands[slot].OnCommand.Execute();

        public void OffButtonWasPushed(int slot)
            => _commands[slot].OffCommand.Execute();

        public string ToString()
        {
            var result = "--- Remote Control ---\n";

            for (var i = 0; i < _commands.Length; i++)
                result += $"{i} - On : {_commands[i].OnCommand.GetType().Name} | Off : {_commands[i].OffCommand.GetType().Name}\n";

            return result;
        }
    }
}