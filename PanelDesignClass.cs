using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;

/*
 * パネルのデザインのみを操作。
 */

namespace LikeWin8Message
{
    public class PanelDesignClass
    {
        MessagePanel panel;

        public PanelDesignClass(MessagePanel panel)
        {
            this.panel = panel;
        }

        // ---------------------------------------------------------------
        // 背景など、フォーム本体の設定
        // ---------------------------------------------------------------
        public void changeBackColor(Color c)
        {
            panel.changeBackColor(c);
        }
        public void setBackImage(Image picture)
        {
            panel.setBackImage(picture);
        }

        // ---------------------------------------------------------------
        // テキストの設定_label1
        // ---------------------------------------------------------------
        public void setLabel1Text(String msg)
        {
            panel.setLabel1Text(msg);
        }
        public void setText1Color(Color c)
        {
            panel.setText1Color(c);
        }
        public void setText1Marker(Color c)
        {
            panel.setText1Marker(c);
        }

        // ---------------------------------------------------------------
        // テキストの設定_label2
        // ---------------------------------------------------------------
        public void setLabel2Text(String msg)
        {
            panel.setLabel2Text(msg);
        }
        public void setText2Color(Color c)
        {
            panel.setText2Color(c);
        }
        public void setText2Marker(Color c)
        {
            panel.setText2Marker(c);
        }

        // ---------------------------------------------------------------
        // ステータス画像の設定
        // ---------------------------------------------------------------
        public void setPicture_State(PictureBox picture)
        {
            panel.setPicture_State(picture);
        }


        // ---------------------------------------------------------------
        // アイコン画像の設定
        // ---------------------------------------------------------------
        public void setPicture_Icon(PictureBox picture)
        {
            panel.setPicture_Icon(picture);
        }

        // ---------------------------------------------------------------
        // コマンド画像の設定
        // ---------------------------------------------------------------
        public void setPicture_Command(PictureBox picture)
        {
            panel.setPicture_Command(picture);
        }
    }

}
