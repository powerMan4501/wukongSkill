using System.Collections.Generic;
using System.Security;
using System.Security.Permissions;
using Microsoft.Win32;

namespace System.Diagnostics.Eventing.Reader;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public class EventLogConfiguration : IDisposable
{
	private EventLogHandle handle = EventLogHandle.Zero;

	private EventLogSession session;

	private string channelName;

	public string LogName => channelName;

	public EventLogType LogType => (EventLogType)(uint)NativeWrapper.EvtGetChannelConfigProperty(handle, Microsoft.Win32.UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelConfigType);

	public EventLogIsolation LogIsolation => (EventLogIsolation)(uint)NativeWrapper.EvtGetChannelConfigProperty(handle, Microsoft.Win32.UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelConfigIsolation);

	public bool IsEnabled
	{
		get
		{
			return (bool)NativeWrapper.EvtGetChannelConfigProperty(handle, Microsoft.Win32.UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelConfigEnabled);
		}
		set
		{
			NativeWrapper.EvtSetChannelConfigProperty(handle, Microsoft.Win32.UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelConfigEnabled, value);
		}
	}

	public bool IsClassicLog => (bool)NativeWrapper.EvtGetChannelConfigProperty(handle, Microsoft.Win32.UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelConfigClassicEventlog);

	public string SecurityDescriptor
	{
		get
		{
			return (string)NativeWrapper.EvtGetChannelConfigProperty(handle, Microsoft.Win32.UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelConfigAccess);
		}
		set
		{
			NativeWrapper.EvtSetChannelConfigProperty(handle, Microsoft.Win32.UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelConfigAccess, value);
		}
	}

	public string LogFilePath
	{
		get
		{
			return (string)NativeWrapper.EvtGetChannelConfigProperty(handle, Microsoft.Win32.UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelLoggingConfigLogFilePath);
		}
		set
		{
			NativeWrapper.EvtSetChannelConfigProperty(handle, Microsoft.Win32.UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelLoggingConfigLogFilePath, value);
		}
	}

	public long MaximumSizeInBytes
	{
		get
		{
			return (long)(ulong)NativeWrapper.EvtGetChannelConfigProperty(handle, Microsoft.Win32.UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelLoggingConfigMaxSize);
		}
		set
		{
			NativeWrapper.EvtSetChannelConfigProperty(handle, Microsoft.Win32.UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelLoggingConfigMaxSize, value);
		}
	}

	public EventLogMode LogMode
	{
		get
		{
			object obj = NativeWrapper.EvtGetChannelConfigProperty(handle, Microsoft.Win32.UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelLoggingConfigRetention);
			object obj2 = NativeWrapper.EvtGetChannelConfigProperty(handle, Microsoft.Win32.UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelLoggingConfigAutoBackup);
			bool flag = obj != null && (bool)obj;
			if (obj2 != null && (bool)obj2)
			{
				return EventLogMode.AutoBackup;
			}
			if (flag)
			{
				return EventLogMode.Retain;
			}
			return EventLogMode.Circular;
		}
		set
		{
			switch (value)
			{
			case EventLogMode.Circular:
				NativeWrapper.EvtSetChannelConfigProperty(handle, Microsoft.Win32.UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelLoggingConfigAutoBackup, false);
				NativeWrapper.EvtSetChannelConfigProperty(handle, Microsoft.Win32.UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelLoggingConfigRetention, false);
				break;
			case EventLogMode.AutoBackup:
				NativeWrapper.EvtSetChannelConfigProperty(handle, Microsoft.Win32.UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelLoggingConfigAutoBackup, true);
				NativeWrapper.EvtSetChannelConfigProperty(handle, Microsoft.Win32.UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelLoggingConfigRetention, true);
				break;
			case EventLogMode.Retain:
				NativeWrapper.EvtSetChannelConfigProperty(handle, Microsoft.Win32.UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelLoggingConfigAutoBackup, false);
				NativeWrapper.EvtSetChannelConfigProperty(handle, Microsoft.Win32.UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelLoggingConfigRetention, true);
				break;
			}
		}
	}

	public string OwningProviderName => (string)NativeWrapper.EvtGetChannelConfigProperty(handle, Microsoft.Win32.UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelConfigOwningPublisher);

	public IEnumerable<string> ProviderNames => (string[])NativeWrapper.EvtGetChannelConfigProperty(handle, Microsoft.Win32.UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelPublisherList);

	public int? ProviderLevel
	{
		get
		{
			return (int?)(uint?)NativeWrapper.EvtGetChannelConfigProperty(handle, Microsoft.Win32.UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelPublishingConfigLevel);
		}
		set
		{
			NativeWrapper.EvtSetChannelConfigProperty(handle, Microsoft.Win32.UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelPublishingConfigLevel, value);
		}
	}

	public long? ProviderKeywords
	{
		get
		{
			return (long?)(ulong?)NativeWrapper.EvtGetChannelConfigProperty(handle, Microsoft.Win32.UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelPublishingConfigKeywords);
		}
		set
		{
			NativeWrapper.EvtSetChannelConfigProperty(handle, Microsoft.Win32.UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelPublishingConfigKeywords, value);
		}
	}

	public int? ProviderBufferSize => (int?)(uint?)NativeWrapper.EvtGetChannelConfigProperty(handle, Microsoft.Win32.UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelPublishingConfigBufferSize);

	public int? ProviderMinimumNumberOfBuffers => (int?)(uint?)NativeWrapper.EvtGetChannelConfigProperty(handle, Microsoft.Win32.UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelPublishingConfigMinBuffers);

	public int? ProviderMaximumNumberOfBuffers => (int?)(uint?)NativeWrapper.EvtGetChannelConfigProperty(handle, Microsoft.Win32.UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelPublishingConfigMaxBuffers);

	public int? ProviderLatency => (int?)(uint?)NativeWrapper.EvtGetChannelConfigProperty(handle, Microsoft.Win32.UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelPublishingConfigLatency);

	public Guid? ProviderControlGuid => (Guid?)NativeWrapper.EvtGetChannelConfigProperty(handle, Microsoft.Win32.UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelPublishingConfigControlGuid);

	public EventLogConfiguration(string logName)
		: this(logName, null)
	{
	}

	[SecurityCritical]
	public EventLogConfiguration(string logName, EventLogSession session)
	{
		EventLogPermissionHolder.GetEventLogPermission().Demand();
		if (session == null)
		{
			session = EventLogSession.GlobalSession;
		}
		this.session = session;
		channelName = logName;
		handle = NativeWrapper.EvtOpenChannelConfig(this.session.Handle, channelName, 0);
	}

	public void SaveChanges()
	{
		NativeWrapper.EvtSaveChannelConfig(handle, 0);
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
