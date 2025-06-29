using UnrealEngine.Runtime;

namespace b1.Plugins.AsyncLoadingScreen;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/AsyncLoadingScreen.EBossRushLoadingType", "AsyncLoadingScreen", UnrealModuleType.GamePlugin)]
public enum EBossRushLoadingType : byte
{
	ReChallengeBoss,
	BossIterations
}
