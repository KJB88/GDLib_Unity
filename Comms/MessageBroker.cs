using System.Collections.Generic;

namespace GDLib.Comms
{
    /// <summary>
    /// Allows messages to be passed between sender and receiver without coupling the systems together.
    /// </summary>
    public class MessageBroker 
    {
        /// <summary> Registry of subscribers, categorized by the message they are interested in. </summary>
        readonly Dictionary<string, List<ISubscriber>> subscribers = new Dictionary<string, List<ISubscriber>>();

        /// <summary> Register a subscriber to receive messages of the given message type. </summary>
        /// <include file="../Docs/Comms.xml" path='doc/members/member[@name="GDLib.Comms.MessageBroker.RegisterSubscriber"]/*'/>
        public void RegisterSubscriber(string messageType, ISubscriber subscriber)
        {
            messageType = messageType.ToLower();
            if (!subscribers.ContainsKey(messageType))
                subscribers.Add(messageType, new List<ISubscriber> { subscriber });
            else
                subscribers[messageType].Add(subscriber);
        }

        /// <summary> Unregister the subscriber from receiving the given message type. </summary>
        /// <include file="../Docs/Comms.xml" path='doc/members/member[@name="GDLib.Comms.MessageBroker.UnregisterSubscriber"]/*'/>
        public void UnregisterSubscriber(string messageType, ISubscriber subscriber)
        {
            messageType = messageType.ToLower();
            if (!subscribers.ContainsKey(messageType))
                return;

            subscribers[messageType].Remove(subscriber);
        }

        /// <summary> Send a message to all subsrcibers based on its internal message type. </summary>
        /// <include file="../Docs/Comms.xml" path='doc/members/member[@name="GDLib.Comms.MessageBroker.SendMessage"]/*'/>
        public void SendMessage(Message message)
        {
            if (!subscribers.ContainsKey(message.MessageType))
                return;

            foreach (ISubscriber subscriber in subscribers[message.MessageType])
            {
                if (subscriber.Receive(message))
                    return;
            }
        }
    };
}