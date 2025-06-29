using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/Engine.DataTableFunctionLibrary", "Engine", UnrealModuleType.Engine)]
public class UDataTableFunctionLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool GetDataTableRowNames_IsValid;

	private static IntPtr GetDataTableRowNames_FunctionAddress;

	private static int GetDataTableRowNames_ParamsSize;

	private static bool GetDataTableRowNames_Table_IsValid;

	private static FFieldAddress GetDataTableRowNames_Table_PropertyAddress;

	private static int GetDataTableRowNames_Table_Offset;

	private static bool GetDataTableRowNames_OutRowNames_IsValid;

	private static FFieldAddress GetDataTableRowNames_OutRowNames_PropertyAddress;

	private static int GetDataTableRowNames_OutRowNames_Offset;

	private static bool GetDataTableColumnAsString_IsValid;

	private static IntPtr GetDataTableColumnAsString_FunctionAddress;

	private static int GetDataTableColumnAsString_ParamsSize;

	private static bool GetDataTableColumnAsString_DataTable_IsValid;

	private static FFieldAddress GetDataTableColumnAsString_DataTable_PropertyAddress;

	private static int GetDataTableColumnAsString_DataTable_Offset;

	private static bool GetDataTableColumnAsString_PropertyName_IsValid;

	private static FFieldAddress GetDataTableColumnAsString_PropertyName_PropertyAddress;

	private static int GetDataTableColumnAsString_PropertyName_Offset;

	private static bool GetDataTableColumnAsString_ReturnValue_IsValid;

	private static FFieldAddress GetDataTableColumnAsString_ReturnValue_PropertyAddress;

	private static int GetDataTableColumnAsString_ReturnValue_Offset;

	private static bool FillDataTableFromJSONString_IsValid;

	private static IntPtr FillDataTableFromJSONString_FunctionAddress;

	private static int FillDataTableFromJSONString_ParamsSize;

	private static bool FillDataTableFromJSONString_DataTable_IsValid;

	private static FFieldAddress FillDataTableFromJSONString_DataTable_PropertyAddress;

	private static int FillDataTableFromJSONString_DataTable_Offset;

	private static bool FillDataTableFromJSONString_JSONString_IsValid;

	private static FFieldAddress FillDataTableFromJSONString_JSONString_PropertyAddress;

	private static int FillDataTableFromJSONString_JSONString_Offset;

	private static bool FillDataTableFromJSONString_ReturnValue_IsValid;

	private static FFieldAddress FillDataTableFromJSONString_ReturnValue_PropertyAddress;

	private static int FillDataTableFromJSONString_ReturnValue_Offset;

	private static bool FillDataTableFromJSONFile_IsValid;

	private static IntPtr FillDataTableFromJSONFile_FunctionAddress;

	private static int FillDataTableFromJSONFile_ParamsSize;

	private static bool FillDataTableFromJSONFile_DataTable_IsValid;

	private static FFieldAddress FillDataTableFromJSONFile_DataTable_PropertyAddress;

	private static int FillDataTableFromJSONFile_DataTable_Offset;

	private static bool FillDataTableFromJSONFile_JSONFilePath_IsValid;

	private static FFieldAddress FillDataTableFromJSONFile_JSONFilePath_PropertyAddress;

	private static int FillDataTableFromJSONFile_JSONFilePath_Offset;

	private static bool FillDataTableFromJSONFile_ImportRowStruct_IsValid;

	private static FFieldAddress FillDataTableFromJSONFile_ImportRowStruct_PropertyAddress;

	private static int FillDataTableFromJSONFile_ImportRowStruct_Offset;

	private static bool FillDataTableFromJSONFile_ReturnValue_IsValid;

	private static FFieldAddress FillDataTableFromJSONFile_ReturnValue_PropertyAddress;

	private static int FillDataTableFromJSONFile_ReturnValue_Offset;

	private static bool FillDataTableFromCSVString_IsValid;

	private static IntPtr FillDataTableFromCSVString_FunctionAddress;

	private static int FillDataTableFromCSVString_ParamsSize;

	private static bool FillDataTableFromCSVString_DataTable_IsValid;

	private static FFieldAddress FillDataTableFromCSVString_DataTable_PropertyAddress;

	private static int FillDataTableFromCSVString_DataTable_Offset;

	private static bool FillDataTableFromCSVString_CSVString_IsValid;

	private static FFieldAddress FillDataTableFromCSVString_CSVString_PropertyAddress;

	private static int FillDataTableFromCSVString_CSVString_Offset;

	private static bool FillDataTableFromCSVString_ReturnValue_IsValid;

	private static FFieldAddress FillDataTableFromCSVString_ReturnValue_PropertyAddress;

	private static int FillDataTableFromCSVString_ReturnValue_Offset;

	private static bool FillDataTableFromCSVFile_IsValid;

	private static IntPtr FillDataTableFromCSVFile_FunctionAddress;

	private static int FillDataTableFromCSVFile_ParamsSize;

	private static bool FillDataTableFromCSVFile_DataTable_IsValid;

	private static FFieldAddress FillDataTableFromCSVFile_DataTable_PropertyAddress;

	private static int FillDataTableFromCSVFile_DataTable_Offset;

	private static bool FillDataTableFromCSVFile_CSVFilePath_IsValid;

	private static FFieldAddress FillDataTableFromCSVFile_CSVFilePath_PropertyAddress;

	private static int FillDataTableFromCSVFile_CSVFilePath_Offset;

	private static bool FillDataTableFromCSVFile_ReturnValue_IsValid;

	private static FFieldAddress FillDataTableFromCSVFile_ReturnValue_PropertyAddress;

	private static int FillDataTableFromCSVFile_ReturnValue_Offset;

	private static bool EvaluateCurveTableRow_IsValid;

	private static IntPtr EvaluateCurveTableRow_FunctionAddress;

	private static int EvaluateCurveTableRow_ParamsSize;

	private static bool EvaluateCurveTableRow_CurveTable_IsValid;

	private static FFieldAddress EvaluateCurveTableRow_CurveTable_PropertyAddress;

	private static int EvaluateCurveTableRow_CurveTable_Offset;

	private static bool EvaluateCurveTableRow_RowName_IsValid;

	private static FFieldAddress EvaluateCurveTableRow_RowName_PropertyAddress;

	private static int EvaluateCurveTableRow_RowName_Offset;

	private static bool EvaluateCurveTableRow_InXY_IsValid;

	private static FFieldAddress EvaluateCurveTableRow_InXY_PropertyAddress;

	private static int EvaluateCurveTableRow_InXY_Offset;

	private static bool EvaluateCurveTableRow_OutResult_IsValid;

	private static FFieldAddress EvaluateCurveTableRow_OutResult_PropertyAddress;

	private static int EvaluateCurveTableRow_OutResult_Offset;

	private static bool EvaluateCurveTableRow_OutXY_IsValid;

	private static FFieldAddress EvaluateCurveTableRow_OutXY_PropertyAddress;

	private static int EvaluateCurveTableRow_OutXY_Offset;

	private static bool EvaluateCurveTableRow_ContextString_IsValid;

	private static FFieldAddress EvaluateCurveTableRow_ContextString_PropertyAddress;

	private static int EvaluateCurveTableRow_ContextString_Offset;

	private static bool DoesDataTableRowExist_IsValid;

	private static IntPtr DoesDataTableRowExist_FunctionAddress;

	private static int DoesDataTableRowExist_ParamsSize;

	private static bool DoesDataTableRowExist_Table_IsValid;

	private static FFieldAddress DoesDataTableRowExist_Table_PropertyAddress;

	private static int DoesDataTableRowExist_Table_Offset;

	private static bool DoesDataTableRowExist_RowName_IsValid;

	private static FFieldAddress DoesDataTableRowExist_RowName_PropertyAddress;

	private static int DoesDataTableRowExist_RowName_Offset;

	private static bool DoesDataTableRowExist_ReturnValue_IsValid;

	private static FFieldAddress DoesDataTableRowExist_ReturnValue_PropertyAddress;

	private static int DoesDataTableRowExist_ReturnValue_Offset;

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.DataTableFunctionLibrary:GetDataTableRowNames")]
	public unsafe static void GetDataTableRowNames(UDataTable Table, out List<FName> OutRowNames)
	{
		if (!GetDataTableRowNames_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.DataTableFunctionLibrary:GetDataTableRowNames");
			OutRowNames = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDataTableRowNames_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDataTableRowNames_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDataTable>.ToNative(IntPtr.Add(intPtr, GetDataTableRowNames_Table_Offset), 0, GetDataTableRowNames_Table_PropertyAddress.Address, Table);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetDataTableRowNames_FunctionAddress, intPtr, GetDataTableRowNames_ParamsSize);
		OutRowNames = new TArrayCopyMarshaler<FName>(1, GetDataTableRowNames_OutRowNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(intPtr, GetDataTableRowNames_OutRowNames_Offset));
		NativeReflection.DestroyValue_InContainer(GetDataTableRowNames_OutRowNames_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/Engine.DataTableFunctionLibrary:GetDataTableColumnAsString")]
	public unsafe static List<string> GetDataTableColumnAsString(UDataTable DataTable, FName PropertyName)
	{
		if (!GetDataTableColumnAsString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.DataTableFunctionLibrary:GetDataTableColumnAsString");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDataTableColumnAsString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDataTableColumnAsString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDataTable>.ToNative(IntPtr.Add(intPtr, GetDataTableColumnAsString_DataTable_Offset), 0, GetDataTableColumnAsString_DataTable_PropertyAddress.Address, DataTable);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetDataTableColumnAsString_PropertyName_Offset), 0, GetDataTableColumnAsString_PropertyName_PropertyAddress.Address, PropertyName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetDataTableColumnAsString_FunctionAddress, intPtr, GetDataTableColumnAsString_ParamsSize);
		List<string> result = new TArrayCopyMarshaler<string>(1, GetDataTableColumnAsString_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetDataTableColumnAsString_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetDataTableColumnAsString_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/Engine.DataTableFunctionLibrary:FillDataTableFromJSONString")]
	public unsafe static bool FillDataTableFromJSONString(UDataTable DataTable, string JSONString)
	{
		if (!FillDataTableFromJSONString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.DataTableFunctionLibrary:FillDataTableFromJSONString");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FillDataTableFromJSONString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FillDataTableFromJSONString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDataTable>.ToNative(IntPtr.Add(intPtr, FillDataTableFromJSONString_DataTable_Offset), 0, FillDataTableFromJSONString_DataTable_PropertyAddress.Address, DataTable);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, FillDataTableFromJSONString_JSONString_Offset), 0, FillDataTableFromJSONString_JSONString_PropertyAddress.Address, JSONString);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FillDataTableFromJSONString_FunctionAddress, intPtr, FillDataTableFromJSONString_ParamsSize);
		NativeReflection.DestroyValue_InContainer(FillDataTableFromJSONString_JSONString_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, FillDataTableFromJSONString_ReturnValue_Offset), 0, FillDataTableFromJSONString_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/Engine.DataTableFunctionLibrary:FillDataTableFromJSONFile")]
	public unsafe static bool FillDataTableFromJSONFile(UDataTable DataTable, string JSONFilePath, UScriptStruct ImportRowStruct)
	{
		if (!FillDataTableFromJSONFile_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.DataTableFunctionLibrary:FillDataTableFromJSONFile");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FillDataTableFromJSONFile_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FillDataTableFromJSONFile_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDataTable>.ToNative(IntPtr.Add(intPtr, FillDataTableFromJSONFile_DataTable_Offset), 0, FillDataTableFromJSONFile_DataTable_PropertyAddress.Address, DataTable);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, FillDataTableFromJSONFile_JSONFilePath_Offset), 0, FillDataTableFromJSONFile_JSONFilePath_PropertyAddress.Address, JSONFilePath);
		UObjectMarshaler<UScriptStruct>.ToNative(IntPtr.Add(intPtr, FillDataTableFromJSONFile_ImportRowStruct_Offset), 0, FillDataTableFromJSONFile_ImportRowStruct_PropertyAddress.Address, ImportRowStruct);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FillDataTableFromJSONFile_FunctionAddress, intPtr, FillDataTableFromJSONFile_ParamsSize);
		NativeReflection.DestroyValue_InContainer(FillDataTableFromJSONFile_JSONFilePath_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, FillDataTableFromJSONFile_ReturnValue_Offset), 0, FillDataTableFromJSONFile_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/Engine.DataTableFunctionLibrary:FillDataTableFromCSVString")]
	public unsafe static bool FillDataTableFromCSVString(UDataTable DataTable, string CSVString)
	{
		if (!FillDataTableFromCSVString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.DataTableFunctionLibrary:FillDataTableFromCSVString");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FillDataTableFromCSVString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FillDataTableFromCSVString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDataTable>.ToNative(IntPtr.Add(intPtr, FillDataTableFromCSVString_DataTable_Offset), 0, FillDataTableFromCSVString_DataTable_PropertyAddress.Address, DataTable);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, FillDataTableFromCSVString_CSVString_Offset), 0, FillDataTableFromCSVString_CSVString_PropertyAddress.Address, CSVString);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FillDataTableFromCSVString_FunctionAddress, intPtr, FillDataTableFromCSVString_ParamsSize);
		NativeReflection.DestroyValue_InContainer(FillDataTableFromCSVString_CSVString_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, FillDataTableFromCSVString_ReturnValue_Offset), 0, FillDataTableFromCSVString_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/Engine.DataTableFunctionLibrary:FillDataTableFromCSVFile")]
	public unsafe static bool FillDataTableFromCSVFile(UDataTable DataTable, string CSVFilePath)
	{
		if (!FillDataTableFromCSVFile_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.DataTableFunctionLibrary:FillDataTableFromCSVFile");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FillDataTableFromCSVFile_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FillDataTableFromCSVFile_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDataTable>.ToNative(IntPtr.Add(intPtr, FillDataTableFromCSVFile_DataTable_Offset), 0, FillDataTableFromCSVFile_DataTable_PropertyAddress.Address, DataTable);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, FillDataTableFromCSVFile_CSVFilePath_Offset), 0, FillDataTableFromCSVFile_CSVFilePath_PropertyAddress.Address, CSVFilePath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FillDataTableFromCSVFile_FunctionAddress, intPtr, FillDataTableFromCSVFile_ParamsSize);
		NativeReflection.DestroyValue_InContainer(FillDataTableFromCSVFile_CSVFilePath_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, FillDataTableFromCSVFile_ReturnValue_Offset), 0, FillDataTableFromCSVFile_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.DataTableFunctionLibrary:EvaluateCurveTableRow")]
	public unsafe static void EvaluateCurveTableRow(UCurveTable CurveTable, FName RowName, float InXY, out EEvaluateCurveTableResult OutResult, out float OutXY, string ContextString)
	{
		if (!EvaluateCurveTableRow_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.DataTableFunctionLibrary:EvaluateCurveTableRow");
			OutResult = EEvaluateCurveTableResult.RowFound;
			OutXY = 0f;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EvaluateCurveTableRow_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EvaluateCurveTableRow_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UCurveTable>.ToNative(IntPtr.Add(intPtr, EvaluateCurveTableRow_CurveTable_Offset), 0, EvaluateCurveTableRow_CurveTable_PropertyAddress.Address, CurveTable);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, EvaluateCurveTableRow_RowName_Offset), 0, EvaluateCurveTableRow_RowName_PropertyAddress.Address, RowName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, EvaluateCurveTableRow_InXY_Offset), 0, EvaluateCurveTableRow_InXY_PropertyAddress.Address, InXY);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, EvaluateCurveTableRow_ContextString_Offset), 0, EvaluateCurveTableRow_ContextString_PropertyAddress.Address, ContextString);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, EvaluateCurveTableRow_FunctionAddress, intPtr, EvaluateCurveTableRow_ParamsSize);
		OutResult = EnumMarshaler<EEvaluateCurveTableResult>.FromNative(IntPtr.Add(intPtr, EvaluateCurveTableRow_OutResult_Offset), 0, EvaluateCurveTableRow_OutResult_PropertyAddress.Address);
		OutXY = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, EvaluateCurveTableRow_OutXY_Offset), 0, EvaluateCurveTableRow_OutXY_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(EvaluateCurveTableRow_ContextString_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/Engine.DataTableFunctionLibrary:DoesDataTableRowExist")]
	public unsafe static bool DoesDataTableRowExist(UDataTable Table, FName RowName)
	{
		if (!DoesDataTableRowExist_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.DataTableFunctionLibrary:DoesDataTableRowExist");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DoesDataTableRowExist_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DoesDataTableRowExist_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDataTable>.ToNative(IntPtr.Add(intPtr, DoesDataTableRowExist_Table_Offset), 0, DoesDataTableRowExist_Table_PropertyAddress.Address, Table);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, DoesDataTableRowExist_RowName_Offset), 0, DoesDataTableRowExist_RowName_PropertyAddress.Address, RowName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DoesDataTableRowExist_FunctionAddress, intPtr, DoesDataTableRowExist_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, DoesDataTableRowExist_ReturnValue_Offset), 0, DoesDataTableRowExist_ReturnValue_PropertyAddress.Address);
	}

	static UDataTableFunctionLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UDataTableFunctionLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UDataTableFunctionLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/Engine.DataTableFunctionLibrary");
		GetDataTableRowNames_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetDataTableRowNames");
		GetDataTableRowNames_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDataTableRowNames_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDataTableRowNames_Table_PropertyAddress, GetDataTableRowNames_FunctionAddress, "Table");
		GetDataTableRowNames_Table_Offset = NativeReflectionCached.GetPropertyOffset(GetDataTableRowNames_FunctionAddress, "Table");
		GetDataTableRowNames_Table_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDataTableRowNames_FunctionAddress, "Table", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDataTableRowNames_OutRowNames_PropertyAddress, GetDataTableRowNames_FunctionAddress, "OutRowNames");
		GetDataTableRowNames_OutRowNames_Offset = NativeReflectionCached.GetPropertyOffset(GetDataTableRowNames_FunctionAddress, "OutRowNames");
		GetDataTableRowNames_OutRowNames_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDataTableRowNames_FunctionAddress, "OutRowNames", Classes.FArrayProperty);
		GetDataTableRowNames_IsValid = GetDataTableRowNames_FunctionAddress != IntPtr.Zero && GetDataTableRowNames_Table_IsValid && GetDataTableRowNames_OutRowNames_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.DataTableFunctionLibrary:GetDataTableRowNames", GetDataTableRowNames_IsValid);
		GetDataTableColumnAsString_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetDataTableColumnAsString");
		GetDataTableColumnAsString_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDataTableColumnAsString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDataTableColumnAsString_DataTable_PropertyAddress, GetDataTableColumnAsString_FunctionAddress, "DataTable");
		GetDataTableColumnAsString_DataTable_Offset = NativeReflectionCached.GetPropertyOffset(GetDataTableColumnAsString_FunctionAddress, "DataTable");
		GetDataTableColumnAsString_DataTable_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDataTableColumnAsString_FunctionAddress, "DataTable", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDataTableColumnAsString_PropertyName_PropertyAddress, GetDataTableColumnAsString_FunctionAddress, "PropertyName");
		GetDataTableColumnAsString_PropertyName_Offset = NativeReflectionCached.GetPropertyOffset(GetDataTableColumnAsString_FunctionAddress, "PropertyName");
		GetDataTableColumnAsString_PropertyName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDataTableColumnAsString_FunctionAddress, "PropertyName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDataTableColumnAsString_ReturnValue_PropertyAddress, GetDataTableColumnAsString_FunctionAddress, "ReturnValue");
		GetDataTableColumnAsString_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDataTableColumnAsString_FunctionAddress, "ReturnValue");
		GetDataTableColumnAsString_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDataTableColumnAsString_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetDataTableColumnAsString_IsValid = GetDataTableColumnAsString_FunctionAddress != IntPtr.Zero && GetDataTableColumnAsString_DataTable_IsValid && GetDataTableColumnAsString_PropertyName_IsValid && GetDataTableColumnAsString_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.DataTableFunctionLibrary:GetDataTableColumnAsString", GetDataTableColumnAsString_IsValid);
		FillDataTableFromJSONString_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FillDataTableFromJSONString");
		FillDataTableFromJSONString_ParamsSize = NativeReflection.GetFunctionParamsSize(FillDataTableFromJSONString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FillDataTableFromJSONString_DataTable_PropertyAddress, FillDataTableFromJSONString_FunctionAddress, "DataTable");
		FillDataTableFromJSONString_DataTable_Offset = NativeReflectionCached.GetPropertyOffset(FillDataTableFromJSONString_FunctionAddress, "DataTable");
		FillDataTableFromJSONString_DataTable_IsValid = NativeReflectionCached.ValidatePropertyClass(FillDataTableFromJSONString_FunctionAddress, "DataTable", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FillDataTableFromJSONString_JSONString_PropertyAddress, FillDataTableFromJSONString_FunctionAddress, "JSONString");
		FillDataTableFromJSONString_JSONString_Offset = NativeReflectionCached.GetPropertyOffset(FillDataTableFromJSONString_FunctionAddress, "JSONString");
		FillDataTableFromJSONString_JSONString_IsValid = NativeReflectionCached.ValidatePropertyClass(FillDataTableFromJSONString_FunctionAddress, "JSONString", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref FillDataTableFromJSONString_ReturnValue_PropertyAddress, FillDataTableFromJSONString_FunctionAddress, "ReturnValue");
		FillDataTableFromJSONString_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FillDataTableFromJSONString_FunctionAddress, "ReturnValue");
		FillDataTableFromJSONString_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FillDataTableFromJSONString_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		FillDataTableFromJSONString_IsValid = FillDataTableFromJSONString_FunctionAddress != IntPtr.Zero && FillDataTableFromJSONString_DataTable_IsValid && FillDataTableFromJSONString_JSONString_IsValid && FillDataTableFromJSONString_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.DataTableFunctionLibrary:FillDataTableFromJSONString", FillDataTableFromJSONString_IsValid);
		FillDataTableFromJSONFile_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FillDataTableFromJSONFile");
		FillDataTableFromJSONFile_ParamsSize = NativeReflection.GetFunctionParamsSize(FillDataTableFromJSONFile_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FillDataTableFromJSONFile_DataTable_PropertyAddress, FillDataTableFromJSONFile_FunctionAddress, "DataTable");
		FillDataTableFromJSONFile_DataTable_Offset = NativeReflectionCached.GetPropertyOffset(FillDataTableFromJSONFile_FunctionAddress, "DataTable");
		FillDataTableFromJSONFile_DataTable_IsValid = NativeReflectionCached.ValidatePropertyClass(FillDataTableFromJSONFile_FunctionAddress, "DataTable", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FillDataTableFromJSONFile_JSONFilePath_PropertyAddress, FillDataTableFromJSONFile_FunctionAddress, "JSONFilePath");
		FillDataTableFromJSONFile_JSONFilePath_Offset = NativeReflectionCached.GetPropertyOffset(FillDataTableFromJSONFile_FunctionAddress, "JSONFilePath");
		FillDataTableFromJSONFile_JSONFilePath_IsValid = NativeReflectionCached.ValidatePropertyClass(FillDataTableFromJSONFile_FunctionAddress, "JSONFilePath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref FillDataTableFromJSONFile_ImportRowStruct_PropertyAddress, FillDataTableFromJSONFile_FunctionAddress, "ImportRowStruct");
		FillDataTableFromJSONFile_ImportRowStruct_Offset = NativeReflectionCached.GetPropertyOffset(FillDataTableFromJSONFile_FunctionAddress, "ImportRowStruct");
		FillDataTableFromJSONFile_ImportRowStruct_IsValid = NativeReflectionCached.ValidatePropertyClass(FillDataTableFromJSONFile_FunctionAddress, "ImportRowStruct", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FillDataTableFromJSONFile_ReturnValue_PropertyAddress, FillDataTableFromJSONFile_FunctionAddress, "ReturnValue");
		FillDataTableFromJSONFile_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FillDataTableFromJSONFile_FunctionAddress, "ReturnValue");
		FillDataTableFromJSONFile_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FillDataTableFromJSONFile_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		FillDataTableFromJSONFile_IsValid = FillDataTableFromJSONFile_FunctionAddress != IntPtr.Zero && FillDataTableFromJSONFile_DataTable_IsValid && FillDataTableFromJSONFile_JSONFilePath_IsValid && FillDataTableFromJSONFile_ImportRowStruct_IsValid && FillDataTableFromJSONFile_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.DataTableFunctionLibrary:FillDataTableFromJSONFile", FillDataTableFromJSONFile_IsValid);
		FillDataTableFromCSVString_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FillDataTableFromCSVString");
		FillDataTableFromCSVString_ParamsSize = NativeReflection.GetFunctionParamsSize(FillDataTableFromCSVString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FillDataTableFromCSVString_DataTable_PropertyAddress, FillDataTableFromCSVString_FunctionAddress, "DataTable");
		FillDataTableFromCSVString_DataTable_Offset = NativeReflectionCached.GetPropertyOffset(FillDataTableFromCSVString_FunctionAddress, "DataTable");
		FillDataTableFromCSVString_DataTable_IsValid = NativeReflectionCached.ValidatePropertyClass(FillDataTableFromCSVString_FunctionAddress, "DataTable", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FillDataTableFromCSVString_CSVString_PropertyAddress, FillDataTableFromCSVString_FunctionAddress, "CSVString");
		FillDataTableFromCSVString_CSVString_Offset = NativeReflectionCached.GetPropertyOffset(FillDataTableFromCSVString_FunctionAddress, "CSVString");
		FillDataTableFromCSVString_CSVString_IsValid = NativeReflectionCached.ValidatePropertyClass(FillDataTableFromCSVString_FunctionAddress, "CSVString", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref FillDataTableFromCSVString_ReturnValue_PropertyAddress, FillDataTableFromCSVString_FunctionAddress, "ReturnValue");
		FillDataTableFromCSVString_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FillDataTableFromCSVString_FunctionAddress, "ReturnValue");
		FillDataTableFromCSVString_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FillDataTableFromCSVString_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		FillDataTableFromCSVString_IsValid = FillDataTableFromCSVString_FunctionAddress != IntPtr.Zero && FillDataTableFromCSVString_DataTable_IsValid && FillDataTableFromCSVString_CSVString_IsValid && FillDataTableFromCSVString_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.DataTableFunctionLibrary:FillDataTableFromCSVString", FillDataTableFromCSVString_IsValid);
		FillDataTableFromCSVFile_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FillDataTableFromCSVFile");
		FillDataTableFromCSVFile_ParamsSize = NativeReflection.GetFunctionParamsSize(FillDataTableFromCSVFile_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FillDataTableFromCSVFile_DataTable_PropertyAddress, FillDataTableFromCSVFile_FunctionAddress, "DataTable");
		FillDataTableFromCSVFile_DataTable_Offset = NativeReflectionCached.GetPropertyOffset(FillDataTableFromCSVFile_FunctionAddress, "DataTable");
		FillDataTableFromCSVFile_DataTable_IsValid = NativeReflectionCached.ValidatePropertyClass(FillDataTableFromCSVFile_FunctionAddress, "DataTable", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FillDataTableFromCSVFile_CSVFilePath_PropertyAddress, FillDataTableFromCSVFile_FunctionAddress, "CSVFilePath");
		FillDataTableFromCSVFile_CSVFilePath_Offset = NativeReflectionCached.GetPropertyOffset(FillDataTableFromCSVFile_FunctionAddress, "CSVFilePath");
		FillDataTableFromCSVFile_CSVFilePath_IsValid = NativeReflectionCached.ValidatePropertyClass(FillDataTableFromCSVFile_FunctionAddress, "CSVFilePath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref FillDataTableFromCSVFile_ReturnValue_PropertyAddress, FillDataTableFromCSVFile_FunctionAddress, "ReturnValue");
		FillDataTableFromCSVFile_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FillDataTableFromCSVFile_FunctionAddress, "ReturnValue");
		FillDataTableFromCSVFile_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FillDataTableFromCSVFile_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		FillDataTableFromCSVFile_IsValid = FillDataTableFromCSVFile_FunctionAddress != IntPtr.Zero && FillDataTableFromCSVFile_DataTable_IsValid && FillDataTableFromCSVFile_CSVFilePath_IsValid && FillDataTableFromCSVFile_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.DataTableFunctionLibrary:FillDataTableFromCSVFile", FillDataTableFromCSVFile_IsValid);
		EvaluateCurveTableRow_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "EvaluateCurveTableRow");
		EvaluateCurveTableRow_ParamsSize = NativeReflection.GetFunctionParamsSize(EvaluateCurveTableRow_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EvaluateCurveTableRow_CurveTable_PropertyAddress, EvaluateCurveTableRow_FunctionAddress, "CurveTable");
		EvaluateCurveTableRow_CurveTable_Offset = NativeReflectionCached.GetPropertyOffset(EvaluateCurveTableRow_FunctionAddress, "CurveTable");
		EvaluateCurveTableRow_CurveTable_IsValid = NativeReflectionCached.ValidatePropertyClass(EvaluateCurveTableRow_FunctionAddress, "CurveTable", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref EvaluateCurveTableRow_RowName_PropertyAddress, EvaluateCurveTableRow_FunctionAddress, "RowName");
		EvaluateCurveTableRow_RowName_Offset = NativeReflectionCached.GetPropertyOffset(EvaluateCurveTableRow_FunctionAddress, "RowName");
		EvaluateCurveTableRow_RowName_IsValid = NativeReflectionCached.ValidatePropertyClass(EvaluateCurveTableRow_FunctionAddress, "RowName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref EvaluateCurveTableRow_InXY_PropertyAddress, EvaluateCurveTableRow_FunctionAddress, "InXY");
		EvaluateCurveTableRow_InXY_Offset = NativeReflectionCached.GetPropertyOffset(EvaluateCurveTableRow_FunctionAddress, "InXY");
		EvaluateCurveTableRow_InXY_IsValid = NativeReflectionCached.ValidatePropertyClass(EvaluateCurveTableRow_FunctionAddress, "InXY", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref EvaluateCurveTableRow_OutResult_PropertyAddress, EvaluateCurveTableRow_FunctionAddress, "OutResult");
		EvaluateCurveTableRow_OutResult_Offset = NativeReflectionCached.GetPropertyOffset(EvaluateCurveTableRow_FunctionAddress, "OutResult");
		EvaluateCurveTableRow_OutResult_IsValid = NativeReflectionCached.ValidatePropertyClass(EvaluateCurveTableRow_FunctionAddress, "OutResult", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref EvaluateCurveTableRow_OutXY_PropertyAddress, EvaluateCurveTableRow_FunctionAddress, "OutXY");
		EvaluateCurveTableRow_OutXY_Offset = NativeReflectionCached.GetPropertyOffset(EvaluateCurveTableRow_FunctionAddress, "OutXY");
		EvaluateCurveTableRow_OutXY_IsValid = NativeReflectionCached.ValidatePropertyClass(EvaluateCurveTableRow_FunctionAddress, "OutXY", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref EvaluateCurveTableRow_ContextString_PropertyAddress, EvaluateCurveTableRow_FunctionAddress, "ContextString");
		EvaluateCurveTableRow_ContextString_Offset = NativeReflectionCached.GetPropertyOffset(EvaluateCurveTableRow_FunctionAddress, "ContextString");
		EvaluateCurveTableRow_ContextString_IsValid = NativeReflectionCached.ValidatePropertyClass(EvaluateCurveTableRow_FunctionAddress, "ContextString", Classes.FStrProperty);
		EvaluateCurveTableRow_IsValid = EvaluateCurveTableRow_FunctionAddress != IntPtr.Zero && EvaluateCurveTableRow_CurveTable_IsValid && EvaluateCurveTableRow_RowName_IsValid && EvaluateCurveTableRow_InXY_IsValid && EvaluateCurveTableRow_OutResult_IsValid && EvaluateCurveTableRow_OutXY_IsValid && EvaluateCurveTableRow_ContextString_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.DataTableFunctionLibrary:EvaluateCurveTableRow", EvaluateCurveTableRow_IsValid);
		DoesDataTableRowExist_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DoesDataTableRowExist");
		DoesDataTableRowExist_ParamsSize = NativeReflection.GetFunctionParamsSize(DoesDataTableRowExist_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DoesDataTableRowExist_Table_PropertyAddress, DoesDataTableRowExist_FunctionAddress, "Table");
		DoesDataTableRowExist_Table_Offset = NativeReflectionCached.GetPropertyOffset(DoesDataTableRowExist_FunctionAddress, "Table");
		DoesDataTableRowExist_Table_IsValid = NativeReflectionCached.ValidatePropertyClass(DoesDataTableRowExist_FunctionAddress, "Table", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DoesDataTableRowExist_RowName_PropertyAddress, DoesDataTableRowExist_FunctionAddress, "RowName");
		DoesDataTableRowExist_RowName_Offset = NativeReflectionCached.GetPropertyOffset(DoesDataTableRowExist_FunctionAddress, "RowName");
		DoesDataTableRowExist_RowName_IsValid = NativeReflectionCached.ValidatePropertyClass(DoesDataTableRowExist_FunctionAddress, "RowName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref DoesDataTableRowExist_ReturnValue_PropertyAddress, DoesDataTableRowExist_FunctionAddress, "ReturnValue");
		DoesDataTableRowExist_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DoesDataTableRowExist_FunctionAddress, "ReturnValue");
		DoesDataTableRowExist_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DoesDataTableRowExist_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		DoesDataTableRowExist_IsValid = DoesDataTableRowExist_FunctionAddress != IntPtr.Zero && DoesDataTableRowExist_Table_IsValid && DoesDataTableRowExist_RowName_IsValid && DoesDataTableRowExist_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.DataTableFunctionLibrary:DoesDataTableRowExist", DoesDataTableRowExist_IsValid);
	}
}
