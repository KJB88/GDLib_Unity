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

        /// <summary>
        /// Register the <paramref name="service"/> with the <see cref="ServiceLocator"/>'s service registry, using its <see cref="Type"/> as the key.<para/>
        /// For replacing an existing service, use <see cref="ReplaceService{T}(T)"/>.<br/>
        /// </summary>
        /// <param name="service">The service to register with the <see cref="ServiceLocator"/>.</param>
        /// <returns><see langword="true"/> if the <paramref name="service"/> was successfully registered; otherwise, <see langword="false"/>.</returns>
        public static bool RegisterService<T>(T service)
        {
            if (serviceRegistry.ContainsKey(typeof(T)))    
                return false;                                   

            serviceRegistry.Add(typeof(T), service);       
            return true;
        }

        /// <summary>
        /// Unregister a service from the <see cref="ServiceLocator"/>'s service registry, specified by its <see cref="Type"/>.<para/>
        /// /// For replacing an existing service, use <see cref="ReplaceService{T}(T)"/>.
        /// </summary>
        /// <returns><see langword="true"/> if the service was successfully removed; otherwise, <see langword="false"/>.</returns>
        public static bool UnregisterService<T>()
            => serviceRegistry.Remove(typeof(T));

        /// <summary>
        /// Replace a service already registered with the <see cref="ServiceLocator"/> with the given <paramref name="service"/>.<br/>
        /// An explicit way to reassign a service.<para/> 
        /// For registering a new service, use <see cref="RegisterService{T}(T)"/>.<br/>
        /// For unregistering an existing service, use <see cref="UnregisterService{T}"/>.
        /// </summary>
        /// <param name="service">The service that will replace the value within the registry, located at <see langword="typeof"/>.</param>
        /// <returns><see langname="true"/> if the service was successfully replaced. Else, returns <see langword="false"/>.</returns>
        public static bool ReplaceService<T>(T service)
        {
            if (!serviceRegistry.ContainsKey(typeof(T)))
                return false;

            serviceRegistry[typeof(T)] = service;
            return true;
        }

        /// <summary> 
        /// Attempts to locate the <paramref name="service"/> within the <see cref="ServiceLocator"/>'s registry and, if found, assigns it to the <see langword="out"/> parameter. 
        /// </summary>
        /// <param name="service">The service to return to caller, located by its <see cref="Type"/>.</param>
        /// <returns> <see langword="true"/> if the <see cref="ServiceLocator"/>'s registry holds a service of the given <see cref="Type"/>. 
        /// Else, returns <see langword="false"/>.</returns>
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