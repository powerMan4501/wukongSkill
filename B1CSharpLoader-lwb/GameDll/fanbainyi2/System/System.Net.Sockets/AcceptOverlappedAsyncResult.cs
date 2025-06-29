using System.Runtime.InteropServices;

namespace System.Net.Sockets;

internal class AcceptOverlappedAsyncResult : BaseOverlappedAsyncResult
{
	private int m_LocalBytesTransferred;

	private Socket m_ListenSocket;

	private Socket m_AcceptSocket;

	private int m_AddressBufferLength;

	private byte[] m_Buffer;

	internal byte[] Buffer => m_Buffer;

	internal int BytesTransferred => m_LocalBytesTransferred;

	internal Socket AcceptSocket
	{
		set
		{
			m_AcceptSocket = value;
		}
	}

	internal AcceptOverlappedAsyncResult(Socket listenSocket, object asyncState, AsyncCallback asyncCallback)
		: base(listenSocket, asyncState, asyncCallback)
	{
		m_ListenSocket = listenSocket;
	}

	internal override object PostCompletion(int numBytes)
	{
		SocketError socketError = (SocketError)base.ErrorCode;
		SocketAddress socketAddress = null;
		if (socketError == SocketError.Success)
		{
			m_LocalBytesTransferred = numBytes;
			if (Logging.On)
			{
				LogBuffer(numBytes);
			}
			socketAddress = m_ListenSocket.m_RightEndPoint.Serialize();
			try
			{
				m_ListenSocket.GetAcceptExSockaddrs(Marshal.UnsafeAddrOfPinnedArrayElement((Array)m_Buffer, 0), m_Buffer.Length - m_AddressBufferLength * 2, m_AddressBufferLength, m_AddressBufferLength, out var _, out var _, out var remoteSocketAddress, out socketAddress.m_Size);
				Marshal.Copy(remoteSocketAddress, socketAddress.m_Buffer, 0, socketAddress.m_Size);
				IntPtr pointer = m_ListenSocket.SafeHandle.DangerousGetHandle();
				socketError = UnsafeNclNativeMethods.OSSOCK.setsockopt(m_AcceptSocket.SafeHandle, SocketOptionLevel.Socket, SocketOptionName.UpdateAcceptContext, ref pointer, Marshal.SizeOf((object)(nint)pointer));
				if (socketError == SocketError.SocketError)
				{
					socketError = (SocketError)Marshal.GetLastWin32Error();
				}
			}
			catch (ObjectDisposedException)
			{
				socketError = SocketError.OperationAborted;
			}
			base.ErrorCode = (int)socketError;
		}
		if (socketError == SocketError.Success)
		{
			return m_ListenSocket.UpdateAcceptSocket(m_AcceptSocket, m_ListenSocket.m_RightEndPoint.Create(socketAddress), needCancelSelect: false);
		}
		return null;
	}

	internal void SetUnmanagedStructures(byte[] buffer, int addressBufferLength)
	{
		SetUnmanagedStructures(buffer);
		m_AddressBufferLength = addressBufferLength;
		m_Buffer = buffer;
	}

	private void LogBuffer(long size)
	{
		IntPtr intPtr = Marshal.UnsafeAddrOfPinnedArrayElement((Array)m_Buffer, 0);
		if (intPtr != IntPtr.Zero)
		{
			if (size > -1)
			{
				Logging.Dump(Logging.Sockets, m_ListenSocket, "PostCompletion", intPtr, (int)Math.Min(size, m_Buffer.Length));
			}
			else
			{
				Logging.Dump(Logging.Sockets, m_ListenSocket, "PostCompletion", intPtr, m_Buffer.Length);
			}
		}
	}
}
