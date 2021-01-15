using GlobalGamesCET49.Data.Enteties;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GlobalGamesCET49.Data
{

    public class DataContext : DbContext
    {

        public DbSet<Contact> Contacts { get; set; }


        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }
}
