using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KairosApp
{
    public partial class calendarForm : Form
    {
        public calendarForm()
        {
            InitializeComponent();
        }

        public string returnText { get; set; }
        public string sermonTitle { get; set; }

        public string sermonDate { get; set; }
        private void label3_Click(object sender, EventArgs e)
        {
            this.returnText = System.IO.File.ReadAllText("../../alphaAndOmegaSermon.txt");
            this.sermonTitle = "Alpha and Omega";
            this.Close();
            //return text;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

            DateTime selection = monthCalendar1.SelectionEnd;
            string text;

           if (selection.Day == 5)
           {
               text = System.IO.File.ReadAllText("../../whatIsLoveSermon.txt");
               this.returnText = text;
               this.sermonTitle = "What is Love?";
               this.sermonDate = "4/5/2015";

               this.Close();
               //return text;
        
           }
           else if (selection.Day == 12)
           {
               text = System.IO.File.ReadAllText("../../christHasRisenSermon.txt");
               this.returnText = text;
               this.sermonTitle = "Christ has Risen";
               this.sermonDate = "4/12/2015";
               this.Close();
               //return text;
           }

            else if (selection.Day == 19)
           {
               text = System.IO.File.ReadAllText("../../alphaAndOmegaSermon.txt");
               this.returnText = text;
               this.sermonTitle = "Alpha and Omega";
               this.sermonDate = "4/19/2015";
               this.Close();
               
               //return text;
           }

           else
           {
               MessageBox.Show("Invalid date selected");
               //text = "";
               //this.returnText = text;
               //this.Close();
           }
            
           //return null;
            
        }

        private void sermonLabel_Click(object sender, EventArgs e)
        {

        }

        private void whatIsLoveLabel_Click(object sender, EventArgs e)
        {
            this.returnText =System.IO.File.ReadAllText("../../whatIsLoveSermon.txt");
            this.sermonTitle = "What is Love?";

            this.Close();
            //return text;
        }

        private void christHasRisenLabel_Click(object sender, EventArgs e)
        {
            this.returnText= System.IO.File.ReadAllText("../../christHasRisenSermon.txt");
            this.sermonTitle = "Christ has Risen";
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void christHasRisenLabel_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                this.returnText = System.IO.File.ReadAllText("../../whatIsLoveSermon.txt");
                this.sermonTitle = "What is Love?";
                this.sermonDate = "4/5/2015";

                this.Close();
                //return text;

            }
            else if (listBox1.SelectedIndex == 1)
            {
                this.returnText = System.IO.File.ReadAllText("../../christHasRisenSermon.txt");
                
                this.sermonTitle = "Christ has Risen";
                this.sermonDate = "4/12/2015";
                this.Close();
                //return text;
            }

            else if (listBox1.SelectedIndex == 2)
            {
                this.returnText = System.IO.File.ReadAllText("../../alphaAndOmegaSermon.txt");
                this.sermonTitle = "Alpha and Omega";
                this.sermonDate = "4/19/2015";
                this.Close();

                //return text;
            }

        }

        private void calendarForm_Load(object sender, EventArgs e)
        {

        }


    }
}
