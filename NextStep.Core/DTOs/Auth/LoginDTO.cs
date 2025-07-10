﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextStep.Core.DTOs.Auth
{
    // LoginDTO.cs
    public class LoginDTO
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }

    public class LoginStudentDTO
    {
        [Required]
        public string NIdPassowrd { get; set; }
    }
}
