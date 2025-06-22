using System.ComponentModel.DataAnnotations;

namespace HospitalManagementSystem.Models
{
    public class Doctor
    {
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }

        public string Specialty { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }
    }
}
