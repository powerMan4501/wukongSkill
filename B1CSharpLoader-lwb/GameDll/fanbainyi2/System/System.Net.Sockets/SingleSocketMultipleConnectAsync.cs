namespace System.Net.Sockets;

internal class SingleSocketMultipleConnectAsync : MultipleConnectAsync
{
	private Socket socket;

	private bool userSocket;

	public SingleSocketMultipleConnectAsync(Socket socket, bool userSocket)
	{
		this.socket = socket;
		this.userSocket = userSocket;
	}

	protected override IPAddress GetNextAddress(out Socket attemptSocket)
	{
		attemptSocket = socket;
		IPAddress iPAddress = null;
		do
		{
			if (nextAddress >= addressList.Length)
			{
				return null;
			}
			iPAddress = addressList[nextAddress];
			nextAddress++;
		}
		while (!socket.CanTryAddressFamily(iPAddress.AddressFamily));
		return iPAddress;
	}

	protected override void OnFail(bool abortive)
	{
		if (abortive || !userSocket)
		{
			socket.Close();
		}
	}

	protected override void OnSucceed()
	{
	}
}
