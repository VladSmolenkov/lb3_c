using System.Diagnostics;
using System.Text;

namespace Campus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Campus> campuses = new List<Campus>(5);
        Random random = new Random();
        private void GenerateCampusBtn_Click(object sender, EventArgs e)
        {
            Campus campus = null;
            string[] campusNames = { "Humboldt", "Bakersfield", "Channel Islands", "Fresno", "Northridge", "Sonoma"};
            try
            {
                 campus = new Campus(campusNames[random.Next(0, campusNames.Length)], "KNURE", "NAUKI", random.Next(25000, 50000), GenerateWorkers(), GenerateRooms());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            campuses.Add(campus);
            UpdateComboBox();
            MessageBox.Show("Success!");
        }
        private string GenerateName()
        {
            string[] names = {"Harry","Ross",
                        "Bruce","Cook",
                        "Carolyn","Morgan",
                        "Albert","Walker",
                        "Randy","Reed",
                        "Larry","Barnes",
                        "Lois","Wilson",
                        "Jesse","Campbell",
                        "Ernest","Rogers",
                        "Theresa","Patterson",
                        "Henry","Simmons",
                        "Michelle","Perry",
                        "Frank","Butler",
                        "Shirley" };
            return names[random.Next(0, names.Length - 1)];
        }
        private string GenerateSurname()
        {
            string[] surnames = {"Ruth","Jackson",
                    "Debra","Allen",
                    "Gerald","Harris",
                    "Raymond","Carter",
                    "Jacqueline","Torres",
                    "Joseph","Nelson",
                    "Carlos","Sanchez",
                    "Ralph","Clark",
                    "Jean","Alexander",
                    "Stephen","Roberts",
                    "Eric","Long",
                    "Amanda","Scott",
                    "Teresa","Diaz",
                    "Wanda","Thomas"};
            return surnames[random.Next(0, surnames.Length - 1)];

        }
        private Worker[] GenerateWorkers()
        {
        
            Worker[] workers = new Worker[random.Next(10, 25)];          
            for (int i = 0; i < workers.Length; i++)
            {
                workers[i] = new Worker(GenerateName(),
                    GenerateSurname(),
                    (Position)random.Next(0, 4),
                    random.Next(8000, 40000),
                    new IndicatorNumber(GenerateKeyForWorker()));
            }
            return workers;

        }
        private string GenerateKeyForWorker()
        {
          
            string[] numbersForKey = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                stringBuilder.Append(numbersForKey[random.Next(1, numbersForKey.Length - 1)]);
            }
            return stringBuilder.ToString();
        }
        private Room[] GenerateRooms()
        {
         
            Room[] rooms = new Room[random.Next(35, 100)];
            RoomType[] roomTypes = { RoomType.Comfort, RoomType.Single, RoomType.Standart};
            for (int i = 0; i < rooms.Length; i++)
            {
                rooms[i] = new Room(i + 1, roomTypes[random.Next(0, roomTypes.Length)], random.Next(1200, 4000), 0);
            }
            return rooms;
        }
        private void UpdateComboBox()
        {
            SavedCampusesComboBox.Items.Clear();
            foreach (var campus in campuses)
            {
                SavedCampusesComboBox.Items.Add(campus);
            }
            SavedCampusesComboBox.Text = "";
        }
        public bool TryGetCampusFromCheckBox(out Campus? campus) 
        {
            campus = null;
            campus = (Campus)SavedCampusesComboBox.SelectedItem;
            if (campus == null)
            {
                MessageBox.Show("Campus wasnt selected! ");
                return false;
            }
            return true;
        }
        private void CloneCampusBtn_Click(object sender, EventArgs e)
        {
            bool gotCampus = TryGetCampusFromCheckBox(out Campus campus);
            if (!gotCampus)
            {
                return;
            }
            Campus clonedCampus = campus.Clone() as Campus;
            campuses.Add(clonedCampus);
            UpdateComboBox();
            MessageBox.Show("Success!");
        }

        private void SwitchRoomBtn_Click(object sender, EventArgs e)
        {
            bool gotCampus = TryGetCampusFromCheckBox(out Campus campus);
            if (!gotCampus)
            {
                return;
            }
            try
            {
                campus.MoveStudent(new IndicatorBook(KeyStudentTextBox.Text), int.Parse(RoomNumberTextBox.Text), int.Parse(NumberRoomToWhichTextBox.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("Success!");
        }

        private void RemoveStudentsBtn_Click(object sender, EventArgs e)
        {
            bool gotCampus = TryGetCampusFromCheckBox(out Campus campus);
            if (!gotCampus)
            {
                return;
            }
            try
            {
                campus.EvictionOfStudent(new IndicatorBook(KeyStudentTextBox.Text), int.Parse(RoomNumberTextBox.Text));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("Success!");
        }
        private void AddStudentBtn_Click(object sender, EventArgs e)
        {
            bool gotCampus = TryGetCampusFromCheckBox(out Campus campus);
            if (!gotCampus)
            {
                return;
            }
            try
            {
                Student student = new Student(GenerateName(), GenerateSurname(), "Unknown", "Computer logics", (Gender)random.Next(0, 2), "Unknown", new IndicatorBook(GenerateKeyForStudent()), (Curse)random.Next(1,5));
                campus.SettlementOfStudent(student, int.Parse(RoomNumberTextBox.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("Success!");
        }
        private string GenerateKeyForStudent()
        {
            string[] symbols = { "A", "G", "M", "G", "a", "b", "c", "d", "e", "f", "g", "h", "m", "x", "y" };
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < 8; i++)
            {
                stringBuilder.Append(symbols[random.Next(0, symbols.Length - 1)]);
            }
            return stringBuilder.ToString();
        }
    

        private void CalculateRevenueBtn_Click(object sender, EventArgs e)
        {
            bool gotCampus = TryGetCampusFromCheckBox(out Campus campus);
            if (!gotCampus)
            {
                return;
            }
            string type = RevenuePeriodComboBox.SelectedItem.ToString();
            bool isParsed = Enum.TryParse(typeof(PeriodType), type, out object parsedObject);
            if (!isParsed)
            {
                MessageBox.Show("correct type wasnt selected");
            }
            PeriodType periodType = (PeriodType)parsedObject;
            MessageBox.Show($"Total revenue: {campus.CalculateRevenue(periodType)}\n{periodType}");
        }

        private void ShowInfoBtn_Click(object sender, EventArgs e)
        {
            bool gotCampus = TryGetCampusFromCheckBox(out Campus campus);
            if (!gotCampus)
            {
                return;
            }
            Form info = new InfoForm(campus.GetFullInfo());
            info.Show();
        }


        private void RemoveCampusBtn_Click(object sender, EventArgs e)
        {
            bool gotCampus = TryGetCampusFromCheckBox(out Campus campus);
            if (!gotCampus)
            {
                return;
            }
            campuses.Remove(campus);
            UpdateComboBox();
            MessageBox.Show("Success!");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckOrCreateDataDirectory();
        }
        public static void CheckOrCreateDataDirectory()
        {
            bool exists = Directory.Exists(@"..\..\CampusData");
            if (!exists)
            {
                Directory.CreateDirectory(@"..\..\CampusData");
            }
        }

        private void SaveToTXTBtn_Click(object sender, EventArgs e)
        {
            bool gotCampus = TryGetCampusFromCheckBox(out Campus campus);
            if (!gotCampus)
            {
                return;
            }
            campus.SaveInfoDataTXT();
            campus.SaveInfoWorkersTXT();
            campus.SaveInfoStudentTXT();
            MessageBox.Show("Success!");
        }

        private void ReadTXTFile_Click(object sender, EventArgs e)
        {
            bool gotCampus = TryGetCampusFromCheckBox(out Campus campus);
            if (!gotCampus)
            {
                return;
            }
            string path = GetPathFromUser();
            if(path == "")
            {
                return;
            }
            Form form = new InfoForm(campus.ReadFileFromPath(path));
            form.Show();
            

        }
        public string GetPathFromUser()
        {
            string path = "";
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Open TXT file";
                ofd.Filter = "txt files(*.txt)|*.txt";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    path = ofd.FileName;
                }
            }
            return path;
        }
    }
}