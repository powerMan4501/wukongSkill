using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net.Configuration;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net.Sockets;

public class Socket : IDisposable
{
	private class CacheSet
	{
		internal CallbackClosure ConnectClosureCache;

		internal CallbackClosure AcceptClosureCache;

		internal CallbackClosure SendClosureCache;

		internal CallbackClosure ReceiveClosureCache;

		internal OverlappedCache SendOverlappedCache;

		internal OverlappedCache ReceiveOverlappedCache;
	}

	private class MultipleAddressConnectAsyncResult : ContextAwareResult
	{
		internal Socket socket;

		internal IPAddress[] addresses;

		internal int index;

		internal int port;

		internal Exception lastException;

		internal EndPoint RemoteEndPoint
		{
			get
			{
				if (addresses != null && index > 0 && index < addresses.Length)
				{
					return new IPEndPoint(addresses[index], port);
				}
				return null;
			}
		}

		internal MultipleAddressConnectAsyncResult(IPAddress[] addresses, int port, Socket socket, object myState, AsyncCallback myCallBack)
			: base(socket, myState, myCallBack)
		{
			this.addresses = addresses;
			this.port = port;
			this.socket = socket;
		}
	}

	private class StateTaskCompletionSource<TField1, TResult> : TaskCompletionSource<TResult>
	{
		internal TField1 _field1;

		public StateTaskCompletionSource(object baseState)
			: base(baseState)
		{
		}
	}

	private class StateTaskCompletionSource<TField1, TField2, TResult> : StateTaskCompletionSource<TField1, TResult>
	{
		internal TField2 _field2;

		public StateTaskCompletionSource(object baseState)
			: base(baseState)
		{
		}
	}

	private sealed class CachedTaskEventArgs
	{
		public TaskSocketAsyncEventArgs<Socket> Accept;

		public Int32TaskSocketAsyncEventArgs Receive;

		public Int32TaskSocketAsyncEventArgs Send;
	}

	private class TaskSocketAsyncEventArgs<TResult> : SocketAsyncEventArgs
	{
		internal AsyncTaskMethodBuilder<TResult> _builder;

		internal bool _accessed;

		internal AsyncTaskMethodBuilder<TResult> GetCompletionResponsibility(out bool responsibleForReturningToPool)
		{
			lock (this)
			{
				responsibleForReturningToPool = _accessed;
				_accessed = true;
				Task<TResult> task = _builder.Task;
				return _builder;
			}
		}
	}

	private sealed class Int32TaskSocketAsyncEventArgs : TaskSocketAsyncEventArgs<int>
	{
		internal Task<int> _successfullyCompletedTask;

		internal bool _wrapExceptionsInIOExceptions;
	}

	internal const int DefaultCloseTimeout = -1;

	private object m_AcceptQueueOrConnectResult;

	private int asyncConnectOperationLock;

	private SafeCloseSocket m_Handle;

	internal EndPoint m_RightEndPoint;

	internal EndPoint m_RemoteEndPoint;

	private bool m_IsConnected;

	private bool m_IsDisconnected;

	private bool willBlock = true;

	private bool willBlockInternal = true;

	private bool isListening;

	private bool m_NonBlockingConnectInProgress;

	private EndPoint m_NonBlockingConnectRightEndPoint;

	private AddressFamily addressFamily;

	private SocketType socketType;

	private ProtocolType protocolType;

	private CacheSet m_Caches;

	internal static volatile bool UseOverlappedIO;

	private bool useOverlappedIO;

	private bool m_BoundToThreadPool;

	private bool m_ReceivingPacketInformation;

	private ManualResetEvent m_AsyncEvent;

	private RegisteredWaitHandle m_RegisteredWait;

	private AsyncEventBits m_BlockEventBits;

	private SocketAddress m_PermittedRemoteAddress;

	private DynamicWinsockMethods m_DynamicWinsockMethods;

	private static object s_InternalSyncObject;

	private int m_CloseTimeout = -1;

	private int m_IntCleanedUp;

	private const int microcnv = 1000000;

	private static readonly int protocolInformationSize = Marshal.SizeOf(typeof(UnsafeNclNativeMethods.OSSOCK.WSAPROTOCOL_INFO));

	internal static volatile bool s_SupportsIPv4;

	internal static volatile bool s_SupportsIPv6;

	internal static volatile bool s_OSSupportsIPv6;

	internal static volatile bool s_Initialized;

	private static volatile WaitOrTimerCallback s_RegisteredWaitCallback;

	private static volatile bool s_LoggingEnabled;

	internal static volatile bool s_PerfCountersEnabled;

	private static readonly EventHandler<SocketAsyncEventArgs> AcceptCompletedHandler = delegate(object s, SocketAsyncEventArgs e)
	{
		CompleteAccept((Socket)s, (TaskSocketAsyncEventArgs<Socket>)e);
	};

	private static readonly EventHandler<SocketAsyncEventArgs> ReceiveCompletedHandler = delegate(object s, SocketAsyncEventArgs e)
	{
		CompleteSendReceive((Socket)s, (Int32TaskSocketAsyncEventArgs)e, isReceive: true);
	};

	private static readonly EventHandler<SocketAsyncEventArgs> SendCompletedHandler = delegate(object s, SocketAsyncEventArgs e)
	{
		CompleteSendReceive((Socket)s, (Int32TaskSocketAsyncEventArgs)e, isReceive: false);
	};

	private static readonly TaskSocketAsyncEventArgs<Socket> s_rentedSocketSentinel = new TaskSocketAsyncEventArgs<Socket>();

	private static readonly Int32TaskSocketAsyncEventArgs s_rentedInt32Sentinel = new Int32TaskSocketAsyncEventArgs();

	private static readonly Task<int> s_zeroTask = Task.FromResult(0);

	private CachedTaskEventArgs _cachedTaskEventArgs;

	[Obsolete("SupportsIPv4 is obsoleted for this type, please use OSSupportsIPv4 instead. http://go.microsoft.com/fwlink/?linkid=14202")]
	public static bool SupportsIPv4
	{
		get
		{
			InitializeSockets();
			return s_SupportsIPv4;
		}
	}

	public static bool OSSupportsIPv4
	{
		get
		{
			InitializeSockets();
			return s_SupportsIPv4;
		}
	}

	[Obsolete("SupportsIPv6 is obsoleted for this type, please use OSSupportsIPv6 instead. http://go.microsoft.com/fwlink/?linkid=14202")]
	public static bool SupportsIPv6
	{
		get
		{
			InitializeSockets();
			return s_SupportsIPv6;
		}
	}

	internal static bool LegacySupportsIPv6
	{
		get
		{
			InitializeSockets();
			return s_SupportsIPv6;
		}
	}

	public static bool OSSupportsIPv6
	{
		get
		{
			InitializeSockets();
			return s_OSSupportsIPv6;
		}
	}

	public int Available
	{
		get
		{
			if (CleanedUp)
			{
				throw new ObjectDisposedException(GetType().FullName);
			}
			int argp = 0;
			SocketError socketError = UnsafeNclNativeMethods.OSSOCK.ioctlsocket(m_Handle, 1074030207, ref argp);
			if (socketError == SocketError.SocketError)
			{
				SocketException ex = new SocketException();
				UpdateStatusAfterSocketError(ex);
				if (s_LoggingEnabled)
				{
					Logging.Exception(Logging.Sockets, this, "Available", ex);
				}
				throw ex;
			}
			return argp;
		}
	}

	public EndPoint LocalEndPoint
	{
		get
		{
			if (CleanedUp)
			{
				throw new ObjectDisposedException(GetType().FullName);
			}
			if (m_NonBlockingConnectInProgress && Poll(0, SelectMode.SelectWrite))
			{
				m_IsConnected = true;
				m_RightEndPoint = m_NonBlockingConnectRightEndPoint;
				m_NonBlockingConnectInProgress = false;
			}
			if (m_RightEndPoint == null)
			{
				return null;
			}
			SocketAddress socketAddress = m_RightEndPoint.Serialize();
			if (UnsafeNclNativeMethods.OSSOCK.getsockname(m_Handle, socketAddress.m_Buffer, ref socketAddress.m_Size) != SocketError.Success)
			{
				SocketException ex = new SocketException();
				UpdateStatusAfterSocketError(ex);
				if (s_LoggingEnabled)
				{
					Logging.Exception(Logging.Sockets, this, "LocalEndPoint", ex);
				}
				throw ex;
			}
			return m_RightEndPoint.Create(socketAddress);
		}
	}

	public EndPoint RemoteEndPoint
	{
		get
		{
			if (CleanedUp)
			{
				throw new ObjectDisposedException(GetType().FullName);
			}
			if (m_RemoteEndPoint == null)
			{
				if (m_NonBlockingConnectInProgress && Poll(0, SelectMode.SelectWrite))
				{
					m_IsConnected = true;
					m_RightEndPoint = m_NonBlockingConnectRightEndPoint;
					m_NonBlockingConnectInProgress = false;
				}
				if (m_RightEndPoint == null)
				{
					return null;
				}
				SocketAddress socketAddress = m_RightEndPoint.Serialize();
				if (UnsafeNclNativeMethods.OSSOCK.getpeername(m_Handle, socketAddress.m_Buffer, ref socketAddress.m_Size) != SocketError.Success)
				{
					SocketException ex = new SocketException();
					UpdateStatusAfterSocketError(ex);
					if (s_LoggingEnabled)
					{
						Logging.Exception(Logging.Sockets, this, "RemoteEndPoint", ex);
					}
					throw ex;
				}
				try
				{
					m_RemoteEndPoint = m_RightEndPoint.Create(socketAddress);
				}
				catch
				{
				}
			}
			return m_RemoteEndPoint;
		}
	}

	public IntPtr Handle
	{
		get
		{
			ExceptionHelper.UnmanagedPermission.Demand();
			return m_Handle.DangerousGetHandle();
		}
	}

	internal SafeCloseSocket SafeHandle => m_Handle;

	public bool Blocking
	{
		get
		{
			return willBlock;
		}
		set
		{
			if (CleanedUp)
			{
				throw new ObjectDisposedException(GetType().FullName);
			}
			bool current;
			SocketError socketError = InternalSetBlocking(value, out current);
			if (socketError != SocketError.Success)
			{
				SocketException ex = new SocketException(socketError);
				UpdateStatusAfterSocketError(ex);
				if (s_LoggingEnabled)
				{
					Logging.Exception(Logging.Sockets, this, "Blocking", ex);
				}
				throw ex;
			}
			willBlock = current;
		}
	}

	public bool UseOnlyOverlappedIO
	{
		get
		{
			return useOverlappedIO;
		}
		set
		{
			if (m_BoundToThreadPool)
			{
				throw new InvalidOperationException(SR.GetString("net_io_completionportwasbound"));
			}
			useOverlappedIO = value;
		}
	}

	public bool Connected
	{
		get
		{
			if (m_NonBlockingConnectInProgress && Poll(0, SelectMode.SelectWrite))
			{
				m_IsConnected = true;
				m_RightEndPoint = m_NonBlockingConnectRightEndPoint;
				m_NonBlockingConnectInProgress = false;
			}
			return m_IsConnected;
		}
	}

	public AddressFamily AddressFamily => addressFamily;

	public SocketType SocketType => socketType;

	public ProtocolType ProtocolType => protocolType;

	public bool IsBound => m_RightEndPoint != null;

