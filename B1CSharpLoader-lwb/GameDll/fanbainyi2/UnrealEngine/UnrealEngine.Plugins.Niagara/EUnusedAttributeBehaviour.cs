using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.EUnusedAttributeBehaviour", "Niagara", UnrealModuleType.EnginePlugin)]
public enum EUnusedAttributeBehaviour
{
	Copy_,
	Zero,
	None,
	MarkInvalid,
	PassThrough
}
