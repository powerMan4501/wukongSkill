using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.EDOFMode", "Engine", UnrealModuleType.Engine)]
public enum EDOFMode : byte
{
	Default,
	SixDOF,
	YZPlane,
	XZPlane,
	XYPlane,
	CustomPlane,
	None
}
