using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Lobby;

[UEnum]
[UMetaPath("/Script/Lobby.ELobbyBeaconJoinState", "Lobby", UnrealModuleType.EnginePlugin)]
public enum ELobbyBeaconJoinState
{
	None,
	SentJoinRequest,
	JoinRequestAcknowledged
}
