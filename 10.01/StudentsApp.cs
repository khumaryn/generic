using System;
using System.Collections.Generic;
using System.Text;

namespace _10._01
{
    internal class StudentsApp<TLetter,TValue>
    {
        public StudentsApp(int size = 0)
        { 
        _letter=new TLetter[size];
        _values=new TValue[size];
        }
        TLetter[] _letter;
        TValue[] _values;
        public void Add(TLetter letter, TValue value)
        { 
        Array.Resize(ref _letter, _letter.Length+1);
            _letter[_letter.Length - 1] = letter;
            Array.Resize(ref _values, _values.Length + 1);
            _values[_values.Length - 1] = value;
        }
        public void Add1(TLetter letter)
        {
            Array.Resize(ref _letter, _letter.Length + 1);
            _letter[_letter.Length - 1] = letter;
            
        }
        public TValue[] Values => _values;
        public TLetter[] Letter => _letter;
        public TValue GetValue(TLetter letter)
        {
            var index = Array.IndexOf(_letter, letter);

            if (index < 0) throw new IndexOutOfRangeException();

            return _values[index];
        }
        public void RemoveAt(int index)
        {
            if (index < 0 || index >= _letter.Length)
                throw new IndexOutOfRangeException();

            for (int i = index; i < _letter.Length - 1; i++)
            {
                var swap = _letter[i];
                _letter[i] = _letter[i + 1];
                _letter[i + 1] = swap;
            }


            System.Array.Resize(ref _letter, _letter.Length - 1);
        }
        public TLetter GetValue(int index)
        {
            return _letter[index];
        }
        public void Remove(TLetter letter)
        {
            var index = System.Array.IndexOf(_letter, letter);

            RemoveAt(index);
        }

    }
}
