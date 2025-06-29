using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EFullyLoadPackageType", "Engine", UnrealModuleType.Engine)]
public enum EFullyLoadPackageType
{
	FULLYLOAD_Map,
	FULLYLOAD_Game_PreLoadClass,
	FULLYLOAD_Game_PostLoadClass,
	FULLYLOAD_Always,
	FULLYLOAD_Mutator
}
