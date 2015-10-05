using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace LikeWin8Message
{
    /*
     * パネル（ユーザーコントロール）に付随させる
     * パネルの動きを制御するだけ
     * 
     */

    public class PanelMoveClass:PanelMoveInterface
    {
        int panelIndex = 0;
        int speed = 2;

        MessageForm form;

        public PanelMoveClass(MessageForm mf,int index)
        {
            
            form = mf;
            setIndex(index);
        }

        public void moveIn()
        {
            int endX = form.Size.Width;
            int endY = form.Size.Height * panelIndex;
            form.Refresh();

            for (int i = 0; i < endX; i+=speed)
            {
                form.SuspendLayout();
                form.Location = new Point(
                    System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width - i,
                    endY);
                form.ResumeLayout();
            }
        }
        
        public void moveOut()
        {
            int endX = form.Size.Width;
            int startX = form.Location.X + endX;

            while(form.Location.X < startX)
            {
                form.SuspendLayout();
                form.Location = new Point(
                    form.Location.X + speed*15
                    ,form.Location.Y);
                System.Threading.Thread.Sleep(1);
                form.ResumeLayout();
                
            }
        }

        public void moveUp()
        {
            int endY = form.Size.Height * panelIndex;

            while(form.Location.Y > endY)
            {
                form.SuspendLayout();
                form.Location = new Point(
                    form.Location.X
                    , form.Location.Y - speed*10);
                System.Threading.Thread.Sleep(1);
                form.ResumeLayout();
            }
        }

        private void dispose()
        {
            //form = null;
        }

        public int getIndex()
        {
            return panelIndex;
        }

        public void setIndex(int index)
        {
            panelIndex = index;
        }
    }
}
