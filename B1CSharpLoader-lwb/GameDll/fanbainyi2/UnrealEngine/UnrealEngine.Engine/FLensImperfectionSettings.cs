using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.LensImperfectionSettings", "Engine", UnrealModuleType.Engine)]
public struct FLensImperfectionSettings
{
	private static bool DirtMask_IsValid;

	private static int DirtMask_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.LensImperfectionSettings:DirtMask")]
	public UTexture DirtMask;

	private static bool DirtMaskIntensity_IsValid;

	private static int DirtMaskIntensity_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/Engine.LensImperfectionSettings:DirtMaskIntensity")]
	public float DirtMaskIntensity;

	private static bool DirtMaskTint_IsValid;

	private static int DirtMaskTint_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/Engine.LensImperfectionSettings:DirtMaskTint")]
	public FLinearColor DirtMaskTint;

	private static bool FLensImperfectionSettings_IsValid;

	private static int FLensImperfectionSettings_StructSize;

	public FLensImperfectionSettings Copy()
	{
		return this;
	}

	public static FLensImperfectionSettings FromNative(IntPtr nativeBuffer)
	{
		return new FLensImperfectionSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FLensImperfectionSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FLensImperfectionSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FLensImperfectionSettings(nativeBuffer + arrayIndex * FLensImperfectionSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FLensImperfectionSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FLensImperfectionSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FLensImperfectionSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.LensImperfectionSettings");
			return;
		}
		UObjectMarshaler<UTexture>.ToNative(IntPtr.Add(nativeStruct, DirtMask_Offset), DirtMask);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DirtMaskIntensity_Offset), DirtMaskIntensity);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, DirtMaskTint_Offset), DirtMaskTint);
	}

	public FLensImperfectionSettings(IntPtr nativeStruct)
	{
		if (!FLensImperfectionSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.LensImperfectionSettings");
			DirtMask = null;
			DirtMaskIntensity = 0f;
			DirtMaskTint = default(FLinearColor);
		}
		else
		{
			DirtMask = UObjectMarshaler<UTexture>.FromNative(IntPtr.Add(nativeStruct, DirtMask_Offset));
			DirtMaskIntensity = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DirtMaskIntensity_Offset));
			DirtMaskTint = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(nativeStruct, DirtMaskTint_Offset));
		}
	}

	static FLensImperfectionSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FLensImperfectionSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FLensImperfectionSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.LensImperfectionSettings");
		FLensImperfectionSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		DirtMask_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DirtMask");
		DirtMask_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DirtMask", Classes.FObjectProperty);
		DirtMaskIntensity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DirtMaskIntensity");
		DirtMaskIntensity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DirtMaskIntensity", Classes.FFloatProperty);
		DirtMaskTint_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DirtMaskTint");
		DirtMaskTint_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DirtMaskTint", Classes.FStructProperty);
		FLensImperfectionSettings_IsValid = intPtr != IntPtr.Zero && DirtMask_IsValid && DirtMaskIntensity_IsValid && DirtMaskTint_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.LensImperfectionSettings", FLensImperfectionSettings_IsValid);
	}
}
