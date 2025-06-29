using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ESceneCaptureSource", "Engine", UnrealModuleType.Engine)]
public enum ESceneCaptureSource
{
	SCS_SceneColorHDR,
	SCS_SceneColorHDRNoAlpha,
	SCS_FinalColorLDR,
	SCS_SceneColorSceneDepth,
	SCS_SceneDepth,
	SCS_DeviceDepth,
	SCS_Normal,
	SCS_BaseColor,
	SCS_FinalColorHDR,
	SCS_FinalToneCurveHDR
}
