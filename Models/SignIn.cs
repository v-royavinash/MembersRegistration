﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MembersRegistration.Models
{
    public class SignIn
    {
        [DisplayName("Username")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Username required.")]
        public string UserName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Password required.")]
        [StringLength(100, ErrorMessage = "Password \"{0}\" must have {2} character", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string Password { get; set; }



        [DisplayName("Remember Me")]
        public bool RememberMe { get; set; }

    }
}