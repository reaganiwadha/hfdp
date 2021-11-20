using c07_HomeTheater.Devices;

namespace c07_HomeTheater
{
    class Program
    {
        static void Main(string[] args)
        {
            var popper = new PopcornPopper();
            var lights = new TheaterLights();
            var screen = new Screen();
            var player = new StreamingPlayer();
            var projector = new Projector(player);
            var amp = new Amplifier();
            var tuner = new Tuner();
            
            var homeTheater = new HomeTheaterFacade(amp, tuner, player, projector, lights, screen, popper);
            homeTheater.WatchMovie("A very cool movie");
            homeTheater.EndMovie();
        }
    }
}
