using System;
namespace GDLib.Singletons
{
    /// <summary> Allows other systems to access the derived classes of <see cref="LazySingleton{T}"/> through an enforced single instance. </summary>
    public abstract class LazySingleton<T> : Singleton<T> where T : class
    {
        /// Lazily initializes the instance of the class.
        private static readonly Lazy<T> instance = new Lazy<T>(() => CreateInstance());
        public static T Instance { get { return instance.Value; } }

        /// <summary> Constructor access is set to private to enforce Singleton pattern. </summary>
        private LazySingleton() { }
    }
}