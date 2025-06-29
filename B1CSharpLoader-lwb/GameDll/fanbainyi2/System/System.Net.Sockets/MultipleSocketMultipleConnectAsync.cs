namespace System.Net.Sockets;

internal class MultipleSocketMultipleConnectAsync : MultipleConnectAsync
{
	private Socket socket4;

	private Socket socket6;

	public MultipleSocketMultipleConnectAsync(SocketType socketType, ProtocolType protocolType)
	{
		if (Socket.OSSupportsIPv4)
		{
			socket4 = new Socket(AddressFamily.InterNetwork, socketType, protocolType);
		}
		if (Socket.OSSupportsIPv6)
		{
			socket6 = new Socket(AddressFamily.InterNetworkV6, socketType, protocolType);
		}
	}

	protected override IPAddress GetNextAddress(out Socket attemptSocket)
	{
		IPAddress iPAddress = null;
		attemptSocket = null;
		while (attemptSocket == null)
		{
			if (nextAddress >= addressList.Length)
			{
				return null;
			}
			iPAddress = addressList[nextAddress];
			nextAddress++;
			if (iPAddress.AddressFamily == AddressFamily.InterNetworkV6)
			{
				attemptSocket = socket6;
			}
			else if (iPAddress.AddressFamily == AddressFamily.InterNetwork)
			{
				attemptSocket = socket4;
			}
		}
		return iPAddress;
	}

	protected override void OnSucceed()
	{
		if (socket4 != null && !socket4.Connected)
		{
			socket4.Close();
		}
		if (socket6 != null && !socket6.Connected)
		{
			socket6.Close();
		}
	}

	protected override void OnFail(bool abortive)
	{
		if (socket4 != null)
		{
			socket4.Close();
		}
		if (socket6 != null)
		{
			socket6.Close();
		}
	}
}
