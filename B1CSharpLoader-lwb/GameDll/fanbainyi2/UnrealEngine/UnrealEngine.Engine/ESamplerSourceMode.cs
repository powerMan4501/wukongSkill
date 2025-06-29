using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ESamplerSourceMode", "Engine", UnrealModuleType.Engine)]
public enum ESamplerSourceMode
{
	SSM_FromTextureAsset,
	SSM_Wrap_WorldGroupSettings,
	SSM_Clamp_WorldGroupSettings
}
