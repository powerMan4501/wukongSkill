using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using Microsoft.Win32.SafeHandles;

namespace System.Net;

[SuppressUnmanagedCodeSecurity]
internal abstract class SafeFreeContextBuffer : SafeHandleZeroOrMinusOneIsInvalid
{
	protected SafeFreeContextBuffer()
		: base(ownsHandle: true)
	{
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal void Set(IntPtr value)
	{
		handle = value;
	}

	internal static int EnumeratePackages(SecurDll Dll, out int pkgnum, out SafeFreeContextBuffer pkgArray)
	{
		int num = -1;
		if (Dll == SecurDll.SECURITY)
		{
			SafeFreeContextBuffer_SECURITY safeFreeContextBuffer_SECURITY = null;
			num = UnsafeNclNativeMethods.SafeNetHandles_SECURITY.EnumerateSecurityPackagesW(out pkgnum, out safeFreeContextBuffer_SECURITY);
			pkgArray = safeFreeContextBuffer_SECURITY;
			if (num != 0 && pkgArray != null)
			{
				pkgArray.SetHandleAsInvalid();
			}
			return num;
		}
		throw new ArgumentException(SR.GetString("net_invalid_enum", "SecurDll"), "Dll");
	}

	internal static SafeFreeContextBuffer CreateEmptyHandle(SecurDll dll)
	{
		if (dll == SecurDll.SECURITY)
		{
			return new SafeFreeContextBuffer_SECURITY();
		}
		throw new ArgumentException(SR.GetString("net_invalid_enum", "SecurDll"), "dll");
	}

	public unsafe static int QueryContextAttributes(SecurDll dll, SafeDeleteContext phContext, ContextAttribute contextAttribute, byte* buffer, SafeHandle refHandle)
	{
		if (dll == SecurDll.SECURITY)
		{
			return QueryContextAttributes_SECURITY(phContext, contextAttribute, buffer, refHandle);
		}
		return -1;
	}

	private unsafe static int QueryContextAttributes_SECURITY(SafeDeleteContext phContext, ContextAttribute contextAttribute, byte* buffer, SafeHandle refHandle)
	{
		int num = -2146893055;
		bool success = false;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			phContext.DangerousAddRef(ref success);
		}
		catch (Exception ex)
		{
			if (success)
			{
				phContext.DangerousRelease();
				success = false;
			}
			if (!(ex is ObjectDisposedException))
			{
				throw;
			}
		}
		finally
		{
			if (success)
			{
				num = UnsafeNclNativeMethods.SafeNetHandles_SECURITY.QueryContextAttributesW(ref phContext._handle, contextAttribute, buffer);
				phContext.DangerousRelease();
			}
			if (num == 0 && refHandle != null)
			{
				if (refHandle is SafeFreeContextBuffer)
				{
					((SafeFreeContextBuffer)refHandle).Set(*(IntPtr*)buffer);
				}
				else
				{
					((SafeFreeCertContext)refHandle).Set(*(IntPtr*)buffer);
				}
			}
			if (num != 0)
			{
				refHandle?.SetHandleAsInvalid();
			}
		}
		return num;
	}

	public static int SetContextAttributes(SecurDll dll, SafeDeleteContext phContext, ContextAttribute contextAttribute, byte[] buffer)
	{
		if (dll == SecurDll.SECURITY)
		{
			return SetContextAttributes_SECURITY(phContext, contextAttribute, buffer);
		}
		return -1;
	}

	private static int SetContextAttributes_SECURITY(SafeDeleteContext phContext, ContextAttribute contextAttribute, byte[] buffer)
	{
		int result = -2146893055;
		bool success = false;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			phContext.DangerousAddRef(ref success);
		}
		catch (Exception ex)
		{
			if (success)
			{
				phContext.DangerousRelease();
				success = false;
			}
			if (!(ex is ObjectDisposedException))
			{
				throw;
			}
		}
		finally
		{
			if (success)
			{
				result = UnsafeNclNativeMethods.SafeNetHandles_SECURITY.SetContextAttributesW(ref phContext._handle, contextAttribute, buffer, buffer.Length);
				phContext.DangerousRelease();
			}
		}
		return result;
	}
}
