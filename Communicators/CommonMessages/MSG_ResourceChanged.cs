using UnityEngine;

namespace KBGDLib.Communicators.CommonMessages
{
    public class MSG_ResourceChanged : Message
    {
        public struct DATA_ResourceChanged
        {
            public GameObject targetObject;
            public string resourceType;
            public float newValue;
        }

        DATA_ResourceChanged payload;
        public DATA_ResourceChanged Payload => payload;

        public MSG_ResourceChanged(string messageType, DATA_ResourceChanged payload)
            : base(messageType) => this.payload = payload;
    }


}
