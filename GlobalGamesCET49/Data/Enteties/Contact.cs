using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GlobalGamesCET49.Data.Enteties
{
    public class Contact
    {
        // Só são necessárias para o BUDGET FORM da página SERVICES as strings NAME, EMAIL, MESSAGE
        public int Id { get; set; }

        [Display(Name = " Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        [Display(Name = "Phone Number")]
        public int PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Message { get; set; }

    }
}
