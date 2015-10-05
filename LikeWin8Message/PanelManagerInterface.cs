using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Collections;

namespace LikeWin8Message
{
    /*
     * パネル全体の状態を管理する
     */
    interface PanelManagerInterface
    {

        void panelOut(int index);
        void panelIn(int index);

        void makeNewPanel();
        void disposePanel(int index);

        void panelInitilize(int index);
    }
}
