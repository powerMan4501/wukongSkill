using System.Collections.Generic;
using System.IO;
using System.Security;
using System.Security.Permissions;
using Microsoft.Win32;

namespace System.Diagnostics.Eventing.Reader;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public class EventLogReader : IDisposable
{
	private EventLogQuery eventQuery;

	private int batchSize;

	private EventLogHandle handle;

	private IntPtr[] eventsBuffer;

	private int currentIndex;

	private int eventCount;

	private bool isEof;

	private ProviderMetadataCachedInformation cachedMetadataInformation;

	public int BatchSize
	{
		get
		{
			return batchSize;
		}
		set
		{
			if (value < 1)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			batchSize = value;
		}
	}

	public IList<EventLogStatus> LogStatus
	{
		[SecurityCritical]
		get
		{
			EventLogPermissionHolder.GetEventLogPermission().Demand();
			List<EventLogStatus> list = null;
			string[] array = null;
			int[] array2 = null;
			EventLogHandle eventLogHandle = handle;
			if (eventLogHandle.IsInvalid)
			{
				throw new InvalidOperationException();
			}
			array = (string[])NativeWrapper.EvtGetQueryInfo(eventLogHandle, Microsoft.Win32.UnsafeNativeMethods.EvtQueryPropertyId.EvtQueryNames);
			array2 = (int[])NativeWrapper.EvtGetQueryInfo(eventLogHandle, Microsoft.Win32.UnsafeNativeMethods.EvtQueryPropertyId.EvtQueryStatuses);
			if (array.Length != array2.Length)
			{
				throw new InvalidOperationException();
			}
			list = new List<EventLogStatus>(array.Length);
			for (int i = 0; i < array.Length; i++)
			{
				EventLogStatus item = new EventLogStatus(array[i], array2[i]);
				list.Add(item);
			}
			return list.AsReadOnly();
		}
	}

	public EventLogReader(string path)
		: this(new EventLogQuery(path, PathType.LogName), null)
	{
	}

	public EventLogReader(string path, PathType pathType)
		: this(new EventLogQuery(path, pathType), null)
	{
	}

	public EventLogReader(EventLogQuery eventQuery)
		: this(eventQuery, null)
	{
	}

	[SecurityCritical]
	public EventLogReader(EventLogQuery eventQuery, EventBookmark bookmark)
	{
		if (eventQuery == null)
		{
			throw new ArgumentNullException("eventQuery");
		}
		string logfile = null;
		if (eventQuery.ThePathType == PathType.FilePath)
		{
			logfile = eventQuery.Path;
		}
		cachedMetadataInformation = new ProviderMetadataCachedInformation(eventQuery.Session, logfile, 50);
		this.eventQuery = eventQuery;
		batchSize = 64;
		eventsBuffer = new IntPtr[batchSize];
		int num = 0;
		num = ((this.eventQuery.ThePathType != PathType.LogName) ? (num | 2) : (num | 1));
		if (this.eventQuery.ReverseDirection)
		{
			num |= 0x200;
		}
		if (this.eventQuery.TolerateQueryErrors)
		{
			num |= 0x1000;
		}
		EventLogPermissionHolder.GetEventLogPermission().Demand();
		handle = NativeWrapper.EvtQuery(this.eventQuery.Session.Handle, this.eventQuery.Path, this.eventQuery.Query, num);
		EventLogHandle bookmarkHandleFromBookmark = EventLogRecord.GetBookmarkHandleFromBookmark(bookmark);
		if (!bookmarkHandleFromBookmark.IsInvalid)
		{
			using (bookmarkHandleFromBookmark)
			{
				NativeWrapper.EvtSeek(handle, 1L, bookmarkHandleFromBookmark, 0, Microsoft.Win32.UnsafeNativeMethods.EvtSeekFlags.EvtSeekRelativeToBookmark);
			}
		}
	}

	[SecurityCritical]
	private bool GetNextBatch(TimeSpan ts)
	{
		int timeout = ((!(ts == TimeSpan.MaxValue)) ? ((int)ts.TotalMilliseconds) : (-1));
		if (batchSize != eventsBuffer.Length)
		{
			eventsBuffer = new IntPtr[batchSize];
		}
		int returned = 0;
		if (!NativeWrapper.EvtNext(handle, batchSize, eventsBuffer, timeout, 0, ref returned))
		{
			eventCount = 0;
			currentIndex = 0;
			return false;
		}
		currentIndex = 0;
		eventCount = returned;
		return true;
	}

