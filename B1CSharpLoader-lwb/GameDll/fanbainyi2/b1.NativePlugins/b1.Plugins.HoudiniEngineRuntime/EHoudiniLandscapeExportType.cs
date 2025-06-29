using UnrealEngine.Runtime;

namespace b1.Plugins.HoudiniEngineRuntime;

[UEnum]
[UMetaPath("/Script/HoudiniEngineRuntime.EHoudiniLandscapeExportType", "HoudiniEngineRuntime", UnrealModuleType.GamePlugin)]
public enum EHoudiniLandscapeExportType
{
	Heightfield,
	Mesh,
	Points
}
