using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.AccessControl;
using System.Security.Permissions;
using System.Security.Principal;
using System.Text;
using System.Threading;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace System.Diagnostics;

internal static class SharedUtils
{
	internal const int UnknownEnvironment = 0;

	internal const int W2kEnvironment = 1;

	internal const int NtEnvironment = 2;

	internal const int NonNtEnvironment = 3;

	private static volatile int environment;

	private static object s_InternalSyncObject;

	private static object InternalSyncObject
	{
		get
		{
			if (s_InternalSyncObject == null)
			{
				object value = new object();
				Interlocked.CompareExchange(ref s_InternalSyncObject, value, null);
			}
			return s_InternalSyncObject;
		}
	}

	internal static int CurrentEnvironment
	{
		get
		{
			if (environment == 0)
			{
				lock (InternalSyncObject)
				{
					if (environment == 0)
					{
						if (Environment.OSVersion.Platform == PlatformID.Win32NT)
						{
							if (Environment.OSVersion.Version.Major >= 5)
							{
								environment = 1;
							}
							else
							{
								environment = 2;
							}
						}
						else
						{
							environment = 3;
						}
					}
				}
			}
			return environment;
		}
	}

	internal static Win32Exception CreateSafeWin32Exception()
	{
		return CreateSafeWin32Exception(0);
	}

	internal static Win32Exception CreateSafeWin32Exception(int error)
	{
		Win32Exception result = null;
		SecurityPermission securityPermission = new SecurityPermission(PermissionState.Unrestricted);
		securityPermission.Assert();
		try
		{
			result = ((error != 0) ? new Win32Exception(error) : new Win32Exception());
		}
		finally
		{
			CodeAccessPermission.RevertAssert();
		}
		return result;
	}

	internal static void CheckEnvironment()
	{
		if (CurrentEnvironment == 3)
		{
			throw new PlatformNotSupportedException(SR.GetString("WinNTRequired"));
		}
	}

	internal static void CheckNtEnvironment()
	{
		if (CurrentEnvironment == 2)
		{
			throw new PlatformNotSupportedException(SR.GetString("Win2000Required"));
		}
	}

	internal static void EnterMutex(string name, ref Mutex mutex)
	{
		string text = null;
		text = ((CurrentEnvironment != 1) ? name : ("Global\\" + name));
		EnterMutexWithoutGlobal(text, ref mutex);
	}

	[SecurityPermission(SecurityAction.Assert, ControlPrincipal = true)]
	internal static void EnterMutexWithoutGlobal(string mutexName, ref Mutex mutex)
	{
		MutexSecurity mutexSecurity = new MutexSecurity();
		SecurityIdentifier identity = new SecurityIdentifier(WellKnownSidType.AuthenticatedUserSid, null);
		mutexSecurity.AddAccessRule(new MutexAccessRule(identity, MutexRights.Modify | MutexRights.Synchronize, AccessControlType.Allow));
		bool createdNew;
		Mutex mutexIn = new Mutex(initiallyOwned: false, mutexName, out createdNew, mutexSecurity);
		SafeWaitForMutex(mutexIn, ref mutex);
	}

