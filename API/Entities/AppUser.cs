using System;

namespace API.Etities
{
    public class AppUser
    {
        public int Id { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int PhoneNumber { get; set; }
        public string BusinessName { get; set; }
        public string RegistrationDate { get; set; }       
    }
}