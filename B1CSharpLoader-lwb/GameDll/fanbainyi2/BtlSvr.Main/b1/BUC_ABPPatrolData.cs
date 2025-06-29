using System.Collections.Generic;
using UnrealEngine.Engine;

namespace b1;

public class BUC_ABPPatrolData : IBUC_ABPPatrolData
{
	public List<UAnimSequence> AnimIdleList { get; set; }

	public UBlendSpace BSWalkFwd { get; set; }

	public UBlendSpace BSWalkBwd { get; set; }

	public UBlendSpace BSWalkLeft { get; set; }

	public UBlendSpace BSWalkRight { get; set; }

	public UBlendSpace BSRunFwd { get; set; }

	public UBlendSpace BSRunBwd { get; set; }

	public UBlendSpace BSRunLeft { get; set; }

	public UBlendSpace BSRunRight { get; set; }

	public UBlendSpace DefaultBSRunFwd { get; set; }

	public UBlendSpace DefaultBSRunBwd { get; set; }

	public UBlendSpace DefaultBSRunLeft { get; set; }

	public UBlendSpace DefaultBSRunRight { get; set; }

	public UBlendSpace DefaultBSWalkFwd { get; set; }

	public UBlendSpace DefaultBSWalkBwd { get; set; }

	public UBlendSpace DefaultBSWalkLeft { get; set; }

	public UBlendSpace DefaultBSWalkRight { get; set; }

	public void Init(BUABPSettingData Setting, IBUC_ABPCommonSettingData CommonData)
	{
		BUABPPatrolSettingData patrolSetting = Setting.PatrolSetting;
		AnimIdleList = new List<UAnimSequence>();
		if (patrolSetting.AnimIdle != null)
		{
			AnimIdleList.Add(patrolSetting.AnimIdle);
		}
		BSRunFwd = patrolSetting.BSRunFwd;
		BSRunBwd = patrolSetting.BSRunBwd;
		BSRunLeft = patrolSetting.BSRunLeft;
		BSRunRight = patrolSetting.BSRunRight;
		BSWalkFwd = patrolSetting.BSWalkFwd;
		BSWalkBwd = patrolSetting.BSWalkBwd;
		BSWalkLeft = patrolSetting.BSWalkLeft;
		BSWalkRight = patrolSetting.BSWalkRight;
		DefaultBSRunFwd = CommonData.BSRunFwd;
		DefaultBSRunBwd = CommonData.BSRunBwd;
		DefaultBSRunLeft = CommonData.BSRunLeft;
		DefaultBSRunRight = CommonData.BSRunRight;
		DefaultBSWalkFwd = CommonData.BSWalkFwd;
		DefaultBSWalkBwd = CommonData.BSWalkBwd;
		DefaultBSWalkLeft = CommonData.BSWalkLeft;
		DefaultBSWalkRight = CommonData.BSWalkRight;
	}
}
