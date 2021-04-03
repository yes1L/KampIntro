using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryExample2
{
    class MyDictionary<Key, Value>
    {
        Key[] _key;
        Value[] _value;

        public MyDictionary()
        {
            _key = new Key[0];
            _value = new Value[0];
        }

        public void Add(Key key, Value value)
        {
            Key[] _tempKey = _key;
            Value[] _tempValue = _value;

            _key = new Key[_key.Length+1];
            _value = new Value[_value.Length+1];

            for (int i = 0; i < _tempKey.Length; i++)
            {
                _key[i] = _tempKey[i];
            }
            
            _key[_key.Length - 1] = key;

            for (int i = 0; i < _tempValue.Length; i++)
            {
                _value[i] = _tempValue[i];
            }

            _value[_value.Length - 1] = value;

        }
        public int Count
        {
            get { return _value.Length; }
        }



    }
}
