using System;
using c07_HomeTheater.Devices;

namespace c07_HomeTheater
{
    public class HomeTheaterFacade
    {
        private Amplifier _amplifier;
        private Tuner _tuner;
        private StreamingPlayer _player;
        private Projector _projector;
        private TheaterLights _lights;
        private Screen _screen;
        private PopcornPopper _popper;

        public HomeTheaterFacade(Amplifier amplifier, Tuner tuner, StreamingPlayer player,
            Projector projector, TheaterLights lights, Screen screen, PopcornPopper popper)
        {
            _amplifier = amplifier;
            _tuner = tuner;
            _player = player;
            _projector = projector;
            _lights = lights;
            _screen = screen;
            _popper = popper;
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine($"Getting ready to watch a movie {movie}");
            _popper.On();
            _popper.Pop();
            _lights.Dim(10);
            _screen.Down();
            _projector.On();
            _projector.WideScreenMode();
            _amplifier.On();
            _amplifier.SetStreamingPlayer(_player);
            _amplifier.SetSurroundAudio();
            _amplifier.SetVolume(5);
            _player.On();
            _player.Play(movie);
        }

        public void EndMovie()
        {
            Console.WriteLine("Shutting down...");
            _popper.Off();
            _lights.On();
            _screen.Up();
            _projector.Off();
            _amplifier.Off();
            _player.Stop();
            _player.Off();
        }
    }
}