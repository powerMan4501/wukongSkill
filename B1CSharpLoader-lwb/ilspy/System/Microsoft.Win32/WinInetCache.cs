using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Cache;
using System.Security.Permissions;
using System.Text;
using System.Threading;

namespace Microsoft.Win32;

internal class WinInetCache : RequestCache
{
	private class ReadStream : FileStream, ICloseEx, IRequestLifetimeTracker
	{
		private string m_Key;

		private int m_ReadTimeout;

		private int m_WriteTimeout;

		private SafeUnlockUrlCacheEntryFile m_Handle;

		private int m_Disposed;

		private int m_CallNesting;

		private ManualResetEvent m_Event;

		private bool m_Aborted;

		private RequestLifetimeSetter m_RequestLifetimeSetter;

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

		[FileIOPermission(SecurityAction.Assert, Unrestricted = true)]
		internal ReadStream(_WinInetCache.Entry entry, SafeUnlockUrlCacheEntryFile handle, bool async)
			: base(entry.Filename, FileMode.Open, FileAccess.Read, FileShare.Read | FileShare.Delete, 4096, async)
		{
			m_Key = entry.Key;
			m_Handle = handle;
			m_ReadTimeout = (m_WriteTimeout = -1);
		}

		internal void UnlockEntry()
		{
			m_Handle.Close();
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			lock (m_Handle)
			{
				try
				{
					if (m_CallNesting != 0)
					{
						throw new NotSupportedException(SR.GetString("net_no_concurrent_io_allowed"));
					}
					if (m_Aborted)
					{
						throw ExceptionHelper.RequestAbortedException;
					}
					if (m_Event != null)
					{
						throw new ObjectDisposedException(GetType().FullName);
					}
					m_CallNesting = 1;
					return base.Read(buffer, offset, count);
				}
				finally
				{
					m_CallNesting = 0;
					if (m_Event != null)
					{
						m_Event.Set();
					}
				}
			}
		}

		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			lock (m_Handle)
			{
				if (m_CallNesting != 0)
				{
					throw new NotSupportedException(SR.GetString("net_no_concurrent_io_allowed"));
				}
				if (m_Aborted)
				{
					throw ExceptionHelper.RequestAbortedException;
				}
				if (m_Event != null)
				{
					throw new ObjectDisposedException(GetType().FullName);
				}
				m_CallNesting = 1;
				try
				{
					return base.BeginRead(buffer, offset, count, callback, state);
				}
				catch
				{
					m_CallNesting = 0;
					throw;
				}
			}
		}

		public override int EndRead(IAsyncResult asyncResult)
		{
			lock (m_Handle)
			{
				try
				{
					return base.EndRead(asyncResult);
				}
				finally
				{
					m_CallNesting = 0;
					if (m_Event != null)
					{
						try
						{
							m_Event.Set();
						}
						catch
						{
						}
					}
				}
			}
		}

		public void CloseEx(CloseExState closeState)
		{
			if ((closeState & CloseExState.Abort) != CloseExState.Normal)
			{
				m_Aborted = true;
			}
			try
			{
				Close();
			}
			catch
			{
				if ((closeState & CloseExState.Silent) == 0)
				{
					throw;
				}
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (Interlocked.Exchange(ref m_Disposed, 1) != 0)
			{
				return;
			}
			if (!disposing)
			{
				base.Dispose(disposing: false);
			}
			else
			{
				if (m_Key == null)
				{
					return;
				}
				try
				{
					lock (m_Handle)
					{
						if (m_CallNesting == 0)
						{
							base.Dispose(disposing: true);
						}
						else
						{
							m_Event = new ManualResetEvent(initialState: false);
						}
					}
					RequestLifetimeSetter.Report(m_RequestLifetimeSetter);
					if (m_Event == null)
					{
						return;
					}
					using (m_Event)
					{
						m_Event.WaitOne();
						lock (m_Handle)
						{
						}
					}
					base.Dispose(disposing: true);
				}
				finally
				{
					if (Logging.On)
					{
						Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_key", "WinInetReadStream.Close()", m_Key));
					}
					m_Handle.Close();
				}
			}
		}

		void IRequestLifetimeTracker.TrackRequestLifetime(long requestStartTimestamp)
		{
			m_RequestLifetimeSetter = new RequestLifetimeSetter(requestStartTimestamp);
		}
	}

	private class WriteStream : FileStream, ICloseEx
	{
		private _WinInetCache.Entry m_Entry;

		private bool m_IsThrow;

