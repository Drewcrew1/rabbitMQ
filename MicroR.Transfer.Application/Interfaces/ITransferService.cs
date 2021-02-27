
using MicroR.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroR.Transfer.Application.Interfaces
{
    public interface ITransferService
    {
        IEnumerable<TransferLog> GetTransferLogs();
        
    }
}
