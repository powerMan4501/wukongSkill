using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ESuggestProjVelocityTraceOption", "Engine", UnrealModuleType.Engine)]
public enum ESuggestProjVelocityTraceOption
{
	DoNotTrace,
	TraceFullPath,
	OnlyTraceWhileAscending
}
