using c07_HomeTheater.Devices.Base;

namespace c07_HomeTheater.Devices
{
    public class TheaterLights : ToggleablePowerBehavior
    {
        private uint _intensity = 100;

        public void Dim(uint amount)
        {
            _intensity -= amount;
        }

        public override void Off()
        {
            _intensity = 0;
            base.Off();
        }

        public override void On()
        {
            _intensity = 100;
            base.On();
        }
    }
}