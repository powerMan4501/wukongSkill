using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DataprepCore;

[UEnum]
[UMetaPath("/Script/DataprepCore.EDataprepIntegerMatchType", "DataprepCore", UnrealModuleType.EnginePlugin)]
public enum EDataprepIntegerMatchType
{
	LessThan,
	GreatherThan,
	IsEqual,
	InBetween
}
