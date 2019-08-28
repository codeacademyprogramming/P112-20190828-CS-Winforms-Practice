using StudentProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentProject
{
    public partial class StudentCreate : Form
    {

        List<StudentGroup> studentGroups = new List<StudentGroup>();

        public StudentCreate()
        {
            InitializeComponent();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.Firstname = txtName.Text;
            s.Lastname = txtSurname.Text;
          
            StudentGroup group = studentGroups[cbxGroup.SelectedIndex];

            s.StudentGroup = group;

            dgvStudents.Rows.Add(s.Firstname, s.Lastname, s.StudentGroup.Name, s.StudentGroup.Teacher);
        }

        private void StudentCreate_Load(object sender, EventArgs e)
        {
            StudentGroup sg = new StudentGroup
            {
                Name = "P112",
                Capacity = 16,
                Teacher = "A"
            };
            StudentGroup sg2 = new StudentGroup
            {
                Name = "P113",
                Capacity = 13,
                Teacher = "B"
            };
            StudentGroup sg3 = new StudentGroup
            {
                Name = "P114",
                Capacity = 14,
                Teacher = "C"
            };
            studentGroups.Add(sg);
            studentGroups.Add(sg2);
            studentGroups.Add(sg3);


            foreach (StudentGroup item in studentGroups)
            {
                cbxGroup.Items.Add(item.Name);
            }
        }
    }
}
