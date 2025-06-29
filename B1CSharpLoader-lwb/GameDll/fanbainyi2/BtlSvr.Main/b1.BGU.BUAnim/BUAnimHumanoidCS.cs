using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.BGU.BUAnim;

[UClass]
[Blueprintable]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS")]
public class BUAnimHumanoidCS : BUAnimInstanceBase
{
	private IBUC_ABPBasicData BasicData;

	private IBUC_ABPCharacterData ChrData;

	private IBUC_ABPBGUCharacterData BGUChrData;

	private IBUC_ABPFootIKData FootIKData;

	private IBUC_ABPSpineIKData SpineIKData;

	private IBUC_ABPHeadAimingData HeadAimingData;

	private IBUC_ABPUpperBodyAimingData UpperBodyAimingData;

	private IBUC_ABPMMFixedData MMFixedData;

	private IBUC_ABPBodyBlendData BodyBlendData;

	private IBUC_ABPAimOffsetData AimOffsetData;

	private IBUC_ABPWeaponAimData WeaponAimData;

	private b1.IBUC_PhysicBlendData PhysicBlendData;

	private IBUC_ABPAMMatryoshkaData AMMatryoshkaData;

	private IBUC_ABPPoseSnapshotData PoseSnapshotData;

	private IBUC_ABPAttackIKData AttackIKData;

	private IBUC_ABPSlopeAdditiveData SlopeAdditiveData;

	private IBUC_ABPCommonSettingData CommonData;

	private IBUC_ABPHelperData AnimHumanoidHelperData;

	private IBUC_ActorBasicData ActorBasicData;

	private AActor Owner;

	private static bool HandIKAlpha_IsValid;

	private static int HandIKAlpha_Offset;

	private static bool DefaultAOAlpha_IsValid;

	private static int DefaultAOAlpha_Offset;

	private static bool AttackAOAlpha_IsValid;

	private static int AttackAOAlpha_Offset;

	private static bool BSSlotAlpha_IsValid;

	private static int BSSlotAlpha_Offset;

	private static bool MMKeepAlpha_IsValid;

	private static int MMKeepAlpha_Offset;

	private static bool bEnableAnyCurveBodyBlend_IsValid;

	private static int bEnableAnyCurveBodyBlend_Offset;

	private static FFieldAddress bEnableAnyCurveBodyBlend_PropertyAddress;

	private static bool bHasUpperBodySlotMontage_IsValid;

	private static int bHasUpperBodySlotMontage_Offset;

	private static FFieldAddress bHasUpperBodySlotMontage_PropertyAddress;

	private static bool bHasLeftArmSlotMontage_IsValid;

	private static int bHasLeftArmSlotMontage_Offset;

	private static FFieldAddress bHasLeftArmSlotMontage_PropertyAddress;

	private static bool bHasRightArmSlotMontage_IsValid;

	private static int bHasRightArmSlotMontage_Offset;

	private static FFieldAddress bHasRightArmSlotMontage_PropertyAddress;

	private static bool bUsePoseOverride_IsValid;

	private static int bUsePoseOverride_Offset;

	private static FFieldAddress bUsePoseOverride_PropertyAddress;

	private static bool PoseSnapshot_IsValid;

	private static int PoseSnapshot_Offset;

	private static bool EnableSnapshotBlendTime_IsValid;

	private static int EnableSnapshotBlendTime_Offset;

	private static bool DisableSnapshotBlendTime_IsValid;

	private static int DisableSnapshotBlendTime_Offset;

	private static bool bEnableAnimCurveBodySeparation_IsValid;

	private static int bEnableAnimCurveBodySeparation_Offset;

	private static FFieldAddress bEnableAnimCurveBodySeparation_PropertyAddress;

	private static bool AMMatryoshkaAlpha_IsValid;

	private static int AMMatryoshkaAlpha_Offset;

	private static bool AttackIKAlpha_IsValid;

	private static int AttackIKAlpha_Offset;

	private static bool bDisableABPMove_IsValid;

	private static int bDisableABPMove_Offset;

	private static FFieldAddress bDisableABPMove_PropertyAddress;

	private static bool bHasMoveInput_IsValid;

	private static int bHasMoveInput_Offset;

	private static FFieldAddress bHasMoveInput_PropertyAddress;

	private static bool bHasPlayerInput_IsValid;

	private static int bHasPlayerInput_Offset;

	private static FFieldAddress bHasPlayerInput_PropertyAddress;

	private static bool MappedSpeed_IsValid;

	private static int MappedSpeed_Offset;

	private static bool HeadAimYaw_IsValid;

	private static int HeadAimYaw_Offset;

	private static bool HeadAimPitch_IsValid;

	private static int HeadAimPitch_Offset;

	private static bool HeadAimAlpha_IsValid;

	private static int HeadAimAlpha_Offset;

	private static bool FootIKAlpha_IsValid;

	private static int FootIKAlpha_Offset;

	private static bool IKPelivisAlpha_IsValid;

	private static int IKPelivisAlpha_Offset;

	private static bool IKSpinePitch_IsValid;

	private static int IKSpinePitch_Offset;

	private static bool IKSpineRoll_IsValid;

	private static int IKSpineRoll_Offset;

	private static bool IKInterpSpeed_IsValid;

	private static int IKInterpSpeed_Offset;

	private static bool bEnableIK_IsValid;

	private static int bEnableIK_Offset;

	private static FFieldAddress bEnableIK_PropertyAddress;

	private static bool AnimIdle_IsValid;

	private static int AnimIdle_Offset;

	private static bool DefaultAimOffset_IsValid;

	private static int DefaultAimOffset_Offset;

	private static bool AttackAimOffset_IsValid;

	private static int AttackAimOffset_Offset;

	private static bool bIsAttackAimOffsetEnable_IsValid;

	private static int bIsAttackAimOffsetEnable_Offset;

	private static FFieldAddress bIsAttackAimOffsetEnable_PropertyAddress;

	private static bool AttackAimOffsetEnableX_IsValid;

	private static int AttackAimOffsetEnableX_Offset;

	private static bool AttackAimOffsetEnableY_IsValid;

	private static int AttackAimOffsetEnableY_Offset;

	private static bool EnableAimOffset_IsValid;

	private static int EnableAimOffset_Offset;

	private static FFieldAddress EnableAimOffset_PropertyAddress;

	private static bool IsFarButInSight_IsValid;

	private static int IsFarButInSight_Offset;

	private static FFieldAddress IsFarButInSight_PropertyAddress;

	private static bool bIsPlayer_IsValid;

	private static int bIsPlayer_Offset;

	private static FFieldAddress bIsPlayer_PropertyAddress;

	private static bool AnimDingShenStart_IsValid;

	private static int AnimDingShenStart_Offset;

	private static bool AnimDingShenHold_IsValid;

	private static int AnimDingShenHold_Offset;

	private static bool BSSlot_IsValid;

	private static int BSSlot_Offset;

	private static bool BSSlotY_IsValid;

	private static int BSSlotY_Offset;

	private static bool BSSlotX_IsValid;

	private static int BSSlotX_Offset;

	private static bool IsBSSlot_IsValid;

	private static int IsBSSlot_Offset;

	private static FFieldAddress IsBSSlot_PropertyAddress;

	private static bool WeaponAimAlpha_IsValid;

	private static int WeaponAimAlpha_Offset;

	private static bool PhysicBlendAlpha_IsValid;

