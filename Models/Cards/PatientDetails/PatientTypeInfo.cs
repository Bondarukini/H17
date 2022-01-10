using System;

namespace H17.Models.Cards.PatientDetails
{
    public class PatientTypeInfo
    {
        public Guid Id { get; set; }
        public Guid PatientId { get; set; }
        public string Race { get; set; }
        public string Ethnicity { get; set; }
        public string Language { get; set; }
    }
}
