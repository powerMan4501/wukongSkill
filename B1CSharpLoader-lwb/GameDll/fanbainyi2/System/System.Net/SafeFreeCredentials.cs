using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Net;

internal abstract class SafeFreeCredentials : SafeHandle
{
	internal SSPIHandle _handle;

	public override bool IsInvalid
	{
		get
		{
			if (!base.IsClosed)
			{
				return _handle.IsZero;
			}
			return true;
		}
	}

	protected SafeFreeCredentials()
		: base(IntPtr.Zero, ownsHandle: true)
	{
		_handle = default(SSPIHandle);
	}

	public unsafe static int AcquireCredentialsHandle(SecurDll dll, string package, CredentialUse intent, ref AuthIdentity authdata, out SafeFreeCredentials outCredential)
	{
		int num = -1;
		if (dll == SecurDll.SECURITY)
		{
			outCredential = new SafeFreeCredential_SECURITY();
			RuntimeHelpers.PrepareConstrainedRegions();
			try
			{
			}
			finally
			{
				num = UnsafeNclNativeMethods.SafeNetHandles_SECURITY.AcquireCredentialsHandleW(null, package, (int)intent, null, ref authdata, null, null, ref outCredential._handle, out var _);
			}
			if (num != 0)
			{
				outCredential.SetHandleAsInvalid();
			}
			return num;
		}
		throw new ArgumentException(SR.GetString("net_invalid_enum", "SecurDll"), "Dll");
	}

	public unsafe static int AcquireDefaultCredential(SecurDll dll, string package, CredentialUse intent, out SafeFreeCredentials outCredential)
	{
		int num = -1;
		if (dll == SecurDll.SECURITY)
		{
			outCredential = new SafeFreeCredential_SECURITY();
			RuntimeHelpers.PrepareConstrainedRegions();
			try
			{
			}
			finally
			{
				num = UnsafeNclNativeMethods.SafeNetHandles_SECURITY.AcquireCredentialsHandleW(null, package, (int)intent, null, IntPtr.Zero, null, null, ref outCredential._handle, out var _);
			}
			if (num != 0)
			{
				outCredential.SetHandleAsInvalid();
			}
			return num;
		}
		throw new ArgumentException(SR.GetString("net_invalid_enum", "SecurDll"), "Dll");
	}

	public unsafe static int AcquireCredentialsHandle(string package, CredentialUse intent, ref SafeSspiAuthDataHandle authdata, out SafeFreeCredentials outCredential)
	{
		int num = -1;
		outCredential = new SafeFreeCredential_SECURITY();
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
		}
		finally
		{
			num = UnsafeNclNativeMethods.SafeNetHandles_SECURITY.AcquireCredentialsHandleW(null, package, (int)intent, null, authdata, null, null, ref outCredential._handle, out var _);
		}
		if (num != 0)
		{
			outCredential.SetHandleAsInvalid();
		}
		return num;
	}

	public unsafe static int AcquireCredentialsHandle(SecurDll dll, string package, CredentialUse intent, ref SecureCredential authdata, out SafeFreeCredentials outCredential)
	{
		int num = -1;
		IntPtr certContextArray = authdata.certContextArray;
		try
		{
			IntPtr certContextArray2 = new IntPtr(&certContextArray);
			if (certContextArray != IntPtr.Zero)
			{
				authdata.certContextArray = certContextArray2;
			}
			if (dll != SecurDll.SECURITY)
			{
				throw new ArgumentException(SR.GetString("net_invalid_enum", "SecurDll"), "Dll");
			}
			outCredential = new SafeFreeCredential_SECURITY();
			RuntimeHelpers.PrepareConstrainedRegions();
			try
			{
			}
			finally
			{
				num = UnsafeNclNativeMethods.SafeNetHandles_SECURITY.AcquireCredentialsHandleW(null, package, (int)intent, null, ref authdata, null, null, ref outCredential._handle, out var _);
			}
		}
		finally
		{
			authdata.certContextArray = certContextArray;
		}
		if (num != 0)
		{
			outCredential.SetHandleAsInvalid();
		}
		return num;
	}

	public unsafe static int AcquireCredentialsHandle(SecurDll dll, string package, CredentialUse intent, ref SecureCredential2 authdata, out SafeFreeCredentials outCredential)
	{
		int num = -1;
		if (dll == SecurDll.SECURITY)
		{
			outCredential = new SafeFreeCredential_SECURITY();
			RuntimeHelpers.PrepareConstrainedRegions();
			try
			{
			}
			finally
			{
				num = UnsafeNclNativeMethods.SafeNetHandles_SECURITY.AcquireCredentialsHandleW(null, package, (int)intent, null, ref authdata, null, null, ref outCredential._handle, out var _);
			}
			if (num != 0)
			{
				outCredential.SetHandleAsInvalid();
			}
			return num;
		}
		throw new ArgumentException(SR.GetString("net_invalid_enum", "SecurDll"), "Dll");
	}
}
