using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Across_High")]
public struct FAnimHumanoidSetting_ParkourMove_Across_High
{
	[EditAnywhere]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Across_High:ASParkourHighAcrossStart")]
	public UAnimSequence ASParkourHighAcrossStart;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Across_High:ASParkourHighAcrossThrough")]
	public UAnimSequence ASParkourHighAcrossThrough;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Across_High:ASParkourHighAcrossFallLoop")]
	public UAnimSequence ASParkourHighAcrossFallLoop;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Across_High:ASParkourHighAcrossLand")]
	public UAnimSequence ASParkourHighAcrossLand;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Across_High:ASParkourHighAcrossLandMove")]
	public UAnimSequence ASParkourHighAcrossLandMove;

	private static int AnimHumanoidSetting_ParkourMove_Across_High_StructSize;

	private static int AnimHumanoidSetting_ParkourMove_Across_High_IsValid;

	private static bool ASParkourHighAcrossStart_IsValid;

	private static int ASParkourHighAcrossStart_Offset;

	private static bool ASParkourHighAcrossThrough_IsValid;

	private static int ASParkourHighAcrossThrough_Offset;

	private static bool ASParkourHighAcrossFallLoop_IsValid;

	private static int ASParkourHighAcrossFallLoop_Offset;

	private static bool ASParkourHighAcrossLand_IsValid;

	private static int ASParkourHighAcrossLand_Offset;

	private static bool ASParkourHighAcrossLandMove_IsValid;

	private static int ASParkourHighAcrossLandMove_Offset;

	public FAnimHumanoidSetting_ParkourMove_Across_High Copy()
	{
		return this;
	}

	public static FAnimHumanoidSetting_ParkourMove_Across_High FromNative(IntPtr nativeBuffer)
	{
		return new FAnimHumanoidSetting_ParkourMove_Across_High(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimHumanoidSetting_ParkourMove_Across_High value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimHumanoidSetting_ParkourMove_Across_High FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimHumanoidSetting_ParkourMove_Across_High(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_ParkourMove_Across_High_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimHumanoidSetting_ParkourMove_Across_High value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_ParkourMove_Across_High_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_ParkourMove_Across_High_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Across_High");
			return;
		}
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASParkourHighAcrossStart_Offset), ASParkourHighAcrossStart);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASParkourHighAcrossThrough_Offset), ASParkourHighAcrossThrough);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASParkourHighAcrossFallLoop_Offset), ASParkourHighAcrossFallLoop);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASParkourHighAcrossLand_Offset), ASParkourHighAcrossLand);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASParkourHighAcrossLandMove_Offset), ASParkourHighAcrossLandMove);
	}

	public FAnimHumanoidSetting_ParkourMove_Across_High(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_ParkourMove_Across_High_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Across_High");
			ASParkourHighAcrossStart = null;
			ASParkourHighAcrossThrough = null;
			ASParkourHighAcrossFallLoop = null;
			ASParkourHighAcrossLand = null;
			ASParkourHighAcrossLandMove = null;
		}
		else
		{
			ASParkourHighAcrossStart = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASParkourHighAcrossStart_Offset));
			ASParkourHighAcrossThrough = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASParkourHighAcrossThrough_Offset));
			ASParkourHighAcrossFallLoop = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASParkourHighAcrossFallLoop_Offset));
			ASParkourHighAcrossLand = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASParkourHighAcrossLand_Offset));
			ASParkourHighAcrossLandMove = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASParkourHighAcrossLandMove_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Across_High");
		AnimHumanoidSetting_ParkourMove_Across_High_StructSize = NativeReflection.GetStructSize(intPtr);
		ASParkourHighAcrossStart_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASParkourHighAcrossStart");
		ASParkourHighAcrossStart_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASParkourHighAcrossStart", Classes.FObjectProperty);
		ASParkourHighAcrossThrough_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASParkourHighAcrossThrough");
		ASParkourHighAcrossThrough_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASParkourHighAcrossThrough", Classes.FObjectProperty);
		ASParkourHighAcrossFallLoop_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASParkourHighAcrossFallLoop");
		ASParkourHighAcrossFallLoop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASParkourHighAcrossFallLoop", Classes.FObjectProperty);
		ASParkourHighAcrossLand_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASParkourHighAcrossLand");
		ASParkourHighAcrossLand_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASParkourHighAcrossLand", Classes.FObjectProperty);
		ASParkourHighAcrossLandMove_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASParkourHighAcrossLandMove");
		ASParkourHighAcrossLandMove_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASParkourHighAcrossLandMove", Classes.FObjectProperty);
		AnimHumanoidSetting_ParkourMove_Across_High_IsValid = ((intPtr != IntPtr.Zero && ASParkourHighAcrossStart_IsValid && ASParkourHighAcrossThrough_IsValid && ASParkourHighAcrossFallLoop_IsValid && ASParkourHighAcrossLand_IsValid && ASParkourHighAcrossLandMove_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Across_High", (byte)AnimHumanoidSetting_ParkourMove_Across_High_IsValid != 0);
	}

	static FAnimHumanoidSetting_ParkourMove_Across_High()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FAnimHumanoidSetting_ParkourMove_Across_High)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimHumanoidSetting_ParkourMove_Across_High));
	}
}
