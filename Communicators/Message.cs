namespace KBGDLib.Communicators
{
    public abstract class Message
    {
        private string messageType;
        public string MessageType => messageType;
        public Message(string messageType)
            => this.messageType = messageType.ToLower();
    }
}
