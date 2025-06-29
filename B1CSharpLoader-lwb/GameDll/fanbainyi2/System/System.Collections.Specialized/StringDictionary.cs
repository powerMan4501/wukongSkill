using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Globalization;

namespace System.Collections.Specialized;

[Serializable]
[DesignerSerializer("System.Diagnostics.Design.StringDictionaryCodeDomSerializer, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.ComponentModel.Design.Serialization.CodeDomSerializer, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
public class StringDictionary : IEnumerable
{
	private class GenericAdapter : IDictionary<string, string>, ICollection<KeyValuePair<string, string>>, IEnumerable<KeyValuePair<string, string>>, IEnumerable
	{
		internal enum KeyOrValue
		{
			Key,
			Value
		}

		private class ICollectionToGenericCollectionAdapter : ICollection<string>, IEnumerable<string>, IEnumerable
		{
			private StringDictionary _internal;

			private KeyOrValue _keyOrValue;

			public int Count => _internal.Count;

			public bool IsReadOnly => true;

			public ICollectionToGenericCollectionAdapter(StringDictionary source, KeyOrValue keyOrValue)
			{
				if (source == null)
				{
					throw new ArgumentNullException("source");
				}
				_internal = source;
				_keyOrValue = keyOrValue;
			}

			public void Add(string item)
			{
				ThrowNotSupportedException();
			}

			public void Clear()
			{
				ThrowNotSupportedException();
			}

			public void ThrowNotSupportedException()
			{
				if (_keyOrValue == KeyOrValue.Key)
				{
					throw new NotSupportedException(SR.GetString("NotSupported_KeyCollectionSet"));
				}
				throw new NotSupportedException(SR.GetString("NotSupported_ValueCollectionSet"));
			}

			public bool Contains(string item)
			{
				if (_keyOrValue == KeyOrValue.Key)
				{
					return _internal.ContainsKey(item);
				}
				return _internal.ContainsValue(item);
			}

			public void CopyTo(string[] array, int arrayIndex)
			{
				ICollection underlyingCollection = GetUnderlyingCollection();
				underlyingCollection.CopyTo(array, arrayIndex);
			}

			public bool Remove(string item)
			{
				ThrowNotSupportedException();
				return false;
			}

			private ICollection GetUnderlyingCollection()
			{
				if (_keyOrValue == KeyOrValue.Key)
				{
					return _internal.Keys;
				}
				return _internal.Values;
			}

			public IEnumerator<string> GetEnumerator()
			{
				ICollection underlyingCollection = GetUnderlyingCollection();
				foreach (string item in underlyingCollection)
				{
					yield return item;
				}
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return GetUnderlyingCollection().GetEnumerator();
			}
		}

		private StringDictionary m_stringDictionary;

		private ICollectionToGenericCollectionAdapter _values;

		private ICollectionToGenericCollectionAdapter _keys;

		public int Count => m_stringDictionary.Count;

		public string this[string key]
		{
			get
			{
				if (key == null)
				{
					throw new ArgumentNullException("key");
				}
				if (!m_stringDictionary.ContainsKey(key))
				{
					throw new KeyNotFoundException();
				}
				return m_stringDictionary[key];
			}
			set
			{
				if (key == null)
				{
					throw new ArgumentNullException("key");
				}
				m_stringDictionary[key] = value;
			}
		}

		public ICollection<string> Keys
		{
			get
			{
				if (_keys == null)
				{
					_keys = new ICollectionToGenericCollectionAdapter(m_stringDictionary, KeyOrValue.Key);
				}
				return _keys;
			}
		}

		public ICollection<string> Values
		{
			get
			{
				if (_values == null)
				{
					_values = new ICollectionToGenericCollectionAdapter(m_stringDictionary, KeyOrValue.Value);
				}
				return _values;
			}
		}

		bool ICollection<KeyValuePair<string, string>>.IsReadOnly => false;

		internal GenericAdapter(StringDictionary stringDictionary)
		{
			m_stringDictionary = stringDictionary;
		}

		public void Add(string key, string value)
		{
			this[key] = value;
		}

		public bool ContainsKey(string key)
		{
			return m_stringDictionary.ContainsKey(key);
		}

		public void Clear()
		{
			m_stringDictionary.Clear();
		}

		public bool Remove(string key)
		{
			if (!m_stringDictionary.ContainsKey(key))
			{
				return false;
			}
			m_stringDictionary.Remove(key);
			return true;
		}

		public bool TryGetValue(string key, out string value)
		{
			if (!m_stringDictionary.ContainsKey(key))
			{
				value = null;
				return false;
			}
			value = m_stringDictionary[key];
			return true;
		}

		void ICollection<KeyValuePair<string, string>>.Add(KeyValuePair<string, string> item)
		{
			m_stringDictionary.Add(item.Key, item.Value);
		}

		bool ICollection<KeyValuePair<string, string>>.Contains(KeyValuePair<string, string> item)
		{
			if (TryGetValue(item.Key, out var value))
			{
				return value.Equals(item.Value);
			}
			return false;
		}

		void ICollection<KeyValuePair<string, string>>.CopyTo(KeyValuePair<string, string>[] array, int arrayIndex)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array", SR.GetString("ArgumentNull_Array"));
			}
			if (arrayIndex < 0)
			{
				throw new ArgumentOutOfRangeException("arrayIndex", SR.GetString("ArgumentOutOfRange_NeedNonNegNum"));
			}
			if (array.Length - arrayIndex < Count)
			{
				throw new ArgumentException(SR.GetString("Arg_ArrayPlusOffTooSmall"));
			}
			int num = arrayIndex;
			foreach (DictionaryEntry item in m_stringDictionary)
			{
				array[num++] = new KeyValuePair<string, string>((string)item.Key, (string)item.Value);
			}
		}

		bool ICollection<KeyValuePair<string, string>>.Remove(KeyValuePair<string, string> item)
		{
			if (!((ICollection<KeyValuePair<string, string>>)this).Contains(item))
			{
				return false;
			}
			m_stringDictionary.Remove(item.Key);
			return true;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public IEnumerator<KeyValuePair<string, string>> GetEnumerator()
		{
			foreach (DictionaryEntry item in m_stringDictionary)
			{
				yield return new KeyValuePair<string, string>((string)item.Key, (string)item.Value);
			}
		}
	}

	internal Hashtable contents = new Hashtable();

	public virtual int Count => contents.Count;

	public virtual bool IsSynchronized => contents.IsSynchronized;

	public virtual string this[string key]
	{
		get
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			return (string)contents[key.ToLower(CultureInfo.InvariantCulture)];
		}
		set
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			contents[key.ToLower(CultureInfo.InvariantCulture)] = value;
		}
	}

	public virtual ICollection Keys => contents.Keys;

	public virtual object SyncRoot => contents.SyncRoot;

	public virtual ICollection Values => contents.Values;

	public virtual void Add(string key, string value)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		contents.Add(key.ToLower(CultureInfo.InvariantCulture), value);
	}

	public virtual void Clear()
	{
		contents.Clear();
	}

	public virtual bool ContainsKey(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		return contents.ContainsKey(key.ToLower(CultureInfo.InvariantCulture));
	}

	public virtual bool ContainsValue(string value)
	{
		return contents.ContainsValue(value);
	}

	public virtual void CopyTo(Array array, int index)
	{
		contents.CopyTo(array, index);
	}

	public virtual IEnumerator GetEnumerator()
	{
		return contents.GetEnumerator();
	}

	public virtual void Remove(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		contents.Remove(key.ToLower(CultureInfo.InvariantCulture));
	}

	internal void ReplaceHashtable(Hashtable useThisHashtableInstead)
	{
		contents = useThisHashtableInstead;
	}

	internal IDictionary<string, string> AsGenericDictionary()
	{
		return new GenericAdapter(this);
	}
}
