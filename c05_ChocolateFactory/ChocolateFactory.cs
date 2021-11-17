namespace c05_ChocolateFactory
{
    public class ChocolateFactory
    {
        private static ChocolateFactory _instance;

        private bool _empty;
        private bool _boiled;

        private ChocolateFactory()
        {
            _empty = true;
            _boiled = false;
        }

        public void Drain()
        {
            if (!_empty && _boiled) _empty = true;
        }

        public void Boil()
        {
            if (!_empty && !_boiled) _boiled = true;
        }

        public void Fill()
        {
            if (!_empty) return;
            _empty = false;
            _boiled = false;
        }

        public bool IsEmpty() => _empty;
        public bool IsBoiled() => _boiled;

        public static ChocolateFactory GetInstance()
        {
            return _instance ??= new ChocolateFactory();
        }
    }
}