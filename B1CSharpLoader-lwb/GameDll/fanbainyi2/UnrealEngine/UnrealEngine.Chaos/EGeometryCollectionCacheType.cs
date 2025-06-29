using UnrealEngine.Runtime;

namespace UnrealEngine.Chaos;

[UEnum]
[UMetaPath("/Script/Chaos.EGeometryCollectionCacheType", "Chaos", UnrealModuleType.Engine)]
public enum EGeometryCollectionCacheType
{
	None,
	Record,
	Play,
	RecordAndPlay
}