		private long m_StreamSize;

		private bool m_Aborted;

		private int m_ReadTimeout;

		private int m_WriteTimeout;

		private int m_Disposed;

		private int m_CallNesting;

		private ManualResetEvent m_Event;

		private bool m_OneWriteSucceeded;

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

		[FileIOPermission(SecurityAction.Assert, Unrestricted = true)]
		internal WriteStream(_WinInetCache.Entry entry, bool isThrow, long streamSize, bool async)
			: base(entry.Filename, FileMode.Create, FileAccess.ReadWrite, FileShare.None, 4096, async)
		{
			m_Entry = entry;
			m_IsThrow = isThrow;
			m_StreamSize = streamSize;
			m_OneWriteSucceeded = streamSize == 0;
			m_ReadTimeout = (m_WriteTimeout = -1);
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
			lock (m_Entry)
			{
				if (m_Aborted)
				{
					throw ExceptionHelper.RequestAbortedException;
				}
				if (m_Event != null)
				{
					throw new ObjectDisposedException(GetType().FullName);
				}
				m_CallNesting = 1;
				try
				{
					base.Write(buffer, offset, count);
					if (m_StreamSize > 0)
					{
						m_StreamSize -= count;
					}
					if (!m_OneWriteSucceeded && count != 0)
					{
						m_OneWriteSucceeded = true;
					}
				}
				catch
				{
					m_Aborted = true;
					throw;
				}
				finally
				{
					m_CallNesting = 0;
					if (m_Event != null)
					{
						m_Event.Set();
					}
				}
			}
		}

		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			lock (m_Entry)
			{
				if (m_CallNesting != 0)
				{
					throw new NotSupportedException(SR.GetString("net_no_concurrent_io_allowed"));
				}
				if (m_Aborted)
				{
					throw ExceptionHelper.RequestAbortedException;
				}
				if (m_Event != null)
				{
					throw new ObjectDisposedException(GetType().FullName);
				}
				m_CallNesting = 1;
				try
				{
					if (m_StreamSize > 0)
					{
						m_StreamSize -= count;
					}
					return base.BeginWrite(buffer, offset, count, callback, state);
				}
				catch
				{
					m_Aborted = true;
					m_CallNesting = 0;
					throw;
				}
			}
		}

		public override void EndWrite(IAsyncResult asyncResult)
		{
			lock (m_Entry)
			{
				try
				{
					base.EndWrite(asyncResult);
					if (!m_OneWriteSucceeded)
					{
						m_OneWriteSucceeded = true;
					}
				}
				catch
				{
					m_Aborted = true;
					throw;
				}
				finally
				{
					m_CallNesting = 0;
					if (m_Event != null)
					{
						try
						{
							m_Event.Set();
						}
						catch
						{
						}
					}
				}
			}
		}