	private static bool SafeWaitForMutex(Mutex mutexIn, ref Mutex mutexOut)
	{
		while (true)
		{
			if (!SafeWaitForMutexOnce(mutexIn, ref mutexOut))
			{
				return false;
			}
			if (mutexOut != null)
			{
				break;
			}
			Thread.Sleep(0);
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool SafeWaitForMutexOnce(Mutex mutexIn, ref Mutex mutexOut)
	{
		RuntimeHelpers.PrepareConstrainedRegions();
		bool result;
		try
		{
		}
		finally
		{
			Thread.BeginCriticalRegion();
			Thread.BeginThreadAffinity();
			switch (WaitForSingleObjectDontCallThis(mutexIn.SafeWaitHandle, 500))
			{
			case 0:
			case 128:
				mutexOut = mutexIn;
				result = true;
				break;
			case 258:
				result = true;
				break;
			default:
				result = false;
				break;
			}
			if (mutexOut == null)
			{
				Thread.EndThreadAffinity();
				Thread.EndCriticalRegion();
			}
		}
		return result;
	}

	[DllImport("kernel32.dll", EntryPoint = "WaitForSingleObject", ExactSpelling = true, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	private static extern int WaitForSingleObjectDontCallThis(SafeWaitHandle handle, int timeout);

	internal static string GetLatestBuildDllDirectory(string machineName)
	{
		string result = "";
		RegistryKey registryKey = null;
		RegistryKey registryKey2 = null;
		RegistryPermission registryPermission = new RegistryPermission(PermissionState.Unrestricted);
		registryPermission.Assert();
		try
		{
			if (machineName.Equals("."))
			{
				return GetLocalBuildDirectory();
			}
			registryKey = RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, machineName);
			if (registryKey == null)
			{
				throw new InvalidOperationException(SR.GetString("RegKeyMissingShort", "HKEY_LOCAL_MACHINE", machineName));
			}
			registryKey2 = registryKey.OpenSubKey("SOFTWARE\\Microsoft\\.NETFramework");
			if (registryKey2 != null)
			{
				string text = (string)registryKey2.GetValue("InstallRoot");
				if (text != null && text != string.Empty)
				{
					string text2 = "v" + Environment.Version.Major + "." + Environment.Version.Minor;
					RegistryKey registryKey3 = registryKey2.OpenSubKey("policy");
					string text3 = null;
					if (registryKey3 != null)
					{
						try
						{
							RegistryKey registryKey4 = registryKey3.OpenSubKey(text2);
							if (registryKey4 != null)
							{
								try
								{
									text3 = text2 + "." + GetLargestBuildNumberFromKey(registryKey4);
								}
								finally
								{
									registryKey4.Close();
								}
							}
							else
							{
								string[] subKeyNames = registryKey3.GetSubKeyNames();
								int[] array = new int[3] { -1, -1, -1 };
								foreach (string text4 in subKeyNames)
								{
									if (text4.Length <= 1 || text4[0] != 'v' || !text4.Contains("."))
									{
										continue;
									}
									int[] array2 = new int[3] { -1, -1, -1 };
									string[] array3 = text4.Substring(1).Split('.');
									if (array3.Length != 2 || !int.TryParse(array3[0], out array2[0]) || !int.TryParse(array3[1], out array2[1]))
									{
										continue;
									}
									RegistryKey registryKey5 = registryKey3.OpenSubKey(text4);
									if (registryKey5 == null)
									{
										continue;
									}
									try
									{
										array2[2] = GetLargestBuildNumberFromKey(registryKey5);
										if (array2[0] > array[0] || (array2[0] == array[0] && array2[1] > array[1]))
										{
											array = array2;
										}
									}
									finally
									{
										registryKey5.Close();
									}
								}
								text3 = "v" + array[0] + "." + array[1] + "." + array[2];
							}
						}
						finally
						{
							registryKey3.Close();
						}
						if (text3 != null && text3 != string.Empty)
						{
							StringBuilder stringBuilder = new StringBuilder();
							stringBuilder.Append(text);
							if (!text.EndsWith("\\", StringComparison.Ordinal))
							{
								stringBuilder.Append("\\");
							}
							stringBuilder.Append(text3);
							result = stringBuilder.ToString();
						}
					}
				}
			}
		}
		catch
		{
		}
		finally
		{
			registryKey2?.Close();
			registryKey?.Close();
			CodeAccessPermission.RevertAssert();
		}
		return result;
	}

	private static int GetLargestBuildNumberFromKey(RegistryKey rootKey)
	{
		int num = -1;
		string[] valueNames = rootKey.GetValueNames();
		for (int i = 0; i < valueNames.Length; i++)
		{
			if (int.TryParse(valueNames[i], out var result))
			{
				num = ((num > result) ? num : result);
			}
		}
		return num;
	}

	private static string GetLocalBuildDirectory()
	{
		return RuntimeEnvironment.GetRuntimeDirectory();
	}
}
