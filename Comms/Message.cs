namespace GDLib.Comms
{
    /// <summary>
    /// Base Message to hold a simple header of the message type.
    /// </summary>
    public class Message
    {
        private string messageType;
        public string MessageType => messageType;
        public Message(string messageType)
            => this.messageType = messageType.ToLower();
    }
}
