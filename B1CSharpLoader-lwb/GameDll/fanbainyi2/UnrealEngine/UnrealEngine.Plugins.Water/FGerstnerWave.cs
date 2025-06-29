using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Water;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Water.GerstnerWave", "Water", UnrealModuleType.EnginePlugin)]
public struct FGerstnerWave
{
	private static bool WaveLength_IsValid;

	private static int WaveLength_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Water.GerstnerWave:WaveLength")]
	public float WaveLength;

	private static bool Amplitude_IsValid;

	private static int Amplitude_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Water.GerstnerWave:Amplitude")]
	public float Amplitude;

	private static bool Steepness_IsValid;

	private static int Steepness_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Water.GerstnerWave:Steepness")]
	public float Steepness;

	private static bool Direction_IsValid;

	private static int Direction_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Water.GerstnerWave:Direction")]
	public FVector Direction;

	private static bool FGerstnerWave_IsValid;

	private static int FGerstnerWave_StructSize;

	public FGerstnerWave Copy()
	{
		return this;
	}

	public static FGerstnerWave FromNative(IntPtr nativeBuffer)
	{
		return new FGerstnerWave(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGerstnerWave value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGerstnerWave FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGerstnerWave(nativeBuffer + arrayIndex * FGerstnerWave_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGerstnerWave value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGerstnerWave_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGerstnerWave_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Water.GerstnerWave");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, WaveLength_Offset), WaveLength);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Amplitude_Offset), Amplitude);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Steepness_Offset), Steepness);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Direction_Offset), Direction);
	}

	public FGerstnerWave(IntPtr nativeStruct)
	{
		if (!FGerstnerWave_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Water.GerstnerWave");
			WaveLength = 0f;
			Amplitude = 0f;
			Steepness = 0f;
			Direction = default(FVector);
		}
		else
		{
			WaveLength = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, WaveLength_Offset));
			Amplitude = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Amplitude_Offset));
			Steepness = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Steepness_Offset));
			Direction = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Direction_Offset));
		}
	}

	static FGerstnerWave()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGerstnerWave)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGerstnerWave));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Water.GerstnerWave");
		FGerstnerWave_StructSize = NativeReflection.GetStructSize(intPtr);
		WaveLength_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WaveLength");
		WaveLength_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WaveLength", Classes.FFloatProperty);
		Amplitude_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Amplitude");
		Amplitude_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Amplitude", Classes.FFloatProperty);
		Steepness_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Steepness");
		Steepness_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Steepness", Classes.FFloatProperty);
		Direction_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Direction");
		Direction_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Direction", Classes.FStructProperty);
		FGerstnerWave_IsValid = intPtr != IntPtr.Zero && WaveLength_IsValid && Amplitude_IsValid && Steepness_IsValid && Direction_IsValid;
		NativeReflection.LogStructIsValid("/Script/Water.GerstnerWave", FGerstnerWave_IsValid);
	}
}
