using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LikeWin8Message
{
    public partial class Form1 : Form
    {
        PanelManagerClass pmc;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pmc = new PanelManagerClass();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            pmc.makeNewPanel("msg1", "label");
        }



    }
}
