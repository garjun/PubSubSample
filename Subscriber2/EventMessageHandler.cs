using System;
using NServiceBus;
/// <summary>
/// Handler for the MyEvent event
/// </summary>
public class EventMessageHandler : IHandleMessages<IMyEvent>
{
    public void Handle(IMyEvent message)
    {
        Console.WriteLine("Subscriber 2 received IEvent with Id {0}.", message.EventId);
        Console.WriteLine("Message time: {0}.", message.Time);
        Console.WriteLine("Message duration: {0}.", message.Duration);
    }
}