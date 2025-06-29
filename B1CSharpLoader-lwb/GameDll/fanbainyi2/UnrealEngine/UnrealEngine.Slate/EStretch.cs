using UnrealEngine.Runtime;

namespace UnrealEngine.Slate;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Slate.EStretch", "Slate", UnrealModuleType.Engine)]
public enum EStretch : byte
{
	None,
	Fill,
	ScaleToFit,
	ScaleToFitX,
	ScaleToFitY,
	ScaleToFill,
	ScaleBySafeZone,
	UserSpecified
}
