using MicroR.Transfer.Data.Context;
using MicroR.Transfer.Domain.Interfaces;
using MicroR.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroR.Transfer.Data.Repository
{
    public class TransferRepository : ITransferRepository
    {
        private TransferDbContext _ctx;
        
        public TransferRepository(TransferDbContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _ctx.TransferLogs;
        }

        public void Add(TransferLog transferLog)
        {
            _ctx.TransferLogs.Add(transferLog);
            _ctx.SaveChanges();
        }
    }
}
