using System.IO;
using System.Net.Sockets;
using System.Security.Permissions;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net;

internal class PooledStream : Stream
{
	private const int ClosingFlag = 536870912;

	private const int ClosedFlag = 1073741824;

	private bool m_CheckLifetime;

	private TimeSpan m_Lifetime;

	private DateTime m_CreateTime;

	private bool m_ConnectionIsDoomed;

	private ConnectionPool m_ConnectionPool;

	private WeakReference m_Owner;

	private int m_PooledCount;

	private bool m_Initalizing;

	private IPAddress m_ServerAddress;

	private NetworkStream m_NetworkStream;

	private Socket m_AbortSocket;

	private Socket m_AbortSocket6;

	private bool m_JustConnected;

	private int m_SynchronousIOClosingState;

	private GeneralAsyncDelegate m_AsyncCallback;

	internal bool JustConnected
	{
		get
		{
			if (m_JustConnected)
			{
				m_JustConnected = false;
				return true;
			}
			return false;
		}
	}

	internal IPAddress ServerAddress => m_ServerAddress;

	internal bool IsInitalizing => m_Initalizing;

	internal bool CanBePooled
	{
		get
		{
			if (m_Initalizing)
			{
				return true;
			}
			if (!m_NetworkStream.Connected)
			{
				return false;
			}
			WeakReference owner = m_Owner;
			return !m_ConnectionIsDoomed && (owner == null || !owner.IsAlive);
		}
		set
		{
			m_ConnectionIsDoomed |= !value;
		}
	}

	internal bool IsEmancipated
	{
		get
		{
			WeakReference owner = m_Owner;
			return 0 >= m_PooledCount && (owner == null || !owner.IsAlive);
		}
	}

	internal object Owner
	{
		get
		{
			WeakReference owner = m_Owner;
			if (owner != null && owner.IsAlive)
			{
				return owner.Target;
			}
			return null;
		}
		set
		{
			lock (this)
			{
				if (m_Owner != null)
				{
					m_Owner.Target = value;
				}
			}
		}
	}

	internal ConnectionPool Pool => m_ConnectionPool;

	internal virtual ServicePoint ServicePoint => Pool.ServicePoint;

	protected bool UsingSecureStream => m_NetworkStream is TlsStream;

	internal NetworkStream NetworkStream
	{
		get
		{
			return m_NetworkStream;
		}
		set
		{
			m_Initalizing = false;
			m_NetworkStream = value;
		}
	}

	protected Socket Socket => m_NetworkStream.InternalSocket;

	public override bool CanRead => m_NetworkStream.CanRead;

	public override bool CanSeek => m_NetworkStream.CanSeek;

	public override bool CanWrite => m_NetworkStream.CanWrite;

	public override bool CanTimeout => m_NetworkStream.CanTimeout;

	public override int ReadTimeout
	{
		get
		{
			return m_NetworkStream.ReadTimeout;
		}
		set
		{
			m_NetworkStream.ReadTimeout = value;
		}
	}

	public override int WriteTimeout
	{
		get
		{
			return m_NetworkStream.WriteTimeout;
		}
		set
		{
			m_NetworkStream.WriteTimeout = value;
		}
	}

	public override long Length => m_NetworkStream.Length;

	public override long Position
	{
		get
		{
			return m_NetworkStream.Position;
		}
		set
		{
			m_NetworkStream.Position = value;
		}
	}

	internal PooledStream(object owner)
	{
		m_Owner = new WeakReference(owner);
		m_PooledCount = -1;
		m_Initalizing = true;
		m_NetworkStream = new NetworkStream();
		m_CreateTime = DateTime.UtcNow;
	}

	internal PooledStream(ConnectionPool connectionPool, TimeSpan lifetime, bool checkLifetime)
	{
		m_ConnectionPool = connectionPool;
		m_Lifetime = lifetime;
		m_CheckLifetime = checkLifetime;
		m_Initalizing = true;
		m_NetworkStream = new NetworkStream();
		m_CreateTime = DateTime.UtcNow;
	}

	internal bool Activate(object owningObject, GeneralAsyncDelegate asyncCallback)
	{
		return Activate(owningObject, asyncCallback != null, asyncCallback);
	}

	protected bool Activate(object owningObject, bool async, GeneralAsyncDelegate asyncCallback)
	{
		try
		{
			if (m_Initalizing)
			{
				IPAddress address = null;
				m_AsyncCallback = asyncCallback;
				Socket connection = ServicePoint.GetConnection(this, owningObject, async, out address, ref m_AbortSocket, ref m_AbortSocket6);
				if (connection != null)
				{
					if (Logging.On)
					{
						Logging.PrintInfo(Logging.Web, this, SR.GetString("net_log_socket_connected", connection.LocalEndPoint, connection.RemoteEndPoint));
					}
					m_NetworkStream.InitNetworkStream(connection, FileAccess.ReadWrite);
					m_ServerAddress = address;
					m_Initalizing = false;
					m_JustConnected = true;
					m_AbortSocket = null;
					m_AbortSocket6 = null;
					return true;
				}
				return false;
			}
			if (async)
			{
				asyncCallback?.Invoke(owningObject, this);
			}
			return true;
		}
		catch
		{
			m_Initalizing = false;
			throw;
		}
	}

