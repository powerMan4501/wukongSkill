using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EParticleUVFlipMode", "Engine", UnrealModuleType.Engine)]
public enum EParticleUVFlipMode
{
	None,
	FlipUV,
	FlipUOnly,
	FlipVOnly,
	RandomFlipUV,
	RandomFlipUOnly,
	RandomFlipVOnly,
	RandomFlipUVIndependent
}
