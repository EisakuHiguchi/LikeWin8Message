using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Collections;

namespace LikeWin8Message
{
    public class PanelManagerClass:PanelManagerInterface
    {
        private ArrayList panelList;

        public PanelManagerClass()
        {
            panelList = new ArrayList();
        }


        public void panelOut(int index)
        {
            PanelMoveClass pm = ((MessageForm)panelList[index]).getPanelMover();
            pm.moveOut();

            disposePanel(index);
            resetPanelLocate();
        }

        public void panelIn(int index)
        {
            PanelMoveClass pm = ((MessageForm)panelList[index]).getPanelMover();
            pm.moveIn();
        }

        public void makeNewPanel(String label1, String label2)
        {
            UtilClass.addIndex(1);
            MessageForm msgForm = new MessageForm(label1, label2);
            panelList.Add(msgForm);
            panelInitilize(panelList.Count - 1);
            msgForm.Show();
        }

        public void disposePanel(int index)
        {
            panelList.RemoveAt(index);
            UtilClass.addIndex(-1);

        }


        public void panelInitilize(int index)
        {
            MessageForm mf = (MessageForm)panelList[index];
            mf.setPanelManager(this);
            mf.Name = "MessageForm_" + index;
        }

        public void resetPanelLocate()
        {
            int i = 0;
            foreach(MessageForm element in panelList)
            {
                element.getPanelMover().setIndex(i);
                if(element.Location.Y != 0)
                {
                    element.getPanelMover().moveUp();
                    
                }
                i++;
            }
        }
    }
}
