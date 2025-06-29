using System.Collections.Generic;
using System.Security;
using System.Security.Permissions;
using System.Security.Principal;
using System.Text;
using Microsoft.Win32;

namespace System.Diagnostics.Eventing.Reader;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public class EventLogRecord : EventRecord
{
	private const int SYSTEM_PROPERTY_COUNT = 18;

	[SecuritySafeCritical]
	private EventLogHandle handle;

	private EventLogSession session;

	private NativeWrapper.SystemProperties systemProperties;

	private string containerChannel;

	private int[] matchedQueryIds;

	private object syncObject;

	private string levelName;

	private string taskName;

	private string opcodeName;

	private IEnumerable<string> keywordsNames;

	private bool levelNameReady;

	private bool taskNameReady;

	private bool opcodeNameReady;

	private ProviderMetadataCachedInformation cachedMetadataInformation;

	internal EventLogHandle Handle
	{
		[SecuritySafeCritical]
		get
		{
			return handle;
		}
	}

	public override int Id
	{
		get
		{
			PrepareSystemData();
			if (!systemProperties.Id.HasValue)
			{
				return 0;
			}
			return systemProperties.Id.Value;
		}
	}

	public override byte? Version
	{
		get
		{
			PrepareSystemData();
			return systemProperties.Version;
		}
	}

	public override int? Qualifiers
	{
		get
		{
			PrepareSystemData();
			return systemProperties.Qualifiers;
		}
	}

	public override byte? Level
	{
		get
		{
			PrepareSystemData();
			return systemProperties.Level;
		}
	}

	public override int? Task
	{
		get
		{
			PrepareSystemData();
			return systemProperties.Task;
		}
	}

	public override short? Opcode
	{
		get
		{
			PrepareSystemData();
			return systemProperties.Opcode;
		}
	}

	public override long? Keywords
	{
		get
		{
			PrepareSystemData();
			return (long?)systemProperties.Keywords;
		}
	}

	public override long? RecordId
	{
		get
		{
			PrepareSystemData();
			return (long?)systemProperties.RecordId;
		}
	}

	public override string ProviderName
	{
		get
		{
			PrepareSystemData();
			return systemProperties.ProviderName;
		}
	}

	public override Guid? ProviderId
	{
		get
		{
			PrepareSystemData();
			return systemProperties.ProviderId;
		}
	}

	public override string LogName
	{
		get
		{
			PrepareSystemData();
			return systemProperties.ChannelName;
		}
	}

	public override int? ProcessId
	{
		get
		{
			PrepareSystemData();
			return (int?)systemProperties.ProcessId;
		}
	}

	public override int? ThreadId
	{
		get
		{
			PrepareSystemData();
			return (int?)systemProperties.ThreadId;
		}
	}

	public override string MachineName
	{
		get
		{
			PrepareSystemData();
			return systemProperties.ComputerName;
		}
	}

	public override SecurityIdentifier UserId
	{
		get
		{
			PrepareSystemData();
			return systemProperties.UserId;
		}
	}

	public override DateTime? TimeCreated
	{
		get
		{
			PrepareSystemData();
			return systemProperties.TimeCreated;
		}
	}

	public override Guid? ActivityId
	{
		get
		{
			PrepareSystemData();
			return systemProperties.ActivityId;
		}
	}

	public override Guid? RelatedActivityId
	{
		get
		{
			PrepareSystemData();
			return systemProperties.RelatedActivityId;
		}
	}

	public string ContainerLog
	{
		get
		{
			if (containerChannel != null)
			{
				return containerChannel;
			}
			lock (syncObject)
			{
				if (containerChannel == null)
				{
					containerChannel = (string)NativeWrapper.EvtGetEventInfo(Handle, Microsoft.Win32.UnsafeNativeMethods.EvtEventPropertyId.EvtEventPath);
				}
				return containerChannel;
			}
		}
	}

	public IEnumerable<int> MatchedQueryIds
	{
		get
		{
			if (matchedQueryIds != null)
			{
				return matchedQueryIds;
			}
			lock (syncObject)
			{
				if (matchedQueryIds == null)
				{
					matchedQueryIds = (int[])NativeWrapper.EvtGetEventInfo(Handle, Microsoft.Win32.UnsafeNativeMethods.EvtEventPropertyId.EvtEventQueryIDs);
				}
				return matchedQueryIds;
			}
		}
	}

	public override EventBookmark Bookmark
	{
		[SecuritySafeCritical]
		get
		{
			EventLogPermissionHolder.GetEventLogPermission().Demand();
			EventLogHandle eventLogHandle = NativeWrapper.EvtCreateBookmark(null);
			NativeWrapper.EvtUpdateBookmark(eventLogHandle, handle);
			string bookmarkText = NativeWrapper.EvtRenderBookmark(eventLogHandle);
			return new EventBookmark(bookmarkText);
		}
	}

