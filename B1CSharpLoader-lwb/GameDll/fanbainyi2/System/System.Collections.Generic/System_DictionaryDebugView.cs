using System.Diagnostics;

namespace System.Collections.Generic;

internal sealed class System_DictionaryDebugView<K, V>
{
	private IDictionary<K, V> dict;

	[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
	public KeyValuePair<K, V>[] Items
	{
		get
		{
			KeyValuePair<K, V>[] array = new KeyValuePair<K, V>[dict.Count];
			dict.CopyTo(array, 0);
			return array;
		}
	}

	public System_DictionaryDebugView(IDictionary<K, V> dictionary)
	{
		if (dictionary == null)
		{
			throw new ArgumentNullException("dictionary");
		}
		dict = dictionary;
	}
}
