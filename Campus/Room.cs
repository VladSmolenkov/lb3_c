using Campus.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campus
{
    public class Room
    {
        private int _number;
        private RoomType _type;
        private decimal _pricePerPeron;
        private int _currentAmountLiving;
        private List<IndicatorBook> _keys;

        public Room(int number, RoomType type, decimal price, int currentAmountLiving, params IndicatorBook[] keys)
        {
            _keys = new List<IndicatorBook>();
            _number = number;
            _type = type;
            _pricePerPeron = price / (int)type;
            _currentAmountLiving = currentAmountLiving;
            for (int i = 0; i < keys.Length; i++)
            {
                _keys.Add(keys[i]);
            }
            
        }

        public int Number { get => _number; set => _number = value; }
        public RoomType Type { get => _type; }
        public decimal PricePerPeron { get => _pricePerPeron; set => _pricePerPeron = value; }
        public int CurrentAmountLiving { get => _currentAmountLiving; set => _currentAmountLiving = value; }
        public List<IndicatorBook> Keys { get => _keys; set => _keys = value; }
        public override string ToString()
        {
            return $"Number :{Number}, Room type {_type}, Price per person {_pricePerPeron}, Current amount living {_currentAmountLiving}";
        }
    }
}
