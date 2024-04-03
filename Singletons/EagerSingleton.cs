using System;
namespace GDLib.Singletons
{
    /// <summary> Allows other systems to access the derived classes of <see cref="EagerSingleton{T}"/> through an enforced single instance. </summary>
    public abstract class EagerSingleton<T> : Singleton<T> where T : class
    {
        /// <summary> Eagerly initializes the instance of the class. </summary>
        private static readonly T instance = CreateInstance();
        public static T Instance => instance;

        /// <summary> Constructor access is set to private to enforce Singleton pattern. </summary>
        private EagerSingleton() { }
    }
}