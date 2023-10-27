using L2.Domain;
using Microsoft.EntityFrameworkCore;

namespace L2.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
            //Database.EnsureCreated();

            public DbSet<Cars> Cars { get; set; }
            //public DbSet<Passangers> Passangers { get; set; }

    }

        /*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cars>().ToTable("cars");
            modelBuilder.Entity<Cars>(builder =>
            {
                builder.Property(x => x.model).HasMaxLength(50).IsRequired();
                builder.Property(x => x.reg_numbers).HasMaxLength(12).IsRequired();
                builder.Property(x => x.id).ValueGeneratedOnAdd();

                builder.HasOne(x => x.Passangers)
                    .WithOne(x => x.Cars)
                    .HasForeignKey<Passangers>(x => x.car_id)
                    .HasForeignKey<Cars>(x => x.id);
            });

            modelBuilder.Entity<Passangers>().ToTable("passangers");
            modelBuilder.Entity<Passangers>(builder =>
            {
                builder.Property(x => x.use_on).IsRequired();
                builder.Property(x => x.address).HasMaxLength(150).IsRequired();
                builder.Property(x => x.id).ValueGeneratedOnAdd();
            });
        }
        */
    }

