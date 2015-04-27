using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KairosApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string sermonTitle { get; set; }
        string sermonText { get; set; }
        private void Form1_Load(object sender, EventArgs e)
        {
            ExtractAssociatedIconEx(@"Test Documents");
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void presentButton_Click(object sender, EventArgs e)
        {
            presentationForm presentForm = new presentationForm(this.sermonTitle, this.sermonText);
            presentForm.Show();
        }

        private void calendarButton_Click(object sender, EventArgs e)
        {
            //calendarForm calForm = new calendarForm();

            //calForm.Show();
            
            using (var form = new calendarForm())
            {
                var result = form.ShowDialog();


                this.sermonText = form.returnText;
                this.sermonTitle = form.sermonTitle;
                
            }
           
            this.mainTextBox.Text = this.sermonText;
        }

        private void saveAsButton_Click(object sender, EventArgs e)
        {
            saveButton_Click(sender, e);
        }

        private void saveButton_Click(object sender, EventArgs e) //File Saving
        {
            UnicodeEncoding uniEncoding = new UnicodeEncoding();


            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            if (mainTextBox.Enabled == true) // Checks if sermon has been created or opened
            {
                saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if ((myStream = saveFileDialog1.OpenFile()) != null)
                    {
                        // Code to write the stream goes here.

                        myStream.Write(uniEncoding.GetBytes(mainTextBox.Text), 0, (mainTextBox.Text.Length * sizeof(char)));

                        myStream.Close();
                    }
                }
            }

            else
            {

            }


        }

        private void openButton_Click(object sender, EventArgs e)
        {
            //Needs to be done: enable mainTextBox, set mainTextBox.ReadOnly to false and set mainTextBox.Text = text inside file user selected
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            mainTextBox.Enabled = true;
            mainTextBox.ReadOnly = false;
            mainTextBox.Text = "";
        }

        private void setTimeButton_Click(object sender, EventArgs e)
        {
            
        }

        private void addBlockButton_Click(object sender, EventArgs e)
        {

        }

        private void addVerseButton_Click(object sender, EventArgs e)
        {

        }

        ImageList imageList1;

        public void ExtractAssociatedIconEx(string filepath)
        {
            // Initialize the ListView, ImageList and Form.
            imageList1 = new ImageList();
            listView1.SmallImageList = imageList1;
            listView1.View = View.SmallIcon;

            // Get the c:\ directory.
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(@filepath);

            ListViewItem item;
            listView1.BeginUpdate();

            // For each file in the c:\ directory, create a ListViewItem 
            // and set the icon to the icon extracted from the file. 
            foreach (System.IO.FileInfo file in dir.GetFiles())
            {
                // Set a default icon for the file.
                Icon iconForFile = SystemIcons.WinLogo;

                item = new ListViewItem(file.Name, 1);
                iconForFile = Icon.ExtractAssociatedIcon(file.FullName);

                // Check to see if the image collection contains an image 
                // for this extension, using the extension as a key. 
                if (!imageList1.Images.ContainsKey(file.Extension))
                {
                    // If not, add the image to the image list.
                    iconForFile = System.Drawing.Icon.ExtractAssociatedIcon(file.FullName);
                    imageList1.Images.Add(file.Extension, iconForFile);
                }
                item.ImageKey = file.Extension;
                listView1.Items.Add(item);
            }
            listView1.EndUpdate();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            listView1.Clear();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void open2Button_Click(object sender, EventArgs e)
        {
            ListViewItem textFile = listView1.SelectedItems[0];
            
            
             //SideTextView. = textFile.Text;
        }

        private void fileSystemLayout_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
