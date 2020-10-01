using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Rregulloje.Domain.Models;

namespace Rregulloje.Domain.Context
{
    public partial class ApplicationDbContext : IdentityDbContext
    {

        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }

        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<ContactUs> ContactUs { get; set; }
        public virtual DbSet<Issue> Issue { get; set; }
        public virtual DbSet<ServiceType> ServiceType { get; set; }
        public virtual DbSet<MinServices> MinServices { get; set; }
        public virtual DbSet<Services> Services { get; set; }
        public virtual DbSet<ExtraServices> ExtraServices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__Company__Id");

                entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(20);

                entity.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(1000);
            });

            modelBuilder.Entity<ContactUs>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_ContactUs_Id");

                entity.Property(e => e.Name)
                      .IsRequired()
                      .HasMaxLength(50);
            });

            modelBuilder.Entity<Issue>(entity =>
            {
                entity.HasKey(e => e.Id)
                      .HasName("PK_Issue_Id");

                entity.Property(e => e.Name)
                      .IsRequired()
                      .HasMaxLength(20);

                entity.Property(e => e.LastName)
                      .IsRequired()
                      .HasMaxLength(20);

                entity.Property(e => e.PhoneNumber)
                      .IsRequired()
                      .HasMaxLength(30);

                entity.Property(e => e.Email)
                      .IsRequired()
                      .HasMaxLength(50);

                entity.Property(e => e.LivingObject)
                      .IsRequired();

                entity.Property(e => e.LivingEntryNumber)
                      .IsRequired();

                entity.Property(e => e.AppartmentNumber)
                      .IsRequired();

                entity.Property(e => e.IssueSubject)
                      .HasMaxLength(100);

                entity.Property(e => e.Message)
                      .IsRequired()
                      .HasMaxLength(500);
            });

            modelBuilder.Entity<ServiceType>(entity =>
            {
                entity.HasKey(e => e.Id)
                      .HasName("PK_ServiceType_Id");

                entity.Property(e => e.Name)
                      .IsRequired()
                      .HasMaxLength(20);

            });

            modelBuilder.Entity<ServiceType>()
            .HasOne(p => p.MinService)
            .WithMany()
            .HasForeignKey(p => p.MinServiceId)
            .HasConstraintName("FK_ServiceType_MinServiceId");

            modelBuilder.Entity<MinServices>(entity =>
            {
                entity.HasKey(e => e.Id)
                      .HasName("PK_MinService_Id");

                entity.Property(e => e.Name)
                      .HasMaxLength(100);

                entity.Property(e => e.Description)
                      .HasMaxLength(800);
            });

            modelBuilder.Entity<MinServices>()
            .HasOne(p => p.ServiceType)
            .WithMany()
            .HasForeignKey(p => p.ServiceTypeId)
            .HasConstraintName("FK_ServiceType_ServiceTypeId");

            modelBuilder.Entity<ExtraServices>(entity =>
            {
                entity.HasKey(e => e.Id)
                      .HasName("PK_ExtraServices_Id");

                entity.Property(e => e.Description)
                      .HasMaxLength(1000);

                entity.Property(e => e.Price)
                      .IsRequired();
            });

            modelBuilder.Entity<Services>(entity =>
            {
                entity.HasKey(e => e.Id)
                      .HasName("PK_Services_Id");

                entity.Property(e => e.Name)
                      .HasMaxLength(100);

                entity.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(1000);

            });

            modelBuilder.Entity<Services>()
            .HasOne(p => p.MinService)
            .WithMany()
            .HasForeignKey(p => p.MinServiceId)
            .HasConstraintName("FK_Services_MinServiceId");

            base.OnModelCreating(modelBuilder);

            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
