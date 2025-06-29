using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ESceneCaptureCompositeMode", "Engine", UnrealModuleType.Engine)]
public enum ESceneCaptureCompositeMode
{
	SCCM_Overwrite,
	SCCM_Additive,
	SCCM_Composite
}
