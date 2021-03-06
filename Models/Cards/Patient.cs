using System;

namespace H17.Models.Cards
{
    public class Patient
    {
        public Guid Id { get; set; }


        public string Family { get; set; }
        public string Given { get; set; }
        public string Prefix { get; set; }
        public string MothersMaidenName { get; set; }



        public string Gender { get; set; }
        public string MaritalStatus { get; set; }


        public double DisabilityAdjustedLifeYears { get; set; }
        public double QualityAdjustedLifeYears { get; set; }


        public DateTime DeceasedDateTime { get; set; }

        
    }
}
