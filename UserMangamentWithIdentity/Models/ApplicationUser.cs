﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UserMangamentWithIdentity.Models
{
    public class ApplicationUser:IdentityUser
    {
        [Required , MaxLength(100)]
        public string FirstName { get; set; }

        [Required, MaxLength(100)]
        public string LastName { get; set; }
        public Byte[] FilePicture { get; set; }
    }
}
