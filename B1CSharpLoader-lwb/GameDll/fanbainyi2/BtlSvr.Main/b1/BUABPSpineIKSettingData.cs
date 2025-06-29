using System.Collections.Generic;

namespace b1;

public class BUABPSpineIKSettingData : BUABPSettingDataBase
{
	public bool bEnableSpineIK { get; private set; }

	public bool bEnableSpineIKDebug { get; private set; }

	public float SpineIKTraceUpDistance { get; private set; }

	public float SpineIKTraceDownDistance { get; private set; }

	public float OffsetPitch { get; private set; }

	public float OffsetRoll { get; private set; }

	public float LerpSpeed { get; private set; }

	public bool DisableLimbIKAlpha { get; private set; }

	public float IgnoreDistance { get; private set; }

	public List<LimbIKData> LimbIKDataList { get; private set; }

	public override void InitSettingData(in BGWDataAsset_AbpHumanoidSetting ABPSetting)
	{
		if (!(ABPSetting == null))
		{
			FAnimHumanoidSetting_SpineIK spineIKSetting = ABPSetting.SpineIKSetting;
			bEnableSpineIK = spineIKSetting.bEnableSpineIK;
			bEnableSpineIKDebug = spineIKSetting.bEnableSpineIKDebug;
			SpineIKTraceUpDistance = spineIKSetting.SpineIKTraceUpDistance;
			SpineIKTraceDownDistance = spineIKSetting.SpineIKTraceDownDistance;
			OffsetPitch = spineIKSetting.OffsetPitch;
			OffsetRoll = spineIKSetting.OffsetRoll;
			LerpSpeed = spineIKSetting.LerpSpeed;
			DisableLimbIKAlpha = spineIKSetting.DisableLimbIKAlpha;
			IgnoreDistance = spineIKSetting.IgnoreDistance;
			LimbIKDataList = spineIKSetting.LimbIKDataList;
		}
	}
}
