using System.ComponentModel.DataAnnotations;

namespace RadioButton.Models
{
    public class ContactModel
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
    }
}
