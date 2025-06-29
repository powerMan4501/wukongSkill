using System.Collections;
using System.Collections.Specialized;
using System.IO;
using Microsoft.Win32;

namespace System.Net.Cache;

internal class SingleItemRequestCache : WinInetCache
{
	private sealed class FrozenCacheEntry : RequestCacheEntry
	{
		private byte[] _StreamBytes;

		private string _Key;

		public byte[] StreamBytes => _StreamBytes;

		public string Key => _Key;

		public FrozenCacheEntry(string key, RequestCacheEntry entry, Stream stream)
			: this(key, entry, GetBytes(stream))
		{
		}

		public FrozenCacheEntry(string key, RequestCacheEntry entry, byte[] streamBytes)
		{
			_Key = key;
			_StreamBytes = streamBytes;
			base.IsPrivateEntry = entry.IsPrivateEntry;
			base.StreamSize = entry.StreamSize;
			base.ExpiresUtc = entry.ExpiresUtc;
			base.HitCount = entry.HitCount;
			base.LastAccessedUtc = entry.LastAccessedUtc;
			entry.LastModifiedUtc = entry.LastModifiedUtc;
			base.LastSynchronizedUtc = entry.LastSynchronizedUtc;
			base.MaxStale = entry.MaxStale;
			base.UsageCount = entry.UsageCount;
			base.IsPartialEntry = entry.IsPartialEntry;
			base.EntryMetadata = entry.EntryMetadata;
			base.SystemMetadata = entry.SystemMetadata;
		}

		private static byte[] GetBytes(Stream stream)
		{
			bool flag = false;
			byte[] array;
			if (stream.CanSeek)
			{
				array = new byte[stream.Length];
			}
			else
			{
				flag = true;
				array = new byte[8192];
			}
			int num = 0;
			while (true)
			{
				int num2 = stream.Read(array, num, array.Length - num);
				if (num2 == 0)
				{
					break;
				}
				if ((num += num2) == array.Length && flag)
				{
					byte[] array2 = new byte[array.Length + 8192];
					Buffer.BlockCopy(array, 0, array2, 0, num);
					array = array2;
				}
			}
			if (flag)
			{
				byte[] array3 = new byte[num];
				Buffer.BlockCopy(array, 0, array3, 0, num);
				array = array3;
			}
			return array;
		}

		public static FrozenCacheEntry Create(FrozenCacheEntry clonedObject)
		{
			if (clonedObject != null)
			{
				return (FrozenCacheEntry)clonedObject.MemberwiseClone();
			}
			return null;
		}
	}

	internal class ReadOnlyStream : Stream, IRequestLifetimeTracker
	{
		private byte[] _Bytes;

		private int _Offset;

		private bool _Disposed;

		private int _ReadTimeout;

		private int _WriteTimeout;

		private RequestLifetimeSetter m_RequestLifetimeSetter;

		public override bool CanRead => true;

		public override bool CanSeek => true;

		public override bool CanTimeout => true;

		public override bool CanWrite => false;

		public override long Length => _Bytes.Length;

		public override long Position
		{
			get
			{
				return _Offset;
			}
			set
			{
				if (value < 0 || value > _Bytes.Length)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				_Offset = (int)value;
			}
		}

		public override int ReadTimeout
		{
			get
			{
				return _ReadTimeout;
			}
			set
			{
				if (value <= 0 && value != -1)
				{
					throw new ArgumentOutOfRangeException("value", SR.GetString("net_io_timeout_use_gt_zero"));
				}
				_ReadTimeout = value;
			}
		}

		public override int WriteTimeout
		{
			get
			{
				return _WriteTimeout;
			}
			set
			{
				if (value <= 0 && value != -1)
				{
					throw new ArgumentOutOfRangeException("value", SR.GetString("net_io_timeout_use_gt_zero"));
				}
				_WriteTimeout = value;
			}
		}

		internal byte[] Buffer => _Bytes;

		internal ReadOnlyStream(byte[] bytes)
		{
			_Bytes = bytes;
			_Offset = 0;
			_Disposed = false;
			_ReadTimeout = (_WriteTimeout = -1);
		}

		public override void Flush()
		{
		}

		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			int num = Read(buffer, offset, count);
			LazyAsyncResult lazyAsyncResult = new LazyAsyncResult(null, state, callback);
			lazyAsyncResult.InvokeCallback(num);
			return lazyAsyncResult;
		}