	internal void Deactivate()
	{
		m_AsyncCallback = null;
		if (!m_ConnectionIsDoomed && m_CheckLifetime)
		{
			CheckLifetime();
		}
	}

	internal virtual void ConnectionCallback(object owningObject, Exception e, Socket socket, IPAddress address)
	{
		object obj = null;
		if (e != null)
		{
			m_Initalizing = false;
			obj = e;
		}
		else
		{
			try
			{
				if (Logging.On)
				{
					Logging.PrintInfo(Logging.Web, this, SR.GetString("net_log_socket_connected", socket.LocalEndPoint, socket.RemoteEndPoint));
				}
				m_NetworkStream.InitNetworkStream(socket, FileAccess.ReadWrite);
				obj = this;
			}
			catch (Exception ex)
			{
				if (NclUtilities.IsFatal(ex))
				{
					throw;
				}
				obj = ex;
			}
			m_ServerAddress = address;
			m_Initalizing = false;
			m_JustConnected = true;
		}
		if (m_AsyncCallback != null)
		{
			m_AsyncCallback(owningObject, obj);
		}
		m_AbortSocket = null;
		m_AbortSocket6 = null;
	}

	protected void CheckLifetime()
	{
		if (!m_ConnectionIsDoomed)
		{
			TimeSpan t = DateTime.UtcNow.Subtract(m_CreateTime);
			m_ConnectionIsDoomed = 0 < TimeSpan.Compare(m_Lifetime, t);
		}
	}

	internal void UpdateLifetime()
	{
		int connectionLeaseTimeout = ServicePoint.ConnectionLeaseTimeout;
		TimeSpan timeSpan;
		if (connectionLeaseTimeout == -1)
		{
			timeSpan = TimeSpan.MaxValue;
			m_CheckLifetime = false;
		}
		else
		{
			timeSpan = new TimeSpan(0, 0, 0, 0, connectionLeaseTimeout);
			m_CheckLifetime = true;
		}
		if (timeSpan != m_Lifetime)
		{
			m_Lifetime = timeSpan;
		}
	}

	internal void PrePush(object expectedOwner)
	{
		lock (this)
		{
			if (expectedOwner == null)
			{
				if (m_Owner != null && m_Owner.Target != null)
				{
					throw new InternalException();
				}
			}
			else if (m_Owner == null || m_Owner.Target != expectedOwner)
			{
				throw new InternalException();
			}
			m_PooledCount++;
			if (1 != m_PooledCount)
			{
				throw new InternalException();
			}
			if (m_Owner != null)
			{
				m_Owner.Target = null;
			}
		}
	}

	internal void PostPop(object newOwner)
	{
		lock (this)
		{
			if (m_Owner == null)
			{
				m_Owner = new WeakReference(newOwner);
			}
			else
			{
				if (m_Owner.Target != null)
				{
					throw new InternalException();
				}
				m_Owner.Target = newOwner;
			}
			m_PooledCount--;
			if (Pool != null)
			{
				if (m_PooledCount != 0)
				{
					throw new InternalException();
				}
			}
			else if (-1 != m_PooledCount)
			{
				throw new InternalException();
			}
		}
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		return m_NetworkStream.Seek(offset, origin);
	}

	public override int Read(byte[] buffer, int offset, int size)
	{
		try
		{
			if (ServicePointManager.UseSafeSynchronousClose)
			{
				int num = Interlocked.Increment(ref m_SynchronousIOClosingState);
				if ((num & 0x60000000) != 0)
				{
					throw new ObjectDisposedException(GetType().FullName);
				}
			}
			return m_NetworkStream.Read(buffer, offset, size);
		}
		finally
		{
			if (ServicePointManager.UseSafeSynchronousClose && 536870912 == Interlocked.Decrement(ref m_SynchronousIOClosingState))
			{
				try
				{
					TryCloseNetworkStream(closeWithTimeout: false, 0);
				}
				catch
				{
				}
			}
		}
	}

	public override void Write(byte[] buffer, int offset, int size)
	{
		try
		{
			if (ServicePointManager.UseSafeSynchronousClose)
			{
				int num = Interlocked.Increment(ref m_SynchronousIOClosingState);
				if ((num & 0x60000000) != 0)
				{
					throw new ObjectDisposedException(GetType().FullName);
				}
			}
			m_NetworkStream.Write(buffer, offset, size);
		}
		finally
		{
			if (ServicePointManager.UseSafeSynchronousClose && 536870912 == Interlocked.Decrement(ref m_SynchronousIOClosingState))
			{
				try
				{
					TryCloseNetworkStream(closeWithTimeout: false, 0);
				}
				catch
				{
				}
			}
		}
	}

