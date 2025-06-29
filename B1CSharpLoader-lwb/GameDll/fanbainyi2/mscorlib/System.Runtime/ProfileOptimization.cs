using System.Runtime.InteropServices;
using System.Security;

namespace System.Runtime;

public static class ProfileOptimization
{
	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	internal static extern void InternalSetProfileRoot(string directoryPath);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	internal static extern void InternalStartProfile(string profile, IntPtr ptrNativeAssemblyLoadContext);

	[SecurityCritical]
	public static void SetProfileRoot(string directoryPath)
	{
		InternalSetProfileRoot(directoryPath);
	}

	[SecurityCritical]
	public static void StartProfile(string profile)
	{
		InternalStartProfile(profile, IntPtr.Zero);
	}
}
