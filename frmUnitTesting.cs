using System.Diagnostics;

namespace Unit_Testing
{
    public partial class frmUnitTesting : Form
    {


        public frmUnitTesting()
        {
            InitializeComponent();
        }

        // Method checks whether or not the strings are matching
        private bool IsMatching(string text1, string text2)
        {
            if (text1 == text2) //if they match return true, if not return false
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Method that checks if the user is an adult
        private bool IsAdult(int value)
        {
            if (value >= 18) //if 18 or older, return true, if not return false
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btn_AgeConfirm_Click(object sender, EventArgs e)
        {
            int age = (int)num_AgeValue.Value; //grab the value from the numUpDown

            Debug.Assert(IsAdult(age) == true, "Expected: Age should be 18 or older.");

            if (IsAdult(age))
            {
                lbl_IsAdult.Text = "You're an adult. Please continue.";
            }
            else
            {
                lbl_IsAdult.Text = "Adults only!!!";
            }
        }

        private void btn_PasswordConfirm_Click(object sender, EventArgs e)
        {
            string newPassword = tb_NewPassword.Text;
            string confirmPassword = tb_ConfirmPassword.Text;

            Debug.Assert(IsMatching(newPassword, confirmPassword) == true, "Expected: newPassword and confirmPassword should be matching.");

            if (IsMatching(newPassword, confirmPassword))
            {
                lbl_PasswordConfirmed.Text = "Password correct.";
                lbl_PasswordConfirmed.ForeColor = Color.Green;
            }
            else
            {
                lbl_PasswordConfirmed.Text = "Password incorrect.";
                lbl_PasswordConfirmed.ForeColor = Color.Red;
            }
        }
    }
}