using System;
using System.Collections.Generic;
using b1.BGU.BUAnim;
using b1.Plugins.GSEngineExtent;
using b1.Plugins.MM;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.IKRig;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_MotionMatching")]
public struct FAnimHumanoidSetting_MotionMatching
{
	[UProperty]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_MotionMatching:Walk2RunAA")]
	public UAnimationAnalyzer Walk2RunAA;

	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_MotionMatching:bMMLockUseFreeMode")]
	public bool bMMLockUseFreeMode;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_MotionMatching:RotateAdditiveBS")]
	public UBlendSpace RotateAdditiveBS;

	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_MotionMatching:MMUpBodyStateAlpha")]
	public float MMUpBodyStateAlpha;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_MotionMatching:DefaultMMState")]
	public EState_MM DefaultMMState;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[Tooltip("If current MotionMatching state has no AA, use this MoveMode")]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_MotionMatching:SpareMoveMode")]
	public EABPMoveMode SpareMoveMode;

	public Dictionary<EState_MM, UAnimationAnalyzer> MMState2AA;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_MotionMatching:MMState2AACS")]
	public Dictionary<EState_MM, BUAnimationAnalyzer> MMState2AACS;

	[UProperty]
	[EditAnywhere]
	[Tooltip("Blend time between different Animation Analyzer")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_MotionMatching:AnimationAnalyzerBlendTime")]
	public float AnimationAnalyzerBlendTime;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[Tooltip("Blend time between different animation in same Animation Analyzer")]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_MotionMatching:MotionBlendTime")]
	public float MotionBlendTime;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_MotionMatching:Retargeter")]
	public UIKRetargeter Retargeter;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_MotionMatching:PelvisOffsetZ")]
	public float PelvisOffsetZ;

	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_MotionMatching:FootOffsetScale")]
	public float FootOffsetScale;

	[UProperty]
	[BlueprintReadOnly]
	[DisplayName("程序插值转向速度阈值")]
	[Tooltip("超过此速度使用程序转向，否则使用动画RootMotion转向")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_MotionMatching:ForceSetRotAnimSpeed")]
	public float ForceSetRotAnimSpeed;

	[EditAnywhere]
	[BlueprintReadOnly]
	[DisplayName("禁用旋转矫正速度阈值")]
	[Tooltip("低于此速度时禁用MM的旋转矫正，防止原地慢慢转向")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_MotionMatching:DisableRotVerifyAnimSpeed")]
	public float DisableRotVerifyAnimSpeed;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[Tooltip("低于此速度时切回待机动画")]
	[DisplayName("回待机速度阈值")]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_MotionMatching:ToIdleAnimSpeed")]
	public float ToIdleAnimSpeed;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_MotionMatching:bNeedFixMM")]
	public bool bNeedFixMM;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_MotionMatching:MMAdditivePose")]
	public UAnimSequence MMAdditivePose;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_MotionMatching:MMAdditiveWeight")]
	public float MMAdditiveWeight;

	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_MotionMatching:bFixMMWeapon_MeshSpaceRotation")]
	public bool bFixMMWeapon_MeshSpaceRotation;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_MotionMatching:bFixMMAdditive_MeshSpaceRotation")]
	public bool bFixMMAdditive_MeshSpaceRotation;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_MotionMatching:MMAdditiveLayerSetup")]
	public List<FGSInputBlendPose> MMAdditiveLayerSetup;

	private static int AnimHumanoidSetting_MotionMatching_StructSize;

	private static int AnimHumanoidSetting_MotionMatching_IsValid;

	private static bool Walk2RunAA_IsValid;

	private static int Walk2RunAA_Offset;

	private static bool bMMLockUseFreeMode_IsValid;

	private static int bMMLockUseFreeMode_Offset;

	private static FFieldAddress bMMLockUseFreeMode_PropertyAddress;

	private static bool RotateAdditiveBS_IsValid;

	private static int RotateAdditiveBS_Offset;

	private static bool MMUpBodyStateAlpha_IsValid;

	private static int MMUpBodyStateAlpha_Offset;

	private static bool DefaultMMState_IsValid;

	private static int DefaultMMState_Offset;

	private static FFieldAddress DefaultMMState_PropertyAddress;

	private static bool SpareMoveMode_IsValid;

	private static int SpareMoveMode_Offset;

	private static FFieldAddress SpareMoveMode_PropertyAddress;

	private static bool MMState2AACS_IsValid;

	private static int MMState2AACS_Offset;

	private static FFieldAddress MMState2AACS_PropertyAddress;

	private static bool AnimationAnalyzerBlendTime_IsValid;

	private static int AnimationAnalyzerBlendTime_Offset;

	private static bool MotionBlendTime_IsValid;

	private static int MotionBlendTime_Offset;

	private static bool Retargeter_IsValid;

	private static int Retargeter_Offset;

	private static bool PelvisOffsetZ_IsValid;

	private static int PelvisOffsetZ_Offset;

	private static bool FootOffsetScale_IsValid;

	private static int FootOffsetScale_Offset;

	private static bool ForceSetRotAnimSpeed_IsValid;

	private static int ForceSetRotAnimSpeed_Offset;

	private static bool DisableRotVerifyAnimSpeed_IsValid;

	private static int DisableRotVerifyAnimSpeed_Offset;

	private static bool ToIdleAnimSpeed_IsValid;

	private static int ToIdleAnimSpeed_Offset;

	private static bool bNeedFixMM_IsValid;

	private static int bNeedFixMM_Offset;

	private static FFieldAddress bNeedFixMM_PropertyAddress;

	private static bool MMAdditivePose_IsValid;

	private static int MMAdditivePose_Offset;

	private static bool MMAdditiveWeight_IsValid;

	private static int MMAdditiveWeight_Offset;

	private static bool bFixMMWeapon_MeshSpaceRotation_IsValid;

	private static int bFixMMWeapon_MeshSpaceRotation_Offset;

	private static FFieldAddress bFixMMWeapon_MeshSpaceRotation_PropertyAddress;

	private static bool bFixMMAdditive_MeshSpaceRotation_IsValid;

	private static int bFixMMAdditive_MeshSpaceRotation_Offset;

	private static FFieldAddress bFixMMAdditive_MeshSpaceRotation_PropertyAddress;

	private static bool MMAdditiveLayerSetup_IsValid;

	private static int MMAdditiveLayerSetup_Offset;

	private static FFieldAddress MMAdditiveLayerSetup_PropertyAddress;

	public FAnimHumanoidSetting_MotionMatching Copy()
	{
		FAnimHumanoidSetting_MotionMatching result = this;
		if (MMState2AACS != null)
		{
			result.MMState2AACS = new Dictionary<EState_MM, BUAnimationAnalyzer>(MMState2AACS);
		}
		if (MMAdditiveLayerSetup != null)
		{
			result.MMAdditiveLayerSetup = new List<FGSInputBlendPose>(MMAdditiveLayerSetup);
		}
		return result;
	}

	public static FAnimHumanoidSetting_MotionMatching FromNative(IntPtr nativeBuffer)
	{
		return new FAnimHumanoidSetting_MotionMatching(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimHumanoidSetting_MotionMatching value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimHumanoidSetting_MotionMatching FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimHumanoidSetting_MotionMatching(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_MotionMatching_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimHumanoidSetting_MotionMatching value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_MotionMatching_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_MotionMatching_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_MotionMatching");
			return;
		}
		UObjectMarshaler<UAnimationAnalyzer>.ToNative(IntPtr.Add(nativeStruct, Walk2RunAA_Offset), Walk2RunAA);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bMMLockUseFreeMode_Offset), 0, bMMLockUseFreeMode_PropertyAddress.Address, bMMLockUseFreeMode);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, RotateAdditiveBS_Offset), RotateAdditiveBS);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MMUpBodyStateAlpha_Offset), MMUpBodyStateAlpha);
		EnumMarshaler<EState_MM>.ToNative(IntPtr.Add(nativeStruct, DefaultMMState_Offset), 0, DefaultMMState_PropertyAddress.Address, DefaultMMState);
		EnumMarshaler<EABPMoveMode>.ToNative(IntPtr.Add(nativeStruct, SpareMoveMode_Offset), 0, SpareMoveMode_PropertyAddress.Address, SpareMoveMode);
		new TMapCopyMarshaler<EState_MM, BUAnimationAnalyzer>(1, MMState2AACS_PropertyAddress, CachedMarshalingDelegates<EState_MM, EnumMarshaler<EState_MM>>.FromNative, CachedMarshalingDelegates<EState_MM, EnumMarshaler<EState_MM>>.ToNative, CachedMarshalingDelegates<BUAnimationAnalyzer, UObjectMarshaler<BUAnimationAnalyzer>>.FromNative, CachedMarshalingDelegates<BUAnimationAnalyzer, UObjectMarshaler<BUAnimationAnalyzer>>.ToNative).ToNative(IntPtr.Add(nativeStruct, MMState2AACS_Offset), MMState2AACS);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, AnimationAnalyzerBlendTime_Offset), AnimationAnalyzerBlendTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MotionBlendTime_Offset), MotionBlendTime);
		UObjectMarshaler<UIKRetargeter>.ToNative(IntPtr.Add(nativeStruct, Retargeter_Offset), Retargeter);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, PelvisOffsetZ_Offset), PelvisOffsetZ);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FootOffsetScale_Offset), FootOffsetScale);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ForceSetRotAnimSpeed_Offset), ForceSetRotAnimSpeed);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DisableRotVerifyAnimSpeed_Offset), DisableRotVerifyAnimSpeed);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ToIdleAnimSpeed_Offset), ToIdleAnimSpeed);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bNeedFixMM_Offset), 0, bNeedFixMM_PropertyAddress.Address, bNeedFixMM);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, MMAdditivePose_Offset), MMAdditivePose);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MMAdditiveWeight_Offset), MMAdditiveWeight);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bFixMMWeapon_MeshSpaceRotation_Offset), 0, bFixMMWeapon_MeshSpaceRotation_PropertyAddress.Address, bFixMMWeapon_MeshSpaceRotation);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bFixMMAdditive_MeshSpaceRotation_Offset), 0, bFixMMAdditive_MeshSpaceRotation_PropertyAddress.Address, bFixMMAdditive_MeshSpaceRotation);
		new TArrayCopyMarshaler<FGSInputBlendPose>(1, MMAdditiveLayerSetup_PropertyAddress, CachedMarshalingDelegates<FGSInputBlendPose, FGSInputBlendPose>.FromNative, CachedMarshalingDelegates<FGSInputBlendPose, FGSInputBlendPose>.ToNative).ToNative(IntPtr.Add(nativeStruct, MMAdditiveLayerSetup_Offset), MMAdditiveLayerSetup);
	}

	public FAnimHumanoidSetting_MotionMatching(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_MotionMatching_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_MotionMatching");
			Walk2RunAA = null;
			bMMLockUseFreeMode = false;
			RotateAdditiveBS = null;
			MMUpBodyStateAlpha = 0f;
			DefaultMMState = EState_MM.None;
			SpareMoveMode = EABPMoveMode.None;
			MMState2AACS = null;
			AnimationAnalyzerBlendTime = 0f;
			MotionBlendTime = 0f;
			Retargeter = null;
			PelvisOffsetZ = 0f;
			FootOffsetScale = 0f;
			ForceSetRotAnimSpeed = 0f;
			DisableRotVerifyAnimSpeed = 0f;
			ToIdleAnimSpeed = 0f;
			bNeedFixMM = false;
			MMAdditivePose = null;
			MMAdditiveWeight = 0f;
			bFixMMWeapon_MeshSpaceRotation = false;
			bFixMMAdditive_MeshSpaceRotation = false;
			MMAdditiveLayerSetup = null;
		}
		else
		{
			Walk2RunAA = UObjectMarshaler<UAnimationAnalyzer>.FromNative(IntPtr.Add(nativeStruct, Walk2RunAA_Offset));
			bMMLockUseFreeMode = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bMMLockUseFreeMode_Offset), 0, bMMLockUseFreeMode_PropertyAddress.Address);
			RotateAdditiveBS = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, RotateAdditiveBS_Offset));
			MMUpBodyStateAlpha = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MMUpBodyStateAlpha_Offset));
			DefaultMMState = EnumMarshaler<EState_MM>.FromNative(IntPtr.Add(nativeStruct, DefaultMMState_Offset), 0, DefaultMMState_PropertyAddress.Address);
			SpareMoveMode = EnumMarshaler<EABPMoveMode>.FromNative(IntPtr.Add(nativeStruct, SpareMoveMode_Offset), 0, SpareMoveMode_PropertyAddress.Address);
			MMState2AACS = new TMapCopyMarshaler<EState_MM, BUAnimationAnalyzer>(1, MMState2AACS_PropertyAddress, CachedMarshalingDelegates<EState_MM, EnumMarshaler<EState_MM>>.FromNative, CachedMarshalingDelegates<EState_MM, EnumMarshaler<EState_MM>>.ToNative, CachedMarshalingDelegates<BUAnimationAnalyzer, UObjectMarshaler<BUAnimationAnalyzer>>.FromNative, CachedMarshalingDelegates<BUAnimationAnalyzer, UObjectMarshaler<BUAnimationAnalyzer>>.ToNative).FromNative(IntPtr.Add(nativeStruct, MMState2AACS_Offset));
			AnimationAnalyzerBlendTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, AnimationAnalyzerBlendTime_Offset));
			MotionBlendTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MotionBlendTime_Offset));
			Retargeter = UObjectMarshaler<UIKRetargeter>.FromNative(IntPtr.Add(nativeStruct, Retargeter_Offset));
			PelvisOffsetZ = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, PelvisOffsetZ_Offset));
			FootOffsetScale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FootOffsetScale_Offset));
			ForceSetRotAnimSpeed = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ForceSetRotAnimSpeed_Offset));
			DisableRotVerifyAnimSpeed = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DisableRotVerifyAnimSpeed_Offset));
			ToIdleAnimSpeed = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ToIdleAnimSpeed_Offset));
			bNeedFixMM = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bNeedFixMM_Offset), 0, bNeedFixMM_PropertyAddress.Address);
			MMAdditivePose = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, MMAdditivePose_Offset));
			MMAdditiveWeight = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MMAdditiveWeight_Offset));
			bFixMMWeapon_MeshSpaceRotation = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bFixMMWeapon_MeshSpaceRotation_Offset), 0, bFixMMWeapon_MeshSpaceRotation_PropertyAddress.Address);
			bFixMMAdditive_MeshSpaceRotation = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bFixMMAdditive_MeshSpaceRotation_Offset), 0, bFixMMAdditive_MeshSpaceRotation_PropertyAddress.Address);
			MMAdditiveLayerSetup = new TArrayCopyMarshaler<FGSInputBlendPose>(1, MMAdditiveLayerSetup_PropertyAddress, CachedMarshalingDelegates<FGSInputBlendPose, FGSInputBlendPose>.FromNative, CachedMarshalingDelegates<FGSInputBlendPose, FGSInputBlendPose>.ToNative).FromNative(IntPtr.Add(nativeStruct, MMAdditiveLayerSetup_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.AnimHumanoidSetting_MotionMatching");
		AnimHumanoidSetting_MotionMatching_StructSize = NativeReflection.GetStructSize(intPtr);
		Walk2RunAA_Offset = NativeReflection.GetPropertyOffset(intPtr, "Walk2RunAA");
		Walk2RunAA_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Walk2RunAA", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref bMMLockUseFreeMode_PropertyAddress, intPtr, "bMMLockUseFreeMode");
		bMMLockUseFreeMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "bMMLockUseFreeMode");
		bMMLockUseFreeMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bMMLockUseFreeMode", Classes.FBoolProperty);
		RotateAdditiveBS_Offset = NativeReflection.GetPropertyOffset(intPtr, "RotateAdditiveBS");
		RotateAdditiveBS_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RotateAdditiveBS", Classes.FObjectProperty);
		MMUpBodyStateAlpha_Offset = NativeReflection.GetPropertyOffset(intPtr, "MMUpBodyStateAlpha");
		MMUpBodyStateAlpha_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MMUpBodyStateAlpha", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref DefaultMMState_PropertyAddress, intPtr, "DefaultMMState");
		DefaultMMState_Offset = NativeReflection.GetPropertyOffset(intPtr, "DefaultMMState");
		DefaultMMState_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DefaultMMState", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref SpareMoveMode_PropertyAddress, intPtr, "SpareMoveMode");
		SpareMoveMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpareMoveMode");
		SpareMoveMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpareMoveMode", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref MMState2AACS_PropertyAddress, intPtr, "MMState2AACS");
		MMState2AACS_Offset = NativeReflection.GetPropertyOffset(intPtr, "MMState2AACS");
		MMState2AACS_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MMState2AACS", Classes.FMapProperty);
		AnimationAnalyzerBlendTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimationAnalyzerBlendTime");
		AnimationAnalyzerBlendTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimationAnalyzerBlendTime", Classes.FFloatProperty);
		MotionBlendTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "MotionBlendTime");
		MotionBlendTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MotionBlendTime", Classes.FFloatProperty);
		Retargeter_Offset = NativeReflection.GetPropertyOffset(intPtr, "Retargeter");
		Retargeter_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Retargeter", Classes.FObjectProperty);
		PelvisOffsetZ_Offset = NativeReflection.GetPropertyOffset(intPtr, "PelvisOffsetZ");
		PelvisOffsetZ_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PelvisOffsetZ", Classes.FFloatProperty);
		FootOffsetScale_Offset = NativeReflection.GetPropertyOffset(intPtr, "FootOffsetScale");
		FootOffsetScale_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FootOffsetScale", Classes.FFloatProperty);
		ForceSetRotAnimSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "ForceSetRotAnimSpeed");
		ForceSetRotAnimSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ForceSetRotAnimSpeed", Classes.FFloatProperty);
		DisableRotVerifyAnimSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "DisableRotVerifyAnimSpeed");
		DisableRotVerifyAnimSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DisableRotVerifyAnimSpeed", Classes.FFloatProperty);
		ToIdleAnimSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "ToIdleAnimSpeed");
		ToIdleAnimSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ToIdleAnimSpeed", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bNeedFixMM_PropertyAddress, intPtr, "bNeedFixMM");
		bNeedFixMM_Offset = NativeReflection.GetPropertyOffset(intPtr, "bNeedFixMM");
		bNeedFixMM_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bNeedFixMM", Classes.FBoolProperty);
		MMAdditivePose_Offset = NativeReflection.GetPropertyOffset(intPtr, "MMAdditivePose");
		MMAdditivePose_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MMAdditivePose", Classes.FObjectProperty);
		MMAdditiveWeight_Offset = NativeReflection.GetPropertyOffset(intPtr, "MMAdditiveWeight");
		MMAdditiveWeight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MMAdditiveWeight", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bFixMMWeapon_MeshSpaceRotation_PropertyAddress, intPtr, "bFixMMWeapon_MeshSpaceRotation");
		bFixMMWeapon_MeshSpaceRotation_Offset = NativeReflection.GetPropertyOffset(intPtr, "bFixMMWeapon_MeshSpaceRotation");
		bFixMMWeapon_MeshSpaceRotation_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bFixMMWeapon_MeshSpaceRotation", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bFixMMAdditive_MeshSpaceRotation_PropertyAddress, intPtr, "bFixMMAdditive_MeshSpaceRotation");
		bFixMMAdditive_MeshSpaceRotation_Offset = NativeReflection.GetPropertyOffset(intPtr, "bFixMMAdditive_MeshSpaceRotation");
		bFixMMAdditive_MeshSpaceRotation_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bFixMMAdditive_MeshSpaceRotation", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref MMAdditiveLayerSetup_PropertyAddress, intPtr, "MMAdditiveLayerSetup");
		MMAdditiveLayerSetup_Offset = NativeReflection.GetPropertyOffset(intPtr, "MMAdditiveLayerSetup");
		MMAdditiveLayerSetup_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MMAdditiveLayerSetup", Classes.FArrayProperty);
		AnimHumanoidSetting_MotionMatching_IsValid = ((intPtr != IntPtr.Zero && Walk2RunAA_IsValid && bMMLockUseFreeMode_IsValid && RotateAdditiveBS_IsValid && MMUpBodyStateAlpha_IsValid && DefaultMMState_IsValid && SpareMoveMode_IsValid && MMState2AACS_IsValid && AnimationAnalyzerBlendTime_IsValid && MotionBlendTime_IsValid && Retargeter_IsValid && PelvisOffsetZ_IsValid && FootOffsetScale_IsValid && ForceSetRotAnimSpeed_IsValid && DisableRotVerifyAnimSpeed_IsValid && ToIdleAnimSpeed_IsValid && bNeedFixMM_IsValid && MMAdditivePose_IsValid && MMAdditiveWeight_IsValid && bFixMMWeapon_MeshSpaceRotation_IsValid && bFixMMAdditive_MeshSpaceRotation_IsValid && MMAdditiveLayerSetup_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.AnimHumanoidSetting_MotionMatching", (byte)AnimHumanoidSetting_MotionMatching_IsValid != 0);
	}

	static FAnimHumanoidSetting_MotionMatching()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FAnimHumanoidSetting_MotionMatching)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimHumanoidSetting_MotionMatching));
	}
}
