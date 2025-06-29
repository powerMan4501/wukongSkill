using System.Collections.Generic;
using b1.BGU.BUAnim;
using b1.Plugins.GSEngineExtent;
using b1.Plugins.MM;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.IKRig;

namespace b1;

public class BUABPMotionMatchingSettingData : BUABPSettingDataBase
{
	public UAnimationAnalyzer Walk2RunAA { get; private set; }

	public bool bMMLockUseFreeMode { get; private set; }

	public UBlendSpace RotateAdditiveBS { get; private set; }

	public float MMUpBodyStateAlpha { get; private set; }

	public EState_MM DefaultMMState { get; private set; }

	public EABPMoveMode SpareMoveMode { get; private set; }

	public Dictionary<EState_MM, UAnimationAnalyzer> MMState2AA { get; private set; }

	public Dictionary<EState_MM, BUAnimationAnalyzer> MMState2AACS { get; private set; }

	public float AnimationAnalyzerBlendTime { get; private set; }

	public float MotionBlendTime { get; private set; }

	public UIKRetargeter Retargeter { get; private set; }

	public float PelvisOffsetZ { get; private set; }

	public float FootOffsetScale { get; private set; }

	public float ForceSetRotAnimSpeed { get; private set; }

	public float DisableRotVerifyAnimSpeed { get; private set; }

	public float ToIdleAnimSpeed { get; private set; }

	public bool bNeedFixMM { get; private set; }

	public UAnimSequence MMAdditivePose { get; private set; }

	public float MMAdditiveWeight { get; private set; }

	public bool bFixMMWeapon_MeshSpaceRotation { get; private set; }

	public bool bFixMMAdditive_MeshSpaceRotation { get; private set; }

	public List<FGSInputBlendPose> MMAdditiveLayerSetup { get; private set; }

	public override void InitSettingData(in BGWDataAsset_AbpHumanoidSetting ABPSetting)
	{
		if (!(ABPSetting == null))
		{
			FAnimHumanoidSetting_MotionMatching motionMatchingSetting = ABPSetting.MotionMatchingSetting;
			Walk2RunAA = motionMatchingSetting.Walk2RunAA;
			bMMLockUseFreeMode = motionMatchingSetting.bMMLockUseFreeMode;
			RotateAdditiveBS = motionMatchingSetting.RotateAdditiveBS;
			MMUpBodyStateAlpha = motionMatchingSetting.MMUpBodyStateAlpha;
			DefaultMMState = motionMatchingSetting.DefaultMMState;
			SpareMoveMode = motionMatchingSetting.SpareMoveMode;
			MMState2AA = motionMatchingSetting.MMState2AA;
			MMState2AACS = motionMatchingSetting.MMState2AACS;
			AnimationAnalyzerBlendTime = motionMatchingSetting.AnimationAnalyzerBlendTime;
			MotionBlendTime = motionMatchingSetting.MotionBlendTime;
			Retargeter = motionMatchingSetting.Retargeter;
			PelvisOffsetZ = motionMatchingSetting.PelvisOffsetZ;
			FootOffsetScale = motionMatchingSetting.FootOffsetScale;
			ForceSetRotAnimSpeed = motionMatchingSetting.ForceSetRotAnimSpeed;
			DisableRotVerifyAnimSpeed = motionMatchingSetting.DisableRotVerifyAnimSpeed;
			ToIdleAnimSpeed = motionMatchingSetting.ToIdleAnimSpeed;
			bNeedFixMM = motionMatchingSetting.bNeedFixMM;
			MMAdditivePose = motionMatchingSetting.MMAdditivePose;
			MMAdditiveWeight = motionMatchingSetting.MMAdditiveWeight;
			bFixMMWeapon_MeshSpaceRotation = motionMatchingSetting.bFixMMWeapon_MeshSpaceRotation;
			bFixMMAdditive_MeshSpaceRotation = motionMatchingSetting.bFixMMAdditive_MeshSpaceRotation;
			MMAdditiveLayerSetup = motionMatchingSetting.MMAdditiveLayerSetup;
		}
	}
}
