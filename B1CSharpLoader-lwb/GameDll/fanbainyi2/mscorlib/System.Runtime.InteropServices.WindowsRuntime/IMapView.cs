using System.Collections;
using System.Collections.Generic;

namespace System.Runtime.InteropServices.WindowsRuntime;

[ComImport]
[Guid("e480ce40-a338-4ada-adcf-272272e48cb9")]
internal interface IMapView<K, V> : IIterable<IKeyValuePair<K, V>>, IEnumerable<IKeyValuePair<K, V>>, IEnumerable
{
	V Lookup(K key);

	uint Size { get; }

	bool HasKey(K key);

	void Split(out IMapView<K, V> first, out IMapView<K, V> second);
}
