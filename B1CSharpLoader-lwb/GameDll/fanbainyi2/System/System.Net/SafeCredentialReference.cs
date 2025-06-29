using System.Runtime.CompilerServices;
using Microsoft.Win32.SafeHandles;

namespace System.Net;

internal sealed class SafeCredentialReference : CriticalHandleMinusOneIsInvalid
{
	internal SafeFreeCredentials _Target;

	internal static SafeCredentialReference CreateReference(SafeFreeCredentials target)
	{
		SafeCredentialReference safeCredentialReference = new SafeCredentialReference(target);
		if (safeCredentialReference.IsInvalid)
		{
			return null;
		}
		return safeCredentialReference;
	}

	private SafeCredentialReference(SafeFreeCredentials target)
	{
		bool success = false;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			target.DangerousAddRef(ref success);
		}
		catch
		{
			if (success)
			{
				target.DangerousRelease();
				success = false;
			}
		}
		finally
		{
			if (success)
			{
				_Target = target;
				SetHandle(new IntPtr(0));
			}
		}
	}

	protected override bool ReleaseHandle()
	{
		_Target?.DangerousRelease();
		_Target = null;
		return true;
	}
}
