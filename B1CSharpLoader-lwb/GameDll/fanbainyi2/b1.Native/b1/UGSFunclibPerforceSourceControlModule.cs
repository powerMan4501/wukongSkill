using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.SourceControl;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/FuncLibEditor.GSFunclibPerforceSourceControlModule", "FuncLibEditor", UnrealModuleType.Game)]
public class UGSFunclibPerforceSourceControlModule : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool RevertFile_IsValid;

	private static IntPtr RevertFile_FunctionAddress;

	private static int RevertFile_ParamsSize;

	private static bool RevertFile_InFile_IsValid;

	private static FFieldAddress RevertFile_InFile_PropertyAddress;

	private static int RevertFile_InFile_Offset;

	private static bool RevertFile_bSilent_IsValid;

	private static FFieldAddress RevertFile_bSilent_PropertyAddress;

	private static int RevertFile_bSilent_Offset;

	private static bool RevertFile_ReturnValue_IsValid;

	private static FFieldAddress RevertFile_ReturnValue_PropertyAddress;

	private static int RevertFile_ReturnValue_Offset;

	private static bool QueryFileState_IsValid;

	private static IntPtr QueryFileState_FunctionAddress;

	private static int QueryFileState_ParamsSize;

	private static bool QueryFileState_inState_IsValid;

	private static FFieldAddress QueryFileState_inState_PropertyAddress;

	private static int QueryFileState_inState_Offset;

	private static bool QueryFileState_InFile_IsValid;

	private static FFieldAddress QueryFileState_InFile_PropertyAddress;

	private static int QueryFileState_InFile_Offset;

	private static bool QueryFileState_bSilent_IsValid;

	private static FFieldAddress QueryFileState_bSilent_PropertyAddress;

	private static int QueryFileState_bSilent_Offset;

	private static bool QueryFileState_ReturnValue_IsValid;

	private static FFieldAddress QueryFileState_ReturnValue_PropertyAddress;

	private static int QueryFileState_ReturnValue_Offset;

	private static bool MarkFileForAdd_IsValid;

	private static IntPtr MarkFileForAdd_FunctionAddress;

	private static int MarkFileForAdd_ParamsSize;

	private static bool MarkFileForAdd_InFile_IsValid;

	private static FFieldAddress MarkFileForAdd_InFile_PropertyAddress;

	private static int MarkFileForAdd_InFile_Offset;

	private static bool MarkFileForAdd_bSilent_IsValid;

	private static FFieldAddress MarkFileForAdd_bSilent_PropertyAddress;

	private static int MarkFileForAdd_bSilent_Offset;

	private static bool MarkFileForAdd_ReturnValue_IsValid;

	private static FFieldAddress MarkFileForAdd_ReturnValue_PropertyAddress;

	private static int MarkFileForAdd_ReturnValue_Offset;

	private static bool IsSourceControlEnabled_IsValid;

	private static IntPtr IsSourceControlEnabled_FunctionAddress;

	private static int IsSourceControlEnabled_ParamsSize;

	private static bool IsSourceControlEnabled_ReturnValue_IsValid;

	private static FFieldAddress IsSourceControlEnabled_ReturnValue_PropertyAddress;

	private static int IsSourceControlEnabled_ReturnValue_Offset;

	private static bool GetSettingsIni_IsValid;

	private static IntPtr GetSettingsIni_FunctionAddress;

	private static int GetSettingsIni_ParamsSize;

	private static bool GetSettingsIni_ReturnValue_IsValid;

	private static FFieldAddress GetSettingsIni_ReturnValue_PropertyAddress;

	private static int GetSettingsIni_ReturnValue_Offset;

	private static bool GetLatestRevision_IsValid;

	private static IntPtr GetLatestRevision_FunctionAddress;

	private static int GetLatestRevision_ParamsSize;

	private static bool GetLatestRevision_filePath_IsValid;

	private static FFieldAddress GetLatestRevision_filePath_PropertyAddress;

	private static int GetLatestRevision_filePath_Offset;

	private static bool GetLatestRevision_IsForced_IsValid;

	private static FFieldAddress GetLatestRevision_IsForced_PropertyAddress;

	private static int GetLatestRevision_IsForced_Offset;

	private static bool CheckOutOrAddFile_IsValid;

	private static IntPtr CheckOutOrAddFile_FunctionAddress;

	private static int CheckOutOrAddFile_ParamsSize;

	private static bool CheckOutOrAddFile_InFile_IsValid;

	private static FFieldAddress CheckOutOrAddFile_InFile_PropertyAddress;

	private static int CheckOutOrAddFile_InFile_Offset;

	private static bool CheckOutOrAddFile_bSilent_IsValid;

	private static FFieldAddress CheckOutOrAddFile_bSilent_PropertyAddress;

	private static int CheckOutOrAddFile_bSilent_Offset;

	private static bool CheckOutOrAddFile_ReturnValue_IsValid;

	private static FFieldAddress CheckOutOrAddFile_ReturnValue_PropertyAddress;

	private static int CheckOutOrAddFile_ReturnValue_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFunclibPerforceSourceControlModule:RevertFile")]
	public unsafe static bool RevertFile(string InFile, bool bSilent = false)
	{
		if (!RevertFile_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFunclibPerforceSourceControlModule:RevertFile");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RevertFile_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RevertFile_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, RevertFile_InFile_Offset), 0, RevertFile_InFile_PropertyAddress.Address, InFile);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RevertFile_bSilent_Offset), 0, RevertFile_bSilent_PropertyAddress.Address, bSilent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RevertFile_FunctionAddress, intPtr, RevertFile_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RevertFile_InFile_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RevertFile_ReturnValue_Offset), 0, RevertFile_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/FuncLibEditor.GSFunclibPerforceSourceControlModule:QueryFileState")]
	public unsafe static bool QueryFileState(out FSourceControlState inState, string InFile, bool bSilent = false)
	{
		if (!QueryFileState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFunclibPerforceSourceControlModule:QueryFileState");
			inState = default(FSourceControlState);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(QueryFileState_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)QueryFileState_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(QueryFileState_inState_PropertyAddress.Address, intPtr);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, QueryFileState_InFile_Offset), 0, QueryFileState_InFile_PropertyAddress.Address, InFile);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, QueryFileState_bSilent_Offset), 0, QueryFileState_bSilent_PropertyAddress.Address, bSilent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, QueryFileState_FunctionAddress, intPtr, QueryFileState_ParamsSize);
		inState = FSourceControlState.FromNative(IntPtr.Add(intPtr, QueryFileState_inState_Offset), 0, QueryFileState_inState_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(QueryFileState_inState_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(QueryFileState_InFile_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, QueryFileState_ReturnValue_Offset), 0, QueryFileState_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFunclibPerforceSourceControlModule:MarkFileForAdd")]
	public unsafe static bool MarkFileForAdd(string InFile, bool bSilent = false)
	{
		if (!MarkFileForAdd_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFunclibPerforceSourceControlModule:MarkFileForAdd");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MarkFileForAdd_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MarkFileForAdd_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, MarkFileForAdd_InFile_Offset), 0, MarkFileForAdd_InFile_PropertyAddress.Address, InFile);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, MarkFileForAdd_bSilent_Offset), 0, MarkFileForAdd_bSilent_PropertyAddress.Address, bSilent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MarkFileForAdd_FunctionAddress, intPtr, MarkFileForAdd_ParamsSize);
		NativeReflection.DestroyValue_InContainer(MarkFileForAdd_InFile_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, MarkFileForAdd_ReturnValue_Offset), 0, MarkFileForAdd_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFunclibPerforceSourceControlModule:IsSourceControlEnabled")]
	public unsafe static bool IsSourceControlEnabled()
	{
		if (!IsSourceControlEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFunclibPerforceSourceControlModule:IsSourceControlEnabled");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsSourceControlEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsSourceControlEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsSourceControlEnabled_FunctionAddress, intPtr, IsSourceControlEnabled_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsSourceControlEnabled_ReturnValue_Offset), 0, IsSourceControlEnabled_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFunclibPerforceSourceControlModule:GetSettingsIni")]
	public unsafe static string GetSettingsIni()
	{
		if (!GetSettingsIni_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFunclibPerforceSourceControlModule:GetSettingsIni");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSettingsIni_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSettingsIni_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSettingsIni_FunctionAddress, intPtr, GetSettingsIni_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetSettingsIni_ReturnValue_Offset), 0, GetSettingsIni_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetSettingsIni_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFunclibPerforceSourceControlModule:GetLatestRevision")]
	public unsafe static void GetLatestRevision(string filePath, bool IsForced = false)
	{
		if (!GetLatestRevision_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFunclibPerforceSourceControlModule:GetLatestRevision");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLatestRevision_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLatestRevision_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetLatestRevision_filePath_Offset), 0, GetLatestRevision_filePath_PropertyAddress.Address, filePath);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetLatestRevision_IsForced_Offset), 0, GetLatestRevision_IsForced_PropertyAddress.Address, IsForced);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLatestRevision_FunctionAddress, intPtr, GetLatestRevision_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetLatestRevision_filePath_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFunclibPerforceSourceControlModule:CheckOutOrAddFile")]
	public unsafe static bool CheckOutOrAddFile(string InFile, bool bSilent = false)
	{
		if (!CheckOutOrAddFile_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFunclibPerforceSourceControlModule:CheckOutOrAddFile");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CheckOutOrAddFile_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CheckOutOrAddFile_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CheckOutOrAddFile_InFile_Offset), 0, CheckOutOrAddFile_InFile_PropertyAddress.Address, InFile);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CheckOutOrAddFile_bSilent_Offset), 0, CheckOutOrAddFile_bSilent_PropertyAddress.Address, bSilent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CheckOutOrAddFile_FunctionAddress, intPtr, CheckOutOrAddFile_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CheckOutOrAddFile_InFile_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CheckOutOrAddFile_ReturnValue_Offset), 0, CheckOutOrAddFile_ReturnValue_PropertyAddress.Address);
	}

	static UGSFunclibPerforceSourceControlModule()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSFunclibPerforceSourceControlModule)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSFunclibPerforceSourceControlModule));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/FuncLibEditor.GSFunclibPerforceSourceControlModule");
		RevertFile_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RevertFile");
		RevertFile_ParamsSize = NativeReflection.GetFunctionParamsSize(RevertFile_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RevertFile_InFile_PropertyAddress, RevertFile_FunctionAddress, "InFile");
		RevertFile_InFile_Offset = NativeReflectionCached.GetPropertyOffset(RevertFile_FunctionAddress, "InFile");
		RevertFile_InFile_IsValid = NativeReflectionCached.ValidatePropertyClass(RevertFile_FunctionAddress, "InFile", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref RevertFile_bSilent_PropertyAddress, RevertFile_FunctionAddress, "bSilent");
		RevertFile_bSilent_Offset = NativeReflectionCached.GetPropertyOffset(RevertFile_FunctionAddress, "bSilent");
		RevertFile_bSilent_IsValid = NativeReflectionCached.ValidatePropertyClass(RevertFile_FunctionAddress, "bSilent", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RevertFile_ReturnValue_PropertyAddress, RevertFile_FunctionAddress, "ReturnValue");
		RevertFile_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RevertFile_FunctionAddress, "ReturnValue");
		RevertFile_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RevertFile_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RevertFile_IsValid = RevertFile_FunctionAddress != IntPtr.Zero && RevertFile_InFile_IsValid && RevertFile_bSilent_IsValid && RevertFile_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFunclibPerforceSourceControlModule:RevertFile", RevertFile_IsValid);
		QueryFileState_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "QueryFileState");
		QueryFileState_ParamsSize = NativeReflection.GetFunctionParamsSize(QueryFileState_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref QueryFileState_inState_PropertyAddress, QueryFileState_FunctionAddress, "inState");
		QueryFileState_inState_Offset = NativeReflectionCached.GetPropertyOffset(QueryFileState_FunctionAddress, "inState");
		QueryFileState_inState_IsValid = NativeReflectionCached.ValidatePropertyClass(QueryFileState_FunctionAddress, "inState", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref QueryFileState_InFile_PropertyAddress, QueryFileState_FunctionAddress, "InFile");
		QueryFileState_InFile_Offset = NativeReflectionCached.GetPropertyOffset(QueryFileState_FunctionAddress, "InFile");
		QueryFileState_InFile_IsValid = NativeReflectionCached.ValidatePropertyClass(QueryFileState_FunctionAddress, "InFile", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref QueryFileState_bSilent_PropertyAddress, QueryFileState_FunctionAddress, "bSilent");
		QueryFileState_bSilent_Offset = NativeReflectionCached.GetPropertyOffset(QueryFileState_FunctionAddress, "bSilent");
		QueryFileState_bSilent_IsValid = NativeReflectionCached.ValidatePropertyClass(QueryFileState_FunctionAddress, "bSilent", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref QueryFileState_ReturnValue_PropertyAddress, QueryFileState_FunctionAddress, "ReturnValue");
		QueryFileState_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(QueryFileState_FunctionAddress, "ReturnValue");
		QueryFileState_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(QueryFileState_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		QueryFileState_IsValid = QueryFileState_FunctionAddress != IntPtr.Zero && QueryFileState_inState_IsValid && QueryFileState_InFile_IsValid && QueryFileState_bSilent_IsValid && QueryFileState_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFunclibPerforceSourceControlModule:QueryFileState", QueryFileState_IsValid);
		MarkFileForAdd_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MarkFileForAdd");
		MarkFileForAdd_ParamsSize = NativeReflection.GetFunctionParamsSize(MarkFileForAdd_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MarkFileForAdd_InFile_PropertyAddress, MarkFileForAdd_FunctionAddress, "InFile");
		MarkFileForAdd_InFile_Offset = NativeReflectionCached.GetPropertyOffset(MarkFileForAdd_FunctionAddress, "InFile");
		MarkFileForAdd_InFile_IsValid = NativeReflectionCached.ValidatePropertyClass(MarkFileForAdd_FunctionAddress, "InFile", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref MarkFileForAdd_bSilent_PropertyAddress, MarkFileForAdd_FunctionAddress, "bSilent");
		MarkFileForAdd_bSilent_Offset = NativeReflectionCached.GetPropertyOffset(MarkFileForAdd_FunctionAddress, "bSilent");
		MarkFileForAdd_bSilent_IsValid = NativeReflectionCached.ValidatePropertyClass(MarkFileForAdd_FunctionAddress, "bSilent", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref MarkFileForAdd_ReturnValue_PropertyAddress, MarkFileForAdd_FunctionAddress, "ReturnValue");
		MarkFileForAdd_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MarkFileForAdd_FunctionAddress, "ReturnValue");
		MarkFileForAdd_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MarkFileForAdd_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		MarkFileForAdd_IsValid = MarkFileForAdd_FunctionAddress != IntPtr.Zero && MarkFileForAdd_InFile_IsValid && MarkFileForAdd_bSilent_IsValid && MarkFileForAdd_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFunclibPerforceSourceControlModule:MarkFileForAdd", MarkFileForAdd_IsValid);
		IsSourceControlEnabled_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsSourceControlEnabled");
		IsSourceControlEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(IsSourceControlEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsSourceControlEnabled_ReturnValue_PropertyAddress, IsSourceControlEnabled_FunctionAddress, "ReturnValue");
		IsSourceControlEnabled_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsSourceControlEnabled_FunctionAddress, "ReturnValue");
		IsSourceControlEnabled_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsSourceControlEnabled_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsSourceControlEnabled_IsValid = IsSourceControlEnabled_FunctionAddress != IntPtr.Zero && IsSourceControlEnabled_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFunclibPerforceSourceControlModule:IsSourceControlEnabled", IsSourceControlEnabled_IsValid);
		GetSettingsIni_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSettingsIni");
		GetSettingsIni_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSettingsIni_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSettingsIni_ReturnValue_PropertyAddress, GetSettingsIni_FunctionAddress, "ReturnValue");
		GetSettingsIni_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSettingsIni_FunctionAddress, "ReturnValue");
		GetSettingsIni_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSettingsIni_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetSettingsIni_IsValid = GetSettingsIni_FunctionAddress != IntPtr.Zero && GetSettingsIni_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFunclibPerforceSourceControlModule:GetSettingsIni", GetSettingsIni_IsValid);
		GetLatestRevision_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLatestRevision");
		GetLatestRevision_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLatestRevision_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLatestRevision_filePath_PropertyAddress, GetLatestRevision_FunctionAddress, "filePath");
		GetLatestRevision_filePath_Offset = NativeReflectionCached.GetPropertyOffset(GetLatestRevision_FunctionAddress, "filePath");
		GetLatestRevision_filePath_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLatestRevision_FunctionAddress, "filePath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLatestRevision_IsForced_PropertyAddress, GetLatestRevision_FunctionAddress, "IsForced");
		GetLatestRevision_IsForced_Offset = NativeReflectionCached.GetPropertyOffset(GetLatestRevision_FunctionAddress, "IsForced");
		GetLatestRevision_IsForced_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLatestRevision_FunctionAddress, "IsForced", Classes.FBoolProperty);
		GetLatestRevision_IsValid = GetLatestRevision_FunctionAddress != IntPtr.Zero && GetLatestRevision_filePath_IsValid && GetLatestRevision_IsForced_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFunclibPerforceSourceControlModule:GetLatestRevision", GetLatestRevision_IsValid);
		CheckOutOrAddFile_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CheckOutOrAddFile");
		CheckOutOrAddFile_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckOutOrAddFile_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CheckOutOrAddFile_InFile_PropertyAddress, CheckOutOrAddFile_FunctionAddress, "InFile");
		CheckOutOrAddFile_InFile_Offset = NativeReflectionCached.GetPropertyOffset(CheckOutOrAddFile_FunctionAddress, "InFile");
		CheckOutOrAddFile_InFile_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckOutOrAddFile_FunctionAddress, "InFile", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CheckOutOrAddFile_bSilent_PropertyAddress, CheckOutOrAddFile_FunctionAddress, "bSilent");
		CheckOutOrAddFile_bSilent_Offset = NativeReflectionCached.GetPropertyOffset(CheckOutOrAddFile_FunctionAddress, "bSilent");
		CheckOutOrAddFile_bSilent_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckOutOrAddFile_FunctionAddress, "bSilent", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CheckOutOrAddFile_ReturnValue_PropertyAddress, CheckOutOrAddFile_FunctionAddress, "ReturnValue");
		CheckOutOrAddFile_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CheckOutOrAddFile_FunctionAddress, "ReturnValue");
		CheckOutOrAddFile_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckOutOrAddFile_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CheckOutOrAddFile_IsValid = CheckOutOrAddFile_FunctionAddress != IntPtr.Zero && CheckOutOrAddFile_InFile_IsValid && CheckOutOrAddFile_bSilent_IsValid && CheckOutOrAddFile_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFunclibPerforceSourceControlModule:CheckOutOrAddFile", CheckOutOrAddFile_IsValid);
	}
}
