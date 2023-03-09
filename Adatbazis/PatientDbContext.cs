using Microsoft.EntityFrameworkCore;

namespace Adatbazis
{
    public class PatientDbContext: DbContext
    {
        public DbSet<Patient> Patients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=. \SQLEXPRESS;Database=PatientDb;Trusted_connection= True; TrustServerCertificate = True");

            //connection string

        }


        // Package manager console ba beirjuk:

        //1. add-migration CreateADATBAZISNEV

        //update-database -verbose   // ez kiirja epp mit csinal

    }

}