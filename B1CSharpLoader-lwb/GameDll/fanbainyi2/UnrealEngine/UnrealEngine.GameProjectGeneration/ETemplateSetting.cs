using UnrealEngine.Runtime;

namespace UnrealEngine.GameProjectGeneration;

[UEnum]
[UMetaPath("/Script/GameProjectGeneration.ETemplateSetting", "GameProjectGeneration", UnrealModuleType.Engine)]
public enum ETemplateSetting
{
	Languages,
	HardwareTarget,
	GraphicsPreset,
	StarterContent,
	XR,
	Raytracing,
	All
}
