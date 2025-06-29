using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.AtkFXOnGroundType")]
public enum EAtkFXOnGroundType : byte
{
	[Tooltip("DBC是配表")]
	[DisplayName("使用DBC")]
	UseDBC,
	[DisplayName("使用材质笔刷")]
	[Tooltip("也是往RT上画")]
	UseMatPainter
}
