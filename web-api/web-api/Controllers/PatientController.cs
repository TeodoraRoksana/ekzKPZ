using Microsoft.AspNetCore.Mvc;
using System.Data.SqlTypes;
using web_api.Model;
using web_api.Model.DTO;

namespace web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private DentalContext _context;
        public PatientController(DentalContext context)
        {
            _context = context;
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteData(int id, [FromBody] PatientDTO patient)
        {
            try
            {
                var currentPatient = _context.Patients.Where(x => x.Id == id).First();
                _context.History.RemoveRange(
                    _context.History.Where(x => x.PatientId == id)
                );

                _context.Patients.Remove(currentPatient);
                _context.SaveChanges();

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateData(int id, [FromBody] PatientDTO patient)
        {
            try
            {
                var currentPatient = _context.Patients.Where(x => x.Id == id).First();
                currentPatient.Name = patient.Name;
                currentPatient.LastName = patient.LastName;
                currentPatient.DateOfBirth = patient.DateOfBirth;

                _context.SaveChanges();

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult InsertData([FromBody] PatientDTO patient)
        {
            _context.Patients.Add(new Patient() { Name = patient.Name, LastName = patient.LastName, DateOfBirth = patient.DateOfBirth });
            _context.SaveChanges();

            _context.History.Add(new HistoryEntity() { Time = DateTime.Now.ToString("h:mm:ss"), 
                                                       Date = DateTime.Now.ToString("dd:MM:yyyy"), 
                                                       PatientId = _context.Patients.OrderBy(x => x.Id).Last().Id });
            _context.SaveChanges();

            return Ok();
        }

        [HttpGet]
        public IActionResult GetData()
        {
            var data = _context.Patients.Select(x => new PatientDTO()
                { Id = x.Id, DateOfBirth = x.DateOfBirth, LastName = x.LastName, Name = x.Name });

            return Ok(data);
        }
    }
}
