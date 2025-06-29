using System.IO;

namespace System.Net;

internal sealed class SyncMemoryStream : MemoryStream, IRequestLifetimeTracker
{
	private int m_ReadTimeout;

	private int m_WriteTimeout;

	private RequestLifetimeSetter m_RequestLifetimeSetter;

	private bool m_Disposed;

	public override bool CanTimeout => true;

	public override int ReadTimeout
	{
		get
		{
			return m_ReadTimeout;
		}
		set
		{
			m_ReadTimeout = value;
		}
	}

	public override int WriteTimeout
	{
		get
		{
			return m_WriteTimeout;
		}
		set
		{
			m_WriteTimeout = value;
		}
	}

	internal SyncMemoryStream(byte[] bytes)
		: base(bytes, writable: false)
	{
		m_ReadTimeout = (m_WriteTimeout = -1);
	}

	internal SyncMemoryStream(int initialCapacity)
		: base(initialCapacity)
	{
		m_ReadTimeout = (m_WriteTimeout = -1);
	}

	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
	{
		int num = Read(buffer, offset, count);
		return new LazyAsyncResult(null, state, callback, num);
	}

	public override int EndRead(IAsyncResult asyncResult)
	{
		LazyAsyncResult lazyAsyncResult = (LazyAsyncResult)asyncResult;
		return (int)lazyAsyncResult.InternalWaitForCompletion();
	}

	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
	{
		Write(buffer, offset, count);
		return new LazyAsyncResult(null, state, callback, null);
	}

	public override void EndWrite(IAsyncResult asyncResult)
	{
		LazyAsyncResult lazyAsyncResult = (LazyAsyncResult)asyncResult;
		lazyAsyncResult.InternalWaitForCompletion();
	}

	public void TrackRequestLifetime(long requestStartTimestamp)
	{
		m_RequestLifetimeSetter = new RequestLifetimeSetter(requestStartTimestamp);
	}

	protected override void Dispose(bool disposing)
	{
		if (!m_Disposed)
		{
			m_Disposed = true;
			if (disposing)
			{
				RequestLifetimeSetter.Report(m_RequestLifetimeSetter);
			}
			base.Dispose(disposing);
		}
	}
}
