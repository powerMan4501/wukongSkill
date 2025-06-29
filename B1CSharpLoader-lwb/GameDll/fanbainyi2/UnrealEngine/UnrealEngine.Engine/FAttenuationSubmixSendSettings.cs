using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.AttenuationSubmixSendSettings", "Engine", UnrealModuleType.Engine)]
public struct FAttenuationSubmixSendSettings
{
	private static bool Submix_IsValid;

	private static int Submix_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.AttenuationSubmixSendSettings:Submix")]
	public USoundSubmixBase Submix;

	private static bool SubmixSendMethod_IsValid;

	private static FFieldAddress SubmixSendMethod_PropertyAddress;

	private static int SubmixSendMethod_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.AttenuationSubmixSendSettings:SubmixSendMethod")]
	public ESubmixSendMethod SubmixSendMethod;

	private static bool SubmixSendLevelMin_IsValid;

	private static int SubmixSendLevelMin_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.AttenuationSubmixSendSettings:SubmixSendLevelMin")]
	public float SubmixSendLevelMin;

	private static bool SubmixSendLevelMax_IsValid;

	private static int SubmixSendLevelMax_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.AttenuationSubmixSendSettings:SubmixSendLevelMax")]
	public float SubmixSendLevelMax;

	private static bool SubmixSendDistanceMin_IsValid;

	private static int SubmixSendDistanceMin_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.AttenuationSubmixSendSettings:SubmixSendDistanceMin")]
	public float SubmixSendDistanceMin;

	private static bool SubmixSendDistanceMax_IsValid;

	private static int SubmixSendDistanceMax_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.AttenuationSubmixSendSettings:SubmixSendDistanceMax")]
	public float SubmixSendDistanceMax;

	private static bool ManualSubmixSendLevel_IsValid;

	private static int ManualSubmixSendLevel_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.AttenuationSubmixSendSettings:ManualSubmixSendLevel")]
	public float ManualSubmixSendLevel;

	private static bool CustomSubmixSendCurve_IsValid;

	private static int CustomSubmixSendCurve_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/Engine.AttenuationSubmixSendSettings:CustomSubmixSendCurve")]
	public FRuntimeFloatCurve CustomSubmixSendCurve;

	private static bool FAttenuationSubmixSendSettings_IsValid;

	private static int FAttenuationSubmixSendSettings_StructSize;

	public FAttenuationSubmixSendSettings Copy()
	{
		return this;
	}

	public static FAttenuationSubmixSendSettings FromNative(IntPtr nativeBuffer)
	{
		return new FAttenuationSubmixSendSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAttenuationSubmixSendSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAttenuationSubmixSendSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAttenuationSubmixSendSettings(nativeBuffer + arrayIndex * FAttenuationSubmixSendSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAttenuationSubmixSendSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAttenuationSubmixSendSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAttenuationSubmixSendSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AttenuationSubmixSendSettings");
			return;
		}
		UObjectMarshaler<USoundSubmixBase>.ToNative(IntPtr.Add(nativeStruct, Submix_Offset), Submix);
		EnumMarshaler<ESubmixSendMethod>.ToNative(IntPtr.Add(nativeStruct, SubmixSendMethod_Offset), 0, SubmixSendMethod_PropertyAddress.Address, SubmixSendMethod);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SubmixSendLevelMin_Offset), SubmixSendLevelMin);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SubmixSendLevelMax_Offset), SubmixSendLevelMax);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SubmixSendDistanceMin_Offset), SubmixSendDistanceMin);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SubmixSendDistanceMax_Offset), SubmixSendDistanceMax);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ManualSubmixSendLevel_Offset), ManualSubmixSendLevel);
		FRuntimeFloatCurve.ToNative(IntPtr.Add(nativeStruct, CustomSubmixSendCurve_Offset), CustomSubmixSendCurve);
	}

	public FAttenuationSubmixSendSettings(IntPtr nativeStruct)
	{
		if (!FAttenuationSubmixSendSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AttenuationSubmixSendSettings");
			Submix = null;
			SubmixSendMethod = ESubmixSendMethod.Linear;
			SubmixSendLevelMin = 0f;
			SubmixSendLevelMax = 0f;
			SubmixSendDistanceMin = 0f;
			SubmixSendDistanceMax = 0f;
			ManualSubmixSendLevel = 0f;
			CustomSubmixSendCurve = default(FRuntimeFloatCurve);
		}
		else
		{
			Submix = UObjectMarshaler<USoundSubmixBase>.FromNative(IntPtr.Add(nativeStruct, Submix_Offset));
			SubmixSendMethod = EnumMarshaler<ESubmixSendMethod>.FromNative(IntPtr.Add(nativeStruct, SubmixSendMethod_Offset), 0, SubmixSendMethod_PropertyAddress.Address);
			SubmixSendLevelMin = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SubmixSendLevelMin_Offset));
			SubmixSendLevelMax = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SubmixSendLevelMax_Offset));
			SubmixSendDistanceMin = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SubmixSendDistanceMin_Offset));
			SubmixSendDistanceMax = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SubmixSendDistanceMax_Offset));
			ManualSubmixSendLevel = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ManualSubmixSendLevel_Offset));
			CustomSubmixSendCurve = FRuntimeFloatCurve.FromNative(IntPtr.Add(nativeStruct, CustomSubmixSendCurve_Offset));
		}
	}

	static FAttenuationSubmixSendSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAttenuationSubmixSendSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAttenuationSubmixSendSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.AttenuationSubmixSendSettings");
		FAttenuationSubmixSendSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		Submix_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Submix");
		Submix_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Submix", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SubmixSendMethod_PropertyAddress, intPtr, "SubmixSendMethod");
		SubmixSendMethod_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SubmixSendMethod");
		SubmixSendMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SubmixSendMethod", Classes.FEnumProperty);
		SubmixSendLevelMin_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SubmixSendLevelMin");
		SubmixSendLevelMin_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SubmixSendLevelMin", Classes.FFloatProperty);
		SubmixSendLevelMax_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SubmixSendLevelMax");
		SubmixSendLevelMax_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SubmixSendLevelMax", Classes.FFloatProperty);
		SubmixSendDistanceMin_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SubmixSendDistanceMin");
		SubmixSendDistanceMin_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SubmixSendDistanceMin", Classes.FFloatProperty);
		SubmixSendDistanceMax_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SubmixSendDistanceMax");
		SubmixSendDistanceMax_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SubmixSendDistanceMax", Classes.FFloatProperty);
		ManualSubmixSendLevel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ManualSubmixSendLevel");
		ManualSubmixSendLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ManualSubmixSendLevel", Classes.FFloatProperty);
		CustomSubmixSendCurve_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CustomSubmixSendCurve");
		CustomSubmixSendCurve_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CustomSubmixSendCurve", Classes.FStructProperty);
		FAttenuationSubmixSendSettings_IsValid = intPtr != IntPtr.Zero && Submix_IsValid && SubmixSendMethod_IsValid && SubmixSendLevelMin_IsValid && SubmixSendLevelMax_IsValid && SubmixSendDistanceMin_IsValid && SubmixSendDistanceMax_IsValid && ManualSubmixSendLevel_IsValid && CustomSubmixSendCurve_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.AttenuationSubmixSendSettings", FAttenuationSubmixSendSettings_IsValid);
	}
}
