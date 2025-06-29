using UnrealEngine.Runtime;

namespace UnrealEngine.Persona;

[UEnum]
[UMetaPath("/Script/Persona.EAnalysisSpace", "Persona", UnrealModuleType.Engine)]
public enum EAnalysisSpace
{
	World,
	Fixed,
	Changing,
	Moving
}
