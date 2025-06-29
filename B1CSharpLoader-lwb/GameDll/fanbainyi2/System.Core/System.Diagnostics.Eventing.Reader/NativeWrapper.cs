using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Security.Principal;
using System.Text;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace System.Diagnostics.Eventing.Reader;

internal class NativeWrapper
{
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public class SystemProperties
	{
		public bool filled;

		public ushort? Id;

		public byte? Version;

		public ushort? Qualifiers;

		public byte? Level;

		public ushort? Task;

		public byte? Opcode;

		public ulong? Keywords;

		public ulong? RecordId;

		public string ProviderName;

		public Guid? ProviderId;

		public string ChannelName;

		public uint? ProcessId;

		public uint? ThreadId;

		public string ComputerName;

		public SecurityIdentifier UserId;

		public DateTime? TimeCreated;

		public Guid? ActivityId;

		public Guid? RelatedActivityId;
	}

	private static bool s_platformNotSupported = Environment.OSVersion.Version.Major < 6;

	[SecurityCritical]
	public static EventLogHandle EvtQuery(EventLogHandle session, string path, string query, int flags)
	{
		if (s_platformNotSupported)
		{
			throw new PlatformNotSupportedException();
		}
		EventLogHandle eventLogHandle = Microsoft.Win32.UnsafeNativeMethods.EvtQuery(session, path, query, flags);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (eventLogHandle.IsInvalid)
		{
			EventLogException.Throw(lastWin32Error);
		}
		return eventLogHandle;
	}

	[SecurityCritical]
	public static void EvtSeek(EventLogHandle resultSet, long position, EventLogHandle bookmark, int timeout, Microsoft.Win32.UnsafeNativeMethods.EvtSeekFlags flags)
	{
		bool flag = Microsoft.Win32.UnsafeNativeMethods.EvtSeek(resultSet, position, bookmark, timeout, flags);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (!flag)
		{
			EventLogException.Throw(lastWin32Error);
		}
	}

	[SecurityCritical]
	public static EventLogHandle EvtSubscribe(EventLogHandle session, SafeWaitHandle signalEvent, string path, string query, EventLogHandle bookmark, IntPtr context, IntPtr callback, int flags)
	{
		if (s_platformNotSupported)
		{
			throw new PlatformNotSupportedException();
		}
		EventLogHandle eventLogHandle = Microsoft.Win32.UnsafeNativeMethods.EvtSubscribe(session, signalEvent, path, query, bookmark, context, callback, flags);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (eventLogHandle.IsInvalid)
		{
			EventLogException.Throw(lastWin32Error);
		}
		return eventLogHandle;
	}

	[SecurityCritical]
	public static bool EvtNext(EventLogHandle queryHandle, int eventSize, IntPtr[] events, int timeout, int flags, ref int returned)
	{
		bool flag = Microsoft.Win32.UnsafeNativeMethods.EvtNext(queryHandle, eventSize, events, timeout, flags, ref returned);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (!flag && lastWin32Error != 259)
		{
			EventLogException.Throw(lastWin32Error);
		}
		return lastWin32Error == 0;
	}

	[SecuritySafeCritical]
	public static void EvtCancel(EventLogHandle handle)
	{
		EventLogPermissionHolder.GetEventLogPermission().Demand();
		if (!Microsoft.Win32.UnsafeNativeMethods.EvtCancel(handle))
		{
			int lastWin32Error = Marshal.GetLastWin32Error();
			EventLogException.Throw(lastWin32Error);
		}
	}

	[SecurityCritical]
	public static void EvtClose(IntPtr handle)
	{
		Microsoft.Win32.UnsafeNativeMethods.EvtClose(handle);
	}

	[SecurityCritical]
	public static EventLogHandle EvtOpenProviderMetadata(EventLogHandle session, string ProviderId, string logFilePath, int locale, int flags)
	{
		if (s_platformNotSupported)
		{
			throw new PlatformNotSupportedException();
		}
		EventLogHandle eventLogHandle = Microsoft.Win32.UnsafeNativeMethods.EvtOpenPublisherMetadata(session, ProviderId, logFilePath, 0, flags);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (eventLogHandle.IsInvalid)
		{
			EventLogException.Throw(lastWin32Error);
		}
		return eventLogHandle;
	}

	[SecurityCritical]
	public static int EvtGetObjectArraySize(EventLogHandle objectArray)
	{
		int objectArraySize;
		bool flag = Microsoft.Win32.UnsafeNativeMethods.EvtGetObjectArraySize(objectArray, out objectArraySize);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (!flag)
		{
			EventLogException.Throw(lastWin32Error);
		}
		return objectArraySize;
	}

	[SecurityCritical]
	public static EventLogHandle EvtOpenEventMetadataEnum(EventLogHandle ProviderMetadata, int flags)
	{
		EventLogHandle eventLogHandle = Microsoft.Win32.UnsafeNativeMethods.EvtOpenEventMetadataEnum(ProviderMetadata, flags);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (eventLogHandle.IsInvalid)
		{
			EventLogException.Throw(lastWin32Error);
		}
		return eventLogHandle;
	}

	[SecurityCritical]
	public static EventLogHandle EvtNextEventMetadata(EventLogHandle eventMetadataEnum, int flags)
	{
		EventLogHandle eventLogHandle = Microsoft.Win32.UnsafeNativeMethods.EvtNextEventMetadata(eventMetadataEnum, flags);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (eventLogHandle.IsInvalid)
		{
			if (lastWin32Error != 259)
			{
				EventLogException.Throw(lastWin32Error);
			}
			return null;
		}
		return eventLogHandle;
	}

	[SecurityCritical]
	public static EventLogHandle EvtOpenChannelEnum(EventLogHandle session, int flags)
	{
		if (s_platformNotSupported)
		{
			throw new PlatformNotSupportedException();
		}
		EventLogHandle eventLogHandle = Microsoft.Win32.UnsafeNativeMethods.EvtOpenChannelEnum(session, flags);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (eventLogHandle.IsInvalid)
		{
			EventLogException.Throw(lastWin32Error);
		}
		return eventLogHandle;
	}

	[SecurityCritical]
	public static EventLogHandle EvtOpenProviderEnum(EventLogHandle session, int flags)
	{
		if (s_platformNotSupported)
		{
			throw new PlatformNotSupportedException();
		}
		EventLogHandle eventLogHandle = Microsoft.Win32.UnsafeNativeMethods.EvtOpenPublisherEnum(session, flags);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (eventLogHandle.IsInvalid)
		{
			EventLogException.Throw(lastWin32Error);
		}
		return eventLogHandle;
	}

