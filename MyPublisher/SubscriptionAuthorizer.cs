using System.Collections.Generic;
using NServiceBus;

#region SubscriptionAuthorizer
/// <summary>
/// We can control the subscription recived using this class
/// </summary>
public class SubscriptionAuthorizer : IAuthorizeSubscriptions
{
    public bool AuthorizeSubscribe(string messageType, string clientEndpoint, IDictionary<string, string> headers)
    {//subscribr authorization logic/check  goes here 
        return true;
    }

    public bool AuthorizeUnsubscribe(string messageType, string clientEndpoint, IDictionary<string, string> headers)
    {
        //subscribr unauthorization logic/check  goes here 
        return true;
    }
}
#endregion