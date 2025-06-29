using System.Collections;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using Microsoft.Win32;

namespace System;

[ComVisible(true)]
[__DynamicallyInvokable]
public static class Environment
{
	internal sealed class ResourceHelper
	{
		internal class GetResourceStringUserData
		{
			public ResourceHelper m_resourceHelper;

			public string m_key;

			public CultureInfo m_culture;

			public string m_retVal;

			public bool m_lockWasTaken;

			public GetResourceStringUserData(ResourceHelper resourceHelper, string key, CultureInfo culture)
			{
				m_resourceHelper = resourceHelper;
				m_key = key;
				m_culture = culture;
			}
		}

		private string m_name;

		private ResourceManager SystemResMgr;

		private Stack currentlyLoading;

		internal bool resourceManagerInited;

		private int infinitelyRecursingCount;

		internal ResourceHelper(string name)
		{
			m_name = name;
		}

		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		internal string GetResourceString(string key)
		{
			if (key == null || key.Length == 0)
			{
				return "[Resource lookup failed - null or empty resource name]";
			}
			return GetResourceString(key, null);
		}

		[SecuritySafeCritical]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		internal string GetResourceString(string key, CultureInfo culture)
		{
			if (key == null || key.Length == 0)
			{
				return "[Resource lookup failed - null or empty resource name]";
			}
			GetResourceStringUserData getResourceStringUserData = new GetResourceStringUserData(this, key, culture);
			RuntimeHelpers.TryCode code = GetResourceStringCode;
			RuntimeHelpers.CleanupCode backoutCode = GetResourceStringBackoutCode;
			RuntimeHelpers.ExecuteCodeWithGuaranteedCleanup(code, backoutCode, getResourceStringUserData);
			return getResourceStringUserData.m_retVal;
		}

		[SecuritySafeCritical]
		private void GetResourceStringCode(object userDataIn)
		{
			GetResourceStringUserData getResourceStringUserData = (GetResourceStringUserData)userDataIn;
			ResourceHelper resourceHelper = getResourceStringUserData.m_resourceHelper;
			string key = getResourceStringUserData.m_key;
			CultureInfo culture = getResourceStringUserData.m_culture;
			Monitor.Enter(resourceHelper, ref getResourceStringUserData.m_lockWasTaken);
			if (resourceHelper.currentlyLoading != null && resourceHelper.currentlyLoading.Count > 0 && resourceHelper.currentlyLoading.Contains(key))
			{
				if (resourceHelper.infinitelyRecursingCount > 0)
				{
					getResourceStringUserData.m_retVal = "[Resource lookup failed - infinite recursion or critical failure detected.]";
					return;
				}
				resourceHelper.infinitelyRecursingCount++;
				string message = "Infinite recursion during resource lookup within mscorlib.  This may be a bug in mscorlib, or potentially in certain extensibility points such as assembly resolve events or CultureInfo names.  Resource name: " + key;
				Assert.Fail("[mscorlib recursive resource lookup bug]", message, -2146232797, System.Diagnostics.StackTrace.TraceFormat.NoResourceLookup);
				FailFast(message);
			}
			if (resourceHelper.currentlyLoading == null)
			{
				resourceHelper.currentlyLoading = new Stack(4);
			}
			if (!resourceHelper.resourceManagerInited)
			{
				RuntimeHelpers.PrepareConstrainedRegions();
				try
				{
				}
				finally
				{
					RuntimeHelpers.RunClassConstructor(typeof(ResourceManager).TypeHandle);
					RuntimeHelpers.RunClassConstructor(typeof(ResourceReader).TypeHandle);
					RuntimeHelpers.RunClassConstructor(typeof(RuntimeResourceSet).TypeHandle);
					RuntimeHelpers.RunClassConstructor(typeof(BinaryReader).TypeHandle);
					resourceHelper.resourceManagerInited = true;
				}
			}
			resourceHelper.currentlyLoading.Push(key);
			if (resourceHelper.SystemResMgr == null)
			{
				resourceHelper.SystemResMgr = new ResourceManager(m_name, typeof(object).Assembly);
			}
			string retVal = resourceHelper.SystemResMgr.GetString(key, null);
			resourceHelper.currentlyLoading.Pop();
			getResourceStringUserData.m_retVal = retVal;
		}

