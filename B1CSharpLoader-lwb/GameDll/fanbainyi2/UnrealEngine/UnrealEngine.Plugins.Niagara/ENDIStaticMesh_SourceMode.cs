using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENDIStaticMesh_SourceMode", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENDIStaticMesh_SourceMode
{
	Default,
	Source,
	AttachParent,
	DefaultMeshOnly
}
