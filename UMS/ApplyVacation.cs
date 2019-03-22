using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
using Repository;

namespace UMS
{
    public partial class ApplyVacation : Form
    {
        private string uId;
        public ApplyVacation(string userId)
        {
            InitializeComponent();
            uId = userId;

            AccountRepository ar = new AccountRepository();
            Account ac = ar.GetAccount(userId);

            this.labelName.Text = "Welcome " + ac.Name;
        }





        private void CloseClicked(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FacultyHome fh = new FacultyHome(uId);
            fh.Show();
            this.Hide();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void buttonApplyVacation_Click(object sender, EventArgs e)
        {
            string days = "" + numericUpDownDays.Value + "";
            TeacherRepository tr = new TeacherRepository();

            if (tr.UpdateStatusNadim(uId, days))
            {
                MessageBox.Show("Vacation applied for " + days + " days");
            }
            else 
            {
                MessageBox.Show("OPPS!!! Something went wrong");
            }
        }
    }
}
