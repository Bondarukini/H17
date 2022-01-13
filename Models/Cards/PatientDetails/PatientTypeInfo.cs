using System;

namespace H17.Models.Cards.PatientDetails
{
    public class PatientTypeInfo
    {
        public Guid Id { get; set; }
        public Guid PatientId { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
