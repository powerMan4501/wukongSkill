using UnrealEngine.Runtime;

namespace UnrealEngine.DetailCustomizations;

[UEnum]
[UMetaPath("/Script/DetailCustomizations.EMaterialImportMethod", "DetailCustomizations", UnrealModuleType.Engine)]
public enum EMaterialImportMethod
{
	CreateNewMaterials,
	CreateNewInstancedMaterials,
	DoNotCreateMaterialString
}
