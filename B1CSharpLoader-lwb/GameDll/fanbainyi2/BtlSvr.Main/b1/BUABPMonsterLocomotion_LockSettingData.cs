using UnrealEngine.Engine;

namespace b1;

public class BUABPMonsterLocomotion_LockSettingData
{
	public UAnimSequence ASLockWalkFwd { get; private set; }

	public UAnimSequence ASLockWalkFR { get; private set; }

	public UAnimSequence ASLockWalkBR { get; private set; }

	public UAnimSequence ASLockWalkFL { get; private set; }

	public UAnimSequence ASLockWalkBL { get; private set; }

	public UAnimSequence ASLockWalkBwd { get; private set; }

	public BUABPMonsterLocomotion_Lock_ExplicitTimeForMoveStopSettingData ExplicitTimeForLeftFootStop { get; private set; }

	public BUABPMonsterLocomotion_Lock_ExplicitTimeForMoveStopSettingData ExplicitTimeForRightFootStop { get; private set; }

	public BUABPMonsterLocomotion_Lock_StopBlendAnimSettingData StopLeftBlendAnim { get; private set; }

	public BUABPMonsterLocomotion_Lock_StopBlendAnimSettingData StopRightBlendAnim { get; private set; }

	public BUABPMonsterLocomotion_LockSettingData(in FAnimHumanoidSetting_MonsterLocomotion_Lock Setting)
	{
		ASLockWalkFwd = Setting.ASLockWalkFwd;
		ASLockWalkFR = Setting.ASLockWalkFR;
		ASLockWalkBR = Setting.ASLockWalkBR;
		ASLockWalkFL = Setting.ASLockWalkFL;
		ASLockWalkBL = Setting.ASLockWalkBL;
		ASLockWalkBwd = Setting.ASLockWalkBwd;
		ExplicitTimeForLeftFootStop = new BUABPMonsterLocomotion_Lock_ExplicitTimeForMoveStopSettingData(in Setting.ExplicitTimeForLeftFootStop);
		ExplicitTimeForRightFootStop = new BUABPMonsterLocomotion_Lock_ExplicitTimeForMoveStopSettingData(in Setting.ExplicitTimeForRightFootStop);
		StopLeftBlendAnim = new BUABPMonsterLocomotion_Lock_StopBlendAnimSettingData(in Setting.StopLeftBlendAnim);
		StopRightBlendAnim = new BUABPMonsterLocomotion_Lock_StopBlendAnimSettingData(in Setting.StopRightBlendAnim);
	}
}
