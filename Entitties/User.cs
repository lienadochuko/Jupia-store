﻿using System;

namespace Entitties
{
    public class User
    {
        public Guid UserID { get; set; }

        public string? UserName { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Gender { get; set; }

        public string? Email { get; set; }
        
        public string? Phone { get; set; }
        
        public string? Password { get; set; }
    }
}
