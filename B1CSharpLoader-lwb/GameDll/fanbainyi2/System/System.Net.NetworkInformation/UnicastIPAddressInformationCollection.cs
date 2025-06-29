using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace System.Net.NetworkInformation;

[global::__DynamicallyInvokable]
public class UnicastIPAddressInformationCollection : ICollection<UnicastIPAddressInformation>, IEnumerable<UnicastIPAddressInformation>, IEnumerable
{
	private Collection<UnicastIPAddressInformation> addresses = new Collection<UnicastIPAddressInformation>();

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
	public virtual UnicastIPAddressInformation this[int index]
	{
		[global::__DynamicallyInvokable]
		get
		{
			return addresses[index];
		}
	}

	[global::__DynamicallyInvokable]
	protected internal UnicastIPAddressInformationCollection()
	{
	}

	[global::__DynamicallyInvokable]
	public virtual void CopyTo(UnicastIPAddressInformation[] array, int offset)
	{
		addresses.CopyTo(array, offset);
	}

	[global::__DynamicallyInvokable]
	public virtual void Add(UnicastIPAddressInformation address)
	{
		throw new NotSupportedException(SR.GetString("net_collection_readonly"));
	}

	internal void InternalAdd(UnicastIPAddressInformation address)
	{
		addresses.Add(address);
	}

	[global::__DynamicallyInvokable]
	public virtual bool Contains(UnicastIPAddressInformation address)
	{
		return addresses.Contains(address);
	}

	[global::__DynamicallyInvokable]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	[global::__DynamicallyInvokable]
	public virtual IEnumerator<UnicastIPAddressInformation> GetEnumerator()
	{
		return addresses.GetEnumerator();
	}

	[global::__DynamicallyInvokable]
	public virtual bool Remove(UnicastIPAddressInformation address)
	{
		throw new NotSupportedException(SR.GetString("net_collection_readonly"));
	}

	[global::__DynamicallyInvokable]
	public virtual void Clear()
	{
		throw new NotSupportedException(SR.GetString("net_collection_readonly"));
	}
}
