using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810553504uL, Config = "Engine")]
[UMetaPath("/Script/Engine.AssetImportData", "Engine", UnrealModuleType.Engine)]
public class UAssetImportData : UObject
{
	private static bool ScriptedAddFilename_IsValid;

	private static IntPtr ScriptedAddFilename_FunctionAddress;

	private static int ScriptedAddFilename_ParamsSize;

	private static bool ScriptedAddFilename_InPath_IsValid;

	private static FFieldAddress ScriptedAddFilename_InPath_PropertyAddress;

	private static int ScriptedAddFilename_InPath_Offset;

	private static bool ScriptedAddFilename_Index_IsValid;

	private static FFieldAddress ScriptedAddFilename_Index_PropertyAddress;

	private static int ScriptedAddFilename_Index_Offset;

	private static bool ScriptedAddFilename_SourceFileLabel_IsValid;

	private static FFieldAddress ScriptedAddFilename_SourceFileLabel_PropertyAddress;

	private static int ScriptedAddFilename_SourceFileLabel_Offset;

	private static bool GetFirstFilename_IsValid;

	private static IntPtr GetFirstFilename_FunctionAddress;

	private static int GetFirstFilename_ParamsSize;

	private static bool GetFirstFilename_ReturnValue_IsValid;

	private static FFieldAddress GetFirstFilename_ReturnValue_PropertyAddress;

	private static int GetFirstFilename_ReturnValue_Offset;

	private static bool ExtractFilenames_IsValid;

	private static IntPtr ExtractFilenames_FunctionAddress;

	private static int ExtractFilenames_ParamsSize;

	private static bool ExtractFilenames_ReturnValue_IsValid;

	private static FFieldAddress ExtractFilenames_ReturnValue_PropertyAddress;

	private static int ExtractFilenames_ReturnValue_Offset;

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/Engine.AssetImportData:ScriptedAddFilename")]
	public unsafe void ScriptedAddFilename(string InPath, int Index, string SourceFileLabel)
	{
		CheckDestroyed();
		if (!ScriptedAddFilename_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AssetImportData:ScriptedAddFilename");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ScriptedAddFilename_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ScriptedAddFilename_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ScriptedAddFilename_InPath_Offset), 0, ScriptedAddFilename_InPath_PropertyAddress.Address, InPath);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ScriptedAddFilename_Index_Offset), 0, ScriptedAddFilename_Index_PropertyAddress.Address, Index);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ScriptedAddFilename_SourceFileLabel_Offset), 0, ScriptedAddFilename_SourceFileLabel_PropertyAddress.Address, SourceFileLabel);
		NativeReflection.InvokeFunctionOptimized(base.Address, ScriptedAddFilename_FunctionAddress, intPtr, ScriptedAddFilename_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ScriptedAddFilename_InPath_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ScriptedAddFilename_SourceFileLabel_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1946289153u, OriginalName = "K2_GetFirstFilename")]
	[UMetaPath("/Script/Engine.AssetImportData:K2_GetFirstFilename")]
	public unsafe string GetFirstFilename()
	{
		CheckDestroyed();
		if (!GetFirstFilename_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AssetImportData:K2_GetFirstFilename");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFirstFilename_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFirstFilename_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetFirstFilename_FunctionAddress, intPtr, GetFirstFilename_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetFirstFilename_ReturnValue_Offset), 0, GetFirstFilename_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetFirstFilename_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1946289153u, OriginalName = "K2_ExtractFilenames")]
	[UMetaPath("/Script/Engine.AssetImportData:K2_ExtractFilenames")]
	public unsafe List<string> ExtractFilenames()
	{
		CheckDestroyed();
		if (!ExtractFilenames_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AssetImportData:K2_ExtractFilenames");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ExtractFilenames_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ExtractFilenames_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, ExtractFilenames_FunctionAddress, intPtr, ExtractFilenames_ParamsSize);
		List<string> result = new TArrayCopyMarshaler<string>(1, ExtractFilenames_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, ExtractFilenames_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(ExtractFilenames_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UAssetImportData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAssetImportData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAssetImportData));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/Engine.AssetImportData");
		ScriptedAddFilename_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ScriptedAddFilename");
		ScriptedAddFilename_ParamsSize = NativeReflection.GetFunctionParamsSize(ScriptedAddFilename_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ScriptedAddFilename_InPath_PropertyAddress, ScriptedAddFilename_FunctionAddress, "InPath");
		ScriptedAddFilename_InPath_Offset = NativeReflectionCached.GetPropertyOffset(ScriptedAddFilename_FunctionAddress, "InPath");
		ScriptedAddFilename_InPath_IsValid = NativeReflectionCached.ValidatePropertyClass(ScriptedAddFilename_FunctionAddress, "InPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ScriptedAddFilename_Index_PropertyAddress, ScriptedAddFilename_FunctionAddress, "Index");
		ScriptedAddFilename_Index_Offset = NativeReflectionCached.GetPropertyOffset(ScriptedAddFilename_FunctionAddress, "Index");
		ScriptedAddFilename_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(ScriptedAddFilename_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ScriptedAddFilename_SourceFileLabel_PropertyAddress, ScriptedAddFilename_FunctionAddress, "SourceFileLabel");
		ScriptedAddFilename_SourceFileLabel_Offset = NativeReflectionCached.GetPropertyOffset(ScriptedAddFilename_FunctionAddress, "SourceFileLabel");
		ScriptedAddFilename_SourceFileLabel_IsValid = NativeReflectionCached.ValidatePropertyClass(ScriptedAddFilename_FunctionAddress, "SourceFileLabel", Classes.FStrProperty);
		ScriptedAddFilename_IsValid = ScriptedAddFilename_FunctionAddress != IntPtr.Zero && ScriptedAddFilename_InPath_IsValid && ScriptedAddFilename_Index_IsValid && ScriptedAddFilename_SourceFileLabel_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AssetImportData:ScriptedAddFilename", ScriptedAddFilename_IsValid);
		GetFirstFilename_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "K2_GetFirstFilename");
		GetFirstFilename_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFirstFilename_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFirstFilename_ReturnValue_PropertyAddress, GetFirstFilename_FunctionAddress, "ReturnValue");
		GetFirstFilename_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFirstFilename_FunctionAddress, "ReturnValue");
		GetFirstFilename_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFirstFilename_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetFirstFilename_IsValid = GetFirstFilename_FunctionAddress != IntPtr.Zero && GetFirstFilename_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AssetImportData:K2_GetFirstFilename", GetFirstFilename_IsValid);
		ExtractFilenames_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "K2_ExtractFilenames");
		ExtractFilenames_ParamsSize = NativeReflection.GetFunctionParamsSize(ExtractFilenames_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ExtractFilenames_ReturnValue_PropertyAddress, ExtractFilenames_FunctionAddress, "ReturnValue");
		ExtractFilenames_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ExtractFilenames_FunctionAddress, "ReturnValue");
		ExtractFilenames_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ExtractFilenames_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		ExtractFilenames_IsValid = ExtractFilenames_FunctionAddress != IntPtr.Zero && ExtractFilenames_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AssetImportData:K2_ExtractFilenames", ExtractFilenames_IsValid);
	}
}
