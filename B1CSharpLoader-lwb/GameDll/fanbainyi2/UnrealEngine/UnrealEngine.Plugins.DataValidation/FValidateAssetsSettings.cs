using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DataValidation;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/DataValidation.ValidateAssetsSettings", "DataValidation", UnrealModuleType.EnginePlugin)]
public struct FValidateAssetsSettings
{
	private static bool SkipExcludedDirectories_IsValid;

	private static FFieldAddress SkipExcludedDirectories_PropertyAddress;

	private static int SkipExcludedDirectories_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DataValidation.ValidateAssetsSettings:bSkipExcludedDirectories")]
	public bool SkipExcludedDirectories;

	private static bool ShowIfNoFailures_IsValid;

	private static FFieldAddress ShowIfNoFailures_PropertyAddress;

	private static int ShowIfNoFailures_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DataValidation.ValidateAssetsSettings:bShowIfNoFailures")]
	public bool ShowIfNoFailures;

	private static bool ValidationUsecase_IsValid;

	private static FFieldAddress ValidationUsecase_PropertyAddress;

	private static int ValidationUsecase_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DataValidation.ValidateAssetsSettings:ValidationUsecase")]
	public EDataValidationUsecase ValidationUsecase;

	private static bool FValidateAssetsSettings_IsValid;

	private static int FValidateAssetsSettings_StructSize;

	public FValidateAssetsSettings Copy()
	{
		return this;
	}

	public static FValidateAssetsSettings FromNative(IntPtr nativeBuffer)
	{
		return new FValidateAssetsSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FValidateAssetsSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FValidateAssetsSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FValidateAssetsSettings(nativeBuffer + arrayIndex * FValidateAssetsSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FValidateAssetsSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FValidateAssetsSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FValidateAssetsSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/DataValidation.ValidateAssetsSettings");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SkipExcludedDirectories_Offset), 0, SkipExcludedDirectories_PropertyAddress.Address, SkipExcludedDirectories);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ShowIfNoFailures_Offset), 0, ShowIfNoFailures_PropertyAddress.Address, ShowIfNoFailures);
		EnumMarshaler<EDataValidationUsecase>.ToNative(IntPtr.Add(nativeStruct, ValidationUsecase_Offset), 0, ValidationUsecase_PropertyAddress.Address, ValidationUsecase);
	}

	public FValidateAssetsSettings(IntPtr nativeStruct)
	{
		if (!FValidateAssetsSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/DataValidation.ValidateAssetsSettings");
			SkipExcludedDirectories = false;
			ShowIfNoFailures = false;
			ValidationUsecase = EDataValidationUsecase.None;
		}
		else
		{
			SkipExcludedDirectories = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SkipExcludedDirectories_Offset), 0, SkipExcludedDirectories_PropertyAddress.Address);
			ShowIfNoFailures = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ShowIfNoFailures_Offset), 0, ShowIfNoFailures_PropertyAddress.Address);
			ValidationUsecase = EnumMarshaler<EDataValidationUsecase>.FromNative(IntPtr.Add(nativeStruct, ValidationUsecase_Offset), 0, ValidationUsecase_PropertyAddress.Address);
		}
	}

	static FValidateAssetsSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FValidateAssetsSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FValidateAssetsSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/DataValidation.ValidateAssetsSettings");
		FValidateAssetsSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref SkipExcludedDirectories_PropertyAddress, intPtr, "bSkipExcludedDirectories");
		SkipExcludedDirectories_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSkipExcludedDirectories");
		SkipExcludedDirectories_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSkipExcludedDirectories", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ShowIfNoFailures_PropertyAddress, intPtr, "bShowIfNoFailures");
		ShowIfNoFailures_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bShowIfNoFailures");
		ShowIfNoFailures_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bShowIfNoFailures", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ValidationUsecase_PropertyAddress, intPtr, "ValidationUsecase");
		ValidationUsecase_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ValidationUsecase");
		ValidationUsecase_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ValidationUsecase", Classes.FEnumProperty);
		FValidateAssetsSettings_IsValid = intPtr != IntPtr.Zero && SkipExcludedDirectories_IsValid && ShowIfNoFailures_IsValid && ValidationUsecase_IsValid;
		NativeReflection.LogStructIsValid("/Script/DataValidation.ValidateAssetsSettings", FValidateAssetsSettings_IsValid);
	}
}
