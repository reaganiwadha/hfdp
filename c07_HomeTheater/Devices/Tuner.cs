using c07_HomeTheater.Devices.Base;

namespace c07_HomeTheater.Devices
{
    public enum TunerModulationMode
    {
        FM,
        AM
    }

    public class Tuner : ToggleablePowerBehavior
    {
        private TunerModulationMode _mode;
        private float _frequency;

        public void SetAM() => _mode = TunerModulationMode.AM;
        public void SetFM() => _mode = TunerModulationMode.FM;

        public void SetFrequency(float frequency) => _frequency = frequency;
    }
}