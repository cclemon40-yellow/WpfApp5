using System.Windows;
using System.Windows.Media.Animation;

namespace WpfApp5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> students = new List<Student>();
        public MainWindow()
        {
            InitializeComponent();
            InitailizeData();
        }

        private void InitailizeData()
        {
            students.Add(new Student { StudentId = "01", StudentName = "Slayer" });
            students.Add(new Student { StudentId = "02", StudentName = "Nagoriyuki"});
            students.Add(new Student { StudentId = "03", StudentName = "Ky"});
            students.Add(new Student { StudentId = "04", StudentName = "SolBadguy"});
            cmbStudent.ItemsSource = students;
            cmbStudent.SelectedIndex = 0;
        }
    }
}