using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationAndLogin
{
    public partial class Home : Form
    {
        int adult, child;
        double ticketcost;
        bool single;
        bool first;
        public Home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void IssueTicketButton_Click(object sender, EventArgs e)
        {
            try
            {
                adult = Convert.ToInt16(textBoxAdult.Text);
                child = Convert.ToInt16(textBoxChildren.Text);
                first = buttonFirst.Checked;
                if (first == false)
                {
                    ticketcost = adult * 20;
                    ticketcost = ticketcost + child * 5;
                }
                else
                {
                    ticketcost = adult * 30;
                    ticketcost = ticketcost + child * 7;
                }
                single = buttonSingle.Checked; ;
                if (single == false)
                {
                    ticketcost = ticketcost * 2;
                }
                textTicket.Text = Convert.ToString(ticketcost);
            }
            catch
            {
                MessageBox.Show("Incorect entry");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Info info = new Info();
            info.ShowDialog(); 
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
