using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/Engine.KismetStringTableLibrary", "Engine", UnrealModuleType.Engine)]
public class UStringTableLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool IsRegisteredTableId_IsValid;

	private static IntPtr IsRegisteredTableId_FunctionAddress;

	private static int IsRegisteredTableId_ParamsSize;

	private static bool IsRegisteredTableId_TableId_IsValid;

	private static FFieldAddress IsRegisteredTableId_TableId_PropertyAddress;

	private static int IsRegisteredTableId_TableId_Offset;

	private static bool IsRegisteredTableId_ReturnValue_IsValid;

	private static FFieldAddress IsRegisteredTableId_ReturnValue_PropertyAddress;

	private static int IsRegisteredTableId_ReturnValue_Offset;

	private static bool IsRegisteredTableEntry_IsValid;

	private static IntPtr IsRegisteredTableEntry_FunctionAddress;

	private static int IsRegisteredTableEntry_ParamsSize;

	private static bool IsRegisteredTableEntry_TableId_IsValid;

	private static FFieldAddress IsRegisteredTableEntry_TableId_PropertyAddress;

	private static int IsRegisteredTableEntry_TableId_Offset;

	private static bool IsRegisteredTableEntry_Key_IsValid;

	private static FFieldAddress IsRegisteredTableEntry_Key_PropertyAddress;

	private static int IsRegisteredTableEntry_Key_Offset;

	private static bool IsRegisteredTableEntry_ReturnValue_IsValid;

	private static FFieldAddress IsRegisteredTableEntry_ReturnValue_PropertyAddress;

	private static int IsRegisteredTableEntry_ReturnValue_Offset;

	private static bool GetTableNamespace_IsValid;

	private static IntPtr GetTableNamespace_FunctionAddress;

	private static int GetTableNamespace_ParamsSize;

	private static bool GetTableNamespace_TableId_IsValid;

	private static FFieldAddress GetTableNamespace_TableId_PropertyAddress;

	private static int GetTableNamespace_TableId_Offset;

	private static bool GetTableNamespace_ReturnValue_IsValid;

	private static FFieldAddress GetTableNamespace_ReturnValue_PropertyAddress;

	private static int GetTableNamespace_ReturnValue_Offset;

	private static bool GetTableEntrySourceString_IsValid;

	private static IntPtr GetTableEntrySourceString_FunctionAddress;

	private static int GetTableEntrySourceString_ParamsSize;

	private static bool GetTableEntrySourceString_TableId_IsValid;

	private static FFieldAddress GetTableEntrySourceString_TableId_PropertyAddress;

	private static int GetTableEntrySourceString_TableId_Offset;

	private static bool GetTableEntrySourceString_Key_IsValid;

	private static FFieldAddress GetTableEntrySourceString_Key_PropertyAddress;

	private static int GetTableEntrySourceString_Key_Offset;

	private static bool GetTableEntrySourceString_ReturnValue_IsValid;

	private static FFieldAddress GetTableEntrySourceString_ReturnValue_PropertyAddress;

	private static int GetTableEntrySourceString_ReturnValue_Offset;

	private static bool GetTableEntryMetaData_IsValid;

	private static IntPtr GetTableEntryMetaData_FunctionAddress;

	private static int GetTableEntryMetaData_ParamsSize;

	private static bool GetTableEntryMetaData_TableId_IsValid;

	private static FFieldAddress GetTableEntryMetaData_TableId_PropertyAddress;

	private static int GetTableEntryMetaData_TableId_Offset;

	private static bool GetTableEntryMetaData_Key_IsValid;

	private static FFieldAddress GetTableEntryMetaData_Key_PropertyAddress;

	private static int GetTableEntryMetaData_Key_Offset;

	private static bool GetTableEntryMetaData_MetaDataId_IsValid;

	private static FFieldAddress GetTableEntryMetaData_MetaDataId_PropertyAddress;

	private static int GetTableEntryMetaData_MetaDataId_Offset;

	private static bool GetTableEntryMetaData_ReturnValue_IsValid;

	private static FFieldAddress GetTableEntryMetaData_ReturnValue_PropertyAddress;

	private static int GetTableEntryMetaData_ReturnValue_Offset;

	private static bool GetRegisteredStringTables_IsValid;

	private static IntPtr GetRegisteredStringTables_FunctionAddress;

	private static int GetRegisteredStringTables_ParamsSize;

	private static bool GetRegisteredStringTables_ReturnValue_IsValid;

	private static FFieldAddress GetRegisteredStringTables_ReturnValue_PropertyAddress;

	private static int GetRegisteredStringTables_ReturnValue_Offset;

	private static bool GetMetaDataIdsFromStringTableEntry_IsValid;

	private static IntPtr GetMetaDataIdsFromStringTableEntry_FunctionAddress;

	private static int GetMetaDataIdsFromStringTableEntry_ParamsSize;

	private static bool GetMetaDataIdsFromStringTableEntry_TableId_IsValid;

	private static FFieldAddress GetMetaDataIdsFromStringTableEntry_TableId_PropertyAddress;

	private static int GetMetaDataIdsFromStringTableEntry_TableId_Offset;

	private static bool GetMetaDataIdsFromStringTableEntry_Key_IsValid;

	private static FFieldAddress GetMetaDataIdsFromStringTableEntry_Key_PropertyAddress;

	private static int GetMetaDataIdsFromStringTableEntry_Key_Offset;

	private static bool GetMetaDataIdsFromStringTableEntry_ReturnValue_IsValid;

	private static FFieldAddress GetMetaDataIdsFromStringTableEntry_ReturnValue_PropertyAddress;

	private static int GetMetaDataIdsFromStringTableEntry_ReturnValue_Offset;

	private static bool GetKeysFromStringTable_IsValid;

	private static IntPtr GetKeysFromStringTable_FunctionAddress;

	private static int GetKeysFromStringTable_ParamsSize;

	private static bool GetKeysFromStringTable_TableId_IsValid;

	private static FFieldAddress GetKeysFromStringTable_TableId_PropertyAddress;

	private static int GetKeysFromStringTable_TableId_Offset;

	private static bool GetKeysFromStringTable_ReturnValue_IsValid;

	private static FFieldAddress GetKeysFromStringTable_ReturnValue_PropertyAddress;

	private static int GetKeysFromStringTable_ReturnValue_Offset;

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetStringTableLibrary:IsRegisteredTableId")]
	public unsafe static bool IsRegisteredTableId(FName TableId)
	{
		if (!IsRegisteredTableId_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringTableLibrary:IsRegisteredTableId");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsRegisteredTableId_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsRegisteredTableId_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, IsRegisteredTableId_TableId_Offset), 0, IsRegisteredTableId_TableId_PropertyAddress.Address, TableId);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsRegisteredTableId_FunctionAddress, intPtr, IsRegisteredTableId_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsRegisteredTableId_ReturnValue_Offset), 0, IsRegisteredTableId_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetStringTableLibrary:IsRegisteredTableEntry")]
	public unsafe static bool IsRegisteredTableEntry(FName TableId, string Key)
	{
		if (!IsRegisteredTableEntry_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringTableLibrary:IsRegisteredTableEntry");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsRegisteredTableEntry_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsRegisteredTableEntry_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, IsRegisteredTableEntry_TableId_Offset), 0, IsRegisteredTableEntry_TableId_PropertyAddress.Address, TableId);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, IsRegisteredTableEntry_Key_Offset), 0, IsRegisteredTableEntry_Key_PropertyAddress.Address, Key);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsRegisteredTableEntry_FunctionAddress, intPtr, IsRegisteredTableEntry_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsRegisteredTableEntry_Key_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsRegisteredTableEntry_ReturnValue_Offset), 0, IsRegisteredTableEntry_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetStringTableLibrary:GetTableNamespace")]
	public unsafe static string GetTableNamespace(FName TableId)
	{
		if (!GetTableNamespace_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringTableLibrary:GetTableNamespace");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTableNamespace_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTableNamespace_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetTableNamespace_TableId_Offset), 0, GetTableNamespace_TableId_PropertyAddress.Address, TableId);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetTableNamespace_FunctionAddress, intPtr, GetTableNamespace_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetTableNamespace_ReturnValue_Offset), 0, GetTableNamespace_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetTableNamespace_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetStringTableLibrary:GetTableEntrySourceString")]
	public unsafe static string GetTableEntrySourceString(FName TableId, string Key)
	{
		if (!GetTableEntrySourceString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringTableLibrary:GetTableEntrySourceString");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTableEntrySourceString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTableEntrySourceString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetTableEntrySourceString_TableId_Offset), 0, GetTableEntrySourceString_TableId_PropertyAddress.Address, TableId);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetTableEntrySourceString_Key_Offset), 0, GetTableEntrySourceString_Key_PropertyAddress.Address, Key);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetTableEntrySourceString_FunctionAddress, intPtr, GetTableEntrySourceString_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetTableEntrySourceString_Key_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetTableEntrySourceString_ReturnValue_Offset), 0, GetTableEntrySourceString_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetTableEntrySourceString_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetStringTableLibrary:GetTableEntryMetaData")]
	public unsafe static string GetTableEntryMetaData(FName TableId, string Key, FName MetaDataId)
	{
		if (!GetTableEntryMetaData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringTableLibrary:GetTableEntryMetaData");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTableEntryMetaData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTableEntryMetaData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetTableEntryMetaData_TableId_Offset), 0, GetTableEntryMetaData_TableId_PropertyAddress.Address, TableId);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetTableEntryMetaData_Key_Offset), 0, GetTableEntryMetaData_Key_PropertyAddress.Address, Key);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetTableEntryMetaData_MetaDataId_Offset), 0, GetTableEntryMetaData_MetaDataId_PropertyAddress.Address, MetaDataId);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetTableEntryMetaData_FunctionAddress, intPtr, GetTableEntryMetaData_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetTableEntryMetaData_Key_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetTableEntryMetaData_ReturnValue_Offset), 0, GetTableEntryMetaData_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetTableEntryMetaData_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetStringTableLibrary:GetRegisteredStringTables")]
	public unsafe static List<FName> GetRegisteredStringTables()
	{
		if (!GetRegisteredStringTables_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringTableLibrary:GetRegisteredStringTables");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRegisteredStringTables_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRegisteredStringTables_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetRegisteredStringTables_FunctionAddress, intPtr, GetRegisteredStringTables_ParamsSize);
		List<FName> result = new TArrayCopyMarshaler<FName>(1, GetRegisteredStringTables_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(intPtr, GetRegisteredStringTables_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetRegisteredStringTables_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetStringTableLibrary:GetMetaDataIdsFromStringTableEntry")]
	public unsafe static List<FName> GetMetaDataIdsFromStringTableEntry(FName TableId, string Key)
	{
		if (!GetMetaDataIdsFromStringTableEntry_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringTableLibrary:GetMetaDataIdsFromStringTableEntry");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMetaDataIdsFromStringTableEntry_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMetaDataIdsFromStringTableEntry_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetMetaDataIdsFromStringTableEntry_TableId_Offset), 0, GetMetaDataIdsFromStringTableEntry_TableId_PropertyAddress.Address, TableId);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetMetaDataIdsFromStringTableEntry_Key_Offset), 0, GetMetaDataIdsFromStringTableEntry_Key_PropertyAddress.Address, Key);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetMetaDataIdsFromStringTableEntry_FunctionAddress, intPtr, GetMetaDataIdsFromStringTableEntry_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetMetaDataIdsFromStringTableEntry_Key_PropertyAddress.Address, intPtr);
		List<FName> result = new TArrayCopyMarshaler<FName>(1, GetMetaDataIdsFromStringTableEntry_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(intPtr, GetMetaDataIdsFromStringTableEntry_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetMetaDataIdsFromStringTableEntry_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetStringTableLibrary:GetKeysFromStringTable")]
	public unsafe static List<string> GetKeysFromStringTable(FName TableId)
	{
		if (!GetKeysFromStringTable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringTableLibrary:GetKeysFromStringTable");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetKeysFromStringTable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetKeysFromStringTable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetKeysFromStringTable_TableId_Offset), 0, GetKeysFromStringTable_TableId_PropertyAddress.Address, TableId);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetKeysFromStringTable_FunctionAddress, intPtr, GetKeysFromStringTable_ParamsSize);
		List<string> result = new TArrayCopyMarshaler<string>(1, GetKeysFromStringTable_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetKeysFromStringTable_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetKeysFromStringTable_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UStringTableLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UStringTableLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UStringTableLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/Engine.KismetStringTableLibrary");
		IsRegisteredTableId_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsRegisteredTableId");
		IsRegisteredTableId_ParamsSize = NativeReflection.GetFunctionParamsSize(IsRegisteredTableId_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsRegisteredTableId_TableId_PropertyAddress, IsRegisteredTableId_FunctionAddress, "TableId");
		IsRegisteredTableId_TableId_Offset = NativeReflectionCached.GetPropertyOffset(IsRegisteredTableId_FunctionAddress, "TableId");
		IsRegisteredTableId_TableId_IsValid = NativeReflectionCached.ValidatePropertyClass(IsRegisteredTableId_FunctionAddress, "TableId", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref IsRegisteredTableId_ReturnValue_PropertyAddress, IsRegisteredTableId_FunctionAddress, "ReturnValue");
		IsRegisteredTableId_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsRegisteredTableId_FunctionAddress, "ReturnValue");
		IsRegisteredTableId_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsRegisteredTableId_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsRegisteredTableId_IsValid = IsRegisteredTableId_FunctionAddress != IntPtr.Zero && IsRegisteredTableId_TableId_IsValid && IsRegisteredTableId_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringTableLibrary:IsRegisteredTableId", IsRegisteredTableId_IsValid);
		IsRegisteredTableEntry_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsRegisteredTableEntry");
		IsRegisteredTableEntry_ParamsSize = NativeReflection.GetFunctionParamsSize(IsRegisteredTableEntry_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsRegisteredTableEntry_TableId_PropertyAddress, IsRegisteredTableEntry_FunctionAddress, "TableId");
		IsRegisteredTableEntry_TableId_Offset = NativeReflectionCached.GetPropertyOffset(IsRegisteredTableEntry_FunctionAddress, "TableId");
		IsRegisteredTableEntry_TableId_IsValid = NativeReflectionCached.ValidatePropertyClass(IsRegisteredTableEntry_FunctionAddress, "TableId", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref IsRegisteredTableEntry_Key_PropertyAddress, IsRegisteredTableEntry_FunctionAddress, "Key");
		IsRegisteredTableEntry_Key_Offset = NativeReflectionCached.GetPropertyOffset(IsRegisteredTableEntry_FunctionAddress, "Key");
		IsRegisteredTableEntry_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(IsRegisteredTableEntry_FunctionAddress, "Key", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref IsRegisteredTableEntry_ReturnValue_PropertyAddress, IsRegisteredTableEntry_FunctionAddress, "ReturnValue");
		IsRegisteredTableEntry_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsRegisteredTableEntry_FunctionAddress, "ReturnValue");
		IsRegisteredTableEntry_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsRegisteredTableEntry_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsRegisteredTableEntry_IsValid = IsRegisteredTableEntry_FunctionAddress != IntPtr.Zero && IsRegisteredTableEntry_TableId_IsValid && IsRegisteredTableEntry_Key_IsValid && IsRegisteredTableEntry_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringTableLibrary:IsRegisteredTableEntry", IsRegisteredTableEntry_IsValid);
		GetTableNamespace_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetTableNamespace");
		GetTableNamespace_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTableNamespace_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTableNamespace_TableId_PropertyAddress, GetTableNamespace_FunctionAddress, "TableId");
		GetTableNamespace_TableId_Offset = NativeReflectionCached.GetPropertyOffset(GetTableNamespace_FunctionAddress, "TableId");
		GetTableNamespace_TableId_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTableNamespace_FunctionAddress, "TableId", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTableNamespace_ReturnValue_PropertyAddress, GetTableNamespace_FunctionAddress, "ReturnValue");
		GetTableNamespace_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTableNamespace_FunctionAddress, "ReturnValue");
		GetTableNamespace_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTableNamespace_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetTableNamespace_IsValid = GetTableNamespace_FunctionAddress != IntPtr.Zero && GetTableNamespace_TableId_IsValid && GetTableNamespace_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringTableLibrary:GetTableNamespace", GetTableNamespace_IsValid);
		GetTableEntrySourceString_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetTableEntrySourceString");
		GetTableEntrySourceString_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTableEntrySourceString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTableEntrySourceString_TableId_PropertyAddress, GetTableEntrySourceString_FunctionAddress, "TableId");
		GetTableEntrySourceString_TableId_Offset = NativeReflectionCached.GetPropertyOffset(GetTableEntrySourceString_FunctionAddress, "TableId");
		GetTableEntrySourceString_TableId_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTableEntrySourceString_FunctionAddress, "TableId", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTableEntrySourceString_Key_PropertyAddress, GetTableEntrySourceString_FunctionAddress, "Key");
		GetTableEntrySourceString_Key_Offset = NativeReflectionCached.GetPropertyOffset(GetTableEntrySourceString_FunctionAddress, "Key");
		GetTableEntrySourceString_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTableEntrySourceString_FunctionAddress, "Key", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTableEntrySourceString_ReturnValue_PropertyAddress, GetTableEntrySourceString_FunctionAddress, "ReturnValue");
		GetTableEntrySourceString_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTableEntrySourceString_FunctionAddress, "ReturnValue");
		GetTableEntrySourceString_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTableEntrySourceString_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetTableEntrySourceString_IsValid = GetTableEntrySourceString_FunctionAddress != IntPtr.Zero && GetTableEntrySourceString_TableId_IsValid && GetTableEntrySourceString_Key_IsValid && GetTableEntrySourceString_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringTableLibrary:GetTableEntrySourceString", GetTableEntrySourceString_IsValid);
		GetTableEntryMetaData_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetTableEntryMetaData");
		GetTableEntryMetaData_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTableEntryMetaData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTableEntryMetaData_TableId_PropertyAddress, GetTableEntryMetaData_FunctionAddress, "TableId");
		GetTableEntryMetaData_TableId_Offset = NativeReflectionCached.GetPropertyOffset(GetTableEntryMetaData_FunctionAddress, "TableId");
		GetTableEntryMetaData_TableId_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTableEntryMetaData_FunctionAddress, "TableId", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTableEntryMetaData_Key_PropertyAddress, GetTableEntryMetaData_FunctionAddress, "Key");
		GetTableEntryMetaData_Key_Offset = NativeReflectionCached.GetPropertyOffset(GetTableEntryMetaData_FunctionAddress, "Key");
		GetTableEntryMetaData_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTableEntryMetaData_FunctionAddress, "Key", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTableEntryMetaData_MetaDataId_PropertyAddress, GetTableEntryMetaData_FunctionAddress, "MetaDataId");
		GetTableEntryMetaData_MetaDataId_Offset = NativeReflectionCached.GetPropertyOffset(GetTableEntryMetaData_FunctionAddress, "MetaDataId");
		GetTableEntryMetaData_MetaDataId_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTableEntryMetaData_FunctionAddress, "MetaDataId", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTableEntryMetaData_ReturnValue_PropertyAddress, GetTableEntryMetaData_FunctionAddress, "ReturnValue");
		GetTableEntryMetaData_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTableEntryMetaData_FunctionAddress, "ReturnValue");
		GetTableEntryMetaData_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTableEntryMetaData_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetTableEntryMetaData_IsValid = GetTableEntryMetaData_FunctionAddress != IntPtr.Zero && GetTableEntryMetaData_TableId_IsValid && GetTableEntryMetaData_Key_IsValid && GetTableEntryMetaData_MetaDataId_IsValid && GetTableEntryMetaData_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringTableLibrary:GetTableEntryMetaData", GetTableEntryMetaData_IsValid);
		GetRegisteredStringTables_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetRegisteredStringTables");
		GetRegisteredStringTables_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRegisteredStringTables_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRegisteredStringTables_ReturnValue_PropertyAddress, GetRegisteredStringTables_FunctionAddress, "ReturnValue");
		GetRegisteredStringTables_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRegisteredStringTables_FunctionAddress, "ReturnValue");
		GetRegisteredStringTables_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRegisteredStringTables_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetRegisteredStringTables_IsValid = GetRegisteredStringTables_FunctionAddress != IntPtr.Zero && GetRegisteredStringTables_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringTableLibrary:GetRegisteredStringTables", GetRegisteredStringTables_IsValid);
		GetMetaDataIdsFromStringTableEntry_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetMetaDataIdsFromStringTableEntry");
		GetMetaDataIdsFromStringTableEntry_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMetaDataIdsFromStringTableEntry_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMetaDataIdsFromStringTableEntry_TableId_PropertyAddress, GetMetaDataIdsFromStringTableEntry_FunctionAddress, "TableId");
		GetMetaDataIdsFromStringTableEntry_TableId_Offset = NativeReflectionCached.GetPropertyOffset(GetMetaDataIdsFromStringTableEntry_FunctionAddress, "TableId");
		GetMetaDataIdsFromStringTableEntry_TableId_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMetaDataIdsFromStringTableEntry_FunctionAddress, "TableId", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMetaDataIdsFromStringTableEntry_Key_PropertyAddress, GetMetaDataIdsFromStringTableEntry_FunctionAddress, "Key");
		GetMetaDataIdsFromStringTableEntry_Key_Offset = NativeReflectionCached.GetPropertyOffset(GetMetaDataIdsFromStringTableEntry_FunctionAddress, "Key");
		GetMetaDataIdsFromStringTableEntry_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMetaDataIdsFromStringTableEntry_FunctionAddress, "Key", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMetaDataIdsFromStringTableEntry_ReturnValue_PropertyAddress, GetMetaDataIdsFromStringTableEntry_FunctionAddress, "ReturnValue");
		GetMetaDataIdsFromStringTableEntry_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMetaDataIdsFromStringTableEntry_FunctionAddress, "ReturnValue");
		GetMetaDataIdsFromStringTableEntry_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMetaDataIdsFromStringTableEntry_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetMetaDataIdsFromStringTableEntry_IsValid = GetMetaDataIdsFromStringTableEntry_FunctionAddress != IntPtr.Zero && GetMetaDataIdsFromStringTableEntry_TableId_IsValid && GetMetaDataIdsFromStringTableEntry_Key_IsValid && GetMetaDataIdsFromStringTableEntry_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringTableLibrary:GetMetaDataIdsFromStringTableEntry", GetMetaDataIdsFromStringTableEntry_IsValid);
		GetKeysFromStringTable_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetKeysFromStringTable");
		GetKeysFromStringTable_ParamsSize = NativeReflection.GetFunctionParamsSize(GetKeysFromStringTable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetKeysFromStringTable_TableId_PropertyAddress, GetKeysFromStringTable_FunctionAddress, "TableId");
		GetKeysFromStringTable_TableId_Offset = NativeReflectionCached.GetPropertyOffset(GetKeysFromStringTable_FunctionAddress, "TableId");
		GetKeysFromStringTable_TableId_IsValid = NativeReflectionCached.ValidatePropertyClass(GetKeysFromStringTable_FunctionAddress, "TableId", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetKeysFromStringTable_ReturnValue_PropertyAddress, GetKeysFromStringTable_FunctionAddress, "ReturnValue");
		GetKeysFromStringTable_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetKeysFromStringTable_FunctionAddress, "ReturnValue");
		GetKeysFromStringTable_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetKeysFromStringTable_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetKeysFromStringTable_IsValid = GetKeysFromStringTable_FunctionAddress != IntPtr.Zero && GetKeysFromStringTable_TableId_IsValid && GetKeysFromStringTable_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringTableLibrary:GetKeysFromStringTable", GetKeysFromStringTable_IsValid);
	}
}
