using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EInterpMoveAxis", "Engine", UnrealModuleType.Engine)]
public enum EInterpMoveAxis
{
	AXIS_TranslationX,
	AXIS_TranslationY,
	AXIS_TranslationZ,
	AXIS_RotationX,
	AXIS_RotationY,
	AXIS_RotationZ
}
