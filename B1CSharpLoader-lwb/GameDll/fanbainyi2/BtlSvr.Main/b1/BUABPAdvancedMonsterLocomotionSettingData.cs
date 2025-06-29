using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUABPAdvancedMonsterLocomotionSettingData : BUABPSettingDataBase
{
	public ELMFreeMode FreeMode { get; private set; }

	public ELMLockMode LockMode { get; private set; }

	public float WalkMaxAcceleration { get; private set; }

	public float WalkBrakingFriction { get; private set; }

	public float WalkBrakingDecelerationWalking { get; private set; }

	public float RunMaxAcceleration { get; private set; }

	public float RunBrakingFriction { get; private set; }

	public float RunBrakingDecelerationWalking { get; private set; }

	public float RushMaxAcceleration { get; private set; }

	public float RushBrakingFriction { get; private set; }

	public float RushBrakingDecelerationWalking { get; private set; }

	public FVector2D StartAndTurnAnimPlayRateClamped { get; private set; }

	public FVector2D LoopAnimPlayRateClamped { get; private set; }

	public List<UAnimSequence> ASIdleList { get; private set; }

	public UAnimSequence ASWalkStartFwd { get; private set; }

	public UAnimSequence ASWalkStartBwd { get; private set; }

	public UAnimSequence ASWalkStartLeftMin { get; private set; }

	public UAnimSequence ASWalkStartLeftMax { get; private set; }

	public UAnimSequence ASWalkStartRightMin { get; private set; }

	public UAnimSequence ASWalkStartRightMax { get; private set; }

	public UAnimSequence ASWalkStartLF { get; private set; }

	public UAnimSequence ASWalkStartLB { get; private set; }

	public UAnimSequence ASWalkStartRF { get; private set; }

	public UAnimSequence ASWalkStartRB { get; private set; }

	public UAnimSequence ASWalkLoopFwd { get; private set; }

	public UAnimSequence ASWalkLoopBwd { get; private set; }

	public UAnimSequence ASWalkLoopLF { get; private set; }

	public UAnimSequence ASWalkLoopLB { get; private set; }

	public UAnimSequence ASWalkLoopRF { get; private set; }

	public UAnimSequence ASWalkLoopRB { get; private set; }

	public UAnimSequence ASWalkSharpturnLeftMin { get; private set; }

	public UAnimSequence ASWalkSharpturnLeftMax { get; private set; }

	public UAnimSequence ASWalkSharpturnRightMin { get; private set; }

	public UAnimSequence ASWalkSharpturnRightMax { get; private set; }

	public UAnimSequence ASWalkPivotFwd { get; private set; }

	public UAnimSequence ASWalkPivotBwd { get; private set; }

	public UAnimSequence ASWalkPivotLF { get; private set; }

	public UAnimSequence ASWalkPivotLB { get; private set; }

	public UAnimSequence ASWalkPivotRF { get; private set; }

	public UAnimSequence ASWalkPivotRB { get; private set; }

	public UAnimSequence ASWalkTransFRToBR { get; private set; }

	public UAnimSequence ASWalkTransBRToFR { get; private set; }

	public UAnimSequence ASWalkTransFLToBL { get; private set; }

	public UAnimSequence ASWalkTransBLToFL { get; private set; }

	public UAnimSequence ASWalkStopFwd { get; private set; }

	public UAnimSequence ASWalkStopBwd { get; private set; }

	public UAnimSequence ASWalkStopLF { get; private set; }

	public UAnimSequence ASWalkStopLB { get; private set; }

	public UAnimSequence ASWalkStopRF { get; private set; }

	public UAnimSequence ASWalkStopRB { get; private set; }

	public UAnimSequence ASWalkLoopAddPose { get; private set; }

	public List<UAnimSequence> ASWalkLoopAdditiveList { get; private set; }

	public UAnimSequence ASRunStartFwd { get; private set; }

	public UAnimSequence ASRunStartBwd { get; private set; }

	public UAnimSequence ASRunStartLeftMin { get; private set; }

	public UAnimSequence ASRunStartLeftMax { get; private set; }

	public UAnimSequence ASRunStartRightMin { get; private set; }

	public UAnimSequence ASRunStartRightMax { get; private set; }

	public UAnimSequence ASRunStartLF { get; private set; }

	public UAnimSequence ASRunStartLB { get; private set; }

	public UAnimSequence ASRunStartRF { get; private set; }

	public UAnimSequence ASRunStartRB { get; private set; }

	public UAnimSequence ASRunLoopFwd { get; private set; }

	public UAnimSequence ASRunLoopBwd { get; private set; }

	public UAnimSequence ASRunLoopLF { get; private set; }

	public UAnimSequence ASRunLoopLB { get; private set; }

	public UAnimSequence ASRunLoopRF { get; private set; }

	public UAnimSequence ASRunLoopRB { get; private set; }

	public UAnimSequence ASRunSharpturnLeftMin { get; private set; }

	public UAnimSequence ASRunSharpturnLeftMax { get; private set; }

	public UAnimSequence ASRunSharpturnRightMin { get; private set; }

	public UAnimSequence ASRunSharpturnRightMax { get; private set; }

	public UAnimSequence ASRunPivotFwd { get; private set; }

	public UAnimSequence ASRunPivotBwd { get; private set; }

	public UAnimSequence ASRunPivotLF { get; private set; }

	public UAnimSequence ASRunPivotLB { get; private set; }

	public UAnimSequence ASRunPivotRF { get; private set; }

	public UAnimSequence ASRunPivotRB { get; private set; }

	public UAnimSequence ASRunTransFRToBR { get; private set; }

	public UAnimSequence ASRunTransBRToFR { get; private set; }

	public UAnimSequence ASRunTransFLToBL { get; private set; }

	public UAnimSequence ASRunTransBLToFL { get; private set; }

	public UAnimSequence ASRunStopFwd { get; private set; }

	public UAnimSequence ASRunStopBwd { get; private set; }

	public UAnimSequence ASRunStopLF { get; private set; }

	public UAnimSequence ASRunStopLB { get; private set; }

	public UAnimSequence ASRunStopRF { get; private set; }

	public UAnimSequence ASRunStopRB { get; private set; }

	public UAnimSequence ASRunLoopAddPose { get; private set; }

	public List<UAnimSequence> ASRunLoopAdditiveList { get; private set; }

	public UAnimSequence ASRushStartFwd { get; private set; }

	public UAnimSequence ASRushStartLeftMin { get; private set; }

	public UAnimSequence ASRushStartLeftMax { get; private set; }

	public UAnimSequence ASRushStartRightMin { get; private set; }

	public UAnimSequence ASRushStartRightMax { get; private set; }

	public UAnimSequence ASRushLoopFwd { get; private set; }

	public UAnimSequence ASRushSharpturnLeftMin { get; private set; }

	public UAnimSequence ASRushSharpturnLeftMax { get; private set; }

	public UAnimSequence ASRushSharpturnRightMin { get; private set; }

	public UAnimSequence ASRushSharpturnRightMax { get; private set; }

	public UAnimSequence ASRushStopFwd { get; private set; }

	public UAnimSequence ASRushLoopAddPose { get; private set; }

	public List<UAnimSequence> ASRushLoopAdditiveList { get; private set; }

	public override void InitSettingData(in BGWDataAsset_AbpHumanoidSetting ABPSetting)
	{
		if (!(ABPSetting == null))
		{
			FAnimHumanoidSetting_AdvancedMonsterLocomotion advancedMonsterLocomotionSetting = ABPSetting.AdvancedMonsterLocomotionSetting;
			FreeMode = advancedMonsterLocomotionSetting.FreeMode;
			LockMode = advancedMonsterLocomotionSetting.LockMode;
			WalkMaxAcceleration = advancedMonsterLocomotionSetting.WalkMaxAcceleration;
			WalkBrakingFriction = advancedMonsterLocomotionSetting.WalkBrakingFriction;
			WalkBrakingDecelerationWalking = advancedMonsterLocomotionSetting.WalkBrakingDecelerationWalking;
			RunMaxAcceleration = advancedMonsterLocomotionSetting.RunMaxAcceleration;
			RunBrakingFriction = advancedMonsterLocomotionSetting.RunBrakingFriction;
			RunBrakingDecelerationWalking = advancedMonsterLocomotionSetting.RunBrakingDecelerationWalking;
			RushMaxAcceleration = advancedMonsterLocomotionSetting.RushMaxAcceleration;
			RushBrakingFriction = advancedMonsterLocomotionSetting.RushBrakingFriction;
			RushBrakingDecelerationWalking = advancedMonsterLocomotionSetting.RushBrakingDecelerationWalking;
			StartAndTurnAnimPlayRateClamped = advancedMonsterLocomotionSetting.StartAndTurnAnimPlayRateClamped;
			LoopAnimPlayRateClamped = advancedMonsterLocomotionSetting.LoopAnimPlayRateClamped;
			ASIdleList = advancedMonsterLocomotionSetting.ASIdleList;
			ASWalkStartFwd = advancedMonsterLocomotionSetting.ASWalkStartFwd;
			ASWalkStartBwd = advancedMonsterLocomotionSetting.ASWalkStartBwd;
			ASWalkStartLeftMin = advancedMonsterLocomotionSetting.ASWalkStartLeftMin;
			ASWalkStartLeftMax = advancedMonsterLocomotionSetting.ASWalkStartLeftMax;
			ASWalkStartRightMin = advancedMonsterLocomotionSetting.ASWalkStartRightMin;
			ASWalkStartRightMax = advancedMonsterLocomotionSetting.ASWalkStartRightMax;
			ASWalkStartLF = advancedMonsterLocomotionSetting.ASWalkStartLF;
			ASWalkStartLB = advancedMonsterLocomotionSetting.ASWalkStartLB;
			ASWalkStartRF = advancedMonsterLocomotionSetting.ASWalkStartRF;
			ASWalkStartRB = advancedMonsterLocomotionSetting.ASWalkStartRB;
			ASWalkLoopFwd = advancedMonsterLocomotionSetting.ASWalkLoopFwd;
			ASWalkLoopBwd = advancedMonsterLocomotionSetting.ASWalkLoopBwd;
			ASWalkLoopLF = advancedMonsterLocomotionSetting.ASWalkLoopLF;
			ASWalkLoopLB = advancedMonsterLocomotionSetting.ASWalkLoopLB;
			ASWalkLoopRF = advancedMonsterLocomotionSetting.ASWalkLoopRF;
			ASWalkLoopRB = advancedMonsterLocomotionSetting.ASWalkLoopRB;
			ASWalkSharpturnLeftMin = advancedMonsterLocomotionSetting.ASWalkSharpturnLeftMin;
			ASWalkSharpturnLeftMax = advancedMonsterLocomotionSetting.ASWalkSharpturnLeftMax;
			ASWalkSharpturnRightMin = advancedMonsterLocomotionSetting.ASWalkSharpturnRightMin;
			ASWalkSharpturnRightMax = advancedMonsterLocomotionSetting.ASWalkSharpturnRightMax;
			ASWalkPivotFwd = advancedMonsterLocomotionSetting.ASWalkPivotFwd;
			ASWalkPivotBwd = advancedMonsterLocomotionSetting.ASWalkPivotBwd;
			ASWalkPivotLF = advancedMonsterLocomotionSetting.ASWalkPivotLF;
			ASWalkPivotLB = advancedMonsterLocomotionSetting.ASWalkPivotLB;
			ASWalkPivotRF = advancedMonsterLocomotionSetting.ASWalkPivotRF;
			ASWalkPivotRB = advancedMonsterLocomotionSetting.ASWalkPivotRB;
			ASWalkTransFRToBR = advancedMonsterLocomotionSetting.ASWalkTransFRToBR;
			ASWalkTransBRToFR = advancedMonsterLocomotionSetting.ASWalkTransBRToFR;
			ASWalkTransFLToBL = advancedMonsterLocomotionSetting.ASWalkTransFLToBL;
			ASWalkTransBLToFL = advancedMonsterLocomotionSetting.ASWalkTransBLToFL;
			ASWalkStopFwd = advancedMonsterLocomotionSetting.ASWalkStopFwd;
			ASWalkStopBwd = advancedMonsterLocomotionSetting.ASWalkStopBwd;
			ASWalkStopLF = advancedMonsterLocomotionSetting.ASWalkStopLF;
			ASWalkStopLB = advancedMonsterLocomotionSetting.ASWalkStopLB;
			ASWalkStopRF = advancedMonsterLocomotionSetting.ASWalkStopRF;
			ASWalkStopRB = advancedMonsterLocomotionSetting.ASWalkStopRB;
			ASWalkLoopAddPose = advancedMonsterLocomotionSetting.ASWalkLoopAddPose;
			ASWalkLoopAdditiveList = advancedMonsterLocomotionSetting.ASWalkLoopAdditiveList;
			ASRunStartFwd = advancedMonsterLocomotionSetting.ASRunStartFwd;
			ASRunStartBwd = advancedMonsterLocomotionSetting.ASRunStartBwd;
			ASRunStartLeftMin = advancedMonsterLocomotionSetting.ASRunStartLeftMin;
			ASRunStartLeftMax = advancedMonsterLocomotionSetting.ASRunStartLeftMax;
			ASRunStartRightMin = advancedMonsterLocomotionSetting.ASRunStartRightMin;
			ASRunStartRightMax = advancedMonsterLocomotionSetting.ASRunStartRightMax;
			ASRunStartLF = advancedMonsterLocomotionSetting.ASRunStartLF;
			ASRunStartLB = advancedMonsterLocomotionSetting.ASRunStartLB;
			ASRunStartRF = advancedMonsterLocomotionSetting.ASRunStartRF;
			ASRunStartRB = advancedMonsterLocomotionSetting.ASRunStartRB;
			ASRunLoopFwd = advancedMonsterLocomotionSetting.ASRunLoopFwd;
			ASRunLoopBwd = advancedMonsterLocomotionSetting.ASRunLoopBwd;
			ASRunLoopLF = advancedMonsterLocomotionSetting.ASRunLoopLF;
			ASRunLoopLB = advancedMonsterLocomotionSetting.ASRunLoopLB;
			ASRunLoopRF = advancedMonsterLocomotionSetting.ASRunLoopRF;
			ASRunLoopRB = advancedMonsterLocomotionSetting.ASRunLoopRB;
			ASRunSharpturnLeftMin = advancedMonsterLocomotionSetting.ASRunSharpturnLeftMin;
			ASRunSharpturnLeftMax = advancedMonsterLocomotionSetting.ASRunSharpturnLeftMax;
			ASRunSharpturnRightMin = advancedMonsterLocomotionSetting.ASRunSharpturnRightMin;
			ASRunSharpturnRightMax = advancedMonsterLocomotionSetting.ASRunSharpturnRightMax;
			ASRunPivotFwd = advancedMonsterLocomotionSetting.ASRunPivotFwd;
			ASRunPivotBwd = advancedMonsterLocomotionSetting.ASRunPivotBwd;
			ASRunPivotLF = advancedMonsterLocomotionSetting.ASRunPivotLF;
			ASRunPivotLB = advancedMonsterLocomotionSetting.ASRunPivotLB;
			ASRunPivotRF = advancedMonsterLocomotionSetting.ASRunPivotRF;
			ASRunPivotRB = advancedMonsterLocomotionSetting.ASRunPivotRB;
			ASRunTransFRToBR = advancedMonsterLocomotionSetting.ASRunTransFRToBR;
			ASRunTransBRToFR = advancedMonsterLocomotionSetting.ASRunTransBRToFR;
			ASRunTransFLToBL = advancedMonsterLocomotionSetting.ASRunTransFLToBL;
			ASRunTransBLToFL = advancedMonsterLocomotionSetting.ASRunTransBLToFL;
			ASRunStopFwd = advancedMonsterLocomotionSetting.ASRunStopFwd;
			ASRunStopBwd = advancedMonsterLocomotionSetting.ASRunStopBwd;
			ASRunStopLF = advancedMonsterLocomotionSetting.ASRunStopLF;
			ASRunStopLB = advancedMonsterLocomotionSetting.ASRunStopLB;
			ASRunStopRF = advancedMonsterLocomotionSetting.ASRunStopRF;
			ASRunStopRB = advancedMonsterLocomotionSetting.ASRunStopRB;
			ASRunLoopAddPose = advancedMonsterLocomotionSetting.ASRunLoopAddPose;
			ASRunLoopAdditiveList = advancedMonsterLocomotionSetting.ASRunLoopAdditiveList;
			ASRushStartFwd = advancedMonsterLocomotionSetting.ASRushStartFwd;
			ASRushStartLeftMin = advancedMonsterLocomotionSetting.ASRushStartLeftMin;
			ASRushStartLeftMax = advancedMonsterLocomotionSetting.ASRushStartLeftMax;
			ASRushStartRightMin = advancedMonsterLocomotionSetting.ASRushStartRightMin;
			ASRushStartRightMax = advancedMonsterLocomotionSetting.ASRushStartRightMax;
			ASRushLoopFwd = advancedMonsterLocomotionSetting.ASRushLoopFwd;
			ASRushSharpturnLeftMin = advancedMonsterLocomotionSetting.ASRushSharpturnLeftMin;
			ASRushSharpturnLeftMax = advancedMonsterLocomotionSetting.ASRushSharpturnLeftMax;
			ASRushSharpturnRightMin = advancedMonsterLocomotionSetting.ASRushSharpturnRightMin;
			ASRushSharpturnRightMax = advancedMonsterLocomotionSetting.ASRushSharpturnRightMax;
			ASRushStopFwd = advancedMonsterLocomotionSetting.ASRushStopFwd;
			ASRushLoopAddPose = advancedMonsterLocomotionSetting.ASRushLoopAddPose;
			ASRushLoopAdditiveList = advancedMonsterLocomotionSetting.ASRushLoopAdditiveList;
		}
	}
}
