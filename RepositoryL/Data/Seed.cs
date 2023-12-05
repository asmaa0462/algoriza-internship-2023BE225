using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryL.Data
{
    public static class Seed
    {
        public static void seed (this ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Specialization>().HasData(
                new Specialization
                {
                    SpecializationId = 1,
                    SpecializationName = "Genetic pathology"
                },
                new Specialization
                {
                    SpecializationId = 2,
                    SpecializationName = "Ophthalmology"
                },
                new Specialization
                {
                    SpecializationId = 3,
                    SpecializationName = "Oncology"
                },
                new Specialization
                {
                    SpecializationId = 4,
                    SpecializationName = "Cardiology "
                },
                new Specialization
                {
                    SpecializationId = 5,
                    SpecializationName = "Hematology "
                },
                new Specialization
                {
                    SpecializationId = 6,
                    SpecializationName = "otolaryngology "
                },
                new Specialization
                {
                    SpecializationId = 7,
                    SpecializationName = "Psychiatry "
                },
                new Specialization
                {
                    SpecializationId = 8,
                    SpecializationName = "Liver Transplant Surgery"
                },
                new Specialization
                {
                    SpecializationId = 9,
                    SpecializationName = "Pediatric surgery"
                },
                new Specialization
                {
                    SpecializationId = 10,
                    SpecializationName = "Foot and ankle orthopedics"
                }
                );

                
        }

    }
}
