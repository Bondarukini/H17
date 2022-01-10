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
    public class PatientAddressInfosController : ControllerBase
    {
        [HttpGet("{id}")]
        public async Task<PatientAddressInfo> Details(Guid patientId)
        {
            using (DB db = new DB())
            {
                return db.PatientAddressInfos.Where(x=>x.PatientId == patientId).FirstOrDefault();
            }
        }

        // POST api/<ValuesController>
        [HttpPost]
        public async Task<PatientAddressInfo> Create(PatientAddressInfo value)
        {
            using (DB db = new DB())
            {
                value.Id = new Guid();
                db.PatientAddressInfos.Add(value);
                await db.SaveChangesAsync();

                return value;
            }
        }

        // PUT api/<ValuesController>/5
        [HttpPost]
        public async Task<bool> Update(PatientAddressInfo value)
        {
            try
            {
                using (DB db = new DB())
                {
                    var data = db.PatientAddressInfos.Where(x=>x.PatientId == value.PatientId && value.Id == x.Id).FirstOrDefault();
                    if (data == null)
                        throw new ArgumentNullException();

                    data.City = value.City;
                    data.State = value.State;
                    data.Line = value.Line;
                    data.Country = value.Country;

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
                    db.PatientAddressInfos.Remove(db.PatientAddressInfos.Find(id));
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
