using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.CinematicCamera;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/CinematicCamera.NamedFilmbackPreset", "CinematicCamera", UnrealModuleType.Engine)]
public struct FNamedFilmbackPreset
{
	private static bool Name_IsValid;

	private static int Name_Offset;

	[UProperty(Flags = (PropFlags)6755399441056260uL)]
	[UMetaPath("/Script/CinematicCamera.NamedFilmbackPreset:Name")]
	public string Name;

	private static bool FilmbackSettings_IsValid;

	private static int FilmbackSettings_Offset;

	[UProperty(Flags = (PropFlags)4503668346847236uL)]
	[UMetaPath("/Script/CinematicCamera.NamedFilmbackPreset:FilmbackSettings")]
	public FCameraFilmbackSettings FilmbackSettings;

	private static bool FNamedFilmbackPreset_IsValid;

	private static int FNamedFilmbackPreset_StructSize;

	public FNamedFilmbackPreset Copy()
	{
		return this;
	}

	public static FNamedFilmbackPreset FromNative(IntPtr nativeBuffer)
	{
		return new FNamedFilmbackPreset(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FNamedFilmbackPreset value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FNamedFilmbackPreset FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FNamedFilmbackPreset(nativeBuffer + arrayIndex * FNamedFilmbackPreset_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FNamedFilmbackPreset value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FNamedFilmbackPreset_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FNamedFilmbackPreset_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CinematicCamera.NamedFilmbackPreset");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, Name_Offset), Name);
		FCameraFilmbackSettings.ToNative(IntPtr.Add(nativeStruct, FilmbackSettings_Offset), FilmbackSettings);
	}

	public FNamedFilmbackPreset(IntPtr nativeStruct)
	{
		if (!FNamedFilmbackPreset_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CinematicCamera.NamedFilmbackPreset");
			Name = FStringMarshaler.DefaultString;
			FilmbackSettings = default(FCameraFilmbackSettings);
		}
		else
		{
			Name = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, Name_Offset));
			FilmbackSettings = FCameraFilmbackSettings.FromNative(IntPtr.Add(nativeStruct, FilmbackSettings_Offset));
		}
	}

	static FNamedFilmbackPreset()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FNamedFilmbackPreset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FNamedFilmbackPreset));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/CinematicCamera.NamedFilmbackPreset");
		FNamedFilmbackPreset_StructSize = NativeReflection.GetStructSize(intPtr);
		Name_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Name");
		Name_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Name", Classes.FStrProperty);
		FilmbackSettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FilmbackSettings");
		FilmbackSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FilmbackSettings", Classes.FStructProperty);
		FNamedFilmbackPreset_IsValid = intPtr != IntPtr.Zero && Name_IsValid && FilmbackSettings_IsValid;
		NativeReflection.LogStructIsValid("/Script/CinematicCamera.NamedFilmbackPreset", FNamedFilmbackPreset_IsValid);
	}
}