	public override string LevelDisplayName
	{
		get
		{
			if (levelNameReady)
			{
				return levelName;
			}
			lock (syncObject)
			{
				if (!levelNameReady)
				{
					levelNameReady = true;
					levelName = cachedMetadataInformation.GetLevelDisplayName(ProviderName, handle);
				}
				return levelName;
			}
		}
	}

	public override string OpcodeDisplayName
	{
		get
		{
			lock (syncObject)
			{
				if (!opcodeNameReady)
				{
					opcodeNameReady = true;
					opcodeName = cachedMetadataInformation.GetOpcodeDisplayName(ProviderName, handle);
				}
				return opcodeName;
			}
		}
	}

	public override string TaskDisplayName
	{
		get
		{
			if (taskNameReady)
			{
				return taskName;
			}
			lock (syncObject)
			{
				if (!taskNameReady)
				{
					taskNameReady = true;
					taskName = cachedMetadataInformation.GetTaskDisplayName(ProviderName, handle);
				}
				return taskName;
			}
		}
	}

	public override IEnumerable<string> KeywordsDisplayNames
	{
		get
		{
			if (keywordsNames != null)
			{
				return keywordsNames;
			}
			lock (syncObject)
			{
				if (keywordsNames == null)
				{
					keywordsNames = cachedMetadataInformation.GetKeywordDisplayNames(ProviderName, handle);
				}
				return keywordsNames;
			}
		}
	}

	public override IList<EventProperty> Properties
	{
		get
		{
			session.SetupUserContext();
			IList<object> list = NativeWrapper.EvtRenderBufferWithContextUserOrValues(session.renderContextHandleUser, handle);
			List<EventProperty> list2 = new List<EventProperty>();
			foreach (object item in list)
			{
				list2.Add(new EventProperty(item));
			}
			return list2;
		}
	}

	[SecuritySafeCritical]
	internal EventLogRecord(EventLogHandle handle, EventLogSession session, ProviderMetadataCachedInformation cachedMetadataInfo)
	{
		cachedMetadataInformation = cachedMetadataInfo;
		this.handle = handle;
		this.session = session;
		systemProperties = new NativeWrapper.SystemProperties();
		syncObject = new object();
	}

	internal void PrepareSystemData()
	{
		if (systemProperties.filled)
		{
			return;
		}
		session.SetupSystemContext();
		lock (syncObject)
		{
			if (!systemProperties.filled)
			{
				NativeWrapper.EvtRenderBufferWithContextSystem(session.renderContextHandleSystem, handle, Microsoft.Win32.UnsafeNativeMethods.EvtRenderFlags.EvtRenderEventValues, systemProperties, 18);
				systemProperties.filled = true;
			}
		}
	}

	public override string FormatDescription()
	{
		return cachedMetadataInformation.GetFormatDescription(ProviderName, handle);
	}

	public override string FormatDescription(IEnumerable<object> values)
	{
		if (values == null)
		{
			return FormatDescription();
		}
		string[] array = new string[0];
		int num = 0;
		foreach (object value in values)
		{
			if (array.Length == num)
			{
				Array.Resize(ref array, num + 1);
			}
			array[num] = value.ToString();
			num++;
		}
		return cachedMetadataInformation.GetFormatDescription(ProviderName, handle, array);
	}

	public IList<object> GetPropertyValues(EventLogPropertySelector propertySelector)
	{
		if (propertySelector == null)
		{
			throw new ArgumentNullException("propertySelector");
		}
		return NativeWrapper.EvtRenderBufferWithContextUserOrValues(propertySelector.Handle, handle);
	}

	[SecuritySafeCritical]
	public override string ToXml()
	{
		EventLogPermissionHolder.GetEventLogPermission().Demand();
		StringBuilder stringBuilder = new StringBuilder(2000);
		NativeWrapper.EvtRender(EventLogHandle.Zero, handle, Microsoft.Win32.UnsafeNativeMethods.EvtRenderFlags.EvtRenderEventXml, stringBuilder);
		return stringBuilder.ToString();
	}

	[SecuritySafeCritical]
	protected override void Dispose(bool disposing)
	{
		try
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
		finally
		{
			base.Dispose(disposing);
		}
	}

	[SecurityCritical]
	internal static EventLogHandle GetBookmarkHandleFromBookmark(EventBookmark bookmark)
	{
		if (bookmark == null)
		{
			return EventLogHandle.Zero;
		}
		return NativeWrapper.EvtCreateBookmark(bookmark.BookmarkText);
	}
}
