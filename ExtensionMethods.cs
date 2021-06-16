using System;
using System.Collections.Generic;
using System.Linq;

namespace Command
{
    public static class ExtensionMethods
    {
        public static List<T> AsList<T>(this IEnumerable<T> enumerable) =>
        enumerable is List<T> listT
            ? listT
            : enumerable.ToList();
        public static IReadOnlyCollection<T> AsReadOnlyList<T>(this IEnumerable<T> ienumerable)
        => (ienumerable ?? Enumerable.Empty<T>()).AsList().AsReadOnly();
    }

    public class InvalidRecursiveOperationException : InvalidOperationException
    {
        public InvalidRecursiveOperationException(string message) : base(message) { }
        public static InvalidRecursiveOperationException Create() => new InvalidRecursiveOperationException("I am going to throw Stack Over Flow Exception");
    }
}
