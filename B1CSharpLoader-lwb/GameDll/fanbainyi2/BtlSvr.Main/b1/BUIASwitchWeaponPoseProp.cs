using BtlShare;

namespace b1;

internal class BUIASwitchWeaponPoseProp : b1.BUIASwitchWeaponPoseBase
{
	public BUIASwitchWeaponPoseProp()
	{
		InputActionType = EInputActionType.SwitchWeaponPoseProp;
	}

	protected override int GetStanceType()
	{
		return 1;
	}
}
