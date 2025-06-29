using System.Runtime.InteropServices;
using System.Security;
using Microsoft.Win32.SafeHandles;

namespace System;

[SecurityCritical]
internal class SafeTypeNameParserHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void _ReleaseTypeNameParser(IntPtr pTypeNameParser);

	public SafeTypeNameParserHandle()
		: base(ownsHandle: true)
	{
	}

	[SecurityCritical]
	protected override bool ReleaseHandle()
	{
		_ReleaseTypeNameParser(handle);
		handle = IntPtr.Zero;
		return true;
	}
}
