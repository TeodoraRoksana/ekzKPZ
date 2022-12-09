using System.ComponentModel.DataAnnotations;

namespace web_api.Model.DTO
{
    public class PatientDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
    }
}
