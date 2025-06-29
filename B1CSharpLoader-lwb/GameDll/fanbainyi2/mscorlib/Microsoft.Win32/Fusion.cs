using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Win32;

internal static class Fusion
{
	[SecurityCritical]
	public static void ReadCache(ArrayList alAssems, string name, uint nFlag)
	{
		IAssemblyEnum ppEnum = null;
		IAssemblyName ppName = null;
		IAssemblyName ppEnum2 = null;
		IApplicationContext ppAppCtx = null;
		int num;
		if (name != null)
		{
			num = Win32Native.CreateAssemblyNameObject(out ppEnum2, name, 1u, IntPtr.Zero);
			if (num != 0)
			{
				Marshal.ThrowExceptionForHR(num);
			}
		}
		num = Win32Native.CreateAssemblyEnum(out ppEnum, ppAppCtx, ppEnum2, nFlag, IntPtr.Zero);
		if (num != 0)
		{
			Marshal.ThrowExceptionForHR(num);
		}
		while (true)
		{
			num = ppEnum.GetNextAssembly(out ppAppCtx, out ppName, 0u);
			if (num != 0)
			{
				break;
			}
			string displayName = GetDisplayName(ppName, 0u);
			if (displayName != null)
			{
				alAssems.Add(displayName);
			}
		}
		if (num < 0)
		{
			Marshal.ThrowExceptionForHR(num);
		}
	}

	[SecuritySafeCritical]
	private unsafe static string GetDisplayName(IAssemblyName aName, uint dwDisplayFlags)
	{
		uint pccDisplayName = 0u;
		string result = null;
		aName.GetDisplayName((IntPtr)0, ref pccDisplayName, dwDisplayFlags);
		if (pccDisplayName != 0)
		{
			IntPtr intPtr = (IntPtr)0;
			fixed (byte* value = new byte[(pccDisplayName + 1) * 2])
			{
				intPtr = new IntPtr(value);
				aName.GetDisplayName(intPtr, ref pccDisplayName, dwDisplayFlags);
				result = Marshal.PtrToStringUni(intPtr);
			}
		}
		return result;
	}
}
