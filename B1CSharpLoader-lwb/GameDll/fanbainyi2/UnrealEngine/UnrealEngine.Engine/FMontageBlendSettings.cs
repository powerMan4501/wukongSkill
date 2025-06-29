using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.MontageBlendSettings", "Engine", UnrealModuleType.Engine)]
public struct FMontageBlendSettings
{
	private static bool BlendProfile_IsValid;

	private static int BlendProfile_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.MontageBlendSettings:BlendProfile")]
	public UBlendProfile BlendProfile;

	private static bool Blend_IsValid;

	private static int Blend_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Engine.MontageBlendSettings:Blend")]
	public FAlphaBlendArgs Blend;

	private static bool BlendMode_IsValid;

	private static FFieldAddress BlendMode_PropertyAddress;

	private static int BlendMode_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MontageBlendSettings:BlendMode")]
	public EMontageBlendMode BlendMode;

	private static bool FMontageBlendSettings_IsValid;

	private static int FMontageBlendSettings_StructSize;

	public FMontageBlendSettings Copy()
	{
		return this;
	}

	public static FMontageBlendSettings FromNative(IntPtr nativeBuffer)
	{
		return new FMontageBlendSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMontageBlendSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMontageBlendSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMontageBlendSettings(nativeBuffer + arrayIndex * FMontageBlendSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMontageBlendSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FMontageBlendSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FMontageBlendSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.MontageBlendSettings");
			return;
		}
		UObjectMarshaler<UBlendProfile>.ToNative(IntPtr.Add(nativeStruct, BlendProfile_Offset), BlendProfile);
		FAlphaBlendArgs.ToNative(IntPtr.Add(nativeStruct, Blend_Offset), Blend);
		EnumMarshaler<EMontageBlendMode>.ToNative(IntPtr.Add(nativeStruct, BlendMode_Offset), 0, BlendMode_PropertyAddress.Address, BlendMode);
	}

	public FMontageBlendSettings(IntPtr nativeStruct)
	{
		if (!FMontageBlendSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.MontageBlendSettings");
			BlendProfile = null;
			Blend = default(FAlphaBlendArgs);
			BlendMode = EMontageBlendMode.Standard;
		}
		else
		{
			BlendProfile = UObjectMarshaler<UBlendProfile>.FromNative(IntPtr.Add(nativeStruct, BlendProfile_Offset));
			Blend = FAlphaBlendArgs.FromNative(IntPtr.Add(nativeStruct, Blend_Offset));
			BlendMode = EnumMarshaler<EMontageBlendMode>.FromNative(IntPtr.Add(nativeStruct, BlendMode_Offset), 0, BlendMode_PropertyAddress.Address);
		}
	}

	static FMontageBlendSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FMontageBlendSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMontageBlendSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.MontageBlendSettings");
		FMontageBlendSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		BlendProfile_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BlendProfile");
		BlendProfile_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BlendProfile", Classes.FObjectProperty);
		Blend_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Blend");
		Blend_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Blend", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BlendMode_PropertyAddress, intPtr, "BlendMode");
		BlendMode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BlendMode");
		BlendMode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BlendMode", Classes.FEnumProperty);
		FMontageBlendSettings_IsValid = intPtr != IntPtr.Zero && BlendProfile_IsValid && Blend_IsValid && BlendMode_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.MontageBlendSettings", FMontageBlendSettings_IsValid);
	}
}
