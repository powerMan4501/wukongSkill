using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.StreamlineBlueprint;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/StreamlineBlueprint.StreamlineVersion", "StreamlineBlueprint", UnrealModuleType.EnginePlugin)]
public struct FStreamlineVersion
{
	private static bool Major_IsValid;

	private static int Major_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/StreamlineBlueprint.StreamlineVersion:Major")]
	public int Major;

	private static bool Minor_IsValid;

	private static int Minor_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/StreamlineBlueprint.StreamlineVersion:Minor")]
	public int Minor;

	private static bool Build_IsValid;

	private static int Build_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/StreamlineBlueprint.StreamlineVersion:Build")]
	public int Build;

	private static bool FStreamlineVersion_IsValid;

	private static int FStreamlineVersion_StructSize;

	public FStreamlineVersion Copy()
	{
		return this;
	}

	public static FStreamlineVersion FromNative(IntPtr nativeBuffer)
	{
		return new FStreamlineVersion(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FStreamlineVersion value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FStreamlineVersion FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FStreamlineVersion(nativeBuffer + arrayIndex * FStreamlineVersion_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FStreamlineVersion value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FStreamlineVersion_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FStreamlineVersion_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/StreamlineBlueprint.StreamlineVersion");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Major_Offset), Major);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Minor_Offset), Minor);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Build_Offset), Build);
	}

	public FStreamlineVersion(IntPtr nativeStruct)
	{
		if (!FStreamlineVersion_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/StreamlineBlueprint.StreamlineVersion");
			Major = 0;
			Minor = 0;
			Build = 0;
		}
		else
		{
			Major = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Major_Offset));
			Minor = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Minor_Offset));
			Build = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Build_Offset));
		}
	}

	static FStreamlineVersion()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FStreamlineVersion)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FStreamlineVersion));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/StreamlineBlueprint.StreamlineVersion");
		FStreamlineVersion_StructSize = NativeReflection.GetStructSize(intPtr);
		Major_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Major");
		Major_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Major", Classes.FIntProperty);
		Minor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Minor");
		Minor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Minor", Classes.FIntProperty);
		Build_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Build");
		Build_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Build", Classes.FIntProperty);
		FStreamlineVersion_IsValid = intPtr != IntPtr.Zero && Major_IsValid && Minor_IsValid && Build_IsValid;
		NativeReflection.LogStructIsValid("/Script/StreamlineBlueprint.StreamlineVersion", FStreamlineVersion_IsValid);
	}
}
