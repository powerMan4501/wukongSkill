using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.AssetRegistry;

[UClass(Flags = (ClassFlags)809500840uL, Config = "Engine")]
[UMetaPath("/Script/AssetRegistry.AssetRegistryHelpers", "AssetRegistry", UnrealModuleType.Engine)]
public class UAssetRegistryHelpers : UObject
{
	private static IntPtr classAddress;

	private static bool ToSoftObjectPath_IsValid;

	private static IntPtr ToSoftObjectPath_FunctionAddress;

	private static int ToSoftObjectPath_ParamsSize;

	private static bool ToSoftObjectPath_InAssetData_IsValid;

	private static FFieldAddress ToSoftObjectPath_InAssetData_PropertyAddress;

	private static int ToSoftObjectPath_InAssetData_Offset;

	private static bool ToSoftObjectPath_ReturnValue_IsValid;

	private static FFieldAddress ToSoftObjectPath_ReturnValue_PropertyAddress;

	private static int ToSoftObjectPath_ReturnValue_Offset;

	private static bool SetFilterTagsAndValues_IsValid;

	private static IntPtr SetFilterTagsAndValues_FunctionAddress;

	private static int SetFilterTagsAndValues_ParamsSize;

	private static bool SetFilterTagsAndValues_InFilter_IsValid;

	private static FFieldAddress SetFilterTagsAndValues_InFilter_PropertyAddress;

	private static int SetFilterTagsAndValues_InFilter_Offset;

	private static bool SetFilterTagsAndValues_InTagsAndValues_IsValid;

	private static FFieldAddress SetFilterTagsAndValues_InTagsAndValues_PropertyAddress;

	private static int SetFilterTagsAndValues_InTagsAndValues_Offset;

	private static bool SetFilterTagsAndValues_ReturnValue_IsValid;

	private static FFieldAddress SetFilterTagsAndValues_ReturnValue_PropertyAddress;

	private static int SetFilterTagsAndValues_ReturnValue_Offset;

	private static bool IsValid_IsValid;

	private static IntPtr IsValid_FunctionAddress;

	private static int IsValid_ParamsSize;

	private static bool IsValid_InAssetData_IsValid;

	private static FFieldAddress IsValid_InAssetData_PropertyAddress;

	private static int IsValid_InAssetData_Offset;

	private static bool IsValid_ReturnValue_IsValid;

	private static FFieldAddress IsValid_ReturnValue_PropertyAddress;

	private static int IsValid_ReturnValue_Offset;

	private static bool IsUAsset_IsValid;

	private static IntPtr IsUAsset_FunctionAddress;

	private static int IsUAsset_ParamsSize;

	private static bool IsUAsset_InAssetData_IsValid;

	private static FFieldAddress IsUAsset_InAssetData_PropertyAddress;

	private static int IsUAsset_InAssetData_Offset;

	private static bool IsUAsset_ReturnValue_IsValid;

	private static FFieldAddress IsUAsset_ReturnValue_PropertyAddress;

	private static int IsUAsset_ReturnValue_Offset;

	private static bool IsRedirector_IsValid;

	private static IntPtr IsRedirector_FunctionAddress;

	private static int IsRedirector_ParamsSize;

	private static bool IsRedirector_InAssetData_IsValid;

	private static FFieldAddress IsRedirector_InAssetData_PropertyAddress;

	private static int IsRedirector_InAssetData_Offset;

	private static bool IsRedirector_ReturnValue_IsValid;

	private static FFieldAddress IsRedirector_ReturnValue_PropertyAddress;

	private static int IsRedirector_ReturnValue_Offset;

	private static bool IsAssetLoaded_IsValid;

	private static IntPtr IsAssetLoaded_FunctionAddress;

	private static int IsAssetLoaded_ParamsSize;

	private static bool IsAssetLoaded_InAssetData_IsValid;

	private static FFieldAddress IsAssetLoaded_InAssetData_PropertyAddress;

	private static int IsAssetLoaded_InAssetData_Offset;

	private static bool IsAssetLoaded_ReturnValue_IsValid;

	private static FFieldAddress IsAssetLoaded_ReturnValue_PropertyAddress;

	private static int IsAssetLoaded_ReturnValue_Offset;

	private static bool GetTagValue_IsValid;

	private static IntPtr GetTagValue_FunctionAddress;

	private static int GetTagValue_ParamsSize;

