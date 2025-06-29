using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UEnum]
[UMetaPath("/Script/AIModule.EEnvQueryHightlightMode", "AIModule", UnrealModuleType.Engine)]
public enum EEnvQueryHightlightMode
{
	All,
	Best5Pct,
	Best25Pct
}
