using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRigEditor;

[UEnum]
[UMetaPath("/Script/ControlRigEditor.ERigElementDetailsTransformComponent", "ControlRigEditor", UnrealModuleType.EnginePlugin)]
public enum ERigElementDetailsTransformComponent
{
	TranslationX,
	TranslationY,
	TranslationZ,
	RotationRoll,
	RotationPitch,
	RotationYaw,
	ScaleX,
	ScaleY,
	ScaleZ
}
