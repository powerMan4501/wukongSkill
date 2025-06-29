using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EDrawDebugItemType", "Engine", UnrealModuleType.Engine)]
public enum EDrawDebugItemType
{
	DirectionalArrow,
	Sphere,
	Line,
	OnScreenMessage,
	CoordinateSystem,
	Point
}
