using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingTools;

[UEnum]
[UMetaPath("/Script/MeshModelingTools.EUVProjectionToolInitializationMode", "MeshModelingTools", UnrealModuleType.EnginePlugin)]
public enum EUVProjectionToolInitializationMode
{
	Default,
	UsePrevious,
	AutoFit,
	AutoFitAlign
}
