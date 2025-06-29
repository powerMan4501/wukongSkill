using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Reflection;
using Microsoft.Win32;

namespace System.Diagnostics.Tracing;

[__DynamicallyInvokable]
public class EventSource : IDisposable
{
	[__DynamicallyInvokable]
	protected internal struct EventData
	{
		internal ulong m_Ptr;

		internal int m_Size;

		internal int m_Reserved;

		[__DynamicallyInvokable]
		public unsafe IntPtr DataPointer
		{
			[SecuritySafeCritical]
			get
			{
				return (IntPtr)(void*)m_Ptr;
			}
			set
			{
				m_Ptr = (ulong)(void*)value;
			}
		}

		[__DynamicallyInvokable]
		public int Size
		{
			[__DynamicallyInvokable]
			get
			{
				return m_Size;
			}
			[__DynamicallyInvokable]
			set
			{
				m_Size = value;
			}
		}

		[SecurityCritical]
		internal unsafe void SetMetadata(byte* pointer, int size, int reserved)
		{
			m_Ptr = (ulong)pointer;
			m_Size = size;
			m_Reserved = reserved;
		}
	}

	private struct Sha1ForNonSecretPurposes
	{
		private long length;

		private uint[] w;

		private int pos;

		public void Start()
		{
			if (w == null)
			{
				w = new uint[85];
			}
			length = 0L;
			pos = 0;
			w[80] = 1732584193u;
			w[81] = 4023233417u;
			w[82] = 2562383102u;
			w[83] = 271733878u;
			w[84] = 3285377520u;
		}

		public void Append(byte input)
		{
			w[pos / 4] = (w[pos / 4] << 8) | input;
			if (64 == ++pos)
			{
				Drain();
			}
		}

		public void Append(byte[] input)
		{
			foreach (byte input2 in input)
			{
				Append(input2);
			}
		}

		public void Finish(byte[] output)
		{
			long num = length + 8 * pos;
			Append(128);
			while (pos != 56)
			{
				Append(0);
			}
			Append((byte)(num >> 56));
			Append((byte)(num >> 48));
			Append((byte)(num >> 40));
			Append((byte)(num >> 32));
			Append((byte)(num >> 24));
			Append((byte)(num >> 16));
			Append((byte)(num >> 8));
			Append((byte)num);
			int num2 = ((output.Length < 20) ? output.Length : 20);
			for (int i = 0; i != num2; i++)
			{
				uint num3 = w[80 + i / 4];
				output[i] = (byte)(num3 >> 24);
				w[80 + i / 4] = num3 << 8;
			}
		}

		private void Drain()
		{
			for (int i = 16; i != 80; i++)
			{
				w[i] = Rol1(w[i - 3] ^ w[i - 8] ^ w[i - 14] ^ w[i - 16]);
			}
			uint num = w[80];
			uint num2 = w[81];
			uint num3 = w[82];
			uint num4 = w[83];
			uint num5 = w[84];
			for (int j = 0; j != 20; j++)
			{
				uint num6 = (num2 & num3) | (~num2 & num4);
				uint num7 = Rol5(num) + num6 + num5 + 1518500249 + w[j];
				num5 = num4;
				num4 = num3;
				num3 = Rol30(num2);
				num2 = num;
				num = num7;
			}
			for (int k = 20; k != 40; k++)
			{
				uint num8 = num2 ^ num3 ^ num4;
				uint num9 = Rol5(num) + num8 + num5 + 1859775393 + w[k];
				num5 = num4;
				num4 = num3;
				num3 = Rol30(num2);
				num2 = num;
				num = num9;
			}
			for (int l = 40; l != 60; l++)
			{
				uint num10 = (num2 & num3) | (num2 & num4) | (num3 & num4);
				uint num11 = (uint)((int)(Rol5(num) + num10 + num5) + -1894007588) + w[l];
				num5 = num4;
				num4 = num3;
				num3 = Rol30(num2);
				num2 = num;
				num = num11;
			}
			for (int m = 60; m != 80; m++)
			{
				uint num12 = num2 ^ num3 ^ num4;
				uint num13 = (uint)((int)(Rol5(num) + num12 + num5) + -899497514) + w[m];
				num5 = num4;
				num4 = num3;
				num3 = Rol30(num2);
				num2 = num;
				num = num13;
			}
			w[80] += num;
			w[81] += num2;
			w[82] += num3;
			w[83] += num4;
			w[84] += num5;
			length += 512L;
			pos = 0;
		}

		private static uint Rol1(uint input)
		{
			return (input << 1) | (input >> 31);
		}

		private static uint Rol5(uint input)
		{
			return (input << 5) | (input >> 27);
		}

		private static uint Rol30(uint input)
		{
			return (input << 30) | (input >> 2);
		}
	}

	private class OverideEventProvider : EventProvider
	{
		private EventSource m_eventSource;

		public OverideEventProvider(EventSource eventSource)
		{
			m_eventSource = eventSource;
		}

		protected override void OnControllerCommand(ControllerCommand command, IDictionary<string, string> arguments, int perEventSourceSessionId, int etwSessionId)
		{
			EventListener listener = null;
			m_eventSource.SendCommand(listener, perEventSourceSessionId, etwSessionId, (EventCommand)command, IsEnabled(), base.Level, base.MatchAnyKeyword, arguments);
		}
	}

	internal struct EventMetadata
	{
		public EventDescriptor Descriptor;

		public EventTags Tags;

		public bool EnabledForAnyListener;

		public bool EnabledForETW;

		public bool HasRelatedActivityID;

		public byte TriggersActivityTracking;

		public string Name;

		public string Message;

		public ParameterInfo[] Parameters;

		public TraceLoggingEventTypes TraceLoggingEventTypes;

		public EventActivityOptions ActivityOptions;
	}

	private string m_name;

	internal int m_id;

	private Guid m_guid;

	internal volatile EventMetadata[] m_eventData;

	private volatile byte[] m_rawManifest;

	private EventHandler<EventCommandEventArgs> m_eventCommandExecuted;

	private EventSourceSettings m_config;

	private bool m_eventSourceEnabled;

	internal EventLevel m_level;

	internal EventKeywords m_matchAnyKeyword;

	internal volatile EventDispatcher m_Dispatchers;

	private volatile OverideEventProvider m_provider;

	private bool m_completelyInited;

	private Exception m_constructionException;

	private byte m_outOfBandMessageCount;

	private EventCommandEventArgs m_deferredCommands;

	private string[] m_traits;

	internal static uint s_currentPid;

	[ThreadStatic]
	private static byte m_EventSourceExceptionRecurenceCount = 0;

	internal volatile ulong[] m_channelData;

	private SessionMask m_curLiveSessions;

	private EtwSession[] m_etwSessionIdMap;

	private List<EtwSession> m_legacySessions;

	internal long m_keywordTriggers;

	internal SessionMask m_activityFilteringForETWEnabled;

	internal static Action<Guid> s_activityDying;

	private ActivityTracker m_activityTracker;

	internal const string s_ActivityStartSuffix = "Start";

	internal const string s_ActivityStopSuffix = "Stop";

	private static readonly byte[] namespaceBytes = new byte[16]
	{
		72, 44, 45, 178, 195, 144, 71, 200, 135, 248,
		26, 21, 191, 193, 48, 251
	};

	private static readonly Guid AspNetEventSourceGuid = new Guid("ee799f41-cfa5-550b-bf2c-344747c1c668");

	private byte[] providerMetadata;

	[__DynamicallyInvokable]
	public string Name
	{
		[__DynamicallyInvokable]
		get
		{
			return m_name;
		}
	}

	[__DynamicallyInvokable]
	public Guid Guid
	{
		[__DynamicallyInvokable]
		get
		{
			return m_guid;
		}
	}

	[__DynamicallyInvokable]
	public EventSourceSettings Settings
	{
		[__DynamicallyInvokable]
		get
		{
			return m_config;
		}
	}

	[__DynamicallyInvokable]
	public static Guid CurrentThreadActivityId
	{
		[SecuritySafeCritical]
		[__DynamicallyInvokable]
		get
		{
			Guid ActivityId = default(Guid);
			UnsafeNativeMethods.ManifestEtw.EventActivityIdControl(UnsafeNativeMethods.ManifestEtw.ActivityControl.EVENT_ACTIVITY_CTRL_GET_ID, ref ActivityId);
			return ActivityId;
		}
	}

	internal static Guid InternalCurrentThreadActivityId
	{
		[SecurityCritical]
		get
		{
			Guid guid = CurrentThreadActivityId;
			if (guid == Guid.Empty)
			{
				guid = FallbackActivityId;
			}
			return guid;
		}
	}

	internal static Guid FallbackActivityId
	{
		[SecurityCritical]
		get
		{
			return new Guid((uint)AppDomain.GetCurrentThreadId(), (ushort)s_currentPid, (ushort)(s_currentPid >> 16), 148, 27, 135, 213, 166, 92, 54, 100);
		}
	}

	[__DynamicallyInvokable]
	public Exception ConstructionException
	{
		[__DynamicallyInvokable]
		get
		{
			return m_constructionException;
		}
	}

	private bool IsDisposed
	{
		get
		{
			if (m_provider != null)
			{
				return m_provider.m_disposed;
			}
			return true;
		}
	}

	private bool ThrowOnEventWriteErrors
	{
		get
		{
			return (m_config & EventSourceSettings.ThrowOnEventWriteErrors) != 0;
		}
		set
		{
			if (value)
			{
				m_config |= EventSourceSettings.ThrowOnEventWriteErrors;
			}
			else
			{
				m_config &= ~EventSourceSettings.ThrowOnEventWriteErrors;
			}
		}
	}

	private bool SelfDescribingEvents
	{
		get
		{
			return (m_config & EventSourceSettings.EtwSelfDescribingEventFormat) != 0;
		}
		set
		{
			if (!value)
			{
				m_config |= EventSourceSettings.EtwManifestEventFormat;
				m_config &= ~EventSourceSettings.EtwSelfDescribingEventFormat;
			}
			else
			{
				m_config |= EventSourceSettings.EtwSelfDescribingEventFormat;
				m_config &= ~EventSourceSettings.EtwManifestEventFormat;
			}
		}
	}

	public event EventHandler<EventCommandEventArgs> EventCommandExecuted
	{
		add
		{
			m_eventCommandExecuted = (EventHandler<EventCommandEventArgs>)Delegate.Combine(m_eventCommandExecuted, value);
			for (EventCommandEventArgs e = m_deferredCommands; e != null; e = e.nextCommand)
			{
				value(this, e);
			}
		}
		remove
		{
			m_eventCommandExecuted = (EventHandler<EventCommandEventArgs>)Delegate.Remove(m_eventCommandExecuted, value);
		}
	}

	[__DynamicallyInvokable]
	public bool IsEnabled()
	{
		return m_eventSourceEnabled;
	}

	[__DynamicallyInvokable]
	public bool IsEnabled(EventLevel level, EventKeywords keywords)
	{
		return IsEnabled(level, keywords, EventChannel.None);
	}

	[__DynamicallyInvokable]
	public bool IsEnabled(EventLevel level, EventKeywords keywords, EventChannel channel)
	{
		if (!m_eventSourceEnabled)
		{
			return false;
		}
		if (!IsEnabledCommon(m_eventSourceEnabled, m_level, m_matchAnyKeyword, level, keywords, channel))
		{
			return false;
		}
		return true;
	}

	[__DynamicallyInvokable]
	public static Guid GetGuid(Type eventSourceType)
	{
		if (eventSourceType == null)
		{
			throw new ArgumentNullException("eventSourceType");
		}
		EventSourceAttribute eventSourceAttribute = (EventSourceAttribute)GetCustomAttributeHelper(eventSourceType, typeof(EventSourceAttribute));
		string name = eventSourceType.Name;
		if (eventSourceAttribute != null)
		{
			if (eventSourceAttribute.Guid != null)
			{
				Guid result = Guid.Empty;
				if (Guid.TryParse(eventSourceAttribute.Guid, out result))
				{
					return result;
				}
			}
			if (eventSourceAttribute.Name != null)
			{
				name = eventSourceAttribute.Name;
			}
		}
		if (name == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidTypeName"), "eventSourceType");
		}
		return GenerateGuidFromName(name.ToUpperInvariant());
	}

	[__DynamicallyInvokable]
	public static string GetName(Type eventSourceType)
	{
		return GetName(eventSourceType, EventManifestOptions.None);
	}

	[__DynamicallyInvokable]
	public static string GenerateManifest(Type eventSourceType, string assemblyPathToIncludeInManifest)
	{
		return GenerateManifest(eventSourceType, assemblyPathToIncludeInManifest, EventManifestOptions.None);
	}

	[__DynamicallyInvokable]
	public static string GenerateManifest(Type eventSourceType, string assemblyPathToIncludeInManifest, EventManifestOptions flags)
	{
		if (eventSourceType == null)
		{
			throw new ArgumentNullException("eventSourceType");
		}
		byte[] array = CreateManifestAndDescriptors(eventSourceType, assemblyPathToIncludeInManifest, null, flags);
		if (array != null)
		{
			return Encoding.UTF8.GetString(array, 0, array.Length);
		}
		return null;
	}

	[__DynamicallyInvokable]
	public static IEnumerable<EventSource> GetSources()
	{
		List<EventSource> list = new List<EventSource>();
		lock (EventListener.EventListenersLock)
		{
			foreach (WeakReference s_EventSource in EventListener.s_EventSources)
			{
				if (s_EventSource.Target is EventSource { IsDisposed: false } eventSource)
				{
					list.Add(eventSource);
				}
			}
			return list;
		}
	}

