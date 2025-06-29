using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/PCG.PCGDataFunctionLibrary", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGDataFunctionLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool GetTypedInputsByTag_IsValid;

	private static IntPtr GetTypedInputsByTag_FunctionAddress;

	private static int GetTypedInputsByTag_ParamsSize;

	private static bool GetTypedInputsByTag_InCollection_IsValid;

	private static FFieldAddress GetTypedInputsByTag_InCollection_PropertyAddress;

	private static int GetTypedInputsByTag_InCollection_Offset;

	private static bool GetTypedInputsByTag_InTag_IsValid;

	private static FFieldAddress GetTypedInputsByTag_InTag_PropertyAddress;

	private static int GetTypedInputsByTag_InTag_Offset;

	private static bool GetTypedInputsByTag_OutTaggedData_IsValid;

	private static FFieldAddress GetTypedInputsByTag_OutTaggedData_PropertyAddress;

	private static int GetTypedInputsByTag_OutTaggedData_Offset;

	private static bool GetTypedInputsByTag_InDataTypeClass_IsValid;

	private static FFieldAddress GetTypedInputsByTag_InDataTypeClass_PropertyAddress;

	private static int GetTypedInputsByTag_InDataTypeClass_Offset;

	private static bool GetTypedInputsByTag_ReturnValue_IsValid;

	private static FFieldAddress GetTypedInputsByTag_ReturnValue_PropertyAddress;

	private static int GetTypedInputsByTag_ReturnValue_Offset;

	private static bool GetTypedInputsByPinLabel_IsValid;

	private static IntPtr GetTypedInputsByPinLabel_FunctionAddress;

	private static int GetTypedInputsByPinLabel_ParamsSize;

	private static bool GetTypedInputsByPinLabel_InCollection_IsValid;

	private static FFieldAddress GetTypedInputsByPinLabel_InCollection_PropertyAddress;

	private static int GetTypedInputsByPinLabel_InCollection_Offset;

	private static bool GetTypedInputsByPinLabel_InPinLabel_IsValid;

	private static FFieldAddress GetTypedInputsByPinLabel_InPinLabel_PropertyAddress;

	private static int GetTypedInputsByPinLabel_InPinLabel_Offset;

	private static bool GetTypedInputsByPinLabel_OutTaggedData_IsValid;

	private static FFieldAddress GetTypedInputsByPinLabel_OutTaggedData_PropertyAddress;

	private static int GetTypedInputsByPinLabel_OutTaggedData_Offset;

	private static bool GetTypedInputsByPinLabel_InDataTypeClass_IsValid;

	private static FFieldAddress GetTypedInputsByPinLabel_InDataTypeClass_PropertyAddress;

	private static int GetTypedInputsByPinLabel_InDataTypeClass_Offset;

	private static bool GetTypedInputsByPinLabel_ReturnValue_IsValid;

	private static FFieldAddress GetTypedInputsByPinLabel_ReturnValue_PropertyAddress;

	private static int GetTypedInputsByPinLabel_ReturnValue_Offset;

	private static bool GetTypedInputsByPin_IsValid;

	private static IntPtr GetTypedInputsByPin_FunctionAddress;

	private static int GetTypedInputsByPin_ParamsSize;

	private static bool GetTypedInputsByPin_InCollection_IsValid;

	private static FFieldAddress GetTypedInputsByPin_InCollection_PropertyAddress;

	private static int GetTypedInputsByPin_InCollection_Offset;

	private static bool GetTypedInputsByPin_InPin_IsValid;

	private static FFieldAddress GetTypedInputsByPin_InPin_PropertyAddress;

	private static int GetTypedInputsByPin_InPin_Offset;

	private static bool GetTypedInputsByPin_OutTaggedData_IsValid;

	private static FFieldAddress GetTypedInputsByPin_OutTaggedData_PropertyAddress;

	private static int GetTypedInputsByPin_OutTaggedData_Offset;

	private static bool GetTypedInputsByPin_InDataTypeClass_IsValid;

	private static FFieldAddress GetTypedInputsByPin_InDataTypeClass_PropertyAddress;

	private static int GetTypedInputsByPin_InDataTypeClass_Offset;

	private static bool GetTypedInputsByPin_ReturnValue_IsValid;

	private static FFieldAddress GetTypedInputsByPin_ReturnValue_PropertyAddress;

	private static int GetTypedInputsByPin_ReturnValue_Offset;

	private static bool GetTypedInputs_IsValid;

	private static IntPtr GetTypedInputs_FunctionAddress;

	private static int GetTypedInputs_ParamsSize;

	private static bool GetTypedInputs_InCollection_IsValid;

	private static FFieldAddress GetTypedInputs_InCollection_PropertyAddress;

	private static int GetTypedInputs_InCollection_Offset;

	private static bool GetTypedInputs_OutTaggedData_IsValid;

	private static FFieldAddress GetTypedInputs_OutTaggedData_PropertyAddress;

	private static int GetTypedInputs_OutTaggedData_Offset;

	private static bool GetTypedInputs_InDataTypeClass_IsValid;

	private static FFieldAddress GetTypedInputs_InDataTypeClass_PropertyAddress;

	private static int GetTypedInputs_InDataTypeClass_Offset;

	private static bool GetTypedInputs_ReturnValue_IsValid;

	private static FFieldAddress GetTypedInputs_ReturnValue_PropertyAddress;

	private static int GetTypedInputs_ReturnValue_Offset;

	private static bool GetParamsByTag_IsValid;

	private static IntPtr GetParamsByTag_FunctionAddress;

	private static int GetParamsByTag_ParamsSize;

	private static bool GetParamsByTag_InCollection_IsValid;

	private static FFieldAddress GetParamsByTag_InCollection_PropertyAddress;

	private static int GetParamsByTag_InCollection_Offset;

	private static bool GetParamsByTag_InTag_IsValid;

	private static FFieldAddress GetParamsByTag_InTag_PropertyAddress;

	private static int GetParamsByTag_InTag_Offset;

	private static bool GetParamsByTag_ReturnValue_IsValid;

	private static FFieldAddress GetParamsByTag_ReturnValue_PropertyAddress;

	private static int GetParamsByTag_ReturnValue_Offset;

	private static bool GetParamsByPinLabel_IsValid;

	private static IntPtr GetParamsByPinLabel_FunctionAddress;

	private static int GetParamsByPinLabel_ParamsSize;

	private static bool GetParamsByPinLabel_InCollection_IsValid;

	private static FFieldAddress GetParamsByPinLabel_InCollection_PropertyAddress;

	private static int GetParamsByPinLabel_InCollection_Offset;

	private static bool GetParamsByPinLabel_InPinLabel_IsValid;

	private static FFieldAddress GetParamsByPinLabel_InPinLabel_PropertyAddress;

	private static int GetParamsByPinLabel_InPinLabel_Offset;

	private static bool GetParamsByPinLabel_ReturnValue_IsValid;

	private static FFieldAddress GetParamsByPinLabel_ReturnValue_PropertyAddress;

	private static int GetParamsByPinLabel_ReturnValue_Offset;

	private static bool GetParams_IsValid;

	private static IntPtr GetParams_FunctionAddress;

	private static int GetParams_ParamsSize;

	private static bool GetParams_InCollection_IsValid;

	private static FFieldAddress GetParams_InCollection_PropertyAddress;

	private static int GetParams_InCollection_Offset;

	private static bool GetParams_ReturnValue_IsValid;

	private static FFieldAddress GetParams_ReturnValue_PropertyAddress;

	private static int GetParams_ReturnValue_Offset;

	private static bool GetInputsByTag_IsValid;

	private static IntPtr GetInputsByTag_FunctionAddress;

	private static int GetInputsByTag_ParamsSize;

	private static bool GetInputsByTag_InCollection_IsValid;

	private static FFieldAddress GetInputsByTag_InCollection_PropertyAddress;

	private static int GetInputsByTag_InCollection_Offset;

	private static bool GetInputsByTag_InTag_IsValid;

	private static FFieldAddress GetInputsByTag_InTag_PropertyAddress;

	private static int GetInputsByTag_InTag_Offset;

	private static bool GetInputsByTag_ReturnValue_IsValid;

	private static FFieldAddress GetInputsByTag_ReturnValue_PropertyAddress;

	private static int GetInputsByTag_ReturnValue_Offset;

	private static bool GetInputsByPinLabel_IsValid;

	private static IntPtr GetInputsByPinLabel_FunctionAddress;

	private static int GetInputsByPinLabel_ParamsSize;

	private static bool GetInputsByPinLabel_InCollection_IsValid;

	private static FFieldAddress GetInputsByPinLabel_InCollection_PropertyAddress;

	private static int GetInputsByPinLabel_InCollection_Offset;

	private static bool GetInputsByPinLabel_InPinLabel_IsValid;

	private static FFieldAddress GetInputsByPinLabel_InPinLabel_PropertyAddress;

	private static int GetInputsByPinLabel_InPinLabel_Offset;

	private static bool GetInputsByPinLabel_ReturnValue_IsValid;

	private static FFieldAddress GetInputsByPinLabel_ReturnValue_PropertyAddress;

	private static int GetInputsByPinLabel_ReturnValue_Offset;

	private static bool GetInputs_IsValid;

	private static IntPtr GetInputs_FunctionAddress;

	private static int GetInputs_ParamsSize;

	private static bool GetInputs_InCollection_IsValid;

	private static FFieldAddress GetInputs_InCollection_PropertyAddress;

	private static int GetInputs_InCollection_Offset;

	private static bool GetInputs_ReturnValue_IsValid;

	private static FFieldAddress GetInputs_ReturnValue_PropertyAddress;

	private static int GetInputs_ReturnValue_Offset;

	private static bool GetAllSettings_IsValid;

	private static IntPtr GetAllSettings_FunctionAddress;

	private static int GetAllSettings_ParamsSize;

	private static bool GetAllSettings_InCollection_IsValid;

	private static FFieldAddress GetAllSettings_InCollection_PropertyAddress;

	private static int GetAllSettings_InCollection_Offset;

	private static bool GetAllSettings_ReturnValue_IsValid;

	private static FFieldAddress GetAllSettings_ReturnValue_PropertyAddress;

	private static int GetAllSettings_ReturnValue_Offset;

	private static bool AddToCollection_IsValid;

	private static IntPtr AddToCollection_FunctionAddress;

	private static int AddToCollection_ParamsSize;

	private static bool AddToCollection_InCollection_IsValid;

	private static FFieldAddress AddToCollection_InCollection_PropertyAddress;

	private static int AddToCollection_InCollection_Offset;

	private static bool AddToCollection_InData_IsValid;

	private static FFieldAddress AddToCollection_InData_PropertyAddress;

	private static int AddToCollection_InData_Offset;

	private static bool AddToCollection_InPinLabel_IsValid;

	private static FFieldAddress AddToCollection_InPinLabel_PropertyAddress;

	private static int AddToCollection_InPinLabel_Offset;

	private static bool AddToCollection_InTags_IsValid;

	private static FFieldAddress AddToCollection_InTags_PropertyAddress;

	private static int AddToCollection_InTags_Offset;

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/PCG.PCGDataFunctionLibrary:GetTypedInputsByTag")]
	public unsafe static List<UPCGData> GetTypedInputsByTag(FPCGDataCollection InCollection, string InTag, out List<FPCGTaggedData> OutTaggedData, TSubclassOf<UPCGData> InDataTypeClass)
	{
		if (!GetTypedInputsByTag_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGDataFunctionLibrary:GetTypedInputsByTag");
			OutTaggedData = null;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTypedInputsByTag_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTypedInputsByTag_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetTypedInputsByTag_InCollection_PropertyAddress.Address, intPtr);
		FPCGDataCollection.ToNative(IntPtr.Add(intPtr, GetTypedInputsByTag_InCollection_Offset), 0, GetTypedInputsByTag_InCollection_PropertyAddress.Address, InCollection);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetTypedInputsByTag_InTag_Offset), 0, GetTypedInputsByTag_InTag_PropertyAddress.Address, InTag);
		TSubclassOfMarshaler<UPCGData>.ToNative(IntPtr.Add(intPtr, GetTypedInputsByTag_InDataTypeClass_Offset), 0, GetTypedInputsByTag_InDataTypeClass_PropertyAddress.Address, InDataTypeClass);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetTypedInputsByTag_FunctionAddress, intPtr, GetTypedInputsByTag_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetTypedInputsByTag_InCollection_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(GetTypedInputsByTag_InTag_PropertyAddress.Address, intPtr);
		OutTaggedData = new TArrayCopyMarshaler<FPCGTaggedData>(1, GetTypedInputsByTag_OutTaggedData_PropertyAddress, CachedMarshalingDelegates<FPCGTaggedData, FPCGTaggedData>.FromNative, CachedMarshalingDelegates<FPCGTaggedData, FPCGTaggedData>.ToNative).FromNative(IntPtr.Add(intPtr, GetTypedInputsByTag_OutTaggedData_Offset));
		NativeReflection.DestroyValue_InContainer(GetTypedInputsByTag_OutTaggedData_PropertyAddress.Address, intPtr);
		List<UPCGData> result = new TArrayCopyMarshaler<UPCGData>(1, GetTypedInputsByTag_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UPCGData, UObjectMarshaler<UPCGData>>.FromNative, CachedMarshalingDelegates<UPCGData, UObjectMarshaler<UPCGData>>.ToNative).FromNative(IntPtr.Add(intPtr, GetTypedInputsByTag_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetTypedInputsByTag_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/PCG.PCGDataFunctionLibrary:GetTypedInputsByPinLabel")]
	public unsafe static List<UPCGData> GetTypedInputsByPinLabel(FPCGDataCollection InCollection, FName InPinLabel, out List<FPCGTaggedData> OutTaggedData, TSubclassOf<UPCGData> InDataTypeClass)
	{
		if (!GetTypedInputsByPinLabel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGDataFunctionLibrary:GetTypedInputsByPinLabel");
			OutTaggedData = null;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTypedInputsByPinLabel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTypedInputsByPinLabel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetTypedInputsByPinLabel_InCollection_PropertyAddress.Address, intPtr);
		FPCGDataCollection.ToNative(IntPtr.Add(intPtr, GetTypedInputsByPinLabel_InCollection_Offset), 0, GetTypedInputsByPinLabel_InCollection_PropertyAddress.Address, InCollection);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetTypedInputsByPinLabel_InPinLabel_Offset), 0, GetTypedInputsByPinLabel_InPinLabel_PropertyAddress.Address, InPinLabel);
		TSubclassOfMarshaler<UPCGData>.ToNative(IntPtr.Add(intPtr, GetTypedInputsByPinLabel_InDataTypeClass_Offset), 0, GetTypedInputsByPinLabel_InDataTypeClass_PropertyAddress.Address, InDataTypeClass);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetTypedInputsByPinLabel_FunctionAddress, intPtr, GetTypedInputsByPinLabel_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetTypedInputsByPinLabel_InCollection_PropertyAddress.Address, intPtr);
		OutTaggedData = new TArrayCopyMarshaler<FPCGTaggedData>(1, GetTypedInputsByPinLabel_OutTaggedData_PropertyAddress, CachedMarshalingDelegates<FPCGTaggedData, FPCGTaggedData>.FromNative, CachedMarshalingDelegates<FPCGTaggedData, FPCGTaggedData>.ToNative).FromNative(IntPtr.Add(intPtr, GetTypedInputsByPinLabel_OutTaggedData_Offset));
		NativeReflection.DestroyValue_InContainer(GetTypedInputsByPinLabel_OutTaggedData_PropertyAddress.Address, intPtr);
		List<UPCGData> result = new TArrayCopyMarshaler<UPCGData>(1, GetTypedInputsByPinLabel_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UPCGData, UObjectMarshaler<UPCGData>>.FromNative, CachedMarshalingDelegates<UPCGData, UObjectMarshaler<UPCGData>>.ToNative).FromNative(IntPtr.Add(intPtr, GetTypedInputsByPinLabel_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetTypedInputsByPinLabel_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/PCG.PCGDataFunctionLibrary:GetTypedInputsByPin")]
	public unsafe static List<UPCGData> GetTypedInputsByPin(FPCGDataCollection InCollection, FPCGPinProperties InPin, out List<FPCGTaggedData> OutTaggedData, TSubclassOf<UPCGData> InDataTypeClass)
	{
		if (!GetTypedInputsByPin_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGDataFunctionLibrary:GetTypedInputsByPin");
			OutTaggedData = null;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTypedInputsByPin_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTypedInputsByPin_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetTypedInputsByPin_InCollection_PropertyAddress.Address, intPtr);
		FPCGDataCollection.ToNative(IntPtr.Add(intPtr, GetTypedInputsByPin_InCollection_Offset), 0, GetTypedInputsByPin_InCollection_PropertyAddress.Address, InCollection);
		NativeReflection.InitializeValue_InContainer(GetTypedInputsByPin_InPin_PropertyAddress.Address, intPtr);
		FPCGPinProperties.ToNative(IntPtr.Add(intPtr, GetTypedInputsByPin_InPin_Offset), 0, GetTypedInputsByPin_InPin_PropertyAddress.Address, InPin);
		TSubclassOfMarshaler<UPCGData>.ToNative(IntPtr.Add(intPtr, GetTypedInputsByPin_InDataTypeClass_Offset), 0, GetTypedInputsByPin_InDataTypeClass_PropertyAddress.Address, InDataTypeClass);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetTypedInputsByPin_FunctionAddress, intPtr, GetTypedInputsByPin_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetTypedInputsByPin_InCollection_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(GetTypedInputsByPin_InPin_PropertyAddress.Address, intPtr);
		OutTaggedData = new TArrayCopyMarshaler<FPCGTaggedData>(1, GetTypedInputsByPin_OutTaggedData_PropertyAddress, CachedMarshalingDelegates<FPCGTaggedData, FPCGTaggedData>.FromNative, CachedMarshalingDelegates<FPCGTaggedData, FPCGTaggedData>.ToNative).FromNative(IntPtr.Add(intPtr, GetTypedInputsByPin_OutTaggedData_Offset));
		NativeReflection.DestroyValue_InContainer(GetTypedInputsByPin_OutTaggedData_PropertyAddress.Address, intPtr);
		List<UPCGData> result = new TArrayCopyMarshaler<UPCGData>(1, GetTypedInputsByPin_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UPCGData, UObjectMarshaler<UPCGData>>.FromNative, CachedMarshalingDelegates<UPCGData, UObjectMarshaler<UPCGData>>.ToNative).FromNative(IntPtr.Add(intPtr, GetTypedInputsByPin_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetTypedInputsByPin_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/PCG.PCGDataFunctionLibrary:GetTypedInputs")]
	public unsafe static List<UPCGData> GetTypedInputs(FPCGDataCollection InCollection, out List<FPCGTaggedData> OutTaggedData, TSubclassOf<UPCGData> InDataTypeClass)
	{
		if (!GetTypedInputs_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGDataFunctionLibrary:GetTypedInputs");
			OutTaggedData = null;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTypedInputs_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTypedInputs_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetTypedInputs_InCollection_PropertyAddress.Address, intPtr);
		FPCGDataCollection.ToNative(IntPtr.Add(intPtr, GetTypedInputs_InCollection_Offset), 0, GetTypedInputs_InCollection_PropertyAddress.Address, InCollection);
		TSubclassOfMarshaler<UPCGData>.ToNative(IntPtr.Add(intPtr, GetTypedInputs_InDataTypeClass_Offset), 0, GetTypedInputs_InDataTypeClass_PropertyAddress.Address, InDataTypeClass);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetTypedInputs_FunctionAddress, intPtr, GetTypedInputs_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetTypedInputs_InCollection_PropertyAddress.Address, intPtr);
		OutTaggedData = new TArrayCopyMarshaler<FPCGTaggedData>(1, GetTypedInputs_OutTaggedData_PropertyAddress, CachedMarshalingDelegates<FPCGTaggedData, FPCGTaggedData>.FromNative, CachedMarshalingDelegates<FPCGTaggedData, FPCGTaggedData>.ToNative).FromNative(IntPtr.Add(intPtr, GetTypedInputs_OutTaggedData_Offset));
		NativeReflection.DestroyValue_InContainer(GetTypedInputs_OutTaggedData_PropertyAddress.Address, intPtr);
		List<UPCGData> result = new TArrayCopyMarshaler<UPCGData>(1, GetTypedInputs_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UPCGData, UObjectMarshaler<UPCGData>>.FromNative, CachedMarshalingDelegates<UPCGData, UObjectMarshaler<UPCGData>>.ToNative).FromNative(IntPtr.Add(intPtr, GetTypedInputs_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetTypedInputs_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/PCG.PCGDataFunctionLibrary:GetParamsByTag")]
	public unsafe static List<FPCGTaggedData> GetParamsByTag(FPCGDataCollection InCollection, string InTag)
	{
		if (!GetParamsByTag_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGDataFunctionLibrary:GetParamsByTag");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetParamsByTag_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetParamsByTag_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetParamsByTag_InCollection_PropertyAddress.Address, intPtr);
		FPCGDataCollection.ToNative(IntPtr.Add(intPtr, GetParamsByTag_InCollection_Offset), 0, GetParamsByTag_InCollection_PropertyAddress.Address, InCollection);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetParamsByTag_InTag_Offset), 0, GetParamsByTag_InTag_PropertyAddress.Address, InTag);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetParamsByTag_FunctionAddress, intPtr, GetParamsByTag_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetParamsByTag_InCollection_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(GetParamsByTag_InTag_PropertyAddress.Address, intPtr);
		List<FPCGTaggedData> result = new TArrayCopyMarshaler<FPCGTaggedData>(1, GetParamsByTag_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FPCGTaggedData, FPCGTaggedData>.FromNative, CachedMarshalingDelegates<FPCGTaggedData, FPCGTaggedData>.ToNative).FromNative(IntPtr.Add(intPtr, GetParamsByTag_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetParamsByTag_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/PCG.PCGDataFunctionLibrary:GetParamsByPinLabel")]
	public unsafe static List<FPCGTaggedData> GetParamsByPinLabel(FPCGDataCollection InCollection, FName InPinLabel)
	{
		if (!GetParamsByPinLabel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGDataFunctionLibrary:GetParamsByPinLabel");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetParamsByPinLabel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetParamsByPinLabel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetParamsByPinLabel_InCollection_PropertyAddress.Address, intPtr);
		FPCGDataCollection.ToNative(IntPtr.Add(intPtr, GetParamsByPinLabel_InCollection_Offset), 0, GetParamsByPinLabel_InCollection_PropertyAddress.Address, InCollection);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetParamsByPinLabel_InPinLabel_Offset), 0, GetParamsByPinLabel_InPinLabel_PropertyAddress.Address, InPinLabel);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetParamsByPinLabel_FunctionAddress, intPtr, GetParamsByPinLabel_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetParamsByPinLabel_InCollection_PropertyAddress.Address, intPtr);
		List<FPCGTaggedData> result = new TArrayCopyMarshaler<FPCGTaggedData>(1, GetParamsByPinLabel_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FPCGTaggedData, FPCGTaggedData>.FromNative, CachedMarshalingDelegates<FPCGTaggedData, FPCGTaggedData>.ToNative).FromNative(IntPtr.Add(intPtr, GetParamsByPinLabel_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetParamsByPinLabel_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/PCG.PCGDataFunctionLibrary:GetParams")]
	public unsafe static List<FPCGTaggedData> GetParams(FPCGDataCollection InCollection)
	{
		if (!GetParams_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGDataFunctionLibrary:GetParams");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetParams_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetParams_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetParams_InCollection_PropertyAddress.Address, intPtr);
		FPCGDataCollection.ToNative(IntPtr.Add(intPtr, GetParams_InCollection_Offset), 0, GetParams_InCollection_PropertyAddress.Address, InCollection);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetParams_FunctionAddress, intPtr, GetParams_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetParams_InCollection_PropertyAddress.Address, intPtr);
		List<FPCGTaggedData> result = new TArrayCopyMarshaler<FPCGTaggedData>(1, GetParams_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FPCGTaggedData, FPCGTaggedData>.FromNative, CachedMarshalingDelegates<FPCGTaggedData, FPCGTaggedData>.ToNative).FromNative(IntPtr.Add(intPtr, GetParams_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetParams_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/PCG.PCGDataFunctionLibrary:GetInputsByTag")]
	public unsafe static List<FPCGTaggedData> GetInputsByTag(FPCGDataCollection InCollection, string InTag)
	{
		if (!GetInputsByTag_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGDataFunctionLibrary:GetInputsByTag");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInputsByTag_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInputsByTag_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetInputsByTag_InCollection_PropertyAddress.Address, intPtr);
		FPCGDataCollection.ToNative(IntPtr.Add(intPtr, GetInputsByTag_InCollection_Offset), 0, GetInputsByTag_InCollection_PropertyAddress.Address, InCollection);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetInputsByTag_InTag_Offset), 0, GetInputsByTag_InTag_PropertyAddress.Address, InTag);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetInputsByTag_FunctionAddress, intPtr, GetInputsByTag_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetInputsByTag_InCollection_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(GetInputsByTag_InTag_PropertyAddress.Address, intPtr);
		List<FPCGTaggedData> result = new TArrayCopyMarshaler<FPCGTaggedData>(1, GetInputsByTag_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FPCGTaggedData, FPCGTaggedData>.FromNative, CachedMarshalingDelegates<FPCGTaggedData, FPCGTaggedData>.ToNative).FromNative(IntPtr.Add(intPtr, GetInputsByTag_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetInputsByTag_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/PCG.PCGDataFunctionLibrary:GetInputsByPinLabel")]
	public unsafe static List<FPCGTaggedData> GetInputsByPinLabel(FPCGDataCollection InCollection, FName InPinLabel)
	{
		if (!GetInputsByPinLabel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGDataFunctionLibrary:GetInputsByPinLabel");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInputsByPinLabel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInputsByPinLabel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetInputsByPinLabel_InCollection_PropertyAddress.Address, intPtr);
		FPCGDataCollection.ToNative(IntPtr.Add(intPtr, GetInputsByPinLabel_InCollection_Offset), 0, GetInputsByPinLabel_InCollection_PropertyAddress.Address, InCollection);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetInputsByPinLabel_InPinLabel_Offset), 0, GetInputsByPinLabel_InPinLabel_PropertyAddress.Address, InPinLabel);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetInputsByPinLabel_FunctionAddress, intPtr, GetInputsByPinLabel_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetInputsByPinLabel_InCollection_PropertyAddress.Address, intPtr);
		List<FPCGTaggedData> result = new TArrayCopyMarshaler<FPCGTaggedData>(1, GetInputsByPinLabel_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FPCGTaggedData, FPCGTaggedData>.FromNative, CachedMarshalingDelegates<FPCGTaggedData, FPCGTaggedData>.ToNative).FromNative(IntPtr.Add(intPtr, GetInputsByPinLabel_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetInputsByPinLabel_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/PCG.PCGDataFunctionLibrary:GetInputs")]
	public unsafe static List<FPCGTaggedData> GetInputs(FPCGDataCollection InCollection)
	{
		if (!GetInputs_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGDataFunctionLibrary:GetInputs");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInputs_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInputs_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetInputs_InCollection_PropertyAddress.Address, intPtr);
		FPCGDataCollection.ToNative(IntPtr.Add(intPtr, GetInputs_InCollection_Offset), 0, GetInputs_InCollection_PropertyAddress.Address, InCollection);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetInputs_FunctionAddress, intPtr, GetInputs_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetInputs_InCollection_PropertyAddress.Address, intPtr);
		List<FPCGTaggedData> result = new TArrayCopyMarshaler<FPCGTaggedData>(1, GetInputs_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FPCGTaggedData, FPCGTaggedData>.FromNative, CachedMarshalingDelegates<FPCGTaggedData, FPCGTaggedData>.ToNative).FromNative(IntPtr.Add(intPtr, GetInputs_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetInputs_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/PCG.PCGDataFunctionLibrary:GetAllSettings")]
	public unsafe static List<FPCGTaggedData> GetAllSettings(FPCGDataCollection InCollection)
	{
		if (!GetAllSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGDataFunctionLibrary:GetAllSettings");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetAllSettings_InCollection_PropertyAddress.Address, intPtr);
		FPCGDataCollection.ToNative(IntPtr.Add(intPtr, GetAllSettings_InCollection_Offset), 0, GetAllSettings_InCollection_PropertyAddress.Address, InCollection);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAllSettings_FunctionAddress, intPtr, GetAllSettings_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetAllSettings_InCollection_PropertyAddress.Address, intPtr);
		List<FPCGTaggedData> result = new TArrayCopyMarshaler<FPCGTaggedData>(1, GetAllSettings_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FPCGTaggedData, FPCGTaggedData>.FromNative, CachedMarshalingDelegates<FPCGTaggedData, FPCGTaggedData>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllSettings_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllSettings_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/PCG.PCGDataFunctionLibrary:AddToCollection")]
	public unsafe static void AddToCollection(ref FPCGDataCollection InCollection, UPCGData InData, FName InPinLabel, List<string> InTags)
	{
		if (!AddToCollection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGDataFunctionLibrary:AddToCollection");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddToCollection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddToCollection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddToCollection_InCollection_PropertyAddress.Address, intPtr);
		FPCGDataCollection.ToNative(IntPtr.Add(intPtr, AddToCollection_InCollection_Offset), 0, AddToCollection_InCollection_PropertyAddress.Address, InCollection);
		UObjectMarshaler<UPCGData>.ToNative(IntPtr.Add(intPtr, AddToCollection_InData_Offset), 0, AddToCollection_InData_PropertyAddress.Address, InData);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddToCollection_InPinLabel_Offset), 0, AddToCollection_InPinLabel_PropertyAddress.Address, InPinLabel);
		new TArrayCopyMarshaler<string>(1, AddToCollection_InTags_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, AddToCollection_InTags_Offset), InTags);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddToCollection_FunctionAddress, intPtr, AddToCollection_ParamsSize);
		InCollection = FPCGDataCollection.FromNative(IntPtr.Add(intPtr, AddToCollection_InCollection_Offset), 0, AddToCollection_InCollection_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(AddToCollection_InCollection_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddToCollection_InTags_PropertyAddress.Address, intPtr);
	}

	static UPCGDataFunctionLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGDataFunctionLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGDataFunctionLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/PCG.PCGDataFunctionLibrary");
		GetTypedInputsByTag_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetTypedInputsByTag");
		GetTypedInputsByTag_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTypedInputsByTag_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTypedInputsByTag_InCollection_PropertyAddress, GetTypedInputsByTag_FunctionAddress, "InCollection");
		GetTypedInputsByTag_InCollection_Offset = NativeReflectionCached.GetPropertyOffset(GetTypedInputsByTag_FunctionAddress, "InCollection");
		GetTypedInputsByTag_InCollection_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTypedInputsByTag_FunctionAddress, "InCollection", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTypedInputsByTag_InTag_PropertyAddress, GetTypedInputsByTag_FunctionAddress, "InTag");
		GetTypedInputsByTag_InTag_Offset = NativeReflectionCached.GetPropertyOffset(GetTypedInputsByTag_FunctionAddress, "InTag");
		GetTypedInputsByTag_InTag_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTypedInputsByTag_FunctionAddress, "InTag", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTypedInputsByTag_OutTaggedData_PropertyAddress, GetTypedInputsByTag_FunctionAddress, "OutTaggedData");
		GetTypedInputsByTag_OutTaggedData_Offset = NativeReflectionCached.GetPropertyOffset(GetTypedInputsByTag_FunctionAddress, "OutTaggedData");
		GetTypedInputsByTag_OutTaggedData_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTypedInputsByTag_FunctionAddress, "OutTaggedData", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTypedInputsByTag_InDataTypeClass_PropertyAddress, GetTypedInputsByTag_FunctionAddress, "InDataTypeClass");
		GetTypedInputsByTag_InDataTypeClass_Offset = NativeReflectionCached.GetPropertyOffset(GetTypedInputsByTag_FunctionAddress, "InDataTypeClass");
		GetTypedInputsByTag_InDataTypeClass_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTypedInputsByTag_FunctionAddress, "InDataTypeClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTypedInputsByTag_ReturnValue_PropertyAddress, GetTypedInputsByTag_FunctionAddress, "ReturnValue");
		GetTypedInputsByTag_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTypedInputsByTag_FunctionAddress, "ReturnValue");
		GetTypedInputsByTag_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTypedInputsByTag_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetTypedInputsByTag_IsValid = GetTypedInputsByTag_FunctionAddress != IntPtr.Zero && GetTypedInputsByTag_InCollection_IsValid && GetTypedInputsByTag_InTag_IsValid && GetTypedInputsByTag_OutTaggedData_IsValid && GetTypedInputsByTag_InDataTypeClass_IsValid && GetTypedInputsByTag_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGDataFunctionLibrary:GetTypedInputsByTag", GetTypedInputsByTag_IsValid);
		GetTypedInputsByPinLabel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetTypedInputsByPinLabel");
		GetTypedInputsByPinLabel_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTypedInputsByPinLabel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTypedInputsByPinLabel_InCollection_PropertyAddress, GetTypedInputsByPinLabel_FunctionAddress, "InCollection");
		GetTypedInputsByPinLabel_InCollection_Offset = NativeReflectionCached.GetPropertyOffset(GetTypedInputsByPinLabel_FunctionAddress, "InCollection");
		GetTypedInputsByPinLabel_InCollection_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTypedInputsByPinLabel_FunctionAddress, "InCollection", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTypedInputsByPinLabel_InPinLabel_PropertyAddress, GetTypedInputsByPinLabel_FunctionAddress, "InPinLabel");
		GetTypedInputsByPinLabel_InPinLabel_Offset = NativeReflectionCached.GetPropertyOffset(GetTypedInputsByPinLabel_FunctionAddress, "InPinLabel");
		GetTypedInputsByPinLabel_InPinLabel_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTypedInputsByPinLabel_FunctionAddress, "InPinLabel", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTypedInputsByPinLabel_OutTaggedData_PropertyAddress, GetTypedInputsByPinLabel_FunctionAddress, "OutTaggedData");
		GetTypedInputsByPinLabel_OutTaggedData_Offset = NativeReflectionCached.GetPropertyOffset(GetTypedInputsByPinLabel_FunctionAddress, "OutTaggedData");
		GetTypedInputsByPinLabel_OutTaggedData_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTypedInputsByPinLabel_FunctionAddress, "OutTaggedData", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTypedInputsByPinLabel_InDataTypeClass_PropertyAddress, GetTypedInputsByPinLabel_FunctionAddress, "InDataTypeClass");
		GetTypedInputsByPinLabel_InDataTypeClass_Offset = NativeReflectionCached.GetPropertyOffset(GetTypedInputsByPinLabel_FunctionAddress, "InDataTypeClass");
		GetTypedInputsByPinLabel_InDataTypeClass_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTypedInputsByPinLabel_FunctionAddress, "InDataTypeClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTypedInputsByPinLabel_ReturnValue_PropertyAddress, GetTypedInputsByPinLabel_FunctionAddress, "ReturnValue");
		GetTypedInputsByPinLabel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTypedInputsByPinLabel_FunctionAddress, "ReturnValue");
		GetTypedInputsByPinLabel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTypedInputsByPinLabel_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetTypedInputsByPinLabel_IsValid = GetTypedInputsByPinLabel_FunctionAddress != IntPtr.Zero && GetTypedInputsByPinLabel_InCollection_IsValid && GetTypedInputsByPinLabel_InPinLabel_IsValid && GetTypedInputsByPinLabel_OutTaggedData_IsValid && GetTypedInputsByPinLabel_InDataTypeClass_IsValid && GetTypedInputsByPinLabel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGDataFunctionLibrary:GetTypedInputsByPinLabel", GetTypedInputsByPinLabel_IsValid);
		GetTypedInputsByPin_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetTypedInputsByPin");
		GetTypedInputsByPin_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTypedInputsByPin_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTypedInputsByPin_InCollection_PropertyAddress, GetTypedInputsByPin_FunctionAddress, "InCollection");
		GetTypedInputsByPin_InCollection_Offset = NativeReflectionCached.GetPropertyOffset(GetTypedInputsByPin_FunctionAddress, "InCollection");
		GetTypedInputsByPin_InCollection_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTypedInputsByPin_FunctionAddress, "InCollection", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTypedInputsByPin_InPin_PropertyAddress, GetTypedInputsByPin_FunctionAddress, "InPin");
		GetTypedInputsByPin_InPin_Offset = NativeReflectionCached.GetPropertyOffset(GetTypedInputsByPin_FunctionAddress, "InPin");
		GetTypedInputsByPin_InPin_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTypedInputsByPin_FunctionAddress, "InPin", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTypedInputsByPin_OutTaggedData_PropertyAddress, GetTypedInputsByPin_FunctionAddress, "OutTaggedData");
		GetTypedInputsByPin_OutTaggedData_Offset = NativeReflectionCached.GetPropertyOffset(GetTypedInputsByPin_FunctionAddress, "OutTaggedData");
		GetTypedInputsByPin_OutTaggedData_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTypedInputsByPin_FunctionAddress, "OutTaggedData", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTypedInputsByPin_InDataTypeClass_PropertyAddress, GetTypedInputsByPin_FunctionAddress, "InDataTypeClass");
		GetTypedInputsByPin_InDataTypeClass_Offset = NativeReflectionCached.GetPropertyOffset(GetTypedInputsByPin_FunctionAddress, "InDataTypeClass");
		GetTypedInputsByPin_InDataTypeClass_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTypedInputsByPin_FunctionAddress, "InDataTypeClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTypedInputsByPin_ReturnValue_PropertyAddress, GetTypedInputsByPin_FunctionAddress, "ReturnValue");
		GetTypedInputsByPin_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTypedInputsByPin_FunctionAddress, "ReturnValue");
		GetTypedInputsByPin_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTypedInputsByPin_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetTypedInputsByPin_IsValid = GetTypedInputsByPin_FunctionAddress != IntPtr.Zero && GetTypedInputsByPin_InCollection_IsValid && GetTypedInputsByPin_InPin_IsValid && GetTypedInputsByPin_OutTaggedData_IsValid && GetTypedInputsByPin_InDataTypeClass_IsValid && GetTypedInputsByPin_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGDataFunctionLibrary:GetTypedInputsByPin", GetTypedInputsByPin_IsValid);
		GetTypedInputs_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetTypedInputs");
		GetTypedInputs_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTypedInputs_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTypedInputs_InCollection_PropertyAddress, GetTypedInputs_FunctionAddress, "InCollection");
		GetTypedInputs_InCollection_Offset = NativeReflectionCached.GetPropertyOffset(GetTypedInputs_FunctionAddress, "InCollection");
		GetTypedInputs_InCollection_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTypedInputs_FunctionAddress, "InCollection", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTypedInputs_OutTaggedData_PropertyAddress, GetTypedInputs_FunctionAddress, "OutTaggedData");
		GetTypedInputs_OutTaggedData_Offset = NativeReflectionCached.GetPropertyOffset(GetTypedInputs_FunctionAddress, "OutTaggedData");
		GetTypedInputs_OutTaggedData_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTypedInputs_FunctionAddress, "OutTaggedData", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTypedInputs_InDataTypeClass_PropertyAddress, GetTypedInputs_FunctionAddress, "InDataTypeClass");
		GetTypedInputs_InDataTypeClass_Offset = NativeReflectionCached.GetPropertyOffset(GetTypedInputs_FunctionAddress, "InDataTypeClass");
		GetTypedInputs_InDataTypeClass_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTypedInputs_FunctionAddress, "InDataTypeClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTypedInputs_ReturnValue_PropertyAddress, GetTypedInputs_FunctionAddress, "ReturnValue");
		GetTypedInputs_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTypedInputs_FunctionAddress, "ReturnValue");
		GetTypedInputs_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTypedInputs_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetTypedInputs_IsValid = GetTypedInputs_FunctionAddress != IntPtr.Zero && GetTypedInputs_InCollection_IsValid && GetTypedInputs_OutTaggedData_IsValid && GetTypedInputs_InDataTypeClass_IsValid && GetTypedInputs_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGDataFunctionLibrary:GetTypedInputs", GetTypedInputs_IsValid);
		GetParamsByTag_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetParamsByTag");
		GetParamsByTag_ParamsSize = NativeReflection.GetFunctionParamsSize(GetParamsByTag_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetParamsByTag_InCollection_PropertyAddress, GetParamsByTag_FunctionAddress, "InCollection");
		GetParamsByTag_InCollection_Offset = NativeReflectionCached.GetPropertyOffset(GetParamsByTag_FunctionAddress, "InCollection");
		GetParamsByTag_InCollection_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParamsByTag_FunctionAddress, "InCollection", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParamsByTag_InTag_PropertyAddress, GetParamsByTag_FunctionAddress, "InTag");
		GetParamsByTag_InTag_Offset = NativeReflectionCached.GetPropertyOffset(GetParamsByTag_FunctionAddress, "InTag");
		GetParamsByTag_InTag_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParamsByTag_FunctionAddress, "InTag", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParamsByTag_ReturnValue_PropertyAddress, GetParamsByTag_FunctionAddress, "ReturnValue");
		GetParamsByTag_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetParamsByTag_FunctionAddress, "ReturnValue");
		GetParamsByTag_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParamsByTag_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetParamsByTag_IsValid = GetParamsByTag_FunctionAddress != IntPtr.Zero && GetParamsByTag_InCollection_IsValid && GetParamsByTag_InTag_IsValid && GetParamsByTag_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGDataFunctionLibrary:GetParamsByTag", GetParamsByTag_IsValid);
		GetParamsByPinLabel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetParamsByPinLabel");
		GetParamsByPinLabel_ParamsSize = NativeReflection.GetFunctionParamsSize(GetParamsByPinLabel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetParamsByPinLabel_InCollection_PropertyAddress, GetParamsByPinLabel_FunctionAddress, "InCollection");
		GetParamsByPinLabel_InCollection_Offset = NativeReflectionCached.GetPropertyOffset(GetParamsByPinLabel_FunctionAddress, "InCollection");
		GetParamsByPinLabel_InCollection_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParamsByPinLabel_FunctionAddress, "InCollection", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParamsByPinLabel_InPinLabel_PropertyAddress, GetParamsByPinLabel_FunctionAddress, "InPinLabel");
		GetParamsByPinLabel_InPinLabel_Offset = NativeReflectionCached.GetPropertyOffset(GetParamsByPinLabel_FunctionAddress, "InPinLabel");
		GetParamsByPinLabel_InPinLabel_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParamsByPinLabel_FunctionAddress, "InPinLabel", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParamsByPinLabel_ReturnValue_PropertyAddress, GetParamsByPinLabel_FunctionAddress, "ReturnValue");
		GetParamsByPinLabel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetParamsByPinLabel_FunctionAddress, "ReturnValue");
		GetParamsByPinLabel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParamsByPinLabel_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetParamsByPinLabel_IsValid = GetParamsByPinLabel_FunctionAddress != IntPtr.Zero && GetParamsByPinLabel_InCollection_IsValid && GetParamsByPinLabel_InPinLabel_IsValid && GetParamsByPinLabel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGDataFunctionLibrary:GetParamsByPinLabel", GetParamsByPinLabel_IsValid);
		GetParams_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetParams");
		GetParams_ParamsSize = NativeReflection.GetFunctionParamsSize(GetParams_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetParams_InCollection_PropertyAddress, GetParams_FunctionAddress, "InCollection");
		GetParams_InCollection_Offset = NativeReflectionCached.GetPropertyOffset(GetParams_FunctionAddress, "InCollection");
		GetParams_InCollection_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParams_FunctionAddress, "InCollection", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParams_ReturnValue_PropertyAddress, GetParams_FunctionAddress, "ReturnValue");
		GetParams_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetParams_FunctionAddress, "ReturnValue");
		GetParams_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParams_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetParams_IsValid = GetParams_FunctionAddress != IntPtr.Zero && GetParams_InCollection_IsValid && GetParams_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGDataFunctionLibrary:GetParams", GetParams_IsValid);
		GetInputsByTag_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetInputsByTag");
		GetInputsByTag_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInputsByTag_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInputsByTag_InCollection_PropertyAddress, GetInputsByTag_FunctionAddress, "InCollection");
		GetInputsByTag_InCollection_Offset = NativeReflectionCached.GetPropertyOffset(GetInputsByTag_FunctionAddress, "InCollection");
		GetInputsByTag_InCollection_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputsByTag_FunctionAddress, "InCollection", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInputsByTag_InTag_PropertyAddress, GetInputsByTag_FunctionAddress, "InTag");
		GetInputsByTag_InTag_Offset = NativeReflectionCached.GetPropertyOffset(GetInputsByTag_FunctionAddress, "InTag");
		GetInputsByTag_InTag_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputsByTag_FunctionAddress, "InTag", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInputsByTag_ReturnValue_PropertyAddress, GetInputsByTag_FunctionAddress, "ReturnValue");
		GetInputsByTag_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetInputsByTag_FunctionAddress, "ReturnValue");
		GetInputsByTag_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputsByTag_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetInputsByTag_IsValid = GetInputsByTag_FunctionAddress != IntPtr.Zero && GetInputsByTag_InCollection_IsValid && GetInputsByTag_InTag_IsValid && GetInputsByTag_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGDataFunctionLibrary:GetInputsByTag", GetInputsByTag_IsValid);
		GetInputsByPinLabel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetInputsByPinLabel");
		GetInputsByPinLabel_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInputsByPinLabel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInputsByPinLabel_InCollection_PropertyAddress, GetInputsByPinLabel_FunctionAddress, "InCollection");
		GetInputsByPinLabel_InCollection_Offset = NativeReflectionCached.GetPropertyOffset(GetInputsByPinLabel_FunctionAddress, "InCollection");
		GetInputsByPinLabel_InCollection_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputsByPinLabel_FunctionAddress, "InCollection", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInputsByPinLabel_InPinLabel_PropertyAddress, GetInputsByPinLabel_FunctionAddress, "InPinLabel");
		GetInputsByPinLabel_InPinLabel_Offset = NativeReflectionCached.GetPropertyOffset(GetInputsByPinLabel_FunctionAddress, "InPinLabel");
		GetInputsByPinLabel_InPinLabel_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputsByPinLabel_FunctionAddress, "InPinLabel", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInputsByPinLabel_ReturnValue_PropertyAddress, GetInputsByPinLabel_FunctionAddress, "ReturnValue");
		GetInputsByPinLabel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetInputsByPinLabel_FunctionAddress, "ReturnValue");
		GetInputsByPinLabel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputsByPinLabel_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetInputsByPinLabel_IsValid = GetInputsByPinLabel_FunctionAddress != IntPtr.Zero && GetInputsByPinLabel_InCollection_IsValid && GetInputsByPinLabel_InPinLabel_IsValid && GetInputsByPinLabel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGDataFunctionLibrary:GetInputsByPinLabel", GetInputsByPinLabel_IsValid);
		GetInputs_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetInputs");
		GetInputs_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInputs_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInputs_InCollection_PropertyAddress, GetInputs_FunctionAddress, "InCollection");
		GetInputs_InCollection_Offset = NativeReflectionCached.GetPropertyOffset(GetInputs_FunctionAddress, "InCollection");
		GetInputs_InCollection_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputs_FunctionAddress, "InCollection", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInputs_ReturnValue_PropertyAddress, GetInputs_FunctionAddress, "ReturnValue");
		GetInputs_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetInputs_FunctionAddress, "ReturnValue");
		GetInputs_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputs_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetInputs_IsValid = GetInputs_FunctionAddress != IntPtr.Zero && GetInputs_InCollection_IsValid && GetInputs_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGDataFunctionLibrary:GetInputs", GetInputs_IsValid);
		GetAllSettings_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAllSettings");
		GetAllSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllSettings_InCollection_PropertyAddress, GetAllSettings_FunctionAddress, "InCollection");
		GetAllSettings_InCollection_Offset = NativeReflectionCached.GetPropertyOffset(GetAllSettings_FunctionAddress, "InCollection");
		GetAllSettings_InCollection_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllSettings_FunctionAddress, "InCollection", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllSettings_ReturnValue_PropertyAddress, GetAllSettings_FunctionAddress, "ReturnValue");
		GetAllSettings_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAllSettings_FunctionAddress, "ReturnValue");
		GetAllSettings_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllSettings_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetAllSettings_IsValid = GetAllSettings_FunctionAddress != IntPtr.Zero && GetAllSettings_InCollection_IsValid && GetAllSettings_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGDataFunctionLibrary:GetAllSettings", GetAllSettings_IsValid);
		AddToCollection_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddToCollection");
		AddToCollection_ParamsSize = NativeReflection.GetFunctionParamsSize(AddToCollection_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddToCollection_InCollection_PropertyAddress, AddToCollection_FunctionAddress, "InCollection");
		AddToCollection_InCollection_Offset = NativeReflectionCached.GetPropertyOffset(AddToCollection_FunctionAddress, "InCollection");
		AddToCollection_InCollection_IsValid = NativeReflectionCached.ValidatePropertyClass(AddToCollection_FunctionAddress, "InCollection", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddToCollection_InData_PropertyAddress, AddToCollection_FunctionAddress, "InData");
		AddToCollection_InData_Offset = NativeReflectionCached.GetPropertyOffset(AddToCollection_FunctionAddress, "InData");
		AddToCollection_InData_IsValid = NativeReflectionCached.ValidatePropertyClass(AddToCollection_FunctionAddress, "InData", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddToCollection_InPinLabel_PropertyAddress, AddToCollection_FunctionAddress, "InPinLabel");
		AddToCollection_InPinLabel_Offset = NativeReflectionCached.GetPropertyOffset(AddToCollection_FunctionAddress, "InPinLabel");
		AddToCollection_InPinLabel_IsValid = NativeReflectionCached.ValidatePropertyClass(AddToCollection_FunctionAddress, "InPinLabel", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddToCollection_InTags_PropertyAddress, AddToCollection_FunctionAddress, "InTags");
		AddToCollection_InTags_Offset = NativeReflectionCached.GetPropertyOffset(AddToCollection_FunctionAddress, "InTags");
		AddToCollection_InTags_IsValid = NativeReflectionCached.ValidatePropertyClass(AddToCollection_FunctionAddress, "InTags", Classes.FArrayProperty);
		AddToCollection_IsValid = AddToCollection_FunctionAddress != IntPtr.Zero && AddToCollection_InCollection_IsValid && AddToCollection_InData_IsValid && AddToCollection_InPinLabel_IsValid && AddToCollection_InTags_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGDataFunctionLibrary:AddToCollection", AddToCollection_IsValid);
	}
}
