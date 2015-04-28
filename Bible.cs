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
    public partial class Bible : Form
    {


        public Bible()
        {
            InitializeComponent();
            biblePassage = "";
        }

        public string biblePassage { get; set; }

        public string book { get; set; }

        public string chapter { get; set; }

        public string verse { get; set; }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void listBox1_OnMouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedItem.ToString().Equals("Jeremiah"))
            {
                listBox1.Visible = false;
                textBox1.Enabled = true;
                textBox1.Visible = true;
                textBox2.Enabled = true;
                textBox2.Visible = true;
                book = "Jeremiah";
            }

            else
            {
                MessageBox.Show("Book not added yet");
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Visible)
            {
                listBox1.Visible = false;
                textBox1.Enabled = true;
                textBox1.Visible = true;
                textBox2.Enabled = true;
                textBox2.Visible = true;
            }

            else if (textBox2.Visible)
            {
                if (textBox2.Text.Equals("29"))
                {
                    checkedListBox1.Visible = true;
                    textBox1.Visible = false;
                    textBox2.Visible = false;
                    chapter = "29";
                }

                else MessageBox.Show("Incorrect Chapter");
            }

            else if (checkedListBox1.Visible)
            {
                foreach (object itemChecked in checkedListBox1.CheckedItems)
                {
                    this.verse = (checkedListBox1.SelectedIndex + 1).ToString();
                    this.biblePassage += itemChecked.ToString() + " ";
                }

                this.biblePassage += "(" + book + " " + chapter + ":" + verse + ")";
                this.Close();
            }

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }
        
    }
}
