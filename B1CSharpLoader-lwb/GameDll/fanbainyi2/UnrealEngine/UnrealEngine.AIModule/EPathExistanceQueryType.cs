using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UEnum]
[UMetaPath("/Script/AIModule.EPathExistanceQueryType", "AIModule", UnrealModuleType.Engine)]
public enum EPathExistanceQueryType
{
	NavmeshRaycast2D,
	HierarchicalQuery,
	RegularPathFinding
}
