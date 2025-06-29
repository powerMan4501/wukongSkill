using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security;
using System.StubHelpers;

namespace System;

internal static class Internal
{
	private static void CommonlyUsedGenericInstantiations()
	{
		Array.Sort<double>(null);
		Array.Sort<int>(null);
		Array.Sort<IntPtr>(null);
		new ArraySegment<byte>(new byte[1], 0, 0);
		new Dictionary<char, object>();
		new Dictionary<Guid, byte>();
		new Dictionary<Guid, object>();
		new Dictionary<Guid, Guid>();
		new Dictionary<short, IntPtr>();
		new Dictionary<int, byte>();
		new Dictionary<int, int>();
		new Dictionary<int, object>();
		new Dictionary<IntPtr, bool>();
		new Dictionary<IntPtr, short>();
		new Dictionary<object, bool>();
		new Dictionary<object, char>();
		new Dictionary<object, Guid>();
		new Dictionary<object, int>();
		new Dictionary<object, long>();
		new Dictionary<uint, WeakReference>();
		new Dictionary<object, uint>();
		new Dictionary<uint, object>();
		new Dictionary<long, object>();
		new Dictionary<MemberTypes, object>();
		new EnumEqualityComparer<MemberTypes>();
		new Dictionary<object, KeyValuePair<object, object>>();
		new Dictionary<KeyValuePair<object, object>, object>();
		NullableHelper<bool>();
		NullableHelper<byte>();
		NullableHelper<char>();
		NullableHelper<DateTime>();
		NullableHelper<decimal>();
		NullableHelper<double>();
		NullableHelper<Guid>();
		NullableHelper<short>();
		NullableHelper<int>();
		NullableHelper<long>();
		NullableHelper<float>();
		NullableHelper<TimeSpan>();
		NullableHelper<DateTimeOffset>();
		new List<bool>();
		new List<byte>();
		new List<char>();
		new List<DateTime>();
		new List<decimal>();
		new List<double>();
		new List<Guid>();
		new List<short>();
		new List<int>();
		new List<long>();
		new List<TimeSpan>();
		new List<sbyte>();
		new List<float>();
		new List<ushort>();
		new List<uint>();
		new List<ulong>();
		new List<IntPtr>();
		new List<KeyValuePair<object, object>>();
		new List<GCHandle>();
		new List<DateTimeOffset>();
		new KeyValuePair<char, ushort>('\0', 0);
		new KeyValuePair<ushort, double>(0, double.MinValue);
		new KeyValuePair<object, int>(string.Empty, int.MinValue);
		new KeyValuePair<int, int>(int.MinValue, int.MinValue);
		SZArrayHelper<bool>(null);
		SZArrayHelper<byte>(null);
		SZArrayHelper<DateTime>(null);
		SZArrayHelper<decimal>(null);
		SZArrayHelper<double>(null);
		SZArrayHelper<Guid>(null);
		SZArrayHelper<short>(null);
		SZArrayHelper<int>(null);
		SZArrayHelper<long>(null);
		SZArrayHelper<TimeSpan>(null);
		SZArrayHelper<sbyte>(null);
		SZArrayHelper<float>(null);
		SZArrayHelper<ushort>(null);
		SZArrayHelper<uint>(null);
		SZArrayHelper<ulong>(null);
		SZArrayHelper<DateTimeOffset>(null);
		SZArrayHelper<CustomAttributeTypedArgument>(null);
		SZArrayHelper<CustomAttributeNamedArgument>(null);
	}

	private static T NullableHelper<T>() where T : struct
	{
		Nullable.Compare<T>(null, null);
		Nullable.Equals<T>(null, null);
		return ((T?)null).GetValueOrDefault();
	}

	private static void SZArrayHelper<T>(SZArrayHelper oSZArrayHelper)
	{
		oSZArrayHelper.get_Count<T>();
		oSZArrayHelper.get_Item<T>(0);
		oSZArrayHelper.GetEnumerator<T>();
	}

