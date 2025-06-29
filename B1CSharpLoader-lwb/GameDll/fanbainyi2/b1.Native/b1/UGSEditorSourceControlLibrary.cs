using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/FuncLibEditor.GSEditorSourceControlLibrary", "FuncLibEditor", UnrealModuleType.Game)]
public class UGSEditorSourceControlLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool GetStatusText_IsValid;

	private static IntPtr GetStatusText_FunctionAddress;

	private static int GetStatusText_ParamsSize;

	private static bool GetStatusText_ReturnValue_IsValid;

	private static FFieldAddress GetStatusText_ReturnValue_PropertyAddress;

	private static int GetStatusText_ReturnValue_Offset;

	private static bool GetScourceControlInfo_IsValid;

	private static IntPtr GetScourceControlInfo_FunctionAddress;

	private static int GetScourceControlInfo_ParamsSize;

	private static bool GetScourceControlInfo_InPackageNames_IsValid;

	private static FFieldAddress GetScourceControlInfo_InPackageNames_PropertyAddress;

	private static int GetScourceControlInfo_InPackageNames_Offset;

	private static bool GetScourceControlInfo_ReturnValue_IsValid;

	private static FFieldAddress GetScourceControlInfo_ReturnValue_PropertyAddress;

	private static int GetScourceControlInfo_ReturnValue_Offset;

	private static bool GetLatestSubmitDate_IsValid;

	private static IntPtr GetLatestSubmitDate_FunctionAddress;

	private static int GetLatestSubmitDate_ParamsSize;

	private static bool GetLatestSubmitDate_InPackageName_IsValid;

	private static FFieldAddress GetLatestSubmitDate_InPackageName_PropertyAddress;

	private static int GetLatestSubmitDate_InPackageName_Offset;

	private static bool GetLatestSubmitDate_ReturnValue_IsValid;

	private static FFieldAddress GetLatestSubmitDate_ReturnValue_PropertyAddress;

	private static int GetLatestSubmitDate_ReturnValue_Offset;

	private static bool GetFirstSubmitUsers_IsValid;

	private static IntPtr GetFirstSubmitUsers_FunctionAddress;

	private static int GetFirstSubmitUsers_ParamsSize;

	private static bool GetFirstSubmitUsers_InPackageNames_IsValid;

	private static FFieldAddress GetFirstSubmitUsers_InPackageNames_PropertyAddress;

	private static int GetFirstSubmitUsers_InPackageNames_Offset;

	private static bool GetFirstSubmitUsers_ReturnValue_IsValid;

	private static FFieldAddress GetFirstSubmitUsers_ReturnValue_PropertyAddress;

	private static int GetFirstSubmitUsers_ReturnValue_Offset;

	private static bool GetFirstSubmitUser_IsValid;

	private static IntPtr GetFirstSubmitUser_FunctionAddress;

	private static int GetFirstSubmitUser_ParamsSize;

	private static bool GetFirstSubmitUser_PackageName_IsValid;

	private static FFieldAddress GetFirstSubmitUser_PackageName_PropertyAddress;

	private static int GetFirstSubmitUser_PackageName_Offset;

	private static bool GetFirstSubmitUser_ReturnValue_IsValid;

	private static FFieldAddress GetFirstSubmitUser_ReturnValue_PropertyAddress;

	private static int GetFirstSubmitUser_ReturnValue_Offset;

	private static bool GetAssetDataFromPackage_IsValid;

	private static IntPtr GetAssetDataFromPackage_FunctionAddress;

	private static int GetAssetDataFromPackage_ParamsSize;

	private static bool GetAssetDataFromPackage_PackageName_IsValid;

	private static FFieldAddress GetAssetDataFromPackage_PackageName_PropertyAddress;

	private static int GetAssetDataFromPackage_PackageName_Offset;

	private static bool GetAssetDataFromPackage_ReturnValue_IsValid;

	private static FFieldAddress GetAssetDataFromPackage_ReturnValue_PropertyAddress;

	private static int GetAssetDataFromPackage_ReturnValue_Offset;

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorSourceControlLibrary:GetStatusText")]
	public unsafe static string GetStatusText()
	{
		if (!GetStatusText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorSourceControlLibrary:GetStatusText");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetStatusText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetStatusText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetStatusText_FunctionAddress, intPtr, GetStatusText_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetStatusText_ReturnValue_Offset), 0, GetStatusText_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetStatusText_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71574529u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorSourceControlLibrary:GetScourceControlInfo")]
	public unsafe static List<FSourceControlInfo> GetScourceControlInfo(List<string> InPackageNames)
	{
		if (!GetScourceControlInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorSourceControlLibrary:GetScourceControlInfo");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetScourceControlInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetScourceControlInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<string>(1, GetScourceControlInfo_InPackageNames_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, GetScourceControlInfo_InPackageNames_Offset), InPackageNames);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetScourceControlInfo_FunctionAddress, intPtr, GetScourceControlInfo_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetScourceControlInfo_InPackageNames_PropertyAddress.Address, intPtr);
		List<FSourceControlInfo> result = new TArrayCopyMarshaler<FSourceControlInfo>(1, GetScourceControlInfo_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FSourceControlInfo, FSourceControlInfo>.FromNative, CachedMarshalingDelegates<FSourceControlInfo, FSourceControlInfo>.ToNative).FromNative(IntPtr.Add(intPtr, GetScourceControlInfo_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetScourceControlInfo_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorSourceControlLibrary:GetLatestSubmitDate")]
	public unsafe static string GetLatestSubmitDate(string InPackageName)
	{
		if (!GetLatestSubmitDate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorSourceControlLibrary:GetLatestSubmitDate");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLatestSubmitDate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLatestSubmitDate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetLatestSubmitDate_InPackageName_Offset), 0, GetLatestSubmitDate_InPackageName_PropertyAddress.Address, InPackageName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLatestSubmitDate_FunctionAddress, intPtr, GetLatestSubmitDate_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetLatestSubmitDate_InPackageName_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetLatestSubmitDate_ReturnValue_Offset), 0, GetLatestSubmitDate_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetLatestSubmitDate_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71574529u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorSourceControlLibrary:GetFirstSubmitUsers")]
	public unsafe static List<string> GetFirstSubmitUsers(List<string> InPackageNames)
	{
		if (!GetFirstSubmitUsers_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorSourceControlLibrary:GetFirstSubmitUsers");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFirstSubmitUsers_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFirstSubmitUsers_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<string>(1, GetFirstSubmitUsers_InPackageNames_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, GetFirstSubmitUsers_InPackageNames_Offset), InPackageNames);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetFirstSubmitUsers_FunctionAddress, intPtr, GetFirstSubmitUsers_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetFirstSubmitUsers_InPackageNames_PropertyAddress.Address, intPtr);
		List<string> result = new TArrayCopyMarshaler<string>(1, GetFirstSubmitUsers_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetFirstSubmitUsers_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetFirstSubmitUsers_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorSourceControlLibrary:GetFirstSubmitUser")]
	public unsafe static string GetFirstSubmitUser(string PackageName)
	{
		if (!GetFirstSubmitUser_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorSourceControlLibrary:GetFirstSubmitUser");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFirstSubmitUser_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFirstSubmitUser_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetFirstSubmitUser_PackageName_Offset), 0, GetFirstSubmitUser_PackageName_PropertyAddress.Address, PackageName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetFirstSubmitUser_FunctionAddress, intPtr, GetFirstSubmitUser_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetFirstSubmitUser_PackageName_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetFirstSubmitUser_ReturnValue_Offset), 0, GetFirstSubmitUser_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetFirstSubmitUser_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorSourceControlLibrary:GetAssetDataFromPackage")]
	public unsafe static List<FAssetData> GetAssetDataFromPackage(string PackageName)
	{
		if (!GetAssetDataFromPackage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorSourceControlLibrary:GetAssetDataFromPackage");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAssetDataFromPackage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAssetDataFromPackage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetAssetDataFromPackage_PackageName_Offset), 0, GetAssetDataFromPackage_PackageName_PropertyAddress.Address, PackageName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAssetDataFromPackage_FunctionAddress, intPtr, GetAssetDataFromPackage_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetAssetDataFromPackage_PackageName_PropertyAddress.Address, intPtr);
		List<FAssetData> result = new TArrayCopyMarshaler<FAssetData>(1, GetAssetDataFromPackage_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FAssetData, FAssetData>.FromNative, CachedMarshalingDelegates<FAssetData, FAssetData>.ToNative).FromNative(IntPtr.Add(intPtr, GetAssetDataFromPackage_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetAssetDataFromPackage_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UGSEditorSourceControlLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSEditorSourceControlLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSEditorSourceControlLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/FuncLibEditor.GSEditorSourceControlLibrary");
		GetStatusText_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetStatusText");
		GetStatusText_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStatusText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetStatusText_ReturnValue_PropertyAddress, GetStatusText_FunctionAddress, "ReturnValue");
		GetStatusText_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetStatusText_FunctionAddress, "ReturnValue");
		GetStatusText_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStatusText_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetStatusText_IsValid = GetStatusText_FunctionAddress != IntPtr.Zero && GetStatusText_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorSourceControlLibrary:GetStatusText", GetStatusText_IsValid);
		GetScourceControlInfo_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetScourceControlInfo");
		GetScourceControlInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(GetScourceControlInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetScourceControlInfo_InPackageNames_PropertyAddress, GetScourceControlInfo_FunctionAddress, "InPackageNames");
		GetScourceControlInfo_InPackageNames_Offset = NativeReflectionCached.GetPropertyOffset(GetScourceControlInfo_FunctionAddress, "InPackageNames");
		GetScourceControlInfo_InPackageNames_IsValid = NativeReflectionCached.ValidatePropertyClass(GetScourceControlInfo_FunctionAddress, "InPackageNames", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetScourceControlInfo_ReturnValue_PropertyAddress, GetScourceControlInfo_FunctionAddress, "ReturnValue");
		GetScourceControlInfo_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetScourceControlInfo_FunctionAddress, "ReturnValue");
		GetScourceControlInfo_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetScourceControlInfo_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetScourceControlInfo_IsValid = GetScourceControlInfo_FunctionAddress != IntPtr.Zero && GetScourceControlInfo_InPackageNames_IsValid && GetScourceControlInfo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorSourceControlLibrary:GetScourceControlInfo", GetScourceControlInfo_IsValid);
		GetLatestSubmitDate_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLatestSubmitDate");
		GetLatestSubmitDate_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLatestSubmitDate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLatestSubmitDate_InPackageName_PropertyAddress, GetLatestSubmitDate_FunctionAddress, "InPackageName");
		GetLatestSubmitDate_InPackageName_Offset = NativeReflectionCached.GetPropertyOffset(GetLatestSubmitDate_FunctionAddress, "InPackageName");
		GetLatestSubmitDate_InPackageName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLatestSubmitDate_FunctionAddress, "InPackageName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLatestSubmitDate_ReturnValue_PropertyAddress, GetLatestSubmitDate_FunctionAddress, "ReturnValue");
		GetLatestSubmitDate_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLatestSubmitDate_FunctionAddress, "ReturnValue");
		GetLatestSubmitDate_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLatestSubmitDate_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetLatestSubmitDate_IsValid = GetLatestSubmitDate_FunctionAddress != IntPtr.Zero && GetLatestSubmitDate_InPackageName_IsValid && GetLatestSubmitDate_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorSourceControlLibrary:GetLatestSubmitDate", GetLatestSubmitDate_IsValid);
		GetFirstSubmitUsers_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetFirstSubmitUsers");
		GetFirstSubmitUsers_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFirstSubmitUsers_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFirstSubmitUsers_InPackageNames_PropertyAddress, GetFirstSubmitUsers_FunctionAddress, "InPackageNames");
		GetFirstSubmitUsers_InPackageNames_Offset = NativeReflectionCached.GetPropertyOffset(GetFirstSubmitUsers_FunctionAddress, "InPackageNames");
		GetFirstSubmitUsers_InPackageNames_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFirstSubmitUsers_FunctionAddress, "InPackageNames", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetFirstSubmitUsers_ReturnValue_PropertyAddress, GetFirstSubmitUsers_FunctionAddress, "ReturnValue");
		GetFirstSubmitUsers_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFirstSubmitUsers_FunctionAddress, "ReturnValue");
		GetFirstSubmitUsers_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFirstSubmitUsers_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetFirstSubmitUsers_IsValid = GetFirstSubmitUsers_FunctionAddress != IntPtr.Zero && GetFirstSubmitUsers_InPackageNames_IsValid && GetFirstSubmitUsers_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorSourceControlLibrary:GetFirstSubmitUsers", GetFirstSubmitUsers_IsValid);
		GetFirstSubmitUser_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetFirstSubmitUser");
		GetFirstSubmitUser_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFirstSubmitUser_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFirstSubmitUser_PackageName_PropertyAddress, GetFirstSubmitUser_FunctionAddress, "PackageName");
		GetFirstSubmitUser_PackageName_Offset = NativeReflectionCached.GetPropertyOffset(GetFirstSubmitUser_FunctionAddress, "PackageName");
		GetFirstSubmitUser_PackageName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFirstSubmitUser_FunctionAddress, "PackageName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetFirstSubmitUser_ReturnValue_PropertyAddress, GetFirstSubmitUser_FunctionAddress, "ReturnValue");
		GetFirstSubmitUser_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFirstSubmitUser_FunctionAddress, "ReturnValue");
		GetFirstSubmitUser_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFirstSubmitUser_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetFirstSubmitUser_IsValid = GetFirstSubmitUser_FunctionAddress != IntPtr.Zero && GetFirstSubmitUser_PackageName_IsValid && GetFirstSubmitUser_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorSourceControlLibrary:GetFirstSubmitUser", GetFirstSubmitUser_IsValid);
		GetAssetDataFromPackage_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAssetDataFromPackage");
		GetAssetDataFromPackage_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAssetDataFromPackage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAssetDataFromPackage_PackageName_PropertyAddress, GetAssetDataFromPackage_FunctionAddress, "PackageName");
		GetAssetDataFromPackage_PackageName_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetDataFromPackage_FunctionAddress, "PackageName");
		GetAssetDataFromPackage_PackageName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetDataFromPackage_FunctionAddress, "PackageName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAssetDataFromPackage_ReturnValue_PropertyAddress, GetAssetDataFromPackage_FunctionAddress, "ReturnValue");
		GetAssetDataFromPackage_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetDataFromPackage_FunctionAddress, "ReturnValue");
		GetAssetDataFromPackage_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetDataFromPackage_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetAssetDataFromPackage_IsValid = GetAssetDataFromPackage_FunctionAddress != IntPtr.Zero && GetAssetDataFromPackage_PackageName_IsValid && GetAssetDataFromPackage_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorSourceControlLibrary:GetAssetDataFromPackage", GetAssetDataFromPackage_IsValid);
	}
}
