using MicroR.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroR.Banking.Domain.Interfaces
{
    public interface IAccountRepository
    {
        IEnumerable<Account> GetAccounts();
    }
}
