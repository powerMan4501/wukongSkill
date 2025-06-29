using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/b1.EGSBlendTypeG", "b1", UnrealModuleType.Game)]
public enum EGSBlendTypeG : byte
{
	GSNone,
	GSLinear,
	GSEaseIn,
	GSEaseOut,
	GSEaseInOut
}
