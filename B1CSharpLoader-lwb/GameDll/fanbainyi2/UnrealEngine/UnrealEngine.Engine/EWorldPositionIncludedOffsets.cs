using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EWorldPositionIncludedOffsets", "Engine", UnrealModuleType.Engine)]
public enum EWorldPositionIncludedOffsets
{
	WPT_Default,
	WPT_ExcludeAllShaderOffsets,
	WPT_CameraRelative,
	WPT_CameraRelativeNoOffsets
}
