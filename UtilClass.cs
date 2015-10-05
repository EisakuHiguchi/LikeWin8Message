using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeWin8Message
{
    static class UtilClass
    {
        public static int PANEL_WIDTH = 450;
        public static int PANEL_HEIGHT = 60;

        private static int INDEX = -1;

        public static int getIndex()
        {
            return INDEX;
        }

        public static void setIndex(int index)
        {
            INDEX = INDEX + index;
        }
    }
}
