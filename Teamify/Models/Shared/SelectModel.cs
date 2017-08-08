namespace Teamify.Models.Shared
{
    /// <summary>
    /// Generic class for Key-Value pairs usage.
    /// </summary>
    /// <typeparam name="T">Text property type.</typeparam>
    /// <typeparam name="V">Value property type.</typeparam>
    public class SelectModel<T, V>
    {
        public SelectModel() {}
        public SelectModel(T text) { Text = text; }
        public SelectModel(V value) { Value = value; }
        public SelectModel(T text, V value) { Text = text; Value = value; }

        public T Text { get; set; }
        public V Value { get; set; }
    }
}