	[SecurityCritical]
	private static void CommonlyUsedWinRTRedirectedInterfaceStubs()
	{
		WinRT_IEnumerable<byte>(null, null, null);
		WinRT_IEnumerable<char>(null, null, null);
		WinRT_IEnumerable<short>(null, null, null);
		WinRT_IEnumerable<ushort>(null, null, null);
		WinRT_IEnumerable<int>(null, null, null);
		WinRT_IEnumerable<uint>(null, null, null);
		WinRT_IEnumerable<long>(null, null, null);
		WinRT_IEnumerable<ulong>(null, null, null);
		WinRT_IEnumerable<float>(null, null, null);
		WinRT_IEnumerable<double>(null, null, null);
		WinRT_IEnumerable<string>(null, null, null);
		typeof(IIterable<string>).ToString();
		typeof(IIterator<string>).ToString();
		WinRT_IEnumerable<object>(null, null, null);
		typeof(IIterable<object>).ToString();
		typeof(IIterator<object>).ToString();
		WinRT_IList<int>(null, null, null, null);
		WinRT_IList<string>(null, null, null, null);
		typeof(IVector<string>).ToString();
		WinRT_IList<object>(null, null, null, null);
		typeof(IVector<object>).ToString();
		WinRT_IReadOnlyList<int>(null, null, null);
		WinRT_IReadOnlyList<string>(null, null, null);
		typeof(IVectorView<string>).ToString();
		WinRT_IReadOnlyList<object>(null, null, null);
		typeof(IVectorView<object>).ToString();
		WinRT_IDictionary<string, int>(null, null, null, null);
		typeof(IMap<string, int>).ToString();
		WinRT_IDictionary<string, string>(null, null, null, null);
		typeof(IMap<string, string>).ToString();
		WinRT_IDictionary<string, object>(null, null, null, null);
		typeof(IMap<string, object>).ToString();
		WinRT_IDictionary<object, object>(null, null, null, null);
		typeof(IMap<object, object>).ToString();
		WinRT_IReadOnlyDictionary<string, int>(null, null, null, null);
		typeof(IMapView<string, int>).ToString();
		WinRT_IReadOnlyDictionary<string, string>(null, null, null, null);
		typeof(IMapView<string, string>).ToString();
		WinRT_IReadOnlyDictionary<string, object>(null, null, null, null);
		typeof(IMapView<string, object>).ToString();
		WinRT_IReadOnlyDictionary<object, object>(null, null, null, null);
		typeof(IMapView<object, object>).ToString();
		WinRT_Nullable<bool>();
		WinRT_Nullable<byte>();
		WinRT_Nullable<int>();
		WinRT_Nullable<uint>();
		WinRT_Nullable<long>();
		WinRT_Nullable<ulong>();
		WinRT_Nullable<float>();
		WinRT_Nullable<double>();
	}

	[SecurityCritical]
	private static void WinRT_IEnumerable<T>(IterableToEnumerableAdapter iterableToEnumerableAdapter, EnumerableToIterableAdapter enumerableToIterableAdapter, IIterable<T> iterable)
	{
		iterableToEnumerableAdapter.GetEnumerator_Stub<T>();
		enumerableToIterableAdapter.First_Stub<T>();
	}

	[SecurityCritical]
	private static void WinRT_IList<T>(VectorToListAdapter vectorToListAdapter, VectorToCollectionAdapter vectorToCollectionAdapter, ListToVectorAdapter listToVectorAdapter, IVector<T> vector)
	{
		WinRT_IEnumerable<T>(null, null, null);
		vectorToListAdapter.Indexer_Get<T>(0);
		vectorToListAdapter.Indexer_Set(0, default(T));
		vectorToListAdapter.Insert(0, default(T));
		vectorToListAdapter.RemoveAt<T>(0);
		vectorToCollectionAdapter.Count<T>();
		vectorToCollectionAdapter.Add(default(T));
		vectorToCollectionAdapter.Clear<T>();
		listToVectorAdapter.GetAt<T>(0u);
		listToVectorAdapter.Size<T>();
		listToVectorAdapter.SetAt(0u, default(T));
		listToVectorAdapter.InsertAt(0u, default(T));
		listToVectorAdapter.RemoveAt<T>(0u);
		listToVectorAdapter.Append(default(T));
		listToVectorAdapter.RemoveAtEnd<T>();
		listToVectorAdapter.Clear<T>();
	}

