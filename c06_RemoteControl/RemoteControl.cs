namespace c06_RemoteControl.Commands
{
    public class RemoteControl
    {
        private readonly (ICommand OffCommand, ICommand OnCommand)[] _commands;
        private ICommand _lastCommand;

        public RemoteControl(int slotSize = 7)
        {
            var noCommand = new NoCommand();
            _commands = new (ICommand OffCommand, ICommand OnCommand)[slotSize];
            for (var i = 0; i < slotSize; i++)
            {
                _commands[i].OffCommand = noCommand;
                _commands[i].OnCommand = noCommand;
            }

            _lastCommand = noCommand;
        }

        public void SetCommand(int slot, ICommand offCommand, ICommand onCommand)
        {
            _commands[slot].OffCommand = offCommand;
            _commands[slot].OnCommand = onCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            _commands[slot].OnCommand.Execute();
            _lastCommand = _commands[slot].OnCommand;
        }

        public void OffButtonWasPushed(int slot)
        {
            _commands[slot].OffCommand.Execute();
            _lastCommand = _commands[slot].OffCommand;
        }

        public void UndoButtonWasPushed(int slot)
            => _lastCommand.Undo();

        public string ToString()
        {
            var result = "--- Remote Control ---\n";

            for (var i = 0; i < _commands.Length; i++)
                result +=
                    $"{i} - On : {_commands[i].OnCommand.GetType().Name} | Off : {_commands[i].OffCommand.GetType().Name}\n";

            return result;
        }
    }
}