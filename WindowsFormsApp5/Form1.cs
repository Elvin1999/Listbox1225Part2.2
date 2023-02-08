using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<Student> students = new List<Student>
            {
                new Student
                {
                    Name="Murad",
                    Age=16
                },
                new Student
                {
                    Name="Amin",
                    Age=19
                },
                new Student
                {
                    Name="Sevil",
                    Age=22
                },
                new Student
                {
                    Name="Shireli",
                    Age=19
                }
            };

            studentListBox.DisplayMember = nameof(Student.Name);
            studentListBox.Items.AddRange(students.ToArray());
        }

        private void studentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var student=studentListBox.SelectedItem as Student;
            label1.Text = student.ToString();
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                                                              Color.FromArgb(0,79,249),
                                                              Color.FromArgb(255, 249, 76),
                                                              45F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void studentListBox_DoubleClick(object sender, EventArgs e)
        {
            try
            {

            var student = studentListBox.SelectedItem as Student;
            listBox1.Items.Add(student);
            studentListBox.Items.Remove(student);
            }
            catch (Exception)
            {
            }
        }
    }
}
