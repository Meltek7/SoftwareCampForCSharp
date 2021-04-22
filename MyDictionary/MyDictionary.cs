using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
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
            bool isKeyExist = ContainsKey(key);
            if (!isKeyExist)
            {
                Key[] _tempKey = _key;
                Value[] _tempValue = _value;

                _key = new Key[_key.Length + 1];
                _value = new Value[_value.Length + 1];


                for (int i = 0; i < _tempKey.Length; i++)
                {
                    _key[i] = _tempKey[i];
                }
                for (int i = 0; i < _tempValue.Length; i++)
                {
                    _value[i] = _tempValue[i];
                }


                _key[_key.Length - 1] = key;
                _value[_value.Length - 1] = value;
            }

            else
            {
                throw new Exception("Key is already exist!");
            }
        }

        public bool ContainsKey(Key key)
        {
            bool isThere = false;
            foreach (var item in _key)
            {
                if (item.ToString() == key.ToString())
                {
                    isThere = true;
                }
                else
                {
                    isThere = false;
                }
            }
            return isThere;
        }

        public bool ContainsValue(Value value)
        {
            bool isThere = false;
            foreach (var item in _value)
            {
                if (item.ToString() == value.ToString())
                {
                    isThere = true;
                }
                else
                {
                    isThere = false;
                }
            }
            return isThere;
        }
        public int KeyLength { get { return _key.Length; } }
        public int ValueLength { get { return _value.Length; } }
        public Key[] Keys { get { return _key; } }
        public Value[] Values { get { return _value; } }


    }
}
