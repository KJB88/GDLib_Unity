namespace GDLib.Helpers
{
    public static class CoreHelper
    {
        public static bool IsNullable<T>(T _)
            => default(T) == null;

        public static bool IsNullableValueType<T>(T _)
        => default(T) == null && typeof(T).BaseType != null && "ValueType".Equals(typeof(T).BaseType.Name);
    }
}
