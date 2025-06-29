using System.Collections.Generic;
using System.Globalization;
using System.Security;
using System.Security.Permissions;
using Microsoft.Win32;

namespace System.Diagnostics.Eventing.Reader;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public class ProviderMetadata : IDisposable
{
	internal enum ObjectTypeName
	{
		Level,
		Opcode,
		Task,
		Keyword
	}

	private EventLogHandle handle = EventLogHandle.Zero;

	private EventLogHandle defaultProviderHandle = EventLogHandle.Zero;

	private EventLogSession session;

	private string providerName;

	private CultureInfo cultureInfo;

	private string logFilePath;

	private IList<EventLevel> levels;

	private IList<EventOpcode> opcodes;

	private IList<EventTask> tasks;

	private IList<EventKeyword> keywords;

	private IList<EventLevel> standardLevels;

	private IList<EventOpcode> standardOpcodes;

	private IList<EventTask> standardTasks;

	private IList<EventKeyword> standardKeywords;

	private IList<EventLogLink> channelReferences;

	private object syncObject;

	internal EventLogHandle Handle => handle;

	public string Name => providerName;

	public Guid Id => (Guid)NativeWrapper.EvtGetPublisherMetadataProperty(handle, Microsoft.Win32.UnsafeNativeMethods.EvtPublisherMetadataPropertyId.EvtPublisherMetadataPublisherGuid);

	public string MessageFilePath => (string)NativeWrapper.EvtGetPublisherMetadataProperty(handle, Microsoft.Win32.UnsafeNativeMethods.EvtPublisherMetadataPropertyId.EvtPublisherMetadataMessageFilePath);

	public string ResourceFilePath => (string)NativeWrapper.EvtGetPublisherMetadataProperty(handle, Microsoft.Win32.UnsafeNativeMethods.EvtPublisherMetadataPropertyId.EvtPublisherMetadataResourceFilePath);

	public string ParameterFilePath => (string)NativeWrapper.EvtGetPublisherMetadataProperty(handle, Microsoft.Win32.UnsafeNativeMethods.EvtPublisherMetadataPropertyId.EvtPublisherMetadataParameterFilePath);

	public Uri HelpLink
	{
		get
		{
			string text = (string)NativeWrapper.EvtGetPublisherMetadataProperty(handle, Microsoft.Win32.UnsafeNativeMethods.EvtPublisherMetadataPropertyId.EvtPublisherMetadataHelpLink);
			if (text == null || text.Length == 0)
			{
				return null;
			}
			return new Uri(text);
		}
	}

	private uint ProviderMessageID => (uint)NativeWrapper.EvtGetPublisherMetadataProperty(handle, Microsoft.Win32.UnsafeNativeMethods.EvtPublisherMetadataPropertyId.EvtPublisherMetadataPublisherMessageID);

	public string DisplayName
	{
		[SecurityCritical]
		get
		{
			uint providerMessageID = ProviderMessageID;
			if (providerMessageID == uint.MaxValue)
			{
				return null;
			}
			EventLogPermissionHolder.GetEventLogPermission().Demand();
			return NativeWrapper.EvtFormatMessage(handle, providerMessageID);
		}
	}

