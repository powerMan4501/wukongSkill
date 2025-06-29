using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AlembicLibrary;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/AlembicLibrary.EAlembicImportType", "AlembicLibrary", UnrealModuleType.EnginePlugin)]
public enum EAlembicImportType : byte
{
	StaticMesh,
	GeometryCache,
	Skeletal
}
