using MicroR.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroR.Transfer.Domain.Interfaces
{
    public interface ITransferRepository
    {
        IEnumerable<TransferLog> GetTransferLogs();
        void Add(TransferLog transferLog);
    }
}
