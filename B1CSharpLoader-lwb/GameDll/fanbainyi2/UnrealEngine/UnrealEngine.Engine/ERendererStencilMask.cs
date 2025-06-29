using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ERendererStencilMask", "Engine", UnrealModuleType.Engine)]
public enum ERendererStencilMask
{
	ERSM_Default,
	ERSM_255,
	ERSM_1,
	ERSM_2,
	ERSM_4,
	ERSM_8,
	ERSM_16,
	ERSM_32,
	ERSM_64,
	ERSM_128
}
