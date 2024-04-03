namespace GDLib.Comms
{
    /// <summary>
    /// Allows subscription to specific messages via the MessageBroker.
    /// </summary>
    public interface ISubscriber 
    {

        /// <summary>Handle a message for which the subscriber is registered to receive.</summary>
        /// <include file="../Docs/Comms.xml" path='doc/members/member[@name="GDLib.Comms.ISubscriber.Receive"]/*'/>
        public bool Receive(Message msg);
    }
}