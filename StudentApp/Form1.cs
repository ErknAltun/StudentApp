using StudentApp.Models;
using System.Data.SQLite;
namespace StudentApp

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public readonly string connectionString =
            "Data Source=students.db;Version=3;";
        private readonly List<Student> students = new();

        private void RefreshGrid()
        {
            dgvStudents.DataSource = null;
            dgvStudents.DataSource = students;
        }

        private void Add(Student student)
        {
   
            using SQLiteConnection conn = new(connectionString);
            conn.Open();

            const string query = """
                INSERT INTO Students (Name, Age, Grade)
                VALUES (@name, @age, @grade);
                """;

            using SQLiteCommand command = new(query, conn);

            command.Parameters.AddWithValue("@name", student.Name);
            command.Parameters.AddWithValue("@age", student.Age);
            command.Parameters.AddWithValue("@grade", student.Grade);

            command.ExecuteNonQuery();
            conn.Close();
  
        }

        private void ClearÝnputs()
        {
            txtName.Clear();
            txtAge.Clear();
            txtGrade.Clear();
            txtName.Focus();
        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            Student? selectedStudent = dgvStudents.CurrentRow?.DataBoundItem as Student;
            if (selectedStudent == null)
            {
                MessageBox.Show("Lütfen Bir Öðrenci Seçiniz!");
                return;
            }

            txtName.Text = selectedStudent.Name;
            txtAge.Text = Convert.ToString(selectedStudent.Age);
            txtGrade.Text = Convert.ToString(selectedStudent.Grade);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();

            List<Student> filteredStudents = students
                .Where(student =>
                    student.Name.Contains(
                        searchText,
                        StringComparison.OrdinalIgnoreCase))
                .ToList();

            dgvStudents.DataSource = null;
            if (filteredStudents.Count > 0) { dgvStudents.DataSource = filteredStudents; }

            else if (filteredStudents.Count == 0) { dgvStudents.DataSource = students; }
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            {
                
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("Lütfen Bir Ýsim Giriniz!");
                    return;
                }

                if (!int.TryParse(txtAge.Text, out int age) || age < 1 || age > 100)
                {
                    MessageBox.Show("Lütfen Geçerli Bir Yaþ Giriniz!");
                    return;
                }

                if (!double.TryParse(txtGrade.Text, out double grade) || grade < 0 || grade > 100)
                {
                    MessageBox.Show("Lütfen Geçerli Bir Not Giriniz!");
                    return;
                }


                student.Name = txtName.Text;
                student.Age = int.Parse(txtAge.Text);
                student.Grade = double.Parse(txtGrade.Text);
            }
            Add(student);
            RefreshGrid();
            ClearÝnputs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Student? selectedStudent = dgvStudents.CurrentRow?.DataBoundItem as Student;
            if (selectedStudent == null)
            {
                MessageBox.Show("Lütfen Bir Öðrenci Seçiniz!");
                return;
            }

            DialogResult result = MessageBox.Show("Seçili Öðrenci Silinsin Mi?", "Silme Onayý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                students.Remove(selectedStudent);
                RefreshGrid();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Student? selectedStudent = dgvStudents.CurrentRow?.DataBoundItem as Student;
            if (selectedStudent == null)
            {
                MessageBox.Show("Lütfen Bir Öðrenci Seçiniz!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Lütfen Bir Ýsim Giriniz!");
                return;
            }

            if (!int.TryParse(txtAge.Text, out int age) || age < 1 || age > 100)
            {
                MessageBox.Show("Lütfen Geçerli Bir Yaþ Giriniz!");
                return;
            }

            if (!double.TryParse(txtGrade.Text, out double grade) || grade < 0 || grade > 100)
            {
                MessageBox.Show("Lütfen Geçerli Bir Not Giriniz!");
                return;
            }

            selectedStudent.Name = txtName.Text;
            selectedStudent.Age = int.Parse(txtAge.Text);
            selectedStudent.Grade = double.Parse(txtGrade.Text);
            RefreshGrid();
            ClearÝnputs();
        }
    }
}
