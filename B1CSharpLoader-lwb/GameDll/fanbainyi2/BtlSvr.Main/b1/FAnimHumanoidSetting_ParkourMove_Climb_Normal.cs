using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Climb_Normal")]
public struct FAnimHumanoidSetting_ParkourMove_Climb_Normal
{
	[EditAnywhere]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Climb_Normal:ASParkourNormalClimbStart")]
	public UAnimSequence ASParkourNormalClimbStart;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Climb_Normal:ASParkourNormalClimbGetUp")]
	public UAnimSequence ASParkourNormalClimbGetUp;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Climb_Normal:ASParkourNormalClimbFallLoop")]
	public UAnimSequence ASParkourNormalClimbFallLoop;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Climb_Normal:ASParkourNormalClimbLand")]
	public UAnimSequence ASParkourNormalClimbLand;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Climb_Normal:ASParkourNormalClimbLandMove")]
	public UAnimSequence ASParkourNormalClimbLandMove;

	private static int AnimHumanoidSetting_ParkourMove_Climb_Normal_StructSize;

	private static int AnimHumanoidSetting_ParkourMove_Climb_Normal_IsValid;

	private static bool ASParkourNormalClimbStart_IsValid;

	private static int ASParkourNormalClimbStart_Offset;

	private static bool ASParkourNormalClimbGetUp_IsValid;

	private static int ASParkourNormalClimbGetUp_Offset;

	private static bool ASParkourNormalClimbFallLoop_IsValid;

	private static int ASParkourNormalClimbFallLoop_Offset;

	private static bool ASParkourNormalClimbLand_IsValid;

	private static int ASParkourNormalClimbLand_Offset;

	private static bool ASParkourNormalClimbLandMove_IsValid;

	private static int ASParkourNormalClimbLandMove_Offset;

	public FAnimHumanoidSetting_ParkourMove_Climb_Normal Copy()
	{
		return this;
	}

	public static FAnimHumanoidSetting_ParkourMove_Climb_Normal FromNative(IntPtr nativeBuffer)
	{
		return new FAnimHumanoidSetting_ParkourMove_Climb_Normal(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimHumanoidSetting_ParkourMove_Climb_Normal value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimHumanoidSetting_ParkourMove_Climb_Normal FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimHumanoidSetting_ParkourMove_Climb_Normal(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_ParkourMove_Climb_Normal_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimHumanoidSetting_ParkourMove_Climb_Normal value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_ParkourMove_Climb_Normal_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_ParkourMove_Climb_Normal_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Climb_Normal");
			return;
		}
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASParkourNormalClimbStart_Offset), ASParkourNormalClimbStart);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASParkourNormalClimbGetUp_Offset), ASParkourNormalClimbGetUp);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASParkourNormalClimbFallLoop_Offset), ASParkourNormalClimbFallLoop);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASParkourNormalClimbLand_Offset), ASParkourNormalClimbLand);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASParkourNormalClimbLandMove_Offset), ASParkourNormalClimbLandMove);
	}

	public FAnimHumanoidSetting_ParkourMove_Climb_Normal(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_ParkourMove_Climb_Normal_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Climb_Normal");
			ASParkourNormalClimbStart = null;
			ASParkourNormalClimbGetUp = null;
			ASParkourNormalClimbFallLoop = null;
			ASParkourNormalClimbLand = null;
			ASParkourNormalClimbLandMove = null;
		}
		else
		{
			ASParkourNormalClimbStart = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASParkourNormalClimbStart_Offset));
			ASParkourNormalClimbGetUp = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASParkourNormalClimbGetUp_Offset));
			ASParkourNormalClimbFallLoop = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASParkourNormalClimbFallLoop_Offset));
			ASParkourNormalClimbLand = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASParkourNormalClimbLand_Offset));
			ASParkourNormalClimbLandMove = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASParkourNormalClimbLandMove_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Climb_Normal");
		AnimHumanoidSetting_ParkourMove_Climb_Normal_StructSize = NativeReflection.GetStructSize(intPtr);
		ASParkourNormalClimbStart_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASParkourNormalClimbStart");
		ASParkourNormalClimbStart_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASParkourNormalClimbStart", Classes.FObjectProperty);
		ASParkourNormalClimbGetUp_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASParkourNormalClimbGetUp");
		ASParkourNormalClimbGetUp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASParkourNormalClimbGetUp", Classes.FObjectProperty);
		ASParkourNormalClimbFallLoop_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASParkourNormalClimbFallLoop");
		ASParkourNormalClimbFallLoop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASParkourNormalClimbFallLoop", Classes.FObjectProperty);
		ASParkourNormalClimbLand_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASParkourNormalClimbLand");
		ASParkourNormalClimbLand_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASParkourNormalClimbLand", Classes.FObjectProperty);
		ASParkourNormalClimbLandMove_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASParkourNormalClimbLandMove");
		ASParkourNormalClimbLandMove_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASParkourNormalClimbLandMove", Classes.FObjectProperty);
		AnimHumanoidSetting_ParkourMove_Climb_Normal_IsValid = ((intPtr != IntPtr.Zero && ASParkourNormalClimbStart_IsValid && ASParkourNormalClimbGetUp_IsValid && ASParkourNormalClimbFallLoop_IsValid && ASParkourNormalClimbLand_IsValid && ASParkourNormalClimbLandMove_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Climb_Normal", (byte)AnimHumanoidSetting_ParkourMove_Climb_Normal_IsValid != 0);
	}

	static FAnimHumanoidSetting_ParkourMove_Climb_Normal()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FAnimHumanoidSetting_ParkourMove_Climb_Normal)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimHumanoidSetting_ParkourMove_Climb_Normal));
	}
}
