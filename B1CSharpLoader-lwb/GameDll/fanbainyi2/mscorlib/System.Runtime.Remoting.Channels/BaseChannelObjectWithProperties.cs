using System.Collections;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;

namespace System.Runtime.Remoting.Channels;

[SecurityCritical]
[ComVisible(true)]
[SecurityPermission(SecurityAction.InheritanceDemand, Flags = SecurityPermissionFlag.Infrastructure)]
public abstract class BaseChannelObjectWithProperties : IDictionary, ICollection, IEnumerable
{
	public virtual IDictionary Properties
	{
		[SecurityCritical]
		get
		{
			return this;
		}
	}

	public virtual object this[object key]
	{
		[SecuritySafeCritical]
		get
		{
			return null;
		}
		[SecuritySafeCritical]
		set
		{
			throw new NotImplementedException();
		}
	}

	public virtual ICollection Keys
	{
		[SecuritySafeCritical]
		get
		{
			return null;
		}
	}

	public virtual ICollection Values
	{
		[SecuritySafeCritical]
		get
		{
			ICollection keys = Keys;
			if (keys == null)
			{
				return null;
			}
			ArrayList arrayList = new ArrayList();
			foreach (object item in keys)
			{
				arrayList.Add(this[item]);
			}
			return arrayList;
		}
	}

	public virtual bool IsReadOnly
	{
		[SecuritySafeCritical]
		get
		{
			return false;
		}
	}

	public virtual bool IsFixedSize
	{
		[SecuritySafeCritical]
		get
		{
			return true;
		}
	}

	public virtual int Count
	{
		[SecuritySafeCritical]
		get
		{
			return Keys?.Count ?? 0;
		}
	}

	public virtual object SyncRoot
	{
		[SecuritySafeCritical]
		get
		{
			return this;
		}
	}

	public virtual bool IsSynchronized
	{
		[SecuritySafeCritical]
		get
		{
			return false;
		}
	}

	[SecuritySafeCritical]
	public virtual bool Contains(object key)
	{
		if (key == null)
		{
			return false;
		}
		ICollection keys = Keys;
		if (keys == null)
		{
			return false;
		}
		string text = key as string;
		foreach (object item in keys)
		{
			if (text != null && item is string strB)
			{
				if (string.Compare(text, strB, StringComparison.OrdinalIgnoreCase) == 0)
				{
					return true;
				}
			}
			else if (key.Equals(item))
			{
				return true;
			}
		}
		return false;
	}

	[SecuritySafeCritical]
	public virtual void Add(object key, object value)
	{
		throw new NotSupportedException();
	}

	[SecuritySafeCritical]
	public virtual void Clear()
	{
		throw new NotSupportedException();
	}

	[SecuritySafeCritical]
	public virtual void Remove(object key)
	{
		throw new NotSupportedException();
	}

	[SecuritySafeCritical]
	public virtual IDictionaryEnumerator GetEnumerator()
	{
		return new DictionaryEnumeratorByKeys(this);
	}

	[SecuritySafeCritical]
	public virtual void CopyTo(Array array, int index)
	{
		throw new NotSupportedException();
	}

	[SecuritySafeCritical]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return new DictionaryEnumeratorByKeys(this);
	}
}
