using System;
using System.Diagnostics.Eventing;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading;
using Microsoft.Win32.SafeHandles;

namespace Microsoft.Win32;

[SuppressUnmanagedCodeSecurity]
internal static class UnsafeNativeMethods
{
	[StructLayout(LayoutKind.Sequential)]
	internal class SECURITY_ATTRIBUTES
	{
		internal int nLength;

		[SecurityCritical]
		internal unsafe byte* pSecurityDescriptor;

		internal int bInheritHandle;
	}

	[SecurityCritical(SecurityCriticalScope.Everything)]
	internal unsafe delegate void EtwEnableCallback([In] ref Guid sourceId, [In] int isEnabled, [In] byte level, [In] long matchAnyKeywords, [In] long matchAllKeywords, [In] void* filterData, [In] void* callbackContext);

	[StructLayout(LayoutKind.Explicit, Size = 40)]
	internal struct PerfCounterSetInfoStruct
	{
		[FieldOffset(0)]
		internal Guid CounterSetGuid;

		[FieldOffset(16)]
		internal Guid ProviderGuid;

		[FieldOffset(32)]
		internal uint NumCounters;

		[FieldOffset(36)]
		internal uint InstanceType;
	}

	[StructLayout(LayoutKind.Explicit, Size = 32)]
	internal struct PerfCounterInfoStruct
	{
		[FieldOffset(0)]
		internal uint CounterId;

		[FieldOffset(4)]
		internal uint CounterType;

		[FieldOffset(8)]
		internal long Attrib;

		[FieldOffset(16)]
		internal uint Size;

		[FieldOffset(20)]
		internal uint DetailLevel;

		[FieldOffset(24)]
		internal uint Scale;

		[FieldOffset(28)]
		internal uint Offset;
	}

	[StructLayout(LayoutKind.Explicit, Size = 32)]
	internal struct PerfCounterSetInstanceStruct
	{
		[FieldOffset(0)]
		internal Guid CounterSetGuid;

		[FieldOffset(16)]
		internal uint dwSize;

		[FieldOffset(20)]
		internal uint InstanceId;

		[FieldOffset(24)]
		internal uint InstanceNameOffset;

		[FieldOffset(28)]
		internal uint InstanceNameSize;
	}

	[SecurityCritical(SecurityCriticalScope.Everything)]
	internal unsafe delegate uint PERFLIBREQUEST([In] uint RequestCode, [In] void* Buffer, [In] uint BufferSize);

	[Flags]
	internal enum EvtQueryFlags
	{
		EvtQueryChannelPath = 1,
		EvtQueryFilePath = 2,
		EvtQueryForwardDirection = 0x100,
		EvtQueryReverseDirection = 0x200,
		EvtQueryTolerateQueryErrors = 0x1000
	}

	[Flags]
	internal enum EvtSubscribeFlags
	{
		EvtSubscribeToFutureEvents = 1,
		EvtSubscribeStartAtOldestRecord = 2,
		EvtSubscribeStartAfterBookmark = 3,
		EvtSubscribeTolerateQueryErrors = 0x1000,
		EvtSubscribeStrict = 0x10000
	}

	internal enum EvtVariantType
	{
		EvtVarTypeNull = 0,
		EvtVarTypeString = 1,
		EvtVarTypeAnsiString = 2,
		EvtVarTypeSByte = 3,
		EvtVarTypeByte = 4,
		EvtVarTypeInt16 = 5,
		EvtVarTypeUInt16 = 6,
		EvtVarTypeInt32 = 7,
		EvtVarTypeUInt32 = 8,
		EvtVarTypeInt64 = 9,
		EvtVarTypeUInt64 = 10,
		EvtVarTypeSingle = 11,
		EvtVarTypeDouble = 12,
		EvtVarTypeBoolean = 13,
		EvtVarTypeBinary = 14,
		EvtVarTypeGuid = 15,
		EvtVarTypeSizeT = 16,
		EvtVarTypeFileTime = 17,
		EvtVarTypeSysTime = 18,
		EvtVarTypeSid = 19,
		EvtVarTypeHexInt32 = 20,
		EvtVarTypeHexInt64 = 21,
		EvtVarTypeEvtHandle = 32,
		EvtVarTypeEvtXml = 35,
		EvtVarTypeStringArray = 129,
		EvtVarTypeUInt32Array = 136
	}

	internal enum EvtMasks
	{
		EVT_VARIANT_TYPE_MASK = 127,
		EVT_VARIANT_TYPE_ARRAY
	}

	internal struct SystemTime
	{
		[MarshalAs(UnmanagedType.U2)]
		public short Year;

		[MarshalAs(UnmanagedType.U2)]
		public short Month;

		[MarshalAs(UnmanagedType.U2)]
		public short DayOfWeek;

		[MarshalAs(UnmanagedType.U2)]
		public short Day;

		[MarshalAs(UnmanagedType.U2)]
		public short Hour;

		[MarshalAs(UnmanagedType.U2)]
		public short Minute;

		[MarshalAs(UnmanagedType.U2)]
		public short Second;

