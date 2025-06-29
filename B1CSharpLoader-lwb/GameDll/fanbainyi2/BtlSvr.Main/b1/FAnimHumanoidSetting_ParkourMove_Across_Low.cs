using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Across_Low")]
public struct FAnimHumanoidSetting_ParkourMove_Across_Low
{
	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Across_Low:ASParkourLowAcrossStart")]
	public UAnimSequence ASParkourLowAcrossStart;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Across_Low:ASParkourLowAcrossThrough")]
	public UAnimSequence ASParkourLowAcrossThrough;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Across_Low:ASParkourLowAcrossFallLoop")]
	public UAnimSequence ASParkourLowAcrossFallLoop;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Across_Low:ASParkourLowAcrossLand")]
	public UAnimSequence ASParkourLowAcrossLand;

	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Across_Low:ASParkourLowAcrossLandMove")]
	public UAnimSequence ASParkourLowAcrossLandMove;

	private static int AnimHumanoidSetting_ParkourMove_Across_Low_StructSize;

	private static int AnimHumanoidSetting_ParkourMove_Across_Low_IsValid;

	private static bool ASParkourLowAcrossStart_IsValid;

	private static int ASParkourLowAcrossStart_Offset;

	private static bool ASParkourLowAcrossThrough_IsValid;

	private static int ASParkourLowAcrossThrough_Offset;

	private static bool ASParkourLowAcrossFallLoop_IsValid;

	private static int ASParkourLowAcrossFallLoop_Offset;

	private static bool ASParkourLowAcrossLand_IsValid;

	private static int ASParkourLowAcrossLand_Offset;

	private static bool ASParkourLowAcrossLandMove_IsValid;

	private static int ASParkourLowAcrossLandMove_Offset;

	public FAnimHumanoidSetting_ParkourMove_Across_Low Copy()
	{
		return this;
	}

	public static FAnimHumanoidSetting_ParkourMove_Across_Low FromNative(IntPtr nativeBuffer)
	{
		return new FAnimHumanoidSetting_ParkourMove_Across_Low(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimHumanoidSetting_ParkourMove_Across_Low value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimHumanoidSetting_ParkourMove_Across_Low FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimHumanoidSetting_ParkourMove_Across_Low(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_ParkourMove_Across_Low_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimHumanoidSetting_ParkourMove_Across_Low value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_ParkourMove_Across_Low_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_ParkourMove_Across_Low_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Across_Low");
			return;
		}
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASParkourLowAcrossStart_Offset), ASParkourLowAcrossStart);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASParkourLowAcrossThrough_Offset), ASParkourLowAcrossThrough);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASParkourLowAcrossFallLoop_Offset), ASParkourLowAcrossFallLoop);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASParkourLowAcrossLand_Offset), ASParkourLowAcrossLand);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASParkourLowAcrossLandMove_Offset), ASParkourLowAcrossLandMove);
	}

	public FAnimHumanoidSetting_ParkourMove_Across_Low(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_ParkourMove_Across_Low_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Across_Low");
			ASParkourLowAcrossStart = null;
			ASParkourLowAcrossThrough = null;
			ASParkourLowAcrossFallLoop = null;
			ASParkourLowAcrossLand = null;
			ASParkourLowAcrossLandMove = null;
		}
		else
		{
			ASParkourLowAcrossStart = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASParkourLowAcrossStart_Offset));
			ASParkourLowAcrossThrough = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASParkourLowAcrossThrough_Offset));
			ASParkourLowAcrossFallLoop = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASParkourLowAcrossFallLoop_Offset));
			ASParkourLowAcrossLand = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASParkourLowAcrossLand_Offset));
			ASParkourLowAcrossLandMove = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASParkourLowAcrossLandMove_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Across_Low");
		AnimHumanoidSetting_ParkourMove_Across_Low_StructSize = NativeReflection.GetStructSize(intPtr);
		ASParkourLowAcrossStart_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASParkourLowAcrossStart");
		ASParkourLowAcrossStart_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASParkourLowAcrossStart", Classes.FObjectProperty);
		ASParkourLowAcrossThrough_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASParkourLowAcrossThrough");
		ASParkourLowAcrossThrough_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASParkourLowAcrossThrough", Classes.FObjectProperty);
		ASParkourLowAcrossFallLoop_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASParkourLowAcrossFallLoop");
		ASParkourLowAcrossFallLoop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASParkourLowAcrossFallLoop", Classes.FObjectProperty);
		ASParkourLowAcrossLand_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASParkourLowAcrossLand");
		ASParkourLowAcrossLand_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASParkourLowAcrossLand", Classes.FObjectProperty);
		ASParkourLowAcrossLandMove_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASParkourLowAcrossLandMove");
		ASParkourLowAcrossLandMove_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASParkourLowAcrossLandMove", Classes.FObjectProperty);
		AnimHumanoidSetting_ParkourMove_Across_Low_IsValid = ((intPtr != IntPtr.Zero && ASParkourLowAcrossStart_IsValid && ASParkourLowAcrossThrough_IsValid && ASParkourLowAcrossFallLoop_IsValid && ASParkourLowAcrossLand_IsValid && ASParkourLowAcrossLandMove_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Across_Low", (byte)AnimHumanoidSetting_ParkourMove_Across_Low_IsValid != 0);
	}

	static FAnimHumanoidSetting_ParkourMove_Across_Low()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FAnimHumanoidSetting_ParkourMove_Across_Low)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimHumanoidSetting_ParkourMove_Across_Low));
	}
}
