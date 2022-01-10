using System;

namespace H17.Models.Cards.PatientDetails
{
    public class PatientAddressInfo
    {
        public Guid Id { get; set; }
        public Guid PatientId { get; set; }

        public string Line { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }
}
