using System.Net.Sockets;

namespace System.Net;

[global::__DynamicallyInvokable]
public class DnsEndPoint : EndPoint
{
	private string m_Host;

	private int m_Port;

	private AddressFamily m_Family;

	[global::__DynamicallyInvokable]
	public string Host
	{
		[global::__DynamicallyInvokable]
		get
		{
			return m_Host;
		}
	}

	[global::__DynamicallyInvokable]
	public override AddressFamily AddressFamily
	{
		[global::__DynamicallyInvokable]
		get
		{
			return m_Family;
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
	}

	[global::__DynamicallyInvokable]
	public DnsEndPoint(string host, int port)
		: this(host, port, AddressFamily.Unspecified)
	{
	}

	[global::__DynamicallyInvokable]
	public DnsEndPoint(string host, int port, AddressFamily addressFamily)
	{
		if (host == null)
		{
			throw new ArgumentNullException("host");
		}
		if (string.IsNullOrEmpty(host))
		{
			throw new ArgumentException(SR.GetString("net_emptystringcall", "host"));
		}
		if (port < 0 || port > 65535)
		{
			throw new ArgumentOutOfRangeException("port");
		}
		if (addressFamily != AddressFamily.InterNetwork && addressFamily != AddressFamily.InterNetworkV6 && addressFamily != AddressFamily.Unspecified)
		{
			throw new ArgumentException(SR.GetString("net_sockets_invalid_optionValue_all"), "addressFamily");
		}
		m_Host = host;
		m_Port = port;
		m_Family = addressFamily;
	}

	[global::__DynamicallyInvokable]
	public override bool Equals(object comparand)
	{
		if (!(comparand is DnsEndPoint dnsEndPoint))
		{
			return false;
		}
		if (m_Family == dnsEndPoint.m_Family && m_Port == dnsEndPoint.m_Port)
		{
			return m_Host == dnsEndPoint.m_Host;
		}
		return false;
	}

	[global::__DynamicallyInvokable]
	public override int GetHashCode()
	{
		return StringComparer.InvariantCultureIgnoreCase.GetHashCode(ToString());
	}

	[global::__DynamicallyInvokable]
	public override string ToString()
	{
		return m_Family.ToString() + "/" + m_Host + ":" + m_Port;
	}
}
