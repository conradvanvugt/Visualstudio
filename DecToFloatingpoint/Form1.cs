using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecToFloatingpoint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private String input;
        private String[] inputsplit;
        private void button1_Click(object sender, EventArgs e)
        {
            inputsplit = new String[1];
            input = textBox1.Text;
            inputsplit = input.Split('.', ',');
        }
    }
    class Converting(String decdeel){
    
    }
}
