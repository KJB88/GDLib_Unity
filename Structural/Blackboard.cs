using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace KBGDLib.Structural
{



    // The entire blackboard is an approach similar to Blackboards used when developing BehaviourTrees, ideally this would hold wrapped classes via polymorphism (EG: EntityTransform : BlackboardEntry).
    public class Blackboard 
    {
        private Dictionary<string, object> blackboard = new Dictionary<string, object>();

        public object this[string key]
        {
            private get => blackboard[key]; // Risk of null reference
            set => blackboard[key] = value;
        }

        public bool ContainsKey(string key) => blackboard.ContainsKey(key);

        public bool TryGetValue<T>(string key, out T var)
        {
            var = default;

                if (!blackboard.ContainsKey(key))
                    return false;

                if (blackboard[key] is T t)
                {
                    var = t;
                    return true;
                }

                return false;
        }
    }

}