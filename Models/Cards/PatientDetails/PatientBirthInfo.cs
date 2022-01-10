using System;
namespace H17.Models.Cards.PatientDetails
{
    public class PatientBirthInfo
    {
        public Guid Id { get; set; }
        public Guid PatientId { get; set; }
        public DateTime BirthDate { get; set; }
        public string BirthCity { get; set; }
        public string BirthState { get; set; } 
        public string BirthCountry { get; set; } 
        public string Birthsex { get; set; }
    }
}
