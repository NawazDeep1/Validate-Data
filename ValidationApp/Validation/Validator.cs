namespace ValidationApp.Validation
{
    using System.Windows.Forms; // required for MessageBox.Show();

    public static class Validator
    {
        public static void IsValidId(TextBox txtInput, int size)
        {
            int tempId = 0;

            if ((txtInput.TextLength) != size || (!int.TryParse(txtInput.Text, out tempId)))
            {
                MessageBox.Show("Student ID must be 7-digit number", "Invalid Student ID");
                txtInput.Clear();
                txtInput.Focus();

            }
        }

        public static bool IsValidId(string input, int size)
        {
            int tempId = 0;

            if ((input.Length) != size || (!int.TryParse(input, out tempId)))
            {
                return false;

            }

            return true;
        }

        public static bool isPresent(TextBox txtInput)
        {
            if (txtInput.Text == "")
            {

                return false;
            }
            else
            {

                return true;
            }
        }

        public static bool IsValidName(TextBox txtInput)
        {
            bool valid = true;
            for (int i = 0; i < txtInput.TextLength; i++)
            {
                if ((char.IsDigit(txtInput.Text, i) && (!char.IsWhiteSpace(txtInput.Text, i))))
                {
                    valid = false;
                    break;
                }


            }

            return valid;
        }
    }
}
