using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EDefaultBackBufferPixelFormat", "Engine", UnrealModuleType.Engine)]
public enum EDefaultBackBufferPixelFormat
{
	DBBPF_B8G8R8A8,
	DBBPF_A16B16G16R16_DEPRECATED,
	DBBPF_FloatRGB_DEPRECATED,
	DBBPF_FloatRGBA,
	DBBPF_A2B10G10R10
}
