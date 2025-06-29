using BtlShare;

namespace b1;

internal class BUIASwitchWeaponPosePoke : b1.BUIASwitchWeaponPoseBase
{
	public BUIASwitchWeaponPosePoke()
	{
		InputActionType = EInputActionType.SwitchWeaponPosePoke;
	}

	protected override int GetStanceType()
	{
		return 2;
	}
}
