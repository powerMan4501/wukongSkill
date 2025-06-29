using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PBIK;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/PBIK.EPBIKLimitType", "PBIK", UnrealModuleType.EnginePlugin)]
public enum EPBIKLimitType : byte
{
	Free,
	Limited,
	Locked
}
