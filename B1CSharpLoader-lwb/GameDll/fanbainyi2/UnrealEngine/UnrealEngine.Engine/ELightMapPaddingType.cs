using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ELightMapPaddingType", "Engine", UnrealModuleType.Engine)]
public enum ELightMapPaddingType
{
	LMPT_NormalPadding,
	LMPT_PrePadding,
	LMPT_NoPadding
}
