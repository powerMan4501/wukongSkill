using UnrealEngine.Runtime;

namespace b1.Plugins.HoudiniEngine;

[UEnum]
[UMetaPath("/Script/HoudiniEngine.EHoudiniSplitType", "HoudiniEngine", UnrealModuleType.GamePlugin)]
public enum EHoudiniSplitType
{
	Invalid,
	Normal,
	LOD,
	RenderedComplexCollider,
	InvisibleComplexCollider,
	RenderedUCXCollider,
	InvisibleUCXCollider,
	RenderedSimpleCollider,
	InvisibleSimpleCollider
}
