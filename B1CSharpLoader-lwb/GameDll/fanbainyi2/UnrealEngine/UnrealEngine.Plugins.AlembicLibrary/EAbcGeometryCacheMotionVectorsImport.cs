using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AlembicLibrary;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/AlembicLibrary.EAbcGeometryCacheMotionVectorsImport", "AlembicLibrary", UnrealModuleType.EnginePlugin)]
public enum EAbcGeometryCacheMotionVectorsImport : byte
{
	NoMotionVectors,
	ImportAbcVelocitiesAsMotionVectors,
	CalculateMotionVectorsDuringImport
}
