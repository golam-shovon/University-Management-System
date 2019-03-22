using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repository;
using ClassLibrary;

namespace UMS
{
    public partial class ShowProfile : Form
    {
        private string uId;
        public ShowProfile(string userId)
        {
            InitializeComponent();

            uId = userId;
            AccountRepository ar = new AccountRepository();
            Account ac = ar.GetAccount(uId);

            textBoxId.Text = ac.AccountId;
            textBoxName.Text = ac.Name;
            textBoxGender.Text = ac.Gender;
            textBoxAddress.Text = ac.Address;
            textBoxAccountType.Text = ac.AccountType;
            textBoxDOB.Text = ac.DOB;
            textBoxBloodGroup.Text = ac.BloodGroup;

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (textBoxAccountType.Text == "Student") 
            {
                StudentHome sh = new StudentHome(textBoxId.Text, textBoxName.Text);
                sh.Show();
                this.Hide();
            }
            else if (textBoxAccountType.Text == "Faculty") 
            {
                FacultyHome fh = new FacultyHome(textBoxId.Text);
                fh.Show();
                this.Hide();
            }
        }

        private void CloseClicked(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void labelId_Click(object sender, EventArgs e)
        {

        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void labelGender_Click(object sender, EventArgs e)
        {

        }

        private void labelAddress_Click(object sender, EventArgs e)
        {

        }

        private void labelAccountType_Click(object sender, EventArgs e)
        {

        }

        private void labelDOB_Click(object sender, EventArgs e)
        {

        }

        private void labelBloodGroup_Click(object sender, EventArgs e)
        {

        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxGender_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAccountType_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDOB_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxBloodGroup_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
