using System.IO;
using System.Threading;

namespace System.Net.Cache;

internal class ForwardingReadStream : BaseWrapperStream, ICloseEx
{
	private class InnerAsyncResult : LazyAsyncResult
	{
		public byte[] Buffer;

		public int Offset;

		public int Count;

		public bool IsWriteCompletion;

		public InnerAsyncResult(object userState, AsyncCallback userCallback, byte[] buffer, int offset, int count)
			: base(null, userState, userCallback)
		{
			Buffer = buffer;
			Offset = offset;
			Count = count;
		}
	}

	private Stream m_ShadowStream;

	private int m_ReadNesting;

	private bool m_ShadowStreamIsDead;

	private AsyncCallback m_ReadCallback;

	private long m_BytesToSkip;

	private bool m_ThrowOnWriteError;

	private bool m_SeenReadEOF;

	private int _Disposed;

	public override bool CanRead => base.WrappedStream.CanRead;

	public override bool CanSeek => false;

	public override bool CanWrite => false;

	public override long Length => base.WrappedStream.Length - m_BytesToSkip;

	public override long Position
	{
		get
		{
			return base.WrappedStream.Position - m_BytesToSkip;
		}
		set
		{
			throw new NotSupportedException(SR.GetString("net_noseek"));
		}
	}

	public override bool CanTimeout
	{
		get
		{
			if (base.WrappedStream.CanTimeout)
			{
				return m_ShadowStream.CanTimeout;
			}
			return false;
		}
	}

	public override int ReadTimeout
	{
		get
		{
			return base.WrappedStream.ReadTimeout;
		}
		set
		{
			Stream wrappedStream = base.WrappedStream;
			int readTimeout = (m_ShadowStream.ReadTimeout = value);
			wrappedStream.ReadTimeout = readTimeout;
		}
	}

	public override int WriteTimeout
	{
		get
		{
			return m_ShadowStream.WriteTimeout;
		}
		set
		{
			Stream wrappedStream = base.WrappedStream;
			int writeTimeout = (m_ShadowStream.WriteTimeout = value);
			wrappedStream.WriteTimeout = writeTimeout;
		}
	}

	internal ForwardingReadStream(Stream originalStream, Stream shadowStream, long bytesToSkip, bool throwOnWriteError)
		: base(originalStream)
	{
		if (!shadowStream.CanWrite)
		{
			throw new ArgumentException(SR.GetString("net_cache_shadowstream_not_writable"), "shadowStream");
		}
		m_ShadowStream = shadowStream;
		m_BytesToSkip = bytesToSkip;
		m_ThrowOnWriteError = throwOnWriteError;
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		throw new NotSupportedException(SR.GetString("net_noseek"));
	}

	public override void SetLength(long value)
	{
		throw new NotSupportedException(SR.GetString("net_noseek"));
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		throw new NotSupportedException(SR.GetString("net_noseek"));
	}

	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
	{
		throw new NotSupportedException(SR.GetString("net_noseek"));
	}

	public override void EndWrite(IAsyncResult asyncResult)
	{
		throw new NotSupportedException(SR.GetString("net_noseek"));
	}

	public override void Flush()
	{
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		bool flag = false;
		int num = -1;
		if (Interlocked.Increment(ref m_ReadNesting) != 1)
		{
			throw new NotSupportedException(SR.GetString("net_io_invalidnestedcall", "Read", "read"));
		}
		try
		{
			if (m_BytesToSkip != 0L)
			{
				byte[] array = new byte[4096];
				while (m_BytesToSkip != 0L)
				{
					int num2 = base.WrappedStream.Read(array, 0, (int)((m_BytesToSkip < array.Length) ? m_BytesToSkip : array.Length));
					if (num2 == 0)
					{
						m_SeenReadEOF = true;
					}
					m_BytesToSkip -= num2;
					if (!m_ShadowStreamIsDead)
					{
						m_ShadowStream.Write(array, 0, num2);
					}
				}
			}
			num = base.WrappedStream.Read(buffer, offset, count);
			if (num == 0)
			{
				m_SeenReadEOF = true;
			}
			if (m_ShadowStreamIsDead)
			{
				return num;
			}
			flag = true;
			m_ShadowStream.Write(buffer, offset, num);
			return num;
		}
		catch (Exception ex)
		{
			if (ex is ThreadAbortException || ex is StackOverflowException || ex is OutOfMemoryException)
			{
				throw;
			}
			if (!m_ShadowStreamIsDead)
			{
				m_ShadowStreamIsDead = true;
				try
				{
					if (m_ShadowStream is ICloseEx)
					{
						((ICloseEx)m_ShadowStream).CloseEx(CloseExState.Abort | CloseExState.Silent);
					}
					else
					{
						m_ShadowStream.Close();
					}
				}
				catch (Exception)
				{
					if (ex is ThreadAbortException || ex is StackOverflowException || ex is OutOfMemoryException)
					{
						throw;
					}
				}
			}
			if (!flag || m_ThrowOnWriteError)
			{
				throw;
			}
			return num;
		}
		finally
		{
			Interlocked.Decrement(ref m_ReadNesting);
		}
	}

