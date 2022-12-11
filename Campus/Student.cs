global using Campus.enums;
namespace Campus
{
    public class Student
    {
        private string _name;
        private string _surname;
        private string _patronymic;
        private string _faculty;
        private Gender _gender;
        private string _group;
        private IndicatorBook key;
        private Curse _curse;

        public Student(string name, string surname, string patronymic, string faculty, Gender gender, string group, IndicatorBook key, Curse curse)
        {
            _name = name;
            _surname = surname;
            _patronymic = patronymic;
            _faculty = faculty;
            _gender = gender;
            _group = group;
            this.key = key;
            _curse = curse;
        }

        public string Name { get => _name; set => _name = value; }
        public string Surname { get => _surname; set => _surname = value; }
        public string Patronymic { get => _patronymic; set => _patronymic = value; }
        public string Faculty { get => _faculty; set => _faculty = value; }
        public Gender Gender { get => _gender; set => _gender = value; }
        public string Group { get => _group; set => _group = value; }
        public IndicatorBook Key { get => key; }
        public Curse Curse { get => _curse; set => _curse = value; }

        public override string ToString()
        {
            return $"Name {Name}, Surname {Surname}, Patronymic {Patronymic}, Faulty {Faculty}\nGender {Gender}, Group {Group}, Key {Key} Curse {_curse}";
        }
    }
}
