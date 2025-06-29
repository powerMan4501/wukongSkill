using System.Collections.Generic;

namespace b1;

public class BUC_PlayerInputActionData : IBUC_PlayerInputActionData
{
	public float AxisSkillDragY { get; set; }

	public float AxisSkillDragX { get; set; }

	public bool IsWithInputMoving { get; set; }

	public bool bPressedSprinting { get; set; }

	public float MoveWeakInputTimer { get; set; }

	public float DeltaTime { get; set; }

	public bool bInPressedSpinModeState { get; set; }

	public List<int> EffectIDList_SwitchWeaponPose { get; set; }

	public float TriggerEffectCoolDown_SwitchWeaponPose { get; set; }

	public float LastTriggerEffectTime_SwitchWeaponPose { get; set; }

	public BUC_PlayerInputActionData()
	{
		EffectIDList_SwitchWeaponPose = new List<int>();
	}
}
