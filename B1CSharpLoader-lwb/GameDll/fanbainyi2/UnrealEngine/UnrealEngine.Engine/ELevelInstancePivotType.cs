using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ELevelInstancePivotType", "Engine", UnrealModuleType.Engine)]
public enum ELevelInstancePivotType
{
	CenterMinZ,
	Center,
	Actor,
	WorldOrigin
}
