using System.ComponentModel.DataAnnotations;

namespace Running_SoMe.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode  { get; set; }
    }
}