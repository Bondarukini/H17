using H17.Models;
using H17.Models.Cards;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace H17.Areas.Cards.Controllers
{
    [Area("PatientsCards")]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        [HttpGet]
        public List<Patient> List()
        {
            using (DB db = new DB())
                return db.Patients.ToList();
        }

        [HttpGet("{id}")]
        public async Task<Patient> Details(Guid id)
        {
            using (DB db = new DB())
                return await db.Patients.FindAsync(id);
        }


        [HttpPost]
        public async Task<Patient> Create(Patient value)
        {
            using (DB db = new DB())
            {
                value.Id = new Guid();
                db.Patients.Add(value);
                await db.SaveChangesAsync();

                return value;
            }
        }

        [HttpPost]
        public async Task<bool> Update(Patient value)
        {
            try
            {
                using (DB db = new DB())
                {
                    var data = db.Patients.Find(value.Id);
                    if (data == null)
                        throw new ArgumentNullException();

                    data.MaritalStatus = value.MaritalStatus;
                    data.Gender = value.Gender;
                    data.DisabilityAdjustedLifeYears = value.DisabilityAdjustedLifeYears;
                    data.DeceasedDateTime = value.DeceasedDateTime;
                    data.QualityAdjustedLifeYears = value.QualityAdjustedLifeYears;


                    data.Family = value.Family;
                    data.Given = value.Given;
                    data.Prefix = value.Prefix;
                    data.MothersMaidenName = value.MothersMaidenName;


                    await db.SaveChangesAsync();
                    return true;
                }
            }
            catch (Exception ex) {
                return false;
            }
        }

        [HttpPost]
        public async Task<bool> Delete([FromBody]Guid id)
        {
            try
            {
                using (DB db = new DB())
                {
                    db.Patients.Remove(db.Patients.Find(id));
                    await db.SaveChangesAsync();
                    return true;
                }
            }
            catch (Exception ex) {
                return false;
            }
        }
    }
}
