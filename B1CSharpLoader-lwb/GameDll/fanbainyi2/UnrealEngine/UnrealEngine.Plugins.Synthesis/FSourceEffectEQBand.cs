using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Synthesis.SourceEffectEQBand", "Synthesis", UnrealModuleType.EnginePlugin)]
public struct FSourceEffectEQBand
{
	private static bool Frequency_IsValid;

	private static int Frequency_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectEQBand:Frequency")]
	public float Frequency;

	private static bool Bandwidth_IsValid;

	private static int Bandwidth_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectEQBand:Bandwidth")]
	public float Bandwidth;

	private static bool GainDb_IsValid;

	private static int GainDb_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectEQBand:GainDb")]
	public float GainDb;

	private static bool Enabled_IsValid;

	private static FFieldAddress Enabled_PropertyAddress;

	private static int Enabled_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectEQBand:bEnabled")]
	public bool Enabled;

	private static bool FSourceEffectEQBand_IsValid;

	private static int FSourceEffectEQBand_StructSize;

	public FSourceEffectEQBand Copy()
	{
		return this;
	}

	public static FSourceEffectEQBand FromNative(IntPtr nativeBuffer)
	{
		return new FSourceEffectEQBand(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSourceEffectEQBand value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSourceEffectEQBand FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSourceEffectEQBand(nativeBuffer + arrayIndex * FSourceEffectEQBand_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSourceEffectEQBand value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSourceEffectEQBand_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSourceEffectEQBand_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.SourceEffectEQBand");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Frequency_Offset), Frequency);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Bandwidth_Offset), Bandwidth);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, GainDb_Offset), GainDb);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Enabled_Offset), 0, Enabled_PropertyAddress.Address, Enabled);
	}

	public FSourceEffectEQBand(IntPtr nativeStruct)
	{
		if (!FSourceEffectEQBand_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.SourceEffectEQBand");
			Frequency = 0f;
			Bandwidth = 0f;
			GainDb = 0f;
			Enabled = false;
		}
		else
		{
			Frequency = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Frequency_Offset));
			Bandwidth = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Bandwidth_Offset));
			GainDb = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, GainDb_Offset));
			Enabled = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Enabled_Offset), 0, Enabled_PropertyAddress.Address);
		}
	}

	static FSourceEffectEQBand()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSourceEffectEQBand)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSourceEffectEQBand));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Synthesis.SourceEffectEQBand");
		FSourceEffectEQBand_StructSize = NativeReflection.GetStructSize(intPtr);
		Frequency_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Frequency");
		Frequency_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Frequency", Classes.FFloatProperty);
		Bandwidth_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Bandwidth");
		Bandwidth_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Bandwidth", Classes.FFloatProperty);
		GainDb_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GainDb");
		GainDb_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GainDb", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref Enabled_PropertyAddress, intPtr, "bEnabled");
		Enabled_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnabled");
		Enabled_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnabled", Classes.FBoolProperty);
		FSourceEffectEQBand_IsValid = intPtr != IntPtr.Zero && Frequency_IsValid && Bandwidth_IsValid && GainDb_IsValid && Enabled_IsValid;
		NativeReflection.LogStructIsValid("/Script/Synthesis.SourceEffectEQBand", FSourceEffectEQBand_IsValid);
	}
}
