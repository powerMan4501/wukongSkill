using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/SlateCore.ETextShapingMethod", "SlateCore", UnrealModuleType.Engine)]
public enum ETextShapingMethod : byte
{
	Auto,
	KerningOnly,
	FullShaping
}