	[SecurityCritical]
	public static EventLogHandle EvtOpenChannelConfig(EventLogHandle session, string channelPath, int flags)
	{
		if (s_platformNotSupported)
		{
			throw new PlatformNotSupportedException();
		}
		EventLogHandle eventLogHandle = Microsoft.Win32.UnsafeNativeMethods.EvtOpenChannelConfig(session, channelPath, flags);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (eventLogHandle.IsInvalid)
		{
			EventLogException.Throw(lastWin32Error);
		}
		return eventLogHandle;
	}

	[SecuritySafeCritical]
	public static void EvtSaveChannelConfig(EventLogHandle channelConfig, int flags)
	{
		EventLogPermissionHolder.GetEventLogPermission().Demand();
		bool flag = Microsoft.Win32.UnsafeNativeMethods.EvtSaveChannelConfig(channelConfig, flags);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (!flag)
		{
			EventLogException.Throw(lastWin32Error);
		}
	}

	[SecurityCritical]
	public static EventLogHandle EvtOpenLog(EventLogHandle session, string path, PathType flags)
	{
		if (s_platformNotSupported)
		{
			throw new PlatformNotSupportedException();
		}
		EventLogHandle eventLogHandle = Microsoft.Win32.UnsafeNativeMethods.EvtOpenLog(session, path, flags);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (eventLogHandle.IsInvalid)
		{
			EventLogException.Throw(lastWin32Error);
		}
		return eventLogHandle;
	}

	[SecuritySafeCritical]
	public static void EvtExportLog(EventLogHandle session, string channelPath, string query, string targetFilePath, int flags)
	{
		if (s_platformNotSupported)
		{
			throw new PlatformNotSupportedException();
		}
		EventLogPermissionHolder.GetEventLogPermission().Demand();
		bool flag = Microsoft.Win32.UnsafeNativeMethods.EvtExportLog(session, channelPath, query, targetFilePath, flags);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (!flag)
		{
			EventLogException.Throw(lastWin32Error);
		}
	}

	[SecuritySafeCritical]
	public static void EvtArchiveExportedLog(EventLogHandle session, string logFilePath, int locale, int flags)
	{
		if (s_platformNotSupported)
		{
			throw new PlatformNotSupportedException();
		}
		EventLogPermissionHolder.GetEventLogPermission().Demand();
		bool flag = Microsoft.Win32.UnsafeNativeMethods.EvtArchiveExportedLog(session, logFilePath, locale, flags);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (!flag)
		{
			EventLogException.Throw(lastWin32Error);
		}
	}

	[SecuritySafeCritical]
	public static void EvtClearLog(EventLogHandle session, string channelPath, string targetFilePath, int flags)
	{
		if (s_platformNotSupported)
		{
			throw new PlatformNotSupportedException();
		}
		EventLogPermissionHolder.GetEventLogPermission().Demand();
		bool flag = Microsoft.Win32.UnsafeNativeMethods.EvtClearLog(session, channelPath, targetFilePath, flags);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (!flag)
		{
			EventLogException.Throw(lastWin32Error);
		}
	}

	[SecurityCritical]
	public static EventLogHandle EvtCreateRenderContext(int valuePathsCount, string[] valuePaths, Microsoft.Win32.UnsafeNativeMethods.EvtRenderContextFlags flags)
	{
		if (s_platformNotSupported)
		{
			throw new PlatformNotSupportedException();
		}
		EventLogHandle eventLogHandle = Microsoft.Win32.UnsafeNativeMethods.EvtCreateRenderContext(valuePathsCount, valuePaths, flags);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (eventLogHandle.IsInvalid)
		{
			EventLogException.Throw(lastWin32Error);
		}
		return eventLogHandle;
	}

	[SecurityCritical]
	public static void EvtRender(EventLogHandle context, EventLogHandle eventHandle, Microsoft.Win32.UnsafeNativeMethods.EvtRenderFlags flags, StringBuilder buffer)
	{
		if (s_platformNotSupported)
		{
			throw new PlatformNotSupportedException();
		}
		int buffUsed;
		int propCount;
		bool flag = Microsoft.Win32.UnsafeNativeMethods.EvtRender(context, eventHandle, flags, buffer.Capacity, buffer, out buffUsed, out propCount);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (!flag)
		{
			if (lastWin32Error == 122)
			{
				buffer.Capacity = buffUsed;
				flag = Microsoft.Win32.UnsafeNativeMethods.EvtRender(context, eventHandle, flags, buffer.Capacity, buffer, out buffUsed, out propCount);
				lastWin32Error = Marshal.GetLastWin32Error();
			}
			if (!flag)
			{
				EventLogException.Throw(lastWin32Error);
			}
		}
	}

	[SecurityCritical]
	public static EventLogHandle EvtOpenSession(Microsoft.Win32.UnsafeNativeMethods.EvtLoginClass loginClass, ref Microsoft.Win32.UnsafeNativeMethods.EvtRpcLogin login, int timeout, int flags)
	{
		if (s_platformNotSupported)
		{
			throw new PlatformNotSupportedException();
		}
		EventLogHandle eventLogHandle = Microsoft.Win32.UnsafeNativeMethods.EvtOpenSession(loginClass, ref login, timeout, flags);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (eventLogHandle.IsInvalid)
		{
			EventLogException.Throw(lastWin32Error);
		}
		return eventLogHandle;
	}

	[SecurityCritical]
	public static EventLogHandle EvtCreateBookmark(string bookmarkXml)
	{
		if (s_platformNotSupported)
		{
			throw new PlatformNotSupportedException();
		}
		EventLogHandle eventLogHandle = Microsoft.Win32.UnsafeNativeMethods.EvtCreateBookmark(bookmarkXml);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (eventLogHandle.IsInvalid)
		{
			EventLogException.Throw(lastWin32Error);
		}
		return eventLogHandle;
	}

	[SecurityCritical]
	public static void EvtUpdateBookmark(EventLogHandle bookmark, EventLogHandle eventHandle)
	{
		bool flag = Microsoft.Win32.UnsafeNativeMethods.EvtUpdateBookmark(bookmark, eventHandle);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (!flag)
		{
			EventLogException.Throw(lastWin32Error);
		}
	}

