using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.EGI_Loading_SwitchTeleportType_Result")]
public enum EGI_Loading_SwitchTeleportType_Result : byte
{
	[DisplayName("同关卡传送")]
	TeleportToSameLevel,
	[DisplayName("跨关卡传送，不修改 PlayerGameMode")]
	TravelLevelToSamePlayerGameMode,
	[DisplayName("传送去浮屠塔")]
	TravelLevelToParty,
	[DisplayName("传送去单机关卡")]
	TravelLevelToConsole
}
