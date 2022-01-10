using System;

namespace H17.Models.Cards.PatientDetails
{
    public class PatientTelecomInfo
    {
        public Guid Id { get; set; }
        public Guid PatientId { get; set; }
        public string System { get; set; }
        public string Phone { get; set; }
        public string Use { get; set; } //homew /work
    }
}
