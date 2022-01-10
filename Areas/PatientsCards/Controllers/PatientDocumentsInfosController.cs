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
    public class PatientDocumentsInfosController : ControllerBase
    {
        [HttpGet("{id}")]
        public async Task<PatientDocumentsInfo> Details(Guid patientId)
        {
            using (DB db = new DB())
            {
                return db.PatientDocumentsInfos.Where(x=>x.PatientId == patientId).FirstOrDefault();
            }
        }

        // POST api/<ValuesController>
        [HttpPost]
        public async Task<PatientDocumentsInfo> Create(PatientDocumentsInfo value)
        {
            using (DB db = new DB())
            {
                value.Id = new Guid();
                db.PatientDocumentsInfos.Add(value);
                await db.SaveChangesAsync();

                return value;
            }
        }

        // PUT api/<ValuesController>/5
        [HttpPost]
        public async Task<bool> Update(PatientDocumentsInfo value)
        {
            try
            {
                using (DB db = new DB())
                {
                    var data = db.PatientDocumentsInfos.Where(x=>x.PatientId == value.PatientId && value.Id == x.Id).FirstOrDefault();
                    if (data == null)
                        throw new ArgumentNullException();

                    data.DriversLicense = value.DriversLicense;
                    data.PassportNumber = value.PassportNumber;
                    data.SocialSecurityNumber = value.SocialSecurityNumber;

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
                    db.PatientDocumentsInfos.Remove(db.PatientDocumentsInfos.Find(id));
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
