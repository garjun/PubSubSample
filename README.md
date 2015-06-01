#NSB Sample with publish/Subscribe pattern

The objective of the sample application is to illustrate how to use Publish/Subscribe pattern in NServiceBus

    Technologies used/required in this sample:    
    - NServiceBus 5.0    
	-NServiceBus.Nhibernate	   
    
Code Walkthrough
This sample contains four projects

    MyPublisher -A console application that hosts the instance of NServiceBus.
	 This project is a publisher of event messages. This uses the bus framework to send alternatively three different types of messages .
	 The created message is populated and published using Bus.Publish.
 Subscribers: 
    To receive a message from the publisher , the subscriber's must subscribe to a message type they are designed to handle.
	Subscriber1: 
		The Subscriber1 process handles and subscribes to both the EventMessage and AnotherEventMessage types.
		Subscriber1 uses the default auto-subscription feature of the bus where the the bus automatically sends subscription messages to the configured publisher.
	Subscriber2:
	The Subscriber2 handles and subscribes to any message implementing the interface IMyEvent.
	Subscriber2 explicitly disables the auto-subscribe feature in the Program.cs file. The subscriptions are therefore done explicitly at startup.
	
Shared: The shared project contains the definition of the message that are send between the processes.       
	
Follow below Steps to Execute /configure on local system
1:Download the solution 
2:Resolve the dependencies and try to build it.
3:Run/Debug the MyPublisher project , it will create the different private queues in MSMQ. The queue name starts with the publisher endpoint i.e Samples.PubSub.MyPublisher.
4:All the published messages will be stored in (samples.pubsub.mypublisher or subscriber queue if already created).
5:Now run/debug the subscriber1 , this will create a subscriber specific queues starting with 'samples.pubsub.subscriber1' name.
6:Follow the step 5 for the subscriber2
7:Verify the details of the MSMQ. 
 
 
