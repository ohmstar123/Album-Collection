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

       

        List<string> addedNames = new List<string>();
        List<string> sortedNames = new List<string>();

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
            sortedNames.Add(names);
           

            originalLabel.Text = "Original Order" + "\n" + "\n";
            sortedLabel.Text = "Sorted Order" + "\n" + "\n";


            for (int i = 0; i < addedNames.Count(); i++)
            {
                originalLabel.Text += addedNames[i] + "\n";
            }

            sortedNames.Sort();

            for (int i = 0; i < sortedNames.Count(); i++)
            {
                sortedLabel.Text += sortedNames[i] + "\n";
            }



        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            string names = inputBox.Text;
            addedNames.Add(names);
            sortedNames.Add(names);

            originalLabel.Text = "Original Order" + "\n" + "\n";
            sortedLabel.Text = "Sorted Order" + "\n" + "\n";

            for (int i = 0; i < sortedNames.Count(); i++)
            {
                if (names == sortedNames[i])
                {
                    sortedNames.RemoveAt(i);
                }
            }

            sortedNames.Sort();

            for (int i = 0; i < sortedNames.Count(); i++)
            {
                sortedLabel.Text += sortedNames[i] + "\n";
            }




        }
    }
}
