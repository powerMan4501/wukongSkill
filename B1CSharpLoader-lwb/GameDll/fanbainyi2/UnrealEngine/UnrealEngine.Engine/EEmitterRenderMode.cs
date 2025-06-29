using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EEmitterRenderMode", "Engine", UnrealModuleType.Engine)]
public enum EEmitterRenderMode
{
	ERM_Normal,
	ERM_Point,
	ERM_Cross,
	ERM_LightsOnly,
	ERM_None
}
