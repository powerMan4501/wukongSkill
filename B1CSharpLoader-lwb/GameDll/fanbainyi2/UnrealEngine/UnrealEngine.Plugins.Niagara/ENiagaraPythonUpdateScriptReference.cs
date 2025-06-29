using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENiagaraPythonUpdateScriptReference", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENiagaraPythonUpdateScriptReference
{
	None,
	ScriptAsset,
	DirectTextEntry
}
