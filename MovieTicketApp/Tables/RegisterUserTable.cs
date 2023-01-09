using System;
using System.Collections.Generic;
using System.Text;

namespace MovieTicketApp.Tables
{
    class RegisterUserTable
    {
        public Guid UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string YrLvl { get; set; }
        public string PatronType { get; set; }
    }
}
