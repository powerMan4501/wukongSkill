using UnrealEngine.Runtime;

namespace GSDispLib;

[UEnum]
[USharpPath("/Script/b1-Managed.DispLibDBCNiagaraScalabilityKillMode")]
public enum DispLibDBCNiagaraScalabilityKillMode : byte
{
	[DisplayName("进入结束表现阶段")]
	[UMeta(MD.ToolTip, "和正常End一个特效的流程一样，通知特效进入结束表现阶段")]
	[UMeta(MDProp.DisplayPriority, 1)]
	IntoEndDispStage,
	[DisplayName("强制跳过结束表现阶段")]
	[UMeta(MD.ToolTip, "无视配置的【结束表现时间】，直接进入RealEnd阶段，这会立即触发 ReleaseToPool。对于本身就没有配【结束表现时间】的特效，这个模式和【进入结束表现阶段】模式没有区别")]
	[UMeta(MDProp.DisplayPriority, 2)]
	ForceNoEndDispStage,
	[UMeta(MDProp.DisplayPriority, 3)]
	[DisplayName("重置并复用")]
	[UMeta(MD.ToolTip, "此模式在新的特效Spawn之前进行检查，如果存需要被淘汰的特效就不会创建新的特效，而是直接复用被淘汰的特效，这样可以省去SpawnNiagara的消耗，但是如Attach等细节问题可能处理不完善，此模式应谨慎评估后按需选择")]
	ReuseByReset
}
