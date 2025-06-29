using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace System.Net;

internal class NetworkAddressChangePolled : IDisposable
{
	private bool disposed;

	private SafeCloseSocketAndEvent ipv4Socket;

	private SafeCloseSocketAndEvent ipv6Socket;

	internal NetworkAddressChangePolled()
	{
		Socket.InitializeSockets();
		if (Socket.OSSupportsIPv4)
		{
			int argp = -1;
			ipv4Socket = SafeCloseSocketAndEvent.CreateWSASocketWithEvent(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.IP, autoReset: true, signaled: false);
			UnsafeNclNativeMethods.OSSOCK.ioctlsocket(ipv4Socket, -2147195266, ref argp);
		}
		if (Socket.OSSupportsIPv6)
		{
			int argp = -1;
			ipv6Socket = SafeCloseSocketAndEvent.CreateWSASocketWithEvent(AddressFamily.InterNetworkV6, SocketType.Dgram, ProtocolType.IP, autoReset: true, signaled: false);
			UnsafeNclNativeMethods.OSSOCK.ioctlsocket(ipv6Socket, -2147195266, ref argp);
		}
		Setup(StartIPOptions.Both);
	}

	private void Setup(StartIPOptions startIPOptions)
	{
		int bytesTransferred;
		if (Socket.OSSupportsIPv4 && (startIPOptions & StartIPOptions.StartIPv4) != StartIPOptions.None)
		{
			if (UnsafeNclNativeMethods.OSSOCK.WSAIoctl_Blocking(ipv4Socket.DangerousGetHandle(), 671088663, null, 0, null, 0, out bytesTransferred, SafeNativeOverlapped.Zero, IntPtr.Zero) != SocketError.Success)
			{
				NetworkInformationException ex = new NetworkInformationException();
				if ((long)ex.ErrorCode != 10035)
				{
					Dispose();
					return;
				}
			}
			if (UnsafeNclNativeMethods.OSSOCK.WSAEventSelect(ipv4Socket, ipv4Socket.GetEventHandle().SafeWaitHandle, AsyncEventBits.FdAddressListChange) != SocketError.Success)
			{
				Dispose();
				return;
			}
		}
		if (!Socket.OSSupportsIPv6 || (startIPOptions & StartIPOptions.StartIPv6) == 0)
		{
			return;
		}
		if (UnsafeNclNativeMethods.OSSOCK.WSAIoctl_Blocking(ipv6Socket.DangerousGetHandle(), 671088663, null, 0, null, 0, out bytesTransferred, SafeNativeOverlapped.Zero, IntPtr.Zero) != SocketError.Success)
		{
			NetworkInformationException ex2 = new NetworkInformationException();
			if ((long)ex2.ErrorCode != 10035)
			{
				Dispose();
				return;
			}
		}
		if (UnsafeNclNativeMethods.OSSOCK.WSAEventSelect(ipv6Socket, ipv6Socket.GetEventHandle().SafeWaitHandle, AsyncEventBits.FdAddressListChange) != SocketError.Success)
		{
			Dispose();
		}
	}

	internal bool CheckAndReset()
	{
		if (!disposed)
		{
			lock (this)
			{
				if (!disposed)
				{
					StartIPOptions startIPOptions = StartIPOptions.None;
					if (ipv4Socket != null && ipv4Socket.GetEventHandle().WaitOne(0, exitContext: false))
					{
						startIPOptions |= StartIPOptions.StartIPv4;
					}
					if (ipv6Socket != null && ipv6Socket.GetEventHandle().WaitOne(0, exitContext: false))
					{
						startIPOptions |= StartIPOptions.StartIPv6;
					}
					if (startIPOptions != StartIPOptions.None)
					{
						Setup(startIPOptions);
						return true;
					}
				}
			}
		}
		return false;
	}

	public void Dispose()
	{
		if (disposed)
		{
			return;
		}
		lock (this)
		{
			if (!disposed)
			{
				if (ipv6Socket != null)
				{
					ipv6Socket.Close();
					ipv6Socket = null;
				}
				if (ipv4Socket != null)
				{
					ipv4Socket.Close();
					ipv6Socket = null;
				}
				disposed = true;
			}
		}
	}
}
