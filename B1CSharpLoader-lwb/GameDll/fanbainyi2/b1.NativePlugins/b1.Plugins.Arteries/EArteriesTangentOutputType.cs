using UnrealEngine.Runtime;

namespace b1.Plugins.Arteries;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Arteries.EArteriesTangentOutputType", "Arteries", UnrealModuleType.GamePlugin)]
public enum EArteriesTangentOutputType : byte
{
	None,
	Flatten,
	Normal
}
