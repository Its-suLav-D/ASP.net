using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Sulav
{
    public enum DesktopMaterial
    {
        Laminate = 100,
        Oak = 200, 
        Rosewood = 300, 
        Veneer = 125, 
        Pine = 50
    }

    public class Desk
    {
        // Constants

        public const int MIN_WIDTH = 24;
        public const int MAX_WIDTH = 96;
        public const int MIN_DEPTH = 12;
        public const int MAX_DEPTH = 48;
        public const int MIN_DESK_DRAWERS = 0;
        public const int MAX_DESK_DRAWERS = 7; 


        // Properties
        public decimal Width { get; set; }

        public decimal Depth { get; set; }

        public int NumberofDrawers { get; set; }

        public DesktopMaterial SurfaceMaterial { get; set; }

    }
}
