using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.AttrCostType")]
public enum EAttrCostType : byte
{
	None,
	Hp,
	Mp,
	Stamina,
	BloodBottleNum,
	SpecialEnergy,
	PotentialEnergy,
	TransEnergy,
	FabaoEnergy,
	VigorEnergy
}