		[PrePrepareMethod]
		private void GetResourceStringBackoutCode(object userDataIn, bool exceptionThrown)
		{
			GetResourceStringUserData getResourceStringUserData = (GetResourceStringUserData)userDataIn;
			ResourceHelper resourceHelper = getResourceStringUserData.m_resourceHelper;
			if (exceptionThrown && getResourceStringUserData.m_lockWasTaken)
			{
				resourceHelper.SystemResMgr = null;
				resourceHelper.currentlyLoading = null;
			}
			if (getResourceStringUserData.m_lockWasTaken)
			{
				Monitor.Exit(resourceHelper);
			}
		}
	}

	public enum SpecialFolderOption
	{
		None = 0,
		Create = 32768,
		DoNotVerify = 16384
	}

	[ComVisible(true)]
	public enum SpecialFolder
	{
		ApplicationData = 26,
		CommonApplicationData = 35,
		LocalApplicationData = 28,
		Cookies = 33,
		Desktop = 0,
		Favorites = 6,
		History = 34,
		InternetCache = 32,
		Programs = 2,
		MyComputer = 17,
		MyMusic = 13,
		MyPictures = 39,
		MyVideos = 14,
		Recent = 8,
		SendTo = 9,
		StartMenu = 11,
		Startup = 7,
		System = 37,
		Templates = 21,
		DesktopDirectory = 16,
		Personal = 5,
		MyDocuments = 5,
		ProgramFiles = 38,
		CommonProgramFiles = 43,
		AdminTools = 48,
		CDBurning = 59,
		CommonAdminTools = 47,
		CommonDocuments = 46,
		CommonMusic = 53,
		CommonOemLinks = 58,
		CommonPictures = 54,
		CommonStartMenu = 22,
		CommonPrograms = 23,
		CommonStartup = 24,
		CommonDesktopDirectory = 25,
		CommonTemplates = 45,
		CommonVideos = 55,
		Fonts = 20,
		NetworkShortcuts = 19,
		PrinterShortcuts = 27,
		UserProfile = 40,
		CommonProgramFilesX86 = 44,
		ProgramFilesX86 = 42,
		Resources = 56,
		LocalizedResources = 57,
		SystemX86 = 41,
		Windows = 36
	}

	private const int MaxEnvVariableValueLength = 32767;

	private const int MaxSystemEnvVariableLength = 1024;

	private const int MaxUserEnvVariableLength = 255;

	private static volatile ResourceHelper m_resHelper;

	private const int MaxMachineNameLength = 256;

	private static object s_InternalSyncObject;

	private static volatile OperatingSystem m_os;

	private static volatile bool s_IsWindows8OrAbove;

	private static volatile bool s_CheckedOSWin8OrAbove;

	private static volatile bool s_WinRTSupported;

	private static volatile bool s_CheckedWinRT;

	private static volatile IntPtr processWinStation;

	private static volatile bool isUserNonInteractive;

	private static object InternalSyncObject
	{
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		get
		{
			if (s_InternalSyncObject == null)
			{
				object value = new object();
				Interlocked.CompareExchange<object>(ref s_InternalSyncObject, value, (object)null);
			}
			return s_InternalSyncObject;
		}
	}

