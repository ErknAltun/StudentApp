using StudentApp.Models;
namespace StudentApp

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private readonly List<Student> students = new();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            {
                student.Id = students.Count + 1;
                student.Name = txtName.Text;
                student.Age = int.Parse(txtAge.Text);
                student.Grade = double.Parse(txtGrade.Text);
            }
            students.Add(student);
        }
    }
}
