using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.UnitTagType")]
public enum EUnitTagType : byte
{
	[UMeta(MDFunc.DisplayName, "普通怪物")]
	NormalMonster,
	[UMeta(MDFunc.DisplayName, "小怪")]
	SmallMonster,
	Boss,
	[UMeta(MDFunc.DisplayName, "分身悟空")]
	ClonedWukong,
	[UMeta(MDFunc.DisplayName, "悟空")]
	Wukong,
	[UMeta(MDFunc.DisplayName, "变身主角")]
	TransitionPlayer,
	[UMeta(MDFunc.DisplayName, "僵尸大圣专用")]
	JSDS,
	[UMeta(MDFunc.DisplayName, "杨戬专用")]
	YangJian
}
