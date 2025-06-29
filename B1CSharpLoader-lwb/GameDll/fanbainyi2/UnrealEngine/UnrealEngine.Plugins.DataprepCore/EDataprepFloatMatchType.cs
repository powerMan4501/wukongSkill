using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DataprepCore;

[UEnum]
[UMetaPath("/Script/DataprepCore.EDataprepFloatMatchType", "DataprepCore", UnrealModuleType.EnginePlugin)]
public enum EDataprepFloatMatchType
{
	LessThan,
	GreatherThan,
	IsNearlyEqual
}
