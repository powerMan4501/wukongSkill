using System.Collections.Generic;
using System.Threading;

namespace System.Diagnostics.Tracing;

[__DynamicallyInvokable]
public class EventListener : IDisposable
{
	private static readonly object s_EventSourceCreatedLock = new object();

	internal volatile EventListener m_Next;

	internal ActivityFilter m_activityFilter;

	internal static EventListener s_Listeners;

	internal static List<WeakReference> s_EventSources;

	private static bool s_CreatingListener = false;

	private static bool s_EventSourceShutdownRegistered = false;

	internal static object EventListenersLock
	{
		get
		{
			if (s_EventSources == null)
			{
				Interlocked.CompareExchange(ref s_EventSources, new List<WeakReference>(2), null);
			}
			return s_EventSources;
		}
	}

	private event EventHandler<EventSourceCreatedEventArgs> _EventSourceCreated;

	public event EventHandler<EventSourceCreatedEventArgs> EventSourceCreated
	{
		add
		{
			lock (s_EventSourceCreatedLock)
			{
				CallBackForExistingEventSources(addToListenersList: false, value);
				this._EventSourceCreated = (EventHandler<EventSourceCreatedEventArgs>)Delegate.Combine(this._EventSourceCreated, value);
			}
		}
		remove
		{
			lock (s_EventSourceCreatedLock)
			{
				this._EventSourceCreated = (EventHandler<EventSourceCreatedEventArgs>)Delegate.Remove(this._EventSourceCreated, value);
			}
		}
	}

	public event EventHandler<EventWrittenEventArgs> EventWritten;

	[__DynamicallyInvokable]
	public EventListener()
	{
		CallBackForExistingEventSources(addToListenersList: true, delegate(object obj, EventSourceCreatedEventArgs args)
		{
			args.EventSource.AddListener(this);
		});
	}

	[__DynamicallyInvokable]
	public virtual void Dispose()
	{
		lock (EventListenersLock)
		{
			if (s_Listeners == null)
			{
				return;
			}
			if (this == s_Listeners)
			{
				EventListener listenerToRemove = s_Listeners;
				s_Listeners = m_Next;
				RemoveReferencesToListenerInEventSources(listenerToRemove);
				return;
			}
			EventListener eventListener = s_Listeners;
			EventListener next;
			while (true)
			{
				next = eventListener.m_Next;
				if (next == null)
				{
					return;
				}
				if (next == this)
				{
					break;
				}
				eventListener = next;
			}
			eventListener.m_Next = next.m_Next;
			RemoveReferencesToListenerInEventSources(next);
		}
	}

	[__DynamicallyInvokable]
	public void EnableEvents(EventSource eventSource, EventLevel level)
	{
		EnableEvents(eventSource, level, EventKeywords.None);
	}

	[__DynamicallyInvokable]
	public void EnableEvents(EventSource eventSource, EventLevel level, EventKeywords matchAnyKeyword)
	{
		EnableEvents(eventSource, level, matchAnyKeyword, null);
	}

	[__DynamicallyInvokable]
	public void EnableEvents(EventSource eventSource, EventLevel level, EventKeywords matchAnyKeyword, IDictionary<string, string> arguments)
	{
		if (eventSource == null)
		{
			throw new ArgumentNullException("eventSource");
		}
		eventSource.SendCommand(this, 0, 0, EventCommand.Update, enable: true, level, matchAnyKeyword, arguments);
	}

	[__DynamicallyInvokable]
	public void DisableEvents(EventSource eventSource)
	{
		if (eventSource == null)
		{
			throw new ArgumentNullException("eventSource");
		}
		eventSource.SendCommand(this, 0, 0, EventCommand.Update, enable: false, EventLevel.LogAlways, EventKeywords.None, null);
	}

	[__DynamicallyInvokable]
	public static int EventSourceIndex(EventSource eventSource)
	{
		return eventSource.m_id;
	}

	[__DynamicallyInvokable]
	protected internal virtual void OnEventSourceCreated(EventSource eventSource)
	{
		EventHandler<EventSourceCreatedEventArgs> eventHandler = this._EventSourceCreated;
		if (eventHandler != null)
		{
			EventSourceCreatedEventArgs e = new EventSourceCreatedEventArgs();
			e.EventSource = eventSource;
			eventHandler(this, e);
		}
	}

