using Domain.Entities;
using Domain.Entities.Enum;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryL.Data
{
    public static class DoctorSeed
    {
        public static void doctorseed(this ModelBuilder modelbuilder)
        {

             modelbuilder.Entity<Doctor>().HasData(
               new Doctor
               {
                   Id= 1,
                   FirstName = "Ahmed",
                   LastName = "Ali",
                   Email = "ahmedali@bit.com",
                   Password = "PO-k?$rn",
                   image = "images/1.jpeg",
                   Phone = "012345678",
                   Gender = Gender.Male,
                   DateBirth = new DateTime(1995, 12, 13),
                   price = 200,
                   SpecializationId = 8
                   
               },
               new Doctor
               {
                   Id = 2,
                   FirstName = "Mohamed",
                   LastName = "Hosam",
                   Email = "mohamedhosam@bit.com",
                   Password = "(UHp'Nkh",
                   image = "images/2.jpeg",
                   Phone = "02456972",
                   Gender = Gender.Male,
                   DateBirth = new DateTime(1978,5,2),
                   price = 200,
                   SpecializationId = 7,
               },
                 new Doctor
                 {
                     Id = 3,
                     FirstName = "Mahmoud",
                     LastName = "Wael",
                     Email = "mahmoudwael@bit.com",
                     Password = "n`6Jy}+z",
                     image = "images/3.jpeg",
                     Phone = "01246875",
                     Gender = Gender.Male,
                     DateBirth = new DateTime(1985,10,1),
                     price = 200,
                     SpecializationId = 5
                 },
                  new Doctor
                  {
                      Id= 4,
                      FirstName = "Hamza",
                      LastName = "Waleed",
                      Email = "hamzawaleed@bit.com",
                      Password = "6(@Ksr5c",
                      image = "images/4.jpeg",
                      Phone = "012364799",
                      Gender = Gender.Male,
                          DateBirth = new DateTime(1992,4,12),
                      price = 200,
                      SpecializationId = 4
                  },
                   new Doctor
                   {
                       Id =5,
                       FirstName = "Omar",
                       LastName = "Taher",
                       Email = "omartaher@bit.com",
                       Password = "6+d$e#Js",
                       image = "images/5.jpeg",
                       Phone = "01268958",
                       Gender = Gender.Male,
                       DateBirth = new DateTime(1993,3,20),
                       price = 200,
                       SpecializationId = 1
                   },
                    new Doctor
                    {
                        Id =6,
                        FirstName = "Yousef",
                        LastName = "Hamed",
                        Email = "yousefhamed@bit.com",
                        Password = "qt;<}Kjh",
                        image = "images/6.jpeg",
                        Phone = "0145588",
                        Gender = Gender.Male,
                        DateBirth = new DateTime(1992,8,25),
                        price = 200,
                        SpecializationId = 2
                    },
                    new Doctor
                    {
                        Id = 7,
                        FirstName = "Khaled",
                        LastName = "Razmy",
                        Email = "khaledramzy@bit.com",
                        Password = "8)Q`wkP$",
                        image = "images/7.jpeg",
                        Phone = "013678526",
                        Gender = Gender.Male,
                        DateBirth = new DateTime(1997,7,5),
                        price = 200,
                        SpecializationId = 3
                    },
                    new Doctor
                    {
                        Id =8,
                        FirstName = "yaser",
                        LastName = "sayed",
                        Email = "yasersayed@bit.com",
                        Password = "P<!=W6fe",
                        image = "images/8.jpeg",
                        Phone = "01369885",
                        Gender = Gender.Male,
                        DateBirth = new DateTime(1999,11,1),
                        price = 200,
                        SpecializationId = 9
                    },
                    new Doctor
                    {
                        Id = 9,
                        FirstName = "Amr",
                        LastName = "Ahmed",
                        Email = "amrahmed",
                        Password = "l)OJ*VkB",
                        image = "images/9.jpeg",
                        Phone = "0123648796",
                        Gender = Gender.Male,
                        DateBirth = new DateTime(1987,5,10),
                        price = 200,
                        SpecializationId = 10
                    },
                    new Doctor
                    {
                        Id = 10,
                        FirstName = "Aya",
                        LastName = "Ahmed",
                        Email = "ayaahmed",
                        Password = "ynz#Jpsg",
                        image = "images/10.jpeg",
                        Phone = "0123546",
                        Gender = Gender.Female,
                        DateBirth = new DateTime(1995,2,9),
                        price = 200,
                        SpecializationId = 11
                    },
                    new Doctor
                    {
                        Id = 11,
                        FirstName = "Hanaa",
                        LastName = "Magdy",
                        Email = "hanaamagdy@bit.com",
                        Password = "zNH:gT7w",
                        image = "images/11.jpeg",
                        Phone = "0197586413",
                        Gender = Gender.Female,
                        DateBirth = new DateTime(1996,6,16),
                        price = 200,
                        SpecializationId = 12
                    },
                    new Doctor
                    {
                        Id = 12,
                        FirstName = "Hala",
                        LastName = "Mohamed",
                        Email = "halamodamed@bit.com",
                        Password = "#;b*D+x$",
                        image = "images/12.jpeg",
                        Phone = "010955487652",
                        Gender = Gender.Female,
                        DateBirth = new DateTime(1998,4,6),
                        price = 200,
                        SpecializationId = 8
                    },
                    new Doctor
                    {
                        Id = 13,
                        FirstName = "Fatma",
                        LastName = "Safwt",
                        Email = "fatmasafwt@@bit.com",
                        Password = "]Q,X$|ri",
                        image = "images/13.jpeg",
                        Phone = "01269753684",
                        Gender = Gender.Female,
                        DateBirth = new DateTime(1994,2,28),
                        price = 200,
                        SpecializationId = 12
                    },
                    new Doctor
                    {
                        Id = 14,
                        FirstName = "yara",
                        LastName = "Ayman",
                        Email = "masaadham@bit.com",
                        Password = "VXFlvL2d",
                        image = "images/14.jpeg",
                        Phone = "0125873",
                        Gender = Gender.Female,
                        DateBirth = new DateTime(1991, 6, 3),
                        price = 200,
                        SpecializationId = 3
                    }   
              );
            
        }
    }
}
