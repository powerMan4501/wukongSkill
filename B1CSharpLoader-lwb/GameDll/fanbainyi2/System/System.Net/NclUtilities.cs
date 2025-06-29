using System.Collections;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;

namespace System.Net;

internal static class NclUtilities
{
	private static volatile ContextCallback s_ContextRelativeDemandCallback;

	private static volatile IPAddress[] _LocalAddresses;

	private static object _LocalAddressesLock;

	private static volatile NetworkAddressChangePolled s_AddressChange;

	internal static bool HasShutdownStarted
	{
		get
		{
			if (!Environment.HasShutdownStarted)
			{
				return AppDomain.CurrentDomain.IsFinalizingForUnload();
			}
			return true;
		}
	}

	internal static ContextCallback ContextRelativeDemandCallback
	{
		get
		{
			if (s_ContextRelativeDemandCallback == null)
			{
				s_ContextRelativeDemandCallback = DemandCallback;
			}
			return s_ContextRelativeDemandCallback;
		}
	}

	internal static IPAddress[] LocalAddresses
	{
		get
		{
			if (s_AddressChange != null && s_AddressChange.CheckAndReset())
			{
				return _LocalAddresses = GetLocalAddresses();
			}
			if (_LocalAddresses != null)
			{
				return _LocalAddresses;
			}
			lock (LocalAddressesLock)
			{
				if (_LocalAddresses != null)
				{
					return _LocalAddresses;
				}
				s_AddressChange = new NetworkAddressChangePolled();
				return _LocalAddresses = GetLocalAddresses();
			}
		}
	}

	private static object LocalAddressesLock
	{
		get
		{
			if (_LocalAddressesLock == null)
			{
				Interlocked.CompareExchange(ref _LocalAddressesLock, new object(), null);
			}
			return _LocalAddressesLock;
		}
	}

	internal static bool IsThreadPoolLow()
	{
		if (ComNetOS.IsAspNetServer)
		{
			return false;
		}
		ThreadPool.GetAvailableThreads(out var workerThreads, out var completionPortThreads);
		if (workerThreads >= 2)
		{
			return completionPortThreads < 2;
		}
		return true;
	}

	internal static bool IsCredentialFailure(SecurityStatus error)
	{
		if (error != SecurityStatus.LogonDenied && error != SecurityStatus.UnknownCredentials && error != SecurityStatus.NoImpersonation && error != SecurityStatus.NoAuthenticatingAuthority && error != SecurityStatus.UntrustedRoot && error != SecurityStatus.CertExpired && error != SecurityStatus.SmartcardLogonRequired)
		{
			return error == SecurityStatus.BadBinding;
		}
		return true;
	}

	internal static bool IsClientFault(SecurityStatus error)
	{
		if (error != SecurityStatus.InvalidToken && error != SecurityStatus.CannotPack && error != SecurityStatus.QopNotSupported && error != SecurityStatus.NoCredentials && error != SecurityStatus.MessageAltered && error != SecurityStatus.OutOfSequence && error != SecurityStatus.IncompleteMessage && error != SecurityStatus.IncompleteCredentials && error != SecurityStatus.WrongPrincipal && error != SecurityStatus.TimeSkew && error != SecurityStatus.IllegalMessage && error != SecurityStatus.CertUnknown && error != SecurityStatus.AlgorithmMismatch && error != SecurityStatus.SecurityQosFailed)
		{
			return error == SecurityStatus.UnsupportedPreauth;
		}
		return true;
	}

	private static void DemandCallback(object state)
	{
		((CodeAccessPermission)state).Demand();
	}

	internal static bool GuessWhetherHostIsLoopback(string host)
	{
		string text = host.ToLowerInvariant();
		if (text == "localhost" || text == "loopback")
		{
			return true;
		}
		IPGlobalProperties iPGlobalProperties = IPGlobalProperties.InternalGetIPGlobalProperties();
		string text2 = iPGlobalProperties.HostName.ToLowerInvariant();
		if (!(text == text2))
		{
			return text == text2 + "." + iPGlobalProperties.DomainName.ToLowerInvariant();
		}
		return true;
	}

	internal static bool IsFatal(Exception exception)
	{
		if (exception != null)
		{
			if (!(exception is OutOfMemoryException) && !(exception is StackOverflowException))
			{
				return exception is ThreadAbortException;
			}
			return true;
		}
		return false;
	}

	private static IPAddress[] GetLocalAddresses()
	{
		ArrayList arrayList = new ArrayList(16);
		int num = 0;
		SafeLocalFree safeLocalFree = null;
		GetAdaptersAddressesFlags flags = GetAdaptersAddressesFlags.SkipAnycast | GetAdaptersAddressesFlags.SkipMulticast | GetAdaptersAddressesFlags.SkipDnsServer | GetAdaptersAddressesFlags.SkipFriendlyName;
		uint outBufLen = 0u;
		uint adaptersAddresses = UnsafeNetInfoNativeMethods.GetAdaptersAddresses(AddressFamily.Unspecified, (uint)flags, IntPtr.Zero, SafeLocalFree.Zero, ref outBufLen);
		while (true)
		{
			switch (adaptersAddresses)
			{
			case 111u:
				try
				{
					safeLocalFree = SafeLocalFree.LocalAlloc((int)outBufLen);
					adaptersAddresses = UnsafeNetInfoNativeMethods.GetAdaptersAddresses(AddressFamily.Unspecified, (uint)flags, IntPtr.Zero, safeLocalFree, ref outBufLen);
					if (adaptersAddresses != 0)
					{
						break;
					}
					IntPtr intPtr = safeLocalFree.DangerousGetHandle();
					while (intPtr != IntPtr.Zero)
					{
						IpAdapterAddresses ipAdapterAddresses = (IpAdapterAddresses)Marshal.PtrToStructure(intPtr, typeof(IpAdapterAddresses));
						if (ipAdapterAddresses.firstUnicastAddress != IntPtr.Zero)
						{
							UnicastIPAddressInformationCollection unicastIPAddressInformationCollection2 = SystemUnicastIPAddressInformation.MarshalUnicastIpAddressInformationCollection(ipAdapterAddresses.firstUnicastAddress);
							num += unicastIPAddressInformationCollection2.Count;
							arrayList.Add(unicastIPAddressInformationCollection2);
						}
						intPtr = ipAdapterAddresses.next;
					}
				}
				finally
				{
					safeLocalFree?.Close();
					safeLocalFree = null;
				}
				break;
			default:
				throw new NetworkInformationException((int)adaptersAddresses);
			case 0u:
			case 232u:
			{
				IPAddress[] array = new IPAddress[num];
				uint num2 = 0u;
				{
					foreach (UnicastIPAddressInformationCollection item in arrayList)
					{
						foreach (UnicastIPAddressInformation item2 in item)
						{
							array[num2++] = item2.Address;
						}
					}
					return array;
				}
			}
			}
		}
	}

	internal static bool IsAddressLocal(IPAddress ipAddress)
	{
		IPAddress[] localAddresses = LocalAddresses;
		for (int i = 0; i < localAddresses.Length; i++)
		{
			if (ipAddress.Equals(localAddresses[i], compareScopeId: false))
			{
				return true;
			}
		}
		return false;
	}
}
