namespace c07_HomeTheater.Devices
{
    public class Screen
    {
        private int _position = 100;

        public void Up() => _position = 100;

        public void Down() => _position = -100;
    }
}