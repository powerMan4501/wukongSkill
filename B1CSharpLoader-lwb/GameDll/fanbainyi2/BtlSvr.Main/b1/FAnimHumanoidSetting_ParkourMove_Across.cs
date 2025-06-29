using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Across")]
public struct FAnimHumanoidSetting_ParkourMove_Across
{
	[UProperty]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Across:Low")]
	public FAnimHumanoidSetting_ParkourMove_Across_Low Low;

	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Across:Normal")]
	public FAnimHumanoidSetting_ParkourMove_Across_Normal Normal;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Across:High")]
	public FAnimHumanoidSetting_ParkourMove_Across_High High;

	private static int AnimHumanoidSetting_ParkourMove_Across_StructSize;

	private static int AnimHumanoidSetting_ParkourMove_Across_IsValid;

	private static bool Low_IsValid;

	private static int Low_Offset;

	private static bool Normal_IsValid;

	private static int Normal_Offset;

	private static bool High_IsValid;

	private static int High_Offset;

	public FAnimHumanoidSetting_ParkourMove_Across Copy()
	{
		return this;
	}

	public static FAnimHumanoidSetting_ParkourMove_Across FromNative(IntPtr nativeBuffer)
	{
		return new FAnimHumanoidSetting_ParkourMove_Across(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimHumanoidSetting_ParkourMove_Across value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimHumanoidSetting_ParkourMove_Across FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimHumanoidSetting_ParkourMove_Across(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_ParkourMove_Across_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimHumanoidSetting_ParkourMove_Across value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_ParkourMove_Across_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_ParkourMove_Across_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Across");
			return;
		}
		FAnimHumanoidSetting_ParkourMove_Across_Low.ToNative(IntPtr.Add(nativeStruct, Low_Offset), Low);
		FAnimHumanoidSetting_ParkourMove_Across_Normal.ToNative(IntPtr.Add(nativeStruct, Normal_Offset), Normal);
		FAnimHumanoidSetting_ParkourMove_Across_High.ToNative(IntPtr.Add(nativeStruct, High_Offset), High);
	}

	public FAnimHumanoidSetting_ParkourMove_Across(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_ParkourMove_Across_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Across");
			Low = default(FAnimHumanoidSetting_ParkourMove_Across_Low);
			Normal = default(FAnimHumanoidSetting_ParkourMove_Across_Normal);
			High = default(FAnimHumanoidSetting_ParkourMove_Across_High);
		}
		else
		{
			Low = FAnimHumanoidSetting_ParkourMove_Across_Low.FromNative(IntPtr.Add(nativeStruct, Low_Offset));
			Normal = FAnimHumanoidSetting_ParkourMove_Across_Normal.FromNative(IntPtr.Add(nativeStruct, Normal_Offset));
			High = FAnimHumanoidSetting_ParkourMove_Across_High.FromNative(IntPtr.Add(nativeStruct, High_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Across");
		AnimHumanoidSetting_ParkourMove_Across_StructSize = NativeReflection.GetStructSize(intPtr);
		Low_Offset = NativeReflection.GetPropertyOffset(intPtr, "Low");
		Low_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Low", Classes.FStructProperty);
		Normal_Offset = NativeReflection.GetPropertyOffset(intPtr, "Normal");
		Normal_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Normal", Classes.FStructProperty);
		High_Offset = NativeReflection.GetPropertyOffset(intPtr, "High");
		High_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "High", Classes.FStructProperty);
		AnimHumanoidSetting_ParkourMove_Across_IsValid = ((intPtr != IntPtr.Zero && Low_IsValid && Normal_IsValid && High_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Across", (byte)AnimHumanoidSetting_ParkourMove_Across_IsValid != 0);
	}

	static FAnimHumanoidSetting_ParkourMove_Across()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FAnimHumanoidSetting_ParkourMove_Across)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimHumanoidSetting_ParkourMove_Across));
	}
}