	internal void MultipleWrite(BufferOffsetSize[] buffers)
	{
		m_NetworkStream.MultipleWrite(buffers);
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing)
			{
				m_Owner = null;
				m_ConnectionIsDoomed = true;
				CloseSocket();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	private int InterlockedOr(ref int location1, int bitMask)
	{
		int num;
		do
		{
			num = Volatile.Read(ref location1);
		}
		while (num != Interlocked.CompareExchange(ref location1, num | bitMask, num));
		return num;
	}

	private bool TryCloseNetworkStream(bool closeWithTimeout, int timeout)
	{
		if (!ServicePointManager.UseSafeSynchronousClose)
		{
			return false;
		}
		if (536870912 == Interlocked.CompareExchange(ref m_SynchronousIOClosingState, 1073741824, 536870912))
		{
			if (closeWithTimeout)
			{
				m_NetworkStream.Close(timeout);
			}
			else
			{
				m_NetworkStream.Close();
			}
			return true;
		}
		return false;
	}

	private bool CancelPendingIoAndCloseIfSafe(bool closeWithTimeout, int timeout)
	{
		if (TryCloseNetworkStream(closeWithTimeout, timeout))
		{
			return true;
		}
		try
		{
			Socket internalSocket = m_NetworkStream.InternalSocket;
			UnsafeNclNativeMethods.CancelIoEx(internalSocket.SafeHandle, IntPtr.Zero);
		}
		catch
		{
		}
		return TryCloseNetworkStream(closeWithTimeout, timeout);
	}

	private void CloseConnectingSockets(bool useTimeout, int timeout)
	{
		Socket abortSocket = m_AbortSocket;
		Socket abortSocket2 = m_AbortSocket6;
		if (abortSocket != null)
		{
			if (ServicePointManager.UseSafeSynchronousClose)
			{
				try
				{
					UnsafeNclNativeMethods.CancelIoEx(abortSocket.SafeHandle, IntPtr.Zero);
				}
				catch
				{
				}
			}
			if (useTimeout)
			{
				abortSocket.Close(timeout);
			}
			else
			{
				abortSocket.Close();
			}
			m_AbortSocket = null;
		}
		if (abortSocket2 == null)
		{
			return;
		}
		if (ServicePointManager.UseSafeSynchronousClose)
		{
			try
			{
				UnsafeNclNativeMethods.CancelIoEx(abortSocket2.SafeHandle, IntPtr.Zero);
			}
			catch
			{
			}
		}
		if (useTimeout)
		{
			abortSocket2.Close(timeout);
		}
		else
		{
			abortSocket2.Close();
		}
		m_AbortSocket6 = null;
	}

	internal void CloseSocket()
	{
		if (!ServicePointManager.UseSafeSynchronousClose)
		{
			m_NetworkStream.Close();
		}
		else
		{
			InterlockedOr(ref m_SynchronousIOClosingState, 536870912);
			CancelPendingIoAndCloseIfSafe(closeWithTimeout: false, 0);
		}
		CloseConnectingSockets(useTimeout: false, 0);
	}

	public void Close(int timeout)
	{
		if (!ServicePointManager.UseSafeSynchronousClose)
		{
			m_NetworkStream.Close(timeout);
		}
		else
		{
			InterlockedOr(ref m_SynchronousIOClosingState, 536870912);
			CancelPendingIoAndCloseIfSafe(closeWithTimeout: true, timeout);
		}
		CloseConnectingSockets(useTimeout: true, timeout);
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
	{
		return m_NetworkStream.BeginRead(buffer, offset, size, callback, state);
	}

	internal virtual IAsyncResult UnsafeBeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
	{
		return m_NetworkStream.UnsafeBeginRead(buffer, offset, size, callback, state);
	}

	public override int EndRead(IAsyncResult asyncResult)
	{
		return m_NetworkStream.EndRead(asyncResult);
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
	{
		return m_NetworkStream.BeginWrite(buffer, offset, size, callback, state);
	}

	internal virtual IAsyncResult UnsafeBeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
	{
		return m_NetworkStream.UnsafeBeginWrite(buffer, offset, size, callback, state);
	}

	public override void EndWrite(IAsyncResult asyncResult)
	{
		m_NetworkStream.EndWrite(asyncResult);
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	internal IAsyncResult BeginMultipleWrite(BufferOffsetSize[] buffers, AsyncCallback callback, object state)
	{
		return m_NetworkStream.BeginMultipleWrite(buffers, callback, state);
	}

	internal void EndMultipleWrite(IAsyncResult asyncResult)
	{
		m_NetworkStream.EndMultipleWrite(asyncResult);
	}

	public override void Flush()
	{
		m_NetworkStream.Flush();
	}

	public override Task FlushAsync(CancellationToken cancellationToken)
	{
		return m_NetworkStream.FlushAsync(cancellationToken);
	}

	public override void SetLength(long value)
	{
		m_NetworkStream.SetLength(value);
	}

	internal void SetSocketTimeoutOption(SocketShutdown mode, int timeout, bool silent)
	{
		m_NetworkStream.SetSocketTimeoutOption(mode, timeout, silent);
	}

	internal bool Poll(int microSeconds, SelectMode mode)
	{
		return m_NetworkStream.Poll(microSeconds, mode);
	}

	internal bool PollRead()
	{
		return m_NetworkStream.PollRead();
	}
}
