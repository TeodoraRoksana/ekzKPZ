using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace web_api.Model
{
    public class HistoryEntity
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Date { get; set; }
        [Required]
        public string Time { get; set; }

        [ForeignKey("Patient")]
        [Required]
        public int PatientId { get; set; }
    }
}