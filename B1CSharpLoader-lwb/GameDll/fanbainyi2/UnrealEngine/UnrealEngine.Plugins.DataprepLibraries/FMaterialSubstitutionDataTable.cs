using System;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.EditorScriptingUtilities;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DataprepLibraries;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/DataprepLibraries.MaterialSubstitutionDataTable", "DataprepLibraries", UnrealModuleType.EnginePlugin)]
public struct FMaterialSubstitutionDataTable
{
	private static bool SearchString_IsValid;

	private static int SearchString_Offset;

	[UProperty(Flags = (PropFlags)6755399441056277uL)]
	[UMetaPath("/Script/DataprepLibraries.MaterialSubstitutionDataTable:SearchString")]
	public string SearchString;

	private static bool StringMatch_IsValid;

	private static FFieldAddress StringMatch_PropertyAddress;

	private static int StringMatch_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/DataprepLibraries.MaterialSubstitutionDataTable:StringMatch")]
	public EEditorScriptingStringMatchType StringMatch;

	private static bool MaterialReplacement_IsValid;

	private static int MaterialReplacement_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/DataprepLibraries.MaterialSubstitutionDataTable:MaterialReplacement")]
	public UMaterialInterface MaterialReplacement;

	private static bool FMaterialSubstitutionDataTable_IsValid;

	private static int FMaterialSubstitutionDataTable_StructSize;

	public FMaterialSubstitutionDataTable Copy()
	{
		return this;
	}

	public static FMaterialSubstitutionDataTable FromNative(IntPtr nativeBuffer)
	{
		return new FMaterialSubstitutionDataTable(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMaterialSubstitutionDataTable value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMaterialSubstitutionDataTable FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMaterialSubstitutionDataTable(nativeBuffer + arrayIndex * FMaterialSubstitutionDataTable_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMaterialSubstitutionDataTable value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FMaterialSubstitutionDataTable_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FMaterialSubstitutionDataTable_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/DataprepLibraries.MaterialSubstitutionDataTable");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, SearchString_Offset), SearchString);
		EnumMarshaler<EEditorScriptingStringMatchType>.ToNative(IntPtr.Add(nativeStruct, StringMatch_Offset), 0, StringMatch_PropertyAddress.Address, StringMatch);
		UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(nativeStruct, MaterialReplacement_Offset), MaterialReplacement);
	}

	public FMaterialSubstitutionDataTable(IntPtr nativeStruct)
	{
		if (!FMaterialSubstitutionDataTable_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/DataprepLibraries.MaterialSubstitutionDataTable");
			SearchString = FStringMarshaler.DefaultString;
			StringMatch = EEditorScriptingStringMatchType.Contains;
			MaterialReplacement = null;
		}
		else
		{
			SearchString = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, SearchString_Offset));
			StringMatch = EnumMarshaler<EEditorScriptingStringMatchType>.FromNative(IntPtr.Add(nativeStruct, StringMatch_Offset), 0, StringMatch_PropertyAddress.Address);
			MaterialReplacement = UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(nativeStruct, MaterialReplacement_Offset));
		}
	}

	static FMaterialSubstitutionDataTable()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FMaterialSubstitutionDataTable)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMaterialSubstitutionDataTable));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/DataprepLibraries.MaterialSubstitutionDataTable");
		FMaterialSubstitutionDataTable_StructSize = NativeReflection.GetStructSize(intPtr);
		SearchString_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SearchString");
		SearchString_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SearchString", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref StringMatch_PropertyAddress, intPtr, "StringMatch");
		StringMatch_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StringMatch");
		StringMatch_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StringMatch", Classes.FEnumProperty);
		MaterialReplacement_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaterialReplacement");
		MaterialReplacement_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaterialReplacement", Classes.FObjectProperty);
		FMaterialSubstitutionDataTable_IsValid = intPtr != IntPtr.Zero && SearchString_IsValid && StringMatch_IsValid && MaterialReplacement_IsValid;
		NativeReflection.LogStructIsValid("/Script/DataprepLibraries.MaterialSubstitutionDataTable", FMaterialSubstitutionDataTable_IsValid);
	}
}
