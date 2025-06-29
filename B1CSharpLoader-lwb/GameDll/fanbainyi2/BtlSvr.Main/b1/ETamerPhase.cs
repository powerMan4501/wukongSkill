namespace b1;

public enum ETamerPhase
{
	None,
	UnLoaded,
	Loaded,
	Visible,
	ServerWaitingAuthorityECSBeginPlay,
	ClientWaitingChannelAndAuthRoleReady,
	PreBegunPlay,
	Spawned,
	Dead,
	ClientBackToLoadWaitChannelClose,
	ClientAuthorityDeadDestroyWaitChannelClose
}
