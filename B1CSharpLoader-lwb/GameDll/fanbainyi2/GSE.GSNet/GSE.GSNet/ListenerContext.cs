using System.Net;
using System.Net.Sockets;

namespace GSE.GSNet;

public class ListenerContext
{
	public TcpListener Listener;

	public IPEndPoint FinalListenAddress;

	public OnNewClientEventCallback onNewConnxCallback;

	public OnClientReceiveEventCallback onConnxReceiveCallback;

	public OnClientClosedEventCallback onConnxCloseCallback;

	public int SendBufferSize;

	public int ReceiveBufferSize;

	public int ZipThresholdSize = 8192;
}
