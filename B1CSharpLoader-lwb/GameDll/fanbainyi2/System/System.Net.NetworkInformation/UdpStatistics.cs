namespace System.Net.NetworkInformation;

[global::__DynamicallyInvokable]
public abstract class UdpStatistics
{
	[global::__DynamicallyInvokable]
	public abstract long DatagramsReceived
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	public abstract long DatagramsSent
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	public abstract long IncomingDatagramsDiscarded
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	public abstract long IncomingDatagramsWithErrors
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	public abstract int UdpListeners
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	protected UdpStatistics()
	{
	}
}
