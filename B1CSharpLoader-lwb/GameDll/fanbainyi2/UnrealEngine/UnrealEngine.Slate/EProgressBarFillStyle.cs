using UnrealEngine.Runtime;

namespace UnrealEngine.Slate;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Slate.EProgressBarFillStyle", "Slate", UnrealModuleType.Engine)]
public enum EProgressBarFillStyle : byte
{
	Mask,
	Scale
}
