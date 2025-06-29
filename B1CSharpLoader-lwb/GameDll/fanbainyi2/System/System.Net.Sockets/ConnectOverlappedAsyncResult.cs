using System.Runtime.InteropServices;

namespace System.Net.Sockets;

internal class ConnectOverlappedAsyncResult : BaseOverlappedAsyncResult
{
	private EndPoint m_EndPoint;

	internal EndPoint RemoteEndPoint => m_EndPoint;

	internal ConnectOverlappedAsyncResult(Socket socket, EndPoint endPoint, object asyncState, AsyncCallback asyncCallback)
		: base(socket, asyncState, asyncCallback)
	{
		m_EndPoint = endPoint;
	}

	internal override object PostCompletion(int numBytes)
	{
		SocketError socketError = (SocketError)base.ErrorCode;
		Socket socket = (Socket)base.AsyncObject;
		if (socketError == SocketError.Success)
		{
			try
			{
				socketError = UnsafeNclNativeMethods.OSSOCK.setsockopt(socket.SafeHandle, SocketOptionLevel.Socket, SocketOptionName.UpdateConnectContext, null, 0);
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
			socket.SetToConnected();
			return socket;
		}
		return null;
	}
}
