using System;

namespace GDLib.Singletons
{
    /// <summary> Base Singleton that holds common data for all Singletons. </summary>
    /// <include file='../Docs/Singletons.xml' path='doc/members/member[@name="GDLib.Singletons.Singleton"]/*'/>
    public abstract class Singleton<T> where T : class
    {
        /// <summary> Creates an instance of the given class with type <typeparamref name="T"/>. </summary>
        /// <include file='../Docs/Singletons.xml' path='doc/members/member[@name="GDLib.Singletons.Singleton.CreateInstance"]/*'/>
        protected static T CreateInstance()
            => Activator.CreateInstance(typeof(T), nonPublic: true) as T;
    }
}
