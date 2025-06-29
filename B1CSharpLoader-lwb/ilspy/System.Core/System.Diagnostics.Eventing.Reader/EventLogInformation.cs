using System.Security;
using System.Security.Permissions;
using Microsoft.Win32;

namespace System.Diagnostics.Eventing.Reader;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public sealed class EventLogInformation
{
	private DateTime? creationTime;

	private DateTime? lastAccessTime;

	private DateTime? lastWriteTime;

	private long? fileSize;

	private int? fileAttributes;

	private long? recordCount;

	private long? oldestRecordNumber;

	private bool? isLogFull;

	public DateTime? CreationTime => creationTime;

	public DateTime? LastAccessTime => lastAccessTime;

	public DateTime? LastWriteTime => lastWriteTime;

	public long? FileSize => fileSize;

	public int? Attributes => fileAttributes;

	public long? RecordCount => recordCount;

	public long? OldestRecordNumber => oldestRecordNumber;

	public bool? IsLogFull => isLogFull;

	[SecuritySafeCritical]
	internal EventLogInformation(EventLogSession session, string channelName, PathType pathType)
	{
		EventLogPermissionHolder.GetEventLogPermission().Demand();
		EventLogHandle eventLogHandle = NativeWrapper.EvtOpenLog(session.Handle, channelName, pathType);
		using (eventLogHandle)
		{
			creationTime = (DateTime?)NativeWrapper.EvtGetLogInfo(eventLogHandle, Microsoft.Win32.UnsafeNativeMethods.EvtLogPropertyId.EvtLogCreationTime);
			lastAccessTime = (DateTime?)NativeWrapper.EvtGetLogInfo(eventLogHandle, Microsoft.Win32.UnsafeNativeMethods.EvtLogPropertyId.EvtLogLastAccessTime);
			lastWriteTime = (DateTime?)NativeWrapper.EvtGetLogInfo(eventLogHandle, Microsoft.Win32.UnsafeNativeMethods.EvtLogPropertyId.EvtLogLastWriteTime);
			fileSize = (long?)(ulong?)NativeWrapper.EvtGetLogInfo(eventLogHandle, Microsoft.Win32.UnsafeNativeMethods.EvtLogPropertyId.EvtLogFileSize);
			fileAttributes = (int?)(uint?)NativeWrapper.EvtGetLogInfo(eventLogHandle, Microsoft.Win32.UnsafeNativeMethods.EvtLogPropertyId.EvtLogAttributes);
			recordCount = (long?)(ulong?)NativeWrapper.EvtGetLogInfo(eventLogHandle, Microsoft.Win32.UnsafeNativeMethods.EvtLogPropertyId.EvtLogNumberOfLogRecords);
			oldestRecordNumber = (long?)(ulong?)NativeWrapper.EvtGetLogInfo(eventLogHandle, Microsoft.Win32.UnsafeNativeMethods.EvtLogPropertyId.EvtLogOldestRecordNumber);
			isLogFull = (bool?)NativeWrapper.EvtGetLogInfo(eventLogHandle, Microsoft.Win32.UnsafeNativeMethods.EvtLogPropertyId.EvtLogFull);
		}
	}
}
