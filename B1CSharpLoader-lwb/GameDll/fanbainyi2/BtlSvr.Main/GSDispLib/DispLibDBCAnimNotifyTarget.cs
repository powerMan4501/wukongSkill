using UnrealEngine.Runtime;

namespace GSDispLib;

[UEnum]
[USharpPath("/Script/b1-Managed.DispLibDBCAnimNotifyTarget")]
public enum DispLibDBCAnimNotifyTarget : byte
{
	[DisplayName("无")]
	None,
	[DisplayName("自身")]
	Self,
	[DisplayName("当前敌对目标")]
	EnemyTarget
}
