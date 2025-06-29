using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace System.Runtime.InteropServices.WindowsRuntime;

[Serializable]
[DebuggerDisplay("Count = {Count}")]
internal sealed class ReadOnlyDictionaryKeyCollection<TKey, TValue> : IEnumerable<TKey>, IEnumerable
{
	private readonly IReadOnlyDictionary<TKey, TValue> dictionary;

	public ReadOnlyDictionaryKeyCollection(IReadOnlyDictionary<TKey, TValue> dictionary)
	{
		if (dictionary == null)
		{
			throw new ArgumentNullException("dictionary");
		}
		this.dictionary = dictionary;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<TKey>)this).GetEnumerator();
	}

	public IEnumerator<TKey> GetEnumerator()
	{
		return new ReadOnlyDictionaryKeyEnumerator<TKey, TValue>(dictionary);
	}
}
