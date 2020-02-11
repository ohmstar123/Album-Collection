using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Album_Collection
{
    public partial class Form1 : Form
    {

       

        static public List<string> addedNames = new List<string>();

        public Form1()
        {
            InitializeComponent();

            

            originalLabel.Text += "\n" + "\n";
            sortedLabel.Text += "\n" + "\n";
            

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string names = inputBox.Text;
            addedNames.Add(names);

            for (int i = 0; i < addedNames.Count(); i++)
            {
                originalLabel.Text = "\n" + addedNames[i] ;
            }



        }

        private void removeButton_Click(object sender, EventArgs e)
        {

        }
    }
}
