using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace System.Runtime.InteropServices.WindowsRuntime;

[Serializable]
[DebuggerDisplay("Count = {Count}")]
internal sealed class ReadOnlyDictionaryValueCollection<TKey, TValue> : IEnumerable<TValue>, IEnumerable
{
	private readonly IReadOnlyDictionary<TKey, TValue> dictionary;

	public ReadOnlyDictionaryValueCollection(IReadOnlyDictionary<TKey, TValue> dictionary)
	{
		if (dictionary == null)
		{
			throw new ArgumentNullException("dictionary");
		}
		this.dictionary = dictionary;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<TValue>)this).GetEnumerator();
	}

	public IEnumerator<TValue> GetEnumerator()
	{
		return new ReadOnlyDictionaryValueEnumerator<TKey, TValue>(dictionary);
	}
}
