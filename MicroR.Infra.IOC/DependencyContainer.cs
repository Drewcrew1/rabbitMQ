using Microsoft.Extensions.DependencyInjection;
using MicroR.Infra.Bus;
using MicroR.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroR.Infra.IOC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //domain Bus
            services.AddTransient<IEventBus, RabbitMQBus>();
        }
    }
}