	[__DynamicallyInvokable]
	public static extern int TickCount
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[SecuritySafeCritical]
		[__DynamicallyInvokable]
		get;
	}

	internal static extern long TickCount64
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[SecuritySafeCritical]
		get;
	}

	public static extern int ExitCode
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[SecuritySafeCritical]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[SecuritySafeCritical]
		set;
	}

	internal static bool IsCLRHosted
	{
		[SecuritySafeCritical]
		get
		{
			return GetIsCLRHosted();
		}
	}

	public static string CommandLine
	{
		[SecuritySafeCritical]
		get
		{
			new EnvironmentPermission(EnvironmentPermissionAccess.Read, "Path").Demand();
			string s = null;
			GetCommandLine(JitHelpers.GetStringHandleOnStack(ref s));
			return s;
		}
	}

	public static string CurrentDirectory
	{
		get
		{
			return Directory.GetCurrentDirectory();
		}
		set
		{
			Directory.SetCurrentDirectory(value);
		}
	}

	public static string SystemDirectory
	{
		[SecuritySafeCritical]
		get
		{
			StringBuilder stringBuilder = new StringBuilder(260);
			if (Win32Native.GetSystemDirectory(stringBuilder, 260) == 0)
			{
				__Error.WinIOError();
			}
			string text = stringBuilder.ToString();
			FileIOPermission.QuickDemand(FileIOPermissionAccess.PathDiscovery, text);
			return text;
		}
	}

	internal static string InternalWindowsDirectory
	{
		[SecurityCritical]
		get
		{
			StringBuilder stringBuilder = new StringBuilder(260);
			if (Win32Native.GetWindowsDirectory(stringBuilder, 260) == 0)
			{
				__Error.WinIOError();
			}
			return stringBuilder.ToString();
		}
	}

	public static string MachineName
	{
		[SecuritySafeCritical]
		get
		{
			new EnvironmentPermission(EnvironmentPermissionAccess.Read, "COMPUTERNAME").Demand();
			StringBuilder stringBuilder = new StringBuilder(256);
			int bufferSize = 256;
			if (Win32Native.GetComputerName(stringBuilder, ref bufferSize) == 0)
			{
				throw new InvalidOperationException(GetResourceString("InvalidOperation_ComputerName"));
			}
			return stringBuilder.ToString();
		}
	}

	[__DynamicallyInvokable]
	public static int ProcessorCount
	{
		[SecuritySafeCritical]
		[__DynamicallyInvokable]
		get
		{
			return GetProcessorCount();
		}
	}

	public static int SystemPageSize
	{
		[SecuritySafeCritical]
		get
		{
			new EnvironmentPermission(PermissionState.Unrestricted).Demand();
			Win32Native.SYSTEM_INFO lpSystemInfo = default(Win32Native.SYSTEM_INFO);
			Win32Native.GetSystemInfo(ref lpSystemInfo);
			return lpSystemInfo.dwPageSize;
		}
	}

	[__DynamicallyInvokable]
	public static string NewLine
	{
		[__DynamicallyInvokable]
		get
		{
			return "\r\n";
		}
	}

	public static Version Version => new Version(4, 0, 30319, 42000);

	public static long WorkingSet
	{
		[SecuritySafeCritical]
		get
		{
			new EnvironmentPermission(PermissionState.Unrestricted).Demand();
			return GetWorkingSet();
		}
	}

	public static OperatingSystem OSVersion
	{
		[SecuritySafeCritical]
		get
		{
			if (m_os == null)
			{
				Win32Native.OSVERSIONINFO oSVERSIONINFO = new Win32Native.OSVERSIONINFO();
				if (!GetVersion(oSVERSIONINFO))
				{
					throw new InvalidOperationException(GetResourceString("InvalidOperation_GetVersion"));
				}
				Win32Native.OSVERSIONINFOEX oSVERSIONINFOEX = new Win32Native.OSVERSIONINFOEX();
				if (!GetVersionEx(oSVERSIONINFOEX))
				{
					throw new InvalidOperationException(GetResourceString("InvalidOperation_GetVersion"));
				}
				PlatformID platform = PlatformID.Win32NT;
				Version version = new Version(oSVERSIONINFO.MajorVersion, oSVERSIONINFO.MinorVersion, oSVERSIONINFO.BuildNumber, (oSVERSIONINFOEX.ServicePackMajor << 16) | oSVERSIONINFOEX.ServicePackMinor);
				m_os = new OperatingSystem(platform, version, oSVERSIONINFO.CSDVersion);
			}
			return m_os;
		}
	}

	internal static bool IsWindows8OrAbove
	{
		get
		{
			if (!s_CheckedOSWin8OrAbove)
			{
				OperatingSystem oSVersion = OSVersion;
				s_IsWindows8OrAbove = oSVersion.Platform == PlatformID.Win32NT && ((oSVersion.Version.Major == 6 && oSVersion.Version.Minor >= 2) || oSVersion.Version.Major > 6);
				s_CheckedOSWin8OrAbove = true;
			}
			return s_IsWindows8OrAbove;
		}
	}

	internal static bool IsWinRTSupported
	{
		[SecuritySafeCritical]
		get
		{
			if (!s_CheckedWinRT)
			{
				s_WinRTSupported = WinRTSupported();
				s_CheckedWinRT = true;
			}
			return s_WinRTSupported;
		}
	}

	[__DynamicallyInvokable]
	public static string StackTrace
	{
		[SecuritySafeCritical]
		[__DynamicallyInvokable]
		get
		{
			new EnvironmentPermission(PermissionState.Unrestricted).Demand();
			return GetStackTrace(null, needFileInfo: true);
		}
	}

	public static bool Is64BitProcess => false;

	public static bool Is64BitOperatingSystem
	{
		[SecuritySafeCritical]
		get
		{
			bool isWow = default(bool);
			return Win32Native.DoesWin32MethodExist("kernel32.dll", "IsWow64Process") && Win32Native.IsWow64Process(Win32Native.GetCurrentProcess(), out isWow) && isWow;
		}
	}

	[__DynamicallyInvokable]
	public static extern bool HasShutdownStarted
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[SecuritySafeCritical]
		[__DynamicallyInvokable]
		get;
	}

	public static string UserName
	{
		[SecuritySafeCritical]
		get
		{
			new EnvironmentPermission(EnvironmentPermissionAccess.Read, "UserName").Demand();
			StringBuilder stringBuilder = new StringBuilder(256);
			int nSize = stringBuilder.Capacity;
			if (Win32Native.GetUserName(stringBuilder, ref nSize))
			{
				return stringBuilder.ToString();
			}
			return string.Empty;
		}
	}

	public static bool UserInteractive
	{
		[SecuritySafeCritical]
		get
		{
			IntPtr processWindowStation = Win32Native.GetProcessWindowStation();
			if (processWindowStation != IntPtr.Zero && processWinStation != processWindowStation)
			{
				int lpnLengthNeeded = 0;
				Win32Native.USEROBJECTFLAGS uSEROBJECTFLAGS = new Win32Native.USEROBJECTFLAGS();
				if (Win32Native.GetUserObjectInformation(processWindowStation, 1, uSEROBJECTFLAGS, Marshal.SizeOf(uSEROBJECTFLAGS), ref lpnLengthNeeded) && (uSEROBJECTFLAGS.dwFlags & 1) == 0)
				{
					isUserNonInteractive = true;
				}
				processWinStation = processWindowStation;
			}
			return !isUserNonInteractive;
		}
	}

	public static string UserDomainName
	{
		[SecuritySafeCritical]
		get
		{
			new EnvironmentPermission(EnvironmentPermissionAccess.Read, "UserDomain").Demand();
			byte[] array = new byte[1024];
			int sidLen = array.Length;
			StringBuilder stringBuilder = new StringBuilder(1024);
			uint domainNameLen = (uint)stringBuilder.Capacity;
			byte userNameEx = Win32Native.GetUserNameEx(2, stringBuilder, ref domainNameLen);
			if (userNameEx == 1)
			{
				string text = stringBuilder.ToString();
				int num = text.IndexOf('\\');
				if (num != -1)
				{
					return text.Substring(0, num);
				}
			}
			domainNameLen = (uint)stringBuilder.Capacity;
			if (!Win32Native.LookupAccountName(null, UserName, array, ref sidLen, stringBuilder, ref domainNameLen, out var _))
			{
				int lastWin32Error = Marshal.GetLastWin32Error();
				throw new InvalidOperationException(Win32Native.GetMessage(lastWin32Error));
			}
			return stringBuilder.ToString();
		}
	}

	[__DynamicallyInvokable]
	public static int CurrentManagedThreadId
	{
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[__DynamicallyInvokable]
		get
		{
			return Thread.CurrentThread.ManagedThreadId;
		}
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	internal static extern void _Exit(int exitCode);

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
	public static void Exit(int exitCode)
	{
		_Exit(exitCode);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	[__DynamicallyInvokable]
	public static extern void FailFast(string message);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern void FailFast(string message, uint exitCode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	[__DynamicallyInvokable]
	public static extern void FailFast(string message, Exception exception);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	internal static extern void TriggerCodeContractFailure(ContractFailureKind failureKind, string message, string condition, string exceptionAsString);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool GetIsCLRHosted();

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void GetCommandLine(StringHandleOnStack retString);

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static string ExpandEnvironmentVariables(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (name.Length == 0)
		{
			return name;
		}
		if (AppDomain.IsAppXModel() && !AppDomain.IsAppXDesignMode())
		{
			return name;
		}
		int num = 100;
		StringBuilder stringBuilder = new StringBuilder(num);
		bool flag = CodeAccessSecurityEngine.QuickCheckForAllDemands();
		string[] array = name.Split('%');
		StringBuilder stringBuilder2 = (flag ? null : new StringBuilder());
		bool flag2 = false;
		int num2;
		for (int i = 1; i < array.Length - 1; i++)
		{
			if (array[i].Length == 0 || flag2)
			{
				flag2 = false;
				continue;
			}
			stringBuilder.Length = 0;
			string text = "%" + array[i] + "%";
			num2 = Win32Native.ExpandEnvironmentStrings(text, stringBuilder, num);
			if (num2 == 0)
			{
				Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
			}
			while (num2 > num)
			{
				num = (stringBuilder.Capacity = num2);
				stringBuilder.Length = 0;
				num2 = Win32Native.ExpandEnvironmentStrings(text, stringBuilder, num);
				if (num2 == 0)
				{
					Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
				}
			}
			if (!flag)
			{
				string text2 = stringBuilder.ToString();
				flag2 = text2 != text;
				if (flag2)
				{
					stringBuilder2.Append(array[i]);
					stringBuilder2.Append(';');
				}
			}
		}
		if (!flag)
		{
			new EnvironmentPermission(EnvironmentPermissionAccess.Read, stringBuilder2.ToString()).Demand();
		}
		stringBuilder.Length = 0;
		num2 = Win32Native.ExpandEnvironmentStrings(name, stringBuilder, num);
		if (num2 == 0)
		{
			Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
		}
		while (num2 > num)
		{
			num = (stringBuilder.Capacity = num2);
			stringBuilder.Length = 0;
			num2 = Win32Native.ExpandEnvironmentStrings(name, stringBuilder, num);
			if (num2 == 0)
			{
				Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
			}
		}
		return stringBuilder.ToString();
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern int GetProcessorCount();

	[SecuritySafeCritical]
	public static string[] GetCommandLineArgs()
	{
		new EnvironmentPermission(EnvironmentPermissionAccess.Read, "Path").Demand();
		return GetCommandLineArgsNative();
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern string[] GetCommandLineArgsNative();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern string nativeGetEnvironmentVariable(string variable);

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static string GetEnvironmentVariable(string variable)
	{
		if (variable == null)
		{
			throw new ArgumentNullException("variable");
		}
		if (AppDomain.IsAppXModel() && !AppDomain.IsAppXDesignMode())
		{
			return null;
		}
		new EnvironmentPermission(EnvironmentPermissionAccess.Read, variable).Demand();
		StringBuilder stringBuilder = StringBuilderCache.Acquire(128);
		int environmentVariable = Win32Native.GetEnvironmentVariable(variable, stringBuilder, stringBuilder.Capacity);
		if (environmentVariable == 0 && Marshal.GetLastWin32Error() == 203)
		{
			StringBuilderCache.Release(stringBuilder);
			return null;
		}
		while (environmentVariable > stringBuilder.Capacity)
		{
			stringBuilder.Capacity = environmentVariable;
			stringBuilder.Length = 0;
			environmentVariable = Win32Native.GetEnvironmentVariable(variable, stringBuilder, stringBuilder.Capacity);
		}
		return StringBuilderCache.GetStringAndRelease(stringBuilder);
	}

	[SecuritySafeCritical]
	public static string GetEnvironmentVariable(string variable, EnvironmentVariableTarget target)
	{
		if (variable == null)
		{
			throw new ArgumentNullException("variable");
		}
		if (target == EnvironmentVariableTarget.Process)
		{
			return GetEnvironmentVariable(variable);
		}
		new EnvironmentPermission(PermissionState.Unrestricted).Demand();
		switch (target)
		{
		case EnvironmentVariableTarget.Machine:
		{
			using RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("System\\CurrentControlSet\\Control\\Session Manager\\Environment", writable: false);
			if (registryKey2 == null)
			{
				return null;
			}
			return registryKey2.GetValue(variable) as string;
		}
		case EnvironmentVariableTarget.User:
		{
			using RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Environment", writable: false);
			if (registryKey == null)
			{
				return null;
			}
			return registryKey.GetValue(variable) as string;
		}
		default:
			throw new ArgumentException(GetResourceString("Arg_EnumIllegalVal", (int)target));
		}
	}

	[SecurityCritical]
	private unsafe static char[] GetEnvironmentCharArray()
	{
		char[] array = null;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
		}
		finally
		{
			char* ptr = null;
			try
			{
				ptr = Win32Native.GetEnvironmentStrings();
				if (ptr == null)
				{
					throw new OutOfMemoryException();
				}
				char* ptr2;
				for (ptr2 = ptr; *ptr2 != 0 || ptr2[1] != 0; ptr2++)
				{
				}
				int num = (int)(ptr2 - ptr + 1);
				array = new char[num];
				fixed (char* dmem = array)
				{
					string.wstrcpy(dmem, ptr, num);
				}
			}
			finally
			{
				if (ptr != null)
				{
					Win32Native.FreeEnvironmentStrings(ptr);
				}
			}
		}
		return array;
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static IDictionary GetEnvironmentVariables()
	{
		if (AppDomain.IsAppXModel() && !AppDomain.IsAppXDesignMode())
		{
			return new Hashtable(0);
		}
		bool flag = CodeAccessSecurityEngine.QuickCheckForAllDemands();
		StringBuilder stringBuilder = (flag ? null : new StringBuilder());
		bool flag2 = true;
		char[] environmentCharArray = GetEnvironmentCharArray();
		Hashtable hashtable = new Hashtable(20);
		for (int i = 0; i < environmentCharArray.Length; i++)
		{
			int num = i;
			for (; environmentCharArray[i] != '=' && environmentCharArray[i] != 0; i++)
			{
			}
			if (environmentCharArray[i] == '\0')
			{
				continue;
			}
			if (i - num == 0)
			{
				for (; environmentCharArray[i] != 0; i++)
				{
				}
				continue;
			}
			string text = new string(environmentCharArray, num, i - num);
			i++;
			int num2 = i;
			for (; environmentCharArray[i] != 0; i++)
			{
			}
			string value = new string(environmentCharArray, num2, i - num2);
			hashtable[text] = value;
			if (!flag)
			{
				if (flag2)
				{
					flag2 = false;
				}
				else
				{
					stringBuilder.Append(';');
				}
				stringBuilder.Append(text);
			}
		}
		if (!flag)
		{
			new EnvironmentPermission(EnvironmentPermissionAccess.Read, stringBuilder.ToString()).Demand();
		}
		return hashtable;
	}

	internal static IDictionary GetRegistryKeyNameValuePairs(RegistryKey registryKey)
	{
		Hashtable hashtable = new Hashtable(20);
		if (registryKey != null)
		{
			string[] valueNames = registryKey.GetValueNames();
			string[] array = valueNames;
			foreach (string text in array)
			{
				string value = registryKey.GetValue(text, "").ToString();
				hashtable.Add(text, value);
			}
		}
		return hashtable;
	}

	[SecuritySafeCritical]
	public static IDictionary GetEnvironmentVariables(EnvironmentVariableTarget target)
	{
		if (target == EnvironmentVariableTarget.Process)
		{
			return GetEnvironmentVariables();
		}
		new EnvironmentPermission(PermissionState.Unrestricted).Demand();
		switch (target)
		{
		case EnvironmentVariableTarget.Machine:
		{
			using RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("System\\CurrentControlSet\\Control\\Session Manager\\Environment", writable: false);
			return GetRegistryKeyNameValuePairs(registryKey2);
		}
		case EnvironmentVariableTarget.User:
		{
			using RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Environment", writable: false);
			return GetRegistryKeyNameValuePairs(registryKey);
		}
		default:
			throw new ArgumentException(GetResourceString("Arg_EnumIllegalVal", (int)target));
		}
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static void SetEnvironmentVariable(string variable, string value)
	{
		CheckEnvironmentVariableName(variable);
		new EnvironmentPermission(PermissionState.Unrestricted).Demand();
		if (string.IsNullOrEmpty(value) || value[0] == '\0')
		{
			value = null;
		}
		else if (value.Length >= 32767)
		{
			throw new ArgumentException(GetResourceString("Argument_LongEnvVarValue"));
		}
		if (AppDomain.IsAppXModel() && !AppDomain.IsAppXDesignMode())
		{
			throw new PlatformNotSupportedException();
		}
		if (!Win32Native.SetEnvironmentVariable(variable, value))
		{
			int lastWin32Error = Marshal.GetLastWin32Error();
			switch (lastWin32Error)
			{
			case 203:
				break;
			case 206:
				throw new ArgumentException(GetResourceString("Argument_LongEnvVarValue"));
			default:
				throw new ArgumentException(Win32Native.GetMessage(lastWin32Error));
			}
		}
	}

	private static void CheckEnvironmentVariableName(string variable)
	{
		if (variable == null)
		{
			throw new ArgumentNullException("variable");
		}
		if (variable.Length == 0)
		{
			throw new ArgumentException(GetResourceString("Argument_StringZeroLength"), "variable");
		}
		if (variable[0] == '\0')
		{
			throw new ArgumentException(GetResourceString("Argument_StringFirstCharIsZero"), "variable");
		}
		if (variable.Length >= 32767)
		{
			throw new ArgumentException(GetResourceString("Argument_LongEnvVarValue"));
		}
		if (variable.IndexOf('=') != -1)
		{
			throw new ArgumentException(GetResourceString("Argument_IllegalEnvVarName"));
		}
	}

	[SecuritySafeCritical]
	public static void SetEnvironmentVariable(string variable, string value, EnvironmentVariableTarget target)
	{
		if (target == EnvironmentVariableTarget.Process)
		{
			SetEnvironmentVariable(variable, value);
			return;
		}
		CheckEnvironmentVariableName(variable);
		if (variable.Length >= 1024)
		{
			throw new ArgumentException(GetResourceString("Argument_LongEnvVarName"));
		}
		new EnvironmentPermission(PermissionState.Unrestricted).Demand();
		if (string.IsNullOrEmpty(value) || value[0] == '\0')
		{
			value = null;
		}
		switch (target)
		{
		case EnvironmentVariableTarget.Machine:
		{
			using (RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("System\\CurrentControlSet\\Control\\Session Manager\\Environment", writable: true))
			{
				if (registryKey2 != null)
				{
					if (value == null)
					{
						registryKey2.DeleteValue(variable, throwOnMissingValue: false);
					}
					else
					{
						registryKey2.SetValue(variable, value);
					}
				}
			}
			break;
		}
		case EnvironmentVariableTarget.User:
		{
			if (variable.Length >= 255)
			{
				throw new ArgumentException(GetResourceString("Argument_LongEnvVarValue"));
			}
			using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Environment", writable: true))
			{
				if (registryKey != null)
				{
					if (value == null)
					{
						registryKey.DeleteValue(variable, throwOnMissingValue: false);
					}
					else
					{
						registryKey.SetValue(variable, value);
					}
				}
			}
			break;
		}
		default:
			throw new ArgumentException(GetResourceString("Arg_EnumIllegalVal", (int)target));
		}
		IntPtr intPtr = Win32Native.SendMessageTimeout(new IntPtr(65535), 26, IntPtr.Zero, "Environment", 0u, 1000u, IntPtr.Zero);
		_ = intPtr == IntPtr.Zero;
	}

	[SecuritySafeCritical]
	public static string[] GetLogicalDrives()
	{
		new EnvironmentPermission(PermissionState.Unrestricted).Demand();
		int logicalDrives = Win32Native.GetLogicalDrives();
		if (logicalDrives == 0)
		{
			__Error.WinIOError();
		}
		uint num = (uint)logicalDrives;
		int num2 = 0;
		while (num != 0)
		{
			if ((num & 1) != 0)
			{
				num2++;
			}
			num >>= 1;
		}
		string[] array = new string[num2];
		char[] array2 = new char[3] { 'A', ':', '\\' };
		num = (uint)logicalDrives;
		num2 = 0;
		while (num != 0)
		{
			if ((num & 1) != 0)
			{
				array[num2++] = new string(array2);
			}
			num >>= 1;
			array2[0] += '\u0001';
		}
		return array;
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern long GetWorkingSet();

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool WinRTSupported();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern bool GetVersion(Win32Native.OSVERSIONINFO osVer);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern bool GetVersionEx(Win32Native.OSVERSIONINFOEX osVer);

	internal static string GetStackTrace(Exception e, bool needFileInfo)
	{
		StackTrace stackTrace = ((e != null) ? new StackTrace(e, needFileInfo) : new StackTrace(needFileInfo));
		return stackTrace.ToString(System.Diagnostics.StackTrace.TraceFormat.Normal);
	}

	[SecuritySafeCritical]
	private static void InitResourceHelper()
	{
		bool lockTaken = false;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			Monitor.Enter(InternalSyncObject, ref lockTaken);
			if (m_resHelper == null)
			{
				ResourceHelper resHelper = new ResourceHelper("mscorlib");
				Thread.MemoryBarrier();
				m_resHelper = resHelper;
			}
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(InternalSyncObject);
			}
		}
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern string GetResourceFromDefault(string key);

	internal static string GetResourceStringLocal(string key)
	{
		if (m_resHelper == null)
		{
			InitResourceHelper();
		}
		return m_resHelper.GetResourceString(key);
	}

	[SecuritySafeCritical]
	internal static string GetResourceString(string key)
	{
		return GetResourceFromDefault(key);
	}

	[SecuritySafeCritical]
	internal static string GetResourceString(string key, params object[] values)
	{
		string resourceString = GetResourceString(key);
		return string.Format(CultureInfo.CurrentCulture, resourceString, values);
	}

	internal static string GetRuntimeResourceString(string key)
	{
		return GetResourceString(key);
	}

	internal static string GetRuntimeResourceString(string key, params object[] values)
	{
		return GetResourceString(key, values);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern bool GetCompatibilityFlag(CompatibilityFlag flag);

	[SecuritySafeCritical]
	public static string GetFolderPath(SpecialFolder folder)
	{
		if (!Enum.IsDefined(typeof(SpecialFolder), folder))
		{
			throw new ArgumentException(GetResourceString("Arg_EnumIllegalVal", (int)folder));
		}
		return InternalGetFolderPath(folder, SpecialFolderOption.None);
	}

	[SecuritySafeCritical]
	public static string GetFolderPath(SpecialFolder folder, SpecialFolderOption option)
	{
		if (!Enum.IsDefined(typeof(SpecialFolder), folder))
		{
			throw new ArgumentException(GetResourceString("Arg_EnumIllegalVal", (int)folder));
		}
		if (!Enum.IsDefined(typeof(SpecialFolderOption), option))
		{
			throw new ArgumentException(GetResourceString("Arg_EnumIllegalVal", (int)option));
		}
		return InternalGetFolderPath(folder, option);
	}

	[SecurityCritical]
	internal static string UnsafeGetFolderPath(SpecialFolder folder)
	{
		return InternalGetFolderPath(folder, SpecialFolderOption.None, suppressSecurityChecks: true);
	}

	[SecurityCritical]
	private static string InternalGetFolderPath(SpecialFolder folder, SpecialFolderOption option, bool suppressSecurityChecks = false)
	{
		if (option == SpecialFolderOption.Create && !suppressSecurityChecks)
		{
			FileIOPermission fileIOPermission = new FileIOPermission(PermissionState.None);
			fileIOPermission.AllFiles = FileIOPermissionAccess.Write;
			fileIOPermission.Demand();
		}
		StringBuilder stringBuilder = new StringBuilder(260);
		int num = Win32Native.SHGetFolderPath(IntPtr.Zero, (int)folder | (int)option, IntPtr.Zero, 0, stringBuilder);
		string text;
		if (num < 0)
		{
			if (num == -2146233031)
			{
				throw new PlatformNotSupportedException();
			}
			text = string.Empty;
		}
		else
		{
			text = stringBuilder.ToString();
		}
		if (!suppressSecurityChecks)
		{
			new FileIOPermission(FileIOPermissionAccess.PathDiscovery, text).Demand();
		}
		return text;
	}
}
