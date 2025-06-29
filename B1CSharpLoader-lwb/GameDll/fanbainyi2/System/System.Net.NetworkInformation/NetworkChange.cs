using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Net.Sockets;
using System.Threading;

namespace System.Net.NetworkInformation;

[global::__DynamicallyInvokable]
public class NetworkChange
{
	internal static class AvailabilityChangeListener
	{
		private static ListDictionary s_availabilityCallerArray = new ListDictionary();

		private static NetworkAddressChangedEventHandler addressChange = ChangedAddress;

		private static volatile bool isAvailable = false;

		private static ContextCallback s_RunHandlerCallback = RunHandlerCallback;

		private static void RunHandlerCallback(object state)
		{
			((NetworkAvailabilityChangedEventHandler)state)(null, new NetworkAvailabilityEventArgs(isAvailable));
		}

		private static void ChangedAddress(object sender, EventArgs eventArgs)
		{
			DictionaryEntry[] array = null;
			lock (s_globalLock)
			{
				bool flag = SystemNetworkInterface.InternalGetIsNetworkAvailable();
				if (flag != isAvailable)
				{
					isAvailable = flag;
					array = new DictionaryEntry[s_availabilityCallerArray.Count];
					s_availabilityCallerArray.CopyTo(array, 0);
				}
			}
			if (array == null)
			{
				return;
			}
			lock (s_protectCallbackLock)
			{
				DictionaryEntry[] array2 = array;
				for (int i = 0; i < array2.Length; i++)
				{
					DictionaryEntry dictionaryEntry = array2[i];
					NetworkAvailabilityChangedEventHandler networkAvailabilityChangedEventHandler = (NetworkAvailabilityChangedEventHandler)dictionaryEntry.Key;
					ExecutionContext executionContext = (ExecutionContext)dictionaryEntry.Value;
					if (executionContext == null)
					{
						networkAvailabilityChangedEventHandler(null, new NetworkAvailabilityEventArgs(isAvailable));
					}
					else
					{
						ExecutionContext.Run(executionContext.CreateCopy(), s_RunHandlerCallback, networkAvailabilityChangedEventHandler);
					}
				}
			}
		}

		internal static void Start(NetworkAvailabilityChangedEventHandler caller)
		{
			lock (s_globalLock)
			{
				if (s_availabilityCallerArray.Count == 0)
				{
					isAvailable = NetworkInterface.GetIsNetworkAvailable();
					AddressChangeListener.UnsafeStart(addressChange);
				}
				if (caller != null && !s_availabilityCallerArray.Contains(caller))
				{
					s_availabilityCallerArray.Add(caller, ExecutionContext.Capture());
				}
			}
		}

		internal static void Stop(NetworkAvailabilityChangedEventHandler caller)
		{
			lock (s_globalLock)
			{
				s_availabilityCallerArray.Remove(caller);
				if (s_availabilityCallerArray.Count == 0)
				{
					AddressChangeListener.Stop(addressChange);
				}
			}
		}
	}

	internal static class AddressChangeListener
	{
		private static ListDictionary s_callerArray = new ListDictionary();

		private static ContextCallback s_runHandlerCallback = RunHandlerCallback;

		private static RegisteredWaitHandle s_registeredWait;

		private static bool s_isListening = false;

		private static bool s_isPending = false;

		private static SafeCloseSocketAndEvent s_ipv4Socket = null;

		private static SafeCloseSocketAndEvent s_ipv6Socket = null;

		private static WaitHandle s_ipv4WaitHandle = null;

		private static WaitHandle s_ipv6WaitHandle = null;

		private static void AddressChangedCallback(object stateObject, bool signaled)
		{
			DictionaryEntry[] array = null;
			lock (s_globalLock)
			{
				s_isPending = false;
				if (!s_isListening)
				{
					return;
				}
				s_isListening = false;
				if (s_callerArray.Count > 0)
				{
					array = new DictionaryEntry[s_callerArray.Count];
					s_callerArray.CopyTo(array, 0);
				}
				try
				{
					StartHelper(null, captureContext: false, (StartIPOptions)stateObject);
				}
				catch (NetworkInformationException e)
				{
					if (Logging.On)
					{
						Logging.Exception(Logging.Web, "AddressChangeListener", "AddressChangedCallback", e);
					}
				}
			}
			if (array == null)
			{
				return;
			}
			lock (s_protectCallbackLock)
			{
				DictionaryEntry[] array2 = array;
				for (int i = 0; i < array2.Length; i++)
				{
					DictionaryEntry dictionaryEntry = array2[i];
					NetworkAddressChangedEventHandler networkAddressChangedEventHandler = (NetworkAddressChangedEventHandler)dictionaryEntry.Key;
					ExecutionContext executionContext = (ExecutionContext)dictionaryEntry.Value;
					if (executionContext == null)
					{
						networkAddressChangedEventHandler(null, EventArgs.Empty);
					}
					else
					{
						ExecutionContext.Run(executionContext.CreateCopy(), s_runHandlerCallback, networkAddressChangedEventHandler);
					}
				}
			}
		}

		private static void RunHandlerCallback(object state)
		{
			((NetworkAddressChangedEventHandler)state)(null, EventArgs.Empty);
		}

