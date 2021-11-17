using c06_RemoteControl.Devices.Base;

namespace c06_RemoteControl.Devices
{
    public enum StereoMediaSource
    {
        CD,
        Radio
    }

    public class Stereo : ToggleablePower
    {
        private int _volume;
        private StereoMediaSource _mediaSource = StereoMediaSource.Radio;

        public void SetCD()
            => _mediaSource = StereoMediaSource.CD;

        public void SetRadio()
            => _mediaSource = StereoMediaSource.Radio;

        public void SetVolume(int volume)
            => _volume = volume;
    }
}