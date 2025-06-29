using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Climb")]
public struct FAnimHumanoidSetting_ParkourMove_Climb
{
	[EditAnywhere]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Climb:Low")]
	public FAnimHumanoidSetting_ParkourMove_Climb_Low Low;

	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Climb:Normal")]
	public FAnimHumanoidSetting_ParkourMove_Climb_Normal Normal;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Climb:High")]
	public FAnimHumanoidSetting_ParkourMove_Climb_High High;

	private static int AnimHumanoidSetting_ParkourMove_Climb_StructSize;

	private static int AnimHumanoidSetting_ParkourMove_Climb_IsValid;

	private static bool Low_IsValid;

	private static int Low_Offset;

	private static bool Normal_IsValid;

	private static int Normal_Offset;

	private static bool High_IsValid;

	private static int High_Offset;

	public FAnimHumanoidSetting_ParkourMove_Climb Copy()
	{
		return this;
	}

	public static FAnimHumanoidSetting_ParkourMove_Climb FromNative(IntPtr nativeBuffer)
	{
		return new FAnimHumanoidSetting_ParkourMove_Climb(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimHumanoidSetting_ParkourMove_Climb value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimHumanoidSetting_ParkourMove_Climb FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimHumanoidSetting_ParkourMove_Climb(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_ParkourMove_Climb_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimHumanoidSetting_ParkourMove_Climb value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_ParkourMove_Climb_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_ParkourMove_Climb_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Climb");
			return;
		}
		FAnimHumanoidSetting_ParkourMove_Climb_Low.ToNative(IntPtr.Add(nativeStruct, Low_Offset), Low);
		FAnimHumanoidSetting_ParkourMove_Climb_Normal.ToNative(IntPtr.Add(nativeStruct, Normal_Offset), Normal);
		FAnimHumanoidSetting_ParkourMove_Climb_High.ToNative(IntPtr.Add(nativeStruct, High_Offset), High);
	}

	public FAnimHumanoidSetting_ParkourMove_Climb(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_ParkourMove_Climb_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Climb");
			Low = default(FAnimHumanoidSetting_ParkourMove_Climb_Low);
			Normal = default(FAnimHumanoidSetting_ParkourMove_Climb_Normal);
			High = default(FAnimHumanoidSetting_ParkourMove_Climb_High);
		}
		else
		{
			Low = FAnimHumanoidSetting_ParkourMove_Climb_Low.FromNative(IntPtr.Add(nativeStruct, Low_Offset));
			Normal = FAnimHumanoidSetting_ParkourMove_Climb_Normal.FromNative(IntPtr.Add(nativeStruct, Normal_Offset));
			High = FAnimHumanoidSetting_ParkourMove_Climb_High.FromNative(IntPtr.Add(nativeStruct, High_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Climb");
		AnimHumanoidSetting_ParkourMove_Climb_StructSize = NativeReflection.GetStructSize(intPtr);
		Low_Offset = NativeReflection.GetPropertyOffset(intPtr, "Low");
		Low_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Low", Classes.FStructProperty);
		Normal_Offset = NativeReflection.GetPropertyOffset(intPtr, "Normal");
		Normal_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Normal", Classes.FStructProperty);
		High_Offset = NativeReflection.GetPropertyOffset(intPtr, "High");
		High_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "High", Classes.FStructProperty);
		AnimHumanoidSetting_ParkourMove_Climb_IsValid = ((intPtr != IntPtr.Zero && Low_IsValid && Normal_IsValid && High_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Climb", (byte)AnimHumanoidSetting_ParkourMove_Climb_IsValid != 0);
	}

	static FAnimHumanoidSetting_ParkourMove_Climb()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FAnimHumanoidSetting_ParkourMove_Climb)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimHumanoidSetting_ParkourMove_Climb));
	}
}
