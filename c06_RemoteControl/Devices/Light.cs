namespace c06_RemoteControl.Devices
{
    public class Light
    {
        private bool _state;

        public void On()
            => _state = true;

        public void Off()
            => _state = false;
    }
}