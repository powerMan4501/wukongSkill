using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace System.Net.NetworkInformation;

[global::__DynamicallyInvokable]
public class IPAddressInformationCollection : ICollection<IPAddressInformation>, IEnumerable<IPAddressInformation>, IEnumerable
{
	private Collection<IPAddressInformation> addresses = new Collection<IPAddressInformation>();

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
	public virtual IPAddressInformation this[int index]
	{
		[global::__DynamicallyInvokable]
		get
		{
			return addresses[index];
		}
	}

	internal IPAddressInformationCollection()
	{
	}

	[global::__DynamicallyInvokable]
	public virtual void CopyTo(IPAddressInformation[] array, int offset)
	{
		addresses.CopyTo(array, offset);
	}

	[global::__DynamicallyInvokable]
	public virtual void Add(IPAddressInformation address)
	{
		throw new NotSupportedException(SR.GetString("net_collection_readonly"));
	}

	internal void InternalAdd(IPAddressInformation address)
	{
		addresses.Add(address);
	}

	[global::__DynamicallyInvokable]
	public virtual bool Contains(IPAddressInformation address)
	{
		return addresses.Contains(address);
	}

	[global::__DynamicallyInvokable]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	[global::__DynamicallyInvokable]
	public virtual IEnumerator<IPAddressInformation> GetEnumerator()
	{
		return addresses.GetEnumerator();
	}

	[global::__DynamicallyInvokable]
	public virtual bool Remove(IPAddressInformation address)
	{
		throw new NotSupportedException(SR.GetString("net_collection_readonly"));
	}

	[global::__DynamicallyInvokable]
	public virtual void Clear()
	{
		throw new NotSupportedException(SR.GetString("net_collection_readonly"));
	}
}
