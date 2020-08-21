using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidateData.Validation;
using System.Windows.Forms;

namespace ValidateData.Validation
{
    public static class Validate
    {
        public static void IsValidId(TextBox txtInput, int size)
        {
            int tempId = 0;
            if((txtInput.TextLength) !=size ||(!int.TryParse(txtInput.Text, out tempId)))
            {
                MessageBox.Show("ID must contain 7 digit number", "Invalid");
                txtInput.Clear();
                txtInput.Focus();
            }
        }

    }
}
