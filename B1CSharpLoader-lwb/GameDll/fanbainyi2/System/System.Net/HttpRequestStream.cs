using System.IO;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net;

internal class HttpRequestStream : Stream
{
	private class HttpRequestStreamAsyncResult : LazyAsyncResult
	{
		internal unsafe NativeOverlapped* m_pOverlapped;

		internal unsafe void* m_pPinnedBuffer;

		internal uint m_dataAlreadyRead;

		private unsafe static readonly IOCompletionCallback s_IOCallback = Callback;

		internal HttpRequestStreamAsyncResult(object asyncObject, object userState, AsyncCallback callback)
			: base(asyncObject, userState, callback)
		{
		}

		internal HttpRequestStreamAsyncResult(object asyncObject, object userState, AsyncCallback callback, uint dataAlreadyRead)
			: base(asyncObject, userState, callback)
		{
			m_dataAlreadyRead = dataAlreadyRead;
		}

		internal unsafe HttpRequestStreamAsyncResult(object asyncObject, object userState, AsyncCallback callback, byte[] buffer, int offset, uint size, uint dataAlreadyRead)
			: base(asyncObject, userState, callback)
		{
			m_dataAlreadyRead = dataAlreadyRead;
			m_pOverlapped = new Overlapped
			{
				AsyncResult = this
			}.Pack(s_IOCallback, buffer);
			m_pPinnedBuffer = (void*)Marshal.UnsafeAddrOfPinnedArrayElement((Array)buffer, offset);
		}

		internal void IOCompleted(uint errorCode, uint numBytes)
		{
			IOCompleted(this, errorCode, numBytes);
		}

		private unsafe static void IOCompleted(HttpRequestStreamAsyncResult asyncResult, uint errorCode, uint numBytes)
		{
			object obj = null;
			try
			{
				if (errorCode != 0 && errorCode != 38)
				{
					asyncResult.ErrorCode = (int)errorCode;
					obj = new HttpListenerException((int)errorCode);
				}
				else
				{
					obj = numBytes;
					if (Logging.On)
					{
						Logging.Dump(Logging.HttpListener, asyncResult, "Callback", (IntPtr)asyncResult.m_pPinnedBuffer, (int)numBytes);
					}
				}
			}
			catch (Exception ex)
			{
				obj = ex;
			}
			asyncResult.InvokeCallback(obj);
		}

		private unsafe static void Callback(uint errorCode, uint numBytes, NativeOverlapped* nativeOverlapped)
		{
			Overlapped overlapped = Overlapped.Unpack(nativeOverlapped);
			HttpRequestStreamAsyncResult asyncResult = overlapped.AsyncResult as HttpRequestStreamAsyncResult;
			IOCompleted(asyncResult, errorCode, numBytes);
		}

		protected unsafe override void Cleanup()
		{
			base.Cleanup();
			if (m_pOverlapped != null)
			{
				Overlapped.Free(m_pOverlapped);
			}
		}
	}

	private HttpListenerContext m_HttpContext;

	private uint m_DataChunkOffset;

	private int m_DataChunkIndex;

	private bool m_Closed;

	internal const int MaxReadSize = 131072;

	private bool m_InOpaqueMode;

	public override bool CanSeek => false;

	public override bool CanWrite => false;

	public override bool CanRead => true;

	internal bool Closed => m_Closed;

	internal bool BufferedDataChunksAvailable => m_DataChunkIndex > -1;

	internal HttpListenerContext InternalHttpContext => m_HttpContext;

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

	internal HttpRequestStream(HttpListenerContext httpContext)
	{
		m_HttpContext = httpContext;
	}

	public override void Flush()
	{
	}

	public override Task FlushAsync(CancellationToken cancellationToken)
	{
		return Task.CompletedTask;
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		throw new NotSupportedException(SR.GetString("net_noseek"));
	}

	public override void SetLength(long value)
	{
		throw new NotSupportedException(SR.GetString("net_noseek"));
	}

