using System;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.IKRig;
using UnrealEngine.Runtime;

namespace b1.BGU.BUAnim;

[Blueprintable]
[Abstract]
[UClass]
[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MMRetarget")]
public class BUAnimHumanoidCS_MMRetarget : BUAnimHumanoidCS_LinkedInstanceBase
{
	private static bool bCanRetarget_IsValid;

	private static int bCanRetarget_Offset;

	private static FFieldAddress bCanRetarget_PropertyAddress;

	private static bool RetargetSrcMesh_IsValid;

	private static int RetargetSrcMesh_Offset;

	private static bool BasePose_IsValid;

	private static int BasePose_Offset;

	private static bool bNeedFixMM_IsValid;

	private static int bNeedFixMM_Offset;

	private static FFieldAddress bNeedFixMM_PropertyAddress;

	private static bool MMAdditiveWeight_IsValid;

	private static int MMAdditiveWeight_Offset;

	private static bool MMAdditivePose_IsValid;

	private static int MMAdditivePose_Offset;

	private static bool Retargeter_IsValid;

	private static int Retargeter_Offset;

	private static bool MMRetarget_PelvisOffsetZ_IsValid;

	private static int MMRetarget_PelvisOffsetZ_Offset;

	private static bool MMRetarget_FootOffsetScale_IsValid;

	private static int MMRetarget_FootOffsetScale_Offset;

	[Category("MotionMatchingRetarget")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MMRetarget:bCanRetarget")]
	public bool bCanRetarget
	{
		get
		{
			CheckDestroyed();
			if (!bCanRetarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MMRetarget:bCanRetarget");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bCanRetarget_Offset), 0, bCanRetarget_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bCanRetarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MMRetarget:bCanRetarget");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bCanRetarget_Offset), 0, bCanRetarget_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("MotionMatchingRetarget")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MMRetarget:RetargetSrcMesh")]
	public USkeletalMeshComponent RetargetSrcMesh
	{
		get
		{
			CheckDestroyed();
			if (!RetargetSrcMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MMRetarget:RetargetSrcMesh");
				return null;
			}
			return UObjectMarshaler<USkeletalMeshComponent>.FromNative(IntPtr.Add(base.Address, RetargetSrcMesh_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RetargetSrcMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MMRetarget:RetargetSrcMesh");
			}
			else
			{
				UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(base.Address, RetargetSrcMesh_Offset), value);
			}
		}
	}

	[Category("MotionMatchingRetarget")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MMRetarget:BasePose")]
	public UAnimSequence BasePose
	{
		get
		{
			CheckDestroyed();
			if (!BasePose_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MMRetarget:BasePose");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, BasePose_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BasePose_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MMRetarget:BasePose");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, BasePose_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("MotionMatching")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MMRetarget:bNeedFixMM")]
	public bool bNeedFixMM
	{
		get
		{
			CheckDestroyed();
			if (!bNeedFixMM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MMRetarget:bNeedFixMM");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bNeedFixMM_Offset), 0, bNeedFixMM_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bNeedFixMM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MMRetarget:bNeedFixMM");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bNeedFixMM_Offset), 0, bNeedFixMM_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[Category("MotionMatchingRetarget")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MMRetarget:MMAdditiveWeight")]
	public float MMAdditiveWeight
	{
		get
		{
			CheckDestroyed();
			if (!MMAdditiveWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MMRetarget:MMAdditiveWeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MMAdditiveWeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MMAdditiveWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MMRetarget:MMAdditiveWeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MMAdditiveWeight_Offset), value);
			}
		}
	}

	[Category("MotionMatchingRetarget")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MMRetarget:MMAdditivePose")]
	public UAnimSequence MMAdditivePose
	{
		get
		{
			CheckDestroyed();
			if (!MMAdditivePose_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MMRetarget:MMAdditivePose");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, MMAdditivePose_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MMAdditivePose_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MMRetarget:MMAdditivePose");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, MMAdditivePose_Offset), value);
			}
		}
	}

	[Category("MotionMatchingRetarget")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MMRetarget:Retargeter")]
	public UIKRetargeter Retargeter
	{
		get
		{
			CheckDestroyed();
			if (!Retargeter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MMRetarget:Retargeter");
				return null;
			}
			return UObjectMarshaler<UIKRetargeter>.FromNative(IntPtr.Add(base.Address, Retargeter_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Retargeter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MMRetarget:Retargeter");
			}
			else
			{
				UObjectMarshaler<UIKRetargeter>.ToNative(IntPtr.Add(base.Address, Retargeter_Offset), value);
			}
		}
	}

	[Category("MotionMatchingRetarget")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MMRetarget:MMRetarget_PelvisOffsetZ")]
	public float MMRetarget_PelvisOffsetZ
	{
		get
		{
			CheckDestroyed();
			if (!MMRetarget_PelvisOffsetZ_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MMRetarget:MMRetarget_PelvisOffsetZ");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MMRetarget_PelvisOffsetZ_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MMRetarget_PelvisOffsetZ_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MMRetarget:MMRetarget_PelvisOffsetZ");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MMRetarget_PelvisOffsetZ_Offset), value);
			}
		}
	}

	[Category("MotionMatchingRetarget")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MMRetarget:MMRetarget_FootOffsetScale")]
	public float MMRetarget_FootOffsetScale
	{
		get
		{
			CheckDestroyed();
			if (!MMRetarget_FootOffsetScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MMRetarget:MMRetarget_FootOffsetScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MMRetarget_FootOffsetScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MMRetarget_FootOffsetScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MMRetarget:MMRetarget_FootOffsetScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MMRetarget_FootOffsetScale_Offset), value);
			}
		}
	}

	protected override void OnInitABPSetting()
	{
		if (this.IsNullOrDestroyed())
		{
			return;
		}
		BUABPSettingData aBPSettingData = TopAnimInst.ABPSettingData;
		if (aBPSettingData != null)
		{
			RetargetSrcMesh = null;
			bCanRetarget = RetargetSrcMesh != null && RetargetSrcMesh.SkeletalMesh != null;
			if (bCanRetarget)
			{
				BUABPMotionMatchingSettingData motionMatchingSetting = aBPSettingData.MotionMatchingSetting;
				BasePose = aBPSettingData.CommonSetting.AnimSeqIdle;
				Retargeter = motionMatchingSetting.Retargeter;
				MMAdditiveWeight = motionMatchingSetting.MMAdditiveWeight;
				MMAdditivePose = motionMatchingSetting.MMAdditivePose;
				bNeedFixMM = motionMatchingSetting.bNeedFixMM;
				MMRetarget_PelvisOffsetZ = motionMatchingSetting.PelvisOffsetZ;
				MMRetarget_FootOffsetScale = motionMatchingSetting.FootOffsetScale;
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUAnimHumanoidCS_MMRetarget");
		NativeReflection.GetPropertyRef(ref bCanRetarget_PropertyAddress, unrealStruct, "bCanRetarget");
		bCanRetarget_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bCanRetarget");
		bCanRetarget_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bCanRetarget", Classes.FBoolProperty);
		RetargetSrcMesh_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RetargetSrcMesh");
		RetargetSrcMesh_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RetargetSrcMesh", Classes.FObjectProperty);
		BasePose_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BasePose");
		BasePose_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BasePose", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref bNeedFixMM_PropertyAddress, unrealStruct, "bNeedFixMM");
		bNeedFixMM_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bNeedFixMM");
		bNeedFixMM_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bNeedFixMM", Classes.FBoolProperty);
		MMAdditiveWeight_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MMAdditiveWeight");
		MMAdditiveWeight_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MMAdditiveWeight", Classes.FFloatProperty);
		MMAdditivePose_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MMAdditivePose");
		MMAdditivePose_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MMAdditivePose", Classes.FObjectProperty);
		Retargeter_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Retargeter");
		Retargeter_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Retargeter", Classes.FObjectProperty);
		MMRetarget_PelvisOffsetZ_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MMRetarget_PelvisOffsetZ");
		MMRetarget_PelvisOffsetZ_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MMRetarget_PelvisOffsetZ", Classes.FFloatProperty);
		MMRetarget_FootOffsetScale_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MMRetarget_FootOffsetScale");
		MMRetarget_FootOffsetScale_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MMRetarget_FootOffsetScale", Classes.FFloatProperty);
	}

	static BUAnimHumanoidCS_MMRetarget()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUAnimHumanoidCS_MMRetarget)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUAnimHumanoidCS_MMRetarget));
	}
}
