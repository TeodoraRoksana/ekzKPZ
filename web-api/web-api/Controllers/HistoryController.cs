using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using web_api.Model;
using web_api.Model.DTO;

namespace web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistoryController : ControllerBase
    {
        private DentalContext _context;
        public HistoryController(DentalContext context)
        {
            _context = context;
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteData(int id, [FromBody] HistoryEntity history)
        {
            try
            {
                _context.History.Remove(_context.History.Where(x => x.Id == id).First());
                _context.SaveChanges();

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateData(int id, [FromBody] HistoryEntity history)
        {
            try
            {
                var currentHistory = _context.History.Where(x => x.Id == id).First();
                currentHistory.Date = history.Date;
                currentHistory.Time = history.Time;
                currentHistory.PatientId = history.PatientId;

                _context.SaveChanges();

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult InsertData([FromBody] HistoryEntity history)
        {
            _context.History.Add(history);
            _context.SaveChanges();

            return Ok();
        }

        [HttpGet]
        public IActionResult GetData()
        {
            return Ok(_context.History.ToList());
        }
    }
}
