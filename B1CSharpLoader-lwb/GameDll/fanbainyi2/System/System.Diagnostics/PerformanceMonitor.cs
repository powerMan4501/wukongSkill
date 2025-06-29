using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Threading;
using Microsoft.Win32;

namespace System.Diagnostics;

internal class PerformanceMonitor
{
	private RegistryKey perfDataKey;

	private string machineName;

	internal PerformanceMonitor(string machineName)
	{
		this.machineName = machineName;
		Init();
	}

	private void Init()
	{
		try
		{
			if (machineName != "." && string.Compare(machineName, PerformanceCounterLib.ComputerName, StringComparison.OrdinalIgnoreCase) != 0)
			{
				new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).Assert();
				perfDataKey = RegistryKey.OpenRemoteBaseKey(RegistryHive.PerformanceData, machineName);
			}
			else
			{
				perfDataKey = Registry.PerformanceData;
			}
		}
		catch (UnauthorizedAccessException)
		{
			throw new Win32Exception(5);
		}
		catch (IOException e)
		{
			throw new Win32Exception(Marshal.GetHRForException(e));
		}
	}

	internal void Close()
	{
		if (perfDataKey != null)
		{
			perfDataKey.Close();
		}
		perfDataKey = null;
	}

	internal byte[] GetData(string item)
	{
		int num = 17;
		int num2 = 0;
		byte[] array = null;
		int num3 = 0;
		new RegistryPermission(PermissionState.Unrestricted).Assert();
		while (num > 0)
		{
			try
			{
				return (byte[])perfDataKey.GetValue(item);
			}
			catch (IOException e)
			{
				num3 = Marshal.GetHRForException(e);
				if (num3 <= 167)
				{
					if (num3 == 6)
					{
						goto IL_0083;
					}
					if (num3 == 21 || num3 == 167)
					{
						goto IL_0089;
					}
				}
				else if (num3 <= 258)
				{
					if (num3 == 170 || num3 == 258)
					{
						goto IL_0089;
					}
				}
				else if (num3 == 1722 || num3 == 1726)
				{
					goto IL_0083;
				}
				throw SharedUtils.CreateSafeWin32Exception(num3);
				IL_0089:
				num--;
				if (num2 == 0)
				{
					num2 = 10;
					continue;
				}
				Thread.Sleep(num2);
				num2 *= 2;
				goto end_IL_0034;
				IL_0083:
				Init();
				goto IL_0089;
				end_IL_0034:;
			}
			catch (InvalidCastException innerException)
			{
				throw new InvalidOperationException(SR.GetString("CounterDataCorrupt", perfDataKey.ToString()), innerException);
			}
		}
		throw SharedUtils.CreateSafeWin32Exception(num3);
	}
}
