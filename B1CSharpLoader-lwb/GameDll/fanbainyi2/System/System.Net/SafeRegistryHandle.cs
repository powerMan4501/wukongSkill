using System.Security;
using Microsoft.Win32.SafeHandles;

namespace System.Net;

[SuppressUnmanagedCodeSecurity]
internal sealed class SafeRegistryHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	private uint resClose;

	private SafeRegistryHandle()
		: base(ownsHandle: true)
	{
	}

	internal static uint RegOpenKeyEx(IntPtr key, string subKey, uint ulOptions, uint samDesired, out SafeRegistryHandle resultSubKey)
	{
		return UnsafeNclNativeMethods.RegistryHelper.RegOpenKeyEx(key, subKey, ulOptions, samDesired, out resultSubKey);
	}

	internal uint RegOpenKeyEx(string subKey, uint ulOptions, uint samDesired, out SafeRegistryHandle resultSubKey)
	{
		return UnsafeNclNativeMethods.RegistryHelper.RegOpenKeyEx(this, subKey, ulOptions, samDesired, out resultSubKey);
	}

	internal uint RegCloseKey()
	{
		Close();
		return resClose;
	}

	internal uint QueryValue(string name, out object data)
	{
		data = null;
		byte[] array = null;
		uint size = 0u;
		uint num;
		uint type;
		while (true)
		{
			num = UnsafeNclNativeMethods.RegistryHelper.RegQueryValueEx(this, name, IntPtr.Zero, out type, array, ref size);
			if (num != 234 && (array != null || num != 0))
			{
				break;
			}
			array = new byte[size];
		}
		if (num != 0)
		{
			return num;
		}
		if (type == 3)
		{
			if (size != array.Length)
			{
				byte[] src = array;
				array = new byte[size];
				Buffer.BlockCopy(src, 0, array, 0, (int)size);
			}
			data = array;
			return 0u;
		}
		return 50u;
	}

	internal uint RegNotifyChangeKeyValue(bool watchSubTree, uint notifyFilter, SafeWaitHandle regEvent, bool async)
	{
		return UnsafeNclNativeMethods.RegistryHelper.RegNotifyChangeKeyValue(this, watchSubTree, notifyFilter, regEvent, async);
	}

	internal static uint RegOpenCurrentUser(uint samDesired, out SafeRegistryHandle resultKey)
	{
		return UnsafeNclNativeMethods.RegistryHelper.RegOpenCurrentUser(samDesired, out resultKey);
	}

	protected override bool ReleaseHandle()
	{
		if (!IsInvalid)
		{
			resClose = UnsafeNclNativeMethods.RegistryHelper.RegCloseKey(handle);
		}
		SetHandleAsInvalid();
		return true;
	}
}