		public void CloseEx(CloseExState closeState)
		{
			if ((closeState & CloseExState.Abort) != CloseExState.Normal)
			{
				m_Aborted = true;
			}
			try
			{
				Close();
			}
			catch
			{
				if ((closeState & CloseExState.Silent) == 0)
				{
					throw;
				}
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (Interlocked.Exchange(ref m_Disposed, 1) != 0 || m_Entry == null)
			{
				return;
			}
			lock (m_Entry)
			{
				if (m_CallNesting == 0)
				{
					base.Dispose(disposing);
				}
				else
				{
					m_Event = new ManualResetEvent(initialState: false);
				}
			}
			if (disposing && m_Event != null)
			{
				using (m_Event)
				{
					m_Event.WaitOne();
					lock (m_Entry)
					{
					}
				}
				base.Dispose(disposing);
			}
			TriState triState = ((m_StreamSize < 0) ? ((!m_Aborted) ? TriState.True : (m_OneWriteSucceeded ? TriState.Unspecified : TriState.False)) : (m_OneWriteSucceeded ? ((m_StreamSize <= 0) ? TriState.True : TriState.Unspecified) : TriState.False));
			if (triState == TriState.False)
			{
				try
				{
					if (Logging.On)
					{
						Logging.PrintWarning(Logging.RequestCache, SR.GetString("net_log_cache_no_commit", "WinInetWriteStream.Close()"));
					}
					File.Delete(m_Entry.Filename);
					return;
				}
				catch (Exception ex)
				{
					if (ex is ThreadAbortException || ex is StackOverflowException || ex is OutOfMemoryException)
					{
						throw;
					}
					if (Logging.On)
					{
						Logging.PrintError(Logging.RequestCache, SR.GetString("net_log_cache_error_deleting_filename", "WinInetWriteStream.Close()", m_Entry.Filename));
					}
					return;
				}
				finally
				{
					_WinInetCache.Status status = _WinInetCache.Remove(m_Entry);
					if (status != _WinInetCache.Status.Success && status != _WinInetCache.Status.FileNotFound && Logging.On)
					{
						Logging.PrintWarning(Logging.RequestCache, SR.GetString("net_log_cache_delete_failed", "WinInetWriteStream.Close()", m_Entry.Key, new Win32Exception((int)m_Entry.Error).Message));
					}
					m_Entry = null;
				}
			}
			m_Entry.OriginalUrl = null;
			if (triState == TriState.Unspecified)
			{
				if (m_Entry.MetaInfo == null || m_Entry.MetaInfo.Length == 0 || (m_Entry.MetaInfo != "\r\n" && m_Entry.MetaInfo.IndexOf("\r\n\r\n", StringComparison.Ordinal) == -1))
				{
					m_Entry.MetaInfo = "\r\n~SPARSE_ENTRY:\r\n";
				}
				else
				{
					m_Entry.MetaInfo += "~SPARSE_ENTRY:\r\n";
				}
			}
			if (_WinInetCache.Commit(m_Entry) != _WinInetCache.Status.Success)
			{
				if (Logging.On)
				{
					Logging.PrintError(Logging.RequestCache, SR.GetString("net_log_cache_commit_failed", "WinInetWriteStream.Close()", m_Entry.Key, new Win32Exception((int)m_Entry.Error).Message));
				}
				try
				{
					File.Delete(m_Entry.Filename);
				}
				catch (Exception ex2)
				{
					if (ex2 is ThreadAbortException || ex2 is StackOverflowException || ex2 is OutOfMemoryException)
					{
						throw;
					}
					if (Logging.On)
					{
						Logging.PrintError(Logging.RequestCache, SR.GetString("net_log_cache_error_deleting_filename", "WinInetWriteStream.Close()", m_Entry.Filename));
					}
				}
				if (m_IsThrow)
				{
					Win32Exception ex3 = new Win32Exception((int)m_Entry.Error);
					throw new IOException(SR.GetString("net_cache_retrieve_failure", ex3.Message), ex3);
				}
				return;
			}
			if (Logging.On)
			{
				if (m_StreamSize > 0 || (m_StreamSize < 0 && m_Aborted))
				{
					Logging.PrintWarning(Logging.RequestCache, SR.GetString("net_log_cache_committed_as_partial", "WinInetWriteStream.Close()", m_Entry.Key, (m_StreamSize > 0) ? m_StreamSize.ToString(CultureInfo.CurrentCulture) : SR.GetString("net_log_unknown")));
				}
				Logging.PrintInfo(Logging.RequestCache, "WinInetWriteStream.Close(), Key = " + m_Entry.Key + ", Commit Status = " + m_Entry.Error);
			}
			if ((m_Entry.Info.EntryType & _WinInetCache.EntryType.StickyEntry) == _WinInetCache.EntryType.StickyEntry)
			{
				if (_WinInetCache.Update(m_Entry, _WinInetCache.Entry_FC.ExemptDelta) != _WinInetCache.Status.Success)
				{
					if (Logging.On)
					{
						Logging.PrintError(Logging.RequestCache, SR.GetString("net_log_cache_update_failed", "WinInetWriteStream.Close(), Key = " + m_Entry.Key, new Win32Exception((int)m_Entry.Error).Message));
					}
					if (m_IsThrow)
					{
						Win32Exception ex4 = new Win32Exception((int)m_Entry.Error);
						throw new IOException(SR.GetString("net_cache_retrieve_failure", ex4.Message), ex4);
					}
					return;
				}
				if (Logging.On)
				{
					Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_max_stale_and_update_status", "WinInetWriteFile.Close()", m_Entry.Info.U.ExemptDelta, m_Entry.Error.ToString()));
				}
			}
			base.Dispose(disposing);
		}
	}

	private const int _MaximumResponseHeadersLength = int.MaxValue;

	private bool async;

	internal const string c_SPARSE_ENTRY_HACK = "~SPARSE_ENTRY:";

	private static readonly DateTime s_MinDateTimeUtcForFileTimeUtc = DateTime.FromFileTimeUtc(0L);

	internal static readonly TimeSpan s_MaxTimeSpanForInt32 = TimeSpan.FromSeconds(2147483647.0);

