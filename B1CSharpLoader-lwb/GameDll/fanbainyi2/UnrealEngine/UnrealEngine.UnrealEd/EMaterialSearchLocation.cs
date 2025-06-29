using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/UnrealEd.EMaterialSearchLocation", "UnrealEd", UnrealModuleType.Engine)]
public enum EMaterialSearchLocation : byte
{
	Local,
	UnderParent,
	UnderRoot,
	AllAssets,
	DoNotSearch
}
