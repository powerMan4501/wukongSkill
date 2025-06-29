using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENiagaraScriptTemplateSpecification", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENiagaraScriptTemplateSpecification
{
	None,
	Template,
	Behavior
}
