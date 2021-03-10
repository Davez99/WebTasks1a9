using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WbEx1a9.Models;

namespace WbEx1a9.Data
{
    public class ExerciciosContext : DbContext
    {
        public ExerciciosContext (DbContextOptions<ExerciciosContext> options)
            : base(options)
        {
        }

        public DbSet<WbEx1a9.Models.Ex01ViewModel> Ex01 { get; set; }

        public DbSet<WbEx1a9.Models.Ex03ViewModel> Ex03ViewModel { get; set; }

        public DbSet<WbEx1a9.Models.Ex02viewmodel> Ex02viewmodel { get; set; }

        public DbSet<WbEx1a9.Models.Ex04ViewModel> Ex04ViewModel { get; set; }

        public DbSet<WbEx1a9.Models.Ex05ViewModel> Ex05ViewModel { get; set; }

        public DbSet<WbEx1a9.Models.Ex06ViewModel> Ex06ViewModel { get; set; }

        public DbSet<WbEx1a9.Models.Ex07ViewModel> Ex07ViewModel { get; set; }

        public DbSet<WbEx1a9.Models.Ex08ViewModel> Ex08ViewModel { get; set; }

        public DbSet<WbEx1a9.Models.Ex09ViewModel> Ex09ViewModel { get; set; }
    }
}
