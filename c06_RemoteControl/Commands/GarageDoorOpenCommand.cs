using c06_RemoteControl.Devices;

namespace c06_RemoteControl.Commands
{
    public class GarageDoorOpenCommand : ICommand
    {
        private readonly GarageDoor _garageDoor;

        public GarageDoorOpenCommand(GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }

        public void Execute()
            => _garageDoor.Open();

        public void Undo()
            => _garageDoor.Close();
    }
}