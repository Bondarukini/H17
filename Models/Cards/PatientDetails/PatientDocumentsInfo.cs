using System;

namespace H17.Models.Cards.PatientDetails
{
    public class PatientDocumentsInfo
    {
        public Guid Id { get; set; }
        public Guid PatientId { get; set; }
        //public string SocialSecurityNumber { get; set; }
        //public string DriversLicense { get; set; }
        //public string PassportNumber { get; set; }

        public string Key { get; set; }
        public string Value { get; set; }
    }
}
