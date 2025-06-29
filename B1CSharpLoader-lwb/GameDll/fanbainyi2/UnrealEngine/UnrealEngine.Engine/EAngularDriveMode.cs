using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EAngularDriveMode", "Engine", UnrealModuleType.Engine)]
public enum EAngularDriveMode
{
	SLERP,
	TwistAndSwing
}
