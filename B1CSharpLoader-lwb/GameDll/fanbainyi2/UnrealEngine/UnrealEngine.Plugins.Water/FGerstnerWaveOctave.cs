using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Water;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Water.GerstnerWaveOctave", "Water", UnrealModuleType.EnginePlugin)]
public struct FGerstnerWaveOctave
{
	private static bool NumWaves_IsValid;

	private static int NumWaves_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Water.GerstnerWaveOctave:NumWaves")]
	public int NumWaves;

	private static bool AmplitudeScale_IsValid;

	private static int AmplitudeScale_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Water.GerstnerWaveOctave:AmplitudeScale")]
	public float AmplitudeScale;

	private static bool MainDirection_IsValid;

	private static int MainDirection_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Water.GerstnerWaveOctave:MainDirection")]
	public float MainDirection;

	private static bool SpreadAngle_IsValid;

	private static int SpreadAngle_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Water.GerstnerWaveOctave:SpreadAngle")]
	public float SpreadAngle;

	private static bool UniformSpread_IsValid;

	private static FFieldAddress UniformSpread_PropertyAddress;

	private static int UniformSpread_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Water.GerstnerWaveOctave:bUniformSpread")]
	public bool UniformSpread;

	private static bool FGerstnerWaveOctave_IsValid;

	private static int FGerstnerWaveOctave_StructSize;

	public FGerstnerWaveOctave Copy()
	{
		return this;
	}

	public static FGerstnerWaveOctave FromNative(IntPtr nativeBuffer)
	{
		return new FGerstnerWaveOctave(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGerstnerWaveOctave value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGerstnerWaveOctave FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGerstnerWaveOctave(nativeBuffer + arrayIndex * FGerstnerWaveOctave_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGerstnerWaveOctave value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGerstnerWaveOctave_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGerstnerWaveOctave_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Water.GerstnerWaveOctave");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, NumWaves_Offset), NumWaves);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, AmplitudeScale_Offset), AmplitudeScale);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MainDirection_Offset), MainDirection);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SpreadAngle_Offset), SpreadAngle);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UniformSpread_Offset), 0, UniformSpread_PropertyAddress.Address, UniformSpread);
	}

	public FGerstnerWaveOctave(IntPtr nativeStruct)
	{
		if (!FGerstnerWaveOctave_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Water.GerstnerWaveOctave");
			NumWaves = 0;
			AmplitudeScale = 0f;
			MainDirection = 0f;
			SpreadAngle = 0f;
			UniformSpread = false;
		}
		else
		{
			NumWaves = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, NumWaves_Offset));
			AmplitudeScale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, AmplitudeScale_Offset));
			MainDirection = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MainDirection_Offset));
			SpreadAngle = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SpreadAngle_Offset));
			UniformSpread = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UniformSpread_Offset), 0, UniformSpread_PropertyAddress.Address);
		}
	}

	static FGerstnerWaveOctave()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGerstnerWaveOctave)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGerstnerWaveOctave));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Water.GerstnerWaveOctave");
		FGerstnerWaveOctave_StructSize = NativeReflection.GetStructSize(intPtr);
		NumWaves_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NumWaves");
		NumWaves_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NumWaves", Classes.FIntProperty);
		AmplitudeScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AmplitudeScale");
		AmplitudeScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AmplitudeScale", Classes.FFloatProperty);
		MainDirection_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MainDirection");
		MainDirection_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MainDirection", Classes.FFloatProperty);
		SpreadAngle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SpreadAngle");
		SpreadAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SpreadAngle", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref UniformSpread_PropertyAddress, intPtr, "bUniformSpread");
		UniformSpread_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUniformSpread");
		UniformSpread_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUniformSpread", Classes.FBoolProperty);
		FGerstnerWaveOctave_IsValid = intPtr != IntPtr.Zero && NumWaves_IsValid && AmplitudeScale_IsValid && MainDirection_IsValid && SpreadAngle_IsValid && UniformSpread_IsValid;
		NativeReflection.LogStructIsValid("/Script/Water.GerstnerWaveOctave", FGerstnerWaveOctave_IsValid);
	}
}
