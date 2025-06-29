using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;
using Microsoft.Win32.SafeHandles;

namespace System.Net;

[SuppressUnmanagedCodeSecurity]
internal class SafeCloseSocket : SafeHandleMinusOneIsInvalid
{
	internal class InnerSafeCloseSocket : SafeHandleMinusOneIsInvalid
	{
		private static readonly byte[] tempBuffer = new byte[1];

		private bool m_Blockable;

		public override bool IsInvalid
		{
			[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
			get
			{
				if (!base.IsClosed)
				{
					return base.IsInvalid;
				}
				return true;
			}
		}

		protected InnerSafeCloseSocket()
			: base(ownsHandle: true)
		{
		}

		protected override bool ReleaseHandle()
		{
			bool flag = false;
			SocketError socketError;
			if (m_Blockable)
			{
				socketError = UnsafeNclNativeMethods.SafeNetHandles.closesocket(handle);
				if (socketError == SocketError.SocketError)
				{
					socketError = (SocketError)Marshal.GetLastWin32Error();
				}
				if (socketError != SocketError.WouldBlock)
				{
					return flag = socketError == SocketError.Success;
				}
				int argp = 0;
				socketError = UnsafeNclNativeMethods.SafeNetHandles.ioctlsocket(handle, -2147195266, ref argp);
				if (socketError == SocketError.SocketError)
				{
					socketError = (SocketError)Marshal.GetLastWin32Error();
				}
				if (socketError == SocketError.InvalidArgument)
				{
					socketError = UnsafeNclNativeMethods.SafeNetHandles.WSAEventSelect(handle, IntPtr.Zero, AsyncEventBits.FdNone);
					socketError = UnsafeNclNativeMethods.SafeNetHandles.ioctlsocket(handle, -2147195266, ref argp);
				}
				if (socketError == SocketError.Success)
				{
					socketError = UnsafeNclNativeMethods.SafeNetHandles.closesocket(handle);
					if (socketError == SocketError.SocketError)
					{
						socketError = (SocketError)Marshal.GetLastWin32Error();
					}
					if (socketError != SocketError.WouldBlock)
					{
						return flag = socketError == SocketError.Success;
					}
				}
			}
			Linger linger = default(Linger);
			linger.OnOff = 1;
			linger.Time = 0;
			socketError = UnsafeNclNativeMethods.SafeNetHandles.setsockopt(handle, SocketOptionLevel.Socket, SocketOptionName.Linger, ref linger, 4);
			if (socketError == SocketError.SocketError)
			{
				socketError = (SocketError)Marshal.GetLastWin32Error();
			}
			if (socketError != SocketError.Success && socketError != SocketError.InvalidArgument && socketError != SocketError.ProtocolOption)
			{
				return flag = false;
			}
			socketError = UnsafeNclNativeMethods.SafeNetHandles.closesocket(handle);
			return flag = socketError == SocketError.Success;
		}

		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		internal void BlockingRelease()
		{
			m_Blockable = true;
			DangerousRelease();
		}

		internal unsafe static InnerSafeCloseSocket CreateWSASocket(byte* pinnedBuffer)
		{
			InnerSafeCloseSocket innerSafeCloseSocket = UnsafeNclNativeMethods.OSSOCK.WSASocket(AddressFamily.Unknown, SocketType.Unknown, ProtocolType.Unknown, pinnedBuffer, 0u, SocketConstructorFlags.WSA_FLAG_OVERLAPPED);
			if (innerSafeCloseSocket.IsInvalid)
			{
				innerSafeCloseSocket.SetHandleAsInvalid();
			}
			return innerSafeCloseSocket;
		}

		internal static InnerSafeCloseSocket CreateWSASocket(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType)
		{
			InnerSafeCloseSocket innerSafeCloseSocket = UnsafeNclNativeMethods.OSSOCK.WSASocket(addressFamily, socketType, protocolType, IntPtr.Zero, 0u, SocketConstructorFlags.WSA_FLAG_OVERLAPPED);
			if (innerSafeCloseSocket.IsInvalid)
			{
				innerSafeCloseSocket.SetHandleAsInvalid();
			}
			return innerSafeCloseSocket;
		}

		internal static InnerSafeCloseSocket Accept(SafeCloseSocket socketHandle, byte[] socketAddress, ref int socketAddressSize)
		{
			InnerSafeCloseSocket innerSafeCloseSocket = UnsafeNclNativeMethods.SafeNetHandles.accept(socketHandle.DangerousGetHandle(), socketAddress, ref socketAddressSize);
			if (innerSafeCloseSocket.IsInvalid)
			{
				innerSafeCloseSocket.SetHandleAsInvalid();
			}
			return innerSafeCloseSocket;
		}
	}

	private InnerSafeCloseSocket m_InnerSocket;

	private volatile bool m_Released;

	public override bool IsInvalid
	{
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		get
		{
			if (!base.IsClosed)
			{
				return base.IsInvalid;
			}
			return true;
		}
	}

	protected SafeCloseSocket()
		: base(ownsHandle: true)
	{
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	private void SetInnerSocket(InnerSafeCloseSocket socket)
	{
		m_InnerSocket = socket;
		SetHandle(socket.DangerousGetHandle());
	}

	private static SafeCloseSocket CreateSocket(InnerSafeCloseSocket socket)
	{
		SafeCloseSocket safeCloseSocket = new SafeCloseSocket();
		CreateSocket(socket, safeCloseSocket);
		return safeCloseSocket;
	}

	protected static void CreateSocket(InnerSafeCloseSocket socket, SafeCloseSocket target)
	{
		if (socket != null && socket.IsInvalid)
		{
			target.SetHandleAsInvalid();
			return;
		}
		bool success = false;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			socket.DangerousAddRef(ref success);
		}
		catch
		{
			if (success)
			{
				socket.DangerousRelease();
				success = false;
			}
		}
		finally
		{
			if (success)
			{
				target.SetInnerSocket(socket);
				socket.Close();
			}
			else
			{
				target.SetHandleAsInvalid();
			}
		}
	}

	internal unsafe static SafeCloseSocket CreateWSASocket(byte* pinnedBuffer)
	{
		return CreateSocket(InnerSafeCloseSocket.CreateWSASocket(pinnedBuffer));
	}

	internal static SafeCloseSocket CreateWSASocket(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType)
	{
		return CreateSocket(InnerSafeCloseSocket.CreateWSASocket(addressFamily, socketType, protocolType));
	}

	internal static SafeCloseSocket Accept(SafeCloseSocket socketHandle, byte[] socketAddress, ref int socketAddressSize)
	{
		return CreateSocket(InnerSafeCloseSocket.Accept(socketHandle, socketAddress, ref socketAddressSize));
	}

	protected override bool ReleaseHandle()
	{
		m_Released = true;
		((m_InnerSocket == null) ? null : Interlocked.Exchange(ref m_InnerSocket, null))?.DangerousRelease();
		return true;
	}

	internal void CloseAsIs()
	{
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
		}
		finally
		{
			InnerSafeCloseSocket innerSafeCloseSocket = ((m_InnerSocket == null) ? null : Interlocked.Exchange(ref m_InnerSocket, null));
			Close();
			if (innerSafeCloseSocket != null)
			{
				while (!m_Released)
				{
					Thread.SpinWait(1);
				}
				innerSafeCloseSocket.BlockingRelease();
			}
		}
	}
}
