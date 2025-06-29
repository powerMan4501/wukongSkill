using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.SpeedTreeImporter;

[UEnum]
[UMetaPath("/Script/SpeedTreeImporter.EImportLODType", "SpeedTreeImporter", UnrealModuleType.EnginePlugin)]
public enum EImportLODType
{
	ILT_PaintedFoliage,
	ILT_IndividualActors
}
