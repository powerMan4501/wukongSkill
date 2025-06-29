using UnrealEngine.Runtime;

namespace UnrealEngine.PhysicsCore;

[UEnum]
[UMetaPath("/Script/PhysicsCore.ESleepFamily", "PhysicsCore", UnrealModuleType.Engine)]
public enum ESleepFamily
{
	Normal,
	Sensitive,
	Custom
}