	private static int PhysicBlendAlpha_Offset;

	private static bool SlopeAlpha_IsValid;

	private static int SlopeAlpha_Offset;

	private static bool ASSlopeAdditiveLocalSpace_IsValid;

	private static int ASSlopeAdditiveLocalSpace_Offset;

	private static bool ASSlopeAdditiveMeshSpace_IsValid;

	private static int ASSlopeAdditiveMeshSpace_Offset;

	private static bool BSMoveSpeedAdditive_IsValid;

	private static int BSMoveSpeedAdditive_Offset;

	private static bool BlueprintThreadSafeUpdateAnimation_IsValid;

	private static IntPtr BlueprintThreadSafeUpdateAnimation_FunctionAddress;

	private static int BlueprintThreadSafeUpdateAnimation_ParamsSize;

	private static bool BlueprintThreadSafeUpdateAnimation_DeltaTimeX_IsValid;

	private static int BlueprintThreadSafeUpdateAnimation_DeltaTimeX_Offset;

	[BlueprintVisible(ReadOnly = true)]
	[UProperty]
	[Category("MovementAlpha")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS:HandIKAlpha")]
	public float HandIKAlpha
	{
		get
		{
			CheckDestroyed();
			if (!HandIKAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:HandIKAlpha");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, HandIKAlpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HandIKAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:HandIKAlpha");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, HandIKAlpha_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintVisible(ReadOnly = true)]
	[Category("MovementAlpha")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS:DefaultAOAlpha")]
	public float DefaultAOAlpha
	{
		get
		{
			CheckDestroyed();
			if (!DefaultAOAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:DefaultAOAlpha");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DefaultAOAlpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultAOAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:DefaultAOAlpha");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DefaultAOAlpha_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintVisible(ReadOnly = true)]
	[Category("MovementAlpha")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS:AttackAOAlpha")]
	public float AttackAOAlpha
	{
		get
		{
			CheckDestroyed();
			if (!AttackAOAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:AttackAOAlpha");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AttackAOAlpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AttackAOAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:AttackAOAlpha");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AttackAOAlpha_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("MovementAlpha")]
	[BlueprintVisible(ReadOnly = true)]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS:BSSlotAlpha")]
	public float BSSlotAlpha
	{
		get
		{
			CheckDestroyed();
			if (!BSSlotAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:BSSlotAlpha");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BSSlotAlpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSSlotAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:BSSlotAlpha");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BSSlotAlpha_Offset), value);
			}
		}
	}

	[Category("MMFixed")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS:MMKeepAlpha")]
	public float MMKeepAlpha
	{
		get
		{
			CheckDestroyed();
			if (!MMKeepAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:MMKeepAlpha");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MMKeepAlpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MMKeepAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:MMKeepAlpha");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MMKeepAlpha_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("DynamicBodyBlend")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS:bEnableAnyCurveBodyBlend")]
	public bool bEnableAnyCurveBodyBlend
	{
		get
		{
			CheckDestroyed();
			if (!bEnableAnyCurveBodyBlend_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:bEnableAnyCurveBodyBlend");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bEnableAnyCurveBodyBlend_Offset), 0, bEnableAnyCurveBodyBlend_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bEnableAnyCurveBodyBlend_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:bEnableAnyCurveBodyBlend");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bEnableAnyCurveBodyBlend_Offset), 0, bEnableAnyCurveBodyBlend_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("DynamicBodyBlend")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS:bHasUpperBodySlotMontage")]
	public bool bHasUpperBodySlotMontage
	{
		get
		{
			CheckDestroyed();
			if (!bHasUpperBodySlotMontage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:bHasUpperBodySlotMontage");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bHasUpperBodySlotMontage_Offset), 0, bHasUpperBodySlotMontage_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bHasUpperBodySlotMontage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:bHasUpperBodySlotMontage");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bHasUpperBodySlotMontage_Offset), 0, bHasUpperBodySlotMontage_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("DynamicBodyBlend")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS:bHasLeftArmSlotMontage")]
	public bool bHasLeftArmSlotMontage
	{
		get
		{
			CheckDestroyed();
			if (!bHasLeftArmSlotMontage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:bHasLeftArmSlotMontage");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bHasLeftArmSlotMontage_Offset), 0, bHasLeftArmSlotMontage_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bHasLeftArmSlotMontage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:bHasLeftArmSlotMontage");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bHasLeftArmSlotMontage_Offset), 0, bHasLeftArmSlotMontage_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("DynamicBodyBlend")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS:bHasRightArmSlotMontage")]
	public bool bHasRightArmSlotMontage
	{
		get
		{
			CheckDestroyed();
			if (!bHasRightArmSlotMontage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:bHasRightArmSlotMontage");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bHasRightArmSlotMontage_Offset), 0, bHasRightArmSlotMontage_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bHasRightArmSlotMontage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:bHasRightArmSlotMontage");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bHasRightArmSlotMontage_Offset), 0, bHasRightArmSlotMontage_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("PoseSnapshot")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS:bUsePoseOverride")]
	public bool bUsePoseOverride
	{
		get
		{
			CheckDestroyed();
			if (!bUsePoseOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:bUsePoseOverride");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bUsePoseOverride_Offset), 0, bUsePoseOverride_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bUsePoseOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:bUsePoseOverride");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bUsePoseOverride_Offset), 0, bUsePoseOverride_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[Category("PoseSnapshot")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS:PoseSnapshot")]
	public FPoseSnapshot PoseSnapshot
	{
		get
		{
			CheckDestroyed();
			if (!PoseSnapshot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:PoseSnapshot");
				return default(FPoseSnapshot);
			}
			return FPoseSnapshot.FromNative(IntPtr.Add(base.Address, PoseSnapshot_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PoseSnapshot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:PoseSnapshot");
			}
			else
			{
				FPoseSnapshot.ToNative(IntPtr.Add(base.Address, PoseSnapshot_Offset), value);
			}
		}
	}

	[Category("PoseSnapshot")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS:EnableSnapshotBlendTime")]
	public float EnableSnapshotBlendTime
	{
		get
		{
			CheckDestroyed();
			if (!EnableSnapshotBlendTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:EnableSnapshotBlendTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, EnableSnapshotBlendTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EnableSnapshotBlendTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:EnableSnapshotBlendTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, EnableSnapshotBlendTime_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("PoseSnapshot")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS:DisableSnapshotBlendTime")]
	public float DisableSnapshotBlendTime
	{
		get
		{
			CheckDestroyed();
			if (!DisableSnapshotBlendTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:DisableSnapshotBlendTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DisableSnapshotBlendTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DisableSnapshotBlendTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:DisableSnapshotBlendTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DisableSnapshotBlendTime_Offset), value);
			}
		}
	}

	[Category("AnimCurveBodySeparation")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS:bEnableAnimCurveBodySeparation")]
	public bool bEnableAnimCurveBodySeparation
	{
		get
		{
			CheckDestroyed();
			if (!bEnableAnimCurveBodySeparation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:bEnableAnimCurveBodySeparation");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bEnableAnimCurveBodySeparation_Offset), 0, bEnableAnimCurveBodySeparation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bEnableAnimCurveBodySeparation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:bEnableAnimCurveBodySeparation");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bEnableAnimCurveBodySeparation_Offset), 0, bEnableAnimCurveBodySeparation_PropertyAddress.Address, value);
			}
		}
	}

	[Category("AMMatryoshka")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS:AMMatryoshkaAlpha")]
	public float AMMatryoshkaAlpha
	{
		get
		{
			CheckDestroyed();
			if (!AMMatryoshkaAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:AMMatryoshkaAlpha");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AMMatryoshkaAlpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AMMatryoshkaAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:AMMatryoshkaAlpha");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AMMatryoshkaAlpha_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[Category("AttackIK")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS:AttackIKAlpha")]
	public float AttackIKAlpha
	{
		get
		{
			CheckDestroyed();
			if (!AttackIKAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:AttackIKAlpha");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AttackIKAlpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AttackIKAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:AttackIKAlpha");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AttackIKAlpha_Offset), value);
			}
		}
	}

	[Category("Movement")]
	[BlueprintVisible(ReadOnly = true)]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS:bDisableABPMove")]
	public bool bDisableABPMove
	{
		get
		{
			CheckDestroyed();
			if (!bDisableABPMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:bDisableABPMove");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bDisableABPMove_Offset), 0, bDisableABPMove_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bDisableABPMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:bDisableABPMove");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bDisableABPMove_Offset), 0, bDisableABPMove_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintVisible(ReadOnly = true)]
	[Category("Movement")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS:bHasMoveInput")]
	public bool bHasMoveInput
	{
		get
		{
			CheckDestroyed();
			if (!bHasMoveInput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:bHasMoveInput");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bHasMoveInput_Offset), 0, bHasMoveInput_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bHasMoveInput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:bHasMoveInput");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bHasMoveInput_Offset), 0, bHasMoveInput_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[Category("Movement")]
	[BlueprintVisible(ReadOnly = true)]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS:bHasPlayerInput")]
	public bool bHasPlayerInput
	{
		get
		{
			CheckDestroyed();
			if (!bHasPlayerInput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:bHasPlayerInput");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bHasPlayerInput_Offset), 0, bHasPlayerInput_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bHasPlayerInput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:bHasPlayerInput");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bHasPlayerInput_Offset), 0, bHasPlayerInput_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintVisible(ReadOnly = true)]
	[UProperty]
	[Category("Movement")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS:MappedSpeed")]
	public float MappedSpeed
	{
		get
		{
			CheckDestroyed();
			if (!MappedSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:MappedSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MappedSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MappedSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:MappedSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MappedSpeed_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintVisible(ReadOnly = true)]
	[Category("Head Aim")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS:HeadAimYaw")]
	public float HeadAimYaw
	{
		get
		{
			CheckDestroyed();
			if (!HeadAimYaw_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:HeadAimYaw");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, HeadAimYaw_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HeadAimYaw_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:HeadAimYaw");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, HeadAimYaw_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintVisible(ReadOnly = true)]
	[Category("Head Aim")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS:HeadAimPitch")]
	public float HeadAimPitch
	{
		get
		{
			CheckDestroyed();
			if (!HeadAimPitch_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:HeadAimPitch");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, HeadAimPitch_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HeadAimPitch_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:HeadAimPitch");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, HeadAimPitch_Offset), value);
			}
		}
	}

	[Category("Head Aim")]
	[UProperty]
	[BlueprintVisible(ReadOnly = true)]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS:HeadAimAlpha")]
	public float HeadAimAlpha
	{
		get
		{
			CheckDestroyed();
			if (!HeadAimAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:HeadAimAlpha");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, HeadAimAlpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HeadAimAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:HeadAimAlpha");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, HeadAimAlpha_Offset), value);
			}
		}
	}

	[Category("IKFoot")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS:FootIKAlpha")]
	public float FootIKAlpha
	{
		get
		{
			CheckDestroyed();
			if (!FootIKAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:FootIKAlpha");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FootIKAlpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FootIKAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:FootIKAlpha");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FootIKAlpha_Offset), value);
			}
		}
	}

	[Category("QuadrupedIK")]
	[BlueprintVisible(ReadOnly = true)]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS:IKPelivisAlpha")]
	public float IKPelivisAlpha
	{
		get
		{
			CheckDestroyed();
			if (!IKPelivisAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:IKPelivisAlpha");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, IKPelivisAlpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IKPelivisAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:IKPelivisAlpha");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, IKPelivisAlpha_Offset), value);
			}
		}
	}

	[Category("QuadrupedIK")]
	[BlueprintVisible(ReadOnly = true)]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS:IKSpinePitch")]
	public float IKSpinePitch
	{
		get
		{
			CheckDestroyed();
			if (!IKSpinePitch_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:IKSpinePitch");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, IKSpinePitch_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IKSpinePitch_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:IKSpinePitch");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, IKSpinePitch_Offset), value);
			}
		}
	}

	[Category("QuadrupedIK")]
	[BlueprintVisible(ReadOnly = true)]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS:IKSpineRoll")]
	public float IKSpineRoll
	{
		get
		{
			CheckDestroyed();
			if (!IKSpineRoll_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:IKSpineRoll");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, IKSpineRoll_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IKSpineRoll_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:IKSpineRoll");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, IKSpineRoll_Offset), value);
			}
		}
	}

	[Category("IKFoot")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS:IKInterpSpeed")]
	public float IKInterpSpeed
	{
		get
		{
			CheckDestroyed();
			if (!IKInterpSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:IKInterpSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, IKInterpSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IKInterpSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:IKInterpSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, IKInterpSpeed_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("IKFoot")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS:bEnableIK")]
	public bool bEnableIK
	{
		get
		{
			CheckDestroyed();
			if (!bEnableIK_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:bEnableIK");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bEnableIK_Offset), 0, bEnableIK_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bEnableIK_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:bEnableIK");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bEnableIK_Offset), 0, bEnableIK_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Anims")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS:AnimIdle")]
	public UAnimSequence AnimIdle
	{
		get
		{
			CheckDestroyed();
			if (!AnimIdle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:AnimIdle");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, AnimIdle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimIdle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:AnimIdle");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, AnimIdle_Offset), value);
			}
		}
	}

	[Category("Anims")]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS:DefaultAimOffset")]
	public UAimOffsetBlendSpace DefaultAimOffset
	{
		get
		{
			CheckDestroyed();
			if (!DefaultAimOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:DefaultAimOffset");
				return null;
			}
			return UObjectMarshaler<UAimOffsetBlendSpace>.FromNative(IntPtr.Add(base.Address, DefaultAimOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultAimOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:DefaultAimOffset");
			}
			else
			{
				UObjectMarshaler<UAimOffsetBlendSpace>.ToNative(IntPtr.Add(base.Address, DefaultAimOffset_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[Category("Anims")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS:AttackAimOffset")]
	public UAimOffsetBlendSpace AttackAimOffset
	{
		get
		{
			CheckDestroyed();
			if (!AttackAimOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:AttackAimOffset");
				return null;
			}
			return UObjectMarshaler<UAimOffsetBlendSpace>.FromNative(IntPtr.Add(base.Address, AttackAimOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AttackAimOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:AttackAimOffset");
			}
			else
			{
				UObjectMarshaler<UAimOffsetBlendSpace>.ToNative(IntPtr.Add(base.Address, AttackAimOffset_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[Category("Anims")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS:bIsAttackAimOffsetEnable")]
	public bool bIsAttackAimOffsetEnable
	{
		get
		{
			CheckDestroyed();
			if (!bIsAttackAimOffsetEnable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:bIsAttackAimOffsetEnable");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bIsAttackAimOffsetEnable_Offset), 0, bIsAttackAimOffsetEnable_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bIsAttackAimOffsetEnable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:bIsAttackAimOffsetEnable");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bIsAttackAimOffsetEnable_Offset), 0, bIsAttackAimOffsetEnable_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[Category("Anims")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS:AttackAimOffsetEnableX")]
	public float AttackAimOffsetEnableX
	{
		get
		{
			CheckDestroyed();
			if (!AttackAimOffsetEnableX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:AttackAimOffsetEnableX");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AttackAimOffsetEnableX_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AttackAimOffsetEnableX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:AttackAimOffsetEnableX");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AttackAimOffsetEnableX_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[Category("Anims")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS:AttackAimOffsetEnableY")]
	public float AttackAimOffsetEnableY
	{
		get
		{
			CheckDestroyed();
			if (!AttackAimOffsetEnableY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:AttackAimOffsetEnableY");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AttackAimOffsetEnableY_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AttackAimOffsetEnableY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:AttackAimOffsetEnableY");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AttackAimOffsetEnableY_Offset), value);
			}
		}
	}

	[Category("Settings")]
	[UProperty]
	[BlueprintVisible(ReadOnly = true)]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS:EnableAimOffset")]
	public bool EnableAimOffset
	{
		get
		{
			CheckDestroyed();
			if (!EnableAimOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:EnableAimOffset");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableAimOffset_Offset), 0, EnableAimOffset_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableAimOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:EnableAimOffset");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableAimOffset_Offset), 0, EnableAimOffset_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS:IsFarButInSight")]
	public bool IsFarButInSight
	{
		get
		{
			CheckDestroyed();
			if (!IsFarButInSight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:IsFarButInSight");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsFarButInSight_Offset), 0, IsFarButInSight_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsFarButInSight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:IsFarButInSight");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsFarButInSight_Offset), 0, IsFarButInSight_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS:bIsPlayer")]
	public bool bIsPlayer
	{
		get
		{
			CheckDestroyed();
			if (!bIsPlayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:bIsPlayer");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bIsPlayer_Offset), 0, bIsPlayer_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bIsPlayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:bIsPlayer");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bIsPlayer_Offset), 0, bIsPlayer_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[Category("DingShen")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS:AnimDingShenStart")]
	public UAnimSequence AnimDingShenStart
	{
		get
		{
			CheckDestroyed();
			if (!AnimDingShenStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:AnimDingShenStart");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, AnimDingShenStart_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimDingShenStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:AnimDingShenStart");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, AnimDingShenStart_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[Category("DingShen")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS:AnimDingShenHold")]
	public UAnimSequence AnimDingShenHold
	{
		get
		{
			CheckDestroyed();
			if (!AnimDingShenHold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:AnimDingShenHold");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, AnimDingShenHold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimDingShenHold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:AnimDingShenHold");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, AnimDingShenHold_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("BS Slot")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS:BSSlot")]
	public UBlendSpace BSSlot
	{
		get
		{
			CheckDestroyed();
			if (!BSSlot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:BSSlot");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSSlot_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSSlot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:BSSlot");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSSlot_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("BS Slot")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS:BSSlotY")]
	public float BSSlotY
	{
		get
		{
			CheckDestroyed();
			if (!BSSlotY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:BSSlotY");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BSSlotY_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSSlotY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:BSSlotY");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BSSlotY_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[Category("BS Slot")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS:BSSlotX")]
	public float BSSlotX
	{
		get
		{
			CheckDestroyed();
			if (!BSSlotX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:BSSlotX");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BSSlotX_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSSlotX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:BSSlotX");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BSSlotX_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[Category("BS Slot")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS:IsBSSlot")]
	public bool IsBSSlot
	{
		get
		{
			CheckDestroyed();
			if (!IsBSSlot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:IsBSSlot");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsBSSlot_Offset), 0, IsBSSlot_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsBSSlot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:IsBSSlot");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsBSSlot_Offset), 0, IsBSSlot_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[Category("Weapon Aim")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS:WeaponAimAlpha")]
	public float WeaponAimAlpha
	{
		get
		{
			CheckDestroyed();
			if (!WeaponAimAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:WeaponAimAlpha");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, WeaponAimAlpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WeaponAimAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:WeaponAimAlpha");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, WeaponAimAlpha_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[Category("PhysicBlend")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS:PhysicBlendAlpha")]
	public float PhysicBlendAlpha
	{
		get
		{
			CheckDestroyed();
			if (!PhysicBlendAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:PhysicBlendAlpha");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PhysicBlendAlpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PhysicBlendAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:PhysicBlendAlpha");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PhysicBlendAlpha_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("SlopeAdditive")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS:SlopeAlpha")]
	public float SlopeAlpha
	{
		get
		{
			CheckDestroyed();
			if (!SlopeAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:SlopeAlpha");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SlopeAlpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SlopeAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:SlopeAlpha");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SlopeAlpha_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("SlopeAdditive")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS:ASSlopeAdditiveLocalSpace")]
	public UAnimSequence ASSlopeAdditiveLocalSpace
	{
		get
		{
			CheckDestroyed();
			if (!ASSlopeAdditiveLocalSpace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:ASSlopeAdditiveLocalSpace");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASSlopeAdditiveLocalSpace_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASSlopeAdditiveLocalSpace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:ASSlopeAdditiveLocalSpace");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASSlopeAdditiveLocalSpace_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("SlopeAdditive")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS:ASSlopeAdditiveMeshSpace")]
	public UAnimSequence ASSlopeAdditiveMeshSpace
	{
		get
		{
			CheckDestroyed();
			if (!ASSlopeAdditiveMeshSpace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:ASSlopeAdditiveMeshSpace");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASSlopeAdditiveMeshSpace_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASSlopeAdditiveMeshSpace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:ASSlopeAdditiveMeshSpace");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASSlopeAdditiveMeshSpace_Offset), value);
			}
		}
	}

	[Category("MoveSpeedAdditive")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS:BSMoveSpeedAdditive")]
	public UBlendSpace BSMoveSpeedAdditive
	{
		get
		{
			CheckDestroyed();
			if (!BSMoveSpeedAdditive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:BSMoveSpeedAdditive");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSMoveSpeedAdditive_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSMoveSpeedAdditive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS:BSMoveSpeedAdditive");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSMoveSpeedAdditive_Offset), value);
			}
		}
	}

	protected override void BlueprintInitializeAnimationImpl()
	{
		base.SkipBlueprintUpdateAnimation = 1;
		Owner = GetOwningActor();
		IsBSSlot = false;
		if (base.ABPSettingData != null)
		{
			BUABPCommonSettingData commonSetting = base.ABPSettingData.CommonSetting;
			AnimIdle = commonSetting.AnimSeqIdle;
			bDisableABPMove = commonSetting.bDisableABPMove;
		}
		InitNeededLinkedInstance();
	}

	private void InitNeededLinkedInstance()
	{
		if (base.ABPSettingData == null)
		{
			return;
		}
		BUABPCommonSettingData commonSetting = base.ABPSettingData.CommonSetting;
		BUAnimHumanoidCS_Move bUAnimHumanoidCS_Move = GetLinkedAnimGraphInstanceByTag(B1GlobalFNames.Move) as BUAnimHumanoidCS_Move;
		if (bUAnimHumanoidCS_Move != null)
		{
			b1.BGU.BUAnim.AbpHelperUtil.InitABPMoveModeAnimInstance(bUAnimHumanoidCS_Move, commonSetting.ABPMoveMode);
			if (commonSetting.ABPMoveMode == EABPMoveMode.MotionMatching)
			{
				BUABPMotionMatchingSettingData motionMatchingSetting = base.ABPSettingData.MotionMatchingSetting;
				b1.BGU.BUAnim.AbpHelperUtil.InitABPMoveModeAnimInstance(bUAnimHumanoidCS_Move, motionMatchingSetting.SpareMoveMode);
			}
		}
		if (bIsPlayer)
		{
			UGSE_AnimFuncLib.InitAnimGraphNode(this, B1GlobalFNames.SpecialMove);
		}
	}

	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS:BlueprintThreadSafeUpdateAnimation")]
	protected override void BlueprintThreadSafeUpdateAnimation_Implementation(float DeltaTimeX)
	{
		_ = Owner;
		if (ChrData != null)
		{
			IsFarButInSight = ChrData.IsFarButInSight;
		}
		FootIKAlpha = 0f;
		HandIKAlpha = 0f;
		BSSlotAlpha = (IsBSSlot ? 1f : 0f);
		if (AimOffsetData != null)
		{
			DefaultAimOffset = AimOffsetData.DefaultAimOffset;
			AttackAimOffset = AimOffsetData.AttackAimOffset;
			EnableAimOffset = DefaultAimOffset != null;
			DefaultAOAlpha = (EnableAimOffset ? AimOffsetData.AOAlpha : 0f);
			bIsAttackAimOffsetEnable = !AttackAimOffset.IsNullOrDestroyed();
		}
		AttackAOAlpha = (bIsAttackAimOffsetEnable ? 1f : 0f);
		if (CommonData != null)
		{
			AnimIdle = CommonData.AnimIdle;
		}
		if (BasicData != null)
		{
			MappedSpeed = BasicData.GetMappedSpeed();
		}
		if (FootIKData != null)
		{
			FootIKData.ThreadSafeUpdateAnimation(Owner, DeltaTimeX);
			FootIKAlpha = (FootIKData.bActiveFootIK ? 1f : 0f);
			HandIKAlpha = ((FootIKData.bActiveTouchIK || FootIKData.bActiveForefootIK) ? 1f : 0f);
		}
		if (AnimHumanoidHelperData != null)
		{
			AnimHumanoidHelperData.GetFloatAnimCurveValue(in B1GlobalFNames.FootIKMaskValue, out var OutCurveValue);
			FootIKAlpha = FMath.Clamp(FootIKAlpha * (1f - OutCurveValue), 0f, 1f);
		}
		if (SpineIKData != null)
		{
			IKSpinePitch = SpineIKData.IKSpinePitch;
			IKSpineRoll = SpineIKData.IKSpineRoll;
			IKPelivisAlpha = SpineIKData.IKPelivisAlpha;
		}
		if (AttackIKData != null)
		{
			AttackIKAlpha = AttackIKData.AttackIKAlpha;
		}
		if (HeadAimingData != null)
		{
			HeadAimYaw = HeadAimingData.HeadAimYaw;
			HeadAimPitch = HeadAimingData.HeadAimPitch;
		}
		if (UpperBodyAimingData != null)
		{
			AttackAimOffsetEnableX = UpperBodyAimingData.UpperBodyAimYaw;
			AttackAimOffsetEnableY = UpperBodyAimingData.UpperBodyAimPitch;
		}
		if (MMFixedData != null)
		{
			MMKeepAlpha = MMFixedData.MMKeepAlpha;
		}
		if (BodyBlendData != null)
		{
			bEnableAnyCurveBodyBlend = BodyBlendData.bEnableAnyCurveBodyBlend;
			bHasUpperBodySlotMontage = BodyBlendData.bHasUpperBodySlotMontage;
			bHasLeftArmSlotMontage = BodyBlendData.bHasLeftArmSlotMontage;
			bHasRightArmSlotMontage = BodyBlendData.bHasRightArmSlotMontage;
			bEnableAnimCurveBodySeparation = BodyBlendData.bEnableAnimCurveBodySeparation;
		}
		if (PoseSnapshotData != null)
		{
			bUsePoseOverride = PoseSnapshotData.bUsePoseOverride;
			PoseSnapshot = PoseSnapshotData.PoseSnapshot;
			EnableSnapshotBlendTime = PoseSnapshotData.EnableSnapshotBlendTime;
			DisableSnapshotBlendTime = PoseSnapshotData.DisableSnapshotBlendTime;
		}
		if (WeaponAimData != null)
		{
			WeaponAimAlpha = WeaponAimData.WeaponAimAlpha;
		}
		if (PhysicBlendData != null)
		{
			PhysicBlendAlpha = PhysicBlendData.PhysicBlendAlpha_ForRigidBody;
		}
		if (AMMatryoshkaData != null)
		{
			AMMatryoshkaAlpha = AMMatryoshkaData.Alpha;
		}
		if (SlopeAdditiveData != null)
		{
			SlopeAlpha = SlopeAdditiveData.SlopeAlpha;
		}
	}

	private void InitBUCData()
	{
		if (ECSExtension.IsECSActor(Owner))
		{
			BasicData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPBasicData, BUC_ABPBasicData>(Owner);
			ChrData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPCharacterData, BUC_ABPCharacterData>(Owner);
			BGUChrData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPBGUCharacterData, BUC_ABPBGUCharacterData>(Owner);
			FootIKData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPFootIKData, BUC_ABPFootIKData>(Owner);
			SpineIKData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPSpineIKData, BUC_ABPSpineIKData>(Owner);
			HeadAimingData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPHeadAimingData, BUC_ABPHeadAimingData>(Owner);
			UpperBodyAimingData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPUpperBodyAimingData, BUC_ABPUpperBodyAimingData>(Owner);
			MMFixedData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPMMFixedData, BUC_ABPMMFixedData>(Owner);
			BodyBlendData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPBodyBlendData, BUC_ABPBodyBlendData>(Owner);
			AimOffsetData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPAimOffsetData, BUC_ABPAimOffsetData>(Owner);
			WeaponAimData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPWeaponAimData, BUC_ABPWeaponAimData>(Owner);
			PhysicBlendData = BGU_DataUtil.GetUnPersistentReadOnlyData<b1.IBUC_PhysicBlendData, BUC_PhysicBlendData>(Owner);
			AMMatryoshkaData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPAMMatryoshkaData, BUC_ABPAMMatryoshkaData>(Owner);
			PoseSnapshotData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPPoseSnapshotData, BUC_ABPPoseSnapshotData>(Owner);
			AttackIKData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPAttackIKData, BUC_ABPAttackIKData>(Owner);
			CommonData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPCommonSettingData, BUC_ABPCommonSettingData>(Owner);
			SlopeAdditiveData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPSlopeAdditiveData, BUC_ABPSpeicalAdditiveData>(Owner);
			AnimHumanoidHelperData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPHelperData, BUC_ABPHelperData>(Owner);
			ActorBasicData = BGU_DataUtil.GetReadOnlyData<IBUC_ActorBasicData, BUC_ActorBasicData>(Owner);
		}
	}

	protected override void OnInitABPSetting()
	{
		base.OnInitABPSetting();
		if (base.ABPSettingData != null)
		{
			InitCommonSetting(base.ABPSettingData.CommonSetting);
			InitDingShenSetting(base.ABPSettingData.DingShenSetting);
			InitSpecialAdditiveSetting(base.ABPSettingData.SpecialAdditiveSetting);
			InitData();
			InitNeededLinkedInstance();
		}
	}

	private void RefreshABP()
	{
		if (!this.IsNullOrDestroyed())
		{
			BlueprintThreadSafeUpdateAnimation_Implementation(0f);
		}
	}

	private void InitCommonSetting(BUABPCommonSettingData Setting)
	{
		bDisableABPMove = Setting.bDisableABPMove;
	}

	private void InitDingShenSetting(BUABPDingShenSettingData Setting)
	{
		AnimDingShenStart = Setting.AnimDingShenStart;
		AnimDingShenHold = Setting.AnimDingShenHold;
	}

	private void InitSpecialAdditiveSetting(BUABPSpecialAdditiveSettingData Setting)
	{
		ASSlopeAdditiveLocalSpace = Setting.ASSlopeAdditiveLocalSpace;
		ASSlopeAdditiveMeshSpace = Setting.ASSlopeAdditiveMeshSpace;
		BSMoveSpeedAdditive = Setting.BSMoveSpeedAdditive;
	}

	protected override void AttachEvent()
	{
		base.AttachEvent();
		if (base.BAE != null)
		{
			BUC_ABPEventCollection bAE = base.BAE;
			bAE.Evt_RefreshABP = (BUC_ABPEventCollection.Del_Void)Delegate.Combine(bAE.Evt_RefreshABP, new BUC_ABPEventCollection.Del_Void(RefreshABP));
			BUAnimHumanoidCS_Move bUAnimHumanoidCS_Move = GetLinkedAnimGraphInstanceByTag(B1GlobalFNames.Move) as BUAnimHumanoidCS_Move;
			if (bUAnimHumanoidCS_Move != null)
			{
				bUAnimHumanoidCS_Move.AttachEvent();
			}
			BUAnimHumanoidCS_SpecialMove bUAnimHumanoidCS_SpecialMove = GetLinkedAnimGraphInstanceByTag(B1GlobalFNames.SpecialMove) as BUAnimHumanoidCS_SpecialMove;
			if (bUAnimHumanoidCS_SpecialMove != null)
			{
				bUAnimHumanoidCS_SpecialMove.AttachEvent();
			}
			BUAnimHumanoidCS_AnimCurveBodyBlend bUAnimHumanoidCS_AnimCurveBodyBlend = GetLinkedAnimGraphInstanceByTag(B1GlobalFNames.AnimCurveBodyBlend) as BUAnimHumanoidCS_AnimCurveBodyBlend;
			if (bUAnimHumanoidCS_AnimCurveBodyBlend != null)
			{
				bUAnimHumanoidCS_AnimCurveBodyBlend.AttachEvent();
			}
			BUAnimHumanoidCS_UpperBodySeparation bUAnimHumanoidCS_UpperBodySeparation = GetLinkedAnimGraphInstanceByTag(B1GlobalFNames.UpperBodySeparation) as BUAnimHumanoidCS_UpperBodySeparation;
			if (bUAnimHumanoidCS_UpperBodySeparation != null)
			{
				bUAnimHumanoidCS_UpperBodySeparation.AttachEvent();
			}
			BUAnimHumanoidCS_LeftArmSeparation bUAnimHumanoidCS_LeftArmSeparation = GetLinkedAnimGraphInstanceByTag(B1GlobalFNames.LeftArmSeparation) as BUAnimHumanoidCS_LeftArmSeparation;
			if (bUAnimHumanoidCS_LeftArmSeparation != null)
			{
				bUAnimHumanoidCS_LeftArmSeparation.AttachEvent();
			}
			GetLinkedAnimGraphInstanceByTag(B1GlobalFNames.RightArmSeparation);
			if (bUAnimHumanoidCS_LeftArmSeparation != null)
			{
				bUAnimHumanoidCS_LeftArmSeparation.AttachEvent();
			}
			BUAnimHumanoidCS_FootIK bUAnimHumanoidCS_FootIK = GetLinkedAnimGraphInstanceByTag(B1GlobalFNames.FootIK) as BUAnimHumanoidCS_FootIK;
			if (bUAnimHumanoidCS_FootIK != null)
			{
				bUAnimHumanoidCS_FootIK.AttachEvent();
			}
			BUAnimHumanoidCS_HandIK bUAnimHumanoidCS_HandIK = GetLinkedAnimGraphInstanceByTag(B1GlobalFNames.HandIK) as BUAnimHumanoidCS_HandIK;
			if (bUAnimHumanoidCS_HandIK != null)
			{
				bUAnimHumanoidCS_HandIK.AttachEvent();
			}
			BUAnimHumanoidCS_BoneAim bUAnimHumanoidCS_BoneAim = GetLinkedAnimGraphInstanceByTag(B1GlobalFNames.BoneAim) as BUAnimHumanoidCS_BoneAim;
			if (bUAnimHumanoidCS_BoneAim != null)
			{
				bUAnimHumanoidCS_BoneAim.AttachEvent();
			}
		}
	}

	protected override void UnAttachEvent()
	{
		base.UnAttachEvent();
		if (base.BAE != null)
		{
			BUC_ABPEventCollection bAE = base.BAE;
			bAE.Evt_RefreshABP = (BUC_ABPEventCollection.Del_Void)Delegate.Remove(bAE.Evt_RefreshABP, new BUC_ABPEventCollection.Del_Void(RefreshABP));
			BUAnimHumanoidCS_Move bUAnimHumanoidCS_Move = GetLinkedAnimGraphInstanceByTag(B1GlobalFNames.Move) as BUAnimHumanoidCS_Move;
			if (bUAnimHumanoidCS_Move != null)
			{
				bUAnimHumanoidCS_Move.UnAttachEvent();
			}
			BUAnimHumanoidCS_SpecialMove bUAnimHumanoidCS_SpecialMove = GetLinkedAnimGraphInstanceByTag(B1GlobalFNames.SpecialMove) as BUAnimHumanoidCS_SpecialMove;
			if (bUAnimHumanoidCS_SpecialMove != null)
			{
				bUAnimHumanoidCS_SpecialMove.UnAttachEvent();
			}
			BUAnimHumanoidCS_AnimCurveBodyBlend bUAnimHumanoidCS_AnimCurveBodyBlend = GetLinkedAnimGraphInstanceByTag(B1GlobalFNames.AnimCurveBodyBlend) as BUAnimHumanoidCS_AnimCurveBodyBlend;
			if (bUAnimHumanoidCS_AnimCurveBodyBlend != null)
			{
				bUAnimHumanoidCS_AnimCurveBodyBlend.UnAttachEvent();
			}
			BUAnimHumanoidCS_UpperBodySeparation bUAnimHumanoidCS_UpperBodySeparation = GetLinkedAnimGraphInstanceByTag(B1GlobalFNames.UpperBodySeparation) as BUAnimHumanoidCS_UpperBodySeparation;
			if (bUAnimHumanoidCS_UpperBodySeparation != null)
			{
				bUAnimHumanoidCS_UpperBodySeparation.UnAttachEvent();
			}
			BUAnimHumanoidCS_LeftArmSeparation bUAnimHumanoidCS_LeftArmSeparation = GetLinkedAnimGraphInstanceByTag(B1GlobalFNames.LeftArmSeparation) as BUAnimHumanoidCS_LeftArmSeparation;
			if (bUAnimHumanoidCS_LeftArmSeparation != null)
			{
				bUAnimHumanoidCS_LeftArmSeparation.UnAttachEvent();
			}
			GetLinkedAnimGraphInstanceByTag(B1GlobalFNames.RightArmSeparation);
			if (bUAnimHumanoidCS_LeftArmSeparation != null)
			{
				bUAnimHumanoidCS_LeftArmSeparation.UnAttachEvent();
			}
			BUAnimHumanoidCS_FootIK bUAnimHumanoidCS_FootIK = GetLinkedAnimGraphInstanceByTag(B1GlobalFNames.FootIK) as BUAnimHumanoidCS_FootIK;
			if (bUAnimHumanoidCS_FootIK != null)
			{
				bUAnimHumanoidCS_FootIK.UnAttachEvent();
			}
			BUAnimHumanoidCS_HandIK bUAnimHumanoidCS_HandIK = GetLinkedAnimGraphInstanceByTag(B1GlobalFNames.HandIK) as BUAnimHumanoidCS_HandIK;
			if (bUAnimHumanoidCS_HandIK != null)
			{
				bUAnimHumanoidCS_HandIK.UnAttachEvent();
			}
			BUAnimHumanoidCS_BoneAim bUAnimHumanoidCS_BoneAim = GetLinkedAnimGraphInstanceByTag(B1GlobalFNames.BoneAim) as BUAnimHumanoidCS_BoneAim;
			if (bUAnimHumanoidCS_BoneAim != null)
			{
				bUAnimHumanoidCS_BoneAim.UnAttachEvent();
			}
		}
	}

	public void InitData()
	{
		InitBUCData();
		if (FootIKData != null)
		{
			bEnableIK = FootIKData.bActiveFootIK;
		}
		if (AimOffsetData != null)
		{
			DefaultAimOffset = AimOffsetData.DefaultAimOffset;
			AttackAimOffset = AimOffsetData.AttackAimOffset;
			bIsAttackAimOffsetEnable = !AttackAimOffset.IsNullOrDestroyed();
		}
		EnableAimOffset = DefaultAimOffset != null;
		if (MMFixedData != null)
		{
			MMKeepAlpha = MMFixedData.MMKeepAlpha;
		}
		if (WeaponAimData != null)
		{
			WeaponAimAlpha = WeaponAimData.WeaponAimAlpha;
		}
		if (ActorBasicData != null)
		{
			bIsPlayer = ActorBasicData.ActorType == BGU_ActorType.CharacterPlayer;
		}
	}

	public void SetBSPatrol(PatrolBlendSpaceSetting ExBS_Patrol)
	{
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS:BlueprintThreadSafeUpdateAnimation")]
	private static void BlueprintThreadSafeUpdateAnimation__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS bUAnimHumanoidCS = GCHelper.Find<BUAnimHumanoidCS>(obj);
		float deltaTimeX = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BlueprintThreadSafeUpdateAnimation_DeltaTimeX_Offset));
		bUAnimHumanoidCS.BlueprintThreadSafeUpdateAnimation_Implementation(deltaTimeX);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUAnimHumanoidCS");
		HandIKAlpha_Offset = NativeReflection.GetPropertyOffset(intPtr, "HandIKAlpha");
		HandIKAlpha_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HandIKAlpha", Classes.FFloatProperty);
		DefaultAOAlpha_Offset = NativeReflection.GetPropertyOffset(intPtr, "DefaultAOAlpha");
		DefaultAOAlpha_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DefaultAOAlpha", Classes.FFloatProperty);
		AttackAOAlpha_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttackAOAlpha");
		AttackAOAlpha_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttackAOAlpha", Classes.FFloatProperty);
		BSSlotAlpha_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSSlotAlpha");
		BSSlotAlpha_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSSlotAlpha", Classes.FFloatProperty);
		MMKeepAlpha_Offset = NativeReflection.GetPropertyOffset(intPtr, "MMKeepAlpha");
		MMKeepAlpha_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MMKeepAlpha", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bEnableAnyCurveBodyBlend_PropertyAddress, intPtr, "bEnableAnyCurveBodyBlend");
		bEnableAnyCurveBodyBlend_Offset = NativeReflection.GetPropertyOffset(intPtr, "bEnableAnyCurveBodyBlend");
		bEnableAnyCurveBodyBlend_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bEnableAnyCurveBodyBlend", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bHasUpperBodySlotMontage_PropertyAddress, intPtr, "bHasUpperBodySlotMontage");
		bHasUpperBodySlotMontage_Offset = NativeReflection.GetPropertyOffset(intPtr, "bHasUpperBodySlotMontage");
		bHasUpperBodySlotMontage_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bHasUpperBodySlotMontage", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bHasLeftArmSlotMontage_PropertyAddress, intPtr, "bHasLeftArmSlotMontage");
		bHasLeftArmSlotMontage_Offset = NativeReflection.GetPropertyOffset(intPtr, "bHasLeftArmSlotMontage");
		bHasLeftArmSlotMontage_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bHasLeftArmSlotMontage", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bHasRightArmSlotMontage_PropertyAddress, intPtr, "bHasRightArmSlotMontage");
		bHasRightArmSlotMontage_Offset = NativeReflection.GetPropertyOffset(intPtr, "bHasRightArmSlotMontage");
		bHasRightArmSlotMontage_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bHasRightArmSlotMontage", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bUsePoseOverride_PropertyAddress, intPtr, "bUsePoseOverride");
		bUsePoseOverride_Offset = NativeReflection.GetPropertyOffset(intPtr, "bUsePoseOverride");
		bUsePoseOverride_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bUsePoseOverride", Classes.FBoolProperty);
		PoseSnapshot_Offset = NativeReflection.GetPropertyOffset(intPtr, "PoseSnapshot");
		PoseSnapshot_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PoseSnapshot", Classes.FStructProperty);
		EnableSnapshotBlendTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnableSnapshotBlendTime");
		EnableSnapshotBlendTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnableSnapshotBlendTime", Classes.FFloatProperty);
		DisableSnapshotBlendTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "DisableSnapshotBlendTime");
		DisableSnapshotBlendTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DisableSnapshotBlendTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bEnableAnimCurveBodySeparation_PropertyAddress, intPtr, "bEnableAnimCurveBodySeparation");
		bEnableAnimCurveBodySeparation_Offset = NativeReflection.GetPropertyOffset(intPtr, "bEnableAnimCurveBodySeparation");
		bEnableAnimCurveBodySeparation_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bEnableAnimCurveBodySeparation", Classes.FBoolProperty);
		AMMatryoshkaAlpha_Offset = NativeReflection.GetPropertyOffset(intPtr, "AMMatryoshkaAlpha");
		AMMatryoshkaAlpha_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AMMatryoshkaAlpha", Classes.FFloatProperty);
		AttackIKAlpha_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttackIKAlpha");
		AttackIKAlpha_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttackIKAlpha", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bDisableABPMove_PropertyAddress, intPtr, "bDisableABPMove");
		bDisableABPMove_Offset = NativeReflection.GetPropertyOffset(intPtr, "bDisableABPMove");
		bDisableABPMove_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bDisableABPMove", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bHasMoveInput_PropertyAddress, intPtr, "bHasMoveInput");
		bHasMoveInput_Offset = NativeReflection.GetPropertyOffset(intPtr, "bHasMoveInput");
		bHasMoveInput_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bHasMoveInput", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bHasPlayerInput_PropertyAddress, intPtr, "bHasPlayerInput");
		bHasPlayerInput_Offset = NativeReflection.GetPropertyOffset(intPtr, "bHasPlayerInput");
		bHasPlayerInput_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bHasPlayerInput", Classes.FBoolProperty);
		MappedSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "MappedSpeed");
		MappedSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MappedSpeed", Classes.FFloatProperty);
		HeadAimYaw_Offset = NativeReflection.GetPropertyOffset(intPtr, "HeadAimYaw");
		HeadAimYaw_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HeadAimYaw", Classes.FFloatProperty);
		HeadAimPitch_Offset = NativeReflection.GetPropertyOffset(intPtr, "HeadAimPitch");
		HeadAimPitch_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HeadAimPitch", Classes.FFloatProperty);
		HeadAimAlpha_Offset = NativeReflection.GetPropertyOffset(intPtr, "HeadAimAlpha");
		HeadAimAlpha_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HeadAimAlpha", Classes.FFloatProperty);
		FootIKAlpha_Offset = NativeReflection.GetPropertyOffset(intPtr, "FootIKAlpha");
		FootIKAlpha_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FootIKAlpha", Classes.FFloatProperty);
		IKPelivisAlpha_Offset = NativeReflection.GetPropertyOffset(intPtr, "IKPelivisAlpha");
		IKPelivisAlpha_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IKPelivisAlpha", Classes.FFloatProperty);
		IKSpinePitch_Offset = NativeReflection.GetPropertyOffset(intPtr, "IKSpinePitch");
		IKSpinePitch_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IKSpinePitch", Classes.FFloatProperty);
		IKSpineRoll_Offset = NativeReflection.GetPropertyOffset(intPtr, "IKSpineRoll");
		IKSpineRoll_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IKSpineRoll", Classes.FFloatProperty);
		IKInterpSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "IKInterpSpeed");
		IKInterpSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IKInterpSpeed", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bEnableIK_PropertyAddress, intPtr, "bEnableIK");
		bEnableIK_Offset = NativeReflection.GetPropertyOffset(intPtr, "bEnableIK");
		bEnableIK_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bEnableIK", Classes.FBoolProperty);
		AnimIdle_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimIdle");
		AnimIdle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimIdle", Classes.FObjectProperty);
		DefaultAimOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "DefaultAimOffset");
		DefaultAimOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DefaultAimOffset", Classes.FObjectProperty);
		AttackAimOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttackAimOffset");
		AttackAimOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttackAimOffset", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref bIsAttackAimOffsetEnable_PropertyAddress, intPtr, "bIsAttackAimOffsetEnable");
		bIsAttackAimOffsetEnable_Offset = NativeReflection.GetPropertyOffset(intPtr, "bIsAttackAimOffsetEnable");
		bIsAttackAimOffsetEnable_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bIsAttackAimOffsetEnable", Classes.FBoolProperty);
		AttackAimOffsetEnableX_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttackAimOffsetEnableX");
		AttackAimOffsetEnableX_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttackAimOffsetEnableX", Classes.FFloatProperty);
		AttackAimOffsetEnableY_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttackAimOffsetEnableY");
		AttackAimOffsetEnableY_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttackAimOffsetEnableY", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref EnableAimOffset_PropertyAddress, intPtr, "EnableAimOffset");
		EnableAimOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnableAimOffset");
		EnableAimOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnableAimOffset", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IsFarButInSight_PropertyAddress, intPtr, "IsFarButInSight");
		IsFarButInSight_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsFarButInSight");
		IsFarButInSight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsFarButInSight", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bIsPlayer_PropertyAddress, intPtr, "bIsPlayer");
		bIsPlayer_Offset = NativeReflection.GetPropertyOffset(intPtr, "bIsPlayer");
		bIsPlayer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bIsPlayer", Classes.FBoolProperty);
		AnimDingShenStart_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimDingShenStart");
		AnimDingShenStart_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimDingShenStart", Classes.FObjectProperty);
		AnimDingShenHold_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimDingShenHold");
		AnimDingShenHold_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimDingShenHold", Classes.FObjectProperty);
		BSSlot_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSSlot");
		BSSlot_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSSlot", Classes.FObjectProperty);
		BSSlotY_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSSlotY");
		BSSlotY_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSSlotY", Classes.FFloatProperty);
		BSSlotX_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSSlotX");
		BSSlotX_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSSlotX", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref IsBSSlot_PropertyAddress, intPtr, "IsBSSlot");
		IsBSSlot_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsBSSlot");
		IsBSSlot_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsBSSlot", Classes.FBoolProperty);
		WeaponAimAlpha_Offset = NativeReflection.GetPropertyOffset(intPtr, "WeaponAimAlpha");
		WeaponAimAlpha_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WeaponAimAlpha", Classes.FFloatProperty);
		PhysicBlendAlpha_Offset = NativeReflection.GetPropertyOffset(intPtr, "PhysicBlendAlpha");
		PhysicBlendAlpha_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PhysicBlendAlpha", Classes.FFloatProperty);
		SlopeAlpha_Offset = NativeReflection.GetPropertyOffset(intPtr, "SlopeAlpha");
		SlopeAlpha_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SlopeAlpha", Classes.FFloatProperty);
		ASSlopeAdditiveLocalSpace_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASSlopeAdditiveLocalSpace");
		ASSlopeAdditiveLocalSpace_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASSlopeAdditiveLocalSpace", Classes.FObjectProperty);
		ASSlopeAdditiveMeshSpace_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASSlopeAdditiveMeshSpace");
		ASSlopeAdditiveMeshSpace_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASSlopeAdditiveMeshSpace", Classes.FObjectProperty);
		BSMoveSpeedAdditive_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSMoveSpeedAdditive");
		BSMoveSpeedAdditive_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSMoveSpeedAdditive", Classes.FObjectProperty);
		BlueprintThreadSafeUpdateAnimation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BlueprintThreadSafeUpdateAnimation");
		BlueprintThreadSafeUpdateAnimation_ParamsSize = NativeReflection.GetFunctionParamsSize(BlueprintThreadSafeUpdateAnimation_FunctionAddress);
		BlueprintThreadSafeUpdateAnimation_DeltaTimeX_Offset = NativeReflection.GetPropertyOffset(BlueprintThreadSafeUpdateAnimation_FunctionAddress, "DeltaTimeX");
		BlueprintThreadSafeUpdateAnimation_DeltaTimeX_IsValid = NativeReflection.ValidatePropertyClass(BlueprintThreadSafeUpdateAnimation_FunctionAddress, "DeltaTimeX", Classes.FFloatProperty);
		BlueprintThreadSafeUpdateAnimation_IsValid = BlueprintThreadSafeUpdateAnimation_FunctionAddress != IntPtr.Zero && BlueprintThreadSafeUpdateAnimation_DeltaTimeX_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS:BlueprintThreadSafeUpdateAnimation", BlueprintThreadSafeUpdateAnimation_IsValid);
	}

	static BUAnimHumanoidCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUAnimHumanoidCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUAnimHumanoidCS));
	}
}
