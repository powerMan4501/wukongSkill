using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace System.Security.Principal;

internal static class Win32
{
	internal const int FALSE = 0;

	internal const int TRUE = 1;

	private static bool _LsaLookupNames2Supported;

	private static bool _WellKnownSidApisSupported;

	internal static bool LsaLookupNames2Supported => _LsaLookupNames2Supported;

	internal static bool WellKnownSidApisSupported => _WellKnownSidApisSupported;

	[SecuritySafeCritical]
	static Win32()
	{
		Win32Native.OSVERSIONINFO oSVERSIONINFO = new Win32Native.OSVERSIONINFO();
		if (!Environment.GetVersion(oSVERSIONINFO))
		{
			throw new SystemException(Environment.GetResourceString("InvalidOperation_GetVersion"));
		}
		if (oSVERSIONINFO.MajorVersion > 5 || oSVERSIONINFO.MinorVersion > 0)
		{
			_LsaLookupNames2Supported = true;
			_WellKnownSidApisSupported = true;
			return;
		}
		_LsaLookupNames2Supported = false;
		Win32Native.OSVERSIONINFOEX oSVERSIONINFOEX = new Win32Native.OSVERSIONINFOEX();
		if (!Environment.GetVersionEx(oSVERSIONINFOEX))
		{
			throw new SystemException(Environment.GetResourceString("InvalidOperation_GetVersion"));
		}
		if (oSVERSIONINFOEX.ServicePackMajor < 3)
		{
			_WellKnownSidApisSupported = false;
		}
		else
		{
			_WellKnownSidApisSupported = true;
		}
	}

	[SecurityCritical]
	internal static SafeLsaPolicyHandle LsaOpenPolicy(string systemName, PolicyRights rights)
	{
		Win32Native.LSA_OBJECT_ATTRIBUTES attributes = default(Win32Native.LSA_OBJECT_ATTRIBUTES);
		attributes.Length = Marshal.SizeOf(typeof(Win32Native.LSA_OBJECT_ATTRIBUTES));
		attributes.RootDirectory = IntPtr.Zero;
		attributes.ObjectName = IntPtr.Zero;
		attributes.Attributes = 0;
		attributes.SecurityDescriptor = IntPtr.Zero;
		attributes.SecurityQualityOfService = IntPtr.Zero;
		uint num;
		if ((num = Win32Native.LsaOpenPolicy(systemName, ref attributes, (int)rights, out var handle)) == 0)
		{
			return handle;
		}
		switch (num)
		{
		case 3221225506u:
			throw new UnauthorizedAccessException();
		case 3221225495u:
		case 3221225626u:
			throw new OutOfMemoryException();
		default:
		{
			int errorCode = Win32Native.LsaNtStatusToWinError((int)num);
			throw new SystemException(Win32Native.GetMessage(errorCode));
		}
		}
	}

	[SecurityCritical]
	internal static byte[] ConvertIntPtrSidToByteArraySid(IntPtr binaryForm)
	{
		byte b = Marshal.ReadByte(binaryForm, 0);
		if (b != SecurityIdentifier.Revision)
		{
			throw new ArgumentException(Environment.GetResourceString("IdentityReference_InvalidSidRevision"), "binaryForm");
		}
		byte b2 = Marshal.ReadByte(binaryForm, 1);
		if (b2 < 0 || b2 > SecurityIdentifier.MaxSubAuthorities)
		{
			throw new ArgumentException(Environment.GetResourceString("IdentityReference_InvalidNumberOfSubauthorities", SecurityIdentifier.MaxSubAuthorities), "binaryForm");
		}
		int num = 8 + b2 * 4;
		byte[] array = new byte[num];
		Marshal.Copy(binaryForm, array, 0, num);
		return array;
	}

	[SecurityCritical]
	internal static int CreateSidFromString(string stringSid, out byte[] resultSid)
	{
		IntPtr ByteArray = IntPtr.Zero;
		int lastWin32Error;
		try
		{
			if (1 != Win32Native.ConvertStringSidToSid(stringSid, out ByteArray))
			{
				lastWin32Error = Marshal.GetLastWin32Error();
				goto IL_002d;
			}
			resultSid = ConvertIntPtrSidToByteArraySid(ByteArray);
		}
		finally
		{
			Win32Native.LocalFree(ByteArray);
		}
		return 0;
		IL_002d:
		resultSid = null;
		return lastWin32Error;
	}

