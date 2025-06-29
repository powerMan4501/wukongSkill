using UnrealEngine.Engine;

namespace b1;

public interface IBGC_UnrealGameplayData
{
	UWorld World { get; }

	BGWGameInstanceCS GameInstance { get; }

	AGameState GameState { get; }

	bool IsListenServer { get; }

	bool IsDedicatedServer { get; }

	float GetTimeSeconds();

	ACharacter GetPlayerCharacter(int Index);

	APlayerController GetFirstLocalPlayerController();
}
