using H17.Models.Cards;
using H17.Models.Cards.PatientDetails;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace H17.Models
{
    public class DB:DbContext
    {
        public DB()
        {
        }
        public DB(DbContextOptions<DB> options) : base(options)
        {
           
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("SQL").Value);
        }


        public DbSet<Patient> Patients { get; set; }
        public DbSet<PatientAddressInfo> PatientAddressInfos { get; set; }

        public DbSet<PatientBirthInfo> PatientBirthInfos  { get; set; }
        public DbSet<PatientDocumentsInfo> PatientDocumentsInfos   { get; set; }
        public DbSet<PatientTelecomInfo> PatientTelecomInfos   { get; set; }
        public DbSet<PatientTypeInfo> PatientTypeInfos   { get; set; }
    }
}
