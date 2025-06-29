using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.POV", "Engine", UnrealModuleType.Engine)]
public struct FPOV
{
	private static bool Location_IsValid;

	private static int Location_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.POV:Location")]
	public FVector Location;

	private static bool Rotation_IsValid;

	private static int Rotation_Offset;

	[UProperty(Flags = (PropFlags)4503669420589573uL)]
	[UMetaPath("/Script/Engine.POV:Rotation")]
	public FRotator Rotation;

	private static bool FOV_IsValid;

	private static int FOV_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.POV:FOV")]
	public float FOV;

	private static bool FPOV_IsValid;

	private static int FPOV_StructSize;

	public FPOV Copy()
	{
		return this;
	}

	public static FPOV FromNative(IntPtr nativeBuffer)
	{
		return new FPOV(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPOV value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPOV FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPOV(nativeBuffer + arrayIndex * FPOV_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPOV value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPOV_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPOV_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.POV");
			return;
		}
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Location_Offset), Location);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(nativeStruct, Rotation_Offset), Rotation);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FOV_Offset), FOV);
	}

	public FPOV(IntPtr nativeStruct)
	{
		if (!FPOV_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.POV");
			Location = default(FVector);
			Rotation = default(FRotator);
			FOV = 0f;
		}
		else
		{
			Location = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Location_Offset));
			Rotation = BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(nativeStruct, Rotation_Offset));
			FOV = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FOV_Offset));
		}
	}

	static FPOV()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPOV)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPOV));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.POV");
		FPOV_StructSize = NativeReflection.GetStructSize(intPtr);
		Location_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Location");
		Location_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Location", Classes.FStructProperty);
		Rotation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Rotation");
		Rotation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Rotation", Classes.FStructProperty);
		FOV_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FOV");
		FOV_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FOV", Classes.FFloatProperty);
		FPOV_IsValid = intPtr != IntPtr.Zero && Location_IsValid && Rotation_IsValid && FOV_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.POV", FPOV_IsValid);
	}
}
