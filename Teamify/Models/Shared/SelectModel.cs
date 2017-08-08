namespace Teamify.Models.Shared
{
    /// <summary>
    /// Generic class for Key-Value pairs usage.
    /// </summary>
    /// <typeparam name="T">Text property type.</typeparam>
    /// <typeparam name="V">Value property type.</typeparam>
    public class SelectModel<T, V>
    {
        public T Text { get; set; }
        public V Value { get; set; }
    }
}