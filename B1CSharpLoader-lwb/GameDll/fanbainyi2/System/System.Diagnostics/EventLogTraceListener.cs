using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;

namespace System.Diagnostics;

[HostProtection(SecurityAction.LinkDemand, Synchronization = true)]
public sealed class EventLogTraceListener : TraceListener
{
	private EventLog eventLog;

	private bool nameSet;

	public EventLog EventLog
	{
		get
		{
			return eventLog;
		}
		set
		{
			eventLog = value;
		}
	}

	public override string Name
	{
		get
		{
			if (!nameSet && eventLog != null)
			{
				nameSet = true;
				base.Name = eventLog.Source;
			}
			return base.Name;
		}
		set
		{
			nameSet = true;
			base.Name = value;
		}
	}

	public EventLogTraceListener()
	{
	}

	public EventLogTraceListener(EventLog eventLog)
		: base((eventLog != null) ? eventLog.Source : string.Empty)
	{
		this.eventLog = eventLog;
	}

	public EventLogTraceListener(string source)
	{
		eventLog = new EventLog();
		eventLog.Source = source;
	}

	public override void Close()
	{
		if (eventLog != null)
		{
			eventLog.Close();
		}
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing)
			{
				Close();
				return;
			}
			if (eventLog != null)
			{
				eventLog.Close();
			}
			eventLog = null;
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	public override void Write(string message)
	{
		if (eventLog != null)
		{
			eventLog.WriteEntry(message);
		}
	}

	public override void WriteLine(string message)
	{
		Write(message);
	}

	[ComVisible(false)]
	public override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType severity, int id, string format, params object[] args)
	{
		if (base.Filter != null && !base.Filter.ShouldTrace(eventCache, source, severity, id, format, args))
		{
			return;
		}
		EventInstance instance = CreateEventInstance(severity, id);
		if (args == null)
		{
			eventLog.WriteEvent(instance, format);
		}
		else if (string.IsNullOrEmpty(format))
		{
			string[] array = new string[args.Length];
			for (int i = 0; i < args.Length; i++)
			{
				array[i] = args[i].ToString();
			}
			EventLog obj = eventLog;
			object[] values = array;
			obj.WriteEvent(instance, values);
		}
		else
		{
			eventLog.WriteEvent(instance, string.Format(CultureInfo.InvariantCulture, format, args));
		}
	}

	[ComVisible(false)]
	public override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType severity, int id, string message)
	{
		if (base.Filter == null || base.Filter.ShouldTrace(eventCache, source, severity, id, message))
		{
			EventInstance instance = CreateEventInstance(severity, id);
			eventLog.WriteEvent(instance, message);
		}
	}

	[ComVisible(false)]
	public override void TraceData(TraceEventCache eventCache, string source, TraceEventType severity, int id, object data)
	{
		if (base.Filter == null || base.Filter.ShouldTrace(eventCache, source, severity, id, null, null, data))
		{
			EventInstance instance = CreateEventInstance(severity, id);
			eventLog.WriteEvent(instance, data);
		}
	}

	[ComVisible(false)]
	public override void TraceData(TraceEventCache eventCache, string source, TraceEventType severity, int id, params object[] data)
	{
		if (base.Filter != null && !base.Filter.ShouldTrace(eventCache, source, severity, id, null, null, null, data))
		{
			return;
		}
		EventInstance instance = CreateEventInstance(severity, id);
		StringBuilder stringBuilder = new StringBuilder();
		if (data != null)
		{
			for (int i = 0; i < data.Length; i++)
			{
				if (i != 0)
				{
					stringBuilder.Append(", ");
				}
				if (data[i] != null)
				{
					stringBuilder.Append(data[i].ToString());
				}
			}
		}
		eventLog.WriteEvent(instance, stringBuilder.ToString());
	}

	private EventInstance CreateEventInstance(TraceEventType severity, int id)
	{
		if (id > 65535)
		{
			id = 65535;
		}
		if (id < 0)
		{
			id = 0;
		}
		EventInstance eventInstance = new EventInstance(id, 0);
		switch (severity)
		{
		case TraceEventType.Critical:
		case TraceEventType.Error:
			eventInstance.EntryType = EventLogEntryType.Error;
			break;
		case TraceEventType.Warning:
			eventInstance.EntryType = EventLogEntryType.Warning;
			break;
		default:
			eventInstance.EntryType = EventLogEntryType.Information;
			break;
		}
		return eventInstance;
	}
}
