namespace GSE.GSNet;

public class ProxyRoleClientConnx
{
	public delegate void OnClientClosedHandler();

	public delegate void OnClientConnectedHandler();

	public NetConnection client;

	public ProxyRoleServerUpstream upstream;

	public TunnelConnectState connectState;

	public uint stateChangeTime;

	public OnClientClosedHandler OnClientClosedEvent;

	public OnClientConnectedHandler OnClientConnectedEvent;
}
