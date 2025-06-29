using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_GlideMove_Start")]
public struct FAnimHumanoidSetting_GlideMove_Start
{
	[UProperty]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_GlideMove_Start:ASGlideStartGroundFlatSlow")]
	public UAnimSequence ASGlideStartGroundFlatSlow;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_GlideMove_Start:ASGlideStartGroundFlatFast")]
	public UAnimSequence ASGlideStartGroundFlatFast;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_GlideMove_Start:ASGlideStartGroundSteepSlow")]
	public UAnimSequence ASGlideStartGroundSteepSlow;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_GlideMove_Start:ASGlideStartGroundSteepFast")]
	public UAnimSequence ASGlideStartGroundSteepFast;

	[UProperty]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_GlideMove_Start:ASGlideStartAirFlatSlow")]
	public UAnimSequence ASGlideStartAirFlatSlow;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_GlideMove_Start:ASGlideStartAirFlatFast")]
	public UAnimSequence ASGlideStartAirFlatFast;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_GlideMove_Start:ASGlideStartAirSteepSlow")]
	public UAnimSequence ASGlideStartAirSteepSlow;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_GlideMove_Start:ASGlideStartAirSteepFast")]
	public UAnimSequence ASGlideStartAirSteepFast;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_GlideMove_Start:ASGlideStartBackAirFlat")]
	public UAnimSequence ASGlideStartBackAirFlat;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_GlideMove_Start:ASGlideStartBackAirSteep")]
	public UAnimSequence ASGlideStartBackAirSteep;

	private static int AnimHumanoidSetting_GlideMove_Start_StructSize;

	private static int AnimHumanoidSetting_GlideMove_Start_IsValid;

	private static bool ASGlideStartGroundFlatSlow_IsValid;

	private static int ASGlideStartGroundFlatSlow_Offset;

	private static bool ASGlideStartGroundFlatFast_IsValid;

	private static int ASGlideStartGroundFlatFast_Offset;

	private static bool ASGlideStartGroundSteepSlow_IsValid;

	private static int ASGlideStartGroundSteepSlow_Offset;

	private static bool ASGlideStartGroundSteepFast_IsValid;

	private static int ASGlideStartGroundSteepFast_Offset;

	private static bool ASGlideStartAirFlatSlow_IsValid;

	private static int ASGlideStartAirFlatSlow_Offset;

	private static bool ASGlideStartAirFlatFast_IsValid;

	private static int ASGlideStartAirFlatFast_Offset;

	private static bool ASGlideStartAirSteepSlow_IsValid;

	private static int ASGlideStartAirSteepSlow_Offset;

	private static bool ASGlideStartAirSteepFast_IsValid;

	private static int ASGlideStartAirSteepFast_Offset;

	private static bool ASGlideStartBackAirFlat_IsValid;

	private static int ASGlideStartBackAirFlat_Offset;

	private static bool ASGlideStartBackAirSteep_IsValid;

	private static int ASGlideStartBackAirSteep_Offset;

	public FAnimHumanoidSetting_GlideMove_Start Copy()
	{
		return this;
	}

