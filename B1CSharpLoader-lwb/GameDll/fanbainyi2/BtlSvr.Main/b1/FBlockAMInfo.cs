using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.BlockAMInfo")]
public struct FBlockAMInfo
{
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("格挡动画期间BuffList")]
	[Tooltip("在格挡动画期间附加，动画结束移除")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BlockAMInfo:BlockBuffList")]
	public List<int> BlockBuffList;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[Tooltip("在格挡弹回动画期间附加，动画结束移除")]
	[DisplayName("格挡弹回动画期间BuffList")]
	[USharpPath("/Script/b1-Managed.BlockAMInfo:BlockBouncedBuffList")]
	public List<int> BlockBouncedBuffList;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[DisplayName("方向格挡动画信息")]
	[USharpPath("/Script/b1-Managed.BlockAMInfo:DirectBlockAMInfo")]
	public FDirectBlockAMInfo DirectBlockAMInfo;

	private static int BlockAMInfo_StructSize;

	private static int BlockAMInfo_IsValid;

	private static bool BlockBuffList_IsValid;

	private static int BlockBuffList_Offset;

	private static FFieldAddress BlockBuffList_PropertyAddress;

	private static bool BlockBouncedBuffList_IsValid;

	private static int BlockBouncedBuffList_Offset;

	private static FFieldAddress BlockBouncedBuffList_PropertyAddress;

	private static bool DirectBlockAMInfo_IsValid;

	private static int DirectBlockAMInfo_Offset;

	public FBlockAMInfo Copy()
	{
		FBlockAMInfo result = this;
		if (BlockBuffList != null)
		{
			result.BlockBuffList = new List<int>(BlockBuffList);
		}
		if (BlockBouncedBuffList != null)
		{
			result.BlockBouncedBuffList = new List<int>(BlockBouncedBuffList);
		}
		return result;
	}

	public static FBlockAMInfo FromNative(IntPtr nativeBuffer)
	{
		return new FBlockAMInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FBlockAMInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FBlockAMInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FBlockAMInfo(IntPtr.Add(nativeBuffer, arrayIndex * BlockAMInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FBlockAMInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BlockAMInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BlockAMInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BlockAMInfo");
			return;
		}
		new TArrayCopyMarshaler<int>(1, BlockBuffList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, BlockBuffList_Offset), BlockBuffList);
		new TArrayCopyMarshaler<int>(1, BlockBouncedBuffList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, BlockBouncedBuffList_Offset), BlockBouncedBuffList);
		FDirectBlockAMInfo.ToNative(IntPtr.Add(nativeStruct, DirectBlockAMInfo_Offset), DirectBlockAMInfo);
	}

	public FBlockAMInfo(IntPtr nativeStruct)
	{
		if (BlockAMInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BlockAMInfo");
			BlockBuffList = null;
			BlockBouncedBuffList = null;
			DirectBlockAMInfo = default(FDirectBlockAMInfo);
		}
		else
		{
			BlockBuffList = new TArrayCopyMarshaler<int>(1, BlockBuffList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, BlockBuffList_Offset));
			BlockBouncedBuffList = new TArrayCopyMarshaler<int>(1, BlockBouncedBuffList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, BlockBouncedBuffList_Offset));
			DirectBlockAMInfo = FDirectBlockAMInfo.FromNative(IntPtr.Add(nativeStruct, DirectBlockAMInfo_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BlockAMInfo");
		BlockAMInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref BlockBuffList_PropertyAddress, intPtr, "BlockBuffList");
		BlockBuffList_Offset = NativeReflection.GetPropertyOffset(intPtr, "BlockBuffList");
		BlockBuffList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BlockBuffList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref BlockBouncedBuffList_PropertyAddress, intPtr, "BlockBouncedBuffList");
		BlockBouncedBuffList_Offset = NativeReflection.GetPropertyOffset(intPtr, "BlockBouncedBuffList");
		BlockBouncedBuffList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BlockBouncedBuffList", Classes.FArrayProperty);
		DirectBlockAMInfo_Offset = NativeReflection.GetPropertyOffset(intPtr, "DirectBlockAMInfo");
		DirectBlockAMInfo_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DirectBlockAMInfo", Classes.FStructProperty);
		BlockAMInfo_IsValid = ((intPtr != IntPtr.Zero && BlockBuffList_IsValid && BlockBouncedBuffList_IsValid && DirectBlockAMInfo_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BlockAMInfo", (byte)BlockAMInfo_IsValid != 0);
	}

	static FBlockAMInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FBlockAMInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FBlockAMInfo));
	}
}
