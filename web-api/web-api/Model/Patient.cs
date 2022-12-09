using System.ComponentModel.DataAnnotations;

namespace web_api.Model
{
    public class Patient
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string DateOfBirth { get; set; }

        public ICollection<HistoryEntity> History { get; set; }
    }
}
