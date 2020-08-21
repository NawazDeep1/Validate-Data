namespace ValidationApp
{
    using System;
    using System.Windows.Forms;
    using ValidationApp.Validation;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonValidate_Click(object sender, EventArgs e)
        {
            //Data validation
            //Check Student ID (7 digits)
            //int tempId = 0;

            //if ((textBoxStudentId.TextLength) != 7 || (!int.TryParse(textBoxStudentId.Text, out tempId)))
            //{
            //    MessageBox.Show("Student ID must be 7-digit number", "Invalid Student ID");
            //    textBoxStudentId.Clear();
            //    textBoxStudentId.Focus();
            //    return;
            //}

            Validator.IsValidId(textBoxStudentId.Text, 7);
            if (!Validator.IsValidId(textBoxStudentId.Text, 7))
            {
                MessageBox.Show("Student ID must be 7-digit number", "Invalid Student ID");
                textBoxStudentId.Clear();
                textBoxStudentId.Focus();
                return;
            }
            //Check First Name
            if (!Validator.isPresent(textBoxFirstName))
            {
                MessageBox.Show("First Name is required", "Missing Data");
                textBoxFirstName.Clear();
                textBoxFirstName.Focus();
                return;
            }

            if (!Validator.IsValidName(textBoxFirstName))
            {
                MessageBox.Show("Invalid First Name", "Invalid First Name");
                textBoxFirstName.Clear();
                textBoxFirstName.Focus();
                return;
            }
            if (!Validator.isPresent(textBoxLastName))
            {
                MessageBox.Show("Last Name is required", "Missing Data");
                textBoxLastName.Clear();
                textBoxLastName.Focus();
                return;
            }

            if (!Validator.IsValidName(textBoxLastName))
            {
                MessageBox.Show("Invalid Last Name", "Invalid Last Name");
                textBoxLastName.Clear();
                textBoxLastName.Focus();
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxStudentId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