		internal static void Start(NetworkAddressChangedEventHandler caller)
		{
			StartHelper(caller, captureContext: true, StartIPOptions.Both);
		}

		internal static void UnsafeStart(NetworkAddressChangedEventHandler caller)
		{
			StartHelper(caller, captureContext: false, StartIPOptions.Both);
		}

		private static void StartHelper(NetworkAddressChangedEventHandler caller, bool captureContext, StartIPOptions startIPOptions)
		{
			lock (s_globalLock)
			{
				if (s_ipv4Socket == null)
				{
					Socket.InitializeSockets();
					if (Socket.OSSupportsIPv4)
					{
						int argp = -1;
						s_ipv4Socket = SafeCloseSocketAndEvent.CreateWSASocketWithEvent(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.IP, autoReset: true, signaled: false);
						UnsafeNclNativeMethods.OSSOCK.ioctlsocket(s_ipv4Socket, -2147195266, ref argp);
						s_ipv4WaitHandle = s_ipv4Socket.GetEventHandle();
					}
					if (Socket.OSSupportsIPv6)
					{
						int argp = -1;
						s_ipv6Socket = SafeCloseSocketAndEvent.CreateWSASocketWithEvent(AddressFamily.InterNetworkV6, SocketType.Dgram, ProtocolType.IP, autoReset: true, signaled: false);
						UnsafeNclNativeMethods.OSSOCK.ioctlsocket(s_ipv6Socket, -2147195266, ref argp);
						s_ipv6WaitHandle = s_ipv6Socket.GetEventHandle();
					}
				}
				if (caller != null && !s_callerArray.Contains(caller))
				{
					s_callerArray.Add(caller, captureContext ? ExecutionContext.Capture() : null);
				}
				if (s_isListening || s_callerArray.Count == 0)
				{
					return;
				}
				if (!s_isPending)
				{
					int bytesTransferred;
					if (Socket.OSSupportsIPv4 && (startIPOptions & StartIPOptions.StartIPv4) != StartIPOptions.None)
					{
						s_registeredWait = ThreadPool.UnsafeRegisterWaitForSingleObject(s_ipv4WaitHandle, AddressChangedCallback, StartIPOptions.StartIPv4, -1, executeOnlyOnce: true);
						if (UnsafeNclNativeMethods.OSSOCK.WSAIoctl_Blocking(s_ipv4Socket.DangerousGetHandle(), 671088663, null, 0, null, 0, out bytesTransferred, SafeNativeOverlapped.Zero, IntPtr.Zero) != SocketError.Success)
						{
							NetworkInformationException ex = new NetworkInformationException();
							if ((long)ex.ErrorCode != 10035)
							{
								throw ex;
							}
						}
						if (UnsafeNclNativeMethods.OSSOCK.WSAEventSelect(s_ipv4Socket, s_ipv4Socket.GetEventHandle().SafeWaitHandle, AsyncEventBits.FdAddressListChange) != SocketError.Success)
						{
							throw new NetworkInformationException();
						}
					}
					if (Socket.OSSupportsIPv6 && (startIPOptions & StartIPOptions.StartIPv6) != StartIPOptions.None)
					{
						s_registeredWait = ThreadPool.UnsafeRegisterWaitForSingleObject(s_ipv6WaitHandle, AddressChangedCallback, StartIPOptions.StartIPv6, -1, executeOnlyOnce: true);
						if (UnsafeNclNativeMethods.OSSOCK.WSAIoctl_Blocking(s_ipv6Socket.DangerousGetHandle(), 671088663, null, 0, null, 0, out bytesTransferred, SafeNativeOverlapped.Zero, IntPtr.Zero) != SocketError.Success)
						{
							NetworkInformationException ex2 = new NetworkInformationException();
							if ((long)ex2.ErrorCode != 10035)
							{
								throw ex2;
							}
						}
						if (UnsafeNclNativeMethods.OSSOCK.WSAEventSelect(s_ipv6Socket, s_ipv6Socket.GetEventHandle().SafeWaitHandle, AsyncEventBits.FdAddressListChange) != SocketError.Success)
						{
							throw new NetworkInformationException();
						}
					}
				}
				s_isListening = true;
				s_isPending = true;
			}
		}

		internal static void Stop(object caller)
		{
			lock (s_globalLock)
			{
				s_callerArray.Remove(caller);
				if (s_callerArray.Count == 0 && s_isListening)
				{
					s_isListening = false;
				}
			}
		}
	}

	private static readonly object s_globalLock = new object();

	private static readonly object s_protectCallbackLock = new object();

	internal static bool CanListenForNetworkChanges => true;

	public static event NetworkAvailabilityChangedEventHandler NetworkAvailabilityChanged
	{
		add
		{
			AvailabilityChangeListener.Start(value);
		}
		remove
		{
			AvailabilityChangeListener.Stop(value);
		}
	}

	[global::__DynamicallyInvokable]
	public static event NetworkAddressChangedEventHandler NetworkAddressChanged
	{
		[global::__DynamicallyInvokable]
		add
		{
			AddressChangeListener.Start(value);
		}
		[global::__DynamicallyInvokable]
		remove
		{
			AddressChangeListener.Stop(value);
		}
	}

	[Obsolete("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public NetworkChange()
	{
	}

	[Obsolete("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static void RegisterNetworkChange(NetworkChange nc)
	{
	}
}
