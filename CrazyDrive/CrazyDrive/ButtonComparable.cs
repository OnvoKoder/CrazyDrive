using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrazyDrive
{
    class ButtonComparable : Button, IComparable
    {
        public int CompareTo(object obj)
        {
            ButtonComparable bc = (ButtonComparable)obj;
            if (this.Location.X > bc.Location.X)
                return -1;
            else if (this.Location.X < bc.Location.X)
                return 1;
            else
                return 0;
        }
    }
}
