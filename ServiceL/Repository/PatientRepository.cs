using Domain.DTO;
using Domain.Entities;
using Domain.Entities.Enum;
using RepositoryL.Data;
using RepositoryL.Interface;
using ServiceL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceL.Interface
{
    public class PatientRepository : RepositoryBase<Patient> , IPatientRepository
    {
        public PatientRepository(ApplicationDbContext context) : base(context)
        {
        }

        public void AddNumberRequest()
        {
            var patient = new GetPatientDto();

            patient.NumberofRequest += 1;
            if (patient.NumberofRequest == 5)
            {
                GenerateDiscount();
            }
        }

        public int GenerateDiscount()
        {
            var discount = new UpdateDiscountDto();
            var rnd = new Random();
            discount.DiscountState = DiscountState.Active;
            return rnd.Next(1,100);
        }
    }
}
