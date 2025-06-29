namespace System.Net.NetworkInformation;

[global::__DynamicallyInvokable]
public abstract class NetworkInterface
{
	[global::__DynamicallyInvokable]
	public static int LoopbackInterfaceIndex
	{
		[global::__DynamicallyInvokable]
		get
		{
			return SystemNetworkInterface.InternalLoopbackInterfaceIndex;
		}
	}

	[global::__DynamicallyInvokable]
	public static int IPv6LoopbackInterfaceIndex
	{
		[global::__DynamicallyInvokable]
		get
		{
			return SystemNetworkInterface.InternalIPv6LoopbackInterfaceIndex;
		}
	}

	[global::__DynamicallyInvokable]
	public virtual string Id
	{
		[global::__DynamicallyInvokable]
		get
		{
			throw new NotImplementedException();
		}
	}

	[global::__DynamicallyInvokable]
	public virtual string Name
	{
		[global::__DynamicallyInvokable]
		get
		{
			throw new NotImplementedException();
		}
	}

	[global::__DynamicallyInvokable]
	public virtual string Description
	{
		[global::__DynamicallyInvokable]
		get
		{
			throw new NotImplementedException();
		}
	}

	[global::__DynamicallyInvokable]
	public virtual OperationalStatus OperationalStatus
	{
		[global::__DynamicallyInvokable]
		get
		{
			throw new NotImplementedException();
		}
	}

	[global::__DynamicallyInvokable]
	public virtual long Speed
	{
		[global::__DynamicallyInvokable]
		get
		{
			throw new NotImplementedException();
		}
	}

	[global::__DynamicallyInvokable]
	public virtual bool IsReceiveOnly
	{
		[global::__DynamicallyInvokable]
		get
		{
			throw new NotImplementedException();
		}
	}

	[global::__DynamicallyInvokable]
	public virtual bool SupportsMulticast
	{
		[global::__DynamicallyInvokable]
		get
		{
			throw new NotImplementedException();
		}
	}

	[global::__DynamicallyInvokable]
	public virtual NetworkInterfaceType NetworkInterfaceType
	{
		[global::__DynamicallyInvokable]
		get
		{
			throw new NotImplementedException();
		}
	}

	[global::__DynamicallyInvokable]
	public static NetworkInterface[] GetAllNetworkInterfaces()
	{
		new NetworkInformationPermission(NetworkInformationAccess.Read).Demand();
		return SystemNetworkInterface.GetNetworkInterfaces();
	}

	[global::__DynamicallyInvokable]
	public static bool GetIsNetworkAvailable()
	{
		return SystemNetworkInterface.InternalGetIsNetworkAvailable();
	}

	[global::__DynamicallyInvokable]
	public virtual IPInterfaceProperties GetIPProperties()
	{
		throw new NotImplementedException();
	}

	[global::__DynamicallyInvokable]
	public virtual IPv4InterfaceStatistics GetIPv4Statistics()
	{
		throw new NotImplementedException();
	}

	[global::__DynamicallyInvokable]
	public virtual IPInterfaceStatistics GetIPStatistics()
	{
		throw new NotImplementedException();
	}

	[global::__DynamicallyInvokable]
	public virtual PhysicalAddress GetPhysicalAddress()
	{
		throw new NotImplementedException();
	}

	[global::__DynamicallyInvokable]
	public virtual bool Supports(NetworkInterfaceComponent networkInterfaceComponent)
	{
		throw new NotImplementedException();
	}

	[global::__DynamicallyInvokable]
	protected NetworkInterface()
	{
	}
}
