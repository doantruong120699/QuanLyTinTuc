using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QuanLyTinTuc.Core.Models;

namespace QuanLyTinTuc.Core
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<TinTuc> TinTucs { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}