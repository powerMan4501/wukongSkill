using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UEnum]
[UMetaPath("/Script/AIModule.EBTParallelMode", "AIModule", UnrealModuleType.Engine)]
public enum EBTParallelMode
{
	AbortBackground,
	WaitForBackground
}
