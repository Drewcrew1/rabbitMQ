using Microsoft.Extensions.DependencyInjection;
using MicroR.Infra.Bus;
using MicroR.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Text;
using MicroR.Banking.Application.Interfaces;
using MicroR.Banking.Application.Services;
using MicroR.Banking.Domain.Interfaces;
using MicroR.Banking.Data.Repository;
using MicroR.Banking.Data.Context;
using MediatR;
using MicroR.Banking.Domain.Commands;
using MicroR.Banking.Domain.CommandHandlers;
using MicroR.Transfer.Application.Interfaces;
using MicroR.Transfer.Domain.Interfaces;
using MicroR.Transfer.Data.Repository;
using MicroR.Transfer.Data.Context;
using MicroR.Transfer.Domain.Events;
using MicroR.Transfer.Domain.EventHandlers;

namespace MicroR.Infra.IOC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //domain Bus
            services.AddSingleton<IEventBus, RabbitMQBus>(sp =>
            {
                var scopeFactory = sp.GetRequiredService<IServiceScopeFactory>();
                return new RabbitMQBus(sp.GetService<IMediator>(), scopeFactory);
            });

            //subscriptions
            services.AddTransient<TransferEventHandler>();

            //domain events
            services.AddTransient<IEventHandler<TransferCreatedEvent>, TransferEventHandler>();
            //domain banking commands
            services.AddTransient<IRequestHandler<CreateTransferCommand, bool>, TransferCommandHandler>();

            //application services
            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<ITransferService, TransferService>();
            //data
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<BankingDbContext>();
            services.AddTransient<ITransferRepository, TransferRepository>();
            services.AddTransient<TransferDbContext>();
        }
    }
}
