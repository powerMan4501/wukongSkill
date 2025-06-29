using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENiagaraInputNodeUsage", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENiagaraInputNodeUsage
{
	Undefined,
	Parameter,
	Attribute,
	SystemConstant,
	TranslatorConstant,
	RapidIterationParameter
}
