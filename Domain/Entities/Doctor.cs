using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Doctor :User
    {
        public int price { get; set; }
        public int SpecializationId {  get; set; }
        public ICollection<Appointment> Appointments { get; set; }
        public int doctorid {  get; set; }
        public string doctorname { get; set; }
        public int numberOfRequests {  get; set; } = 0;
        public List<DoctorsAppointments> doctorsAppointments { get; set; }
    }
}