		[MarshalAs(UnmanagedType.U2)]
		public short Milliseconds;
	}

	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Auto)]
	[SecurityCritical(SecurityCriticalScope.Everything)]
	internal struct EvtVariant
	{
		[FieldOffset(0)]
		public uint UInteger;

		[FieldOffset(0)]
		public int Integer;

		[FieldOffset(0)]
		public byte UInt8;

		[FieldOffset(0)]
		public short Short;

		[FieldOffset(0)]
		public ushort UShort;

		[FieldOffset(0)]
		public uint Bool;

		[FieldOffset(0)]
		public byte ByteVal;

		[FieldOffset(0)]
		public byte SByte;

		[FieldOffset(0)]
		public ulong ULong;

		[FieldOffset(0)]
		public long Long;

		[FieldOffset(0)]
		public float Single;

		[FieldOffset(0)]
		public double Double;

		[FieldOffset(0)]
		public IntPtr StringVal;

		[FieldOffset(0)]
		public IntPtr AnsiString;

		[FieldOffset(0)]
		public IntPtr SidVal;

		[FieldOffset(0)]
		public IntPtr Binary;

		[FieldOffset(0)]
		public IntPtr Reference;

		[FieldOffset(0)]
		public IntPtr Handle;

		[FieldOffset(0)]
		public IntPtr GuidReference;

		[FieldOffset(0)]
		public ulong FileTime;

		[FieldOffset(0)]
		public IntPtr SystemTime;

		[FieldOffset(0)]
		public IntPtr SizeT;

		[FieldOffset(8)]
		public uint Count;

		[FieldOffset(12)]
		public uint Type;
	}

	internal enum EvtEventPropertyId
	{
		EvtEventQueryIDs,
		EvtEventPath
	}

	internal enum EvtQueryPropertyId
	{
		EvtQueryNames,
		EvtQueryStatuses
	}

	internal enum EvtPublisherMetadataPropertyId
	{
		EvtPublisherMetadataPublisherGuid,
		EvtPublisherMetadataResourceFilePath,
		EvtPublisherMetadataParameterFilePath,
		EvtPublisherMetadataMessageFilePath,
		EvtPublisherMetadataHelpLink,
		EvtPublisherMetadataPublisherMessageID,
		EvtPublisherMetadataChannelReferences,
		EvtPublisherMetadataChannelReferencePath,
		EvtPublisherMetadataChannelReferenceIndex,
		EvtPublisherMetadataChannelReferenceID,
		EvtPublisherMetadataChannelReferenceFlags,
		EvtPublisherMetadataChannelReferenceMessageID,
		EvtPublisherMetadataLevels,
		EvtPublisherMetadataLevelName,
		EvtPublisherMetadataLevelValue,
		EvtPublisherMetadataLevelMessageID,
		EvtPublisherMetadataTasks,
		EvtPublisherMetadataTaskName,
		EvtPublisherMetadataTaskEventGuid,
		EvtPublisherMetadataTaskValue,
		EvtPublisherMetadataTaskMessageID,
		EvtPublisherMetadataOpcodes,
		EvtPublisherMetadataOpcodeName,
		EvtPublisherMetadataOpcodeValue,
		EvtPublisherMetadataOpcodeMessageID,
		EvtPublisherMetadataKeywords,
		EvtPublisherMetadataKeywordName,
		EvtPublisherMetadataKeywordValue,
		EvtPublisherMetadataKeywordMessageID
	}

	internal enum EvtChannelReferenceFlags
	{
		EvtChannelReferenceImported = 1
	}

	internal enum EvtEventMetadataPropertyId
	{
		EventMetadataEventID,
		EventMetadataEventVersion,
		EventMetadataEventChannel,
		EventMetadataEventLevel,
		EventMetadataEventOpcode,
		EventMetadataEventTask,
		EventMetadataEventKeyword,
		EventMetadataEventMessageID,
		EventMetadataEventTemplate
	}

	internal enum EvtChannelConfigPropertyId
	{
		EvtChannelConfigEnabled,
		EvtChannelConfigIsolation,
		EvtChannelConfigType,
		EvtChannelConfigOwningPublisher,
		EvtChannelConfigClassicEventlog,
		EvtChannelConfigAccess,
		EvtChannelLoggingConfigRetention,
		EvtChannelLoggingConfigAutoBackup,
		EvtChannelLoggingConfigMaxSize,
		EvtChannelLoggingConfigLogFilePath,
		EvtChannelPublishingConfigLevel,
		EvtChannelPublishingConfigKeywords,
		EvtChannelPublishingConfigControlGuid,
		EvtChannelPublishingConfigBufferSize,
		EvtChannelPublishingConfigMinBuffers,
		EvtChannelPublishingConfigMaxBuffers,
		EvtChannelPublishingConfigLatency,
		EvtChannelPublishingConfigClockType,
		EvtChannelPublishingConfigSidType,
		EvtChannelPublisherList,
		EvtChannelConfigPropertyIdEND
	}

	internal enum EvtLogPropertyId
	{
		EvtLogCreationTime,
		EvtLogLastAccessTime,
		EvtLogLastWriteTime,
		EvtLogFileSize,
		EvtLogAttributes,
		EvtLogNumberOfLogRecords,
		EvtLogOldestRecordNumber,
		EvtLogFull
	}

	internal enum EvtExportLogFlags
	{
		EvtExportLogChannelPath = 1,
		EvtExportLogFilePath = 2,
		EvtExportLogTolerateQueryErrors = 0x1000
	}

	internal enum EvtRenderContextFlags
	{
		EvtRenderContextValues,
		EvtRenderContextSystem,
		EvtRenderContextUser
	}

	internal enum EvtRenderFlags
	{
		EvtRenderEventValues,
		EvtRenderEventXml,
		EvtRenderBookmark
	}

	internal enum EvtFormatMessageFlags
	{
		EvtFormatMessageEvent = 1,
		EvtFormatMessageLevel,
		EvtFormatMessageTask,
		EvtFormatMessageOpcode,
		EvtFormatMessageKeyword,
		EvtFormatMessageChannel,
		EvtFormatMessageProvider,
		EvtFormatMessageId,
		EvtFormatMessageXml
	}

	internal enum EvtSystemPropertyId
	{
		EvtSystemProviderName,
		EvtSystemProviderGuid,
		EvtSystemEventID,
		EvtSystemQualifiers,
		EvtSystemLevel,
		EvtSystemTask,
		EvtSystemOpcode,
		EvtSystemKeywords,
		EvtSystemTimeCreated,
		EvtSystemEventRecordId,
		EvtSystemActivityID,
		EvtSystemRelatedActivityID,
		EvtSystemProcessID,
		EvtSystemThreadID,
		EvtSystemChannel,
		EvtSystemComputer,
		EvtSystemUserID,
		EvtSystemVersion,
		EvtSystemPropertyIdEND
	}

	internal enum EvtLoginClass
	{
		EvtRpcLogin = 1
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
	internal struct EvtRpcLogin
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public string Server;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string User;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string Domain;

		[SecurityCritical]
		public CoTaskMemUnicodeSafeHandle Password;

		public int Flags;
	}

	[Flags]
	internal enum EvtSeekFlags
	{
		EvtSeekRelativeToFirst = 1,
		EvtSeekRelativeToLast = 2,
		EvtSeekRelativeToCurrent = 3,
		EvtSeekRelativeToBookmark = 4,
		EvtSeekOriginMask = 7,
		EvtSeekStrict = 0x10000
	}

	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Auto)]
	internal struct EvtStringVariant
	{
		[FieldOffset(0)]
		[MarshalAs(UnmanagedType.LPWStr)]
		public string StringVal;

		[FieldOffset(8)]
		public uint Count;

		[FieldOffset(12)]
		public uint Type;
	}

	[SecurityCritical(SecurityCriticalScope.Everything)]
	internal struct MEMORY_BASIC_INFORMATION
	{
		internal unsafe void* BaseAddress;

		internal unsafe void* AllocationBase;

		internal uint AllocationProtect;

		internal UIntPtr RegionSize;

		internal uint State;

		internal uint Protect;

		internal uint Type;
	}

	internal struct SYSTEM_INFO
	{
		internal int dwOemId;

		internal int dwPageSize;

		internal IntPtr lpMinimumApplicationAddress;

		internal IntPtr lpMaximumApplicationAddress;

		internal IntPtr dwActiveProcessorMask;

		internal int dwNumberOfProcessors;

		internal int dwProcessorType;

		internal int dwAllocationGranularity;

		internal short wProcessorLevel;

		internal short wProcessorRevision;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
	internal struct MEMORYSTATUSEX
	{
		internal uint dwLength;

		internal uint dwMemoryLoad;

		internal ulong ullTotalPhys;

		internal ulong ullAvailPhys;

		internal ulong ullTotalPageFile;

		internal ulong ullAvailPageFile;

		internal ulong ullTotalVirtual;

		internal ulong ullAvailVirtual;

		internal ulong ullAvailExtendedVirtual;
	}

	internal const string KERNEL32 = "kernel32.dll";

	internal const string ADVAPI32 = "advapi32.dll";

	internal const string WEVTAPI = "wevtapi.dll";

	internal static readonly IntPtr NULL = IntPtr.Zero;

	internal const int CREDUI_MAX_USERNAME_LENGTH = 513;

	internal const int ERROR_SUCCESS = 0;

	internal const int ERROR_FILE_NOT_FOUND = 2;

	internal const int ERROR_PATH_NOT_FOUND = 3;

	internal const int ERROR_ACCESS_DENIED = 5;

	internal const int ERROR_INVALID_HANDLE = 6;

	internal const int ERROR_NOT_ENOUGH_MEMORY = 8;

	internal const int ERROR_INVALID_DRIVE = 15;

	internal const int ERROR_NO_MORE_FILES = 18;

	internal const int ERROR_NOT_READY = 21;

	internal const int ERROR_BAD_LENGTH = 24;

	internal const int ERROR_SHARING_VIOLATION = 32;

	internal const int ERROR_LOCK_VIOLATION = 33;

	internal const int ERROR_HANDLE_EOF = 38;

	internal const int ERROR_FILE_EXISTS = 80;

	internal const int ERROR_INVALID_PARAMETER = 87;

	internal const int ERROR_BROKEN_PIPE = 109;

	internal const int ERROR_INSUFFICIENT_BUFFER = 122;

	internal const int ERROR_INVALID_NAME = 123;

	internal const int ERROR_BAD_PATHNAME = 161;

	internal const int ERROR_ALREADY_EXISTS = 183;

	internal const int ERROR_ENVVAR_NOT_FOUND = 203;

	internal const int ERROR_FILENAME_EXCED_RANGE = 206;

	internal const int ERROR_PIPE_BUSY = 231;

	internal const int ERROR_NO_DATA = 232;

	internal const int ERROR_PIPE_NOT_CONNECTED = 233;

	internal const int ERROR_MORE_DATA = 234;

	internal const int ERROR_NO_MORE_ITEMS = 259;

	internal const int ERROR_PIPE_CONNECTED = 535;

	internal const int ERROR_PIPE_LISTENING = 536;

	internal const int ERROR_OPERATION_ABORTED = 995;

	internal const int ERROR_IO_PENDING = 997;

	internal const int ERROR_NOT_FOUND = 1168;

	internal const int ERROR_ARITHMETIC_OVERFLOW = 534;

	internal const int ERROR_RESOURCE_LANG_NOT_FOUND = 1815;

	internal const int ERROR_EVT_MESSAGE_NOT_FOUND = 15027;

	internal const int ERROR_EVT_MESSAGE_ID_NOT_FOUND = 15028;

	internal const int ERROR_EVT_UNRESOLVED_VALUE_INSERT = 15029;

	internal const int ERROR_EVT_UNRESOLVED_PARAMETER_INSERT = 15030;

	internal const int ERROR_EVT_MAX_INSERTS_REACHED = 15031;

	internal const int ERROR_EVT_MESSAGE_LOCALE_NOT_FOUND = 15033;

	internal const int ERROR_MUI_FILE_NOT_FOUND = 15100;

	internal const int SECURITY_SQOS_PRESENT = 1048576;

	internal const int SECURITY_ANONYMOUS = 0;

	internal const int SECURITY_IDENTIFICATION = 65536;

	internal const int SECURITY_IMPERSONATION = 131072;

	internal const int SECURITY_DELEGATION = 196608;

	internal const int GENERIC_READ = int.MinValue;

	internal const int GENERIC_WRITE = 1073741824;

	internal const int STD_INPUT_HANDLE = -10;

	internal const int STD_OUTPUT_HANDLE = -11;

	internal const int STD_ERROR_HANDLE = -12;

	internal const int DUPLICATE_SAME_ACCESS = 2;

	internal const int PIPE_ACCESS_INBOUND = 1;

	internal const int PIPE_ACCESS_OUTBOUND = 2;

	internal const int PIPE_ACCESS_DUPLEX = 3;

	internal const int PIPE_TYPE_BYTE = 0;

	internal const int PIPE_TYPE_MESSAGE = 4;

	internal const int PIPE_READMODE_BYTE = 0;

	internal const int PIPE_READMODE_MESSAGE = 2;

	internal const int PIPE_UNLIMITED_INSTANCES = 255;

	internal const int FILE_FLAG_FIRST_PIPE_INSTANCE = 524288;

	internal const int FILE_SHARE_READ = 1;

	internal const int FILE_SHARE_WRITE = 2;

	internal const int FILE_ATTRIBUTE_NORMAL = 128;

	internal const int FILE_FLAG_OVERLAPPED = 1073741824;

	internal const int OPEN_EXISTING = 3;

	internal const int FILE_TYPE_DISK = 1;

	internal const int FILE_TYPE_CHAR = 2;

	internal const int FILE_TYPE_PIPE = 3;

	internal const int MEM_COMMIT = 4096;

	internal const int MEM_RESERVE = 8192;

	internal const int INVALID_FILE_SIZE = -1;

	internal const int PAGE_READWRITE = 4;

	internal const int PAGE_READONLY = 2;

	internal const int PAGE_WRITECOPY = 8;

	internal const int PAGE_EXECUTE_READ = 32;

	internal const int PAGE_EXECUTE_READWRITE = 64;

	internal const int FILE_MAP_COPY = 1;

	internal const int FILE_MAP_WRITE = 2;

	internal const int FILE_MAP_READ = 4;

	internal const int FILE_MAP_EXECUTE = 32;

	internal const int SEM_FAILCRITICALERRORS = 1;

	private const int FORMAT_MESSAGE_IGNORE_INSERTS = 512;

	private const int FORMAT_MESSAGE_FROM_SYSTEM = 4096;

	private const int FORMAT_MESSAGE_ARGUMENT_ARRAY = 8192;

	[DllImport("kernel32.dll")]
	[SecurityCritical]
	internal static extern int GetFileType(SafeFileHandle handle);

	[DllImport("kernel32.dll", SetLastError = true)]
	[SecurityCritical]
	internal unsafe static extern int WriteFile(SafeFileHandle handle, byte* bytes, int numBytesToWrite, out int numBytesWritten, NativeOverlapped* lpOverlapped);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[SecurityCritical]
	private static extern SafeFileHandle CreateFile(string lpFileName, int dwDesiredAccess, FileShare dwShareMode, SECURITY_ATTRIBUTES securityAttrs, FileMode dwCreationDisposition, int dwFlagsAndAttributes, IntPtr hTemplateFile);

	[SecurityCritical]
	internal static SafeFileHandle SafeCreateFile(string lpFileName, int dwDesiredAccess, FileShare dwShareMode, SECURITY_ATTRIBUTES securityAttrs, FileMode dwCreationDisposition, int dwFlagsAndAttributes, IntPtr hTemplateFile)
	{
		SafeFileHandle safeFileHandle = CreateFile(lpFileName, dwDesiredAccess, dwShareMode, securityAttrs, dwCreationDisposition, dwFlagsAndAttributes, hTemplateFile);
		if (!safeFileHandle.IsInvalid)
		{
			int fileType = GetFileType(safeFileHandle);
			if (fileType != 1)
			{
				safeFileHandle.Dispose();
				throw new NotSupportedException(System.SR.GetString("NotSupported_IONonFileDevices"));
			}
		}
		return safeFileHandle;
	}

	[DllImport("kernel32.dll")]
	[SecurityCritical]
	internal static extern int SetErrorMode(int newMode);

	[DllImport("kernel32.dll", EntryPoint = "SetFilePointer", SetLastError = true)]
	[SecurityCritical]
	private unsafe static extern int SetFilePointerWin32(SafeFileHandle handle, int lo, int* hi, int origin);

	[SecurityCritical]
	internal unsafe static long SetFilePointer(SafeFileHandle handle, long offset, SeekOrigin origin, out int hr)
	{
		hr = 0;
		int lo = (int)offset;
		int num = (int)(offset >> 32);
		lo = SetFilePointerWin32(handle, lo, &num, (int)origin);
		if (lo == -1 && (hr = Marshal.GetLastWin32Error()) != 0)
		{
			return -1L;
		}
		return (long)(((ulong)(uint)num << 32) | (uint)lo);
	}

	internal static int MakeHRFromErrorCode(int errorCode)
	{
		return -2147024896 | errorCode;
	}

	[DllImport("kernel32.dll", BestFitMapping = false, CharSet = CharSet.Auto)]
	[SecurityCritical]
	internal static extern int FormatMessage(int dwFlags, IntPtr lpSource, int dwMessageId, int dwLanguageId, StringBuilder lpBuffer, int nSize, IntPtr va_list_arguments);

	[SecurityCritical]
	internal static string GetMessage(int errorCode)
	{
		StringBuilder stringBuilder = new StringBuilder(512);
		if (FormatMessage(12800, NULL, errorCode, 0, stringBuilder, stringBuilder.Capacity, NULL) != 0)
		{
			return stringBuilder.ToString();
		}
		return "UnknownError_Num " + errorCode;
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SecurityCritical]
	internal static extern SafeLibraryHandle LoadLibraryEx(string libFilename, IntPtr reserved, int flags);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool FreeLibrary(IntPtr hModule);

	[DllImport("kernel32.dll", SetLastError = true)]
	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool CloseHandle(IntPtr handle);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[SecurityCritical]
	internal static extern IntPtr GetCurrentProcess();

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool DuplicateHandle(IntPtr hSourceProcessHandle, SafePipeHandle hSourceHandle, IntPtr hTargetProcessHandle, out SafePipeHandle lpTargetHandle, uint dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, uint dwOptions);

	[DllImport("kernel32.dll")]
	[SecurityCritical]
	internal static extern int GetFileType(SafePipeHandle handle);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool CreatePipe(out SafePipeHandle hReadPipe, out SafePipeHandle hWritePipe, SECURITY_ATTRIBUTES lpPipeAttributes, int nSize);

	[DllImport("kernel32.dll", BestFitMapping = false, CharSet = CharSet.Auto, EntryPoint = "CreateFile", SetLastError = true)]
	[SecurityCritical]
	internal static extern SafePipeHandle CreateNamedPipeClient(string lpFileName, int dwDesiredAccess, FileShare dwShareMode, SECURITY_ATTRIBUTES securityAttrs, FileMode dwCreationDisposition, int dwFlagsAndAttributes, IntPtr hTemplateFile);

	[DllImport("kernel32.dll", SetLastError = true)]
	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal unsafe static extern bool ConnectNamedPipe(SafePipeHandle handle, NativeOverlapped* overlapped);

	[DllImport("kernel32.dll", SetLastError = true)]
	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool ConnectNamedPipe(SafePipeHandle handle, IntPtr overlapped);

	[DllImport("kernel32.dll", BestFitMapping = false, CharSet = CharSet.Auto, SetLastError = true)]
	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool WaitNamedPipe(string name, int timeout);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool GetNamedPipeHandleState(SafePipeHandle hNamedPipe, out int lpState, IntPtr lpCurInstances, IntPtr lpMaxCollectionCount, IntPtr lpCollectDataTimeout, IntPtr lpUserName, int nMaxUserNameSize);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool GetNamedPipeHandleState(SafePipeHandle hNamedPipe, IntPtr lpState, out int lpCurInstances, IntPtr lpMaxCollectionCount, IntPtr lpCollectDataTimeout, IntPtr lpUserName, int nMaxUserNameSize);

	[DllImport("kernel32.dll", BestFitMapping = false, CharSet = CharSet.Auto, SetLastError = true)]
	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool GetNamedPipeHandleState(SafePipeHandle hNamedPipe, IntPtr lpState, IntPtr lpCurInstances, IntPtr lpMaxCollectionCount, IntPtr lpCollectDataTimeout, StringBuilder lpUserName, int nMaxUserNameSize);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool GetNamedPipeInfo(SafePipeHandle hNamedPipe, out int lpFlags, IntPtr lpOutBufferSize, IntPtr lpInBufferSize, IntPtr lpMaxInstances);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool GetNamedPipeInfo(SafePipeHandle hNamedPipe, IntPtr lpFlags, out int lpOutBufferSize, IntPtr lpInBufferSize, IntPtr lpMaxInstances);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool GetNamedPipeInfo(SafePipeHandle hNamedPipe, IntPtr lpFlags, IntPtr lpOutBufferSize, out int lpInBufferSize, IntPtr lpMaxInstances);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal unsafe static extern bool SetNamedPipeHandleState(SafePipeHandle hNamedPipe, int* lpMode, IntPtr lpMaxCollectionCount, IntPtr lpCollectDataTimeout);

	[DllImport("kernel32.dll", SetLastError = true)]
	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool DisconnectNamedPipe(SafePipeHandle hNamedPipe);

	[DllImport("kernel32.dll", SetLastError = true)]
	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool FlushFileBuffers(SafePipeHandle hNamedPipe);

	[DllImport("advapi32.dll", SetLastError = true)]
	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool RevertToSelf();

	[DllImport("advapi32.dll", SetLastError = true)]
	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool ImpersonateNamedPipeClient(SafePipeHandle hNamedPipe);

	[DllImport("kernel32.dll", BestFitMapping = false, CharSet = CharSet.Auto, SetLastError = true)]
	[SecurityCritical]
	internal static extern SafePipeHandle CreateNamedPipe(string pipeName, int openMode, int pipeMode, int maxInstances, int outBufferSize, int inBufferSize, int defaultTimeout, SECURITY_ATTRIBUTES securityAttributes);

	[DllImport("kernel32.dll", SetLastError = true)]
	[SecurityCritical]
	internal unsafe static extern int ReadFile(SafePipeHandle handle, byte* bytes, int numBytesToRead, IntPtr numBytesRead_mustBeZero, NativeOverlapped* overlapped);

	[DllImport("kernel32.dll", SetLastError = true)]
	[SecurityCritical]
	internal unsafe static extern int ReadFile(SafePipeHandle handle, byte* bytes, int numBytesToRead, out int numBytesRead, IntPtr mustBeZero);

	[DllImport("kernel32.dll", SetLastError = true)]
	[SecurityCritical]
	internal unsafe static extern int WriteFile(SafePipeHandle handle, byte* bytes, int numBytesToWrite, IntPtr numBytesWritten_mustBeZero, NativeOverlapped* lpOverlapped);

	[DllImport("kernel32.dll", SetLastError = true)]
	[SecurityCritical]
	internal unsafe static extern int WriteFile(SafePipeHandle handle, byte* bytes, int numBytesToWrite, out int numBytesWritten, IntPtr mustBeZero);

	[DllImport("kernel32.dll", SetLastError = true)]
	[SecurityCritical]
	internal static extern bool SetEndOfFile(IntPtr hNamedPipe);

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
	[SecurityCritical]
	internal unsafe static extern uint EventRegister([In] ref Guid providerId, [In] EtwEnableCallback enableCallback, [In] void* callbackContext, [In][Out] ref long registrationHandle);

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
	[SecurityCritical]
	internal static extern int EventUnregister([In] long registrationHandle);

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
	[SecurityCritical]
	internal static extern int EventEnabled([In] long registrationHandle, [In] ref EventDescriptor eventDescriptor);

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
	[SecurityCritical]
	internal static extern int EventProviderEnabled([In] long registrationHandle, [In] byte level, [In] long keywords);

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
	[SecurityCritical]
	internal unsafe static extern uint EventWrite([In] long registrationHandle, [In] ref EventDescriptor eventDescriptor, [In] uint userDataCount, [In] void* userData);

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
	[SecurityCritical]
	internal unsafe static extern uint EventWrite([In] long registrationHandle, [In] EventDescriptor* eventDescriptor, [In] uint userDataCount, [In] void* userData);

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
	[SecurityCritical]
	internal unsafe static extern uint EventWriteTransfer([In] long registrationHandle, [In] ref EventDescriptor eventDescriptor, [In] Guid* activityId, [In] Guid* relatedActivityId, [In] uint userDataCount, [In] void* userData);

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
	[SecurityCritical]
	internal unsafe static extern uint EventWriteString([In] long registrationHandle, [In] byte level, [In] long keywords, [In] char* message);

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
	[SecurityCritical]
	internal static extern uint EventActivityIdControl([In] int ControlCode, [In][Out] ref Guid ActivityId);

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
	[SecurityCritical]
	internal static extern uint PerfStartProvider([In] ref Guid ProviderGuid, [In] PERFLIBREQUEST ControlCallback, out SafePerfProviderHandle phProvider);

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
	[SecurityCritical]
	internal static extern uint PerfStopProvider([In] IntPtr hProvider);

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
	[SecurityCritical]
	internal unsafe static extern uint PerfSetCounterSetInfo([In] SafePerfProviderHandle hProvider, [In][Out] PerfCounterSetInfoStruct* pTemplate, [In] uint dwTemplateSize);

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	[SecurityCritical]
	internal unsafe static extern PerfCounterSetInstanceStruct* PerfCreateInstance([In] SafePerfProviderHandle hProvider, [In] ref Guid CounterSetGuid, [In] string szInstanceName, [In] uint dwInstance);

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
	[SecurityCritical]
	internal unsafe static extern uint PerfDeleteInstance([In] SafePerfProviderHandle hProvider, [In] PerfCounterSetInstanceStruct* InstanceBlock);

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
	[SecurityCritical]
	internal unsafe static extern uint PerfSetCounterRefValue([In] SafePerfProviderHandle hProvider, [In] PerfCounterSetInstanceStruct* pInstance, [In] uint CounterId, [In] void* lpAddr);

	[DllImport("wevtapi.dll", SetLastError = true)]
	[SecurityCritical]
	internal static extern EventLogHandle EvtQuery(EventLogHandle session, [MarshalAs(UnmanagedType.LPWStr)] string path, [MarshalAs(UnmanagedType.LPWStr)] string query, int flags);

	[DllImport("wevtapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool EvtSeek(EventLogHandle resultSet, long position, EventLogHandle bookmark, int timeout, [MarshalAs(UnmanagedType.I4)] EvtSeekFlags flags);

	[DllImport("wevtapi.dll", SetLastError = true)]
	[SecurityCritical]
	internal static extern EventLogHandle EvtSubscribe(EventLogHandle session, SafeWaitHandle signalEvent, [MarshalAs(UnmanagedType.LPWStr)] string path, [MarshalAs(UnmanagedType.LPWStr)] string query, EventLogHandle bookmark, IntPtr context, IntPtr callback, int flags);

	[DllImport("wevtapi.dll", SetLastError = true)]
	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool EvtNext(EventLogHandle queryHandle, int eventSize, [MarshalAs(UnmanagedType.LPArray)] IntPtr[] events, int timeout, int flags, ref int returned);

	[DllImport("wevtapi.dll", SetLastError = true)]
	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool EvtCancel(EventLogHandle handle);

	[DllImport("wevtapi.dll")]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool EvtClose(IntPtr handle);

	[DllImport("wevtapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool EvtGetEventInfo(EventLogHandle eventHandle, [MarshalAs(UnmanagedType.I4)] EvtEventPropertyId propertyId, int bufferSize, IntPtr bufferPtr, out int bufferUsed);

	[DllImport("wevtapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool EvtGetQueryInfo(EventLogHandle queryHandle, [MarshalAs(UnmanagedType.I4)] EvtQueryPropertyId propertyId, int bufferSize, IntPtr buffer, ref int bufferRequired);

	[DllImport("wevtapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[SecurityCritical]
	internal static extern EventLogHandle EvtOpenPublisherMetadata(EventLogHandle session, [MarshalAs(UnmanagedType.LPWStr)] string publisherId, [MarshalAs(UnmanagedType.LPWStr)] string logFilePath, int locale, int flags);

	[DllImport("wevtapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool EvtGetPublisherMetadataProperty(EventLogHandle publisherMetadataHandle, [MarshalAs(UnmanagedType.I4)] EvtPublisherMetadataPropertyId propertyId, int flags, int publisherMetadataPropertyBufferSize, IntPtr publisherMetadataPropertyBuffer, out int publisherMetadataPropertyBufferUsed);

	[DllImport("wevtapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool EvtGetObjectArraySize(EventLogHandle objectArray, out int objectArraySize);

	[DllImport("wevtapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool EvtGetObjectArrayProperty(EventLogHandle objectArray, int propertyId, int arrayIndex, int flags, int propertyValueBufferSize, IntPtr propertyValueBuffer, out int propertyValueBufferUsed);

	[DllImport("wevtapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[SecurityCritical]
	internal static extern EventLogHandle EvtOpenEventMetadataEnum(EventLogHandle publisherMetadata, int flags);

	[DllImport("wevtapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[SecurityCritical]
	internal static extern EventLogHandle EvtNextEventMetadata(EventLogHandle eventMetadataEnum, int flags);

	[DllImport("wevtapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool EvtGetEventMetadataProperty(EventLogHandle eventMetadata, [MarshalAs(UnmanagedType.I4)] EvtEventMetadataPropertyId propertyId, int flags, int eventMetadataPropertyBufferSize, IntPtr eventMetadataPropertyBuffer, out int eventMetadataPropertyBufferUsed);

	[DllImport("wevtapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[SecurityCritical]
	internal static extern EventLogHandle EvtOpenChannelEnum(EventLogHandle session, int flags);

	[DllImport("wevtapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool EvtNextChannelPath(EventLogHandle channelEnum, int channelPathBufferSize, [Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder channelPathBuffer, out int channelPathBufferUsed);

	[DllImport("wevtapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[SecurityCritical]
	internal static extern EventLogHandle EvtOpenPublisherEnum(EventLogHandle session, int flags);

	[DllImport("wevtapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool EvtNextPublisherId(EventLogHandle publisherEnum, int publisherIdBufferSize, [Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder publisherIdBuffer, out int publisherIdBufferUsed);

	[DllImport("wevtapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[SecurityCritical]
	internal static extern EventLogHandle EvtOpenChannelConfig(EventLogHandle session, [MarshalAs(UnmanagedType.LPWStr)] string channelPath, int flags);

	[DllImport("wevtapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool EvtSaveChannelConfig(EventLogHandle channelConfig, int flags);

	[DllImport("wevtapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool EvtSetChannelConfigProperty(EventLogHandle channelConfig, [MarshalAs(UnmanagedType.I4)] EvtChannelConfigPropertyId propertyId, int flags, ref EvtVariant propertyValue);

	[DllImport("wevtapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool EvtGetChannelConfigProperty(EventLogHandle channelConfig, [MarshalAs(UnmanagedType.I4)] EvtChannelConfigPropertyId propertyId, int flags, int propertyValueBufferSize, IntPtr propertyValueBuffer, out int propertyValueBufferUsed);

	[DllImport("wevtapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[SecurityCritical]
	internal static extern EventLogHandle EvtOpenLog(EventLogHandle session, [MarshalAs(UnmanagedType.LPWStr)] string path, [MarshalAs(UnmanagedType.I4)] PathType flags);

	[DllImport("wevtapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool EvtGetLogInfo(EventLogHandle log, [MarshalAs(UnmanagedType.I4)] EvtLogPropertyId propertyId, int propertyValueBufferSize, IntPtr propertyValueBuffer, out int propertyValueBufferUsed);

	[DllImport("wevtapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool EvtExportLog(EventLogHandle session, [MarshalAs(UnmanagedType.LPWStr)] string channelPath, [MarshalAs(UnmanagedType.LPWStr)] string query, [MarshalAs(UnmanagedType.LPWStr)] string targetFilePath, int flags);

	[DllImport("wevtapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool EvtArchiveExportedLog(EventLogHandle session, [MarshalAs(UnmanagedType.LPWStr)] string logFilePath, int locale, int flags);

	[DllImport("wevtapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool EvtClearLog(EventLogHandle session, [MarshalAs(UnmanagedType.LPWStr)] string channelPath, [MarshalAs(UnmanagedType.LPWStr)] string targetFilePath, int flags);

	[DllImport("wevtapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[SecurityCritical]
	internal static extern EventLogHandle EvtCreateRenderContext(int valuePathsCount, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPWStr)] string[] valuePaths, [MarshalAs(UnmanagedType.I4)] EvtRenderContextFlags flags);

	[DllImport("wevtapi.dll", SetLastError = true)]
	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool EvtRender(EventLogHandle context, EventLogHandle eventHandle, EvtRenderFlags flags, int buffSize, [Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder buffer, out int buffUsed, out int propCount);

	[DllImport("wevtapi.dll", SetLastError = true)]
	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool EvtRender(EventLogHandle context, EventLogHandle eventHandle, EvtRenderFlags flags, int buffSize, IntPtr buffer, out int buffUsed, out int propCount);

	[DllImport("wevtapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool EvtFormatMessage(EventLogHandle publisherMetadataHandle, EventLogHandle eventHandle, uint messageId, int valueCount, EvtStringVariant[] values, [MarshalAs(UnmanagedType.I4)] EvtFormatMessageFlags flags, int bufferSize, [Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder buffer, out int bufferUsed);

	[DllImport("wevtapi.dll", CharSet = CharSet.Auto, EntryPoint = "EvtFormatMessage", SetLastError = true)]
	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool EvtFormatMessageBuffer(EventLogHandle publisherMetadataHandle, EventLogHandle eventHandle, uint messageId, int valueCount, IntPtr values, [MarshalAs(UnmanagedType.I4)] EvtFormatMessageFlags flags, int bufferSize, IntPtr buffer, out int bufferUsed);

	[DllImport("wevtapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[SecurityCritical]
	internal static extern EventLogHandle EvtOpenSession([MarshalAs(UnmanagedType.I4)] EvtLoginClass loginClass, ref EvtRpcLogin login, int timeout, int flags);

	[DllImport("wevtapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[SecurityCritical]
	internal static extern EventLogHandle EvtCreateBookmark([MarshalAs(UnmanagedType.LPWStr)] string bookmarkXml);

	[DllImport("wevtapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool EvtUpdateBookmark(EventLogHandle bookmark, EventLogHandle eventHandle);

	[DllImport("kernel32.dll", SetLastError = true)]
	[SecurityCritical]
	internal static extern void GetSystemInfo(ref SYSTEM_INFO lpSystemInfo);

	[DllImport("kernel32.dll", ExactSpelling = true)]
	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool UnmapViewOfFile(IntPtr lpBaseAddress);

	[DllImport("kernel32.dll", SetLastError = true)]
	[SecurityCritical]
	internal static extern int GetFileSize(SafeMemoryMappedFileHandle hFile, out int highSize);

	[DllImport("kernel32.dll", SetLastError = true)]
	[SecurityCritical]
	internal static extern IntPtr VirtualQuery(SafeMemoryMappedViewHandle address, ref MEMORY_BASIC_INFORMATION buffer, IntPtr sizeOfBuffer);

	[DllImport("kernel32.dll", BestFitMapping = false, CharSet = CharSet.Auto, SetLastError = true)]
	[SecurityCritical]
	internal static extern SafeMemoryMappedFileHandle CreateFileMapping(SafeFileHandle hFile, SECURITY_ATTRIBUTES lpAttributes, int fProtect, int dwMaximumSizeHigh, int dwMaximumSizeLow, string lpName);

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal unsafe static extern bool FlushViewOfFile(byte* lpBaseAddress, IntPtr dwNumberOfBytesToFlush);

	[DllImport("kernel32.dll", BestFitMapping = false, CharSet = CharSet.Auto, SetLastError = true)]
	[SecurityCritical]
	internal static extern SafeMemoryMappedFileHandle OpenFileMapping(int dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, string lpName);

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	[SecurityCritical]
	internal static extern SafeMemoryMappedViewHandle MapViewOfFile(SafeMemoryMappedFileHandle handle, int dwDesiredAccess, uint dwFileOffsetHigh, uint dwFileOffsetLow, UIntPtr dwNumberOfBytesToMap);

	[DllImport("kernel32.dll", SetLastError = true)]
	[SecurityCritical]
	internal static extern IntPtr VirtualAlloc(SafeMemoryMappedViewHandle address, UIntPtr numBytes, int commitOrReserve, int pageProtectionMode);

	[SecurityCritical]
	internal static bool GlobalMemoryStatusEx(ref MEMORYSTATUSEX lpBuffer)
	{
		lpBuffer.dwLength = (uint)Marshal.SizeOf(typeof(MEMORYSTATUSEX));
		return GlobalMemoryStatusExNative(ref lpBuffer);
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "GlobalMemoryStatusEx", SetLastError = true)]
	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool GlobalMemoryStatusExNative([In][Out] ref MEMORYSTATUSEX lpBuffer);

	[DllImport("kernel32.dll", SetLastError = true)]
	[SecurityCritical]
	internal unsafe static extern bool CancelIoEx(SafeHandle handle, NativeOverlapped* lpOverlapped);
}
