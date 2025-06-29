using System.Collections.Generic;
using UnrealEngine.Engine;

namespace b1;

public class BUABPCloudLocomotionSettingData : BUABPSettingDataBase
{
	public UCurveFloat RotationSpeedCurve { get; private set; }

	public List<UAnimSequence> AnimIdleList { get; private set; }

	public UAnimSequence LeanPitchAdditvie_Up { get; private set; }

	public UAnimSequence LeanPitchAdditvie_Down { get; private set; }

	public UAnimSequence StartFwd { get; private set; }

	public UAnimSequence StartFwdL { get; private set; }

	public UAnimSequence StartFwdR { get; private set; }

	public UAnimSequence StartBwdL { get; private set; }

	public UAnimSequence StartBwdR { get; private set; }

	public UAnimSequence RunLoop { get; private set; }

	public UAnimSequence RushLoop { get; private set; }

	public UAnimSequence RunLoopAdditvie_Left { get; private set; }

	public UAnimSequence RunLoopAdditvie_Right { get; private set; }

	public UAnimSequence RushLoopAdditvie_Left { get; private set; }

	public UAnimSequence RushLoopAdditvie_Right { get; private set; }

	public UAnimSequence RunStop { get; private set; }

	public UAnimSequence RushStop { get; private set; }

	public UAnimSequence CloudFallLoop { get; private set; }

	public BUABPJump_LandSettingData CloudLand_High { get; private set; }

	public BUABPJump_LandSettingData CloudLand_Low { get; private set; }

	public Dictionary<int, FCloudBreakAnimSetting> CloudBreakAnimSettings { get; private set; }

	public override void InitSettingData(in BGWDataAsset_AbpHumanoidSetting ABPSetting)
	{
		if (!(ABPSetting == null))
		{
			FAnimHumanoidSetting_CloudLocomotion cloudLocomotionSetting = ABPSetting.CloudLocomotionSetting;
			RotationSpeedCurve = cloudLocomotionSetting.RotationSpeedCurve;
			AnimIdleList = cloudLocomotionSetting.AnimIdleList;
			LeanPitchAdditvie_Up = cloudLocomotionSetting.LeanPitchAdditvie_Up;
			LeanPitchAdditvie_Down = cloudLocomotionSetting.LeanPitchAdditvie_Down;
			StartFwd = cloudLocomotionSetting.StartFwd;
			StartFwdL = cloudLocomotionSetting.StartFwdL;
			StartFwdR = cloudLocomotionSetting.StartFwdR;
			StartBwdL = cloudLocomotionSetting.StartBwdL;
			StartBwdR = cloudLocomotionSetting.StartBwdR;
			RunLoop = cloudLocomotionSetting.RunLoop;
			RushLoop = cloudLocomotionSetting.RushLoop;
			RunLoopAdditvie_Left = cloudLocomotionSetting.RunLoopAdditvie_Left;
			RunLoopAdditvie_Right = cloudLocomotionSetting.RunLoopAdditvie_Right;
			RushLoopAdditvie_Left = cloudLocomotionSetting.RushLoopAdditvie_Left;
			RushLoopAdditvie_Right = cloudLocomotionSetting.RushLoopAdditvie_Right;
			RunStop = cloudLocomotionSetting.RunStop;
			RushStop = cloudLocomotionSetting.RushStop;
			CloudFallLoop = cloudLocomotionSetting.CloudFallLoop;
			CloudLand_High = new BUABPJump_LandSettingData(in cloudLocomotionSetting.CloudLand_High);
			CloudLand_Low = new BUABPJump_LandSettingData(in cloudLocomotionSetting.CloudLand_Low);
			CloudBreakAnimSettings = cloudLocomotionSetting.CloudBreakAnimSettings;
		}
	}
}
