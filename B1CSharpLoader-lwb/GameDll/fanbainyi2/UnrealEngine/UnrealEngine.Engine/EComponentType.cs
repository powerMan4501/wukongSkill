using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EComponentType", "Engine", UnrealModuleType.Engine)]
public enum EComponentType
{
	None,
	TranslationX,
	TranslationY,
	TranslationZ,
	RotationX,
	RotationY,
	RotationZ,
	Scale,
	ScaleX,
	ScaleY,
	ScaleZ
}
