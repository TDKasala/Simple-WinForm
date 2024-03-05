namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string? gender = cboGender.SelectedItem?.ToString();
            string dob = dateTimePicker1.Value.ToShortDateString();
            string race = "";
            if (rbWhite.Checked)
                race = "White";
            else if (rbBlack.Checked)
                race = "Black";
            else if (rbIndian.Checked)
                race = "Indian";

            string hobbies = "";
            if (chkTv.Checked)
                hobbies += "Tv, ";
            if (chkBooks.Checked)
                hobbies += "Books, ";
            if (chkSport.Checked)
                hobbies += "Sport, ";
            if (chkWork.Checked)
                hobbies += "Work";

            MessageBox.Show($"Your name is {name}\n" +
                            $"Your surname is {surname}\n" +
                            $"Your gender is {gender}\n" +
                            $"Date of Birth is {dob}\n" +
                            $"Your race is {race}\n" +
                            $"Your hobbies are {hobbies}");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            txtName.Clear();
            txtSurname.Clear();
            cboGender.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
            rbWhite.Checked = false;
            rbBlack.Checked = false;
            rbIndian.Checked = false;
            chkTv.Checked = false;
            chkBooks.Checked = false;
            chkSport.Checked = false;
            chkWork.Checked = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnValidate_Click(object sender, EventArgs e)
        {

            {
                if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtSurname.Text) ||
                    cboGender.SelectedIndex == -1 || (!rbWhite.Checked && !rbBlack.Checked && !rbIndian.Checked))
                {
                    MessageBox.Show("Error: Some values are missing!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Success: All inputs are entered!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void chkBooks_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
