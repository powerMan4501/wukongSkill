using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.EAMScaleType")]
public enum EAMScaleType : byte
{
	[DisplayName("根据目标缩放")]
	[Tooltip("如果没有目标则不缩放")]
	ScaleForTarget,
	[DisplayName("根据场景物件缩放")]
	[Tooltip("如果没有场景物件则不缩放")]
	ScaleForSceneItem,
	[DisplayName("根据缓存点缩放")]
	[Tooltip("找到指定缓存点集里第一个点")]
	ScaleForCachedPoint,
	[Tooltip("")]
	[DisplayName("单纯缩放")]
	UsePureScale,
	[DisplayName("根据技能基准目标缩放")]
	[Tooltip("如果没有目标则不缩放")]
	UseSkillBaseTarget
}