	public static FAnimHumanoidSetting_GlideMove_Start FromNative(IntPtr nativeBuffer)
	{
		return new FAnimHumanoidSetting_GlideMove_Start(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimHumanoidSetting_GlideMove_Start value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimHumanoidSetting_GlideMove_Start FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimHumanoidSetting_GlideMove_Start(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_GlideMove_Start_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimHumanoidSetting_GlideMove_Start value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_GlideMove_Start_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_GlideMove_Start_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_GlideMove_Start");
			return;
		}
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASGlideStartGroundFlatSlow_Offset), ASGlideStartGroundFlatSlow);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASGlideStartGroundFlatFast_Offset), ASGlideStartGroundFlatFast);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASGlideStartGroundSteepSlow_Offset), ASGlideStartGroundSteepSlow);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASGlideStartGroundSteepFast_Offset), ASGlideStartGroundSteepFast);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASGlideStartAirFlatSlow_Offset), ASGlideStartAirFlatSlow);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASGlideStartAirFlatFast_Offset), ASGlideStartAirFlatFast);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASGlideStartAirSteepSlow_Offset), ASGlideStartAirSteepSlow);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASGlideStartAirSteepFast_Offset), ASGlideStartAirSteepFast);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASGlideStartBackAirFlat_Offset), ASGlideStartBackAirFlat);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASGlideStartBackAirSteep_Offset), ASGlideStartBackAirSteep);
	}

	public FAnimHumanoidSetting_GlideMove_Start(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_GlideMove_Start_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_GlideMove_Start");
			ASGlideStartGroundFlatSlow = null;
			ASGlideStartGroundFlatFast = null;
			ASGlideStartGroundSteepSlow = null;
			ASGlideStartGroundSteepFast = null;
			ASGlideStartAirFlatSlow = null;
			ASGlideStartAirFlatFast = null;
			ASGlideStartAirSteepSlow = null;
			ASGlideStartAirSteepFast = null;
			ASGlideStartBackAirFlat = null;
			ASGlideStartBackAirSteep = null;
		}
		else
		{
			ASGlideStartGroundFlatSlow = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASGlideStartGroundFlatSlow_Offset));
			ASGlideStartGroundFlatFast = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASGlideStartGroundFlatFast_Offset));
			ASGlideStartGroundSteepSlow = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASGlideStartGroundSteepSlow_Offset));
			ASGlideStartGroundSteepFast = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASGlideStartGroundSteepFast_Offset));
			ASGlideStartAirFlatSlow = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASGlideStartAirFlatSlow_Offset));
			ASGlideStartAirFlatFast = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASGlideStartAirFlatFast_Offset));
			ASGlideStartAirSteepSlow = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASGlideStartAirSteepSlow_Offset));
			ASGlideStartAirSteepFast = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASGlideStartAirSteepFast_Offset));
			ASGlideStartBackAirFlat = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASGlideStartBackAirFlat_Offset));
			ASGlideStartBackAirSteep = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASGlideStartBackAirSteep_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.AnimHumanoidSetting_GlideMove_Start");
		AnimHumanoidSetting_GlideMove_Start_StructSize = NativeReflection.GetStructSize(intPtr);
		ASGlideStartGroundFlatSlow_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASGlideStartGroundFlatSlow");
		ASGlideStartGroundFlatSlow_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASGlideStartGroundFlatSlow", Classes.FObjectProperty);
		ASGlideStartGroundFlatFast_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASGlideStartGroundFlatFast");
		ASGlideStartGroundFlatFast_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASGlideStartGroundFlatFast", Classes.FObjectProperty);
		ASGlideStartGroundSteepSlow_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASGlideStartGroundSteepSlow");
		ASGlideStartGroundSteepSlow_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASGlideStartGroundSteepSlow", Classes.FObjectProperty);
		ASGlideStartGroundSteepFast_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASGlideStartGroundSteepFast");
		ASGlideStartGroundSteepFast_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASGlideStartGroundSteepFast", Classes.FObjectProperty);
		ASGlideStartAirFlatSlow_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASGlideStartAirFlatSlow");
		ASGlideStartAirFlatSlow_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASGlideStartAirFlatSlow", Classes.FObjectProperty);
		ASGlideStartAirFlatFast_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASGlideStartAirFlatFast");
		ASGlideStartAirFlatFast_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASGlideStartAirFlatFast", Classes.FObjectProperty);
		ASGlideStartAirSteepSlow_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASGlideStartAirSteepSlow");
		ASGlideStartAirSteepSlow_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASGlideStartAirSteepSlow", Classes.FObjectProperty);
		ASGlideStartAirSteepFast_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASGlideStartAirSteepFast");
		ASGlideStartAirSteepFast_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASGlideStartAirSteepFast", Classes.FObjectProperty);
		ASGlideStartBackAirFlat_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASGlideStartBackAirFlat");
		ASGlideStartBackAirFlat_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASGlideStartBackAirFlat", Classes.FObjectProperty);
		ASGlideStartBackAirSteep_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASGlideStartBackAirSteep");
		ASGlideStartBackAirSteep_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASGlideStartBackAirSteep", Classes.FObjectProperty);
		AnimHumanoidSetting_GlideMove_Start_IsValid = ((intPtr != IntPtr.Zero && ASGlideStartGroundFlatSlow_IsValid && ASGlideStartGroundFlatFast_IsValid && ASGlideStartGroundSteepSlow_IsValid && ASGlideStartGroundSteepFast_IsValid && ASGlideStartAirFlatSlow_IsValid && ASGlideStartAirFlatFast_IsValid && ASGlideStartAirSteepSlow_IsValid && ASGlideStartAirSteepFast_IsValid && ASGlideStartBackAirFlat_IsValid && ASGlideStartBackAirSteep_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.AnimHumanoidSetting_GlideMove_Start", (byte)AnimHumanoidSetting_GlideMove_Start_IsValid != 0);
	}

	static FAnimHumanoidSetting_GlideMove_Start()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FAnimHumanoidSetting_GlideMove_Start)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimHumanoidSetting_GlideMove_Start));
	}
}
