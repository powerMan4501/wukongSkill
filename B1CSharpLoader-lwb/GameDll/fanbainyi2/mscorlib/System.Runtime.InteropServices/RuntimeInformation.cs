using System.Reflection;
using System.Security;
using Microsoft.Win32;

namespace System.Runtime.InteropServices;

public static class RuntimeInformation
{
	private const string FrameworkName = ".NET Framework";

	private static string s_frameworkDescription;

	private static string s_osDescription = null;

	private static object s_osLock = new object();

	private static object s_processLock = new object();

	private static Architecture? s_osArch = null;

	private static Architecture? s_processArch = null;

	public static string FrameworkDescription
	{
		get
		{
			if (s_frameworkDescription == null)
			{
				AssemblyFileVersionAttribute assemblyFileVersionAttribute = (AssemblyFileVersionAttribute)typeof(object).GetTypeInfo().Assembly.GetCustomAttribute(typeof(AssemblyFileVersionAttribute));
				s_frameworkDescription = ".NET Framework " + assemblyFileVersionAttribute.Version;
			}
			return s_frameworkDescription;
		}
	}

	public static string OSDescription
	{
		[SecuritySafeCritical]
		get
		{
			if (s_osDescription == null)
			{
				s_osDescription = RtlGetVersion();
			}
			return s_osDescription;
		}
	}

	public static Architecture OSArchitecture
	{
		[SecuritySafeCritical]
		get
		{
			lock (s_osLock)
			{
				if (!s_osArch.HasValue)
				{
					Win32Native.GetNativeSystemInfo(out var lpSystemInfo);
					s_osArch = GetArchitecture(lpSystemInfo.wProcessorArchitecture);
				}
			}
			return s_osArch.Value;
		}
	}

	public static Architecture ProcessArchitecture
	{
		[SecuritySafeCritical]
		get
		{
			lock (s_processLock)
			{
				if (!s_processArch.HasValue)
				{
					Win32Native.SYSTEM_INFO lpSystemInfo = default(Win32Native.SYSTEM_INFO);
					Win32Native.GetSystemInfo(ref lpSystemInfo);
					s_processArch = GetArchitecture(lpSystemInfo.wProcessorArchitecture);
				}
			}
			return s_processArch.Value;
		}
	}

	public static bool IsOSPlatform(OSPlatform osPlatform)
	{
		return OSPlatform.Windows == osPlatform;
	}

	private static Architecture GetArchitecture(ushort wProcessorArchitecture)
	{
		Architecture result = Architecture.X86;
		switch (wProcessorArchitecture)
		{
		case 12:
			result = Architecture.Arm64;
			break;
		case 5:
			result = Architecture.Arm;
			break;
		case 9:
			result = Architecture.X64;
			break;
		case 0:
			result = Architecture.X86;
			break;
		}
		return result;
	}

	[SecuritySafeCritical]
	private static string RtlGetVersion()
	{
		Win32Native.RTL_OSVERSIONINFOEX lpVersionInformation = default(Win32Native.RTL_OSVERSIONINFOEX);
		lpVersionInformation.dwOSVersionInfoSize = (uint)Marshal.SizeOf(lpVersionInformation);
		if (Win32Native.RtlGetVersion(out lpVersionInformation) == 0)
		{
			return string.Format("{0} {1}.{2}.{3} {4}", "Microsoft Windows", lpVersionInformation.dwMajorVersion, lpVersionInformation.dwMinorVersion, lpVersionInformation.dwBuildNumber, lpVersionInformation.szCSDVersion);
		}
		return "Microsoft Windows";
	}
}
