using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.EAnimAssetCurveFlags", "Engine", UnrealModuleType.Engine)]
public enum EAnimAssetCurveFlags : byte
{
	AACF_NONE = 0,
	AACF_DriveMorphTarget_DEPRECATED = 1,
	AACF_DriveAttribute_DEPRECATED = 2,
	AACF_Editable = 4,
	AACF_DriveMaterial_DEPRECATED = 8,
	AACF_Metadata = 0x10,
	AACF_DriveTrack = 0x20,
	AACF_Disabled = 0x40
}
