using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextProcess.Database.Models
{
   
    public class Context : DbContext
    {
        private string _dbPath;

        public Context(string dbPath) : base(dbPath) { }

        public DbSet<Dictionary> dictionary { get; set; }

    }
}
