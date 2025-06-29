using System.Security;
using System.Threading;

namespace System.Runtime.CompilerServices;

[FriendAccessAllowed]
internal static class JitHelpers
{
	internal const string QCall = "QCall";

	[SecurityCritical]
	internal static StringHandleOnStack GetStringHandleOnStack(ref string s)
	{
		return new StringHandleOnStack(UnsafeCastToStackPointer(ref s));
	}

	[SecurityCritical]
	internal static ObjectHandleOnStack GetObjectHandleOnStack<T>(ref T o) where T : class
	{
		return new ObjectHandleOnStack(UnsafeCastToStackPointer(ref o));
	}

	[SecurityCritical]
	internal static StackCrawlMarkHandle GetStackCrawlMarkHandle(ref StackCrawlMark stackMark)
	{
		return new StackCrawlMarkHandle(UnsafeCastToStackPointer(ref stackMark));
	}

	[SecurityCritical]
	[FriendAccessAllowed]
	internal static T UnsafeCast<T>(object o) where T : class
	{
		throw new InvalidOperationException();
	}

	internal static int UnsafeEnumCast<T>(T val) where T : struct
	{
		throw new InvalidOperationException();
	}

	internal static long UnsafeEnumCastLong<T>(T val) where T : struct
	{
		throw new InvalidOperationException();
	}

	[SecurityCritical]
	internal static IntPtr UnsafeCastToStackPointer<T>(ref T val)
	{
		throw new InvalidOperationException();
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern void UnsafeSetArrayElement(object[] target, int index, object element);

	[SecurityCritical]
	internal static PinningHelper GetPinningHelper(object o)
	{
		return UnsafeCast<PinningHelper>(o);
	}
}