	[SecuritySafeCritical]
	public static object EvtGetEventInfo(EventLogHandle handle, Microsoft.Win32.UnsafeNativeMethods.EvtEventPropertyId enumType)
	{
		IntPtr intPtr = IntPtr.Zero;
		EventLogPermissionHolder.GetEventLogPermission().Demand();
		try
		{
			bool flag = Microsoft.Win32.UnsafeNativeMethods.EvtGetEventInfo(handle, enumType, 0, IntPtr.Zero, out var bufferUsed);
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (!flag && lastWin32Error != 0 && lastWin32Error != 122)
			{
				EventLogException.Throw(lastWin32Error);
			}
			intPtr = Marshal.AllocHGlobal(bufferUsed);
			flag = Microsoft.Win32.UnsafeNativeMethods.EvtGetEventInfo(handle, enumType, bufferUsed, intPtr, out bufferUsed);
			lastWin32Error = Marshal.GetLastWin32Error();
			if (!flag)
			{
				EventLogException.Throw(lastWin32Error);
			}
			Microsoft.Win32.UnsafeNativeMethods.EvtVariant val = (Microsoft.Win32.UnsafeNativeMethods.EvtVariant)Marshal.PtrToStructure(intPtr, typeof(Microsoft.Win32.UnsafeNativeMethods.EvtVariant));
			return ConvertToObject(val);
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intPtr);
			}
		}
	}

	[SecurityCritical]
	public static object EvtGetQueryInfo(EventLogHandle handle, Microsoft.Win32.UnsafeNativeMethods.EvtQueryPropertyId enumType)
	{
		IntPtr intPtr = IntPtr.Zero;
		int bufferRequired = 0;
		try
		{
			bool flag = Microsoft.Win32.UnsafeNativeMethods.EvtGetQueryInfo(handle, enumType, 0, IntPtr.Zero, ref bufferRequired);
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (!flag && lastWin32Error != 122)
			{
				EventLogException.Throw(lastWin32Error);
			}
			intPtr = Marshal.AllocHGlobal(bufferRequired);
			flag = Microsoft.Win32.UnsafeNativeMethods.EvtGetQueryInfo(handle, enumType, bufferRequired, intPtr, ref bufferRequired);
			lastWin32Error = Marshal.GetLastWin32Error();
			if (!flag)
			{
				EventLogException.Throw(lastWin32Error);
			}
			Microsoft.Win32.UnsafeNativeMethods.EvtVariant val = (Microsoft.Win32.UnsafeNativeMethods.EvtVariant)Marshal.PtrToStructure(intPtr, typeof(Microsoft.Win32.UnsafeNativeMethods.EvtVariant));
			return ConvertToObject(val);
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intPtr);
			}
		}
	}

	[SecuritySafeCritical]
	public static object EvtGetPublisherMetadataProperty(EventLogHandle pmHandle, Microsoft.Win32.UnsafeNativeMethods.EvtPublisherMetadataPropertyId thePropertyId)
	{
		IntPtr intPtr = IntPtr.Zero;
		EventLogPermissionHolder.GetEventLogPermission().Demand();
		try
		{
			bool flag = Microsoft.Win32.UnsafeNativeMethods.EvtGetPublisherMetadataProperty(pmHandle, thePropertyId, 0, 0, IntPtr.Zero, out var publisherMetadataPropertyBufferUsed);
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (!flag && lastWin32Error != 122)
			{
				EventLogException.Throw(lastWin32Error);
			}
			intPtr = Marshal.AllocHGlobal(publisherMetadataPropertyBufferUsed);
			flag = Microsoft.Win32.UnsafeNativeMethods.EvtGetPublisherMetadataProperty(pmHandle, thePropertyId, 0, publisherMetadataPropertyBufferUsed, intPtr, out publisherMetadataPropertyBufferUsed);
			lastWin32Error = Marshal.GetLastWin32Error();
			if (!flag)
			{
				EventLogException.Throw(lastWin32Error);
			}
			Microsoft.Win32.UnsafeNativeMethods.EvtVariant val = (Microsoft.Win32.UnsafeNativeMethods.EvtVariant)Marshal.PtrToStructure(intPtr, typeof(Microsoft.Win32.UnsafeNativeMethods.EvtVariant));
			return ConvertToObject(val);
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intPtr);
			}
		}
	}

	[SecurityCritical]
	internal static EventLogHandle EvtGetPublisherMetadataPropertyHandle(EventLogHandle pmHandle, Microsoft.Win32.UnsafeNativeMethods.EvtPublisherMetadataPropertyId thePropertyId)
	{
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			bool flag = Microsoft.Win32.UnsafeNativeMethods.EvtGetPublisherMetadataProperty(pmHandle, thePropertyId, 0, 0, IntPtr.Zero, out var publisherMetadataPropertyBufferUsed);
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (!flag && lastWin32Error != 122)
			{
				EventLogException.Throw(lastWin32Error);
			}
			intPtr = Marshal.AllocHGlobal(publisherMetadataPropertyBufferUsed);
			flag = Microsoft.Win32.UnsafeNativeMethods.EvtGetPublisherMetadataProperty(pmHandle, thePropertyId, 0, publisherMetadataPropertyBufferUsed, intPtr, out publisherMetadataPropertyBufferUsed);
			lastWin32Error = Marshal.GetLastWin32Error();
			if (!flag)
			{
				EventLogException.Throw(lastWin32Error);
			}
			Microsoft.Win32.UnsafeNativeMethods.EvtVariant val = (Microsoft.Win32.UnsafeNativeMethods.EvtVariant)Marshal.PtrToStructure(intPtr, typeof(Microsoft.Win32.UnsafeNativeMethods.EvtVariant));
			return ConvertToSafeHandle(val);
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intPtr);
			}
		}
	}

	[SecurityCritical]
	public static string EvtFormatMessage(EventLogHandle handle, uint msgId)
	{
		if (s_platformNotSupported)
		{
			throw new PlatformNotSupportedException();
		}
		StringBuilder stringBuilder = new StringBuilder(null);
		bool flag = Microsoft.Win32.UnsafeNativeMethods.EvtFormatMessage(handle, EventLogHandle.Zero, msgId, 0, null, Microsoft.Win32.UnsafeNativeMethods.EvtFormatMessageFlags.EvtFormatMessageId, 0, stringBuilder, out var bufferUsed);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (!flag)
		{
			switch (lastWin32Error)
			{
			case 1815:
			case 15027:
			case 15028:
			case 15033:
			case 15100:
				return null;
			default:
				if (lastWin32Error != 122)
				{
					EventLogException.Throw(lastWin32Error);
				}
				break;
			case 15029:
			case 15030:
			case 15031:
				break;
			}
		}
		stringBuilder.EnsureCapacity(bufferUsed);
		flag = Microsoft.Win32.UnsafeNativeMethods.EvtFormatMessage(handle, EventLogHandle.Zero, msgId, 0, null, Microsoft.Win32.UnsafeNativeMethods.EvtFormatMessageFlags.EvtFormatMessageId, bufferUsed, stringBuilder, out bufferUsed);
		lastWin32Error = Marshal.GetLastWin32Error();
		if (!flag)
		{
			switch (lastWin32Error)
			{
			case 1815:
			case 15027:
			case 15028:
			case 15033:
			case 15100:
				return null;
			default:
				if (lastWin32Error == 15029)
				{
					return null;
				}
				EventLogException.Throw(lastWin32Error);
				break;
			case 15029:
			case 15030:
			case 15031:
				break;
			}
		}
		return stringBuilder.ToString();
	}

	[SecurityCritical]
	public static object EvtGetObjectArrayProperty(EventLogHandle objArrayHandle, int index, int thePropertyId)
	{
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			bool flag = Microsoft.Win32.UnsafeNativeMethods.EvtGetObjectArrayProperty(objArrayHandle, thePropertyId, index, 0, 0, IntPtr.Zero, out var propertyValueBufferUsed);
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (!flag && lastWin32Error != 122)
			{
				EventLogException.Throw(lastWin32Error);
			}
			intPtr = Marshal.AllocHGlobal(propertyValueBufferUsed);
			flag = Microsoft.Win32.UnsafeNativeMethods.EvtGetObjectArrayProperty(objArrayHandle, thePropertyId, index, 0, propertyValueBufferUsed, intPtr, out propertyValueBufferUsed);
			lastWin32Error = Marshal.GetLastWin32Error();
			if (!flag)
			{
				EventLogException.Throw(lastWin32Error);
			}
			Microsoft.Win32.UnsafeNativeMethods.EvtVariant val = (Microsoft.Win32.UnsafeNativeMethods.EvtVariant)Marshal.PtrToStructure(intPtr, typeof(Microsoft.Win32.UnsafeNativeMethods.EvtVariant));
			return ConvertToObject(val);
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intPtr);
			}
		}
	}

	[SecurityCritical]
	public static object EvtGetEventMetadataProperty(EventLogHandle handle, Microsoft.Win32.UnsafeNativeMethods.EvtEventMetadataPropertyId enumType)
	{
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			bool flag = Microsoft.Win32.UnsafeNativeMethods.EvtGetEventMetadataProperty(handle, enumType, 0, 0, IntPtr.Zero, out var eventMetadataPropertyBufferUsed);
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (!flag && lastWin32Error != 122)
			{
				EventLogException.Throw(lastWin32Error);
			}
			intPtr = Marshal.AllocHGlobal(eventMetadataPropertyBufferUsed);
			flag = Microsoft.Win32.UnsafeNativeMethods.EvtGetEventMetadataProperty(handle, enumType, 0, eventMetadataPropertyBufferUsed, intPtr, out eventMetadataPropertyBufferUsed);
			lastWin32Error = Marshal.GetLastWin32Error();
			if (!flag)
			{
				EventLogException.Throw(lastWin32Error);
			}
			Microsoft.Win32.UnsafeNativeMethods.EvtVariant val = (Microsoft.Win32.UnsafeNativeMethods.EvtVariant)Marshal.PtrToStructure(intPtr, typeof(Microsoft.Win32.UnsafeNativeMethods.EvtVariant));
			return ConvertToObject(val);
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intPtr);
			}
		}
	}

	[SecuritySafeCritical]
	public static object EvtGetChannelConfigProperty(EventLogHandle handle, Microsoft.Win32.UnsafeNativeMethods.EvtChannelConfigPropertyId enumType)
	{
		IntPtr intPtr = IntPtr.Zero;
		EventLogPermissionHolder.GetEventLogPermission().Demand();
		try
		{
			bool flag = Microsoft.Win32.UnsafeNativeMethods.EvtGetChannelConfigProperty(handle, enumType, 0, 0, IntPtr.Zero, out var propertyValueBufferUsed);
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (!flag && lastWin32Error != 122)
			{
				EventLogException.Throw(lastWin32Error);
			}
			intPtr = Marshal.AllocHGlobal(propertyValueBufferUsed);
			flag = Microsoft.Win32.UnsafeNativeMethods.EvtGetChannelConfigProperty(handle, enumType, 0, propertyValueBufferUsed, intPtr, out propertyValueBufferUsed);
			lastWin32Error = Marshal.GetLastWin32Error();
			if (!flag)
			{
				EventLogException.Throw(lastWin32Error);
			}
			Microsoft.Win32.UnsafeNativeMethods.EvtVariant val = (Microsoft.Win32.UnsafeNativeMethods.EvtVariant)Marshal.PtrToStructure(intPtr, typeof(Microsoft.Win32.UnsafeNativeMethods.EvtVariant));
			return ConvertToObject(val);
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intPtr);
			}
		}
	}

	[SecuritySafeCritical]
	public static void EvtSetChannelConfigProperty(EventLogHandle handle, Microsoft.Win32.UnsafeNativeMethods.EvtChannelConfigPropertyId enumType, object val)
	{
		EventLogPermissionHolder.GetEventLogPermission().Demand();
		Microsoft.Win32.UnsafeNativeMethods.EvtVariant propertyValue = default(Microsoft.Win32.UnsafeNativeMethods.EvtVariant);
		CoTaskMemSafeHandle coTaskMemSafeHandle = new CoTaskMemSafeHandle();
		using (coTaskMemSafeHandle)
		{
			if (val != null)
			{
				switch (enumType)
				{
				case Microsoft.Win32.UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelConfigEnabled:
					propertyValue.Type = 13u;
					if ((bool)val)
					{
						propertyValue.Bool = 1u;
					}
					else
					{
						propertyValue.Bool = 0u;
					}
					break;
				case Microsoft.Win32.UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelConfigAccess:
					propertyValue.Type = 1u;
					coTaskMemSafeHandle.SetMemory(Marshal.StringToCoTaskMemAuto((string)val));
					propertyValue.StringVal = coTaskMemSafeHandle.GetMemory();
					break;
				case Microsoft.Win32.UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelLoggingConfigLogFilePath:
					propertyValue.Type = 1u;
					coTaskMemSafeHandle.SetMemory(Marshal.StringToCoTaskMemAuto((string)val));
					propertyValue.StringVal = coTaskMemSafeHandle.GetMemory();
					break;
				case Microsoft.Win32.UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelLoggingConfigMaxSize:
					propertyValue.Type = 10u;
					propertyValue.ULong = (ulong)(long)val;
					break;
				case Microsoft.Win32.UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelPublishingConfigLevel:
					propertyValue.Type = 8u;
					propertyValue.UInteger = (uint)(int)val;
					break;
				case Microsoft.Win32.UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelPublishingConfigKeywords:
					propertyValue.Type = 10u;
					propertyValue.ULong = (ulong)(long)val;
					break;
				case Microsoft.Win32.UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelLoggingConfigRetention:
					propertyValue.Type = 13u;
					if ((bool)val)
					{
						propertyValue.Bool = 1u;
					}
					else
					{
						propertyValue.Bool = 0u;
					}
					break;
				case Microsoft.Win32.UnsafeNativeMethods.EvtChannelConfigPropertyId.EvtChannelLoggingConfigAutoBackup:
					propertyValue.Type = 13u;
					if ((bool)val)
					{
						propertyValue.Bool = 1u;
					}
					else
					{
						propertyValue.Bool = 0u;
					}
					break;
				default:
					throw new InvalidOperationException();
				}
			}
			else
			{
				propertyValue.Type = 0u;
			}
			bool flag = Microsoft.Win32.UnsafeNativeMethods.EvtSetChannelConfigProperty(handle, enumType, 0, ref propertyValue);
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (!flag)
			{
				EventLogException.Throw(lastWin32Error);
			}
		}
	}

	[SecurityCritical]
	public static string EvtNextChannelPath(EventLogHandle handle, ref bool finish)
	{
		StringBuilder stringBuilder = new StringBuilder(null);
		bool flag = Microsoft.Win32.UnsafeNativeMethods.EvtNextChannelPath(handle, 0, stringBuilder, out var channelPathBufferUsed);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (!flag)
		{
			switch (lastWin32Error)
			{
			case 259:
				finish = true;
				return null;
			default:
				EventLogException.Throw(lastWin32Error);
				break;
			case 122:
				break;
			}
		}
		stringBuilder.EnsureCapacity(channelPathBufferUsed);
		flag = Microsoft.Win32.UnsafeNativeMethods.EvtNextChannelPath(handle, channelPathBufferUsed, stringBuilder, out channelPathBufferUsed);
		lastWin32Error = Marshal.GetLastWin32Error();
		if (!flag)
		{
			EventLogException.Throw(lastWin32Error);
		}
		return stringBuilder.ToString();
	}

	[SecurityCritical]
	public static string EvtNextPublisherId(EventLogHandle handle, ref bool finish)
	{
		StringBuilder stringBuilder = new StringBuilder(null);
		bool flag = Microsoft.Win32.UnsafeNativeMethods.EvtNextPublisherId(handle, 0, stringBuilder, out var publisherIdBufferUsed);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (!flag)
		{
			switch (lastWin32Error)
			{
			case 259:
				finish = true;
				return null;
			default:
				EventLogException.Throw(lastWin32Error);
				break;
			case 122:
				break;
			}
		}
		stringBuilder.EnsureCapacity(publisherIdBufferUsed);
		flag = Microsoft.Win32.UnsafeNativeMethods.EvtNextPublisherId(handle, publisherIdBufferUsed, stringBuilder, out publisherIdBufferUsed);
		lastWin32Error = Marshal.GetLastWin32Error();
		if (!flag)
		{
			EventLogException.Throw(lastWin32Error);
		}
		return stringBuilder.ToString();
	}

	[SecurityCritical]
	public static object EvtGetLogInfo(EventLogHandle handle, Microsoft.Win32.UnsafeNativeMethods.EvtLogPropertyId enumType)
	{
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			bool flag = Microsoft.Win32.UnsafeNativeMethods.EvtGetLogInfo(handle, enumType, 0, IntPtr.Zero, out var propertyValueBufferUsed);
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (!flag && lastWin32Error != 122)
			{
				EventLogException.Throw(lastWin32Error);
			}
			intPtr = Marshal.AllocHGlobal(propertyValueBufferUsed);
			flag = Microsoft.Win32.UnsafeNativeMethods.EvtGetLogInfo(handle, enumType, propertyValueBufferUsed, intPtr, out propertyValueBufferUsed);
			lastWin32Error = Marshal.GetLastWin32Error();
			if (!flag)
			{
				EventLogException.Throw(lastWin32Error);
			}
			Microsoft.Win32.UnsafeNativeMethods.EvtVariant val = (Microsoft.Win32.UnsafeNativeMethods.EvtVariant)Marshal.PtrToStructure(intPtr, typeof(Microsoft.Win32.UnsafeNativeMethods.EvtVariant));
			return ConvertToObject(val);
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intPtr);
			}
		}
	}

	[SecuritySafeCritical]
	public static void EvtRenderBufferWithContextSystem(EventLogHandle contextHandle, EventLogHandle eventHandle, Microsoft.Win32.UnsafeNativeMethods.EvtRenderFlags flag, SystemProperties systemProperties, int SYSTEM_PROPERTY_COUNT)
	{
		IntPtr intPtr = IntPtr.Zero;
		IntPtr zero = IntPtr.Zero;
		EventLogPermissionHolder.GetEventLogPermission().Demand();
		try
		{
			if (!Microsoft.Win32.UnsafeNativeMethods.EvtRender(contextHandle, eventHandle, flag, 0, IntPtr.Zero, out var buffUsed, out var propCount))
			{
				int lastWin32Error = Marshal.GetLastWin32Error();
				if (lastWin32Error != 122)
				{
					EventLogException.Throw(lastWin32Error);
				}
			}
			intPtr = Marshal.AllocHGlobal(buffUsed);
			bool flag2 = Microsoft.Win32.UnsafeNativeMethods.EvtRender(contextHandle, eventHandle, flag, buffUsed, intPtr, out buffUsed, out propCount);
			int lastWin32Error2 = Marshal.GetLastWin32Error();
			if (!flag2)
			{
				EventLogException.Throw(lastWin32Error2);
			}
			if (propCount != SYSTEM_PROPERTY_COUNT)
			{
				throw new InvalidOperationException("We do not have " + SYSTEM_PROPERTY_COUNT + " variants given for the  UnsafeNativeMethods.EvtRenderFlags.EvtRenderEventValues flag. (System Properties)");
			}
			zero = intPtr;
			for (int i = 0; i < propCount; i++)
			{
				Microsoft.Win32.UnsafeNativeMethods.EvtVariant evtVariant = (Microsoft.Win32.UnsafeNativeMethods.EvtVariant)Marshal.PtrToStructure(zero, typeof(Microsoft.Win32.UnsafeNativeMethods.EvtVariant));
				switch (i)
				{
				case 0:
					systemProperties.ProviderName = (string)ConvertToObject(evtVariant, Microsoft.Win32.UnsafeNativeMethods.EvtVariantType.EvtVarTypeString);
					break;
				case 1:
					systemProperties.ProviderId = (Guid?)ConvertToObject(evtVariant, Microsoft.Win32.UnsafeNativeMethods.EvtVariantType.EvtVarTypeGuid);
					break;
				case 2:
					systemProperties.Id = (ushort?)ConvertToObject(evtVariant, Microsoft.Win32.UnsafeNativeMethods.EvtVariantType.EvtVarTypeUInt16);
					break;
				case 3:
					systemProperties.Qualifiers = (ushort?)ConvertToObject(evtVariant, Microsoft.Win32.UnsafeNativeMethods.EvtVariantType.EvtVarTypeUInt16);
					break;
				case 4:
					systemProperties.Level = (byte?)ConvertToObject(evtVariant, Microsoft.Win32.UnsafeNativeMethods.EvtVariantType.EvtVarTypeByte);
					break;
				case 5:
					systemProperties.Task = (ushort?)ConvertToObject(evtVariant, Microsoft.Win32.UnsafeNativeMethods.EvtVariantType.EvtVarTypeUInt16);
					break;
				case 6:
					systemProperties.Opcode = (byte?)ConvertToObject(evtVariant, Microsoft.Win32.UnsafeNativeMethods.EvtVariantType.EvtVarTypeByte);
					break;
				case 7:
					systemProperties.Keywords = (ulong?)ConvertToObject(evtVariant, Microsoft.Win32.UnsafeNativeMethods.EvtVariantType.EvtVarTypeHexInt64);
					break;
				case 8:
					systemProperties.TimeCreated = (DateTime?)ConvertToObject(evtVariant, Microsoft.Win32.UnsafeNativeMethods.EvtVariantType.EvtVarTypeFileTime);
					break;
				case 9:
					systemProperties.RecordId = (ulong?)ConvertToObject(evtVariant, Microsoft.Win32.UnsafeNativeMethods.EvtVariantType.EvtVarTypeUInt64);
					break;
				case 10:
					systemProperties.ActivityId = (Guid?)ConvertToObject(evtVariant, Microsoft.Win32.UnsafeNativeMethods.EvtVariantType.EvtVarTypeGuid);
					break;
				case 11:
					systemProperties.RelatedActivityId = (Guid?)ConvertToObject(evtVariant, Microsoft.Win32.UnsafeNativeMethods.EvtVariantType.EvtVarTypeGuid);
					break;
				case 12:
					systemProperties.ProcessId = (uint?)ConvertToObject(evtVariant, Microsoft.Win32.UnsafeNativeMethods.EvtVariantType.EvtVarTypeUInt32);
					break;
				case 13:
					systemProperties.ThreadId = (uint?)ConvertToObject(evtVariant, Microsoft.Win32.UnsafeNativeMethods.EvtVariantType.EvtVarTypeUInt32);
					break;
				case 14:
					systemProperties.ChannelName = (string)ConvertToObject(evtVariant, Microsoft.Win32.UnsafeNativeMethods.EvtVariantType.EvtVarTypeString);
					break;
				case 15:
					systemProperties.ComputerName = (string)ConvertToObject(evtVariant, Microsoft.Win32.UnsafeNativeMethods.EvtVariantType.EvtVarTypeString);
					break;
				case 16:
					systemProperties.UserId = (SecurityIdentifier)ConvertToObject(evtVariant, Microsoft.Win32.UnsafeNativeMethods.EvtVariantType.EvtVarTypeSid);
					break;
				case 17:
					systemProperties.Version = (byte?)ConvertToObject(evtVariant, Microsoft.Win32.UnsafeNativeMethods.EvtVariantType.EvtVarTypeByte);
					break;
				}
				zero = new IntPtr((long)zero + Marshal.SizeOf((object)evtVariant));
			}
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intPtr);
			}
		}
	}

	[SecuritySafeCritical]
	public static IList<object> EvtRenderBufferWithContextUserOrValues(EventLogHandle contextHandle, EventLogHandle eventHandle)
	{
		IntPtr intPtr = IntPtr.Zero;
		IntPtr zero = IntPtr.Zero;
		Microsoft.Win32.UnsafeNativeMethods.EvtRenderFlags flags = Microsoft.Win32.UnsafeNativeMethods.EvtRenderFlags.EvtRenderEventValues;
		EventLogPermissionHolder.GetEventLogPermission().Demand();
		try
		{
			if (!Microsoft.Win32.UnsafeNativeMethods.EvtRender(contextHandle, eventHandle, flags, 0, IntPtr.Zero, out var buffUsed, out var propCount))
			{
				int lastWin32Error = Marshal.GetLastWin32Error();
				if (lastWin32Error != 122)
				{
					EventLogException.Throw(lastWin32Error);
				}
			}
			intPtr = Marshal.AllocHGlobal(buffUsed);
			bool flag = Microsoft.Win32.UnsafeNativeMethods.EvtRender(contextHandle, eventHandle, flags, buffUsed, intPtr, out buffUsed, out propCount);
			int lastWin32Error2 = Marshal.GetLastWin32Error();
			if (!flag)
			{
				EventLogException.Throw(lastWin32Error2);
			}
			List<object> list = new List<object>(propCount);
			if (propCount > 0)
			{
				zero = intPtr;
				for (int i = 0; i < propCount; i++)
				{
					Microsoft.Win32.UnsafeNativeMethods.EvtVariant evtVariant = (Microsoft.Win32.UnsafeNativeMethods.EvtVariant)Marshal.PtrToStructure(zero, typeof(Microsoft.Win32.UnsafeNativeMethods.EvtVariant));
					list.Add(ConvertToObject(evtVariant));
					zero = new IntPtr((long)zero + Marshal.SizeOf((object)evtVariant));
				}
			}
			return list;
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intPtr);
			}
		}
	}

	[SecuritySafeCritical]
	public static string EvtFormatMessageRenderName(EventLogHandle pmHandle, EventLogHandle eventHandle, Microsoft.Win32.UnsafeNativeMethods.EvtFormatMessageFlags flag)
	{
		EventLogPermissionHolder.GetEventLogPermission().Demand();
		StringBuilder stringBuilder = new StringBuilder(null);
		bool flag2 = Microsoft.Win32.UnsafeNativeMethods.EvtFormatMessage(pmHandle, eventHandle, 0u, 0, null, flag, 0, stringBuilder, out var bufferUsed);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (!flag2)
		{
			switch (lastWin32Error)
			{
			case 1815:
			case 15027:
			case 15028:
			case 15033:
			case 15100:
				return null;
			default:
				if (lastWin32Error != 122)
				{
					EventLogException.Throw(lastWin32Error);
				}
				break;
			case 15029:
				break;
			}
		}
		stringBuilder.EnsureCapacity(bufferUsed);
		flag2 = Microsoft.Win32.UnsafeNativeMethods.EvtFormatMessage(pmHandle, eventHandle, 0u, 0, null, flag, bufferUsed, stringBuilder, out bufferUsed);
		lastWin32Error = Marshal.GetLastWin32Error();
		if (!flag2)
		{
			switch (lastWin32Error)
			{
			case 1815:
			case 15027:
			case 15028:
			case 15033:
			case 15100:
				return null;
			default:
				EventLogException.Throw(lastWin32Error);
				break;
			case 15029:
				break;
			}
		}
		return stringBuilder.ToString();
	}

	[SecuritySafeCritical]
	public static IEnumerable<string> EvtFormatMessageRenderKeywords(EventLogHandle pmHandle, EventLogHandle eventHandle, Microsoft.Win32.UnsafeNativeMethods.EvtFormatMessageFlags flag)
	{
		EventLogPermissionHolder.GetEventLogPermission().Demand();
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			List<string> list = new List<string>();
			bool flag2 = Microsoft.Win32.UnsafeNativeMethods.EvtFormatMessageBuffer(pmHandle, eventHandle, 0u, 0, IntPtr.Zero, flag, 0, IntPtr.Zero, out var bufferUsed);
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (!flag2)
			{
				switch (lastWin32Error)
				{
				case 1815:
				case 15027:
				case 15028:
				case 15033:
				case 15100:
					return list.AsReadOnly();
				}
				if (lastWin32Error != 122)
				{
					EventLogException.Throw(lastWin32Error);
				}
			}
			intPtr = Marshal.AllocHGlobal(bufferUsed * 2);
			flag2 = Microsoft.Win32.UnsafeNativeMethods.EvtFormatMessageBuffer(pmHandle, eventHandle, 0u, 0, IntPtr.Zero, flag, bufferUsed, intPtr, out bufferUsed);
			lastWin32Error = Marshal.GetLastWin32Error();
			if (!flag2)
			{
				switch (lastWin32Error)
				{
				case 1815:
				case 15027:
				case 15028:
				case 15033:
				case 15100:
					return list;
				}
				EventLogException.Throw(lastWin32Error);
			}
			IntPtr intPtr2 = intPtr;
			while (true)
			{
				string text = Marshal.PtrToStringAuto(intPtr2);
				if (string.IsNullOrEmpty(text))
				{
					break;
				}
				list.Add(text);
				intPtr2 = new IntPtr((long)intPtr2 + text.Length * 2 + 2);
			}
			return list.AsReadOnly();
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intPtr);
			}
		}
	}

	[SecurityCritical]
	public static string EvtRenderBookmark(EventLogHandle eventHandle)
	{
		IntPtr intPtr = IntPtr.Zero;
		Microsoft.Win32.UnsafeNativeMethods.EvtRenderFlags flags = Microsoft.Win32.UnsafeNativeMethods.EvtRenderFlags.EvtRenderBookmark;
		try
		{
			bool flag = Microsoft.Win32.UnsafeNativeMethods.EvtRender(EventLogHandle.Zero, eventHandle, flags, 0, IntPtr.Zero, out var buffUsed, out var propCount);
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (!flag && lastWin32Error != 122)
			{
				EventLogException.Throw(lastWin32Error);
			}
			intPtr = Marshal.AllocHGlobal(buffUsed);
			flag = Microsoft.Win32.UnsafeNativeMethods.EvtRender(EventLogHandle.Zero, eventHandle, flags, buffUsed, intPtr, out buffUsed, out propCount);
			lastWin32Error = Marshal.GetLastWin32Error();
			if (!flag)
			{
				EventLogException.Throw(lastWin32Error);
			}
			return Marshal.PtrToStringAuto(intPtr);
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intPtr);
			}
		}
	}

	[SecuritySafeCritical]
	public static string EvtFormatMessageFormatDescription(EventLogHandle handle, EventLogHandle eventHandle, string[] values)
	{
		if (s_platformNotSupported)
		{
			throw new PlatformNotSupportedException();
		}
		EventLogPermissionHolder.GetEventLogPermission().Demand();
		Microsoft.Win32.UnsafeNativeMethods.EvtStringVariant[] array = new Microsoft.Win32.UnsafeNativeMethods.EvtStringVariant[values.Length];
		for (int i = 0; i < values.Length; i++)
		{
			array[i].Type = 1u;
			array[i].StringVal = values[i];
		}
		StringBuilder stringBuilder = new StringBuilder(null);
		bool flag = Microsoft.Win32.UnsafeNativeMethods.EvtFormatMessage(handle, eventHandle, uint.MaxValue, values.Length, array, Microsoft.Win32.UnsafeNativeMethods.EvtFormatMessageFlags.EvtFormatMessageEvent, 0, stringBuilder, out var bufferUsed);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (!flag)
		{
			switch (lastWin32Error)
			{
			case 1815:
			case 15027:
			case 15028:
			case 15033:
			case 15100:
				return null;
			default:
				if (lastWin32Error != 122)
				{
					EventLogException.Throw(lastWin32Error);
				}
				break;
			case 15029:
				break;
			}
		}
		stringBuilder.EnsureCapacity(bufferUsed);
		flag = Microsoft.Win32.UnsafeNativeMethods.EvtFormatMessage(handle, eventHandle, uint.MaxValue, values.Length, array, Microsoft.Win32.UnsafeNativeMethods.EvtFormatMessageFlags.EvtFormatMessageEvent, bufferUsed, stringBuilder, out bufferUsed);
		lastWin32Error = Marshal.GetLastWin32Error();
		if (!flag)
		{
			switch (lastWin32Error)
			{
			case 1815:
			case 15027:
			case 15028:
			case 15033:
			case 15100:
				return null;
			default:
				EventLogException.Throw(lastWin32Error);
				break;
			case 15029:
				break;
			}
		}
		return stringBuilder.ToString();
	}

	[SecurityCritical]
	private static object ConvertToObject(Microsoft.Win32.UnsafeNativeMethods.EvtVariant val)
	{
		switch (val.Type)
		{
		case 8u:
			return val.UInteger;
		case 7u:
			return val.Integer;
		case 6u:
			return val.UShort;
		case 5u:
			return val.SByte;
		case 4u:
			return val.UInt8;
		case 3u:
			return val.SByte;
		case 10u:
			return val.ULong;
		case 9u:
			return val.Long;
		case 21u:
			return val.ULong;
		case 20u:
			return val.Integer;
		case 11u:
			return val.Single;
		case 12u:
			return val.Double;
		case 0u:
			return null;
		case 1u:
			return ConvertToString(val);
		case 2u:
			return ConvertToAnsiString(val);
		case 19u:
			if (!(val.SidVal == IntPtr.Zero))
			{
				return new SecurityIdentifier(val.SidVal);
			}
			return null;
		case 15u:
			if (!(val.GuidReference == IntPtr.Zero))
			{
				return Marshal.PtrToStructure(val.GuidReference, typeof(Guid));
			}
			return Guid.Empty;
		case 32u:
			return ConvertToSafeHandle(val);
		case 17u:
			return DateTime.FromFileTime((long)val.FileTime);
		case 18u:
		{
			Microsoft.Win32.UnsafeNativeMethods.SystemTime systemTime = (Microsoft.Win32.UnsafeNativeMethods.SystemTime)Marshal.PtrToStructure(val.SystemTime, typeof(Microsoft.Win32.UnsafeNativeMethods.SystemTime));
			return new DateTime(systemTime.Year, systemTime.Month, systemTime.Day, systemTime.Hour, systemTime.Minute, systemTime.Second, systemTime.Milliseconds);
		}
		case 16u:
			return val.SizeT;
		case 13u:
			if (val.Bool != 0)
			{
				return true;
			}
			return false;
		case 14u:
		case 132u:
		{
			if (val.Reference == IntPtr.Zero)
			{
				return new byte[0];
			}
			byte[] array6 = new byte[val.Count];
			Marshal.Copy(val.Reference, array6, 0, (int)val.Count);
			return array6;
		}
		case 133u:
		{
			if (val.Reference == IntPtr.Zero)
			{
				return new short[0];
			}
			short[] array5 = new short[val.Count];
			Marshal.Copy(val.Reference, array5, 0, (int)val.Count);
			return array5;
		}
		case 135u:
		{
			if (val.Reference == IntPtr.Zero)
			{
				return new int[0];
			}
			int[] array4 = new int[val.Count];
			Marshal.Copy(val.Reference, array4, 0, (int)val.Count);
			return array4;
		}
		case 137u:
		{
			if (val.Reference == IntPtr.Zero)
			{
				return new long[0];
			}
			long[] array3 = new long[val.Count];
			Marshal.Copy(val.Reference, array3, 0, (int)val.Count);
			return array3;
		}
		case 139u:
		{
			if (val.Reference == IntPtr.Zero)
			{
				return new float[0];
			}
			float[] array2 = new float[val.Count];
			Marshal.Copy(val.Reference, array2, 0, (int)val.Count);
			return array2;
		}
		case 140u:
		{
			if (val.Reference == IntPtr.Zero)
			{
				return new double[0];
			}
			double[] array = new double[val.Count];
			Marshal.Copy(val.Reference, array, 0, (int)val.Count);
			return array;
		}
		case 131u:
			return ConvertToArray(val, typeof(sbyte), 1);
		case 134u:
			return ConvertToArray(val, typeof(ushort), 2);
		case 138u:
		case 149u:
			return ConvertToArray(val, typeof(ulong), 8);
		case 136u:
		case 148u:
			return ConvertToArray(val, typeof(uint), 4);
		case 129u:
			return ConvertToStringArray(val, ansi: false);
		case 130u:
			return ConvertToStringArray(val, ansi: true);
		case 141u:
			return ConvertToBoolArray(val);
		case 143u:
			return ConvertToArray(val, typeof(Guid), 16);
		case 145u:
			return ConvertToFileTimeArray(val);
		case 146u:
			return ConvertToSysTimeArray(val);
		default:
			throw new EventLogInvalidDataException();
		}
	}

	[SecurityCritical]
	public static object ConvertToObject(Microsoft.Win32.UnsafeNativeMethods.EvtVariant val, Microsoft.Win32.UnsafeNativeMethods.EvtVariantType desiredType)
	{
		if (val.Type == 0)
		{
			return null;
		}
		if ((ulong)val.Type != (ulong)desiredType)
		{
			throw new EventLogInvalidDataException();
		}
		return ConvertToObject(val);
	}

	[SecurityCritical]
	public static string ConvertToString(Microsoft.Win32.UnsafeNativeMethods.EvtVariant val)
	{
		if (val.StringVal == IntPtr.Zero)
		{
			return string.Empty;
		}
		return Marshal.PtrToStringAuto(val.StringVal);
	}

	[SecurityCritical]
	public static string ConvertToAnsiString(Microsoft.Win32.UnsafeNativeMethods.EvtVariant val)
	{
		if (val.AnsiString == IntPtr.Zero)
		{
			return string.Empty;
		}
		return Marshal.PtrToStringAnsi(val.AnsiString);
	}

	[SecurityCritical]
	public static EventLogHandle ConvertToSafeHandle(Microsoft.Win32.UnsafeNativeMethods.EvtVariant val)
	{
		if (val.Handle == IntPtr.Zero)
		{
			return EventLogHandle.Zero;
		}
		return new EventLogHandle(val.Handle, ownsHandle: true);
	}

	[SecurityCritical]
	public static Array ConvertToArray(Microsoft.Win32.UnsafeNativeMethods.EvtVariant val, Type objType, int size)
	{
		IntPtr intPtr = val.Reference;
		if (intPtr == IntPtr.Zero)
		{
			return Array.CreateInstance(objType, 0);
		}
		Array array = Array.CreateInstance(objType, val.Count);
		for (int i = 0; i < val.Count; i++)
		{
			array.SetValue(Marshal.PtrToStructure(intPtr, objType), i);
			intPtr = new IntPtr((long)intPtr + size);
		}
		return array;
	}

	[SecurityCritical]
	public static Array ConvertToBoolArray(Microsoft.Win32.UnsafeNativeMethods.EvtVariant val)
	{
		IntPtr intPtr = val.Reference;
		if (intPtr == IntPtr.Zero)
		{
			return new bool[0];
		}
		bool[] array = new bool[val.Count];
		for (int i = 0; i < val.Count; i++)
		{
			bool flag = ((Marshal.ReadInt32(intPtr) != 0) ? true : false);
			array[i] = flag;
			intPtr = new IntPtr((long)intPtr + 4);
		}
		return array;
	}

	[SecurityCritical]
	public static Array ConvertToFileTimeArray(Microsoft.Win32.UnsafeNativeMethods.EvtVariant val)
	{
		IntPtr intPtr = val.Reference;
		if (intPtr == IntPtr.Zero)
		{
			return new DateTime[0];
		}
		DateTime[] array = new DateTime[val.Count];
		for (int i = 0; i < val.Count; i++)
		{
			array[i] = DateTime.FromFileTime(Marshal.ReadInt64(intPtr));
			intPtr = new IntPtr((long)intPtr + 8);
		}
		return array;
	}

	[SecurityCritical]
	public static Array ConvertToSysTimeArray(Microsoft.Win32.UnsafeNativeMethods.EvtVariant val)
	{
		IntPtr intPtr = val.Reference;
		if (intPtr == IntPtr.Zero)
		{
			return new DateTime[0];
		}
		DateTime[] array = new DateTime[val.Count];
		for (int i = 0; i < val.Count; i++)
		{
			Microsoft.Win32.UnsafeNativeMethods.SystemTime systemTime = (Microsoft.Win32.UnsafeNativeMethods.SystemTime)Marshal.PtrToStructure(intPtr, typeof(Microsoft.Win32.UnsafeNativeMethods.SystemTime));
			array[i] = new DateTime(systemTime.Year, systemTime.Month, systemTime.Day, systemTime.Hour, systemTime.Minute, systemTime.Second, systemTime.Milliseconds);
			intPtr = new IntPtr((long)intPtr + 16);
		}
		return array;
	}

	[SecurityCritical]
	public static string[] ConvertToStringArray(Microsoft.Win32.UnsafeNativeMethods.EvtVariant val, bool ansi)
	{
		if (val.Reference == IntPtr.Zero)
		{
			return new string[0];
		}
		IntPtr reference = val.Reference;
		IntPtr[] array = new IntPtr[val.Count];
		Marshal.Copy(reference, array, 0, (int)val.Count);
		string[] array2 = new string[val.Count];
		for (int i = 0; i < val.Count; i++)
		{
			array2[i] = (ansi ? Marshal.PtrToStringAnsi(array[i]) : Marshal.PtrToStringAuto(array[i]));
		}
		return array2;
	}
}
