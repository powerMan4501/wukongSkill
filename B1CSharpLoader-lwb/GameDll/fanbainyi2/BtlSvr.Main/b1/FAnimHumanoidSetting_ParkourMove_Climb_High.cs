using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Climb_High")]
public struct FAnimHumanoidSetting_ParkourMove_Climb_High
{
	[UProperty]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Climb_High:ASParkourHighClimbStart")]
	public UAnimSequence ASParkourHighClimbStart;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Climb_High:ASParkourHighClimbGetUp")]
	public UAnimSequence ASParkourHighClimbGetUp;

	[UProperty]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Climb_High:ASParkourHighClimbFallLoop")]
	public UAnimSequence ASParkourHighClimbFallLoop;

	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Climb_High:ASParkourHighClimbLand")]
	public UAnimSequence ASParkourHighClimbLand;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Climb_High:ASParkourHighClimbLandMove")]
	public UAnimSequence ASParkourHighClimbLandMove;

	private static int AnimHumanoidSetting_ParkourMove_Climb_High_StructSize;

	private static int AnimHumanoidSetting_ParkourMove_Climb_High_IsValid;

	private static bool ASParkourHighClimbStart_IsValid;

	private static int ASParkourHighClimbStart_Offset;

	private static bool ASParkourHighClimbGetUp_IsValid;

	private static int ASParkourHighClimbGetUp_Offset;

	private static bool ASParkourHighClimbFallLoop_IsValid;

	private static int ASParkourHighClimbFallLoop_Offset;

	private static bool ASParkourHighClimbLand_IsValid;

	private static int ASParkourHighClimbLand_Offset;

	private static bool ASParkourHighClimbLandMove_IsValid;

	private static int ASParkourHighClimbLandMove_Offset;

	public FAnimHumanoidSetting_ParkourMove_Climb_High Copy()
	{
		return this;
	}

	public static FAnimHumanoidSetting_ParkourMove_Climb_High FromNative(IntPtr nativeBuffer)
	{
		return new FAnimHumanoidSetting_ParkourMove_Climb_High(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimHumanoidSetting_ParkourMove_Climb_High value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimHumanoidSetting_ParkourMove_Climb_High FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimHumanoidSetting_ParkourMove_Climb_High(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_ParkourMove_Climb_High_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimHumanoidSetting_ParkourMove_Climb_High value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_ParkourMove_Climb_High_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_ParkourMove_Climb_High_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Climb_High");
			return;
		}
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASParkourHighClimbStart_Offset), ASParkourHighClimbStart);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASParkourHighClimbGetUp_Offset), ASParkourHighClimbGetUp);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASParkourHighClimbFallLoop_Offset), ASParkourHighClimbFallLoop);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASParkourHighClimbLand_Offset), ASParkourHighClimbLand);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASParkourHighClimbLandMove_Offset), ASParkourHighClimbLandMove);
	}

	public FAnimHumanoidSetting_ParkourMove_Climb_High(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_ParkourMove_Climb_High_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Climb_High");
			ASParkourHighClimbStart = null;
			ASParkourHighClimbGetUp = null;
			ASParkourHighClimbFallLoop = null;
			ASParkourHighClimbLand = null;
			ASParkourHighClimbLandMove = null;
		}
		else
		{
			ASParkourHighClimbStart = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASParkourHighClimbStart_Offset));
			ASParkourHighClimbGetUp = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASParkourHighClimbGetUp_Offset));
			ASParkourHighClimbFallLoop = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASParkourHighClimbFallLoop_Offset));
			ASParkourHighClimbLand = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASParkourHighClimbLand_Offset));
			ASParkourHighClimbLandMove = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASParkourHighClimbLandMove_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Climb_High");
		AnimHumanoidSetting_ParkourMove_Climb_High_StructSize = NativeReflection.GetStructSize(intPtr);
		ASParkourHighClimbStart_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASParkourHighClimbStart");
		ASParkourHighClimbStart_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASParkourHighClimbStart", Classes.FObjectProperty);
		ASParkourHighClimbGetUp_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASParkourHighClimbGetUp");
		ASParkourHighClimbGetUp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASParkourHighClimbGetUp", Classes.FObjectProperty);
		ASParkourHighClimbFallLoop_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASParkourHighClimbFallLoop");
		ASParkourHighClimbFallLoop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASParkourHighClimbFallLoop", Classes.FObjectProperty);
		ASParkourHighClimbLand_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASParkourHighClimbLand");
		ASParkourHighClimbLand_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASParkourHighClimbLand", Classes.FObjectProperty);
		ASParkourHighClimbLandMove_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASParkourHighClimbLandMove");
		ASParkourHighClimbLandMove_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASParkourHighClimbLandMove", Classes.FObjectProperty);
		AnimHumanoidSetting_ParkourMove_Climb_High_IsValid = ((intPtr != IntPtr.Zero && ASParkourHighClimbStart_IsValid && ASParkourHighClimbGetUp_IsValid && ASParkourHighClimbFallLoop_IsValid && ASParkourHighClimbLand_IsValid && ASParkourHighClimbLandMove_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Climb_High", (byte)AnimHumanoidSetting_ParkourMove_Climb_High_IsValid != 0);
	}

	static FAnimHumanoidSetting_ParkourMove_Climb_High()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FAnimHumanoidSetting_ParkourMove_Climb_High)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimHumanoidSetting_ParkourMove_Climb_High));
	}
}