	internal WinInetCache(bool isPrivateCache, bool canWrite, bool async)
		: base(isPrivateCache, canWrite)
	{
		this.async = async;
	}

	internal override Stream Retrieve(string key, out RequestCacheEntry cacheEntry)
	{
		return Lookup(key, out cacheEntry, isThrow: true);
	}

	internal override bool TryRetrieve(string key, out RequestCacheEntry cacheEntry, out Stream readStream)
	{
		readStream = Lookup(key, out cacheEntry, isThrow: false);
		if (readStream == null)
		{
			return false;
		}
		return true;
	}

	internal override Stream Store(string key, long contentLength, DateTime expiresUtc, DateTime lastModifiedUtc, TimeSpan maxStale, StringCollection entryMetadata, StringCollection systemMetadata)
	{
		return GetWriteStream(key, contentLength, expiresUtc, lastModifiedUtc, maxStale, entryMetadata, systemMetadata, isThrow: true);
	}

	internal override bool TryStore(string key, long contentLength, DateTime expiresUtc, DateTime lastModifiedUtc, TimeSpan maxStale, StringCollection entryMetadata, StringCollection systemMetadata, out Stream writeStream)
	{
		writeStream = GetWriteStream(key, contentLength, expiresUtc, lastModifiedUtc, maxStale, entryMetadata, systemMetadata, isThrow: false);
		if (writeStream == null)
		{
			return false;
		}
		return true;
	}

