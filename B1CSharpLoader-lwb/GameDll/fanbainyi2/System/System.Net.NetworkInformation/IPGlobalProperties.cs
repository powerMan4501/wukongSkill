using System.Security.Permissions;
using System.Threading.Tasks;

namespace System.Net.NetworkInformation;

[global::__DynamicallyInvokable]
public abstract class IPGlobalProperties
{
	[global::__DynamicallyInvokable]
	public abstract string DhcpScopeName
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	public abstract string DomainName
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	public abstract string HostName
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	public abstract bool IsWinsProxy
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	public abstract NetBiosNodeType NodeType
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	public static IPGlobalProperties GetIPGlobalProperties()
	{
		new NetworkInformationPermission(NetworkInformationAccess.Read).Demand();
		return new SystemIPGlobalProperties();
	}

	internal static IPGlobalProperties InternalGetIPGlobalProperties()
	{
		return new SystemIPGlobalProperties();
	}

	[global::__DynamicallyInvokable]
	public abstract IPEndPoint[] GetActiveUdpListeners();

	[global::__DynamicallyInvokable]
	public abstract IPEndPoint[] GetActiveTcpListeners();

	[global::__DynamicallyInvokable]
	public abstract TcpConnectionInformation[] GetActiveTcpConnections();

	[global::__DynamicallyInvokable]
	public abstract TcpStatistics GetTcpIPv4Statistics();

	[global::__DynamicallyInvokable]
	public abstract TcpStatistics GetTcpIPv6Statistics();

	[global::__DynamicallyInvokable]
	public abstract UdpStatistics GetUdpIPv4Statistics();

	[global::__DynamicallyInvokable]
	public abstract UdpStatistics GetUdpIPv6Statistics();

	[global::__DynamicallyInvokable]
	public abstract IcmpV4Statistics GetIcmpV4Statistics();

	[global::__DynamicallyInvokable]
	public abstract IcmpV6Statistics GetIcmpV6Statistics();

	[global::__DynamicallyInvokable]
	public abstract IPGlobalStatistics GetIPv4GlobalStatistics();

	[global::__DynamicallyInvokable]
	public abstract IPGlobalStatistics GetIPv6GlobalStatistics();

	[global::__DynamicallyInvokable]
	public virtual UnicastIPAddressInformationCollection GetUnicastAddresses()
	{
		throw ExceptionHelper.MethodNotImplementedException;
	}

	[global::__DynamicallyInvokable]
	public virtual IAsyncResult BeginGetUnicastAddresses(AsyncCallback callback, object state)
	{
		throw ExceptionHelper.MethodNotImplementedException;
	}

	[global::__DynamicallyInvokable]
	public virtual UnicastIPAddressInformationCollection EndGetUnicastAddresses(IAsyncResult asyncResult)
	{
		throw ExceptionHelper.MethodNotImplementedException;
	}

	[global::__DynamicallyInvokable]
	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public virtual Task<UnicastIPAddressInformationCollection> GetUnicastAddressesAsync()
	{
		return Task<UnicastIPAddressInformationCollection>.Factory.FromAsync(BeginGetUnicastAddresses, EndGetUnicastAddresses, null);
	}

	[global::__DynamicallyInvokable]
	protected IPGlobalProperties()
	{
	}
}
