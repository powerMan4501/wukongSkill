using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.BossRushPlayerStartType")]
public enum EBossRushPlayerStartType : byte
{
	None,
	[DisplayName("再战")]
	Single,
	[DisplayName("连战")]
	Group
}
