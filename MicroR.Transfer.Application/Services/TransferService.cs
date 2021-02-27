using MicroR.Transfer.Application.Interfaces;
using MicroR.Transfer.Domain.Interfaces;
using MicroR.Transfer.Domain.Models;
using MicroR.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroR.Banking.Application.Services
{
    public class TransferService : ITransferService
    {
        private readonly ITransferRepository _transferRepository;
        private readonly IEventBus _bus;

        public TransferService(ITransferRepository transferRepository, IEventBus bus)
        {
            _transferRepository = transferRepository;
            _bus = bus;
        }
        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _transferRepository.GetTransferLogs();
        }

        
    }
}
