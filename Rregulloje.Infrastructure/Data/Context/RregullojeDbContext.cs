using Microsoft.EntityFrameworkCore;
using Rregulloje.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rregulloje.Infrastructure.Data.Context
{
    public class RregullojeDbContext : DbContext
    {
        public RregullojeDbContext(DbContextOptions options) : base(options)
        {
        }

        DbSet<Company> Companies { get; set; }
        DbSet<ContactUs> ContactUs { get; set; }
        DbSet<ExtraServices> ExtraServices { get; set; }
        DbSet<Issues> Issues { get; set; }
        DbSet<MiniService> MiniServices { get; set; }
        DbSet<Services> Services { get; set; }
        DbSet<ServiceType> ServiceTypes { get; set; }
    }
}