	public bool ExclusiveAddressUse
	{
		get
		{
			if ((int)GetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ExclusiveAddressUse) == 0)
			{
				return false;
			}
			return true;
		}
		set
		{
			if (IsBound)
			{
				throw new InvalidOperationException(SR.GetString("net_sockets_mustnotbebound"));
			}
			SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ExclusiveAddressUse, value ? 1 : 0);
		}
	}

	public int ReceiveBufferSize
	{
		get
		{
			return (int)GetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveBuffer);
		}
		set
		{
			if (value < 0)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveBuffer, value);
		}
	}

	public int SendBufferSize
	{
		get
		{
			return (int)GetSocketOption(SocketOptionLevel.Socket, SocketOptionName.SendBuffer);
		}
		set
		{
			if (value < 0)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.SendBuffer, value);
		}
	}

	public int ReceiveTimeout
	{
		get
		{
			return (int)GetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout);
		}
		set
		{
			if (value < -1)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			if (value == -1)
			{
				value = 0;
			}
			SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout, value);
		}
	}

	public int SendTimeout
	{
		get
		{
			return (int)GetSocketOption(SocketOptionLevel.Socket, SocketOptionName.SendTimeout);
		}
		set
		{
			if (value < -1)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			if (value == -1)
			{
				value = 0;
			}
			SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.SendTimeout, value);
		}
	}

	public LingerOption LingerState
	{
		get
		{
			return (LingerOption)GetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Linger);
		}
		set
		{
			SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Linger, value);
		}
	}

	public bool NoDelay
	{
		get
		{
			if ((int)GetSocketOption(SocketOptionLevel.Tcp, SocketOptionName.Debug) == 0)
			{
				return false;
			}
			return true;
		}
		set
		{
			SetSocketOption(SocketOptionLevel.Tcp, SocketOptionName.Debug, value ? 1 : 0);
		}
	}

	public short Ttl
	{
		get
		{
			if (addressFamily == AddressFamily.InterNetwork)
			{
				return (short)(int)GetSocketOption(SocketOptionLevel.IP, SocketOptionName.ReuseAddress);
			}
			if (addressFamily == AddressFamily.InterNetworkV6)
			{
				return (short)(int)GetSocketOption(SocketOptionLevel.IPv6, SocketOptionName.ReuseAddress);
			}
			throw new NotSupportedException(SR.GetString("net_invalidversion"));
		}
		set
		{
			if (value < 0 || value > 255)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			if (addressFamily == AddressFamily.InterNetwork)
			{
				SetSocketOption(SocketOptionLevel.IP, SocketOptionName.ReuseAddress, value);
				return;
			}
			if (addressFamily == AddressFamily.InterNetworkV6)
			{
				SetSocketOption(SocketOptionLevel.IPv6, SocketOptionName.ReuseAddress, value);
				return;
			}
			throw new NotSupportedException(SR.GetString("net_invalidversion"));
		}
	}

	public bool DontFragment
	{
		get
		{
			if (addressFamily == AddressFamily.InterNetwork)
			{
				if ((int)GetSocketOption(SocketOptionLevel.IP, SocketOptionName.DontFragment) == 0)
				{
					return false;
				}
				return true;
			}
			throw new NotSupportedException(SR.GetString("net_invalidversion"));
		}
		set
		{
			if (addressFamily == AddressFamily.InterNetwork)
			{
				SetSocketOption(SocketOptionLevel.IP, SocketOptionName.DontFragment, value ? 1 : 0);
				return;
			}
			throw new NotSupportedException(SR.GetString("net_invalidversion"));
		}
	}

	public bool MulticastLoopback
	{
		get
		{
			if (addressFamily == AddressFamily.InterNetwork)
			{
				if ((int)GetSocketOption(SocketOptionLevel.IP, SocketOptionName.MulticastLoopback) == 0)
				{
					return false;
				}
				return true;
			}
			if (addressFamily == AddressFamily.InterNetworkV6)
			{
				if ((int)GetSocketOption(SocketOptionLevel.IPv6, SocketOptionName.MulticastLoopback) == 0)
				{
					return false;
				}
				return true;
			}
			throw new NotSupportedException(SR.GetString("net_invalidversion"));
		}
		set
		{
			if (addressFamily == AddressFamily.InterNetwork)
			{
				SetSocketOption(SocketOptionLevel.IP, SocketOptionName.MulticastLoopback, value ? 1 : 0);
				return;
			}
			if (addressFamily == AddressFamily.InterNetworkV6)
			{
				SetSocketOption(SocketOptionLevel.IPv6, SocketOptionName.MulticastLoopback, value ? 1 : 0);
				return;
			}
			throw new NotSupportedException(SR.GetString("net_invalidversion"));
		}
	}

	public bool EnableBroadcast
	{
		get
		{
			if ((int)GetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast) == 0)
			{
				return false;
			}
			return true;
		}
		set
		{
			SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, value ? 1 : 0);
		}
	}

	public bool DualMode
	{
		get
		{
			if (AddressFamily != AddressFamily.InterNetworkV6)
			{
				throw new NotSupportedException(SR.GetString("net_invalidversion"));
			}
			return (int)GetSocketOption(SocketOptionLevel.IPv6, SocketOptionName.IPv6Only) == 0;
		}
		set
		{
			if (AddressFamily != AddressFamily.InterNetworkV6)
			{
				throw new NotSupportedException(SR.GetString("net_invalidversion"));
			}
			SetSocketOption(SocketOptionLevel.IPv6, SocketOptionName.IPv6Only, (!value) ? 1 : 0);
		}
	}

	private bool IsDualMode
	{
		get
		{
			if (AddressFamily == AddressFamily.InterNetworkV6)
			{
				return DualMode;
			}
			return false;
		}
	}

	private bool CanUseAcceptEx
	{
		get
		{
			if (!Thread.CurrentThread.IsThreadPoolThread && !SettingsSectionInternal.Section.AlwaysUseCompletionPortsForAccept)
			{
				return m_IsDisconnected;
			}
			return true;
		}
	}

	private static object InternalSyncObject
	{
		get
		{
			if (s_InternalSyncObject == null)
			{
				object value = new object();
				Interlocked.CompareExchange(ref s_InternalSyncObject, value, null);
			}
			return s_InternalSyncObject;
		}
	}

	private CacheSet Caches
	{
		get
		{
			if (m_Caches == null)
			{
				m_Caches = new CacheSet();
			}
			return m_Caches;
		}
	}

	internal bool CleanedUp => m_IntCleanedUp == 1;

	internal TransportType Transport
	{
		get
		{
			if (protocolType != ProtocolType.Tcp)
			{
				if (protocolType != ProtocolType.Udp)
				{
					return TransportType.All;
				}
				return TransportType.Udp;
			}
			return TransportType.Tcp;
		}
	}

	public Socket(SocketType socketType, ProtocolType protocolType)
		: this(AddressFamily.InterNetworkV6, socketType, protocolType)
	{
		DualMode = true;
	}

	public Socket(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType)
	{
		s_LoggingEnabled = Logging.On;
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "Socket", addressFamily);
		}
		InitializeSockets();
		m_Handle = SafeCloseSocket.CreateWSASocket(addressFamily, socketType, protocolType);
		if (m_Handle.IsInvalid)
		{
			throw new SocketException();
		}
		this.addressFamily = addressFamily;
		this.socketType = socketType;
		this.protocolType = protocolType;
		IPProtectionLevel iPProtectionLevel = SettingsSectionInternal.Section.IPProtectionLevel;
		if (iPProtectionLevel != IPProtectionLevel.Unspecified)
		{
			SetIPProtectionLevel(iPProtectionLevel);
		}
		if (s_LoggingEnabled)
		{
			Logging.Exit(Logging.Sockets, this, "Socket", null);
		}
	}

	public unsafe Socket(SocketInformation socketInformation)
	{
		s_LoggingEnabled = Logging.On;
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "Socket", addressFamily);
		}
		ExceptionHelper.UnrestrictedSocketPermission.Demand();
		InitializeSockets();
		if (socketInformation.ProtocolInformation == null || socketInformation.ProtocolInformation.Length < protocolInformationSize)
		{
			throw new ArgumentException(SR.GetString("net_sockets_invalid_socketinformation"), "socketInformation.ProtocolInformation");
		}
		fixed (byte* protocolInformation = socketInformation.ProtocolInformation)
		{
			m_Handle = SafeCloseSocket.CreateWSASocket(protocolInformation);
			UnsafeNclNativeMethods.OSSOCK.WSAPROTOCOL_INFO wSAPROTOCOL_INFO = (UnsafeNclNativeMethods.OSSOCK.WSAPROTOCOL_INFO)Marshal.PtrToStructure((IntPtr)protocolInformation, typeof(UnsafeNclNativeMethods.OSSOCK.WSAPROTOCOL_INFO));
			addressFamily = wSAPROTOCOL_INFO.iAddressFamily;
			socketType = (SocketType)wSAPROTOCOL_INFO.iSocketType;
			protocolType = (ProtocolType)wSAPROTOCOL_INFO.iProtocol;
		}
		if (m_Handle.IsInvalid)
		{
			SocketException ex = new SocketException();
			if (ex.ErrorCode == 10022)
			{
				throw new ArgumentException(SR.GetString("net_sockets_invalid_socketinformation"), "socketInformation");
			}
			throw ex;
		}
		if (addressFamily != AddressFamily.InterNetwork && addressFamily != AddressFamily.InterNetworkV6)
		{
			throw new NotSupportedException(SR.GetString("net_invalidversion"));
		}
		m_IsConnected = socketInformation.IsConnected;
		willBlock = !socketInformation.IsNonBlocking;
		InternalSetBlocking(willBlock);
		isListening = socketInformation.IsListening;
		UseOnlyOverlappedIO = socketInformation.UseOnlyOverlappedIO;
		if (socketInformation.RemoteEndPoint != null)
		{
			m_RightEndPoint = socketInformation.RemoteEndPoint;
			m_RemoteEndPoint = socketInformation.RemoteEndPoint;
		}
		else
		{
			EndPoint endPoint = null;
			if (addressFamily == AddressFamily.InterNetwork)
			{
				endPoint = IPEndPoint.Any;
			}
			else if (addressFamily == AddressFamily.InterNetworkV6)
			{
				endPoint = IPEndPoint.IPv6Any;
			}
			SocketAddress socketAddress = endPoint.Serialize();
			SocketError socketError;
			try
			{
				socketError = UnsafeNclNativeMethods.OSSOCK.getsockname(m_Handle, socketAddress.m_Buffer, ref socketAddress.m_Size);
			}
			catch (ObjectDisposedException)
			{
				socketError = SocketError.NotSocket;
			}
			if (socketError == SocketError.Success)
			{
				try
				{
					m_RightEndPoint = endPoint.Create(socketAddress);
				}
				catch
				{
				}
			}
		}
		if (s_LoggingEnabled)
		{
			Logging.Exit(Logging.Sockets, this, "Socket", null);
		}
	}

	private Socket(SafeCloseSocket fd)
	{
		s_LoggingEnabled = Logging.On;
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "Socket", null);
		}
		InitializeSockets();
		if (fd == null || fd.IsInvalid)
		{
			throw new ArgumentException(SR.GetString("net_InvalidSocketHandle"));
		}
		m_Handle = fd;
		addressFamily = AddressFamily.Unknown;
		socketType = SocketType.Unknown;
		protocolType = ProtocolType.Unknown;
		if (s_LoggingEnabled)
		{
			Logging.Exit(Logging.Sockets, this, "Socket", null);
		}
	}

	internal bool CanTryAddressFamily(AddressFamily family)
	{
		if (family != addressFamily)
		{
			if (family == AddressFamily.InterNetwork)
			{
				return IsDualMode;
			}
			return false;
		}
		return true;
	}

	public void Bind(EndPoint localEP)
	{
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "Bind", localEP);
		}
		if (CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		if (localEP == null)
		{
			throw new ArgumentNullException("localEP");
		}
		EndPoint endPoint = localEP;
		if (localEP is IPEndPoint iPEndPoint)
		{
			IPEndPoint iPEndPoint2 = iPEndPoint.Snapshot();
			endPoint = RemapIPEndPoint(iPEndPoint2);
			SocketPermission socketPermission = new SocketPermission(NetworkAccess.Accept, Transport, iPEndPoint2.Address.ToString(), iPEndPoint2.Port);
			socketPermission.Demand();
		}
		else
		{
			ExceptionHelper.UnmanagedPermission.Demand();
		}
		SocketAddress socketAddress = CallSerializeCheckDnsEndPoint(endPoint);
		DoBind(endPoint, socketAddress);
		if (s_LoggingEnabled)
		{
			Logging.Exit(Logging.Sockets, this, "Bind", "");
		}
	}

	internal void InternalBind(EndPoint localEP)
	{
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "InternalBind", localEP);
		}
		if (CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		EndPoint remoteEP = localEP;
		SocketAddress socketAddress = SnapshotAndSerialize(ref remoteEP);
		DoBind(remoteEP, socketAddress);
		if (s_LoggingEnabled)
		{
			Logging.Exit(Logging.Sockets, this, "InternalBind", "");
		}
	}

	private void DoBind(EndPoint endPointSnapshot, SocketAddress socketAddress)
	{
		IPEndPoint iPEndPoint = endPointSnapshot as IPEndPoint;
		if (!OSSupportsIPv4 && iPEndPoint != null && iPEndPoint.Address.IsIPv4MappedToIPv6)
		{
			SocketException ex = new SocketException(SocketError.InvalidArgument);
			UpdateStatusAfterSocketError(ex);
			if (s_LoggingEnabled)
			{
				Logging.Exception(Logging.Sockets, this, "DoBind", ex);
			}
			throw ex;
		}
		if (UnsafeNclNativeMethods.OSSOCK.bind(m_Handle, socketAddress.m_Buffer, socketAddress.m_Size) != SocketError.Success)
		{
			SocketException ex2 = new SocketException();
			UpdateStatusAfterSocketError(ex2);
			if (s_LoggingEnabled)
			{
				Logging.Exception(Logging.Sockets, this, "DoBind", ex2);
			}
			throw ex2;
		}
		if (m_RightEndPoint == null)
		{
			m_RightEndPoint = endPointSnapshot;
		}
	}

	public void Connect(EndPoint remoteEP)
	{
		if (CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		if (remoteEP == null)
		{
			throw new ArgumentNullException("remoteEP");
		}
		if (m_IsDisconnected)
		{
			throw new InvalidOperationException(SR.GetString("net_sockets_disconnectedConnect"));
		}
		if (isListening)
		{
			throw new InvalidOperationException(SR.GetString("net_sockets_mustnotlisten"));
		}
		ValidateBlockingMode();
		if (remoteEP is DnsEndPoint dnsEndPoint)
		{
			if (dnsEndPoint.AddressFamily != AddressFamily.Unspecified && !CanTryAddressFamily(dnsEndPoint.AddressFamily))
			{
				throw new NotSupportedException(SR.GetString("net_invalidversion"));
			}
			Connect(dnsEndPoint.Host, dnsEndPoint.Port);
			return;
		}
		EndPoint remoteEP2 = remoteEP;
		SocketAddress socketAddress = CheckCacheRemote(ref remoteEP2, isOverwrite: true);
		if (!Blocking)
		{
			m_NonBlockingConnectRightEndPoint = remoteEP2;
			m_NonBlockingConnectInProgress = true;
		}
		DoConnect(remoteEP2, socketAddress);
	}

	public void Connect(IPAddress address, int port)
	{
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "Connect", address);
		}
		if (CleanedUp)
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
		if (!CanTryAddressFamily(address.AddressFamily))
		{
			throw new NotSupportedException(SR.GetString("net_invalidversion"));
		}
		IPEndPoint remoteEP = new IPEndPoint(address, port);
		Connect(remoteEP);
		if (s_LoggingEnabled)
		{
			Logging.Exit(Logging.Sockets, this, "Connect", null);
		}
	}

	public void Connect(string host, int port)
	{
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "Connect", host);
		}
		if (CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		if (host == null)
		{
			throw new ArgumentNullException("host");
		}
		if (!ValidationHelper.ValidateTcpPort(port))
		{
			throw new ArgumentOutOfRangeException("port");
		}
		if (addressFamily != AddressFamily.InterNetwork && addressFamily != AddressFamily.InterNetworkV6)
		{
			throw new NotSupportedException(SR.GetString("net_invalidversion"));
		}
		IPAddress[] hostAddresses = Dns.GetHostAddresses(host);
		Connect(hostAddresses, port);
		if (s_LoggingEnabled)
		{
			Logging.Exit(Logging.Sockets, this, "Connect", null);
		}
	}

	public void Connect(IPAddress[] addresses, int port)
	{
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "Connect", addresses);
		}
		if (CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		if (addresses == null)
		{
			throw new ArgumentNullException("addresses");
		}
		if (addresses.Length == 0)
		{
			throw new ArgumentException(SR.GetString("net_sockets_invalid_ipaddress_length"), "addresses");
		}
		if (!ValidationHelper.ValidateTcpPort(port))
		{
			throw new ArgumentOutOfRangeException("port");
		}
		if (addressFamily != AddressFamily.InterNetwork && addressFamily != AddressFamily.InterNetworkV6)
		{
			throw new NotSupportedException(SR.GetString("net_invalidversion"));
		}
		Exception ex = null;
		foreach (IPAddress iPAddress in addresses)
		{
			if (!CanTryAddressFamily(iPAddress.AddressFamily))
			{
				continue;
			}
			try
			{
				Connect(new IPEndPoint(iPAddress, port));
				ex = null;
			}
			catch (Exception ex2)
			{
				if (NclUtilities.IsFatal(ex2))
				{
					throw;
				}
				ex = ex2;
				continue;
			}
			break;
		}
		if (ex != null)
		{
			throw ex;
		}
		if (!Connected)
		{
			throw new ArgumentException(SR.GetString("net_invalidAddressList"), "addresses");
		}
		if (s_LoggingEnabled)
		{
			Logging.Exit(Logging.Sockets, this, "Connect", null);
		}
	}

	public void Close()
	{
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "Close", null);
		}
		((IDisposable)this).Dispose();
		if (s_LoggingEnabled)
		{
			Logging.Exit(Logging.Sockets, this, "Close", null);
		}
	}

	public void Close(int timeout)
	{
		if (timeout < -1)
		{
			throw new ArgumentOutOfRangeException("timeout");
		}
		m_CloseTimeout = timeout;
		((IDisposable)this).Dispose();
	}

	public void Listen(int backlog)
	{
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "Listen", backlog);
		}
		if (CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		if (UnsafeNclNativeMethods.OSSOCK.listen(m_Handle, backlog) != SocketError.Success)
		{
			SocketException ex = new SocketException();
			UpdateStatusAfterSocketError(ex);
			if (s_LoggingEnabled)
			{
				Logging.Exception(Logging.Sockets, this, "Listen", ex);
			}
			throw ex;
		}
		isListening = true;
		if (s_LoggingEnabled)
		{
			Logging.Exit(Logging.Sockets, this, "Listen", "");
		}
	}

	public Socket Accept()
	{
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "Accept", "");
		}
		if (CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		if (m_RightEndPoint == null)
		{
			throw new InvalidOperationException(SR.GetString("net_sockets_mustbind"));
		}
		if (!isListening)
		{
			throw new InvalidOperationException(SR.GetString("net_sockets_mustlisten"));
		}
		if (m_IsDisconnected)
		{
			throw new InvalidOperationException(SR.GetString("net_sockets_disconnectedAccept"));
		}
		ValidateBlockingMode();
		SocketAddress socketAddress = m_RightEndPoint.Serialize();
		SafeCloseSocket safeCloseSocket = SafeCloseSocket.Accept(m_Handle, socketAddress.m_Buffer, ref socketAddress.m_Size);
		if (safeCloseSocket.IsInvalid)
		{
			SocketException ex = new SocketException();
			UpdateStatusAfterSocketError(ex);
			if (s_LoggingEnabled)
			{
				Logging.Exception(Logging.Sockets, this, "Accept", ex);
			}
			throw ex;
		}
		Socket socket = CreateAcceptSocket(safeCloseSocket, m_RightEndPoint.Create(socketAddress), needCancelSelect: false);
		if (s_LoggingEnabled)
		{
			Logging.PrintInfo(Logging.Sockets, socket, SR.GetString("net_log_socket_accepted", socket.RemoteEndPoint, socket.LocalEndPoint));
			Logging.Exit(Logging.Sockets, this, "Accept", socket);
		}
		return socket;
	}

	public int Send(byte[] buffer, int size, SocketFlags socketFlags)
	{
		return Send(buffer, 0, size, socketFlags);
	}

	public int Send(byte[] buffer, SocketFlags socketFlags)
	{
		return Send(buffer, 0, (buffer != null) ? buffer.Length : 0, socketFlags);
	}

	public int Send(byte[] buffer)
	{
		return Send(buffer, 0, (buffer != null) ? buffer.Length : 0, SocketFlags.None);
	}

	public int Send(IList<ArraySegment<byte>> buffers)
	{
		return Send(buffers, SocketFlags.None);
	}

	public int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags)
	{
		SocketError errorCode;
		int result = Send(buffers, socketFlags, out errorCode);
		if (errorCode != SocketError.Success)
		{
			throw new SocketException(errorCode);
		}
		return result;
	}

	public int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode)
	{
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "Send", "");
		}
		if (CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		if (buffers == null)
		{
			throw new ArgumentNullException("buffers");
		}
		if (buffers.Count == 0)
		{
			throw new ArgumentException(SR.GetString("net_sockets_zerolist", "buffers"), "buffers");
		}
		ValidateBlockingMode();
		errorCode = SocketError.Success;
		int count = buffers.Count;
		WSABuffer[] array = new WSABuffer[count];
		GCHandle[] array2 = null;
		int bytesTransferred;
		try
		{
			array2 = new GCHandle[count];
			for (int i = 0; i < count; i++)
			{
				ArraySegment<byte> segment = buffers[i];
				ValidationHelper.ValidateSegment(segment);
				array2[i] = GCHandle.Alloc(segment.Array, GCHandleType.Pinned);
				array[i].Length = segment.Count;
				array[i].Pointer = Marshal.UnsafeAddrOfPinnedArrayElement((Array)segment.Array, segment.Offset);
			}
			errorCode = UnsafeNclNativeMethods.OSSOCK.WSASend_Blocking(m_Handle.DangerousGetHandle(), array, count, out bytesTransferred, socketFlags, SafeNativeOverlapped.Zero, IntPtr.Zero);
			if (errorCode == SocketError.SocketError)
			{
				errorCode = (SocketError)Marshal.GetLastWin32Error();
			}
		}
		finally
		{
			if (array2 != null)
			{
				for (int j = 0; j < array2.Length; j++)
				{
					if (array2[j].IsAllocated)
					{
						array2[j].Free();
					}
				}
			}
		}
		if (errorCode != SocketError.Success)
		{
			UpdateStatusAfterSocketError(errorCode);
			if (s_LoggingEnabled)
			{
				Logging.Exception(Logging.Sockets, this, "Send", new SocketException(errorCode));
				Logging.Exit(Logging.Sockets, this, "Send", 0);
			}
			return 0;
		}
		if (s_PerfCountersEnabled && bytesTransferred > 0)
		{
			NetworkingPerfCounters.Instance.Increment(NetworkingPerfCounterName.SocketBytesSent, bytesTransferred);
			if (Transport == TransportType.Udp)
			{
				NetworkingPerfCounters.Instance.Increment(NetworkingPerfCounterName.SocketDatagramsSent);
			}
		}
		if (s_LoggingEnabled)
		{
			Logging.Exit(Logging.Sockets, this, "Send", bytesTransferred);
		}
		return bytesTransferred;
	}

	public void SendFile(string fileName)
	{
		SendFile(fileName, null, null, TransmitFileOptions.UseDefaultWorkerThread);
	}

	public void SendFile(string fileName, byte[] preBuffer, byte[] postBuffer, TransmitFileOptions flags)
	{
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "SendFile", "");
		}
		if (CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		if (!Connected)
		{
			throw new NotSupportedException(SR.GetString("net_notconnected"));
		}
		ValidateBlockingMode();
		TransmitFileOverlappedAsyncResult transmitFileOverlappedAsyncResult = new TransmitFileOverlappedAsyncResult(this);
		FileStream fileStream = null;
		if (fileName != null && fileName.Length > 0)
		{
			fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
		}
		SafeHandle safeHandle = null;
		if (fileStream != null)
		{
			ExceptionHelper.UnmanagedPermission.Assert();
			try
			{
				safeHandle = fileStream.SafeFileHandle;
			}
			finally
			{
				CodeAccessPermission.RevertAssert();
			}
		}
		SocketError socketError = SocketError.Success;
		try
		{
			transmitFileOverlappedAsyncResult.SetUnmanagedStructures(preBuffer, postBuffer, fileStream, TransmitFileOptions.UseDefaultWorkerThread, sync: true);
			if ((safeHandle != null) ? (!UnsafeNclNativeMethods.OSSOCK.TransmitFile_Blocking(m_Handle.DangerousGetHandle(), safeHandle, 0, 0, SafeNativeOverlapped.Zero, transmitFileOverlappedAsyncResult.TransmitFileBuffers, flags)) : (!UnsafeNclNativeMethods.OSSOCK.TransmitFile_Blocking2(m_Handle.DangerousGetHandle(), IntPtr.Zero, 0, 0, SafeNativeOverlapped.Zero, transmitFileOverlappedAsyncResult.TransmitFileBuffers, flags)))
			{
				socketError = (SocketError)Marshal.GetLastWin32Error();
			}
		}
		finally
		{
			transmitFileOverlappedAsyncResult.SyncReleaseUnmanagedStructures();
		}
		if (socketError != SocketError.Success)
		{
			SocketException ex = new SocketException(socketError);
			UpdateStatusAfterSocketError(ex);
			if (s_LoggingEnabled)
			{
				Logging.Exception(Logging.Sockets, this, "SendFile", ex);
			}
			throw ex;
		}
		if ((transmitFileOverlappedAsyncResult.Flags & (TransmitFileOptions.Disconnect | TransmitFileOptions.ReuseSocket)) != TransmitFileOptions.UseDefaultWorkerThread)
		{
			SetToDisconnected();
			m_RemoteEndPoint = null;
		}
		if (s_LoggingEnabled)
		{
			Logging.Exit(Logging.Sockets, this, "SendFile", socketError);
		}
	}

	public int Send(byte[] buffer, int offset, int size, SocketFlags socketFlags)
	{
		SocketError errorCode;
		int result = Send(buffer, offset, size, socketFlags, out errorCode);
		if (errorCode != SocketError.Success)
		{
			throw new SocketException(errorCode);
		}
		return result;
	}

	public unsafe int Send(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode)
	{
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "Send", "");
		}
		if (CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (offset < 0 || offset > buffer.Length)
		{
			throw new ArgumentOutOfRangeException("offset");
		}
		if (size < 0 || size > buffer.Length - offset)
		{
			throw new ArgumentOutOfRangeException("size");
		}
		errorCode = SocketError.Success;
		ValidateBlockingMode();
		int num;
		if (buffer.Length == 0)
		{
			num = UnsafeNclNativeMethods.OSSOCK.send(m_Handle.DangerousGetHandle(), null, 0, socketFlags);
		}
		else
		{
			fixed (byte* ptr = buffer)
			{
				num = UnsafeNclNativeMethods.OSSOCK.send(m_Handle.DangerousGetHandle(), ptr + offset, size, socketFlags);
			}
		}
		if (num == -1)
		{
			errorCode = (SocketError)Marshal.GetLastWin32Error();
			UpdateStatusAfterSocketError(errorCode);
			if (s_LoggingEnabled)
			{
				Logging.Exception(Logging.Sockets, this, "Send", new SocketException(errorCode));
				Logging.Exit(Logging.Sockets, this, "Send", 0);
			}
			return 0;
		}
		if (s_PerfCountersEnabled && num > 0)
		{
			NetworkingPerfCounters.Instance.Increment(NetworkingPerfCounterName.SocketBytesSent, num);
			if (Transport == TransportType.Udp)
			{
				NetworkingPerfCounters.Instance.Increment(NetworkingPerfCounterName.SocketDatagramsSent);
			}
		}
		if (s_LoggingEnabled)
		{
			Logging.Dump(Logging.Sockets, this, "Send", buffer, offset, size);
		}
		if (s_LoggingEnabled)
		{
			Logging.Exit(Logging.Sockets, this, "Send", num);
		}
		return num;
	}

	public unsafe int SendTo(byte[] buffer, int offset, int size, SocketFlags socketFlags, EndPoint remoteEP)
	{
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "SendTo", "");
		}
		if (CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (remoteEP == null)
		{
			throw new ArgumentNullException("remoteEP");
		}
		if (offset < 0 || offset > buffer.Length)
		{
			throw new ArgumentOutOfRangeException("offset");
		}
		if (size < 0 || size > buffer.Length - offset)
		{
			throw new ArgumentOutOfRangeException("size");
		}
		ValidateBlockingMode();
		EndPoint remoteEP2 = remoteEP;
		SocketAddress socketAddress = CheckCacheRemote(ref remoteEP2, isOverwrite: false);
		int num;
		if (buffer.Length == 0)
		{
			num = UnsafeNclNativeMethods.OSSOCK.sendto(m_Handle.DangerousGetHandle(), null, 0, socketFlags, socketAddress.m_Buffer, socketAddress.m_Size);
		}
		else
		{
			fixed (byte* ptr = buffer)
			{
				num = UnsafeNclNativeMethods.OSSOCK.sendto(m_Handle.DangerousGetHandle(), ptr + offset, size, socketFlags, socketAddress.m_Buffer, socketAddress.m_Size);
			}
		}
		if (num == -1)
		{
			SocketException ex = new SocketException();
			UpdateStatusAfterSocketError(ex);
			if (s_LoggingEnabled)
			{
				Logging.Exception(Logging.Sockets, this, "SendTo", ex);
			}
			throw ex;
		}
		if (m_RightEndPoint == null)
		{
			m_RightEndPoint = remoteEP2;
		}
		if (s_PerfCountersEnabled && num > 0)
		{
			NetworkingPerfCounters.Instance.Increment(NetworkingPerfCounterName.SocketBytesSent, num);
			if (Transport == TransportType.Udp)
			{
				NetworkingPerfCounters.Instance.Increment(NetworkingPerfCounterName.SocketDatagramsSent);
			}
		}
		if (s_LoggingEnabled)
		{
			Logging.Dump(Logging.Sockets, this, "SendTo", buffer, offset, size);
		}
		if (s_LoggingEnabled)
		{
			Logging.Exit(Logging.Sockets, this, "SendTo", num);
		}
		return num;
	}

	public int SendTo(byte[] buffer, int size, SocketFlags socketFlags, EndPoint remoteEP)
	{
		return SendTo(buffer, 0, size, socketFlags, remoteEP);
	}

	public int SendTo(byte[] buffer, SocketFlags socketFlags, EndPoint remoteEP)
	{
		return SendTo(buffer, 0, (buffer != null) ? buffer.Length : 0, socketFlags, remoteEP);
	}

	public int SendTo(byte[] buffer, EndPoint remoteEP)
	{
		return SendTo(buffer, 0, (buffer != null) ? buffer.Length : 0, SocketFlags.None, remoteEP);
	}

	public int Receive(byte[] buffer, int size, SocketFlags socketFlags)
	{
		return Receive(buffer, 0, size, socketFlags);
	}

	public int Receive(byte[] buffer, SocketFlags socketFlags)
	{
		return Receive(buffer, 0, (buffer != null) ? buffer.Length : 0, socketFlags);
	}

	public int Receive(byte[] buffer)
	{
		return Receive(buffer, 0, (buffer != null) ? buffer.Length : 0, SocketFlags.None);
	}

	public int Receive(byte[] buffer, int offset, int size, SocketFlags socketFlags)
	{
		SocketError errorCode;
		int result = Receive(buffer, offset, size, socketFlags, out errorCode);
		if (errorCode != SocketError.Success)
		{
			throw new SocketException(errorCode);
		}
		return result;
	}

	public unsafe int Receive(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode)
	{
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "Receive", "");
		}
		if (CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (offset < 0 || offset > buffer.Length)
		{
			throw new ArgumentOutOfRangeException("offset");
		}
		if (size < 0 || size > buffer.Length - offset)
		{
			throw new ArgumentOutOfRangeException("size");
		}
		ValidateBlockingMode();
		errorCode = SocketError.Success;
		int num;
		if (buffer.Length == 0)
		{
			num = UnsafeNclNativeMethods.OSSOCK.recv(m_Handle.DangerousGetHandle(), null, 0, socketFlags);
		}
		else
		{
			fixed (byte* ptr = buffer)
			{
				num = UnsafeNclNativeMethods.OSSOCK.recv(m_Handle.DangerousGetHandle(), ptr + offset, size, socketFlags);
			}
		}
		if (num == -1)
		{
			errorCode = (SocketError)Marshal.GetLastWin32Error();
			UpdateStatusAfterSocketError(errorCode);
			if (s_LoggingEnabled)
			{
				Logging.Exception(Logging.Sockets, this, "Receive", new SocketException(errorCode));
				Logging.Exit(Logging.Sockets, this, "Receive", 0);
			}
			return 0;
		}
		if (s_PerfCountersEnabled)
		{
			bool flag = (socketFlags & SocketFlags.Peek) != 0;
			if (num > 0 && !flag)
			{
				NetworkingPerfCounters.Instance.Increment(NetworkingPerfCounterName.SocketBytesReceived, num);
				if (Transport == TransportType.Udp)
				{
					NetworkingPerfCounters.Instance.Increment(NetworkingPerfCounterName.SocketDatagramsReceived);
				}
			}
		}
		if (s_LoggingEnabled)
		{
			Logging.Dump(Logging.Sockets, this, "Receive", buffer, offset, num);
		}
		if (s_LoggingEnabled)
		{
			Logging.Exit(Logging.Sockets, this, "Receive", num);
		}
		return num;
	}

	public int Receive(IList<ArraySegment<byte>> buffers)
	{
		return Receive(buffers, SocketFlags.None);
	}

	public int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags)
	{
		SocketError errorCode;
		int result = Receive(buffers, socketFlags, out errorCode);
		if (errorCode != SocketError.Success)
		{
			throw new SocketException(errorCode);
		}
		return result;
	}

	public int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode)
	{
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "Receive", "");
		}
		if (CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		if (buffers == null)
		{
			throw new ArgumentNullException("buffers");
		}
		if (buffers.Count == 0)
		{
			throw new ArgumentException(SR.GetString("net_sockets_zerolist", "buffers"), "buffers");
		}
		ValidateBlockingMode();
		int count = buffers.Count;
		WSABuffer[] array = new WSABuffer[count];
		GCHandle[] array2 = null;
		errorCode = SocketError.Success;
		int bytesTransferred;
		try
		{
			array2 = new GCHandle[count];
			for (int i = 0; i < count; i++)
			{
				ArraySegment<byte> segment = buffers[i];
				ValidationHelper.ValidateSegment(segment);
				array2[i] = GCHandle.Alloc(segment.Array, GCHandleType.Pinned);
				array[i].Length = segment.Count;
				array[i].Pointer = Marshal.UnsafeAddrOfPinnedArrayElement((Array)segment.Array, segment.Offset);
			}
			errorCode = UnsafeNclNativeMethods.OSSOCK.WSARecv_Blocking(m_Handle.DangerousGetHandle(), array, count, out bytesTransferred, ref socketFlags, SafeNativeOverlapped.Zero, IntPtr.Zero);
			if (errorCode == SocketError.SocketError)
			{
				errorCode = (SocketError)Marshal.GetLastWin32Error();
			}
		}
		finally
		{
			if (array2 != null)
			{
				for (int j = 0; j < array2.Length; j++)
				{
					if (array2[j].IsAllocated)
					{
						array2[j].Free();
					}
				}
			}
		}
		if (errorCode != SocketError.Success)
		{
			UpdateStatusAfterSocketError(errorCode);
			if (s_LoggingEnabled)
			{
				Logging.Exception(Logging.Sockets, this, "Receive", new SocketException(errorCode));
				Logging.Exit(Logging.Sockets, this, "Receive", 0);
			}
			return 0;
		}
		if (s_PerfCountersEnabled)
		{
			bool flag = (socketFlags & SocketFlags.Peek) != 0;
			if (bytesTransferred > 0 && !flag)
			{
				NetworkingPerfCounters.Instance.Increment(NetworkingPerfCounterName.SocketBytesReceived, bytesTransferred);
				if (Transport == TransportType.Udp)
				{
					NetworkingPerfCounters.Instance.Increment(NetworkingPerfCounterName.SocketDatagramsReceived);
				}
			}
		}
		if (s_LoggingEnabled)
		{
			Logging.Exit(Logging.Sockets, this, "Receive", bytesTransferred);
		}
		return bytesTransferred;
	}

	public int ReceiveMessageFrom(byte[] buffer, int offset, int size, ref SocketFlags socketFlags, ref EndPoint remoteEP, out IPPacketInformation ipPacketInformation)
	{
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "ReceiveMessageFrom", "");
		}
		if (CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (remoteEP == null)
		{
			throw new ArgumentNullException("remoteEP");
		}
		if (!CanTryAddressFamily(remoteEP.AddressFamily))
		{
			throw new ArgumentException(SR.GetString("net_InvalidEndPointAddressFamily", remoteEP.AddressFamily, addressFamily), "remoteEP");
		}
		if (offset < 0 || offset > buffer.Length)
		{
			throw new ArgumentOutOfRangeException("offset");
		}
		if (size < 0 || size > buffer.Length - offset)
		{
			throw new ArgumentOutOfRangeException("size");
		}
		if (m_RightEndPoint == null)
		{
			throw new InvalidOperationException(SR.GetString("net_sockets_mustbind"));
		}
		ValidateBlockingMode();
		EndPoint remoteEP2 = remoteEP;
		SocketAddress socketAddress = SnapshotAndSerialize(ref remoteEP2);
		ReceiveMessageOverlappedAsyncResult receiveMessageOverlappedAsyncResult = new ReceiveMessageOverlappedAsyncResult(this, null, null);
		receiveMessageOverlappedAsyncResult.SetUnmanagedStructures(buffer, offset, size, socketAddress, socketFlags);
		SocketAddress socketAddress2 = remoteEP2.Serialize();
		int bytesTransferred = 0;
		SocketError socketError = SocketError.Success;
		SetReceivingPacketInformation();
		try
		{
			if (WSARecvMsg_Blocking(m_Handle.DangerousGetHandle(), Marshal.UnsafeAddrOfPinnedArrayElement((Array)receiveMessageOverlappedAsyncResult.m_MessageBuffer, 0), out bytesTransferred, IntPtr.Zero, IntPtr.Zero) == SocketError.SocketError)
			{
				socketError = (SocketError)Marshal.GetLastWin32Error();
			}
		}
		finally
		{
			receiveMessageOverlappedAsyncResult.SyncReleaseUnmanagedStructures();
		}
		if (socketError != SocketError.Success && socketError != SocketError.MessageSize)
		{
			SocketException ex = new SocketException(socketError);
			UpdateStatusAfterSocketError(ex);
			if (s_LoggingEnabled)
			{
				Logging.Exception(Logging.Sockets, this, "ReceiveMessageFrom", ex);
			}
			throw ex;
		}
		if (!socketAddress2.Equals(receiveMessageOverlappedAsyncResult.m_SocketAddress))
		{
			try
			{
				remoteEP = remoteEP2.Create(receiveMessageOverlappedAsyncResult.m_SocketAddress);
			}
			catch
			{
			}
			if (m_RightEndPoint == null)
			{
				m_RightEndPoint = remoteEP2;
			}
		}
		socketFlags = receiveMessageOverlappedAsyncResult.m_flags;
		ipPacketInformation = receiveMessageOverlappedAsyncResult.m_IPPacketInformation;
		if (s_LoggingEnabled)
		{
			Logging.Exit(Logging.Sockets, this, "ReceiveMessageFrom", socketError);
		}
		return bytesTransferred;
	}

	public unsafe int ReceiveFrom(byte[] buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP)
	{
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "ReceiveFrom", "");
		}
		if (CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (remoteEP == null)
		{
			throw new ArgumentNullException("remoteEP");
		}
		if (!CanTryAddressFamily(remoteEP.AddressFamily))
		{
			throw new ArgumentException(SR.GetString("net_InvalidEndPointAddressFamily", remoteEP.AddressFamily, addressFamily), "remoteEP");
		}
		if (offset < 0 || offset > buffer.Length)
		{
			throw new ArgumentOutOfRangeException("offset");
		}
		if (size < 0 || size > buffer.Length - offset)
		{
			throw new ArgumentOutOfRangeException("size");
		}
		if (m_RightEndPoint == null)
		{
			throw new InvalidOperationException(SR.GetString("net_sockets_mustbind"));
		}
		ValidateBlockingMode();
		EndPoint remoteEP2 = remoteEP;
		SocketAddress socketAddress = SnapshotAndSerialize(ref remoteEP2);
		SocketAddress socketAddress2 = remoteEP2.Serialize();
		int num;
		if (buffer.Length == 0)
		{
			num = UnsafeNclNativeMethods.OSSOCK.recvfrom(m_Handle.DangerousGetHandle(), null, 0, socketFlags, socketAddress.m_Buffer, ref socketAddress.m_Size);
		}
		else
		{
			fixed (byte* ptr = buffer)
			{
				num = UnsafeNclNativeMethods.OSSOCK.recvfrom(m_Handle.DangerousGetHandle(), ptr + offset, size, socketFlags, socketAddress.m_Buffer, ref socketAddress.m_Size);
			}
		}
		SocketException ex = null;
		if (num == -1)
		{
			ex = new SocketException();
			UpdateStatusAfterSocketError(ex);
			if (s_LoggingEnabled)
			{
				Logging.Exception(Logging.Sockets, this, "ReceiveFrom", ex);
			}
			if (ex.ErrorCode != 10040)
			{
				throw ex;
			}
		}
		if (!socketAddress2.Equals(socketAddress))
		{
			try
			{
				remoteEP = remoteEP2.Create(socketAddress);
			}
			catch
			{
			}
			if (m_RightEndPoint == null)
			{
				m_RightEndPoint = remoteEP2;
			}
		}
		if (ex != null)
		{
			throw ex;
		}
		if (s_PerfCountersEnabled && num > 0)
		{
			NetworkingPerfCounters.Instance.Increment(NetworkingPerfCounterName.SocketBytesReceived, num);
			if (Transport == TransportType.Udp)
			{
				NetworkingPerfCounters.Instance.Increment(NetworkingPerfCounterName.SocketDatagramsReceived);
			}
		}
		if (s_LoggingEnabled)
		{
			Logging.Dump(Logging.Sockets, this, "ReceiveFrom", buffer, offset, size);
		}
		if (s_LoggingEnabled)
		{
			Logging.Exit(Logging.Sockets, this, "ReceiveFrom", num);
		}
		return num;
	}

	public int ReceiveFrom(byte[] buffer, int size, SocketFlags socketFlags, ref EndPoint remoteEP)
	{
		return ReceiveFrom(buffer, 0, size, socketFlags, ref remoteEP);
	}

	public int ReceiveFrom(byte[] buffer, SocketFlags socketFlags, ref EndPoint remoteEP)
	{
		return ReceiveFrom(buffer, 0, (buffer != null) ? buffer.Length : 0, socketFlags, ref remoteEP);
	}

	public int ReceiveFrom(byte[] buffer, ref EndPoint remoteEP)
	{
		return ReceiveFrom(buffer, 0, (buffer != null) ? buffer.Length : 0, SocketFlags.None, ref remoteEP);
	}

	public int IOControl(int ioControlCode, byte[] optionInValue, byte[] optionOutValue)
	{
		if (CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		if (ioControlCode == -2147195266)
		{
			throw new InvalidOperationException(SR.GetString("net_sockets_useblocking"));
		}
		ExceptionHelper.UnmanagedPermission.Demand();
		int bytesTransferred = 0;
		SocketError socketError = UnsafeNclNativeMethods.OSSOCK.WSAIoctl_Blocking(m_Handle.DangerousGetHandle(), ioControlCode, optionInValue, (optionInValue != null) ? optionInValue.Length : 0, optionOutValue, (optionOutValue != null) ? optionOutValue.Length : 0, out bytesTransferred, SafeNativeOverlapped.Zero, IntPtr.Zero);
		if (socketError == SocketError.SocketError)
		{
			SocketException ex = new SocketException();
			UpdateStatusAfterSocketError(ex);
			if (s_LoggingEnabled)
			{
				Logging.Exception(Logging.Sockets, this, "IOControl", ex);
			}
			throw ex;
		}
		return bytesTransferred;
	}

	public int IOControl(IOControlCode ioControlCode, byte[] optionInValue, byte[] optionOutValue)
	{
		return IOControl((int)ioControlCode, optionInValue, optionOutValue);
	}

	internal int IOControl(IOControlCode ioControlCode, IntPtr optionInValue, int inValueSize, IntPtr optionOutValue, int outValueSize)
	{
		if (CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		if ((int)ioControlCode == -2147195266)
		{
			throw new InvalidOperationException(SR.GetString("net_sockets_useblocking"));
		}
		int bytesTransferred = 0;
		SocketError socketError = UnsafeNclNativeMethods.OSSOCK.WSAIoctl_Blocking_Internal(m_Handle.DangerousGetHandle(), (uint)ioControlCode, optionInValue, inValueSize, optionOutValue, outValueSize, out bytesTransferred, SafeNativeOverlapped.Zero, IntPtr.Zero);
		if (socketError == SocketError.SocketError)
		{
			SocketException ex = new SocketException();
			UpdateStatusAfterSocketError(ex);
			if (s_LoggingEnabled)
			{
				Logging.Exception(Logging.Sockets, this, "IOControl", ex);
			}
			throw ex;
		}
		return bytesTransferred;
	}

	public void SetIPProtectionLevel(IPProtectionLevel level)
	{
		if (level == IPProtectionLevel.Unspecified)
		{
			throw new ArgumentException(SR.GetString("net_sockets_invalid_optionValue_all"), "level");
		}
		if (addressFamily == AddressFamily.InterNetworkV6)
		{
			SetSocketOption(SocketOptionLevel.IPv6, SocketOptionName.IPProtectionLevel, (int)level);
			return;
		}
		if (addressFamily == AddressFamily.InterNetwork)
		{
			SetSocketOption(SocketOptionLevel.IP, SocketOptionName.IPProtectionLevel, (int)level);
			return;
		}
		throw new NotSupportedException(SR.GetString("net_invalidversion"));
	}

	public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue)
	{
		if (CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		CheckSetOptionPermissions(optionLevel, optionName);
		SetSocketOption(optionLevel, optionName, optionValue, silent: false);
	}

	public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, byte[] optionValue)
	{
		if (CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		CheckSetOptionPermissions(optionLevel, optionName);
		SocketError socketError = UnsafeNclNativeMethods.OSSOCK.setsockopt(m_Handle, optionLevel, optionName, optionValue, (optionValue != null) ? optionValue.Length : 0);
		if (socketError == SocketError.SocketError)
		{
			SocketException ex = new SocketException();
			UpdateStatusAfterSocketError(ex);
			if (s_LoggingEnabled)
			{
				Logging.Exception(Logging.Sockets, this, "SetSocketOption", ex);
			}
			throw ex;
		}
	}

	public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, bool optionValue)
	{
		SetSocketOption(optionLevel, optionName, optionValue ? 1 : 0);
	}

	public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, object optionValue)
	{
		if (CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		if (optionValue == null)
		{
			throw new ArgumentNullException("optionValue");
		}
		CheckSetOptionPermissions(optionLevel, optionName);
		if (optionLevel == SocketOptionLevel.Socket && optionName == SocketOptionName.Linger)
		{
			if (!(optionValue is LingerOption lingerOption))
			{
				throw new ArgumentException(SR.GetString("net_sockets_invalid_optionValue", "LingerOption"), "optionValue");
			}
			if (lingerOption.LingerTime < 0 || lingerOption.LingerTime > 65535)
			{
				throw new ArgumentException(SR.GetString("ArgumentOutOfRange_Bounds_Lower_Upper", 0, 65535), "optionValue.LingerTime");
			}
			setLingerOption(lingerOption);
		}
		else if (optionLevel == SocketOptionLevel.IP && (optionName == SocketOptionName.AddMembership || optionName == SocketOptionName.DropMembership))
		{
			if (!(optionValue is MulticastOption mR))
			{
				throw new ArgumentException(SR.GetString("net_sockets_invalid_optionValue", "MulticastOption"), "optionValue");
			}
			setMulticastOption(optionName, mR);
		}
		else
		{
			if (optionLevel != SocketOptionLevel.IPv6 || (optionName != SocketOptionName.AddMembership && optionName != SocketOptionName.DropMembership))
			{
				throw new ArgumentException(SR.GetString("net_sockets_invalid_optionValue_all"), "optionValue");
			}
			if (!(optionValue is IPv6MulticastOption mR2))
			{
				throw new ArgumentException(SR.GetString("net_sockets_invalid_optionValue", "IPv6MulticastOption"), "optionValue");
			}
			setIPv6MulticastOption(optionName, mR2);
		}
	}

	public object GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName)
	{
		if (CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		if (optionLevel == SocketOptionLevel.Socket && optionName == SocketOptionName.Linger)
		{
			return getLingerOpt();
		}
		if (optionLevel == SocketOptionLevel.IP && (optionName == SocketOptionName.AddMembership || optionName == SocketOptionName.DropMembership))
		{
			return getMulticastOpt(optionName);
		}
		if (optionLevel == SocketOptionLevel.IPv6 && (optionName == SocketOptionName.AddMembership || optionName == SocketOptionName.DropMembership))
		{
			return getIPv6MulticastOpt(optionName);
		}
		int optionValue = 0;
		int optionLength = 4;
		SocketError socketError = UnsafeNclNativeMethods.OSSOCK.getsockopt(m_Handle, optionLevel, optionName, out optionValue, ref optionLength);
		if (socketError == SocketError.SocketError)
		{
			SocketException ex = new SocketException();
			UpdateStatusAfterSocketError(ex);
			if (s_LoggingEnabled)
			{
				Logging.Exception(Logging.Sockets, this, "GetSocketOption", ex);
			}
			throw ex;
		}
		return optionValue;
	}

	public void GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, byte[] optionValue)
	{
		if (CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		int optionLength = ((optionValue != null) ? optionValue.Length : 0);
		SocketError socketError = UnsafeNclNativeMethods.OSSOCK.getsockopt(m_Handle, optionLevel, optionName, optionValue, ref optionLength);
		if (socketError == SocketError.SocketError)
		{
			SocketException ex = new SocketException();
			UpdateStatusAfterSocketError(ex);
			if (s_LoggingEnabled)
			{
				Logging.Exception(Logging.Sockets, this, "GetSocketOption", ex);
			}
			throw ex;
		}
	}

	public byte[] GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionLength)
	{
		if (CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		byte[] array = new byte[optionLength];
		int optionLength2 = optionLength;
		SocketError socketError = UnsafeNclNativeMethods.OSSOCK.getsockopt(m_Handle, optionLevel, optionName, array, ref optionLength2);
		if (socketError == SocketError.SocketError)
		{
			SocketException ex = new SocketException();
			UpdateStatusAfterSocketError(ex);
			if (s_LoggingEnabled)
			{
				Logging.Exception(Logging.Sockets, this, "GetSocketOption", ex);
			}
			throw ex;
		}
		if (optionLength != optionLength2)
		{
			byte[] array2 = new byte[optionLength2];
			Buffer.BlockCopy(array, 0, array2, 0, optionLength2);
			array = array2;
		}
		return array;
	}

	public bool Poll(int microSeconds, SelectMode mode)
	{
		if (CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		IntPtr intPtr = m_Handle.DangerousGetHandle();
		IntPtr[] array = new IntPtr[2]
		{
			(IntPtr)1,
			intPtr
		};
		TimeValue socketTime = default(TimeValue);
		int num;
		if (microSeconds != -1)
		{
			MicrosecondsToTimeValue((uint)microSeconds, ref socketTime);
			num = UnsafeNclNativeMethods.OSSOCK.select(0, (mode == SelectMode.SelectRead) ? array : null, (mode == SelectMode.SelectWrite) ? array : null, (mode == SelectMode.SelectError) ? array : null, ref socketTime);
		}
		else
		{
			num = UnsafeNclNativeMethods.OSSOCK.select(0, (mode == SelectMode.SelectRead) ? array : null, (mode == SelectMode.SelectWrite) ? array : null, (mode == SelectMode.SelectError) ? array : null, IntPtr.Zero);
		}
		if (num == -1)
		{
			SocketException ex = new SocketException();
			UpdateStatusAfterSocketError(ex);
			if (s_LoggingEnabled)
			{
				Logging.Exception(Logging.Sockets, this, "Poll", ex);
			}
			throw ex;
		}
		if ((int)array[0] == 0)
		{
			return false;
		}
		return array[1] == intPtr;
	}

	public static void Select(IList checkRead, IList checkWrite, IList checkError, int microSeconds)
	{
		if ((checkRead == null || checkRead.Count == 0) && (checkWrite == null || checkWrite.Count == 0) && (checkError == null || checkError.Count == 0))
		{
			throw new ArgumentNullException(SR.GetString("net_sockets_empty_select"));
		}
		if (checkRead != null && checkRead.Count > 65536)
		{
			throw new ArgumentOutOfRangeException("checkRead", SR.GetString("net_sockets_toolarge_select", "checkRead", 65536.ToString(NumberFormatInfo.CurrentInfo)));
		}
		if (checkWrite != null && checkWrite.Count > 65536)
		{
			throw new ArgumentOutOfRangeException("checkWrite", SR.GetString("net_sockets_toolarge_select", "checkWrite", 65536.ToString(NumberFormatInfo.CurrentInfo)));
		}
		if (checkError != null && checkError.Count > 65536)
		{
			throw new ArgumentOutOfRangeException("checkError", SR.GetString("net_sockets_toolarge_select", "checkError", 65536.ToString(NumberFormatInfo.CurrentInfo)));
		}
		IntPtr[] array = SocketListToFileDescriptorSet(checkRead);
		IntPtr[] array2 = SocketListToFileDescriptorSet(checkWrite);
		IntPtr[] array3 = SocketListToFileDescriptorSet(checkError);
		int num;
		if (microSeconds != -1)
		{
			TimeValue socketTime = default(TimeValue);
			MicrosecondsToTimeValue((uint)microSeconds, ref socketTime);
			num = UnsafeNclNativeMethods.OSSOCK.select(0, array, array2, array3, ref socketTime);
		}
		else
		{
			num = UnsafeNclNativeMethods.OSSOCK.select(0, array, array2, array3, IntPtr.Zero);
		}
		if (num == -1)
		{
			throw new SocketException();
		}
		SelectFileDescriptor(checkRead, array);
		SelectFileDescriptor(checkWrite, array2);
		SelectFileDescriptor(checkError, array3);
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public IAsyncResult BeginSendFile(string fileName, AsyncCallback callback, object state)
	{
		return BeginSendFile(fileName, null, null, TransmitFileOptions.UseDefaultWorkerThread, callback, state);
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public IAsyncResult BeginConnect(EndPoint remoteEP, AsyncCallback callback, object state)
	{
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "BeginConnect", remoteEP);
		}
		if (CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		if (remoteEP == null)
		{
			throw new ArgumentNullException("remoteEP");
		}
		if (isListening)
		{
			throw new InvalidOperationException(SR.GetString("net_sockets_mustnotlisten"));
		}
		if (Interlocked.Exchange(ref asyncConnectOperationLock, 1) != 0)
		{
			throw new InvalidOperationException(SR.GetString("net_sockets_no_duplicate_async"));
		}
		try
		{
			if (remoteEP is DnsEndPoint dnsEndPoint)
			{
				if (dnsEndPoint.AddressFamily != AddressFamily.Unspecified && !CanTryAddressFamily(dnsEndPoint.AddressFamily))
				{
					throw new NotSupportedException(SR.GetString("net_invalidversion"));
				}
				return InternalBeginConnectHostName(dnsEndPoint.Host, dnsEndPoint.Port, callback, state);
			}
			if (CanUseConnectEx(remoteEP))
			{
				return BeginConnectEx(remoteEP, flowContext: true, callback, state);
			}
			EndPoint remoteEP2 = remoteEP;
			SocketAddress socketAddress = CheckCacheRemote(ref remoteEP2, isOverwrite: true);
			ConnectAsyncResult connectAsyncResult = new ConnectAsyncResult(this, remoteEP2, state, callback);
			connectAsyncResult.StartPostingAsyncOp(lockCapture: false);
			DoBeginConnect(remoteEP2, socketAddress, connectAsyncResult);
			connectAsyncResult.FinishPostingAsyncOp(ref Caches.ConnectClosureCache);
			if (s_LoggingEnabled)
			{
				Logging.Exit(Logging.Sockets, this, "BeginConnect", connectAsyncResult);
			}
			return connectAsyncResult;
		}
		catch
		{
			Interlocked.Exchange(ref asyncConnectOperationLock, 0);
			throw;
		}
	}

	public unsafe SocketInformation DuplicateAndClose(int targetProcessId)
	{
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "DuplicateAndClose", null);
		}
		if (CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		ExceptionHelper.UnrestrictedSocketPermission.Demand();
		SocketInformation result = new SocketInformation
		{
			ProtocolInformation = new byte[protocolInformationSize]
		};
		SocketError socketError;
		fixed (byte* protocolInformation = result.ProtocolInformation)
		{
			socketError = (SocketError)UnsafeNclNativeMethods.OSSOCK.WSADuplicateSocket(m_Handle, (uint)targetProcessId, protocolInformation);
		}
		if (socketError != SocketError.Success)
		{
			SocketException ex = new SocketException();
			if (s_LoggingEnabled)
			{
				Logging.Exception(Logging.Sockets, this, "DuplicateAndClose", ex);
			}
			throw ex;
		}
		result.IsConnected = Connected;
		result.IsNonBlocking = !Blocking;
		result.IsListening = isListening;
		result.UseOnlyOverlappedIO = UseOnlyOverlappedIO;
		result.RemoteEndPoint = m_RemoteEndPoint;
		Close(-1);
		if (s_LoggingEnabled)
		{
			Logging.Exit(Logging.Sockets, this, "DuplicateAndClose", null);
		}
		return result;
	}

	internal IAsyncResult UnsafeBeginConnect(EndPoint remoteEP, AsyncCallback callback, object state)
	{
		if (CanUseConnectEx(remoteEP))
		{
			return BeginConnectEx(remoteEP, flowContext: false, callback, state);
		}
		EndPoint remoteEP2 = remoteEP;
		SocketAddress socketAddress = SnapshotAndSerialize(ref remoteEP2);
		ConnectAsyncResult connectAsyncResult = new ConnectAsyncResult(this, remoteEP2, state, callback);
		DoBeginConnect(remoteEP2, socketAddress, connectAsyncResult);
		return connectAsyncResult;
	}

	private void DoBeginConnect(EndPoint endPointSnapshot, SocketAddress socketAddress, LazyAsyncResult asyncResult)
	{
		EndPoint rightEndPoint = m_RightEndPoint;
		if (m_AcceptQueueOrConnectResult != null)
		{
			throw new InvalidOperationException(SR.GetString("net_sockets_no_duplicate_async"));
		}
		m_AcceptQueueOrConnectResult = asyncResult;
		if (!SetAsyncEventSelect(AsyncEventBits.FdConnect))
		{
			m_AcceptQueueOrConnectResult = null;
			throw new ObjectDisposedException(GetType().FullName);
		}
		IntPtr socketHandle = m_Handle.DangerousGetHandle();
		if (m_RightEndPoint == null)
		{
			m_RightEndPoint = endPointSnapshot;
		}
		SocketError socketError = UnsafeNclNativeMethods.OSSOCK.WSAConnect(socketHandle, socketAddress.m_Buffer, socketAddress.m_Size, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero);
		if (socketError != SocketError.Success)
		{
			socketError = (SocketError)Marshal.GetLastWin32Error();
		}
		if (socketError == SocketError.WouldBlock)
		{
			return;
		}
		bool flag = true;
		if (socketError == SocketError.Success)
		{
			SetToConnected();
		}
		else
		{
			asyncResult.ErrorCode = (int)socketError;
		}
		if (Interlocked.Exchange(ref m_RegisteredWait, null) == null)
		{
			flag = false;
		}
		UnsetAsyncEventSelect();
		if (socketError == SocketError.Success)
		{
			if (flag)
			{
				asyncResult.InvokeCallback();
			}
			return;
		}
		m_RightEndPoint = rightEndPoint;
		SocketException ex = new SocketException(socketError);
		UpdateStatusAfterSocketError(ex);
		m_AcceptQueueOrConnectResult = null;
		if (s_LoggingEnabled)
		{
			Logging.Exception(Logging.Sockets, this, "BeginConnect", ex);
		}
		throw ex;
	}

	private bool CanUseConnectEx(EndPoint remoteEP)
	{
		if (socketType == SocketType.Stream && (m_RightEndPoint != null || remoteEP.GetType() == typeof(IPEndPoint)))
		{
			if (!Thread.CurrentThread.IsThreadPoolThread && !SettingsSectionInternal.Section.AlwaysUseCompletionPortsForConnect)
			{
				return m_IsDisconnected;
			}
			return true;
		}
		return false;
	}

	private void ConnectCallback()
	{
		LazyAsyncResult lazyAsyncResult = (LazyAsyncResult)m_AcceptQueueOrConnectResult;
		if (lazyAsyncResult.InternalPeekCompleted)
		{
			return;
		}
		NetworkEvents networkEvents = new NetworkEvents
		{
			Events = AsyncEventBits.FdConnect
		};
		SocketError socketError = SocketError.OperationAborted;
		object result = null;
		try
		{
			if (!CleanedUp)
			{
				try
				{
					socketError = UnsafeNclNativeMethods.OSSOCK.WSAEnumNetworkEvents(m_Handle, m_AsyncEvent.SafeWaitHandle, ref networkEvents);
					socketError = (SocketError)((socketError == SocketError.Success) ? networkEvents.ErrorCodes[4] : Marshal.GetLastWin32Error());
					UnsetAsyncEventSelect();
				}
				catch (ObjectDisposedException)
				{
					socketError = SocketError.OperationAborted;
				}
			}
			if (socketError == SocketError.Success)
			{
				SetToConnected();
			}
		}
		catch (Exception ex2)
		{
			if (NclUtilities.IsFatal(ex2))
			{
				throw;
			}
			result = ex2;
		}
		if (!lazyAsyncResult.InternalPeekCompleted)
		{
			lazyAsyncResult.ErrorCode = (int)socketError;
			lazyAsyncResult.InvokeCallback(result);
		}
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public IAsyncResult BeginConnect(string host, int port, AsyncCallback requestCallback, object state)
	{
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "BeginConnect", host);
		}
		if (CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		if (host == null)
		{
			throw new ArgumentNullException("host");
		}
		if (!ValidationHelper.ValidateTcpPort(port))
		{
			throw new ArgumentOutOfRangeException("port");
		}
		if (addressFamily != AddressFamily.InterNetwork && addressFamily != AddressFamily.InterNetworkV6)
		{
			throw new NotSupportedException(SR.GetString("net_invalidversion"));
		}
		if (isListening)
		{
			throw new InvalidOperationException(SR.GetString("net_sockets_mustnotlisten"));
		}
		if (Interlocked.Exchange(ref asyncConnectOperationLock, 1) != 0)
		{
			throw new InvalidOperationException(SR.GetString("net_sockets_no_duplicate_async"));
		}
		try
		{
			MultipleAddressConnectAsyncResult multipleAddressConnectAsyncResult = InternalBeginConnectHostName(host, port, requestCallback, state);
			if (s_LoggingEnabled)
			{
				Logging.Exit(Logging.Sockets, this, "BeginConnect", multipleAddressConnectAsyncResult);
			}
			return multipleAddressConnectAsyncResult;
		}
		catch
		{
			Interlocked.Exchange(ref asyncConnectOperationLock, 0);
			throw;
		}
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public IAsyncResult BeginConnect(IPAddress address, int port, AsyncCallback requestCallback, object state)
	{
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "BeginConnect", address);
		}
		if (CleanedUp)
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
		if (!CanTryAddressFamily(address.AddressFamily))
		{
			throw new NotSupportedException(SR.GetString("net_invalidversion"));
		}
		IAsyncResult asyncResult = BeginConnect(new IPEndPoint(address, port), requestCallback, state);
		if (s_LoggingEnabled)
		{
			Logging.Exit(Logging.Sockets, this, "BeginConnect", asyncResult);
		}
		return asyncResult;
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public IAsyncResult BeginConnect(IPAddress[] addresses, int port, AsyncCallback requestCallback, object state)
	{
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "BeginConnect", addresses);
		}
		if (CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		if (addresses == null)
		{
			throw new ArgumentNullException("addresses");
		}
		if (addresses.Length == 0)
		{
			throw new ArgumentException(SR.GetString("net_invalidAddressList"), "addresses");
		}
		if (!ValidationHelper.ValidateTcpPort(port))
		{
			throw new ArgumentOutOfRangeException("port");
		}
		if (addressFamily != AddressFamily.InterNetwork && addressFamily != AddressFamily.InterNetworkV6)
		{
			throw new NotSupportedException(SR.GetString("net_invalidversion"));
		}
		if (isListening)
		{
			throw new InvalidOperationException(SR.GetString("net_sockets_mustnotlisten"));
		}
		if (Interlocked.Exchange(ref asyncConnectOperationLock, 1) != 0)
		{
			throw new InvalidOperationException(SR.GetString("net_sockets_no_duplicate_async"));
		}
		try
		{
			MultipleAddressConnectAsyncResult multipleAddressConnectAsyncResult = new MultipleAddressConnectAsyncResult(addresses, port, this, state, requestCallback);
			multipleAddressConnectAsyncResult.StartPostingAsyncOp(lockCapture: false);
			if (DoMultipleAddressConnectCallback(PostOneBeginConnect(multipleAddressConnectAsyncResult), multipleAddressConnectAsyncResult))
			{
				multipleAddressConnectAsyncResult.InvokeCallback();
			}
			multipleAddressConnectAsyncResult.FinishPostingAsyncOp(ref Caches.ConnectClosureCache);
			if (s_LoggingEnabled)
			{
				Logging.Exit(Logging.Sockets, this, "BeginConnect", multipleAddressConnectAsyncResult);
			}
			return multipleAddressConnectAsyncResult;
		}
		catch
		{
			Interlocked.Exchange(ref asyncConnectOperationLock, 0);
			throw;
		}
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public IAsyncResult BeginDisconnect(bool reuseSocket, AsyncCallback callback, object state)
	{
		DisconnectOverlappedAsyncResult disconnectOverlappedAsyncResult = new DisconnectOverlappedAsyncResult(this, state, callback);
		disconnectOverlappedAsyncResult.StartPostingAsyncOp(lockCapture: false);
		DoBeginDisconnect(reuseSocket, disconnectOverlappedAsyncResult);
		disconnectOverlappedAsyncResult.FinishPostingAsyncOp();
		return disconnectOverlappedAsyncResult;
	}

	private void DoBeginDisconnect(bool reuseSocket, DisconnectOverlappedAsyncResult asyncResult)
	{
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "BeginDisconnect", null);
		}
		if (CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		asyncResult.SetUnmanagedStructures(null);
		SocketError socketError = SocketError.Success;
		if (!DisconnectEx(m_Handle, asyncResult.OverlappedHandle, reuseSocket ? 2 : 0, 0))
		{
			socketError = (SocketError)Marshal.GetLastWin32Error();
		}
		if (socketError == SocketError.Success)
		{
			SetToDisconnected();
			m_RemoteEndPoint = null;
		}
		socketError = asyncResult.CheckAsyncCallOverlappedResult(socketError);
		if (socketError != SocketError.Success)
		{
			SocketException ex = new SocketException(socketError);
			UpdateStatusAfterSocketError(ex);
			if (s_LoggingEnabled)
			{
				Logging.Exception(Logging.Sockets, this, "BeginDisconnect", ex);
			}
			throw ex;
		}
		if (s_LoggingEnabled)
		{
			Logging.Exit(Logging.Sockets, this, "BeginDisconnect", asyncResult);
		}
	}

	public void Disconnect(bool reuseSocket)
	{
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "Disconnect", null);
		}
		if (CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		SocketError socketError = SocketError.Success;
		if (!DisconnectEx_Blocking(m_Handle.DangerousGetHandle(), IntPtr.Zero, reuseSocket ? 2 : 0, 0))
		{
			socketError = (SocketError)Marshal.GetLastWin32Error();
		}
		if (socketError != SocketError.Success)
		{
			SocketException ex = new SocketException(socketError);
			UpdateStatusAfterSocketError(ex);
			if (s_LoggingEnabled)
			{
				Logging.Exception(Logging.Sockets, this, "Disconnect", ex);
			}
			throw ex;
		}
		SetToDisconnected();
		m_RemoteEndPoint = null;
		if (s_LoggingEnabled)
		{
			Logging.Exit(Logging.Sockets, this, "Disconnect", null);
		}
	}

	public void EndConnect(IAsyncResult asyncResult)
	{
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "EndConnect", asyncResult);
		}
		try
		{
			InternalEndConnect(asyncResult);
		}
		finally
		{
			Interlocked.Exchange(ref asyncConnectOperationLock, 0);
		}
		if (s_LoggingEnabled)
		{
			Logging.Exit(Logging.Sockets, this, "EndConnect", "");
		}
	}

	public void EndDisconnect(IAsyncResult asyncResult)
	{
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "EndDisconnect", asyncResult);
		}
		if (CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		if (asyncResult == null)
		{
			throw new ArgumentNullException("asyncResult");
		}
		if (!(asyncResult is LazyAsyncResult lazyAsyncResult) || lazyAsyncResult.AsyncObject != this)
		{
			throw new ArgumentException(SR.GetString("net_io_invalidasyncresult"), "asyncResult");
		}
		if (lazyAsyncResult.EndCalled)
		{
			throw new InvalidOperationException(SR.GetString("net_io_invalidendcall", "EndDisconnect"));
		}
		lazyAsyncResult.InternalWaitForCompletion();
		lazyAsyncResult.EndCalled = true;
		if (lazyAsyncResult.ErrorCode != 0)
		{
			SocketException ex = new SocketException(lazyAsyncResult.ErrorCode);
			UpdateStatusAfterSocketError(ex);
			if (s_LoggingEnabled)
			{
				Logging.Exception(Logging.Sockets, this, "EndDisconnect", ex);
			}
			throw ex;
		}
		if (s_LoggingEnabled)
		{
			Logging.Exit(Logging.Sockets, this, "EndDisconnect", null);
		}
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public IAsyncResult BeginSend(byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state)
	{
		SocketError errorCode;
		IAsyncResult result = BeginSend(buffer, offset, size, socketFlags, out errorCode, callback, state);
		if (errorCode != SocketError.Success && errorCode != SocketError.IOPending)
		{
			throw new SocketException(errorCode);
		}
		return result;
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public IAsyncResult BeginSend(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state)
	{
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "BeginSend", "");
		}
		if (CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (offset < 0 || offset > buffer.Length)
		{
			throw new ArgumentOutOfRangeException("offset");
		}
		if (size < 0 || size > buffer.Length - offset)
		{
			throw new ArgumentOutOfRangeException("size");
		}
		OverlappedAsyncResult overlappedAsyncResult = new OverlappedAsyncResult(this, state, callback);
		overlappedAsyncResult.StartPostingAsyncOp(lockCapture: false);
		errorCode = DoBeginSend(buffer, offset, size, socketFlags, overlappedAsyncResult);
		if (errorCode != SocketError.Success && errorCode != SocketError.IOPending)
		{
			overlappedAsyncResult = null;
		}
		else
		{
			overlappedAsyncResult.FinishPostingAsyncOp(ref Caches.SendClosureCache);
		}
		if (s_LoggingEnabled)
		{
			Logging.Exit(Logging.Sockets, this, "BeginSend", overlappedAsyncResult);
		}
		return overlappedAsyncResult;
	}

	internal IAsyncResult UnsafeBeginSend(byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state)
	{
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "UnsafeBeginSend", "");
		}
		if (CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		OverlappedAsyncResult overlappedAsyncResult = new OverlappedAsyncResult(this, state, callback);
		SocketError socketError = DoBeginSend(buffer, offset, size, socketFlags, overlappedAsyncResult);
		if (socketError != SocketError.Success && socketError != SocketError.IOPending)
		{
			throw new SocketException(socketError);
		}
		if (s_LoggingEnabled)
		{
			Logging.Exit(Logging.Sockets, this, "UnsafeBeginSend", overlappedAsyncResult);
		}
		return overlappedAsyncResult;
	}

	private SocketError DoBeginSend(byte[] buffer, int offset, int size, SocketFlags socketFlags, OverlappedAsyncResult asyncResult)
	{
		SocketError socketError = SocketError.SocketError;
		try
		{
			asyncResult.SetUnmanagedStructures(buffer, offset, size, null, pinSocketAddress: false, ref Caches.SendOverlappedCache);
			socketError = UnsafeNclNativeMethods.OSSOCK.WSASend(m_Handle, ref asyncResult.m_SingleBuffer, 1, out var _, socketFlags, asyncResult.OverlappedHandle, IntPtr.Zero);
			if (socketError != SocketError.Success)
			{
				socketError = (SocketError)Marshal.GetLastWin32Error();
			}
		}
		finally
		{
			socketError = asyncResult.CheckAsyncCallOverlappedResult(socketError);
		}
		if (socketError != SocketError.Success)
		{
			asyncResult.ExtractCache(ref Caches.SendOverlappedCache);
			UpdateStatusAfterSocketError(socketError);
			if (s_LoggingEnabled)
			{
				Logging.Exception(Logging.Sockets, this, "BeginSend", new SocketException(socketError));
			}
		}
		return socketError;
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public IAsyncResult BeginSendFile(string fileName, byte[] preBuffer, byte[] postBuffer, TransmitFileOptions flags, AsyncCallback callback, object state)
	{
		TransmitFileOverlappedAsyncResult transmitFileOverlappedAsyncResult = new TransmitFileOverlappedAsyncResult(this, state, callback);
		transmitFileOverlappedAsyncResult.StartPostingAsyncOp(lockCapture: false);
		DoBeginSendFile(fileName, preBuffer, postBuffer, flags, transmitFileOverlappedAsyncResult);
		transmitFileOverlappedAsyncResult.FinishPostingAsyncOp(ref Caches.SendClosureCache);
		return transmitFileOverlappedAsyncResult;
	}

	private void DoBeginSendFile(string fileName, byte[] preBuffer, byte[] postBuffer, TransmitFileOptions flags, TransmitFileOverlappedAsyncResult asyncResult)
	{
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "BeginSendFile", "");
		}
		if (CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		if (CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		if (!Connected)
		{
			throw new NotSupportedException(SR.GetString("net_notconnected"));
		}
		FileStream fileStream = null;
		if (fileName != null && fileName.Length > 0)
		{
			fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
		}
		SafeHandle safeHandle = null;
		if (fileStream != null)
		{
			ExceptionHelper.UnmanagedPermission.Assert();
			try
			{
				safeHandle = fileStream.SafeFileHandle;
			}
			finally
			{
				CodeAccessPermission.RevertAssert();
			}
		}
		SocketError errorCode = SocketError.SocketError;
		try
		{
			asyncResult.SetUnmanagedStructures(preBuffer, postBuffer, fileStream, flags, ref Caches.SendOverlappedCache);
			bool flag = false;
			flag = ((safeHandle == null) ? UnsafeNclNativeMethods.OSSOCK.TransmitFile2(m_Handle, IntPtr.Zero, 0, 0, asyncResult.OverlappedHandle, asyncResult.TransmitFileBuffers, flags) : UnsafeNclNativeMethods.OSSOCK.TransmitFile(m_Handle, safeHandle, 0, 0, asyncResult.OverlappedHandle, asyncResult.TransmitFileBuffers, flags));
			errorCode = ((!flag) ? ((SocketError)Marshal.GetLastWin32Error()) : SocketError.Success);
		}
		finally
		{
			errorCode = asyncResult.CheckAsyncCallOverlappedResult(errorCode);
		}
		if (errorCode != SocketError.Success)
		{
			asyncResult.ExtractCache(ref Caches.SendOverlappedCache);
			SocketException ex = new SocketException(errorCode);
			UpdateStatusAfterSocketError(ex);
			if (s_LoggingEnabled)
			{
				Logging.Exception(Logging.Sockets, this, "BeginSendFile", ex);
			}
			throw ex;
		}
		if (s_LoggingEnabled)
		{
			Logging.Exit(Logging.Sockets, this, "BeginSendFile", errorCode);
		}
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public IAsyncResult BeginSend(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, AsyncCallback callback, object state)
	{
		SocketError errorCode;
		IAsyncResult result = BeginSend(buffers, socketFlags, out errorCode, callback, state);
		if (errorCode != SocketError.Success && errorCode != SocketError.IOPending)
		{
			throw new SocketException(errorCode);
		}
		return result;
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public IAsyncResult BeginSend(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state)
	{
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "BeginSend", "");
		}
		if (CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		if (buffers == null)
		{
			throw new ArgumentNullException("buffers");
		}
		if (buffers.Count == 0)
		{
			throw new ArgumentException(SR.GetString("net_sockets_zerolist", "buffers"), "buffers");
		}
		OverlappedAsyncResult overlappedAsyncResult = new OverlappedAsyncResult(this, state, callback);
		overlappedAsyncResult.StartPostingAsyncOp(lockCapture: false);
		errorCode = DoBeginSend(buffers, socketFlags, overlappedAsyncResult);
		overlappedAsyncResult.FinishPostingAsyncOp(ref Caches.SendClosureCache);
		if (errorCode != SocketError.Success && errorCode != SocketError.IOPending)
		{
			overlappedAsyncResult = null;
		}
		if (s_LoggingEnabled)
		{
			Logging.Exit(Logging.Sockets, this, "BeginSend", overlappedAsyncResult);
		}
		return overlappedAsyncResult;
	}

	private SocketError DoBeginSend(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, OverlappedAsyncResult asyncResult)
	{
		SocketError socketError = SocketError.SocketError;
		try
		{
			asyncResult.SetUnmanagedStructures(buffers, ref Caches.SendOverlappedCache);
			socketError = UnsafeNclNativeMethods.OSSOCK.WSASend(m_Handle, asyncResult.m_WSABuffers, asyncResult.m_WSABuffers.Length, out var _, socketFlags, asyncResult.OverlappedHandle, IntPtr.Zero);
			if (socketError != SocketError.Success)
			{
				socketError = (SocketError)Marshal.GetLastWin32Error();
			}
		}
		finally
		{
			socketError = asyncResult.CheckAsyncCallOverlappedResult(socketError);
		}
		if (socketError != SocketError.Success)
		{
			asyncResult.ExtractCache(ref Caches.SendOverlappedCache);
			UpdateStatusAfterSocketError(socketError);
			if (s_LoggingEnabled)
			{
				Logging.Exception(Logging.Sockets, this, "BeginSend", new SocketException(socketError));
			}
		}
		return socketError;
	}

	public int EndSend(IAsyncResult asyncResult)
	{
		SocketError errorCode;
		int result = EndSend(asyncResult, out errorCode);
		if (errorCode != SocketError.Success)
		{
			throw new SocketException(errorCode);
		}
		return result;
	}

	public int EndSend(IAsyncResult asyncResult, out SocketError errorCode)
	{
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "EndSend", asyncResult);
		}
		if (CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		if (asyncResult == null)
		{
			throw new ArgumentNullException("asyncResult");
		}
		if (!(asyncResult is OverlappedAsyncResult overlappedAsyncResult) || overlappedAsyncResult.AsyncObject != this)
		{
			throw new ArgumentException(SR.GetString("net_io_invalidasyncresult"), "asyncResult");
		}
		if (overlappedAsyncResult.EndCalled)
		{
			throw new InvalidOperationException(SR.GetString("net_io_invalidendcall", "EndSend"));
		}
		int num = (int)overlappedAsyncResult.InternalWaitForCompletion();
		overlappedAsyncResult.EndCalled = true;
		overlappedAsyncResult.ExtractCache(ref Caches.SendOverlappedCache);
		if (s_PerfCountersEnabled && num > 0)
		{
			NetworkingPerfCounters.Instance.Increment(NetworkingPerfCounterName.SocketBytesSent, num);
			if (Transport == TransportType.Udp)
			{
				NetworkingPerfCounters.Instance.Increment(NetworkingPerfCounterName.SocketDatagramsSent);
			}
		}
		errorCode = (SocketError)overlappedAsyncResult.ErrorCode;
		if (errorCode != SocketError.Success)
		{
			UpdateStatusAfterSocketError(errorCode);
			if (s_LoggingEnabled)
			{
				Logging.Exception(Logging.Sockets, this, "EndSend", new SocketException(errorCode));
				Logging.Exit(Logging.Sockets, this, "EndSend", 0);
			}
			return 0;
		}
		if (s_LoggingEnabled)
		{
			Logging.Exit(Logging.Sockets, this, "EndSend", num);
		}
		return num;
	}

	public void EndSendFile(IAsyncResult asyncResult)
	{
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "EndSendFile", asyncResult);
		}
		if (CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		if (asyncResult == null)
		{
			throw new ArgumentNullException("asyncResult");
		}
		if (!(asyncResult is TransmitFileOverlappedAsyncResult transmitFileOverlappedAsyncResult) || transmitFileOverlappedAsyncResult.AsyncObject != this)
		{
			throw new ArgumentException(SR.GetString("net_io_invalidasyncresult"), "asyncResult");
		}
		if (transmitFileOverlappedAsyncResult.EndCalled)
		{
			throw new InvalidOperationException(SR.GetString("net_io_invalidendcall", "EndSendFile"));
		}
		transmitFileOverlappedAsyncResult.InternalWaitForCompletion();
		transmitFileOverlappedAsyncResult.EndCalled = true;
		transmitFileOverlappedAsyncResult.ExtractCache(ref Caches.SendOverlappedCache);
		if ((transmitFileOverlappedAsyncResult.Flags & (TransmitFileOptions.Disconnect | TransmitFileOptions.ReuseSocket)) != TransmitFileOptions.UseDefaultWorkerThread)
		{
			SetToDisconnected();
			m_RemoteEndPoint = null;
		}
		if (transmitFileOverlappedAsyncResult.ErrorCode != 0)
		{
			SocketException ex = new SocketException(transmitFileOverlappedAsyncResult.ErrorCode);
			UpdateStatusAfterSocketError(ex);
			if (s_LoggingEnabled)
			{
				Logging.Exception(Logging.Sockets, this, "EndSendFile", ex);
			}
			throw ex;
		}
		if (s_LoggingEnabled)
		{
			Logging.Exit(Logging.Sockets, this, "EndSendFile", "");
		}
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public IAsyncResult BeginSendTo(byte[] buffer, int offset, int size, SocketFlags socketFlags, EndPoint remoteEP, AsyncCallback callback, object state)
	{
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "BeginSendTo", "");
		}
		if (CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (remoteEP == null)
		{
			throw new ArgumentNullException("remoteEP");
		}
		if (offset < 0 || offset > buffer.Length)
		{
			throw new ArgumentOutOfRangeException("offset");
		}
		if (size < 0 || size > buffer.Length - offset)
		{
			throw new ArgumentOutOfRangeException("size");
		}
		EndPoint remoteEP2 = remoteEP;
		SocketAddress socketAddress = CheckCacheRemote(ref remoteEP2, isOverwrite: false);
		OverlappedAsyncResult overlappedAsyncResult = new OverlappedAsyncResult(this, state, callback);
		overlappedAsyncResult.StartPostingAsyncOp(lockCapture: false);
		DoBeginSendTo(buffer, offset, size, socketFlags, remoteEP2, socketAddress, overlappedAsyncResult);
		overlappedAsyncResult.FinishPostingAsyncOp(ref Caches.SendClosureCache);
		if (s_LoggingEnabled)
		{
			Logging.Exit(Logging.Sockets, this, "BeginSendTo", overlappedAsyncResult);
		}
		return overlappedAsyncResult;
	}

	private void DoBeginSendTo(byte[] buffer, int offset, int size, SocketFlags socketFlags, EndPoint endPointSnapshot, SocketAddress socketAddress, OverlappedAsyncResult asyncResult)
	{
		EndPoint rightEndPoint = m_RightEndPoint;
		SocketError socketError = SocketError.SocketError;
		try
		{
			asyncResult.SetUnmanagedStructures(buffer, offset, size, socketAddress, pinSocketAddress: false, ref Caches.SendOverlappedCache);
			if (m_RightEndPoint == null)
			{
				m_RightEndPoint = endPointSnapshot;
			}
			socketError = UnsafeNclNativeMethods.OSSOCK.WSASendTo(m_Handle, ref asyncResult.m_SingleBuffer, 1, out var _, socketFlags, asyncResult.GetSocketAddressPtr(), asyncResult.SocketAddress.Size, asyncResult.OverlappedHandle, IntPtr.Zero);
			if (socketError != SocketError.Success)
			{
				socketError = (SocketError)Marshal.GetLastWin32Error();
			}
		}
		catch (ObjectDisposedException)
		{
			m_RightEndPoint = rightEndPoint;
			throw;
		}
		finally
		{
			socketError = asyncResult.CheckAsyncCallOverlappedResult(socketError);
		}
		if (socketError != SocketError.Success)
		{
			m_RightEndPoint = rightEndPoint;
			asyncResult.ExtractCache(ref Caches.SendOverlappedCache);
			SocketException ex2 = new SocketException(socketError);
			UpdateStatusAfterSocketError(ex2);
			if (s_LoggingEnabled)
			{
				Logging.Exception(Logging.Sockets, this, "BeginSendTo", ex2);
			}
			throw ex2;
		}
	}

	public int EndSendTo(IAsyncResult asyncResult)
	{
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "EndSendTo", asyncResult);
		}
		if (CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		if (asyncResult == null)
		{
			throw new ArgumentNullException("asyncResult");
		}
		if (!(asyncResult is OverlappedAsyncResult overlappedAsyncResult) || overlappedAsyncResult.AsyncObject != this)
		{
			throw new ArgumentException(SR.GetString("net_io_invalidasyncresult"), "asyncResult");
		}
		if (overlappedAsyncResult.EndCalled)
		{
			throw new InvalidOperationException(SR.GetString("net_io_invalidendcall", "EndSendTo"));
		}
		int num = (int)overlappedAsyncResult.InternalWaitForCompletion();
		overlappedAsyncResult.EndCalled = true;
		overlappedAsyncResult.ExtractCache(ref Caches.SendOverlappedCache);
		if (s_PerfCountersEnabled && num > 0)
		{
			NetworkingPerfCounters.Instance.Increment(NetworkingPerfCounterName.SocketBytesSent, num);
			if (Transport == TransportType.Udp)
			{
				NetworkingPerfCounters.Instance.Increment(NetworkingPerfCounterName.SocketDatagramsSent);
			}
		}
		if (overlappedAsyncResult.ErrorCode != 0)
		{
			SocketException ex = new SocketException(overlappedAsyncResult.ErrorCode);
			UpdateStatusAfterSocketError(ex);
			if (s_LoggingEnabled)
			{
				Logging.Exception(Logging.Sockets, this, "EndSendTo", ex);
			}
			throw ex;
		}
		if (s_LoggingEnabled)
		{
			Logging.Exit(Logging.Sockets, this, "EndSendTo", num);
		}
		return num;
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public IAsyncResult BeginReceive(byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state)
	{
		SocketError errorCode;
		IAsyncResult result = BeginReceive(buffer, offset, size, socketFlags, out errorCode, callback, state);
		if (errorCode != SocketError.Success && errorCode != SocketError.IOPending)
		{
			throw new SocketException(errorCode);
		}
		return result;
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public IAsyncResult BeginReceive(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state)
	{
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "BeginReceive", "");
		}
		if (CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (offset < 0 || offset > buffer.Length)
		{
			throw new ArgumentOutOfRangeException("offset");
		}
		if (size < 0 || size > buffer.Length - offset)
		{
			throw new ArgumentOutOfRangeException("size");
		}
		OverlappedAsyncResult overlappedAsyncResult = new OverlappedAsyncResult(this, state, callback);
		overlappedAsyncResult.StartPostingAsyncOp(lockCapture: false);
		errorCode = DoBeginReceive(buffer, offset, size, socketFlags, overlappedAsyncResult);
		if (errorCode != SocketError.Success && errorCode != SocketError.IOPending)
		{
			overlappedAsyncResult = null;
		}
		else
		{
			overlappedAsyncResult.FinishPostingAsyncOp(ref Caches.ReceiveClosureCache);
		}
		if (s_LoggingEnabled)
		{
			Logging.Exit(Logging.Sockets, this, "BeginReceive", overlappedAsyncResult);
		}
		return overlappedAsyncResult;
	}

	internal IAsyncResult UnsafeBeginReceive(byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state)
	{
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "UnsafeBeginReceive", "");
		}
		if (CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		OverlappedAsyncResult overlappedAsyncResult = new OverlappedAsyncResult(this, state, callback);
		DoBeginReceive(buffer, offset, size, socketFlags, overlappedAsyncResult);
		if (s_LoggingEnabled)
		{
			Logging.Exit(Logging.Sockets, this, "UnsafeBeginReceive", overlappedAsyncResult);
		}
		return overlappedAsyncResult;
	}

	private SocketError DoBeginReceive(byte[] buffer, int offset, int size, SocketFlags socketFlags, OverlappedAsyncResult asyncResult)
	{
		SocketError socketError = SocketError.SocketError;
		try
		{
			asyncResult.SetUnmanagedStructures(buffer, offset, size, null, pinSocketAddress: false, ref Caches.ReceiveOverlappedCache);
			socketError = UnsafeNclNativeMethods.OSSOCK.WSARecv(m_Handle, ref asyncResult.m_SingleBuffer, 1, out var _, ref socketFlags, asyncResult.OverlappedHandle, IntPtr.Zero);
			if (socketError != SocketError.Success)
			{
				socketError = (SocketError)Marshal.GetLastWin32Error();
			}
		}
		finally
		{
			socketError = asyncResult.CheckAsyncCallOverlappedResult(socketError);
		}
		if (socketError != SocketError.Success)
		{
			asyncResult.ExtractCache(ref Caches.ReceiveOverlappedCache);
			UpdateStatusAfterSocketError(socketError);
			if (s_LoggingEnabled)
			{
				Logging.Exception(Logging.Sockets, this, "BeginReceive", new SocketException(socketError));
			}
			asyncResult.InvokeCallback(new SocketException(socketError));
		}
		return socketError;
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public IAsyncResult BeginReceive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, AsyncCallback callback, object state)
	{
		SocketError errorCode;
		IAsyncResult result = BeginReceive(buffers, socketFlags, out errorCode, callback, state);
		if (errorCode != SocketError.Success && errorCode != SocketError.IOPending)
		{
			throw new SocketException(errorCode);
		}
		return result;
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public IAsyncResult BeginReceive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state)
	{
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "BeginReceive", "");
		}
		if (CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		if (buffers == null)
		{
			throw new ArgumentNullException("buffers");
		}
		if (buffers.Count == 0)
		{
			throw new ArgumentException(SR.GetString("net_sockets_zerolist", "buffers"), "buffers");
		}
		OverlappedAsyncResult overlappedAsyncResult = new OverlappedAsyncResult(this, state, callback);
		overlappedAsyncResult.StartPostingAsyncOp(lockCapture: false);
		errorCode = DoBeginReceive(buffers, socketFlags, overlappedAsyncResult);
		if (errorCode != SocketError.Success && errorCode != SocketError.IOPending)
		{
			overlappedAsyncResult = null;
		}
		else
		{
			overlappedAsyncResult.FinishPostingAsyncOp(ref Caches.ReceiveClosureCache);
		}
		if (s_LoggingEnabled)
		{
			Logging.Exit(Logging.Sockets, this, "BeginReceive", overlappedAsyncResult);
		}
		return overlappedAsyncResult;
	}

	private SocketError DoBeginReceive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, OverlappedAsyncResult asyncResult)
	{
		SocketError socketError = SocketError.SocketError;
		try
		{
			asyncResult.SetUnmanagedStructures(buffers, ref Caches.ReceiveOverlappedCache);
			socketError = UnsafeNclNativeMethods.OSSOCK.WSARecv(m_Handle, asyncResult.m_WSABuffers, asyncResult.m_WSABuffers.Length, out var _, ref socketFlags, asyncResult.OverlappedHandle, IntPtr.Zero);
			if (socketError != SocketError.Success)
			{
				socketError = (SocketError)Marshal.GetLastWin32Error();
			}
		}
		finally
		{
			socketError = asyncResult.CheckAsyncCallOverlappedResult(socketError);
		}
		if (socketError != SocketError.Success)
		{
			asyncResult.ExtractCache(ref Caches.ReceiveOverlappedCache);
			UpdateStatusAfterSocketError(socketError);
			if (s_LoggingEnabled)
			{
				Logging.Exception(Logging.Sockets, this, "BeginReceive", new SocketException(socketError));
			}
		}
		return socketError;
	}

	public int EndReceive(IAsyncResult asyncResult)
	{
		SocketError errorCode;
		int result = EndReceive(asyncResult, out errorCode);
		if (errorCode != SocketError.Success)
		{
			throw new SocketException(errorCode);
		}
		return result;
	}

	public int EndReceive(IAsyncResult asyncResult, out SocketError errorCode)
	{
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "EndReceive", asyncResult);
		}
		if (CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		if (asyncResult == null)
		{
			throw new ArgumentNullException("asyncResult");
		}
		if (!(asyncResult is OverlappedAsyncResult overlappedAsyncResult) || overlappedAsyncResult.AsyncObject != this)
		{
			throw new ArgumentException(SR.GetString("net_io_invalidasyncresult"), "asyncResult");
		}
		if (overlappedAsyncResult.EndCalled)
		{
			throw new InvalidOperationException(SR.GetString("net_io_invalidendcall", "EndReceive"));
		}
		int num = (int)overlappedAsyncResult.InternalWaitForCompletion();
		overlappedAsyncResult.EndCalled = true;
		overlappedAsyncResult.ExtractCache(ref Caches.ReceiveOverlappedCache);
		if (s_PerfCountersEnabled && num > 0)
		{
			NetworkingPerfCounters.Instance.Increment(NetworkingPerfCounterName.SocketBytesReceived, num);
			if (Transport == TransportType.Udp)
			{
				NetworkingPerfCounters.Instance.Increment(NetworkingPerfCounterName.SocketDatagramsReceived);
			}
		}
		errorCode = (SocketError)overlappedAsyncResult.ErrorCode;
		if (errorCode != SocketError.Success)
		{
			UpdateStatusAfterSocketError(errorCode);
			if (s_LoggingEnabled)
			{
				Logging.Exception(Logging.Sockets, this, "EndReceive", new SocketException(errorCode));
				Logging.Exit(Logging.Sockets, this, "EndReceive", 0);
			}
			return 0;
		}
		if (s_LoggingEnabled)
		{
			Logging.Exit(Logging.Sockets, this, "EndReceive", num);
		}
		return num;
	}

	public IAsyncResult BeginReceiveMessageFrom(byte[] buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP, AsyncCallback callback, object state)
	{
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "BeginReceiveMessageFrom", "");
		}
		if (CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (remoteEP == null)
		{
			throw new ArgumentNullException("remoteEP");
		}
		if (!CanTryAddressFamily(remoteEP.AddressFamily))
		{
			throw new ArgumentException(SR.GetString("net_InvalidEndPointAddressFamily", remoteEP.AddressFamily, addressFamily), "remoteEP");
		}
		if (offset < 0 || offset > buffer.Length)
		{
			throw new ArgumentOutOfRangeException("offset");
		}
		if (size < 0 || size > buffer.Length - offset)
		{
			throw new ArgumentOutOfRangeException("size");
		}
		if (m_RightEndPoint == null)
		{
			throw new InvalidOperationException(SR.GetString("net_sockets_mustbind"));
		}
		ReceiveMessageOverlappedAsyncResult receiveMessageOverlappedAsyncResult = new ReceiveMessageOverlappedAsyncResult(this, state, callback);
		receiveMessageOverlappedAsyncResult.StartPostingAsyncOp(lockCapture: false);
		EndPoint rightEndPoint = m_RightEndPoint;
		SocketAddress socketAddress = SnapshotAndSerialize(ref remoteEP);
		SocketError socketError = SocketError.SocketError;
		try
		{
			receiveMessageOverlappedAsyncResult.SetUnmanagedStructures(buffer, offset, size, socketAddress, socketFlags, ref Caches.ReceiveOverlappedCache);
			receiveMessageOverlappedAsyncResult.SocketAddressOriginal = remoteEP.Serialize();
			SetReceivingPacketInformation();
			if (m_RightEndPoint == null)
			{
				m_RightEndPoint = remoteEP;
			}
			socketError = WSARecvMsg(m_Handle, Marshal.UnsafeAddrOfPinnedArrayElement((Array)receiveMessageOverlappedAsyncResult.m_MessageBuffer, 0), out var _, receiveMessageOverlappedAsyncResult.OverlappedHandle, IntPtr.Zero);
			if (socketError != SocketError.Success)
			{
				socketError = (SocketError)Marshal.GetLastWin32Error();
				if (socketError == SocketError.MessageSize)
				{
					socketError = SocketError.IOPending;
				}
			}
		}
		catch (ObjectDisposedException)
		{
			m_RightEndPoint = rightEndPoint;
			throw;
		}
		finally
		{
			socketError = receiveMessageOverlappedAsyncResult.CheckAsyncCallOverlappedResult(socketError);
		}
		if (socketError != SocketError.Success)
		{
			m_RightEndPoint = rightEndPoint;
			receiveMessageOverlappedAsyncResult.ExtractCache(ref Caches.ReceiveOverlappedCache);
			SocketException ex2 = new SocketException(socketError);
			UpdateStatusAfterSocketError(ex2);
			if (s_LoggingEnabled)
			{
				Logging.Exception(Logging.Sockets, this, "BeginReceiveMessageFrom", ex2);
			}
			throw ex2;
		}
		receiveMessageOverlappedAsyncResult.FinishPostingAsyncOp(ref Caches.ReceiveClosureCache);
		if (receiveMessageOverlappedAsyncResult.CompletedSynchronously && !receiveMessageOverlappedAsyncResult.SocketAddressOriginal.Equals(receiveMessageOverlappedAsyncResult.SocketAddress))
		{
			try
			{
				remoteEP = remoteEP.Create(receiveMessageOverlappedAsyncResult.SocketAddress);
			}
			catch
			{
			}
		}
		if (s_LoggingEnabled)
		{
			Logging.Exit(Logging.Sockets, this, "BeginReceiveMessageFrom", receiveMessageOverlappedAsyncResult);
		}
		return receiveMessageOverlappedAsyncResult;
	}

	public int EndReceiveMessageFrom(IAsyncResult asyncResult, ref SocketFlags socketFlags, ref EndPoint endPoint, out IPPacketInformation ipPacketInformation)
	{
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "EndReceiveMessageFrom", asyncResult);
		}
		if (CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		if (endPoint == null)
		{
			throw new ArgumentNullException("endPoint");
		}
		if (!CanTryAddressFamily(endPoint.AddressFamily))
		{
			throw new ArgumentException(SR.GetString("net_InvalidEndPointAddressFamily", endPoint.AddressFamily, addressFamily), "endPoint");
		}
		if (asyncResult == null)
		{
			throw new ArgumentNullException("asyncResult");
		}
		if (!(asyncResult is ReceiveMessageOverlappedAsyncResult receiveMessageOverlappedAsyncResult) || receiveMessageOverlappedAsyncResult.AsyncObject != this)
		{
			throw new ArgumentException(SR.GetString("net_io_invalidasyncresult"), "asyncResult");
		}
		if (receiveMessageOverlappedAsyncResult.EndCalled)
		{
			throw new InvalidOperationException(SR.GetString("net_io_invalidendcall", "EndReceiveMessageFrom"));
		}
		SocketAddress socketAddress = SnapshotAndSerialize(ref endPoint);
		int num = (int)receiveMessageOverlappedAsyncResult.InternalWaitForCompletion();
		receiveMessageOverlappedAsyncResult.EndCalled = true;
		receiveMessageOverlappedAsyncResult.ExtractCache(ref Caches.ReceiveOverlappedCache);
		receiveMessageOverlappedAsyncResult.SocketAddress.SetSize(receiveMessageOverlappedAsyncResult.GetSocketAddressSizePtr());
		if (!socketAddress.Equals(receiveMessageOverlappedAsyncResult.SocketAddress))
		{
			try
			{
				endPoint = endPoint.Create(receiveMessageOverlappedAsyncResult.SocketAddress);
			}
			catch
			{
			}
		}
		if (s_PerfCountersEnabled && num > 0)
		{
			NetworkingPerfCounters.Instance.Increment(NetworkingPerfCounterName.SocketBytesReceived, num);
			if (Transport == TransportType.Udp)
			{
				NetworkingPerfCounters.Instance.Increment(NetworkingPerfCounterName.SocketDatagramsReceived);
			}
		}
		if (receiveMessageOverlappedAsyncResult.ErrorCode != 0 && receiveMessageOverlappedAsyncResult.ErrorCode != 10040)
		{
			SocketException ex = new SocketException(receiveMessageOverlappedAsyncResult.ErrorCode);
			UpdateStatusAfterSocketError(ex);
			if (s_LoggingEnabled)
			{
				Logging.Exception(Logging.Sockets, this, "EndReceiveMessageFrom", ex);
			}
			throw ex;
		}
		socketFlags = receiveMessageOverlappedAsyncResult.m_flags;
		ipPacketInformation = receiveMessageOverlappedAsyncResult.m_IPPacketInformation;
		if (s_LoggingEnabled)
		{
			Logging.Exit(Logging.Sockets, this, "EndReceiveMessageFrom", num);
		}
		return num;
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public IAsyncResult BeginReceiveFrom(byte[] buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP, AsyncCallback callback, object state)
	{
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "BeginReceiveFrom", "");
		}
		if (CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (remoteEP == null)
		{
			throw new ArgumentNullException("remoteEP");
		}
		if (!CanTryAddressFamily(remoteEP.AddressFamily))
		{
			throw new ArgumentException(SR.GetString("net_InvalidEndPointAddressFamily", remoteEP.AddressFamily, addressFamily), "remoteEP");
		}
		if (offset < 0 || offset > buffer.Length)
		{
			throw new ArgumentOutOfRangeException("offset");
		}
		if (size < 0 || size > buffer.Length - offset)
		{
			throw new ArgumentOutOfRangeException("size");
		}
		if (m_RightEndPoint == null)
		{
			throw new InvalidOperationException(SR.GetString("net_sockets_mustbind"));
		}
		SocketAddress socketAddress = SnapshotAndSerialize(ref remoteEP);
		OverlappedAsyncResult overlappedAsyncResult = new ReceiveFromOverlappedAsyncResult(this, state, callback);
		overlappedAsyncResult.StartPostingAsyncOp(lockCapture: false);
		DoBeginReceiveFrom(buffer, offset, size, socketFlags, remoteEP, socketAddress, overlappedAsyncResult);
		overlappedAsyncResult.FinishPostingAsyncOp(ref Caches.ReceiveClosureCache);
		if (overlappedAsyncResult.CompletedSynchronously && !overlappedAsyncResult.SocketAddressOriginal.Equals(overlappedAsyncResult.SocketAddress))
		{
			try
			{
				remoteEP = remoteEP.Create(overlappedAsyncResult.SocketAddress);
			}
			catch
			{
			}
		}
		if (s_LoggingEnabled)
		{
			Logging.Exit(Logging.Sockets, this, "BeginReceiveFrom", overlappedAsyncResult);
		}
		return overlappedAsyncResult;
	}

	private void DoBeginReceiveFrom(byte[] buffer, int offset, int size, SocketFlags socketFlags, EndPoint endPointSnapshot, SocketAddress socketAddress, OverlappedAsyncResult asyncResult)
	{
		EndPoint rightEndPoint = m_RightEndPoint;
		SocketError socketError = SocketError.SocketError;
		try
		{
			asyncResult.SetUnmanagedStructures(buffer, offset, size, socketAddress, pinSocketAddress: true, ref Caches.ReceiveOverlappedCache);
			asyncResult.SocketAddressOriginal = endPointSnapshot.Serialize();
			if (m_RightEndPoint == null)
			{
				m_RightEndPoint = endPointSnapshot;
			}
			socketError = UnsafeNclNativeMethods.OSSOCK.WSARecvFrom(m_Handle, ref asyncResult.m_SingleBuffer, 1, out var _, ref socketFlags, asyncResult.GetSocketAddressPtr(), asyncResult.GetSocketAddressSizePtr(), asyncResult.OverlappedHandle, IntPtr.Zero);
			if (socketError != SocketError.Success)
			{
				socketError = (SocketError)Marshal.GetLastWin32Error();
			}
		}
		catch (ObjectDisposedException)
		{
			m_RightEndPoint = rightEndPoint;
			throw;
		}
		finally
		{
			socketError = asyncResult.CheckAsyncCallOverlappedResult(socketError);
		}
		if (socketError != SocketError.Success)
		{
			m_RightEndPoint = rightEndPoint;
			asyncResult.ExtractCache(ref Caches.ReceiveOverlappedCache);
			SocketException ex2 = new SocketException(socketError);
			UpdateStatusAfterSocketError(ex2);
			if (s_LoggingEnabled)
			{
				Logging.Exception(Logging.Sockets, this, "BeginReceiveFrom", ex2);
			}
			throw ex2;
		}
	}

	public int EndReceiveFrom(IAsyncResult asyncResult, ref EndPoint endPoint)
	{
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "EndReceiveFrom", asyncResult);
		}
		if (CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		if (endPoint == null)
		{
			throw new ArgumentNullException("endPoint");
		}
		if (!CanTryAddressFamily(endPoint.AddressFamily))
		{
			throw new ArgumentException(SR.GetString("net_InvalidEndPointAddressFamily", endPoint.AddressFamily, addressFamily), "endPoint");
		}
		if (asyncResult == null)
		{
			throw new ArgumentNullException("asyncResult");
		}
		if (!(asyncResult is OverlappedAsyncResult overlappedAsyncResult) || overlappedAsyncResult.AsyncObject != this)
		{
			throw new ArgumentException(SR.GetString("net_io_invalidasyncresult"), "asyncResult");
		}
		if (overlappedAsyncResult.EndCalled)
		{
			throw new InvalidOperationException(SR.GetString("net_io_invalidendcall", "EndReceiveFrom"));
		}
		SocketAddress socketAddress = SnapshotAndSerialize(ref endPoint);
		int num = (int)overlappedAsyncResult.InternalWaitForCompletion();
		overlappedAsyncResult.EndCalled = true;
		overlappedAsyncResult.ExtractCache(ref Caches.ReceiveOverlappedCache);
		if (!socketAddress.Equals(overlappedAsyncResult.SocketAddress))
		{
			try
			{
				endPoint = endPoint.Create(overlappedAsyncResult.SocketAddress);
			}
			catch
			{
			}
		}
		if (s_PerfCountersEnabled && num > 0)
		{
			NetworkingPerfCounters.Instance.Increment(NetworkingPerfCounterName.SocketBytesReceived, num);
			if (Transport == TransportType.Udp)
			{
				NetworkingPerfCounters.Instance.Increment(NetworkingPerfCounterName.SocketDatagramsReceived);
			}
		}
		if (overlappedAsyncResult.ErrorCode != 0)
		{
			SocketException ex = new SocketException(overlappedAsyncResult.ErrorCode);
			UpdateStatusAfterSocketError(ex);
			if (s_LoggingEnabled)
			{
				Logging.Exception(Logging.Sockets, this, "EndReceiveFrom", ex);
			}
			throw ex;
		}
		if (s_LoggingEnabled)
		{
			Logging.Exit(Logging.Sockets, this, "EndReceiveFrom", num);
		}
		return num;
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public IAsyncResult BeginAccept(AsyncCallback callback, object state)
	{
		if (CanUseAcceptEx)
		{
			return BeginAccept(0, callback, state);
		}
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "BeginAccept", "");
		}
		if (CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		AcceptAsyncResult acceptAsyncResult = new AcceptAsyncResult(this, state, callback);
		acceptAsyncResult.StartPostingAsyncOp(lockCapture: false);
		DoBeginAccept(acceptAsyncResult);
		acceptAsyncResult.FinishPostingAsyncOp(ref Caches.AcceptClosureCache);
		if (s_LoggingEnabled)
		{
			Logging.Exit(Logging.Sockets, this, "BeginAccept", acceptAsyncResult);
		}
		return acceptAsyncResult;
	}

	private void DoBeginAccept(LazyAsyncResult asyncResult)
	{
		if (m_RightEndPoint == null)
		{
			throw new InvalidOperationException(SR.GetString("net_sockets_mustbind"));
		}
		if (!isListening)
		{
			throw new InvalidOperationException(SR.GetString("net_sockets_mustlisten"));
		}
		bool flag = false;
		SocketError socketError = SocketError.Success;
		Queue acceptQueue = GetAcceptQueue();
		lock (this)
		{
			if (acceptQueue.Count == 0)
			{
				SocketAddress socketAddress = m_RightEndPoint.Serialize();
				InternalSetBlocking(desired: false);
				SafeCloseSocket safeCloseSocket = null;
				try
				{
					safeCloseSocket = SafeCloseSocket.Accept(m_Handle, socketAddress.m_Buffer, ref socketAddress.m_Size);
					socketError = (safeCloseSocket.IsInvalid ? ((SocketError)Marshal.GetLastWin32Error()) : SocketError.Success);
				}
				catch (ObjectDisposedException)
				{
					socketError = SocketError.NotSocket;
				}
				if (socketError != SocketError.WouldBlock)
				{
					if (socketError == SocketError.Success)
					{
						asyncResult.Result = CreateAcceptSocket(safeCloseSocket, m_RightEndPoint.Create(socketAddress), needCancelSelect: false);
					}
					else
					{
						asyncResult.ErrorCode = (int)socketError;
					}
					InternalSetBlocking(desired: true);
					flag = true;
				}
				else
				{
					acceptQueue.Enqueue(asyncResult);
					if (!SetAsyncEventSelect(AsyncEventBits.FdAccept))
					{
						acceptQueue.Dequeue();
						throw new ObjectDisposedException(GetType().FullName);
					}
				}
			}
			else
			{
				acceptQueue.Enqueue(asyncResult);
			}
		}
		if (!flag)
		{
			return;
		}
		if (socketError == SocketError.Success)
		{
			asyncResult.InvokeCallback();
			return;
		}
		SocketException ex2 = new SocketException(socketError);
		UpdateStatusAfterSocketError(ex2);
		if (s_LoggingEnabled)
		{
			Logging.Exception(Logging.Sockets, this, "BeginAccept", ex2);
		}
		throw ex2;
	}

	private void CompleteAcceptResults(object nullState)
	{
		Queue acceptQueue = GetAcceptQueue();
		bool flag = true;
		while (flag)
		{
			LazyAsyncResult lazyAsyncResult = null;
			lock (this)
			{
				if (acceptQueue.Count == 0)
				{
					break;
				}
				lazyAsyncResult = (LazyAsyncResult)acceptQueue.Dequeue();
				if (acceptQueue.Count == 0)
				{
					flag = false;
				}
			}
			try
			{
				lazyAsyncResult.InvokeCallback(new SocketException(SocketError.OperationAborted));
			}
			catch
			{
				if (flag)
				{
					ThreadPool.UnsafeQueueUserWorkItem(CompleteAcceptResults, null);
				}
				throw;
			}
		}
	}

	private void AcceptCallback(object nullState)
	{
		bool flag = true;
		Queue acceptQueue = GetAcceptQueue();
		while (flag)
		{
			LazyAsyncResult lazyAsyncResult = null;
			SocketError socketError = SocketError.OperationAborted;
			SocketAddress socketAddress = null;
			SafeCloseSocket safeCloseSocket = null;
			Exception ex = null;
			object result = null;
			lock (this)
			{
				if (acceptQueue.Count == 0)
				{
					break;
				}
				lazyAsyncResult = (LazyAsyncResult)acceptQueue.Peek();
				if (!CleanedUp)
				{
					socketAddress = m_RightEndPoint.Serialize();
					try
					{
						safeCloseSocket = SafeCloseSocket.Accept(m_Handle, socketAddress.m_Buffer, ref socketAddress.m_Size);
						socketError = (safeCloseSocket.IsInvalid ? ((SocketError)Marshal.GetLastWin32Error()) : SocketError.Success);
					}
					catch (ObjectDisposedException)
					{
						socketError = SocketError.OperationAborted;
					}
					catch (Exception ex3)
					{
						if (NclUtilities.IsFatal(ex3))
						{
							throw;
						}
						ex = ex3;
					}
				}
				if (socketError == SocketError.WouldBlock && ex == null)
				{
					try
					{
						m_AsyncEvent.Reset();
						if (SetAsyncEventSelect(AsyncEventBits.FdAccept))
						{
							break;
						}
					}
					catch (ObjectDisposedException)
					{
					}
					ex = new ObjectDisposedException(GetType().FullName);
				}
				if (ex != null)
				{
					result = ex;
				}
				else if (socketError == SocketError.Success)
				{
					result = CreateAcceptSocket(safeCloseSocket, m_RightEndPoint.Create(socketAddress), needCancelSelect: true);
				}
				else
				{
					lazyAsyncResult.ErrorCode = (int)socketError;
				}
				acceptQueue.Dequeue();
				if (acceptQueue.Count == 0)
				{
					if (!CleanedUp)
					{
						UnsetAsyncEventSelect();
					}
					flag = false;
				}
			}
			try
			{
				lazyAsyncResult.InvokeCallback(result);
			}
			catch
			{
				if (flag)
				{
					ThreadPool.UnsafeQueueUserWorkItem(AcceptCallback, nullState);
				}
				throw;
			}
		}
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public IAsyncResult BeginAccept(int receiveSize, AsyncCallback callback, object state)
	{
		return BeginAccept(null, receiveSize, callback, state);
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public IAsyncResult BeginAccept(Socket acceptSocket, int receiveSize, AsyncCallback callback, object state)
	{
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "BeginAccept", "");
		}
		if (CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		if (receiveSize < 0)
		{
			throw new ArgumentOutOfRangeException("size");
		}
		AcceptOverlappedAsyncResult acceptOverlappedAsyncResult = new AcceptOverlappedAsyncResult(this, state, callback);
		acceptOverlappedAsyncResult.StartPostingAsyncOp(lockCapture: false);
		DoBeginAccept(acceptSocket, receiveSize, acceptOverlappedAsyncResult);
		acceptOverlappedAsyncResult.FinishPostingAsyncOp(ref Caches.AcceptClosureCache);
		if (s_LoggingEnabled)
		{
			Logging.Exit(Logging.Sockets, this, "BeginAccept", acceptOverlappedAsyncResult);
		}
		return acceptOverlappedAsyncResult;
	}

	private void DoBeginAccept(Socket acceptSocket, int receiveSize, AcceptOverlappedAsyncResult asyncResult)
	{
		if (m_RightEndPoint == null)
		{
			throw new InvalidOperationException(SR.GetString("net_sockets_mustbind"));
		}
		if (!isListening)
		{
			throw new InvalidOperationException(SR.GetString("net_sockets_mustlisten"));
		}
		if (acceptSocket == null)
		{
			acceptSocket = new Socket(addressFamily, socketType, protocolType);
		}
		else if (acceptSocket.m_RightEndPoint != null)
		{
			throw new InvalidOperationException(SR.GetString("net_sockets_namedmustnotbebound", "acceptSocket"));
		}
		asyncResult.AcceptSocket = acceptSocket;
		int num = m_RightEndPoint.Serialize().Size + 16;
		byte[] buffer = new byte[receiveSize + num * 2];
		asyncResult.SetUnmanagedStructures(buffer, num);
		SocketError errorCode = SocketError.Success;
		if (!AcceptEx(m_Handle, acceptSocket.m_Handle, Marshal.UnsafeAddrOfPinnedArrayElement((Array)asyncResult.Buffer, 0), receiveSize, num, num, out var _, asyncResult.OverlappedHandle))
		{
			errorCode = (SocketError)Marshal.GetLastWin32Error();
		}
		errorCode = asyncResult.CheckAsyncCallOverlappedResult(errorCode);
		if (errorCode != SocketError.Success)
		{
			SocketException ex = new SocketException(errorCode);
			UpdateStatusAfterSocketError(ex);
			if (s_LoggingEnabled)
			{
				Logging.Exception(Logging.Sockets, this, "BeginAccept", ex);
			}
			throw ex;
		}
	}

	public Socket EndAccept(IAsyncResult asyncResult)
	{
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "EndAccept", asyncResult);
		}
		if (CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		byte[] buffer;
		int bytesTransferred;
		if (asyncResult != null && asyncResult is AcceptOverlappedAsyncResult)
		{
			return EndAccept(out buffer, out bytesTransferred, asyncResult);
		}
		if (asyncResult == null)
		{
			throw new ArgumentNullException("asyncResult");
		}
		if (!(asyncResult is AcceptAsyncResult acceptAsyncResult) || acceptAsyncResult.AsyncObject != this)
		{
			throw new ArgumentException(SR.GetString("net_io_invalidasyncresult"), "asyncResult");
		}
		if (acceptAsyncResult.EndCalled)
		{
			throw new InvalidOperationException(SR.GetString("net_io_invalidendcall", "EndAccept"));
		}
		object obj = acceptAsyncResult.InternalWaitForCompletion();
		acceptAsyncResult.EndCalled = true;
		if (obj is Exception ex)
		{
			throw ex;
		}
		if (acceptAsyncResult.ErrorCode != 0)
		{
			SocketException ex2 = new SocketException(acceptAsyncResult.ErrorCode);
			UpdateStatusAfterSocketError(ex2);
			if (s_LoggingEnabled)
			{
				Logging.Exception(Logging.Sockets, this, "EndAccept", ex2);
			}
			throw ex2;
		}
		Socket socket = (Socket)obj;
		if (s_LoggingEnabled)
		{
			Logging.PrintInfo(Logging.Sockets, socket, SR.GetString("net_log_socket_accepted", socket.RemoteEndPoint, socket.LocalEndPoint));
			Logging.Exit(Logging.Sockets, this, "EndAccept", obj);
		}
		return socket;
	}

	public Socket EndAccept(out byte[] buffer, IAsyncResult asyncResult)
	{
		byte[] buffer2;
		int bytesTransferred;
		Socket result = EndAccept(out buffer2, out bytesTransferred, asyncResult);
		buffer = new byte[bytesTransferred];
		Array.Copy(buffer2, buffer, bytesTransferred);
		return result;
	}

	public Socket EndAccept(out byte[] buffer, out int bytesTransferred, IAsyncResult asyncResult)
	{
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "EndAccept", asyncResult);
		}
		if (CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		if (asyncResult == null)
		{
			throw new ArgumentNullException("asyncResult");
		}
		if (!(asyncResult is AcceptOverlappedAsyncResult acceptOverlappedAsyncResult) || acceptOverlappedAsyncResult.AsyncObject != this)
		{
			throw new ArgumentException(SR.GetString("net_io_invalidasyncresult"), "asyncResult");
		}
		if (acceptOverlappedAsyncResult.EndCalled)
		{
			throw new InvalidOperationException(SR.GetString("net_io_invalidendcall", "EndAccept"));
		}
		Socket socket = (Socket)acceptOverlappedAsyncResult.InternalWaitForCompletion();
		bytesTransferred = acceptOverlappedAsyncResult.BytesTransferred;
		buffer = acceptOverlappedAsyncResult.Buffer;
		acceptOverlappedAsyncResult.EndCalled = true;
		if (s_PerfCountersEnabled && bytesTransferred > 0)
		{
			NetworkingPerfCounters.Instance.Increment(NetworkingPerfCounterName.SocketBytesReceived, bytesTransferred);
		}
		if (acceptOverlappedAsyncResult.ErrorCode != 0)
		{
			SocketException ex = new SocketException(acceptOverlappedAsyncResult.ErrorCode);
			UpdateStatusAfterSocketError(ex);
			if (s_LoggingEnabled)
			{
				Logging.Exception(Logging.Sockets, this, "EndAccept", ex);
			}
			throw ex;
		}
		if (s_LoggingEnabled)
		{
			Logging.PrintInfo(Logging.Sockets, socket, SR.GetString("net_log_socket_accepted", socket.RemoteEndPoint, socket.LocalEndPoint));
			Logging.Exit(Logging.Sockets, this, "EndAccept", socket);
		}
		return socket;
	}

	public void Shutdown(SocketShutdown how)
	{
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "Shutdown", how);
		}
		if (CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		SocketError socketError = UnsafeNclNativeMethods.OSSOCK.shutdown(m_Handle, (int)how);
		socketError = ((socketError == SocketError.SocketError) ? ((SocketError)Marshal.GetLastWin32Error()) : SocketError.Success);
		if (socketError != SocketError.Success && socketError != SocketError.NotSocket)
		{
			SocketException ex = new SocketException(socketError);
			UpdateStatusAfterSocketError(ex);
			if (s_LoggingEnabled)
			{
				Logging.Exception(Logging.Sockets, this, "Shutdown", ex);
			}
			throw ex;
		}
		SetToDisconnected();
		InternalSetBlocking(willBlockInternal);
		if (s_LoggingEnabled)
		{
			Logging.Exit(Logging.Sockets, this, "Shutdown", "");
		}
	}

	private void EnsureDynamicWinsockMethods()
	{
		if (m_DynamicWinsockMethods == null)
		{
			m_DynamicWinsockMethods = DynamicWinsockMethods.GetMethods(addressFamily, socketType, protocolType);
		}
	}

	private bool AcceptEx(SafeCloseSocket listenSocketHandle, SafeCloseSocket acceptSocketHandle, IntPtr buffer, int len, int localAddressLength, int remoteAddressLength, out int bytesReceived, SafeHandle overlapped)
	{
		EnsureDynamicWinsockMethods();
		AcceptExDelegate acceptExDelegate = m_DynamicWinsockMethods.GetDelegate<AcceptExDelegate>(listenSocketHandle);
		return acceptExDelegate(listenSocketHandle, acceptSocketHandle, buffer, len, localAddressLength, remoteAddressLength, out bytesReceived, overlapped);
	}

	internal void GetAcceptExSockaddrs(IntPtr buffer, int receiveDataLength, int localAddressLength, int remoteAddressLength, out IntPtr localSocketAddress, out int localSocketAddressLength, out IntPtr remoteSocketAddress, out int remoteSocketAddressLength)
	{
		EnsureDynamicWinsockMethods();
		GetAcceptExSockaddrsDelegate getAcceptExSockaddrsDelegate = m_DynamicWinsockMethods.GetDelegate<GetAcceptExSockaddrsDelegate>(m_Handle);
		getAcceptExSockaddrsDelegate(buffer, receiveDataLength, localAddressLength, remoteAddressLength, out localSocketAddress, out localSocketAddressLength, out remoteSocketAddress, out remoteSocketAddressLength);
	}

	private bool DisconnectEx(SafeCloseSocket socketHandle, SafeHandle overlapped, int flags, int reserved)
	{
		EnsureDynamicWinsockMethods();
		DisconnectExDelegate disconnectExDelegate = m_DynamicWinsockMethods.GetDelegate<DisconnectExDelegate>(socketHandle);
		return disconnectExDelegate(socketHandle, overlapped, flags, reserved);
	}

	private bool DisconnectEx_Blocking(IntPtr socketHandle, IntPtr overlapped, int flags, int reserved)
	{
		EnsureDynamicWinsockMethods();
		DisconnectExDelegate_Blocking disconnectExDelegate_Blocking = m_DynamicWinsockMethods.GetDelegate<DisconnectExDelegate_Blocking>(m_Handle);
		return disconnectExDelegate_Blocking(socketHandle, overlapped, flags, reserved);
	}

	private bool ConnectEx(SafeCloseSocket socketHandle, IntPtr socketAddress, int socketAddressSize, IntPtr buffer, int dataLength, out int bytesSent, SafeHandle overlapped)
	{
		EnsureDynamicWinsockMethods();
		ConnectExDelegate connectExDelegate = m_DynamicWinsockMethods.GetDelegate<ConnectExDelegate>(socketHandle);
		return connectExDelegate(socketHandle, socketAddress, socketAddressSize, buffer, dataLength, out bytesSent, overlapped);
	}

	private SocketError WSARecvMsg(SafeCloseSocket socketHandle, IntPtr msg, out int bytesTransferred, SafeHandle overlapped, IntPtr completionRoutine)
	{
		EnsureDynamicWinsockMethods();
		WSARecvMsgDelegate wSARecvMsgDelegate = m_DynamicWinsockMethods.GetDelegate<WSARecvMsgDelegate>(socketHandle);
		return wSARecvMsgDelegate(socketHandle, msg, out bytesTransferred, overlapped, completionRoutine);
	}

	private SocketError WSARecvMsg_Blocking(IntPtr socketHandle, IntPtr msg, out int bytesTransferred, IntPtr overlapped, IntPtr completionRoutine)
	{
		EnsureDynamicWinsockMethods();
		WSARecvMsgDelegate_Blocking wSARecvMsgDelegate_Blocking = m_DynamicWinsockMethods.GetDelegate<WSARecvMsgDelegate_Blocking>(m_Handle);
		return wSARecvMsgDelegate_Blocking(socketHandle, msg, out bytesTransferred, overlapped, completionRoutine);
	}

	private bool TransmitPackets(SafeCloseSocket socketHandle, IntPtr packetArray, int elementCount, int sendSize, SafeNativeOverlapped overlapped, TransmitFileOptions flags)
	{
		EnsureDynamicWinsockMethods();
		TransmitPacketsDelegate transmitPacketsDelegate = m_DynamicWinsockMethods.GetDelegate<TransmitPacketsDelegate>(socketHandle);
		return transmitPacketsDelegate(socketHandle, packetArray, elementCount, sendSize, overlapped, flags);
	}

	private Queue GetAcceptQueue()
	{
		if (m_AcceptQueueOrConnectResult == null)
		{
			Interlocked.CompareExchange(ref m_AcceptQueueOrConnectResult, new Queue(16), null);
		}
		return (Queue)m_AcceptQueueOrConnectResult;
	}

	private void CheckSetOptionPermissions(SocketOptionLevel optionLevel, SocketOptionName optionName)
	{
		if ((optionLevel != SocketOptionLevel.Tcp || (optionName != SocketOptionName.Debug && optionName != SocketOptionName.AcceptConnection && optionName != SocketOptionName.AcceptConnection)) && (optionLevel != SocketOptionLevel.Udp || (optionName != SocketOptionName.Debug && optionName != SocketOptionName.ChecksumCoverage)) && (optionLevel != SocketOptionLevel.Socket || (optionName != SocketOptionName.KeepAlive && optionName != SocketOptionName.Linger && optionName != SocketOptionName.DontLinger && optionName != SocketOptionName.SendBuffer && optionName != SocketOptionName.ReceiveBuffer && optionName != SocketOptionName.SendTimeout && optionName != SocketOptionName.ExclusiveAddressUse && optionName != SocketOptionName.ReceiveTimeout)) && (optionLevel != SocketOptionLevel.IPv6 || optionName != SocketOptionName.IPProtectionLevel))
		{
			ExceptionHelper.UnmanagedPermission.Demand();
		}
	}

	private SocketAddress SnapshotAndSerialize(ref EndPoint remoteEP)
	{
		if (remoteEP is IPEndPoint iPEndPoint)
		{
			IPEndPoint input = iPEndPoint.Snapshot();
			remoteEP = RemapIPEndPoint(input);
		}
		return CallSerializeCheckDnsEndPoint(remoteEP);
	}

	private SocketAddress CallSerializeCheckDnsEndPoint(EndPoint remoteEP)
	{
		if (remoteEP is DnsEndPoint)
		{
			throw new ArgumentException(SR.GetString("net_sockets_invalid_dnsendpoint", "remoteEP"), "remoteEP");
		}
		return remoteEP.Serialize();
	}

	private IPEndPoint RemapIPEndPoint(IPEndPoint input)
	{
		if (input.AddressFamily == AddressFamily.InterNetwork && IsDualMode)
		{
			return new IPEndPoint(input.Address.MapToIPv6(), input.Port);
		}
		return input;
	}

	private SocketAddress CheckCacheRemote(ref EndPoint remoteEP, bool isOverwrite)
	{
		IPEndPoint iPEndPoint = remoteEP as IPEndPoint;
		if (iPEndPoint != null)
		{
			iPEndPoint = iPEndPoint.Snapshot();
			remoteEP = RemapIPEndPoint(iPEndPoint);
		}
		SocketAddress socketAddress = CallSerializeCheckDnsEndPoint(remoteEP);
		SocketAddress permittedRemoteAddress = m_PermittedRemoteAddress;
		if (permittedRemoteAddress != null && permittedRemoteAddress.Equals(socketAddress))
		{
			return permittedRemoteAddress;
		}
		if (iPEndPoint != null)
		{
			SocketPermission socketPermission = new SocketPermission(NetworkAccess.Connect, Transport, iPEndPoint.Address.ToString(), iPEndPoint.Port);
			socketPermission.Demand();
		}
		else
		{
			ExceptionHelper.UnmanagedPermission.Demand();
		}
		if (m_PermittedRemoteAddress == null || isOverwrite)
		{
			m_PermittedRemoteAddress = socketAddress;
		}
		return socketAddress;
	}

	internal static void InitializeSockets()
	{
		if (s_Initialized)
		{
			return;
		}
		lock (InternalSyncObject)
		{
			if (s_Initialized)
			{
				return;
			}
			WSAData lpWSAData = default(WSAData);
			SocketError socketError = UnsafeNclNativeMethods.OSSOCK.WSAStartup(514, out lpWSAData);
			if (socketError != SocketError.Success)
			{
				throw new SocketException(socketError);
			}
			bool flag = true;
			bool flag2 = true;
			SafeCloseSocket.InnerSafeCloseSocket innerSafeCloseSocket = UnsafeNclNativeMethods.OSSOCK.WSASocket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.IP, IntPtr.Zero, 0u, (SocketConstructorFlags)0);
			if (innerSafeCloseSocket.IsInvalid)
			{
				socketError = (SocketError)Marshal.GetLastWin32Error();
				if (socketError == SocketError.AddressFamilyNotSupported)
				{
					flag = false;
				}
			}
			innerSafeCloseSocket.Close();
			SafeCloseSocket.InnerSafeCloseSocket innerSafeCloseSocket2 = UnsafeNclNativeMethods.OSSOCK.WSASocket(AddressFamily.InterNetworkV6, SocketType.Dgram, ProtocolType.IP, IntPtr.Zero, 0u, (SocketConstructorFlags)0);
			if (innerSafeCloseSocket2.IsInvalid)
			{
				socketError = (SocketError)Marshal.GetLastWin32Error();
				if (socketError == SocketError.AddressFamilyNotSupported)
				{
					flag2 = false;
				}
			}
			innerSafeCloseSocket2.Close();
			if (flag2)
			{
				s_OSSupportsIPv6 = true;
				flag2 = SettingsSectionInternal.Section.Ipv6Enabled;
			}
			s_SupportsIPv4 = flag;
			s_SupportsIPv6 = flag2;
			s_PerfCountersEnabled = NetworkingPerfCounters.Instance.Enabled;
			s_Initialized = true;
		}
	}

	private MultipleAddressConnectAsyncResult InternalBeginConnectHostName(string host, int port, AsyncCallback requestCallback, object state)
	{
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "InternalBeginConnectHostName", host);
		}
		MultipleAddressConnectAsyncResult multipleAddressConnectAsyncResult = new MultipleAddressConnectAsyncResult(null, port, this, state, requestCallback);
		multipleAddressConnectAsyncResult.StartPostingAsyncOp(lockCapture: false);
		IAsyncResult asyncResult = Dns.UnsafeBeginGetHostAddresses(host, DnsCallback, multipleAddressConnectAsyncResult);
		if (asyncResult.CompletedSynchronously && DoDnsCallback(asyncResult, multipleAddressConnectAsyncResult))
		{
			multipleAddressConnectAsyncResult.InvokeCallback();
		}
		multipleAddressConnectAsyncResult.FinishPostingAsyncOp(ref Caches.ConnectClosureCache);
		if (s_LoggingEnabled)
		{
			Logging.Exit(Logging.Sockets, this, "InternalBeginConnectHostName", multipleAddressConnectAsyncResult);
		}
		return multipleAddressConnectAsyncResult;
	}

	private void InternalEndConnect(IAsyncResult asyncResult)
	{
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "InternalEndConnect", asyncResult);
		}
		if (CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		if (asyncResult == null)
		{
			throw new ArgumentNullException("asyncResult");
		}
		LazyAsyncResult lazyAsyncResult = null;
		EndPoint endPoint = null;
		if (!(asyncResult is ConnectOverlappedAsyncResult connectOverlappedAsyncResult))
		{
			if (!(asyncResult is MultipleAddressConnectAsyncResult multipleAddressConnectAsyncResult))
			{
				if (asyncResult is ConnectAsyncResult connectAsyncResult)
				{
					endPoint = connectAsyncResult.RemoteEndPoint;
					lazyAsyncResult = connectAsyncResult;
				}
			}
			else
			{
				endPoint = multipleAddressConnectAsyncResult.RemoteEndPoint;
				lazyAsyncResult = multipleAddressConnectAsyncResult;
			}
		}
		else
		{
			endPoint = connectOverlappedAsyncResult.RemoteEndPoint;
			lazyAsyncResult = connectOverlappedAsyncResult;
		}
		if (lazyAsyncResult == null || lazyAsyncResult.AsyncObject != this)
		{
			throw new ArgumentException(SR.GetString("net_io_invalidasyncresult"), "asyncResult");
		}
		if (lazyAsyncResult.EndCalled)
		{
			throw new InvalidOperationException(SR.GetString("net_io_invalidendcall", "InternalEndConnect"));
		}
		lazyAsyncResult.InternalWaitForCompletion();
		lazyAsyncResult.EndCalled = true;
		m_AcceptQueueOrConnectResult = null;
		if (lazyAsyncResult.Result is Exception)
		{
			if (s_LoggingEnabled)
			{
				Logging.Exception(Logging.Sockets, this, "InternalEndConnect", (Exception)lazyAsyncResult.Result);
			}
			throw (Exception)lazyAsyncResult.Result;
		}
		if (lazyAsyncResult.ErrorCode != 0)
		{
			SocketException ex = new SocketException(lazyAsyncResult.ErrorCode, endPoint);
			UpdateStatusAfterSocketError(ex);
			if (s_LoggingEnabled)
			{
				Logging.Exception(Logging.Sockets, this, "InternalEndConnect", ex);
			}
			throw ex;
		}
		if (s_LoggingEnabled)
		{
			Logging.PrintInfo(Logging.Sockets, this, SR.GetString("net_log_socket_connected", LocalEndPoint, RemoteEndPoint));
			Logging.Exit(Logging.Sockets, this, "InternalEndConnect", "");
		}
	}

	internal void InternalConnect(EndPoint remoteEP)
	{
		EndPoint remoteEP2 = remoteEP;
		SocketAddress socketAddress = SnapshotAndSerialize(ref remoteEP2);
		DoConnect(remoteEP2, socketAddress);
	}

	private void DoConnect(EndPoint endPointSnapshot, SocketAddress socketAddress)
	{
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "Connect", endPointSnapshot);
		}
		if (UnsafeNclNativeMethods.OSSOCK.WSAConnect(m_Handle.DangerousGetHandle(), socketAddress.m_Buffer, socketAddress.m_Size, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero) != SocketError.Success)
		{
			SocketException ex = new SocketException(endPointSnapshot);
			UpdateStatusAfterSocketError(ex);
			if (s_LoggingEnabled)
			{
				Logging.Exception(Logging.Sockets, this, "Connect", ex);
			}
			throw ex;
		}
		if (m_RightEndPoint == null)
		{
			m_RightEndPoint = endPointSnapshot;
		}
		SetToConnected();
		if (s_LoggingEnabled)
		{
			Logging.PrintInfo(Logging.Sockets, this, SR.GetString("net_log_socket_connected", LocalEndPoint, RemoteEndPoint));
			Logging.Exit(Logging.Sockets, this, "Connect", "");
		}
	}

	protected unsafe virtual void Dispose(bool disposing)
	{
		if (!disposing)
		{
			return;
		}
		try
		{
			if (s_LoggingEnabled)
			{
				Logging.Enter(Logging.Sockets, this, "Dispose", null);
			}
		}
		catch (Exception exception)
		{
			if (NclUtilities.IsFatal(exception))
			{
				throw;
			}
		}
		int num;
		while ((num = Interlocked.CompareExchange(ref m_IntCleanedUp, 1, 0)) == 2)
		{
			Thread.SpinWait(1);
		}
		if (num == 1)
		{
			try
			{
				if (s_LoggingEnabled)
				{
					Logging.Exit(Logging.Sockets, this, "Dispose", null);
				}
				return;
			}
			catch (Exception exception2)
			{
				if (NclUtilities.IsFatal(exception2))
				{
					throw;
				}
				return;
			}
		}
		SetToDisconnected();
		AsyncEventBits asyncEventBits = AsyncEventBits.FdNone;
		if (m_BlockEventBits != AsyncEventBits.FdNone)
		{
			UnsetAsyncEventSelect();
			if (m_BlockEventBits == AsyncEventBits.FdConnect)
			{
				if (m_AcceptQueueOrConnectResult is LazyAsyncResult { InternalPeekCompleted: false })
				{
					asyncEventBits = AsyncEventBits.FdConnect;
				}
			}
			else if (m_BlockEventBits == AsyncEventBits.FdAccept && m_AcceptQueueOrConnectResult is Queue { Count: not 0 })
			{
				asyncEventBits = AsyncEventBits.FdAccept;
			}
		}
		try
		{
			int optionValue = m_CloseTimeout;
			if (optionValue == 0)
			{
				m_Handle.Dispose();
			}
			else
			{
				if (!willBlock || !willBlockInternal)
				{
					int argp = 0;
					SocketError socketError = UnsafeNclNativeMethods.OSSOCK.ioctlsocket(m_Handle, -2147195266, ref argp);
				}
				if (optionValue < 0)
				{
					m_Handle.CloseAsIs();
				}
				else
				{
					SocketError socketError = UnsafeNclNativeMethods.OSSOCK.shutdown(m_Handle, 1);
					if (UnsafeNclNativeMethods.OSSOCK.setsockopt(m_Handle, SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout, ref optionValue, 4) != SocketError.Success)
					{
						m_Handle.Dispose();
					}
					else if (UnsafeNclNativeMethods.OSSOCK.recv(m_Handle.DangerousGetHandle(), null, 0, SocketFlags.None) != 0)
					{
						m_Handle.Dispose();
					}
					else
					{
						int argp2 = 0;
						if (UnsafeNclNativeMethods.OSSOCK.ioctlsocket(m_Handle, 1074030207, ref argp2) != SocketError.Success || argp2 != 0)
						{
							m_Handle.Dispose();
						}
						else
						{
							m_Handle.CloseAsIs();
						}
					}
				}
			}
		}
		catch (ObjectDisposedException)
		{
		}
		if (m_Caches != null)
		{
			OverlappedCache.InterlockedFree(ref m_Caches.SendOverlappedCache);
			OverlappedCache.InterlockedFree(ref m_Caches.ReceiveOverlappedCache);
		}
		switch (asyncEventBits)
		{
		case AsyncEventBits.FdConnect:
			ThreadPool.UnsafeQueueUserWorkItem(((LazyAsyncResult)m_AcceptQueueOrConnectResult).InvokeCallback, new SocketException(SocketError.OperationAborted));
			break;
		case AsyncEventBits.FdAccept:
			ThreadPool.UnsafeQueueUserWorkItem(CompleteAcceptResults, null);
			break;
		}
		if (m_AsyncEvent != null)
		{
			m_AsyncEvent.Close();
		}
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	~Socket()
	{
		Dispose(disposing: false);
	}

	internal void InternalShutdown(SocketShutdown how)
	{
		if (CleanedUp || m_Handle.IsInvalid)
		{
			return;
		}
		try
		{
			UnsafeNclNativeMethods.OSSOCK.shutdown(m_Handle, (int)how);
		}
		catch (ObjectDisposedException)
		{
		}
	}

	internal void SetReceivingPacketInformation()
	{
		if (!m_ReceivingPacketInformation)
		{
			IPAddress iPAddress = ((m_RightEndPoint is IPEndPoint iPEndPoint) ? iPEndPoint.Address : null);
			if (addressFamily == AddressFamily.InterNetwork || (iPAddress != null && IsDualMode && (iPAddress.IsIPv4MappedToIPv6 || iPAddress.Equals(IPAddress.IPv6Any))))
			{
				SetSocketOption(SocketOptionLevel.IP, SocketOptionName.PacketInformation, optionValue: true);
			}
			if (addressFamily == AddressFamily.InterNetworkV6 && (iPAddress == null || !iPAddress.IsIPv4MappedToIPv6))
			{
				SetSocketOption(SocketOptionLevel.IPv6, SocketOptionName.PacketInformation, optionValue: true);
			}
			m_ReceivingPacketInformation = true;
		}
	}

	internal void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue, bool silent)
	{
		if (silent && (CleanedUp || m_Handle.IsInvalid))
		{
			return;
		}
		SocketError socketError = SocketError.Success;
		try
		{
			socketError = UnsafeNclNativeMethods.OSSOCK.setsockopt(m_Handle, optionLevel, optionName, ref optionValue, 4);
		}
		catch
		{
			if (silent && m_Handle.IsInvalid)
			{
				return;
			}
			throw;
		}
		if (optionName == SocketOptionName.PacketInformation && optionValue == 0 && socketError == SocketError.Success)
		{
			m_ReceivingPacketInformation = false;
		}
		if (silent || socketError != SocketError.SocketError)
		{
			return;
		}
		SocketException ex = new SocketException();
		UpdateStatusAfterSocketError(ex);
		if (s_LoggingEnabled)
		{
			Logging.Exception(Logging.Sockets, this, "SetSocketOption", ex);
		}
		throw ex;
	}

	private void setMulticastOption(SocketOptionName optionName, MulticastOption MR)
	{
		IPMulticastRequest mreq = new IPMulticastRequest
		{
			MulticastAddress = (int)MR.Group.m_Address
		};
		if (MR.LocalAddress != null)
		{
			mreq.InterfaceAddress = (int)MR.LocalAddress.m_Address;
		}
		else
		{
			int interfaceAddress = IPAddress.HostToNetworkOrder(MR.InterfaceIndex);
			mreq.InterfaceAddress = interfaceAddress;
		}
		SocketError socketError = UnsafeNclNativeMethods.OSSOCK.setsockopt(m_Handle, SocketOptionLevel.IP, optionName, ref mreq, IPMulticastRequest.Size);
		if (socketError == SocketError.SocketError)
		{
			SocketException ex = new SocketException();
			UpdateStatusAfterSocketError(ex);
			if (s_LoggingEnabled)
			{
				Logging.Exception(Logging.Sockets, this, "setMulticastOption", ex);
			}
			throw ex;
		}
	}

	private void setIPv6MulticastOption(SocketOptionName optionName, IPv6MulticastOption MR)
	{
		IPv6MulticastRequest mreq = new IPv6MulticastRequest
		{
			MulticastAddress = MR.Group.GetAddressBytes(),
			InterfaceIndex = (int)MR.InterfaceIndex
		};
		SocketError socketError = UnsafeNclNativeMethods.OSSOCK.setsockopt(m_Handle, SocketOptionLevel.IPv6, optionName, ref mreq, IPv6MulticastRequest.Size);
		if (socketError == SocketError.SocketError)
		{
			SocketException ex = new SocketException();
			UpdateStatusAfterSocketError(ex);
			if (s_LoggingEnabled)
			{
				Logging.Exception(Logging.Sockets, this, "setIPv6MulticastOption", ex);
			}
			throw ex;
		}
	}

	private void setLingerOption(LingerOption lref)
	{
		Linger linger = new Linger
		{
			OnOff = (ushort)(lref.Enabled ? 1 : 0),
			Time = (ushort)lref.LingerTime
		};
		SocketError socketError = UnsafeNclNativeMethods.OSSOCK.setsockopt(m_Handle, SocketOptionLevel.Socket, SocketOptionName.Linger, ref linger, 4);
		if (socketError == SocketError.SocketError)
		{
			SocketException ex = new SocketException();
			UpdateStatusAfterSocketError(ex);
			if (s_LoggingEnabled)
			{
				Logging.Exception(Logging.Sockets, this, "setLingerOption", ex);
			}
			throw ex;
		}
	}

	private LingerOption getLingerOpt()
	{
		Linger optionValue = default(Linger);
		int optionLength = 4;
		SocketError socketError = UnsafeNclNativeMethods.OSSOCK.getsockopt(m_Handle, SocketOptionLevel.Socket, SocketOptionName.Linger, out optionValue, ref optionLength);
		if (socketError == SocketError.SocketError)
		{
			SocketException ex = new SocketException();
			UpdateStatusAfterSocketError(ex);
			if (s_LoggingEnabled)
			{
				Logging.Exception(Logging.Sockets, this, "getLingerOpt", ex);
			}
			throw ex;
		}
		return new LingerOption(optionValue.OnOff != 0, optionValue.Time);
	}

	private MulticastOption getMulticastOpt(SocketOptionName optionName)
	{
		IPMulticastRequest optionValue = default(IPMulticastRequest);
		int optionLength = IPMulticastRequest.Size;
		SocketError socketError = UnsafeNclNativeMethods.OSSOCK.getsockopt(m_Handle, SocketOptionLevel.IP, optionName, out optionValue, ref optionLength);
		if (socketError == SocketError.SocketError)
		{
			SocketException ex = new SocketException();
			UpdateStatusAfterSocketError(ex);
			if (s_LoggingEnabled)
			{
				Logging.Exception(Logging.Sockets, this, "getMulticastOpt", ex);
			}
			throw ex;
		}
		IPAddress iPAddress = new IPAddress(optionValue.MulticastAddress);
		IPAddress mcint = new IPAddress(optionValue.InterfaceAddress);
		return new MulticastOption(iPAddress, mcint);
	}

	private IPv6MulticastOption getIPv6MulticastOpt(SocketOptionName optionName)
	{
		IPv6MulticastRequest optionValue = default(IPv6MulticastRequest);
		int optionLength = IPv6MulticastRequest.Size;
		SocketError socketError = UnsafeNclNativeMethods.OSSOCK.getsockopt(m_Handle, SocketOptionLevel.IP, optionName, out optionValue, ref optionLength);
		if (socketError == SocketError.SocketError)
		{
			SocketException ex = new SocketException();
			UpdateStatusAfterSocketError(ex);
			if (s_LoggingEnabled)
			{
				Logging.Exception(Logging.Sockets, this, "getIPv6MulticastOpt", ex);
			}
			throw ex;
		}
		return new IPv6MulticastOption(new IPAddress(optionValue.MulticastAddress), optionValue.InterfaceIndex);
	}

	private SocketError InternalSetBlocking(bool desired, out bool current)
	{
		if (CleanedUp)
		{
			current = willBlock;
			return SocketError.Success;
		}
		int argp = ((!desired) ? (-1) : 0);
		SocketError socketError;
		try
		{
			socketError = UnsafeNclNativeMethods.OSSOCK.ioctlsocket(m_Handle, -2147195266, ref argp);
			if (socketError == SocketError.SocketError)
			{
				socketError = (SocketError)Marshal.GetLastWin32Error();
			}
		}
		catch (ObjectDisposedException)
		{
			socketError = SocketError.NotSocket;
		}
		if (socketError == SocketError.Success)
		{
			willBlockInternal = argp == 0;
		}
		current = willBlockInternal;
		return socketError;
	}

	internal void InternalSetBlocking(bool desired)
	{
		InternalSetBlocking(desired, out var _);
	}

	private static IntPtr[] SocketListToFileDescriptorSet(IList socketList)
	{
		if (socketList == null || socketList.Count == 0)
		{
			return null;
		}
		IntPtr[] array = new IntPtr[socketList.Count + 1];
		array[0] = (IntPtr)socketList.Count;
		for (int i = 0; i < socketList.Count; i++)
		{
			if (!(socketList[i] is Socket))
			{
				throw new ArgumentException(SR.GetString("net_sockets_select", socketList[i].GetType().FullName, typeof(Socket).FullName), "socketList");
			}
			array[i + 1] = ((Socket)socketList[i]).m_Handle.DangerousGetHandle();
		}
		return array;
	}

	private static void SelectFileDescriptor(IList socketList, IntPtr[] fileDescriptorSet)
	{
		if (socketList == null || socketList.Count == 0)
		{
			return;
		}
		if ((int)fileDescriptorSet[0] == 0)
		{
			socketList.Clear();
			return;
		}
		lock (socketList)
		{
			for (int i = 0; i < socketList.Count; i++)
			{
				Socket socket = socketList[i] as Socket;
				int j;
				for (j = 0; j < (int)fileDescriptorSet[0] && !(fileDescriptorSet[j + 1] == socket.m_Handle.DangerousGetHandle()); j++)
				{
				}
				if (j == (int)fileDescriptorSet[0])
				{
					socketList.RemoveAt(i--);
				}
			}
		}
	}

	private static void MicrosecondsToTimeValue(long microSeconds, ref TimeValue socketTime)
	{
		socketTime.Seconds = (int)(microSeconds / 1000000);
		socketTime.Microseconds = (int)(microSeconds % 1000000);
	}

	private IAsyncResult BeginConnectEx(EndPoint remoteEP, bool flowContext, AsyncCallback callback, object state)
	{
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "BeginConnectEx", "");
		}
		EndPoint remoteEP2 = remoteEP;
		SocketAddress socketAddress = (flowContext ? CheckCacheRemote(ref remoteEP2, isOverwrite: true) : SnapshotAndSerialize(ref remoteEP2));
		if (m_RightEndPoint == null)
		{
			if (remoteEP2.AddressFamily == AddressFamily.InterNetwork)
			{
				InternalBind(new IPEndPoint(IPAddress.Any, 0));
			}
			else
			{
				InternalBind(new IPEndPoint(IPAddress.IPv6Any, 0));
			}
		}
		ConnectOverlappedAsyncResult connectOverlappedAsyncResult = new ConnectOverlappedAsyncResult(this, remoteEP2, state, callback);
		if (flowContext)
		{
			connectOverlappedAsyncResult.StartPostingAsyncOp(lockCapture: false);
		}
		connectOverlappedAsyncResult.SetUnmanagedStructures(socketAddress.m_Buffer);
		EndPoint rightEndPoint = m_RightEndPoint;
		if (m_RightEndPoint == null)
		{
			m_RightEndPoint = remoteEP2;
		}
		SocketError socketError = SocketError.Success;
		try
		{
			if (!ConnectEx(m_Handle, Marshal.UnsafeAddrOfPinnedArrayElement((Array)socketAddress.m_Buffer, 0), socketAddress.m_Size, IntPtr.Zero, 0, out var _, connectOverlappedAsyncResult.OverlappedHandle))
			{
				socketError = (SocketError)Marshal.GetLastWin32Error();
			}
		}
		catch
		{
			connectOverlappedAsyncResult.InternalCleanup();
			m_RightEndPoint = rightEndPoint;
			throw;
		}
		if (socketError == SocketError.Success)
		{
			SetToConnected();
		}
		socketError = connectOverlappedAsyncResult.CheckAsyncCallOverlappedResult(socketError);
		if (socketError != SocketError.Success)
		{
			m_RightEndPoint = rightEndPoint;
			SocketException ex = new SocketException(socketError);
			UpdateStatusAfterSocketError(ex);
			if (s_LoggingEnabled)
			{
				Logging.Exception(Logging.Sockets, this, "BeginConnectEx", ex);
			}
			throw ex;
		}
		connectOverlappedAsyncResult.FinishPostingAsyncOp(ref Caches.ConnectClosureCache);
		if (s_LoggingEnabled)
		{
			Logging.Exit(Logging.Sockets, this, "BeginConnectEx", connectOverlappedAsyncResult);
		}
		return connectOverlappedAsyncResult;
	}

	internal void MultipleSend(BufferOffsetSize[] buffers, SocketFlags socketFlags)
	{
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "MultipleSend", "");
		}
		if (CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		WSABuffer[] array = new WSABuffer[buffers.Length];
		GCHandle[] array2 = null;
		SocketError socketError;
		try
		{
			array2 = new GCHandle[buffers.Length];
			for (int i = 0; i < buffers.Length; i++)
			{
				array2[i] = GCHandle.Alloc(buffers[i].Buffer, GCHandleType.Pinned);
				array[i].Length = buffers[i].Size;
				array[i].Pointer = Marshal.UnsafeAddrOfPinnedArrayElement((Array)buffers[i].Buffer, buffers[i].Offset);
			}
			socketError = UnsafeNclNativeMethods.OSSOCK.WSASend_Blocking(m_Handle.DangerousGetHandle(), array, array.Length, out var _, socketFlags, SafeNativeOverlapped.Zero, IntPtr.Zero);
		}
		finally
		{
			if (array2 != null)
			{
				for (int j = 0; j < array2.Length; j++)
				{
					if (array2[j].IsAllocated)
					{
						array2[j].Free();
					}
				}
			}
		}
		if (socketError != SocketError.Success)
		{
			SocketException ex = new SocketException();
			UpdateStatusAfterSocketError(ex);
			if (s_LoggingEnabled)
			{
				Logging.Exception(Logging.Sockets, this, "MultipleSend", ex);
			}
			throw ex;
		}
		if (s_LoggingEnabled)
		{
			Logging.Exit(Logging.Sockets, this, "MultipleSend", "");
		}
	}

	private static void DnsCallback(IAsyncResult result)
	{
		if (!result.CompletedSynchronously)
		{
			bool flag = false;
			MultipleAddressConnectAsyncResult multipleAddressConnectAsyncResult = (MultipleAddressConnectAsyncResult)result.AsyncState;
			try
			{
				flag = DoDnsCallback(result, multipleAddressConnectAsyncResult);
			}
			catch (Exception result2)
			{
				multipleAddressConnectAsyncResult.InvokeCallback(result2);
			}
			if (flag)
			{
				multipleAddressConnectAsyncResult.InvokeCallback();
			}
		}
	}

	private static bool DoDnsCallback(IAsyncResult result, MultipleAddressConnectAsyncResult context)
	{
		IPAddress[] addresses = Dns.EndGetHostAddresses(result);
		context.addresses = addresses;
		return DoMultipleAddressConnectCallback(PostOneBeginConnect(context), context);
	}

	private static object PostOneBeginConnect(MultipleAddressConnectAsyncResult context)
	{
		IPAddress iPAddress = context.addresses[context.index];
		if (!context.socket.CanTryAddressFamily(iPAddress.AddressFamily))
		{
			if (context.lastException == null)
			{
				return new ArgumentException(SR.GetString("net_invalidAddressList"), "context");
			}
			return context.lastException;
		}
		try
		{
			EndPoint remoteEP = new IPEndPoint(iPAddress, context.port);
			context.socket.CheckCacheRemote(ref remoteEP, isOverwrite: true);
			IAsyncResult asyncResult = context.socket.UnsafeBeginConnect(remoteEP, MultipleAddressConnectCallback, context);
			if (asyncResult.CompletedSynchronously)
			{
				return asyncResult;
			}
		}
		catch (Exception ex)
		{
			if (ex is OutOfMemoryException || ex is StackOverflowException || ex is ThreadAbortException)
			{
				throw;
			}
			return ex;
		}
		return null;
	}

	private static void MultipleAddressConnectCallback(IAsyncResult result)
	{
		if (!result.CompletedSynchronously)
		{
			bool flag = false;
			MultipleAddressConnectAsyncResult multipleAddressConnectAsyncResult = (MultipleAddressConnectAsyncResult)result.AsyncState;
			try
			{
				flag = DoMultipleAddressConnectCallback(result, multipleAddressConnectAsyncResult);
			}
			catch (Exception result2)
			{
				multipleAddressConnectAsyncResult.InvokeCallback(result2);
			}
			if (flag)
			{
				multipleAddressConnectAsyncResult.InvokeCallback();
			}
		}
	}

	private static bool DoMultipleAddressConnectCallback(object result, MultipleAddressConnectAsyncResult context)
	{
		while (result != null)
		{
			Exception ex = result as Exception;
			if (ex == null)
			{
				try
				{
					context.socket.InternalEndConnect((IAsyncResult)result);
				}
				catch (Exception ex2)
				{
					ex = ex2;
				}
			}
			if (ex == null)
			{
				return true;
			}
			if (++context.index >= context.addresses.Length)
			{
				throw ex;
			}
			context.lastException = ex;
			result = PostOneBeginConnect(context);
		}
		return false;
	}

	internal IAsyncResult BeginMultipleSend(BufferOffsetSize[] buffers, SocketFlags socketFlags, AsyncCallback callback, object state)
	{
		OverlappedAsyncResult overlappedAsyncResult = new OverlappedAsyncResult(this, state, callback);
		overlappedAsyncResult.StartPostingAsyncOp(lockCapture: false);
		DoBeginMultipleSend(buffers, socketFlags, overlappedAsyncResult);
		overlappedAsyncResult.FinishPostingAsyncOp(ref Caches.SendClosureCache);
		return overlappedAsyncResult;
	}

	internal IAsyncResult UnsafeBeginMultipleSend(BufferOffsetSize[] buffers, SocketFlags socketFlags, AsyncCallback callback, object state)
	{
		OverlappedAsyncResult overlappedAsyncResult = new OverlappedAsyncResult(this, state, callback);
		DoBeginMultipleSend(buffers, socketFlags, overlappedAsyncResult);
		return overlappedAsyncResult;
	}

	private void DoBeginMultipleSend(BufferOffsetSize[] buffers, SocketFlags socketFlags, OverlappedAsyncResult asyncResult)
	{
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "BeginMultipleSend", "");
		}
		if (CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		SocketError socketError = SocketError.SocketError;
		try
		{
			asyncResult.SetUnmanagedStructures(buffers, ref Caches.SendOverlappedCache);
			socketError = UnsafeNclNativeMethods.OSSOCK.WSASend(m_Handle, asyncResult.m_WSABuffers, asyncResult.m_WSABuffers.Length, out var _, socketFlags, asyncResult.OverlappedHandle, IntPtr.Zero);
			if (socketError != SocketError.Success)
			{
				socketError = (SocketError)Marshal.GetLastWin32Error();
			}
		}
		finally
		{
			socketError = asyncResult.CheckAsyncCallOverlappedResult(socketError);
		}
		if (socketError != SocketError.Success)
		{
			asyncResult.ExtractCache(ref Caches.SendOverlappedCache);
			SocketException ex = new SocketException(socketError);
			UpdateStatusAfterSocketError(ex);
			if (s_LoggingEnabled)
			{
				Logging.Exception(Logging.Sockets, this, "BeginMultipleSend", ex);
			}
			throw ex;
		}
		if (s_LoggingEnabled)
		{
			Logging.Exit(Logging.Sockets, this, "BeginMultipleSend", asyncResult);
		}
	}

	internal int EndMultipleSend(IAsyncResult asyncResult)
	{
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "EndMultipleSend", asyncResult);
		}
		OverlappedAsyncResult overlappedAsyncResult = asyncResult as OverlappedAsyncResult;
		int num = (int)overlappedAsyncResult.InternalWaitForCompletion();
		overlappedAsyncResult.EndCalled = true;
		overlappedAsyncResult.ExtractCache(ref Caches.SendOverlappedCache);
		if (s_PerfCountersEnabled && num > 0)
		{
			NetworkingPerfCounters.Instance.Increment(NetworkingPerfCounterName.SocketBytesSent, num);
			if (Transport == TransportType.Udp)
			{
				NetworkingPerfCounters.Instance.Increment(NetworkingPerfCounterName.SocketDatagramsSent);
			}
		}
		if (overlappedAsyncResult.ErrorCode != 0)
		{
			SocketException ex = new SocketException(overlappedAsyncResult.ErrorCode);
			if (s_LoggingEnabled)
			{
				Logging.Exception(Logging.Sockets, this, "EndMultipleSend", ex);
			}
			throw ex;
		}
		if (s_LoggingEnabled)
		{
			Logging.Exit(Logging.Sockets, this, "EndMultipleSend", num);
		}
		return num;
	}

	private Socket CreateAcceptSocket(SafeCloseSocket fd, EndPoint remoteEP, bool needCancelSelect)
	{
		Socket socket = new Socket(fd);
		return UpdateAcceptSocket(socket, remoteEP, needCancelSelect);
	}

	internal Socket UpdateAcceptSocket(Socket socket, EndPoint remoteEP, bool needCancelSelect)
	{
		socket.addressFamily = addressFamily;
		socket.socketType = socketType;
		socket.protocolType = protocolType;
		socket.m_RightEndPoint = m_RightEndPoint;
		socket.m_RemoteEndPoint = remoteEP;
		socket.SetToConnected();
		socket.willBlock = willBlock;
		if (needCancelSelect)
		{
			socket.UnsetAsyncEventSelect();
		}
		else
		{
			socket.InternalSetBlocking(willBlock);
		}
		return socket;
	}

	internal void SetToConnected()
	{
		if (!m_IsConnected)
		{
			m_IsConnected = true;
			m_IsDisconnected = false;
			if (s_PerfCountersEnabled)
			{
				NetworkingPerfCounters.Instance.Increment(NetworkingPerfCounterName.SocketConnectionsEstablished);
			}
		}
	}

	internal void SetToDisconnected()
	{
		if (m_IsConnected)
		{
			m_IsConnected = false;
			m_IsDisconnected = true;
			if (!CleanedUp)
			{
				UnsetAsyncEventSelect();
			}
		}
	}

	internal void UpdateStatusAfterSocketError(SocketException socketException)
	{
		UpdateStatusAfterSocketError((SocketError)socketException.NativeErrorCode);
	}

	internal void UpdateStatusAfterSocketError(SocketError errorCode)
	{
		if (s_LoggingEnabled)
		{
			Logging.PrintError(Logging.Sockets, this, "UpdateStatusAfterSocketError", errorCode.ToString());
		}
		if (m_IsConnected && (m_Handle.IsInvalid || (errorCode != SocketError.WouldBlock && errorCode != SocketError.IOPending && errorCode != SocketError.NoBufferSpaceAvailable && errorCode != SocketError.TimedOut)))
		{
			SetToDisconnected();
		}
	}

	private void UnsetAsyncEventSelect()
	{
		RegisteredWaitHandle registeredWait = m_RegisteredWait;
		if (registeredWait != null)
		{
			m_RegisteredWait = null;
			registeredWait.Unregister(null);
		}
		SocketError socketError = SocketError.NotSocket;
		try
		{
			socketError = UnsafeNclNativeMethods.OSSOCK.WSAEventSelect(m_Handle, IntPtr.Zero, AsyncEventBits.FdNone);
		}
		catch (Exception exception)
		{
			if (NclUtilities.IsFatal(exception))
			{
				throw;
			}
		}
		if (m_AsyncEvent != null)
		{
			try
			{
				m_AsyncEvent.Reset();
			}
			catch (ObjectDisposedException)
			{
			}
		}
		if (socketError == SocketError.SocketError)
		{
			UpdateStatusAfterSocketError(socketError);
		}
		InternalSetBlocking(willBlock);
	}

	private bool SetAsyncEventSelect(AsyncEventBits blockEventBits)
	{
		if (m_RegisteredWait != null)
		{
			return false;
		}
		if (m_AsyncEvent == null)
		{
			Interlocked.CompareExchange(ref m_AsyncEvent, new ManualResetEvent(initialState: false), null);
			if (s_RegisteredWaitCallback == null)
			{
				s_RegisteredWaitCallback = RegisteredWaitCallback;
			}
		}
		if (Interlocked.CompareExchange(ref m_IntCleanedUp, 2, 0) != 0)
		{
			return false;
		}
		try
		{
			m_BlockEventBits = blockEventBits;
			m_RegisteredWait = ThreadPool.UnsafeRegisterWaitForSingleObject(m_AsyncEvent, s_RegisteredWaitCallback, this, -1, executeOnlyOnce: true);
		}
		finally
		{
			Interlocked.Exchange(ref m_IntCleanedUp, 0);
		}
		SocketError socketError = SocketError.NotSocket;
		try
		{
			socketError = UnsafeNclNativeMethods.OSSOCK.WSAEventSelect(m_Handle, m_AsyncEvent.SafeWaitHandle, blockEventBits);
		}
		catch (Exception exception)
		{
			if (NclUtilities.IsFatal(exception))
			{
				throw;
			}
		}
		if (socketError == SocketError.SocketError)
		{
			UpdateStatusAfterSocketError(socketError);
		}
		willBlockInternal = false;
		return socketError == SocketError.Success;
	}

	private static void RegisteredWaitCallback(object state, bool timedOut)
	{
		Socket socket = (Socket)state;
		if (Interlocked.Exchange(ref socket.m_RegisteredWait, null) != null)
		{
			switch (socket.m_BlockEventBits)
			{
			case AsyncEventBits.FdConnect:
				socket.ConnectCallback();
				break;
			case AsyncEventBits.FdAccept:
				socket.AcceptCallback(null);
				break;
			}
		}
	}

	private void ValidateBlockingMode()
	{
		if (willBlock && !willBlockInternal)
		{
			throw new InvalidOperationException(SR.GetString("net_invasync"));
		}
	}

	[SecurityPermission(SecurityAction.Assert, Flags = SecurityPermissionFlag.UnmanagedCode)]
	internal void BindToCompletionPort()
	{
		if (m_BoundToThreadPool || UseOverlappedIO)
		{
			return;
		}
		lock (this)
		{
			if (m_BoundToThreadPool)
			{
				return;
			}
			try
			{
				ThreadPool.BindHandle(m_Handle);
				m_BoundToThreadPool = true;
			}
			catch (Exception exception)
			{
				if (NclUtilities.IsFatal(exception))
				{
					throw;
				}
				Close(0);
				throw;
			}
		}
	}

	public bool AcceptAsync(SocketAsyncEventArgs e)
	{
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "AcceptAsync", "");
		}
		if (CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		if (e.m_BufferList != null)
		{
			throw new ArgumentException(SR.GetString("net_multibuffernotsupported"), "BufferList");
		}
		if (m_RightEndPoint == null)
		{
			throw new InvalidOperationException(SR.GetString("net_sockets_mustbind"));
		}
		if (!isListening)
		{
			throw new InvalidOperationException(SR.GetString("net_sockets_mustlisten"));
		}
		if (e.AcceptSocket == null)
		{
			e.AcceptSocket = new Socket(addressFamily, socketType, protocolType);
		}
		else if (e.AcceptSocket.m_RightEndPoint != null && !e.AcceptSocket.m_IsDisconnected)
		{
			throw new InvalidOperationException(SR.GetString("net_sockets_namedmustnotbebound", "AcceptSocket"));
		}
		e.StartOperationCommon(this);
		e.StartOperationAccept();
		BindToCompletionPort();
		SocketError socketError = SocketError.Success;
		int bytesReceived;
		try
		{
			if (!AcceptEx(m_Handle, e.AcceptSocket.m_Handle, (e.m_PtrSingleBuffer != IntPtr.Zero) ? e.m_PtrSingleBuffer : e.m_PtrAcceptBuffer, (e.m_PtrSingleBuffer != IntPtr.Zero) ? (e.Count - e.m_AcceptAddressBufferCount) : 0, e.m_AcceptAddressBufferCount / 2, e.m_AcceptAddressBufferCount / 2, out bytesReceived, e.m_PtrNativeOverlapped))
			{
				socketError = (SocketError)Marshal.GetLastWin32Error();
			}
		}
		catch (Exception ex)
		{
			e.Complete();
			throw ex;
		}
		bool flag;
		if (socketError != SocketError.Success && socketError != SocketError.IOPending)
		{
			e.FinishOperationSyncFailure(socketError, bytesReceived, SocketFlags.None);
			flag = false;
		}
		else
		{
			flag = true;
		}
		if (s_LoggingEnabled)
		{
			Logging.Exit(Logging.Sockets, this, "AcceptAsync", flag);
		}
		return flag;
	}

	public bool ConnectAsync(SocketAsyncEventArgs e)
	{
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "ConnectAsync", "");
		}
		if (CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		if (e.m_BufferList != null)
		{
			throw new ArgumentException(SR.GetString("net_multibuffernotsupported"), "BufferList");
		}
		if (e.RemoteEndPoint == null)
		{
			throw new ArgumentNullException("remoteEP");
		}
		if (isListening)
		{
			throw new InvalidOperationException(SR.GetString("net_sockets_mustnotlisten"));
		}
		EndPoint remoteEP = e.RemoteEndPoint;
		bool flag;
		if (remoteEP is DnsEndPoint dnsEndPoint)
		{
			if (s_LoggingEnabled)
			{
				Logging.PrintInfo(Logging.Sockets, "Socket#" + ValidationHelper.HashString(this) + "::ConnectAsync " + SR.GetString("net_log_socket_connect_dnsendpoint"));
			}
			if (dnsEndPoint.AddressFamily != AddressFamily.Unspecified && !CanTryAddressFamily(dnsEndPoint.AddressFamily))
			{
				throw new NotSupportedException(SR.GetString("net_invalidversion"));
			}
			MultipleConnectAsync multipleConnectAsync = new SingleSocketMultipleConnectAsync(this, userSocket: true);
			e.StartOperationCommon(this);
			e.StartOperationWrapperConnect(multipleConnectAsync);
			flag = multipleConnectAsync.StartConnectAsync(e, dnsEndPoint);
		}
		else
		{
			if (!CanTryAddressFamily(e.RemoteEndPoint.AddressFamily))
			{
				throw new NotSupportedException(SR.GetString("net_invalidversion"));
			}
			e.m_SocketAddress = CheckCacheRemote(ref remoteEP, isOverwrite: false);
			if (m_RightEndPoint == null)
			{
				if (remoteEP.AddressFamily == AddressFamily.InterNetwork)
				{
					InternalBind(new IPEndPoint(IPAddress.Any, 0));
				}
				else
				{
					InternalBind(new IPEndPoint(IPAddress.IPv6Any, 0));
				}
			}
			EndPoint rightEndPoint = m_RightEndPoint;
			if (m_RightEndPoint == null)
			{
				m_RightEndPoint = remoteEP;
			}
			e.StartOperationCommon(this);
			e.StartOperationConnect();
			BindToCompletionPort();
			SocketError socketError = SocketError.Success;
			int bytesSent;
			try
			{
				if (!ConnectEx(m_Handle, e.m_PtrSocketAddressBuffer, e.m_SocketAddress.m_Size, e.m_PtrSingleBuffer, e.Count, out bytesSent, e.m_PtrNativeOverlapped))
				{
					socketError = (SocketError)Marshal.GetLastWin32Error();
				}
			}
			catch (Exception ex)
			{
				m_RightEndPoint = rightEndPoint;
				e.Complete();
				throw ex;
			}
			if (socketError != SocketError.Success && socketError != SocketError.IOPending)
			{
				e.FinishOperationSyncFailure(socketError, bytesSent, SocketFlags.None);
				flag = false;
			}
			else
			{
				flag = true;
			}
		}
		if (s_LoggingEnabled)
		{
			Logging.Exit(Logging.Sockets, this, "ConnectAsync", flag);
		}
		return flag;
	}

	public static bool ConnectAsync(SocketType socketType, ProtocolType protocolType, SocketAsyncEventArgs e)
	{
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, null, "ConnectAsync", "");
		}
		if (e.m_BufferList != null)
		{
			throw new ArgumentException(SR.GetString("net_multibuffernotsupported"), "BufferList");
		}
		if (e.RemoteEndPoint == null)
		{
			throw new ArgumentNullException("remoteEP");
		}
		EndPoint remoteEndPoint = e.RemoteEndPoint;
		bool flag;
		if (remoteEndPoint is DnsEndPoint dnsEndPoint)
		{
			Socket socket = null;
			MultipleConnectAsync multipleConnectAsync = null;
			if (dnsEndPoint.AddressFamily == AddressFamily.Unspecified)
			{
				multipleConnectAsync = new MultipleSocketMultipleConnectAsync(socketType, protocolType);
			}
			else
			{
				socket = new Socket(dnsEndPoint.AddressFamily, socketType, protocolType);
				multipleConnectAsync = new SingleSocketMultipleConnectAsync(socket, userSocket: false);
			}
			e.StartOperationCommon(socket);
			e.StartOperationWrapperConnect(multipleConnectAsync);
			flag = multipleConnectAsync.StartConnectAsync(e, dnsEndPoint);
		}
		else
		{
			Socket socket2 = new Socket(remoteEndPoint.AddressFamily, socketType, protocolType);
			flag = socket2.ConnectAsync(e);
		}
		if (s_LoggingEnabled)
		{
			Logging.Exit(Logging.Sockets, null, "ConnectAsync", flag);
		}
		return flag;
	}

	public static void CancelConnectAsync(SocketAsyncEventArgs e)
	{
		if (e == null)
		{
			throw new ArgumentNullException("e");
		}
		e.CancelConnectAsync();
	}

	public bool DisconnectAsync(SocketAsyncEventArgs e)
	{
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "DisconnectAsync", "");
		}
		if (CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		e.StartOperationCommon(this);
		e.StartOperationDisconnect();
		BindToCompletionPort();
		SocketError socketError = SocketError.Success;
		try
		{
			if (!DisconnectEx(m_Handle, e.m_PtrNativeOverlapped, e.DisconnectReuseSocket ? 2 : 0, 0))
			{
				socketError = (SocketError)Marshal.GetLastWin32Error();
			}
		}
		catch (Exception ex)
		{
			e.Complete();
			throw ex;
		}
		bool flag;
		if (socketError != SocketError.Success && socketError != SocketError.IOPending)
		{
			e.FinishOperationSyncFailure(socketError, 0, SocketFlags.None);
			flag = false;
		}
		else
		{
			flag = true;
		}
		if (s_LoggingEnabled)
		{
			Logging.Exit(Logging.Sockets, this, "DisconnectAsync", flag);
		}
		return flag;
	}

	public bool ReceiveAsync(SocketAsyncEventArgs e)
	{
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "ReceiveAsync", "");
		}
		if (CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		e.StartOperationCommon(this);
		e.StartOperationReceive();
		BindToCompletionPort();
		SocketFlags socketFlags = e.m_SocketFlags;
		SocketError socketError;
		int bytesTransferred;
		try
		{
			socketError = ((e.m_Buffer == null) ? UnsafeNclNativeMethods.OSSOCK.WSARecv(m_Handle, e.m_WSABufferArray, e.m_WSABufferArray.Length, out bytesTransferred, ref socketFlags, e.m_PtrNativeOverlapped, IntPtr.Zero) : UnsafeNclNativeMethods.OSSOCK.WSARecv(m_Handle, ref e.m_WSABuffer, 1, out bytesTransferred, ref socketFlags, e.m_PtrNativeOverlapped, IntPtr.Zero));
		}
		catch (Exception ex)
		{
			e.Complete();
			throw ex;
		}
		if (socketError != SocketError.Success)
		{
			socketError = (SocketError)Marshal.GetLastWin32Error();
		}
		bool flag;
		if (socketError != SocketError.Success && socketError != SocketError.IOPending)
		{
			e.FinishOperationSyncFailure(socketError, bytesTransferred, socketFlags);
			flag = false;
		}
		else
		{
			flag = true;
		}
		if (s_LoggingEnabled)
		{
			Logging.Exit(Logging.Sockets, this, "ReceiveAsync", flag);
		}
		return flag;
	}

	public bool ReceiveFromAsync(SocketAsyncEventArgs e)
	{
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "ReceiveFromAsync", "");
		}
		if (CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		if (e.RemoteEndPoint == null)
		{
			throw new ArgumentNullException("RemoteEndPoint");
		}
		if (!CanTryAddressFamily(e.RemoteEndPoint.AddressFamily))
		{
			throw new ArgumentException(SR.GetString("net_InvalidEndPointAddressFamily", e.RemoteEndPoint.AddressFamily, addressFamily), "RemoteEndPoint");
		}
		EndPoint remoteEP = e.RemoteEndPoint;
		e.m_SocketAddress = SnapshotAndSerialize(ref remoteEP);
		e.RemoteEndPoint = remoteEP;
		e.StartOperationCommon(this);
		e.StartOperationReceiveFrom();
		BindToCompletionPort();
		SocketFlags socketFlags = e.m_SocketFlags;
		SocketError socketError;
		int bytesTransferred;
		try
		{
			socketError = ((e.m_Buffer == null) ? UnsafeNclNativeMethods.OSSOCK.WSARecvFrom(m_Handle, e.m_WSABufferArray, e.m_WSABufferArray.Length, out bytesTransferred, ref socketFlags, e.m_PtrSocketAddressBuffer, e.m_PtrSocketAddressBufferSize, e.m_PtrNativeOverlapped, IntPtr.Zero) : UnsafeNclNativeMethods.OSSOCK.WSARecvFrom(m_Handle, ref e.m_WSABuffer, 1, out bytesTransferred, ref socketFlags, e.m_PtrSocketAddressBuffer, e.m_PtrSocketAddressBufferSize, e.m_PtrNativeOverlapped, IntPtr.Zero));
		}
		catch (Exception ex)
		{
			e.Complete();
			throw ex;
		}
		if (socketError != SocketError.Success)
		{
			socketError = (SocketError)Marshal.GetLastWin32Error();
		}
		bool flag;
		if (socketError != SocketError.Success && socketError != SocketError.IOPending)
		{
			e.FinishOperationSyncFailure(socketError, bytesTransferred, socketFlags);
			flag = false;
		}
		else
		{
			flag = true;
		}
		if (s_LoggingEnabled)
		{
			Logging.Exit(Logging.Sockets, this, "ReceiveFromAsync", flag);
		}
		return flag;
	}

	public bool ReceiveMessageFromAsync(SocketAsyncEventArgs e)
	{
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "ReceiveMessageFromAsync", "");
		}
		if (CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		if (e.RemoteEndPoint == null)
		{
			throw new ArgumentNullException("RemoteEndPoint");
		}
		if (!CanTryAddressFamily(e.RemoteEndPoint.AddressFamily))
		{
			throw new ArgumentException(SR.GetString("net_InvalidEndPointAddressFamily", e.RemoteEndPoint.AddressFamily, addressFamily), "RemoteEndPoint");
		}
		EndPoint remoteEP = e.RemoteEndPoint;
		e.m_SocketAddress = SnapshotAndSerialize(ref remoteEP);
		e.RemoteEndPoint = remoteEP;
		SetReceivingPacketInformation();
		e.StartOperationCommon(this);
		e.StartOperationReceiveMessageFrom();
		BindToCompletionPort();
		SocketError socketError;
		int bytesTransferred;
		try
		{
			socketError = WSARecvMsg(m_Handle, e.m_PtrWSAMessageBuffer, out bytesTransferred, e.m_PtrNativeOverlapped, IntPtr.Zero);
		}
		catch (Exception ex)
		{
			e.Complete();
			throw ex;
		}
		if (socketError != SocketError.Success)
		{
			socketError = (SocketError)Marshal.GetLastWin32Error();
		}
		bool flag;
		if (socketError != SocketError.Success && socketError != SocketError.IOPending)
		{
			e.FinishOperationSyncFailure(socketError, bytesTransferred, SocketFlags.None);
			flag = false;
		}
		else
		{
			flag = true;
		}
		if (s_LoggingEnabled)
		{
			Logging.Exit(Logging.Sockets, this, "ReceiveMessageFromAsync", flag);
		}
		return flag;
	}

	public bool SendAsync(SocketAsyncEventArgs e)
	{
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "SendAsync", "");
		}
		if (CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		e.StartOperationCommon(this);
		e.StartOperationSend();
		BindToCompletionPort();
		SocketError socketError;
		int bytesTransferred;
		try
		{
			socketError = ((e.m_Buffer == null) ? UnsafeNclNativeMethods.OSSOCK.WSASend(m_Handle, e.m_WSABufferArray, e.m_WSABufferArray.Length, out bytesTransferred, e.m_SocketFlags, e.m_PtrNativeOverlapped, IntPtr.Zero) : UnsafeNclNativeMethods.OSSOCK.WSASend(m_Handle, ref e.m_WSABuffer, 1, out bytesTransferred, e.m_SocketFlags, e.m_PtrNativeOverlapped, IntPtr.Zero));
		}
		catch (Exception ex)
		{
			e.Complete();
			throw ex;
		}
		if (socketError != SocketError.Success)
		{
			socketError = (SocketError)Marshal.GetLastWin32Error();
		}
		bool flag;
		if (socketError != SocketError.Success && socketError != SocketError.IOPending)
		{
			e.FinishOperationSyncFailure(socketError, bytesTransferred, SocketFlags.None);
			flag = false;
		}
		else
		{
			flag = true;
		}
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "SendAsync", flag);
		}
		return flag;
	}

	public bool SendPacketsAsync(SocketAsyncEventArgs e)
	{
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "SendPacketsAsync", "");
		}
		if (CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		if (!Connected)
		{
			throw new NotSupportedException(SR.GetString("net_notconnected"));
		}
		e.StartOperationCommon(this);
		e.StartOperationSendPackets();
		BindToCompletionPort();
		bool flag2;
		if (e.m_SendPacketsDescriptor.Length != 0)
		{
			bool flag;
			try
			{
				flag = TransmitPackets(m_Handle, e.m_PtrSendPacketsDescriptor, e.m_SendPacketsDescriptor.Length, e.m_SendPacketsSendSize, e.m_PtrNativeOverlapped, e.m_SendPacketsFlags);
			}
			catch (Exception)
			{
				e.Complete();
				throw;
			}
			SocketError socketError = ((!flag) ? ((SocketError)Marshal.GetLastWin32Error()) : SocketError.Success);
			if (socketError != SocketError.Success && socketError != SocketError.IOPending)
			{
				e.FinishOperationSyncFailure(socketError, 0, SocketFlags.None);
				flag2 = false;
			}
			else
			{
				flag2 = true;
			}
		}
		else
		{
			e.FinishOperationSuccess(SocketError.Success, 0, SocketFlags.None);
			flag2 = false;
		}
		if (s_LoggingEnabled)
		{
			Logging.Exit(Logging.Sockets, this, "SendPacketsAsync", flag2);
		}
		return flag2;
	}

	public bool SendToAsync(SocketAsyncEventArgs e)
	{
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.Sockets, this, "SendToAsync", "");
		}
		if (CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		if (e.RemoteEndPoint == null)
		{
			throw new ArgumentNullException("RemoteEndPoint");
		}
		EndPoint remoteEP = e.RemoteEndPoint;
		e.m_SocketAddress = CheckCacheRemote(ref remoteEP, isOverwrite: false);
		e.StartOperationCommon(this);
		e.StartOperationSendTo();
		BindToCompletionPort();
		SocketError socketError;
		int bytesTransferred;
		try
		{
			socketError = ((e.m_Buffer == null) ? UnsafeNclNativeMethods.OSSOCK.WSASendTo(m_Handle, e.m_WSABufferArray, e.m_WSABufferArray.Length, out bytesTransferred, e.m_SocketFlags, e.m_PtrSocketAddressBuffer, e.m_SocketAddress.m_Size, e.m_PtrNativeOverlapped, IntPtr.Zero) : UnsafeNclNativeMethods.OSSOCK.WSASendTo(m_Handle, ref e.m_WSABuffer, 1, out bytesTransferred, e.m_SocketFlags, e.m_PtrSocketAddressBuffer, e.m_SocketAddress.m_Size, e.m_PtrNativeOverlapped, IntPtr.Zero));
		}
		catch (Exception ex)
		{
			e.Complete();
			throw ex;
		}
		if (socketError != SocketError.Success)
		{
			socketError = (SocketError)Marshal.GetLastWin32Error();
		}
		bool flag;
		if (socketError != SocketError.Success && socketError != SocketError.IOPending)
		{
			e.FinishOperationSyncFailure(socketError, bytesTransferred, SocketFlags.None);
			flag = false;
		}
		else
		{
			flag = true;
		}
		if (s_LoggingEnabled)
		{
			Logging.Exit(Logging.Sockets, this, "SendToAsync", flag);
		}
		return flag;
	}

	internal Task<Socket> AcceptAsync(Socket acceptSocket)
	{
		TaskSocketAsyncEventArgs<Socket> e = Interlocked.Exchange(ref LazyInitializer.EnsureInitialized(ref _cachedTaskEventArgs).Accept, s_rentedSocketSentinel);
		if (e == s_rentedSocketSentinel)
		{
			return AcceptAsyncApm(acceptSocket);
		}
		if (e == null)
		{
			e = new TaskSocketAsyncEventArgs<Socket>();
			e.Completed += AcceptCompletedHandler;
		}
		e.AcceptSocket = acceptSocket;
		Task<Socket> result;
		if (AcceptAsync(e))
		{
			result = e.GetCompletionResponsibility(out var responsibleForReturningToPool).Task;
			if (responsibleForReturningToPool)
			{
				ReturnSocketAsyncEventArgs(e);
			}
		}
		else
		{
			result = ((e.SocketError == SocketError.Success) ? Task.FromResult(e.AcceptSocket) : Task.FromException<Socket>(GetException(e.SocketError)));
			ReturnSocketAsyncEventArgs(e);
		}
		return result;
	}

	private Task<Socket> AcceptAsyncApm(Socket acceptSocket)
	{
		TaskCompletionSource<Socket> taskCompletionSource = new TaskCompletionSource<Socket>(this);
		BeginAccept(acceptSocket, 0, delegate(IAsyncResult iar)
		{
			TaskCompletionSource<Socket> taskCompletionSource2 = (TaskCompletionSource<Socket>)iar.AsyncState;
			try
			{
				taskCompletionSource2.TrySetResult(((Socket)taskCompletionSource2.Task.AsyncState).EndAccept(iar));
			}
			catch (Exception exception)
			{
				taskCompletionSource2.TrySetException(exception);
			}
		}, taskCompletionSource);
		return taskCompletionSource.Task;
	}

	internal Task ConnectAsync(EndPoint remoteEP)
	{
		TaskCompletionSource<bool> taskCompletionSource = new TaskCompletionSource<bool>(this);
		BeginConnect(remoteEP, delegate(IAsyncResult iar)
		{
			TaskCompletionSource<bool> taskCompletionSource2 = (TaskCompletionSource<bool>)iar.AsyncState;
			try
			{
				((Socket)taskCompletionSource2.Task.AsyncState).EndConnect(iar);
				taskCompletionSource2.TrySetResult(result: true);
			}
			catch (Exception exception)
			{
				taskCompletionSource2.TrySetException(exception);
			}
		}, taskCompletionSource);
		return taskCompletionSource.Task;
	}

	internal Task ConnectAsync(IPAddress address, int port)
	{
		TaskCompletionSource<bool> taskCompletionSource = new TaskCompletionSource<bool>(this);
		BeginConnect(address, port, delegate(IAsyncResult iar)
		{
			TaskCompletionSource<bool> taskCompletionSource2 = (TaskCompletionSource<bool>)iar.AsyncState;
			try
			{
				((Socket)taskCompletionSource2.Task.AsyncState).EndConnect(iar);
				taskCompletionSource2.TrySetResult(result: true);
			}
			catch (Exception exception)
			{
				taskCompletionSource2.TrySetException(exception);
			}
		}, taskCompletionSource);
		return taskCompletionSource.Task;
	}

	internal Task ConnectAsync(IPAddress[] addresses, int port)
	{
		TaskCompletionSource<bool> taskCompletionSource = new TaskCompletionSource<bool>(this);
		BeginConnect(addresses, port, delegate(IAsyncResult iar)
		{
			TaskCompletionSource<bool> taskCompletionSource2 = (TaskCompletionSource<bool>)iar.AsyncState;
			try
			{
				((Socket)taskCompletionSource2.Task.AsyncState).EndConnect(iar);
				taskCompletionSource2.TrySetResult(result: true);
			}
			catch (Exception exception)
			{
				taskCompletionSource2.TrySetException(exception);
			}
		}, taskCompletionSource);
		return taskCompletionSource.Task;
	}

	internal Task ConnectAsync(string host, int port)
	{
		TaskCompletionSource<bool> taskCompletionSource = new TaskCompletionSource<bool>(this);
		BeginConnect(host, port, delegate(IAsyncResult iar)
		{
			TaskCompletionSource<bool> taskCompletionSource2 = (TaskCompletionSource<bool>)iar.AsyncState;
			try
			{
				((Socket)taskCompletionSource2.Task.AsyncState).EndConnect(iar);
				taskCompletionSource2.TrySetResult(result: true);
			}
			catch (Exception exception)
			{
				taskCompletionSource2.TrySetException(exception);
			}
		}, taskCompletionSource);
		return taskCompletionSource.Task;
	}

	internal Task<int> ReceiveAsync(ArraySegment<byte> buffer, SocketFlags socketFlags, bool fromNetworkStream)
	{
		ValidateBuffer(buffer);
		Int32TaskSocketAsyncEventArgs e = RentSocketAsyncEventArgs(isReceive: true);
		if (e != null)
		{
			ConfigureBuffer(e, buffer, socketFlags, fromNetworkStream);
			return GetTaskForSendReceive(ReceiveAsync(e), e, fromNetworkStream, isReceive: true);
		}
		return ReceiveAsyncApm(buffer, socketFlags);
	}

	private Task<int> ReceiveAsyncApm(ArraySegment<byte> buffer, SocketFlags socketFlags)
	{
		TaskCompletionSource<int> taskCompletionSource = new TaskCompletionSource<int>(this);
		BeginReceive(buffer.Array, buffer.Offset, buffer.Count, socketFlags, delegate(IAsyncResult iar)
		{
			TaskCompletionSource<int> taskCompletionSource2 = (TaskCompletionSource<int>)iar.AsyncState;
			try
			{
				taskCompletionSource2.TrySetResult(((Socket)taskCompletionSource2.Task.AsyncState).EndReceive(iar));
			}
			catch (Exception exception)
			{
				taskCompletionSource2.TrySetException(exception);
			}
		}, taskCompletionSource);
		return taskCompletionSource.Task;
	}

	internal Task<int> ReceiveAsync(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags)
	{
		ValidateBuffersList(buffers);
		Int32TaskSocketAsyncEventArgs e = RentSocketAsyncEventArgs(isReceive: true);
		if (e != null)
		{
			ConfigureBufferList(e, buffers, socketFlags);
			return GetTaskForSendReceive(ReceiveAsync(e), e, fromNetworkStream: false, isReceive: true);
		}
		return ReceiveAsyncApm(buffers, socketFlags);
	}

	private Task<int> ReceiveAsyncApm(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags)
	{
		TaskCompletionSource<int> taskCompletionSource = new TaskCompletionSource<int>(this);
		BeginReceive(buffers, socketFlags, delegate(IAsyncResult iar)
		{
			TaskCompletionSource<int> taskCompletionSource2 = (TaskCompletionSource<int>)iar.AsyncState;
			try
			{
				taskCompletionSource2.TrySetResult(((Socket)taskCompletionSource2.Task.AsyncState).EndReceive(iar));
			}
			catch (Exception exception)
			{
				taskCompletionSource2.TrySetException(exception);
			}
		}, taskCompletionSource);
		return taskCompletionSource.Task;
	}

	internal Task<SocketReceiveFromResult> ReceiveFromAsync(ArraySegment<byte> buffer, SocketFlags socketFlags, EndPoint remoteEndPoint)
	{
		StateTaskCompletionSource<EndPoint, SocketReceiveFromResult> stateTaskCompletionSource = new StateTaskCompletionSource<EndPoint, SocketReceiveFromResult>(this)
		{
			_field1 = remoteEndPoint
		};
		BeginReceiveFrom(buffer.Array, buffer.Offset, buffer.Count, socketFlags, ref stateTaskCompletionSource._field1, delegate(IAsyncResult iar)
		{
			StateTaskCompletionSource<EndPoint, SocketReceiveFromResult> stateTaskCompletionSource2 = (StateTaskCompletionSource<EndPoint, SocketReceiveFromResult>)iar.AsyncState;
			try
			{
				int receivedBytes = ((Socket)stateTaskCompletionSource2.Task.AsyncState).EndReceiveFrom(iar, ref stateTaskCompletionSource2._field1);
				stateTaskCompletionSource2.TrySetResult(new SocketReceiveFromResult
				{
					ReceivedBytes = receivedBytes,
					RemoteEndPoint = stateTaskCompletionSource2._field1
				});
			}
			catch (Exception exception)
			{
				stateTaskCompletionSource2.TrySetException(exception);
			}
		}, stateTaskCompletionSource);
		return stateTaskCompletionSource.Task;
	}

	internal Task<SocketReceiveMessageFromResult> ReceiveMessageFromAsync(ArraySegment<byte> buffer, SocketFlags socketFlags, EndPoint remoteEndPoint)
	{
		StateTaskCompletionSource<SocketFlags, EndPoint, SocketReceiveMessageFromResult> stateTaskCompletionSource = new StateTaskCompletionSource<SocketFlags, EndPoint, SocketReceiveMessageFromResult>(this)
		{
			_field1 = socketFlags,
			_field2 = remoteEndPoint
		};
		BeginReceiveMessageFrom(buffer.Array, buffer.Offset, buffer.Count, socketFlags, ref stateTaskCompletionSource._field2, delegate(IAsyncResult iar)
		{
			StateTaskCompletionSource<SocketFlags, EndPoint, SocketReceiveMessageFromResult> stateTaskCompletionSource2 = (StateTaskCompletionSource<SocketFlags, EndPoint, SocketReceiveMessageFromResult>)iar.AsyncState;
			try
			{
				IPPacketInformation ipPacketInformation;
				int receivedBytes = ((Socket)stateTaskCompletionSource2.Task.AsyncState).EndReceiveMessageFrom(iar, ref stateTaskCompletionSource2._field1, ref stateTaskCompletionSource2._field2, out ipPacketInformation);
				stateTaskCompletionSource2.TrySetResult(new SocketReceiveMessageFromResult
				{
					ReceivedBytes = receivedBytes,
					RemoteEndPoint = stateTaskCompletionSource2._field2,
					SocketFlags = stateTaskCompletionSource2._field1,
					PacketInformation = ipPacketInformation
				});
			}
			catch (Exception exception)
			{
				stateTaskCompletionSource2.TrySetException(exception);
			}
		}, stateTaskCompletionSource);
		return stateTaskCompletionSource.Task;
	}

	internal Task<int> SendAsync(ArraySegment<byte> buffer, SocketFlags socketFlags, bool fromNetworkStream)
	{
		ValidateBuffer(buffer);
		Int32TaskSocketAsyncEventArgs e = RentSocketAsyncEventArgs(isReceive: false);
		if (e != null)
		{
			ConfigureBuffer(e, buffer, socketFlags, fromNetworkStream);
			return GetTaskForSendReceive(SendAsync(e), e, fromNetworkStream, isReceive: false);
		}
		return SendAsyncApm(buffer, socketFlags);
	}

	private Task<int> SendAsyncApm(ArraySegment<byte> buffer, SocketFlags socketFlags)
	{
		TaskCompletionSource<int> taskCompletionSource = new TaskCompletionSource<int>(this);
		BeginSend(buffer.Array, buffer.Offset, buffer.Count, socketFlags, delegate(IAsyncResult iar)
		{
			TaskCompletionSource<int> taskCompletionSource2 = (TaskCompletionSource<int>)iar.AsyncState;
			try
			{
				taskCompletionSource2.TrySetResult(((Socket)taskCompletionSource2.Task.AsyncState).EndSend(iar));
			}
			catch (Exception exception)
			{
				taskCompletionSource2.TrySetException(exception);
			}
		}, taskCompletionSource);
		return taskCompletionSource.Task;
	}

	internal Task<int> SendAsync(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags)
	{
		ValidateBuffersList(buffers);
		Int32TaskSocketAsyncEventArgs e = RentSocketAsyncEventArgs(isReceive: false);
		if (e != null)
		{
			ConfigureBufferList(e, buffers, socketFlags);
			return GetTaskForSendReceive(SendAsync(e), e, fromNetworkStream: false, isReceive: false);
		}
		return SendAsyncApm(buffers, socketFlags);
	}

	private Task<int> SendAsyncApm(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags)
	{
		TaskCompletionSource<int> taskCompletionSource = new TaskCompletionSource<int>(this);
		BeginSend(buffers, socketFlags, delegate(IAsyncResult iar)
		{
			TaskCompletionSource<int> taskCompletionSource2 = (TaskCompletionSource<int>)iar.AsyncState;
			try
			{
				taskCompletionSource2.TrySetResult(((Socket)taskCompletionSource2.Task.AsyncState).EndSend(iar));
			}
			catch (Exception exception)
			{
				taskCompletionSource2.TrySetException(exception);
			}
		}, taskCompletionSource);
		return taskCompletionSource.Task;
	}

	internal Task<int> SendToAsync(ArraySegment<byte> buffer, SocketFlags socketFlags, EndPoint remoteEP)
	{
		TaskCompletionSource<int> taskCompletionSource = new TaskCompletionSource<int>(this);
		BeginSendTo(buffer.Array, buffer.Offset, buffer.Count, socketFlags, remoteEP, delegate(IAsyncResult iar)
		{
			TaskCompletionSource<int> taskCompletionSource2 = (TaskCompletionSource<int>)iar.AsyncState;
			try
			{
				taskCompletionSource2.TrySetResult(((Socket)taskCompletionSource2.Task.AsyncState).EndSendTo(iar));
			}
			catch (Exception exception)
			{
				taskCompletionSource2.TrySetException(exception);
			}
		}, taskCompletionSource);
		return taskCompletionSource.Task;
	}

	private static void ValidateBuffer(ArraySegment<byte> buffer)
	{
		if (buffer.Array == null)
		{
			throw new ArgumentNullException("Array");
		}
		if (buffer.Offset < 0 || buffer.Offset > buffer.Array.Length)
		{
			throw new ArgumentOutOfRangeException("Offset");
		}
		if (buffer.Count < 0 || buffer.Count > buffer.Array.Length - buffer.Offset)
		{
			throw new ArgumentOutOfRangeException("Count");
		}
	}

	private static void ValidateBuffersList(IList<ArraySegment<byte>> buffers)
	{
		if (buffers == null)
		{
			throw new ArgumentNullException("buffers");
		}
		if (buffers.Count == 0)
		{
			throw new ArgumentException(string.Format("net_sockets_zerolist", "buffers"), "buffers");
		}
	}

	private static void ConfigureBuffer(Int32TaskSocketAsyncEventArgs saea, ArraySegment<byte> buffer, SocketFlags socketFlags, bool wrapExceptionsInIOExceptions)
	{
		if (saea.BufferList != null)
		{
			saea.BufferList = null;
		}
		saea.SetBuffer(buffer.Array, buffer.Offset, buffer.Count);
		saea.SocketFlags = socketFlags;
		saea._wrapExceptionsInIOExceptions = wrapExceptionsInIOExceptions;
	}

	private static void ConfigureBufferList(Int32TaskSocketAsyncEventArgs saea, IList<ArraySegment<byte>> buffers, SocketFlags socketFlags)
	{
		if (saea.Buffer != null)
		{
			saea.SetBuffer(null, 0, 0);
		}
		saea.BufferList = buffers;
		saea.SocketFlags = socketFlags;
	}

	private Task<int> GetTaskForSendReceive(bool pending, Int32TaskSocketAsyncEventArgs saea, bool fromNetworkStream, bool isReceive)
	{
		Task<int> result;
		if (pending)
		{
			result = saea.GetCompletionResponsibility(out var responsibleForReturningToPool).Task;
			if (responsibleForReturningToPool)
			{
				ReturnSocketAsyncEventArgs(saea, isReceive);
			}
		}
		else
		{
			if (saea.SocketError == SocketError.Success)
			{
				int bytesTransferred = saea.BytesTransferred;
				if (bytesTransferred == 0 || (fromNetworkStream && !isReceive))
				{
					result = s_zeroTask;
				}
				else
				{
					Task<int> successfullyCompletedTask = saea._successfullyCompletedTask;
					result = ((successfullyCompletedTask != null && successfullyCompletedTask.Result == bytesTransferred) ? successfullyCompletedTask : (saea._successfullyCompletedTask = Task.FromResult(bytesTransferred)));
				}
			}
			else
			{
				result = Task.FromException<int>(GetException(saea.SocketError, fromNetworkStream));
			}
			ReturnSocketAsyncEventArgs(saea, isReceive);
		}
		return result;
	}

	private static void CompleteAccept(Socket s, TaskSocketAsyncEventArgs<Socket> saea)
	{
		SocketError socketError = saea.SocketError;
		Socket acceptSocket = saea.AcceptSocket;
		bool responsibleForReturningToPool;
		AsyncTaskMethodBuilder<Socket> completionResponsibility = saea.GetCompletionResponsibility(out responsibleForReturningToPool);
		if (responsibleForReturningToPool)
		{
			s.ReturnSocketAsyncEventArgs(saea);
		}
		if (socketError == SocketError.Success)
		{
			completionResponsibility.SetResult(acceptSocket);
		}
		else
		{
			completionResponsibility.SetException(GetException(socketError));
		}
	}

	private static void CompleteSendReceive(Socket s, Int32TaskSocketAsyncEventArgs saea, bool isReceive)
	{
		SocketError socketError = saea.SocketError;
		int bytesTransferred = saea.BytesTransferred;
		bool wrapExceptionsInIOExceptions = saea._wrapExceptionsInIOExceptions;
		bool responsibleForReturningToPool;
		AsyncTaskMethodBuilder<int> completionResponsibility = saea.GetCompletionResponsibility(out responsibleForReturningToPool);
		if (responsibleForReturningToPool)
		{
			s.ReturnSocketAsyncEventArgs(saea, isReceive);
		}
		if (socketError == SocketError.Success)
		{
			completionResponsibility.SetResult(bytesTransferred);
		}
		else
		{
			completionResponsibility.SetException(GetException(socketError, wrapExceptionsInIOExceptions));
		}
	}

	private static Exception GetException(SocketError error, bool wrapExceptionsInIOExceptions = false)
	{
		Exception ex = new SocketException((int)error);
		if (!wrapExceptionsInIOExceptions)
		{
			return ex;
		}
		return new IOException(string.Format("net_io_readwritefailure", ex.Message), ex);
	}

	private Int32TaskSocketAsyncEventArgs RentSocketAsyncEventArgs(bool isReceive)
	{
		CachedTaskEventArgs e = LazyInitializer.EnsureInitialized(ref _cachedTaskEventArgs);
		Int32TaskSocketAsyncEventArgs e2 = (isReceive ? Interlocked.Exchange(ref e.Receive, s_rentedInt32Sentinel) : Interlocked.Exchange(ref e.Send, s_rentedInt32Sentinel));
		if (e2 == s_rentedInt32Sentinel)
		{
			return null;
		}
		if (e2 == null)
		{
			e2 = new Int32TaskSocketAsyncEventArgs();
			e2.Completed += (isReceive ? ReceiveCompletedHandler : SendCompletedHandler);
		}
		return e2;
	}

	private void ReturnSocketAsyncEventArgs(Int32TaskSocketAsyncEventArgs saea, bool isReceive)
	{
		saea._accessed = false;
		saea._builder = default(AsyncTaskMethodBuilder<int>);
		saea._wrapExceptionsInIOExceptions = false;
		if (isReceive)
		{
			Volatile.Write(ref _cachedTaskEventArgs.Receive, saea);
		}
		else
		{
			Volatile.Write(ref _cachedTaskEventArgs.Send, saea);
		}
	}

	private void ReturnSocketAsyncEventArgs(TaskSocketAsyncEventArgs<Socket> saea)
	{
		saea.AcceptSocket = null;
		saea._accessed = false;
		saea._builder = default(AsyncTaskMethodBuilder<Socket>);
		Volatile.Write(ref _cachedTaskEventArgs.Accept, saea);
	}

	private void DisposeCachedTaskSocketAsyncEventArgs()
	{
		CachedTaskEventArgs cachedTaskEventArgs = _cachedTaskEventArgs;
		if (cachedTaskEventArgs != null)
		{
			Interlocked.Exchange(ref cachedTaskEventArgs.Accept, s_rentedSocketSentinel)?.Dispose();
			Interlocked.Exchange(ref cachedTaskEventArgs.Receive, s_rentedInt32Sentinel)?.Dispose();
			Interlocked.Exchange(ref cachedTaskEventArgs.Send, s_rentedInt32Sentinel)?.Dispose();
		}
	}
}
