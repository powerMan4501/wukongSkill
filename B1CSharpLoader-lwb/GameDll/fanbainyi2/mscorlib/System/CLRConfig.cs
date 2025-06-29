using System.Runtime.CompilerServices;
using System.Security;

namespace System;

[FriendAccessAllowed]
internal class CLRConfig
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[FriendAccessAllowed]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	internal static extern bool CheckLegacyManagedDeflateStream();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	internal static extern bool CheckThrowUnobservedTaskExceptions();
}
