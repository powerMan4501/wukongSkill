using UnrealEngine.Engine;

namespace b1.BGU.BUAnim;

internal static class AbpHelperUtil
{
	public static bool ShouldInitABPMoveModeData(AActor Owner, EABPMoveMode ABPMoveMode, BUABPSettingData Setting)
	{
		if (Setting == null)
		{
			BGW_LogUtil.LogError("[{0}] ABPSetting is null!", Owner.GetName());
			return false;
		}
		BUABPCommonSettingData commonSetting = Setting.CommonSetting;
		if (ABPMoveMode == EABPMoveMode.MotionMatching)
		{
			return commonSetting.ABPMoveMode == EABPMoveMode.MotionMatching;
		}
		if (commonSetting.ABPMoveMode == ABPMoveMode)
		{
			return true;
		}
		if (commonSetting.ABPMoveMode == EABPMoveMode.MotionMatching)
		{
			return Setting.MotionMatchingSetting.SpareMoveMode == ABPMoveMode;
		}
		return false;
	}

	public static void InitABPMoveModeAnimInstance(UAnimInstance ParentAnimInst, EABPMoveMode ABPMoveMode)
	{
		if (!(ParentAnimInst == null))
		{
			switch (ABPMoveMode)
			{
			case EABPMoveMode.Locomotion_Simple4Dir:
				UGSE_AnimFuncLib.InitAnimGraphNode(ParentAnimInst, B1GlobalFNames.Simple4Dir);
				break;
			case EABPMoveMode.MotionMatching:
				UGSE_AnimFuncLib.InitAnimGraphNode(ParentAnimInst, B1GlobalFNames.MotionMatching);
				break;
			case EABPMoveMode.SimpleFlyControl:
			case EABPMoveMode.ComplexFlyControl:
				UGSE_AnimFuncLib.InitAnimGraphNode(ParentAnimInst, B1GlobalFNames.FlyControl);
				break;
			case EABPMoveMode.PlayerLocomotion:
				UGSE_AnimFuncLib.InitAnimGraphNode(ParentAnimInst, B1GlobalFNames.PlayerLocomotion);
				break;
			case EABPMoveMode.MonsterLocomotion:
				UGSE_AnimFuncLib.InitAnimGraphNode(ParentAnimInst, B1GlobalFNames.MonsterLocomotion);
				break;
			case EABPMoveMode.AdvancedMonsterLocomotion:
				UGSE_AnimFuncLib.InitAnimGraphNode(ParentAnimInst, B1GlobalFNames.AdvancedMonsterLocomotion);
				break;
			case EABPMoveMode.QuadrupedLocomotion:
				UGSE_AnimFuncLib.InitAnimGraphNode(ParentAnimInst, B1GlobalFNames.QuadrupedLocomotion);
				break;
			case EABPMoveMode.Locomotion_Paragon4Dir:
			case EABPMoveMode.Locomotion_Simple8Dir:
			case EABPMoveMode.CarMove:
			case EABPMoveMode.Locomotion_Player8Dir:
				break;
			}
		}
	}
}
