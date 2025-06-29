using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENDISkelMesh_GpuMaxInfluences", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENDISkelMesh_GpuMaxInfluences
{
	AllowMax4,
	AllowMax8,
	Unlimited
}