	[__DynamicallyInvokable]
	protected internal virtual void OnEventWritten(EventWrittenEventArgs eventData)
	{
		this.EventWritten?.Invoke(this, eventData);
	}

	internal static void AddEventSource(EventSource newEventSource)
	{
		lock (EventListenersLock)
		{
			if (s_EventSources == null)
			{
				s_EventSources = new List<WeakReference>(2);
			}
			if (!s_EventSourceShutdownRegistered)
			{
				s_EventSourceShutdownRegistered = true;
				AppDomain.CurrentDomain.ProcessExit += DisposeOnShutdown;
				AppDomain.CurrentDomain.DomainUnload += DisposeOnShutdown;
			}
			int num = -1;
			if (s_EventSources.Count % 64 == 63)
			{
				int num2 = s_EventSources.Count;
				while (0 < num2)
				{
					num2--;
					WeakReference weakReference = s_EventSources[num2];
					if (!weakReference.IsAlive)
					{
						num = num2;
						weakReference.Target = newEventSource;
						break;
					}
				}
			}
			if (num < 0)
			{
				num = s_EventSources.Count;
				s_EventSources.Add(new WeakReference(newEventSource));
			}
			newEventSource.m_id = num;
			for (EventListener next = s_Listeners; next != null; next = next.m_Next)
			{
				newEventSource.AddListener(next);
			}
		}
	}

	private static void DisposeOnShutdown(object sender, EventArgs e)
	{
		lock (EventListenersLock)
		{
			foreach (WeakReference s_EventSource in s_EventSources)
			{
				if (s_EventSource.Target is EventSource eventSource)
				{
					eventSource.Dispose();
				}
			}
		}
	}

	private static void RemoveReferencesToListenerInEventSources(EventListener listenerToRemove)
	{
		foreach (WeakReference s_EventSource in s_EventSources)
		{
			if (!(s_EventSource.Target is EventSource eventSource))
			{
				continue;
			}
			if (eventSource.m_Dispatchers.m_Listener == listenerToRemove)
			{
				eventSource.m_Dispatchers = eventSource.m_Dispatchers.m_Next;
				continue;
			}
			EventDispatcher eventDispatcher = eventSource.m_Dispatchers;
			while (true)
			{
				EventDispatcher next = eventDispatcher.m_Next;
				if (next == null)
				{
					break;
				}
				if (next.m_Listener == listenerToRemove)
				{
					eventDispatcher.m_Next = next.m_Next;
					break;
				}
				eventDispatcher = next;
			}
		}
	}

	[Conditional("DEBUG")]
	internal static void Validate()
	{
		lock (EventListenersLock)
		{
			Dictionary<EventListener, bool> dictionary = new Dictionary<EventListener, bool>();
			for (EventListener next = s_Listeners; next != null; next = next.m_Next)
			{
				dictionary.Add(next, value: true);
			}
			int num = -1;
			foreach (WeakReference s_EventSource in s_EventSources)
			{
				num++;
				if (!(s_EventSource.Target is EventSource eventSource))
				{
					continue;
				}
				for (EventDispatcher eventDispatcher = eventSource.m_Dispatchers; eventDispatcher != null; eventDispatcher = eventDispatcher.m_Next)
				{
				}
				foreach (EventListener key in dictionary.Keys)
				{
					EventDispatcher eventDispatcher = eventSource.m_Dispatchers;
					while (eventDispatcher.m_Listener != key)
					{
						eventDispatcher = eventDispatcher.m_Next;
					}
				}
			}
		}
	}

	private void CallBackForExistingEventSources(bool addToListenersList, EventHandler<EventSourceCreatedEventArgs> callback)
	{
		lock (EventListenersLock)
		{
			if (s_CreatingListener)
			{
				throw new InvalidOperationException(Environment.GetResourceString("EventSource_ListenerCreatedInsideCallback"));
			}
			try
			{
				s_CreatingListener = true;
				if (addToListenersList)
				{
					m_Next = s_Listeners;
					s_Listeners = this;
				}
				WeakReference[] array = s_EventSources.ToArray();
				foreach (WeakReference weakReference in array)
				{
					if (weakReference.Target is EventSource eventSource)
					{
						EventSourceCreatedEventArgs e = new EventSourceCreatedEventArgs();
						e.EventSource = eventSource;
						callback(this, e);
					}
				}
			}
			finally
			{
				s_CreatingListener = false;
			}
		}
	}
}
