namespace System.Net.NetworkInformation;

[global::__DynamicallyInvokable]
public abstract class IPv4InterfaceProperties
{
	[global::__DynamicallyInvokable]
	public abstract bool UsesWins
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	public abstract bool IsDhcpEnabled
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	public abstract bool IsAutomaticPrivateAddressingActive
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	public abstract bool IsAutomaticPrivateAddressingEnabled
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	public abstract int Index
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	public abstract bool IsForwardingEnabled
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	public abstract int Mtu
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	protected IPv4InterfaceProperties()
	{
	}
}
