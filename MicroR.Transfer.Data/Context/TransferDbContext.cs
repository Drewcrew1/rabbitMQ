using MicroR.Transfer.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroR.Transfer.Data.Context
{
    public class TransferDbContext : DbContext
    {
        public TransferDbContext(DbContextOptions options): base(options)
        {

        }
        public DbSet<TransferLog> TransferLogs {  get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
          => options.UseSqlite("Data Source=sqliterabbit.db");
    }
}
