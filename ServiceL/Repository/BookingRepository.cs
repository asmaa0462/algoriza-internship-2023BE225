using Domain.Entities;
using RepositoryL.Data;
using RepositoryL.Interface;
using ServiceL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceL.Repository
{
    public class BookingRepository : RepositoryBase<Booking>, IBookingRepository
    {
        public BookingRepository(AppDbContext context) : base(context)
        {

        }
    }
}