	public IList<EventLogLink> LogLinks
	{
		[SecurityCritical]
		get
		{
			EventLogHandle eventLogHandle = EventLogHandle.Zero;
			try
			{
				lock (syncObject)
				{
					if (channelReferences != null)
					{
						return channelReferences;
					}
					EventLogPermissionHolder.GetEventLogPermission().Demand();
					eventLogHandle = NativeWrapper.EvtGetPublisherMetadataPropertyHandle(handle, Microsoft.Win32.UnsafeNativeMethods.EvtPublisherMetadataPropertyId.EvtPublisherMetadataChannelReferences);
					int num = NativeWrapper.EvtGetObjectArraySize(eventLogHandle);
					List<EventLogLink> list = new List<EventLogLink>(num);
					for (int i = 0; i < num; i++)
					{
						string text = (string)NativeWrapper.EvtGetObjectArrayProperty(eventLogHandle, i, 7);
						uint channelId = (uint)NativeWrapper.EvtGetObjectArrayProperty(eventLogHandle, i, 9);
						uint num2 = (uint)NativeWrapper.EvtGetObjectArrayProperty(eventLogHandle, i, 10);
						bool flag = num2 == 1;
						int num3 = (int)(uint)NativeWrapper.EvtGetObjectArrayProperty(eventLogHandle, i, 11);
						string text2 = ((num3 != -1) ? NativeWrapper.EvtFormatMessage(handle, (uint)num3) : null);
						if (text2 == null && flag)
						{
							num3 = ((string.Compare(text, "Application", StringComparison.OrdinalIgnoreCase) == 0) ? 256 : ((string.Compare(text, "System", StringComparison.OrdinalIgnoreCase) == 0) ? 258 : ((string.Compare(text, "Security", StringComparison.OrdinalIgnoreCase) != 0) ? (-1) : 257)));
							if (num3 != -1)
							{
								if (defaultProviderHandle.IsInvalid)
								{
									defaultProviderHandle = NativeWrapper.EvtOpenProviderMetadata(session.Handle, null, null, cultureInfo.LCID, 0);
								}
								text2 = NativeWrapper.EvtFormatMessage(defaultProviderHandle, (uint)num3);
							}
						}
						list.Add(new EventLogLink(text, flag, text2, channelId));
					}
					channelReferences = list.AsReadOnly();
				}
				return channelReferences;
			}
			finally
			{
				eventLogHandle.Close();
			}
		}
	}

	public IList<EventLevel> Levels
	{
		get
		{
			lock (syncObject)
			{
				if (levels != null)
				{
					return levels;
				}
				List<EventLevel> list = (List<EventLevel>)GetProviderListProperty(handle, Microsoft.Win32.UnsafeNativeMethods.EvtPublisherMetadataPropertyId.EvtPublisherMetadataLevels);
				levels = list.AsReadOnly();
			}
			return levels;
		}
	}

	public IList<EventOpcode> Opcodes
	{
		get
		{
			lock (syncObject)
			{
				if (opcodes != null)
				{
					return opcodes;
				}
				List<EventOpcode> list = (List<EventOpcode>)GetProviderListProperty(handle, Microsoft.Win32.UnsafeNativeMethods.EvtPublisherMetadataPropertyId.EvtPublisherMetadataOpcodes);
				opcodes = list.AsReadOnly();
			}
			return opcodes;
		}
	}

	public IList<EventKeyword> Keywords
	{
		get
		{
			lock (syncObject)
			{
				if (keywords != null)
				{
					return keywords;
				}
				List<EventKeyword> list = (List<EventKeyword>)GetProviderListProperty(handle, Microsoft.Win32.UnsafeNativeMethods.EvtPublisherMetadataPropertyId.EvtPublisherMetadataKeywords);
				keywords = list.AsReadOnly();
			}
			return keywords;
		}
	}

	public IList<EventTask> Tasks
	{
		get
		{
			lock (syncObject)
			{
				if (tasks != null)
				{
					return tasks;
				}
				List<EventTask> list = (List<EventTask>)GetProviderListProperty(handle, Microsoft.Win32.UnsafeNativeMethods.EvtPublisherMetadataPropertyId.EvtPublisherMetadataTasks);
				tasks = list.AsReadOnly();
			}
			return tasks;
		}
	}

