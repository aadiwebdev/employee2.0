﻿using Domain.Interfaces;

namespace Domain.Models
{
    internal class UserModel
    {
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ConfirmPassword { get; set; }
        public string IsStudent { get; set; }
    }
}
