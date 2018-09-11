using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_Interface
{
    public partial class MainForm : Form
    {
        public Button button1;

        public MainForm()
        {
            InitializeComponent();

            button1 = new Button();
            button1.Size = new System.Drawing.Size(40, 40);
            button1.Location = new System.Drawing.Point(30, 30);
            button1.Text = "Click Me";
            this.Controls.Add(button1);
            button1.Click += new EventHandler(button1_Click);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }
    }
}
