using StudentProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentProject
{
    public partial class frmStudent : Form
    {

        List<Student> students = new List<Student>();
        public frmStudent()
        {
            InitializeComponent();
        }

        private void BtnSaveStudent_Click(object sender, EventArgs e)
        {
            string name = txtFirstname.Text.Trim();
            string lastname = txtLastname.Text.Trim();
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(lastname))
            {
                Student telebe = new Student();
                telebe.Firstname = name;
                telebe.Lastname = lastname;

                txtFirstname.Text = "";
                txtLastname.Text = "";

                lbxStudents.Items.Add(telebe.GetFullname());
            } else
            {
                MessageBox.Show("Ad ve soyad daxil edin");
            }

        }

        private void FrmStudent_Load(object sender, EventArgs e)
        {
            Student st1 = new Student
            {
                Firstname = "Kamil",
                Lastname = "Hesenov",
                Email    = "kamil@code.edu.az"
            };
            students.Add(st1);

            Student st2 = new Student
            {
                Firstname = "Fuad",
                Lastname = "Tagiyev",
                Email = "fuad@code.edu.az"
            };
            students.Add(st2);

            Student st3 = new Student
            {
                Firstname = "Ismayil",
                Lastname = "Huseynov",
                Email = "ismayil@code.edu.az"
            };
            students.Add(st3);


            foreach (Student s in students)
            {
                lbxStudents.Items.Add(s.GetFullname());
            }

        }

        private void LbxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            int secilmishElement = lbxStudents.SelectedIndex;

            lblSelectedIndex.Text = students[secilmishElement].Email;
        }
    }
}
