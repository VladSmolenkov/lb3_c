using Campus.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campus
{
    public class Campus : ICloneable
    {
        private const string DIRECTORYPATH = @"..\..\CampusData";
        private string _name;
        private string _universityName;
        private string _adress;
        private List<Room> _rooms = new List<Room>(10);      
        private List<Worker> _workers = new List<Worker>(10);    
        private Dictionary<string, Student> _students = new Dictionary<string, Student>(5);
        private decimal _revenuePerMonth;
        private Dictionary<int, List<Student>> _roomStudents = new Dictionary<int, List<Student>>(10);
        private Campus(string name, string universityName, string adress, List<Room> rooms, List<Worker> workers, Dictionary<string, Student> students, decimal revenuePerMonth, Dictionary<int, List<Student>> roomStudents) // Constructor to clone
        {
            _name = name;
            _universityName = universityName;
            _adress = adress;
            _rooms = rooms;
            _workers = workers;
            _students = students;
            _revenuePerMonth = revenuePerMonth;
            this._roomStudents = roomStudents;
        }
        public Campus(string name, string universityName, string adress, decimal revenuePerMonth, Worker[] workers, Room[] rooms)
        {
            CampusValidator(rooms, workers);
            for (int i = 0; i < workers.Length; i++)
            {
                _workers.Add(workers[i]);
            }
            for (int i = 0; i < rooms.Length; i++)
            {
                _rooms.Add(rooms[i]);
            }
            for (int i = 0; i < rooms.Length; i++) // saving all available rooms
            {
                _roomStudents.Add(rooms[i].Number, new List<Student>());
            }
            _universityName = universityName;
            _adress = adress;
            _revenuePerMonth = revenuePerMonth;
            _name = name;
        }         
        public string UniversityName { get => _universityName; set => _universityName = value;  }
        public string UniversityAdress { get => _adress; set => _adress = value; }
        public int AmoontOfRooms { get => _rooms.Count; }
        public int AmountOfPersonal { get => _workers.Count; }
        public int AmountOfStudents { get => _students.Count;  }
        public decimal RevenuePerMonth { get => _revenuePerMonth; set => _revenuePerMonth = value; }
        private void CampusValidator(Room[] rooms, Worker[] workers)
        {
            bool amountOfRoomsIsValid = rooms.Length >= 30;
            bool resultWorkersIsValid = workers.Length >= 10;
            if(!amountOfRoomsIsValid || !resultWorkersIsValid)
            {
                throw new ArgumentException("Incorrent amount of rooms / workers");
            }
            bool[] allPositionsExist = {false, false, false, false};
            Position[] positions = { Position.zavgosp, Position.guardian, Position.commandant, Position.cleaner };
            for (int i = 0; i < positions.Length; i++)
            {
                bool found = false;
                for (int j = 0; j < workers.Length; j++)
                {
                    if(positions[i] == workers[j].Position)
                    {
                        found = true;
                        break;
                   } 
                }
                allPositionsExist[i] = found;
            }
            for (int i = 0; i < allPositionsExist.Length; i++)
            {
                if(allPositionsExist[i] == false)
                {
                    throw new ArgumentException("Not every position was found in workers");               
                }
            }

    
        }
        public void SettlementOfStudent(Student student, int roomNumber)
        {
             if(student == null)
            {
                throw new NullReferenceException("student was null");
            }
            if (!_roomStudents.ContainsKey(roomNumber))
            {
                throw new ArgumentException("Room with that number wasnt found");
            }
            List<Student> studentsLivingInCurrentRoom = _roomStudents[roomNumber];
            foreach (var studentRoom in studentsLivingInCurrentRoom)
            {
                if (studentRoom.Gender != student.Gender)
                {
                    throw new ArgumentException("Peope with two different genders cant live in the same room");
                }
            }
            if (_roomStudents[roomNumber].Count == (int)_rooms[roomNumber - 1].Type)
            {
                throw new ArgumentException("Cant add more students to that room with that type");
            }
            _roomStudents[roomNumber].Add(student);
            _rooms[roomNumber - 1].CurrentAmountLiving++;
            _students.Add(student.Key.ToString(), student);

        }
        public void EvictionOfStudent(IndicatorBook indecatorBook, int roomNumber)
        {
            if (!_students.ContainsKey(indecatorBook.ToString()))
            {
                throw new ArgumentException("Key (book) was invalid");
            }
            if (!_roomStudents.ContainsKey(roomNumber))
            {
                throw new ArgumentException("Room with that number wasnt found");
            }
            _students.Remove(indecatorBook.ToString());
            bool removed = false;
            foreach (var studentInRoom in _roomStudents[roomNumber])
            {
                if(studentInRoom.Key.ToString() == indecatorBook.ToString())
                {
                    _roomStudents[roomNumber].Remove(studentInRoom);
                    _rooms[roomNumber - 1].CurrentAmountLiving--;
                    removed = true;
                    break;
                }
            }
            if (!removed)
            {
                throw new ArgumentException($"Student wasnt found in {roomNumber} room");
            }
        }
        public void MoveStudent(IndicatorBook indecatorBook, int roomNumberFromWhich, int roomNumberToWhich)
        {
            if (!_roomStudents.ContainsKey(roomNumberFromWhich) || !_roomStudents.ContainsKey(roomNumberToWhich))
            {
                throw new ArgumentException("One of the rooms doesnt exist!");
            }
            
            Student savedStudent = null;
            foreach(var student in _roomStudents[roomNumberFromWhich])
            {
                if(student.Key.ToString() == indecatorBook.ToString())
                {
                    savedStudent = student;                  
                    break;
                }
            }
            if (savedStudent == null)
            {
                throw new ArgumentException($"Student with this key wasnt found in {roomNumberFromWhich} room");
            }
            foreach (var studentsInRoom in _roomStudents[roomNumberToWhich])                                         //Proverka na gender
            {
                if(studentsInRoom.Gender != savedStudent.Gender)
                {
                    throw new ArgumentException("You cant move to that room due to gender difference");
                }
                break;
            }
            _roomStudents[roomNumberFromWhich].Remove(savedStudent);
            _rooms[roomNumberFromWhich - 1].CurrentAmountLiving--;
            _roomStudents[roomNumberToWhich].Add(savedStudent);
            _rooms[roomNumberToWhich - 1].CurrentAmountLiving++;

        }
        public override string ToString()
        {            
            return _name;
        }
        public object Clone() // deep cloning
        {
            List<Room> rooms = new List<Room>(10);
            foreach (var room in _rooms)
            {
                Room roomToDeepClone = new Room(room.Number, room.Type, (room.PricePerPeron * (int)room.Type), room.CurrentAmountLiving, room.Keys.ToArray());
                rooms.Add(roomToDeepClone);
            }
            List<Worker> workers = new List<Worker>(10);
            foreach (var worker in _workers)
            {
                Worker workerToDeepClone = new Worker(worker.Name, worker.Surname, worker.Position, worker.Salary, worker.IndicatorNumber);
                workers.Add(workerToDeepClone);
            }
            Dictionary<string, Student> students = new Dictionary<string, Student>(10);
            foreach (var item in _students)
            {
                Student student = new Student(item.Value.Name, item.Value.Surname, item.Value.Patronymic, item.Value.Faculty, item.Value.Gender, item.Value.Group, item.Value.Key, item.Value.Curse);
                students.Add(item.Key, student);
            }
            Dictionary<int, List<Student>> roomStudents = new Dictionary<int, List<Student>>(10);
            for (int i = 1; i <= _roomStudents.Count; i++)
            {
                List<Student> studentsForDeepCloning = new List<Student>();
                foreach (var item in _roomStudents[i])
                {
                    studentsForDeepCloning.Add(new Student(item.Name, item.Surname, item.Patronymic, item.Faculty, item.Gender, item.Group, item.Key, item.Curse));
                }
                roomStudents.Add(i, studentsForDeepCloning);
            }
            return new Campus(_name, _universityName, _adress, rooms, workers, students, _revenuePerMonth, roomStudents);
        }
        public decimal CalculateRevenue(PeriodType periodType)
        {
            return _revenuePerMonth * (int)periodType;
        }
        public string GetFullInfo()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(this._name);
            stringBuilder.AppendLine(_universityName);
            stringBuilder.AppendLine(_adress);
            stringBuilder.AppendLine(_revenuePerMonth.ToString());
            stringBuilder.AppendLine("ROOMS");
            foreach (var room in this._rooms)
            {
                stringBuilder.AppendLine(room.ToString());
            }
            stringBuilder.AppendLine("WORKERS");
            foreach (var worker in _workers)
            {
                stringBuilder.AppendLine(worker.ToString());
            }
            stringBuilder.AppendLine("STUDENTS");
            if (_students != null)
            {
                foreach (var student in _students)
                {
                    stringBuilder.AppendLine(student.ToString());
                }
            }
            stringBuilder.AppendLine("Rooms And Students");
            for (int i = 1; i <= _roomStudents.Count; i++)
            {
                stringBuilder.AppendLine($"Room {i}\nStudents:");
                foreach (var item in _roomStudents[i])
                {
                    stringBuilder.AppendLine($"\n\t{item.ToString()}");
                }
            }
            return stringBuilder.ToString();
        }
        public void SaveInfoDataTXT()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(this._name);
            stringBuilder.AppendLine(_universityName);
            stringBuilder.AppendLine(_adress);
            stringBuilder.AppendLine(_revenuePerMonth.ToString());
            foreach (var room in this._rooms)
            {
                stringBuilder.AppendLine(room.ToString());
            }
            stringBuilder.AppendLine("WORKERS");
            foreach (var worker in _workers)
            {
                stringBuilder.AppendLine(worker.ToString());
            }
            File.WriteAllText($@"{DIRECTORYPATH}\Data.txt", stringBuilder.ToString());
        }
        public void SaveInfoStudentTXT()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Rooms And Students");
            for (int i = 1; i <= _roomStudents.Count; i++)
            {
                stringBuilder.AppendLine($"Room {i}\nStudents:");
                foreach (var item in _roomStudents[i])
                {
                    stringBuilder.AppendLine($"\n\t{item.ToString()}");
                }
            }
            File.WriteAllText($@"{DIRECTORYPATH}\Student.txt", stringBuilder.ToString());
        }
        public void SaveInfoWorkersTXT()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("WORKERS");
            foreach (var worker in _workers)
            {
                stringBuilder.AppendLine(worker.ToString());
            }
            File.WriteAllText($@"{DIRECTORYPATH}\Workers.txt", stringBuilder.ToString());
        }
        public string ReadFileFromPath(string path)
        {
            string text = "";
            using (var reader = new StreamReader(path))
            {
                string line;
                while (((line = reader.ReadLine()) != null))
                {
                    text += $"{line}\n";
                }
                
            }
            return text;
        }
    }
}
