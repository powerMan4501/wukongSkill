using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace System.Dynamic.Utils;

internal static class CollectionExtensions
{
	internal static ReadOnlyCollection<T> ToReadOnly<T>(this IEnumerable<T> enumerable)
	{
		if (enumerable == null)
		{
			return EmptyReadOnlyCollection<T>.Instance;
		}
		if (enumerable is TrueReadOnlyCollection<T> result)
		{
			return result;
		}
		if (enumerable is ReadOnlyCollectionBuilder<T> readOnlyCollectionBuilder)
		{
			return readOnlyCollectionBuilder.ToReadOnlyCollection();
		}
		if (enumerable is ICollection<T> { Count: var count } collection)
		{
			if (count == 0)
			{
				return EmptyReadOnlyCollection<T>.Instance;
			}
			T[] array = new T[count];
			collection.CopyTo(array, 0);
			return new TrueReadOnlyCollection<T>(array);
		}
		return new TrueReadOnlyCollection<T>(new List<T>(enumerable).ToArray());
	}

	internal static int ListHashCode<T>(this IEnumerable<T> list)
	{
		EqualityComparer<T> equalityComparer = EqualityComparer<T>.Default;
		int num = 6551;
		foreach (T item in list)
		{
			num ^= (num << 5) ^ equalityComparer.GetHashCode(item);
		}
		return num;
	}

	internal static bool ListEquals<T>(this ICollection<T> first, ICollection<T> second)
	{
		if (first.Count != second.Count)
		{
			return false;
		}
		EqualityComparer<T> equalityComparer = EqualityComparer<T>.Default;
		IEnumerator<T> enumerator = first.GetEnumerator();
		IEnumerator<T> enumerator2 = second.GetEnumerator();
		while (enumerator.MoveNext())
		{
			enumerator2.MoveNext();
			if (!equalityComparer.Equals(enumerator.Current, enumerator2.Current))
			{
				return false;
			}
		}
		return true;
	}

	internal static IEnumerable<U> Select<T, U>(this IEnumerable<T> enumerable, Func<T, U> select)
	{
		foreach (T item in enumerable)
		{
			yield return select(item);
		}
	}

	internal static U[] Map<T, U>(this ICollection<T> collection, Func<T, U> select)
	{
		int count = collection.Count;
		U[] array = new U[count];
		count = 0;
		foreach (T item in collection)
		{
			array[count++] = select(item);
		}
		return array;
	}

	internal static IEnumerable<T> Where<T>(this IEnumerable<T> enumerable, Func<T, bool> where)
	{
		foreach (T item in enumerable)
		{
			if (where(item))
			{
				yield return item;
			}
		}
	}

	internal static bool Any<T>(this IEnumerable<T> source, Func<T, bool> predicate)
	{
		foreach (T item in source)
		{
			if (predicate(item))
			{
				return true;
			}
		}
		return false;
	}

	internal static bool All<T>(this IEnumerable<T> source, Func<T, bool> predicate)
	{
		foreach (T item in source)
		{
			if (!predicate(item))
			{
				return false;
			}
		}
		return true;
	}

	internal static T[] RemoveFirst<T>(this T[] array)
	{
		T[] array2 = new T[array.Length - 1];
		Array.Copy(array, 1, array2, 0, array2.Length);
		return array2;
	}

	internal static T[] RemoveLast<T>(this T[] array)
	{
		T[] array2 = new T[array.Length - 1];
		Array.Copy(array, 0, array2, 0, array2.Length);
		return array2;
	}

	internal static T[] AddFirst<T>(this IList<T> list, T item)
	{
		T[] array = new T[list.Count + 1];
		array[0] = item;
		list.CopyTo(array, 1);
		return array;
	}

	internal static T[] AddLast<T>(this IList<T> list, T item)
	{
		T[] array = new T[list.Count + 1];
		list.CopyTo(array, 0);
		array[list.Count] = item;
		return array;
	}

	internal static T First<T>(this IEnumerable<T> source)
	{
		if (source is IList<T> list)
		{
			return list[0];
		}
		using (IEnumerator<T> enumerator = source.GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				return enumerator.Current;
			}
		}
		throw new InvalidOperationException();
	}

	internal static T Last<T>(this IList<T> list)
	{
		return list[list.Count - 1];
	}

	internal static T[] Copy<T>(this T[] array)
	{
		T[] array2 = new T[array.Length];
		Array.Copy(array, array2, array.Length);
		return array2;
	}
}