		public override int EndRead(IAsyncResult asyncResult)
		{
			if (asyncResult == null)
			{
				throw new ArgumentNullException("asyncResult");
			}
			LazyAsyncResult lazyAsyncResult = (LazyAsyncResult)asyncResult;
			if (lazyAsyncResult.EndCalled)
			{
				throw new InvalidOperationException(SR.GetString("net_io_invalidendcall", "EndRead"));
			}
			lazyAsyncResult.EndCalled = true;
			return (int)lazyAsyncResult.InternalWaitForCompletion();
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			if (_Disposed)
			{
				throw new ObjectDisposedException(GetType().Name);
			}
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if (offset < 0 || offset > buffer.Length)
			{
				throw new ArgumentOutOfRangeException("offset");
			}
			if (count < 0 || count > buffer.Length - offset)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			if (_Offset == _Bytes.Length)
			{
				return 0;
			}
			int offset2 = _Offset;
			count = Math.Min(count, _Bytes.Length - offset2);
			System.Buffer.BlockCopy(_Bytes, offset2, buffer, offset, count);
			offset2 += count;
			_Offset = offset2;
			return count;
		}

		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
		{
			throw new NotSupportedException(SR.GetString("net_readonlystream"));
		}

		public override void EndWrite(IAsyncResult asyncResult)
		{
			throw new NotSupportedException(SR.GetString("net_readonlystream"));
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
			throw new NotSupportedException(SR.GetString("net_readonlystream"));
		}

		public override long Seek(long offset, SeekOrigin origin)
		{
			return origin switch
			{
				SeekOrigin.Begin => Position = offset, 
				SeekOrigin.Current => Position += offset, 
				SeekOrigin.End => Position = _Bytes.Length - offset, 
				_ => throw new ArgumentException(SR.GetString("net_invalid_enum", "SeekOrigin"), "origin"), 
			};
		}

		public override void SetLength(long length)
		{
			throw new NotSupportedException(SR.GetString("net_readonlystream"));
		}

		protected override void Dispose(bool disposing)
		{
			try
			{
				if (!_Disposed)
				{
					_Disposed = true;
					if (disposing)
					{
						RequestLifetimeSetter.Report(m_RequestLifetimeSetter);
					}
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		void IRequestLifetimeTracker.TrackRequestLifetime(long requestStartTimestamp)
		{
			m_RequestLifetimeSetter = new RequestLifetimeSetter(requestStartTimestamp);
		}
	}

	private class WriteOnlyStream : Stream
	{
		private string _Key;

		private SingleItemRequestCache _Cache;

		private RequestCacheEntry _TempEntry;

		private Stream _RealStream;

		private long _TotalSize;

		private ArrayList _Buffers;

		private bool _Disposed;

		private int _ReadTimeout;

		private int _WriteTimeout;

		public override bool CanRead => false;

		public override bool CanSeek => false;

		public override bool CanTimeout => true;

		public override bool CanWrite => true;

		public override long Length
		{
			get
			{
				throw new NotSupportedException(SR.GetString("net_writeonlystream"));
			}
		}

		public override long Position
		{
			get
			{
				throw new NotSupportedException(SR.GetString("net_writeonlystream"));
			}
			set
			{
				throw new NotSupportedException(SR.GetString("net_writeonlystream"));
			}
		}

		public override int ReadTimeout
		{
			get
			{
				return _ReadTimeout;
			}
			set
			{
				if (value <= 0 && value != -1)
				{
					throw new ArgumentOutOfRangeException("value", SR.GetString("net_io_timeout_use_gt_zero"));
				}
				_ReadTimeout = value;
			}
		}

		public override int WriteTimeout
		{
			get
			{
				return _WriteTimeout;
			}
			set
			{
				if (value <= 0 && value != -1)
				{
					throw new ArgumentOutOfRangeException("value", SR.GetString("net_io_timeout_use_gt_zero"));
				}
				_WriteTimeout = value;
			}
		}

		public WriteOnlyStream(string key, SingleItemRequestCache cache, RequestCacheEntry cacheEntry, Stream realWriteStream)
		{
			_Key = key;
			_Cache = cache;
			_TempEntry = cacheEntry;
			_RealStream = realWriteStream;
			_Buffers = new ArrayList();
		}

		public override void Flush()
		{
		}

		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			throw new NotSupportedException(SR.GetString("net_writeonlystream"));
		}

		public override int EndRead(IAsyncResult asyncResult)
		{
			throw new NotSupportedException(SR.GetString("net_writeonlystream"));
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			throw new NotSupportedException(SR.GetString("net_writeonlystream"));
		}

		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new NotSupportedException(SR.GetString("net_writeonlystream"));
		}

		public override void SetLength(long length)
		{
			throw new NotSupportedException(SR.GetString("net_writeonlystream"));
		}

		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			Write(buffer, offset, count);
			LazyAsyncResult lazyAsyncResult = new LazyAsyncResult(null, state, callback);
			lazyAsyncResult.InvokeCallback(null);
			return lazyAsyncResult;
		}

