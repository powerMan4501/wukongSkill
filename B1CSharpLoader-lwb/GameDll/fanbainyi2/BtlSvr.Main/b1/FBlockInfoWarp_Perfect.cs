using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.BlockInfoWarp_Perfect")]
public struct FBlockInfoWarp_Perfect
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Tooltip("默认情况下，完美格挡下不会扣除格挡值。此项配置可以突破这个限制")]
	[DisplayName("完美格挡下伤害信息")]
	[USharpPath("/Script/b1-Managed.BlockInfoWarp_Perfect:PerfectBlockDamageInfoList")]
	public List<FPerfectBlockDamageInfo> PerfectBlockDamageInfoList;

	[BlueprintReadWrite]
	[DisplayName("完美格挡动画信息")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BlockInfoWarp_Perfect:BlockAMInfoList")]
	public List<FBlockAMInfo> BlockAMInfoList;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("完美崩防动画")]
	[USharpPath("/Script/b1-Managed.BlockInfoWarp_Perfect:BreakBlockAM")]
	public UAnimMontage BreakBlockAM;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("触发完美崩防虚弱最低HitWeight")]
	[USharpPath("/Script/b1-Managed.BlockInfoWarp_Perfect:TriggerBlock2WeakMinHitWeight")]
	public int TriggerBlock2WeakMinHitWeight;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("完美崩防虚弱动画")]
	[USharpPath("/Script/b1-Managed.BlockInfoWarp_Perfect:BreakBlock2WeakAM")]
	public UAnimMontage BreakBlock2WeakAM;

	private static int BlockInfoWarp_Perfect_StructSize;

	private static int BlockInfoWarp_Perfect_IsValid;

	private static bool PerfectBlockDamageInfoList_IsValid;

	private static int PerfectBlockDamageInfoList_Offset;

	private static FFieldAddress PerfectBlockDamageInfoList_PropertyAddress;

	private static bool BlockAMInfoList_IsValid;

	private static int BlockAMInfoList_Offset;

	private static FFieldAddress BlockAMInfoList_PropertyAddress;

	private static bool BreakBlockAM_IsValid;

	private static int BreakBlockAM_Offset;

	private static bool TriggerBlock2WeakMinHitWeight_IsValid;

	private static int TriggerBlock2WeakMinHitWeight_Offset;

	private static bool BreakBlock2WeakAM_IsValid;

	private static int BreakBlock2WeakAM_Offset;

	public FBlockInfoWarp_Perfect Copy()
	{
		FBlockInfoWarp_Perfect result = this;
		if (PerfectBlockDamageInfoList != null)
		{
			result.PerfectBlockDamageInfoList = new List<FPerfectBlockDamageInfo>(PerfectBlockDamageInfoList);
		}
		if (BlockAMInfoList != null)
		{
			result.BlockAMInfoList = new List<FBlockAMInfo>(BlockAMInfoList);
		}
		return result;
	}

	public static FBlockInfoWarp_Perfect FromNative(IntPtr nativeBuffer)
	{
		return new FBlockInfoWarp_Perfect(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FBlockInfoWarp_Perfect value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FBlockInfoWarp_Perfect FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FBlockInfoWarp_Perfect(IntPtr.Add(nativeBuffer, arrayIndex * BlockInfoWarp_Perfect_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FBlockInfoWarp_Perfect value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BlockInfoWarp_Perfect_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BlockInfoWarp_Perfect_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BlockInfoWarp_Perfect");
			return;
		}
		new TArrayCopyMarshaler<FPerfectBlockDamageInfo>(1, PerfectBlockDamageInfoList_PropertyAddress, CachedMarshalingDelegates<FPerfectBlockDamageInfo, BlittableTypeMarshaler<FPerfectBlockDamageInfo>>.FromNative, CachedMarshalingDelegates<FPerfectBlockDamageInfo, BlittableTypeMarshaler<FPerfectBlockDamageInfo>>.ToNative).ToNative(IntPtr.Add(nativeStruct, PerfectBlockDamageInfoList_Offset), PerfectBlockDamageInfoList);
		new TArrayCopyMarshaler<FBlockAMInfo>(1, BlockAMInfoList_PropertyAddress, CachedMarshalingDelegates<FBlockAMInfo, FBlockAMInfo>.FromNative, CachedMarshalingDelegates<FBlockAMInfo, FBlockAMInfo>.ToNative).ToNative(IntPtr.Add(nativeStruct, BlockAMInfoList_Offset), BlockAMInfoList);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(nativeStruct, BreakBlockAM_Offset), BreakBlockAM);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, TriggerBlock2WeakMinHitWeight_Offset), TriggerBlock2WeakMinHitWeight);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(nativeStruct, BreakBlock2WeakAM_Offset), BreakBlock2WeakAM);
	}

	public FBlockInfoWarp_Perfect(IntPtr nativeStruct)
	{
		if (BlockInfoWarp_Perfect_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BlockInfoWarp_Perfect");
			PerfectBlockDamageInfoList = null;
			BlockAMInfoList = null;
			BreakBlockAM = null;
			TriggerBlock2WeakMinHitWeight = 0;
			BreakBlock2WeakAM = null;
		}
		else
		{
			PerfectBlockDamageInfoList = new TArrayCopyMarshaler<FPerfectBlockDamageInfo>(1, PerfectBlockDamageInfoList_PropertyAddress, CachedMarshalingDelegates<FPerfectBlockDamageInfo, BlittableTypeMarshaler<FPerfectBlockDamageInfo>>.FromNative, CachedMarshalingDelegates<FPerfectBlockDamageInfo, BlittableTypeMarshaler<FPerfectBlockDamageInfo>>.ToNative).FromNative(IntPtr.Add(nativeStruct, PerfectBlockDamageInfoList_Offset));
			BlockAMInfoList = new TArrayCopyMarshaler<FBlockAMInfo>(1, BlockAMInfoList_PropertyAddress, CachedMarshalingDelegates<FBlockAMInfo, FBlockAMInfo>.FromNative, CachedMarshalingDelegates<FBlockAMInfo, FBlockAMInfo>.ToNative).FromNative(IntPtr.Add(nativeStruct, BlockAMInfoList_Offset));
			BreakBlockAM = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(nativeStruct, BreakBlockAM_Offset));
			TriggerBlock2WeakMinHitWeight = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, TriggerBlock2WeakMinHitWeight_Offset));
			BreakBlock2WeakAM = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(nativeStruct, BreakBlock2WeakAM_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BlockInfoWarp_Perfect");
		BlockInfoWarp_Perfect_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref PerfectBlockDamageInfoList_PropertyAddress, intPtr, "PerfectBlockDamageInfoList");
		PerfectBlockDamageInfoList_Offset = NativeReflection.GetPropertyOffset(intPtr, "PerfectBlockDamageInfoList");
		PerfectBlockDamageInfoList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PerfectBlockDamageInfoList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref BlockAMInfoList_PropertyAddress, intPtr, "BlockAMInfoList");
		BlockAMInfoList_Offset = NativeReflection.GetPropertyOffset(intPtr, "BlockAMInfoList");
		BlockAMInfoList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BlockAMInfoList", Classes.FArrayProperty);
		BreakBlockAM_Offset = NativeReflection.GetPropertyOffset(intPtr, "BreakBlockAM");
		BreakBlockAM_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BreakBlockAM", Classes.FObjectProperty);
		TriggerBlock2WeakMinHitWeight_Offset = NativeReflection.GetPropertyOffset(intPtr, "TriggerBlock2WeakMinHitWeight");
		TriggerBlock2WeakMinHitWeight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TriggerBlock2WeakMinHitWeight", Classes.FIntProperty);
		BreakBlock2WeakAM_Offset = NativeReflection.GetPropertyOffset(intPtr, "BreakBlock2WeakAM");
		BreakBlock2WeakAM_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BreakBlock2WeakAM", Classes.FObjectProperty);
		BlockInfoWarp_Perfect_IsValid = ((intPtr != IntPtr.Zero && PerfectBlockDamageInfoList_IsValid && BlockAMInfoList_IsValid && BreakBlockAM_IsValid && TriggerBlock2WeakMinHitWeight_IsValid && BreakBlock2WeakAM_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BlockInfoWarp_Perfect", (byte)BlockInfoWarp_Perfect_IsValid != 0);
	}

	static FBlockInfoWarp_Perfect()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FBlockInfoWarp_Perfect)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FBlockInfoWarp_Perfect));
	}
}
