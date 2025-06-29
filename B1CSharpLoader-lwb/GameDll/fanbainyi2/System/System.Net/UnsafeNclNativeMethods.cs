using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net.Cache;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace System.Net;

[SuppressUnmanagedCodeSecurity]
internal static class UnsafeNclNativeMethods
{
	internal static class ErrorCodes
	{
		internal const uint ERROR_SUCCESS = 0u;

		internal const uint ERROR_HANDLE_EOF = 38u;

		internal const uint ERROR_NOT_SUPPORTED = 50u;

		internal const uint ERROR_INVALID_PARAMETER = 87u;

		internal const uint ERROR_ALREADY_EXISTS = 183u;

		internal const uint ERROR_MORE_DATA = 234u;

		internal const uint ERROR_OPERATION_ABORTED = 995u;

		internal const uint ERROR_IO_PENDING = 997u;

		internal const uint ERROR_NOT_FOUND = 1168u;

		internal const uint ERROR_CONNECTION_INVALID = 1229u;
	}

	internal static class NTStatus
	{
		internal const uint STATUS_SUCCESS = 0u;

		internal const uint STATUS_OBJECT_NAME_NOT_FOUND = 3221225524u;
	}

	[Flags]
	internal enum FileCompletionNotificationModes : byte
	{
		None = 0,
		SkipCompletionPortOnSuccess = 1,
		SkipSetEventOnHandle = 2
	}

	[SuppressUnmanagedCodeSecurity]
	internal static class RegistryHelper
	{
		internal const uint REG_NOTIFY_CHANGE_LAST_SET = 4u;

		internal const uint REG_BINARY = 3u;

		internal const uint KEY_READ = 131097u;

		internal static readonly IntPtr HKEY_CURRENT_USER = (IntPtr)(-2147483647);

		internal static readonly IntPtr HKEY_LOCAL_MACHINE = (IntPtr)(-2147483646);

		[DllImport("advapi32.dll", BestFitMapping = false, CharSet = CharSet.Auto, SetLastError = true, ThrowOnUnmappableChar = true)]
		internal static extern uint RegOpenKeyEx(IntPtr key, string subKey, uint ulOptions, uint samDesired, out SafeRegistryHandle resultSubKey);

		[DllImport("advapi32.dll", BestFitMapping = false, CharSet = CharSet.Auto, SetLastError = true, ThrowOnUnmappableChar = true)]
		internal static extern uint RegOpenKeyEx(SafeRegistryHandle key, string subKey, uint ulOptions, uint samDesired, out SafeRegistryHandle resultSubKey);

		[DllImport("advapi32.dll", ExactSpelling = true, SetLastError = true)]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		internal static extern uint RegCloseKey(IntPtr key);

		[DllImport("advapi32.dll", ExactSpelling = true, SetLastError = true)]
		internal static extern uint RegNotifyChangeKeyValue(SafeRegistryHandle key, bool watchSubTree, uint notifyFilter, SafeWaitHandle regEvent, bool async);

		[DllImport("advapi32.dll", ExactSpelling = true, SetLastError = true)]
		internal static extern uint RegOpenCurrentUser(uint samDesired, out SafeRegistryHandle resultKey);

		[DllImport("advapi32.dll", BestFitMapping = false, CharSet = CharSet.Auto, SetLastError = true, ThrowOnUnmappableChar = true)]
		internal static extern uint RegQueryValueEx(SafeRegistryHandle key, string valueName, IntPtr reserved, out uint type, [Out] byte[] data, [In][Out] ref uint size);
	}

