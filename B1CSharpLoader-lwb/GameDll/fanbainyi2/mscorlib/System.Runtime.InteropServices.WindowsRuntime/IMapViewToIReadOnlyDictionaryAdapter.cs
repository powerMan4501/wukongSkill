using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

namespace System.Runtime.InteropServices.WindowsRuntime;

[DebuggerDisplay("Count = {Count}")]
internal sealed class IMapViewToIReadOnlyDictionaryAdapter
{
	private IMapViewToIReadOnlyDictionaryAdapter()
	{
	}

	[SecurityCritical]
	internal V Indexer_Get<K, V>(K key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IMapView<K, V> mapView = JitHelpers.UnsafeCast<IMapView<K, V>>(this);
		return Lookup(mapView, key);
	}

	[SecurityCritical]
	internal IEnumerable<K> Keys<K, V>()
	{
		IMapView<K, V> mapView = JitHelpers.UnsafeCast<IMapView<K, V>>(this);
		IReadOnlyDictionary<K, V> dictionary = (IReadOnlyDictionary<K, V>)mapView;
		return new ReadOnlyDictionaryKeyCollection<K, V>(dictionary);
	}

	[SecurityCritical]
	internal IEnumerable<V> Values<K, V>()
	{
		IMapView<K, V> mapView = JitHelpers.UnsafeCast<IMapView<K, V>>(this);
		IReadOnlyDictionary<K, V> dictionary = (IReadOnlyDictionary<K, V>)mapView;
		return new ReadOnlyDictionaryValueCollection<K, V>(dictionary);
	}

	[SecurityCritical]
	internal bool ContainsKey<K, V>(K key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IMapView<K, V> mapView = JitHelpers.UnsafeCast<IMapView<K, V>>(this);
		return mapView.HasKey(key);
	}

	[SecurityCritical]
	internal bool TryGetValue<K, V>(K key, out V value)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IMapView<K, V> mapView = JitHelpers.UnsafeCast<IMapView<K, V>>(this);
		if (!mapView.HasKey(key))
		{
			value = default(V);
			return false;
		}
		try
		{
			value = mapView.Lookup(key);
			return true;
		}
		catch (Exception ex)
		{
			if (-2147483637 == ex._HResult)
			{
				value = default(V);
				return false;
			}
			throw;
		}
	}

	private static V Lookup<K, V>(IMapView<K, V> _this, K key)
	{
		try
		{
			return _this.Lookup(key);
		}
		catch (Exception ex)
		{
			if (-2147483637 == ex._HResult)
			{
				throw new KeyNotFoundException(Environment.GetResourceString("Arg_KeyNotFound"));
			}
			throw;
		}
	}
}
