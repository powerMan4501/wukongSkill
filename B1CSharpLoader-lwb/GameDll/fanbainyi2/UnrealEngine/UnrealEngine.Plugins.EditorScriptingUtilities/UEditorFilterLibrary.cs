using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.EditorScriptingUtilities;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/EditorScriptingUtilities.EditorFilterLibrary", "EditorScriptingUtilities", UnrealModuleType.EnginePlugin)]
public class UEditorFilterLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool BySelection_IsValid;

	private static IntPtr BySelection_FunctionAddress;

	private static int BySelection_ParamsSize;

	private static bool BySelection_TargetArray_IsValid;

	private static FFieldAddress BySelection_TargetArray_PropertyAddress;

	private static int BySelection_TargetArray_Offset;

	private static bool BySelection_FilterType_IsValid;

	private static FFieldAddress BySelection_FilterType_PropertyAddress;

	private static int BySelection_FilterType_Offset;

	private static bool BySelection_ReturnValue_IsValid;

	private static FFieldAddress BySelection_ReturnValue_PropertyAddress;

	private static int BySelection_ReturnValue_Offset;

	private static bool ByLevelName_IsValid;

	private static IntPtr ByLevelName_FunctionAddress;

	private static int ByLevelName_ParamsSize;

	private static bool ByLevelName_TargetArray_IsValid;

	private static FFieldAddress ByLevelName_TargetArray_PropertyAddress;

	private static int ByLevelName_TargetArray_Offset;

	private static bool ByLevelName_LevelName_IsValid;

	private static FFieldAddress ByLevelName_LevelName_PropertyAddress;

	private static int ByLevelName_LevelName_Offset;

	private static bool ByLevelName_FilterType_IsValid;

	private static FFieldAddress ByLevelName_FilterType_PropertyAddress;

	private static int ByLevelName_FilterType_Offset;

	private static bool ByLevelName_ReturnValue_IsValid;

	private static FFieldAddress ByLevelName_ReturnValue_PropertyAddress;

	private static int ByLevelName_ReturnValue_Offset;

	private static bool ByLayer_IsValid;

	private static IntPtr ByLayer_FunctionAddress;

	private static int ByLayer_ParamsSize;

	private static bool ByLayer_TargetArray_IsValid;

	private static FFieldAddress ByLayer_TargetArray_PropertyAddress;

	private static int ByLayer_TargetArray_Offset;

	private static bool ByLayer_LayerName_IsValid;

	private static FFieldAddress ByLayer_LayerName_PropertyAddress;

	private static int ByLayer_LayerName_Offset;

	private static bool ByLayer_FilterType_IsValid;

	private static FFieldAddress ByLayer_FilterType_PropertyAddress;

	private static int ByLayer_FilterType_Offset;

	private static bool ByLayer_ReturnValue_IsValid;

	private static FFieldAddress ByLayer_ReturnValue_PropertyAddress;

	private static int ByLayer_ReturnValue_Offset;

	private static bool ByIDName_IsValid;

	private static IntPtr ByIDName_FunctionAddress;

	private static int ByIDName_ParamsSize;

	private static bool ByIDName_TargetArray_IsValid;

	private static FFieldAddress ByIDName_TargetArray_PropertyAddress;

	private static int ByIDName_TargetArray_Offset;

	private static bool ByIDName_NameSubString_IsValid;

	private static FFieldAddress ByIDName_NameSubString_PropertyAddress;

	private static int ByIDName_NameSubString_Offset;

	private static bool ByIDName_StringMatch_IsValid;

	private static FFieldAddress ByIDName_StringMatch_PropertyAddress;

	private static int ByIDName_StringMatch_Offset;

	private static bool ByIDName_FilterType_IsValid;

	private static FFieldAddress ByIDName_FilterType_PropertyAddress;

	private static int ByIDName_FilterType_Offset;

	private static bool ByIDName_ReturnValue_IsValid;

	private static FFieldAddress ByIDName_ReturnValue_PropertyAddress;

	private static int ByIDName_ReturnValue_Offset;

	private static bool ByClass_IsValid;

	private static IntPtr ByClass_FunctionAddress;

	private static int ByClass_ParamsSize;

	private static bool ByClass_TargetArray_IsValid;

	private static FFieldAddress ByClass_TargetArray_PropertyAddress;

	private static int ByClass_TargetArray_Offset;

	private static bool ByClass_ObjectClass_IsValid;

	private static FFieldAddress ByClass_ObjectClass_PropertyAddress;

	private static int ByClass_ObjectClass_Offset;

	private static bool ByClass_FilterType_IsValid;

	private static FFieldAddress ByClass_FilterType_PropertyAddress;

	private static int ByClass_FilterType_Offset;

	private static bool ByClass_ReturnValue_IsValid;

	private static FFieldAddress ByClass_ReturnValue_PropertyAddress;

	private static int ByClass_ReturnValue_Offset;

	private static bool ByActorTag_IsValid;

	private static IntPtr ByActorTag_FunctionAddress;

	private static int ByActorTag_ParamsSize;

	private static bool ByActorTag_TargetArray_IsValid;

	private static FFieldAddress ByActorTag_TargetArray_PropertyAddress;

	private static int ByActorTag_TargetArray_Offset;

	private static bool ByActorTag_Tag_IsValid;

	private static FFieldAddress ByActorTag_Tag_PropertyAddress;

	private static int ByActorTag_Tag_Offset;

	private static bool ByActorTag_FilterType_IsValid;

	private static FFieldAddress ByActorTag_FilterType_PropertyAddress;

	private static int ByActorTag_FilterType_Offset;

	private static bool ByActorTag_ReturnValue_IsValid;

	private static FFieldAddress ByActorTag_ReturnValue_PropertyAddress;

	private static int ByActorTag_ReturnValue_Offset;

	private static bool ByActorLabel_IsValid;

	private static IntPtr ByActorLabel_FunctionAddress;

	private static int ByActorLabel_ParamsSize;

	private static bool ByActorLabel_TargetArray_IsValid;

	private static FFieldAddress ByActorLabel_TargetArray_PropertyAddress;

	private static int ByActorLabel_TargetArray_Offset;

	private static bool ByActorLabel_NameSubString_IsValid;

	private static FFieldAddress ByActorLabel_NameSubString_PropertyAddress;

	private static int ByActorLabel_NameSubString_Offset;

	private static bool ByActorLabel_StringMatch_IsValid;

	private static FFieldAddress ByActorLabel_StringMatch_PropertyAddress;

	private static int ByActorLabel_StringMatch_Offset;

	private static bool ByActorLabel_FilterType_IsValid;

	private static FFieldAddress ByActorLabel_FilterType_PropertyAddress;

	private static int ByActorLabel_FilterType_Offset;

	private static bool ByActorLabel_bIgnoreCase_IsValid;

	private static FFieldAddress ByActorLabel_bIgnoreCase_PropertyAddress;

	private static int ByActorLabel_bIgnoreCase_Offset;

	private static bool ByActorLabel_ReturnValue_IsValid;

	private static FFieldAddress ByActorLabel_ReturnValue_PropertyAddress;

	private static int ByActorLabel_ReturnValue_Offset;

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorFilterLibrary:BySelection")]
	public unsafe static List<AActor> BySelection(List<AActor> TargetArray, EEditorScriptingFilterType FilterType = EEditorScriptingFilterType.Include)
	{
		if (!BySelection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EditorScriptingUtilities.EditorFilterLibrary:BySelection");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BySelection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BySelection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<AActor>(1, BySelection_TargetArray_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).ToNative(IntPtr.Add(intPtr, BySelection_TargetArray_Offset), TargetArray);
		EnumMarshaler<EEditorScriptingFilterType>.ToNative(IntPtr.Add(intPtr, BySelection_FilterType_Offset), 0, BySelection_FilterType_PropertyAddress.Address, FilterType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BySelection_FunctionAddress, intPtr, BySelection_ParamsSize);
		NativeReflection.DestroyValue_InContainer(BySelection_TargetArray_PropertyAddress.Address, intPtr);
		List<AActor> result = new TArrayCopyMarshaler<AActor>(1, BySelection_ReturnValue_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(intPtr, BySelection_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(BySelection_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorFilterLibrary:ByLevelName")]
	public unsafe static List<AActor> ByLevelName(List<AActor> TargetArray, FName LevelName, EEditorScriptingFilterType FilterType = EEditorScriptingFilterType.Include)
	{
		if (!ByLevelName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EditorScriptingUtilities.EditorFilterLibrary:ByLevelName");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ByLevelName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ByLevelName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<AActor>(1, ByLevelName_TargetArray_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).ToNative(IntPtr.Add(intPtr, ByLevelName_TargetArray_Offset), TargetArray);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ByLevelName_LevelName_Offset), 0, ByLevelName_LevelName_PropertyAddress.Address, LevelName);
		EnumMarshaler<EEditorScriptingFilterType>.ToNative(IntPtr.Add(intPtr, ByLevelName_FilterType_Offset), 0, ByLevelName_FilterType_PropertyAddress.Address, FilterType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ByLevelName_FunctionAddress, intPtr, ByLevelName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ByLevelName_TargetArray_PropertyAddress.Address, intPtr);
		List<AActor> result = new TArrayCopyMarshaler<AActor>(1, ByLevelName_ReturnValue_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(intPtr, ByLevelName_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(ByLevelName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorFilterLibrary:ByLayer")]
	public unsafe static List<AActor> ByLayer(List<AActor> TargetArray, FName LayerName, EEditorScriptingFilterType FilterType = EEditorScriptingFilterType.Include)
	{
		if (!ByLayer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EditorScriptingUtilities.EditorFilterLibrary:ByLayer");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ByLayer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ByLayer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<AActor>(1, ByLayer_TargetArray_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).ToNative(IntPtr.Add(intPtr, ByLayer_TargetArray_Offset), TargetArray);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ByLayer_LayerName_Offset), 0, ByLayer_LayerName_PropertyAddress.Address, LayerName);
		EnumMarshaler<EEditorScriptingFilterType>.ToNative(IntPtr.Add(intPtr, ByLayer_FilterType_Offset), 0, ByLayer_FilterType_PropertyAddress.Address, FilterType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ByLayer_FunctionAddress, intPtr, ByLayer_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ByLayer_TargetArray_PropertyAddress.Address, intPtr);
		List<AActor> result = new TArrayCopyMarshaler<AActor>(1, ByLayer_ReturnValue_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(intPtr, ByLayer_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(ByLayer_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorFilterLibrary:ByIDName")]
	public unsafe static List<UObject> ByIDName(List<UObject> TargetArray, string NameSubString, EEditorScriptingStringMatchType StringMatch = EEditorScriptingStringMatchType.Contains, EEditorScriptingFilterType FilterType = EEditorScriptingFilterType.Include)
	{
		if (!ByIDName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EditorScriptingUtilities.EditorFilterLibrary:ByIDName");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ByIDName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ByIDName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UObject>(1, ByIDName_TargetArray_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, ByIDName_TargetArray_Offset), TargetArray);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ByIDName_NameSubString_Offset), 0, ByIDName_NameSubString_PropertyAddress.Address, NameSubString);
		EnumMarshaler<EEditorScriptingStringMatchType>.ToNative(IntPtr.Add(intPtr, ByIDName_StringMatch_Offset), 0, ByIDName_StringMatch_PropertyAddress.Address, StringMatch);
		EnumMarshaler<EEditorScriptingFilterType>.ToNative(IntPtr.Add(intPtr, ByIDName_FilterType_Offset), 0, ByIDName_FilterType_PropertyAddress.Address, FilterType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ByIDName_FunctionAddress, intPtr, ByIDName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ByIDName_TargetArray_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ByIDName_NameSubString_PropertyAddress.Address, intPtr);
		List<UObject> result = new TArrayCopyMarshaler<UObject>(1, ByIDName_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, ByIDName_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(ByIDName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorFilterLibrary:ByClass")]
	public unsafe static List<UObject> ByClass(List<UObject> TargetArray, TSubclassOf<UObject> ObjectClass, EEditorScriptingFilterType FilterType = EEditorScriptingFilterType.Include)
	{
		if (!ByClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EditorScriptingUtilities.EditorFilterLibrary:ByClass");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ByClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ByClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UObject>(1, ByClass_TargetArray_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, ByClass_TargetArray_Offset), TargetArray);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ByClass_ObjectClass_Offset), 0, ByClass_ObjectClass_PropertyAddress.Address, ObjectClass);
		EnumMarshaler<EEditorScriptingFilterType>.ToNative(IntPtr.Add(intPtr, ByClass_FilterType_Offset), 0, ByClass_FilterType_PropertyAddress.Address, FilterType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ByClass_FunctionAddress, intPtr, ByClass_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ByClass_TargetArray_PropertyAddress.Address, intPtr);
		List<UObject> result = new TArrayCopyMarshaler<UObject>(1, ByClass_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, ByClass_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(ByClass_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorFilterLibrary:ByActorTag")]
	public unsafe static List<AActor> ByActorTag(List<AActor> TargetArray, FName Tag, EEditorScriptingFilterType FilterType = EEditorScriptingFilterType.Include)
	{
		if (!ByActorTag_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EditorScriptingUtilities.EditorFilterLibrary:ByActorTag");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ByActorTag_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ByActorTag_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<AActor>(1, ByActorTag_TargetArray_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).ToNative(IntPtr.Add(intPtr, ByActorTag_TargetArray_Offset), TargetArray);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ByActorTag_Tag_Offset), 0, ByActorTag_Tag_PropertyAddress.Address, Tag);
		EnumMarshaler<EEditorScriptingFilterType>.ToNative(IntPtr.Add(intPtr, ByActorTag_FilterType_Offset), 0, ByActorTag_FilterType_PropertyAddress.Address, FilterType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ByActorTag_FunctionAddress, intPtr, ByActorTag_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ByActorTag_TargetArray_PropertyAddress.Address, intPtr);
		List<AActor> result = new TArrayCopyMarshaler<AActor>(1, ByActorTag_ReturnValue_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(intPtr, ByActorTag_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(ByActorTag_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorFilterLibrary:ByActorLabel")]
	public unsafe static List<AActor> ByActorLabel(List<AActor> TargetArray, string NameSubString, EEditorScriptingStringMatchType StringMatch = EEditorScriptingStringMatchType.Contains, EEditorScriptingFilterType FilterType = EEditorScriptingFilterType.Include, bool bIgnoreCase = true)
	{
		if (!ByActorLabel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EditorScriptingUtilities.EditorFilterLibrary:ByActorLabel");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ByActorLabel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ByActorLabel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<AActor>(1, ByActorLabel_TargetArray_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).ToNative(IntPtr.Add(intPtr, ByActorLabel_TargetArray_Offset), TargetArray);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ByActorLabel_NameSubString_Offset), 0, ByActorLabel_NameSubString_PropertyAddress.Address, NameSubString);
		EnumMarshaler<EEditorScriptingStringMatchType>.ToNative(IntPtr.Add(intPtr, ByActorLabel_StringMatch_Offset), 0, ByActorLabel_StringMatch_PropertyAddress.Address, StringMatch);
		EnumMarshaler<EEditorScriptingFilterType>.ToNative(IntPtr.Add(intPtr, ByActorLabel_FilterType_Offset), 0, ByActorLabel_FilterType_PropertyAddress.Address, FilterType);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ByActorLabel_bIgnoreCase_Offset), 0, ByActorLabel_bIgnoreCase_PropertyAddress.Address, bIgnoreCase);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ByActorLabel_FunctionAddress, intPtr, ByActorLabel_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ByActorLabel_TargetArray_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ByActorLabel_NameSubString_PropertyAddress.Address, intPtr);
		List<AActor> result = new TArrayCopyMarshaler<AActor>(1, ByActorLabel_ReturnValue_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(intPtr, ByActorLabel_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(ByActorLabel_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UEditorFilterLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UEditorFilterLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UEditorFilterLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/EditorScriptingUtilities.EditorFilterLibrary");
		BySelection_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BySelection");
		BySelection_ParamsSize = NativeReflection.GetFunctionParamsSize(BySelection_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BySelection_TargetArray_PropertyAddress, BySelection_FunctionAddress, "TargetArray");
		BySelection_TargetArray_Offset = NativeReflectionCached.GetPropertyOffset(BySelection_FunctionAddress, "TargetArray");
		BySelection_TargetArray_IsValid = NativeReflectionCached.ValidatePropertyClass(BySelection_FunctionAddress, "TargetArray", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref BySelection_FilterType_PropertyAddress, BySelection_FunctionAddress, "FilterType");
		BySelection_FilterType_Offset = NativeReflectionCached.GetPropertyOffset(BySelection_FunctionAddress, "FilterType");
		BySelection_FilterType_IsValid = NativeReflectionCached.ValidatePropertyClass(BySelection_FunctionAddress, "FilterType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref BySelection_ReturnValue_PropertyAddress, BySelection_FunctionAddress, "ReturnValue");
		BySelection_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BySelection_FunctionAddress, "ReturnValue");
		BySelection_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BySelection_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		BySelection_IsValid = BySelection_FunctionAddress != IntPtr.Zero && BySelection_TargetArray_IsValid && BySelection_FilterType_IsValid && BySelection_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EditorScriptingUtilities.EditorFilterLibrary:BySelection", BySelection_IsValid);
		ByLevelName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ByLevelName");
		ByLevelName_ParamsSize = NativeReflection.GetFunctionParamsSize(ByLevelName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ByLevelName_TargetArray_PropertyAddress, ByLevelName_FunctionAddress, "TargetArray");
		ByLevelName_TargetArray_Offset = NativeReflectionCached.GetPropertyOffset(ByLevelName_FunctionAddress, "TargetArray");
		ByLevelName_TargetArray_IsValid = NativeReflectionCached.ValidatePropertyClass(ByLevelName_FunctionAddress, "TargetArray", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ByLevelName_LevelName_PropertyAddress, ByLevelName_FunctionAddress, "LevelName");
		ByLevelName_LevelName_Offset = NativeReflectionCached.GetPropertyOffset(ByLevelName_FunctionAddress, "LevelName");
		ByLevelName_LevelName_IsValid = NativeReflectionCached.ValidatePropertyClass(ByLevelName_FunctionAddress, "LevelName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref ByLevelName_FilterType_PropertyAddress, ByLevelName_FunctionAddress, "FilterType");
		ByLevelName_FilterType_Offset = NativeReflectionCached.GetPropertyOffset(ByLevelName_FunctionAddress, "FilterType");
		ByLevelName_FilterType_IsValid = NativeReflectionCached.ValidatePropertyClass(ByLevelName_FunctionAddress, "FilterType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref ByLevelName_ReturnValue_PropertyAddress, ByLevelName_FunctionAddress, "ReturnValue");
		ByLevelName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ByLevelName_FunctionAddress, "ReturnValue");
		ByLevelName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ByLevelName_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		ByLevelName_IsValid = ByLevelName_FunctionAddress != IntPtr.Zero && ByLevelName_TargetArray_IsValid && ByLevelName_LevelName_IsValid && ByLevelName_FilterType_IsValid && ByLevelName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EditorScriptingUtilities.EditorFilterLibrary:ByLevelName", ByLevelName_IsValid);
		ByLayer_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ByLayer");
		ByLayer_ParamsSize = NativeReflection.GetFunctionParamsSize(ByLayer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ByLayer_TargetArray_PropertyAddress, ByLayer_FunctionAddress, "TargetArray");
		ByLayer_TargetArray_Offset = NativeReflectionCached.GetPropertyOffset(ByLayer_FunctionAddress, "TargetArray");
		ByLayer_TargetArray_IsValid = NativeReflectionCached.ValidatePropertyClass(ByLayer_FunctionAddress, "TargetArray", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ByLayer_LayerName_PropertyAddress, ByLayer_FunctionAddress, "LayerName");
		ByLayer_LayerName_Offset = NativeReflectionCached.GetPropertyOffset(ByLayer_FunctionAddress, "LayerName");
		ByLayer_LayerName_IsValid = NativeReflectionCached.ValidatePropertyClass(ByLayer_FunctionAddress, "LayerName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref ByLayer_FilterType_PropertyAddress, ByLayer_FunctionAddress, "FilterType");
		ByLayer_FilterType_Offset = NativeReflectionCached.GetPropertyOffset(ByLayer_FunctionAddress, "FilterType");
		ByLayer_FilterType_IsValid = NativeReflectionCached.ValidatePropertyClass(ByLayer_FunctionAddress, "FilterType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref ByLayer_ReturnValue_PropertyAddress, ByLayer_FunctionAddress, "ReturnValue");
		ByLayer_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ByLayer_FunctionAddress, "ReturnValue");
		ByLayer_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ByLayer_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		ByLayer_IsValid = ByLayer_FunctionAddress != IntPtr.Zero && ByLayer_TargetArray_IsValid && ByLayer_LayerName_IsValid && ByLayer_FilterType_IsValid && ByLayer_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EditorScriptingUtilities.EditorFilterLibrary:ByLayer", ByLayer_IsValid);
		ByIDName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ByIDName");
		ByIDName_ParamsSize = NativeReflection.GetFunctionParamsSize(ByIDName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ByIDName_TargetArray_PropertyAddress, ByIDName_FunctionAddress, "TargetArray");
		ByIDName_TargetArray_Offset = NativeReflectionCached.GetPropertyOffset(ByIDName_FunctionAddress, "TargetArray");
		ByIDName_TargetArray_IsValid = NativeReflectionCached.ValidatePropertyClass(ByIDName_FunctionAddress, "TargetArray", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ByIDName_NameSubString_PropertyAddress, ByIDName_FunctionAddress, "NameSubString");
		ByIDName_NameSubString_Offset = NativeReflectionCached.GetPropertyOffset(ByIDName_FunctionAddress, "NameSubString");
		ByIDName_NameSubString_IsValid = NativeReflectionCached.ValidatePropertyClass(ByIDName_FunctionAddress, "NameSubString", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ByIDName_StringMatch_PropertyAddress, ByIDName_FunctionAddress, "StringMatch");
		ByIDName_StringMatch_Offset = NativeReflectionCached.GetPropertyOffset(ByIDName_FunctionAddress, "StringMatch");
		ByIDName_StringMatch_IsValid = NativeReflectionCached.ValidatePropertyClass(ByIDName_FunctionAddress, "StringMatch", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref ByIDName_FilterType_PropertyAddress, ByIDName_FunctionAddress, "FilterType");
		ByIDName_FilterType_Offset = NativeReflectionCached.GetPropertyOffset(ByIDName_FunctionAddress, "FilterType");
		ByIDName_FilterType_IsValid = NativeReflectionCached.ValidatePropertyClass(ByIDName_FunctionAddress, "FilterType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref ByIDName_ReturnValue_PropertyAddress, ByIDName_FunctionAddress, "ReturnValue");
		ByIDName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ByIDName_FunctionAddress, "ReturnValue");
		ByIDName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ByIDName_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		ByIDName_IsValid = ByIDName_FunctionAddress != IntPtr.Zero && ByIDName_TargetArray_IsValid && ByIDName_NameSubString_IsValid && ByIDName_StringMatch_IsValid && ByIDName_FilterType_IsValid && ByIDName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EditorScriptingUtilities.EditorFilterLibrary:ByIDName", ByIDName_IsValid);
		ByClass_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ByClass");
		ByClass_ParamsSize = NativeReflection.GetFunctionParamsSize(ByClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ByClass_TargetArray_PropertyAddress, ByClass_FunctionAddress, "TargetArray");
		ByClass_TargetArray_Offset = NativeReflectionCached.GetPropertyOffset(ByClass_FunctionAddress, "TargetArray");
		ByClass_TargetArray_IsValid = NativeReflectionCached.ValidatePropertyClass(ByClass_FunctionAddress, "TargetArray", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ByClass_ObjectClass_PropertyAddress, ByClass_FunctionAddress, "ObjectClass");
		ByClass_ObjectClass_Offset = NativeReflectionCached.GetPropertyOffset(ByClass_FunctionAddress, "ObjectClass");
		ByClass_ObjectClass_IsValid = NativeReflectionCached.ValidatePropertyClass(ByClass_FunctionAddress, "ObjectClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref ByClass_FilterType_PropertyAddress, ByClass_FunctionAddress, "FilterType");
		ByClass_FilterType_Offset = NativeReflectionCached.GetPropertyOffset(ByClass_FunctionAddress, "FilterType");
		ByClass_FilterType_IsValid = NativeReflectionCached.ValidatePropertyClass(ByClass_FunctionAddress, "FilterType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref ByClass_ReturnValue_PropertyAddress, ByClass_FunctionAddress, "ReturnValue");
		ByClass_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ByClass_FunctionAddress, "ReturnValue");
		ByClass_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ByClass_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		ByClass_IsValid = ByClass_FunctionAddress != IntPtr.Zero && ByClass_TargetArray_IsValid && ByClass_ObjectClass_IsValid && ByClass_FilterType_IsValid && ByClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EditorScriptingUtilities.EditorFilterLibrary:ByClass", ByClass_IsValid);
		ByActorTag_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ByActorTag");
		ByActorTag_ParamsSize = NativeReflection.GetFunctionParamsSize(ByActorTag_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ByActorTag_TargetArray_PropertyAddress, ByActorTag_FunctionAddress, "TargetArray");
		ByActorTag_TargetArray_Offset = NativeReflectionCached.GetPropertyOffset(ByActorTag_FunctionAddress, "TargetArray");
		ByActorTag_TargetArray_IsValid = NativeReflectionCached.ValidatePropertyClass(ByActorTag_FunctionAddress, "TargetArray", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ByActorTag_Tag_PropertyAddress, ByActorTag_FunctionAddress, "Tag");
		ByActorTag_Tag_Offset = NativeReflectionCached.GetPropertyOffset(ByActorTag_FunctionAddress, "Tag");
		ByActorTag_Tag_IsValid = NativeReflectionCached.ValidatePropertyClass(ByActorTag_FunctionAddress, "Tag", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref ByActorTag_FilterType_PropertyAddress, ByActorTag_FunctionAddress, "FilterType");
		ByActorTag_FilterType_Offset = NativeReflectionCached.GetPropertyOffset(ByActorTag_FunctionAddress, "FilterType");
		ByActorTag_FilterType_IsValid = NativeReflectionCached.ValidatePropertyClass(ByActorTag_FunctionAddress, "FilterType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref ByActorTag_ReturnValue_PropertyAddress, ByActorTag_FunctionAddress, "ReturnValue");
		ByActorTag_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ByActorTag_FunctionAddress, "ReturnValue");
		ByActorTag_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ByActorTag_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		ByActorTag_IsValid = ByActorTag_FunctionAddress != IntPtr.Zero && ByActorTag_TargetArray_IsValid && ByActorTag_Tag_IsValid && ByActorTag_FilterType_IsValid && ByActorTag_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EditorScriptingUtilities.EditorFilterLibrary:ByActorTag", ByActorTag_IsValid);
		ByActorLabel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ByActorLabel");
		ByActorLabel_ParamsSize = NativeReflection.GetFunctionParamsSize(ByActorLabel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ByActorLabel_TargetArray_PropertyAddress, ByActorLabel_FunctionAddress, "TargetArray");
		ByActorLabel_TargetArray_Offset = NativeReflectionCached.GetPropertyOffset(ByActorLabel_FunctionAddress, "TargetArray");
		ByActorLabel_TargetArray_IsValid = NativeReflectionCached.ValidatePropertyClass(ByActorLabel_FunctionAddress, "TargetArray", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ByActorLabel_NameSubString_PropertyAddress, ByActorLabel_FunctionAddress, "NameSubString");
		ByActorLabel_NameSubString_Offset = NativeReflectionCached.GetPropertyOffset(ByActorLabel_FunctionAddress, "NameSubString");
		ByActorLabel_NameSubString_IsValid = NativeReflectionCached.ValidatePropertyClass(ByActorLabel_FunctionAddress, "NameSubString", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ByActorLabel_StringMatch_PropertyAddress, ByActorLabel_FunctionAddress, "StringMatch");
		ByActorLabel_StringMatch_Offset = NativeReflectionCached.GetPropertyOffset(ByActorLabel_FunctionAddress, "StringMatch");
		ByActorLabel_StringMatch_IsValid = NativeReflectionCached.ValidatePropertyClass(ByActorLabel_FunctionAddress, "StringMatch", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref ByActorLabel_FilterType_PropertyAddress, ByActorLabel_FunctionAddress, "FilterType");
		ByActorLabel_FilterType_Offset = NativeReflectionCached.GetPropertyOffset(ByActorLabel_FunctionAddress, "FilterType");
		ByActorLabel_FilterType_IsValid = NativeReflectionCached.ValidatePropertyClass(ByActorLabel_FunctionAddress, "FilterType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref ByActorLabel_bIgnoreCase_PropertyAddress, ByActorLabel_FunctionAddress, "bIgnoreCase");
		ByActorLabel_bIgnoreCase_Offset = NativeReflectionCached.GetPropertyOffset(ByActorLabel_FunctionAddress, "bIgnoreCase");
		ByActorLabel_bIgnoreCase_IsValid = NativeReflectionCached.ValidatePropertyClass(ByActorLabel_FunctionAddress, "bIgnoreCase", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ByActorLabel_ReturnValue_PropertyAddress, ByActorLabel_FunctionAddress, "ReturnValue");
		ByActorLabel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ByActorLabel_FunctionAddress, "ReturnValue");
		ByActorLabel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ByActorLabel_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		ByActorLabel_IsValid = ByActorLabel_FunctionAddress != IntPtr.Zero && ByActorLabel_TargetArray_IsValid && ByActorLabel_NameSubString_IsValid && ByActorLabel_StringMatch_IsValid && ByActorLabel_FilterType_IsValid && ByActorLabel_bIgnoreCase_IsValid && ByActorLabel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EditorScriptingUtilities.EditorFilterLibrary:ByActorLabel", ByActorLabel_IsValid);
	}
}
