using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DataprepLibraries;

[UEnum]
[UMetaPath("/Script/DataprepLibraries.EDataprepSizeFilterMode", "DataprepLibraries", UnrealModuleType.EnginePlugin)]
public enum EDataprepSizeFilterMode
{
	SmallerThan,
	BiggerThan
}
