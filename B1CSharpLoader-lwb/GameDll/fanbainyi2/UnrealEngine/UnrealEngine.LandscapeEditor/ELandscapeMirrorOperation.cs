using UnrealEngine.Runtime;

namespace UnrealEngine.LandscapeEditor;

[UEnum]
[UMetaPath("/Script/LandscapeEditor.ELandscapeMirrorOperation", "LandscapeEditor", UnrealModuleType.Engine)]
public enum ELandscapeMirrorOperation
{
	MinusXToPlusX,
	PlusXToMinusX,
	MinusYToPlusY,
	PlusYToMinusY,
	RotateMinusXToPlusX,
	RotatePlusXToMinusX,
	RotateMinusYToPlusY,
	RotatePlusYToMinusY
}
