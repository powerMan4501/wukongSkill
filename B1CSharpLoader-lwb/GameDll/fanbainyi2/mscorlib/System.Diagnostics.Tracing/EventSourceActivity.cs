namespace System.Diagnostics.Tracing;

internal sealed class EventSourceActivity : IDisposable
{
	private enum State
	{
		Started,
		Stopped
	}

	private readonly EventSource eventSource;

	private EventSourceOptions startStopOptions;

	internal Guid activityId;

	private State state;

	private string eventName;

	internal static Guid s_empty;

	public EventSource EventSource => eventSource;

	public Guid Id => activityId;

	private bool StartEventWasFired => eventName != null;

	public EventSourceActivity(EventSource eventSource)
	{
		if (eventSource == null)
		{
			throw new ArgumentNullException("eventSource");
		}
		this.eventSource = eventSource;
	}

	public static implicit operator EventSourceActivity(EventSource eventSource)
	{
		return new EventSourceActivity(eventSource);
	}

	public EventSourceActivity Start<T>(string eventName, EventSourceOptions options, T data)
	{
		return Start(eventName, ref options, ref data);
	}

	public EventSourceActivity Start(string eventName)
	{
		EventSourceOptions options = default(EventSourceOptions);
		EmptyStruct data = default(EmptyStruct);
		return Start(eventName, ref options, ref data);
	}

	public EventSourceActivity Start(string eventName, EventSourceOptions options)
	{
		EmptyStruct data = default(EmptyStruct);
		return Start(eventName, ref options, ref data);
	}

	public EventSourceActivity Start<T>(string eventName, T data)
	{
		EventSourceOptions options = default(EventSourceOptions);
		return Start(eventName, ref options, ref data);
	}

	public void Stop<T>(T data)
	{
		Stop(null, ref data);
	}

	public void Stop<T>(string eventName)
	{
		EmptyStruct data = default(EmptyStruct);
		Stop(eventName, ref data);
	}

	public void Stop<T>(string eventName, T data)
	{
		Stop(eventName, ref data);
	}

	public void Write<T>(string eventName, EventSourceOptions options, T data)
	{
		Write(eventSource, eventName, ref options, ref data);
	}

	public void Write<T>(string eventName, T data)
	{
		EventSourceOptions options = default(EventSourceOptions);
		Write(eventSource, eventName, ref options, ref data);
	}

	public void Write(string eventName, EventSourceOptions options)
	{
		EmptyStruct data = default(EmptyStruct);
		Write(eventSource, eventName, ref options, ref data);
	}

	public void Write(string eventName)
	{
		EventSourceOptions options = default(EventSourceOptions);
		EmptyStruct data = default(EmptyStruct);
		Write(eventSource, eventName, ref options, ref data);
	}

	public void Write<T>(EventSource source, string eventName, EventSourceOptions options, T data)
	{
		Write(source, eventName, ref options, ref data);
	}

	public void Dispose()
	{
		if (state == State.Started)
		{
			EmptyStruct data = default(EmptyStruct);
			Stop(null, ref data);
		}
	}

	private EventSourceActivity Start<T>(string eventName, ref EventSourceOptions options, ref T data)
	{
		if (state != State.Started)
		{
			throw new InvalidOperationException();
		}
		if (!eventSource.IsEnabled())
		{
			return this;
		}
		EventSourceActivity eventSourceActivity = new EventSourceActivity(eventSource);
		if (!eventSource.IsEnabled(options.Level, options.Keywords))
		{
			Guid relatedActivityId = Id;
			eventSourceActivity.activityId = Guid.NewGuid();
			eventSourceActivity.startStopOptions = options;
			eventSourceActivity.eventName = eventName;
			eventSourceActivity.startStopOptions.Opcode = EventOpcode.Start;
			eventSource.Write(eventName, ref eventSourceActivity.startStopOptions, ref eventSourceActivity.activityId, ref relatedActivityId, ref data);
		}
		else
		{
			eventSourceActivity.activityId = Id;
		}
		return eventSourceActivity;
	}

	private void Write<T>(EventSource eventSource, string eventName, ref EventSourceOptions options, ref T data)
	{
		if (state != State.Started)
		{
			throw new InvalidOperationException();
		}
		if (eventName == null)
		{
			throw new ArgumentNullException();
		}
		eventSource.Write(eventName, ref options, ref activityId, ref s_empty, ref data);
	}

	private void Stop<T>(string eventName, ref T data)
	{
		if (state != State.Started)
		{
			throw new InvalidOperationException();
		}
		if (!StartEventWasFired)
		{
			return;
		}
		state = State.Stopped;
		if (eventName == null)
		{
			eventName = this.eventName;
			if (eventName.EndsWith("Start"))
			{
				eventName = eventName.Substring(0, eventName.Length - 5);
			}
			eventName += "Stop";
		}
		startStopOptions.Opcode = EventOpcode.Stop;
		eventSource.Write(eventName, ref startStopOptions, ref activityId, ref s_empty, ref data);
	}
}
