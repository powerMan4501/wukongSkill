using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AnimationLocomotionLibraryEditor;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/AnimationLocomotionLibraryEditor.EDistanceCurve_Axis", "AnimationLocomotionLibraryEditor", UnrealModuleType.EnginePlugin)]
public enum EDistanceCurve_Axis : byte
{
	X,
	Y,
	Z,
	XY,
	XZ,
	YZ,
	XYZ
}
