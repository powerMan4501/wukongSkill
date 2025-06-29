using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UEnum]
[UMetaPath("/Script/UnrealEd.EPlayNetMode", "UnrealEd", UnrealModuleType.Engine)]
public enum EPlayNetMode
{
	PIE_Standalone,
	PIE_ListenServer,
	PIE_Client
}
