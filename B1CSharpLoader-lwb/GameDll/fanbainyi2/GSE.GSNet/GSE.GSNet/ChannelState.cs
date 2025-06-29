using Gs;

namespace GSE.GSNet;

internal struct ChannelState
{
	public NetDriver driver;

	public NetConnection connection;

	public int retriedConnectTimes;

	public ChannelConnectState connectState;

	public uint stateChangeTime;

	public ulong sessionRoleId;

	public UxNetAuthToken sessionKey;

	public bool is_connecting;
}
