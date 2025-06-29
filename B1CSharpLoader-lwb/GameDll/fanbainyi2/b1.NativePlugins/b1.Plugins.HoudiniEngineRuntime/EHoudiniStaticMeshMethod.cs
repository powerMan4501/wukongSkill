using UnrealEngine.Runtime;

namespace b1.Plugins.HoudiniEngineRuntime;

[UEnum]
[UMetaPath("/Script/HoudiniEngineRuntime.EHoudiniStaticMeshMethod", "HoudiniEngineRuntime", UnrealModuleType.GamePlugin)]
public enum EHoudiniStaticMeshMethod
{
	RawMesh,
	FMeshDescription,
	UHoudiniStaticMesh
}
