using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campus
{
    public class IndicatorBook
    {
        private string _key;
        public IndicatorBook(string key)
        {
           if(key.Length != 8)
            {
                throw new ArgumentException("Key must be 8 charecters long!");
            }
           _key = key;
        }
        public string Key { get => _key; }
        public override string ToString()
        {
            return _key;
        }
        public override bool Equals(object? obj)
        {
           IndicatorBook indicatorBook = obj as IndicatorBook;
            return indicatorBook.ToString() == this.ToString();
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
