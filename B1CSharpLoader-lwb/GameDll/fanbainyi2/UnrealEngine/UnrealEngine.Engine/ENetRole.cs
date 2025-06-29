using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ENetRole", "Engine", UnrealModuleType.Engine)]
public enum ENetRole
{
	ROLE_None,
	ROLE_SimulatedProxy,
	ROLE_AutonomousProxy,
	ROLE_Authority
}
