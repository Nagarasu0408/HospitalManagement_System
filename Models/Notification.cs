using System.ComponentModel.DataAnnotations;

namespace HospitalManagementSystem.Models
{
    public class Notification
    {
        public int Id { get; set; }

        [Required]
        public string Message { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public string RecipientRole { get; set; } // Admin, Doctor, Patient
    }
}
