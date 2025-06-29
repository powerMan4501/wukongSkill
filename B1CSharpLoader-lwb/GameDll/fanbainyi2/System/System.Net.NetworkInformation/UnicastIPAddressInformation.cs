namespace System.Net.NetworkInformation;

[global::__DynamicallyInvokable]
public abstract class UnicastIPAddressInformation : IPAddressInformation
{
	[global::__DynamicallyInvokable]
	public abstract long AddressPreferredLifetime
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	public abstract long AddressValidLifetime
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	public abstract long DhcpLeaseLifetime
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	public abstract DuplicateAddressDetectionState DuplicateAddressDetectionState
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	public abstract PrefixOrigin PrefixOrigin
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	public abstract SuffixOrigin SuffixOrigin
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	public abstract IPAddress IPv4Mask
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	public virtual int PrefixLength
	{
		[global::__DynamicallyInvokable]
		get
		{
			throw new NotImplementedException();
		}
	}

	[global::__DynamicallyInvokable]
	protected UnicastIPAddressInformation()
	{
	}
}
