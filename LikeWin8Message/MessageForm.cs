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
    public partial class MessageForm : Form
    {
        private PanelMoveClass pm;
        private PanelManagerClass pmc;
        private PanelDesignClass pd;

        public MessageForm(String msg1, String msg2)
        {
            InitializeComponent();

            pm = new PanelMoveClass(this, UtilClass.getIndex());
            pd = new PanelDesignClass(messagePanel1);

            pd.setLabel1Text(msg1);
            pd.setLabel2Text(msg2);
        }

        private void MessageForm_Load(object sender, EventArgs e)
        {
            // 場所の指定
            Location = new Point(System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width - Size.Width, 0);

            // クリック時の挙動を指定
            messagePanel1.Click += new EventHandler(panel_Click);
        }



        public void panel_Click(Object sender, EventArgs e)
        {
            Close();
        }

        private void MessageForm_Shown(object sender, EventArgs e)
        {
            pm.moveIn();
        }

        private void MessageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            pmc.panelOut(pm.getIndex());
            pm = null;
            this.Dispose();
            
        }

        public PanelMoveClass getPanelMover()
        {
            return pm;
        }

        public void setPanelManager(PanelManagerClass pmc)
        {
            this.pmc = pmc;
        }
        public PanelDesignClass getPanelDesignClass()
        {
            return pd;
        }



    }
}
