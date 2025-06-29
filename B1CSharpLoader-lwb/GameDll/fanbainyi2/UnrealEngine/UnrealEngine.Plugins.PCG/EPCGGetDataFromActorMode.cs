using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[UMetaPath("/Script/PCG.EPCGGetDataFromActorMode", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGGetDataFromActorMode
{
	ParseActorComponents,
	GetSinglePoint,
	GetDataFromProperty,
	GetDataFromPCGComponent,
	GetDataFromPCGComponentOrParseComponents
}
