using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EMaterialFloatPrecisionMode", "Engine", UnrealModuleType.Engine)]
public enum EMaterialFloatPrecisionMode
{
	MFPM_Default,
	MFPM_Full_MaterialExpressionOnly,
	MFPM_Full,
	MFPM_Half
}
