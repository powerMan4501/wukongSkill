using System.ComponentModel;
using System.Security;
using System.Security.Permissions;
using System.Security.Principal;
using Microsoft.Win32;

namespace System;

internal static class EnvironmentHelpers
{
	private static volatile bool s_IsAppContainerProcess;

	private static volatile bool s_IsAppContainerProcessInitalized;

	public static bool IsAppContainerProcess
	{
		get
		{
			if (!s_IsAppContainerProcessInitalized)
			{
				if (Environment.OSVersion.Platform != PlatformID.Win32NT)
				{
					s_IsAppContainerProcess = false;
				}
				else if (Environment.OSVersion.Version.Major < 6 || (Environment.OSVersion.Version.Major == 6 && Environment.OSVersion.Version.Minor <= 1))
				{
					s_IsAppContainerProcess = false;
				}
				else
				{
					s_IsAppContainerProcess = HasAppContainerToken();
				}
				s_IsAppContainerProcessInitalized = true;
			}
			return s_IsAppContainerProcess;
		}
	}

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Assert, Flags = (SecurityPermissionFlag.UnmanagedCode | SecurityPermissionFlag.ControlPrincipal))]
	private unsafe static bool HasAppContainerToken()
	{
		int* ptr = stackalloc int[1];
		uint ReturnLength = 0u;
		using (WindowsIdentity windowsIdentity = WindowsIdentity.GetCurrent(TokenAccessLevels.Query))
		{
			if (!Microsoft.Win32.UnsafeNativeMethods.GetTokenInformation(windowsIdentity.Token, 29u, new IntPtr(ptr), 4u, out ReturnLength))
			{
				throw new Win32Exception();
			}
		}
		return *ptr != 0;
	}

	internal static bool IsWindowsVistaOrAbove()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		if (oSVersion.Platform == PlatformID.Win32NT)
		{
			return oSVersion.Version.Major >= 6;
		}
		return false;
	}
}
