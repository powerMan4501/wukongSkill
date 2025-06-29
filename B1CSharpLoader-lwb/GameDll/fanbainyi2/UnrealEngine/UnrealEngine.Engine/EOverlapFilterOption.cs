using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.EOverlapFilterOption", "Engine", UnrealModuleType.Engine)]
public enum EOverlapFilterOption : byte
{
	OverlapFilter_All,
	OverlapFilter_DynamicOnly,
	OverlapFilter_StaticOnly
}
