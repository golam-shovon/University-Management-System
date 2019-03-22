using ClassLibrary;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UMS
{
    public partial class ShowProfileStudent : Form
    {
        private string uId;
        public ShowProfileStudent(string userId,string stId)
        {
            InitializeComponent();

            uId = userId;
            AccountRepository ar = new AccountRepository();
            Account ac = ar.GetAccount(stId);

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
            ShowCourseStudent sc = new ShowCourseStudent(uId);
            sc.Show();
            this.Hide();
        }

    }
}
