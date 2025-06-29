using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.StreamlineBlueprint;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/StreamlineBlueprint.StreamlineFeatureRequirements", "StreamlineBlueprint", UnrealModuleType.EnginePlugin)]
public struct FStreamlineFeatureRequirements
{
	private static bool Support_IsValid;

	private static FFieldAddress Support_PropertyAddress;

	private static int Support_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/StreamlineBlueprint.StreamlineFeatureRequirements:Support")]
	public EUStreamlineFeatureSupport Support;

	private static bool Requirements_IsValid;

	private static FFieldAddress Requirements_PropertyAddress;

	private static int Requirements_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/StreamlineBlueprint.StreamlineFeatureRequirements:Requirements")]
	public EUStreamlineFeatureRequirementsFlags Requirements;

	private static bool RequiredOperatingSystemVersion_IsValid;

	private static int RequiredOperatingSystemVersion_Offset;

	[UProperty(Flags = (PropFlags)4503668346847236uL)]
	[UMetaPath("/Script/StreamlineBlueprint.StreamlineFeatureRequirements:RequiredOperatingSystemVersion")]
	public FStreamlineVersion RequiredOperatingSystemVersion;

	private static bool DetectedOperatingSystemVersion_IsValid;

	private static int DetectedOperatingSystemVersion_Offset;

	[UProperty(Flags = (PropFlags)4503668346847236uL)]
	[UMetaPath("/Script/StreamlineBlueprint.StreamlineFeatureRequirements:DetectedOperatingSystemVersion")]
	public FStreamlineVersion DetectedOperatingSystemVersion;

	private static bool RequiredDriverVersion_IsValid;

	private static int RequiredDriverVersion_Offset;

	[UProperty(Flags = (PropFlags)4503668346847236uL)]
	[UMetaPath("/Script/StreamlineBlueprint.StreamlineFeatureRequirements:RequiredDriverVersion")]
	public FStreamlineVersion RequiredDriverVersion;

	private static bool DetectedDriverVersion_IsValid;

	private static int DetectedDriverVersion_Offset;

	[UProperty(Flags = (PropFlags)4503668346847236uL)]
	[UMetaPath("/Script/StreamlineBlueprint.StreamlineFeatureRequirements:DetectedDriverVersion")]
	public FStreamlineVersion DetectedDriverVersion;

	private static bool FStreamlineFeatureRequirements_IsValid;

	private static int FStreamlineFeatureRequirements_StructSize;

	public FStreamlineFeatureRequirements Copy()
	{
		return this;
	}

	public static FStreamlineFeatureRequirements FromNative(IntPtr nativeBuffer)
	{
		return new FStreamlineFeatureRequirements(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FStreamlineFeatureRequirements value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FStreamlineFeatureRequirements FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FStreamlineFeatureRequirements(nativeBuffer + arrayIndex * FStreamlineFeatureRequirements_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FStreamlineFeatureRequirements value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FStreamlineFeatureRequirements_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FStreamlineFeatureRequirements_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/StreamlineBlueprint.StreamlineFeatureRequirements");
			return;
		}
		EnumMarshaler<EUStreamlineFeatureSupport>.ToNative(IntPtr.Add(nativeStruct, Support_Offset), 0, Support_PropertyAddress.Address, Support);
		EnumMarshaler<EUStreamlineFeatureRequirementsFlags>.ToNative(IntPtr.Add(nativeStruct, Requirements_Offset), 0, Requirements_PropertyAddress.Address, Requirements);
		FStreamlineVersion.ToNative(IntPtr.Add(nativeStruct, RequiredOperatingSystemVersion_Offset), RequiredOperatingSystemVersion);
		FStreamlineVersion.ToNative(IntPtr.Add(nativeStruct, DetectedOperatingSystemVersion_Offset), DetectedOperatingSystemVersion);
		FStreamlineVersion.ToNative(IntPtr.Add(nativeStruct, RequiredDriverVersion_Offset), RequiredDriverVersion);
		FStreamlineVersion.ToNative(IntPtr.Add(nativeStruct, DetectedDriverVersion_Offset), DetectedDriverVersion);
	}

	public FStreamlineFeatureRequirements(IntPtr nativeStruct)
	{
		if (!FStreamlineFeatureRequirements_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/StreamlineBlueprint.StreamlineFeatureRequirements");
			Support = EUStreamlineFeatureSupport.Supported;
			Requirements = EUStreamlineFeatureRequirementsFlags.None;
			RequiredOperatingSystemVersion = default(FStreamlineVersion);
			DetectedOperatingSystemVersion = default(FStreamlineVersion);
			RequiredDriverVersion = default(FStreamlineVersion);
			DetectedDriverVersion = default(FStreamlineVersion);
		}
		else
		{
			Support = EnumMarshaler<EUStreamlineFeatureSupport>.FromNative(IntPtr.Add(nativeStruct, Support_Offset), 0, Support_PropertyAddress.Address);
			Requirements = EnumMarshaler<EUStreamlineFeatureRequirementsFlags>.FromNative(IntPtr.Add(nativeStruct, Requirements_Offset), 0, Requirements_PropertyAddress.Address);
			RequiredOperatingSystemVersion = FStreamlineVersion.FromNative(IntPtr.Add(nativeStruct, RequiredOperatingSystemVersion_Offset));
			DetectedOperatingSystemVersion = FStreamlineVersion.FromNative(IntPtr.Add(nativeStruct, DetectedOperatingSystemVersion_Offset));
			RequiredDriverVersion = FStreamlineVersion.FromNative(IntPtr.Add(nativeStruct, RequiredDriverVersion_Offset));
			DetectedDriverVersion = FStreamlineVersion.FromNative(IntPtr.Add(nativeStruct, DetectedDriverVersion_Offset));
		}
	}

	static FStreamlineFeatureRequirements()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FStreamlineFeatureRequirements)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FStreamlineFeatureRequirements));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/StreamlineBlueprint.StreamlineFeatureRequirements");
		FStreamlineFeatureRequirements_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Support_PropertyAddress, intPtr, "Support");
		Support_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Support");
		Support_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Support", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref Requirements_PropertyAddress, intPtr, "Requirements");
		Requirements_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Requirements");
		Requirements_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Requirements", Classes.FEnumProperty);
		RequiredOperatingSystemVersion_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RequiredOperatingSystemVersion");
		RequiredOperatingSystemVersion_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RequiredOperatingSystemVersion", Classes.FStructProperty);
		DetectedOperatingSystemVersion_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DetectedOperatingSystemVersion");
		DetectedOperatingSystemVersion_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DetectedOperatingSystemVersion", Classes.FStructProperty);
		RequiredDriverVersion_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RequiredDriverVersion");
		RequiredDriverVersion_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RequiredDriverVersion", Classes.FStructProperty);
		DetectedDriverVersion_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DetectedDriverVersion");
		DetectedDriverVersion_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DetectedDriverVersion", Classes.FStructProperty);
		FStreamlineFeatureRequirements_IsValid = intPtr != IntPtr.Zero && Support_IsValid && Requirements_IsValid && RequiredOperatingSystemVersion_IsValid && DetectedOperatingSystemVersion_IsValid && RequiredDriverVersion_IsValid && DetectedDriverVersion_IsValid;
		NativeReflection.LogStructIsValid("/Script/StreamlineBlueprint.StreamlineFeatureRequirements", FStreamlineFeatureRequirements_IsValid);
	}
}
