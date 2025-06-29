namespace b1;

public enum EServerTamerAuthState
{
	ClientFirstAuth,
	AuthSwitchWaitingOldAuthChannelCleanUp,
	AuthSwitchWaitingOldSimulateChannelCleanUp,
	ClientAuthWaitingNewChannelReady,
	ClientAuthConfirmed,
	ServerAuthConfirmed,
	ClientAuthUnRegisterWaitingChannelClose,
	UnKnow
}
