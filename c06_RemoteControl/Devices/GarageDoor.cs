namespace c06_RemoteControl.Devices
{
    public enum DoorState
    {
        Opened,
        Halfway,
        Closed
    }

    public class GarageDoor
    {
        private DoorState _doorState;

        public void Open()
            => _doorState = DoorState.Opened;

        public void OpenHalfway()
            => _doorState = DoorState.Halfway;

        public void Close()
            => _doorState = DoorState.Closed;
    }
}