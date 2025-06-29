using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.OnlineSubsystem;

[Abstract]
[UInterface(Flags = 809517217u)]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/OnlineSubsystem.TurnBasedMatchInterface", "OnlineSubsystem", UnrealModuleType.EnginePlugin, InterfaceImpl = typeof(ITurnBasedMatchInterfaceImpl))]
public interface ITurnBasedMatchInterface : IInterface
{
	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/OnlineSubsystem.TurnBasedMatchInterface:OnMatchReceivedTurn")]
	void OnMatchReceivedTurn(string Match, bool bDidBecomeActive);

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/OnlineSubsystem.TurnBasedMatchInterface:OnMatchEnded")]
	void OnMatchEnded(string Match);
}
