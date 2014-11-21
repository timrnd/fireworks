﻿using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Microsoft.AspNet.SignalR;

[assembly: OwinStartup(typeof(Firework.Startup))]

namespace Firework
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
            //GlobalHost.DependencyResolver.UseRedis("[Redis cache cluster]",6379,"[access key]","Fireworks");
            //GlobalHost.DependencyResolver.UseServiceBus("Endpoint=sb://xxxx.servicebus.windows.net/;SharedSecretIssuer=owner;SharedSecretValue=XXXXXXXX","Fireworks");
            app.MapSignalR();
            
        }
    }
}
