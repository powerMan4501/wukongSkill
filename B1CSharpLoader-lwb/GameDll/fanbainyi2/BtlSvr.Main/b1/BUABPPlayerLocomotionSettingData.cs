using System.Collections.Generic;
using UnrealEngine.Engine;

namespace b1;

public class BUABPPlayerLocomotionSettingData : BUABPSettingDataBase
{
	public List<UAnimSequence> ASIdleList { get; private set; }

	public UAnimSequence ASSequenceTransitionMoveFromWalkLFoot { get; private set; }

	public UAnimSequence ASSequenceTransitionMoveFromWalkRFoot { get; private set; }

	public UAnimSequence ASSequenceTransitionMoveFromRunLFoot { get; private set; }

	public UAnimSequence ASSequenceTransitionMoveFromRunRFoot { get; private set; }

	public UAnimSequence ASSequenceTransitionMoveFromRushLFoot { get; private set; }

	public UAnimSequence ASSequenceTransitionMoveFromRushRFoot { get; private set; }

	public BUABPPlayerLocomotion_FreeSettingData Free { get; private set; }

	public BUABPPlayerLocomotion_LockSettingData Lock { get; private set; }

	public override void InitSettingData(in BGWDataAsset_AbpHumanoidSetting ABPSetting)
	{
		if (!(ABPSetting == null))
		{
			FAnimHumanoidSetting_PlayerLocomotion playerLocomotionSetting = ABPSetting.PlayerLocomotionSetting;
			ASIdleList = playerLocomotionSetting.ASIdleList;
			ASSequenceTransitionMoveFromWalkLFoot = playerLocomotionSetting.ASSequenceTransitionMoveFromWalkLFoot;
			ASSequenceTransitionMoveFromWalkRFoot = playerLocomotionSetting.ASSequenceTransitionMoveFromWalkRFoot;
			ASSequenceTransitionMoveFromRunLFoot = playerLocomotionSetting.ASSequenceTransitionMoveFromRunLFoot;
			ASSequenceTransitionMoveFromRunRFoot = playerLocomotionSetting.ASSequenceTransitionMoveFromRunRFoot;
			ASSequenceTransitionMoveFromRushLFoot = playerLocomotionSetting.ASSequenceTransitionMoveFromRushLFoot;
			ASSequenceTransitionMoveFromRushRFoot = playerLocomotionSetting.ASSequenceTransitionMoveFromRushRFoot;
			Free = new BUABPPlayerLocomotion_FreeSettingData(in playerLocomotionSetting.Free);
			Lock = new BUABPPlayerLocomotion_LockSettingData(in playerLocomotionSetting.Lock);
		}
	}
}
