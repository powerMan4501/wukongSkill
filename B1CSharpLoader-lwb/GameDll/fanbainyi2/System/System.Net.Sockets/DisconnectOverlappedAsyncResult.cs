namespace System.Net.Sockets;

internal class DisconnectOverlappedAsyncResult : BaseOverlappedAsyncResult
{
	internal DisconnectOverlappedAsyncResult(Socket socket, object asyncState, AsyncCallback asyncCallback)
		: base(socket, asyncState, asyncCallback)
	{
	}

	internal override object PostCompletion(int numBytes)
	{
		if (base.ErrorCode == 0)
		{
			Socket socket = (Socket)base.AsyncObject;
			socket.SetToDisconnected();
			socket.m_RemoteEndPoint = null;
		}
		return base.PostCompletion(numBytes);
	}
}
