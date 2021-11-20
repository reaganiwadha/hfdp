using c07_HomeTheater.Devices.Base;

namespace c07_HomeTheater.Devices
{
    public enum PlayerState
    {
        Playing,
        Paused,
        Stopped
    }

    public enum PlayerAudioMode
    {
        Surround,
        TwoChannel
    }

    public class StreamingPlayer : ToggleablePowerBehavior, IVideoOutput
    {
        private PlayerState _playerState;
        private PlayerAudioMode _playerAudioMode;
        
        public void Play(string movie) => _playerState = PlayerState.Playing;
        public void Pause() => _playerState = PlayerState.Paused;
        public void Stop() => _playerState = PlayerState.Stopped;
        
        public void SetSurroundAudio() => _playerAudioMode = PlayerAudioMode.Surround;
        public void SetTwoChannelAudio() => _playerAudioMode = PlayerAudioMode.TwoChannel;
    }
}