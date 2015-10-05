using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeWin8Message
{
    /*
     *パネル（ユーザーコントロール）の動きを担当
     */
    interface PanelMoveInterface
    {

        void moveIn();
        void moveOut();

        int getIndex();
        

        void setIndex(int index);

    }
        
}
