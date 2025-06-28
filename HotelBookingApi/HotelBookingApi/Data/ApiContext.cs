using Microsoft.EntityFrameworkCore;
using HotelBookingApi.Models;

namespace HotelBookingApi.Data
{
    public class ApiContext : DbContext 
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {
        }

       
        public DbSet<HotelBooking> Bookings { get; set; }
    }
}
