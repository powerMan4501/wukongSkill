namespace GSE.GSNet;

public struct ChannelContext
{
	public string name;

	public string url;

	public string authToken;

	public bool connectToProxy;

	public ulong ProxyAuthRoleId;

	public ulong DSAuthToken;

	public uint worldId;

	public byte[] loginEnv;

	public int maxRetryConnectTimes;

	public int maxConnectingTimeoutSeconds;

	public string uri;

	public ProxyRoleServerUpstream attachUpstream;
}
