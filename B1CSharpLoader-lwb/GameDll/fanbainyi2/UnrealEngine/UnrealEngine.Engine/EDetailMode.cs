using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EDetailMode", "Engine", UnrealModuleType.Engine)]
public enum EDetailMode
{
	DM_Low,
	DM_Medium,
	DM_High
}
