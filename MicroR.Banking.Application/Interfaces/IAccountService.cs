using MicroR.Banking.Application.Models;
using MicroR.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroR.Banking.Application.Interfaces
{
    public interface IAccountService
    {
        IEnumerable<Account> GetAccounts();
        void Transfer(AccountTransfer accountTransfer);

    }
}
