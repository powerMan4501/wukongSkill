using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.RebirthPointConfig")]
public struct FRebirthPointConfig
{
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.RebirthPointConfig:RebirthPointID")]
	public int RebirthPointID;

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.RebirthPointConfig:bActiveSetCurrentRebirthPoint")]
	public bool bActiveSetCurrentRebirthPoint;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.RebirthPointConfig:TargetCheckRange")]
	public int TargetCheckRange;

	private static int RebirthPointConfig_StructSize;

	private static int RebirthPointConfig_IsValid;

	private static bool RebirthPointID_IsValid;

	private static int RebirthPointID_Offset;

	private static bool bActiveSetCurrentRebirthPoint_IsValid;

	private static int bActiveSetCurrentRebirthPoint_Offset;

	private static FFieldAddress bActiveSetCurrentRebirthPoint_PropertyAddress;

	private static bool TargetCheckRange_IsValid;

	private static int TargetCheckRange_Offset;

	public FRebirthPointConfig Copy()
	{
		return this;
	}

	public static FRebirthPointConfig FromNative(IntPtr nativeBuffer)
	{
		return new FRebirthPointConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRebirthPointConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRebirthPointConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRebirthPointConfig(IntPtr.Add(nativeBuffer, arrayIndex * RebirthPointConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRebirthPointConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * RebirthPointConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (RebirthPointConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.RebirthPointConfig");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, RebirthPointID_Offset), RebirthPointID);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bActiveSetCurrentRebirthPoint_Offset), 0, bActiveSetCurrentRebirthPoint_PropertyAddress.Address, bActiveSetCurrentRebirthPoint);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, TargetCheckRange_Offset), TargetCheckRange);
	}

	public FRebirthPointConfig(IntPtr nativeStruct)
	{
		if (RebirthPointConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.RebirthPointConfig");
			RebirthPointID = 0;
			bActiveSetCurrentRebirthPoint = false;
			TargetCheckRange = 0;
		}
		else
		{
			RebirthPointID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, RebirthPointID_Offset));
			bActiveSetCurrentRebirthPoint = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bActiveSetCurrentRebirthPoint_Offset), 0, bActiveSetCurrentRebirthPoint_PropertyAddress.Address);
			TargetCheckRange = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, TargetCheckRange_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.RebirthPointConfig");
		RebirthPointConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		RebirthPointID_Offset = NativeReflection.GetPropertyOffset(intPtr, "RebirthPointID");
		RebirthPointID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RebirthPointID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref bActiveSetCurrentRebirthPoint_PropertyAddress, intPtr, "bActiveSetCurrentRebirthPoint");
		bActiveSetCurrentRebirthPoint_Offset = NativeReflection.GetPropertyOffset(intPtr, "bActiveSetCurrentRebirthPoint");
		bActiveSetCurrentRebirthPoint_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bActiveSetCurrentRebirthPoint", Classes.FBoolProperty);
		TargetCheckRange_Offset = NativeReflection.GetPropertyOffset(intPtr, "TargetCheckRange");
		TargetCheckRange_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TargetCheckRange", Classes.FIntProperty);
		RebirthPointConfig_IsValid = ((intPtr != IntPtr.Zero && RebirthPointID_IsValid && bActiveSetCurrentRebirthPoint_IsValid && TargetCheckRange_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.RebirthPointConfig", (byte)RebirthPointConfig_IsValid != 0);
	}

	static FRebirthPointConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FRebirthPointConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRebirthPointConfig));
	}
}
