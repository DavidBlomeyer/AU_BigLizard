using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _02_Komodo_Claims_Department
{
    public enum ClaimType
    {
        Auto = 1,
        Home,
        Theft
    }

    // POCO - _queue "blueprint"
    public class ClaimsContent
    {
        // Variable Statement
        public int ClaimID { get; set; }
        public ClaimType TypeOfClaim { get; set; }
        public string ClaimDescription { get; set; }
        public double ClaimAmount { get; set; }
        public DateTime DateOfIncident { get; set; }
        public DateTime DateOfClaim { get; set; }
        public bool ClaimIsValid { get; set; }

        // Zeroed Constructor
        public ClaimsContent() { }

        // Parameterized Constructor
        public ClaimsContent(int claimID, ClaimType type, string claimDescription, double claimAmount, DateTime dateOfIncident, DateTime dateOfClaim, bool claimisValid)
        {
            ClaimID = claimID;
            TypeOfClaim = type;
            ClaimDescription = claimDescription;
            ClaimAmount = claimAmount;
            DateOfIncident = dateOfIncident;
            DateOfClaim = dateOfClaim;
            ClaimIsValid = claimisValid;
        }
    }
}