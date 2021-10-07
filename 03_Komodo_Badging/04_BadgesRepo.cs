using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace _03_Komodo_Badging
{
    public class BadgesContentRepo 
    {
        // Instance the BadgesContent Object
        public static IDictionary<int, BadgesContent> _dictionaryOfBadgesContent = new Dictionary<int, BadgesContent>();

        // C
        public void AddEntryToDictionary(BadgesContent content)
        {
            _dictionaryOfBadgesContent.Add(content.BadgeID, content);
        }

        // R
        public IDictionary<int, BadgesContent> GetEntryFromDictionary()
        {
            return _dictionaryOfBadgesContent;
        }

        // U
        public bool UpdateDoorListOnBadge(int badgeID, string doorAccess)
        {
            BadgesContent thisBadge = GetBadgesContentEntryByBadgeID(badgeID);
            thisBadge.DoorAccess.Add(doorAccess);

            return true;
        }

        // D
        public bool RemoveAllEntriesFromDictionaryByBadgeID(int badgeID)
        {
            BadgesContent content = GetBadgesContentEntryByBadgeID(badgeID);

            if (content == null) { return false; }
            int initialCount = _dictionaryOfBadgesContent.Count;

            _dictionaryOfBadgesContent.Remove(badgeID);

            if (initialCount > _dictionaryOfBadgesContent.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RemoveEntryFromDictionaryByBadgeIDAndDoorAccess(int badgeID, string doorAccess)
        {
            BadgesContent content = GetBadgesContentEntryByBadgeID(badgeID);

            if (content == null)
            {
                return false;
            }
            int initialCount = _dictionaryOfBadgesContent.Count;

            content.DoorAccess.Remove(doorAccess);

            if (initialCount > _dictionaryOfBadgesContent.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Localized Helper Methods
        public BadgesContent GetBadgesContentEntryByBadgeID(int badgeID)
        {
            foreach (var badgeContent in _dictionaryOfBadgesContent)
            {
                if (badgeContent.Key == badgeID)
                {
                    return badgeContent.Value;
                }
            }

            return null;
        }
    }
}