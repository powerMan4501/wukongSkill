using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EAdditiveBasePoseType", "Engine", UnrealModuleType.Engine)]
public enum EAdditiveBasePoseType
{
	ABPT_None,
	ABPT_RefPose,
	ABPT_AnimScaled,
	ABPT_AnimFrame,
	ABPT_LocalAnimFrame
}
