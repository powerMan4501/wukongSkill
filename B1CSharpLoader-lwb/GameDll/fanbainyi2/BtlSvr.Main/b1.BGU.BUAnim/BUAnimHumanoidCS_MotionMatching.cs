using System;
using b1.Plugins.GSEngineExtent;
using b1.Plugins.MM;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.BGU.BUAnim;

[UClass]
[Abstract]
[Blueprintable]
[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching")]
public class BUAnimHumanoidCS_MotionMatching : BUAnimHumanoidCS_LinkedInstanceBase, b1.BGU.BUAnim.IBUEnityAnim
{
	private IBUC_ABPMotionMatchingData MMData;

	private IBUC_ABPBasicData BasicData;

	private IBUC_ABPCommonSettingData CommonData;

	private IBUC_ABPCharacterData ChrData;

	private float MMToIdleSpeed;

	private static bool InputDesiredTransform_IsValid;

	private static int InputDesiredTransform_Offset;

	private static bool InputRootTransform_IsValid;

	private static int InputRootTransform_Offset;

	private static bool InputStrength_IsValid;

	private static int InputStrength_Offset;

	private static bool MotionMatchingState_IsValid;

	private static int MotionMatchingState_Offset;

	private static FFieldAddress MotionMatchingState_PropertyAddress;

	private static bool RotatorforMM_IsValid;

	private static int RotatorforMM_Offset;

	private static bool UseMotionMatching_IsValid;

	private static int UseMotionMatching_Offset;

	private static FFieldAddress UseMotionMatching_PropertyAddress;

	private static bool SpareMoveMode_IsValid;

	private static int SpareMoveMode_Offset;

	private static FFieldAddress SpareMoveMode_PropertyAddress;

	private static bool CurrentAA_IsValid;

	private static int CurrentAA_Offset;

	private static bool AnimationAnalyzerBlendTime_IsValid;

	private static int AnimationAnalyzerBlendTime_Offset;

	private static bool MotionBlendTime_IsValid;

	private static int MotionBlendTime_Offset;

	private static bool MMPlayRate_IsValid;

	private static int MMPlayRate_Offset;

	private static bool ForceSetRotAnimSpeed_IsValid;

	private static int ForceSetRotAnimSpeed_Offset;

	private static bool DisableRotVerifyAnimSpeed_IsValid;

	private static int DisableRotVerifyAnimSpeed_Offset;

	private static bool bRecordMMAnimData_IsValid;

	private static int bRecordMMAnimData_Offset;

	private static FFieldAddress bRecordMMAnimData_PropertyAddress;

	private static bool bDisableLocomotionIdle_IsValid;

	private static int bDisableLocomotionIdle_Offset;

	private static FFieldAddress bDisableLocomotionIdle_PropertyAddress;

	private static bool bForceMMToIdle_IsValid;

	private static int bForceMMToIdle_Offset;

	private static FFieldAddress bForceMMToIdle_PropertyAddress;

	private static bool MMUpBodyStateAlpha_IsValid;

	private static int MMUpBodyStateAlpha_Offset;

	private static bool RotateAdditiveBS_IsValid;

	private static int RotateAdditiveBS_Offset;

	private static bool RotateBSX_IsValid;

	private static int RotateBSX_Offset;

	private static bool bMMtoIdle_IsValid;

	private static int bMMtoIdle_Offset;

	private static FFieldAddress bMMtoIdle_PropertyAddress;

	private static bool bIdleToMM_IsValid;

	private static int bIdleToMM_Offset;

	private static FFieldAddress bIdleToMM_PropertyAddress;

	private static bool bNeedFixMM_IsValid;

	private static int bNeedFixMM_Offset;

	private static FFieldAddress bNeedFixMM_PropertyAddress;

	private static bool bFixMMWeapon_MeshSpaceRotation_IsValid;

	private static int bFixMMWeapon_MeshSpaceRotation_Offset;

	private static FFieldAddress bFixMMWeapon_MeshSpaceRotation_PropertyAddress;

	private static bool MMAdditivePose_IsValid;

	private static int MMAdditivePose_Offset;

	private static bool bFixMMAdditive_MeshSpaceRotation_IsValid;

	private static int bFixMMAdditive_MeshSpaceRotation_Offset;

	private static FFieldAddress bFixMMAdditive_MeshSpaceRotation_PropertyAddress;

	private static bool MMAdditiveLayerSetup_IsValid;

	private static int MMAdditiveLayerSetup_Offset;

	private static FFieldAddress MMAdditiveLayerSetup_PropertyAddress;

	private TArrayReadWriteMarshaler<FGSInputBlendPose> MMAdditiveLayerSetup_Marshaler;

	private static bool MMAdditiveWeight_IsValid;

	private static int MMAdditiveWeight_Offset;

	private static bool MMTransAnim_IsValid;

	private static int MMTransAnim_Offset;

	private static bool MMTransAnimStartPos_IsValid;

	private static int MMTransAnimStartPos_Offset;

	private static bool MMTransAlpha_IsValid;

	private static int MMTransAlpha_Offset;

	private static bool bMMTransFinish_IsValid;

	private static int bMMTransFinish_Offset;

	private static FFieldAddress bMMTransFinish_PropertyAddress;

	private static bool bMMTransStart_IsValid;

	private static int bMMTransStart_Offset;

	private static FFieldAddress bMMTransStart_PropertyAddress;

	private static bool DefaultJointData_IsValid;

	private static int DefaultJointData_Offset;

	private static bool DefaultVelocity_IsValid;

	private static int DefaultVelocity_Offset;

	private static bool bKeepMMInputUnchanged_IsValid;

	private static int bKeepMMInputUnchanged_Offset;

	private static FFieldAddress bKeepMMInputUnchanged_PropertyAddress;

	private static bool bUseLMAnim_IsValid;

	private static int bUseLMAnim_Offset;

	private static FFieldAddress bUseLMAnim_PropertyAddress;

	private static bool bDisableMMRootMotion_IsValid;

	private static int bDisableMMRootMotion_Offset;

	private static FFieldAddress bDisableMMRootMotion_PropertyAddress;

	private static bool Speed_IsValid;

	private static int Speed_Offset;

	private static bool AnimIdle_IsValid;

	private static int AnimIdle_Offset;

	private static bool BSRunFwd_IsValid;

	private static int BSRunFwd_Offset;

	private static bool SetupDefaultMMPoseData_IsValid;

	private static IntPtr SetupDefaultMMPoseData_FunctionAddress;

	private static int SetupDefaultMMPoseData_ParamsSize;

	private static bool SetupDefaultMMPoseData_Context_IsValid;

	private static int SetupDefaultMMPoseData_Context_Offset;

	private static FFieldAddress SetupDefaultMMPoseData_Context_PropertyAddress;

	private static bool SetupDefaultMMPoseData_Node_IsValid;

	private static int SetupDefaultMMPoseData_Node_Offset;

	private static FFieldAddress SetupDefaultMMPoseData_Node_PropertyAddress;

	[BlueprintReadOnly]
	[UProperty]
	[Category("MotionMatching")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:InputDesiredTransform")]
	public FTransform InputDesiredTransform
	{
		get
		{
			CheckDestroyed();
			if (!InputDesiredTransform_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:InputDesiredTransform");
				return default(FTransform);
			}
			return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(base.Address, InputDesiredTransform_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InputDesiredTransform_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:InputDesiredTransform");
			}
			else
			{
				BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(base.Address, InputDesiredTransform_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("MotionMatching")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:InputRootTransform")]
	public FTransform InputRootTransform
	{
		get
		{
			CheckDestroyed();
			if (!InputRootTransform_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:InputRootTransform");
				return default(FTransform);
			}
			return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(base.Address, InputRootTransform_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InputRootTransform_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:InputRootTransform");
			}
			else
			{
				BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(base.Address, InputRootTransform_Offset), value);
			}
		}
	}

	[Category("MotionMatching")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:InputStrength")]
	public float InputStrength
	{
		get
		{
			CheckDestroyed();
			if (!InputStrength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:InputStrength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, InputStrength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InputStrength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:InputStrength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, InputStrength_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("MotionMatching")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:MotionMatchingState")]
	public EState_MM MotionMatchingState
	{
		get
		{
			CheckDestroyed();
			if (!MotionMatchingState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:MotionMatchingState");
				return EState_MM.None;
			}
			return EnumMarshaler<EState_MM>.FromNative(IntPtr.Add(base.Address, MotionMatchingState_Offset), 0, MotionMatchingState_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MotionMatchingState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:MotionMatchingState");
			}
			else
			{
				EnumMarshaler<EState_MM>.ToNative(IntPtr.Add(base.Address, MotionMatchingState_Offset), 0, MotionMatchingState_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[Category("MotionMatching")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:RotatorforMM")]
	public FRotator RotatorforMM
	{
		get
		{
			CheckDestroyed();
			if (!RotatorforMM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:RotatorforMM");
				return default(FRotator);
			}
			return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(base.Address, RotatorforMM_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RotatorforMM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:RotatorforMM");
			}
			else
			{
				BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(base.Address, RotatorforMM_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("MotionMatching")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:UseMotionMatching")]
	public bool UseMotionMatching
	{
		get
		{
			CheckDestroyed();
			if (!UseMotionMatching_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:UseMotionMatching");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseMotionMatching_Offset), 0, UseMotionMatching_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseMotionMatching_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:UseMotionMatching");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseMotionMatching_Offset), 0, UseMotionMatching_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("MotionMatching")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:SpareMoveMode")]
	public EABPMoveMode SpareMoveMode
	{
		get
		{
			CheckDestroyed();
			if (!SpareMoveMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:SpareMoveMode");
				return EABPMoveMode.None;
			}
			return EnumMarshaler<EABPMoveMode>.FromNative(IntPtr.Add(base.Address, SpareMoveMode_Offset), 0, SpareMoveMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SpareMoveMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:SpareMoveMode");
			}
			else
			{
				EnumMarshaler<EABPMoveMode>.ToNative(IntPtr.Add(base.Address, SpareMoveMode_Offset), 0, SpareMoveMode_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("MotionMatching")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:CurrentAA")]
	public UAnimationAnalyzer CurrentAA
	{
		get
		{
			CheckDestroyed();
			if (!CurrentAA_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:CurrentAA");
				return null;
			}
			return UObjectMarshaler<UAnimationAnalyzer>.FromNative(IntPtr.Add(base.Address, CurrentAA_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CurrentAA_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:CurrentAA");
			}
			else
			{
				UObjectMarshaler<UAnimationAnalyzer>.ToNative(IntPtr.Add(base.Address, CurrentAA_Offset), value);
			}
		}
	}

	[Category("MotionMatching")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:AnimationAnalyzerBlendTime")]
	public float AnimationAnalyzerBlendTime
	{
		get
		{
			CheckDestroyed();
			if (!AnimationAnalyzerBlendTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:AnimationAnalyzerBlendTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AnimationAnalyzerBlendTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimationAnalyzerBlendTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:AnimationAnalyzerBlendTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AnimationAnalyzerBlendTime_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("MotionMatching")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:MotionBlendTime")]
	public float MotionBlendTime
	{
		get
		{
			CheckDestroyed();
			if (!MotionBlendTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:MotionBlendTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MotionBlendTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MotionBlendTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:MotionBlendTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MotionBlendTime_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("MotionMatching")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:MMPlayRate")]
	public float MMPlayRate
	{
		get
		{
			CheckDestroyed();
			if (!MMPlayRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:MMPlayRate");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MMPlayRate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MMPlayRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:MMPlayRate");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MMPlayRate_Offset), value);
			}
		}
	}

	[Category("MotionMatching")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:ForceSetRotAnimSpeed")]
	public float ForceSetRotAnimSpeed
	{
		get
		{
			CheckDestroyed();
			if (!ForceSetRotAnimSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:ForceSetRotAnimSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ForceSetRotAnimSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ForceSetRotAnimSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:ForceSetRotAnimSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ForceSetRotAnimSpeed_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("MotionMatching")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:DisableRotVerifyAnimSpeed")]
	public float DisableRotVerifyAnimSpeed
	{
		get
		{
			CheckDestroyed();
			if (!DisableRotVerifyAnimSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:DisableRotVerifyAnimSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DisableRotVerifyAnimSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DisableRotVerifyAnimSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:DisableRotVerifyAnimSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DisableRotVerifyAnimSpeed_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("MotionMatching")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:bRecordMMAnimData")]
	public bool bRecordMMAnimData
	{
		get
		{
			CheckDestroyed();
			if (!bRecordMMAnimData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:bRecordMMAnimData");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bRecordMMAnimData_Offset), 0, bRecordMMAnimData_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bRecordMMAnimData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:bRecordMMAnimData");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bRecordMMAnimData_Offset), 0, bRecordMMAnimData_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("MotionMatching")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:bDisableLocomotionIdle")]
	public bool bDisableLocomotionIdle
	{
		get
		{
			CheckDestroyed();
			if (!bDisableLocomotionIdle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:bDisableLocomotionIdle");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bDisableLocomotionIdle_Offset), 0, bDisableLocomotionIdle_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bDisableLocomotionIdle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:bDisableLocomotionIdle");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bDisableLocomotionIdle_Offset), 0, bDisableLocomotionIdle_PropertyAddress.Address, value);
			}
		}
	}

	[Category("MotionMatching")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:bForceMMToIdle")]
	public bool bForceMMToIdle
	{
		get
		{
			CheckDestroyed();
			if (!bForceMMToIdle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:bForceMMToIdle");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bForceMMToIdle_Offset), 0, bForceMMToIdle_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bForceMMToIdle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:bForceMMToIdle");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bForceMMToIdle_Offset), 0, bForceMMToIdle_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("MotionMatching")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:MMUpBodyStateAlpha")]
	public float MMUpBodyStateAlpha
	{
		get
		{
			CheckDestroyed();
			if (!MMUpBodyStateAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:MMUpBodyStateAlpha");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MMUpBodyStateAlpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MMUpBodyStateAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:MMUpBodyStateAlpha");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MMUpBodyStateAlpha_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("MotionMatching")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:RotateAdditiveBS")]
	public UBlendSpace RotateAdditiveBS
	{
		get
		{
			CheckDestroyed();
			if (!RotateAdditiveBS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:RotateAdditiveBS");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, RotateAdditiveBS_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RotateAdditiveBS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:RotateAdditiveBS");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, RotateAdditiveBS_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("MotionMatching")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:RotateBSX")]
	public float RotateBSX
	{
		get
		{
			CheckDestroyed();
			if (!RotateBSX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:RotateBSX");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, RotateBSX_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RotateBSX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:RotateBSX");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, RotateBSX_Offset), value);
			}
		}
	}

	[Category("MotionMatching")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:bMMtoIdle")]
	public bool bMMtoIdle
	{
		get
		{
			CheckDestroyed();
			if (!bMMtoIdle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:bMMtoIdle");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bMMtoIdle_Offset), 0, bMMtoIdle_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bMMtoIdle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:bMMtoIdle");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bMMtoIdle_Offset), 0, bMMtoIdle_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("MotionMatching")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:bIdleToMM")]
	public bool bIdleToMM
	{
		get
		{
			CheckDestroyed();
			if (!bIdleToMM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:bIdleToMM");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bIdleToMM_Offset), 0, bIdleToMM_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bIdleToMM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:bIdleToMM");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bIdleToMM_Offset), 0, bIdleToMM_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("MotionMatching")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:bNeedFixMM")]
	public bool bNeedFixMM
	{
		get
		{
			CheckDestroyed();
			if (!bNeedFixMM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:bNeedFixMM");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bNeedFixMM_Offset), 0, bNeedFixMM_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bNeedFixMM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:bNeedFixMM");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bNeedFixMM_Offset), 0, bNeedFixMM_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("MotionMatching")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:bFixMMWeapon_MeshSpaceRotation")]
	public bool bFixMMWeapon_MeshSpaceRotation
	{
		get
		{
			CheckDestroyed();
			if (!bFixMMWeapon_MeshSpaceRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:bFixMMWeapon_MeshSpaceRotation");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bFixMMWeapon_MeshSpaceRotation_Offset), 0, bFixMMWeapon_MeshSpaceRotation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bFixMMWeapon_MeshSpaceRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:bFixMMWeapon_MeshSpaceRotation");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bFixMMWeapon_MeshSpaceRotation_Offset), 0, bFixMMWeapon_MeshSpaceRotation_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("MotionMatching")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:MMAdditivePose")]
	public UAnimSequence MMAdditivePose
	{
		get
		{
			CheckDestroyed();
			if (!MMAdditivePose_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:MMAdditivePose");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, MMAdditivePose_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MMAdditivePose_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:MMAdditivePose");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, MMAdditivePose_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("MotionMatching")]
	[Tooltip("Additive是否使用MeshSpaceRotation，需要MMAdditive LayerSetup有效")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:bFixMMAdditive_MeshSpaceRotation")]
	public bool bFixMMAdditive_MeshSpaceRotation
	{
		get
		{
			CheckDestroyed();
			if (!bFixMMAdditive_MeshSpaceRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:bFixMMAdditive_MeshSpaceRotation");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bFixMMAdditive_MeshSpaceRotation_Offset), 0, bFixMMAdditive_MeshSpaceRotation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bFixMMAdditive_MeshSpaceRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:bFixMMAdditive_MeshSpaceRotation");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bFixMMAdditive_MeshSpaceRotation_Offset), 0, bFixMMAdditive_MeshSpaceRotation_PropertyAddress.Address, value);
			}
		}
	}

	[Category("MotionMatching")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:MMAdditiveLayerSetup")]
	public TArrayReadWrite<FGSInputBlendPose> MMAdditiveLayerSetup
	{
		get
		{
			CheckDestroyed();
			if (!MMAdditiveLayerSetup_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:MMAdditiveLayerSetup");
				return null;
			}
			if (MMAdditiveLayerSetup_Marshaler == null)
			{
				MMAdditiveLayerSetup_Marshaler = new TArrayReadWriteMarshaler<FGSInputBlendPose>(1, MMAdditiveLayerSetup_PropertyAddress, CachedMarshalingDelegates<FGSInputBlendPose, FGSInputBlendPose>.FromNative, CachedMarshalingDelegates<FGSInputBlendPose, FGSInputBlendPose>.ToNative);
			}
			return MMAdditiveLayerSetup_Marshaler.FromNative(IntPtr.Add(base.Address, MMAdditiveLayerSetup_Offset));
		}
	}

	[Category("MotionMatching")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:MMAdditiveWeight")]
	public float MMAdditiveWeight
	{
		get
		{
			CheckDestroyed();
			if (!MMAdditiveWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:MMAdditiveWeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MMAdditiveWeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MMAdditiveWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:MMAdditiveWeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MMAdditiveWeight_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("MotionMatching")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:MMTransAnim")]
	public UAnimSequence MMTransAnim
	{
		get
		{
			CheckDestroyed();
			if (!MMTransAnim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:MMTransAnim");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, MMTransAnim_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MMTransAnim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:MMTransAnim");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, MMTransAnim_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("MotionMatching")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:MMTransAnimStartPos")]
	public float MMTransAnimStartPos
	{
		get
		{
			CheckDestroyed();
			if (!MMTransAnimStartPos_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:MMTransAnimStartPos");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MMTransAnimStartPos_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MMTransAnimStartPos_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:MMTransAnimStartPos");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MMTransAnimStartPos_Offset), value);
			}
		}
	}

	[Category("MotionMatching")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:MMTransAlpha")]
	public float MMTransAlpha
	{
		get
		{
			CheckDestroyed();
			if (!MMTransAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:MMTransAlpha");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MMTransAlpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MMTransAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:MMTransAlpha");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MMTransAlpha_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("MotionMatching")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:bMMTransFinish")]
	public bool bMMTransFinish
	{
		get
		{
			CheckDestroyed();
			if (!bMMTransFinish_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:bMMTransFinish");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bMMTransFinish_Offset), 0, bMMTransFinish_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bMMTransFinish_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:bMMTransFinish");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bMMTransFinish_Offset), 0, bMMTransFinish_PropertyAddress.Address, value);
			}
		}
	}

	[Category("MotionMatching")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:bMMTransStart")]
	public bool bMMTransStart
	{
		get
		{
			CheckDestroyed();
			if (!bMMTransStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:bMMTransStart");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bMMTransStart_Offset), 0, bMMTransStart_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bMMTransStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:bMMTransStart");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bMMTransStart_Offset), 0, bMMTransStart_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("MotionMatching")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:DefaultJointData")]
	public FDefaultMotionJointData DefaultJointData
	{
		get
		{
			CheckDestroyed();
			if (!DefaultJointData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:DefaultJointData");
				return default(FDefaultMotionJointData);
			}
			return FDefaultMotionJointData.FromNative(IntPtr.Add(base.Address, DefaultJointData_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultJointData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:DefaultJointData");
			}
			else
			{
				FDefaultMotionJointData.ToNative(IntPtr.Add(base.Address, DefaultJointData_Offset), value);
			}
		}
	}

	[Category("MotionMatching")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:DefaultVelocity")]
	public FVector DefaultVelocity
	{
		get
		{
			CheckDestroyed();
			if (!DefaultVelocity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:DefaultVelocity");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, DefaultVelocity_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultVelocity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:DefaultVelocity");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, DefaultVelocity_Offset), value);
			}
		}
	}

	[Category("MotionMatching")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:bKeepMMInputUnchanged")]
	public bool bKeepMMInputUnchanged
	{
		get
		{
			CheckDestroyed();
			if (!bKeepMMInputUnchanged_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:bKeepMMInputUnchanged");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bKeepMMInputUnchanged_Offset), 0, bKeepMMInputUnchanged_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bKeepMMInputUnchanged_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:bKeepMMInputUnchanged");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bKeepMMInputUnchanged_Offset), 0, bKeepMMInputUnchanged_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("MotionMatching")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:bUseLMAnim")]
	public bool bUseLMAnim
	{
		get
		{
			CheckDestroyed();
			if (!bUseLMAnim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:bUseLMAnim");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bUseLMAnim_Offset), 0, bUseLMAnim_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bUseLMAnim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:bUseLMAnim");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bUseLMAnim_Offset), 0, bUseLMAnim_PropertyAddress.Address, value);
			}
		}
	}

	[Category("MotionMatching")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:bDisableMMRootMotion")]
	public bool bDisableMMRootMotion
	{
		get
		{
			CheckDestroyed();
			if (!bDisableMMRootMotion_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:bDisableMMRootMotion");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bDisableMMRootMotion_Offset), 0, bDisableMMRootMotion_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bDisableMMRootMotion_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:bDisableMMRootMotion");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bDisableMMRootMotion_Offset), 0, bDisableMMRootMotion_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Common")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:Speed")]
	public float Speed
	{
		get
		{
			CheckDestroyed();
			if (!Speed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:Speed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Speed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Speed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:Speed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Speed_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("Common")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:AnimIdle")]
	public UAnimSequence AnimIdle
	{
		get
		{
			CheckDestroyed();
			if (!AnimIdle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:AnimIdle");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, AnimIdle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimIdle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:AnimIdle");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, AnimIdle_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Common")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:BSRunFwd")]
	public UBlendSpace BSRunFwd
	{
		get
		{
			CheckDestroyed();
			if (!BSRunFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:BSRunFwd");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSRunFwd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSRunFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:BSRunFwd");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSRunFwd_Offset), value);
			}
		}
	}

	public void OnEntityInitFinish()
	{
		AttachEvent();
	}

	public void OnEntityEndPlay(EEndPlayReason EndPlayReason)
	{
		UnAttachEvent();
	}

	protected override void OnInitABPSetting()
	{
		if (!this.IsNullOrDestroyed())
		{
			BUABPSettingData aBPSettingData = TopAnimInst.ABPSettingData;
			if (aBPSettingData != null && aBPSettingData.CommonSetting.ABPMoveMode == EABPMoveMode.MotionMatching)
			{
				BUABPMotionMatchingSettingData motionMatchingSetting = aBPSettingData.MotionMatchingSetting;
				RotateAdditiveBS = motionMatchingSetting.RotateAdditiveBS;
				bNeedFixMM = motionMatchingSetting.bNeedFixMM;
				MMAdditivePose = motionMatchingSetting.MMAdditivePose;
				MMAdditiveWeight = motionMatchingSetting.MMAdditiveWeight;
				bFixMMWeapon_MeshSpaceRotation = motionMatchingSetting.bFixMMWeapon_MeshSpaceRotation;
				bFixMMAdditive_MeshSpaceRotation = motionMatchingSetting.bFixMMAdditive_MeshSpaceRotation;
				MMAdditiveLayerSetup.SetValues(motionMatchingSetting.MMAdditiveLayerSetup);
				MMToIdleSpeed = motionMatchingSetting.ToIdleAnimSpeed;
				bMMtoIdle = true;
				bIdleToMM = false;
				InitData();
			}
		}
	}

	protected override void LinkedGraphInitializeAnimation()
	{
		if (TopAnimInst != null && TopAnimInst.ABPSettingData != null)
		{
			AnimIdle = TopAnimInst.ABPSettingData.CommonSetting.AnimSeqIdle;
		}
		CommonData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_ABPCommonSettingData, BUC_ABPCommonSettingData>(Owner);
		if (CommonData != null)
		{
			AnimIdle = CommonData.AnimIdle;
		}
	}

	protected override void LinkedGraphThreadUpdateAnimation(float DeltaTimeX)
	{
		UpdateData();
	}

	private void InitBUCData()
	{
		if (!(Owner == null) && ECSExtension.IsECSActor(Owner))
		{
			MMData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPMotionMatchingData, BUC_ABPMotionMatchingData>(Owner);
			BasicData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_ABPBasicData, BUC_ABPBasicData>(Owner);
			CommonData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_ABPCommonSettingData, BUC_ABPCommonSettingData>(Owner);
			ChrData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPCharacterData, BUC_ABPCharacterData>(Owner);
		}
	}

	private void InitData()
	{
		InitBUCData();
		if (MMData != null)
		{
			MotionMatchingState = MMData.MotionMatchingStateForABP;
			RotatorforMM = MMData.RotatorforMM;
			SpareMoveMode = MMData.SpareMoveMode;
			CurrentAA = MMData.CurrentAA;
			AnimationAnalyzerBlendTime = MMData.AnimationAnalyzerBlendTime;
			MotionBlendTime = MMData.MotionBlendTime;
			MMPlayRate = MMData.MMPlayRate;
			ForceSetRotAnimSpeed = MMData.ForceSetRotAnimSpeed;
			DisableRotVerifyAnimSpeed = MMData.DisableRotVerifyAnimSpeed;
			bRecordMMAnimData = MMData.bRecordMMAnimData;
			bDisableLocomotionIdle = MMData.bDisableLocomotionIdle;
			bForceMMToIdle = MMData.bForceMMToIdle;
			MMUpBodyStateAlpha = MMData.MMUpBodyStateAlpha;
		}
		if (BasicData != null)
		{
			Speed = BasicData.Speed;
		}
		if (CommonData != null)
		{
			AnimIdle = CommonData.AnimIdle;
			BSRunFwd = CommonData.BSRunFwd;
		}
	}

	private void UpdateData()
	{
		bDisableMMRootMotion = true;
		if (CommonData != null && CommonData.FinalABPMoveMode == EABPMoveMode.MotionMatching)
		{
			bDisableMMRootMotion = false;
			if (CommonData != null)
			{
				AnimIdle = CommonData.AnimIdle;
			}
			if (MMData != null)
			{
				CurrentAA = MMData.CurrentAA;
				MotionMatchingState = MMData.MotionMatchingStateForABP;
				RotatorforMM = MMData.RotatorforMM;
				MMPlayRate = MMData.MMPlayRate;
				bRecordMMAnimData = MMData.bRecordMMAnimData;
				bDisableLocomotionIdle = MMData.bDisableLocomotionIdle;
				bForceMMToIdle = MMData.bForceMMToIdle;
				RotateBSX = MMData.RotateBSX;
				MMTransAnim = MMData.MMTransAnim;
				MMTransAnimStartPos = MMData.MMTransAnimStartPos;
				MMTransAlpha = MMData.MMTransAlpha;
				bMMTransFinish = MMData.bMMTransFinish;
				bMMTransStart = MMData.bMMTransStart;
				bKeepMMInputUnchanged = MMData.bKeepMMInputUnchanged;
				bUseLMAnim = MMData.bUseLMAnim;
				InputDesiredTransform = MMData.MMInputDesiredTransform;
				InputRootTransform = MMData.MMInputRootTransform;
				InputStrength = MMData.MMInputStrength;
			}
			if (BasicData != null)
			{
				Speed = BasicData.Speed;
			}
			bool flag = InputDesiredTransform.GetRelativeTransform(InputRootTransform).GetLocation().Size() > 0.1f;
			bool flag2 = MotionMatchingState == EState_MM.None || bForceMMToIdle;
			bMMtoIdle = (!flag && Speed <= MMToIdleSpeed && !bDisableLocomotionIdle) || flag2;
			bIdleToMM = (flag || Speed > 100f || bDisableLocomotionIdle) && !flag2;
		}
	}

	[UFunction]
	[BlueprintCallable]
	[Category("Thread Safe")]
	[UMeta(MDClass.BlueprintThreadSafe)]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:SetupDefaultMMPoseData")]
	private void SetupDefaultMMPoseData(ref FAnimUpdateContext Context, ref FAnimNodeReference Node)
	{
		MMData.GetDefaultLocalMotionJointData(Owner, out var JointLocation, out var JointVelocity);
		DefaultJointData = new FDefaultMotionJointData
		{
			JointLocation = JointLocation,
			JointVelocity = JointVelocity
		};
		if (ChrData != null)
		{
			DefaultVelocity = ChrData.LastVelocity;
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:SetupDefaultMMPoseData")]
	private static void SetupDefaultMMPoseData__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_MotionMatching bUAnimHumanoidCS_MotionMatching = GCHelper.Find<BUAnimHumanoidCS_MotionMatching>(obj);
		FAnimUpdateContext Context = StructAsClassMarshaler<FAnimUpdateContext>.FromNative(IntPtr.Add(buffer, SetupDefaultMMPoseData_Context_Offset));
		FAnimNodeReference Node = StructAsClassMarshaler<FAnimNodeReference>.FromNative(IntPtr.Add(buffer, SetupDefaultMMPoseData_Node_Offset));
		bUAnimHumanoidCS_MotionMatching.SetupDefaultMMPoseData(ref Context, ref Node);
		StructAsClassMarshaler<FAnimUpdateContext>.ToNative(IntPtr.Add(buffer, SetupDefaultMMPoseData_Context_Offset), Context);
		StructAsClassMarshaler<FAnimNodeReference>.ToNative(IntPtr.Add(buffer, SetupDefaultMMPoseData_Node_Offset), Node);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching");
		InputDesiredTransform_Offset = NativeReflection.GetPropertyOffset(intPtr, "InputDesiredTransform");
		InputDesiredTransform_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InputDesiredTransform", Classes.FStructProperty);
		InputRootTransform_Offset = NativeReflection.GetPropertyOffset(intPtr, "InputRootTransform");
		InputRootTransform_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InputRootTransform", Classes.FStructProperty);
		InputStrength_Offset = NativeReflection.GetPropertyOffset(intPtr, "InputStrength");
		InputStrength_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InputStrength", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref MotionMatchingState_PropertyAddress, intPtr, "MotionMatchingState");
		MotionMatchingState_Offset = NativeReflection.GetPropertyOffset(intPtr, "MotionMatchingState");
		MotionMatchingState_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MotionMatchingState", Classes.FEnumProperty);
		RotatorforMM_Offset = NativeReflection.GetPropertyOffset(intPtr, "RotatorforMM");
		RotatorforMM_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RotatorforMM", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref UseMotionMatching_PropertyAddress, intPtr, "UseMotionMatching");
		UseMotionMatching_Offset = NativeReflection.GetPropertyOffset(intPtr, "UseMotionMatching");
		UseMotionMatching_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UseMotionMatching", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref SpareMoveMode_PropertyAddress, intPtr, "SpareMoveMode");
		SpareMoveMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpareMoveMode");
		SpareMoveMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpareMoveMode", Classes.FEnumProperty);
		CurrentAA_Offset = NativeReflection.GetPropertyOffset(intPtr, "CurrentAA");
		CurrentAA_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CurrentAA", Classes.FObjectProperty);
		AnimationAnalyzerBlendTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimationAnalyzerBlendTime");
		AnimationAnalyzerBlendTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimationAnalyzerBlendTime", Classes.FFloatProperty);
		MotionBlendTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "MotionBlendTime");
		MotionBlendTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MotionBlendTime", Classes.FFloatProperty);
		MMPlayRate_Offset = NativeReflection.GetPropertyOffset(intPtr, "MMPlayRate");
		MMPlayRate_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MMPlayRate", Classes.FFloatProperty);
		ForceSetRotAnimSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "ForceSetRotAnimSpeed");
		ForceSetRotAnimSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ForceSetRotAnimSpeed", Classes.FFloatProperty);
		DisableRotVerifyAnimSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "DisableRotVerifyAnimSpeed");
		DisableRotVerifyAnimSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DisableRotVerifyAnimSpeed", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bRecordMMAnimData_PropertyAddress, intPtr, "bRecordMMAnimData");
		bRecordMMAnimData_Offset = NativeReflection.GetPropertyOffset(intPtr, "bRecordMMAnimData");
		bRecordMMAnimData_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bRecordMMAnimData", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bDisableLocomotionIdle_PropertyAddress, intPtr, "bDisableLocomotionIdle");
		bDisableLocomotionIdle_Offset = NativeReflection.GetPropertyOffset(intPtr, "bDisableLocomotionIdle");
		bDisableLocomotionIdle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bDisableLocomotionIdle", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bForceMMToIdle_PropertyAddress, intPtr, "bForceMMToIdle");
		bForceMMToIdle_Offset = NativeReflection.GetPropertyOffset(intPtr, "bForceMMToIdle");
		bForceMMToIdle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bForceMMToIdle", Classes.FBoolProperty);
		MMUpBodyStateAlpha_Offset = NativeReflection.GetPropertyOffset(intPtr, "MMUpBodyStateAlpha");
		MMUpBodyStateAlpha_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MMUpBodyStateAlpha", Classes.FFloatProperty);
		RotateAdditiveBS_Offset = NativeReflection.GetPropertyOffset(intPtr, "RotateAdditiveBS");
		RotateAdditiveBS_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RotateAdditiveBS", Classes.FObjectProperty);
		RotateBSX_Offset = NativeReflection.GetPropertyOffset(intPtr, "RotateBSX");
		RotateBSX_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RotateBSX", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bMMtoIdle_PropertyAddress, intPtr, "bMMtoIdle");
		bMMtoIdle_Offset = NativeReflection.GetPropertyOffset(intPtr, "bMMtoIdle");
		bMMtoIdle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bMMtoIdle", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bIdleToMM_PropertyAddress, intPtr, "bIdleToMM");
		bIdleToMM_Offset = NativeReflection.GetPropertyOffset(intPtr, "bIdleToMM");
		bIdleToMM_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bIdleToMM", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bNeedFixMM_PropertyAddress, intPtr, "bNeedFixMM");
		bNeedFixMM_Offset = NativeReflection.GetPropertyOffset(intPtr, "bNeedFixMM");
		bNeedFixMM_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bNeedFixMM", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bFixMMWeapon_MeshSpaceRotation_PropertyAddress, intPtr, "bFixMMWeapon_MeshSpaceRotation");
		bFixMMWeapon_MeshSpaceRotation_Offset = NativeReflection.GetPropertyOffset(intPtr, "bFixMMWeapon_MeshSpaceRotation");
		bFixMMWeapon_MeshSpaceRotation_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bFixMMWeapon_MeshSpaceRotation", Classes.FBoolProperty);
		MMAdditivePose_Offset = NativeReflection.GetPropertyOffset(intPtr, "MMAdditivePose");
		MMAdditivePose_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MMAdditivePose", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref bFixMMAdditive_MeshSpaceRotation_PropertyAddress, intPtr, "bFixMMAdditive_MeshSpaceRotation");
		bFixMMAdditive_MeshSpaceRotation_Offset = NativeReflection.GetPropertyOffset(intPtr, "bFixMMAdditive_MeshSpaceRotation");
		bFixMMAdditive_MeshSpaceRotation_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bFixMMAdditive_MeshSpaceRotation", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref MMAdditiveLayerSetup_PropertyAddress, intPtr, "MMAdditiveLayerSetup");
		MMAdditiveLayerSetup_Offset = NativeReflection.GetPropertyOffset(intPtr, "MMAdditiveLayerSetup");
		MMAdditiveLayerSetup_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MMAdditiveLayerSetup", Classes.FArrayProperty);
		MMAdditiveWeight_Offset = NativeReflection.GetPropertyOffset(intPtr, "MMAdditiveWeight");
		MMAdditiveWeight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MMAdditiveWeight", Classes.FFloatProperty);
		MMTransAnim_Offset = NativeReflection.GetPropertyOffset(intPtr, "MMTransAnim");
		MMTransAnim_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MMTransAnim", Classes.FObjectProperty);
		MMTransAnimStartPos_Offset = NativeReflection.GetPropertyOffset(intPtr, "MMTransAnimStartPos");
		MMTransAnimStartPos_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MMTransAnimStartPos", Classes.FFloatProperty);
		MMTransAlpha_Offset = NativeReflection.GetPropertyOffset(intPtr, "MMTransAlpha");
		MMTransAlpha_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MMTransAlpha", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bMMTransFinish_PropertyAddress, intPtr, "bMMTransFinish");
		bMMTransFinish_Offset = NativeReflection.GetPropertyOffset(intPtr, "bMMTransFinish");
		bMMTransFinish_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bMMTransFinish", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bMMTransStart_PropertyAddress, intPtr, "bMMTransStart");
		bMMTransStart_Offset = NativeReflection.GetPropertyOffset(intPtr, "bMMTransStart");
		bMMTransStart_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bMMTransStart", Classes.FBoolProperty);
		DefaultJointData_Offset = NativeReflection.GetPropertyOffset(intPtr, "DefaultJointData");
		DefaultJointData_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DefaultJointData", Classes.FStructProperty);
		DefaultVelocity_Offset = NativeReflection.GetPropertyOffset(intPtr, "DefaultVelocity");
		DefaultVelocity_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DefaultVelocity", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref bKeepMMInputUnchanged_PropertyAddress, intPtr, "bKeepMMInputUnchanged");
		bKeepMMInputUnchanged_Offset = NativeReflection.GetPropertyOffset(intPtr, "bKeepMMInputUnchanged");
		bKeepMMInputUnchanged_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bKeepMMInputUnchanged", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bUseLMAnim_PropertyAddress, intPtr, "bUseLMAnim");
		bUseLMAnim_Offset = NativeReflection.GetPropertyOffset(intPtr, "bUseLMAnim");
		bUseLMAnim_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bUseLMAnim", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bDisableMMRootMotion_PropertyAddress, intPtr, "bDisableMMRootMotion");
		bDisableMMRootMotion_Offset = NativeReflection.GetPropertyOffset(intPtr, "bDisableMMRootMotion");
		bDisableMMRootMotion_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bDisableMMRootMotion", Classes.FBoolProperty);
		Speed_Offset = NativeReflection.GetPropertyOffset(intPtr, "Speed");
		Speed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Speed", Classes.FFloatProperty);
		AnimIdle_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimIdle");
		AnimIdle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimIdle", Classes.FObjectProperty);
		BSRunFwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSRunFwd");
		BSRunFwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSRunFwd", Classes.FObjectProperty);
		SetupDefaultMMPoseData_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetupDefaultMMPoseData");
		SetupDefaultMMPoseData_ParamsSize = NativeReflection.GetFunctionParamsSize(SetupDefaultMMPoseData_FunctionAddress);
		NativeReflection.GetPropertyRef(ref SetupDefaultMMPoseData_Context_PropertyAddress, SetupDefaultMMPoseData_FunctionAddress, "Context");
		SetupDefaultMMPoseData_Context_Offset = NativeReflection.GetPropertyOffset(SetupDefaultMMPoseData_FunctionAddress, "Context");
		SetupDefaultMMPoseData_Context_IsValid = NativeReflection.ValidatePropertyClass(SetupDefaultMMPoseData_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref SetupDefaultMMPoseData_Node_PropertyAddress, SetupDefaultMMPoseData_FunctionAddress, "Node");
		SetupDefaultMMPoseData_Node_Offset = NativeReflection.GetPropertyOffset(SetupDefaultMMPoseData_FunctionAddress, "Node");
		SetupDefaultMMPoseData_Node_IsValid = NativeReflection.ValidatePropertyClass(SetupDefaultMMPoseData_FunctionAddress, "Node", Classes.FStructProperty);
		SetupDefaultMMPoseData_IsValid = SetupDefaultMMPoseData_FunctionAddress != IntPtr.Zero && SetupDefaultMMPoseData_Context_IsValid && SetupDefaultMMPoseData_Node_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_MotionMatching:SetupDefaultMMPoseData", SetupDefaultMMPoseData_IsValid);
	}

	static BUAnimHumanoidCS_MotionMatching()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUAnimHumanoidCS_MotionMatching)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUAnimHumanoidCS_MotionMatching));
	}
}
