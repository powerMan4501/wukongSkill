using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ECsgOper", "Engine", UnrealModuleType.Engine)]
public enum ECsgOper
{
	CSG_Active,
	CSG_Add,
	CSG_Subtract,
	CSG_Intersect,
	CSG_Deintersect,
	CSG_None
}
