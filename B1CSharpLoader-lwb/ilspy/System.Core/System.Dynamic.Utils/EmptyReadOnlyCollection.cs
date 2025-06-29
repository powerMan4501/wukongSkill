using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace System.Dynamic.Utils;

internal static class EmptyReadOnlyCollection<T>
{
	internal static ReadOnlyCollection<T> Instance = new TrueReadOnlyCollection<T>(new T[0]);
}
