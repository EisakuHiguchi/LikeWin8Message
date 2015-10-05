using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Collections;

namespace LikeWin8Message
{
    public partial class MessagePanel : UserControl
    {

        public MessagePanel()
        {
            InitializeComponent();
        }

        // ロード時に実行
        private void MessagePanel_Load(object sender, EventArgs e)
        {
            // ラベル処理
            String msg = "MessagePanel_" + UtilClass.getIndex();
            label1.Text = msg;
            label1.Name = msg;
        }



        // ---------------------------------------------------------------
        // 背景など、フォーム本体の設定
        // ---------------------------------------------------------------
        public void changeBackColor(Color c)
        {
            BackColor = c;
        }
        public void setBackImage(Image picture)
        {
            BackgroundImage = picture;
        }

        // ---------------------------------------------------------------
        // テキストの設定_label1
        // ---------------------------------------------------------------
        public void setLabel1Text(String msg)
        {
            label1.Text = msg;
        }
        public void setText1Color(Color c)
        {
            label1.ForeColor = c;
        }
        public void setText1Marker(Color c)
        {
            label1.BackColor = c;
        }


        // ---------------------------------------------------------------
        // テキストの設定_label2
        // ---------------------------------------------------------------
        public void setLabel2Text(String msg)
        {
            label2.Text = msg;
        }
        public void setText2Color(Color c)
        {
            label2.ForeColor = c;
        }
        public void setText2Marker(Color c)
        {
            label2.BackColor = c;
        }
        

        // ---------------------------------------------------------------
        // ステータス画像の設定
        // ---------------------------------------------------------------
        public void setPicture_State(PictureBox picture)
        {
            //pictureBox_state = picture;
        }


        // ---------------------------------------------------------------
        // アイコン画像の設定
        // ---------------------------------------------------------------
        public void setPicture_Icon(PictureBox picture)
        {
            pictureBox_Icon = picture;
        }

        // ---------------------------------------------------------------
        // コマンド画像の設定
        // ---------------------------------------------------------------
        public void setPicture_Command(PictureBox picture)
        {
            pictureBox_command = picture;
        }

        private void pictureBox_command_Click(object sender, EventArgs e)
        {

        }



    }
}
