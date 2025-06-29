using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EMaterialParameterAssociation", "Engine", UnrealModuleType.Engine)]
public enum EMaterialParameterAssociation
{
	LayerParameter,
	BlendParameter,
	GlobalParameter
}
