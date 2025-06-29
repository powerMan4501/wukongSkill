using UnrealEngine.Runtime;

namespace b1.Plugins.AsyncLoadingScreen;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/AsyncLoadingScreen.EGSLoadingScreenState", "AsyncLoadingScreen", UnrealModuleType.GamePlugin)]
public enum EGSLoadingScreenState : byte
{
	Idle,
	SlateThreadUpdating,
	GameThreadWaitingMovieFinish,
	MainThreadUpdating
}
