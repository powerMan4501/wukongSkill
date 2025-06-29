namespace GSE.GSNet;

public class ProxyRoleServerUpstream
{
	public delegate void OnSererClientResponseHandler(byte[] Buffer);

	public delegate void OnServerClosedHandler();

	public delegate void OnServerConnectedHandler();

	public NetConnection server;

	public int retriedConnectTimes;

	public ulong serverConnectCookie;

	public ulong RoleId;

	public ulong NetioAuthCookie;

	public ulong ProxyAuthCookie;

	public ulong DsAuthToken;

	public int verifyFailTimes;

	public uint lastVerifyCheckTime;

	public bool authed;

	public bool connectingServer;

	public string upUrl;

	public bool relayDisable;

	public uint SessionTokenKey;

	public uint SessionTokenMagic;

	public OnSererClientResponseHandler OnServerClientResponseEvent;

	public OnServerClosedHandler OnServerClosedEvent;

	public OnServerConnectedHandler OnServerConnectedEvent;
}
