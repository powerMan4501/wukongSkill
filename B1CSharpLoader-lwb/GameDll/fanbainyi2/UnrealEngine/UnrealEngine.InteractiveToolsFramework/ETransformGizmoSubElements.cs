using UnrealEngine.Runtime;

namespace UnrealEngine.InteractiveToolsFramework;

[UEnum]
[UMetaPath("/Script/InteractiveToolsFramework.ETransformGizmoSubElements", "InteractiveToolsFramework", UnrealModuleType.Engine)]
public enum ETransformGizmoSubElements
{
	None = 0,
	TranslateAxisX = 2,
	TranslateAxisY = 4,
	TranslateAxisZ = 8,
	TranslateAllAxes = 14,
	TranslatePlaneXY = 16,
	TranslatePlaneXZ = 32,
	TranslatePlaneYZ = 64,
	TranslateAllPlanes = 112,
	RotateAxisX = 128,
	RotateAxisY = 256,
	RotateAxisZ = 512,
	RotateAllAxes = 896,
	ScaleAxisX = 1024,
	ScaleAxisY = 2048,
	ScaleAxisZ = 4096,
	ScaleAllAxes = 7168,
	ScalePlaneYZ = 8192,
	ScalePlaneXZ = 16384,
	ScalePlaneXY = 32768,
	ScaleAllPlanes = 57344,
	ScaleUniform = 65536,
	StandardTranslateRotate = 1022,
	TranslateRotateUniformScale = 66558,
	FullTranslateRotateScale = 131070
}
