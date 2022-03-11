using System.ComponentModel;

namespace Testik
{
    public class Counter
    {
        private int _value;

        public int Value => _value;

        public Counter()
        {
            _value = 0;
        }

        public void Increase()
        {
            _value++;
        }

        public void Reduce()
        {
            if(_value > 0) _value--;
        }
    }
}
