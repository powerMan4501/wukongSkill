namespace System.Net.NetworkInformation;

[global::__DynamicallyInvokable]
public abstract class TcpConnectionInformation
{
	[global::__DynamicallyInvokable]
	public abstract IPEndPoint LocalEndPoint
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	public abstract IPEndPoint RemoteEndPoint
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	public abstract TcpState State
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	protected TcpConnectionInformation()
	{
	}
}
