using System.Collections.Generic;

namespace System.Runtime.InteropServices.WindowsRuntime;

internal sealed class CLRIKeyValuePairImpl<K, V> : IKeyValuePair<K, V>
{
	private readonly KeyValuePair<K, V> _pair;

	public K Key => _pair.Key;

	public V Value => _pair.Value;

	public CLRIKeyValuePairImpl([In] ref KeyValuePair<K, V> pair)
	{
		_pair = pair;
	}

	internal static object BoxHelper(object pair)
	{
		KeyValuePair<K, V> pair2 = (KeyValuePair<K, V>)pair;
		return new CLRIKeyValuePairImpl<K, V>(ref pair2);
	}

	internal static object UnboxHelper(object wrapper)
	{
		CLRIKeyValuePairImpl<K, V> cLRIKeyValuePairImpl = (CLRIKeyValuePairImpl<K, V>)wrapper;
		return cLRIKeyValuePairImpl._pair;
	}

	public override string ToString()
	{
		return _pair.ToString();
	}
}
