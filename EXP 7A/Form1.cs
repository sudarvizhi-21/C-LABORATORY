using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowValidation
{
    public partial class Form1 : Form
    {
        TextBox txtName;
        TextBox txtAge;
        TextBox txtEmail;
        TextBox txtMobile;

        Button btnValidate;
        Button btnClear;

        public Form1()
        {
            InitializeComponent();

            this.Text = "Window Validation";
            this.Size = new Size(500, 400);
            this.StartPosition = FormStartPosition.CenterScreen;

            CreateControls();
        }

        private void CreateControls()
        {
            Label lblName = new Label();
            lblName.Text = "Name";
            lblName.Location = new Point(50, 50);
            lblName.AutoSize = true;

            txtName = new TextBox();
            txtName.Location = new Point(170, 45);
            txtName.Width = 250;

            Label lblAge = new Label();
            lblAge.Text = "Age";
            lblAge.Location = new Point(50, 100);
            lblAge.AutoSize = true;

            txtAge = new TextBox();
            txtAge.Location = new Point(170, 95);
            txtAge.Width = 250;

            Label lblEmail = new Label();
            lblEmail.Text = "Email";
            lblEmail.Location = new Point(50, 150);
            lblEmail.AutoSize = true;

            txtEmail = new TextBox();
            txtEmail.Location = new Point(170, 145);
            txtEmail.Width = 250;

            Label lblMobile = new Label();
            lblMobile.Text = "Mobile Number";
            lblMobile.Location = new Point(50, 200);
            lblMobile.AutoSize = true;

            txtMobile = new TextBox();
            txtMobile.Location = new Point(170, 195);
            txtMobile.Width = 250;

            btnValidate = new Button();
            btnValidate.Text = "Validate";
            btnValidate.Location = new Point(170, 250);
            btnValidate.Click += Validate_Click;

            btnClear = new Button();
            btnClear.Text = "Clear";
            btnClear.Location = new Point(280, 250);
            btnClear.Click += Clear_Click;

            this.Controls.Add(lblName);
            this.Controls.Add(txtName);

            this.Controls.Add(lblAge);
            this.Controls.Add(txtAge);

            this.Controls.Add(lblEmail);
            this.Controls.Add(txtEmail);

            this.Controls.Add(lblMobile);
            this.Controls.Add(txtMobile);

            this.Controls.Add(btnValidate);
            this.Controls.Add(btnClear);
        }

        private void Validate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter your name.");
                txtName.Focus();
                return;
            }

            int age;

            if (!int.TryParse(txtAge.Text, out age) || age < 1 || age > 100)
            {
                MessageBox.Show("Please enter a valid age.");
                txtAge.Focus();
                return;
            }

            if (!Regex.IsMatch(
                txtEmail.Text,
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Please enter a valid email address.");
                txtEmail.Focus();
                return;
            }

            if (!Regex.IsMatch(txtMobile.Text, @"^[0-9]{10}$"))
            {
                MessageBox.Show("Mobile number must contain 10 digits.");
                txtMobile.Focus();
                return;
            }

            MessageBox.Show("Validation Successful!");
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtAge.Clear();
            txtEmail.Clear();
            txtMobile.Clear();

            txtName.Focus();
        }
    }
}