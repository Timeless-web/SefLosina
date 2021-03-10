using ILHO.DOMAIN;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILHO.PERSISTENCE
{
    public class DataContext : DbContext

    {
        public DataContext([NotNullAttribute] DbContextOptions options) : base(options)
        {

        }

        public DbSet<Activity> Activities { get; set; }
    }

}
