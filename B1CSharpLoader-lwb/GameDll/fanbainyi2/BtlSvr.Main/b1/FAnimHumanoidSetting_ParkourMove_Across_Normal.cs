using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Across_Normal")]
public struct FAnimHumanoidSetting_ParkourMove_Across_Normal
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Across_Normal:ASParkourNormalAcrossStart")]
	public UAnimSequence ASParkourNormalAcrossStart;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Across_Normal:ASParkourNormalAcrossThrough")]
	public UAnimSequence ASParkourNormalAcrossThrough;

	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Across_Normal:ASParkourNormalAcrossFallLoop")]
	public UAnimSequence ASParkourNormalAcrossFallLoop;

	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Across_Normal:ASParkourNormalAcrossLand")]
	public UAnimSequence ASParkourNormalAcrossLand;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Across_Normal:ASParkourNormalAcrossLandMove")]
	public UAnimSequence ASParkourNormalAcrossLandMove;

	private static int AnimHumanoidSetting_ParkourMove_Across_Normal_StructSize;

	private static int AnimHumanoidSetting_ParkourMove_Across_Normal_IsValid;

	private static bool ASParkourNormalAcrossStart_IsValid;

	private static int ASParkourNormalAcrossStart_Offset;

	private static bool ASParkourNormalAcrossThrough_IsValid;

	private static int ASParkourNormalAcrossThrough_Offset;

	private static bool ASParkourNormalAcrossFallLoop_IsValid;

	private static int ASParkourNormalAcrossFallLoop_Offset;

	private static bool ASParkourNormalAcrossLand_IsValid;

	private static int ASParkourNormalAcrossLand_Offset;

	private static bool ASParkourNormalAcrossLandMove_IsValid;

	private static int ASParkourNormalAcrossLandMove_Offset;

	public FAnimHumanoidSetting_ParkourMove_Across_Normal Copy()
	{
		return this;
	}

	public static FAnimHumanoidSetting_ParkourMove_Across_Normal FromNative(IntPtr nativeBuffer)
	{
		return new FAnimHumanoidSetting_ParkourMove_Across_Normal(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimHumanoidSetting_ParkourMove_Across_Normal value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimHumanoidSetting_ParkourMove_Across_Normal FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimHumanoidSetting_ParkourMove_Across_Normal(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_ParkourMove_Across_Normal_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimHumanoidSetting_ParkourMove_Across_Normal value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_ParkourMove_Across_Normal_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_ParkourMove_Across_Normal_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Across_Normal");
			return;
		}
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASParkourNormalAcrossStart_Offset), ASParkourNormalAcrossStart);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASParkourNormalAcrossThrough_Offset), ASParkourNormalAcrossThrough);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASParkourNormalAcrossFallLoop_Offset), ASParkourNormalAcrossFallLoop);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASParkourNormalAcrossLand_Offset), ASParkourNormalAcrossLand);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASParkourNormalAcrossLandMove_Offset), ASParkourNormalAcrossLandMove);
	}

	public FAnimHumanoidSetting_ParkourMove_Across_Normal(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_ParkourMove_Across_Normal_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Across_Normal");
			ASParkourNormalAcrossStart = null;
			ASParkourNormalAcrossThrough = null;
			ASParkourNormalAcrossFallLoop = null;
			ASParkourNormalAcrossLand = null;
			ASParkourNormalAcrossLandMove = null;
		}
		else
		{
			ASParkourNormalAcrossStart = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASParkourNormalAcrossStart_Offset));
			ASParkourNormalAcrossThrough = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASParkourNormalAcrossThrough_Offset));
			ASParkourNormalAcrossFallLoop = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASParkourNormalAcrossFallLoop_Offset));
			ASParkourNormalAcrossLand = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASParkourNormalAcrossLand_Offset));
			ASParkourNormalAcrossLandMove = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASParkourNormalAcrossLandMove_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Across_Normal");
		AnimHumanoidSetting_ParkourMove_Across_Normal_StructSize = NativeReflection.GetStructSize(intPtr);
		ASParkourNormalAcrossStart_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASParkourNormalAcrossStart");
		ASParkourNormalAcrossStart_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASParkourNormalAcrossStart", Classes.FObjectProperty);
		ASParkourNormalAcrossThrough_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASParkourNormalAcrossThrough");
		ASParkourNormalAcrossThrough_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASParkourNormalAcrossThrough", Classes.FObjectProperty);
		ASParkourNormalAcrossFallLoop_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASParkourNormalAcrossFallLoop");
		ASParkourNormalAcrossFallLoop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASParkourNormalAcrossFallLoop", Classes.FObjectProperty);
		ASParkourNormalAcrossLand_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASParkourNormalAcrossLand");
		ASParkourNormalAcrossLand_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASParkourNormalAcrossLand", Classes.FObjectProperty);
		ASParkourNormalAcrossLandMove_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASParkourNormalAcrossLandMove");
		ASParkourNormalAcrossLandMove_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASParkourNormalAcrossLandMove", Classes.FObjectProperty);
		AnimHumanoidSetting_ParkourMove_Across_Normal_IsValid = ((intPtr != IntPtr.Zero && ASParkourNormalAcrossStart_IsValid && ASParkourNormalAcrossThrough_IsValid && ASParkourNormalAcrossFallLoop_IsValid && ASParkourNormalAcrossLand_IsValid && ASParkourNormalAcrossLandMove_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove_Across_Normal", (byte)AnimHumanoidSetting_ParkourMove_Across_Normal_IsValid != 0);
	}

	static FAnimHumanoidSetting_ParkourMove_Across_Normal()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FAnimHumanoidSetting_ParkourMove_Across_Normal)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimHumanoidSetting_ParkourMove_Across_Normal));
	}
}
