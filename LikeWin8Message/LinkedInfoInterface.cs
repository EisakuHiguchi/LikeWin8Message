using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeWin8Message
{
    /*
     * パネル(ユーザーコントロール)に付随する情報
     */
    interface LinkedInfoInterface
    {

        int getIndex();
        String getErrorMessage();
        String getDeviceName();
        String getRoomName();

        void setIndex(int index);
        void setErrorMessage(String error);
        void setDeviceName(String device);
        void setRoomName(String room);



    }
}
