using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.UnitCompNeedLevel")]
public enum EUnitCompNeedLevel : byte
{
	Unused,
	DebugAndTest,
	OnlyTest,
	OnlyDebug,
	Alter,
	Need
}