	public IEnumerable<EventMetadata> Events
	{
		[SecurityCritical]
		get
		{
			EventLogPermissionHolder.GetEventLogPermission().Demand();
			List<EventMetadata> list = new List<EventMetadata>();
			EventLogHandle eventLogHandle = NativeWrapper.EvtOpenEventMetadataEnum(handle, 0);
			using (eventLogHandle)
			{
				while (true)
				{
					EventLogHandle eventLogHandle2 = (eventLogHandle2 = NativeWrapper.EvtNextEventMetadata(eventLogHandle, 0));
					if (eventLogHandle2 == null)
					{
						break;
					}
					using (eventLogHandle2)
					{
						uint id = (uint)NativeWrapper.EvtGetEventMetadataProperty(eventLogHandle2, Microsoft.Win32.UnsafeNativeMethods.EvtEventMetadataPropertyId.EventMetadataEventID);
						byte version = (byte)(uint)NativeWrapper.EvtGetEventMetadataProperty(eventLogHandle2, Microsoft.Win32.UnsafeNativeMethods.EvtEventMetadataPropertyId.EventMetadataEventVersion);
						byte channelId = (byte)(uint)NativeWrapper.EvtGetEventMetadataProperty(eventLogHandle2, Microsoft.Win32.UnsafeNativeMethods.EvtEventMetadataPropertyId.EventMetadataEventChannel);
						byte level = (byte)(uint)NativeWrapper.EvtGetEventMetadataProperty(eventLogHandle2, Microsoft.Win32.UnsafeNativeMethods.EvtEventMetadataPropertyId.EventMetadataEventLevel);
						byte opcode = (byte)(uint)NativeWrapper.EvtGetEventMetadataProperty(eventLogHandle2, Microsoft.Win32.UnsafeNativeMethods.EvtEventMetadataPropertyId.EventMetadataEventOpcode);
						short task = (short)(uint)NativeWrapper.EvtGetEventMetadataProperty(eventLogHandle2, Microsoft.Win32.UnsafeNativeMethods.EvtEventMetadataPropertyId.EventMetadataEventTask);
						long num = (long)(ulong)NativeWrapper.EvtGetEventMetadataProperty(eventLogHandle2, Microsoft.Win32.UnsafeNativeMethods.EvtEventMetadataPropertyId.EventMetadataEventKeyword);
						string template = (string)NativeWrapper.EvtGetEventMetadataProperty(eventLogHandle2, Microsoft.Win32.UnsafeNativeMethods.EvtEventMetadataPropertyId.EventMetadataEventTemplate);
						int num2 = (int)(uint)NativeWrapper.EvtGetEventMetadataProperty(eventLogHandle2, Microsoft.Win32.UnsafeNativeMethods.EvtEventMetadataPropertyId.EventMetadataEventMessageID);
						string description = ((num2 != -1) ? NativeWrapper.EvtFormatMessage(handle, (uint)num2) : null);
						EventMetadata item = new EventMetadata(id, version, channelId, level, opcode, task, num, template, description, this);
						list.Add(item);
					}
				}
				return list.AsReadOnly();
			}
		}
	}

	public ProviderMetadata(string providerName)
		: this(providerName, null, null, null)
	{
	}

	public ProviderMetadata(string providerName, EventLogSession session, CultureInfo targetCultureInfo)
		: this(providerName, session, targetCultureInfo, null)
	{
	}

	[SecuritySafeCritical]
	internal ProviderMetadata(string providerName, EventLogSession session, CultureInfo targetCultureInfo, string logFilePath)
	{
		EventLogPermissionHolder.GetEventLogPermission().Demand();
		if (targetCultureInfo == null)
		{
			targetCultureInfo = CultureInfo.CurrentCulture;
		}
		if (session == null)
		{
			session = EventLogSession.GlobalSession;
		}
		this.session = session;
		this.providerName = providerName;
		cultureInfo = targetCultureInfo;
		this.logFilePath = logFilePath;
		handle = NativeWrapper.EvtOpenProviderMetadata(this.session.Handle, this.providerName, this.logFilePath, cultureInfo.LCID, 0);
		syncObject = new object();
	}

	internal string FindStandardLevelDisplayName(string name, uint value)
	{
		if (standardLevels == null)
		{
			standardLevels = (List<EventLevel>)GetProviderListProperty(defaultProviderHandle, Microsoft.Win32.UnsafeNativeMethods.EvtPublisherMetadataPropertyId.EvtPublisherMetadataLevels);
		}
		foreach (EventLevel standardLevel in standardLevels)
		{
			if (standardLevel.Name == name && standardLevel.Value == value)
			{
				return standardLevel.DisplayName;
			}
		}
		return null;
	}

	internal string FindStandardOpcodeDisplayName(string name, uint value)
	{
		if (standardOpcodes == null)
		{
			standardOpcodes = (List<EventOpcode>)GetProviderListProperty(defaultProviderHandle, Microsoft.Win32.UnsafeNativeMethods.EvtPublisherMetadataPropertyId.EvtPublisherMetadataOpcodes);
		}
		foreach (EventOpcode standardOpcode in standardOpcodes)
		{
			if (standardOpcode.Name == name && standardOpcode.Value == value)
			{
				return standardOpcode.DisplayName;
			}
		}
		return null;
	}

