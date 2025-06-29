using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.CinematicCamera;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/CinematicCamera.NamedLensPreset", "CinematicCamera", UnrealModuleType.Engine)]
public struct FNamedLensPreset
{
	private static bool Name_IsValid;

	private static int Name_Offset;

	[UProperty(Flags = (PropFlags)6755399441056260uL)]
	[UMetaPath("/Script/CinematicCamera.NamedLensPreset:Name")]
	public string Name;

	private static bool LensSettings_IsValid;

	private static int LensSettings_Offset;

	[UProperty(Flags = (PropFlags)4503668346847236uL)]
	[UMetaPath("/Script/CinematicCamera.NamedLensPreset:LensSettings")]
	public FCameraLensSettings LensSettings;

	private static bool FNamedLensPreset_IsValid;

	private static int FNamedLensPreset_StructSize;

	public FNamedLensPreset Copy()
	{
		return this;
	}

	public static FNamedLensPreset FromNative(IntPtr nativeBuffer)
	{
		return new FNamedLensPreset(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FNamedLensPreset value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FNamedLensPreset FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FNamedLensPreset(nativeBuffer + arrayIndex * FNamedLensPreset_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FNamedLensPreset value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FNamedLensPreset_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FNamedLensPreset_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CinematicCamera.NamedLensPreset");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, Name_Offset), Name);
		FCameraLensSettings.ToNative(IntPtr.Add(nativeStruct, LensSettings_Offset), LensSettings);
	}

	public FNamedLensPreset(IntPtr nativeStruct)
	{
		if (!FNamedLensPreset_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CinematicCamera.NamedLensPreset");
			Name = FStringMarshaler.DefaultString;
			LensSettings = default(FCameraLensSettings);
		}
		else
		{
			Name = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, Name_Offset));
			LensSettings = FCameraLensSettings.FromNative(IntPtr.Add(nativeStruct, LensSettings_Offset));
		}
	}

	static FNamedLensPreset()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FNamedLensPreset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FNamedLensPreset));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/CinematicCamera.NamedLensPreset");
		FNamedLensPreset_StructSize = NativeReflection.GetStructSize(intPtr);
		Name_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Name");
		Name_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Name", Classes.FStrProperty);
		LensSettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LensSettings");
		LensSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LensSettings", Classes.FStructProperty);
		FNamedLensPreset_IsValid = intPtr != IntPtr.Zero && Name_IsValid && LensSettings_IsValid;
		NativeReflection.LogStructIsValid("/Script/CinematicCamera.NamedLensPreset", FNamedLensPreset_IsValid);
	}
}
