using System;
using System.Collections.Generic;
using System.Text;

namespace KBGDLib.Communicators
{
    /// <summary>
    /// Static library to hold a list of static message types. Good for keeping magic string literals out of the messaging system. 
    /// </summary>
    public static class MessageLibrary 
        {
            public static string RESOURCE_CHANGED = "ResourceChanged";
            public static string ENTITY_DIED = "EntityDied";
        }
}
