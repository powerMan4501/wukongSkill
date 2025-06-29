using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.FollowPartnerIdleWaitingInfo")]
public struct FFollowPartnerIdleWaitingInfo
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("是否能触发")]
	[USharpPath("/Script/b1-Managed.FollowPartnerIdleWaitingInfo:CanTrigger")]
	public bool CanTrigger;

	[DisplayName("触发CD（秒）")]
	[UMeta(MDProp.EditCondition, "CanTrigger")]
	[UMeta(MDProp.ClampMin, "0")]
	[Tooltip("触发CD会在播放动画完成再开始计算")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FollowPartnerIdleWaitingInfo:TriggerCD")]
	public int TriggerCD;

	[UProperty]
	[UMeta(MDProp.EditCondition, "CanTrigger")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("随机动画列表")]
	[USharpPath("/Script/b1-Managed.FollowPartnerIdleWaitingInfo:IdleRandomMontageList")]
	public List<UAnimMontage> IdleRandomMontageList;

	private static int FollowPartnerIdleWaitingInfo_StructSize;

	private static int FollowPartnerIdleWaitingInfo_IsValid;

	private static bool CanTrigger_IsValid;

	private static int CanTrigger_Offset;

	private static FFieldAddress CanTrigger_PropertyAddress;

	private static bool TriggerCD_IsValid;

	private static int TriggerCD_Offset;

	private static bool IdleRandomMontageList_IsValid;

	private static int IdleRandomMontageList_Offset;

	private static FFieldAddress IdleRandomMontageList_PropertyAddress;

	public FFollowPartnerIdleWaitingInfo Copy()
	{
		FFollowPartnerIdleWaitingInfo result = this;
		if (IdleRandomMontageList != null)
		{
			result.IdleRandomMontageList = new List<UAnimMontage>(IdleRandomMontageList);
		}
		return result;
	}

	public static FFollowPartnerIdleWaitingInfo FromNative(IntPtr nativeBuffer)
	{
		return new FFollowPartnerIdleWaitingInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FFollowPartnerIdleWaitingInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FFollowPartnerIdleWaitingInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FFollowPartnerIdleWaitingInfo(IntPtr.Add(nativeBuffer, arrayIndex * FollowPartnerIdleWaitingInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FFollowPartnerIdleWaitingInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * FollowPartnerIdleWaitingInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (FollowPartnerIdleWaitingInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FollowPartnerIdleWaitingInfo");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CanTrigger_Offset), 0, CanTrigger_PropertyAddress.Address, CanTrigger);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, TriggerCD_Offset), TriggerCD);
		new TArrayCopyMarshaler<UAnimMontage>(1, IdleRandomMontageList_PropertyAddress, CachedMarshalingDelegates<UAnimMontage, UObjectMarshaler<UAnimMontage>>.FromNative, CachedMarshalingDelegates<UAnimMontage, UObjectMarshaler<UAnimMontage>>.ToNative).ToNative(IntPtr.Add(nativeStruct, IdleRandomMontageList_Offset), IdleRandomMontageList);
	}

	public FFollowPartnerIdleWaitingInfo(IntPtr nativeStruct)
	{
		if (FollowPartnerIdleWaitingInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FollowPartnerIdleWaitingInfo");
			CanTrigger = false;
			TriggerCD = 0;
			IdleRandomMontageList = null;
		}
		else
		{
			CanTrigger = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CanTrigger_Offset), 0, CanTrigger_PropertyAddress.Address);
			TriggerCD = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, TriggerCD_Offset));
			IdleRandomMontageList = new TArrayCopyMarshaler<UAnimMontage>(1, IdleRandomMontageList_PropertyAddress, CachedMarshalingDelegates<UAnimMontage, UObjectMarshaler<UAnimMontage>>.FromNative, CachedMarshalingDelegates<UAnimMontage, UObjectMarshaler<UAnimMontage>>.ToNative).FromNative(IntPtr.Add(nativeStruct, IdleRandomMontageList_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.FollowPartnerIdleWaitingInfo");
		FollowPartnerIdleWaitingInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref CanTrigger_PropertyAddress, intPtr, "CanTrigger");
		CanTrigger_Offset = NativeReflection.GetPropertyOffset(intPtr, "CanTrigger");
		CanTrigger_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CanTrigger", Classes.FBoolProperty);
		TriggerCD_Offset = NativeReflection.GetPropertyOffset(intPtr, "TriggerCD");
		TriggerCD_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TriggerCD", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref IdleRandomMontageList_PropertyAddress, intPtr, "IdleRandomMontageList");
		IdleRandomMontageList_Offset = NativeReflection.GetPropertyOffset(intPtr, "IdleRandomMontageList");
		IdleRandomMontageList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IdleRandomMontageList", Classes.FArrayProperty);
		FollowPartnerIdleWaitingInfo_IsValid = ((intPtr != IntPtr.Zero && CanTrigger_IsValid && TriggerCD_IsValid && IdleRandomMontageList_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.FollowPartnerIdleWaitingInfo", (byte)FollowPartnerIdleWaitingInfo_IsValid != 0);
	}

	static FFollowPartnerIdleWaitingInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FFollowPartnerIdleWaitingInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FFollowPartnerIdleWaitingInfo));
	}
}
