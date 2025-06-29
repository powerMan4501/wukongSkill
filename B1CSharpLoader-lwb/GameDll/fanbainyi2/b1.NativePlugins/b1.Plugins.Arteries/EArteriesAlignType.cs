using UnrealEngine.Runtime;

namespace b1.Plugins.Arteries;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Arteries.EArteriesAlignType", "Arteries", UnrealModuleType.GamePlugin)]
public enum EArteriesAlignType : byte
{
	Start,
	Center,
	End
}
