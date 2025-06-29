using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UEnum]
[UMetaPath("/Script/AIModule.EEnvTestWeight", "AIModule", UnrealModuleType.Engine)]
public enum EEnvTestWeight
{
	None,
	Square,
	Inverse,
	Unused,
	Constant,
	Skip
}
