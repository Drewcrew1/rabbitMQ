using MicroR.Banking.Application.Interfaces;
using MicroR.Banking.Application.Models;
using MicroR.Banking.Domain.Commands;
using MicroR.Banking.Domain.Interfaces;
using MicroR.Banking.Domain.Models;
using MicroR.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroR.Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IEventBus _bus;

        public AccountService(IAccountRepository accountRepository, IEventBus bus)
        {
            _accountRepository = accountRepository;
            _bus = bus;
        }
        public IEnumerable<Account> GetAccounts()
        {
            return _accountRepository.GetAccounts();
        }


        public void Transfer(AccountTransfer accountTransfer)
        {
            var createTransferCommand = new CreateTransferCommand(
                accountTransfer.FromAccount,
                accountTransfer.ToAccount,
                accountTransfer.TransferAmount
                );

            _bus.SendCommand(createTransferCommand);
        }
    }
}
