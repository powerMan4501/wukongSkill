using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.TargetLevelNetType")]
public enum ETargetLevelNetType : byte
{
	[DisplayName("主菜单")]
	MainMenu,
	[DisplayName("单机")]
	StandAlone,
	[DisplayName("房主")]
	ListenServer,
	[DisplayName("客户端")]
	Client,
	[DisplayName("其他")]
	Other
}
