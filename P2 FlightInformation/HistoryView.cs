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
    public partial class HistoryView : Form
    {
        public HistoryView()
        {
            InitializeComponent();
        }

      
        public void Updating()
        {
            
            listBoxHistory.Items.Clear();
            Refresh();
            foreach (Flight f in Flight.flights)
                listBoxHistory.Items.Add(f.ToString());
        }
        public void Editing()
        {
            listBoxHistory.BackColor = Color.Aqua;
            Refresh();
        }
      
    }
}
