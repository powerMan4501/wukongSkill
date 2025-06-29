using System.Security.Permissions;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net.Sockets;

public class TcpClient : IDisposable
{
	private Socket m_ClientSocket;

	private bool m_Active;

	private NetworkStream m_DataStream;

	private AddressFamily m_Family = AddressFamily.InterNetwork;

	private bool m_CleanedUp;

	public Socket Client
	{
		get
		{
			return m_ClientSocket;
		}
		set
		{
			m_ClientSocket = value;
		}
	}

	protected bool Active
	{
		get
		{
			return m_Active;
		}
		set
		{
			m_Active = value;
		}
	}

	public int Available => m_ClientSocket.Available;

	public bool Connected => m_ClientSocket.Connected;

	public bool ExclusiveAddressUse
	{
		get
		{
			return m_ClientSocket.ExclusiveAddressUse;
		}
		set
		{
			m_ClientSocket.ExclusiveAddressUse = value;
		}
	}

	public int ReceiveBufferSize
	{
		get
		{
			return numericOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveBuffer);
		}
		set
		{
			Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveBuffer, value);
		}
	}

	public int SendBufferSize
	{
		get
		{
			return numericOption(SocketOptionLevel.Socket, SocketOptionName.SendBuffer);
		}
		set
		{
			Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.SendBuffer, value);
		}
	}

	public int ReceiveTimeout
	{
		get
		{
			return numericOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout);
		}
		set
		{
			Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout, value);
		}
	}

	public int SendTimeout
	{
		get
		{
			return numericOption(SocketOptionLevel.Socket, SocketOptionName.SendTimeout);
		}
		set
		{
			Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.SendTimeout, value);
		}
	}

	public LingerOption LingerState
	{
		get
		{
			return (LingerOption)Client.GetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Linger);
		}
		set
		{
			Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Linger, value);
		}
	}

	public bool NoDelay
	{
		get
		{
			if (numericOption(SocketOptionLevel.Tcp, SocketOptionName.Debug) == 0)
			{
				return false;
			}
			return true;
		}
		set
		{
			Client.SetSocketOption(SocketOptionLevel.Tcp, SocketOptionName.Debug, value ? 1 : 0);
		}
	}

	public TcpClient(IPEndPoint localEP)
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.Sockets, this, "TcpClient", localEP);
		}
		if (localEP == null)
		{
			throw new ArgumentNullException("localEP");
		}
		m_Family = localEP.AddressFamily;
		initialize();
		Client.Bind(localEP);
		if (Logging.On)
		{
			Logging.Exit(Logging.Sockets, this, "TcpClient", "");
		}
	}

	public TcpClient()
		: this(AddressFamily.InterNetwork)
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.Sockets, this, "TcpClient", null);
		}
		if (Logging.On)
		{
			Logging.Exit(Logging.Sockets, this, "TcpClient", null);
		}
	}

	public TcpClient(AddressFamily family)
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.Sockets, this, "TcpClient", family);
		}
		if (family != AddressFamily.InterNetwork && family != AddressFamily.InterNetworkV6)
		{
			throw new ArgumentException(SR.GetString("net_protocol_invalid_family", "TCP"), "family");
		}
		m_Family = family;
		initialize();
		if (Logging.On)
		{
			Logging.Exit(Logging.Sockets, this, "TcpClient", null);
		}
	}

	public TcpClient(string hostname, int port)
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.Sockets, this, "TcpClient", hostname);
		}
		if (hostname == null)
		{
			throw new ArgumentNullException("hostname");
		}
		if (!ValidationHelper.ValidateTcpPort(port))
		{
			throw new ArgumentOutOfRangeException("port");
		}
		try
		{
			Connect(hostname, port);
		}
		catch (Exception ex)
		{
			if (ex is ThreadAbortException || ex is StackOverflowException || ex is OutOfMemoryException)
			{
				throw;
			}
			if (m_ClientSocket != null)
			{
				m_ClientSocket.Close();
			}
			throw ex;
		}
		if (Logging.On)
		{
			Logging.Exit(Logging.Sockets, this, "TcpClient", null);
		}
	}

	internal TcpClient(Socket acceptedSocket)
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.Sockets, this, "TcpClient", acceptedSocket);
		}
		Client = acceptedSocket;
		m_Active = true;
		if (Logging.On)
		{
			Logging.Exit(Logging.Sockets, this, "TcpClient", null);
		}
	}

	public void Connect(string hostname, int port)
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.Sockets, this, "Connect", hostname);
		}
		if (m_CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		if (hostname == null)
		{
			throw new ArgumentNullException("hostname");
		}
		if (!ValidationHelper.ValidateTcpPort(port))
		{
			throw new ArgumentOutOfRangeException("port");
		}
		if (m_Active)
		{
			throw new SocketException(SocketError.IsConnected);
		}
		IPAddress[] hostAddresses = Dns.GetHostAddresses(hostname);
		Exception ex = null;
		Socket socket = null;
		Socket socket2 = null;
		try
		{
			if (m_ClientSocket == null)
			{
				if (Socket.OSSupportsIPv4)
				{
					socket2 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
				}
				if (Socket.OSSupportsIPv6)
				{
					socket = new Socket(AddressFamily.InterNetworkV6, SocketType.Stream, ProtocolType.Tcp);
				}
			}
			IPAddress[] array = hostAddresses;
			foreach (IPAddress iPAddress in array)
			{
				try
				{
					if (m_ClientSocket == null)
					{
						if (iPAddress.AddressFamily == AddressFamily.InterNetwork && socket2 != null)
						{
							socket2.Connect(iPAddress, port);
							m_ClientSocket = socket2;
							socket?.Close();
						}
						else if (socket != null)
						{
							socket.Connect(iPAddress, port);
							m_ClientSocket = socket;
							socket2?.Close();
						}
						m_Family = iPAddress.AddressFamily;
						m_Active = true;
						break;
					}
					if (iPAddress.AddressFamily == m_Family)
					{
						Connect(new IPEndPoint(iPAddress, port));
						m_Active = true;
						break;
					}
				}
				catch (Exception ex2)
				{
					if (ex2 is ThreadAbortException || ex2 is StackOverflowException || ex2 is OutOfMemoryException)
					{
						throw;
					}
					ex = ex2;
				}
			}
		}
		catch (Exception ex3)
		{
			if (ex3 is ThreadAbortException || ex3 is StackOverflowException || ex3 is OutOfMemoryException)
			{
				throw;
			}
			ex = ex3;
		}
		finally
		{
			if (!m_Active)
			{
				socket?.Close();
				socket2?.Close();
				if (ex != null)
				{
					throw ex;
				}
				throw new SocketException(SocketError.NotConnected);
			}
		}
		if (Logging.On)
		{
			Logging.Exit(Logging.Sockets, this, "Connect", null);
		}
	}

	public void Connect(IPAddress address, int port)
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.Sockets, this, "Connect", address);
		}
		if (m_CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		if (address == null)
		{
			throw new ArgumentNullException("address");
		}
		if (!ValidationHelper.ValidateTcpPort(port))
		{
			throw new ArgumentOutOfRangeException("port");
		}
		IPEndPoint remoteEP = new IPEndPoint(address, port);
		Connect(remoteEP);
		if (Logging.On)
		{
			Logging.Exit(Logging.Sockets, this, "Connect", null);
		}
	}

	public void Connect(IPEndPoint remoteEP)
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.Sockets, this, "Connect", remoteEP);
		}
		if (m_CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		if (remoteEP == null)
		{
			throw new ArgumentNullException("remoteEP");
		}
		Client.Connect(remoteEP);
		m_Active = true;
		if (Logging.On)
		{
			Logging.Exit(Logging.Sockets, this, "Connect", null);
		}
	}

	public void Connect(IPAddress[] ipAddresses, int port)
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.Sockets, this, "Connect", ipAddresses);
		}
		Client.Connect(ipAddresses, port);
		m_Active = true;
		if (Logging.On)
		{
			Logging.Exit(Logging.Sockets, this, "Connect", null);
		}
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public IAsyncResult BeginConnect(string host, int port, AsyncCallback requestCallback, object state)
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.Sockets, this, "BeginConnect", host);
		}
		IAsyncResult result = Client.BeginConnect(host, port, requestCallback, state);
		if (Logging.On)
		{
			Logging.Exit(Logging.Sockets, this, "BeginConnect", null);
		}
		return result;
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public IAsyncResult BeginConnect(IPAddress address, int port, AsyncCallback requestCallback, object state)
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.Sockets, this, "BeginConnect", address);
		}
		IAsyncResult result = Client.BeginConnect(address, port, requestCallback, state);
		if (Logging.On)
		{
			Logging.Exit(Logging.Sockets, this, "BeginConnect", null);
		}
		return result;
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public IAsyncResult BeginConnect(IPAddress[] addresses, int port, AsyncCallback requestCallback, object state)
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.Sockets, this, "BeginConnect", addresses);
		}
		IAsyncResult result = Client.BeginConnect(addresses, port, requestCallback, state);
		if (Logging.On)
		{
			Logging.Exit(Logging.Sockets, this, "BeginConnect", null);
		}
		return result;
	}

	public void EndConnect(IAsyncResult asyncResult)
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.Sockets, this, "EndConnect", asyncResult);
		}
		Client.EndConnect(asyncResult);
		m_Active = true;
		if (Logging.On)
		{
			Logging.Exit(Logging.Sockets, this, "EndConnect", null);
		}
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public Task ConnectAsync(IPAddress address, int port)
	{
		return Task.Factory.FromAsync(BeginConnect, EndConnect, address, port, null);
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public Task ConnectAsync(string host, int port)
	{
		return Task.Factory.FromAsync(BeginConnect, EndConnect, host, port, null);
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public Task ConnectAsync(IPAddress[] addresses, int port)
	{
		return Task.Factory.FromAsync(BeginConnect, EndConnect, addresses, port, null);
	}

	public NetworkStream GetStream()
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.Sockets, this, "GetStream", "");
		}
		if (m_CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		if (!Client.Connected)
		{
			throw new InvalidOperationException(SR.GetString("net_notconnected"));
		}
		if (m_DataStream == null)
		{
			m_DataStream = new NetworkStream(Client, ownsSocket: true);
		}
		if (Logging.On)
		{
			Logging.Exit(Logging.Sockets, this, "GetStream", m_DataStream);
		}
		return m_DataStream;
	}

	public void Close()
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.Sockets, this, "Close", "");
		}
		((IDisposable)this).Dispose();
		if (Logging.On)
		{
			Logging.Exit(Logging.Sockets, this, "Close", "");
		}
	}

	protected virtual void Dispose(bool disposing)
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.Sockets, this, "Dispose", "");
		}
		if (m_CleanedUp)
		{
			if (Logging.On)
			{
				Logging.Exit(Logging.Sockets, this, "Dispose", "");
			}
			return;
		}
		if (disposing)
		{
			IDisposable dataStream = m_DataStream;
			if (dataStream != null)
			{
				dataStream.Dispose();
			}
			else
			{
				Socket client = Client;
				if (client != null)
				{
					try
					{
						client.InternalShutdown(SocketShutdown.Both);
					}
					finally
					{
						client.Close();
						Client = null;
					}
				}
			}
			GC.SuppressFinalize(this);
		}
		m_CleanedUp = true;
		if (Logging.On)
		{
			Logging.Exit(Logging.Sockets, this, "Dispose", "");
		}
	}

	public void Dispose()
	{
		Dispose(disposing: true);
	}

	~TcpClient()
	{
		Dispose(disposing: false);
	}

	private void initialize()
	{
		Client = new Socket(m_Family, SocketType.Stream, ProtocolType.Tcp);
		m_Active = false;
	}

	private int numericOption(SocketOptionLevel optionLevel, SocketOptionName optionName)
	{
		return (int)Client.GetSocketOption(optionLevel, optionName);
	}
}
