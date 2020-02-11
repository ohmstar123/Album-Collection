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

        public Form1()
        {
            InitializeComponent();


        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string names = inputBox.Text;

        }

        private void removeButton_Click(object sender, EventArgs e)
        {

        }
    }
}
