using System.IO;
using System.Net.Sockets;
using System.Security.Permissions;

namespace System.Net;

internal class FtpDataStream : Stream, ICloseEx
{
	private FtpWebRequest m_Request;

	private NetworkStream m_NetworkStream;

	private bool m_Writeable;

	private bool m_Readable;

	private bool m_IsFullyRead;

	private bool m_Closing;

	public override bool CanRead => m_Readable;

	public override bool CanSeek => m_NetworkStream.CanSeek;

	public override bool CanWrite => m_Writeable;

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

	internal FtpDataStream(NetworkStream networkStream, FtpWebRequest request, TriState writeOnly)
	{
		m_Readable = true;
		m_Writeable = true;
		switch (writeOnly)
		{
		case TriState.True:
			m_Readable = false;
			break;
		case TriState.False:
			m_Writeable = false;
			break;
		}
		m_NetworkStream = networkStream;
		m_Request = request;
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing)
			{
				((ICloseEx)this).CloseEx(CloseExState.Normal);
			}
			else
			{
				((ICloseEx)this).CloseEx(CloseExState.Abort | CloseExState.Silent);
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	void ICloseEx.CloseEx(CloseExState closeState)
	{
		lock (this)
		{
			if (m_Closing)
			{
				return;
			}
			m_Closing = true;
			m_Writeable = false;
			m_Readable = false;
		}
		try
		{
			try
			{
				if ((closeState & CloseExState.Abort) == 0)
				{
					m_NetworkStream.Close(-1);
				}
				else
				{
					m_NetworkStream.Close(0);
				}
			}
			finally
			{
				m_Request.DataStreamClosed(closeState);
			}
		}
		catch (Exception ex)
		{
			bool flag = true;
			if (ex is WebException { Response: FtpWebResponse response } && !m_IsFullyRead && response.StatusCode == FtpStatusCode.ConnectionClosed)
			{
				flag = false;
			}
			if (flag && (closeState & CloseExState.Silent) == 0)
			{
				throw;
			}
		}
	}

	private void CheckError()
	{
		if (m_Request.Aborted)
		{
			throw new WebException(NetRes.GetWebStatusString("net_requestaborted", WebExceptionStatus.RequestCanceled), WebExceptionStatus.RequestCanceled);
		}
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		CheckError();
		try
		{
			return m_NetworkStream.Seek(offset, origin);
		}
		catch
		{
			CheckError();
			throw;
		}
	}

	public override int Read(byte[] buffer, int offset, int size)
	{
		CheckError();
		int num;
		try
		{
			num = m_NetworkStream.Read(buffer, offset, size);
		}
		catch
		{
			CheckError();
			throw;
		}
		if (num == 0)
		{
			m_IsFullyRead = true;
			Close();
		}
		return num;
	}

	public override void Write(byte[] buffer, int offset, int size)
	{
		CheckError();
		try
		{
			m_NetworkStream.Write(buffer, offset, size);
		}
		catch
		{
			CheckError();
			throw;
		}
	}

	private void AsyncReadCallback(IAsyncResult ar)
	{
		LazyAsyncResult lazyAsyncResult = (LazyAsyncResult)ar.AsyncState;
		try
		{
			try
			{
				int num = m_NetworkStream.EndRead(ar);
				if (num == 0)
				{
					m_IsFullyRead = true;
					Close();
				}
				lazyAsyncResult.InvokeCallback(num);
			}
			catch (Exception result)
			{
				if (!lazyAsyncResult.IsCompleted)
				{
					lazyAsyncResult.InvokeCallback(result);
				}
			}
		}
		catch
		{
		}
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
	{
		CheckError();
		LazyAsyncResult lazyAsyncResult = new LazyAsyncResult(this, state, callback);
		try
		{
			m_NetworkStream.BeginRead(buffer, offset, size, AsyncReadCallback, lazyAsyncResult);
			return lazyAsyncResult;
		}
		catch
		{
			CheckError();
			throw;
		}
	}

	public override int EndRead(IAsyncResult ar)
	{
		try
		{
			object obj = ((LazyAsyncResult)ar).InternalWaitForCompletion();
			if (obj is Exception)
			{
				throw (Exception)obj;
			}
			return (int)obj;
		}
		finally
		{
			CheckError();
		}
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
	{
		CheckError();
		try
		{
			return m_NetworkStream.BeginWrite(buffer, offset, size, callback, state);
		}
		catch
		{
			CheckError();
			throw;
		}
	}

	public override void EndWrite(IAsyncResult asyncResult)
	{
		try
		{
			m_NetworkStream.EndWrite(asyncResult);
		}
		finally
		{
			CheckError();
		}
	}

	public override void Flush()
	{
		m_NetworkStream.Flush();
	}

	public override void SetLength(long value)
	{
		m_NetworkStream.SetLength(value);
	}

	internal void SetSocketTimeoutOption(SocketShutdown mode, int timeout, bool silent)
	{
		m_NetworkStream.SetSocketTimeoutOption(mode, timeout, silent);
	}
}