	private void ReadCallback(IAsyncResult transportResult)
	{
		if (!transportResult.CompletedSynchronously)
		{
			InnerAsyncResult innerAsyncResult = transportResult.AsyncState as InnerAsyncResult;
			ReadComplete(transportResult);
		}
	}

	private void ReadComplete(IAsyncResult transportResult)
	{
		while (true)
		{
			InnerAsyncResult innerAsyncResult = transportResult.AsyncState as InnerAsyncResult;
			try
			{
				if (!innerAsyncResult.IsWriteCompletion)
				{
					innerAsyncResult.Count = base.WrappedStream.EndRead(transportResult);
					if (innerAsyncResult.Count == 0)
					{
						m_SeenReadEOF = true;
					}
					if (!m_ShadowStreamIsDead)
					{
						innerAsyncResult.IsWriteCompletion = true;
						transportResult = m_ShadowStream.BeginWrite(innerAsyncResult.Buffer, innerAsyncResult.Offset, innerAsyncResult.Count, m_ReadCallback, innerAsyncResult);
						if (transportResult.CompletedSynchronously)
						{
							continue;
						}
						break;
					}
				}
				else
				{
					m_ShadowStream.EndWrite(transportResult);
					innerAsyncResult.IsWriteCompletion = false;
				}
			}
			catch (Exception result)
			{
				if (innerAsyncResult.InternalPeekCompleted)
				{
					throw;
				}
				try
				{
					m_ShadowStreamIsDead = true;
					if (m_ShadowStream is ICloseEx)
					{
						((ICloseEx)m_ShadowStream).CloseEx(CloseExState.Abort | CloseExState.Silent);
					}
					else
					{
						m_ShadowStream.Close();
					}
				}
				catch (Exception)
				{
				}
				if (!innerAsyncResult.IsWriteCompletion || m_ThrowOnWriteError)
				{
					if (transportResult.CompletedSynchronously)
					{
						throw;
					}
					innerAsyncResult.InvokeCallback(result);
					break;
				}
			}
			try
			{
				if (m_BytesToSkip != 0L)
				{
					m_BytesToSkip -= innerAsyncResult.Count;
					innerAsyncResult.Count = (int)((m_BytesToSkip < innerAsyncResult.Buffer.Length) ? m_BytesToSkip : innerAsyncResult.Buffer.Length);
					if (m_BytesToSkip == 0L)
					{
						transportResult = innerAsyncResult;
						innerAsyncResult = innerAsyncResult.AsyncState as InnerAsyncResult;
					}
					transportResult = base.WrappedStream.BeginRead(innerAsyncResult.Buffer, innerAsyncResult.Offset, innerAsyncResult.Count, m_ReadCallback, innerAsyncResult);
					if (transportResult.CompletedSynchronously)
					{
						continue;
					}
					break;
				}
				innerAsyncResult.InvokeCallback(innerAsyncResult.Count);
				break;
			}
			catch (Exception result2)
			{
				if (innerAsyncResult.InternalPeekCompleted)
				{
					throw;
				}
				try
				{
					m_ShadowStreamIsDead = true;
					if (m_ShadowStream is ICloseEx)
					{
						((ICloseEx)m_ShadowStream).CloseEx(CloseExState.Abort | CloseExState.Silent);
					}
					else
					{
						m_ShadowStream.Close();
					}
				}
				catch (Exception)
				{
				}
				if (transportResult.CompletedSynchronously)
				{
					throw;
				}
				innerAsyncResult.InvokeCallback(result2);
				break;
			}
		}
	}

	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
	{
		if (Interlocked.Increment(ref m_ReadNesting) != 1)
		{
			throw new NotSupportedException(SR.GetString("net_io_invalidnestedcall", "BeginRead", "read"));
		}
		try
		{
			if (m_ReadCallback == null)
			{
				m_ReadCallback = ReadCallback;
			}
			if (m_ShadowStreamIsDead && m_BytesToSkip == 0L)
			{
				return base.WrappedStream.BeginRead(buffer, offset, count, callback, state);
			}
			InnerAsyncResult innerAsyncResult = new InnerAsyncResult(state, callback, buffer, offset, count);
			if (m_BytesToSkip != 0L)
			{
				InnerAsyncResult userState = innerAsyncResult;
				innerAsyncResult = new InnerAsyncResult(userState, null, new byte[4096], 0, (int)((m_BytesToSkip < buffer.Length) ? m_BytesToSkip : buffer.Length));
			}
			IAsyncResult asyncResult = base.WrappedStream.BeginRead(innerAsyncResult.Buffer, innerAsyncResult.Offset, innerAsyncResult.Count, m_ReadCallback, innerAsyncResult);
			if (asyncResult.CompletedSynchronously)
			{
				ReadComplete(asyncResult);
			}
			return innerAsyncResult;
		}
		catch
		{
			Interlocked.Decrement(ref m_ReadNesting);
			throw;
		}
	}

