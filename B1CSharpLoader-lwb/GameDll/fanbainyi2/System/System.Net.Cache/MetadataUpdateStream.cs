using System.Collections.Specialized;
using System.IO;
using System.Threading;

namespace System.Net.Cache;

internal class MetadataUpdateStream : BaseWrapperStream, ICloseEx
{
	private RequestCache m_Cache;

	private string m_Key;

	private DateTime m_Expires;

	private DateTime m_LastModified;

	private DateTime m_LastSynchronized;

	private TimeSpan m_MaxStale;

	private StringCollection m_EntryMetadata;

	private StringCollection m_SystemMetadata;

	private bool m_CacheDestroy;

	private bool m_IsStrictCacheErrors;

	private int _Disposed;

	public override bool CanRead => base.WrappedStream.CanRead;

	public override bool CanSeek => base.WrappedStream.CanSeek;

	public override bool CanWrite => base.WrappedStream.CanWrite;

	public override long Length => base.WrappedStream.Length;

	public override long Position
	{
		get
		{
			return base.WrappedStream.Position;
		}
		set
		{
			base.WrappedStream.Position = value;
		}
	}

	public override bool CanTimeout => base.WrappedStream.CanTimeout;

	public override int ReadTimeout
	{
		get
		{
			return base.WrappedStream.ReadTimeout;
		}
		set
		{
			base.WrappedStream.ReadTimeout = value;
		}
	}

	public override int WriteTimeout
	{
		get
		{
			return base.WrappedStream.WriteTimeout;
		}
		set
		{
			base.WrappedStream.WriteTimeout = value;
		}
	}

	internal MetadataUpdateStream(Stream parentStream, RequestCache cache, string key, DateTime expiresGMT, DateTime lastModifiedGMT, DateTime lastSynchronizedGMT, TimeSpan maxStale, StringCollection entryMetadata, StringCollection systemMetadata, bool isStrictCacheErrors)
		: base(parentStream)
	{
		m_Cache = cache;
		m_Key = key;
		m_Expires = expiresGMT;
		m_LastModified = lastModifiedGMT;
		m_LastSynchronized = lastSynchronizedGMT;
		m_MaxStale = maxStale;
		m_EntryMetadata = entryMetadata;
		m_SystemMetadata = systemMetadata;
		m_IsStrictCacheErrors = isStrictCacheErrors;
	}

	private MetadataUpdateStream(Stream parentStream, RequestCache cache, string key, bool isStrictCacheErrors)
		: base(parentStream)
	{
		m_Cache = cache;
		m_Key = key;
		m_CacheDestroy = true;
		m_IsStrictCacheErrors = isStrictCacheErrors;
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		return base.WrappedStream.Seek(offset, origin);
	}

	public override void SetLength(long value)
	{
		base.WrappedStream.SetLength(value);
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		base.WrappedStream.Write(buffer, offset, count);
	}

	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
	{
		return base.WrappedStream.BeginWrite(buffer, offset, count, callback, state);
	}

	public override void EndWrite(IAsyncResult asyncResult)
	{
		base.WrappedStream.EndWrite(asyncResult);
	}

	public override void Flush()
	{
		base.WrappedStream.Flush();
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		return base.WrappedStream.Read(buffer, offset, count);
	}

	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
	{
		return base.WrappedStream.BeginRead(buffer, offset, count, callback, state);
	}

	public override int EndRead(IAsyncResult asyncResult)
	{
		return base.WrappedStream.EndRead(asyncResult);
	}

	protected sealed override void Dispose(bool disposing)
	{
		Dispose(disposing, CloseExState.Normal);
	}

	void ICloseEx.CloseEx(CloseExState closeState)
	{
		Dispose(disposing: true, closeState);
	}

	protected virtual void Dispose(bool disposing, CloseExState closeState)
	{
		try
		{
			if (Interlocked.Increment(ref _Disposed) != 1 || !disposing)
			{
				return;
			}
			if (base.WrappedStream is ICloseEx closeEx)
			{
				closeEx.CloseEx(closeState);
			}
			else
			{
				base.WrappedStream.Close();
			}
			if (m_CacheDestroy)
			{
				if (m_IsStrictCacheErrors)
				{
					m_Cache.Remove(m_Key);
				}
				else
				{
					m_Cache.TryRemove(m_Key);
				}
			}
			else if (m_IsStrictCacheErrors)
			{
				m_Cache.Update(m_Key, m_Expires, m_LastModified, m_LastSynchronized, m_MaxStale, m_EntryMetadata, m_SystemMetadata);
			}
			else
			{
				m_Cache.TryUpdate(m_Key, m_Expires, m_LastModified, m_LastSynchronized, m_MaxStale, m_EntryMetadata, m_SystemMetadata);
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}
}
