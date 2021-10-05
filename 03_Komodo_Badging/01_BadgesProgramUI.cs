using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _03_Komodo_Badging
{
    public class BadgesProgramUI
    {
        private BadgesUIMethodRepo _listOfUIMethods = new BadgesUIMethodRepo();

        public void Run()
        {
            //_listOfUIMethods.SeedBadgesDictionary();
            BadgesStartMenu();
        }

        public void BadgesStartMenu()
        {
            _listOfUIMethods.SeedBadgesDictionary();

        }
    }
}