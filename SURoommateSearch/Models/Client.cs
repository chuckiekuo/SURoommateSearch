using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace SURoommateSearch.Models
{
    public class Client
        
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "Must include E-mail")]
        [Display(Name = "E-mail address: ")]
        [DataType(DataType.EmailAddress,ErrorMessage = "E-mail is not valid")]
        [EmailAddress(ErrorMessage = "Invalid E-mail Address")]
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public string Major { get; set; }
        public string Job { get; set; }

        [Display(Name = "Phone Number: ")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        public string Gender { get; set; }
        public string Hometown { get; set; }
    }

    public class ClientDbContext : DbContext
    {
        public DbSet<Client> Client { get; set; }
    }
}