using ApiStudent;
using System;
using System.Formats.Asn1;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Windows.Forms;
namespace Laby2API
{
    public partial class FormStudent : Form
    {

        private HttpClient client;
        private University university;
        public FormStudent()
        {
            InitializeComponent();
            client = new HttpClient();
            university = new University();
        }

        private async void buttonDownload_ClickAsync(object sender, EventArgs e)
        {
            /*string call = "http://radoslaw.idzikowski.staff.iiar.pwr.wroc.pl/instruction/students.json";

            string response = await client.GetStringAsync(call);
            textBoxResponse.Text = response;*/
            /*university.students.RemoveRange(university.students);*/
            /*university.addStudent("asddsa", 12, "asds");*/
            List<StudentDb> st = university.searchStudentWhereAverageIsHigerThen(0);
            foreach (var student in st)
            {
                textBoxResponse.Text += student.Name;
            }

        }

        private void textBoxResponseMethod(object sender, EventArgs e)
        {
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void runApi_Click(object sender, EventArgs e)
        {
        }

        private void textBoxResponse_TextChanged(object sender, EventArgs e)
        {

        }


        /*string call = "http://radoslaw.idzikowski.staff.iiar.pwr.wroc.pl/instruction/students.json";
        string response = await client.GetStringAsync(call);
        List<Student> students = JsonSerializer.Deserialize<List<Student>>(response);
        foreach (var student in students) listBox1.Items.Add(student.ToString());
        */
    }
}
