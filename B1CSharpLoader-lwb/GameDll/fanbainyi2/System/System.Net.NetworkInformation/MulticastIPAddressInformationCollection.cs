using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace System.Net.NetworkInformation;

[global::__DynamicallyInvokable]
public class MulticastIPAddressInformationCollection : ICollection<MulticastIPAddressInformation>, IEnumerable<MulticastIPAddressInformation>, IEnumerable
{
	private Collection<MulticastIPAddressInformation> addresses = new Collection<MulticastIPAddressInformation>();

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
	public virtual MulticastIPAddressInformation this[int index]
	{
		[global::__DynamicallyInvokable]
		get
		{
			return addresses[index];
		}
	}

	[global::__DynamicallyInvokable]
	protected internal MulticastIPAddressInformationCollection()
	{
	}

	[global::__DynamicallyInvokable]
	public virtual void CopyTo(MulticastIPAddressInformation[] array, int offset)
	{
		addresses.CopyTo(array, offset);
	}

	[global::__DynamicallyInvokable]
	public virtual void Add(MulticastIPAddressInformation address)
	{
		throw new NotSupportedException(SR.GetString("net_collection_readonly"));
	}

	internal void InternalAdd(MulticastIPAddressInformation address)
	{
		addresses.Add(address);
	}

	[global::__DynamicallyInvokable]
	public virtual bool Contains(MulticastIPAddressInformation address)
	{
		return addresses.Contains(address);
	}

	[global::__DynamicallyInvokable]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	[global::__DynamicallyInvokable]
	public virtual IEnumerator<MulticastIPAddressInformation> GetEnumerator()
	{
		return addresses.GetEnumerator();
	}

	[global::__DynamicallyInvokable]
	public virtual bool Remove(MulticastIPAddressInformation address)
	{
		throw new NotSupportedException(SR.GetString("net_collection_readonly"));
	}

	[global::__DynamicallyInvokable]
	public virtual void Clear()
	{
		throw new NotSupportedException(SR.GetString("net_collection_readonly"));
	}
}
