using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingTools;

[UEnum]
[UMetaPath("/Script/MeshModelingTools.EUVProjectionToolActions", "MeshModelingTools", UnrealModuleType.EnginePlugin)]
public enum EUVProjectionToolActions
{
	NoAction,
	AutoFit,
	AutoFitAlign,
	Reset
}
