using System;
using System.Windows.Forms;

namespace WindowsFormsControls
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }

    public class Form1 : Form
    {
        private readonly TextBox txtName = new();
        private readonly RadioButton radioMale = new();
        private readonly RadioButton radioFemale = new();
        private readonly CheckBox checkReading = new();
        private readonly CheckBox checkSports = new();
        private readonly Button btnSubmit = new();

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Text = "Windows Forms Controls";
            ClientSize = new System.Drawing.Size(320, 250);
            StartPosition = FormStartPosition.CenterScreen;

            var nameLabel = new Label { Text = "Name", AutoSize = true, Location = new System.Drawing.Point(20, 20) };
            txtName.Location = new System.Drawing.Point(100, 16);
            txtName.Width = 180;

            var genderLabel = new Label { Text = "Gender", AutoSize = true, Location = new System.Drawing.Point(20, 60) };
            radioMale.Text = "Male";
            radioMale.AutoSize = true;
            radioMale.Location = new System.Drawing.Point(100, 56);
            radioFemale.Text = "Female";
            radioFemale.AutoSize = true;
            radioFemale.Location = new System.Drawing.Point(170, 56);

            var hobbyLabel = new Label { Text = "Hobbies", AutoSize = true, Location = new System.Drawing.Point(20, 100) };
            checkReading.Text = "Reading";
            checkReading.AutoSize = true;
            checkReading.Location = new System.Drawing.Point(100, 96);
            checkSports.Text = "Sports";
            checkSports.AutoSize = true;
            checkSports.Location = new System.Drawing.Point(180, 96);

            btnSubmit.Text = "Submit";
            btnSubmit.AutoSize = true;
            btnSubmit.Location = new System.Drawing.Point(100, 145);
            btnSubmit.Click += btnSubmit_Click;

            Controls.AddRange(new Control[]
            {
                nameLabel, txtName, genderLabel, radioMale, radioFemale,
                hobbyLabel, checkReading, checkSports, btnSubmit
            });
        }

        private void btnSubmit_Click(object? sender, EventArgs e)
        {
            string name = txtName.Text;
            string gender = "";

            if (radioMale.Checked)
                gender = "Male";
            else if (radioFemale.Checked)
                gender = "Female";

            string hobby = "";

            if (checkReading.Checked)
                hobby += "Reading ";

            if (checkSports.Checked)
                hobby += "Sports";

            MessageBox.Show("Name: " + name +
                            "\nGender: " + gender +
                            "\nHobbies: " + hobby);
        }
    }
}
