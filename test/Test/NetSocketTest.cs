using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using SuperSocket;


namespace Tests
{
    public class NetSocketTest : TestBase
    {
        protected override void RegisterServices(IServiceCollection services)
        {
            services.UseNetSocketListener();
        }
    }
}
