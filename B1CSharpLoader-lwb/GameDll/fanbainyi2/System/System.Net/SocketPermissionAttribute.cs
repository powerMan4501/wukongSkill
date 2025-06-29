using System.Globalization;
using System.Security;
using System.Security.Permissions;
using System.Threading;

namespace System.Net;

[Serializable]
[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
public sealed class SocketPermissionAttribute : CodeAccessSecurityAttribute
{
	private string m_access;

	private string m_host;

	private string m_port;

	private string m_transport;

	private const string strAccess = "Access";

	private const string strConnect = "Connect";

	private const string strAccept = "Accept";

	private const string strHost = "Host";

	private const string strTransport = "Transport";

	private const string strPort = "Port";

	public string Access
	{
		get
		{
			return m_access;
		}
		set
		{
			if (m_access != null)
			{
				throw new ArgumentException(SR.GetString("net_perm_attrib_multi", "Access", value), "value");
			}
			m_access = value;
		}
	}

	public string Host
	{
		get
		{
			return m_host;
		}
		set
		{
			if (m_host != null)
			{
				throw new ArgumentException(SR.GetString("net_perm_attrib_multi", "Host", value), "value");
			}
			m_host = value;
		}
	}

	public string Transport
	{
		get
		{
			return m_transport;
		}
		set
		{
			if (m_transport != null)
			{
				throw new ArgumentException(SR.GetString("net_perm_attrib_multi", "Transport", value), "value");
			}
			m_transport = value;
		}
	}

	public string Port
	{
		get
		{
			return m_port;
		}
		set
		{
			if (m_port != null)
			{
				throw new ArgumentException(SR.GetString("net_perm_attrib_multi", "Port", value), "value");
			}
			m_port = value;
		}
	}

	public SocketPermissionAttribute(SecurityAction action)
		: base(action)
	{
	}

	public override IPermission CreatePermission()
	{
		SocketPermission socketPermission = null;
		if (base.Unrestricted)
		{
			socketPermission = new SocketPermission(PermissionState.Unrestricted);
		}
		else
		{
			socketPermission = new SocketPermission(PermissionState.None);
			if (m_access == null)
			{
				throw new ArgumentException(SR.GetString("net_perm_attrib_count", "Access"));
			}
			if (m_host == null)
			{
				throw new ArgumentException(SR.GetString("net_perm_attrib_count", "Host"));
			}
			if (m_transport == null)
			{
				throw new ArgumentException(SR.GetString("net_perm_attrib_count", "Transport"));
			}
			if (m_port == null)
			{
				throw new ArgumentException(SR.GetString("net_perm_attrib_count", "Port"));
			}
			ParseAddPermissions(socketPermission);
		}
		return socketPermission;
	}

	private void ParseAddPermissions(SocketPermission perm)
	{
		NetworkAccess access;
		if (string.Compare(m_access, "Connect", StringComparison.OrdinalIgnoreCase) == 0)
		{
			access = NetworkAccess.Connect;
		}
		else
		{
			if (string.Compare(m_access, "Accept", StringComparison.OrdinalIgnoreCase) != 0)
			{
				throw new ArgumentException(SR.GetString("net_perm_invalid_val", "Access", m_access));
			}
			access = NetworkAccess.Accept;
		}
		TransportType transport;
		try
		{
			transport = (TransportType)Enum.Parse(typeof(TransportType), m_transport, ignoreCase: true);
		}
		catch (Exception ex)
		{
			if (ex is ThreadAbortException || ex is StackOverflowException || ex is OutOfMemoryException)
			{
				throw;
			}
			throw new ArgumentException(SR.GetString("net_perm_invalid_val", "Transport", m_transport), ex);
		}
		if (string.Compare(m_port, "All", StringComparison.OrdinalIgnoreCase) == 0)
		{
			m_port = "-1";
		}
		int num;
		try
		{
			num = int.Parse(m_port, NumberFormatInfo.InvariantInfo);
		}
		catch (Exception ex2)
		{
			if (ex2 is ThreadAbortException || ex2 is StackOverflowException || ex2 is OutOfMemoryException)
			{
				throw;
			}
			throw new ArgumentException(SR.GetString("net_perm_invalid_val", "Port", m_port), ex2);
		}
		if (!ValidationHelper.ValidateTcpPort(num) && num != -1)
		{
			throw new ArgumentOutOfRangeException("port", num, SR.GetString("net_perm_invalid_val", "Port", m_port));
		}
		perm.AddPermission(access, transport, m_host, num);
	}
}
