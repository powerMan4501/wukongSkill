using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.FollowPartnerDodgeInfo")]
public struct FFollowPartnerDodgeInfo
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("是否能触发")]
	[USharpPath("/Script/b1-Managed.FollowPartnerDodgeInfo:CanTrigger")]
	public bool CanTrigger;

	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "CanTrigger")]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("触发CD（秒）")]
	[UMeta(MDProp.ClampMin, "0")]
	[Tooltip("触发CD会在播放动画完成再开始计算")]
	[USharpPath("/Script/b1-Managed.FollowPartnerDodgeInfo:TriggerCD")]
	public int TriggerCD;

	[UMeta(MDProp.ClampMin, "0")]
	[UMeta(MDProp.EditCondition, "CanTrigger")]
	[DisplayName("触发范围（cm）")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FollowPartnerDodgeInfo:TriggerRadius")]
	public int TriggerRadius;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Tooltip("和本地主角速度差绝对值大于等于这个才会触发")]
	[DisplayName("速度差【绝对值】")]
	[UMeta(MDProp.ClampMin, "0")]
	[UMeta(MDProp.EditCondition, "CanTrigger")]
	[USharpPath("/Script/b1-Managed.FollowPartnerDodgeInfo:VelocityDifferent")]
	public int VelocityDifferent;

	[UMeta(MDProp.EditCondition, "CanTrigger")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[DisplayName("向前躲避动画列表")]
	[USharpPath("/Script/b1-Managed.FollowPartnerDodgeInfo:ForwardDodgeMontageList")]
	public List<UAnimMontage> ForwardDodgeMontageList;

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("向后躲避动画列表")]
	[UMeta(MDProp.EditCondition, "CanTrigger")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FollowPartnerDodgeInfo:BackwardDodgeMontageList")]
	public List<UAnimMontage> BackwardDodgeMontageList;

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("向左躲避动画列表")]
	[UMeta(MDProp.EditCondition, "CanTrigger")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FollowPartnerDodgeInfo:LeftSideDodgeMontageList")]
	public List<UAnimMontage> LeftSideDodgeMontageList;

	[BlueprintReadWrite]
	[DisplayName("向右躲避动画列表")]
	[UMeta(MDProp.EditCondition, "CanTrigger")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FollowPartnerDodgeInfo:RightSideDodgeMontageList")]
	public List<UAnimMontage> RightSideDodgeMontageList;

	[UMeta(MDProp.EditCondition, "CanTrigger")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("躲闪结束后是否移动")]
	[USharpPath("/Script/b1-Managed.FollowPartnerDodgeInfo:CanTriggerEQSRun")]
	public bool CanTriggerEQSRun;

	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("EQS移动参数")]
	[UMeta(MDProp.EditCondition, "CanTrigger && CanTriggerEQSRun")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FollowPartnerDodgeInfo:EQSRunParamInfo")]
	public FEQSRunParamInfo EQSRunParamInfo;

	private static int FollowPartnerDodgeInfo_StructSize;

	private static int FollowPartnerDodgeInfo_IsValid;

	private static bool CanTrigger_IsValid;

	private static int CanTrigger_Offset;

	private static FFieldAddress CanTrigger_PropertyAddress;

	private static bool TriggerCD_IsValid;

	private static int TriggerCD_Offset;

	private static bool TriggerRadius_IsValid;

	private static int TriggerRadius_Offset;

	private static bool VelocityDifferent_IsValid;

	private static int VelocityDifferent_Offset;

	private static bool ForwardDodgeMontageList_IsValid;

	private static int ForwardDodgeMontageList_Offset;

	private static FFieldAddress ForwardDodgeMontageList_PropertyAddress;

	private static bool BackwardDodgeMontageList_IsValid;

	private static int BackwardDodgeMontageList_Offset;

	private static FFieldAddress BackwardDodgeMontageList_PropertyAddress;

	private static bool LeftSideDodgeMontageList_IsValid;

	private static int LeftSideDodgeMontageList_Offset;

	private static FFieldAddress LeftSideDodgeMontageList_PropertyAddress;

	private static bool RightSideDodgeMontageList_IsValid;

	private static int RightSideDodgeMontageList_Offset;

	private static FFieldAddress RightSideDodgeMontageList_PropertyAddress;

	private static bool CanTriggerEQSRun_IsValid;

	private static int CanTriggerEQSRun_Offset;

	private static FFieldAddress CanTriggerEQSRun_PropertyAddress;

	private static bool EQSRunParamInfo_IsValid;

	private static int EQSRunParamInfo_Offset;

	public FFollowPartnerDodgeInfo Copy()
	{
		FFollowPartnerDodgeInfo result = this;
		if (ForwardDodgeMontageList != null)
		{
			result.ForwardDodgeMontageList = new List<UAnimMontage>(ForwardDodgeMontageList);
		}
		if (BackwardDodgeMontageList != null)
		{
			result.BackwardDodgeMontageList = new List<UAnimMontage>(BackwardDodgeMontageList);
		}
		if (LeftSideDodgeMontageList != null)
		{
			result.LeftSideDodgeMontageList = new List<UAnimMontage>(LeftSideDodgeMontageList);
		}
		if (RightSideDodgeMontageList != null)
		{
			result.RightSideDodgeMontageList = new List<UAnimMontage>(RightSideDodgeMontageList);
		}
		return result;
	}

	public static FFollowPartnerDodgeInfo FromNative(IntPtr nativeBuffer)
	{
		return new FFollowPartnerDodgeInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FFollowPartnerDodgeInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FFollowPartnerDodgeInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FFollowPartnerDodgeInfo(IntPtr.Add(nativeBuffer, arrayIndex * FollowPartnerDodgeInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FFollowPartnerDodgeInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * FollowPartnerDodgeInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (FollowPartnerDodgeInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FollowPartnerDodgeInfo");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CanTrigger_Offset), 0, CanTrigger_PropertyAddress.Address, CanTrigger);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, TriggerCD_Offset), TriggerCD);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, TriggerRadius_Offset), TriggerRadius);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, VelocityDifferent_Offset), VelocityDifferent);
		new TArrayCopyMarshaler<UAnimMontage>(1, ForwardDodgeMontageList_PropertyAddress, CachedMarshalingDelegates<UAnimMontage, UObjectMarshaler<UAnimMontage>>.FromNative, CachedMarshalingDelegates<UAnimMontage, UObjectMarshaler<UAnimMontage>>.ToNative).ToNative(IntPtr.Add(nativeStruct, ForwardDodgeMontageList_Offset), ForwardDodgeMontageList);
		new TArrayCopyMarshaler<UAnimMontage>(1, BackwardDodgeMontageList_PropertyAddress, CachedMarshalingDelegates<UAnimMontage, UObjectMarshaler<UAnimMontage>>.FromNative, CachedMarshalingDelegates<UAnimMontage, UObjectMarshaler<UAnimMontage>>.ToNative).ToNative(IntPtr.Add(nativeStruct, BackwardDodgeMontageList_Offset), BackwardDodgeMontageList);
		new TArrayCopyMarshaler<UAnimMontage>(1, LeftSideDodgeMontageList_PropertyAddress, CachedMarshalingDelegates<UAnimMontage, UObjectMarshaler<UAnimMontage>>.FromNative, CachedMarshalingDelegates<UAnimMontage, UObjectMarshaler<UAnimMontage>>.ToNative).ToNative(IntPtr.Add(nativeStruct, LeftSideDodgeMontageList_Offset), LeftSideDodgeMontageList);
		new TArrayCopyMarshaler<UAnimMontage>(1, RightSideDodgeMontageList_PropertyAddress, CachedMarshalingDelegates<UAnimMontage, UObjectMarshaler<UAnimMontage>>.FromNative, CachedMarshalingDelegates<UAnimMontage, UObjectMarshaler<UAnimMontage>>.ToNative).ToNative(IntPtr.Add(nativeStruct, RightSideDodgeMontageList_Offset), RightSideDodgeMontageList);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CanTriggerEQSRun_Offset), 0, CanTriggerEQSRun_PropertyAddress.Address, CanTriggerEQSRun);
		FEQSRunParamInfo.ToNative(IntPtr.Add(nativeStruct, EQSRunParamInfo_Offset), EQSRunParamInfo);
	}

	public FFollowPartnerDodgeInfo(IntPtr nativeStruct)
	{
		if (FollowPartnerDodgeInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FollowPartnerDodgeInfo");
			CanTrigger = false;
			TriggerCD = 0;
			TriggerRadius = 0;
			VelocityDifferent = 0;
			ForwardDodgeMontageList = null;
			BackwardDodgeMontageList = null;
			LeftSideDodgeMontageList = null;
			RightSideDodgeMontageList = null;
			CanTriggerEQSRun = false;
			EQSRunParamInfo = default(FEQSRunParamInfo);
		}
		else
		{
			CanTrigger = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CanTrigger_Offset), 0, CanTrigger_PropertyAddress.Address);
			TriggerCD = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, TriggerCD_Offset));
			TriggerRadius = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, TriggerRadius_Offset));
			VelocityDifferent = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, VelocityDifferent_Offset));
			ForwardDodgeMontageList = new TArrayCopyMarshaler<UAnimMontage>(1, ForwardDodgeMontageList_PropertyAddress, CachedMarshalingDelegates<UAnimMontage, UObjectMarshaler<UAnimMontage>>.FromNative, CachedMarshalingDelegates<UAnimMontage, UObjectMarshaler<UAnimMontage>>.ToNative).FromNative(IntPtr.Add(nativeStruct, ForwardDodgeMontageList_Offset));
			BackwardDodgeMontageList = new TArrayCopyMarshaler<UAnimMontage>(1, BackwardDodgeMontageList_PropertyAddress, CachedMarshalingDelegates<UAnimMontage, UObjectMarshaler<UAnimMontage>>.FromNative, CachedMarshalingDelegates<UAnimMontage, UObjectMarshaler<UAnimMontage>>.ToNative).FromNative(IntPtr.Add(nativeStruct, BackwardDodgeMontageList_Offset));
			LeftSideDodgeMontageList = new TArrayCopyMarshaler<UAnimMontage>(1, LeftSideDodgeMontageList_PropertyAddress, CachedMarshalingDelegates<UAnimMontage, UObjectMarshaler<UAnimMontage>>.FromNative, CachedMarshalingDelegates<UAnimMontage, UObjectMarshaler<UAnimMontage>>.ToNative).FromNative(IntPtr.Add(nativeStruct, LeftSideDodgeMontageList_Offset));
			RightSideDodgeMontageList = new TArrayCopyMarshaler<UAnimMontage>(1, RightSideDodgeMontageList_PropertyAddress, CachedMarshalingDelegates<UAnimMontage, UObjectMarshaler<UAnimMontage>>.FromNative, CachedMarshalingDelegates<UAnimMontage, UObjectMarshaler<UAnimMontage>>.ToNative).FromNative(IntPtr.Add(nativeStruct, RightSideDodgeMontageList_Offset));
			CanTriggerEQSRun = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CanTriggerEQSRun_Offset), 0, CanTriggerEQSRun_PropertyAddress.Address);
			EQSRunParamInfo = FEQSRunParamInfo.FromNative(IntPtr.Add(nativeStruct, EQSRunParamInfo_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.FollowPartnerDodgeInfo");
		FollowPartnerDodgeInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref CanTrigger_PropertyAddress, intPtr, "CanTrigger");
		CanTrigger_Offset = NativeReflection.GetPropertyOffset(intPtr, "CanTrigger");
		CanTrigger_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CanTrigger", Classes.FBoolProperty);
		TriggerCD_Offset = NativeReflection.GetPropertyOffset(intPtr, "TriggerCD");
		TriggerCD_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TriggerCD", Classes.FIntProperty);
		TriggerRadius_Offset = NativeReflection.GetPropertyOffset(intPtr, "TriggerRadius");
		TriggerRadius_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TriggerRadius", Classes.FIntProperty);
		VelocityDifferent_Offset = NativeReflection.GetPropertyOffset(intPtr, "VelocityDifferent");
		VelocityDifferent_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "VelocityDifferent", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref ForwardDodgeMontageList_PropertyAddress, intPtr, "ForwardDodgeMontageList");
		ForwardDodgeMontageList_Offset = NativeReflection.GetPropertyOffset(intPtr, "ForwardDodgeMontageList");
		ForwardDodgeMontageList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ForwardDodgeMontageList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref BackwardDodgeMontageList_PropertyAddress, intPtr, "BackwardDodgeMontageList");
		BackwardDodgeMontageList_Offset = NativeReflection.GetPropertyOffset(intPtr, "BackwardDodgeMontageList");
		BackwardDodgeMontageList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BackwardDodgeMontageList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref LeftSideDodgeMontageList_PropertyAddress, intPtr, "LeftSideDodgeMontageList");
		LeftSideDodgeMontageList_Offset = NativeReflection.GetPropertyOffset(intPtr, "LeftSideDodgeMontageList");
		LeftSideDodgeMontageList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LeftSideDodgeMontageList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref RightSideDodgeMontageList_PropertyAddress, intPtr, "RightSideDodgeMontageList");
		RightSideDodgeMontageList_Offset = NativeReflection.GetPropertyOffset(intPtr, "RightSideDodgeMontageList");
		RightSideDodgeMontageList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RightSideDodgeMontageList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref CanTriggerEQSRun_PropertyAddress, intPtr, "CanTriggerEQSRun");
		CanTriggerEQSRun_Offset = NativeReflection.GetPropertyOffset(intPtr, "CanTriggerEQSRun");
		CanTriggerEQSRun_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CanTriggerEQSRun", Classes.FBoolProperty);
		EQSRunParamInfo_Offset = NativeReflection.GetPropertyOffset(intPtr, "EQSRunParamInfo");
		EQSRunParamInfo_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EQSRunParamInfo", Classes.FStructProperty);
		FollowPartnerDodgeInfo_IsValid = ((intPtr != IntPtr.Zero && CanTrigger_IsValid && TriggerCD_IsValid && TriggerRadius_IsValid && VelocityDifferent_IsValid && ForwardDodgeMontageList_IsValid && BackwardDodgeMontageList_IsValid && LeftSideDodgeMontageList_IsValid && RightSideDodgeMontageList_IsValid && CanTriggerEQSRun_IsValid && EQSRunParamInfo_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.FollowPartnerDodgeInfo", (byte)FollowPartnerDodgeInfo_IsValid != 0);
	}

	static FFollowPartnerDodgeInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FFollowPartnerDodgeInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FFollowPartnerDodgeInfo));
	}
}