	internal string FindStandardKeywordDisplayName(string name, long value)
	{
		if (standardKeywords == null)
		{
			standardKeywords = (List<EventKeyword>)GetProviderListProperty(defaultProviderHandle, Microsoft.Win32.UnsafeNativeMethods.EvtPublisherMetadataPropertyId.EvtPublisherMetadataKeywords);
		}
		foreach (EventKeyword standardKeyword in standardKeywords)
		{
			if (standardKeyword.Name == name && standardKeyword.Value == value)
			{
				return standardKeyword.DisplayName;
			}
		}
		return null;
	}

	internal string FindStandardTaskDisplayName(string name, uint value)
	{
		if (standardTasks == null)
		{
			standardTasks = (List<EventTask>)GetProviderListProperty(defaultProviderHandle, Microsoft.Win32.UnsafeNativeMethods.EvtPublisherMetadataPropertyId.EvtPublisherMetadataTasks);
		}
		foreach (EventTask standardTask in standardTasks)
		{
			if (standardTask.Name == name && standardTask.Value == value)
			{
				return standardTask.DisplayName;
			}
		}
		return null;
	}

	[SecuritySafeCritical]
	internal object GetProviderListProperty(EventLogHandle providerHandle, Microsoft.Win32.UnsafeNativeMethods.EvtPublisherMetadataPropertyId metadataProperty)
	{
		EventLogHandle eventLogHandle = EventLogHandle.Zero;
		EventLogPermissionHolder.GetEventLogPermission().Demand();
		try
		{
			List<EventLevel> list = null;
			List<EventOpcode> list2 = null;
			List<EventKeyword> list3 = null;
			List<EventTask> list4 = null;
			eventLogHandle = NativeWrapper.EvtGetPublisherMetadataPropertyHandle(providerHandle, metadataProperty);
			int num = NativeWrapper.EvtGetObjectArraySize(eventLogHandle);
			Microsoft.Win32.UnsafeNativeMethods.EvtPublisherMetadataPropertyId thePropertyId;
			Microsoft.Win32.UnsafeNativeMethods.EvtPublisherMetadataPropertyId thePropertyId2;
			Microsoft.Win32.UnsafeNativeMethods.EvtPublisherMetadataPropertyId thePropertyId3;
			ObjectTypeName objectTypeName;
			switch (metadataProperty)
			{
			case Microsoft.Win32.UnsafeNativeMethods.EvtPublisherMetadataPropertyId.EvtPublisherMetadataLevels:
				thePropertyId = Microsoft.Win32.UnsafeNativeMethods.EvtPublisherMetadataPropertyId.EvtPublisherMetadataLevelName;
				thePropertyId2 = Microsoft.Win32.UnsafeNativeMethods.EvtPublisherMetadataPropertyId.EvtPublisherMetadataLevelValue;
				thePropertyId3 = Microsoft.Win32.UnsafeNativeMethods.EvtPublisherMetadataPropertyId.EvtPublisherMetadataLevelMessageID;
				objectTypeName = ObjectTypeName.Level;
				list = new List<EventLevel>(num);
				break;
			case Microsoft.Win32.UnsafeNativeMethods.EvtPublisherMetadataPropertyId.EvtPublisherMetadataOpcodes:
				thePropertyId = Microsoft.Win32.UnsafeNativeMethods.EvtPublisherMetadataPropertyId.EvtPublisherMetadataOpcodeName;
				thePropertyId2 = Microsoft.Win32.UnsafeNativeMethods.EvtPublisherMetadataPropertyId.EvtPublisherMetadataOpcodeValue;
				thePropertyId3 = Microsoft.Win32.UnsafeNativeMethods.EvtPublisherMetadataPropertyId.EvtPublisherMetadataOpcodeMessageID;
				objectTypeName = ObjectTypeName.Opcode;
				list2 = new List<EventOpcode>(num);
				break;
			case Microsoft.Win32.UnsafeNativeMethods.EvtPublisherMetadataPropertyId.EvtPublisherMetadataKeywords:
				thePropertyId = Microsoft.Win32.UnsafeNativeMethods.EvtPublisherMetadataPropertyId.EvtPublisherMetadataKeywordName;
				thePropertyId2 = Microsoft.Win32.UnsafeNativeMethods.EvtPublisherMetadataPropertyId.EvtPublisherMetadataKeywordValue;
				thePropertyId3 = Microsoft.Win32.UnsafeNativeMethods.EvtPublisherMetadataPropertyId.EvtPublisherMetadataKeywordMessageID;
				objectTypeName = ObjectTypeName.Keyword;
				list3 = new List<EventKeyword>(num);
				break;
			case Microsoft.Win32.UnsafeNativeMethods.EvtPublisherMetadataPropertyId.EvtPublisherMetadataTasks:
				thePropertyId = Microsoft.Win32.UnsafeNativeMethods.EvtPublisherMetadataPropertyId.EvtPublisherMetadataTaskName;
				thePropertyId2 = Microsoft.Win32.UnsafeNativeMethods.EvtPublisherMetadataPropertyId.EvtPublisherMetadataTaskValue;
				thePropertyId3 = Microsoft.Win32.UnsafeNativeMethods.EvtPublisherMetadataPropertyId.EvtPublisherMetadataTaskMessageID;
				objectTypeName = ObjectTypeName.Task;
				list4 = new List<EventTask>(num);
				break;
			default:
				return null;
			}
			for (int i = 0; i < num; i++)
			{
				string name = (string)NativeWrapper.EvtGetObjectArrayProperty(eventLogHandle, i, (int)thePropertyId);
				uint num2 = 0u;
				long value = 0L;
				if (objectTypeName != ObjectTypeName.Keyword)
				{
					num2 = (uint)NativeWrapper.EvtGetObjectArrayProperty(eventLogHandle, i, (int)thePropertyId2);
				}
				else
				{
					value = (long)(ulong)NativeWrapper.EvtGetObjectArrayProperty(eventLogHandle, i, (int)thePropertyId2);
				}
				int num3 = (int)(uint)NativeWrapper.EvtGetObjectArrayProperty(eventLogHandle, i, (int)thePropertyId3);
				string displayName = null;
				if (num3 == -1)
				{
					if (providerHandle != defaultProviderHandle)
					{
						if (defaultProviderHandle.IsInvalid)
						{
							defaultProviderHandle = NativeWrapper.EvtOpenProviderMetadata(session.Handle, null, null, cultureInfo.LCID, 0);
						}
						displayName = objectTypeName switch
						{
							ObjectTypeName.Level => FindStandardLevelDisplayName(name, num2), 
							ObjectTypeName.Opcode => FindStandardOpcodeDisplayName(name, num2 >> 16), 
							ObjectTypeName.Keyword => FindStandardKeywordDisplayName(name, value), 
							ObjectTypeName.Task => FindStandardTaskDisplayName(name, num2), 
							_ => null, 
						};
					}
				}
				else
				{
					displayName = NativeWrapper.EvtFormatMessage(providerHandle, (uint)num3);
				}
				switch (objectTypeName)
				{
				case ObjectTypeName.Level:
					list.Add(new EventLevel(name, (int)num2, displayName));
					break;
				case ObjectTypeName.Opcode:
					list2.Add(new EventOpcode(name, (int)(num2 >> 16), displayName));
					break;
				case ObjectTypeName.Keyword:
					list3.Add(new EventKeyword(name, value, displayName));
					break;
				case ObjectTypeName.Task:
				{
					Guid guid = (Guid)NativeWrapper.EvtGetObjectArrayProperty(eventLogHandle, i, 18);
					list4.Add(new EventTask(name, (int)num2, displayName, guid));
					break;
				}
				default:
					return null;
				}
			}
			return objectTypeName switch
			{
				ObjectTypeName.Level => list, 
				ObjectTypeName.Opcode => list2, 
				ObjectTypeName.Keyword => list3, 
				ObjectTypeName.Task => list4, 
				_ => null, 
			};
		}
		finally
		{
			eventLogHandle.Close();
		}
	}

	internal void CheckReleased()
	{
		lock (syncObject)
		{
			GetProviderListProperty(handle, Microsoft.Win32.UnsafeNativeMethods.EvtPublisherMetadataPropertyId.EvtPublisherMetadataTasks);
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
			EventLogPermissionHolder.GetEventLogPermission().Demand();
		}
		if (handle != null && !handle.IsInvalid)
		{
			handle.Dispose();
		}
	}
}
