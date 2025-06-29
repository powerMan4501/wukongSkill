using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.BGU.BUAnim;

[UClass]
[BlueprintType]
[Blueprintable]
[USharpPath("/Script/b1-Managed.BUAnimQuadruped")]
public class BUAnimQuadruped : BUAnimInstanceBase
{
	private IBUC_ABPCommonSettingData CommonData;

	private IBUC_ABPFootIKData FootIKData;

	private IBUC_ABPHelperData ABPHelperData;

	private AActor Owner;

	private static bool AnimIdle_IsValid;

	private static int AnimIdle_Offset;

	private static bool FinalABPMoveMode_IsValid;

	private static int FinalABPMoveMode_Offset;

	private static FFieldAddress FinalABPMoveMode_PropertyAddress;

	private static bool QuadrupedIKAlpha_IsValid;

	private static int QuadrupedIKAlpha_Offset;

	private static bool BlueprintThreadSafeUpdateAnimation_IsValid;

	private static IntPtr BlueprintThreadSafeUpdateAnimation_FunctionAddress;

	private static int BlueprintThreadSafeUpdateAnimation_ParamsSize;

	private static bool BlueprintThreadSafeUpdateAnimation_DeltaTime_IsValid;

	private static int BlueprintThreadSafeUpdateAnimation_DeltaTime_Offset;

