namespace System.Net.NetworkInformation;

[global::__DynamicallyInvokable]
public abstract class MulticastIPAddressInformation : IPAddressInformation
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
	protected MulticastIPAddressInformation()
	{
	}
}
