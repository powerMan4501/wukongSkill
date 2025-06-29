using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/UMG.EWidgetBlendMode", "UMG", UnrealModuleType.Engine)]
public enum EWidgetBlendMode : byte
{
	Opaque,
	Masked,
	Transparent
}
