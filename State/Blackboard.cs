using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace GDLib.StateHandling
{
    /// <summary>
    /// Blackboard is a wrapper for System.Collections.Generic.Dictionary that reduces verbosity.
    /// </summary>
    public class Blackboard
    {
        /// The collection of resources, upcast to object and paired by Type. 
        private readonly Dictionary<Type, object> blackboard = new Dictionary<Type, object>();

        /// <summary> Does the blackboard contain a key at the given type? </summary>
        /// <include file='../Docs/StateHandling.xml' path='doc/members/member[@name="GDLib.StateHandling.Blackboard.ContainsKey"]/*'/>
        public bool ContainsKey<T>(T _) => blackboard.ContainsKey(typeof(T));

        /// <summary> Set a value to the Blackboard using its type as a key. Can force replace of existing value at the given key. </summary>
        /// <include file='../Docs/StateHandling.xml' path='doc/members/member[@name="GDLib.StateHandling.Blackboard.SetValue"]/*'/>
        public bool SetValue<T>(T obj, bool forceReplace = false)
        {
            if (!blackboard.ContainsKey(typeof(T)))
            {
                blackboard.Add(typeof(T), obj);
                return true;
            }
            else if (forceReplace) // Reassign
            {
                blackboard[typeof(T)] = obj;
                return true;
            }

            return false;
        }

        /// <summary> Replaces the value held within the blackboard with the given value if it exists.</summary>
        /// <include file='../Docs/StateHandling.xml' path='doc/members/member[@name="GDLib.StateHandling.Blackboard.ReplaceValue"]/*'/>
        public bool ReplaceValue<T>(T obj)
        {
            if (!blackboard.ContainsKey(typeof(T)))
                return false;

            blackboard[typeof(T)] = obj;
            return true;
        }

        /// <summary> Tries to get the value specified by the out argument's type. </summary>
        /// <include file='../Docs/StateHandling.xml' path='doc/members/member[@name="GDLib.StateHandling.Blackboard.TryGetValue"]/*'/>
        public bool TryGetValue<T>(out T obj)
        {
            obj = default;
            if (!blackboard.ContainsKey(typeof(T)))
                return false;

            obj = (T)blackboard[typeof(T)];
            return true;
        }
    }

}