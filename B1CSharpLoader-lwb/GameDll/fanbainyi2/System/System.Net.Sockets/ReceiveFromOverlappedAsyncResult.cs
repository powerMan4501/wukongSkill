namespace System.Net.Sockets;

internal class ReceiveFromOverlappedAsyncResult : OverlappedAsyncResult
{
	internal ReceiveFromOverlappedAsyncResult(Socket socket, object asyncState, AsyncCallback asyncCallback)
		: base(socket, asyncState, asyncCallback)
	{
	}

	internal override object PostCompletion(int numBytes)
	{
		base.SocketAddress.SetSize(GetSocketAddressSizePtr());
		return base.PostCompletion(numBytes);
	}
}
