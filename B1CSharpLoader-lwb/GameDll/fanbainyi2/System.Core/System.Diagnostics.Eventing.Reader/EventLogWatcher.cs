using System.Security;
using System.Security.Permissions;
using System.Threading;

namespace System.Diagnostics.Eventing.Reader;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public class EventLogWatcher : IDisposable
{
	private EventLogQuery eventQuery;

	private EventBookmark bookmark;

	private bool readExistingEvents;

	private EventLogHandle handle;

	private IntPtr[] eventsBuffer;

	private int numEventsInBuffer;

	private bool isSubscribing;

	private int callbackThreadId;

	private AutoResetEvent subscriptionWaitHandle;

	private AutoResetEvent unregisterDoneHandle;

	private RegisteredWaitHandle registeredWaitHandle;

	private ProviderMetadataCachedInformation cachedMetadataInformation;

	private EventLogException asyncException;

	public bool Enabled
	{
		get
		{
			return isSubscribing;
		}
		set
		{
			if (value && !isSubscribing)
			{
				StartSubscribing();
			}
			else if (!value && isSubscribing)
			{
				StopSubscribing();
			}
		}
	}

	public event EventHandler<EventRecordWrittenEventArgs> EventRecordWritten;

	public EventLogWatcher(string path)
		: this(new EventLogQuery(path, PathType.LogName), null, readExistingEvents: false)
	{
	}

	public EventLogWatcher(EventLogQuery eventQuery)
		: this(eventQuery, null, readExistingEvents: false)
	{
	}

	public EventLogWatcher(EventLogQuery eventQuery, EventBookmark bookmark)
		: this(eventQuery, bookmark, readExistingEvents: false)
	{
	}

	public EventLogWatcher(EventLogQuery eventQuery, EventBookmark bookmark, bool readExistingEvents)
	{
		if (eventQuery == null)
		{
			throw new ArgumentNullException("eventQuery");
		}
		if (bookmark != null)
		{
			readExistingEvents = false;
		}
		this.eventQuery = eventQuery;
		this.readExistingEvents = readExistingEvents;
		if (this.eventQuery.ReverseDirection)
		{
			throw new InvalidOperationException();
		}
		eventsBuffer = new IntPtr[64];
		cachedMetadataInformation = new ProviderMetadataCachedInformation(eventQuery.Session, null, 50);
		this.bookmark = bookmark;
	}

	[SecuritySafeCritical]
	internal void StopSubscribing()
	{
		EventLogPermissionHolder.GetEventLogPermission().Demand();
		isSubscribing = false;
		if (registeredWaitHandle != null)
		{
			registeredWaitHandle.Unregister(unregisterDoneHandle);
			if (callbackThreadId != Thread.CurrentThread.ManagedThreadId && unregisterDoneHandle != null)
			{
				unregisterDoneHandle.WaitOne();
			}
			registeredWaitHandle = null;
		}
		if (unregisterDoneHandle != null)
		{
			unregisterDoneHandle.Close();
			unregisterDoneHandle = null;
		}
		if (subscriptionWaitHandle != null)
		{
			subscriptionWaitHandle.Close();
			subscriptionWaitHandle = null;
		}
		for (int i = 0; i < numEventsInBuffer; i++)
		{
			if (eventsBuffer[i] != IntPtr.Zero)
			{
				NativeWrapper.EvtClose(eventsBuffer[i]);
				eventsBuffer[i] = IntPtr.Zero;
			}
		}
		numEventsInBuffer = 0;
		if (handle != null && !handle.IsInvalid)
		{
			handle.Dispose();
		}
	}

	[SecuritySafeCritical]
	internal void StartSubscribing()
	{
		if (isSubscribing)
		{
			throw new InvalidOperationException();
		}
		int num = 0;
		num = ((bookmark != null) ? (num | 3) : ((!readExistingEvents) ? (num | 1) : (num | 2)));
		if (eventQuery.TolerateQueryErrors)
		{
			num |= 0x1000;
		}
		EventLogPermissionHolder.GetEventLogPermission().Demand();
		callbackThreadId = -1;
		unregisterDoneHandle = new AutoResetEvent(initialState: false);
		subscriptionWaitHandle = new AutoResetEvent(initialState: false);
		EventLogHandle bookmarkHandleFromBookmark = EventLogRecord.GetBookmarkHandleFromBookmark(bookmark);
		using (bookmarkHandleFromBookmark)
		{
			handle = NativeWrapper.EvtSubscribe(eventQuery.Session.Handle, subscriptionWaitHandle.SafeWaitHandle, eventQuery.Path, eventQuery.Query, bookmarkHandleFromBookmark, IntPtr.Zero, IntPtr.Zero, num);
		}
		isSubscribing = true;
		RequestEvents();
		registeredWaitHandle = ThreadPool.RegisterWaitForSingleObject(subscriptionWaitHandle, SubscribedEventsAvailableCallback, null, -1, executeOnlyOnce: false);
	}

	internal void SubscribedEventsAvailableCallback(object state, bool timedOut)
	{
		callbackThreadId = Thread.CurrentThread.ManagedThreadId;
		try
		{
			RequestEvents();
		}
		finally
		{
			callbackThreadId = -1;
		}
	}

	[SecuritySafeCritical]
	private void RequestEvents()
	{
		EventLogPermissionHolder.GetEventLogPermission().Demand();
		asyncException = null;
		bool flag = false;
		while (isSubscribing)
		{
			try
			{
				flag = NativeWrapper.EvtNext(handle, eventsBuffer.Length, eventsBuffer, 0, 0, ref numEventsInBuffer);
				if (!flag)
				{
					break;
				}
			}
			catch (Exception value)
			{
				asyncException = new EventLogException();
				asyncException.Data.Add("RealException", value);
			}
			HandleEventsRequestCompletion();
			if (!flag)
			{
				break;
			}
		}
	}

	private void IssueCallback(EventRecordWrittenEventArgs eventArgs)
	{
		if (this.EventRecordWritten != null)
		{
			this.EventRecordWritten(this, eventArgs);
		}
	}

	[SecurityCritical]
	private void HandleEventsRequestCompletion()
	{
		if (asyncException != null)
		{
			EventRecordWrittenEventArgs eventArgs = new EventRecordWrittenEventArgs(asyncException.Data["RealException"] as Exception);
			IssueCallback(eventArgs);
		}
		for (int i = 0; i < numEventsInBuffer; i++)
		{
			if (!isSubscribing)
			{
				break;
			}
			EventLogRecord record = new EventLogRecord(new EventLogHandle(eventsBuffer[i], ownsHandle: true), eventQuery.Session, cachedMetadataInformation);
			EventRecordWrittenEventArgs eventArgs2 = new EventRecordWrittenEventArgs(record);
			eventsBuffer[i] = IntPtr.Zero;
			IssueCallback(eventArgs2);
		}
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
			StopSubscribing();
			return;
		}
		for (int i = 0; i < numEventsInBuffer; i++)
		{
			if (eventsBuffer[i] != IntPtr.Zero)
			{
				NativeWrapper.EvtClose(eventsBuffer[i]);
				eventsBuffer[i] = IntPtr.Zero;
			}
		}
		numEventsInBuffer = 0;
	}
}
