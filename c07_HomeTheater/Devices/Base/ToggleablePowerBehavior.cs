namespace c07_HomeTheater.Devices.Base
{
    public class ToggleablePowerBehavior
    {
        protected bool _powerState = false;

        public virtual void On() => _powerState = true;
        public virtual void Off() => _powerState = false;
    }
}