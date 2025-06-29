using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Climb_Low")]
public struct FAnimHumanoidSetting_ParkourMove_Climb_Low
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Climb_Low:ASParkourLowClimbStart")]
	public UAnimSequence ASParkourLowClimbStart;

	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Climb_Low:ASParkourLowClimbGetUp")]
	public UAnimSequence ASParkourLowClimbGetUp;

	[UProperty]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Climb_Low:ASParkourLowClimbFallLoop")]
	public UAnimSequence ASParkourLowClimbFallLoop;

	[UProperty]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Climb_Low:ASParkourLowClimbLand")]
	public UAnimSequence ASParkourLowClimbLand;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Climb_Low:ASParkourLowClimbLandMove")]
	public UAnimSequence ASParkourLowClimbLandMove;

	private static int AnimHumanoidSetting_ParkourMove_Climb_Low_StructSize;

	private static int AnimHumanoidSetting_ParkourMove_Climb_Low_IsValid;

	private static bool ASParkourLowClimbStart_IsValid;

	private static int ASParkourLowClimbStart_Offset;

	private static bool ASParkourLowClimbGetUp_IsValid;

	private static int ASParkourLowClimbGetUp_Offset;

	private static bool ASParkourLowClimbFallLoop_IsValid;

	private static int ASParkourLowClimbFallLoop_Offset;

	private static bool ASParkourLowClimbLand_IsValid;

	private static int ASParkourLowClimbLand_Offset;

	private static bool ASParkourLowClimbLandMove_IsValid;

	private static int ASParkourLowClimbLandMove_Offset;

	public FAnimHumanoidSetting_ParkourMove_Climb_Low Copy()
	{
		return this;
	}

	public static FAnimHumanoidSetting_ParkourMove_Climb_Low FromNative(IntPtr nativeBuffer)
	{
		return new FAnimHumanoidSetting_ParkourMove_Climb_Low(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimHumanoidSetting_ParkourMove_Climb_Low value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimHumanoidSetting_ParkourMove_Climb_Low FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimHumanoidSetting_ParkourMove_Climb_Low(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_ParkourMove_Climb_Low_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimHumanoidSetting_ParkourMove_Climb_Low value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_ParkourMove_Climb_Low_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_ParkourMove_Climb_Low_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Climb_Low");
			return;
		}
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASParkourLowClimbStart_Offset), ASParkourLowClimbStart);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASParkourLowClimbGetUp_Offset), ASParkourLowClimbGetUp);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASParkourLowClimbFallLoop_Offset), ASParkourLowClimbFallLoop);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASParkourLowClimbLand_Offset), ASParkourLowClimbLand);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASParkourLowClimbLandMove_Offset), ASParkourLowClimbLandMove);
	}

	public FAnimHumanoidSetting_ParkourMove_Climb_Low(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_ParkourMove_Climb_Low_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Climb_Low");
			ASParkourLowClimbStart = null;
			ASParkourLowClimbGetUp = null;
			ASParkourLowClimbFallLoop = null;
			ASParkourLowClimbLand = null;
			ASParkourLowClimbLandMove = null;
		}
		else
		{
			ASParkourLowClimbStart = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASParkourLowClimbStart_Offset));
			ASParkourLowClimbGetUp = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASParkourLowClimbGetUp_Offset));
			ASParkourLowClimbFallLoop = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASParkourLowClimbFallLoop_Offset));
			ASParkourLowClimbLand = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASParkourLowClimbLand_Offset));
			ASParkourLowClimbLandMove = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASParkourLowClimbLandMove_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Climb_Low");
		AnimHumanoidSetting_ParkourMove_Climb_Low_StructSize = NativeReflection.GetStructSize(intPtr);
		ASParkourLowClimbStart_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASParkourLowClimbStart");
		ASParkourLowClimbStart_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASParkourLowClimbStart", Classes.FObjectProperty);
		ASParkourLowClimbGetUp_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASParkourLowClimbGetUp");
		ASParkourLowClimbGetUp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASParkourLowClimbGetUp", Classes.FObjectProperty);
		ASParkourLowClimbFallLoop_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASParkourLowClimbFallLoop");
		ASParkourLowClimbFallLoop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASParkourLowClimbFallLoop", Classes.FObjectProperty);
		ASParkourLowClimbLand_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASParkourLowClimbLand");
		ASParkourLowClimbLand_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASParkourLowClimbLand", Classes.FObjectProperty);
		ASParkourLowClimbLandMove_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASParkourLowClimbLandMove");
		ASParkourLowClimbLandMove_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASParkourLowClimbLandMove", Classes.FObjectProperty);
		AnimHumanoidSetting_ParkourMove_Climb_Low_IsValid = ((intPtr != IntPtr.Zero && ASParkourLowClimbStart_IsValid && ASParkourLowClimbGetUp_IsValid && ASParkourLowClimbFallLoop_IsValid && ASParkourLowClimbLand_IsValid && ASParkourLowClimbLandMove_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Climb_Low", (byte)AnimHumanoidSetting_ParkourMove_Climb_Low_IsValid != 0);
	}

	static FAnimHumanoidSetting_ParkourMove_Climb_Low()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FAnimHumanoidSetting_ParkourMove_Climb_Low)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimHumanoidSetting_ParkourMove_Climb_Low));
	}
}
