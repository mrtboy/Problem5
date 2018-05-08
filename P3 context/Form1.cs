using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P3_context
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtWidth.Hide();
            txtHeight.Hide();
            lblHeight.Hide();
            lblWigth.Hide();
            btnSubmit.Hide();

        }
        List<TextBox> textBoxes = new List<TextBox>();
        static string newCoordination;
        private void btnClickMe_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            //Random Color for Backgraound
            int r = random.Next(0,255);
            int g = random.Next(0, 255);
            int b = random.Next(0, 255);
            this.BackColor = Color.FromArgb(r,g,b);

            //Change the Form position
            int left = random.Next(0,500);
            int top = random.Next(0,500);
            StartPosition = FormStartPosition.Manual;
            Left = left;
            Top = top;


            //Show the new position coordination into textbox
            newCoordination = "Y = "+left.ToString() + " X = "+ top.ToString();
            txtText.Text = newCoordination;
            foreach (TextBox txt in textBoxes)
                txt.Text = newCoordination;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            ContextMenu cm = new ContextMenu();
            cm.MenuItems.Add("Change Size");
            cm.MenuItems.Add("Change Color");

            btnClickMe.ContextMenu = cm;
        }

        private void changeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.ShowDialog();
            this.btnClickMe.BackColor=dlg.Color;
        }

        private void changeSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            txtWidth.Show();
            txtHeight.Show();
            lblHeight.Show();
            lblWigth.Show();
            btnSubmit.Show();

        }
        
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(txtHeight.Text != "" && txtWidth.Text != "")
            {
                int width = 30;
                int height = 30;
                height = int.Parse(txtHeight.Text);
                width = int.Parse(txtWidth.Text);
                btnClickMe.Width = width;
                btnClickMe.Height = height;
            }
            
            txtWidth.Hide();
            txtHeight.Hide();
            lblHeight.Hide();
            lblWigth.Hide();
            btnSubmit.Hide(); 
        }

        
        static int counter = 1;
        private void dupilicateFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form newForm = new Form();
            Form1 master = new Form1();
            
            newForm = master;
            
            master.Text = "Form No. " + counter;
            counter++;
            master.Show();
            
        }

        int B = 1;
        private void buttonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button newButton = new Button();
            newButton.Text = btnClickMe.Text;
            newButton.ContextMenuStrip = btnClickMe.ContextMenuStrip;
            newButton.Click += btnClickMe_Click;
            newButton.BackColor = btnClickMe.BackColor;
            newButton.Left = 100;
            newButton.Top = B * 28;
            Controls.Add(newButton);

            
            B++;
        }

        
        int A = 1;
        private void textboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox textBox = new TextBox();
            textBox.Text = newCoordination;
            
            textBox.Top = A * 28;
            this.Controls.Add(textBox);
            textBoxes.Add(textBox);
            A++;
            
        }

        private void btnClickMe_MouseHover(object sender, EventArgs e)
        {
            textboxToolStripMenuItem_Click(sender,e);
        }

        private void btnMyButton_Click(object sender, EventArgs e)
        {
            myClickHandler();
        }

        void myClickHandler()
        {
            MessageBox.Show("This is My click Event Hadler.");
        }
    }
}