	internal override void Remove(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (!base.CanWrite)
		{
			if (Logging.On)
			{
				Logging.PrintError(Logging.RequestCache, SR.GetString("net_log_operation_failed_with_error", "WinInetCache.Remove()", SR.GetString("net_cache_access_denied", "Write")));
			}
			return;
		}
		_WinInetCache.Entry entry = new _WinInetCache.Entry(key, int.MaxValue);
		if (_WinInetCache.Remove(entry) != _WinInetCache.Status.Success && entry.Error != _WinInetCache.Status.FileNotFound)
		{
			Win32Exception ex = new Win32Exception((int)entry.Error);
			if (Logging.On)
			{
				Logging.PrintError(Logging.RequestCache, SR.GetString("net_log_cache_cannot_remove", "WinInetCache.Remove()", key, ex.Message));
			}
			throw new IOException(SR.GetString("net_cache_retrieve_failure", ex.Message), ex);
		}
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_key_status", "WinInetCache.Remove(), ", key, entry.Error.ToString()));
		}
	}

	internal override bool TryRemove(string key)
	{
		return TryRemove(key, forceRemove: false);
	}

	internal bool TryRemove(string key, bool forceRemove)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (!base.CanWrite)
		{
			if (Logging.On)
			{
				Logging.PrintError(Logging.RequestCache, SR.GetString("net_log_operation_failed_with_error", "WinInetCache.TryRemove()", SR.GetString("net_cache_access_denied", "Write")));
			}
			return false;
		}
		_WinInetCache.Entry entry = new _WinInetCache.Entry(key, int.MaxValue);
		if (_WinInetCache.Remove(entry) == _WinInetCache.Status.Success || entry.Error == _WinInetCache.Status.FileNotFound)
		{
			if (Logging.On)
			{
				Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_key_status", "WinInetCache.TryRemove()", key, entry.Error.ToString()));
			}
			return true;
		}
		if (!forceRemove)
		{
			if (Logging.On)
			{
				Logging.PrintWarning(Logging.RequestCache, SR.GetString("net_log_cache_key_remove_failed_status", "WinInetCache.TryRemove()", key, entry.Error.ToString()));
			}
			return false;
		}
		if (_WinInetCache.LookupInfo(entry) == _WinInetCache.Status.Success)
		{
			while (entry.Info.UseCount != 0)
			{
				if (Logging.On)
				{
					Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_key_status", "WinInetCache.TryRemove()", key, entry.Error.ToString()));
				}
				if (Logging.On)
				{
					Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_usecount_file", "WinInetCache.TryRemove()", entry.Info.UseCount, entry.Filename));
				}
				if (!UnsafeNclNativeMethods.UnsafeWinInetCache.UnlockUrlCacheEntryFileW(key, 0))
				{
					break;
				}
				_WinInetCache.Status status = _WinInetCache.LookupInfo(entry);
			}
		}
		_WinInetCache.Remove(entry);
		if (entry.Error != _WinInetCache.Status.Success && _WinInetCache.LookupInfo(entry) == _WinInetCache.Status.FileNotFound)
		{
			entry.Error = _WinInetCache.Status.Success;
		}
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_key_status", "WinInetCache.TryRemove()", key, entry.Error.ToString()));
		}
		return entry.Error == _WinInetCache.Status.Success;
	}

	internal override void Update(string key, DateTime expiresUtc, DateTime lastModifiedUtc, DateTime lastSynchronizedUtc, TimeSpan maxStale, StringCollection entryMetadata, StringCollection systemMetadata)
	{
		UpdateInfo(key, expiresUtc, lastModifiedUtc, lastSynchronizedUtc, maxStale, entryMetadata, systemMetadata, isThrow: true);
	}

	internal override bool TryUpdate(string key, DateTime expiresUtc, DateTime lastModifiedUtc, DateTime lastSynchronizedUtc, TimeSpan maxStale, StringCollection entryMetadata, StringCollection systemMetadata)
	{
		return UpdateInfo(key, expiresUtc, lastModifiedUtc, lastSynchronizedUtc, maxStale, entryMetadata, systemMetadata, isThrow: false);
	}

	internal override void UnlockEntry(Stream stream)
	{
		ReadStream readStream = stream as ReadStream;
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_stream", "WinInetCache.UnlockEntry", (stream == null) ? "<null>" : stream.GetType().FullName));
		}
		readStream?.UnlockEntry();
	}

	private unsafe Stream Lookup(string key, out RequestCacheEntry cacheEntry, bool isThrow)
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.RequestCache, "WinInetCache.Retrieve", "key = " + key);
		}
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		Stream stream = Stream.Null;
		SafeUnlockUrlCacheEntryFile safeUnlockUrlCacheEntryFile = null;
		_WinInetCache.Entry entry = new _WinInetCache.Entry(key, int.MaxValue);
		try
		{
			safeUnlockUrlCacheEntryFile = _WinInetCache.LookupFile(entry);
			if (entry.Error == _WinInetCache.Status.Success)
			{
				if (Logging.On)
				{
					Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_filename", "WinInetCache.Retrieve()", entry.Filename, entry.Error));
				}
				cacheEntry = new RequestCacheEntry(entry, base.IsPrivateCache);
				if (entry.MetaInfo != null && entry.MetaInfo.Length != 0)
				{
					int num = 0;
					int length = entry.MetaInfo.Length;
					StringCollection stringCollection = new StringCollection();
					fixed (char* metaInfo = entry.MetaInfo)
					{
						for (int i = 0; i < length; i++)
						{
							if (i == num && i + 2 < length && metaInfo[i] == '~' && (metaInfo[i + 1] == 'U' || metaInfo[i + 1] == 'u') && metaInfo[i + 2] == ':')
							{
								while (i < length && metaInfo[++i] != '\n')
								{
								}
								num = i + 1;
							}
							else if (i + 1 == length || metaInfo[i] == '\n')
							{
								string text = entry.MetaInfo.Substring(num, ((metaInfo[i - 1] == '\r') ? (i - 1) : (i + 1)) - num);
								if (text.Length == 0 && cacheEntry.EntryMetadata == null)
								{
									cacheEntry.EntryMetadata = stringCollection;
									stringCollection = new StringCollection();
								}
								else if (cacheEntry.EntryMetadata != null && text.StartsWith("~SPARSE_ENTRY:", StringComparison.Ordinal))
								{
									cacheEntry.IsPartialEntry = true;
								}
								else
								{
									stringCollection.Add(text);
								}
								num = i + 1;
							}
						}
					}
					if (cacheEntry.EntryMetadata == null)
					{
						cacheEntry.EntryMetadata = stringCollection;
					}
					else
					{
						cacheEntry.SystemMetadata = stringCollection;
					}
				}
				stream = new ReadStream(entry, safeUnlockUrlCacheEntryFile, async);
			}
			else
			{
				safeUnlockUrlCacheEntryFile?.Close();
				cacheEntry = new RequestCacheEntry();
				cacheEntry.IsPrivateEntry = base.IsPrivateCache;
				if (entry.Error != _WinInetCache.Status.FileNotFound)
				{
					if (Logging.On)
					{
						Logging.PrintError(Logging.RequestCache, SR.GetString("net_log_cache_lookup_failed", "WinInetCache.Retrieve()", new Win32Exception((int)entry.Error).Message));
					}
					if (Logging.On)
					{
						Logging.Exit(Logging.RequestCache, "WinInetCache.Retrieve()");
					}
					if (isThrow)
					{
						Win32Exception ex = new Win32Exception((int)entry.Error);
						throw new IOException(SR.GetString("net_cache_retrieve_failure", ex.Message), ex);
					}
					return null;
				}
			}
		}
		catch (Exception ex2)
		{
			if (ex2 is ThreadAbortException || ex2 is StackOverflowException || ex2 is OutOfMemoryException)
			{
				throw;
			}
			if (Logging.On)
			{
				Logging.PrintError(Logging.RequestCache, SR.GetString("net_log_cache_exception", "WinInetCache.Retrieve()", ex2.ToString()));
			}
			if (Logging.On)
			{
				Logging.Exit(Logging.RequestCache, "WinInetCache.Retrieve()");
			}
			safeUnlockUrlCacheEntryFile?.Close();
			stream.Close();
			stream = Stream.Null;
			cacheEntry = new RequestCacheEntry();
			cacheEntry.IsPrivateEntry = base.IsPrivateCache;
			if (isThrow)
			{
				throw;
			}
			return null;
		}
		if (Logging.On)
		{
			Logging.Exit(Logging.RequestCache, "WinInetCache.Retrieve()", "Status = " + entry.Error);
		}
		return stream;
	}

	private string CombineMetaInfo(StringCollection entryMetadata, StringCollection systemMetadata)
	{
		if ((entryMetadata == null || entryMetadata.Count == 0) && (systemMetadata == null || systemMetadata.Count == 0))
		{
			return string.Empty;
		}
		StringBuilder stringBuilder = new StringBuilder(100);
		if (entryMetadata != null && entryMetadata.Count != 0)
		{
			for (int i = 0; i < entryMetadata.Count; i++)
			{
				if (entryMetadata[i] != null && entryMetadata[i].Length != 0)
				{
					stringBuilder.Append(entryMetadata[i]).Append("\r\n");
				}
			}
		}
		if (systemMetadata != null && systemMetadata.Count != 0)
		{
			stringBuilder.Append("\r\n");
			for (int i = 0; i < systemMetadata.Count; i++)
			{
				if (systemMetadata[i] != null && systemMetadata[i].Length != 0)
				{
					stringBuilder.Append(systemMetadata[i]).Append("\r\n");
				}
			}
		}
		return stringBuilder.ToString();
	}

	private Stream GetWriteStream(string key, long contentLength, DateTime expiresUtc, DateTime lastModifiedUtc, TimeSpan maxStale, StringCollection entryMetadata, StringCollection systemMetadata, bool isThrow)
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.RequestCache, "WinInetCache.Store()", "Key = " + key);
		}
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (!base.CanWrite)
		{
			if (Logging.On)
			{
				Logging.PrintError(Logging.RequestCache, SR.GetString("net_log_operation_failed_with_error", "WinInetCache.Store()", SR.GetString("net_cache_access_denied", "Write")));
			}
			if (Logging.On)
			{
				Logging.Exit(Logging.RequestCache, "WinInetCache.Store");
			}
			if (isThrow)
			{
				throw new InvalidOperationException(SR.GetString("net_cache_access_denied", "Write"));
			}
			return null;
		}
		_WinInetCache.Entry entry = new _WinInetCache.Entry(key, int.MaxValue);
		entry.Key = key;
		entry.OptionalLength = (int)((contentLength >= 0) ? ((contentLength > int.MaxValue) ? int.MaxValue : contentLength) : 0);
		entry.Info.ExpireTime = _WinInetCache.FILETIME.Zero;
		if (expiresUtc != DateTime.MinValue && expiresUtc > s_MinDateTimeUtcForFileTimeUtc)
		{
			entry.Info.ExpireTime = new _WinInetCache.FILETIME(expiresUtc.ToFileTimeUtc());
		}
		entry.Info.LastModifiedTime = _WinInetCache.FILETIME.Zero;
		if (lastModifiedUtc != DateTime.MinValue && lastModifiedUtc > s_MinDateTimeUtcForFileTimeUtc)
		{
			entry.Info.LastModifiedTime = new _WinInetCache.FILETIME(lastModifiedUtc.ToFileTimeUtc());
		}
		entry.Info.EntryType = _WinInetCache.EntryType.NormalEntry;
		if (maxStale > TimeSpan.Zero)
		{
			if (maxStale >= s_MaxTimeSpanForInt32)
			{
				maxStale = s_MaxTimeSpanForInt32;
			}
			entry.Info.U.ExemptDelta = (int)maxStale.TotalSeconds;
			entry.Info.EntryType = _WinInetCache.EntryType.StickyEntry;
		}
		entry.MetaInfo = CombineMetaInfo(entryMetadata, systemMetadata);
		entry.FileExt = "cache";
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_expected_length", entry.OptionalLength));
			Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_last_modified", entry.Info.LastModifiedTime.IsNull ? "0" : DateTime.FromFileTimeUtc(entry.Info.LastModifiedTime.ToLong()).ToString("r")));
			Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_expires", entry.Info.ExpireTime.IsNull ? "0" : DateTime.FromFileTimeUtc(entry.Info.ExpireTime.ToLong()).ToString("r")));
			Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_max_stale", (maxStale > TimeSpan.Zero) ? ((int)maxStale.TotalSeconds).ToString() : "n/a"));
			if (Logging.IsVerbose(Logging.RequestCache))
			{
				Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_dumping_metadata"));
				if (entry.MetaInfo.Length == 0)
				{
					Logging.PrintInfo(Logging.RequestCache, "<null>");
				}
				else
				{
					if (entryMetadata != null)
					{
						StringEnumerator enumerator = entryMetadata.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								string current = enumerator.Current;
								Logging.PrintInfo(Logging.RequestCache, current.TrimEnd(RequestCache.LineSplits));
							}
						}
						finally
						{
							if (enumerator is IDisposable disposable)
							{
								disposable.Dispose();
							}
						}
					}
					Logging.PrintInfo(Logging.RequestCache, "------");
					if (systemMetadata != null)
					{
						StringEnumerator enumerator2 = systemMetadata.GetEnumerator();
						try
						{
							while (enumerator2.MoveNext())
							{
								string current2 = enumerator2.Current;
								Logging.PrintInfo(Logging.RequestCache, current2.TrimEnd(RequestCache.LineSplits));
							}
						}
						finally
						{
							if (enumerator2 is IDisposable disposable2)
							{
								disposable2.Dispose();
							}
						}
					}
				}
			}
		}
		_WinInetCache.CreateFileName(entry);
		Stream stream = Stream.Null;
		if (entry.Error != _WinInetCache.Status.Success)
		{
			if (Logging.On)
			{
				Logging.PrintWarning(Logging.RequestCache, SR.GetString("net_log_cache_create_failed", new Win32Exception((int)entry.Error).Message));
				Logging.Exit(Logging.RequestCache, "WinInetCache.Store");
			}
			if (isThrow)
			{
				Win32Exception ex = new Win32Exception((int)entry.Error);
				throw new IOException(SR.GetString("net_cache_retrieve_failure", ex.Message), ex);
			}
			return null;
		}
		try
		{
			stream = new WriteStream(entry, isThrow, contentLength, async);
		}
		catch (Exception ex2)
		{
			if (ex2 is ThreadAbortException || ex2 is StackOverflowException || ex2 is OutOfMemoryException)
			{
				throw;
			}
			if (Logging.On)
			{
				Logging.PrintError(Logging.RequestCache, SR.GetString("net_log_cache_exception", "WinInetCache.Store()", ex2));
				Logging.Exit(Logging.RequestCache, "WinInetCache.Store");
			}
			if (isThrow)
			{
				throw;
			}
			return null;
		}
		if (Logging.On)
		{
			Logging.Exit(Logging.RequestCache, "WinInetCache.Store", "Filename = " + entry.Filename);
		}
		return stream;
	}

	private bool UpdateInfo(string key, DateTime expiresUtc, DateTime lastModifiedUtc, DateTime lastSynchronizedUtc, TimeSpan maxStale, StringCollection entryMetadata, StringCollection systemMetadata, bool isThrow)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (Logging.On)
		{
			Logging.Enter(Logging.RequestCache, "WinInetCache.Update", "Key = " + key);
		}
		if (!base.CanWrite)
		{
			if (Logging.On)
			{
				Logging.PrintError(Logging.RequestCache, SR.GetString("net_log_operation_failed_with_error", "WinInetCache.Update()", SR.GetString("net_cache_access_denied", "Write")));
			}
			if (Logging.On)
			{
				Logging.Exit(Logging.RequestCache, "WinInetCache.Update()");
			}
			if (isThrow)
			{
				throw new InvalidOperationException(SR.GetString("net_cache_access_denied", "Write"));
			}
			return false;
		}
		_WinInetCache.Entry entry = new _WinInetCache.Entry(key, int.MaxValue);
		_WinInetCache.Entry_FC entry_FC = _WinInetCache.Entry_FC.None;
		if (expiresUtc != DateTime.MinValue && expiresUtc > s_MinDateTimeUtcForFileTimeUtc)
		{
			entry_FC |= _WinInetCache.Entry_FC.Exptime;
			entry.Info.ExpireTime = new _WinInetCache.FILETIME(expiresUtc.ToFileTimeUtc());
			if (Logging.On)
			{
				Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_set_expires", expiresUtc.ToString("r")));
			}
		}
		if (lastModifiedUtc != DateTime.MinValue && lastModifiedUtc > s_MinDateTimeUtcForFileTimeUtc)
		{
			entry_FC |= _WinInetCache.Entry_FC.Modtime;
			entry.Info.LastModifiedTime = new _WinInetCache.FILETIME(lastModifiedUtc.ToFileTimeUtc());
			if (Logging.On)
			{
				Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_set_last_modified", lastModifiedUtc.ToString("r")));
			}
		}
		if (lastSynchronizedUtc != DateTime.MinValue && lastSynchronizedUtc > s_MinDateTimeUtcForFileTimeUtc)
		{
			entry_FC |= _WinInetCache.Entry_FC.Synctime;
			entry.Info.LastSyncTime = new _WinInetCache.FILETIME(lastSynchronizedUtc.ToFileTimeUtc());
			if (Logging.On)
			{
				Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_set_last_synchronized", lastSynchronizedUtc.ToString("r")));
			}
		}
		if (maxStale != TimeSpan.MinValue)
		{
			entry_FC |= _WinInetCache.Entry_FC.Attribute | _WinInetCache.Entry_FC.ExemptDelta;
			entry.Info.EntryType = _WinInetCache.EntryType.NormalEntry;
			if (maxStale >= TimeSpan.Zero)
			{
				if (maxStale >= s_MaxTimeSpanForInt32)
				{
					maxStale = s_MaxTimeSpanForInt32;
				}
				entry.Info.EntryType = _WinInetCache.EntryType.StickyEntry;
				entry.Info.U.ExemptDelta = (int)maxStale.TotalSeconds;
				if (Logging.On)
				{
					Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_enable_max_stale", ((int)maxStale.TotalSeconds).ToString()));
				}
			}
			else
			{
				entry.Info.U.ExemptDelta = 0;
				if (Logging.On)
				{
					Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_disable_max_stale"));
				}
			}
		}
		entry.MetaInfo = CombineMetaInfo(entryMetadata, systemMetadata);
		if (entry.MetaInfo.Length != 0)
		{
			entry_FC |= _WinInetCache.Entry_FC.Headerinfo;
			if (Logging.On)
			{
				Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_dumping"));
				if (Logging.IsVerbose(Logging.RequestCache))
				{
					Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_dumping"));
					if (entryMetadata != null)
					{
						StringEnumerator enumerator = entryMetadata.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								string current = enumerator.Current;
								Logging.PrintInfo(Logging.RequestCache, current.TrimEnd(RequestCache.LineSplits));
							}
						}
						finally
						{
							if (enumerator is IDisposable disposable)
							{
								disposable.Dispose();
							}
						}
					}
					Logging.PrintInfo(Logging.RequestCache, "------");
					if (systemMetadata != null)
					{
						StringEnumerator enumerator2 = systemMetadata.GetEnumerator();
						try
						{
							while (enumerator2.MoveNext())
							{
								string current2 = enumerator2.Current;
								Logging.PrintInfo(Logging.RequestCache, current2.TrimEnd(RequestCache.LineSplits));
							}
						}
						finally
						{
							if (enumerator2 is IDisposable disposable2)
							{
								disposable2.Dispose();
							}
						}
					}
				}
			}
		}
		_WinInetCache.Update(entry, entry_FC);
		if (entry.Error != _WinInetCache.Status.Success)
		{
			if (Logging.On)
			{
				Logging.PrintWarning(Logging.RequestCache, SR.GetString("net_log_cache_update_failed", "WinInetCache.Update()", entry.Key, new Win32Exception((int)entry.Error).Message));
				Logging.Exit(Logging.RequestCache, "WinInetCache.Update()");
			}
			if (isThrow)
			{
				Win32Exception ex = new Win32Exception((int)entry.Error);
				throw new IOException(SR.GetString("net_cache_retrieve_failure", ex.Message), ex);
			}
			return false;
		}
		if (Logging.On)
		{
			Logging.Exit(Logging.RequestCache, "WinInetCache.Update()", "Status = " + entry.Error);
		}
		return true;
	}
}
