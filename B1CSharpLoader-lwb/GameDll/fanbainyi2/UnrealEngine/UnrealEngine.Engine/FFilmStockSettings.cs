using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.FilmStockSettings", "Engine", UnrealModuleType.Engine)]
public struct FFilmStockSettings
{
	private static bool Slope_IsValid;

	private static int Slope_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/Engine.FilmStockSettings:Slope")]
	public float Slope;

	private static bool Toe_IsValid;

	private static int Toe_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/Engine.FilmStockSettings:Toe")]
	public float Toe;

	private static bool Shoulder_IsValid;

	private static int Shoulder_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/Engine.FilmStockSettings:Shoulder")]
	public float Shoulder;

	private static bool BlackClip_IsValid;

	private static int BlackClip_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/Engine.FilmStockSettings:BlackClip")]
	public float BlackClip;

	private static bool WhiteClip_IsValid;

	private static int WhiteClip_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/Engine.FilmStockSettings:WhiteClip")]
	public float WhiteClip;

	private static bool FFilmStockSettings_IsValid;

	private static int FFilmStockSettings_StructSize;

	public FFilmStockSettings Copy()
	{
		return this;
	}

	public static FFilmStockSettings FromNative(IntPtr nativeBuffer)
	{
		return new FFilmStockSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FFilmStockSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FFilmStockSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FFilmStockSettings(nativeBuffer + arrayIndex * FFilmStockSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FFilmStockSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FFilmStockSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FFilmStockSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.FilmStockSettings");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Slope_Offset), Slope);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Toe_Offset), Toe);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Shoulder_Offset), Shoulder);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BlackClip_Offset), BlackClip);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, WhiteClip_Offset), WhiteClip);
	}

	public FFilmStockSettings(IntPtr nativeStruct)
	{
		if (!FFilmStockSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.FilmStockSettings");
			Slope = 0f;
			Toe = 0f;
			Shoulder = 0f;
			BlackClip = 0f;
			WhiteClip = 0f;
		}
		else
		{
			Slope = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Slope_Offset));
			Toe = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Toe_Offset));
			Shoulder = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Shoulder_Offset));
			BlackClip = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BlackClip_Offset));
			WhiteClip = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, WhiteClip_Offset));
		}
	}

	static FFilmStockSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FFilmStockSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FFilmStockSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.FilmStockSettings");
		FFilmStockSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		Slope_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Slope");
		Slope_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Slope", Classes.FFloatProperty);
		Toe_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Toe");
		Toe_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Toe", Classes.FFloatProperty);
		Shoulder_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Shoulder");
		Shoulder_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Shoulder", Classes.FFloatProperty);
		BlackClip_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BlackClip");
		BlackClip_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BlackClip", Classes.FFloatProperty);
		WhiteClip_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WhiteClip");
		WhiteClip_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WhiteClip", Classes.FFloatProperty);
		FFilmStockSettings_IsValid = intPtr != IntPtr.Zero && Slope_IsValid && Toe_IsValid && Shoulder_IsValid && BlackClip_IsValid && WhiteClip_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.FilmStockSettings", FFilmStockSettings_IsValid);
	}
}