	public EventRecord ReadEvent()
	{
		return ReadEvent(TimeSpan.MaxValue);
	}

	[SecurityCritical]
	public EventRecord ReadEvent(TimeSpan timeout)
	{
		EventLogPermissionHolder.GetEventLogPermission().Demand();
		if (isEof)
		{
			throw new InvalidOperationException();
		}
		if (currentIndex >= eventCount)
		{
			GetNextBatch(timeout);
			if (currentIndex >= eventCount)
			{
				isEof = true;
				return null;
			}
		}
		EventLogRecord result = new EventLogRecord(new EventLogHandle(eventsBuffer[currentIndex], ownsHandle: true), eventQuery.Session, cachedMetadataInformation);
		currentIndex++;
		return result;
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	[SecuritySafeCritical]
	protected virtual void Dispose(bool disposing)
	{
		if (disposing)
		{
			EventLogPermissionHolder.GetEventLogPermission().Demand();
		}
		while (currentIndex < eventCount)
		{
			NativeWrapper.EvtClose(eventsBuffer[currentIndex]);
			currentIndex++;
		}
		if (handle != null && !handle.IsInvalid)
		{
			handle.Dispose();
		}
	}

	[SecurityCritical]
	internal void SeekReset()
	{
		while (currentIndex < eventCount)
		{
			NativeWrapper.EvtClose(eventsBuffer[currentIndex]);
			currentIndex++;
		}
		currentIndex = 0;
		eventCount = 0;
		isEof = false;
	}

	[SecurityCritical]
	internal void SeekCommon(long offset)
	{
		offset -= eventCount - currentIndex;
		SeekReset();
		NativeWrapper.EvtSeek(handle, offset, EventLogHandle.Zero, 0, Microsoft.Win32.UnsafeNativeMethods.EvtSeekFlags.EvtSeekRelativeToCurrent);
	}

	public void Seek(EventBookmark bookmark)
	{
		Seek(bookmark, 0L);
	}

	[SecurityCritical]
	public void Seek(EventBookmark bookmark, long offset)
	{
		if (bookmark == null)
		{
			throw new ArgumentNullException("bookmark");
		}
		EventLogPermissionHolder.GetEventLogPermission().Demand();
		SeekReset();
		using EventLogHandle bookmark2 = EventLogRecord.GetBookmarkHandleFromBookmark(bookmark);
		NativeWrapper.EvtSeek(handle, offset, bookmark2, 0, Microsoft.Win32.UnsafeNativeMethods.EvtSeekFlags.EvtSeekRelativeToBookmark);
	}

	[SecurityCritical]
	public void Seek(SeekOrigin origin, long offset)
	{
		EventLogPermissionHolder.GetEventLogPermission().Demand();
		switch (origin)
		{
		case SeekOrigin.Begin:
			SeekReset();
			NativeWrapper.EvtSeek(handle, offset, EventLogHandle.Zero, 0, Microsoft.Win32.UnsafeNativeMethods.EvtSeekFlags.EvtSeekRelativeToFirst);
			break;
		case SeekOrigin.End:
			SeekReset();
			NativeWrapper.EvtSeek(handle, offset, EventLogHandle.Zero, 0, Microsoft.Win32.UnsafeNativeMethods.EvtSeekFlags.EvtSeekRelativeToLast);
			break;
		case SeekOrigin.Current:
			if (offset >= 0)
			{
				if (currentIndex + offset < eventCount)
				{
					for (int i = currentIndex; i < currentIndex + offset; i++)
					{
						NativeWrapper.EvtClose(eventsBuffer[i]);
					}
					currentIndex = (int)(currentIndex + offset);
				}
				else
				{
					SeekCommon(offset);
				}
			}
			else if (currentIndex + offset >= 0)
			{
				SeekCommon(offset);
			}
			else
			{
				SeekCommon(offset);
			}
			break;
		}
	}

	public void CancelReading()
	{
		NativeWrapper.EvtCancel(handle);
	}
}
