using System.Security;
using Microsoft.Win32.SafeHandles;

namespace System.Net;

[SuppressUnmanagedCodeSecurity]
internal sealed class SafeLoadLibrary : SafeHandleZeroOrMinusOneIsInvalid
{
	private const string KERNEL32 = "kernel32.dll";

	private const string AddDllDirectory = "AddDllDirectory";

	private const uint LOAD_LIBRARY_SEARCH_SYSTEM32 = 2048u;

	public static readonly SafeLoadLibrary Zero;

	private static uint _flags;

	static SafeLoadLibrary()
	{
		Zero = new SafeLoadLibrary(ownsHandle: false);
		_flags = 0u;
		try
		{
			IntPtr moduleHandleW = UnsafeNclNativeMethods.SafeNetHandles.GetModuleHandleW("kernel32.dll");
			if (moduleHandleW != IntPtr.Zero && UnsafeNclNativeMethods.GetProcAddress(moduleHandleW, "AddDllDirectory") != IntPtr.Zero)
			{
				_flags = 2048u;
			}
		}
		catch
		{
		}
	}

	private SafeLoadLibrary()
		: base(ownsHandle: true)
	{
	}

	private SafeLoadLibrary(bool ownsHandle)
		: base(ownsHandle)
	{
	}

	public unsafe static SafeLoadLibrary LoadLibraryEx(string library)
	{
		SafeLoadLibrary safeLoadLibrary = UnsafeNclNativeMethods.SafeNetHandles.LoadLibraryExW(library, null, _flags);
		if (safeLoadLibrary.IsInvalid)
		{
			safeLoadLibrary.SetHandleAsInvalid();
		}
		return safeLoadLibrary;
	}

	public bool HasFunction(string functionName)
	{
		IntPtr procAddress = UnsafeNclNativeMethods.GetProcAddress(this, functionName);
		return procAddress != IntPtr.Zero;
	}

	protected override bool ReleaseHandle()
	{
		return UnsafeNclNativeMethods.SafeNetHandles.FreeLibrary(handle);
	}
}
