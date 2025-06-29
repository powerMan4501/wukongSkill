using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.SpeedTreeImporter;

[UEnum]
[UMetaPath("/Script/SpeedTreeImporter.EImportGeometryType", "SpeedTreeImporter", UnrealModuleType.EnginePlugin)]
public enum EImportGeometryType
{
	IGT_3D,
	IGT_Billboards,
	IGT_Both
}
