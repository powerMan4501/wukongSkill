using System.IO;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net.Sockets;

public class NetworkStream : Stream
{
	private Socket m_StreamSocket;

	private bool m_Readable;

	private bool m_Writeable;

	private bool m_OwnsSocket;

	private int m_CloseTimeout = -1;

	private volatile bool m_CleanedUp;

	private int m_CurrentReadTimeout = -1;

	private int m_CurrentWriteTimeout = -1;

	protected Socket Socket => m_StreamSocket;

	internal Socket InternalSocket
	{
		get
		{
			Socket streamSocket = m_StreamSocket;
			if (m_CleanedUp || streamSocket == null)
			{
				throw new ObjectDisposedException(GetType().FullName);
			}
			return streamSocket;
		}
	}

	protected bool Readable
	{
		get
		{
			return m_Readable;
		}
		set
		{
			m_Readable = value;
		}
	}

	protected bool Writeable
	{
		get
		{
			return m_Writeable;
		}
		set
		{
			m_Writeable = value;
		}
	}

	public override bool CanRead => m_Readable;

	public override bool CanSeek => false;

	public override bool CanWrite => m_Writeable;

	public override bool CanTimeout => true;

	public override int ReadTimeout
	{
		get
		{
			int num = (int)m_StreamSocket.GetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout);
			if (num == 0)
			{
				return -1;
			}
			return num;
		}
		set
		{
			if (value <= 0 && value != -1)
			{
				throw new ArgumentOutOfRangeException("value", SR.GetString("net_io_timeout_use_gt_zero"));
			}
			SetSocketTimeoutOption(SocketShutdown.Receive, value, silent: false);
		}
	}

	public override int WriteTimeout
	{
		get
		{
			int num = (int)m_StreamSocket.GetSocketOption(SocketOptionLevel.Socket, SocketOptionName.SendTimeout);
			if (num == 0)
			{
				return -1;
			}
			return num;
		}
		set
		{
			if (value <= 0 && value != -1)
			{
				throw new ArgumentOutOfRangeException("value", SR.GetString("net_io_timeout_use_gt_zero"));
			}
			SetSocketTimeoutOption(SocketShutdown.Send, value, silent: false);
		}
	}

	public virtual bool DataAvailable
	{
		get
		{
			if (m_CleanedUp)
			{
				throw new ObjectDisposedException(GetType().FullName);
			}
			Socket streamSocket = m_StreamSocket;
			if (streamSocket == null)
			{
				throw new IOException(SR.GetString("net_io_readfailure", SR.GetString("net_io_connectionclosed")));
			}
			return streamSocket.Available != 0;
		}
	}

	public override long Length
	{
		get
		{
			throw new NotSupportedException(SR.GetString("net_noseek"));
		}
	}

	public override long Position
	{
		get
		{
			throw new NotSupportedException(SR.GetString("net_noseek"));
		}
		set
		{
			throw new NotSupportedException(SR.GetString("net_noseek"));
		}
	}

	internal bool Connected
	{
		get
		{
			Socket streamSocket = m_StreamSocket;
			if (!m_CleanedUp && streamSocket != null && streamSocket.Connected)
			{
				return true;
			}
			return false;
		}
	}

	internal NetworkStream()
	{
		m_OwnsSocket = true;
	}

	public NetworkStream(Socket socket)
	{
		if (socket == null)
		{
			throw new ArgumentNullException("socket");
		}
		InitNetworkStream(socket, FileAccess.ReadWrite);
	}

	public NetworkStream(Socket socket, bool ownsSocket)
	{
		if (socket == null)
		{
			throw new ArgumentNullException("socket");
		}
		InitNetworkStream(socket, FileAccess.ReadWrite);
		m_OwnsSocket = ownsSocket;
	}

	internal NetworkStream(NetworkStream networkStream, bool ownsSocket)
	{
		Socket socket = networkStream.Socket;
		if (socket == null)
		{
			throw new ArgumentNullException("networkStream");
		}
		InitNetworkStream(socket, FileAccess.ReadWrite);
		m_OwnsSocket = ownsSocket;
	}

	public NetworkStream(Socket socket, FileAccess access)
	{
		if (socket == null)
		{
			throw new ArgumentNullException("socket");
		}
		InitNetworkStream(socket, access);
	}

	public NetworkStream(Socket socket, FileAccess access, bool ownsSocket)
	{
		if (socket == null)
		{
			throw new ArgumentNullException("socket");
		}
		InitNetworkStream(socket, access);
		m_OwnsSocket = ownsSocket;
	}

	internal void InternalAbortSocket()
	{
		if (!m_OwnsSocket)
		{
			throw new InvalidOperationException();
		}
		Socket streamSocket = m_StreamSocket;
		if (m_CleanedUp || streamSocket == null)
		{
			return;
		}
		try
		{
			streamSocket.Close(0);
		}
		catch (ObjectDisposedException)
		{
		}
	}

	internal void ConvertToNotSocketOwner()
	{
		m_OwnsSocket = false;
		GC.SuppressFinalize(this);
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		throw new NotSupportedException(SR.GetString("net_noseek"));
	}

	internal void InitNetworkStream(Socket socket, FileAccess Access)
	{
		if (!socket.Blocking)
		{
			throw new IOException(SR.GetString("net_sockets_blocking"));
		}
		if (!socket.Connected)
		{
			throw new IOException(SR.GetString("net_notconnected"));
		}
		if (socket.SocketType != SocketType.Stream)
		{
			throw new IOException(SR.GetString("net_notstream"));
		}
		m_StreamSocket = socket;
		switch (Access)
		{
		case FileAccess.Read:
			m_Readable = true;
			break;
		case FileAccess.Write:
			m_Writeable = true;
			break;
		default:
			m_Readable = true;
			m_Writeable = true;
			break;
		}
	}

	internal bool PollRead()
	{
		if (m_CleanedUp)
		{
			return false;
		}
		return m_StreamSocket?.Poll(0, SelectMode.SelectRead) ?? false;
	}

	internal bool Poll(int microSeconds, SelectMode mode)
	{
		if (m_CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		Socket streamSocket = m_StreamSocket;
		if (streamSocket == null)
		{
			throw new IOException(SR.GetString("net_io_readfailure", SR.GetString("net_io_connectionclosed")));
		}
		return streamSocket.Poll(microSeconds, mode);
	}

	public override int Read([In][Out] byte[] buffer, int offset, int size)
	{
		bool canRead = CanRead;
		if (m_CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		if (!canRead)
		{
			throw new InvalidOperationException(SR.GetString("net_writeonlystream"));
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
		Socket streamSocket = m_StreamSocket;
		if (streamSocket == null)
		{
			throw new IOException(SR.GetString("net_io_readfailure", SR.GetString("net_io_connectionclosed")));
		}
		try
		{
			return streamSocket.Receive(buffer, offset, size, SocketFlags.None);
		}
		catch (Exception ex)
		{
			if (ex is ThreadAbortException || ex is StackOverflowException || ex is OutOfMemoryException)
			{
				throw;
			}
			throw new IOException(SR.GetString("net_io_readfailure", ex.Message), ex);
		}
	}

	public override void Write(byte[] buffer, int offset, int size)
	{
		bool canWrite = CanWrite;
		if (m_CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		if (!canWrite)
		{
			throw new InvalidOperationException(SR.GetString("net_readonlystream"));
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
		Socket streamSocket = m_StreamSocket;
		if (streamSocket == null)
		{
			throw new IOException(SR.GetString("net_io_writefailure", SR.GetString("net_io_connectionclosed")));
		}
		try
		{
			streamSocket.Send(buffer, offset, size, SocketFlags.None);
		}
		catch (Exception ex)
		{
			if (ex is ThreadAbortException || ex is StackOverflowException || ex is OutOfMemoryException)
			{
				throw;
			}
			throw new IOException(SR.GetString("net_io_writefailure", ex.Message), ex);
		}
	}

	public void Close(int timeout)
	{
		if (timeout < -1)
		{
			throw new ArgumentOutOfRangeException("timeout");
		}
		m_CloseTimeout = timeout;
		Close();
	}

	protected override void Dispose(bool disposing)
	{
		bool cleanedUp = m_CleanedUp;
		m_CleanedUp = true;
		if (!cleanedUp && disposing && m_StreamSocket != null)
		{
			m_Readable = false;
			m_Writeable = false;
			if (m_OwnsSocket)
			{
				Socket streamSocket = m_StreamSocket;
				if (streamSocket != null)
				{
					streamSocket.InternalShutdown(SocketShutdown.Both);
					streamSocket.Close(m_CloseTimeout);
				}
			}
		}
		base.Dispose(disposing);
	}

	~NetworkStream()
	{
		Dispose(disposing: false);
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
	{
		bool canRead = CanRead;
		if (m_CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		if (!canRead)
		{
			throw new InvalidOperationException(SR.GetString("net_writeonlystream"));
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
		Socket streamSocket = m_StreamSocket;
		if (streamSocket == null)
		{
			throw new IOException(SR.GetString("net_io_readfailure", SR.GetString("net_io_connectionclosed")));
		}
		try
		{
			return streamSocket.BeginReceive(buffer, offset, size, SocketFlags.None, callback, state);
		}
		catch (Exception ex)
		{
			if (ex is ThreadAbortException || ex is StackOverflowException || ex is OutOfMemoryException)
			{
				throw;
			}
			throw new IOException(SR.GetString("net_io_readfailure", ex.Message), ex);
		}
	}

	internal virtual IAsyncResult UnsafeBeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
	{
		bool canRead = CanRead;
		if (m_CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		if (!canRead)
		{
			throw new InvalidOperationException(SR.GetString("net_writeonlystream"));
		}
		Socket streamSocket = m_StreamSocket;
		if (streamSocket == null)
		{
			throw new IOException(SR.GetString("net_io_readfailure", SR.GetString("net_io_connectionclosed")));
		}
		try
		{
			return streamSocket.UnsafeBeginReceive(buffer, offset, size, SocketFlags.None, callback, state);
		}
		catch (Exception ex)
		{
			if (NclUtilities.IsFatal(ex))
			{
				throw;
			}
			throw new IOException(SR.GetString("net_io_readfailure", ex.Message), ex);
		}
	}

	public override int EndRead(IAsyncResult asyncResult)
	{
		if (m_CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		if (asyncResult == null)
		{
			throw new ArgumentNullException("asyncResult");
		}
		Socket streamSocket = m_StreamSocket;
		if (streamSocket == null)
		{
			throw new IOException(SR.GetString("net_io_readfailure", SR.GetString("net_io_connectionclosed")));
		}
		try
		{
			return streamSocket.EndReceive(asyncResult);
		}
		catch (Exception ex)
		{
			if (ex is ThreadAbortException || ex is StackOverflowException || ex is OutOfMemoryException)
			{
				throw;
			}
			throw new IOException(SR.GetString("net_io_readfailure", ex.Message), ex);
		}
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
	{
		bool canWrite = CanWrite;
		if (m_CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		if (!canWrite)
		{
			throw new InvalidOperationException(SR.GetString("net_readonlystream"));
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
		Socket streamSocket = m_StreamSocket;
		if (streamSocket == null)
		{
			throw new IOException(SR.GetString("net_io_writefailure", SR.GetString("net_io_connectionclosed")));
		}
		try
		{
			return streamSocket.BeginSend(buffer, offset, size, SocketFlags.None, callback, state);
		}
		catch (Exception ex)
		{
			if (ex is ThreadAbortException || ex is StackOverflowException || ex is OutOfMemoryException)
			{
				throw;
			}
			throw new IOException(SR.GetString("net_io_writefailure", ex.Message), ex);
		}
	}

	internal virtual IAsyncResult UnsafeBeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
	{
		bool canWrite = CanWrite;
		if (m_CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		if (!canWrite)
		{
			throw new InvalidOperationException(SR.GetString("net_readonlystream"));
		}
		Socket streamSocket = m_StreamSocket;
		if (streamSocket == null)
		{
			throw new IOException(SR.GetString("net_io_writefailure", SR.GetString("net_io_connectionclosed")));
		}
		try
		{
			return streamSocket.UnsafeBeginSend(buffer, offset, size, SocketFlags.None, callback, state);
		}
		catch (Exception ex)
		{
			if (ex is ThreadAbortException || ex is StackOverflowException || ex is OutOfMemoryException)
			{
				throw;
			}
			throw new IOException(SR.GetString("net_io_writefailure", ex.Message), ex);
		}
	}

	public override void EndWrite(IAsyncResult asyncResult)
	{
		if (m_CleanedUp)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		if (asyncResult == null)
		{
			throw new ArgumentNullException("asyncResult");
		}
		Socket streamSocket = m_StreamSocket;
		if (streamSocket == null)
		{
			throw new IOException(SR.GetString("net_io_writefailure", SR.GetString("net_io_connectionclosed")));
		}
		try
		{
			streamSocket.EndSend(asyncResult);
		}
		catch (Exception ex)
		{
			if (ex is ThreadAbortException || ex is StackOverflowException || ex is OutOfMemoryException)
			{
				throw;
			}
			throw new IOException(SR.GetString("net_io_writefailure", ex.Message), ex);
		}
	}

	internal virtual void MultipleWrite(BufferOffsetSize[] buffers)
	{
		if (buffers == null)
		{
			throw new ArgumentNullException("buffers");
		}
		Socket streamSocket = m_StreamSocket;
		if (streamSocket == null)
		{
			throw new IOException(SR.GetString("net_io_writefailure", SR.GetString("net_io_connectionclosed")));
		}
		try
		{
			streamSocket.MultipleSend(buffers, SocketFlags.None);
		}
		catch (Exception ex)
		{
			if (ex is ThreadAbortException || ex is StackOverflowException || ex is OutOfMemoryException)
			{
				throw;
			}
			throw new IOException(SR.GetString("net_io_writefailure", ex.Message), ex);
		}
	}

	internal virtual IAsyncResult BeginMultipleWrite(BufferOffsetSize[] buffers, AsyncCallback callback, object state)
	{
		if (buffers == null)
		{
			throw new ArgumentNullException("buffers");
		}
		Socket streamSocket = m_StreamSocket;
		if (streamSocket == null)
		{
			throw new IOException(SR.GetString("net_io_writefailure", SR.GetString("net_io_connectionclosed")));
		}
		try
		{
			return streamSocket.BeginMultipleSend(buffers, SocketFlags.None, callback, state);
		}
		catch (Exception ex)
		{
			if (ex is ThreadAbortException || ex is StackOverflowException || ex is OutOfMemoryException)
			{
				throw;
			}
			throw new IOException(SR.GetString("net_io_writefailure", ex.Message), ex);
		}
	}

	internal virtual IAsyncResult UnsafeBeginMultipleWrite(BufferOffsetSize[] buffers, AsyncCallback callback, object state)
	{
		if (buffers == null)
		{
			throw new ArgumentNullException("buffers");
		}
		Socket streamSocket = m_StreamSocket;
		if (streamSocket == null)
		{
			throw new IOException(SR.GetString("net_io_writefailure", SR.GetString("net_io_connectionclosed")));
		}
		try
		{
			return streamSocket.UnsafeBeginMultipleSend(buffers, SocketFlags.None, callback, state);
		}
		catch (Exception ex)
		{
			if (ex is ThreadAbortException || ex is StackOverflowException || ex is OutOfMemoryException)
			{
				throw;
			}
			throw new IOException(SR.GetString("net_io_writefailure", ex.Message), ex);
		}
	}

	internal virtual void EndMultipleWrite(IAsyncResult asyncResult)
	{
		if (asyncResult == null)
		{
			throw new ArgumentNullException("asyncResult");
		}
		Socket streamSocket = m_StreamSocket;
		if (streamSocket == null)
		{
			throw new IOException(SR.GetString("net_io_writefailure", SR.GetString("net_io_connectionclosed")));
		}
		try
		{
			streamSocket.EndMultipleSend(asyncResult);
		}
		catch (Exception ex)
		{
			if (ex is ThreadAbortException || ex is StackOverflowException || ex is OutOfMemoryException)
			{
				throw;
			}
			throw new IOException(SR.GetString("net_io_writefailure", ex.Message), ex);
		}
	}

	public override void Flush()
	{
	}

	public override Task FlushAsync(CancellationToken cancellationToken)
	{
		return Task.CompletedTask;
	}

	public override void SetLength(long value)
	{
		throw new NotSupportedException(SR.GetString("net_noseek"));
	}

	internal void SetSocketTimeoutOption(SocketShutdown mode, int timeout, bool silent)
	{
		if (timeout < 0)
		{
			timeout = 0;
		}
		Socket streamSocket = m_StreamSocket;
		if (streamSocket != null)
		{
			if ((mode == SocketShutdown.Send || mode == SocketShutdown.Both) && timeout != m_CurrentWriteTimeout)
			{
				streamSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.SendTimeout, timeout, silent);
				m_CurrentWriteTimeout = timeout;
			}
			if ((mode == SocketShutdown.Receive || mode == SocketShutdown.Both) && timeout != m_CurrentReadTimeout)
			{
				streamSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout, timeout, silent);
				m_CurrentReadTimeout = timeout;
			}
		}
	}
}
