using UnrealEngine.Runtime;

namespace b1.Plugins.HoudiniEngineRuntime;

[UEnum]
[UMetaPath("/Script/HoudiniEngineRuntime.EAttribOwner", "HoudiniEngineRuntime", UnrealModuleType.GamePlugin)]
public enum EAttribOwner
{
	Invalid = -1,
	Vertex,
	Point,
	Prim,
	Detail
}
