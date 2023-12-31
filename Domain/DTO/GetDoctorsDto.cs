﻿using Domain.Entities.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO
{
    public class GetDoctorsDto
    {

     
        //[Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }

        //[Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }

        //[EmailAddress]
        //[Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        //[Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        //[Required(ErrorMessage = "Image is required")]
        public string? image { get; set; }

        //[Required(ErrorMessage = "Phone is required")]
        public string Phone { get; set; }

        //[Required(ErrorMessage = "Gender is required")]
        public Gender Gender { get; set; }

       // [Required(ErrorMessage = "Date of Birth is required")]
        public DateTime DateBirth { get; set; }
        public int price { get; set; }
        public string SpecializationName { get; set; }
        public int numberOfRequested { get; set; }
    }
}
