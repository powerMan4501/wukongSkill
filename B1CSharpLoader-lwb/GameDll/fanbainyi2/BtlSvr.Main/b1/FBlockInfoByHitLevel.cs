using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.BlockInfoByHitLevel")]
public struct FBlockInfoByHitLevel
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("打击力度")]
	[USharpPath("/Script/b1-Managed.BlockInfoByHitLevel:HitLevel")]
	public int HitLevel;

	[DisplayName("普通格挡动画信息序列")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BlockInfoByHitLevel:BlockAMInfoList")]
	public List<FBlockAMInfo> BlockAMInfoList;

	private static int BlockInfoByHitLevel_StructSize;

	private static int BlockInfoByHitLevel_IsValid;

	private static bool HitLevel_IsValid;

	private static int HitLevel_Offset;

	private static bool BlockAMInfoList_IsValid;

	private static int BlockAMInfoList_Offset;

	private static FFieldAddress BlockAMInfoList_PropertyAddress;

	public FBlockInfoByHitLevel Copy()
	{
		FBlockInfoByHitLevel result = this;
		if (BlockAMInfoList != null)
		{
			result.BlockAMInfoList = new List<FBlockAMInfo>(BlockAMInfoList);
		}
		return result;
	}

	public static FBlockInfoByHitLevel FromNative(IntPtr nativeBuffer)
	{
		return new FBlockInfoByHitLevel(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FBlockInfoByHitLevel value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FBlockInfoByHitLevel FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FBlockInfoByHitLevel(IntPtr.Add(nativeBuffer, arrayIndex * BlockInfoByHitLevel_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FBlockInfoByHitLevel value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BlockInfoByHitLevel_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BlockInfoByHitLevel_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BlockInfoByHitLevel");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, HitLevel_Offset), HitLevel);
		new TArrayCopyMarshaler<FBlockAMInfo>(1, BlockAMInfoList_PropertyAddress, CachedMarshalingDelegates<FBlockAMInfo, FBlockAMInfo>.FromNative, CachedMarshalingDelegates<FBlockAMInfo, FBlockAMInfo>.ToNative).ToNative(IntPtr.Add(nativeStruct, BlockAMInfoList_Offset), BlockAMInfoList);
	}

	public FBlockInfoByHitLevel(IntPtr nativeStruct)
	{
		if (BlockInfoByHitLevel_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BlockInfoByHitLevel");
			HitLevel = 0;
			BlockAMInfoList = null;
		}
		else
		{
			HitLevel = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, HitLevel_Offset));
			BlockAMInfoList = new TArrayCopyMarshaler<FBlockAMInfo>(1, BlockAMInfoList_PropertyAddress, CachedMarshalingDelegates<FBlockAMInfo, FBlockAMInfo>.FromNative, CachedMarshalingDelegates<FBlockAMInfo, FBlockAMInfo>.ToNative).FromNative(IntPtr.Add(nativeStruct, BlockAMInfoList_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BlockInfoByHitLevel");
		BlockInfoByHitLevel_StructSize = NativeReflection.GetStructSize(intPtr);
		HitLevel_Offset = NativeReflection.GetPropertyOffset(intPtr, "HitLevel");
		HitLevel_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HitLevel", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref BlockAMInfoList_PropertyAddress, intPtr, "BlockAMInfoList");
		BlockAMInfoList_Offset = NativeReflection.GetPropertyOffset(intPtr, "BlockAMInfoList");
		BlockAMInfoList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BlockAMInfoList", Classes.FArrayProperty);
		BlockInfoByHitLevel_IsValid = ((intPtr != IntPtr.Zero && HitLevel_IsValid && BlockAMInfoList_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BlockInfoByHitLevel", (byte)BlockInfoByHitLevel_IsValid != 0);
	}

	static FBlockInfoByHitLevel()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FBlockInfoByHitLevel)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FBlockInfoByHitLevel));
	}
}
