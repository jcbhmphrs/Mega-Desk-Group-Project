using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mega_Desk_Group_Project
{
    public class Desk
    {
        public int Width { get; set; }
        public int Depth { get; set; }
        public int DrawerCount { get; set; }
        public string Material { get; set; }

       public Desk(string material, int width, int depth, int drawerCount )
        {
            Material = material;
            Width = width;
            Depth = depth;
            DrawerCount = drawerCount;
        }

    }
}
