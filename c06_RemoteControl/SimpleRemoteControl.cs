using c06_RemoteControl.Commands;

namespace c06_RemoteControl
{
    public class SimpleRemoteControl
    {
        private ICommand _slot;

        public void SetCommand(ICommand command) => _slot = command;

        public void ButtonWasPressed() => _slot.Execute();
    }
}