	[SecurityCritical]
	internal static int CreateWellKnownSid(WellKnownSidType sidType, SecurityIdentifier domainSid, out byte[] resultSid)
	{
		if (!WellKnownSidApisSupported)
		{
			throw new PlatformNotSupportedException(Environment.GetResourceString("PlatformNotSupported_RequiresW2kSP3"));
		}
		uint resultSidLength = (uint)SecurityIdentifier.MaxBinaryLength;
		resultSid = new byte[resultSidLength];
		if (Win32Native.CreateWellKnownSid((int)sidType, (domainSid == null) ? null : domainSid.BinaryForm, resultSid, ref resultSidLength) != 0)
		{
			return 0;
		}
		resultSid = null;
		return Marshal.GetLastWin32Error();
	}

	[SecurityCritical]
	internal static bool IsEqualDomainSid(SecurityIdentifier sid1, SecurityIdentifier sid2)
	{
		if (!WellKnownSidApisSupported)
		{
			throw new PlatformNotSupportedException(Environment.GetResourceString("PlatformNotSupported_RequiresW2kSP3"));
		}
		if (sid1 == null || sid2 == null)
		{
			return false;
		}
		byte[] array = new byte[sid1.BinaryLength];
		sid1.GetBinaryForm(array, 0);
		byte[] array2 = new byte[sid2.BinaryLength];
		sid2.GetBinaryForm(array2, 0);
		if (Win32Native.IsEqualDomainSid(array, array2, out var result) != 0)
		{
			return result;
		}
		return false;
	}

	[SecurityCritical]
	internal unsafe static void InitializeReferencedDomainsPointer(SafeLsaMemoryHandle referencedDomains)
	{
		referencedDomains.Initialize((uint)Marshal.SizeOf(typeof(Win32Native.LSA_REFERENCED_DOMAIN_LIST)));
		Win32Native.LSA_REFERENCED_DOMAIN_LIST lSA_REFERENCED_DOMAIN_LIST = referencedDomains.Read<Win32Native.LSA_REFERENCED_DOMAIN_LIST>(0uL);
		byte* pointer = null;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			referencedDomains.AcquirePointer(ref pointer);
			if (!lSA_REFERENCED_DOMAIN_LIST.Domains.IsNull())
			{
				Win32Native.LSA_TRUST_INFORMATION* ptr = (Win32Native.LSA_TRUST_INFORMATION*)(void*)lSA_REFERENCED_DOMAIN_LIST.Domains;
				ptr += lSA_REFERENCED_DOMAIN_LIST.Entries;
				long numBytes = (byte*)ptr - pointer;
				referencedDomains.Initialize((ulong)numBytes);
			}
		}
		finally
		{
			if (pointer != null)
			{
				referencedDomains.ReleasePointer();
			}
		}
	}

	[SecurityCritical]
	internal static int GetWindowsAccountDomainSid(SecurityIdentifier sid, out SecurityIdentifier resultSid)
	{
		if (!WellKnownSidApisSupported)
		{
			throw new PlatformNotSupportedException(Environment.GetResourceString("PlatformNotSupported_RequiresW2kSP3"));
		}
		byte[] array = new byte[sid.BinaryLength];
		sid.GetBinaryForm(array, 0);
		uint resultSidLength = (uint)SecurityIdentifier.MaxBinaryLength;
		byte[] array2 = new byte[resultSidLength];
		if (Win32Native.GetWindowsAccountDomainSid(array, array2, ref resultSidLength) != 0)
		{
			resultSid = new SecurityIdentifier(array2, 0);
			return 0;
		}
		resultSid = null;
		return Marshal.GetLastWin32Error();
	}

	[SecurityCritical]
	internal static bool IsWellKnownSid(SecurityIdentifier sid, WellKnownSidType type)
	{
		if (!WellKnownSidApisSupported)
		{
			throw new PlatformNotSupportedException(Environment.GetResourceString("PlatformNotSupported_RequiresW2kSP3"));
		}
		byte[] array = new byte[sid.BinaryLength];
		sid.GetBinaryForm(array, 0);
		if (Win32Native.IsWellKnownSid(array, (int)type) == 0)
		{
			return false;
		}
		return true;
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	internal static extern int ImpersonateLoggedOnUser(SafeAccessTokenHandle hToken);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern int OpenThreadToken(TokenAccessLevels dwDesiredAccess, WinSecurityContext OpenAs, out SafeAccessTokenHandle phThreadToken);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	internal static extern int RevertToSelf();

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	internal static extern int SetThreadToken(SafeAccessTokenHandle hToken);
}
