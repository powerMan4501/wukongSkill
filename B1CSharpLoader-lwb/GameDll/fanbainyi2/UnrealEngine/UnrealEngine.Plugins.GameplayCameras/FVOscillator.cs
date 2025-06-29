using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GameplayCameras;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/GameplayCameras.VOscillator", "GameplayCameras", UnrealModuleType.EnginePlugin)]
public struct FVOscillator
{
	private static bool X_IsValid;

	private static int X_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/GameplayCameras.VOscillator:X")]
	public FOscillator X;

	private static bool Y_IsValid;

	private static int Y_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/GameplayCameras.VOscillator:Y")]
	public FOscillator Y;

	private static bool Z_IsValid;

	private static int Z_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/GameplayCameras.VOscillator:Z")]
	public FOscillator Z;

	private static bool FVOscillator_IsValid;

	private static int FVOscillator_StructSize;

	public FVOscillator Copy()
	{
		return this;
	}

	public static FVOscillator FromNative(IntPtr nativeBuffer)
	{
		return new FVOscillator(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FVOscillator value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FVOscillator FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FVOscillator(nativeBuffer + arrayIndex * FVOscillator_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FVOscillator value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FVOscillator_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FVOscillator_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GameplayCameras.VOscillator");
			return;
		}
		FOscillator.ToNative(IntPtr.Add(nativeStruct, X_Offset), X);
		FOscillator.ToNative(IntPtr.Add(nativeStruct, Y_Offset), Y);
		FOscillator.ToNative(IntPtr.Add(nativeStruct, Z_Offset), Z);
	}

	public FVOscillator(IntPtr nativeStruct)
	{
		if (!FVOscillator_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GameplayCameras.VOscillator");
			X = default(FOscillator);
			Y = default(FOscillator);
			Z = default(FOscillator);
		}
		else
		{
			X = FOscillator.FromNative(IntPtr.Add(nativeStruct, X_Offset));
			Y = FOscillator.FromNative(IntPtr.Add(nativeStruct, Y_Offset));
			Z = FOscillator.FromNative(IntPtr.Add(nativeStruct, Z_Offset));
		}
	}

	static FVOscillator()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FVOscillator)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FVOscillator));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GameplayCameras.VOscillator");
		FVOscillator_StructSize = NativeReflection.GetStructSize(intPtr);
		X_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "X");
		X_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "X", Classes.FStructProperty);
		Y_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Y");
		Y_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Y", Classes.FStructProperty);
		Z_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Z");
		Z_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Z", Classes.FStructProperty);
		FVOscillator_IsValid = intPtr != IntPtr.Zero && X_IsValid && Y_IsValid && Z_IsValid;
		NativeReflection.LogStructIsValid("/Script/GameplayCameras.VOscillator", FVOscillator_IsValid);
	}
}
