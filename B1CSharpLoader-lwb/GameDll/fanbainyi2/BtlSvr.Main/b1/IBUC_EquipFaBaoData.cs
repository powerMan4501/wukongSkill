using GUR.Runtime;

namespace b1;

[NeedToUI]
public interface IBUC_EquipFaBaoData
{
	EFaBaoState FaBaoState { get; }

	float FaBaoCastDuration { get; }

	float CurrentCastDuration { get; }

	float FaBaoCoolDownPercentage { get; }

	int GetEquippedFaBaoID();

	bool GetCanCastFaBaoSkill();
}
