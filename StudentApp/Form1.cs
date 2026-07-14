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

        private void RefreshGrid()
        {
            dgvStudents.DataSource = null;
            dgvStudents.DataSource = students;
        }

        private void ClearÝnputs()
        {
            txtName.Clear();
            txtAge.Clear();
            txtGrade.Clear();
            txtName.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            {
                student.Id = students.Count + 1;
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("Lütfen Bir Ýsim Giriniz!");
                    return;
                }

                if(!int.TryParse(txtAge.Text, out int age) || age<1 || age>100)
                {
                    MessageBox.Show("Lütfen Geçerli Bir Yaþ Giriniz!");
                    return;
                }

                if(!double.TryParse(txtGrade.Text, out double grade) || grade<0 || grade>100)
                {
                    MessageBox.Show("Lütfen Geçerli Bir Not Giriniz!");
                    return;
                }


                student.Name = txtName.Text;
                student.Age = int.Parse(txtAge.Text);
                student.Grade = double.Parse(txtGrade.Text);
            }
            students.Add(student);
            RefreshGrid();
            ClearÝnputs();
        }
    }
}
