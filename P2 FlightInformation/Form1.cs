using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2_FlightInformation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public HistoryView historyView;
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(txtId.Text != "" && txtDate.Text != "" && txtDestination.Text != "")
            {
                Flight flight = new Flight(int.Parse(txtId.Text), txtOrigin.Text, txtDestination.Text,
                DateTime.Parse(txtDate.Text), DateTime.Parse(txtTime.Text));

                historyView = new HistoryView();
                historyView.Updating();

            }
            
            
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
        private void Reset()
        {
            txtId.Text = "";
            txtOrigin.Text = "";
            txtDestination.Text = "";
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            HistoryView historyView = new HistoryView();
            if ((Application.OpenForms["DataTable"] as HistoryView) == null)
            {
                historyView.Show();
            }
            historyView.Updating();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
