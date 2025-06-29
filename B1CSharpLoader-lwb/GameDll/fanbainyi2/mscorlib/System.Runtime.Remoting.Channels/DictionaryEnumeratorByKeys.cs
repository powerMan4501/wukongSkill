using System.Collections;

namespace System.Runtime.Remoting.Channels;

internal class DictionaryEnumeratorByKeys : IDictionaryEnumerator, IEnumerator
{
	private IDictionary _properties;

	private IEnumerator _keyEnum;

	public object Current => Entry;

	public DictionaryEntry Entry => new DictionaryEntry(Key, Value);

	public object Key => _keyEnum.Current;

	public object Value => _properties[Key];

	public DictionaryEnumeratorByKeys(IDictionary properties)
	{
		_properties = properties;
		_keyEnum = properties.Keys.GetEnumerator();
	}

	public bool MoveNext()
	{
		return _keyEnum.MoveNext();
	}

	public void Reset()
	{
		_keyEnum.Reset();
	}
}
