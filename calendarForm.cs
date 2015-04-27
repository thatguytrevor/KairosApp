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

        private void label3_Click(object sender, EventArgs e)
        {

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

               this.Close();
               //return text;
        
           }
           else if (selection.Day == 12)
           {
               text = System.IO.File.ReadAllText("../../christHasRisenSermon.txt");
               this.returnText = text;
               this.sermonTitle = "Christ has Risen";
               this.Close();
               //return text;
           }

            else if (selection.Day == 19)
           {
               text = System.IO.File.ReadAllText("../../alphaAndOmegaSermon.txt");
               this.returnText = text;
               this.sermonTitle = "Alpha and Omega";
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
    }
}