	[UProperty]
	[BlueprintReadOnly]
	[Category("Move")]
	[USharpPath("/Script/b1-Managed.BUAnimQuadruped:AnimIdle")]
	public UAnimSequence AnimIdle
	{
		get
		{
			CheckDestroyed();
			if (!AnimIdle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimQuadruped:AnimIdle");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, AnimIdle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimIdle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimQuadruped:AnimIdle");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, AnimIdle_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Move")]
	[USharpPath("/Script/b1-Managed.BUAnimQuadruped:FinalABPMoveMode")]
	public EABPMoveMode FinalABPMoveMode
	{
		get
		{
			CheckDestroyed();
			if (!FinalABPMoveMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimQuadruped:FinalABPMoveMode");
				return EABPMoveMode.None;
			}
			return EnumMarshaler<EABPMoveMode>.FromNative(IntPtr.Add(base.Address, FinalABPMoveMode_Offset), 0, FinalABPMoveMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!FinalABPMoveMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimQuadruped:FinalABPMoveMode");
			}
			else
			{
				EnumMarshaler<EABPMoveMode>.ToNative(IntPtr.Add(base.Address, FinalABPMoveMode_Offset), 0, FinalABPMoveMode_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("IK")]
	[USharpPath("/Script/b1-Managed.BUAnimQuadruped:QuadrupedIKAlpha")]
	public float QuadrupedIKAlpha
	{
		get
		{
			CheckDestroyed();
			if (!QuadrupedIKAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimQuadruped:QuadrupedIKAlpha");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, QuadrupedIKAlpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!QuadrupedIKAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimQuadruped:QuadrupedIKAlpha");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, QuadrupedIKAlpha_Offset), value);
			}
		}
	}

	protected override void BlueprintInitializeAnimationImpl()
	{
		base.BlueprintInitializeAnimationImpl();
		Owner = GetOwningActor();
		if (base.ABPSettingData != null)
		{
			AnimIdle = base.ABPSettingData.CommonSetting.AnimSeqIdle;
		}
		InitNeededLinkedInstance();
	}

	private void InitNeededLinkedInstance()
	{
		BUAnimHumanoidCS_Move bUAnimHumanoidCS_Move = GetLinkedAnimGraphInstanceByTag(B1GlobalFNames.Move) as BUAnimHumanoidCS_Move;
		if (!(bUAnimHumanoidCS_Move == null))
		{
			b1.BGU.BUAnim.AbpHelperUtil.InitABPMoveModeAnimInstance(bUAnimHumanoidCS_Move, EABPMoveMode.QuadrupedLocomotion);
		}
	}

	[USharpPath("/Script/b1-Managed.BUAnimQuadruped:BlueprintThreadSafeUpdateAnimation")]
	protected override void BlueprintThreadSafeUpdateAnimation_Implementation(float DeltaTime)
	{
		UpdateData(DeltaTime);
	}

	private void InitBUCData()
	{
		if (ECSExtension.IsECSActor(Owner))
		{
			CommonData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPCommonSettingData, BUC_ABPCommonSettingData>(Owner);
			FootIKData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPFootIKData, BUC_ABPFootIKData>(Owner);
			ABPHelperData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPHelperData, BUC_ABPHelperData>(Owner);
		}
	}

	protected override void OnInitABPSetting()
	{
		base.OnInitABPSetting();
		if (base.ABPSettingData != null)
		{
			InitData();
		}
	}

	protected override void AttachEvent()
	{
		base.AttachEvent();
		BUAnimHumanoidCS_QuadrupedLocomotion bUAnimHumanoidCS_QuadrupedLocomotion = GetLinkedAnimGraphInstanceByTag(B1GlobalFNames.QuadrupedLocomotion) as BUAnimHumanoidCS_QuadrupedLocomotion;
		if (bUAnimHumanoidCS_QuadrupedLocomotion != null)
		{
			bUAnimHumanoidCS_QuadrupedLocomotion.AttachEvent();
		}
		BUAnimHumanoidCS_QuadrupedIK bUAnimHumanoidCS_QuadrupedIK = GetLinkedAnimGraphInstanceByTag(B1GlobalFNames.QuadrupedIK) as BUAnimHumanoidCS_QuadrupedIK;
		if (bUAnimHumanoidCS_QuadrupedIK != null)
		{
			bUAnimHumanoidCS_QuadrupedIK.AttachEvent();
		}
	}

	protected override void UnAttachEvent()
	{
		base.UnAttachEvent();
		BUAnimHumanoidCS_QuadrupedLocomotion bUAnimHumanoidCS_QuadrupedLocomotion = GetLinkedAnimGraphInstanceByTag(B1GlobalFNames.QuadrupedLocomotion) as BUAnimHumanoidCS_QuadrupedLocomotion;
		if (bUAnimHumanoidCS_QuadrupedLocomotion != null)
		{
			bUAnimHumanoidCS_QuadrupedLocomotion.UnAttachEvent();
		}
		BUAnimHumanoidCS_QuadrupedIK bUAnimHumanoidCS_QuadrupedIK = GetLinkedAnimGraphInstanceByTag(B1GlobalFNames.QuadrupedIK) as BUAnimHumanoidCS_QuadrupedIK;
		if (bUAnimHumanoidCS_QuadrupedIK != null)
		{
			bUAnimHumanoidCS_QuadrupedIK.UnAttachEvent();
		}
	}

	public void InitData()
	{
		InitBUCData();
		if (CommonData != null)
		{
			FinalABPMoveMode = CommonData.FinalABPMoveMode;
		}
	}

	private void UpdateData(float DeltaTimeX)
	{
		if (CommonData != null)
		{
			FinalABPMoveMode = CommonData.FinalABPMoveMode;
		}
		if (FootIKData != null)
		{
			FootIKData.ThreadSafeUpdateAnimation(Owner, DeltaTimeX);
			QuadrupedIKAlpha = ((FootIKData.bActiveFootIK && FootIKData.bActiveForefootIK) ? 1f : 0f);
		}
		if (ABPHelperData != null)
		{
			ABPHelperData.GetFloatAnimCurveValue(in B1GlobalFNames.FootIKMaskValue, out var OutCurveValue);
			QuadrupedIKAlpha = FMath.Clamp(QuadrupedIKAlpha * (1f - OutCurveValue), 0f, 1f);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimQuadruped:BlueprintThreadSafeUpdateAnimation")]
	private static void BlueprintThreadSafeUpdateAnimation__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimQuadruped bUAnimQuadruped = GCHelper.Find<BUAnimQuadruped>(obj);
		float deltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BlueprintThreadSafeUpdateAnimation_DeltaTime_Offset));
		bUAnimQuadruped.BlueprintThreadSafeUpdateAnimation_Implementation(deltaTime);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUAnimQuadruped");
		AnimIdle_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimIdle");
		AnimIdle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimIdle", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref FinalABPMoveMode_PropertyAddress, intPtr, "FinalABPMoveMode");
		FinalABPMoveMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "FinalABPMoveMode");
		FinalABPMoveMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FinalABPMoveMode", Classes.FEnumProperty);
		QuadrupedIKAlpha_Offset = NativeReflection.GetPropertyOffset(intPtr, "QuadrupedIKAlpha");
		QuadrupedIKAlpha_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "QuadrupedIKAlpha", Classes.FFloatProperty);
		BlueprintThreadSafeUpdateAnimation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BlueprintThreadSafeUpdateAnimation");
		BlueprintThreadSafeUpdateAnimation_ParamsSize = NativeReflection.GetFunctionParamsSize(BlueprintThreadSafeUpdateAnimation_FunctionAddress);
		BlueprintThreadSafeUpdateAnimation_DeltaTime_Offset = NativeReflection.GetPropertyOffset(BlueprintThreadSafeUpdateAnimation_FunctionAddress, "DeltaTime");
		BlueprintThreadSafeUpdateAnimation_DeltaTime_IsValid = NativeReflection.ValidatePropertyClass(BlueprintThreadSafeUpdateAnimation_FunctionAddress, "DeltaTime", Classes.FFloatProperty);
		BlueprintThreadSafeUpdateAnimation_IsValid = BlueprintThreadSafeUpdateAnimation_FunctionAddress != IntPtr.Zero && BlueprintThreadSafeUpdateAnimation_DeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimQuadruped:BlueprintThreadSafeUpdateAnimation", BlueprintThreadSafeUpdateAnimation_IsValid);
	}

	static BUAnimQuadruped()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUAnimQuadruped)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUAnimQuadruped));
	}
}
