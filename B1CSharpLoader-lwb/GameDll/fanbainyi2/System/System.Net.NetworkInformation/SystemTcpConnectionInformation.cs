namespace System.Net.NetworkInformation;

internal class SystemTcpConnectionInformation : TcpConnectionInformation
{
	private IPEndPoint localEndPoint;

	private IPEndPoint remoteEndPoint;

	private TcpState state;

	public override TcpState State => state;

	public override IPEndPoint LocalEndPoint => localEndPoint;

	public override IPEndPoint RemoteEndPoint => remoteEndPoint;

	internal SystemTcpConnectionInformation(MibTcpRow row)
	{
		state = row.state;
		int port = (row.localPort1 << 8) | row.localPort2;
		int port2 = ((state != TcpState.Listen) ? ((row.remotePort1 << 8) | row.remotePort2) : 0);
		localEndPoint = new IPEndPoint(row.localAddr, port);
		remoteEndPoint = new IPEndPoint(row.remoteAddr, port2);
	}

	internal SystemTcpConnectionInformation(MibTcp6RowOwnerPid row)
	{
		state = row.state;
		int port = (row.localPort1 << 8) | row.localPort2;
		int port2 = ((state != TcpState.Listen) ? ((row.remotePort1 << 8) | row.remotePort2) : 0);
		localEndPoint = new IPEndPoint(new IPAddress(row.localAddr, row.localScopeId), port);
		remoteEndPoint = new IPEndPoint(new IPAddress(row.remoteAddr, row.remoteScopeId), port2);
	}
}
