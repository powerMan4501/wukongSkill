using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EMobileFloatPrecisionMode", "Engine", UnrealModuleType.Engine)]
public enum EMobileFloatPrecisionMode
{
	Half,
	Full_MaterialExpressionOnly,
	Full
}
