using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security;

namespace System.Runtime.InteropServices.WindowsRuntime;

internal sealed class MapViewToReadOnlyCollectionAdapter
{
	private MapViewToReadOnlyCollectionAdapter()
	{
	}

	[SecurityCritical]
	internal int Count<K, V>()
	{
		object obj = JitHelpers.UnsafeCast<object>(this);
		if (obj is IMapView<K, V> { Size: var size })
		{
			if (int.MaxValue < size)
			{
				throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_CollectionBackingDictionaryTooLarge"));
			}
			return (int)size;
		}
		IVectorView<KeyValuePair<K, V>> vectorView = JitHelpers.UnsafeCast<IVectorView<KeyValuePair<K, V>>>(this);
		uint size2 = vectorView.Size;
		if (int.MaxValue < size2)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_CollectionBackingListTooLarge"));
		}
		return (int)size2;
	}
}