	[SuppressUnmanagedCodeSecurity]
	internal class RasHelper
	{
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto, Pack = 4)]
		private struct RASCONN
		{
			internal uint dwSize;

			internal IntPtr hrasconn;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 257)]
			internal string szEntryName;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
			internal string szDeviceType;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
			internal string szDeviceName;
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
		private struct RASCONNSTATUS
		{
			internal uint dwSize;

			internal RASCONNSTATE rasconnstate;

			internal uint dwError;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
			internal string szDeviceType;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
			internal string szDeviceName;
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
		private struct RASDIALPARAMS
		{
			internal uint dwSize;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 257)]
			internal string szEntryName;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
			internal string szPhoneNumber;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
			internal string szCallbackNumber;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 257)]
			internal string szUserName;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 257)]
			internal string szPassword;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			internal string szDomain;
		}

		private enum RASCONNSTATE
		{
			RASCS_OpenPort = 0,
			RASCS_PortOpened = 1,
			RASCS_ConnectDevice = 2,
			RASCS_DeviceConnected = 3,
			RASCS_AllDevicesConnected = 4,
			RASCS_Authenticate = 5,
			RASCS_AuthNotify = 6,
			RASCS_AuthRetry = 7,
			RASCS_AuthCallback = 8,
			RASCS_AuthChangePassword = 9,
			RASCS_AuthProject = 10,
			RASCS_AuthLinkSpeed = 11,
			RASCS_AuthAck = 12,
			RASCS_ReAuthenticate = 13,
			RASCS_Authenticated = 14,
			RASCS_PrepareForCallback = 15,
			RASCS_WaitForModemReset = 16,
			RASCS_WaitForCallback = 17,
			RASCS_Projected = 18,
			RASCS_StartAuthentication = 19,
			RASCS_CallbackComplete = 20,
			RASCS_LogonNetwork = 21,
			RASCS_SubEntryConnected = 22,
			RASCS_SubEntryDisconnected = 23,
			RASCS_Interactive = 4096,
			RASCS_RetryAuthentication = 4097,
			RASCS_CallbackSetByCaller = 4098,
			RASCS_PasswordExpired = 4099,
			RASCS_InvokeEapUI = 4100,
			RASCS_Connected = 8192,
			RASCS_Disconnected = 8193
		}

		private static readonly bool s_RasSupported;

		private ManualResetEvent m_RasEvent;

		private bool m_Suppressed;

		private const int RAS_MaxEntryName = 256;

		private const int RAS_MaxDeviceType = 16;

		private const int RAS_MaxDeviceName = 128;

		private const int RAS_MaxPhoneNumber = 128;

		private const int RAS_MaxCallbackNumber = 128;

		private const uint RASCN_Connection = 1u;

		private const uint RASCN_Disconnection = 2u;

		private const int UNLEN = 256;

		private const int PWLEN = 256;

		private const int DNLEN = 15;

		private const int MAX_PATH = 260;

		private const uint RASBASE = 600u;

		private const uint ERROR_DIAL_ALREADY_IN_PROGRESS = 756u;

		private const uint ERROR_BUFFER_TOO_SMALL = 603u;

		private const int RASCS_PAUSED = 4096;

		private const int RASCS_DONE = 8192;

		internal static bool RasSupported => s_RasSupported;

		internal bool HasChanged
		{
			get
			{
				if (m_Suppressed)
				{
					return false;
				}
				ManualResetEvent rasEvent = m_RasEvent;
				if (rasEvent == null)
				{
					throw new ObjectDisposedException(GetType().FullName);
				}
				return rasEvent.WaitOne(0, exitContext: false);
			}
		}

		static RasHelper()
		{
			if (ComNetOS.InstallationType == WindowsInstallationType.ServerCore)
			{
				s_RasSupported = false;
			}
			else
			{
				s_RasSupported = true;
			}
			if (Logging.On)
			{
				Logging.PrintInfo(Logging.Web, SR.GetString("net_log_proxy_ras_supported", s_RasSupported));
			}
		}

		internal RasHelper()
		{
			if (!s_RasSupported)
			{
				throw new InvalidOperationException(SR.GetString("net_log_proxy_ras_notsupported_exception"));
			}
			m_RasEvent = new ManualResetEvent(initialState: false);
			if (RasConnectionNotification((IntPtr)(-1), m_RasEvent.SafeWaitHandle, 3u) != 0)
			{
				m_Suppressed = true;
				m_RasEvent.Close();
				m_RasEvent = null;
			}
		}

		internal void Reset()
		{
			if (!m_Suppressed)
			{
				ManualResetEvent rasEvent = m_RasEvent;
				if (rasEvent == null)
				{
					throw new ObjectDisposedException(GetType().FullName);
				}
				rasEvent.Reset();
			}
		}

		internal static string GetCurrentConnectoid()
		{
			uint num = (uint)Marshal.SizeOf(typeof(RASCONN));
			if (!s_RasSupported)
			{
				return null;
			}
			uint lpcConnections = 4u;
			uint num2 = 0u;
			RASCONN[] array = null;
			while (true)
			{
				uint lpcb = checked(num * lpcConnections);
				array = new RASCONN[lpcConnections];
				array[0].dwSize = num;
				num2 = RasEnumConnections(array, ref lpcb, ref lpcConnections);
				if (num2 != 603)
				{
					break;
				}
				lpcConnections = checked(lpcb + num - 1) / num;
			}
			if (lpcConnections == 0 || num2 != 0)
			{
				return null;
			}
			for (uint num3 = 0u; num3 < lpcConnections; num3++)
			{
				RASCONNSTATUS lprasconnstatus = default(RASCONNSTATUS);
				lprasconnstatus.dwSize = (uint)Marshal.SizeOf((object)lprasconnstatus);
				if (RasGetConnectStatus(array[num3].hrasconn, ref lprasconnstatus) == 0 && lprasconnstatus.rasconnstate == RASCONNSTATE.RASCS_Connected)
				{
					return array[num3].szEntryName;
				}
			}
			return null;
		}

		[DllImport("rasapi32.dll", BestFitMapping = false, CharSet = CharSet.Auto, ThrowOnUnmappableChar = true)]
		private static extern uint RasEnumConnections([In][Out] RASCONN[] lprasconn, ref uint lpcb, ref uint lpcConnections);

		[DllImport("rasapi32.dll", BestFitMapping = false, CharSet = CharSet.Auto, ThrowOnUnmappableChar = true)]
		private static extern uint RasGetConnectStatus([In] IntPtr hrasconn, [In][Out] ref RASCONNSTATUS lprasconnstatus);

		[DllImport("rasapi32.dll", BestFitMapping = false, CharSet = CharSet.Auto, ThrowOnUnmappableChar = true)]
		private static extern uint RasConnectionNotification([In] IntPtr hrasconn, [In] SafeWaitHandle hEvent, uint dwFlags);
	}

	[SuppressUnmanagedCodeSecurity]
	internal static class SafeNetHandles_SECURITY
	{
		[DllImport("secur32.dll", ExactSpelling = true, SetLastError = true)]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		internal static extern int FreeContextBuffer([In] IntPtr contextBuffer);

		[DllImport("secur32.dll", ExactSpelling = true, SetLastError = true)]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		internal static extern int FreeCredentialsHandle(ref SSPIHandle handlePtr);

		[DllImport("secur32.dll", ExactSpelling = true, SetLastError = true)]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		internal static extern int DeleteSecurityContext(ref SSPIHandle handlePtr);

		[DllImport("secur32.dll", ExactSpelling = true, SetLastError = true)]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		internal unsafe static extern int AcceptSecurityContext(ref SSPIHandle credentialHandle, [In] void* inContextPtr, [In] SecurityBufferDescriptor inputBuffer, [In] ContextFlags inFlags, [In] Endianness endianness, ref SSPIHandle outContextPtr, [In][Out] SecurityBufferDescriptor outputBuffer, [In][Out] ref ContextFlags attributes, out long timeStamp);

		[DllImport("secur32.dll", ExactSpelling = true, SetLastError = true)]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		internal unsafe static extern int QueryContextAttributesW(ref SSPIHandle contextHandle, [In] ContextAttribute attribute, [In] void* buffer);

		[DllImport("secur32.dll", ExactSpelling = true, SetLastError = true)]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		internal static extern int SetContextAttributesW(ref SSPIHandle contextHandle, [In] ContextAttribute attribute, [In] byte[] buffer, [In] int bufferSize);

		[DllImport("secur32.dll", ExactSpelling = true, SetLastError = true)]
		internal static extern int EnumerateSecurityPackagesW(out int pkgnum, out SafeFreeContextBuffer_SECURITY handle);

		[DllImport("secur32.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
		internal unsafe static extern int AcquireCredentialsHandleW([In] string principal, [In] string moduleName, [In] int usage, [In] void* logonID, [In] ref AuthIdentity authdata, [In] void* keyCallback, [In] void* keyArgument, ref SSPIHandle handlePtr, out long timeStamp);

		[DllImport("secur32.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
		internal unsafe static extern int AcquireCredentialsHandleW([In] string principal, [In] string moduleName, [In] int usage, [In] void* logonID, [In] IntPtr zero, [In] void* keyCallback, [In] void* keyArgument, ref SSPIHandle handlePtr, out long timeStamp);

		[DllImport("secur32.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
		internal unsafe static extern int AcquireCredentialsHandleW([In] string principal, [In] string moduleName, [In] int usage, [In] void* logonID, [In] SafeSspiAuthDataHandle authdata, [In] void* keyCallback, [In] void* keyArgument, ref SSPIHandle handlePtr, out long timeStamp);

		[DllImport("secur32.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
		internal unsafe static extern int AcquireCredentialsHandleW([In] string principal, [In] string moduleName, [In] int usage, [In] void* logonID, [In] ref SecureCredential authData, [In] void* keyCallback, [In] void* keyArgument, ref SSPIHandle handlePtr, out long timeStamp);

		[DllImport("secur32.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
		internal unsafe static extern int AcquireCredentialsHandleW([In] string principal, [In] string moduleName, [In] int usage, [In] void* logonID, [In] ref SecureCredential2 authData, [In] void* keyCallback, [In] void* keyArgument, ref SSPIHandle handlePtr, out long timeStamp);

		[DllImport("secur32.dll", ExactSpelling = true, SetLastError = true)]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		internal unsafe static extern int InitializeSecurityContextW(ref SSPIHandle credentialHandle, [In] void* inContextPtr, [In] byte* targetName, [In] ContextFlags inFlags, [In] int reservedI, [In] Endianness endianness, [In] SecurityBufferDescriptor inputBuffer, [In] int reservedII, ref SSPIHandle outContextPtr, [In][Out] SecurityBufferDescriptor outputBuffer, [In][Out] ref ContextFlags attributes, out long timeStamp);

		[DllImport("secur32.dll", ExactSpelling = true, SetLastError = true)]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		internal unsafe static extern int CompleteAuthToken([In] void* inContextPtr, [In][Out] SecurityBufferDescriptor inputBuffers);

		[DllImport("secur32.dll", ExactSpelling = true, SetLastError = true)]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		internal unsafe static extern int ApplyControlToken([In] void* inContextPtr, [In][Out] SecurityBufferDescriptor inputBuffers);
	}

	[SuppressUnmanagedCodeSecurity]
	internal static class SafeNetHandlesSafeOverlappedFree
	{
		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		internal static extern SafeOverlappedFree LocalAlloc(int uFlags, UIntPtr sizetdwBytes);
	}

	[SuppressUnmanagedCodeSecurity]
	internal static class SafeNetHandlesXPOrLater
	{
		[DllImport("ws2_32.dll", BestFitMapping = false, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true, ThrowOnUnmappableChar = true)]
		internal static extern int GetAddrInfoW([In] string nodename, [In] string servicename, [In] ref AddressInfo hints, out SafeFreeAddrInfo handle);

		[DllImport("ws2_32.dll", ExactSpelling = true, SetLastError = true)]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		internal static extern void freeaddrinfo([In] IntPtr info);
	}

	[SuppressUnmanagedCodeSecurity]
	internal static class SafeNetHandles
	{
		[DllImport("secur32.dll", ExactSpelling = true, SetLastError = true)]
		internal static extern int QuerySecurityContextToken(ref SSPIHandle phContext, out SafeCloseHandle handle);

		[DllImport("httpapi.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
		internal static extern uint HttpCreateRequestQueue(HttpApi.HTTPAPI_VERSION version, string pName, Microsoft.Win32.NativeMethods.SECURITY_ATTRIBUTES pSecurityAttributes, uint flags, out HttpRequestQueueV2Handle pReqQueueHandle);

		[DllImport("httpapi.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
		internal static extern uint HttpCloseRequestQueue(IntPtr pReqQueueHandle);

		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		internal static extern bool CloseHandle(IntPtr handle);

		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		internal static extern SafeLocalFree LocalAlloc(int uFlags, UIntPtr sizetdwBytes);

		[DllImport("kernel32.dll", EntryPoint = "LocalAlloc", SetLastError = true)]
		internal static extern SafeLocalFreeChannelBinding LocalAllocChannelBinding(int uFlags, UIntPtr sizetdwBytes);

		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		internal static extern IntPtr LocalFree(IntPtr handle);

		[DllImport("kernel32.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
		internal unsafe static extern SafeLoadLibrary LoadLibraryExW([In] string lpwLibFileName, [In] void* hFile, [In] uint dwFlags);

		[DllImport("kernel32.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
		public static extern IntPtr GetModuleHandleW(string modName);

		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		internal static extern bool FreeLibrary([In] IntPtr hModule);

		[DllImport("crypt32.dll", ExactSpelling = true, SetLastError = true)]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		internal static extern void CertFreeCertificateChain([In] IntPtr pChainContext);

		[DllImport("crypt32.dll", ExactSpelling = true, SetLastError = true)]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		internal static extern void CertFreeCertificateChainList([In] IntPtr ppChainContext);

		[DllImport("crypt32.dll", ExactSpelling = true, SetLastError = true)]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		internal static extern bool CertFreeCertificateContext([In] IntPtr certContext);

		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		internal static extern IntPtr GlobalFree(IntPtr handle);

		[DllImport("ws2_32.dll", ExactSpelling = true, SetLastError = true)]
		internal static extern SafeCloseSocket.InnerSafeCloseSocket accept([In] IntPtr socketHandle, [Out] byte[] socketAddress, [In][Out] ref int socketAddressSize);

		[DllImport("ws2_32.dll", ExactSpelling = true, SetLastError = true)]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		internal static extern SocketError closesocket([In] IntPtr socketHandle);

		[DllImport("ws2_32.dll", ExactSpelling = true, SetLastError = true)]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		internal static extern SocketError ioctlsocket([In] IntPtr handle, [In] int cmd, [In][Out] ref int argp);

		[DllImport("ws2_32.dll", ExactSpelling = true, SetLastError = true)]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		internal static extern SocketError WSAEventSelect([In] IntPtr handle, [In] IntPtr Event, [In] AsyncEventBits NetworkEvents);

		[DllImport("ws2_32.dll", ExactSpelling = true, SetLastError = true)]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		internal static extern SocketError setsockopt([In] IntPtr handle, [In] SocketOptionLevel optionLevel, [In] SocketOptionName optionName, [In] ref Linger linger, [In] int optionLength);

		[DllImport("wininet.dll", ExactSpelling = true, SetLastError = true)]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		internal unsafe static extern bool RetrieveUrlCacheEntryFileW([In] char* urlName, [In] byte* entryPtr, [In][Out] ref int entryBufSize, [In] int dwReserved);

		[DllImport("wininet.dll", ExactSpelling = true, SetLastError = true)]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		internal unsafe static extern bool UnlockUrlCacheEntryFileW([In] char* urlName, [In] int dwReserved);
	}

	[SuppressUnmanagedCodeSecurity]
	internal static class OSSOCK
	{
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
		internal struct WSAPROTOCOLCHAIN
		{
			internal int ChainLen;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
			internal uint[] ChainEntries;
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
		internal struct WSAPROTOCOL_INFO
		{
			internal uint dwServiceFlags1;

			internal uint dwServiceFlags2;

			internal uint dwServiceFlags3;

			internal uint dwServiceFlags4;

			internal uint dwProviderFlags;

			private Guid ProviderId;

			internal uint dwCatalogEntryId;

			private WSAPROTOCOLCHAIN ProtocolChain;

			internal int iVersion;

			internal AddressFamily iAddressFamily;

			internal int iMaxSockAddr;

			internal int iMinSockAddr;

			internal int iSocketType;

			internal int iProtocol;

			internal int iProtocolMaxOffset;

			internal int iNetworkByteOrder;

			internal int iSecurityScheme;

			internal uint dwMessageSize;

			internal uint dwProviderReserved;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
			internal string szProtocol;
		}

		internal struct ControlData
		{
			internal UIntPtr length;

			internal uint level;

			internal uint type;

			internal uint address;

			internal uint index;
		}

		internal struct ControlDataIPv6
		{
			internal UIntPtr length;

			internal uint level;

			internal uint type;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
			internal byte[] address;

			internal uint index;
		}

		internal struct WSAMsg
		{
			internal IntPtr socketAddress;

			internal uint addressLength;

			internal IntPtr buffers;

			internal uint count;

			internal WSABuffer controlBuffer;

			internal SocketFlags flags;
		}

		[Flags]
		internal enum TransmitPacketsElementFlags : uint
		{
			None = 0u,
			Memory = 1u,
			File = 2u,
			EndOfPacket = 4u
		}

		[StructLayout(LayoutKind.Explicit)]
		internal struct TransmitPacketsElement
		{
			[FieldOffset(0)]
			internal TransmitPacketsElementFlags flags;

			[FieldOffset(4)]
			internal uint length;

			[FieldOffset(8)]
			internal long fileOffset;

			[FieldOffset(8)]
			internal IntPtr buffer;

			[FieldOffset(16)]
			internal IntPtr fileHandle;
		}

		internal struct SOCKET_ADDRESS
		{
			internal IntPtr lpSockAddr;

			internal int iSockaddrLength;
		}

		internal struct SOCKET_ADDRESS_LIST
		{
			internal int iAddressCount;

			internal SOCKET_ADDRESS Addresses;
		}

		internal struct TransmitFileBuffersStruct
		{
			internal IntPtr preBuffer;

			internal int preBufferLength;

			internal IntPtr postBuffer;

			internal int postBufferLength;
		}

		private const string WS2_32 = "ws2_32.dll";

		private const string mswsock = "mswsock.dll";

		[DllImport("ws2_32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		internal static extern SafeCloseSocket.InnerSafeCloseSocket WSASocket([In] AddressFamily addressFamily, [In] SocketType socketType, [In] ProtocolType protocolType, [In] IntPtr protocolInfo, [In] uint group, [In] SocketConstructorFlags flags);

		[DllImport("ws2_32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		internal unsafe static extern SafeCloseSocket.InnerSafeCloseSocket WSASocket([In] AddressFamily addressFamily, [In] SocketType socketType, [In] ProtocolType protocolType, [In] byte* pinnedBuffer, [In] uint group, [In] SocketConstructorFlags flags);

		[DllImport("ws2_32.dll", BestFitMapping = false, CharSet = CharSet.Ansi, SetLastError = true, ThrowOnUnmappableChar = true)]
		internal static extern SocketError WSAStartup([In] short wVersionRequested, out WSAData lpWSAData);

		[DllImport("ws2_32.dll", SetLastError = true)]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		internal static extern SocketError ioctlsocket([In] SafeCloseSocket socketHandle, [In] int cmd, [In][Out] ref int argp);

		[DllImport("ws2_32.dll", BestFitMapping = false, CharSet = CharSet.Ansi, SetLastError = true, ThrowOnUnmappableChar = true)]
		internal static extern IntPtr gethostbyname([In] string host);

		[DllImport("ws2_32.dll", SetLastError = true)]
		internal static extern IntPtr gethostbyaddr([In] ref int addr, [In] int len, [In] ProtocolFamily type);

		[DllImport("ws2_32.dll", BestFitMapping = false, CharSet = CharSet.Ansi, SetLastError = true, ThrowOnUnmappableChar = true)]
		internal static extern SocketError gethostname([Out] StringBuilder hostName, [In] int bufferLength);

		[DllImport("ws2_32.dll", SetLastError = true)]
		internal static extern SocketError getpeername([In] SafeCloseSocket socketHandle, [Out] byte[] socketAddress, [In][Out] ref int socketAddressSize);

		[DllImport("ws2_32.dll", SetLastError = true)]
		internal static extern SocketError getsockopt([In] SafeCloseSocket socketHandle, [In] SocketOptionLevel optionLevel, [In] SocketOptionName optionName, out int optionValue, [In][Out] ref int optionLength);

		[DllImport("ws2_32.dll", SetLastError = true)]
		internal static extern SocketError getsockopt([In] SafeCloseSocket socketHandle, [In] SocketOptionLevel optionLevel, [In] SocketOptionName optionName, [Out] byte[] optionValue, [In][Out] ref int optionLength);

		[DllImport("ws2_32.dll", SetLastError = true)]
		internal static extern SocketError getsockopt([In] SafeCloseSocket socketHandle, [In] SocketOptionLevel optionLevel, [In] SocketOptionName optionName, out Linger optionValue, [In][Out] ref int optionLength);

		[DllImport("ws2_32.dll", SetLastError = true)]
		internal static extern SocketError getsockopt([In] SafeCloseSocket socketHandle, [In] SocketOptionLevel optionLevel, [In] SocketOptionName optionName, out IPMulticastRequest optionValue, [In][Out] ref int optionLength);

		[DllImport("ws2_32.dll", SetLastError = true)]
		internal static extern SocketError getsockopt([In] SafeCloseSocket socketHandle, [In] SocketOptionLevel optionLevel, [In] SocketOptionName optionName, out IPv6MulticastRequest optionValue, [In][Out] ref int optionLength);

		[DllImport("ws2_32.dll", SetLastError = true)]
		internal static extern SocketError setsockopt([In] SafeCloseSocket socketHandle, [In] SocketOptionLevel optionLevel, [In] SocketOptionName optionName, [In] ref int optionValue, [In] int optionLength);

		[DllImport("ws2_32.dll", SetLastError = true)]
		internal static extern SocketError setsockopt([In] SafeCloseSocket socketHandle, [In] SocketOptionLevel optionLevel, [In] SocketOptionName optionName, [In] byte[] optionValue, [In] int optionLength);

		[DllImport("ws2_32.dll", SetLastError = true)]
		internal static extern SocketError setsockopt([In] SafeCloseSocket socketHandle, [In] SocketOptionLevel optionLevel, [In] SocketOptionName optionName, [In] ref IntPtr pointer, [In] int optionLength);

		[DllImport("ws2_32.dll", SetLastError = true)]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		internal static extern SocketError setsockopt([In] SafeCloseSocket socketHandle, [In] SocketOptionLevel optionLevel, [In] SocketOptionName optionName, [In] ref Linger linger, [In] int optionLength);

		[DllImport("ws2_32.dll", SetLastError = true)]
		internal static extern SocketError setsockopt([In] SafeCloseSocket socketHandle, [In] SocketOptionLevel optionLevel, [In] SocketOptionName optionName, [In] ref IPMulticastRequest mreq, [In] int optionLength);

		[DllImport("ws2_32.dll", SetLastError = true)]
		internal static extern SocketError setsockopt([In] SafeCloseSocket socketHandle, [In] SocketOptionLevel optionLevel, [In] SocketOptionName optionName, [In] ref IPv6MulticastRequest mreq, [In] int optionLength);

		[DllImport("mswsock.dll", SetLastError = true)]
		internal static extern bool TransmitFile([In] SafeCloseSocket socket, [In] SafeHandle fileHandle, [In] int numberOfBytesToWrite, [In] int numberOfBytesPerSend, [In] SafeHandle overlapped, [In] TransmitFileBuffers buffers, [In] TransmitFileOptions flags);

		[DllImport("mswsock.dll", EntryPoint = "TransmitFile", SetLastError = true)]
		internal static extern bool TransmitFile2([In] SafeCloseSocket socket, [In] IntPtr fileHandle, [In] int numberOfBytesToWrite, [In] int numberOfBytesPerSend, [In] SafeHandle overlapped, [In] TransmitFileBuffers buffers, [In] TransmitFileOptions flags);

		[DllImport("mswsock.dll", EntryPoint = "TransmitFile", SetLastError = true)]
		internal static extern bool TransmitFile_Blocking([In] IntPtr socket, [In] SafeHandle fileHandle, [In] int numberOfBytesToWrite, [In] int numberOfBytesPerSend, [In] SafeHandle overlapped, [In] TransmitFileBuffers buffers, [In] TransmitFileOptions flags);

		[DllImport("mswsock.dll", EntryPoint = "TransmitFile", SetLastError = true)]
		internal static extern bool TransmitFile_Blocking2([In] IntPtr socket, [In] IntPtr fileHandle, [In] int numberOfBytesToWrite, [In] int numberOfBytesPerSend, [In] SafeHandle overlapped, [In] TransmitFileBuffers buffers, [In] TransmitFileOptions flags);

		[DllImport("ws2_32.dll", SetLastError = true)]
		internal unsafe static extern int send([In] IntPtr socketHandle, [In] byte* pinnedBuffer, [In] int len, [In] SocketFlags socketFlags);

		[DllImport("ws2_32.dll", SetLastError = true)]
		internal unsafe static extern int recv([In] IntPtr socketHandle, [In] byte* pinnedBuffer, [In] int len, [In] SocketFlags socketFlags);

		[DllImport("ws2_32.dll", SetLastError = true)]
		internal static extern SocketError listen([In] SafeCloseSocket socketHandle, [In] int backlog);

		[DllImport("ws2_32.dll", SetLastError = true)]
		internal static extern SocketError bind([In] SafeCloseSocket socketHandle, [In] byte[] socketAddress, [In] int socketAddressSize);

		[DllImport("ws2_32.dll", SetLastError = true)]
		internal static extern SocketError shutdown([In] SafeCloseSocket socketHandle, [In] int how);

		[DllImport("ws2_32.dll", SetLastError = true)]
		internal unsafe static extern int sendto([In] IntPtr socketHandle, [In] byte* pinnedBuffer, [In] int len, [In] SocketFlags socketFlags, [In] byte[] socketAddress, [In] int socketAddressSize);

		[DllImport("ws2_32.dll", SetLastError = true)]
		internal unsafe static extern int recvfrom([In] IntPtr socketHandle, [In] byte* pinnedBuffer, [In] int len, [In] SocketFlags socketFlags, [Out] byte[] socketAddress, [In][Out] ref int socketAddressSize);

		[DllImport("ws2_32.dll", SetLastError = true)]
		internal static extern SocketError getsockname([In] SafeCloseSocket socketHandle, [Out] byte[] socketAddress, [In][Out] ref int socketAddressSize);

		[DllImport("ws2_32.dll", SetLastError = true)]
		internal static extern int select([In] int ignoredParameter, [In][Out] IntPtr[] readfds, [In][Out] IntPtr[] writefds, [In][Out] IntPtr[] exceptfds, [In] ref TimeValue timeout);

		[DllImport("ws2_32.dll", SetLastError = true)]
		internal static extern int select([In] int ignoredParameter, [In][Out] IntPtr[] readfds, [In][Out] IntPtr[] writefds, [In][Out] IntPtr[] exceptfds, [In] IntPtr nullTimeout);

		[DllImport("ws2_32.dll", SetLastError = true)]
		internal static extern SocketError WSAConnect([In] IntPtr socketHandle, [In] byte[] socketAddress, [In] int socketAddressSize, [In] IntPtr inBuffer, [In] IntPtr outBuffer, [In] IntPtr sQOS, [In] IntPtr gQOS);

		[DllImport("ws2_32.dll", SetLastError = true)]
		internal static extern SocketError WSASend([In] SafeCloseSocket socketHandle, [In] ref WSABuffer buffer, [In] int bufferCount, out int bytesTransferred, [In] SocketFlags socketFlags, [In] SafeHandle overlapped, [In] IntPtr completionRoutine);

		[DllImport("ws2_32.dll", SetLastError = true)]
		internal static extern SocketError WSASend([In] SafeCloseSocket socketHandle, [In] WSABuffer[] buffersArray, [In] int bufferCount, out int bytesTransferred, [In] SocketFlags socketFlags, [In] SafeHandle overlapped, [In] IntPtr completionRoutine);

		[DllImport("ws2_32.dll", EntryPoint = "WSASend", SetLastError = true)]
		internal static extern SocketError WSASend_Blocking([In] IntPtr socketHandle, [In] WSABuffer[] buffersArray, [In] int bufferCount, out int bytesTransferred, [In] SocketFlags socketFlags, [In] SafeHandle overlapped, [In] IntPtr completionRoutine);

		[DllImport("ws2_32.dll", SetLastError = true)]
		internal static extern SocketError WSASendTo([In] SafeCloseSocket socketHandle, [In] ref WSABuffer buffer, [In] int bufferCount, out int bytesTransferred, [In] SocketFlags socketFlags, [In] IntPtr socketAddress, [In] int socketAddressSize, [In] SafeHandle overlapped, [In] IntPtr completionRoutine);

		[DllImport("ws2_32.dll", SetLastError = true)]
		internal static extern SocketError WSASendTo([In] SafeCloseSocket socketHandle, [In] WSABuffer[] buffersArray, [In] int bufferCount, out int bytesTransferred, [In] SocketFlags socketFlags, [In] IntPtr socketAddress, [In] int socketAddressSize, [In] SafeNativeOverlapped overlapped, [In] IntPtr completionRoutine);

		[DllImport("ws2_32.dll", SetLastError = true)]
		internal static extern SocketError WSARecv([In] SafeCloseSocket socketHandle, [In] ref WSABuffer buffer, [In] int bufferCount, out int bytesTransferred, [In][Out] ref SocketFlags socketFlags, [In] SafeHandle overlapped, [In] IntPtr completionRoutine);

		[DllImport("ws2_32.dll", SetLastError = true)]
		internal static extern SocketError WSARecv([In] SafeCloseSocket socketHandle, [In][Out] WSABuffer[] buffers, [In] int bufferCount, out int bytesTransferred, [In][Out] ref SocketFlags socketFlags, [In] SafeHandle overlapped, [In] IntPtr completionRoutine);

		[DllImport("ws2_32.dll", EntryPoint = "WSARecv", SetLastError = true)]
		internal static extern SocketError WSARecv_Blocking([In] IntPtr socketHandle, [In][Out] WSABuffer[] buffers, [In] int bufferCount, out int bytesTransferred, [In][Out] ref SocketFlags socketFlags, [In] SafeHandle overlapped, [In] IntPtr completionRoutine);

		[DllImport("ws2_32.dll", SetLastError = true)]
		internal static extern SocketError WSARecvFrom([In] SafeCloseSocket socketHandle, [In] ref WSABuffer buffer, [In] int bufferCount, out int bytesTransferred, [In][Out] ref SocketFlags socketFlags, [In] IntPtr socketAddressPointer, [In] IntPtr socketAddressSizePointer, [In] SafeHandle overlapped, [In] IntPtr completionRoutine);

		[DllImport("ws2_32.dll", SetLastError = true)]
		internal static extern SocketError WSARecvFrom([In] SafeCloseSocket socketHandle, [In][Out] WSABuffer[] buffers, [In] int bufferCount, out int bytesTransferred, [In][Out] ref SocketFlags socketFlags, [In] IntPtr socketAddressPointer, [In] IntPtr socketAddressSizePointer, [In] SafeNativeOverlapped overlapped, [In] IntPtr completionRoutine);

		[DllImport("ws2_32.dll", SetLastError = true)]
		internal static extern SocketError WSAEventSelect([In] SafeCloseSocket socketHandle, [In] SafeHandle Event, [In] AsyncEventBits NetworkEvents);

		[DllImport("ws2_32.dll", SetLastError = true)]
		internal static extern SocketError WSAEventSelect([In] SafeCloseSocket socketHandle, [In] IntPtr Event, [In] AsyncEventBits NetworkEvents);

		[DllImport("ws2_32.dll", SetLastError = true)]
		internal static extern SocketError WSAIoctl([In] SafeCloseSocket socketHandle, [In] int ioControlCode, [In][Out] ref Guid guid, [In] int guidSize, out IntPtr funcPtr, [In] int funcPtrSize, out int bytesTransferred, [In] IntPtr shouldBeNull, [In] IntPtr shouldBeNull2);

		[DllImport("ws2_32.dll", EntryPoint = "WSAIoctl", SetLastError = true)]
		internal static extern SocketError WSAIoctl_Blocking([In] IntPtr socketHandle, [In] int ioControlCode, [In] byte[] inBuffer, [In] int inBufferSize, [Out] byte[] outBuffer, [In] int outBufferSize, out int bytesTransferred, [In] SafeHandle overlapped, [In] IntPtr completionRoutine);

		[DllImport("ws2_32.dll", EntryPoint = "WSAIoctl", SetLastError = true)]
		internal static extern SocketError WSAIoctl_Blocking_Internal([In] IntPtr socketHandle, [In] uint ioControlCode, [In] IntPtr inBuffer, [In] int inBufferSize, [Out] IntPtr outBuffer, [In] int outBufferSize, out int bytesTransferred, [In] SafeHandle overlapped, [In] IntPtr completionRoutine);

		[DllImport("ws2_32.dll", SetLastError = true)]
		internal static extern SocketError WSAEnumNetworkEvents([In] SafeCloseSocket socketHandle, [In] SafeWaitHandle Event, [In][Out] ref NetworkEvents networkEvents);

		[DllImport("ws2_32.dll", SetLastError = true)]
		internal unsafe static extern int WSADuplicateSocket([In] SafeCloseSocket socketHandle, [In] uint targetProcessID, [In] byte* pinnedBuffer);

		[DllImport("ws2_32.dll", SetLastError = true)]
		internal static extern bool WSAGetOverlappedResult([In] SafeCloseSocket socketHandle, [In] SafeHandle overlapped, out uint bytesTransferred, [In] bool wait, out SocketFlags socketFlags);

		[DllImport("ws2_32.dll", BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = true, ThrowOnUnmappableChar = false)]
		internal static extern SocketError WSAStringToAddress([In] string addressString, [In] AddressFamily addressFamily, [In] IntPtr lpProtocolInfo, [Out] byte[] socketAddress, [In][Out] ref int socketAddressSize);

		[DllImport("ws2_32.dll", BestFitMapping = false, CharSet = CharSet.Ansi, SetLastError = true, ThrowOnUnmappableChar = true)]
		internal static extern SocketError WSAAddressToString([In] byte[] socketAddress, [In] int socketAddressSize, [In] IntPtr lpProtocolInfo, [Out] StringBuilder addressString, [In][Out] ref int addressStringLength);

		[DllImport("ws2_32.dll", BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = true, ThrowOnUnmappableChar = true)]
		internal static extern SocketError GetNameInfoW([In] byte[] sa, [In] int salen, [In][Out] StringBuilder host, [In] int hostlen, [In][Out] StringBuilder serv, [In] int servlen, [In] int flags);

		[DllImport("ws2_32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		internal static extern int WSAEnumProtocols([In][MarshalAs(UnmanagedType.LPArray)] int[] lpiProtocols, [In] SafeLocalFree lpProtocolBuffer, [In][Out] ref uint lpdwBufferLength);
	}

	[SuppressUnmanagedCodeSecurity]
	internal static class NativePKI
	{
		internal struct CRYPT_OBJID_BLOB
		{
			public uint cbData;

			public IntPtr pbData;
		}

		internal struct CERT_EXTENSION
		{
			public IntPtr pszObjId;

			public uint fCritical;

			public CRYPT_OBJID_BLOB Value;
		}

		internal struct CERT_SELECT_CRITERIA
		{
			public uint dwType;

			public uint cPara;

			public IntPtr ppPara;
		}

		[Flags]
		private enum CertificateSelect
		{
			None = 0,
			AllowExpired = 1,
			TrustedRoot = 2,
			DisallowSelfsigned = 4,
			HasPrivateKey = 8,
			HasKeyForSignature = 0x10,
			HasKeyForKeyExchange = 0x20,
			HardwareOnly = 0x40,
			AllowDuplicates = 0x80
		}

		[DllImport("crypt32.dll", ExactSpelling = true, SetLastError = true)]
		internal static extern int CertVerifyCertificateChainPolicy([In] IntPtr policy, [In] SafeFreeCertChain chainContext, [In] ref ChainPolicyParameter cpp, [In][Out] ref ChainPolicyStatus ps);

		[DllImport("crypt32.dll", ExactSpelling = true, SetLastError = true)]
		private static extern bool CertSelectCertificateChains([In] IntPtr pSelectionContext, [In] CertificateSelect flags, [In] IntPtr pChainParameters, [In] int cCriteria, [In] SafeCertSelectCritera rgpCriteria, [In] IntPtr hStore, out int pcSelection, out SafeFreeCertChainList pprgpSelection);

		[FriendAccessAllowed]
		internal static X509CertificateCollection FindClientCertificates()
		{
			if (!ComNetOS.IsWin7orLater)
			{
				throw new PlatformNotSupportedException();
			}
			X509CertificateCollection x509CertificateCollection = new X509CertificateCollection();
			X509Store x509Store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
			x509Store.Open(OpenFlags.MaxAllowed);
			int pcSelection = 0;
			SafeFreeCertChainList pprgpSelection = null;
			SafeCertSelectCritera safeCertSelectCritera = new SafeCertSelectCritera();
			try
			{
				if (!CertSelectCertificateChains(IntPtr.Zero, CertificateSelect.HasPrivateKey, IntPtr.Zero, safeCertSelectCritera.Count, safeCertSelectCritera, x509Store.StoreHandle, out pcSelection, out pprgpSelection))
				{
					throw new Win32Exception();
				}
				for (int i = 0; i < pcSelection; i++)
				{
					using SafeFreeCertChain safeFreeCertChain = new SafeFreeCertChain(Marshal.ReadIntPtr(pprgpSelection.DangerousGetHandle() + i * Marshal.SizeOf(typeof(IntPtr))), ownsHandle: true);
					X509Chain x509Chain = new X509Chain(safeFreeCertChain.DangerousGetHandle());
					if (x509Chain.ChainElements.Count > 0)
					{
						X509Certificate2 certificate = x509Chain.ChainElements[0].Certificate;
						x509CertificateCollection.Add(certificate);
					}
					x509Chain.Reset();
				}
				return x509CertificateCollection;
			}
			finally
			{
				x509Store.Close();
				pprgpSelection.Dispose();
				safeCertSelectCritera.Dispose();
			}
		}
	}

	[SuppressUnmanagedCodeSecurity]
	internal static class NativeNTSSPI
	{
		[DllImport("secur32.dll", ExactSpelling = true, SetLastError = true)]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		internal static extern int EncryptMessage(ref SSPIHandle contextHandle, [In] uint qualityOfProtection, [In][Out] SecurityBufferDescriptor inputOutput, [In] uint sequenceNumber);

		[DllImport("secur32.dll", ExactSpelling = true, SetLastError = true)]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		internal unsafe static extern int DecryptMessage([In] ref SSPIHandle contextHandle, [In][Out] SecurityBufferDescriptor inputOutput, [In] uint sequenceNumber, uint* qualityOfProtection);
	}

	[SuppressUnmanagedCodeSecurity]
	internal static class WinHttp
	{
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		internal struct WINHTTP_CURRENT_USER_IE_PROXY_CONFIG
		{
			public bool AutoDetect;

			public IntPtr AutoConfigUrl;

			public IntPtr Proxy;

			public IntPtr ProxyBypass;
		}

		[Flags]
		internal enum AutoProxyFlags
		{
			AutoDetect = 1,
			AutoProxyConfigUrl = 2,
			RunInProcess = 0x10000,
			RunOutProcessOnly = 0x20000
		}

		internal enum AccessType
		{
			DefaultProxy = 0,
			NoProxy = 1,
			NamedProxy = 3
		}

		[Flags]
		internal enum AutoDetectType
		{
			None = 0,
			Dhcp = 1,
			DnsA = 2
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		internal struct WINHTTP_AUTOPROXY_OPTIONS
		{
			public AutoProxyFlags Flags;

			public AutoDetectType AutoDetectFlags;

			[MarshalAs(UnmanagedType.LPWStr)]
			public string AutoConfigUrl;

			private IntPtr lpvReserved;

			private int dwReserved;

			public bool AutoLogonIfChallenged;
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		internal struct WINHTTP_PROXY_INFO
		{
			public AccessType AccessType;

			public IntPtr Proxy;

			public IntPtr ProxyBypass;
		}

		internal enum ErrorCodes
		{
			Success = 0,
			OutOfHandles = 12001,
			Timeout = 12002,
			InternalError = 12004,
			InvalidUrl = 12005,
			UnrecognizedScheme = 12006,
			NameNotResolved = 12007,
			InvalidOption = 12009,
			OptionNotSettable = 12011,
			Shutdown = 12012,
			LoginFailure = 12015,
			OperationCancelled = 12017,
			IncorrectHandleType = 12018,
			IncorrectHandleState = 12019,
			CannotConnect = 12029,
			ConnectionError = 12030,
			ResendRequest = 12032,
			AuthCertNeeded = 12044,
			CannotCallBeforeOpen = 12100,
			CannotCallBeforeSend = 12101,
			CannotCallAfterSend = 12102,
			CannotCallAfterOpen = 12103,
			HeaderNotFound = 12150,
			InvalidServerResponse = 12152,
			InvalidHeader = 12153,
			InvalidQueryRequest = 12154,
			HeaderAlreadyExists = 12155,
			RedirectFailed = 12156,
			AutoProxyServiceError = 12178,
			BadAutoProxyScript = 12166,
			UnableToDownloadScript = 12167,
			NotInitialized = 12172,
			SecureFailure = 12175,
			SecureCertDateInvalid = 12037,
			SecureCertCNInvalid = 12038,
			SecureInvalidCA = 12045,
			SecureCertRevFailed = 12057,
			SecureChannelError = 12157,
			SecureInvalidCert = 12169,
			SecureCertRevoked = 12170,
			SecureCertWrongUsage = 12179,
			AudodetectionFailed = 12180,
			HeaderCountExceeded = 12181,
			HeaderSizeOverflow = 12182,
			ChunkedEncodingHeaderSizeOverflow = 12183,
			ResponseDrainOverflow = 12184,
			ClientCertNoPrivateKey = 12185,
			ClientCertNoAccessPrivateKey = 12186
		}

		[DllImport("winhttp.dll", ExactSpelling = true, SetLastError = true)]
		internal static extern bool WinHttpDetectAutoProxyConfigUrl(AutoDetectType autoDetectFlags, out SafeGlobalFree autoConfigUrl);

		[DllImport("winhttp.dll", SetLastError = true)]
		internal static extern bool WinHttpGetIEProxyConfigForCurrentUser(ref WINHTTP_CURRENT_USER_IE_PROXY_CONFIG proxyConfig);

		[DllImport("winhttp.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		internal static extern SafeInternetHandle WinHttpOpen(string userAgent, AccessType accessType, string proxyName, string proxyBypass, int dwFlags);

		[DllImport("winhttp.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		internal static extern bool WinHttpSetTimeouts(SafeInternetHandle session, int resolveTimeout, int connectTimeout, int sendTimeout, int receiveTimeout);

		[DllImport("winhttp.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		internal static extern bool WinHttpGetProxyForUrl(SafeInternetHandle session, string url, [In] ref WINHTTP_AUTOPROXY_OPTIONS autoProxyOptions, out WINHTTP_PROXY_INFO proxyInfo);

		[DllImport("winhttp.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		internal static extern bool WinHttpCloseHandle(IntPtr httpSession);
	}

	[SuppressUnmanagedCodeSecurity]
	internal static class UnsafeWinInetCache
	{
		public const int MAX_PATH = 260;

		[DllImport("wininet.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
		internal static extern bool CreateUrlCacheEntryW([In] string urlName, [In] int expectedFileSize, [In] string fileExtension, [Out] StringBuilder fileName, [In] int dwReserved);

		[DllImport("wininet.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
		internal unsafe static extern bool CommitUrlCacheEntryW([In] string urlName, [In] string localFileName, [In] _WinInetCache.FILETIME expireTime, [In] _WinInetCache.FILETIME lastModifiedTime, [In] _WinInetCache.EntryType EntryType, [In] byte* headerInfo, [In] int headerSizeTChars, [In] string fileExtension, [In] string originalUrl);

		[DllImport("wininet.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
		internal unsafe static extern bool GetUrlCacheEntryInfoW([In] string urlName, [In] byte* entryPtr, [In][Out] ref int bufferSz);

		[DllImport("wininet.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
		internal unsafe static extern bool SetUrlCacheEntryInfoW([In] string lpszUrlName, [In] byte* EntryPtr, [In] _WinInetCache.Entry_FC fieldControl);

		[DllImport("wininet.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
		internal static extern bool DeleteUrlCacheEntryW([In] string urlName);

		[DllImport("wininet.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
		internal static extern bool UnlockUrlCacheEntryFileW([In] string urlName, [In] int dwReserved);
	}

	[SuppressUnmanagedCodeSecurity]
	internal static class SspiHelper
	{
		[DllImport("secur32.dll", ExactSpelling = true, SetLastError = true)]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		internal static extern SecurityStatus SspiFreeAuthIdentity([In] IntPtr authData);

		[DllImport("secur32.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
		internal static extern SecurityStatus SspiEncodeStringsAsAuthIdentity([In] string userName, [In] string domainName, [In] string password, out SafeSspiAuthDataHandle authData);
	}

	[SuppressUnmanagedCodeSecurity]
	internal static class HttpApi
	{
		internal sealed class HeapAllocHandle : SafeHandleZeroOrMinusOneIsInvalid
		{
			private static readonly IntPtr ProcessHeap = GetProcessHeap();

			private HeapAllocHandle()
				: base(ownsHandle: true)
			{
			}

			protected override bool ReleaseHandle()
			{
				return HeapFree(ProcessHeap, 0u, handle);
			}
		}

		internal enum HTTP_API_VERSION
		{
			Invalid,
			Version10,
			Version20
		}

		internal enum HTTP_SERVER_PROPERTY
		{
			HttpServerAuthenticationProperty,
			HttpServerLoggingProperty,
			HttpServerQosProperty,
			HttpServerTimeoutsProperty,
			HttpServerQueueLengthProperty,
			HttpServerStateProperty,
			HttpServer503VerbosityProperty,
			HttpServerBindingProperty,
			HttpServerExtendedAuthenticationProperty,
			HttpServerListenEndpointProperty,
			HttpServerChannelBindProperty,
			HttpServerProtectionLevelProperty
		}

		internal enum HTTP_REQUEST_INFO_TYPE
		{
			HttpRequestInfoTypeAuth,
			HttpRequestInfoTypeChannelBind,
			HttpRequestInfoTypeSslProtocol,
			HttpRequestInfoTypeSslTokenBindingDraft,
			HttpRequestInfoTypeSslTokenBinding
		}

		internal enum HTTP_RESPONSE_INFO_TYPE
		{
			HttpResponseInfoTypeMultipleKnownHeaders,
			HttpResponseInfoTypeAuthenticationProperty,
			HttpResponseInfoTypeQosProperty
		}

		internal enum HTTP_TIMEOUT_TYPE
		{
			EntityBody,
			DrainEntityBody,
			RequestQueue,
			IdleConnection,
			HeaderWait,
			MinSendRate
		}

		internal struct HTTP_VERSION
		{
			internal ushort MajorVersion;

			internal ushort MinorVersion;
		}

		internal struct HTTP_KNOWN_HEADER
		{
			internal ushort RawValueLength;

			internal unsafe sbyte* pRawValue;
		}

		[StructLayout(LayoutKind.Sequential, Size = 32)]
		internal struct HTTP_DATA_CHUNK
		{
			internal HTTP_DATA_CHUNK_TYPE DataChunkType;

			internal uint p0;

			internal unsafe byte* pBuffer;

			internal uint BufferLength;
		}

		internal struct HTTPAPI_VERSION
		{
			internal ushort HttpApiMajorVersion;

			internal ushort HttpApiMinorVersion;
		}

		internal struct HTTP_COOKED_URL
		{
			internal ushort FullUrlLength;

			internal ushort HostLength;

			internal ushort AbsPathLength;

			internal ushort QueryStringLength;

			internal unsafe ushort* pFullUrl;

			internal unsafe ushort* pHost;

			internal unsafe ushort* pAbsPath;

			internal unsafe ushort* pQueryString;
		}

		internal struct SOCKADDR
		{
			internal ushort sa_family;

			internal byte sa_data;

			internal byte sa_data_02;

			internal byte sa_data_03;

			internal byte sa_data_04;

			internal byte sa_data_05;

			internal byte sa_data_06;

			internal byte sa_data_07;

			internal byte sa_data_08;

			internal byte sa_data_09;

			internal byte sa_data_10;

			internal byte sa_data_11;

			internal byte sa_data_12;

			internal byte sa_data_13;

			internal byte sa_data_14;
		}

		internal struct HTTP_TRANSPORT_ADDRESS
		{
			internal unsafe SOCKADDR* pRemoteAddress;

			internal unsafe SOCKADDR* pLocalAddress;
		}

		internal struct HTTP_SSL_CLIENT_CERT_INFO
		{
			internal uint CertFlags;

			internal uint CertEncodedSize;

			internal unsafe byte* pCertEncoded;

			internal unsafe void* Token;

			internal byte CertDeniedByMapper;
		}

		internal enum HTTP_SERVICE_BINDING_TYPE : uint
		{
			HttpServiceBindingTypeNone,
			HttpServiceBindingTypeW,
			HttpServiceBindingTypeA
		}

		internal struct HTTP_SERVICE_BINDING_BASE
		{
			internal HTTP_SERVICE_BINDING_TYPE Type;
		}

		internal struct HTTP_REQUEST_CHANNEL_BIND_STATUS
		{
			internal IntPtr ServiceName;

			internal IntPtr ChannelToken;

			internal uint ChannelTokenSize;

			internal uint Flags;
		}

		internal struct HTTP_UNKNOWN_HEADER
		{
			internal ushort NameLength;

			internal ushort RawValueLength;

			internal unsafe sbyte* pName;

			internal unsafe sbyte* pRawValue;
		}

		internal struct HTTP_SSL_INFO
		{
			internal ushort ServerCertKeySize;

			internal ushort ConnectionKeySize;

			internal uint ServerCertIssuerSize;

			internal uint ServerCertSubjectSize;

			internal unsafe sbyte* pServerCertIssuer;

			internal unsafe sbyte* pServerCertSubject;

			internal unsafe HTTP_SSL_CLIENT_CERT_INFO* pClientCertInfo;

			internal uint SslClientCertNegotiated;
		}

		internal struct HTTP_RESPONSE_HEADERS
		{
			internal ushort UnknownHeaderCount;

			internal unsafe HTTP_UNKNOWN_HEADER* pUnknownHeaders;

			internal ushort TrailerCount;

			internal unsafe HTTP_UNKNOWN_HEADER* pTrailers;

			internal HTTP_KNOWN_HEADER KnownHeaders;

			internal HTTP_KNOWN_HEADER KnownHeaders_02;

			internal HTTP_KNOWN_HEADER KnownHeaders_03;

			internal HTTP_KNOWN_HEADER KnownHeaders_04;

			internal HTTP_KNOWN_HEADER KnownHeaders_05;

			internal HTTP_KNOWN_HEADER KnownHeaders_06;

			internal HTTP_KNOWN_HEADER KnownHeaders_07;

			internal HTTP_KNOWN_HEADER KnownHeaders_08;

			internal HTTP_KNOWN_HEADER KnownHeaders_09;

			internal HTTP_KNOWN_HEADER KnownHeaders_10;

			internal HTTP_KNOWN_HEADER KnownHeaders_11;

			internal HTTP_KNOWN_HEADER KnownHeaders_12;

			internal HTTP_KNOWN_HEADER KnownHeaders_13;

			internal HTTP_KNOWN_HEADER KnownHeaders_14;

			internal HTTP_KNOWN_HEADER KnownHeaders_15;

			internal HTTP_KNOWN_HEADER KnownHeaders_16;

			internal HTTP_KNOWN_HEADER KnownHeaders_17;

			internal HTTP_KNOWN_HEADER KnownHeaders_18;

			internal HTTP_KNOWN_HEADER KnownHeaders_19;

			internal HTTP_KNOWN_HEADER KnownHeaders_20;

			internal HTTP_KNOWN_HEADER KnownHeaders_21;

			internal HTTP_KNOWN_HEADER KnownHeaders_22;

			internal HTTP_KNOWN_HEADER KnownHeaders_23;

			internal HTTP_KNOWN_HEADER KnownHeaders_24;

			internal HTTP_KNOWN_HEADER KnownHeaders_25;

			internal HTTP_KNOWN_HEADER KnownHeaders_26;

			internal HTTP_KNOWN_HEADER KnownHeaders_27;

			internal HTTP_KNOWN_HEADER KnownHeaders_28;

			internal HTTP_KNOWN_HEADER KnownHeaders_29;

			internal HTTP_KNOWN_HEADER KnownHeaders_30;
		}

		internal struct HTTP_REQUEST_HEADERS
		{
			internal ushort UnknownHeaderCount;

			internal unsafe HTTP_UNKNOWN_HEADER* pUnknownHeaders;

			internal ushort TrailerCount;

			internal unsafe HTTP_UNKNOWN_HEADER* pTrailers;

			internal HTTP_KNOWN_HEADER KnownHeaders;

			internal HTTP_KNOWN_HEADER KnownHeaders_02;

			internal HTTP_KNOWN_HEADER KnownHeaders_03;

			internal HTTP_KNOWN_HEADER KnownHeaders_04;

			internal HTTP_KNOWN_HEADER KnownHeaders_05;

			internal HTTP_KNOWN_HEADER KnownHeaders_06;

			internal HTTP_KNOWN_HEADER KnownHeaders_07;

			internal HTTP_KNOWN_HEADER KnownHeaders_08;

			internal HTTP_KNOWN_HEADER KnownHeaders_09;

			internal HTTP_KNOWN_HEADER KnownHeaders_10;

			internal HTTP_KNOWN_HEADER KnownHeaders_11;

			internal HTTP_KNOWN_HEADER KnownHeaders_12;

			internal HTTP_KNOWN_HEADER KnownHeaders_13;

			internal HTTP_KNOWN_HEADER KnownHeaders_14;

			internal HTTP_KNOWN_HEADER KnownHeaders_15;

			internal HTTP_KNOWN_HEADER KnownHeaders_16;

			internal HTTP_KNOWN_HEADER KnownHeaders_17;

			internal HTTP_KNOWN_HEADER KnownHeaders_18;

			internal HTTP_KNOWN_HEADER KnownHeaders_19;

			internal HTTP_KNOWN_HEADER KnownHeaders_20;

			internal HTTP_KNOWN_HEADER KnownHeaders_21;

			internal HTTP_KNOWN_HEADER KnownHeaders_22;

			internal HTTP_KNOWN_HEADER KnownHeaders_23;

			internal HTTP_KNOWN_HEADER KnownHeaders_24;

			internal HTTP_KNOWN_HEADER KnownHeaders_25;

			internal HTTP_KNOWN_HEADER KnownHeaders_26;

			internal HTTP_KNOWN_HEADER KnownHeaders_27;

			internal HTTP_KNOWN_HEADER KnownHeaders_28;

			internal HTTP_KNOWN_HEADER KnownHeaders_29;

			internal HTTP_KNOWN_HEADER KnownHeaders_30;

			internal HTTP_KNOWN_HEADER KnownHeaders_31;

			internal HTTP_KNOWN_HEADER KnownHeaders_32;

			internal HTTP_KNOWN_HEADER KnownHeaders_33;

			internal HTTP_KNOWN_HEADER KnownHeaders_34;

			internal HTTP_KNOWN_HEADER KnownHeaders_35;

			internal HTTP_KNOWN_HEADER KnownHeaders_36;

			internal HTTP_KNOWN_HEADER KnownHeaders_37;

			internal HTTP_KNOWN_HEADER KnownHeaders_38;

			internal HTTP_KNOWN_HEADER KnownHeaders_39;

			internal HTTP_KNOWN_HEADER KnownHeaders_40;

			internal HTTP_KNOWN_HEADER KnownHeaders_41;
		}

		internal enum HTTP_VERB
		{
			HttpVerbUnparsed,
			HttpVerbUnknown,
			HttpVerbInvalid,
			HttpVerbOPTIONS,
			HttpVerbGET,
			HttpVerbHEAD,
			HttpVerbPOST,
			HttpVerbPUT,
			HttpVerbDELETE,
			HttpVerbTRACE,
			HttpVerbCONNECT,
			HttpVerbTRACK,
			HttpVerbMOVE,
			HttpVerbCOPY,
			HttpVerbPROPFIND,
			HttpVerbPROPPATCH,
			HttpVerbMKCOL,
			HttpVerbLOCK,
			HttpVerbUNLOCK,
			HttpVerbSEARCH,
			HttpVerbMaximum
		}

		internal enum HTTP_DATA_CHUNK_TYPE
		{
			HttpDataChunkFromMemory,
			HttpDataChunkFromFileHandle,
			HttpDataChunkFromFragmentCache,
			HttpDataChunkMaximum
		}

		internal struct HTTP_RESPONSE_INFO
		{
			internal HTTP_RESPONSE_INFO_TYPE Type;

			internal uint Length;

			internal unsafe void* pInfo;
		}

		internal struct HTTP_RESPONSE
		{
			internal uint Flags;

			internal HTTP_VERSION Version;

			internal ushort StatusCode;

			internal ushort ReasonLength;

			internal unsafe sbyte* pReason;

			internal HTTP_RESPONSE_HEADERS Headers;

			internal ushort EntityChunkCount;

			internal unsafe HTTP_DATA_CHUNK* pEntityChunks;

			internal ushort ResponseInfoCount;

			internal unsafe HTTP_RESPONSE_INFO* pResponseInfo;
		}

		internal struct HTTP_REQUEST_INFO
		{
			internal HTTP_REQUEST_INFO_TYPE InfoType;

			internal uint InfoLength;

			internal unsafe void* pInfo;
		}

		internal struct HTTP_REQUEST
		{
			internal uint Flags;

			internal ulong ConnectionId;

			internal ulong RequestId;

			internal ulong UrlContext;

			internal HTTP_VERSION Version;

			internal HTTP_VERB Verb;

			internal ushort UnknownVerbLength;

			internal ushort RawUrlLength;

			internal unsafe sbyte* pUnknownVerb;

			internal unsafe sbyte* pRawUrl;

			internal HTTP_COOKED_URL CookedUrl;

			internal HTTP_TRANSPORT_ADDRESS Address;

			internal HTTP_REQUEST_HEADERS Headers;

			internal ulong BytesReceived;

			internal ushort EntityChunkCount;

			internal unsafe HTTP_DATA_CHUNK* pEntityChunks;

			internal ulong RawConnectionId;

			internal unsafe HTTP_SSL_INFO* pSslInfo;
		}

		internal struct HTTP_REQUEST_V2
		{
			internal HTTP_REQUEST RequestV1;

			internal ushort RequestInfoCount;

			internal unsafe HTTP_REQUEST_INFO* pRequestInfo;
		}

		internal struct HTTP_TIMEOUT_LIMIT_INFO
		{
			internal HTTP_FLAGS Flags;

			internal ushort EntityBody;

			internal ushort DrainEntityBody;

			internal ushort RequestQueue;

			internal ushort IdleConnection;

			internal ushort HeaderWait;

			internal uint MinSendRate;
		}

		internal struct HTTP_BINDING_INFO
		{
			internal HTTP_FLAGS Flags;

			internal IntPtr RequestQueueHandle;
		}

		internal struct HTTP_REQUEST_TOKEN_BINDING_INFO
		{
			public unsafe byte* TokenBinding;

			public uint TokenBindingSize;

			public unsafe byte* TlsUnique;

			public uint TlsUniqueSize;

			public TOKENBINDING_KEY_PARAMETERS_TYPE KeyType;
		}

		internal struct HTTP_REQUEST_TOKEN_BINDING_INFO_V1
		{
			public unsafe byte* TokenBinding;

			public uint TokenBindingSize;

			public unsafe byte* TlsUnique;

			public uint TlsUniqueSize;

			public IntPtr KeyType;
		}

		internal enum TOKENBINDING_HASH_ALGORITHM_V1 : byte
		{
			TOKENBINDING_HASH_ALGORITHM_SHA256 = 4
		}

		internal enum TOKENBINDING_SIGNATURE_ALGORITHM_V1 : byte
		{
			TOKENBINDING_SIGNATURE_ALGORITHM_RSA = 1,
			TOKENBINDING_SIGNATURE_ALGORITHM_ECDSAP256 = 3
		}

		internal enum TOKENBINDING_TYPE : byte
		{
			TOKENBINDING_TYPE_PROVIDED,
			TOKENBINDING_TYPE_REFERRED
		}

		internal enum TOKENBINDING_EXTENSION_FORMAT
		{
			TOKENBINDING_EXTENSION_FORMAT_UNDEFINED
		}

		internal enum TOKENBINDING_KEY_PARAMETERS_TYPE : byte
		{
			TOKENBINDING_KEY_PARAMETERS_TYPE_RSA_PKCS_SHA256,
			TOKENBINDING_KEY_PARAMETERS_TYPE_RSA_PSS_SHA256,
			TOKENBINDING_KEY_PARAMETERS_TYPE_ECDSA_SHA256
		}

		internal struct TOKENBINDING_IDENTIFIER
		{
			public TOKENBINDING_KEY_PARAMETERS_TYPE keyType;
		}

		internal struct TOKENBINDING_IDENTIFIER_V1
		{
			public TOKENBINDING_TYPE bindingType;

			public TOKENBINDING_HASH_ALGORITHM_V1 hashAlgorithm;

			public TOKENBINDING_SIGNATURE_ALGORITHM_V1 signatureAlgorithm;
		}

		internal struct TOKENBINDING_RESULT_DATA
		{
			public TOKENBINDING_TYPE bindingType;

			public uint identifierSize;

			public unsafe TOKENBINDING_IDENTIFIER* identifierData;

			public TOKENBINDING_EXTENSION_FORMAT extensionFormat;

			public uint extensionSize;

			public IntPtr extensionData;
		}

		internal struct TOKENBINDING_RESULT_DATA_V1
		{
			public uint identifierSize;

			public unsafe TOKENBINDING_IDENTIFIER_V1* identifierData;

			public TOKENBINDING_EXTENSION_FORMAT extensionFormat;

			public uint extensionSize;

			public IntPtr extensionData;
		}

		internal struct TOKENBINDING_RESULT_LIST
		{
			public uint resultCount;

			public unsafe TOKENBINDING_RESULT_DATA* resultData;
		}

		internal struct TOKENBINDING_RESULT_LIST_V1
		{
			public uint resultCount;

			public unsafe TOKENBINDING_RESULT_DATA_V1* resultData;
		}

		[Flags]
		internal enum HTTP_FLAGS : uint
		{
			NONE = 0u,
			HTTP_RECEIVE_REQUEST_FLAG_COPY_BODY = 1u,
			HTTP_RECEIVE_SECURE_CHANNEL_TOKEN = 1u,
			HTTP_SEND_RESPONSE_FLAG_DISCONNECT = 1u,
			HTTP_SEND_RESPONSE_FLAG_MORE_DATA = 2u,
			HTTP_SEND_RESPONSE_FLAG_BUFFER_DATA = 4u,
			HTTP_SEND_RESPONSE_FLAG_RAW_HEADER = 4u,
			HTTP_SEND_REQUEST_FLAG_MORE_DATA = 1u,
			HTTP_PROPERTY_FLAG_PRESENT = 1u,
			HTTP_INITIALIZE_SERVER = 1u,
			HTTP_INITIALIZE_CBT = 4u,
			HTTP_SEND_RESPONSE_FLAG_OPAQUE = 0x40u
		}

		internal static class HTTP_REQUEST_HEADER_ID
		{
			private static string[] m_Strings = new string[41]
			{
				"Cache-Control", "Connection", "Date", "Keep-Alive", "Pragma", "Trailer", "Transfer-Encoding", "Upgrade", "Via", "Warning",
				"Allow", "Content-Length", "Content-Type", "Content-Encoding", "Content-Language", "Content-Location", "Content-MD5", "Content-Range", "Expires", "Last-Modified",
				"Accept", "Accept-Charset", "Accept-Encoding", "Accept-Language", "Authorization", "Cookie", "Expect", "From", "Host", "If-Match",
				"If-Modified-Since", "If-None-Match", "If-Range", "If-Unmodified-Since", "Max-Forwards", "Proxy-Authorization", "Referer", "Range", "Te", "Translate",
				"User-Agent"
			};

			internal static string ToString(int position)
			{
				return m_Strings[position];
			}
		}

		internal static class HTTP_RESPONSE_HEADER_ID
		{
			internal enum Enum
			{
				HttpHeaderCacheControl = 0,
				HttpHeaderConnection = 1,
				HttpHeaderDate = 2,
				HttpHeaderKeepAlive = 3,
				HttpHeaderPragma = 4,
				HttpHeaderTrailer = 5,
				HttpHeaderTransferEncoding = 6,
				HttpHeaderUpgrade = 7,
				HttpHeaderVia = 8,
				HttpHeaderWarning = 9,
				HttpHeaderAllow = 10,
				HttpHeaderContentLength = 11,
				HttpHeaderContentType = 12,
				HttpHeaderContentEncoding = 13,
				HttpHeaderContentLanguage = 14,
				HttpHeaderContentLocation = 15,
				HttpHeaderContentMd5 = 16,
				HttpHeaderContentRange = 17,
				HttpHeaderExpires = 18,
				HttpHeaderLastModified = 19,
				HttpHeaderAcceptRanges = 20,
				HttpHeaderAge = 21,
				HttpHeaderEtag = 22,
				HttpHeaderLocation = 23,
				HttpHeaderProxyAuthenticate = 24,
				HttpHeaderRetryAfter = 25,
				HttpHeaderServer = 26,
				HttpHeaderSetCookie = 27,
				HttpHeaderVary = 28,
				HttpHeaderWwwAuthenticate = 29,
				HttpHeaderResponseMaximum = 30,
				HttpHeaderMaximum = 41
			}

			private static Hashtable m_Hashtable;

			private static string[] m_Strings;

			static HTTP_RESPONSE_HEADER_ID()
			{
				m_Strings = new string[30]
				{
					"Cache-Control", "Connection", "Date", "Keep-Alive", "Pragma", "Trailer", "Transfer-Encoding", "Upgrade", "Via", "Warning",
					"Allow", "Content-Length", "Content-Type", "Content-Encoding", "Content-Language", "Content-Location", "Content-MD5", "Content-Range", "Expires", "Last-Modified",
					"Accept-Ranges", "Age", "ETag", "Location", "Proxy-Authenticate", "Retry-After", "Server", "Set-Cookie", "Vary", "WWW-Authenticate"
				};
				m_Hashtable = new Hashtable(30);
				for (int i = 0; i < 30; i++)
				{
					m_Hashtable.Add(m_Strings[i], i);
				}
			}

			internal static int IndexOfKnownHeader(string HeaderName)
			{
				object obj = m_Hashtable[HeaderName];
				if (obj != null)
				{
					return (int)obj;
				}
				return -1;
			}

			internal static string ToString(int position)
			{
				return m_Strings[position];
			}
		}

		internal const int MaxTimeout = 6;

		internal static readonly string[] HttpVerbs;

		private const int HttpHeaderRequestMaximum = 41;

		private const int HttpHeaderResponseMaximum = 30;

		private static HTTPAPI_VERSION version;

		private static volatile bool extendedProtectionSupported;

		private static volatile bool supported;

		internal static HTTPAPI_VERSION Version => version;

		internal static HTTP_API_VERSION ApiVersion
		{
			get
			{
				if (version.HttpApiMajorVersion == 2 && version.HttpApiMinorVersion == 0)
				{
					return HTTP_API_VERSION.Version20;
				}
				if (version.HttpApiMajorVersion == 1 && version.HttpApiMinorVersion == 0)
				{
					return HTTP_API_VERSION.Version10;
				}
				return HTTP_API_VERSION.Invalid;
			}
		}

		internal static bool ExtendedProtectionSupported => extendedProtectionSupported;

		internal static bool Supported => supported;

		[DllImport("httpapi.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
		internal unsafe static extern uint HttpInitialize(HTTPAPI_VERSION version, uint flags, void* pReserved);

		[DllImport("httpapi.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
		internal unsafe static extern uint HttpReceiveRequestEntityBody(CriticalHandle requestQueueHandle, ulong requestId, uint flags, void* pEntityBuffer, uint entityBufferLength, out uint bytesReturned, NativeOverlapped* pOverlapped);

		[DllImport("httpapi.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "HttpReceiveRequestEntityBody", ExactSpelling = true, SetLastError = true)]
		internal unsafe static extern uint HttpReceiveRequestEntityBody2(CriticalHandle requestQueueHandle, ulong requestId, uint flags, void* pEntityBuffer, uint entityBufferLength, out uint bytesReturned, [In] SafeHandle pOverlapped);

		[DllImport("httpapi.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
		internal unsafe static extern uint HttpReceiveClientCertificate(CriticalHandle requestQueueHandle, ulong connectionId, uint flags, HTTP_SSL_CLIENT_CERT_INFO* pSslClientCertInfo, uint sslClientCertInfoSize, uint* pBytesReceived, NativeOverlapped* pOverlapped);

		[DllImport("httpapi.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
		internal unsafe static extern uint HttpReceiveClientCertificate(CriticalHandle requestQueueHandle, ulong connectionId, uint flags, byte* pSslClientCertInfo, uint sslClientCertInfoSize, uint* pBytesReceived, NativeOverlapped* pOverlapped);

		[DllImport("httpapi.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
		internal unsafe static extern uint HttpReceiveHttpRequest(CriticalHandle requestQueueHandle, ulong requestId, uint flags, HTTP_REQUEST* pRequestBuffer, uint requestBufferLength, uint* pBytesReturned, NativeOverlapped* pOverlapped);

		[DllImport("httpapi.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
		internal unsafe static extern uint HttpSendHttpResponse(CriticalHandle requestQueueHandle, ulong requestId, uint flags, HTTP_RESPONSE* pHttpResponse, void* pCachePolicy, uint* pBytesSent, SafeLocalFree pRequestBuffer, uint requestBufferLength, NativeOverlapped* pOverlapped, void* pLogData);

		[DllImport("httpapi.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
		internal unsafe static extern uint HttpSendResponseEntityBody(CriticalHandle requestQueueHandle, ulong requestId, uint flags, ushort entityChunkCount, HTTP_DATA_CHUNK* pEntityChunks, uint* pBytesSent, SafeLocalFree pRequestBuffer, uint requestBufferLength, NativeOverlapped* pOverlapped, void* pLogData);

		[DllImport("httpapi.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
		internal static extern uint HttpCancelHttpRequest(CriticalHandle requestQueueHandle, ulong requestId, IntPtr pOverlapped);

		[DllImport("httpapi.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "HttpSendResponseEntityBody", ExactSpelling = true, SetLastError = true)]
		internal static extern uint HttpSendResponseEntityBody2(CriticalHandle requestQueueHandle, ulong requestId, uint flags, ushort entityChunkCount, IntPtr pEntityChunks, out uint pBytesSent, SafeLocalFree pRequestBuffer, uint requestBufferLength, SafeHandle pOverlapped, IntPtr pLogData);

		[DllImport("httpapi.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
		internal unsafe static extern uint HttpWaitForDisconnect(CriticalHandle requestQueueHandle, ulong connectionId, NativeOverlapped* pOverlapped);

		[DllImport("httpapi.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
		internal unsafe static extern uint HttpCreateServerSession(HTTPAPI_VERSION version, ulong* serverSessionId, uint reserved);

		[DllImport("httpapi.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
		internal unsafe static extern uint HttpCreateUrlGroup(ulong serverSessionId, ulong* urlGroupId, uint reserved);

		[DllImport("httpapi.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
		internal static extern uint HttpAddUrlToUrlGroup(ulong urlGroupId, string pFullyQualifiedUrl, ulong context, uint pReserved);

		[DllImport("httpapi.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
		internal static extern uint HttpSetUrlGroupProperty(ulong urlGroupId, HTTP_SERVER_PROPERTY serverProperty, IntPtr pPropertyInfo, uint propertyInfoLength);

		[DllImport("httpapi.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
		internal static extern uint HttpRemoveUrlFromUrlGroup(ulong urlGroupId, string pFullyQualifiedUrl, uint flags);

		[DllImport("httpapi.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
		internal static extern uint HttpCloseServerSession(ulong serverSessionId);

		[DllImport("httpapi.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
		internal static extern uint HttpCloseUrlGroup(ulong urlGroupId);

		[DllImport("tokenbinding.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
		public unsafe static extern int TokenBindingVerifyMessage([In] byte* tokenBindingMessage, [In] uint tokenBindingMessageSize, [In] TOKENBINDING_KEY_PARAMETERS_TYPE keyType, [In] byte* tlsUnique, [In] uint tlsUniqueSize, out HeapAllocHandle resultList);

		[DllImport("tokenbinding.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, EntryPoint = "TokenBindingVerifyMessage")]
		public unsafe static extern int TokenBindingVerifyMessage_V1([In] byte* tokenBindingMessage, [In] uint tokenBindingMessageSize, [In] IntPtr keyType, [In] byte* tlsUnique, [In] uint tlsUniqueSize, out HeapAllocHandle resultList);

		static HttpApi()
		{
			HttpVerbs = new string[20]
			{
				null, "Unknown", "Invalid", "OPTIONS", "GET", "HEAD", "POST", "PUT", "DELETE", "TRACE",
				"CONNECT", "TRACK", "MOVE", "COPY", "PROPFIND", "PROPPATCH", "MKCOL", "LOCK", "UNLOCK", "SEARCH"
			};
			InitHttpApi(2, 0);
		}

		private unsafe static void InitHttpApi(ushort majorVersion, ushort minorVersion)
		{
			version.HttpApiMajorVersion = majorVersion;
			version.HttpApiMinorVersion = minorVersion;
			uint num = 0u;
			extendedProtectionSupported = true;
			if (ComNetOS.IsWin7orLater)
			{
				num = HttpInitialize(version, 1u, null);
			}
			else
			{
				num = HttpInitialize(version, 5u, null);
				if (num == 87)
				{
					if (Logging.On)
					{
						Logging.PrintWarning(Logging.HttpListener, SR.GetString("net_listener_cbt_not_supported"));
					}
					extendedProtectionSupported = false;
					num = HttpInitialize(version, 1u, null);
				}
			}
			supported = num == 0;
		}

		internal unsafe static WebHeaderCollection GetHeaders(byte[] memoryBlob, IntPtr originalAddress)
		{
			WebHeaderCollection webHeaderCollection = new WebHeaderCollection(WebHeaderCollectionType.HttpListenerRequest);
			fixed (byte* ptr = memoryBlob)
			{
				HTTP_REQUEST* ptr2 = (HTTP_REQUEST*)ptr;
				long num = ptr - (byte*)(void*)originalAddress;
				if (ptr2->Headers.UnknownHeaderCount != 0)
				{
					HTTP_UNKNOWN_HEADER* ptr3 = (HTTP_UNKNOWN_HEADER*)(num + (byte*)ptr2->Headers.pUnknownHeaders);
					for (int i = 0; i < ptr2->Headers.UnknownHeaderCount; i++)
					{
						if (ptr3->pName != null && ptr3->NameLength > 0)
						{
							string name = new string(ptr3->pName + num, 0, ptr3->NameLength);
							string value = ((ptr3->pRawValue == null || ptr3->RawValueLength <= 0) ? string.Empty : new string(ptr3->pRawValue + num, 0, ptr3->RawValueLength));
							webHeaderCollection.AddInternal(name, value);
						}
						ptr3++;
					}
				}
				HTTP_KNOWN_HEADER* ptr4 = &ptr2->Headers.KnownHeaders;
				for (int i = 0; i < 41; i++)
				{
					if (ptr4->pRawValue != null)
					{
						string value2 = new string(ptr4->pRawValue + num, 0, ptr4->RawValueLength);
						webHeaderCollection.AddInternal(HTTP_REQUEST_HEADER_ID.ToString(i), value2);
					}
					ptr4++;
				}
			}
			return webHeaderCollection;
		}

		private unsafe static string GetKnownHeader(HTTP_REQUEST* request, long fixup, int headerIndex)
		{
			string result = null;
			HTTP_KNOWN_HEADER* ptr = &request->Headers.KnownHeaders + headerIndex;
			if (ptr->pRawValue != null)
			{
				result = new string(ptr->pRawValue + fixup, 0, ptr->RawValueLength);
			}
			return result;
		}

		internal unsafe static string GetKnownHeader(HTTP_REQUEST* request, int headerIndex)
		{
			return GetKnownHeader(request, 0L, headerIndex);
		}

		internal unsafe static string GetKnownHeader(byte[] memoryBlob, IntPtr originalAddress, int headerIndex)
		{
			fixed (byte* ptr = memoryBlob)
			{
				return GetKnownHeader((HTTP_REQUEST*)ptr, ptr - (byte*)(void*)originalAddress, headerIndex);
			}
		}

		private unsafe static string GetVerb(HTTP_REQUEST* request, long fixup)
		{
			string result = null;
			if (request->Verb > HTTP_VERB.HttpVerbUnknown && request->Verb < HTTP_VERB.HttpVerbMaximum)
			{
				result = HttpVerbs[(int)request->Verb];
			}
			else if (request->Verb == HTTP_VERB.HttpVerbUnknown && request->pUnknownVerb != null)
			{
				result = new string(request->pUnknownVerb + fixup, 0, request->UnknownVerbLength);
			}
			return result;
		}

		internal unsafe static string GetVerb(HTTP_REQUEST* request)
		{
			return GetVerb(request, 0L);
		}

		internal unsafe static string GetVerb(byte[] memoryBlob, IntPtr originalAddress)
		{
			fixed (byte* ptr = memoryBlob)
			{
				return GetVerb((HTTP_REQUEST*)ptr, ptr - (byte*)(void*)originalAddress);
			}
		}

		internal unsafe static HTTP_VERB GetKnownVerb(byte[] memoryBlob, IntPtr originalAddress)
		{
			HTTP_VERB result = HTTP_VERB.HttpVerbUnknown;
			fixed (byte* ptr = memoryBlob)
			{
				HTTP_REQUEST* ptr2 = (HTTP_REQUEST*)ptr;
				if (ptr2->Verb > HTTP_VERB.HttpVerbUnparsed && ptr2->Verb < HTTP_VERB.HttpVerbMaximum)
				{
					result = ptr2->Verb;
				}
			}
			return result;
		}

		internal unsafe static uint GetChunks(byte[] memoryBlob, IntPtr originalAddress, ref int dataChunkIndex, ref uint dataChunkOffset, byte[] buffer, int offset, int size)
		{
			uint num = 0u;
			fixed (byte* ptr = memoryBlob)
			{
				HTTP_REQUEST* ptr2 = (HTTP_REQUEST*)ptr;
				long num2 = ptr - (byte*)(void*)originalAddress;
				if (ptr2->EntityChunkCount > 0 && dataChunkIndex < ptr2->EntityChunkCount && dataChunkIndex != -1)
				{
					HTTP_DATA_CHUNK* ptr3 = (HTTP_DATA_CHUNK*)(num2 + (byte*)(ptr2->pEntityChunks + dataChunkIndex));
					fixed (byte* ptr4 = buffer)
					{
						byte* ptr5 = ptr4 + offset;
						while (dataChunkIndex < ptr2->EntityChunkCount && num < size)
						{
							if (dataChunkOffset >= ptr3->BufferLength)
							{
								dataChunkOffset = 0u;
								dataChunkIndex++;
								ptr3++;
								continue;
							}
							byte* ptr6 = ptr3->pBuffer + dataChunkOffset + num2;
							uint num3 = ptr3->BufferLength - dataChunkOffset;
							if (num3 > (uint)size)
							{
								num3 = (uint)size;
							}
							for (uint num4 = 0u; num4 < num3; num4++)
							{
								*(ptr5++) = *(ptr6++);
							}
							num += num3;
							dataChunkOffset += num3;
						}
					}
				}
				if (dataChunkIndex == ptr2->EntityChunkCount)
				{
					dataChunkIndex = -1;
				}
			}
			return num;
		}

		internal unsafe static IPEndPoint GetRemoteEndPoint(byte[] memoryBlob, IntPtr originalAddress)
		{
			SocketAddress v4address = new SocketAddress(AddressFamily.InterNetwork, 16);
			SocketAddress v6address = new SocketAddress(AddressFamily.InterNetworkV6, 28);
			fixed (byte* ptr = memoryBlob)
			{
				HTTP_REQUEST* ptr2 = (HTTP_REQUEST*)ptr;
				IntPtr address = ((ptr2->Address.pRemoteAddress != null) ? ((IntPtr)(ptr - (byte*)(void*)originalAddress + (byte*)ptr2->Address.pRemoteAddress)) : IntPtr.Zero);
				CopyOutAddress(address, ref v4address, ref v6address);
			}
			IPEndPoint result = null;
			if (v4address != null)
			{
				result = IPEndPoint.Any.Create(v4address) as IPEndPoint;
			}
			else if (v6address != null)
			{
				result = IPEndPoint.IPv6Any.Create(v6address) as IPEndPoint;
			}
			return result;
		}

		internal unsafe static IPEndPoint GetLocalEndPoint(byte[] memoryBlob, IntPtr originalAddress)
		{
			SocketAddress v4address = new SocketAddress(AddressFamily.InterNetwork, 16);
			SocketAddress v6address = new SocketAddress(AddressFamily.InterNetworkV6, 28);
			fixed (byte* ptr = memoryBlob)
			{
				HTTP_REQUEST* ptr2 = (HTTP_REQUEST*)ptr;
				IntPtr address = ((ptr2->Address.pLocalAddress != null) ? ((IntPtr)(ptr - (byte*)(void*)originalAddress + (byte*)ptr2->Address.pLocalAddress)) : IntPtr.Zero);
				CopyOutAddress(address, ref v4address, ref v6address);
			}
			IPEndPoint result = null;
			if (v4address != null)
			{
				result = IPEndPoint.Any.Create(v4address) as IPEndPoint;
			}
			else if (v6address != null)
			{
				result = IPEndPoint.IPv6Any.Create(v6address) as IPEndPoint;
			}
			return result;
		}

		internal unsafe static HTTP_REQUEST_TOKEN_BINDING_INFO* GetTlsTokenBindingRequestInfo(byte[] memoryBlob, IntPtr originalAddress)
		{
			fixed (byte* ptr = memoryBlob)
			{
				HTTP_REQUEST_V2* ptr2 = (HTTP_REQUEST_V2*)ptr;
				long num = ptr - (byte*)(void*)originalAddress;
				for (int i = 0; i < ptr2->RequestInfoCount; i++)
				{
					HTTP_REQUEST_INFO* ptr3 = (HTTP_REQUEST_INFO*)(num + (byte*)(ptr2->pRequestInfo + i));
					if (ptr3 != null && ptr3->InfoType == HTTP_REQUEST_INFO_TYPE.HttpRequestInfoTypeSslTokenBinding)
					{
						return (HTTP_REQUEST_TOKEN_BINDING_INFO*)((byte*)ptr3->pInfo + num);
					}
				}
			}
			return null;
		}

		internal unsafe static HTTP_REQUEST_TOKEN_BINDING_INFO_V1* GetTlsTokenBindingRequestInfo_V1(byte[] memoryBlob, IntPtr originalAddress)
		{
			fixed (byte* ptr = memoryBlob)
			{
				HTTP_REQUEST_V2* ptr2 = (HTTP_REQUEST_V2*)ptr;
				long num = ptr - (byte*)(void*)originalAddress;
				for (int i = 0; i < ptr2->RequestInfoCount; i++)
				{
					HTTP_REQUEST_INFO* ptr3 = (HTTP_REQUEST_INFO*)(num + (byte*)(ptr2->pRequestInfo + i));
					if (ptr3 != null && ptr3->InfoType == HTTP_REQUEST_INFO_TYPE.HttpRequestInfoTypeSslTokenBindingDraft)
					{
						return (HTTP_REQUEST_TOKEN_BINDING_INFO_V1*)((byte*)ptr3->pInfo + num);
					}
				}
			}
			return null;
		}

		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		private unsafe static void CopyOutAddress(IntPtr address, ref SocketAddress v4address, ref SocketAddress v6address)
		{
			if (address != IntPtr.Zero)
			{
				switch (*(ushort*)(void*)address)
				{
				case 2:
					v6address = null;
					fixed (byte* buffer2 = v4address.m_Buffer)
					{
						for (int j = 2; j < 16; j++)
						{
							buffer2[j] = ((byte*)(void*)address)[j];
						}
					}
					return;
				case 23:
					v4address = null;
					fixed (byte* buffer = v6address.m_Buffer)
					{
						for (int i = 2; i < 28; i++)
						{
							buffer[i] = ((byte*)(void*)address)[i];
						}
					}
					return;
				}
			}
			v4address = null;
			v6address = null;
		}
	}

	[SuppressUnmanagedCodeSecurity]
	internal static class SecureStringHelper
	{
		internal static string CreateString(SecureString secureString)
		{
			IntPtr intPtr = IntPtr.Zero;
			if (secureString == null || secureString.Length == 0)
			{
				return string.Empty;
			}
			try
			{
				intPtr = Marshal.SecureStringToBSTR(secureString);
				return Marshal.PtrToStringBSTR(intPtr);
			}
			finally
			{
				if (intPtr != IntPtr.Zero)
				{
					Marshal.ZeroFreeBSTR(intPtr);
				}
			}
		}

		internal unsafe static SecureString CreateSecureString(string plainString)
		{
			if (plainString == null || plainString.Length == 0)
			{
				return new SecureString();
			}
			SecureString result;
			fixed (char* value = plainString)
			{
				result = new SecureString(value, plainString.Length);
			}
			return result;
		}
	}

	[FriendAccessAllowed]
	internal class AppXHelper
	{
		private struct GuiThreadInfo
		{
			public int cbSize;

			public int flags;

			public IntPtr hwndActive;

			public IntPtr hwndFocus;

			public IntPtr hwndCapture;

			public IntPtr hwndMenuOwner;

			public IntPtr hwndMoveSize;

			public IntPtr hwndCaret;

			public int left;

			public int top;

			public int right;

			public int bottom;
		}

		[SecuritySafeCritical]
		internal static Lazy<IntPtr> PrimaryWindowHandle = new Lazy<IntPtr>(() => GetPrimaryWindowHandle());

		[SecuritySafeCritical]
		private static IntPtr GetPrimaryWindowHandle()
		{
			IntPtr result = IntPtr.Zero;
			GuiThreadInfo info = default(GuiThreadInfo);
			info.cbSize = Marshal.SizeOf((object)info);
			if (GetGUIThreadInfo(0, ref info) != 0 && info.hwndActive != IntPtr.Zero)
			{
				GetWindowThreadProcessId(info.hwndActive, out var processId);
				if (processId == Process.GetCurrentProcess().Id)
				{
					result = info.hwndActive;
				}
			}
			return result;
		}

		[DllImport("user32.dll", ExactSpelling = true, SetLastError = true)]
		private static extern uint GetGUIThreadInfo(int threadId, ref GuiThreadInfo info);

		[DllImport("user32.dll", ExactSpelling = true)]
		private static extern uint GetWindowThreadProcessId(IntPtr hwnd, out int processId);
	}

	internal static class TokenBindingOSHelper
	{
		private static bool s_supportsTokenBinding = false;

		private static object s_Lock = new object();

		private static volatile bool s_Initialized = false;

		internal static bool SupportsTokenBinding
		{
			get
			{
				EnsureTokenBindingOSHelperInitialized();
				return s_supportsTokenBinding;
			}
		}

		[SecurityCritical]
		private static void EnsureTokenBindingOSHelperInitialized()
		{
			if (s_Initialized)
			{
				return;
			}
			lock (s_Lock)
			{
				if (s_Initialized)
				{
					return;
				}
				try
				{
					string library = Path.Combine(Environment.SystemDirectory, "tokenbinding.dll");
					SafeLoadLibrary safeLoadLibrary = SafeLoadLibrary.LoadLibraryEx(library);
					if (!safeLoadLibrary.IsInvalid)
					{
						s_supportsTokenBinding = safeLoadLibrary.HasFunction("TokenBindingVerifyMessage");
					}
					s_Initialized = true;
				}
				catch (Exception exception)
				{
					if (NclUtilities.IsFatal(exception))
					{
						throw;
					}
				}
			}
		}
	}

	private const string KERNEL32 = "kernel32.dll";

	private const string WS2_32 = "ws2_32.dll";

	private const string SECUR32 = "secur32.dll";

	private const string CRYPT32 = "crypt32.dll";

	private const string ADVAPI32 = "advapi32.dll";

	private const string HTTPAPI = "httpapi.dll";

	private const string SCHANNEL = "schannel.dll";

	private const string RASAPI32 = "rasapi32.dll";

	private const string WININET = "wininet.dll";

	private const string WINHTTP = "winhttp.dll";

	private const string BCRYPT = "bcrypt.dll";

	private const string USER32 = "user32.dll";

	private const string TOKENBINDING = "tokenbinding.dll";

	private const string OLE32 = "ole32.dll";

	internal const int CLSCTX_SERVER = 21;

	[DllImport("kernel32.dll")]
	internal static extern IntPtr CreateSemaphore([In] IntPtr lpSemaphoreAttributes, [In] int lInitialCount, [In] int lMaximumCount, [In] IntPtr lpName);

	[DllImport("kernel32.dll")]
	internal static extern bool ReleaseSemaphore([In] IntPtr hSemaphore, [In] int lReleaseCount, [In] IntPtr lpPreviousCount);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
	internal static extern uint GetCurrentThreadId();

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
	internal unsafe static extern uint CancelIoEx(CriticalHandle handle, NativeOverlapped* overlapped);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
	internal static extern uint CancelIoEx(SafeHandle handle, IntPtr overlapped);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
	internal static extern bool SetFileCompletionNotificationModes(CriticalHandle handle, FileCompletionNotificationModes modes);

	[DllImport("kernel32.dll", SetLastError = true)]
	internal static extern IntPtr GetProcessHeap();

	[DllImport("kernel32.dll", SetLastError = true)]
	internal static extern bool HeapFree([In] IntPtr hHeap, [In] uint dwFlags, [In] IntPtr lpMem);

	[DllImport("kernel32.dll", SetLastError = true)]
	[SecurityCritical]
	internal static extern IntPtr GetProcAddress(SafeLoadLibrary hModule, string entryPoint);

	[DllImport("kernel32.dll", SetLastError = true)]
	[SecurityCritical]
	internal static extern IntPtr GetProcAddress(IntPtr hModule, string entryPoint);

	[DllImport("kernel32.dll", ExactSpelling = true)]
	internal static extern void DebugBreak();

	[DllImport("ole32.dll", PreserveSig = false)]
	public static extern void CoCreateInstance([In] ref Guid clsid, IntPtr pUnkOuter, int context, [In] ref Guid iid, [MarshalAs(UnmanagedType.IUnknown)] out object o);
}
