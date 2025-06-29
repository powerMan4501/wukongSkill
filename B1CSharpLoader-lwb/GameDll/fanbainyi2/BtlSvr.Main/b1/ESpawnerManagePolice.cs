using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.SpawnerManagePolice")]
public enum ESpawnerManagePolice : byte
{
	[DisplayName("与前状态保持一致")]
	SameAsPrevious,
	[DisplayName("与战斗无关")]
	[Tooltip("不做管理，自行开始结束")]
	Auto,
	[Tooltip("战斗开始时刷怪，战斗结束时销毁怪物")]
	[DisplayName("与战斗同时开始结束")]
	SameAsBattle,
	[Tooltip("战斗开始时刷怪，战斗结束时不做管理，刷出的怪物不会主动销毁")]
	[DisplayName("仅与战斗同时开始")]
	OnlyBeginSameAsBattle,
	[DisplayName("仅与战斗同时结束")]
	[Tooltip("自动开始，战斗结束时销毁怪物")]
	OnlyEndSameAsBattle,
	[DisplayName("禁用")]
	[Tooltip("不刷怪")]
	Disable,
	[DisplayName("状态开始时刷新，战斗结束时销毁")]
	[Tooltip("进入状态刷怪，退出状态销毁怪物")]
	BeginLikeStateEndLikeBattle
}
