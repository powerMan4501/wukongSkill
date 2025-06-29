using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GameplayCameras;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/GameplayCameras.ROscillator", "GameplayCameras", UnrealModuleType.EnginePlugin)]
public struct FROscillator
{
	private static bool Pitch_IsValid;

	private static int Pitch_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/GameplayCameras.ROscillator:Pitch")]
	public FOscillator Pitch;

	private static bool Yaw_IsValid;

	private static int Yaw_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/GameplayCameras.ROscillator:Yaw")]
	public FOscillator Yaw;

	private static bool Roll_IsValid;

	private static int Roll_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/GameplayCameras.ROscillator:Roll")]
	public FOscillator Roll;

	private static bool FROscillator_IsValid;

	private static int FROscillator_StructSize;

	public FROscillator Copy()
	{
		return this;
	}

	public static FROscillator FromNative(IntPtr nativeBuffer)
	{
		return new FROscillator(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FROscillator value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FROscillator FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FROscillator(nativeBuffer + arrayIndex * FROscillator_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FROscillator value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FROscillator_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FROscillator_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GameplayCameras.ROscillator");
			return;
		}
		FOscillator.ToNative(IntPtr.Add(nativeStruct, Pitch_Offset), Pitch);
		FOscillator.ToNative(IntPtr.Add(nativeStruct, Yaw_Offset), Yaw);
		FOscillator.ToNative(IntPtr.Add(nativeStruct, Roll_Offset), Roll);
	}

	public FROscillator(IntPtr nativeStruct)
	{
		if (!FROscillator_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GameplayCameras.ROscillator");
			Pitch = default(FOscillator);
			Yaw = default(FOscillator);
			Roll = default(FOscillator);
		}
		else
		{
			Pitch = FOscillator.FromNative(IntPtr.Add(nativeStruct, Pitch_Offset));
			Yaw = FOscillator.FromNative(IntPtr.Add(nativeStruct, Yaw_Offset));
			Roll = FOscillator.FromNative(IntPtr.Add(nativeStruct, Roll_Offset));
		}
	}

	static FROscillator()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FROscillator)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FROscillator));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GameplayCameras.ROscillator");
		FROscillator_StructSize = NativeReflection.GetStructSize(intPtr);
		Pitch_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Pitch");
		Pitch_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Pitch", Classes.FStructProperty);
		Yaw_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Yaw");
		Yaw_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Yaw", Classes.FStructProperty);
		Roll_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Roll");
		Roll_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Roll", Classes.FStructProperty);
		FROscillator_IsValid = intPtr != IntPtr.Zero && Pitch_IsValid && Yaw_IsValid && Roll_IsValid;
		NativeReflection.LogStructIsValid("/Script/GameplayCameras.ROscillator", FROscillator_IsValid);
	}
}
