using c06_RemoteControl.Devices;

namespace c06_RemoteControl.Commands
{
    public class GarageDoorCloseCommand : ICommand
    {
        private readonly GarageDoor _garageDoor;

        public GarageDoorCloseCommand(GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }

        public void Execute()
            => _garageDoor.Close();

        public void Undo()
            => _garageDoor.Open();
    }
}