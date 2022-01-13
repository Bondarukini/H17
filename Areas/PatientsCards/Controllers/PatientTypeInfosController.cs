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
    public class PatientTypeInfosController : ControllerBase
    {

        [HttpGet]
        public async Task<List<PatientTypeInfo>> List([FromQuery] Guid patientId)
        {
            using (DB db = new DB())
            {
                return db.PatientTypeInfos.Where(x => x.PatientId == patientId).ToList();
            }
        }
        [HttpGet]
        public async Task<PatientTypeInfo> Details(Guid patientId, Guid cardId)
        {
            using (DB db = new DB())
            {
                return db.PatientTypeInfos.Where(x => x.PatientId == patientId && x.Id == cardId).SingleOrDefault();
            }
        }

        [HttpPost]
        public async Task<PatientTypeInfo> Create(PatientTypeInfo value)
        {
            using (DB db = new DB())
            {
                value.Id = new Guid();
                db.PatientTypeInfos.Add(value);
                await db.SaveChangesAsync();

                return value;
            }
        }

        // PUT api/<ValuesController>/5
        [HttpPost]
        public async Task<bool> Update(PatientTypeInfo value)
        {
            try
            {
                using (DB db = new DB())
                {
                    var data = db.PatientTypeInfos.Where(x=>x.PatientId == value.PatientId && value.Id == x.Id).FirstOrDefault();
                    if (data == null)
                        throw new ArgumentNullException();

                    data.Key = value.Key;
                    data.Value = value.Value;

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
        public async Task<bool> Delete([FromBody]Guid id)
        {
            try
            {
                using (DB db = new DB())
                {
                    db.PatientTypeInfos.Remove(db.PatientTypeInfos.Find(id));
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
