using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.BlockInfoWarp_Normal")]
public struct FBlockInfoWarp_Normal
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Tooltip("按力度区分；如果某个打击力度为空，则会用打击力度为-1的信息，如果没有-1打击力度的信息，才为空")]
	[DisplayName("普通格挡动画信息")]
	[USharpPath("/Script/b1-Managed.BlockInfoWarp_Normal:BlockInfoByHitLevelList")]
	public List<FBlockInfoByHitLevel> BlockInfoByHitLevelList;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("普通格挡崩防动画")]
	[USharpPath("/Script/b1-Managed.BlockInfoWarp_Normal:BreakBlockAM")]
	public UAnimMontage BreakBlockAM;

	[DisplayName("触发普通崩防虚弱最低HitWeight")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BlockInfoWarp_Normal:TriggerBlock2WeakMinHitWeight")]
	public int TriggerBlock2WeakMinHitWeight;

	[UProperty]
	[DisplayName("普通崩防虚弱动画")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BlockInfoWarp_Normal:BreakBlock2WeakAM")]
	public UAnimMontage BreakBlock2WeakAM;

	private static int BlockInfoWarp_Normal_StructSize;

	private static int BlockInfoWarp_Normal_IsValid;

	private static bool BlockInfoByHitLevelList_IsValid;

	private static int BlockInfoByHitLevelList_Offset;

	private static FFieldAddress BlockInfoByHitLevelList_PropertyAddress;

	private static bool BreakBlockAM_IsValid;

	private static int BreakBlockAM_Offset;

	private static bool TriggerBlock2WeakMinHitWeight_IsValid;

	private static int TriggerBlock2WeakMinHitWeight_Offset;

	private static bool BreakBlock2WeakAM_IsValid;

	private static int BreakBlock2WeakAM_Offset;

	public FBlockInfoWarp_Normal Copy()
	{
		FBlockInfoWarp_Normal result = this;
		if (BlockInfoByHitLevelList != null)
		{
			result.BlockInfoByHitLevelList = new List<FBlockInfoByHitLevel>(BlockInfoByHitLevelList);
		}
		return result;
	}

	public static FBlockInfoWarp_Normal FromNative(IntPtr nativeBuffer)
	{
		return new FBlockInfoWarp_Normal(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FBlockInfoWarp_Normal value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FBlockInfoWarp_Normal FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FBlockInfoWarp_Normal(IntPtr.Add(nativeBuffer, arrayIndex * BlockInfoWarp_Normal_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FBlockInfoWarp_Normal value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BlockInfoWarp_Normal_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BlockInfoWarp_Normal_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BlockInfoWarp_Normal");
			return;
		}
		new TArrayCopyMarshaler<FBlockInfoByHitLevel>(1, BlockInfoByHitLevelList_PropertyAddress, CachedMarshalingDelegates<FBlockInfoByHitLevel, FBlockInfoByHitLevel>.FromNative, CachedMarshalingDelegates<FBlockInfoByHitLevel, FBlockInfoByHitLevel>.ToNative).ToNative(IntPtr.Add(nativeStruct, BlockInfoByHitLevelList_Offset), BlockInfoByHitLevelList);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(nativeStruct, BreakBlockAM_Offset), BreakBlockAM);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, TriggerBlock2WeakMinHitWeight_Offset), TriggerBlock2WeakMinHitWeight);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(nativeStruct, BreakBlock2WeakAM_Offset), BreakBlock2WeakAM);
	}

	public FBlockInfoWarp_Normal(IntPtr nativeStruct)
	{
		if (BlockInfoWarp_Normal_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BlockInfoWarp_Normal");
			BlockInfoByHitLevelList = null;
			BreakBlockAM = null;
			TriggerBlock2WeakMinHitWeight = 0;
			BreakBlock2WeakAM = null;
		}
		else
		{
			BlockInfoByHitLevelList = new TArrayCopyMarshaler<FBlockInfoByHitLevel>(1, BlockInfoByHitLevelList_PropertyAddress, CachedMarshalingDelegates<FBlockInfoByHitLevel, FBlockInfoByHitLevel>.FromNative, CachedMarshalingDelegates<FBlockInfoByHitLevel, FBlockInfoByHitLevel>.ToNative).FromNative(IntPtr.Add(nativeStruct, BlockInfoByHitLevelList_Offset));
			BreakBlockAM = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(nativeStruct, BreakBlockAM_Offset));
			TriggerBlock2WeakMinHitWeight = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, TriggerBlock2WeakMinHitWeight_Offset));
			BreakBlock2WeakAM = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(nativeStruct, BreakBlock2WeakAM_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BlockInfoWarp_Normal");
		BlockInfoWarp_Normal_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref BlockInfoByHitLevelList_PropertyAddress, intPtr, "BlockInfoByHitLevelList");
		BlockInfoByHitLevelList_Offset = NativeReflection.GetPropertyOffset(intPtr, "BlockInfoByHitLevelList");
		BlockInfoByHitLevelList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BlockInfoByHitLevelList", Classes.FArrayProperty);
		BreakBlockAM_Offset = NativeReflection.GetPropertyOffset(intPtr, "BreakBlockAM");
		BreakBlockAM_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BreakBlockAM", Classes.FObjectProperty);
		TriggerBlock2WeakMinHitWeight_Offset = NativeReflection.GetPropertyOffset(intPtr, "TriggerBlock2WeakMinHitWeight");
		TriggerBlock2WeakMinHitWeight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TriggerBlock2WeakMinHitWeight", Classes.FIntProperty);
		BreakBlock2WeakAM_Offset = NativeReflection.GetPropertyOffset(intPtr, "BreakBlock2WeakAM");
		BreakBlock2WeakAM_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BreakBlock2WeakAM", Classes.FObjectProperty);
		BlockInfoWarp_Normal_IsValid = ((intPtr != IntPtr.Zero && BlockInfoByHitLevelList_IsValid && BreakBlockAM_IsValid && TriggerBlock2WeakMinHitWeight_IsValid && BreakBlock2WeakAM_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BlockInfoWarp_Normal", (byte)BlockInfoWarp_Normal_IsValid != 0);
	}

	static FBlockInfoWarp_Normal()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FBlockInfoWarp_Normal)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FBlockInfoWarp_Normal));
	}
}
