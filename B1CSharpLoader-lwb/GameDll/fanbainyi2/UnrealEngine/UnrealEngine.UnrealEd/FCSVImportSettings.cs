using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/UnrealEd.CSVImportSettings", "UnrealEd", UnrealModuleType.Engine)]
public struct FCSVImportSettings
{
	private static bool ImportRowStruct_IsValid;

	private static int ImportRowStruct_Offset;

	[UProperty(Flags = (PropFlags)7881369141117444uL)]
	[UMetaPath("/Script/UnrealEd.CSVImportSettings:ImportRowStruct")]
	public UScriptStruct ImportRowStruct;

	private static bool ImportType_IsValid;

	private static FFieldAddress ImportType_PropertyAddress;

	private static int ImportType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/UnrealEd.CSVImportSettings:ImportType")]
	public ECSVImportType ImportType;

	private static bool ImportCurveInterpMode_IsValid;

	private static FFieldAddress ImportCurveInterpMode_PropertyAddress;

	private static int ImportCurveInterpMode_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/UnrealEd.CSVImportSettings:ImportCurveInterpMode")]
	public ERichCurveInterpMode ImportCurveInterpMode;

	private static bool FCSVImportSettings_IsValid;

	private static int FCSVImportSettings_StructSize;

	public FCSVImportSettings Copy()
	{
		return this;
	}

	public static FCSVImportSettings FromNative(IntPtr nativeBuffer)
	{
		return new FCSVImportSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCSVImportSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCSVImportSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCSVImportSettings(nativeBuffer + arrayIndex * FCSVImportSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCSVImportSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCSVImportSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCSVImportSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealEd.CSVImportSettings");
			return;
		}
		UObjectMarshaler<UScriptStruct>.ToNative(IntPtr.Add(nativeStruct, ImportRowStruct_Offset), ImportRowStruct);
		EnumMarshaler<ECSVImportType>.ToNative(IntPtr.Add(nativeStruct, ImportType_Offset), 0, ImportType_PropertyAddress.Address, ImportType);
		EnumMarshaler<ERichCurveInterpMode>.ToNative(IntPtr.Add(nativeStruct, ImportCurveInterpMode_Offset), 0, ImportCurveInterpMode_PropertyAddress.Address, ImportCurveInterpMode);
	}

	public FCSVImportSettings(IntPtr nativeStruct)
	{
		if (!FCSVImportSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealEd.CSVImportSettings");
			ImportRowStruct = null;
			ImportType = ECSVImportType.ECSV_DataTable;
			ImportCurveInterpMode = ERichCurveInterpMode.RCIM_Linear;
		}
		else
		{
			ImportRowStruct = UObjectMarshaler<UScriptStruct>.FromNative(IntPtr.Add(nativeStruct, ImportRowStruct_Offset));
			ImportType = EnumMarshaler<ECSVImportType>.FromNative(IntPtr.Add(nativeStruct, ImportType_Offset), 0, ImportType_PropertyAddress.Address);
			ImportCurveInterpMode = EnumMarshaler<ERichCurveInterpMode>.FromNative(IntPtr.Add(nativeStruct, ImportCurveInterpMode_Offset), 0, ImportCurveInterpMode_PropertyAddress.Address);
		}
	}

	static FCSVImportSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCSVImportSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCSVImportSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/UnrealEd.CSVImportSettings");
		FCSVImportSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		ImportRowStruct_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ImportRowStruct");
		ImportRowStruct_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ImportRowStruct", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportType_PropertyAddress, intPtr, "ImportType");
		ImportType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ImportType");
		ImportType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ImportType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportCurveInterpMode_PropertyAddress, intPtr, "ImportCurveInterpMode");
		ImportCurveInterpMode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ImportCurveInterpMode");
		ImportCurveInterpMode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ImportCurveInterpMode", Classes.FByteProperty);
		FCSVImportSettings_IsValid = intPtr != IntPtr.Zero && ImportRowStruct_IsValid && ImportType_IsValid && ImportCurveInterpMode_IsValid;
		NativeReflection.LogStructIsValid("/Script/UnrealEd.CSVImportSettings", FCSVImportSettings_IsValid);
	}
}
