using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace NHL.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<NHLDbContext>
    {
        public NHLDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<NHLDbContext>();
            var connectionString = "server=162.144.12.227;database=jose_NHL;user=jose_admin;password=Baltimore_123!";
            builder.UseMySQL(connectionString);
            return new NHLDbContext(builder.Options);
        }
    }
}