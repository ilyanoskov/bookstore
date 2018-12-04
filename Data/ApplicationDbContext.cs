using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Bookstore.Models;

namespace Bookstore.Data
{
public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {}

    public DbSet<Bookstore.Models.Book> Book { get; set; }
    public DbSet<Bookstore.Models.Category> Category { get; set; }
    public DbSet<Bookstore.Models.Manager> Manager { get; set; }
    


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<ApplicationUser>(
            //  typeBuilder =>
            //  {
            //      typeBuilder.HasMany(host => host.Basket)
            //          .WithOne(guest => guest.ApplicationUser)
            //          .HasForeignKey(guest => guest.ApplicationUserId)
            //          .IsRequired();

                
            //});

            //modelBuilder.Entity<Book>(
            //    typeBuilder =>
            //    {
            //        typeBuilder.HasOne(guest => guest.ApplicationUser)
            //            .WithMany(host => host.Basket)
            //            .HasForeignKey(guest => guest.ApplicationUserId)
            //            .IsRequired();

                
            //});
        }
    }


}