	private static bool GetTagValue_InAssetData_IsValid;

	private static FFieldAddress GetTagValue_InAssetData_PropertyAddress;

	private static int GetTagValue_InAssetData_Offset;

	private static bool GetTagValue_InTagName_IsValid;

	private static FFieldAddress GetTagValue_InTagName_PropertyAddress;

	private static int GetTagValue_InTagName_Offset;

	private static bool GetTagValue_OutTagValue_IsValid;

	private static FFieldAddress GetTagValue_OutTagValue_PropertyAddress;

	private static int GetTagValue_OutTagValue_Offset;

	private static bool GetTagValue_ReturnValue_IsValid;

	private static FFieldAddress GetTagValue_ReturnValue_PropertyAddress;

	private static int GetTagValue_ReturnValue_Offset;

	private static bool GetFullName_IsValid;

	private static IntPtr GetFullName_FunctionAddress;

	private static int GetFullName_ParamsSize;

	private static bool GetFullName_InAssetData_IsValid;

	private static FFieldAddress GetFullName_InAssetData_PropertyAddress;

	private static int GetFullName_InAssetData_Offset;

	private static bool GetFullName_ReturnValue_IsValid;

	private static FFieldAddress GetFullName_ReturnValue_PropertyAddress;

	private static int GetFullName_ReturnValue_Offset;

	private static bool GetExportTextName_IsValid;

	private static IntPtr GetExportTextName_FunctionAddress;

	private static int GetExportTextName_ParamsSize;

	private static bool GetExportTextName_InAssetData_IsValid;

	private static FFieldAddress GetExportTextName_InAssetData_PropertyAddress;

	private static int GetExportTextName_InAssetData_Offset;

	private static bool GetExportTextName_ReturnValue_IsValid;

	private static FFieldAddress GetExportTextName_ReturnValue_PropertyAddress;

	private static int GetExportTextName_ReturnValue_Offset;

	private static bool GetClass_IsValid;

	private static IntPtr GetClass_FunctionAddress;

	private static int GetClass_ParamsSize;

	private static bool GetClass_InAssetData_IsValid;

	private static FFieldAddress GetClass_InAssetData_PropertyAddress;

	private static int GetClass_InAssetData_Offset;

	private static bool GetClass_ReturnValue_IsValid;

	private static FFieldAddress GetClass_ReturnValue_PropertyAddress;

	private static int GetClass_ReturnValue_Offset;

	private static bool GetAssetRegistry_IsValid;

	private static IntPtr GetAssetRegistry_FunctionAddress;

	private static int GetAssetRegistry_ParamsSize;

	private static bool GetAssetRegistry_ReturnValue_IsValid;

	private static FFieldAddress GetAssetRegistry_ReturnValue_PropertyAddress;

	private static int GetAssetRegistry_ReturnValue_Offset;

	private static bool GetAsset_IsValid;

	private static IntPtr GetAsset_FunctionAddress;

	private static int GetAsset_ParamsSize;

	private static bool GetAsset_InAssetData_IsValid;

	private static FFieldAddress GetAsset_InAssetData_PropertyAddress;

	private static int GetAsset_InAssetData_Offset;

	private static bool GetAsset_ReturnValue_IsValid;

	private static FFieldAddress GetAsset_ReturnValue_PropertyAddress;

	private static int GetAsset_ReturnValue_Offset;

	private static bool CreateAssetData_IsValid;

	private static IntPtr CreateAssetData_FunctionAddress;

	private static int CreateAssetData_ParamsSize;

	private static bool CreateAssetData_InAsset_IsValid;

	private static FFieldAddress CreateAssetData_InAsset_PropertyAddress;

	private static int CreateAssetData_InAsset_Offset;

	private static bool CreateAssetData_bAllowBlueprintClass_IsValid;

	private static FFieldAddress CreateAssetData_bAllowBlueprintClass_PropertyAddress;

	private static int CreateAssetData_bAllowBlueprintClass_Offset;

	private static bool CreateAssetData_ReturnValue_IsValid;

	private static FFieldAddress CreateAssetData_ReturnValue_PropertyAddress;

