namespace System.Net.NetworkInformation;

[global::__DynamicallyInvokable]
public abstract class IPAddressInformation
{
	[global::__DynamicallyInvokable]
	public abstract IPAddress Address
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	public abstract bool IsDnsEligible
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	public abstract bool IsTransient
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	protected IPAddressInformation()
	{
	}
}
