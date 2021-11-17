using c06_RemoteControl.Devices;

namespace c06_RemoteControl.Commands
{
    public class StereoOnWithCDCommand : ICommand
    {
        private readonly Stereo _stereo;

        public StereoOnWithCDCommand(Stereo stereo)
            => _stereo = stereo;

        public void Execute()
        {
            _stereo.On();
            _stereo.SetCD();
            _stereo.SetVolume(78);
        }

        public void Undo()
            => _stereo.Off();
    }
}