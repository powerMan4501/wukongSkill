using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ESetResolutionMethod", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ESetResolutionMethod
{
	Independent,
	MaxAxis,
	CellSize
}
