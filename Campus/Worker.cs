using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campus
{
    public class Worker
    {
        private string _name;
        private string _surname;
        private Position _position;
        private decimal _salary;
        private IndicatorNumber _indicatorNumber;

        public Worker(string name, string surname, Position position, decimal salary, IndicatorNumber indicatorNumber)
        {
            if(salary < 8000 || salary > 40000)
            {
                throw new ArgumentException("Salary cant be less than 8000 or more than 40000");
            }
            _name = name;
            _surname = surname;
            _position = position;
            _salary = salary;
            _indicatorNumber = indicatorNumber;
        }

        public string Name { get => _name; set => _name = value; }
        public string Surname { get => _surname; set => _surname = value; }
        public Position Position { get => _position; set => _position = value; }
        public decimal Salary { get => _salary; set => _salary = value; }
        public IndicatorNumber IndicatorNumber { get => _indicatorNumber;}
        public override string ToString()
        {
            return $"Name {_name}, Surname {_surname}, Position {_position}, Salary {_salary}, Indicator Number {_indicatorNumber}";
        }
    }
}
