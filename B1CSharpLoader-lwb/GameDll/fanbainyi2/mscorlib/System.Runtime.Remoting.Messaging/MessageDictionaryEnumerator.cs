using System.Collections;

namespace System.Runtime.Remoting.Messaging;

internal class MessageDictionaryEnumerator : IDictionaryEnumerator, IEnumerator
{
	private int i = -1;

	private IDictionaryEnumerator _enumHash;

	private MessageDictionary _md;

	public object Key
	{
		get
		{
			if (i < 0)
			{
				throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_InternalState"));
			}
			if (i < _md._keys.Length)
			{
				return _md._keys[i];
			}
			return _enumHash.Key;
		}
	}

	public object Value
	{
		get
		{
			if (i < 0)
			{
				throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_InternalState"));
			}
			if (i < _md._keys.Length)
			{
				return _md.GetMessageValue(i);
			}
			return _enumHash.Value;
		}
	}

	public object Current => Entry;

	public DictionaryEntry Entry => new DictionaryEntry(Key, Value);

	public MessageDictionaryEnumerator(MessageDictionary md, IDictionary hashtable)
	{
		_md = md;
		if (hashtable != null)
		{
			_enumHash = hashtable.GetEnumerator();
		}
		else
		{
			_enumHash = null;
		}
	}

	public bool MoveNext()
	{
		if (i == -2)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_InternalState"));
		}
		i++;
		if (i < _md._keys.Length)
		{
			return true;
		}
		if (_enumHash != null && _enumHash.MoveNext())
		{
			return true;
		}
		i = -2;
		return false;
	}

	public void Reset()
	{
		i = -1;
		if (_enumHash != null)
		{
			_enumHash.Reset();
		}
	}
}
