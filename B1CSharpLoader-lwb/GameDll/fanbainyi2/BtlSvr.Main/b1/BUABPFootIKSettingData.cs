namespace b1;

public class BUABPFootIKSettingData : BUABPSettingDataBase
{
	public bool bEnableIK { get; private set; }

	public bool bEnableForefootIK { get; private set; }

	public bool bEnableQuadrupedIK { get; private set; }

	public bool bFootUseFBIK { get; private set; }

	public override void InitSettingData(in BGWDataAsset_AbpHumanoidSetting ABPSetting)
	{
		if (!(ABPSetting == null))
		{
			FAnimHumanoidSetting_FootIK footIKSetting = ABPSetting.FootIKSetting;
			bEnableIK = footIKSetting.bEnableIK;
			bEnableForefootIK = footIKSetting.bEnableForefootIK;
			bEnableQuadrupedIK = footIKSetting.bEnableQuadrupedIK;
			bFootUseFBIK = footIKSetting.bFootUseFBIK;
		}
	}
}
