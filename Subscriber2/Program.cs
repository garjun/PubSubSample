using System;
using NServiceBus;
using NServiceBus.Features;
using NServiceBus.Logging;

static class Program
{
    static void Main()
    {
        LogManager.Use<DefaultFactory>().Level(LogLevel.Info);
        BusConfiguration busConfiguration = new BusConfiguration();
        busConfiguration.EndpointName("Samples.PubSub.Subscriber2");
        busConfiguration.UseSerialization<JsonSerializer>();
        //explicitly disable the AutoSubscribe feature 
        busConfiguration.DisableFeature<AutoSubscribe>();
        busConfiguration.UsePersistence<InMemoryPersistence>();
        busConfiguration.EnableInstallers();
        IStartableBus startableBus = Bus.Create(busConfiguration);
        using (IBus bus = startableBus.Start())
        {
            //subscribe explicitly at startup.
            bus.Subscribe<IMyEvent>();
            Console.WriteLine("To exit, Ctrl + C");
            Console.ReadLine();
            bus.Unsubscribe<IMyEvent>();
        }
    }
}