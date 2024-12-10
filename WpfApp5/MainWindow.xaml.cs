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
        List<Teacher> teachers = new List<Teacher>();
        List<Course> courses = new List<Course>();
        List<Record> records = new List<Record>();
        public MainWindow()
        {
            InitializeComponent();
            InitailizeData();
        }

        private void InitailizeData()
        {
            //新增學生資料，連結至cmbStudent
            students.Add(new Student { StudentId = "01", StudentName = "May" });
            students.Add(new Student { StudentId = "02", StudentName = "Nagoriyuki"});
            students.Add(new Student { StudentId = "03", StudentName = "Sin"});
            students.Add(new Student { StudentId = "04", StudentName = "SolBadguy"});
            cmbStudent.ItemsSource = students;
            cmbStudent.SelectedIndex = 0;

            //新增老師資料以及所授課程
            Teacher teacher1 = new Teacher("KY");
            teacher1.TeachingCourses.Add(new Course { CourseName = "歷史", OpeningClass="一年甲班", Type="必修", Point = 3, Tutor = teacher1 });
            teacher1.TeachingCourses.Add(new Course { CourseName = "倫理學", OpeningClass = "二年甲班", Type = "選修", Point = 3, Tutor = teacher1 });
            teacher1.TeachingCourses.Add(new Course { CourseName = "哲學", OpeningClass = "三年甲班", Type = "選修", Point = 3, Tutor = teacher1 });
            teachers.Add(teacher1);

            Teacher teacher2 = new Teacher("Faust");
            teacher2.TeachingCourses.Add(new Course { CourseName = "解剖學", OpeningClass = "三年丙班", Type = "選修", Point = 3, Tutor = teacher2 });
            teacher2.TeachingCourses.Add(new Course { CourseName = "生物學", OpeningClass = "三年甲班", Type = "必修", Point = 3, Tutor = teacher2 });
            teacher2.TeachingCourses.Add(new Course { CourseName = "化學", OpeningClass = "三年乙班", Type = "必修", Point = 3, Tutor = teacher2 });
            teachers.Add(teacher2);

            Teacher teacher3 = new Teacher("Slayer");
            teacher3.TeachingCourses.Add(new Course { CourseName = "美食學", OpeningClass = "二年丙班", Type = "選修", Point = 3, Tutor = teacher3 });
            teacher3.TeachingCourses.Add(new Course { CourseName = "烹飪學", OpeningClass = "二年丁班", Type = "必修", Point = 3, Tutor = teacher3 });
            teacher3.TeachingCourses.Add(new Course { CourseName = "烘焙學", OpeningClass = "二年乙班", Type = "必修", Point = 3, Tutor = teacher3 });
            teachers.Add(teacher3);

            tvTeacher.ItemsSource = teachers;
        }
    }
}