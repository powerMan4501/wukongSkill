using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.LensSettings", "Engine", UnrealModuleType.Engine)]
public struct FLensSettings
{
	private static bool Bloom_IsValid;

	private static int Bloom_Offset;

	[UProperty(Flags = (PropFlags)4503676936781829uL)]
	[UMetaPath("/Script/Engine.LensSettings:Bloom")]
	public FLensBloomSettings Bloom;

	private static bool Imperfections_IsValid;

	private static int Imperfections_Offset;

	[UProperty(Flags = (PropFlags)4503676936781829uL)]
	[UMetaPath("/Script/Engine.LensSettings:Imperfections")]
	public FLensImperfectionSettings Imperfections;

	private static bool ChromaticAberration_IsValid;

	private static int ChromaticAberration_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/Engine.LensSettings:ChromaticAberration")]
	public float ChromaticAberration;

	private static bool FLensSettings_IsValid;

	private static int FLensSettings_StructSize;

	public FLensSettings Copy()
	{
		return this;
	}

	public static FLensSettings FromNative(IntPtr nativeBuffer)
	{
		return new FLensSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FLensSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FLensSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FLensSettings(nativeBuffer + arrayIndex * FLensSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FLensSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FLensSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FLensSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.LensSettings");
			return;
		}
		FLensBloomSettings.ToNative(IntPtr.Add(nativeStruct, Bloom_Offset), Bloom);
		FLensImperfectionSettings.ToNative(IntPtr.Add(nativeStruct, Imperfections_Offset), Imperfections);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ChromaticAberration_Offset), ChromaticAberration);
	}

	public FLensSettings(IntPtr nativeStruct)
	{
		if (!FLensSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.LensSettings");
			Bloom = default(FLensBloomSettings);
			Imperfections = default(FLensImperfectionSettings);
			ChromaticAberration = 0f;
		}
		else
		{
			Bloom = FLensBloomSettings.FromNative(IntPtr.Add(nativeStruct, Bloom_Offset));
			Imperfections = FLensImperfectionSettings.FromNative(IntPtr.Add(nativeStruct, Imperfections_Offset));
			ChromaticAberration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ChromaticAberration_Offset));
		}
	}

	static FLensSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FLensSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FLensSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.LensSettings");
		FLensSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		Bloom_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Bloom");
		Bloom_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Bloom", Classes.FStructProperty);
		Imperfections_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Imperfections");
		Imperfections_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Imperfections", Classes.FStructProperty);
		ChromaticAberration_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ChromaticAberration");
		ChromaticAberration_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ChromaticAberration", Classes.FFloatProperty);
		FLensSettings_IsValid = intPtr != IntPtr.Zero && Bloom_IsValid && Imperfections_IsValid && ChromaticAberration_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.LensSettings", FLensSettings_IsValid);
	}
}