	public unsafe override int Read([In][Out] byte[] buffer, int offset, int size)
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.HttpListener, this, "Read", "");
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
		if (size == 0 || m_Closed)
		{
			if (Logging.On)
			{
				Logging.Exit(Logging.HttpListener, this, "Read", "dataRead:0");
			}
			return 0;
		}
		uint num = 0u;
		if (m_DataChunkIndex != -1)
		{
			num = UnsafeNclNativeMethods.HttpApi.GetChunks(m_HttpContext.Request.RequestBuffer, m_HttpContext.Request.OriginalBlobAddress, ref m_DataChunkIndex, ref m_DataChunkOffset, buffer, offset, size);
		}
		if (m_DataChunkIndex == -1 && num < size)
		{
			uint num2 = 0u;
			uint bytesReturned = 0u;
			offset += (int)num;
			size -= (int)num;
			if (size > 131072)
			{
				size = 131072;
			}
			fixed (byte* ptr = buffer)
			{
				uint flags = 0u;
				if (!m_InOpaqueMode)
				{
					flags = 1u;
				}
				num2 = UnsafeNclNativeMethods.HttpApi.HttpReceiveRequestEntityBody(m_HttpContext.RequestQueueHandle, m_HttpContext.RequestId, flags, ptr + offset, (uint)size, out bytesReturned, null);
				num += bytesReturned;
			}
			if (num2 != 0 && num2 != 38)
			{
				Exception ex = new HttpListenerException((int)num2);
				if (Logging.On)
				{
					Logging.Exception(Logging.HttpListener, this, "Read", ex);
				}
				throw ex;
			}
			UpdateAfterRead(num2, num);
		}
		if (Logging.On)
		{
			Logging.Dump(Logging.HttpListener, this, "Read", buffer, offset, (int)num);
		}
		if (Logging.On)
		{
			Logging.Exit(Logging.HttpListener, this, "Read", "dataRead:" + num);
		}
		return (int)num;
	}

	private void UpdateAfterRead(uint statusCode, uint dataRead)
	{
		if (statusCode == 38 || dataRead == 0)
		{
			Close();
		}
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public unsafe override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.HttpListener, this, "BeginRead", "");
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
		if (size == 0 || m_Closed)
		{
			if (Logging.On)
			{
				Logging.Exit(Logging.HttpListener, this, "BeginRead", "");
			}
			HttpRequestStreamAsyncResult httpRequestStreamAsyncResult = new HttpRequestStreamAsyncResult(this, state, callback);
			httpRequestStreamAsyncResult.InvokeCallback(0u);
			return httpRequestStreamAsyncResult;
		}
		HttpRequestStreamAsyncResult httpRequestStreamAsyncResult2 = null;
		uint num = 0u;
		if (m_DataChunkIndex != -1)
		{
			num = UnsafeNclNativeMethods.HttpApi.GetChunks(m_HttpContext.Request.RequestBuffer, m_HttpContext.Request.OriginalBlobAddress, ref m_DataChunkIndex, ref m_DataChunkOffset, buffer, offset, size);
			if (m_DataChunkIndex != -1 && num == size)
			{
				httpRequestStreamAsyncResult2 = new HttpRequestStreamAsyncResult(this, state, callback, buffer, offset, (uint)size, 0u);
				httpRequestStreamAsyncResult2.InvokeCallback(num);
			}
		}
		if (m_DataChunkIndex == -1 && num < size)
		{
			uint num2 = 0u;
			offset += (int)num;
			size -= (int)num;
			if (size > 131072)
			{
				size = 131072;
			}
			httpRequestStreamAsyncResult2 = new HttpRequestStreamAsyncResult(this, state, callback, buffer, offset, (uint)size, num);
			uint bytesReturned;
			try
			{
				fixed (byte* ptr = buffer)
				{
					m_HttpContext.EnsureBoundHandle();
					uint flags = 0u;
					if (!m_InOpaqueMode)
					{
						flags = 1u;
					}
					num2 = UnsafeNclNativeMethods.HttpApi.HttpReceiveRequestEntityBody(m_HttpContext.RequestQueueHandle, m_HttpContext.RequestId, flags, httpRequestStreamAsyncResult2.m_pPinnedBuffer, (uint)size, out bytesReturned, httpRequestStreamAsyncResult2.m_pOverlapped);
				}
			}
			catch (Exception e)
			{
				if (Logging.On)
				{
					Logging.Exception(Logging.HttpListener, this, "BeginRead", e);
				}
				httpRequestStreamAsyncResult2.InternalCleanup();
				throw;
			}
			if (num2 != 0 && num2 != 997)
			{
				httpRequestStreamAsyncResult2.InternalCleanup();
				if (num2 != 38)
				{
					Exception ex = new HttpListenerException((int)num2);
					if (Logging.On)
					{
						Logging.Exception(Logging.HttpListener, this, "BeginRead", ex);
					}
					httpRequestStreamAsyncResult2.InternalCleanup();
					throw ex;
				}
				httpRequestStreamAsyncResult2 = new HttpRequestStreamAsyncResult(this, state, callback, num);
				httpRequestStreamAsyncResult2.InvokeCallback(0u);
			}
			else if (num2 == 0 && HttpListener.SkipIOCPCallbackOnSuccess)
			{
				httpRequestStreamAsyncResult2.IOCompleted(num2, bytesReturned);
			}
		}
		if (Logging.On)
		{
			Logging.Exit(Logging.HttpListener, this, "BeginRead", "");
		}
		return httpRequestStreamAsyncResult2;
	}

	public override int EndRead(IAsyncResult asyncResult)
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.HttpListener, this, "EndRead", "");
		}
		if (asyncResult == null)
		{
			throw new ArgumentNullException("asyncResult");
		}
		if (!(asyncResult is HttpRequestStreamAsyncResult httpRequestStreamAsyncResult) || httpRequestStreamAsyncResult.AsyncObject != this)
		{
			throw new ArgumentException(SR.GetString("net_io_invalidasyncresult"), "asyncResult");
		}
		if (httpRequestStreamAsyncResult.EndCalled)
		{
			throw new InvalidOperationException(SR.GetString("net_io_invalidendcall", "EndRead"));
		}
		httpRequestStreamAsyncResult.EndCalled = true;
		object obj = httpRequestStreamAsyncResult.InternalWaitForCompletion();
		if (obj is Exception ex)
		{
			if (Logging.On)
			{
				Logging.Exception(Logging.HttpListener, this, "EndRead", ex);
			}
			throw ex;
		}
		uint num = (uint)obj;
		UpdateAfterRead((uint)httpRequestStreamAsyncResult.ErrorCode, num);
		if (Logging.On)
		{
			Logging.Exit(Logging.HttpListener, this, "EndRead", "");
		}
		return (int)(num + httpRequestStreamAsyncResult.m_dataAlreadyRead);
	}

	public override void Write(byte[] buffer, int offset, int size)
	{
		throw new InvalidOperationException(SR.GetString("net_readonlystream"));
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
	{
		throw new InvalidOperationException(SR.GetString("net_readonlystream"));
	}

	public override void EndWrite(IAsyncResult asyncResult)
	{
		throw new InvalidOperationException(SR.GetString("net_readonlystream"));
	}

	protected override void Dispose(bool disposing)
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.HttpListener, this, "Dispose", "");
		}
		try
		{
			m_Closed = true;
		}
		finally
		{
			base.Dispose(disposing);
		}
		if (Logging.On)
		{
			Logging.Exit(Logging.HttpListener, this, "Dispose", "");
		}
	}

	internal void SwitchToOpaqueMode()
	{
		m_InOpaqueMode = true;
	}

	internal uint GetChunks(byte[] buffer, int offset, int size)
	{
		return UnsafeNclNativeMethods.HttpApi.GetChunks(m_HttpContext.Request.RequestBuffer, m_HttpContext.Request.OriginalBlobAddress, ref m_DataChunkIndex, ref m_DataChunkOffset, buffer, offset, size);
	}
}