	[SecurityCritical]
	private static void WinRT_IReadOnlyCollection<T>(VectorViewToReadOnlyCollectionAdapter vectorViewToReadOnlyCollectionAdapter)
	{
		WinRT_IEnumerable<T>(null, null, null);
		vectorViewToReadOnlyCollectionAdapter.Count<T>();
	}

	[SecurityCritical]
	private static void WinRT_IReadOnlyList<T>(IVectorViewToIReadOnlyListAdapter vectorToListAdapter, IReadOnlyListToIVectorViewAdapter listToVectorAdapter, IVectorView<T> vectorView)
	{
		WinRT_IEnumerable<T>(null, null, null);
		WinRT_IReadOnlyCollection<T>(null);
		vectorToListAdapter.Indexer_Get<T>(0);
		listToVectorAdapter.GetAt<T>(0u);
		listToVectorAdapter.Size<T>();
	}

	[SecurityCritical]
	private static void WinRT_IDictionary<K, V>(MapToDictionaryAdapter mapToDictionaryAdapter, MapToCollectionAdapter mapToCollectionAdapter, DictionaryToMapAdapter dictionaryToMapAdapter, IMap<K, V> map)
	{
		WinRT_IEnumerable<KeyValuePair<K, V>>(null, null, null);
		mapToDictionaryAdapter.Indexer_Get<K, V>(default(K));
		mapToDictionaryAdapter.Indexer_Set(default(K), default(V));
		mapToDictionaryAdapter.ContainsKey<K, V>(default(K));
		mapToDictionaryAdapter.Add(default(K), default(V));
		mapToDictionaryAdapter.Remove<K, V>(default(K));
		mapToDictionaryAdapter.TryGetValue<K, V>(default(K), out var _);
		mapToCollectionAdapter.Count<K, V>();
		mapToCollectionAdapter.Add(new KeyValuePair<K, V>(default(K), default(V)));
		mapToCollectionAdapter.Clear<K, V>();
		dictionaryToMapAdapter.Lookup<K, V>(default(K));
		dictionaryToMapAdapter.Size<K, V>();
		dictionaryToMapAdapter.HasKey<K, V>(default(K));
		dictionaryToMapAdapter.Insert(default(K), default(V));
		dictionaryToMapAdapter.Remove<K, V>(default(K));
		dictionaryToMapAdapter.Clear<K, V>();
	}

	[SecurityCritical]
	private static void WinRT_IReadOnlyDictionary<K, V>(IMapViewToIReadOnlyDictionaryAdapter mapToDictionaryAdapter, IReadOnlyDictionaryToIMapViewAdapter dictionaryToMapAdapter, IMapView<K, V> mapView, MapViewToReadOnlyCollectionAdapter mapViewToReadOnlyCollectionAdapter)
	{
		WinRT_IEnumerable<KeyValuePair<K, V>>(null, null, null);
		WinRT_IReadOnlyCollection<KeyValuePair<K, V>>(null);
		mapToDictionaryAdapter.Indexer_Get<K, V>(default(K));
		mapToDictionaryAdapter.ContainsKey<K, V>(default(K));
		mapToDictionaryAdapter.TryGetValue<K, V>(default(K), out var _);
		mapViewToReadOnlyCollectionAdapter.Count<K, V>();
		dictionaryToMapAdapter.Lookup<K, V>(default(K));
		dictionaryToMapAdapter.Size<K, V>();
		dictionaryToMapAdapter.HasKey<K, V>(default(K));
	}

	[SecurityCritical]
	private static void WinRT_Nullable<T>() where T : struct
	{
		T? pManaged = null;
		NullableMarshaler.ConvertToNative(ref pManaged);
		NullableMarshaler.ConvertToManagedRetVoid(IntPtr.Zero, ref pManaged);
	}
}
