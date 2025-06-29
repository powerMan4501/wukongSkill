using System.Runtime.CompilerServices;
using System.Security;

namespace System.Runtime.InteropServices.WindowsRuntime;

internal abstract class RuntimeClass : __ComObject
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal extern IntPtr GetRedirectedGetHashCodeMD();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal extern int RedirectGetHashCode(IntPtr pMD);

	[SecuritySafeCritical]
	public override int GetHashCode()
	{
		IntPtr redirectedGetHashCodeMD = GetRedirectedGetHashCodeMD();
		if (redirectedGetHashCodeMD == IntPtr.Zero)
		{
			return base.GetHashCode();
		}
		return RedirectGetHashCode(redirectedGetHashCodeMD);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal extern IntPtr GetRedirectedToStringMD();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal extern string RedirectToString(IntPtr pMD);

	[SecuritySafeCritical]
	public override string ToString()
	{
		if (this is IStringable stringable)
		{
			return stringable.ToString();
		}
		IntPtr redirectedToStringMD = GetRedirectedToStringMD();
		if (redirectedToStringMD == IntPtr.Zero)
		{
			return base.ToString();
		}
		return RedirectToString(redirectedToStringMD);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal extern IntPtr GetRedirectedEqualsMD();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal extern bool RedirectEquals(object obj, IntPtr pMD);

	[SecuritySafeCritical]
	public override bool Equals(object obj)
	{
		IntPtr redirectedEqualsMD = GetRedirectedEqualsMD();
		if (redirectedEqualsMD == IntPtr.Zero)
		{
			return base.Equals(obj);
		}
		return RedirectEquals(obj, redirectedEqualsMD);
	}
}
