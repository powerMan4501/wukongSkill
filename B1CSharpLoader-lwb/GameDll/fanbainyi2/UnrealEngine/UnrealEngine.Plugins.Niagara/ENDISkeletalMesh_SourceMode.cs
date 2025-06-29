using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENDISkeletalMesh_SourceMode", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENDISkeletalMesh_SourceMode
{
	Default,
	Source,
	AttachParent
}
