using System.Collections;
using System.Collections.Specialized;
using System.Security.Permissions;

namespace System.Net;

internal class SpnDictionary : StringDictionary
{
	private class ValueCollection : ICollection, IEnumerable
	{
		private SpnDictionary spnDictionary;

		public int Count => spnDictionary.m_SyncTable.Values.Count;

		public bool IsSynchronized => true;

		public object SyncRoot => spnDictionary.m_SyncTable.SyncRoot;

		internal ValueCollection(SpnDictionary spnDictionary)
		{
			this.spnDictionary = spnDictionary;
		}

		public void CopyTo(Array array, int index)
		{
			CheckCopyToArguments(array, index, Count);
			int num = 0;
			IEnumerator enumerator = GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object current = enumerator.Current;
					array.SetValue(current, num + index);
					num++;
				}
			}
			finally
			{
				IDisposable disposable = enumerator as IDisposable;
				if (disposable != null)
				{
					disposable.Dispose();
				}
			}
		}

		public IEnumerator GetEnumerator()
		{
			foreach (SpnToken value in spnDictionary.m_SyncTable.Values)
			{
				yield return value?.Spn;
			}
		}
	}

	private Hashtable m_SyncTable = Hashtable.Synchronized(new Hashtable());

	private ValueCollection m_ValuesWrapper;

	public override int Count
	{
		get
		{
			ExceptionHelper.WebPermissionUnrestricted.Demand();
			return m_SyncTable.Count;
		}
	}

	public override bool IsSynchronized => true;

	public override string this[string key]
	{
		get
		{
			key = GetCanonicalKey(key);
			return InternalGet(key)?.Spn;
		}
		set
		{
			key = GetCanonicalKey(key);
			InternalSet(key, new SpnToken(value));
		}
	}

	public override ICollection Keys
	{
		get
		{
			ExceptionHelper.WebPermissionUnrestricted.Demand();
			return m_SyncTable.Keys;
		}
	}

	public override object SyncRoot
	{
		[HostProtection(SecurityAction.LinkDemand, Synchronization = true)]
		get
		{
			ExceptionHelper.WebPermissionUnrestricted.Demand();
			return m_SyncTable;
		}
	}

	public override ICollection Values
	{
		get
		{
			ExceptionHelper.WebPermissionUnrestricted.Demand();
			if (m_ValuesWrapper == null)
			{
				m_ValuesWrapper = new ValueCollection(this);
			}
			return m_ValuesWrapper;
		}
	}

	internal SpnDictionary()
	{
	}

	internal SpnToken InternalGet(string canonicalKey)
	{
		int num = 0;
		string text = null;
		lock (m_SyncTable.SyncRoot)
		{
			foreach (object key in m_SyncTable.Keys)
			{
				string text2 = (string)key;
				if (text2 != null && text2.Length > num && string.Compare(text2, 0, canonicalKey, 0, text2.Length, StringComparison.OrdinalIgnoreCase) == 0)
				{
					num = text2.Length;
					text = text2;
				}
			}
		}
		if (text == null)
		{
			return null;
		}
		return (SpnToken)m_SyncTable[text];
	}

	internal void InternalSet(string canonicalKey, SpnToken spnToken)
	{
		m_SyncTable[canonicalKey] = spnToken;
	}

	public override void Add(string key, string value)
	{
		key = GetCanonicalKey(key);
		m_SyncTable.Add(key, new SpnToken(value));
	}

	public override void Clear()
	{
		ExceptionHelper.WebPermissionUnrestricted.Demand();
		m_SyncTable.Clear();
	}

	public override bool ContainsKey(string key)
	{
		key = GetCanonicalKey(key);
		return m_SyncTable.ContainsKey(key);
	}

	public override bool ContainsValue(string value)
	{
		ExceptionHelper.WebPermissionUnrestricted.Demand();
		foreach (SpnToken value2 in m_SyncTable.Values)
		{
			if (value2.Spn == value)
			{
				return true;
			}
		}
		return false;
	}

	public override void CopyTo(Array array, int index)
	{
		ExceptionHelper.WebPermissionUnrestricted.Demand();
		CheckCopyToArguments(array, index, Count);
		int num = 0;
		IEnumerator enumerator = GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object current = enumerator.Current;
				array.SetValue(current, num + index);
				num++;
			}
		}
		finally
		{
			IDisposable disposable = enumerator as IDisposable;
			if (disposable != null)
			{
				disposable.Dispose();
			}
		}
	}

	public override IEnumerator GetEnumerator()
	{
		ExceptionHelper.WebPermissionUnrestricted.Demand();
		foreach (string key in m_SyncTable.Keys)
		{
			SpnToken spnToken = (SpnToken)m_SyncTable[key];
			yield return new DictionaryEntry(key, spnToken.Spn);
		}
	}

	public override void Remove(string key)
	{
		key = GetCanonicalKey(key);
		m_SyncTable.Remove(key);
	}

	private static string GetCanonicalKey(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		try
		{
			Uri uri = new Uri(key);
			key = uri.GetParts(UriComponents.SchemeAndServer | UriComponents.Path, UriFormat.SafeUnescaped);
			new WebPermission(NetworkAccess.Connect, new Uri(key)).Demand();
			return key;
		}
		catch (UriFormatException innerException)
		{
			throw new ArgumentException(SR.GetString("net_mustbeuri", "key"), "key", innerException);
		}
	}

	private static void CheckCopyToArguments(Array array, int index, int count)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		if (array.Rank != 1)
		{
			throw new ArgumentException(SR.GetString("Arg_RankMultiDimNotSupported"));
		}
		if (index < 0)
		{
			throw new ArgumentOutOfRangeException("index", SR.GetString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (array.Length - index < count)
		{
			throw new ArgumentException(SR.GetString("Arg_ArrayPlusOffTooSmall"));
		}
	}
}
