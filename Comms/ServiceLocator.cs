using System;
using System.Collections.Generic;

namespace GDLib.Comms
{
    /// <summary>
    /// Allows scoped systems to request access to a scoped services without coupling services directly to systems.
    /// </summary>
    public static class ServiceLocator
    {
        /// <summary>
        /// The service registry that holds all services that have registered with the <see cref="ServiceLocator"/>.<para/>
        /// <typeparamref name="TKey"/> is specified by the <see cref="Type"/> of the service. This is attained via <see langword="typeof"/>(<typeparamref name="T"/>) in relevant methods.<br/>
        /// <typeparamref name="TValue"/> is the service itself, upcast to <see langword="object"/>.
        /// </summary>
        static readonly Dictionary<Type, object> serviceRegistry = new Dictionary<Type, object>();

        /// <summary> Register the service with the service locator, using its type as the key. </summary>
        /// <include file='../Docs/Comms.xml' path='doc/members/member[@name="GDLib.Comms.ServiceLocator.RegisterService"]/*'/>
        public static bool RegisterService<T>(T service)
        {
            if (serviceRegistry.ContainsKey(typeof(T)))    
                return false;                                   

            serviceRegistry.Add(typeof(T), service);       
            return true;
        }

        /// <summary> Unregister a service from the service locator, specified by its type. </summary>
        /// <include file='../Docs/Comms.xml' path='doc/members/member[@name="GDLib.Comms.ServiceLocator.UnregisterService"]/*'/>
        public static bool UnregisterService<T>()
            => serviceRegistry.Remove(typeof(T));

        /// <summary> Replace a service already registered with the service locator with the given service. </summary>
        /// <include file='../Docs/Comms.xml' path='doc/members/member[@name="GDLib.Comms.ServiceLocator.ReplaceService"]/*'/>
        public static bool ReplaceService<T>(T service)
        {
            if (!serviceRegistry.ContainsKey(typeof(T)))
                return false;

            serviceRegistry[typeof(T)] = service;
            return true;
        }

        /// <summary> Attempts to locate the service within the service locator and, if found, assigns it to the out parameter. </summary>
        /// <include file='../Docs/Comms.xml' path='doc/members/member[@name="GDLib.Comms.ServiceLocator.GetService"]/*'/>
        public static bool GetService<T>(out T service)
        {
            service = default;
            if (!serviceRegistry.ContainsKey(typeof(T)))
                return false;

            service = (T)serviceRegistry[typeof(T)];
            return true;
        }
    }
}