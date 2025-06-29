using System.Globalization;
using System.Security;
using System.Security.Permissions;
using System.Text;

namespace System.Diagnostics.Eventing;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public class EventProviderTraceListener : TraceListener
{
	private EventProvider m_provider;

	private const string s_nullStringValue = "null";

	private const string s_nullStringComaValue = "null,";

	private const string s_nullCStringValue = ": null";

	private const string s_activityIdString = "activityId=";

	private const string s_relatedActivityIdString = "relatedActivityId=";

	private const string s_callStackString = " : CallStack:";

	private const string s_optionDelimiter = "delimiter";

	private string m_delimiter = ";";

	private int m_initializedDelim;

	private const uint s_keyWordMask = 4294967040u;

	private const int s_defaultPayloadSize = 512;

	private object m_Lock = new object();

	public string Delimiter
	{
		get
		{
			if (m_initializedDelim == 0)
			{
				lock (m_Lock)
				{
					if (m_initializedDelim == 0)
					{
						if (base.Attributes.ContainsKey("delimiter"))
						{
							m_delimiter = base.Attributes["delimiter"];
						}
						m_initializedDelim = 1;
					}
				}
				if (m_delimiter == null)
				{
					throw new ArgumentNullException("Delimiter");
				}
				if (m_delimiter.Length == 0)
				{
					throw new ArgumentException(System.SR.GetString("Argument_NeedNonemptyDelimiter"));
				}
			}
			return m_delimiter;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("Delimiter");
			}
			if (value.Length == 0)
			{
				throw new ArgumentException(System.SR.GetString("Argument_NeedNonemptyDelimiter"));
			}
			lock (m_Lock)
			{
				m_delimiter = value;
				m_initializedDelim = 1;
			}
		}
	}

	public sealed override bool IsThreadSafe => true;

	protected override string[] GetSupportedAttributes()
	{
		return new string[1] { "delimiter" };
	}

	public EventProviderTraceListener(string providerId)
	{
		InitProvider(providerId);
	}

	public EventProviderTraceListener(string providerId, string name)
		: base(name)
	{
		InitProvider(providerId);
	}

	public EventProviderTraceListener(string providerId, string name, string delimiter)
		: base(name)
	{
		if (delimiter == null)
		{
			throw new ArgumentNullException("delimiter");
		}
		if (delimiter.Length == 0)
		{
			throw new ArgumentException(System.SR.GetString("Argument_NeedNonemptyDelimiter"));
		}
		m_delimiter = delimiter;
		m_initializedDelim = 1;
		InitProvider(providerId);
	}

	private void InitProvider(string providerId)
	{
		Guid providerGuid = new Guid(providerId);
		m_provider = new EventProvider(providerGuid);
	}

	public sealed override void Flush()
	{
	}

	public override void Close()
	{
		m_provider.Close();
	}

	public sealed override void Write(string message)
	{
		if (m_provider.IsEnabled())
		{
			m_provider.WriteMessageEvent(message, 8, 0L);
		}
	}

	public sealed override void WriteLine(string message)
	{
		Write(message);
	}

	public sealed override void TraceData(TraceEventCache eventCache, string source, TraceEventType eventType, int id, object data)
	{
		if (m_provider.IsEnabled() && (base.Filter == null || base.Filter.ShouldTrace(eventCache, source, eventType, id, null, null, null, null)))
		{
			StringBuilder stringBuilder = new StringBuilder(512);
			if (data != null)
			{
				stringBuilder.Append(data.ToString());
			}
			else
			{
				stringBuilder.Append(": null");
			}
			if (eventCache != null && (base.TraceOutputOptions & TraceOptions.Callstack) != TraceOptions.None)
			{
				stringBuilder.Append(" : CallStack:");
				stringBuilder.Append(eventCache.Callstack);
				m_provider.WriteMessageEvent(stringBuilder.ToString(), (byte)eventType, (long)eventType & 0xFFFFFF00L);
			}
			else
			{
				m_provider.WriteMessageEvent(stringBuilder.ToString(), (byte)eventType, (long)eventType & 0xFFFFFF00L);
			}
		}
	}

	public sealed override void TraceData(TraceEventCache eventCache, string source, TraceEventType eventType, int id, params object[] data)
	{
		if (!m_provider.IsEnabled() || (base.Filter != null && !base.Filter.ShouldTrace(eventCache, source, eventType, id, null, null, null, null)))
		{
			return;
		}
		StringBuilder stringBuilder = new StringBuilder(512);
		if (data != null && data.Length != 0)
		{
			int i;
			for (i = 0; i < data.Length - 1; i++)
			{
				if (data[i] != null)
				{
					stringBuilder.Append(data[i].ToString());
					stringBuilder.Append(Delimiter);
				}
				else
				{
					stringBuilder.Append("null,");
				}
			}
			if (data[i] != null)
			{
				stringBuilder.Append(data[i].ToString());
			}
			else
			{
				stringBuilder.Append("null");
			}
		}
		else
		{
			stringBuilder.Append("null");
		}
		if (eventCache != null && (base.TraceOutputOptions & TraceOptions.Callstack) != TraceOptions.None)
		{
			stringBuilder.Append(" : CallStack:");
			stringBuilder.Append(eventCache.Callstack);
			m_provider.WriteMessageEvent(stringBuilder.ToString(), (byte)eventType, (long)eventType & 0xFFFFFF00L);
		}
		else
		{
			m_provider.WriteMessageEvent(stringBuilder.ToString(), (byte)eventType, (long)eventType & 0xFFFFFF00L);
		}
	}

	public sealed override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id)
	{
		if (m_provider.IsEnabled() && (base.Filter == null || base.Filter.ShouldTrace(eventCache, source, eventType, id, null, null, null, null)))
		{
			if (eventCache != null && (base.TraceOutputOptions & TraceOptions.Callstack) != TraceOptions.None)
			{
				m_provider.WriteMessageEvent(" : CallStack:" + eventCache.Callstack, (byte)eventType, (long)eventType & 0xFFFFFF00L);
			}
			else
			{
				m_provider.WriteMessageEvent(string.Empty, (byte)eventType, (long)eventType & 0xFFFFFF00L);
			}
		}
	}

	public sealed override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string message)
	{
		if (m_provider.IsEnabled() && (base.Filter == null || base.Filter.ShouldTrace(eventCache, source, eventType, id, null, null, null, null)))
		{
			StringBuilder stringBuilder = new StringBuilder(512);
			stringBuilder.Append(message);
			if (eventCache != null && (base.TraceOutputOptions & TraceOptions.Callstack) != TraceOptions.None)
			{
				stringBuilder.Append(" : CallStack:");
				stringBuilder.Append(eventCache.Callstack);
				m_provider.WriteMessageEvent(stringBuilder.ToString(), (byte)eventType, (long)eventType & 0xFFFFFF00L);
			}
			else
			{
				m_provider.WriteMessageEvent(stringBuilder.ToString(), (byte)eventType, (long)eventType & 0xFFFFFF00L);
			}
		}
	}

	public sealed override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string format, params object[] args)
	{
		if (!m_provider.IsEnabled() || (base.Filter != null && !base.Filter.ShouldTrace(eventCache, source, eventType, id, null, null, null, null)))
		{
			return;
		}
		if (args == null)
		{
			if (eventCache != null && (base.TraceOutputOptions & TraceOptions.Callstack) != TraceOptions.None)
			{
				m_provider.WriteMessageEvent(format + " : CallStack:" + eventCache.Callstack, (byte)eventType, (long)eventType & 0xFFFFFF00L);
			}
			else
			{
				m_provider.WriteMessageEvent(format, (byte)eventType, (long)eventType & 0xFFFFFF00L);
			}
		}
		else if (eventCache != null && (base.TraceOutputOptions & TraceOptions.Callstack) != TraceOptions.None)
		{
			m_provider.WriteMessageEvent(string.Format(CultureInfo.InvariantCulture, format, args) + " : CallStack:" + eventCache.Callstack, (byte)eventType, (long)eventType & 0xFFFFFF00L);
		}
		else
		{
			m_provider.WriteMessageEvent(string.Format(CultureInfo.InvariantCulture, format, args), (byte)eventType, (long)eventType & 0xFFFFFF00L);
		}
	}

	public override void Fail(string message, string detailMessage)
	{
		StringBuilder stringBuilder = new StringBuilder(message);
		if (detailMessage != null)
		{
			stringBuilder.Append(" ");
			stringBuilder.Append(detailMessage);
		}
		TraceEvent(null, null, TraceEventType.Error, 0, stringBuilder.ToString());
	}

	[SecurityCritical]
	public sealed override void TraceTransfer(TraceEventCache eventCache, string source, int id, string message, Guid relatedActivityId)
	{
		if (m_provider.IsEnabled())
		{
			StringBuilder stringBuilder = new StringBuilder(512);
			object obj = Trace.CorrelationManager.ActivityId;
			if (obj != null)
			{
				Guid guid = (Guid)obj;
				stringBuilder.Append("activityId=");
				stringBuilder.Append(guid.ToString());
				stringBuilder.Append(Delimiter);
			}
			stringBuilder.Append("relatedActivityId=");
			stringBuilder.Append(relatedActivityId.ToString());
			stringBuilder.Append(Delimiter + message);
			if (eventCache != null && (base.TraceOutputOptions & TraceOptions.Callstack) != TraceOptions.None)
			{
				stringBuilder.Append(" : CallStack:");
				stringBuilder.Append(eventCache.Callstack);
				m_provider.WriteMessageEvent(stringBuilder.ToString(), 0, 4096L);
			}
			else
			{
				m_provider.WriteMessageEvent(stringBuilder.ToString(), 0, 4096L);
			}
		}
	}
}
