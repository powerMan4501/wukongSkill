using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.FullBodyIK;

[UEnum]
[UMetaPath("/Script/FullBodyIK.EFBIKBoneLimitType", "FullBodyIK", UnrealModuleType.EnginePlugin)]
public enum EFBIKBoneLimitType
{
	Free,
	Limit,
	Locked
}
