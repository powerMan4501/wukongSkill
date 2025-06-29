using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ESceneCapturePrimitiveRenderMode", "Engine", UnrealModuleType.Engine)]
public enum ESceneCapturePrimitiveRenderMode
{
	PRM_LegacySceneCapture,
	PRM_RenderScenePrimitives,
	PRM_UseShowOnlyList
}
