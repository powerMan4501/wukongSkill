using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/FuncLibEditor.GSEditorContentLibrary", "FuncLibEditor", UnrealModuleType.Game)]
public class UGSEditorContentLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool LoadLevel_IsValid;

	private static IntPtr LoadLevel_FunctionAddress;

	private static int LoadLevel_ParamsSize;

	private static bool LoadLevel_LevelPath_IsValid;

	private static FFieldAddress LoadLevel_LevelPath_PropertyAddress;

	private static int LoadLevel_LevelPath_Offset;

	private static bool GetContentCurrentPath_IsValid;

	private static IntPtr GetContentCurrentPath_FunctionAddress;

	private static int GetContentCurrentPath_ParamsSize;

	private static bool GetContentCurrentPath_ReturnValue_IsValid;

	private static FFieldAddress GetContentCurrentPath_ReturnValue_PropertyAddress;

	private static int GetContentCurrentPath_ReturnValue_Offset;

	private static bool GetAssetsByTagValues_IsValid;

	private static IntPtr GetAssetsByTagValues_FunctionAddress;

	private static int GetAssetsByTagValues_ParamsSize;

	private static bool GetAssetsByTagValues_Tags_IsValid;

	private static FFieldAddress GetAssetsByTagValues_Tags_PropertyAddress;

	private static int GetAssetsByTagValues_Tags_Offset;

	private static bool GetAssetsByTagValues_Values_IsValid;

	private static FFieldAddress GetAssetsByTagValues_Values_PropertyAddress;

	private static int GetAssetsByTagValues_Values_Offset;

	private static bool GetAssetsByTagValues_OutAssetData_IsValid;

	private static FFieldAddress GetAssetsByTagValues_OutAssetData_PropertyAddress;

	private static int GetAssetsByTagValues_OutAssetData_Offset;

	private static bool GetAssetsByTagValues_ReturnValue_IsValid;

	private static FFieldAddress GetAssetsByTagValues_ReturnValue_PropertyAddress;

	private static int GetAssetsByTagValues_ReturnValue_Offset;

	private static bool GetAssetsByClass_IsValid;

	private static IntPtr GetAssetsByClass_FunctionAddress;

	private static int GetAssetsByClass_ParamsSize;

	private static bool GetAssetsByClass_ClassName_IsValid;

	private static FFieldAddress GetAssetsByClass_ClassName_PropertyAddress;

	private static int GetAssetsByClass_ClassName_Offset;

	private static bool GetAssetsByClass_bSearchSubClasses_IsValid;

	private static FFieldAddress GetAssetsByClass_bSearchSubClasses_PropertyAddress;

	private static int GetAssetsByClass_bSearchSubClasses_Offset;

	private static bool GetAssetsByClass_ReturnValue_IsValid;

	private static FFieldAddress GetAssetsByClass_ReturnValue_PropertyAddress;

	private static int GetAssetsByClass_ReturnValue_Offset;

	private static bool FindAsset_IsValid;

	private static IntPtr FindAsset_FunctionAddress;

	private static int FindAsset_ParamsSize;

	private static bool FindAsset_Path_IsValid;

	private static FFieldAddress FindAsset_Path_PropertyAddress;

	private static int FindAsset_Path_Offset;

	private static bool FindAsset_inClass_IsValid;

	private static FFieldAddress FindAsset_inClass_PropertyAddress;

	private static int FindAsset_inClass_Offset;

	private static bool FindAsset_AssetData_IsValid;

	private static FFieldAddress FindAsset_AssetData_PropertyAddress;

	private static int FindAsset_AssetData_Offset;

	private static bool FindAsset_bRecursive_IsValid;

	private static FFieldAddress FindAsset_bRecursive_PropertyAddress;

	private static int FindAsset_bRecursive_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorContentLibrary:LoadLevel")]
	public unsafe static void LoadLevel(string LevelPath)
	{
		if (!LoadLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorContentLibrary:LoadLevel");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LoadLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LoadLevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, LoadLevel_LevelPath_Offset), 0, LoadLevel_LevelPath_PropertyAddress.Address, LevelPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LoadLevel_FunctionAddress, intPtr, LoadLevel_ParamsSize);
		NativeReflection.DestroyValue_InContainer(LoadLevel_LevelPath_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorContentLibrary:GetContentCurrentPath")]
	public unsafe static string GetContentCurrentPath()
	{
		if (!GetContentCurrentPath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorContentLibrary:GetContentCurrentPath");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetContentCurrentPath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetContentCurrentPath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetContentCurrentPath_FunctionAddress, intPtr, GetContentCurrentPath_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetContentCurrentPath_ReturnValue_Offset), 0, GetContentCurrentPath_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetContentCurrentPath_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorContentLibrary:GetAssetsByTagValues")]
	public unsafe static bool GetAssetsByTagValues(List<FName> Tags, List<string> Values, out List<FAssetData> OutAssetData)
	{
		if (!GetAssetsByTagValues_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorContentLibrary:GetAssetsByTagValues");
			OutAssetData = null;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAssetsByTagValues_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAssetsByTagValues_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FName>(1, GetAssetsByTagValues_Tags_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(intPtr, GetAssetsByTagValues_Tags_Offset), Tags);
		new TArrayCopyMarshaler<string>(1, GetAssetsByTagValues_Values_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, GetAssetsByTagValues_Values_Offset), Values);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAssetsByTagValues_FunctionAddress, intPtr, GetAssetsByTagValues_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetAssetsByTagValues_Tags_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(GetAssetsByTagValues_Values_PropertyAddress.Address, intPtr);
		OutAssetData = new TArrayCopyMarshaler<FAssetData>(1, GetAssetsByTagValues_OutAssetData_PropertyAddress, CachedMarshalingDelegates<FAssetData, FAssetData>.FromNative, CachedMarshalingDelegates<FAssetData, FAssetData>.ToNative).FromNative(IntPtr.Add(intPtr, GetAssetsByTagValues_OutAssetData_Offset));
		NativeReflection.DestroyValue_InContainer(GetAssetsByTagValues_OutAssetData_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetAssetsByTagValues_ReturnValue_Offset), 0, GetAssetsByTagValues_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorContentLibrary:GetAssetsByClass")]
	public unsafe static UAssetDataArray GetAssetsByClass(string ClassName, bool bSearchSubClasses)
	{
		if (!GetAssetsByClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorContentLibrary:GetAssetsByClass");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAssetsByClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAssetsByClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetAssetsByClass_ClassName_Offset), 0, GetAssetsByClass_ClassName_PropertyAddress.Address, ClassName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetAssetsByClass_bSearchSubClasses_Offset), 0, GetAssetsByClass_bSearchSubClasses_PropertyAddress.Address, bSearchSubClasses);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAssetsByClass_FunctionAddress, intPtr, GetAssetsByClass_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetAssetsByClass_ClassName_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UAssetDataArray>.FromNative(IntPtr.Add(intPtr, GetAssetsByClass_ReturnValue_Offset), 0, GetAssetsByClass_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorContentLibrary:FindAsset")]
	public unsafe static void FindAsset(string Path, TSubclassOf<UObject> inClass, out List<FAssetData> AssetData, bool bRecursive = false)
	{
		if (!FindAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorContentLibrary:FindAsset");
			AssetData = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, FindAsset_Path_Offset), 0, FindAsset_Path_PropertyAddress.Address, Path);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, FindAsset_inClass_Offset), 0, FindAsset_inClass_PropertyAddress.Address, inClass);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, FindAsset_bRecursive_Offset), 0, FindAsset_bRecursive_PropertyAddress.Address, bRecursive);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FindAsset_FunctionAddress, intPtr, FindAsset_ParamsSize);
		NativeReflection.DestroyValue_InContainer(FindAsset_Path_PropertyAddress.Address, intPtr);
		AssetData = new TArrayCopyMarshaler<FAssetData>(1, FindAsset_AssetData_PropertyAddress, CachedMarshalingDelegates<FAssetData, FAssetData>.FromNative, CachedMarshalingDelegates<FAssetData, FAssetData>.ToNative).FromNative(IntPtr.Add(intPtr, FindAsset_AssetData_Offset));
		NativeReflection.DestroyValue_InContainer(FindAsset_AssetData_PropertyAddress.Address, intPtr);
	}

	static UGSEditorContentLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSEditorContentLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSEditorContentLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/FuncLibEditor.GSEditorContentLibrary");
		LoadLevel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LoadLevel");
		LoadLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(LoadLevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LoadLevel_LevelPath_PropertyAddress, LoadLevel_FunctionAddress, "LevelPath");
		LoadLevel_LevelPath_Offset = NativeReflectionCached.GetPropertyOffset(LoadLevel_FunctionAddress, "LevelPath");
		LoadLevel_LevelPath_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadLevel_FunctionAddress, "LevelPath", Classes.FStrProperty);
		LoadLevel_IsValid = LoadLevel_FunctionAddress != IntPtr.Zero && LoadLevel_LevelPath_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorContentLibrary:LoadLevel", LoadLevel_IsValid);
		GetContentCurrentPath_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetContentCurrentPath");
		GetContentCurrentPath_ParamsSize = NativeReflection.GetFunctionParamsSize(GetContentCurrentPath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetContentCurrentPath_ReturnValue_PropertyAddress, GetContentCurrentPath_FunctionAddress, "ReturnValue");
		GetContentCurrentPath_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetContentCurrentPath_FunctionAddress, "ReturnValue");
		GetContentCurrentPath_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetContentCurrentPath_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetContentCurrentPath_IsValid = GetContentCurrentPath_FunctionAddress != IntPtr.Zero && GetContentCurrentPath_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorContentLibrary:GetContentCurrentPath", GetContentCurrentPath_IsValid);
		GetAssetsByTagValues_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAssetsByTagValues");
		GetAssetsByTagValues_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAssetsByTagValues_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAssetsByTagValues_Tags_PropertyAddress, GetAssetsByTagValues_FunctionAddress, "Tags");
		GetAssetsByTagValues_Tags_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetsByTagValues_FunctionAddress, "Tags");
		GetAssetsByTagValues_Tags_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetsByTagValues_FunctionAddress, "Tags", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAssetsByTagValues_Values_PropertyAddress, GetAssetsByTagValues_FunctionAddress, "Values");
		GetAssetsByTagValues_Values_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetsByTagValues_FunctionAddress, "Values");
		GetAssetsByTagValues_Values_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetsByTagValues_FunctionAddress, "Values", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAssetsByTagValues_OutAssetData_PropertyAddress, GetAssetsByTagValues_FunctionAddress, "OutAssetData");
		GetAssetsByTagValues_OutAssetData_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetsByTagValues_FunctionAddress, "OutAssetData");
		GetAssetsByTagValues_OutAssetData_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetsByTagValues_FunctionAddress, "OutAssetData", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAssetsByTagValues_ReturnValue_PropertyAddress, GetAssetsByTagValues_FunctionAddress, "ReturnValue");
		GetAssetsByTagValues_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetsByTagValues_FunctionAddress, "ReturnValue");
		GetAssetsByTagValues_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetsByTagValues_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetAssetsByTagValues_IsValid = GetAssetsByTagValues_FunctionAddress != IntPtr.Zero && GetAssetsByTagValues_Tags_IsValid && GetAssetsByTagValues_Values_IsValid && GetAssetsByTagValues_OutAssetData_IsValid && GetAssetsByTagValues_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorContentLibrary:GetAssetsByTagValues", GetAssetsByTagValues_IsValid);
		GetAssetsByClass_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAssetsByClass");
		GetAssetsByClass_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAssetsByClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAssetsByClass_ClassName_PropertyAddress, GetAssetsByClass_FunctionAddress, "ClassName");
		GetAssetsByClass_ClassName_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetsByClass_FunctionAddress, "ClassName");
		GetAssetsByClass_ClassName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetsByClass_FunctionAddress, "ClassName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAssetsByClass_bSearchSubClasses_PropertyAddress, GetAssetsByClass_FunctionAddress, "bSearchSubClasses");
		GetAssetsByClass_bSearchSubClasses_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetsByClass_FunctionAddress, "bSearchSubClasses");
		GetAssetsByClass_bSearchSubClasses_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetsByClass_FunctionAddress, "bSearchSubClasses", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAssetsByClass_ReturnValue_PropertyAddress, GetAssetsByClass_FunctionAddress, "ReturnValue");
		GetAssetsByClass_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetsByClass_FunctionAddress, "ReturnValue");
		GetAssetsByClass_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetsByClass_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetAssetsByClass_IsValid = GetAssetsByClass_FunctionAddress != IntPtr.Zero && GetAssetsByClass_ClassName_IsValid && GetAssetsByClass_bSearchSubClasses_IsValid && GetAssetsByClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorContentLibrary:GetAssetsByClass", GetAssetsByClass_IsValid);
		FindAsset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FindAsset");
		FindAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(FindAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindAsset_Path_PropertyAddress, FindAsset_FunctionAddress, "Path");
		FindAsset_Path_Offset = NativeReflectionCached.GetPropertyOffset(FindAsset_FunctionAddress, "Path");
		FindAsset_Path_IsValid = NativeReflectionCached.ValidatePropertyClass(FindAsset_FunctionAddress, "Path", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref FindAsset_inClass_PropertyAddress, FindAsset_FunctionAddress, "inClass");
		FindAsset_inClass_Offset = NativeReflectionCached.GetPropertyOffset(FindAsset_FunctionAddress, "inClass");
		FindAsset_inClass_IsValid = NativeReflectionCached.ValidatePropertyClass(FindAsset_FunctionAddress, "inClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref FindAsset_AssetData_PropertyAddress, FindAsset_FunctionAddress, "AssetData");
		FindAsset_AssetData_Offset = NativeReflectionCached.GetPropertyOffset(FindAsset_FunctionAddress, "AssetData");
		FindAsset_AssetData_IsValid = NativeReflectionCached.ValidatePropertyClass(FindAsset_FunctionAddress, "AssetData", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref FindAsset_bRecursive_PropertyAddress, FindAsset_FunctionAddress, "bRecursive");
		FindAsset_bRecursive_Offset = NativeReflectionCached.GetPropertyOffset(FindAsset_FunctionAddress, "bRecursive");
		FindAsset_bRecursive_IsValid = NativeReflectionCached.ValidatePropertyClass(FindAsset_FunctionAddress, "bRecursive", Classes.FBoolProperty);
		FindAsset_IsValid = FindAsset_FunctionAddress != IntPtr.Zero && FindAsset_Path_IsValid && FindAsset_inClass_IsValid && FindAsset_AssetData_IsValid && FindAsset_bRecursive_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorContentLibrary:FindAsset", FindAsset_IsValid);
	}
}
