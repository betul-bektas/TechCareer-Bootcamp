using Microsoft.EntityFrameworkCore;

namespace TechCareerBootcampProje.Models{
    public class TechCareerDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //connection string
             optionsBuilder.UseSqlServer("Server=BETUL-BEKTAS\\MSSQLSERVER05; Database=TechCareerDb; Trusted_Connection =true");
        } 

        public DbSet<ClientModel>? Client { get; set;}

        public DbSet<CompanyModel>? Companies { get; set; }
        public DbSet<ReservationModel>? Reservations { get; set; }
        public DbSet<RoomModel>? Rooms { get; set; }

    }
}