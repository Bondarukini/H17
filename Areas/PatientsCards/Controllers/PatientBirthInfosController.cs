using H17.Models;
using H17.Models.Cards;
using H17.Models.Cards.PatientDetails;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace H17.Areas.Cards.Controllers
{
    [Area("PatientsCards")]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PatientBirthInfosController : ControllerBase
    {
        [HttpGet("{id}")]
        public async Task<PatientBirthInfo> Details(Guid patientId)
        {
            using (DB db = new DB())
            {
                return db.PatientBirthInfos.Where(x=>x.PatientId == patientId).FirstOrDefault();
            }
        }

        // POST api/<ValuesController>
        [HttpPost]
        public async Task<PatientBirthInfo> Create(PatientBirthInfo value)
        {
            using (DB db = new DB())
            {
                value.Id = new Guid();
                db.PatientBirthInfos.Add(value);
                await db.SaveChangesAsync();

                return value;
            }
        }

        // PUT api/<ValuesController>/5
        [HttpPost]
        public async Task<bool> Update(PatientBirthInfo value)
        {
            try
            {
                using (DB db = new DB())
                {
                    var data = db.PatientBirthInfos.Where(x=>x.PatientId == value.PatientId && value.Id == x.Id).FirstOrDefault();
                    if (data == null)
                        throw new ArgumentNullException();

                    data.BirthState = value.BirthState;
                    data.BirthCity = value.BirthCity;
                    data.BirthCountry = value.BirthCountry;
                    data.Birthsex = value.Birthsex;
                    data.BirthDate = value.BirthDate;


                    await db.SaveChangesAsync();
                    return true;
                }
            }
            catch (Exception ex) {
                return false;
            }
        }

        // DELETE api/<ValuesController>/5
        [HttpPost]
        public async Task<bool> Delete(Guid id)
        {
            try
            {
                using (DB db = new DB())
                {
                    db.PatientBirthInfos.Remove(db.PatientBirthInfos.Find(id));
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
