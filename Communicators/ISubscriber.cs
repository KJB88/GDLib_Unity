namespace KBGDLib.Comms
{
    public interface ISubscriber // Allows subscription to specific messages via the MessageBroker
    {
        /// <summary>
        /// Act on a received message that the class is subscribed to.
        /// </summary>
        /// <param name="msg">string: The message.</param>
        /// <returns>Bool: Consume message if true. Passthrough message if false.</returns>
        public bool Receive(string msg);
    }
}