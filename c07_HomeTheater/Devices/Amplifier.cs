using c07_HomeTheater.Devices.Base;

namespace c07_HomeTheater.Devices
{
    public class Amplifier : ToggleablePowerBehavior
    {
        private int _volume;
        private PlayerAudioMode _playerAudioMode;

        public void SetVolume(int volume) => _volume = volume;

        public void SetSurroundAudio() => _playerAudioMode = PlayerAudioMode.Surround;
        public void SetTwoChannelAudio() => _playerAudioMode = PlayerAudioMode.TwoChannel;

        private Tuner _tuner;
        private StreamingPlayer _player;

        public void SetTuner(Tuner tuner) => _tuner = tuner;
        public void SetStreamingPlayer(StreamingPlayer player) => _player = player;
    }
}