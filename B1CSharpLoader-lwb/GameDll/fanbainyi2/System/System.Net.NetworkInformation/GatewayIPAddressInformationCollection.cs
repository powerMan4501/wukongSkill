using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace System.Net.NetworkInformation;

[global::__DynamicallyInvokable]
public class GatewayIPAddressInformationCollection : ICollection<GatewayIPAddressInformation>, IEnumerable<GatewayIPAddressInformation>, IEnumerable
{
	private Collection<GatewayIPAddressInformation> addresses = new Collection<GatewayIPAddressInformation>();

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
	public virtual GatewayIPAddressInformation this[int index]
	{
		[global::__DynamicallyInvokable]
		get
		{
			return addresses[index];
		}
	}

	[global::__DynamicallyInvokable]
	protected internal GatewayIPAddressInformationCollection()
	{
	}

	[global::__DynamicallyInvokable]
	public virtual void CopyTo(GatewayIPAddressInformation[] array, int offset)
	{
		addresses.CopyTo(array, offset);
	}

	[global::__DynamicallyInvokable]
	public virtual void Add(GatewayIPAddressInformation address)
	{
		throw new NotSupportedException(SR.GetString("net_collection_readonly"));
	}

	internal void InternalAdd(GatewayIPAddressInformation address)
	{
		addresses.Add(address);
	}

	[global::__DynamicallyInvokable]
	public virtual bool Contains(GatewayIPAddressInformation address)
	{
		return addresses.Contains(address);
	}

	[global::__DynamicallyInvokable]
	public virtual IEnumerator<GatewayIPAddressInformation> GetEnumerator()
	{
		return addresses.GetEnumerator();
	}

	[global::__DynamicallyInvokable]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	[global::__DynamicallyInvokable]
	public virtual bool Remove(GatewayIPAddressInformation address)
	{
		throw new NotSupportedException(SR.GetString("net_collection_readonly"));
	}

	[global::__DynamicallyInvokable]
	public virtual void Clear()
	{
		throw new NotSupportedException(SR.GetString("net_collection_readonly"));
	}
}
