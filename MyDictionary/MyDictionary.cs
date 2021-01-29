using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<Tkey, Tvalue>
    {
        Tkey[] _keys;
        Tvalue[] _values;

        public MyDictionary()
        {
            _keys = new Tkey[0];
            _values = new Tvalue[0];
        }

        public void Add(Tkey key, Tvalue value)
        {
            Tkey[] tempKey = _keys;
            Tvalue[] tempValue = _values;

            _keys = new Tkey[_keys.Length + 1 ];
            _values = new Tvalue[_values.Length + 1];

            for (int i = 0; i <tempKey.Length; i++)
            {
                _keys[i] = tempKey[i];
            }

            for (int i = 0; i < tempValue.Length; i++)
            {
                _values[i] = tempValue[i];
            }


            _keys[_keys.Length - 1] = key;
            _values[_values.Length - 1] = value;
        }
        public Tkey[] Keys
        {
            get { return _keys; }
        }

        public Tvalue[] Values
        {
            get { return _values; }
        }
    }
}
