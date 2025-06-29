using UnrealEngine.Runtime;

namespace b1.Plugins.AsyncLoadingScreen;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/AsyncLoadingScreen.EGSLoadingScreenType", "AsyncLoadingScreen", UnrealModuleType.GamePlugin)]
public enum EGSLoadingScreenType : byte
{
	Unknown,
	LoadProgOnly,
	Full,
	FullBlack,
	FullWhite,
	Chapter,
	BossRush
}
