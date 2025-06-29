using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EMaterialDomain", "Engine", UnrealModuleType.Engine)]
public enum EMaterialDomain
{
	MD_Surface,
	MD_DeferredDecal,
	MD_LightFunction,
	MD_Volume,
	MD_PostProcess,
	MD_UI,
	MD_RuntimeVirtualTexture
}
