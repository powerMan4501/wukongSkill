using System.Security.Permissions;
using System.Threading.Tasks;

namespace System.Net.Sockets;

public class TcpListener
{
	private IPEndPoint m_ServerSocketEP;

	private Socket m_ServerSocket;

	private bool m_Active;

	private bool m_ExclusiveAddressUse;

	public Socket Server => m_ServerSocket;

	protected bool Active => m_Active;

	public EndPoint LocalEndpoint
	{
		get
		{
			if (!m_Active)
			{
				return m_ServerSocketEP;
			}
			return m_ServerSocket.LocalEndPoint;
		}
	}

	public bool ExclusiveAddressUse
	{
		get
		{
			return m_ServerSocket.ExclusiveAddressUse;
		}
		set
		{
			if (m_Active)
			{
				throw new InvalidOperationException(SR.GetString("net_tcplistener_mustbestopped"));
			}
			m_ServerSocket.ExclusiveAddressUse = value;
			m_ExclusiveAddressUse = value;
		}
	}

	public TcpListener(IPEndPoint localEP)
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.Sockets, this, "TcpListener", localEP);
		}
		if (localEP == null)
		{
			throw new ArgumentNullException("localEP");
		}
		m_ServerSocketEP = localEP;
		m_ServerSocket = new Socket(m_ServerSocketEP.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
		if (Logging.On)
		{
			Logging.Exit(Logging.Sockets, this, "TcpListener", null);
		}
	}

	public TcpListener(IPAddress localaddr, int port)
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.Sockets, this, "TcpListener", localaddr);
		}
		if (localaddr == null)
		{
			throw new ArgumentNullException("localaddr");
		}
		if (!ValidationHelper.ValidateTcpPort(port))
		{
			throw new ArgumentOutOfRangeException("port");
		}
		m_ServerSocketEP = new IPEndPoint(localaddr, port);
		m_ServerSocket = new Socket(m_ServerSocketEP.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
		if (Logging.On)
		{
			Logging.Exit(Logging.Sockets, this, "TcpListener", null);
		}
	}

	[Obsolete("This method has been deprecated. Please use TcpListener(IPAddress localaddr, int port) instead. http://go.microsoft.com/fwlink/?linkid=14202")]
	public TcpListener(int port)
	{
		if (!ValidationHelper.ValidateTcpPort(port))
		{
			throw new ArgumentOutOfRangeException("port");
		}
		m_ServerSocketEP = new IPEndPoint(IPAddress.Any, port);
		m_ServerSocket = new Socket(m_ServerSocketEP.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
	}

	public static TcpListener Create(int port)
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.Sockets, "TcpListener.Create", "Port: " + port);
		}
		if (!ValidationHelper.ValidateTcpPort(port))
		{
			throw new ArgumentOutOfRangeException("port");
		}
		TcpListener tcpListener = new TcpListener(IPAddress.IPv6Any, port);
		tcpListener.Server.DualMode = true;
		if (Logging.On)
		{
			Logging.Exit(Logging.Sockets, "TcpListener.Create", "Port: " + port);
		}
		return tcpListener;
	}

	public void AllowNatTraversal(bool allowed)
	{
		if (m_Active)
		{
			throw new InvalidOperationException(SR.GetString("net_tcplistener_mustbestopped"));
		}
		if (allowed)
		{
			m_ServerSocket.SetIPProtectionLevel(IPProtectionLevel.Unrestricted);
		}
		else
		{
			m_ServerSocket.SetIPProtectionLevel(IPProtectionLevel.EdgeRestricted);
		}
	}

	public void Start()
	{
		Start(int.MaxValue);
	}

	public void Start(int backlog)
	{
		if (backlog > int.MaxValue || backlog < 0)
		{
			throw new ArgumentOutOfRangeException("backlog");
		}
		if (Logging.On)
		{
			Logging.Enter(Logging.Sockets, this, "Start", null);
		}
		if (m_ServerSocket == null)
		{
			throw new InvalidOperationException(SR.GetString("net_InvalidSocketHandle"));
		}
		if (m_Active)
		{
			if (Logging.On)
			{
				Logging.Exit(Logging.Sockets, this, "Start", null);
			}
			return;
		}
		m_ServerSocket.Bind(m_ServerSocketEP);
		try
		{
			m_ServerSocket.Listen(backlog);
		}
		catch (SocketException)
		{
			Stop();
			throw;
		}
		m_Active = true;
		if (Logging.On)
		{
			Logging.Exit(Logging.Sockets, this, "Start", null);
		}
	}

	public void Stop()
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.Sockets, this, "Stop", null);
		}
		if (m_ServerSocket != null)
		{
			m_ServerSocket.Close();
			m_ServerSocket = null;
		}
		m_Active = false;
		m_ServerSocket = new Socket(m_ServerSocketEP.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
		if (m_ExclusiveAddressUse)
		{
			m_ServerSocket.ExclusiveAddressUse = true;
		}
		if (Logging.On)
		{
			Logging.Exit(Logging.Sockets, this, "Stop", null);
		}
	}

	public bool Pending()
	{
		if (!m_Active)
		{
			throw new InvalidOperationException(SR.GetString("net_stopped"));
		}
		return m_ServerSocket.Poll(0, SelectMode.SelectRead);
	}

	public Socket AcceptSocket()
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.Sockets, this, "AcceptSocket", null);
		}
		if (!m_Active)
		{
			throw new InvalidOperationException(SR.GetString("net_stopped"));
		}
		Socket socket = m_ServerSocket.Accept();
		if (Logging.On)
		{
			Logging.Exit(Logging.Sockets, this, "AcceptSocket", socket);
		}
		return socket;
	}

	public TcpClient AcceptTcpClient()
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.Sockets, this, "AcceptTcpClient", null);
		}
		if (!m_Active)
		{
			throw new InvalidOperationException(SR.GetString("net_stopped"));
		}
		Socket acceptedSocket = m_ServerSocket.Accept();
		TcpClient tcpClient = new TcpClient(acceptedSocket);
		if (Logging.On)
		{
			Logging.Exit(Logging.Sockets, this, "AcceptTcpClient", tcpClient);
		}
		return tcpClient;
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public IAsyncResult BeginAcceptSocket(AsyncCallback callback, object state)
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.Sockets, this, "BeginAcceptSocket", null);
		}
		if (!m_Active)
		{
			throw new InvalidOperationException(SR.GetString("net_stopped"));
		}
		IAsyncResult result = m_ServerSocket.BeginAccept(callback, state);
		if (Logging.On)
		{
			Logging.Exit(Logging.Sockets, this, "BeginAcceptSocket", null);
		}
		return result;
	}

	public Socket EndAcceptSocket(IAsyncResult asyncResult)
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.Sockets, this, "EndAcceptSocket", null);
		}
		if (asyncResult == null)
		{
			throw new ArgumentNullException("asyncResult");
		}
		Socket socket = ((!(asyncResult is LazyAsyncResult lazyAsyncResult)) ? null : (lazyAsyncResult.AsyncObject as Socket));
		if (socket == null)
		{
			throw new ArgumentException(SR.GetString("net_io_invalidasyncresult"), "asyncResult");
		}
		Socket socket2 = socket.EndAccept(asyncResult);
		if (Logging.On)
		{
			Logging.Exit(Logging.Sockets, this, "EndAcceptSocket", socket2);
		}
		return socket2;
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public IAsyncResult BeginAcceptTcpClient(AsyncCallback callback, object state)
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.Sockets, this, "BeginAcceptTcpClient", null);
		}
		if (!m_Active)
		{
			throw new InvalidOperationException(SR.GetString("net_stopped"));
		}
		IAsyncResult result = m_ServerSocket.BeginAccept(callback, state);
		if (Logging.On)
		{
			Logging.Exit(Logging.Sockets, this, "BeginAcceptTcpClient", null);
		}
		return result;
	}

	public TcpClient EndAcceptTcpClient(IAsyncResult asyncResult)
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.Sockets, this, "EndAcceptTcpClient", null);
		}
		if (asyncResult == null)
		{
			throw new ArgumentNullException("asyncResult");
		}
		Socket socket = ((!(asyncResult is LazyAsyncResult lazyAsyncResult)) ? null : (lazyAsyncResult.AsyncObject as Socket));
		if (socket == null)
		{
			throw new ArgumentException(SR.GetString("net_io_invalidasyncresult"), "asyncResult");
		}
		Socket socket2 = socket.EndAccept(asyncResult);
		if (Logging.On)
		{
			Logging.Exit(Logging.Sockets, this, "EndAcceptTcpClient", socket2);
		}
		return new TcpClient(socket2);
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public Task<Socket> AcceptSocketAsync()
	{
		return Task<Socket>.Factory.FromAsync(BeginAcceptSocket, EndAcceptSocket, null);
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public Task<TcpClient> AcceptTcpClientAsync()
	{
		return Task<TcpClient>.Factory.FromAsync(BeginAcceptTcpClient, EndAcceptTcpClient, null);
	}
}
