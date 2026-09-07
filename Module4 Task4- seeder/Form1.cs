namespace Module4_Task4__seeder
{
    public partial class Form1 : Form
    {
        private static List<Institution> institutions;
        private static List<Department> departments;
        private static List<Course> courses;
        public Form1()
        {
            InitializeComponent();
            institutions = Seeder.SeedInstitutions();
            departments = Seeder.SeedDepartments();
            courses= Seeder.SeedCourses();


            //CourseAssessmentMark cam = new CourseAssessmentMark(null, new List<int> { 10, 49, 50, 75, 100, 100 });
            //MessageBox.Show(string.Join(", ", cam.GetAllMarks()));
            //MessageBox.Show(string.Join(", ", cam.GetAllGrades()));
            //MessageBox.Show(string.Join(", ", cam.GetHighestMarks()));
            //MessageBox.Show(string.Join(", ", cam.GetLowestMarks()));
            //MessageBox.Show(string.Join(", ", cam.GetFailMarks()));
            //MessageBox.Show(cam.GetAverageMark().ToString());
            //MessageBox.Show(cam.GetAverageGrade());

            Institution institution1 = institutions[0];
            Institution institution2 = institutions[1];
            Department department1 = departments[0];
            Department department2 = departments[1];
            Course course1 = courses[0];
            Course course2 = courses[1];
   
            MessageBox.Show(institution1.DisplayInfo().ToString());
            MessageBox.Show(institution2.DisplayInfo().ToString());
            MessageBox.Show(department1.DisplayInfo().ToString());
            MessageBox.Show(department2.DisplayInfo().ToString());
            MessageBox.Show(course1.DisplayInfo().ToString());
            MessageBox.Show(course2.DisplayInfo().ToString());
        }
    }
}
