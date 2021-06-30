using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace EmptyAspCore.ViewModels
{
    public class ContactViewModel
    {

        public int Id { get; set; }

        [DisplayName("Full Name")]
        public string Name { get; set; }

        [DisplayName("Email Address")]
        public string Email { get; set; }
    }
}
