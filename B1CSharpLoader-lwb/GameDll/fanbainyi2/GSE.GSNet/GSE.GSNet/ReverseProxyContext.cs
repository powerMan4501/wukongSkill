namespace GSE.GSNet;

public struct ReverseProxyContext
{
	public string name;

	public string url;

	public string authToken;

	public uint worldId;

	public byte[] loginEnv;

	public int maxRetryConnectTimes;

	public int maxConnectingTimeoutSeconds;

	public string uri;
}
