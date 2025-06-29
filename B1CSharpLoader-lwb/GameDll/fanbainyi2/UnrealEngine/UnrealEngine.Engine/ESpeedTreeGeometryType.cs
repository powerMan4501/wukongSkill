using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ESpeedTreeGeometryType", "Engine", UnrealModuleType.Engine)]
public enum ESpeedTreeGeometryType
{
	STG_Branch,
	STG_Frond,
	STG_Leaf,
	STG_FacingLeaf,
	STG_Billboard
}