	public override int EndRead(IAsyncResult asyncResult)
	{
		if (Interlocked.Decrement(ref m_ReadNesting) != 0)
		{
			Interlocked.Increment(ref m_ReadNesting);
			throw new InvalidOperationException(SR.GetString("net_io_invalidendcall", "EndRead"));
		}
		if (asyncResult == null)
		{
			throw new ArgumentNullException("asyncResult");
		}
		InnerAsyncResult innerAsyncResult = asyncResult as InnerAsyncResult;
		if (innerAsyncResult == null && base.WrappedStream.EndRead(asyncResult) == 0)
		{
			m_SeenReadEOF = true;
		}
		bool flag = false;
		try
		{
			innerAsyncResult.InternalWaitForCompletion();
			if (innerAsyncResult.Result is Exception)
			{
				throw (Exception)innerAsyncResult.Result;
			}
			flag = true;
		}
		finally
		{
			if (!flag && !m_ShadowStreamIsDead)
			{
				m_ShadowStreamIsDead = true;
				if (m_ShadowStream is ICloseEx)
				{
					((ICloseEx)m_ShadowStream).CloseEx(CloseExState.Abort | CloseExState.Silent);
				}
				else
				{
					m_ShadowStream.Close();
				}
			}
		}
		return (int)innerAsyncResult.Result;
	}

	protected sealed override void Dispose(bool disposing)
	{
		Dispose(disposing, CloseExState.Normal);
	}

	void ICloseEx.CloseEx(CloseExState closeState)
	{
		if (Interlocked.Increment(ref _Disposed) != 1)
		{
			return;
		}
		if (closeState == CloseExState.Silent)
		{
			try
			{
				int num;
				for (int i = 0; i < ConnectStream.s_DrainingBuffer.Length; i += num)
				{
					if ((num = Read(ConnectStream.s_DrainingBuffer, 0, ConnectStream.s_DrainingBuffer.Length)) <= 0)
					{
						break;
					}
				}
			}
			catch (Exception ex)
			{
				if (ex is ThreadAbortException || ex is StackOverflowException || ex is OutOfMemoryException)
				{
					throw;
				}
			}
		}
		Dispose(disposing: true, closeState);
	}

	protected virtual void Dispose(bool disposing, CloseExState closeState)
	{
		try
		{
			if (!disposing)
			{
				return;
			}
			try
			{
				if (base.WrappedStream is ICloseEx closeEx)
				{
					closeEx.CloseEx(closeState);
				}
				else
				{
					base.WrappedStream.Close();
				}
			}
			finally
			{
				if (!m_SeenReadEOF)
				{
					closeState |= CloseExState.Abort;
				}
				if (m_ShadowStream is ICloseEx)
				{
					((ICloseEx)m_ShadowStream).CloseEx(closeState);
				}
				else
				{
					m_ShadowStream.Close();
				}
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}
}
