using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.InterchangeEngine;

[UClass(Flags = (ClassFlags)810553504uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/InterchangeEngine.InterchangeAssetImportData", "InterchangeEngine", UnrealModuleType.Engine)]
public class UInterchangeAssetImportData : UAssetImportData
{
	private static bool ScriptGetFirstFilename_IsValid;

	private static IntPtr ScriptGetFirstFilename_FunctionAddress;

	private static int ScriptGetFirstFilename_ParamsSize;

	private static bool ScriptGetFirstFilename_ReturnValue_IsValid;

	private static FFieldAddress ScriptGetFirstFilename_ReturnValue_PropertyAddress;

	private static int ScriptGetFirstFilename_ReturnValue_Offset;

	private static bool ScriptExtractFilenames_IsValid;

	private static IntPtr ScriptExtractFilenames_FunctionAddress;

	private static int ScriptExtractFilenames_ParamsSize;

	private static bool ScriptExtractFilenames_ReturnValue_IsValid;

	private static FFieldAddress ScriptExtractFilenames_ReturnValue_PropertyAddress;

	private static int ScriptExtractFilenames_ReturnValue_Offset;

	private static bool ScriptExtractDisplayLabels_IsValid;

	private static IntPtr ScriptExtractDisplayLabels_FunctionAddress;

	private static int ScriptExtractDisplayLabels_ParamsSize;

	private static bool ScriptExtractDisplayLabels_ReturnValue_IsValid;

	private static FFieldAddress ScriptExtractDisplayLabels_ReturnValue_PropertyAddress;

	private static int ScriptExtractDisplayLabels_ReturnValue_Offset;

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/InterchangeEngine.InterchangeAssetImportData:ScriptGetFirstFilename")]
	public unsafe string ScriptGetFirstFilename()
	{
		CheckDestroyed();
		if (!ScriptGetFirstFilename_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeEngine.InterchangeAssetImportData:ScriptGetFirstFilename");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ScriptGetFirstFilename_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ScriptGetFirstFilename_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, ScriptGetFirstFilename_FunctionAddress, intPtr, ScriptGetFirstFilename_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, ScriptGetFirstFilename_ReturnValue_Offset), 0, ScriptGetFirstFilename_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ScriptGetFirstFilename_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/InterchangeEngine.InterchangeAssetImportData:ScriptExtractFilenames")]
	public unsafe List<string> ScriptExtractFilenames()
	{
		CheckDestroyed();
		if (!ScriptExtractFilenames_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeEngine.InterchangeAssetImportData:ScriptExtractFilenames");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ScriptExtractFilenames_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ScriptExtractFilenames_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, ScriptExtractFilenames_FunctionAddress, intPtr, ScriptExtractFilenames_ParamsSize);
		List<string> result = new TArrayCopyMarshaler<string>(1, ScriptExtractFilenames_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, ScriptExtractFilenames_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(ScriptExtractFilenames_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/InterchangeEngine.InterchangeAssetImportData:ScriptExtractDisplayLabels")]
	public unsafe List<string> ScriptExtractDisplayLabels()
	{
		CheckDestroyed();
		if (!ScriptExtractDisplayLabels_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeEngine.InterchangeAssetImportData:ScriptExtractDisplayLabels");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ScriptExtractDisplayLabels_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ScriptExtractDisplayLabels_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, ScriptExtractDisplayLabels_FunctionAddress, intPtr, ScriptExtractDisplayLabels_ParamsSize);
		List<string> result = new TArrayCopyMarshaler<string>(1, ScriptExtractDisplayLabels_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, ScriptExtractDisplayLabels_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(ScriptExtractDisplayLabels_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UInterchangeAssetImportData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UInterchangeAssetImportData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UInterchangeAssetImportData));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/InterchangeEngine.InterchangeAssetImportData");
		ScriptGetFirstFilename_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ScriptGetFirstFilename");
		ScriptGetFirstFilename_ParamsSize = NativeReflection.GetFunctionParamsSize(ScriptGetFirstFilename_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ScriptGetFirstFilename_ReturnValue_PropertyAddress, ScriptGetFirstFilename_FunctionAddress, "ReturnValue");
		ScriptGetFirstFilename_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ScriptGetFirstFilename_FunctionAddress, "ReturnValue");
		ScriptGetFirstFilename_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ScriptGetFirstFilename_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		ScriptGetFirstFilename_IsValid = ScriptGetFirstFilename_FunctionAddress != IntPtr.Zero && ScriptGetFirstFilename_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeEngine.InterchangeAssetImportData:ScriptGetFirstFilename", ScriptGetFirstFilename_IsValid);
		ScriptExtractFilenames_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ScriptExtractFilenames");
		ScriptExtractFilenames_ParamsSize = NativeReflection.GetFunctionParamsSize(ScriptExtractFilenames_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ScriptExtractFilenames_ReturnValue_PropertyAddress, ScriptExtractFilenames_FunctionAddress, "ReturnValue");
		ScriptExtractFilenames_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ScriptExtractFilenames_FunctionAddress, "ReturnValue");
		ScriptExtractFilenames_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ScriptExtractFilenames_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		ScriptExtractFilenames_IsValid = ScriptExtractFilenames_FunctionAddress != IntPtr.Zero && ScriptExtractFilenames_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeEngine.InterchangeAssetImportData:ScriptExtractFilenames", ScriptExtractFilenames_IsValid);
		ScriptExtractDisplayLabels_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ScriptExtractDisplayLabels");
		ScriptExtractDisplayLabels_ParamsSize = NativeReflection.GetFunctionParamsSize(ScriptExtractDisplayLabels_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ScriptExtractDisplayLabels_ReturnValue_PropertyAddress, ScriptExtractDisplayLabels_FunctionAddress, "ReturnValue");
		ScriptExtractDisplayLabels_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ScriptExtractDisplayLabels_FunctionAddress, "ReturnValue");
		ScriptExtractDisplayLabels_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ScriptExtractDisplayLabels_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		ScriptExtractDisplayLabels_IsValid = ScriptExtractDisplayLabels_FunctionAddress != IntPtr.Zero && ScriptExtractDisplayLabels_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeEngine.InterchangeAssetImportData:ScriptExtractDisplayLabels", ScriptExtractDisplayLabels_IsValid);
	}
}
