using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/UnrealEd.EFbxExportCompatibility", "UnrealEd", UnrealModuleType.Engine)]
public enum EFbxExportCompatibility : byte
{
	FBX_2011,
	FBX_2012,
	FBX_2013,
	FBX_2014,
	FBX_2016,
	FBX_2018,
	FBX_2019,
	FBX_2020
}