		public override void EndWrite(IAsyncResult asyncResult)
		{
			if (asyncResult == null)
			{
				throw new ArgumentNullException("asyncResult");
			}
			LazyAsyncResult lazyAsyncResult = (LazyAsyncResult)asyncResult;
			if (lazyAsyncResult.EndCalled)
			{
				throw new InvalidOperationException(SR.GetString("net_io_invalidendcall", "EndWrite"));
			}
			lazyAsyncResult.EndCalled = true;
			lazyAsyncResult.InternalWaitForCompletion();
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
			if (_Disposed)
			{
				throw new ObjectDisposedException(GetType().Name);
			}
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if (offset < 0 || offset > buffer.Length)
			{
				throw new ArgumentOutOfRangeException("offset");
			}
			if (count < 0 || count > buffer.Length - offset)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			if (_RealStream != null)
			{
				try
				{
					_RealStream.Write(buffer, offset, count);
				}
				catch
				{
					_RealStream.Close();
					_RealStream = null;
				}
			}
			byte[] array = new byte[count];
			Buffer.BlockCopy(buffer, offset, array, 0, count);
			_Buffers.Add(array);
			_TotalSize += count;
		}

		protected override void Dispose(bool disposing)
		{
			_Disposed = true;
			base.Dispose(disposing);
			if (!disposing)
			{
				return;
			}
			if (_RealStream != null)
			{
				try
				{
					_RealStream.Close();
				}
				catch
				{
				}
			}
			byte[] array = new byte[_TotalSize];
			int num = 0;
			for (int i = 0; i < _Buffers.Count; i++)
			{
				byte[] array2 = (byte[])_Buffers[i];
				Buffer.BlockCopy(array2, 0, array, num, array2.Length);
				num += array2.Length;
			}
			_Cache.Commit(_Key, _TempEntry, array);
		}
	}

	private bool _UseWinInet;

	private FrozenCacheEntry _Entry;

	internal SingleItemRequestCache(bool useWinInet)
		: base(isPrivateCache: true, canWrite: true, async: false)
	{
		_UseWinInet = useWinInet;
	}

	internal override Stream Retrieve(string key, out RequestCacheEntry cacheEntry)
	{
		if (!TryRetrieve(key, out cacheEntry, out var readStream))
		{
			FileNotFoundException ex = new FileNotFoundException(null, key);
			throw new IOException(SR.GetString("net_cache_retrieve_failure", ex.Message), ex);
		}
		return readStream;
	}

	internal override Stream Store(string key, long contentLength, DateTime expiresUtc, DateTime lastModifiedUtc, TimeSpan maxStale, StringCollection entryMetadata, StringCollection systemMetadata)
	{
		if (!TryStore(key, contentLength, expiresUtc, lastModifiedUtc, maxStale, entryMetadata, systemMetadata, out var writeStream))
		{
			FileNotFoundException ex = new FileNotFoundException(null, key);
			throw new IOException(SR.GetString("net_cache_retrieve_failure", ex.Message), ex);
		}
		return writeStream;
	}

	internal override void Remove(string key)
	{
		if (!TryRemove(key))
		{
			FileNotFoundException ex = new FileNotFoundException(null, key);
			throw new IOException(SR.GetString("net_cache_retrieve_failure", ex.Message), ex);
		}
	}

	internal override void Update(string key, DateTime expiresUtc, DateTime lastModifiedUtc, DateTime lastSynchronizedUtc, TimeSpan maxStale, StringCollection entryMetadata, StringCollection systemMetadata)
	{
		if (!TryUpdate(key, expiresUtc, lastModifiedUtc, lastSynchronizedUtc, maxStale, entryMetadata, systemMetadata))
		{
			FileNotFoundException ex = new FileNotFoundException(null, key);
			throw new IOException(SR.GetString("net_cache_retrieve_failure", ex.Message), ex);
		}
	}

	internal override bool TryRetrieve(string key, out RequestCacheEntry cacheEntry, out Stream readStream)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		FrozenCacheEntry frozenCacheEntry = _Entry;
		cacheEntry = null;
		readStream = null;
		if (frozenCacheEntry == null || frozenCacheEntry.Key != key)
		{
			if (!_UseWinInet || !base.TryRetrieve(key, out RequestCacheEntry cacheEntry2, out Stream readStream2))
			{
				return false;
			}
			frozenCacheEntry = new FrozenCacheEntry(key, cacheEntry2, readStream2);
			readStream2.Close();
			_Entry = frozenCacheEntry;
		}
		cacheEntry = FrozenCacheEntry.Create(frozenCacheEntry);
		readStream = new ReadOnlyStream(frozenCacheEntry.StreamBytes);
		return true;
	}

	internal override bool TryStore(string key, long contentLength, DateTime expiresUtc, DateTime lastModifiedUtc, TimeSpan maxStale, StringCollection entryMetadata, StringCollection systemMetadata, out Stream writeStream)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		RequestCacheEntry requestCacheEntry = new RequestCacheEntry();
		requestCacheEntry.IsPrivateEntry = base.IsPrivateCache;
		requestCacheEntry.StreamSize = contentLength;
		requestCacheEntry.ExpiresUtc = expiresUtc;
		requestCacheEntry.LastModifiedUtc = lastModifiedUtc;
		requestCacheEntry.LastAccessedUtc = DateTime.UtcNow;
		requestCacheEntry.LastSynchronizedUtc = DateTime.UtcNow;
		requestCacheEntry.MaxStale = maxStale;
		requestCacheEntry.HitCount = 0;
		requestCacheEntry.UsageCount = 0;
		requestCacheEntry.IsPartialEntry = false;
		requestCacheEntry.EntryMetadata = entryMetadata;
		requestCacheEntry.SystemMetadata = systemMetadata;
		writeStream = null;
		Stream writeStream2 = null;
		if (_UseWinInet)
		{
			base.TryStore(key, contentLength, expiresUtc, lastModifiedUtc, maxStale, entryMetadata, systemMetadata, out writeStream2);
		}
		writeStream = new WriteOnlyStream(key, this, requestCacheEntry, writeStream2);
		return true;
	}

	private void Commit(string key, RequestCacheEntry tempEntry, byte[] allBytes)
	{
		FrozenCacheEntry entry = new FrozenCacheEntry(key, tempEntry, allBytes);
		_Entry = entry;
	}

	internal override bool TryRemove(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (_UseWinInet)
		{
			base.TryRemove(key);
		}
		FrozenCacheEntry entry = _Entry;
		if (entry != null && entry.Key == key)
		{
			_Entry = null;
		}
		return true;
	}

	internal override bool TryUpdate(string key, DateTime expiresUtc, DateTime lastModifiedUtc, DateTime lastSynchronizedUtc, TimeSpan maxStale, StringCollection entryMetadata, StringCollection systemMetadata)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		FrozenCacheEntry frozenCacheEntry = FrozenCacheEntry.Create(_Entry);
		if (frozenCacheEntry == null || frozenCacheEntry.Key != key)
		{
			return true;
		}
		frozenCacheEntry.ExpiresUtc = expiresUtc;
		frozenCacheEntry.LastModifiedUtc = lastModifiedUtc;
		frozenCacheEntry.LastSynchronizedUtc = lastSynchronizedUtc;
		frozenCacheEntry.MaxStale = maxStale;
		frozenCacheEntry.EntryMetadata = entryMetadata;
		frozenCacheEntry.SystemMetadata = systemMetadata;
		_Entry = frozenCacheEntry;
		return true;
	}

	internal override void UnlockEntry(Stream stream)
	{
	}
}
