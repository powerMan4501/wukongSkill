using System.Globalization;
using System.Net.Sockets;

namespace System.Net;

[Serializable]
[global::__DynamicallyInvokable]
public class IPEndPoint : EndPoint
{
	[global::__DynamicallyInvokable]
	public const int MinPort = 0;

	[global::__DynamicallyInvokable]
	public const int MaxPort = 65535;

	private IPAddress m_Address;

	private int m_Port;

	internal const int AnyPort = 0;

	internal static IPEndPoint Any = new IPEndPoint(IPAddress.Any, 0);

	internal static IPEndPoint IPv6Any = new IPEndPoint(IPAddress.IPv6Any, 0);

	[global::__DynamicallyInvokable]
	public override AddressFamily AddressFamily
	{
		[global::__DynamicallyInvokable]
		get
		{
			return m_Address.AddressFamily;
		}
	}

	[global::__DynamicallyInvokable]
	public IPAddress Address
	{
		[global::__DynamicallyInvokable]
		get
		{
			return m_Address;
		}
		[global::__DynamicallyInvokable]
		set
		{
			m_Address = value;
		}
	}

	[global::__DynamicallyInvokable]
	public int Port
	{
		[global::__DynamicallyInvokable]
		get
		{
			return m_Port;
		}
		[global::__DynamicallyInvokable]
		set
		{
			if (!ValidationHelper.ValidateTcpPort(value))
			{
				throw new ArgumentOutOfRangeException("value");
			}
			m_Port = value;
		}
	}

	[global::__DynamicallyInvokable]
	public IPEndPoint(long address, int port)
	{
		if (!ValidationHelper.ValidateTcpPort(port))
		{
			throw new ArgumentOutOfRangeException("port");
		}
		m_Port = port;
		m_Address = new IPAddress(address);
	}

	[global::__DynamicallyInvokable]
	public IPEndPoint(IPAddress address, int port)
	{
		if (address == null)
		{
			throw new ArgumentNullException("address");
		}
		if (!ValidationHelper.ValidateTcpPort(port))
		{
			throw new ArgumentOutOfRangeException("port");
		}
		m_Port = port;
		m_Address = address;
	}

	[global::__DynamicallyInvokable]
	public override string ToString()
	{
		string format = ((m_Address.AddressFamily != AddressFamily.InterNetworkV6) ? "{0}:{1}" : "[{0}]:{1}");
		return string.Format(format, m_Address.ToString(), Port.ToString(NumberFormatInfo.InvariantInfo));
	}

	[global::__DynamicallyInvokable]
	public override SocketAddress Serialize()
	{
		return new SocketAddress(Address, Port);
	}

	[global::__DynamicallyInvokable]
	public override EndPoint Create(SocketAddress socketAddress)
	{
		if (socketAddress.Family != AddressFamily)
		{
			throw new ArgumentException(SR.GetString("net_InvalidAddressFamily", socketAddress.Family.ToString(), GetType().FullName, AddressFamily.ToString()), "socketAddress");
		}
		if (socketAddress.Size < 8)
		{
			throw new ArgumentException(SR.GetString("net_InvalidSocketAddressSize", socketAddress.GetType().FullName, GetType().FullName), "socketAddress");
		}
		return socketAddress.GetIPEndPoint();
	}

	[global::__DynamicallyInvokable]
	public override bool Equals(object comparand)
	{
		if (!(comparand is IPEndPoint))
		{
			return false;
		}
		if (((IPEndPoint)comparand).m_Address.Equals(m_Address))
		{
			return ((IPEndPoint)comparand).m_Port == m_Port;
		}
		return false;
	}

	[global::__DynamicallyInvokable]
	public override int GetHashCode()
	{
		return m_Address.GetHashCode() ^ m_Port;
	}

	internal IPEndPoint Snapshot()
	{
		return new IPEndPoint(Address.Snapshot(), Port);
	}
}
