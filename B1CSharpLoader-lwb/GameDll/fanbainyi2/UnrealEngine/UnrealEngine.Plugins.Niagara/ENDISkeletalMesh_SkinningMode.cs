using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENDISkeletalMesh_SkinningMode", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENDISkeletalMesh_SkinningMode
{
	Invalid = 255,
	None = 0,
	SkinOnTheFly = 1,
	PreSkin = 2
}
