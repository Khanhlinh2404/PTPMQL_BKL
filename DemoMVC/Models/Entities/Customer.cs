using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models.Entities
{
    public class Customer
    {
        [Key]
        public string CustomerId { get; set; }
        [MinLength (3)]
        public string Fullname { get; set; }
        public string? Address { get; set; }
        [DataType (DataType.EmailAddress)]
        public string Email { get; set; }

    }

}