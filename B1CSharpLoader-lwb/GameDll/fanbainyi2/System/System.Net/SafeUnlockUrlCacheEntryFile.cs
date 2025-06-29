using System.Net.Cache;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace System.Net;

internal sealed class SafeUnlockUrlCacheEntryFile : SafeHandleZeroOrMinusOneIsInvalid
{
	private string m_KeyString;

	private SafeUnlockUrlCacheEntryFile(string keyString)
		: base(ownsHandle: true)
	{
		m_KeyString = keyString;
	}

	protected unsafe override bool ReleaseHandle()
	{
		fixed (char* keyString = m_KeyString)
		{
			UnsafeNclNativeMethods.SafeNetHandles.UnlockUrlCacheEntryFileW(keyString, 0);
		}
		SetHandle(IntPtr.Zero);
		m_KeyString = null;
		return true;
	}

	internal unsafe static _WinInetCache.Status GetAndLockFile(string key, byte* entryPtr, ref int entryBufSize, out SafeUnlockUrlCacheEntryFile handle)
	{
		if (ValidationHelper.IsBlankString(key))
		{
			throw new ArgumentNullException("key");
		}
		handle = new SafeUnlockUrlCacheEntryFile(key);
		fixed (char* key2 = key)
		{
			return MustRunGetAndLockFile(key2, entryPtr, ref entryBufSize, handle);
		}
	}

	private unsafe static _WinInetCache.Status MustRunGetAndLockFile(char* key, byte* entryPtr, ref int entryBufSize, SafeUnlockUrlCacheEntryFile handle)
	{
		_WinInetCache.Status result = _WinInetCache.Status.Success;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
		}
		finally
		{
			if (!UnsafeNclNativeMethods.SafeNetHandles.RetrieveUrlCacheEntryFileW(key, entryPtr, ref entryBufSize, 0))
			{
				result = (_WinInetCache.Status)Marshal.GetLastWin32Error();
				handle.SetHandleAsInvalid();
			}
			else
			{
				handle.SetHandle((IntPtr)1);
			}
		}
		return result;
	}
}
