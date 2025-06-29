using System.Collections;
using System.Security;

namespace System.Runtime.Remoting.Messaging;

internal abstract class MessageDictionary : IDictionary, ICollection, IEnumerable
{
	internal string[] _keys;

	internal IDictionary _dict;

	internal IDictionary InternalDictionary => _dict;

	public virtual bool IsReadOnly => false;

	public virtual bool IsSynchronized => false;

	public virtual bool IsFixedSize => false;

	public virtual object SyncRoot => this;

	public virtual object this[object key]
	{
		get
		{
			if (key is string text)
			{
				for (int i = 0; i < _keys.Length; i++)
				{
					if (text.Equals(_keys[i]))
					{
						return GetMessageValue(i);
					}
				}
				if (_dict != null)
				{
					return _dict[key];
				}
			}
			return null;
		}
		[SecuritySafeCritical]
		set
		{
			if (ContainsSpecialKey(key))
			{
				if (key.Equals(Message.UriKey))
				{
					SetSpecialKey(0, value);
					return;
				}
				if (!key.Equals(Message.CallContextKey))
				{
					throw new ArgumentException(Environment.GetResourceString("Argument_InvalidKey"));
				}
				SetSpecialKey(1, value);
			}
			else
			{
				if (_dict == null)
				{
					_dict = new Hashtable();
				}
				_dict[key] = value;
			}
		}
	}

	public virtual ICollection Keys
	{
		get
		{
			int num = _keys.Length;
			ICollection collection = ((_dict != null) ? _dict.Keys : null);
			if (collection != null)
			{
				num += collection.Count;
			}
			ArrayList arrayList = new ArrayList(num);
			for (int i = 0; i < _keys.Length; i++)
			{
				arrayList.Add(_keys[i]);
			}
			if (collection != null)
			{
				arrayList.AddRange(collection);
			}
			return arrayList;
		}
	}

	public virtual ICollection Values
	{
		get
		{
			int num = _keys.Length;
			ICollection collection = ((_dict != null) ? _dict.Keys : null);
			if (collection != null)
			{
				num += collection.Count;
			}
			ArrayList arrayList = new ArrayList(num);
			for (int i = 0; i < _keys.Length; i++)
			{
				arrayList.Add(GetMessageValue(i));
			}
			if (collection != null)
			{
				arrayList.AddRange(collection);
			}
			return arrayList;
		}
	}

	public virtual int Count
	{
		get
		{
			if (_dict != null)
			{
				return _dict.Count + _keys.Length;
			}
			return _keys.Length;
		}
	}

	internal MessageDictionary(string[] keys, IDictionary idict)
	{
		_keys = keys;
		_dict = idict;
	}

	internal bool HasUserData()
	{
		if (_dict != null && _dict.Count > 0)
		{
			return true;
		}
		return false;
	}

	internal abstract object GetMessageValue(int i);

	[SecurityCritical]
	internal abstract void SetSpecialKey(int keyNum, object value);

	public virtual bool Contains(object key)
	{
		if (ContainsSpecialKey(key))
		{
			return true;
		}
		if (_dict != null)
		{
			return _dict.Contains(key);
		}
		return false;
	}

	protected virtual bool ContainsSpecialKey(object key)
	{
		if (!(key is string))
		{
			return false;
		}
		string text = (string)key;
		for (int i = 0; i < _keys.Length; i++)
		{
			if (text.Equals(_keys[i]))
			{
				return true;
			}
		}
		return false;
	}

	public virtual void CopyTo(Array array, int index)
	{
		for (int i = 0; i < _keys.Length; i++)
		{
			array.SetValue(GetMessageValue(i), index + i);
		}
		if (_dict != null)
		{
			_dict.CopyTo(array, index + _keys.Length);
		}
	}

	IDictionaryEnumerator IDictionary.GetEnumerator()
	{
		return new MessageDictionaryEnumerator(this, _dict);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		throw new NotSupportedException();
	}

	public virtual void Add(object key, object value)
	{
		if (ContainsSpecialKey(key))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidKey"));
		}
		if (_dict == null)
		{
			_dict = new Hashtable();
		}
		_dict.Add(key, value);
	}

	public virtual void Clear()
	{
		if (_dict != null)
		{
			_dict.Clear();
		}
	}

	public virtual void Remove(object key)
	{
		if (ContainsSpecialKey(key) || _dict == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidKey"));
		}
		_dict.Remove(key);
	}
}
