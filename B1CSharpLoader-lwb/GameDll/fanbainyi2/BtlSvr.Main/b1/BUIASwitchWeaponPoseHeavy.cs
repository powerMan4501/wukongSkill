using BtlShare;

namespace b1;

internal class BUIASwitchWeaponPoseHeavy : b1.BUIASwitchWeaponPoseBase
{
	public BUIASwitchWeaponPoseHeavy()
	{
		InputActionType = EInputActionType.SwitchWeaponPoseHeavy;
	}

	protected override int GetStanceType()
	{
		return 0;
	}
}
