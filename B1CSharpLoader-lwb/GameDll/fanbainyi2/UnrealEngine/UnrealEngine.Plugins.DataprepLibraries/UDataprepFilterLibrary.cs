using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.EditorScriptingUtilities;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DataprepLibraries;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/DataprepLibraries.DataprepFilterLibrary", "DataprepLibraries", UnrealModuleType.EnginePlugin)]
public class UDataprepFilterLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool FilterByTag_IsValid;

	private static IntPtr FilterByTag_FunctionAddress;

	private static int FilterByTag_ParamsSize;

	private static bool FilterByTag_TargetArray_IsValid;

	private static FFieldAddress FilterByTag_TargetArray_PropertyAddress;

	private static int FilterByTag_TargetArray_Offset;

	private static bool FilterByTag_Tag_IsValid;

	private static FFieldAddress FilterByTag_Tag_PropertyAddress;

	private static int FilterByTag_Tag_Offset;

	private static bool FilterByTag_ReturnValue_IsValid;

	private static FFieldAddress FilterByTag_ReturnValue_PropertyAddress;

	private static int FilterByTag_ReturnValue_Offset;

	private static bool FilterBySize_IsValid;

	private static IntPtr FilterBySize_FunctionAddress;

	private static int FilterBySize_ParamsSize;

	private static bool FilterBySize_TargetArray_IsValid;

	private static FFieldAddress FilterBySize_TargetArray_PropertyAddress;

	private static int FilterBySize_TargetArray_Offset;

	private static bool FilterBySize_SizeSource_IsValid;

	private static FFieldAddress FilterBySize_SizeSource_PropertyAddress;

	private static int FilterBySize_SizeSource_Offset;

	private static bool FilterBySize_FilterMode_IsValid;

	private static FFieldAddress FilterBySize_FilterMode_PropertyAddress;

	private static int FilterBySize_FilterMode_Offset;

	private static bool FilterBySize_Threshold_IsValid;

	private static FFieldAddress FilterBySize_Threshold_PropertyAddress;

	private static int FilterBySize_Threshold_Offset;

	private static bool FilterBySize_ReturnValue_IsValid;

	private static FFieldAddress FilterBySize_ReturnValue_PropertyAddress;

	private static int FilterBySize_ReturnValue_Offset;

	private static bool FilterByName_IsValid;

	private static IntPtr FilterByName_FunctionAddress;

	private static int FilterByName_ParamsSize;

	private static bool FilterByName_TargetArray_IsValid;

	private static FFieldAddress FilterByName_TargetArray_PropertyAddress;

	private static int FilterByName_TargetArray_Offset;

	private static bool FilterByName_NameSubString_IsValid;

	private static FFieldAddress FilterByName_NameSubString_PropertyAddress;

	private static int FilterByName_NameSubString_Offset;

	private static bool FilterByName_StringMatch_IsValid;

	private static FFieldAddress FilterByName_StringMatch_PropertyAddress;

	private static int FilterByName_StringMatch_Offset;

	private static bool FilterByName_ReturnValue_IsValid;

	private static FFieldAddress FilterByName_ReturnValue_PropertyAddress;

	private static int FilterByName_ReturnValue_Offset;

	private static bool FilterByClass_IsValid;

	private static IntPtr FilterByClass_FunctionAddress;

	private static int FilterByClass_ParamsSize;

	private static bool FilterByClass_TargetArray_IsValid;

	private static FFieldAddress FilterByClass_TargetArray_PropertyAddress;

	private static int FilterByClass_TargetArray_Offset;

	private static bool FilterByClass_ObjectClass_IsValid;

	private static FFieldAddress FilterByClass_ObjectClass_PropertyAddress;

	private static int FilterByClass_ObjectClass_Offset;

	private static bool FilterByClass_ReturnValue_IsValid;

	private static FFieldAddress FilterByClass_ReturnValue_PropertyAddress;

	private static int FilterByClass_ReturnValue_Offset;

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/DataprepLibraries.DataprepFilterLibrary:FilterByTag")]
	public unsafe static List<AActor> FilterByTag(List<AActor> TargetArray, FName Tag)
	{
		if (!FilterByTag_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepLibraries.DataprepFilterLibrary:FilterByTag");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FilterByTag_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FilterByTag_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<AActor>(1, FilterByTag_TargetArray_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).ToNative(IntPtr.Add(intPtr, FilterByTag_TargetArray_Offset), TargetArray);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, FilterByTag_Tag_Offset), 0, FilterByTag_Tag_PropertyAddress.Address, Tag);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FilterByTag_FunctionAddress, intPtr, FilterByTag_ParamsSize);
		NativeReflection.DestroyValue_InContainer(FilterByTag_TargetArray_PropertyAddress.Address, intPtr);
		List<AActor> result = new TArrayCopyMarshaler<AActor>(1, FilterByTag_ReturnValue_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(intPtr, FilterByTag_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(FilterByTag_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/DataprepLibraries.DataprepFilterLibrary:FilterBySize")]
	public unsafe static List<UObject> FilterBySize(List<UObject> TargetArray, EDataprepSizeSource SizeSource, EDataprepSizeFilterMode FilterMode, float Threshold)
	{
		if (!FilterBySize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepLibraries.DataprepFilterLibrary:FilterBySize");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FilterBySize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FilterBySize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UObject>(1, FilterBySize_TargetArray_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, FilterBySize_TargetArray_Offset), TargetArray);
		EnumMarshaler<EDataprepSizeSource>.ToNative(IntPtr.Add(intPtr, FilterBySize_SizeSource_Offset), 0, FilterBySize_SizeSource_PropertyAddress.Address, SizeSource);
		EnumMarshaler<EDataprepSizeFilterMode>.ToNative(IntPtr.Add(intPtr, FilterBySize_FilterMode_Offset), 0, FilterBySize_FilterMode_PropertyAddress.Address, FilterMode);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, FilterBySize_Threshold_Offset), 0, FilterBySize_Threshold_PropertyAddress.Address, Threshold);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FilterBySize_FunctionAddress, intPtr, FilterBySize_ParamsSize);
		NativeReflection.DestroyValue_InContainer(FilterBySize_TargetArray_PropertyAddress.Address, intPtr);
		List<UObject> result = new TArrayCopyMarshaler<UObject>(1, FilterBySize_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, FilterBySize_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(FilterBySize_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/DataprepLibraries.DataprepFilterLibrary:FilterByName")]
	public unsafe static List<UObject> FilterByName(List<UObject> TargetArray, string NameSubString, EEditorScriptingStringMatchType StringMatch = EEditorScriptingStringMatchType.Contains)
	{
		if (!FilterByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepLibraries.DataprepFilterLibrary:FilterByName");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FilterByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FilterByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UObject>(1, FilterByName_TargetArray_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, FilterByName_TargetArray_Offset), TargetArray);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, FilterByName_NameSubString_Offset), 0, FilterByName_NameSubString_PropertyAddress.Address, NameSubString);
		EnumMarshaler<EEditorScriptingStringMatchType>.ToNative(IntPtr.Add(intPtr, FilterByName_StringMatch_Offset), 0, FilterByName_StringMatch_PropertyAddress.Address, StringMatch);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FilterByName_FunctionAddress, intPtr, FilterByName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(FilterByName_TargetArray_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(FilterByName_NameSubString_PropertyAddress.Address, intPtr);
		List<UObject> result = new TArrayCopyMarshaler<UObject>(1, FilterByName_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, FilterByName_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(FilterByName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/DataprepLibraries.DataprepFilterLibrary:FilterByClass")]
	public unsafe static List<UObject> FilterByClass(List<UObject> TargetArray, TSubclassOf<UObject> ObjectClass)
	{
		if (!FilterByClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepLibraries.DataprepFilterLibrary:FilterByClass");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FilterByClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FilterByClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UObject>(1, FilterByClass_TargetArray_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, FilterByClass_TargetArray_Offset), TargetArray);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, FilterByClass_ObjectClass_Offset), 0, FilterByClass_ObjectClass_PropertyAddress.Address, ObjectClass);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FilterByClass_FunctionAddress, intPtr, FilterByClass_ParamsSize);
		NativeReflection.DestroyValue_InContainer(FilterByClass_TargetArray_PropertyAddress.Address, intPtr);
		List<UObject> result = new TArrayCopyMarshaler<UObject>(1, FilterByClass_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, FilterByClass_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(FilterByClass_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UDataprepFilterLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UDataprepFilterLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UDataprepFilterLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/DataprepLibraries.DataprepFilterLibrary");
		FilterByTag_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FilterByTag");
		FilterByTag_ParamsSize = NativeReflection.GetFunctionParamsSize(FilterByTag_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FilterByTag_TargetArray_PropertyAddress, FilterByTag_FunctionAddress, "TargetArray");
		FilterByTag_TargetArray_Offset = NativeReflectionCached.GetPropertyOffset(FilterByTag_FunctionAddress, "TargetArray");
		FilterByTag_TargetArray_IsValid = NativeReflectionCached.ValidatePropertyClass(FilterByTag_FunctionAddress, "TargetArray", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref FilterByTag_Tag_PropertyAddress, FilterByTag_FunctionAddress, "Tag");
		FilterByTag_Tag_Offset = NativeReflectionCached.GetPropertyOffset(FilterByTag_FunctionAddress, "Tag");
		FilterByTag_Tag_IsValid = NativeReflectionCached.ValidatePropertyClass(FilterByTag_FunctionAddress, "Tag", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref FilterByTag_ReturnValue_PropertyAddress, FilterByTag_FunctionAddress, "ReturnValue");
		FilterByTag_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FilterByTag_FunctionAddress, "ReturnValue");
		FilterByTag_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FilterByTag_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		FilterByTag_IsValid = FilterByTag_FunctionAddress != IntPtr.Zero && FilterByTag_TargetArray_IsValid && FilterByTag_Tag_IsValid && FilterByTag_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepLibraries.DataprepFilterLibrary:FilterByTag", FilterByTag_IsValid);
		FilterBySize_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FilterBySize");
		FilterBySize_ParamsSize = NativeReflection.GetFunctionParamsSize(FilterBySize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FilterBySize_TargetArray_PropertyAddress, FilterBySize_FunctionAddress, "TargetArray");
		FilterBySize_TargetArray_Offset = NativeReflectionCached.GetPropertyOffset(FilterBySize_FunctionAddress, "TargetArray");
		FilterBySize_TargetArray_IsValid = NativeReflectionCached.ValidatePropertyClass(FilterBySize_FunctionAddress, "TargetArray", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref FilterBySize_SizeSource_PropertyAddress, FilterBySize_FunctionAddress, "SizeSource");
		FilterBySize_SizeSource_Offset = NativeReflectionCached.GetPropertyOffset(FilterBySize_FunctionAddress, "SizeSource");
		FilterBySize_SizeSource_IsValid = NativeReflectionCached.ValidatePropertyClass(FilterBySize_FunctionAddress, "SizeSource", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref FilterBySize_FilterMode_PropertyAddress, FilterBySize_FunctionAddress, "FilterMode");
		FilterBySize_FilterMode_Offset = NativeReflectionCached.GetPropertyOffset(FilterBySize_FunctionAddress, "FilterMode");
		FilterBySize_FilterMode_IsValid = NativeReflectionCached.ValidatePropertyClass(FilterBySize_FunctionAddress, "FilterMode", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref FilterBySize_Threshold_PropertyAddress, FilterBySize_FunctionAddress, "Threshold");
		FilterBySize_Threshold_Offset = NativeReflectionCached.GetPropertyOffset(FilterBySize_FunctionAddress, "Threshold");
		FilterBySize_Threshold_IsValid = NativeReflectionCached.ValidatePropertyClass(FilterBySize_FunctionAddress, "Threshold", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref FilterBySize_ReturnValue_PropertyAddress, FilterBySize_FunctionAddress, "ReturnValue");
		FilterBySize_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FilterBySize_FunctionAddress, "ReturnValue");
		FilterBySize_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FilterBySize_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		FilterBySize_IsValid = FilterBySize_FunctionAddress != IntPtr.Zero && FilterBySize_TargetArray_IsValid && FilterBySize_SizeSource_IsValid && FilterBySize_FilterMode_IsValid && FilterBySize_Threshold_IsValid && FilterBySize_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepLibraries.DataprepFilterLibrary:FilterBySize", FilterBySize_IsValid);
		FilterByName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FilterByName");
		FilterByName_ParamsSize = NativeReflection.GetFunctionParamsSize(FilterByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FilterByName_TargetArray_PropertyAddress, FilterByName_FunctionAddress, "TargetArray");
		FilterByName_TargetArray_Offset = NativeReflectionCached.GetPropertyOffset(FilterByName_FunctionAddress, "TargetArray");
		FilterByName_TargetArray_IsValid = NativeReflectionCached.ValidatePropertyClass(FilterByName_FunctionAddress, "TargetArray", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref FilterByName_NameSubString_PropertyAddress, FilterByName_FunctionAddress, "NameSubString");
		FilterByName_NameSubString_Offset = NativeReflectionCached.GetPropertyOffset(FilterByName_FunctionAddress, "NameSubString");
		FilterByName_NameSubString_IsValid = NativeReflectionCached.ValidatePropertyClass(FilterByName_FunctionAddress, "NameSubString", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref FilterByName_StringMatch_PropertyAddress, FilterByName_FunctionAddress, "StringMatch");
		FilterByName_StringMatch_Offset = NativeReflectionCached.GetPropertyOffset(FilterByName_FunctionAddress, "StringMatch");
		FilterByName_StringMatch_IsValid = NativeReflectionCached.ValidatePropertyClass(FilterByName_FunctionAddress, "StringMatch", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref FilterByName_ReturnValue_PropertyAddress, FilterByName_FunctionAddress, "ReturnValue");
		FilterByName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FilterByName_FunctionAddress, "ReturnValue");
		FilterByName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FilterByName_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		FilterByName_IsValid = FilterByName_FunctionAddress != IntPtr.Zero && FilterByName_TargetArray_IsValid && FilterByName_NameSubString_IsValid && FilterByName_StringMatch_IsValid && FilterByName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepLibraries.DataprepFilterLibrary:FilterByName", FilterByName_IsValid);
		FilterByClass_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FilterByClass");
		FilterByClass_ParamsSize = NativeReflection.GetFunctionParamsSize(FilterByClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FilterByClass_TargetArray_PropertyAddress, FilterByClass_FunctionAddress, "TargetArray");
		FilterByClass_TargetArray_Offset = NativeReflectionCached.GetPropertyOffset(FilterByClass_FunctionAddress, "TargetArray");
		FilterByClass_TargetArray_IsValid = NativeReflectionCached.ValidatePropertyClass(FilterByClass_FunctionAddress, "TargetArray", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref FilterByClass_ObjectClass_PropertyAddress, FilterByClass_FunctionAddress, "ObjectClass");
		FilterByClass_ObjectClass_Offset = NativeReflectionCached.GetPropertyOffset(FilterByClass_FunctionAddress, "ObjectClass");
		FilterByClass_ObjectClass_IsValid = NativeReflectionCached.ValidatePropertyClass(FilterByClass_FunctionAddress, "ObjectClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref FilterByClass_ReturnValue_PropertyAddress, FilterByClass_FunctionAddress, "ReturnValue");
		FilterByClass_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FilterByClass_FunctionAddress, "ReturnValue");
		FilterByClass_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FilterByClass_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		FilterByClass_IsValid = FilterByClass_FunctionAddress != IntPtr.Zero && FilterByClass_TargetArray_IsValid && FilterByClass_ObjectClass_IsValid && FilterByClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepLibraries.DataprepFilterLibrary:FilterByClass", FilterByClass_IsValid);
	}
}