	[__DynamicallyInvokable]
	public static void SendCommand(EventSource eventSource, EventCommand command, IDictionary<string, string> commandArguments)
	{
		if (eventSource == null)
		{
			throw new ArgumentNullException("eventSource");
		}
		if (command <= EventCommand.Update && command != EventCommand.SendManifest)
		{
			throw new ArgumentException(Environment.GetResourceString("EventSource_InvalidCommand"), "command");
		}
		eventSource.SendCommand(null, 0, 0, command, enable: true, EventLevel.LogAlways, EventKeywords.None, commandArguments);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static void SetCurrentThreadActivityId(Guid activityId)
	{
		Guid guid = activityId;
		if (UnsafeNativeMethods.ManifestEtw.EventActivityIdControl(UnsafeNativeMethods.ManifestEtw.ActivityControl.EVENT_ACTIVITY_CTRL_GET_SET_ID, ref activityId) == 0)
		{
			Action<Guid> action = s_activityDying;
			if (action != null && guid != activityId)
			{
				if (activityId == Guid.Empty)
				{
					activityId = FallbackActivityId;
				}
				action(activityId);
			}
		}
		if (TplEtwProvider.Log != null)
		{
			TplEtwProvider.Log.SetActivityId(activityId);
		}
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static void SetCurrentThreadActivityId(Guid activityId, out Guid oldActivityThatWillContinue)
	{
		oldActivityThatWillContinue = activityId;
		UnsafeNativeMethods.ManifestEtw.EventActivityIdControl(UnsafeNativeMethods.ManifestEtw.ActivityControl.EVENT_ACTIVITY_CTRL_GET_SET_ID, ref oldActivityThatWillContinue);
		if (TplEtwProvider.Log != null)
		{
			TplEtwProvider.Log.SetActivityId(activityId);
		}
	}

	[__DynamicallyInvokable]
	public string GetTrait(string key)
	{
		if (m_traits != null)
		{
			for (int i = 0; i < m_traits.Length - 1; i += 2)
			{
				if (m_traits[i] == key)
				{
					return m_traits[i + 1];
				}
			}
		}
		return null;
	}

	[__DynamicallyInvokable]
	public override string ToString()
	{
		return Environment.GetResourceString("EventSource_ToString", Name, Guid);
	}

	[__DynamicallyInvokable]
	protected EventSource()
		: this(EventSourceSettings.EtwManifestEventFormat)
	{
	}

	[__DynamicallyInvokable]
	protected EventSource(bool throwOnEventWriteErrors)
		: this((EventSourceSettings)(4 | (throwOnEventWriteErrors ? 1 : 0)))
	{
	}

	[__DynamicallyInvokable]
	protected EventSource(EventSourceSettings settings)
		: this(settings, (string[])null)
	{
	}

	[__DynamicallyInvokable]
	protected EventSource(EventSourceSettings settings, params string[] traits)
	{
		m_config = ValidateSettings(settings);
		Type type = GetType();
		Initialize(GetGuid(type), GetName(type), traits);
	}

	[__DynamicallyInvokable]
	protected virtual void OnEventCommand(EventCommandEventArgs command)
	{
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	protected unsafe void WriteEvent(int eventId)
	{
		WriteEventCore(eventId, 0, null);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	protected unsafe void WriteEvent(int eventId, int arg1)
	{
		if (m_eventSourceEnabled)
		{
			EventData* ptr = stackalloc EventData[1];
			ptr->DataPointer = (IntPtr)(&arg1);
			ptr->Size = 4;
			WriteEventCore(eventId, 1, ptr);
		}
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	protected unsafe void WriteEvent(int eventId, int arg1, int arg2)
	{
		if (m_eventSourceEnabled)
		{
			EventData* ptr = stackalloc EventData[2];
			ptr->DataPointer = (IntPtr)(&arg1);
			ptr->Size = 4;
			ptr[1].DataPointer = (IntPtr)(&arg2);
			ptr[1].Size = 4;
			WriteEventCore(eventId, 2, ptr);
		}
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	protected unsafe void WriteEvent(int eventId, int arg1, int arg2, int arg3)
	{
		if (m_eventSourceEnabled)
		{
			EventData* ptr = stackalloc EventData[3];
			ptr->DataPointer = (IntPtr)(&arg1);
			ptr->Size = 4;
			ptr[1].DataPointer = (IntPtr)(&arg2);
			ptr[1].Size = 4;
			ptr[2].DataPointer = (IntPtr)(&arg3);
			ptr[2].Size = 4;
			WriteEventCore(eventId, 3, ptr);
		}
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	protected unsafe void WriteEvent(int eventId, long arg1)
	{
		if (m_eventSourceEnabled)
		{
			EventData* ptr = stackalloc EventData[1];
			ptr->DataPointer = (IntPtr)(&arg1);
			ptr->Size = 8;
			WriteEventCore(eventId, 1, ptr);
		}
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	protected unsafe void WriteEvent(int eventId, long arg1, long arg2)
	{
		if (m_eventSourceEnabled)
		{
			EventData* ptr = stackalloc EventData[2];
			ptr->DataPointer = (IntPtr)(&arg1);
			ptr->Size = 8;
			ptr[1].DataPointer = (IntPtr)(&arg2);
			ptr[1].Size = 8;
			WriteEventCore(eventId, 2, ptr);
		}
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	protected unsafe void WriteEvent(int eventId, long arg1, long arg2, long arg3)
	{
		if (m_eventSourceEnabled)
		{
			EventData* ptr = stackalloc EventData[3];
			ptr->DataPointer = (IntPtr)(&arg1);
			ptr->Size = 8;
			ptr[1].DataPointer = (IntPtr)(&arg2);
			ptr[1].Size = 8;
			ptr[2].DataPointer = (IntPtr)(&arg3);
			ptr[2].Size = 8;
			WriteEventCore(eventId, 3, ptr);
		}
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	protected unsafe void WriteEvent(int eventId, string arg1)
	{
		if (m_eventSourceEnabled)
		{
			if (arg1 == null)
			{
				arg1 = "";
			}
			fixed (char* ptr = arg1)
			{
				EventData* ptr2 = stackalloc EventData[1];
				ptr2->DataPointer = (IntPtr)ptr;
				ptr2->Size = (arg1.Length + 1) * 2;
				WriteEventCore(eventId, 1, ptr2);
			}
		}
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	protected unsafe void WriteEvent(int eventId, string arg1, string arg2)
	{
		if (!m_eventSourceEnabled)
		{
			return;
		}
		if (arg1 == null)
		{
			arg1 = "";
		}
		if (arg2 == null)
		{
			arg2 = "";
		}
		fixed (char* ptr = arg1)
		{
			fixed (char* ptr2 = arg2)
			{
				EventData* ptr3 = stackalloc EventData[2];
				ptr3->DataPointer = (IntPtr)ptr;
				ptr3->Size = (arg1.Length + 1) * 2;
				ptr3[1].DataPointer = (IntPtr)ptr2;
				ptr3[1].Size = (arg2.Length + 1) * 2;
				WriteEventCore(eventId, 2, ptr3);
			}
		}
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	protected unsafe void WriteEvent(int eventId, string arg1, string arg2, string arg3)
	{
		if (!m_eventSourceEnabled)
		{
			return;
		}
		if (arg1 == null)
		{
			arg1 = "";
		}
		if (arg2 == null)
		{
			arg2 = "";
		}
		if (arg3 == null)
		{
			arg3 = "";
		}
		fixed (char* ptr = arg1)
		{
			fixed (char* ptr2 = arg2)
			{
				fixed (char* ptr3 = arg3)
				{
					EventData* ptr4 = stackalloc EventData[3];
					ptr4->DataPointer = (IntPtr)ptr;
					ptr4->Size = (arg1.Length + 1) * 2;
					ptr4[1].DataPointer = (IntPtr)ptr2;
					ptr4[1].Size = (arg2.Length + 1) * 2;
					ptr4[2].DataPointer = (IntPtr)ptr3;
					ptr4[2].Size = (arg3.Length + 1) * 2;
					WriteEventCore(eventId, 3, ptr4);
				}
			}
		}
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	protected unsafe void WriteEvent(int eventId, string arg1, int arg2)
	{
		if (m_eventSourceEnabled)
		{
			if (arg1 == null)
			{
				arg1 = "";
			}
			fixed (char* ptr = arg1)
			{
				EventData* ptr2 = stackalloc EventData[2];
				ptr2->DataPointer = (IntPtr)ptr;
				ptr2->Size = (arg1.Length + 1) * 2;
				ptr2[1].DataPointer = (IntPtr)(&arg2);
				ptr2[1].Size = 4;
				WriteEventCore(eventId, 2, ptr2);
			}
		}
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	protected unsafe void WriteEvent(int eventId, string arg1, int arg2, int arg3)
	{
		if (m_eventSourceEnabled)
		{
			if (arg1 == null)
			{
				arg1 = "";
			}
			fixed (char* ptr = arg1)
			{
				EventData* ptr2 = stackalloc EventData[3];
				ptr2->DataPointer = (IntPtr)ptr;
				ptr2->Size = (arg1.Length + 1) * 2;
				ptr2[1].DataPointer = (IntPtr)(&arg2);
				ptr2[1].Size = 4;
				ptr2[2].DataPointer = (IntPtr)(&arg3);
				ptr2[2].Size = 4;
				WriteEventCore(eventId, 3, ptr2);
			}
		}
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	protected unsafe void WriteEvent(int eventId, string arg1, long arg2)
	{
		if (m_eventSourceEnabled)
		{
			if (arg1 == null)
			{
				arg1 = "";
			}
			fixed (char* ptr = arg1)
			{
				EventData* ptr2 = stackalloc EventData[2];
				ptr2->DataPointer = (IntPtr)ptr;
				ptr2->Size = (arg1.Length + 1) * 2;
				ptr2[1].DataPointer = (IntPtr)(&arg2);
				ptr2[1].Size = 8;
				WriteEventCore(eventId, 2, ptr2);
			}
		}
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	protected unsafe void WriteEvent(int eventId, long arg1, string arg2)
	{
		if (m_eventSourceEnabled)
		{
			if (arg2 == null)
			{
				arg2 = "";
			}
			fixed (char* ptr = arg2)
			{
				EventData* ptr2 = stackalloc EventData[2];
				ptr2->DataPointer = (IntPtr)(&arg1);
				ptr2->Size = 8;
				ptr2[1].DataPointer = (IntPtr)ptr;
				ptr2[1].Size = (arg2.Length + 1) * 2;
				WriteEventCore(eventId, 2, ptr2);
			}
		}
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	protected unsafe void WriteEvent(int eventId, int arg1, string arg2)
	{
		if (m_eventSourceEnabled)
		{
			if (arg2 == null)
			{
				arg2 = "";
			}
			fixed (char* ptr = arg2)
			{
				EventData* ptr2 = stackalloc EventData[2];
				ptr2->DataPointer = (IntPtr)(&arg1);
				ptr2->Size = 4;
				ptr2[1].DataPointer = (IntPtr)ptr;
				ptr2[1].Size = (arg2.Length + 1) * 2;
				WriteEventCore(eventId, 2, ptr2);
			}
		}
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	protected unsafe void WriteEvent(int eventId, byte[] arg1)
	{
		if (m_eventSourceEnabled)
		{
			if (arg1 == null)
			{
				arg1 = new byte[0];
			}
			int size = arg1.Length;
			fixed (byte* ptr = &arg1[0])
			{
				EventData* ptr2 = stackalloc EventData[2];
				ptr2->DataPointer = (IntPtr)(&size);
				ptr2->Size = 4;
				ptr2[1].DataPointer = (IntPtr)ptr;
				ptr2[1].Size = size;
				WriteEventCore(eventId, 2, ptr2);
			}
		}
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	protected unsafe void WriteEvent(int eventId, long arg1, byte[] arg2)
	{
		if (m_eventSourceEnabled)
		{
			if (arg2 == null)
			{
				arg2 = new byte[0];
			}
			int size = arg2.Length;
			fixed (byte* ptr = &arg2[0])
			{
				EventData* ptr2 = stackalloc EventData[3];
				ptr2->DataPointer = (IntPtr)(&arg1);
				ptr2->Size = 8;
				ptr2[1].DataPointer = (IntPtr)(&size);
				ptr2[1].Size = 4;
				ptr2[2].DataPointer = (IntPtr)ptr;
				ptr2[2].Size = size;
				WriteEventCore(eventId, 3, ptr2);
			}
		}
	}

	[SecurityCritical]
	[CLSCompliant(false)]
	protected unsafe void WriteEventCore(int eventId, int eventDataCount, EventData* data)
	{
		WriteEventWithRelatedActivityIdCore(eventId, null, eventDataCount, data);
	}

	[SecurityCritical]
	[CLSCompliant(false)]
	protected unsafe void WriteEventWithRelatedActivityIdCore(int eventId, Guid* relatedActivityId, int eventDataCount, EventData* data)
	{
		if (!m_eventSourceEnabled)
		{
			return;
		}
		try
		{
			if (relatedActivityId != null)
			{
				ValidateEventOpcodeForTransfer(ref m_eventData[eventId], m_eventData[eventId].Name);
			}
			EventOpcode opcode = (EventOpcode)m_eventData[eventId].Descriptor.Opcode;
			EventActivityOptions activityOptions = m_eventData[eventId].ActivityOptions;
			Guid* activityID = null;
			Guid activityId = Guid.Empty;
			Guid relatedActivityId2 = Guid.Empty;
			if (opcode != EventOpcode.Info && relatedActivityId == null && (activityOptions & EventActivityOptions.Disable) == 0)
			{
				switch (opcode)
				{
				case EventOpcode.Start:
					m_activityTracker.OnStart(m_name, m_eventData[eventId].Name, m_eventData[eventId].Descriptor.Task, ref activityId, ref relatedActivityId2, m_eventData[eventId].ActivityOptions);
					break;
				case EventOpcode.Stop:
					m_activityTracker.OnStop(m_name, m_eventData[eventId].Name, m_eventData[eventId].Descriptor.Task, ref activityId);
					break;
				}
				if (activityId != Guid.Empty)
				{
					activityID = &activityId;
				}
				if (relatedActivityId2 != Guid.Empty)
				{
					relatedActivityId = &relatedActivityId2;
				}
			}
			if (m_eventData[eventId].EnabledForETW)
			{
				SessionMask sessionMask = SessionMask.All;
				if ((ulong)m_curLiveSessions != 0L)
				{
					sessionMask = GetEtwSessionMask(eventId, relatedActivityId);
				}
				if ((ulong)sessionMask != 0L || (m_legacySessions != null && m_legacySessions.Count > 0))
				{
					if (!SelfDescribingEvents)
					{
						if (sessionMask.IsEqualOrSupersetOf(m_curLiveSessions))
						{
							if (!m_provider.WriteEvent(ref m_eventData[eventId].Descriptor, activityID, relatedActivityId, eventDataCount, (IntPtr)data))
							{
								ThrowEventSourceException(m_eventData[eventId].Name);
							}
						}
						else
						{
							long num = m_eventData[eventId].Descriptor.Keywords & (long)(~SessionMask.All.ToEventKeywords());
							EventDescriptor eventDescriptor = new EventDescriptor(m_eventData[eventId].Descriptor.EventId, m_eventData[eventId].Descriptor.Version, m_eventData[eventId].Descriptor.Channel, m_eventData[eventId].Descriptor.Level, m_eventData[eventId].Descriptor.Opcode, m_eventData[eventId].Descriptor.Task, (long)sessionMask.ToEventKeywords() | num);
							if (!m_provider.WriteEvent(ref eventDescriptor, activityID, relatedActivityId, eventDataCount, (IntPtr)data))
							{
								ThrowEventSourceException(m_eventData[eventId].Name);
							}
						}
					}
					else
					{
						TraceLoggingEventTypes traceLoggingEventTypes = m_eventData[eventId].TraceLoggingEventTypes;
						if (traceLoggingEventTypes == null)
						{
							traceLoggingEventTypes = new TraceLoggingEventTypes(m_eventData[eventId].Name, EventTags.None, m_eventData[eventId].Parameters);
							Interlocked.CompareExchange(ref m_eventData[eventId].TraceLoggingEventTypes, traceLoggingEventTypes, null);
						}
						long num2 = m_eventData[eventId].Descriptor.Keywords & (long)(~SessionMask.All.ToEventKeywords());
						EventSourceOptions options = new EventSourceOptions
						{
							Keywords = (EventKeywords)((long)sessionMask.ToEventKeywords() | num2),
							Level = (EventLevel)m_eventData[eventId].Descriptor.Level,
							Opcode = (EventOpcode)m_eventData[eventId].Descriptor.Opcode
						};
						WriteMultiMerge(m_eventData[eventId].Name, ref options, traceLoggingEventTypes, activityID, relatedActivityId, data);
					}
				}
			}
			if (m_Dispatchers != null && m_eventData[eventId].EnabledForAnyListener)
			{
				WriteToAllListeners(eventId, activityID, relatedActivityId, eventDataCount, data);
			}
		}
		catch (Exception ex)
		{
			if (ex is EventSourceException)
			{
				throw;
			}
			ThrowEventSourceException(m_eventData[eventId].Name, ex);
		}
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	protected unsafe void WriteEvent(int eventId, params object[] args)
	{
		WriteEventVarargs(eventId, null, args);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	protected unsafe void WriteEventWithRelatedActivityId(int eventId, Guid relatedActivityId, params object[] args)
	{
		WriteEventVarargs(eventId, &relatedActivityId, args);
	}

	[__DynamicallyInvokable]
	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	[__DynamicallyInvokable]
	protected virtual void Dispose(bool disposing)
	{
		if (disposing)
		{
			if (m_eventSourceEnabled)
			{
				try
				{
					SendManifest(m_rawManifest);
				}
				catch (Exception)
				{
				}
				m_eventSourceEnabled = false;
			}
			if (m_provider != null)
			{
				m_provider.Dispose();
				m_provider = null;
			}
		}
		m_eventSourceEnabled = false;
	}

	[__DynamicallyInvokable]
	~EventSource()
	{
		Dispose(disposing: false);
	}

	internal void WriteStringToListener(EventListener listener, string msg, SessionMask m)
	{
		if (m_eventSourceEnabled)
		{
			if (listener == null)
			{
				WriteEventString(EventLevel.LogAlways, (long)m.ToEventKeywords(), msg);
				return;
			}
			List<object> list = new List<object>();
			list.Add(msg);
			EventWrittenEventArgs e = new EventWrittenEventArgs(this);
			e.EventId = 0;
			e.Payload = new ReadOnlyCollection<object>(list);
			listener.OnEventWritten(e);
		}
	}

	[SecurityCritical]
	private unsafe void WriteEventRaw(string eventName, ref EventDescriptor eventDescriptor, Guid* activityID, Guid* relatedActivityID, int dataCount, IntPtr data)
	{
		if (m_provider == null)
		{
			ThrowEventSourceException(eventName);
		}
		else if (!m_provider.WriteEventRaw(ref eventDescriptor, activityID, relatedActivityID, dataCount, data))
		{
			ThrowEventSourceException(eventName);
		}
	}

	internal EventSource(Guid eventSourceGuid, string eventSourceName)
		: this(eventSourceGuid, eventSourceName, EventSourceSettings.EtwManifestEventFormat)
	{
	}

	internal EventSource(Guid eventSourceGuid, string eventSourceName, EventSourceSettings settings, string[] traits = null)
	{
		m_config = ValidateSettings(settings);
		Initialize(eventSourceGuid, eventSourceName, traits);
	}

	[SecuritySafeCritical]
	private unsafe void Initialize(Guid eventSourceGuid, string eventSourceName, string[] traits)
	{
		try
		{
			m_traits = traits;
			if (m_traits != null && m_traits.Length % 2 != 0)
			{
				throw new ArgumentException(Environment.GetResourceString("TraitEven"), "traits");
			}
			if (eventSourceGuid == Guid.Empty)
			{
				throw new ArgumentException(Environment.GetResourceString("EventSource_NeedGuid"));
			}
			if (eventSourceName == null)
			{
				throw new ArgumentException(Environment.GetResourceString("EventSource_NeedName"));
			}
			m_name = eventSourceName;
			m_guid = eventSourceGuid;
			m_curLiveSessions = new SessionMask(0u);
			m_etwSessionIdMap = new EtwSession[4];
			m_activityTracker = ActivityTracker.Instance;
			InitializeProviderMetadata();
			OverideEventProvider overideEventProvider = new OverideEventProvider(this);
			overideEventProvider.Register(eventSourceGuid);
			EventListener.AddEventSource(this);
			m_provider = overideEventProvider;
			int num = Environment.OSVersion.Version.Major * 10 + Environment.OSVersion.Version.Minor;
			if (Name != "System.Diagnostics.Eventing.FrameworkEventSource" || num >= 62)
			{
				fixed (byte* ptr = providerMetadata)
				{
					void* data = ptr;
					int num2 = m_provider.SetInformation(UnsafeNativeMethods.ManifestEtw.EVENT_INFO_CLASS.SetTraits, data, providerMetadata.Length);
				}
			}
			m_completelyInited = true;
		}
		catch (Exception ex)
		{
			if (m_constructionException == null)
			{
				m_constructionException = ex;
			}
			ReportOutOfBandMessage("ERROR: Exception during construction of EventSource " + Name + ": " + ex.Message, flush: true);
		}
		lock (EventListener.EventListenersLock)
		{
			for (EventCommandEventArgs e = m_deferredCommands; e != null; e = e.nextCommand)
			{
				DoCommand(e);
			}
		}
	}

	private static string GetName(Type eventSourceType, EventManifestOptions flags)
	{
		if (eventSourceType == null)
		{
			throw new ArgumentNullException("eventSourceType");
		}
		EventSourceAttribute eventSourceAttribute = (EventSourceAttribute)GetCustomAttributeHelper(eventSourceType, typeof(EventSourceAttribute), flags);
		if (eventSourceAttribute != null && eventSourceAttribute.Name != null)
		{
			return eventSourceAttribute.Name;
		}
		return eventSourceType.Name;
	}

	private static Guid GenerateGuidFromName(string name)
	{
		byte[] array = Encoding.BigEndianUnicode.GetBytes(name);
		Sha1ForNonSecretPurposes sha1ForNonSecretPurposes = default(Sha1ForNonSecretPurposes);
		sha1ForNonSecretPurposes.Start();
		sha1ForNonSecretPurposes.Append(namespaceBytes);
		sha1ForNonSecretPurposes.Append(array);
		Array.Resize(ref array, 16);
		sha1ForNonSecretPurposes.Finish(array);
		array[7] = (byte)((array[7] & 0xF) | 0x50);
		return new Guid(array);
	}

	[SecurityCritical]
	private unsafe object DecodeObject(int eventId, int parameterId, ref EventData* data)
	{
		IntPtr dataPointer = data->DataPointer;
		data++;
		Type type = m_eventData[eventId].Parameters[parameterId].ParameterType;
		while (true)
		{
			if (type == typeof(IntPtr))
			{
				return *(IntPtr*)(void*)dataPointer;
			}
			if (type == typeof(int))
			{
				return *(int*)(void*)dataPointer;
			}
			if (type == typeof(uint))
			{
				return *(uint*)(void*)dataPointer;
			}
			if (type == typeof(long))
			{
				return *(long*)(void*)dataPointer;
			}
			if (type == typeof(ulong))
			{
				return *(ulong*)(void*)dataPointer;
			}
			if (type == typeof(byte))
			{
				return *(byte*)(void*)dataPointer;
			}
			if (type == typeof(sbyte))
			{
				return *(sbyte*)(void*)dataPointer;
			}
			if (type == typeof(short))
			{
				return *(short*)(void*)dataPointer;
			}
			if (type == typeof(ushort))
			{
				return *(ushort*)(void*)dataPointer;
			}
			if (type == typeof(float))
			{
				return *(float*)(void*)dataPointer;
			}
			if (type == typeof(double))
			{
				return *(double*)(void*)dataPointer;
			}
			if (type == typeof(decimal))
			{
				return *(decimal*)(void*)dataPointer;
			}
			if (type == typeof(bool))
			{
				if (*(int*)(void*)dataPointer == 1)
				{
					return true;
				}
				return false;
			}
			if (type == typeof(Guid))
			{
				return *(Guid*)(void*)dataPointer;
			}
			if (type == typeof(char))
			{
				return *(char*)(void*)dataPointer;
			}
			if (type == typeof(DateTime))
			{
				long fileTime = *(long*)(void*)dataPointer;
				return DateTime.FromFileTimeUtc(fileTime);
			}
			if (type == typeof(byte[]))
			{
				int num = *(int*)(void*)dataPointer;
				byte[] array = new byte[num];
				dataPointer = data->DataPointer;
				data++;
				for (int i = 0; i < num; i++)
				{
					array[i] = ((byte*)(void*)dataPointer)[i];
				}
				return array;
			}
			if (type == typeof(byte*))
			{
				return null;
			}
			if (!type.IsEnum())
			{
				break;
			}
			type = Enum.GetUnderlyingType(type);
		}
		return Marshal.PtrToStringUni(dataPointer);
	}

	private EventDispatcher GetDispatcher(EventListener listener)
	{
		EventDispatcher eventDispatcher;
		for (eventDispatcher = m_Dispatchers; eventDispatcher != null; eventDispatcher = eventDispatcher.m_Next)
		{
			if (eventDispatcher.m_Listener == listener)
			{
				return eventDispatcher;
			}
		}
		return eventDispatcher;
	}

	[SecurityCritical]
	private unsafe void WriteEventVarargs(int eventId, Guid* childActivityID, object[] args)
	{
		if (!m_eventSourceEnabled)
		{
			return;
		}
		try
		{
			if (childActivityID != null)
			{
				ValidateEventOpcodeForTransfer(ref m_eventData[eventId], m_eventData[eventId].Name);
				if (!m_eventData[eventId].HasRelatedActivityID)
				{
					throw new ArgumentException(Environment.GetResourceString("EventSource_NoRelatedActivityId"));
				}
			}
			LogEventArgsMismatches(m_eventData[eventId].Parameters, args);
			Guid* activityID = null;
			Guid activityId = Guid.Empty;
			Guid relatedActivityId = Guid.Empty;
			EventOpcode opcode = (EventOpcode)m_eventData[eventId].Descriptor.Opcode;
			EventActivityOptions activityOptions = m_eventData[eventId].ActivityOptions;
			if (childActivityID == null && (activityOptions & EventActivityOptions.Disable) == 0)
			{
				switch (opcode)
				{
				case EventOpcode.Start:
					m_activityTracker.OnStart(m_name, m_eventData[eventId].Name, m_eventData[eventId].Descriptor.Task, ref activityId, ref relatedActivityId, m_eventData[eventId].ActivityOptions);
					break;
				case EventOpcode.Stop:
					m_activityTracker.OnStop(m_name, m_eventData[eventId].Name, m_eventData[eventId].Descriptor.Task, ref activityId);
					break;
				}
				if (activityId != Guid.Empty)
				{
					activityID = &activityId;
				}
				if (relatedActivityId != Guid.Empty)
				{
					childActivityID = &relatedActivityId;
				}
			}
			if (m_eventData[eventId].EnabledForETW)
			{
				SessionMask sessionMask = SessionMask.All;
				if ((ulong)m_curLiveSessions != 0L)
				{
					sessionMask = GetEtwSessionMask(eventId, childActivityID);
				}
				if ((ulong)sessionMask != 0L || (m_legacySessions != null && m_legacySessions.Count > 0))
				{
					if (!SelfDescribingEvents)
					{
						if (sessionMask.IsEqualOrSupersetOf(m_curLiveSessions))
						{
							if (!m_provider.WriteEvent(ref m_eventData[eventId].Descriptor, activityID, childActivityID, args))
							{
								ThrowEventSourceException(m_eventData[eventId].Name);
							}
						}
						else
						{
							long num = m_eventData[eventId].Descriptor.Keywords & (long)(~SessionMask.All.ToEventKeywords());
							EventDescriptor eventDescriptor = new EventDescriptor(m_eventData[eventId].Descriptor.EventId, m_eventData[eventId].Descriptor.Version, m_eventData[eventId].Descriptor.Channel, m_eventData[eventId].Descriptor.Level, m_eventData[eventId].Descriptor.Opcode, m_eventData[eventId].Descriptor.Task, (long)sessionMask.ToEventKeywords() | num);
							if (!m_provider.WriteEvent(ref eventDescriptor, activityID, childActivityID, args))
							{
								ThrowEventSourceException(m_eventData[eventId].Name);
							}
						}
					}
					else
					{
						TraceLoggingEventTypes traceLoggingEventTypes = m_eventData[eventId].TraceLoggingEventTypes;
						if (traceLoggingEventTypes == null)
						{
							traceLoggingEventTypes = new TraceLoggingEventTypes(m_eventData[eventId].Name, EventTags.None, m_eventData[eventId].Parameters);
							Interlocked.CompareExchange(ref m_eventData[eventId].TraceLoggingEventTypes, traceLoggingEventTypes, null);
						}
						long num2 = m_eventData[eventId].Descriptor.Keywords & (long)(~SessionMask.All.ToEventKeywords());
						EventSourceOptions options = new EventSourceOptions
						{
							Keywords = (EventKeywords)((long)sessionMask.ToEventKeywords() | num2),
							Level = (EventLevel)m_eventData[eventId].Descriptor.Level,
							Opcode = (EventOpcode)m_eventData[eventId].Descriptor.Opcode
						};
						WriteMultiMerge(m_eventData[eventId].Name, ref options, traceLoggingEventTypes, activityID, childActivityID, args);
					}
				}
			}
			if (m_Dispatchers != null && m_eventData[eventId].EnabledForAnyListener)
			{
				if (AppContextSwitches.PreserveEventListnerObjectIdentity)
				{
					WriteToAllListeners(eventId, activityID, childActivityID, args);
					return;
				}
				object[] args2 = SerializeEventArgs(eventId, args);
				WriteToAllListeners(eventId, activityID, childActivityID, args2);
			}
		}
		catch (Exception ex)
		{
			if (ex is EventSourceException)
			{
				throw;
			}
			ThrowEventSourceException(m_eventData[eventId].Name, ex);
		}
	}

	[SecurityCritical]
	private object[] SerializeEventArgs(int eventId, object[] args)
	{
		TraceLoggingEventTypes traceLoggingEventTypes = m_eventData[eventId].TraceLoggingEventTypes;
		if (traceLoggingEventTypes == null)
		{
			traceLoggingEventTypes = new TraceLoggingEventTypes(m_eventData[eventId].Name, EventTags.None, m_eventData[eventId].Parameters);
			Interlocked.CompareExchange(ref m_eventData[eventId].TraceLoggingEventTypes, traceLoggingEventTypes, null);
		}
		object[] array = new object[traceLoggingEventTypes.typeInfos.Length];
		for (int i = 0; i < traceLoggingEventTypes.typeInfos.Length; i++)
		{
			array[i] = traceLoggingEventTypes.typeInfos[i].GetData(args[i]);
		}
		return array;
	}

	private void LogEventArgsMismatches(ParameterInfo[] infos, object[] args)
	{
		bool flag = args.Length == infos.Length;
		int num = 0;
		while (flag && num < args.Length)
		{
			Type parameterType = infos[num].ParameterType;
			if ((args[num] != null && args[num].GetType() != parameterType) || (args[num] == null && (!parameterType.IsGenericType || !(parameterType.GetGenericTypeDefinition() == typeof(Nullable<>)))))
			{
				flag = false;
				break;
			}
			num++;
		}
		if (!flag)
		{
			Debugger.Log(0, null, Environment.GetResourceString("EventSource_VarArgsParameterMismatch") + "\r\n");
		}
	}

	private int GetParamLengthIncludingByteArray(ParameterInfo[] parameters)
	{
		int num = 0;
		foreach (ParameterInfo parameterInfo in parameters)
		{
			num = ((!(parameterInfo.ParameterType == typeof(byte[]))) ? (num + 1) : (num + 2));
		}
		return num;
	}

	[SecurityCritical]
	private unsafe void WriteToAllListeners(int eventId, Guid* activityID, Guid* childActivityID, int eventDataCount, EventData* data)
	{
		int num = m_eventData[eventId].Parameters.Length;
		int paramLengthIncludingByteArray = GetParamLengthIncludingByteArray(m_eventData[eventId].Parameters);
		if (eventDataCount != paramLengthIncludingByteArray)
		{
			ReportOutOfBandMessage(Environment.GetResourceString("EventSource_EventParametersMismatch", eventId, eventDataCount, num), flush: true);
			num = Math.Min(num, eventDataCount);
		}
		object[] array = new object[num];
		EventData* data2 = data;
		for (int i = 0; i < num; i++)
		{
			array[i] = DecodeObject(eventId, i, ref data2);
		}
		WriteToAllListeners(eventId, activityID, childActivityID, array);
	}

	[SecurityCritical]
	private unsafe void WriteToAllListeners(int eventId, Guid* activityID, Guid* childActivityID, params object[] args)
	{
		EventWrittenEventArgs e = new EventWrittenEventArgs(this);
		e.EventId = eventId;
		if (activityID != null)
		{
			e.ActivityId = *activityID;
		}
		if (childActivityID != null)
		{
			e.RelatedActivityId = *childActivityID;
		}
		e.EventName = m_eventData[eventId].Name;
		e.Message = m_eventData[eventId].Message;
		e.Payload = new ReadOnlyCollection<object>(args);
		DispatchToAllListeners(eventId, childActivityID, e);
	}

	[SecurityCritical]
	private unsafe void DispatchToAllListeners(int eventId, Guid* childActivityID, EventWrittenEventArgs eventCallbackArgs)
	{
		Exception ex = null;
		for (EventDispatcher eventDispatcher = m_Dispatchers; eventDispatcher != null; eventDispatcher = eventDispatcher.m_Next)
		{
			if (eventId == -1 || eventDispatcher.m_EventEnabled[eventId])
			{
				ActivityFilter activityFilter = eventDispatcher.m_Listener.m_activityFilter;
				if (activityFilter == null || ActivityFilter.PassesActivityFilter(activityFilter, childActivityID, m_eventData[eventId].TriggersActivityTracking > 0, this, eventId) || !eventDispatcher.m_activityFilteringEnabled)
				{
					try
					{
						eventDispatcher.m_Listener.OnEventWritten(eventCallbackArgs);
					}
					catch (Exception ex2)
					{
						ReportOutOfBandMessage("ERROR: Exception during EventSource.OnEventWritten: " + ex2.Message, flush: false);
						ex = ex2;
					}
				}
			}
		}
		if (ex != null)
		{
			throw new EventSourceException(ex);
		}
	}

	[SecuritySafeCritical]
	private unsafe void WriteEventString(EventLevel level, long keywords, string msgString)
	{
		if (m_provider == null)
		{
			return;
		}
		string text = "EventSourceMessage";
		if (SelfDescribingEvents)
		{
			EventSourceOptions options = new EventSourceOptions
			{
				Keywords = (EventKeywords)keywords,
				Level = level
			};
			var anon = new
			{
				message = msgString
			};
			TraceLoggingEventTypes eventTypes = new TraceLoggingEventTypes(text, EventTags.None, anon.GetType());
			WriteMultiMergeInner(text, ref options, eventTypes, null, null, anon);
			return;
		}
		if (m_rawManifest == null && m_outOfBandMessageCount == 1)
		{
			ManifestBuilder manifestBuilder = new ManifestBuilder(Name, Guid, Name, null, EventManifestOptions.None);
			manifestBuilder.StartEvent(text, new EventAttribute(0)
			{
				Level = EventLevel.LogAlways,
				Task = (EventTask)65534
			});
			manifestBuilder.AddEventParameter(typeof(string), "message");
			manifestBuilder.EndEvent();
			SendManifest(manifestBuilder.CreateManifest());
		}
		fixed (char* ptr = msgString)
		{
			EventDescriptor eventDescriptor = new EventDescriptor(0, 0, 0, (byte)level, 0, 0, keywords);
			EventProvider.EventData eventData = new EventProvider.EventData
			{
				Ptr = (ulong)ptr,
				Size = (uint)(2 * (msgString.Length + 1)),
				Reserved = 0u
			};
			m_provider.WriteEvent(ref eventDescriptor, null, null, 1, (IntPtr)(&eventData));
		}
	}

	private void WriteStringToAllListeners(string eventName, string msg)
	{
		EventWrittenEventArgs e = new EventWrittenEventArgs(this);
		e.EventId = 0;
		e.Message = msg;
		e.Payload = new ReadOnlyCollection<object>(new List<object> { msg });
		e.PayloadNames = new ReadOnlyCollection<string>(new List<string> { "message" });
		e.EventName = eventName;
		for (EventDispatcher eventDispatcher = m_Dispatchers; eventDispatcher != null; eventDispatcher = eventDispatcher.m_Next)
		{
			bool flag = false;
			if (eventDispatcher.m_EventEnabled == null)
			{
				flag = true;
			}
			else
			{
				for (int i = 0; i < eventDispatcher.m_EventEnabled.Length; i++)
				{
					if (eventDispatcher.m_EventEnabled[i])
					{
						flag = true;
						break;
					}
				}
			}
			try
			{
				if (flag)
				{
					eventDispatcher.m_Listener.OnEventWritten(e);
				}
			}
			catch
			{
			}
		}
	}

	[SecurityCritical]
	private unsafe SessionMask GetEtwSessionMask(int eventId, Guid* childActivityID)
	{
		SessionMask result = default(SessionMask);
		for (int i = 0; (long)i < 4L; i++)
		{
			EtwSession etwSession = m_etwSessionIdMap[i];
			if (etwSession != null)
			{
				ActivityFilter activityFilter = etwSession.m_activityFilter;
				if ((activityFilter == null && !m_activityFilteringForETWEnabled[i]) || (activityFilter != null && ActivityFilter.PassesActivityFilter(activityFilter, childActivityID, m_eventData[eventId].TriggersActivityTracking > 0, this, eventId)) || !m_activityFilteringForETWEnabled[i])
				{
					result[i] = true;
				}
			}
		}
		if (m_legacySessions != null && m_legacySessions.Count > 0 && m_eventData[eventId].Descriptor.Opcode == 9)
		{
			Guid* ptr = null;
			foreach (EtwSession legacySession in m_legacySessions)
			{
				if (legacySession == null)
				{
					continue;
				}
				ActivityFilter activityFilter2 = legacySession.m_activityFilter;
				if (activityFilter2 != null)
				{
					if (ptr == null)
					{
						Guid internalCurrentThreadActivityId = InternalCurrentThreadActivityId;
						ptr = &internalCurrentThreadActivityId;
					}
					ActivityFilter.FlowActivityIfNeeded(activityFilter2, ptr, childActivityID);
				}
			}
		}
		return result;
	}

	private bool IsEnabledByDefault(int eventNum, bool enable, EventLevel currentLevel, EventKeywords currentMatchAnyKeyword)
	{
		if (!enable)
		{
			return false;
		}
		EventLevel level = (EventLevel)m_eventData[eventNum].Descriptor.Level;
		EventKeywords eventKeywords = (EventKeywords)(m_eventData[eventNum].Descriptor.Keywords & (long)(~SessionMask.All.ToEventKeywords()));
		EventChannel channel = (EventChannel)m_eventData[eventNum].Descriptor.Channel;
		return IsEnabledCommon(enable, currentLevel, currentMatchAnyKeyword, level, eventKeywords, channel);
	}

	private bool IsEnabledCommon(bool enabled, EventLevel currentLevel, EventKeywords currentMatchAnyKeyword, EventLevel eventLevel, EventKeywords eventKeywords, EventChannel eventChannel)
	{
		if (!enabled)
		{
			return false;
		}
		if (currentLevel != EventLevel.LogAlways && currentLevel < eventLevel)
		{
			return false;
		}
		if (currentMatchAnyKeyword != EventKeywords.None && eventKeywords != EventKeywords.None)
		{
			if (eventChannel != EventChannel.None && m_channelData != null && m_channelData.Length > (int)eventChannel)
			{
				EventKeywords eventKeywords2 = (EventKeywords)((long)m_channelData[(uint)eventChannel] | (long)eventKeywords);
				if (eventKeywords2 != EventKeywords.None && (eventKeywords2 & currentMatchAnyKeyword) == EventKeywords.None)
				{
					return false;
				}
			}
			else if ((eventKeywords & currentMatchAnyKeyword) == EventKeywords.None)
			{
				return false;
			}
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ThrowEventSourceException(string eventName, Exception innerEx = null)
	{
		if (m_EventSourceExceptionRecurenceCount > 0)
		{
			return;
		}
		try
		{
			m_EventSourceExceptionRecurenceCount++;
			string text = "EventSourceException";
			if (eventName != null)
			{
				text = text + " while processing event \"" + eventName + "\"";
			}
			switch (EventProvider.GetLastWriteEventError())
			{
			case EventProvider.WriteEventErrorCode.EventTooBig:
				ReportOutOfBandMessage(text + ": " + Environment.GetResourceString("EventSource_EventTooBig"), flush: true);
				if (ThrowOnEventWriteErrors)
				{
					throw new EventSourceException(Environment.GetResourceString("EventSource_EventTooBig"), innerEx);
				}
				return;
			case EventProvider.WriteEventErrorCode.NoFreeBuffers:
				ReportOutOfBandMessage(text + ": " + Environment.GetResourceString("EventSource_NoFreeBuffers"), flush: true);
				if (ThrowOnEventWriteErrors)
				{
					throw new EventSourceException(Environment.GetResourceString("EventSource_NoFreeBuffers"), innerEx);
				}
				return;
			case EventProvider.WriteEventErrorCode.NullInput:
				ReportOutOfBandMessage(text + ": " + Environment.GetResourceString("EventSource_NullInput"), flush: true);
				if (ThrowOnEventWriteErrors)
				{
					throw new EventSourceException(Environment.GetResourceString("EventSource_NullInput"), innerEx);
				}
				return;
			case EventProvider.WriteEventErrorCode.TooManyArgs:
				ReportOutOfBandMessage(text + ": " + Environment.GetResourceString("EventSource_TooManyArgs"), flush: true);
				if (ThrowOnEventWriteErrors)
				{
					throw new EventSourceException(Environment.GetResourceString("EventSource_TooManyArgs"), innerEx);
				}
				return;
			}
			if (innerEx != null)
			{
				ReportOutOfBandMessage(text + ": " + innerEx.GetType()?.ToString() + ":" + innerEx.Message, flush: true);
			}
			else
			{
				ReportOutOfBandMessage(text, flush: true);
			}
			if (ThrowOnEventWriteErrors)
			{
				throw new EventSourceException(innerEx);
			}
		}
		finally
		{
			m_EventSourceExceptionRecurenceCount--;
		}
	}

	private void ValidateEventOpcodeForTransfer(ref EventMetadata eventData, string eventName)
	{
		if (eventData.Descriptor.Opcode != 9 && eventData.Descriptor.Opcode != 240 && eventData.Descriptor.Opcode != 1)
		{
			ThrowEventSourceException(eventName);
		}
	}

	internal static EventOpcode GetOpcodeWithDefault(EventOpcode opcode, string eventName)
	{
		if (opcode == EventOpcode.Info && eventName != null)
		{
			if (eventName.EndsWith("Start"))
			{
				return EventOpcode.Start;
			}
			if (eventName.EndsWith("Stop"))
			{
				return EventOpcode.Stop;
			}
		}
		return opcode;
	}

	internal void SendCommand(EventListener listener, int perEventSourceSessionId, int etwSessionId, EventCommand command, bool enable, EventLevel level, EventKeywords matchAnyKeyword, IDictionary<string, string> commandArguments)
	{
		EventCommandEventArgs e = new EventCommandEventArgs(command, commandArguments, this, listener, perEventSourceSessionId, etwSessionId, enable, level, matchAnyKeyword);
		lock (EventListener.EventListenersLock)
		{
			if (m_completelyInited)
			{
				m_deferredCommands = null;
				DoCommand(e);
			}
			else
			{
				e.nextCommand = m_deferredCommands;
				m_deferredCommands = e;
			}
		}
	}

	internal void DoCommand(EventCommandEventArgs commandArgs)
	{
		if (m_provider == null)
		{
			return;
		}
		m_outOfBandMessageCount = 0;
		bool flag = commandArgs.perEventSourceSessionId > 0 && (long)commandArgs.perEventSourceSessionId <= 4L;
		try
		{
			EnsureDescriptorsInitialized();
			commandArgs.dispatcher = GetDispatcher(commandArgs.listener);
			if (commandArgs.dispatcher == null && commandArgs.listener != null)
			{
				throw new ArgumentException(Environment.GetResourceString("EventSource_ListenerNotFound"));
			}
			if (commandArgs.Arguments == null)
			{
				commandArgs.Arguments = new Dictionary<string, string>();
			}
			if (commandArgs.Command == EventCommand.Update)
			{
				for (int i = 0; i < m_eventData.Length; i++)
				{
					EnableEventForDispatcher(commandArgs.dispatcher, i, IsEnabledByDefault(i, commandArgs.enable, commandArgs.level, commandArgs.matchAnyKeyword));
				}
				if (commandArgs.enable)
				{
					if (!m_eventSourceEnabled)
					{
						m_level = commandArgs.level;
						m_matchAnyKeyword = commandArgs.matchAnyKeyword;
					}
					else
					{
						if (commandArgs.level > m_level)
						{
							m_level = commandArgs.level;
						}
						if (commandArgs.matchAnyKeyword == EventKeywords.None)
						{
							m_matchAnyKeyword = EventKeywords.None;
						}
						else if (m_matchAnyKeyword != EventKeywords.None)
						{
							m_matchAnyKeyword |= commandArgs.matchAnyKeyword;
						}
					}
				}
				bool flag2 = commandArgs.perEventSourceSessionId >= 0;
				if (commandArgs.perEventSourceSessionId == 0 && !commandArgs.enable)
				{
					flag2 = false;
				}
				if (commandArgs.listener == null)
				{
					if (!flag2)
					{
						commandArgs.perEventSourceSessionId = -commandArgs.perEventSourceSessionId;
					}
					commandArgs.perEventSourceSessionId--;
				}
				commandArgs.Command = (flag2 ? EventCommand.Enable : EventCommand.Disable);
				if (flag2 && commandArgs.dispatcher == null && !SelfDescribingEvents)
				{
					SendManifest(m_rawManifest);
				}
				if (flag2 && commandArgs.perEventSourceSessionId != -1)
				{
					bool participateInSampling = false;
					ParseCommandArgs(commandArgs.Arguments, out participateInSampling, out var activityFilters, out var sessionIdBit);
					if (commandArgs.listener == null && commandArgs.Arguments.Count > 0 && commandArgs.perEventSourceSessionId != sessionIdBit)
					{
						throw new ArgumentException(Environment.GetResourceString("EventSource_SessionIdError", commandArgs.perEventSourceSessionId + 44, sessionIdBit + 44));
					}
					if (commandArgs.listener == null)
					{
						UpdateEtwSession(commandArgs.perEventSourceSessionId, commandArgs.etwSessionId, bEnable: true, activityFilters, participateInSampling);
					}
					else
					{
						ActivityFilter.UpdateFilter(ref commandArgs.listener.m_activityFilter, this, 0, activityFilters);
						commandArgs.dispatcher.m_activityFilteringEnabled = participateInSampling;
					}
				}
				else if (!flag2 && commandArgs.listener == null && commandArgs.perEventSourceSessionId >= 0 && (long)commandArgs.perEventSourceSessionId < 4L)
				{
					commandArgs.Arguments["EtwSessionKeyword"] = (commandArgs.perEventSourceSessionId + 44).ToString(CultureInfo.InvariantCulture);
				}
				if (commandArgs.enable)
				{
					m_eventSourceEnabled = true;
				}
				OnEventCommand(commandArgs);
				m_eventCommandExecuted?.Invoke(this, commandArgs);
				if (commandArgs.listener == null && !flag2 && commandArgs.perEventSourceSessionId != -1)
				{
					UpdateEtwSession(commandArgs.perEventSourceSessionId, commandArgs.etwSessionId, bEnable: false, null, participateInSampling: false);
				}
				if (!commandArgs.enable)
				{
					if (commandArgs.listener == null)
					{
						for (int j = 0; (long)j < 4L; j++)
						{
							EtwSession etwSession = m_etwSessionIdMap[j];
							if (etwSession != null)
							{
								ActivityFilter.DisableFilter(ref etwSession.m_activityFilter, this);
							}
						}
						m_activityFilteringForETWEnabled = new SessionMask(0u);
						m_curLiveSessions = new SessionMask(0u);
						if (m_etwSessionIdMap != null)
						{
							for (int k = 0; (long)k < 4L; k++)
							{
								m_etwSessionIdMap[k] = null;
							}
						}
						if (m_legacySessions != null)
						{
							m_legacySessions.Clear();
						}
					}
					else
					{
						ActivityFilter.DisableFilter(ref commandArgs.listener.m_activityFilter, this);
						commandArgs.dispatcher.m_activityFilteringEnabled = false;
					}
					for (int l = 0; l < m_eventData.Length; l++)
					{
						bool enabledForAnyListener = false;
						for (EventDispatcher eventDispatcher = m_Dispatchers; eventDispatcher != null; eventDispatcher = eventDispatcher.m_Next)
						{
							if (eventDispatcher.m_EventEnabled[l])
							{
								enabledForAnyListener = true;
								break;
							}
						}
						m_eventData[l].EnabledForAnyListener = enabledForAnyListener;
					}
					if (!AnyEventEnabled())
					{
						m_level = EventLevel.LogAlways;
						m_matchAnyKeyword = EventKeywords.None;
						m_eventSourceEnabled = false;
					}
				}
				UpdateKwdTriggers(commandArgs.enable);
			}
			else
			{
				if (commandArgs.Command == EventCommand.SendManifest && m_rawManifest != null)
				{
					SendManifest(m_rawManifest);
				}
				OnEventCommand(commandArgs);
				m_eventCommandExecuted?.Invoke(this, commandArgs);
			}
			if (m_completelyInited && (commandArgs.listener != null || flag))
			{
				SessionMask sessions = SessionMask.FromId(commandArgs.perEventSourceSessionId);
				ReportActivitySamplingInfo(commandArgs.listener, sessions);
			}
		}
		catch (Exception ex)
		{
			ReportOutOfBandMessage("ERROR: Exception in Command Processing for EventSource " + Name + ": " + ex.Message, flush: true);
		}
	}

	internal void UpdateEtwSession(int sessionIdBit, int etwSessionId, bool bEnable, string activityFilters, bool participateInSampling)
	{
		if ((long)sessionIdBit < 4L)
		{
			if (bEnable)
			{
				EtwSession etwSession = EtwSession.GetEtwSession(etwSessionId, bCreateIfNeeded: true);
				ActivityFilter.UpdateFilter(ref etwSession.m_activityFilter, this, sessionIdBit, activityFilters);
				m_etwSessionIdMap[sessionIdBit] = etwSession;
				m_activityFilteringForETWEnabled[sessionIdBit] = participateInSampling;
			}
			else
			{
				EtwSession etwSession2 = EtwSession.GetEtwSession(etwSessionId);
				m_etwSessionIdMap[sessionIdBit] = null;
				m_activityFilteringForETWEnabled[sessionIdBit] = false;
				if (etwSession2 != null)
				{
					ActivityFilter.DisableFilter(ref etwSession2.m_activityFilter, this);
					EtwSession.RemoveEtwSession(etwSession2);
				}
			}
			m_curLiveSessions[sessionIdBit] = bEnable;
			return;
		}
		if (bEnable)
		{
			if (m_legacySessions == null)
			{
				m_legacySessions = new List<EtwSession>(8);
			}
			EtwSession etwSession3 = EtwSession.GetEtwSession(etwSessionId, bCreateIfNeeded: true);
			if (!m_legacySessions.Contains(etwSession3))
			{
				m_legacySessions.Add(etwSession3);
			}
			return;
		}
		EtwSession etwSession4 = EtwSession.GetEtwSession(etwSessionId);
		if (etwSession4 != null)
		{
			if (m_legacySessions != null)
			{
				m_legacySessions.Remove(etwSession4);
			}
			EtwSession.RemoveEtwSession(etwSession4);
		}
	}

	internal static bool ParseCommandArgs(IDictionary<string, string> commandArguments, out bool participateInSampling, out string activityFilters, out int sessionIdBit)
	{
		bool result = true;
		participateInSampling = false;
		if (commandArguments.TryGetValue("ActivitySamplingStartEvent", out activityFilters))
		{
			participateInSampling = true;
		}
		if (commandArguments.TryGetValue("ActivitySampling", out var value))
		{
			if (string.Compare(value, "false", StringComparison.OrdinalIgnoreCase) == 0 || value == "0")
			{
				participateInSampling = false;
			}
			else
			{
				participateInSampling = true;
			}
		}
		int result2 = -1;
		if (!commandArguments.TryGetValue("EtwSessionKeyword", out var value2) || !int.TryParse(value2, out result2) || result2 < 44 || (long)result2 >= 48L)
		{
			sessionIdBit = -1;
			result = false;
		}
		else
		{
			sessionIdBit = result2 - 44;
		}
		return result;
	}

	internal void UpdateKwdTriggers(bool enable)
	{
		if (enable)
		{
			ulong num = (ulong)m_matchAnyKeyword;
			if (num == 0L)
			{
				num = ulong.MaxValue;
			}
			m_keywordTriggers = 0L;
			for (int i = 0; (long)i < 4L; i++)
			{
				EtwSession etwSession = m_etwSessionIdMap[i];
				if (etwSession != null)
				{
					ActivityFilter activityFilter = etwSession.m_activityFilter;
					ActivityFilter.UpdateKwdTriggers(activityFilter, m_guid, this, (EventKeywords)num);
				}
			}
		}
		else
		{
			m_keywordTriggers = 0L;
		}
	}

	internal bool EnableEventForDispatcher(EventDispatcher dispatcher, int eventId, bool value)
	{
		if (dispatcher == null)
		{
			if (eventId >= m_eventData.Length)
			{
				return false;
			}
			if (m_provider != null)
			{
				m_eventData[eventId].EnabledForETW = value;
			}
		}
		else
		{
			if (eventId >= dispatcher.m_EventEnabled.Length)
			{
				return false;
			}
			dispatcher.m_EventEnabled[eventId] = value;
			if (value)
			{
				m_eventData[eventId].EnabledForAnyListener = true;
			}
		}
		return true;
	}

	private bool AnyEventEnabled()
	{
		for (int i = 0; i < m_eventData.Length; i++)
		{
			if (m_eventData[i].EnabledForETW || m_eventData[i].EnabledForAnyListener)
			{
				return true;
			}
		}
		return false;
	}

	[SecuritySafeCritical]
	private void EnsureDescriptorsInitialized()
	{
		if (m_eventData == null)
		{
			m_rawManifest = CreateManifestAndDescriptors(GetType(), Name, this);
			foreach (WeakReference s_EventSource in EventListener.s_EventSources)
			{
				if (s_EventSource.Target is EventSource eventSource && eventSource.Guid == m_guid && !eventSource.IsDisposed && eventSource != this)
				{
					throw new ArgumentException(Environment.GetResourceString("EventSource_EventSourceGuidInUse", m_guid));
				}
			}
			for (EventDispatcher eventDispatcher = m_Dispatchers; eventDispatcher != null; eventDispatcher = eventDispatcher.m_Next)
			{
				if (eventDispatcher.m_EventEnabled == null)
				{
					eventDispatcher.m_EventEnabled = new bool[m_eventData.Length];
				}
			}
		}
		if (s_currentPid == 0)
		{
			s_currentPid = Win32Native.GetCurrentProcessId();
		}
	}

	[SecuritySafeCritical]
	private unsafe bool SendManifest(byte[] rawManifest)
	{
		bool result = true;
		if (rawManifest == null)
		{
			return false;
		}
		fixed (byte* ptr = rawManifest)
		{
			EventDescriptor eventDescriptor = new EventDescriptor(65534, 1, 0, 0, 254, 65534, 72057594037927935L);
			ManifestEnvelope manifestEnvelope = new ManifestEnvelope
			{
				Format = ManifestEnvelope.ManifestFormats.SimpleXmlFormat,
				MajorVersion = 1,
				MinorVersion = 0,
				Magic = 91
			};
			int num = rawManifest.Length;
			manifestEnvelope.ChunkNumber = 0;
			EventProvider.EventData* ptr2 = stackalloc EventProvider.EventData[2];
			ptr2->Ptr = (ulong)(&manifestEnvelope);
			ptr2->Size = (uint)sizeof(ManifestEnvelope);
			ptr2->Reserved = 0u;
			ptr2[1].Ptr = (ulong)ptr;
			ptr2[1].Reserved = 0u;
			int num2 = 65280;
			while (true)
			{
				IL_00ca:
				manifestEnvelope.TotalChunks = (ushort)((num + (num2 - 1)) / num2);
				while (num > 0)
				{
					ptr2[1].Size = (uint)Math.Min(num, num2);
					if (m_provider != null && !m_provider.WriteEvent(ref eventDescriptor, null, null, 2, (IntPtr)ptr2))
					{
						if (EventProvider.GetLastWriteEventError() == EventProvider.WriteEventErrorCode.EventTooBig && manifestEnvelope.ChunkNumber == 0 && num2 > 256)
						{
							num2 /= 2;
							goto IL_00ca;
						}
						result = false;
						if (ThrowOnEventWriteErrors)
						{
							ThrowEventSourceException("SendManifest");
						}
						break;
					}
					num -= num2;
					ptr2[1].Ptr += (uint)num2;
					manifestEnvelope.ChunkNumber++;
					if (manifestEnvelope.ChunkNumber % 5 == 0)
					{
						Thread.Sleep(15);
					}
				}
				break;
			}
		}
		return result;
	}

	internal static Attribute GetCustomAttributeHelper(MemberInfo member, Type attributeType, EventManifestOptions flags = EventManifestOptions.None)
	{
		if (!member.Module.Assembly.ReflectionOnly() && (flags & EventManifestOptions.AllowEventSourceOverride) == 0)
		{
			Attribute result = null;
			object[] customAttributes = member.GetCustomAttributes(attributeType, inherit: false);
			int num = 0;
			if (num < customAttributes.Length)
			{
				object obj = customAttributes[num];
				result = (Attribute)obj;
			}
			return result;
		}
		string fullName = attributeType.FullName;
		foreach (CustomAttributeData customAttribute in CustomAttributeData.GetCustomAttributes(member))
		{
			if (!AttributeTypeNamesMatch(attributeType, customAttribute.Constructor.ReflectedType))
			{
				continue;
			}
			Attribute attribute = null;
			if (customAttribute.ConstructorArguments.Count == 1)
			{
				attribute = (Attribute)Activator.CreateInstance(attributeType, customAttribute.ConstructorArguments[0].Value);
			}
			else if (customAttribute.ConstructorArguments.Count == 0)
			{
				attribute = (Attribute)Activator.CreateInstance(attributeType);
			}
			if (attribute == null)
			{
				continue;
			}
			Type type = attribute.GetType();
			foreach (CustomAttributeNamedArgument namedArgument in customAttribute.NamedArguments)
			{
				PropertyInfo property = type.GetProperty(namedArgument.MemberInfo.Name, BindingFlags.Instance | BindingFlags.Public);
				object obj2 = namedArgument.TypedValue.Value;
				if (property.PropertyType.IsEnum)
				{
					obj2 = Enum.Parse(property.PropertyType, obj2.ToString());
				}
				property.SetValue(attribute, obj2, null);
			}
			return attribute;
		}
		return null;
	}

	private static bool AttributeTypeNamesMatch(Type attributeType, Type reflectedAttributeType)
	{
		if (!(attributeType == reflectedAttributeType) && !string.Equals(attributeType.FullName, reflectedAttributeType.FullName, StringComparison.Ordinal))
		{
			if (string.Equals(attributeType.Name, reflectedAttributeType.Name, StringComparison.Ordinal) && attributeType.Namespace.EndsWith("Diagnostics.Tracing"))
			{
				return reflectedAttributeType.Namespace.EndsWith("Diagnostics.Tracing");
			}
			return false;
		}
		return true;
	}

	private static Type GetEventSourceBaseType(Type eventSourceType, bool allowEventSourceOverride, bool reflectionOnly)
	{
		if (eventSourceType.BaseType() == null)
		{
			return null;
		}
		do
		{
			eventSourceType = eventSourceType.BaseType();
		}
		while (eventSourceType != null && eventSourceType.IsAbstract());
		if (eventSourceType != null)
		{
			if (!allowEventSourceOverride)
			{
				if ((reflectionOnly && eventSourceType.FullName != typeof(EventSource).FullName) || (!reflectionOnly && eventSourceType != typeof(EventSource)))
				{
					return null;
				}
			}
			else if (eventSourceType.Name != "EventSource")
			{
				return null;
			}
		}
		return eventSourceType;
	}

	private static byte[] CreateManifestAndDescriptors(Type eventSourceType, string eventSourceDllName, EventSource source, EventManifestOptions flags = EventManifestOptions.None)
	{
		ManifestBuilder manifestBuilder = null;
		bool flag = source == null || !source.SelfDescribingEvents;
		Exception ex = null;
		byte[] result = null;
		if (eventSourceType.IsAbstract() && (flags & EventManifestOptions.Strict) == 0)
		{
			return null;
		}
		try
		{
			MethodInfo[] methods = eventSourceType.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			int num = 1;
			EventMetadata[] eventData = null;
			Dictionary<string, string> eventsByName = null;
			if (source != null || (flags & EventManifestOptions.Strict) != EventManifestOptions.None)
			{
				eventData = new EventMetadata[methods.Length + 1];
				eventData[0].Name = "";
			}
			ResourceManager resources = null;
			EventSourceAttribute eventSourceAttribute = (EventSourceAttribute)GetCustomAttributeHelper(eventSourceType, typeof(EventSourceAttribute), flags);
			if (eventSourceAttribute != null && eventSourceAttribute.LocalizationResources != null)
			{
				resources = new ResourceManager(eventSourceAttribute.LocalizationResources, eventSourceType.Assembly());
			}
			manifestBuilder = new ManifestBuilder(GetName(eventSourceType, flags), GetGuid(eventSourceType), eventSourceDllName, resources, flags);
			manifestBuilder.StartEvent("EventSourceMessage", new EventAttribute(0)
			{
				Level = EventLevel.LogAlways,
				Task = (EventTask)65534
			});
			manifestBuilder.AddEventParameter(typeof(string), "message");
			manifestBuilder.EndEvent();
			if ((flags & EventManifestOptions.Strict) != EventManifestOptions.None)
			{
				if (!(GetEventSourceBaseType(eventSourceType, (flags & EventManifestOptions.AllowEventSourceOverride) != 0, eventSourceType.Assembly().ReflectionOnly()) != null))
				{
					manifestBuilder.ManifestError(Environment.GetResourceString("EventSource_TypeMustDeriveFromEventSource"));
				}
				if (!eventSourceType.IsAbstract() && !eventSourceType.IsSealed())
				{
					manifestBuilder.ManifestError(Environment.GetResourceString("EventSource_TypeMustBeSealedOrAbstract"));
				}
			}
			string[] array = new string[3] { "Keywords", "Tasks", "Opcodes" };
			foreach (string text in array)
			{
				Type nestedType = eventSourceType.GetNestedType(text);
				if (!(nestedType != null))
				{
					continue;
				}
				if (eventSourceType.IsAbstract())
				{
					manifestBuilder.ManifestError(Environment.GetResourceString("EventSource_AbstractMustNotDeclareKTOC", nestedType.Name));
					continue;
				}
				FieldInfo[] fields = nestedType.GetFields(BindingFlags.DeclaredOnly | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
				foreach (FieldInfo staticField in fields)
				{
					AddProviderEnumKind(manifestBuilder, staticField, text);
				}
			}
			manifestBuilder.AddKeyword("Session3", 17592186044416uL);
			manifestBuilder.AddKeyword("Session2", 35184372088832uL);
			manifestBuilder.AddKeyword("Session1", 70368744177664uL);
			manifestBuilder.AddKeyword("Session0", 140737488355328uL);
			if (eventSourceType != typeof(EventSource))
			{
				foreach (MethodInfo methodInfo in methods)
				{
					ParameterInfo[] args = methodInfo.GetParameters();
					EventAttribute eventAttribute = (EventAttribute)GetCustomAttributeHelper(methodInfo, typeof(EventAttribute), flags);
					if (eventAttribute != null && source != null && eventAttribute.EventId <= 3 && source.Guid.Equals(AspNetEventSourceGuid))
					{
						eventAttribute.ActivityOptions |= EventActivityOptions.Disable;
					}
					if (methodInfo.IsStatic)
					{
						continue;
					}
					if (eventSourceType.IsAbstract())
					{
						if (eventAttribute != null)
						{
							manifestBuilder.ManifestError(Environment.GetResourceString("EventSource_AbstractMustNotDeclareEventMethods", methodInfo.Name, eventAttribute.EventId));
						}
						continue;
					}
					if (eventAttribute == null)
					{
						if (methodInfo.ReturnType != typeof(void) || methodInfo.IsVirtual || GetCustomAttributeHelper(methodInfo, typeof(NonEventAttribute), flags) != null)
						{
							continue;
						}
						EventAttribute eventAttribute2 = new EventAttribute(num);
						eventAttribute = eventAttribute2;
					}
					else if (eventAttribute.EventId <= 0)
					{
						manifestBuilder.ManifestError(Environment.GetResourceString("EventSource_NeedPositiveId", methodInfo.Name), runtimeCritical: true);
						continue;
					}
					if (methodInfo.Name.LastIndexOf('.') >= 0)
					{
						manifestBuilder.ManifestError(Environment.GetResourceString("EventSource_EventMustNotBeExplicitImplementation", methodInfo.Name, eventAttribute.EventId));
					}
					num++;
					string name = methodInfo.Name;
					if (eventAttribute.Opcode == EventOpcode.Info)
					{
						bool flag2 = eventAttribute.Task == EventTask.None;
						if (flag2)
						{
							eventAttribute.Task = (EventTask)(65534 - eventAttribute.EventId);
						}
						if (!eventAttribute.IsOpcodeSet)
						{
							eventAttribute.Opcode = GetOpcodeWithDefault(EventOpcode.Info, name);
						}
						if (flag2)
						{
							if (eventAttribute.Opcode == EventOpcode.Start)
							{
								string text2 = name.Substring(0, name.Length - "Start".Length);
								if (string.Compare(name, 0, text2, 0, text2.Length) == 0 && string.Compare(name, text2.Length, "Start", 0, Math.Max(name.Length - text2.Length, "Start".Length)) == 0)
								{
									manifestBuilder.AddTask(text2, (int)eventAttribute.Task);
								}
							}
							else if (eventAttribute.Opcode == EventOpcode.Stop)
							{
								int num2 = eventAttribute.EventId - 1;
								if (eventData != null && num2 < eventData.Length)
								{
									EventMetadata eventMetadata = eventData[num2];
									string text3 = name.Substring(0, name.Length - "Stop".Length);
									if (eventMetadata.Descriptor.Opcode == 1 && string.Compare(eventMetadata.Name, 0, text3, 0, text3.Length) == 0 && string.Compare(eventMetadata.Name, text3.Length, "Start", 0, Math.Max(eventMetadata.Name.Length - text3.Length, "Start".Length)) == 0)
									{
										eventAttribute.Task = (EventTask)eventMetadata.Descriptor.Task;
										flag2 = false;
									}
								}
								if (flag2 && (flags & EventManifestOptions.Strict) != EventManifestOptions.None)
								{
									throw new ArgumentException(Environment.GetResourceString("EventSource_StopsFollowStarts"));
								}
							}
						}
					}
					bool hasRelatedActivityID = RemoveFirstArgIfRelatedActivityId(ref args);
					if (source == null || !source.SelfDescribingEvents)
					{
						manifestBuilder.StartEvent(name, eventAttribute);
						for (int l = 0; l < args.Length; l++)
						{
							manifestBuilder.AddEventParameter(args[l].ParameterType, args[l].Name);
						}
						manifestBuilder.EndEvent();
					}
					if (source != null || (flags & EventManifestOptions.Strict) != EventManifestOptions.None)
					{
						DebugCheckEvent(ref eventsByName, eventData, methodInfo, eventAttribute, manifestBuilder, flags);
						if (eventAttribute.Channel != EventChannel.None)
						{
							eventAttribute.Keywords |= (EventKeywords)manifestBuilder.GetChannelKeyword(eventAttribute.Channel);
						}
						string key = "event_" + name;
						string localizedMessage = manifestBuilder.GetLocalizedMessage(key, CultureInfo.CurrentUICulture, etwFormat: false);
						if (localizedMessage != null)
						{
							eventAttribute.Message = localizedMessage;
						}
						AddEventDescriptor(ref eventData, name, eventAttribute, args, hasRelatedActivityID);
					}
				}
			}
			NameInfo.ReserveEventIDsBelow(num);
			if (source != null)
			{
				TrimEventDescriptors(ref eventData);
				source.m_eventData = eventData;
				source.m_channelData = manifestBuilder.GetChannelData();
			}
			if (!eventSourceType.IsAbstract() && (source == null || !source.SelfDescribingEvents))
			{
				flag = (flags & EventManifestOptions.OnlyIfNeededForRegistration) == 0 || manifestBuilder.GetChannelData().Length != 0;
				if (!flag && (flags & EventManifestOptions.Strict) == 0)
				{
					return null;
				}
				result = manifestBuilder.CreateManifest();
			}
		}
		catch (Exception ex2)
		{
			if ((flags & EventManifestOptions.Strict) == 0)
			{
				throw;
			}
			ex = ex2;
		}
		if ((flags & EventManifestOptions.Strict) != EventManifestOptions.None && (manifestBuilder.Errors.Count > 0 || ex != null))
		{
			string text4 = string.Empty;
			if (manifestBuilder.Errors.Count > 0)
			{
				bool flag3 = true;
				foreach (string error in manifestBuilder.Errors)
				{
					if (!flag3)
					{
						text4 += Environment.NewLine;
					}
					flag3 = false;
					text4 += error;
				}
			}
			else
			{
				text4 = "Unexpected error: " + ex.Message;
			}
			throw new ArgumentException(text4, ex);
		}
		if (!flag)
		{
			return null;
		}
		return result;
	}

	private static bool RemoveFirstArgIfRelatedActivityId(ref ParameterInfo[] args)
	{
		if (args.Length != 0 && args[0].ParameterType == typeof(Guid) && string.Compare(args[0].Name, "relatedActivityId", StringComparison.OrdinalIgnoreCase) == 0)
		{
			ParameterInfo[] array = new ParameterInfo[args.Length - 1];
			Array.Copy(args, 1, array, 0, args.Length - 1);
			args = array;
			return true;
		}
		return false;
	}

	private static void AddProviderEnumKind(ManifestBuilder manifest, FieldInfo staticField, string providerEnumKind)
	{
		bool flag = staticField.Module.Assembly.ReflectionOnly();
		Type fieldType = staticField.FieldType;
		if ((!flag && fieldType == typeof(EventOpcode)) || AttributeTypeNamesMatch(fieldType, typeof(EventOpcode)))
		{
			if (!(providerEnumKind != "Opcodes"))
			{
				int value = (int)staticField.GetRawConstantValue();
				manifest.AddOpcode(staticField.Name, value);
				return;
			}
		}
		else if ((!flag && fieldType == typeof(EventTask)) || AttributeTypeNamesMatch(fieldType, typeof(EventTask)))
		{
			if (!(providerEnumKind != "Tasks"))
			{
				int value2 = (int)staticField.GetRawConstantValue();
				manifest.AddTask(staticField.Name, value2);
				return;
			}
		}
		else
		{
			if ((flag || !(fieldType == typeof(EventKeywords))) && !AttributeTypeNamesMatch(fieldType, typeof(EventKeywords)))
			{
				return;
			}
			if (!(providerEnumKind != "Keywords"))
			{
				ulong value3 = (ulong)(long)staticField.GetRawConstantValue();
				manifest.AddKeyword(staticField.Name, value3);
				return;
			}
		}
		manifest.ManifestError(Environment.GetResourceString("EventSource_EnumKindMismatch", staticField.Name, staticField.FieldType.Name, providerEnumKind));
	}

	private static void AddEventDescriptor(ref EventMetadata[] eventData, string eventName, EventAttribute eventAttribute, ParameterInfo[] eventParameters, bool hasRelatedActivityID)
	{
		if (eventData == null || eventData.Length <= eventAttribute.EventId)
		{
			EventMetadata[] array = new EventMetadata[Math.Max(eventData.Length + 16, eventAttribute.EventId + 1)];
			Array.Copy(eventData, array, eventData.Length);
			eventData = array;
		}
		eventData[eventAttribute.EventId].Descriptor = new EventDescriptor(eventAttribute.EventId, eventAttribute.Version, (byte)eventAttribute.Channel, (byte)eventAttribute.Level, (byte)eventAttribute.Opcode, (int)eventAttribute.Task, (long)eventAttribute.Keywords | (long)SessionMask.All.ToEventKeywords());
		eventData[eventAttribute.EventId].Tags = eventAttribute.Tags;
		eventData[eventAttribute.EventId].Name = eventName;
		eventData[eventAttribute.EventId].Parameters = eventParameters;
		eventData[eventAttribute.EventId].Message = eventAttribute.Message;
		eventData[eventAttribute.EventId].ActivityOptions = eventAttribute.ActivityOptions;
		eventData[eventAttribute.EventId].HasRelatedActivityID = hasRelatedActivityID;
	}

	private static void TrimEventDescriptors(ref EventMetadata[] eventData)
	{
		int num = eventData.Length;
		while (0 < num)
		{
			num--;
			if (eventData[num].Descriptor.EventId != 0)
			{
				break;
			}
		}
		if (eventData.Length - num > 2)
		{
			EventMetadata[] array = new EventMetadata[num + 1];
			Array.Copy(eventData, array, array.Length);
			eventData = array;
		}
	}

	internal void AddListener(EventListener listener)
	{
		lock (EventListener.EventListenersLock)
		{
			bool[] eventEnabled = null;
			if (m_eventData != null)
			{
				eventEnabled = new bool[m_eventData.Length];
			}
			m_Dispatchers = new EventDispatcher(m_Dispatchers, eventEnabled, listener);
			listener.OnEventSourceCreated(this);
		}
	}

	private static void DebugCheckEvent(ref Dictionary<string, string> eventsByName, EventMetadata[] eventData, MethodInfo method, EventAttribute eventAttribute, ManifestBuilder manifest, EventManifestOptions options)
	{
		int eventId = eventAttribute.EventId;
		string name = method.Name;
		int helperCallFirstArg = GetHelperCallFirstArg(method);
		if (helperCallFirstArg >= 0 && eventId != helperCallFirstArg)
		{
			manifest.ManifestError(Environment.GetResourceString("EventSource_MismatchIdToWriteEvent", name, eventId, helperCallFirstArg), runtimeCritical: true);
		}
		if (eventId < eventData.Length && eventData[eventId].Descriptor.EventId != 0)
		{
			manifest.ManifestError(Environment.GetResourceString("EventSource_EventIdReused", name, eventId, eventData[eventId].Name), runtimeCritical: true);
		}
		for (int i = 0; i < eventData.Length; i++)
		{
			if (eventData[i].Name != null && eventData[i].Descriptor.Task == (int)eventAttribute.Task && (EventOpcode)eventData[i].Descriptor.Opcode == eventAttribute.Opcode)
			{
				manifest.ManifestError(Environment.GetResourceString("EventSource_TaskOpcodePairReused", name, eventId, eventData[i].Name, i));
				if ((options & EventManifestOptions.Strict) == 0)
				{
					break;
				}
			}
		}
		if (eventAttribute.Opcode != EventOpcode.Info)
		{
			bool flag = false;
			if (eventAttribute.Task == EventTask.None)
			{
				flag = true;
			}
			else
			{
				EventTask eventTask = (EventTask)(65534 - eventId);
				if (eventAttribute.Opcode != EventOpcode.Start && eventAttribute.Opcode != EventOpcode.Stop && eventAttribute.Task == eventTask)
				{
					flag = true;
				}
			}
			if (flag)
			{
				manifest.ManifestError(Environment.GetResourceString("EventSource_EventMustHaveTaskIfNonDefaultOpcode", name, eventId));
			}
		}
		if (eventsByName == null)
		{
			eventsByName = new Dictionary<string, string>();
		}
		if (eventsByName.ContainsKey(name))
		{
			manifest.ManifestError(Environment.GetResourceString("EventSource_EventNameReused", name), runtimeCritical: true);
		}
		eventsByName[name] = name;
	}

	[SecuritySafeCritical]
	private static int GetHelperCallFirstArg(MethodInfo method)
	{
		new ReflectionPermission(ReflectionPermissionFlag.MemberAccess).Assert();
		byte[] iLAsByteArray = method.GetMethodBody().GetILAsByteArray();
		int num = -1;
		for (int i = 0; i < iLAsByteArray.Length; i++)
		{
			switch (iLAsByteArray[i])
			{
			case 14:
			case 16:
				i++;
				continue;
			case 21:
			case 22:
			case 23:
			case 24:
			case 25:
			case 26:
			case 27:
			case 28:
			case 29:
			case 30:
				if (i > 0 && iLAsByteArray[i - 1] == 2)
				{
					num = iLAsByteArray[i] - 22;
				}
				continue;
			case 31:
				if (i > 0 && iLAsByteArray[i - 1] == 2)
				{
					num = iLAsByteArray[i + 1];
				}
				i++;
				continue;
			case 32:
				i += 4;
				continue;
			case 40:
				i += 4;
				if (num >= 0)
				{
					for (int j = i + 1; j < iLAsByteArray.Length; j++)
					{
						if (iLAsByteArray[j] == 42)
						{
							return num;
						}
						if (iLAsByteArray[j] != 0)
						{
							break;
						}
					}
				}
				num = -1;
				continue;
			case 44:
			case 45:
				num = -1;
				i++;
				continue;
			case 57:
			case 58:
				num = -1;
				i += 4;
				continue;
			case 140:
			case 141:
				i += 4;
				continue;
			case 254:
				i++;
				if (i < iLAsByteArray.Length && iLAsByteArray[i] < 6)
				{
					continue;
				}
				break;
			case 0:
			case 1:
			case 2:
			case 3:
			case 4:
			case 5:
			case 6:
			case 7:
			case 8:
			case 9:
			case 10:
			case 11:
			case 12:
			case 13:
			case 20:
			case 37:
			case 103:
			case 104:
			case 105:
			case 106:
			case 109:
			case 110:
			case 162:
				continue;
			}
			return -1;
		}
		return -1;
	}

	internal void ReportOutOfBandMessage(string msg, bool flush)
	{
		try
		{
			Debugger.Log(0, null, msg + "\r\n");
			if (m_outOfBandMessageCount < 15)
			{
				m_outOfBandMessageCount++;
			}
			else
			{
				if (m_outOfBandMessageCount == 16)
				{
					return;
				}
				m_outOfBandMessageCount = 16;
				msg = "Reached message limit.   End of EventSource error messages.";
			}
			WriteEventString(EventLevel.LogAlways, -1L, msg);
			WriteStringToAllListeners("EventSourceMessage", msg);
		}
		catch (Exception)
		{
		}
	}

	private EventSourceSettings ValidateSettings(EventSourceSettings settings)
	{
		EventSourceSettings eventSourceSettings = EventSourceSettings.EtwManifestEventFormat | EventSourceSettings.EtwSelfDescribingEventFormat;
		if ((settings & eventSourceSettings) == eventSourceSettings)
		{
			throw new ArgumentException(Environment.GetResourceString("EventSource_InvalidEventFormat"), "settings");
		}
		if ((settings & eventSourceSettings) == 0)
		{
			settings |= EventSourceSettings.EtwSelfDescribingEventFormat;
		}
		return settings;
	}

	private void ReportActivitySamplingInfo(EventListener listener, SessionMask sessions)
	{
		for (int i = 0; (long)i < 4L; i++)
		{
			if (!sessions[i])
			{
				continue;
			}
			ActivityFilter activityFilter;
			if (listener == null)
			{
				EtwSession etwSession = m_etwSessionIdMap[i];
				activityFilter = etwSession.m_activityFilter;
			}
			else
			{
				activityFilter = listener.m_activityFilter;
			}
			if (activityFilter == null)
			{
				continue;
			}
			SessionMask m = new SessionMask { [i] = true };
			foreach (Tuple<int, int> item in activityFilter.GetFilterAsTuple(m_guid))
			{
				WriteStringToListener(listener, string.Format(CultureInfo.InvariantCulture, "Session {0}: {1} = {2}", i, item.Item1, item.Item2), m);
			}
			bool flag = ((listener == null) ? m_activityFilteringForETWEnabled[i] : GetDispatcher(listener).m_activityFilteringEnabled);
			WriteStringToListener(listener, string.Format(CultureInfo.InvariantCulture, "Session {0}: Activity Sampling support: {1}", i, flag ? "enabled" : "disabled"), m);
		}
	}

	[__DynamicallyInvokable]
	public EventSource(string eventSourceName)
		: this(eventSourceName, EventSourceSettings.EtwSelfDescribingEventFormat)
	{
	}

	[__DynamicallyInvokable]
	public EventSource(string eventSourceName, EventSourceSettings config)
		: this(eventSourceName, config, (string[])null)
	{
	}

	[__DynamicallyInvokable]
	public EventSource(string eventSourceName, EventSourceSettings config, params string[] traits)
		: this((eventSourceName == null) ? default(Guid) : GenerateGuidFromName(eventSourceName.ToUpperInvariant()), eventSourceName, config, traits)
	{
		if (eventSourceName == null)
		{
			throw new ArgumentNullException("eventSourceName");
		}
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public unsafe void Write(string eventName)
	{
		if (eventName == null)
		{
			throw new ArgumentNullException("eventName");
		}
		if (IsEnabled())
		{
			EventSourceOptions options = default(EventSourceOptions);
			EmptyStruct data = default(EmptyStruct);
			WriteImpl(eventName, ref options, ref data, null, null);
		}
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public unsafe void Write(string eventName, EventSourceOptions options)
	{
		if (eventName == null)
		{
			throw new ArgumentNullException("eventName");
		}
		if (IsEnabled())
		{
			EmptyStruct data = default(EmptyStruct);
			WriteImpl(eventName, ref options, ref data, null, null);
		}
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public unsafe void Write<T>(string eventName, T data)
	{
		if (IsEnabled())
		{
			EventSourceOptions options = default(EventSourceOptions);
			WriteImpl(eventName, ref options, ref data, null, null);
		}
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public unsafe void Write<T>(string eventName, EventSourceOptions options, T data)
	{
		if (IsEnabled())
		{
			WriteImpl(eventName, ref options, ref data, null, null);
		}
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public unsafe void Write<T>(string eventName, ref EventSourceOptions options, ref T data)
	{
		if (IsEnabled())
		{
			WriteImpl(eventName, ref options, ref data, null, null);
		}
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public unsafe void Write<T>(string eventName, ref EventSourceOptions options, ref Guid activityId, ref Guid relatedActivityId, ref T data)
	{
		if (!IsEnabled())
		{
			return;
		}
		fixed (Guid* pActivityId = &activityId)
		{
			fixed (Guid* ptr = &relatedActivityId)
			{
				WriteImpl(eventName, ref options, ref data, pActivityId, (relatedActivityId == Guid.Empty) ? null : ptr);
			}
		}
	}

	[SecuritySafeCritical]
	private unsafe void WriteMultiMerge(string eventName, ref EventSourceOptions options, TraceLoggingEventTypes eventTypes, Guid* activityID, Guid* childActivityID, params object[] values)
	{
		if (IsEnabled())
		{
			byte level = (((options.valuesSet & 4) != 0) ? options.level : eventTypes.level);
			EventKeywords keywords = (((options.valuesSet & 1) != 0) ? options.keywords : eventTypes.keywords);
			if (IsEnabled((EventLevel)level, keywords))
			{
				WriteMultiMergeInner(eventName, ref options, eventTypes, activityID, childActivityID, values);
			}
		}
	}

	[SecuritySafeCritical]
	private unsafe void WriteMultiMergeInner(string eventName, ref EventSourceOptions options, TraceLoggingEventTypes eventTypes, Guid* activityID, Guid* childActivityID, params object[] values)
	{
		int num = 0;
		byte level = (((options.valuesSet & 4) != 0) ? options.level : eventTypes.level);
		byte opcode = (((options.valuesSet & 8) != 0) ? options.opcode : eventTypes.opcode);
		EventTags tags = (((options.valuesSet & 2) != 0) ? options.tags : eventTypes.Tags);
		EventKeywords keywords = (((options.valuesSet & 1) != 0) ? options.keywords : eventTypes.keywords);
		NameInfo nameInfo = eventTypes.GetNameInfo(eventName ?? eventTypes.Name, tags);
		if (nameInfo == null)
		{
			return;
		}
		num = nameInfo.identity;
		EventDescriptor eventDescriptor = new EventDescriptor(num, level, opcode, (long)keywords);
		int pinCount = eventTypes.pinCount;
		byte* scratch = stackalloc byte[(int)(uint)eventTypes.scratchSize];
		EventData* ptr = stackalloc EventData[eventTypes.dataCount + 3];
		GCHandle* ptr2 = stackalloc GCHandle[pinCount];
		fixed (byte* pointer = providerMetadata)
		{
			fixed (byte* nameMetadata = nameInfo.nameMetadata)
			{
				fixed (byte* typeMetadata = eventTypes.typeMetadata)
				{
					ptr->SetMetadata(pointer, providerMetadata.Length, 2);
					ptr[1].SetMetadata(nameMetadata, nameInfo.nameMetadata.Length, 1);
					ptr[2].SetMetadata(typeMetadata, eventTypes.typeMetadata.Length, 1);
					RuntimeHelpers.PrepareConstrainedRegions();
					try
					{
						DataCollector.ThreadInstance.Enable(scratch, eventTypes.scratchSize, ptr + 3, eventTypes.dataCount, ptr2, pinCount);
						for (int i = 0; i < eventTypes.typeInfos.Length; i++)
						{
							eventTypes.typeInfos[i].WriteObjectData(TraceLoggingDataCollector.Instance, values[i]);
						}
						WriteEventRaw(eventName, ref eventDescriptor, activityID, childActivityID, (int)(DataCollector.ThreadInstance.Finish() - ptr), (IntPtr)ptr);
					}
					finally
					{
						WriteCleanup(ptr2, pinCount);
					}
				}
			}
		}
	}

	[SecuritySafeCritical]
	internal unsafe void WriteMultiMerge(string eventName, ref EventSourceOptions options, TraceLoggingEventTypes eventTypes, Guid* activityID, Guid* childActivityID, EventData* data)
	{
		if (!IsEnabled())
		{
			return;
		}
		fixed (EventSourceOptions* ptr = &options)
		{
			EventDescriptor descriptor;
			NameInfo nameInfo = UpdateDescriptor(eventName, eventTypes, ref options, out descriptor);
			if (nameInfo == null)
			{
				return;
			}
			EventData* ptr2 = stackalloc EventData[eventTypes.dataCount + eventTypes.typeInfos.Length * 2 + 3];
			fixed (byte* pointer = providerMetadata)
			{
				fixed (byte* nameMetadata = nameInfo.nameMetadata)
				{
					fixed (byte* typeMetadata = eventTypes.typeMetadata)
					{
						ptr2->SetMetadata(pointer, providerMetadata.Length, 2);
						ptr2[1].SetMetadata(nameMetadata, nameInfo.nameMetadata.Length, 1);
						ptr2[2].SetMetadata(typeMetadata, eventTypes.typeMetadata.Length, 1);
						int num = 3;
						for (int i = 0; i < eventTypes.typeInfos.Length; i++)
						{
							if (eventTypes.typeInfos[i].DataType == typeof(string))
							{
								ptr2[num].DataPointer = (IntPtr)(&ptr2[num + 1].m_Size);
								ptr2[num].m_Size = 2;
								num++;
								ptr2[num].m_Ptr = data[i].m_Ptr;
								ptr2[num].m_Size = data[i].m_Size - 2;
								num++;
							}
							else
							{
								ptr2[num].m_Ptr = data[i].m_Ptr;
								ptr2[num].m_Size = data[i].m_Size;
								if (data[i].m_Size == 4 && eventTypes.typeInfos[i].DataType == typeof(bool))
								{
									ptr2[num].m_Size = 1;
								}
								num++;
							}
						}
						WriteEventRaw(eventName, ref descriptor, activityID, childActivityID, num, (IntPtr)ptr2);
					}
				}
			}
		}
	}

	[SecuritySafeCritical]
	private unsafe void WriteImpl<T>(string eventName, ref EventSourceOptions options, ref T data, Guid* pActivityId, Guid* pRelatedActivityId)
	{
		try
		{
			SimpleEventTypes<T> instance = SimpleEventTypes<T>.Instance;
			fixed (EventSourceOptions* ptr = &options)
			{
				options.Opcode = (options.IsOpcodeSet ? options.Opcode : GetOpcodeWithDefault(options.Opcode, eventName));
				EventDescriptor descriptor;
				NameInfo nameInfo = UpdateDescriptor(eventName, instance, ref options, out descriptor);
				if (nameInfo == null)
				{
					return;
				}
				int pinCount = instance.pinCount;
				byte* scratch = stackalloc byte[(int)(uint)instance.scratchSize];
				EventData* ptr2 = stackalloc EventData[instance.dataCount + 3];
				GCHandle* ptr3 = stackalloc GCHandle[pinCount];
				fixed (byte* pointer = providerMetadata)
				{
					fixed (byte* nameMetadata = nameInfo.nameMetadata)
					{
						fixed (byte* typeMetadata = instance.typeMetadata)
						{
							ptr2->SetMetadata(pointer, providerMetadata.Length, 2);
							ptr2[1].SetMetadata(nameMetadata, nameInfo.nameMetadata.Length, 1);
							ptr2[2].SetMetadata(typeMetadata, instance.typeMetadata.Length, 1);
							RuntimeHelpers.PrepareConstrainedRegions();
							EventOpcode opcode = (EventOpcode)descriptor.Opcode;
							Guid activityId = Guid.Empty;
							Guid relatedActivityId = Guid.Empty;
							if (pActivityId == null && pRelatedActivityId == null && (options.ActivityOptions & EventActivityOptions.Disable) == 0)
							{
								switch (opcode)
								{
								case EventOpcode.Start:
									m_activityTracker.OnStart(m_name, eventName, 0, ref activityId, ref relatedActivityId, options.ActivityOptions);
									break;
								case EventOpcode.Stop:
									m_activityTracker.OnStop(m_name, eventName, 0, ref activityId);
									break;
								}
								if (activityId != Guid.Empty)
								{
									pActivityId = &activityId;
								}
								if (relatedActivityId != Guid.Empty)
								{
									pRelatedActivityId = &relatedActivityId;
								}
							}
							try
							{
								DataCollector.ThreadInstance.Enable(scratch, instance.scratchSize, ptr2 + 3, instance.dataCount, ptr3, pinCount);
								instance.typeInfo.WriteData(TraceLoggingDataCollector.Instance, ref data);
								WriteEventRaw(eventName, ref descriptor, pActivityId, pRelatedActivityId, (int)(DataCollector.ThreadInstance.Finish() - ptr2), (IntPtr)ptr2);
								if (m_Dispatchers != null)
								{
									EventPayload payload = (EventPayload)instance.typeInfo.GetData(data);
									WriteToAllListeners(eventName, ref descriptor, nameInfo.tags, pActivityId, pRelatedActivityId, payload);
								}
							}
							catch (Exception ex)
							{
								if (ex is EventSourceException)
								{
									throw;
								}
								ThrowEventSourceException(eventName, ex);
							}
							finally
							{
								WriteCleanup(ptr3, pinCount);
							}
						}
					}
				}
			}
		}
		catch (Exception ex2)
		{
			if (ex2 is EventSourceException)
			{
				throw;
			}
			ThrowEventSourceException(eventName, ex2);
		}
	}

	[SecurityCritical]
	private unsafe void WriteToAllListeners(string eventName, ref EventDescriptor eventDescriptor, EventTags tags, Guid* pActivityId, Guid* pChildActivityId, EventPayload payload)
	{
		EventWrittenEventArgs e = new EventWrittenEventArgs(this);
		e.EventName = eventName;
		e.m_level = (EventLevel)eventDescriptor.Level;
		e.m_keywords = (EventKeywords)eventDescriptor.Keywords;
		e.m_opcode = (EventOpcode)eventDescriptor.Opcode;
		e.m_tags = tags;
		e.EventId = -1;
		if (pActivityId != null)
		{
			e.ActivityId = *pActivityId;
		}
		if (pChildActivityId != null)
		{
			e.RelatedActivityId = *pChildActivityId;
		}
		if (payload != null)
		{
			e.Payload = new ReadOnlyCollection<object>((IList<object>)payload.Values);
			e.PayloadNames = new ReadOnlyCollection<string>((IList<string>)payload.Keys);
		}
		DispatchToAllListeners(-1, pActivityId, e);
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[SecurityCritical]
	[NonEvent]
	private unsafe void WriteCleanup(GCHandle* pPins, int cPins)
	{
		DataCollector.ThreadInstance.Disable();
		for (int i = 0; i != cPins; i++)
		{
			if (IntPtr.Zero != (IntPtr)pPins[i])
			{
				pPins[i].Free();
			}
		}
	}

	private void InitializeProviderMetadata()
	{
		if (m_traits != null)
		{
			List<byte> list = new List<byte>(100);
			for (int i = 0; i < m_traits.Length - 1; i += 2)
			{
				if (!m_traits[i].StartsWith("ETW_"))
				{
					continue;
				}
				string text = m_traits[i].Substring(4);
				if (!byte.TryParse(text, out var result))
				{
					if (!(text == "GROUP"))
					{
						throw new ArgumentException(Environment.GetResourceString("UnknownEtwTrait", text), "traits");
					}
					result = 1;
				}
				string value = m_traits[i + 1];
				int count = list.Count;
				list.Add(0);
				list.Add(0);
				list.Add(result);
				int num = AddValueToMetaData(list, value) + 3;
				list[count] = (byte)num;
				list[count + 1] = (byte)(num >> 8);
			}
			providerMetadata = Statics.MetadataForString(Name, 0, list.Count, 0);
			int num2 = providerMetadata.Length - list.Count;
			{
				foreach (byte item in list)
				{
					providerMetadata[num2++] = item;
				}
				return;
			}
		}
		providerMetadata = Statics.MetadataForString(Name, 0, 0, 0);
	}

	private static int AddValueToMetaData(List<byte> metaData, string value)
	{
		if (value.Length == 0)
		{
			return 0;
		}
		int count = metaData.Count;
		char c = value[0];
		switch (c)
		{
		case '@':
			metaData.AddRange(Encoding.UTF8.GetBytes(value.Substring(1)));
			break;
		case '{':
			metaData.AddRange(new Guid(value).ToByteArray());
			break;
		case '#':
		{
			for (int i = 1; i < value.Length; i++)
			{
				if (value[i] != ' ')
				{
					if (i + 1 >= value.Length)
					{
						throw new ArgumentException(Environment.GetResourceString("EvenHexDigits"), "traits");
					}
					metaData.Add((byte)(HexDigit(value[i]) * 16 + HexDigit(value[i + 1])));
					i++;
				}
			}
			break;
		}
		default:
			if (' ' <= c)
			{
				metaData.AddRange(Encoding.UTF8.GetBytes(value));
				break;
			}
			throw new ArgumentException(Environment.GetResourceString("IllegalValue", value), "traits");
		}
		return metaData.Count - count;
	}

	private static int HexDigit(char c)
	{
		if ('0' <= c && c <= '9')
		{
			return c - 48;
		}
		if ('a' <= c)
		{
			c = (char)(c - 32);
		}
		if ('A' <= c && c <= 'F')
		{
			return c - 65 + 10;
		}
		throw new ArgumentException(Environment.GetResourceString("BadHexDigit", c), "traits");
	}

	private NameInfo UpdateDescriptor(string name, TraceLoggingEventTypes eventInfo, ref EventSourceOptions options, out EventDescriptor descriptor)
	{
		NameInfo nameInfo = null;
		int traceloggingId = 0;
		byte level = (((options.valuesSet & 4) != 0) ? options.level : eventInfo.level);
		byte opcode = (((options.valuesSet & 8) != 0) ? options.opcode : eventInfo.opcode);
		EventTags tags = (((options.valuesSet & 2) != 0) ? options.tags : eventInfo.Tags);
		EventKeywords keywords = (((options.valuesSet & 1) != 0) ? options.keywords : eventInfo.keywords);
		if (IsEnabled((EventLevel)level, keywords))
		{
			nameInfo = eventInfo.GetNameInfo(name ?? eventInfo.Name, tags);
			traceloggingId = nameInfo.identity;
		}
		descriptor = new EventDescriptor(traceloggingId, level, opcode, (long)keywords);
		return nameInfo;
	}
}
