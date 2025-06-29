using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UEnum]
[UMetaPath("/Script/AnimGraphRuntime.ERBFSolverType", "AnimGraphRuntime", UnrealModuleType.Engine)]
public enum ERBFSolverType
{
	Additive,
	Interpolative
}
