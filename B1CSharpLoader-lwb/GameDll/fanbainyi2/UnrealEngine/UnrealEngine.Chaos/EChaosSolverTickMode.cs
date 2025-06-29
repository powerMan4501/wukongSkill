using UnrealEngine.Runtime;

namespace UnrealEngine.Chaos;

[UEnum]
[UMetaPath("/Script/Chaos.EChaosSolverTickMode", "Chaos", UnrealModuleType.Engine)]
public enum EChaosSolverTickMode
{
	Fixed,
	Variable,
	VariableCapped,
	VariableCappedWithTarget
}
