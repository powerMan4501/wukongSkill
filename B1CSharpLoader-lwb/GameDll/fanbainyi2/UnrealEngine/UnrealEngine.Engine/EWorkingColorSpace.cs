using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EWorkingColorSpace", "Engine", UnrealModuleType.Engine)]
public enum EWorkingColorSpace
{
	SRGB = 1,
	Rec2020,
	ACESAP0,
	ACESAP1,
	P3DCI,
	P3D65,
	Custom
}
