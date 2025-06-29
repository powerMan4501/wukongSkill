using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENDILandscape_SourceMode", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENDILandscape_SourceMode
{
	Default,
	Source,
	AttachParent
}
