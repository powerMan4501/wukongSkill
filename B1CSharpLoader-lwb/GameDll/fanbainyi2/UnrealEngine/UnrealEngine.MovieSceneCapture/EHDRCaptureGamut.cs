using UnrealEngine.Runtime;

namespace UnrealEngine.MovieSceneCapture;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/MovieSceneCapture.EHDRCaptureGamut", "MovieSceneCapture", UnrealModuleType.Engine)]
public enum EHDRCaptureGamut : byte
{
	HCGM_Rec709,
	HCGM_P3DCI,
	HCGM_Rec2020,
	HCGM_ACES,
	HCGM_ACEScg,
	HCGM_Linear
}