	private static int CreateAssetData_ReturnValue_Offset;

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/AssetRegistry.AssetRegistryHelpers:ToSoftObjectPath")]
	public unsafe static FSoftObjectPath ToSoftObjectPath(FAssetData InAssetData)
	{
		if (!ToSoftObjectPath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AssetRegistry.AssetRegistryHelpers:ToSoftObjectPath");
			return default(FSoftObjectPath);
		}
		byte* ptr = stackalloc byte[(int)(uint)(ToSoftObjectPath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ToSoftObjectPath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ToSoftObjectPath_InAssetData_PropertyAddress.Address, intPtr);
		FAssetData.ToNative(IntPtr.Add(intPtr, ToSoftObjectPath_InAssetData_Offset), 0, ToSoftObjectPath_InAssetData_PropertyAddress.Address, InAssetData);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ToSoftObjectPath_FunctionAddress, intPtr, ToSoftObjectPath_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ToSoftObjectPath_InAssetData_PropertyAddress.Address, intPtr);
		FSoftObjectPath result = FSoftObjectPath.FromNative(IntPtr.Add(intPtr, ToSoftObjectPath_ReturnValue_Offset), 0, ToSoftObjectPath_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ToSoftObjectPath_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/AssetRegistry.AssetRegistryHelpers:SetFilterTagsAndValues")]
	public unsafe static FARFilter SetFilterTagsAndValues(FARFilter InFilter, List<FTagAndValue> InTagsAndValues)
	{
		if (!SetFilterTagsAndValues_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AssetRegistry.AssetRegistryHelpers:SetFilterTagsAndValues");
			return default(FARFilter);
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFilterTagsAndValues_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFilterTagsAndValues_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetFilterTagsAndValues_InFilter_PropertyAddress.Address, intPtr);
		FARFilter.ToNative(IntPtr.Add(intPtr, SetFilterTagsAndValues_InFilter_Offset), 0, SetFilterTagsAndValues_InFilter_PropertyAddress.Address, InFilter);
		new TArrayCopyMarshaler<FTagAndValue>(1, SetFilterTagsAndValues_InTagsAndValues_PropertyAddress, CachedMarshalingDelegates<FTagAndValue, FTagAndValue>.FromNative, CachedMarshalingDelegates<FTagAndValue, FTagAndValue>.ToNative).ToNative(IntPtr.Add(intPtr, SetFilterTagsAndValues_InTagsAndValues_Offset), InTagsAndValues);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetFilterTagsAndValues_FunctionAddress, intPtr, SetFilterTagsAndValues_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetFilterTagsAndValues_InFilter_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SetFilterTagsAndValues_InTagsAndValues_PropertyAddress.Address, intPtr);
		FARFilter result = FARFilter.FromNative(IntPtr.Add(intPtr, SetFilterTagsAndValues_ReturnValue_Offset), 0, SetFilterTagsAndValues_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SetFilterTagsAndValues_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/AssetRegistry.AssetRegistryHelpers:IsValid")]
	public unsafe static bool IsValid(FAssetData InAssetData)
	{
		if (!IsValid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AssetRegistry.AssetRegistryHelpers:IsValid");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsValid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsValid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsValid_InAssetData_PropertyAddress.Address, intPtr);
		FAssetData.ToNative(IntPtr.Add(intPtr, IsValid_InAssetData_Offset), 0, IsValid_InAssetData_PropertyAddress.Address, InAssetData);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsValid_FunctionAddress, intPtr, IsValid_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsValid_InAssetData_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsValid_ReturnValue_Offset), 0, IsValid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/AssetRegistry.AssetRegistryHelpers:IsUAsset")]
	public unsafe static bool IsUAsset(FAssetData InAssetData)
	{
		if (!IsUAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AssetRegistry.AssetRegistryHelpers:IsUAsset");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsUAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsUAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsUAsset_InAssetData_PropertyAddress.Address, intPtr);
		FAssetData.ToNative(IntPtr.Add(intPtr, IsUAsset_InAssetData_Offset), 0, IsUAsset_InAssetData_PropertyAddress.Address, InAssetData);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsUAsset_FunctionAddress, intPtr, IsUAsset_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsUAsset_InAssetData_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsUAsset_ReturnValue_Offset), 0, IsUAsset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/AssetRegistry.AssetRegistryHelpers:IsRedirector")]
	public unsafe static bool IsRedirector(FAssetData InAssetData)
	{
		if (!IsRedirector_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AssetRegistry.AssetRegistryHelpers:IsRedirector");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsRedirector_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsRedirector_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsRedirector_InAssetData_PropertyAddress.Address, intPtr);
		FAssetData.ToNative(IntPtr.Add(intPtr, IsRedirector_InAssetData_Offset), 0, IsRedirector_InAssetData_PropertyAddress.Address, InAssetData);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsRedirector_FunctionAddress, intPtr, IsRedirector_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsRedirector_InAssetData_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsRedirector_ReturnValue_Offset), 0, IsRedirector_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/AssetRegistry.AssetRegistryHelpers:IsAssetLoaded")]
	public unsafe static bool IsAssetLoaded(FAssetData InAssetData)
	{
		if (!IsAssetLoaded_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AssetRegistry.AssetRegistryHelpers:IsAssetLoaded");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsAssetLoaded_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsAssetLoaded_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsAssetLoaded_InAssetData_PropertyAddress.Address, intPtr);
		FAssetData.ToNative(IntPtr.Add(intPtr, IsAssetLoaded_InAssetData_Offset), 0, IsAssetLoaded_InAssetData_PropertyAddress.Address, InAssetData);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsAssetLoaded_FunctionAddress, intPtr, IsAssetLoaded_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsAssetLoaded_InAssetData_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsAssetLoaded_ReturnValue_Offset), 0, IsAssetLoaded_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/AssetRegistry.AssetRegistryHelpers:GetTagValue")]
	public unsafe static bool GetTagValue(FAssetData InAssetData, FName InTagName, out string OutTagValue)
	{
		if (!GetTagValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AssetRegistry.AssetRegistryHelpers:GetTagValue");
			OutTagValue = FStringMarshaler.DefaultString;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTagValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTagValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetTagValue_InAssetData_PropertyAddress.Address, intPtr);
		FAssetData.ToNative(IntPtr.Add(intPtr, GetTagValue_InAssetData_Offset), 0, GetTagValue_InAssetData_PropertyAddress.Address, InAssetData);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetTagValue_InTagName_Offset), 0, GetTagValue_InTagName_PropertyAddress.Address, InTagName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetTagValue_FunctionAddress, intPtr, GetTagValue_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetTagValue_InAssetData_PropertyAddress.Address, intPtr);
		OutTagValue = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetTagValue_OutTagValue_Offset), 0, GetTagValue_OutTagValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetTagValue_OutTagValue_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetTagValue_ReturnValue_Offset), 0, GetTagValue_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/AssetRegistry.AssetRegistryHelpers:GetFullName")]
	public unsafe static string GetFullName(FAssetData InAssetData)
	{
		if (!GetFullName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AssetRegistry.AssetRegistryHelpers:GetFullName");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFullName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFullName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetFullName_InAssetData_PropertyAddress.Address, intPtr);
		FAssetData.ToNative(IntPtr.Add(intPtr, GetFullName_InAssetData_Offset), 0, GetFullName_InAssetData_PropertyAddress.Address, InAssetData);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetFullName_FunctionAddress, intPtr, GetFullName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetFullName_InAssetData_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetFullName_ReturnValue_Offset), 0, GetFullName_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetFullName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/AssetRegistry.AssetRegistryHelpers:GetExportTextName")]
	public unsafe static string GetExportTextName(FAssetData InAssetData)
	{
		if (!GetExportTextName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AssetRegistry.AssetRegistryHelpers:GetExportTextName");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetExportTextName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetExportTextName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetExportTextName_InAssetData_PropertyAddress.Address, intPtr);
		FAssetData.ToNative(IntPtr.Add(intPtr, GetExportTextName_InAssetData_Offset), 0, GetExportTextName_InAssetData_PropertyAddress.Address, InAssetData);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetExportTextName_FunctionAddress, intPtr, GetExportTextName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetExportTextName_InAssetData_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetExportTextName_ReturnValue_Offset), 0, GetExportTextName_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetExportTextName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/AssetRegistry.AssetRegistryHelpers:GetClass")]
	public unsafe static TSubclassOf<UObject> GetClass(FAssetData InAssetData)
	{
		if (!GetClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AssetRegistry.AssetRegistryHelpers:GetClass");
			return default(TSubclassOf<UObject>);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetClass_InAssetData_PropertyAddress.Address, intPtr);
		FAssetData.ToNative(IntPtr.Add(intPtr, GetClass_InAssetData_Offset), 0, GetClass_InAssetData_PropertyAddress.Address, InAssetData);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetClass_FunctionAddress, intPtr, GetClass_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetClass_InAssetData_PropertyAddress.Address, intPtr);
		return TSubclassOfMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, GetClass_ReturnValue_Offset), 0, GetClass_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/AssetRegistry.AssetRegistryHelpers:GetAssetRegistry")]
	public unsafe static IAssetRegistry GetAssetRegistry()
	{
		if (!GetAssetRegistry_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AssetRegistry.AssetRegistryHelpers:GetAssetRegistry");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAssetRegistry_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAssetRegistry_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAssetRegistry_FunctionAddress, intPtr, GetAssetRegistry_ParamsSize);
		return InterfaceMarshaler<IAssetRegistry>.FromNative(IntPtr.Add(intPtr, GetAssetRegistry_ReturnValue_Offset), 0, GetAssetRegistry_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/AssetRegistry.AssetRegistryHelpers:GetAsset")]
	public unsafe static UObject GetAsset(FAssetData InAssetData)
	{
		if (!GetAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AssetRegistry.AssetRegistryHelpers:GetAsset");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetAsset_InAssetData_PropertyAddress.Address, intPtr);
		FAssetData.ToNative(IntPtr.Add(intPtr, GetAsset_InAssetData_Offset), 0, GetAsset_InAssetData_PropertyAddress.Address, InAssetData);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAsset_FunctionAddress, intPtr, GetAsset_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetAsset_InAssetData_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, GetAsset_ReturnValue_Offset), 0, GetAsset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 344073217u)]
	[UMetaPath("/Script/AssetRegistry.AssetRegistryHelpers:CreateAssetData")]
	public unsafe static FAssetData CreateAssetData(UObject InAsset, bool bAllowBlueprintClass = false)
	{
		if (!CreateAssetData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AssetRegistry.AssetRegistryHelpers:CreateAssetData");
			return default(FAssetData);
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateAssetData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateAssetData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, CreateAssetData_InAsset_Offset), 0, CreateAssetData_InAsset_PropertyAddress.Address, InAsset);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CreateAssetData_bAllowBlueprintClass_Offset), 0, CreateAssetData_bAllowBlueprintClass_PropertyAddress.Address, bAllowBlueprintClass);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateAssetData_FunctionAddress, intPtr, CreateAssetData_ParamsSize);
		FAssetData result = FAssetData.FromNative(IntPtr.Add(intPtr, CreateAssetData_ReturnValue_Offset), 0, CreateAssetData_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(CreateAssetData_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UAssetRegistryHelpers()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAssetRegistryHelpers)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAssetRegistryHelpers));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/AssetRegistry.AssetRegistryHelpers");
		ToSoftObjectPath_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ToSoftObjectPath");
		ToSoftObjectPath_ParamsSize = NativeReflection.GetFunctionParamsSize(ToSoftObjectPath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ToSoftObjectPath_InAssetData_PropertyAddress, ToSoftObjectPath_FunctionAddress, "InAssetData");
		ToSoftObjectPath_InAssetData_Offset = NativeReflectionCached.GetPropertyOffset(ToSoftObjectPath_FunctionAddress, "InAssetData");
		ToSoftObjectPath_InAssetData_IsValid = NativeReflectionCached.ValidatePropertyClass(ToSoftObjectPath_FunctionAddress, "InAssetData", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ToSoftObjectPath_ReturnValue_PropertyAddress, ToSoftObjectPath_FunctionAddress, "ReturnValue");
		ToSoftObjectPath_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ToSoftObjectPath_FunctionAddress, "ReturnValue");
		ToSoftObjectPath_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ToSoftObjectPath_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		ToSoftObjectPath_IsValid = ToSoftObjectPath_FunctionAddress != IntPtr.Zero && ToSoftObjectPath_InAssetData_IsValid && ToSoftObjectPath_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AssetRegistry.AssetRegistryHelpers:ToSoftObjectPath", ToSoftObjectPath_IsValid);
		SetFilterTagsAndValues_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetFilterTagsAndValues");
		SetFilterTagsAndValues_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFilterTagsAndValues_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFilterTagsAndValues_InFilter_PropertyAddress, SetFilterTagsAndValues_FunctionAddress, "InFilter");
		SetFilterTagsAndValues_InFilter_Offset = NativeReflectionCached.GetPropertyOffset(SetFilterTagsAndValues_FunctionAddress, "InFilter");
		SetFilterTagsAndValues_InFilter_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFilterTagsAndValues_FunctionAddress, "InFilter", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetFilterTagsAndValues_InTagsAndValues_PropertyAddress, SetFilterTagsAndValues_FunctionAddress, "InTagsAndValues");
		SetFilterTagsAndValues_InTagsAndValues_Offset = NativeReflectionCached.GetPropertyOffset(SetFilterTagsAndValues_FunctionAddress, "InTagsAndValues");
		SetFilterTagsAndValues_InTagsAndValues_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFilterTagsAndValues_FunctionAddress, "InTagsAndValues", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SetFilterTagsAndValues_ReturnValue_PropertyAddress, SetFilterTagsAndValues_FunctionAddress, "ReturnValue");
		SetFilterTagsAndValues_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetFilterTagsAndValues_FunctionAddress, "ReturnValue");
		SetFilterTagsAndValues_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFilterTagsAndValues_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		SetFilterTagsAndValues_IsValid = SetFilterTagsAndValues_FunctionAddress != IntPtr.Zero && SetFilterTagsAndValues_InFilter_IsValid && SetFilterTagsAndValues_InTagsAndValues_IsValid && SetFilterTagsAndValues_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AssetRegistry.AssetRegistryHelpers:SetFilterTagsAndValues", SetFilterTagsAndValues_IsValid);
		IsValid_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsValid");
		IsValid_ParamsSize = NativeReflection.GetFunctionParamsSize(IsValid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsValid_InAssetData_PropertyAddress, IsValid_FunctionAddress, "InAssetData");
		IsValid_InAssetData_Offset = NativeReflectionCached.GetPropertyOffset(IsValid_FunctionAddress, "InAssetData");
		IsValid_InAssetData_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValid_FunctionAddress, "InAssetData", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsValid_ReturnValue_PropertyAddress, IsValid_FunctionAddress, "ReturnValue");
		IsValid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsValid_FunctionAddress, "ReturnValue");
		IsValid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsValid_IsValid = IsValid_FunctionAddress != IntPtr.Zero && IsValid_InAssetData_IsValid && IsValid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AssetRegistry.AssetRegistryHelpers:IsValid", IsValid_IsValid);
		IsUAsset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsUAsset");
		IsUAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(IsUAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsUAsset_InAssetData_PropertyAddress, IsUAsset_FunctionAddress, "InAssetData");
		IsUAsset_InAssetData_Offset = NativeReflectionCached.GetPropertyOffset(IsUAsset_FunctionAddress, "InAssetData");
		IsUAsset_InAssetData_IsValid = NativeReflectionCached.ValidatePropertyClass(IsUAsset_FunctionAddress, "InAssetData", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsUAsset_ReturnValue_PropertyAddress, IsUAsset_FunctionAddress, "ReturnValue");
		IsUAsset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsUAsset_FunctionAddress, "ReturnValue");
		IsUAsset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsUAsset_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsUAsset_IsValid = IsUAsset_FunctionAddress != IntPtr.Zero && IsUAsset_InAssetData_IsValid && IsUAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AssetRegistry.AssetRegistryHelpers:IsUAsset", IsUAsset_IsValid);
		IsRedirector_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsRedirector");
		IsRedirector_ParamsSize = NativeReflection.GetFunctionParamsSize(IsRedirector_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsRedirector_InAssetData_PropertyAddress, IsRedirector_FunctionAddress, "InAssetData");
		IsRedirector_InAssetData_Offset = NativeReflectionCached.GetPropertyOffset(IsRedirector_FunctionAddress, "InAssetData");
		IsRedirector_InAssetData_IsValid = NativeReflectionCached.ValidatePropertyClass(IsRedirector_FunctionAddress, "InAssetData", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsRedirector_ReturnValue_PropertyAddress, IsRedirector_FunctionAddress, "ReturnValue");
		IsRedirector_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsRedirector_FunctionAddress, "ReturnValue");
		IsRedirector_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsRedirector_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsRedirector_IsValid = IsRedirector_FunctionAddress != IntPtr.Zero && IsRedirector_InAssetData_IsValid && IsRedirector_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AssetRegistry.AssetRegistryHelpers:IsRedirector", IsRedirector_IsValid);
		IsAssetLoaded_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsAssetLoaded");
		IsAssetLoaded_ParamsSize = NativeReflection.GetFunctionParamsSize(IsAssetLoaded_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsAssetLoaded_InAssetData_PropertyAddress, IsAssetLoaded_FunctionAddress, "InAssetData");
		IsAssetLoaded_InAssetData_Offset = NativeReflectionCached.GetPropertyOffset(IsAssetLoaded_FunctionAddress, "InAssetData");
		IsAssetLoaded_InAssetData_IsValid = NativeReflectionCached.ValidatePropertyClass(IsAssetLoaded_FunctionAddress, "InAssetData", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsAssetLoaded_ReturnValue_PropertyAddress, IsAssetLoaded_FunctionAddress, "ReturnValue");
		IsAssetLoaded_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsAssetLoaded_FunctionAddress, "ReturnValue");
		IsAssetLoaded_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsAssetLoaded_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsAssetLoaded_IsValid = IsAssetLoaded_FunctionAddress != IntPtr.Zero && IsAssetLoaded_InAssetData_IsValid && IsAssetLoaded_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AssetRegistry.AssetRegistryHelpers:IsAssetLoaded", IsAssetLoaded_IsValid);
		GetTagValue_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetTagValue");
		GetTagValue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTagValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTagValue_InAssetData_PropertyAddress, GetTagValue_FunctionAddress, "InAssetData");
		GetTagValue_InAssetData_Offset = NativeReflectionCached.GetPropertyOffset(GetTagValue_FunctionAddress, "InAssetData");
		GetTagValue_InAssetData_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTagValue_FunctionAddress, "InAssetData", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTagValue_InTagName_PropertyAddress, GetTagValue_FunctionAddress, "InTagName");
		GetTagValue_InTagName_Offset = NativeReflectionCached.GetPropertyOffset(GetTagValue_FunctionAddress, "InTagName");
		GetTagValue_InTagName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTagValue_FunctionAddress, "InTagName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTagValue_OutTagValue_PropertyAddress, GetTagValue_FunctionAddress, "OutTagValue");
		GetTagValue_OutTagValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTagValue_FunctionAddress, "OutTagValue");
		GetTagValue_OutTagValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTagValue_FunctionAddress, "OutTagValue", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTagValue_ReturnValue_PropertyAddress, GetTagValue_FunctionAddress, "ReturnValue");
		GetTagValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTagValue_FunctionAddress, "ReturnValue");
		GetTagValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTagValue_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetTagValue_IsValid = GetTagValue_FunctionAddress != IntPtr.Zero && GetTagValue_InAssetData_IsValid && GetTagValue_InTagName_IsValid && GetTagValue_OutTagValue_IsValid && GetTagValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AssetRegistry.AssetRegistryHelpers:GetTagValue", GetTagValue_IsValid);
		GetFullName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetFullName");
		GetFullName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFullName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFullName_InAssetData_PropertyAddress, GetFullName_FunctionAddress, "InAssetData");
		GetFullName_InAssetData_Offset = NativeReflectionCached.GetPropertyOffset(GetFullName_FunctionAddress, "InAssetData");
		GetFullName_InAssetData_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFullName_FunctionAddress, "InAssetData", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetFullName_ReturnValue_PropertyAddress, GetFullName_FunctionAddress, "ReturnValue");
		GetFullName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFullName_FunctionAddress, "ReturnValue");
		GetFullName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFullName_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetFullName_IsValid = GetFullName_FunctionAddress != IntPtr.Zero && GetFullName_InAssetData_IsValid && GetFullName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AssetRegistry.AssetRegistryHelpers:GetFullName", GetFullName_IsValid);
		GetExportTextName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetExportTextName");
		GetExportTextName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetExportTextName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetExportTextName_InAssetData_PropertyAddress, GetExportTextName_FunctionAddress, "InAssetData");
		GetExportTextName_InAssetData_Offset = NativeReflectionCached.GetPropertyOffset(GetExportTextName_FunctionAddress, "InAssetData");
		GetExportTextName_InAssetData_IsValid = NativeReflectionCached.ValidatePropertyClass(GetExportTextName_FunctionAddress, "InAssetData", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetExportTextName_ReturnValue_PropertyAddress, GetExportTextName_FunctionAddress, "ReturnValue");
		GetExportTextName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetExportTextName_FunctionAddress, "ReturnValue");
		GetExportTextName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetExportTextName_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetExportTextName_IsValid = GetExportTextName_FunctionAddress != IntPtr.Zero && GetExportTextName_InAssetData_IsValid && GetExportTextName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AssetRegistry.AssetRegistryHelpers:GetExportTextName", GetExportTextName_IsValid);
		GetClass_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetClass");
		GetClass_ParamsSize = NativeReflection.GetFunctionParamsSize(GetClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetClass_InAssetData_PropertyAddress, GetClass_FunctionAddress, "InAssetData");
		GetClass_InAssetData_Offset = NativeReflectionCached.GetPropertyOffset(GetClass_FunctionAddress, "InAssetData");
		GetClass_InAssetData_IsValid = NativeReflectionCached.ValidatePropertyClass(GetClass_FunctionAddress, "InAssetData", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetClass_ReturnValue_PropertyAddress, GetClass_FunctionAddress, "ReturnValue");
		GetClass_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetClass_FunctionAddress, "ReturnValue");
		GetClass_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetClass_FunctionAddress, "ReturnValue", Classes.FClassProperty);
		GetClass_IsValid = GetClass_FunctionAddress != IntPtr.Zero && GetClass_InAssetData_IsValid && GetClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AssetRegistry.AssetRegistryHelpers:GetClass", GetClass_IsValid);
		GetAssetRegistry_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAssetRegistry");
		GetAssetRegistry_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAssetRegistry_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAssetRegistry_ReturnValue_PropertyAddress, GetAssetRegistry_FunctionAddress, "ReturnValue");
		GetAssetRegistry_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetRegistry_FunctionAddress, "ReturnValue");
		GetAssetRegistry_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetRegistry_FunctionAddress, "ReturnValue", Classes.FInterfaceProperty);
		GetAssetRegistry_IsValid = GetAssetRegistry_FunctionAddress != IntPtr.Zero && GetAssetRegistry_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AssetRegistry.AssetRegistryHelpers:GetAssetRegistry", GetAssetRegistry_IsValid);
		GetAsset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAsset");
		GetAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAsset_InAssetData_PropertyAddress, GetAsset_FunctionAddress, "InAssetData");
		GetAsset_InAssetData_Offset = NativeReflectionCached.GetPropertyOffset(GetAsset_FunctionAddress, "InAssetData");
		GetAsset_InAssetData_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAsset_FunctionAddress, "InAssetData", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAsset_ReturnValue_PropertyAddress, GetAsset_FunctionAddress, "ReturnValue");
		GetAsset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAsset_FunctionAddress, "ReturnValue");
		GetAsset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAsset_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetAsset_IsValid = GetAsset_FunctionAddress != IntPtr.Zero && GetAsset_InAssetData_IsValid && GetAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AssetRegistry.AssetRegistryHelpers:GetAsset", GetAsset_IsValid);
		CreateAssetData_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateAssetData");
		CreateAssetData_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateAssetData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateAssetData_InAsset_PropertyAddress, CreateAssetData_FunctionAddress, "InAsset");
		CreateAssetData_InAsset_Offset = NativeReflectionCached.GetPropertyOffset(CreateAssetData_FunctionAddress, "InAsset");
		CreateAssetData_InAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateAssetData_FunctionAddress, "InAsset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateAssetData_bAllowBlueprintClass_PropertyAddress, CreateAssetData_FunctionAddress, "bAllowBlueprintClass");
		CreateAssetData_bAllowBlueprintClass_Offset = NativeReflectionCached.GetPropertyOffset(CreateAssetData_FunctionAddress, "bAllowBlueprintClass");
		CreateAssetData_bAllowBlueprintClass_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateAssetData_FunctionAddress, "bAllowBlueprintClass", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateAssetData_ReturnValue_PropertyAddress, CreateAssetData_FunctionAddress, "ReturnValue");
		CreateAssetData_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateAssetData_FunctionAddress, "ReturnValue");
		CreateAssetData_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateAssetData_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		CreateAssetData_IsValid = CreateAssetData_FunctionAddress != IntPtr.Zero && CreateAssetData_InAsset_IsValid && CreateAssetData_bAllowBlueprintClass_IsValid && CreateAssetData_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AssetRegistry.AssetRegistryHelpers:CreateAssetData", CreateAssetData_IsValid);
	}
}
