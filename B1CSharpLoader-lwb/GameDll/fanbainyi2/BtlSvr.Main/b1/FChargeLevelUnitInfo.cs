using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.ChargeLevelUnitInfo")]
public struct FChargeLevelUnitInfo
{
	[BlueprintReadOnly]
	[DisplayName("进入下一等级需要的时间")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.ChargeLevelUnitInfo:Duration")]
	public float Duration;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[DisplayName("当前等级中携带的Buff")]
	[USharpPath("/Script/b1-Managed.ChargeLevelUnitInfo:BuffList")]
	public List<int> BuffList;

	[DisplayName("当前等级在蓄力Loop中携带的Buff")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.ChargeLevelUnitInfo:LoopBuffList")]
	public List<int> LoopBuffList;

	private static int ChargeLevelUnitInfo_StructSize;

	private static int ChargeLevelUnitInfo_IsValid;

	private static bool Duration_IsValid;

	private static int Duration_Offset;

	private static bool BuffList_IsValid;

	private static int BuffList_Offset;

	private static FFieldAddress BuffList_PropertyAddress;

	private static bool LoopBuffList_IsValid;

	private static int LoopBuffList_Offset;

	private static FFieldAddress LoopBuffList_PropertyAddress;

	public FChargeLevelUnitInfo Copy()
	{
		FChargeLevelUnitInfo result = this;
		if (BuffList != null)
		{
			result.BuffList = new List<int>(BuffList);
		}
		if (LoopBuffList != null)
		{
			result.LoopBuffList = new List<int>(LoopBuffList);
		}
		return result;
	}

	public static FChargeLevelUnitInfo FromNative(IntPtr nativeBuffer)
	{
		return new FChargeLevelUnitInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FChargeLevelUnitInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FChargeLevelUnitInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FChargeLevelUnitInfo(IntPtr.Add(nativeBuffer, arrayIndex * ChargeLevelUnitInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FChargeLevelUnitInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * ChargeLevelUnitInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (ChargeLevelUnitInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ChargeLevelUnitInfo");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Duration_Offset), Duration);
		new TArrayCopyMarshaler<int>(1, BuffList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, BuffList_Offset), BuffList);
		new TArrayCopyMarshaler<int>(1, LoopBuffList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, LoopBuffList_Offset), LoopBuffList);
	}

	public FChargeLevelUnitInfo(IntPtr nativeStruct)
	{
		if (ChargeLevelUnitInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ChargeLevelUnitInfo");
			Duration = 0f;
			BuffList = null;
			LoopBuffList = null;
		}
		else
		{
			Duration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Duration_Offset));
			BuffList = new TArrayCopyMarshaler<int>(1, BuffList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, BuffList_Offset));
			LoopBuffList = new TArrayCopyMarshaler<int>(1, LoopBuffList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, LoopBuffList_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.ChargeLevelUnitInfo");
		ChargeLevelUnitInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		Duration_Offset = NativeReflection.GetPropertyOffset(intPtr, "Duration");
		Duration_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Duration", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref BuffList_PropertyAddress, intPtr, "BuffList");
		BuffList_Offset = NativeReflection.GetPropertyOffset(intPtr, "BuffList");
		BuffList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BuffList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref LoopBuffList_PropertyAddress, intPtr, "LoopBuffList");
		LoopBuffList_Offset = NativeReflection.GetPropertyOffset(intPtr, "LoopBuffList");
		LoopBuffList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LoopBuffList", Classes.FArrayProperty);
		ChargeLevelUnitInfo_IsValid = ((intPtr != IntPtr.Zero && Duration_IsValid && BuffList_IsValid && LoopBuffList_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.ChargeLevelUnitInfo", (byte)ChargeLevelUnitInfo_IsValid != 0);
	}

	static FChargeLevelUnitInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FChargeLevelUnitInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FChargeLevelUnitInfo));
	}
}
