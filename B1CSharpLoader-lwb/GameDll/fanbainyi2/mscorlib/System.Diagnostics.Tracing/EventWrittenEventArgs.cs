using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Security;

namespace System.Diagnostics.Tracing;

[__DynamicallyInvokable]
public class EventWrittenEventArgs : EventArgs
{
	private string m_message;

	private string m_eventName;

	private EventSource m_eventSource;

	private ReadOnlyCollection<string> m_payloadNames;

	private Guid m_activityId;

	internal EventTags m_tags;

	internal EventOpcode m_opcode;

	internal EventKeywords m_keywords;

	internal EventLevel m_level;

	[__DynamicallyInvokable]
	public string EventName
	{
		[__DynamicallyInvokable]
		get
		{
			if (m_eventName != null || EventId < 0)
			{
				return m_eventName;
			}
			return m_eventSource.m_eventData[EventId].Name;
		}
		internal set
		{
			m_eventName = value;
		}
	}

	[__DynamicallyInvokable]
	public int EventId
	{
		[__DynamicallyInvokable]
		get;
		internal set; }

	[__DynamicallyInvokable]
	public Guid ActivityId
	{
		[SecurityCritical]
		[__DynamicallyInvokable]
		get
		{
			Guid guid = m_activityId;
			if (guid == Guid.Empty)
			{
				guid = EventSource.CurrentThreadActivityId;
			}
			return guid;
		}
		internal set
		{
			m_activityId = value;
		}
	}

	[__DynamicallyInvokable]
	public Guid RelatedActivityId
	{
		[SecurityCritical]
		[__DynamicallyInvokable]
		get;
		internal set; }

	[__DynamicallyInvokable]
	public ReadOnlyCollection<object> Payload
	{
		[__DynamicallyInvokable]
		get;
		internal set; }

	[__DynamicallyInvokable]
	public ReadOnlyCollection<string> PayloadNames
	{
		[__DynamicallyInvokable]
		get
		{
			if (m_payloadNames == null)
			{
				List<string> list = new List<string>();
				ParameterInfo[] parameters = m_eventSource.m_eventData[EventId].Parameters;
				foreach (ParameterInfo parameterInfo in parameters)
				{
					list.Add(parameterInfo.Name);
				}
				m_payloadNames = new ReadOnlyCollection<string>(list);
			}
			return m_payloadNames;
		}
		internal set
		{
			m_payloadNames = value;
		}
	}

	[__DynamicallyInvokable]
	public EventSource EventSource
	{
		[__DynamicallyInvokable]
		get
		{
			return m_eventSource;
		}
	}

	[__DynamicallyInvokable]
	public EventKeywords Keywords
	{
		[__DynamicallyInvokable]
		get
		{
			if (EventId < 0)
			{
				return m_keywords;
			}
			return (EventKeywords)m_eventSource.m_eventData[EventId].Descriptor.Keywords;
		}
	}

	[__DynamicallyInvokable]
	public EventOpcode Opcode
	{
		[__DynamicallyInvokable]
		get
		{
			if (EventId < 0)
			{
				return m_opcode;
			}
			return (EventOpcode)m_eventSource.m_eventData[EventId].Descriptor.Opcode;
		}
	}

	[__DynamicallyInvokable]
	public EventTask Task
	{
		[__DynamicallyInvokable]
		get
		{
			if (EventId < 0)
			{
				return EventTask.None;
			}
			return (EventTask)m_eventSource.m_eventData[EventId].Descriptor.Task;
		}
	}

	[__DynamicallyInvokable]
	public EventTags Tags
	{
		[__DynamicallyInvokable]
		get
		{
			if (EventId < 0)
			{
				return m_tags;
			}
			return m_eventSource.m_eventData[EventId].Tags;
		}
	}

	[__DynamicallyInvokable]
	public string Message
	{
		[__DynamicallyInvokable]
		get
		{
			if (EventId < 0)
			{
				return m_message;
			}
			return m_eventSource.m_eventData[EventId].Message;
		}
		internal set
		{
			m_message = value;
		}
	}

	[__DynamicallyInvokable]
	public EventChannel Channel
	{
		[__DynamicallyInvokable]
		get
		{
			if (EventId < 0)
			{
				return EventChannel.None;
			}
			return (EventChannel)m_eventSource.m_eventData[EventId].Descriptor.Channel;
		}
	}

	[__DynamicallyInvokable]
	public byte Version
	{
		[__DynamicallyInvokable]
		get
		{
			if (EventId < 0)
			{
				return 0;
			}
			return m_eventSource.m_eventData[EventId].Descriptor.Version;
		}
	}

	[__DynamicallyInvokable]
	public EventLevel Level
	{
		[__DynamicallyInvokable]
		get
		{
			if (EventId < 0)
			{
				return m_level;
			}
			return (EventLevel)m_eventSource.m_eventData[EventId].Descriptor.Level;
		}
	}

	internal EventWrittenEventArgs(EventSource eventSource)
	{
		m_eventSource = eventSource;
	}
}
