using System.ComponentModel.DataAnnotations;

namespace MVCCoreAppExample.Models
{
    public class Customer
    {
       [Key]
        public int Id { get; set; }        
        public string FirstName { get; set; }        
        public string LastName { get; set; }
        public string CompanyName { get; set; }        
        public string EmailAddress { get; set; }        
    }
}