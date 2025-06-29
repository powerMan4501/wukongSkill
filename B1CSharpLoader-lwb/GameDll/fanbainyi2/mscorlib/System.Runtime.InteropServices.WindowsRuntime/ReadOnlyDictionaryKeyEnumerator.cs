using System.Collections;
using System.Collections.Generic;

namespace System.Runtime.InteropServices.WindowsRuntime;

[Serializable]
internal sealed class ReadOnlyDictionaryKeyEnumerator<TKey, TValue> : IEnumerator<TKey>, IDisposable, IEnumerator
{
	private readonly IReadOnlyDictionary<TKey, TValue> dictionary;

	private IEnumerator<KeyValuePair<TKey, TValue>> enumeration;

	object IEnumerator.Current => ((IEnumerator<TKey>)this).Current;

	public TKey Current => enumeration.Current.Key;

	public ReadOnlyDictionaryKeyEnumerator(IReadOnlyDictionary<TKey, TValue> dictionary)
	{
		if (dictionary == null)
		{
			throw new ArgumentNullException("dictionary");
		}
		this.dictionary = dictionary;
		enumeration = dictionary.GetEnumerator();
	}

	void IDisposable.Dispose()
	{
		enumeration.Dispose();
	}

	public bool MoveNext()
	{
		return enumeration.MoveNext();
	}

	public void Reset()
	{
		enumeration = dictionary.GetEnumerator();
	}
}
