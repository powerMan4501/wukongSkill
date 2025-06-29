using UnrealEngine.Runtime;

namespace b1.GSMUI.GSWidget;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.DefaulValueType")]
public enum EDefaulValueType : byte
{
	Percent,
	PlayerHp,
	PlayerMp,
	PlayerSt,
	UnitHp,
	MultiMapping
}
