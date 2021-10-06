using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _03_Komodo_Badging
{
    // POCO - _dictionary "blueprint"
    public class BadgesContent 
    {
        // Variable Statement
        public int BadgeID { get; set; }
        public List<string> DoorAccess { get; set; } = new List<string>();

        // Zerod Constructor
        public BadgesContent() { }

        // Parameterized Constructor
        public BadgesContent(List<string> doorAccess)
        {
            DoorAccess = doorAccess;
        }
    }
}