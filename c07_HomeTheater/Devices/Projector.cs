using c07_HomeTheater.Devices.Base;

namespace c07_HomeTheater.Devices
{
    public enum ProjectorMode
    {
        Tv,
        WideScreen
    }

    public class Projector : ToggleablePowerBehavior
    {
        private ProjectorMode _projectorMode;
        private StreamingPlayer _player;
        private IVideoOutput _videoOutput;

        public Projector(StreamingPlayer player)
        {
            _player = player;
        }

        public void TvMode() => _projectorMode = ProjectorMode.Tv;
        public void WideScreenMode() => _projectorMode = ProjectorMode.WideScreen;
        public void SetInput(IVideoOutput videoOutput) => _videoOutput = videoOutput;
    }
}