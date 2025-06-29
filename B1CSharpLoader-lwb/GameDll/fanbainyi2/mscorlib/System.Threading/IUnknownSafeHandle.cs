using System.Runtime.InteropServices;
using System.Security;

namespace System.Threading;

[SecurityCritical]
internal class IUnknownSafeHandle : SafeHandle
{
	public override bool IsInvalid
	{
		[SecurityCritical]
		get
		{
			return handle == IntPtr.Zero;
		}
	}

	public IUnknownSafeHandle()
		: base(IntPtr.Zero, ownsHandle: true)
	{
	}

	[SecurityCritical]
	protected override bool ReleaseHandle()
	{
		HostExecutionContextManager.ReleaseHostSecurityContext(handle);
		return true;
	}

	internal object Clone()
	{
		IUnknownSafeHandle unknownSafeHandle = new IUnknownSafeHandle();
		if (!IsInvalid)
		{
			HostExecutionContextManager.CloneHostSecurityContext(this, unknownSafeHandle);
		}
		return unknownSafeHandle;
	}
}
