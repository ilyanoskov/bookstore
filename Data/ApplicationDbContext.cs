using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Bookstore1.Models;

namespace Bookstore1.Data
{
public class ApplicationDbContext : IdentityDbContext
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

            modelBuilder.Entity<Bookstore.Models.BookCategory>()
.HasKey(bc => new { bc.BookId, bc.CategoryId });

        modelBuilder.Entity<Bookstore.Models.BookCategory>()
            .HasOne(bc => bc.Book)
            .WithMany(b => b.BookCategories)
            .HasForeignKey(bc => bc.BookId);

        modelBuilder.Entity<Bookstore.Models.BookCategory>()
            .HasOne(bc => bc.Category)
            .WithMany(c => c.BookCategories)
            .HasForeignKey(bc => bc.CategoryId);

    }


}


}
