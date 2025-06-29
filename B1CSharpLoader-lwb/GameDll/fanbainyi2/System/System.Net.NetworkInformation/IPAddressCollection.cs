using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace System.Net.NetworkInformation;

[global::__DynamicallyInvokable]
public class IPAddressCollection : ICollection<IPAddress>, IEnumerable<IPAddress>, IEnumerable
{
	private Collection<IPAddress> addresses = new Collection<IPAddress>();

	[global::__DynamicallyInvokable]
	public virtual int Count
	{
		[global::__DynamicallyInvokable]
		get
		{
			return addresses.Count;
		}
	}

	[global::__DynamicallyInvokable]
	public virtual bool IsReadOnly
	{
		[global::__DynamicallyInvokable]
		get
		{
			return true;
		}
	}

	[global::__DynamicallyInvokable]
	public virtual IPAddress this[int index]
	{
		[global::__DynamicallyInvokable]
		get
		{
			return addresses[index];
		}
	}

	[global::__DynamicallyInvokable]
	protected internal IPAddressCollection()
	{
	}

	[global::__DynamicallyInvokable]
	public virtual void CopyTo(IPAddress[] array, int offset)
	{
		addresses.CopyTo(array, offset);
	}

	[global::__DynamicallyInvokable]
	public virtual void Add(IPAddress address)
	{
		throw new NotSupportedException(SR.GetString("net_collection_readonly"));
	}

	internal void InternalAdd(IPAddress address)
	{
		addresses.Add(address);
	}

	[global::__DynamicallyInvokable]
	public virtual bool Contains(IPAddress address)
	{
		return addresses.Contains(address);
	}

	[global::__DynamicallyInvokable]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	[global::__DynamicallyInvokable]
	public virtual IEnumerator<IPAddress> GetEnumerator()
	{
		return addresses.GetEnumerator();
	}

	[global::__DynamicallyInvokable]
	public virtual bool Remove(IPAddress address)
	{
		throw new NotSupportedException(SR.GetString("net_collection_readonly"));
	}

	[global::__DynamicallyInvokable]
	public virtual void Clear()
	{
		throw new NotSupportedException(SR.GetString("net_collection_readonly"));
	}
}
