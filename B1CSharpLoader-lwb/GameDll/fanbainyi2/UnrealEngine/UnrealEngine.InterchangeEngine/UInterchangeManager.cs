using System;
using System.Runtime.CompilerServices;
using UnrealEngine.InterchangeCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.InterchangeEngine;

[UClass(Flags = (ClassFlags)810549416uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/InterchangeEngine.InterchangeManager", "InterchangeEngine", UnrealModuleType.Engine)]
public class UInterchangeManager : UObject
{
	private static IntPtr classAddress;

	private static bool ImportScene_IsValid;

	private static IntPtr ImportScene_FunctionAddress;

	private static int ImportScene_ParamsSize;

	private static bool ImportScene_ContentPath_IsValid;

	private static FFieldAddress ImportScene_ContentPath_PropertyAddress;

	private static int ImportScene_ContentPath_Offset;

	private static bool ImportScene_SourceData_IsValid;

	private static FFieldAddress ImportScene_SourceData_PropertyAddress;

	private static int ImportScene_SourceData_Offset;

	private static bool ImportScene_ImportAssetParameters_IsValid;

	private static FFieldAddress ImportScene_ImportAssetParameters_PropertyAddress;

	private static int ImportScene_ImportAssetParameters_Offset;

	private static bool ImportScene_ReturnValue_IsValid;

	private static FFieldAddress ImportScene_ReturnValue_PropertyAddress;

	private static int ImportScene_ReturnValue_Offset;

	private static bool ImportAsset_IsValid;

	private static IntPtr ImportAsset_FunctionAddress;

	private static int ImportAsset_ParamsSize;

	private static bool ImportAsset_ContentPath_IsValid;

	private static FFieldAddress ImportAsset_ContentPath_PropertyAddress;

	private static int ImportAsset_ContentPath_Offset;

	private static bool ImportAsset_SourceData_IsValid;

	private static FFieldAddress ImportAsset_SourceData_PropertyAddress;

	private static int ImportAsset_SourceData_Offset;

	private static bool ImportAsset_ImportAssetParameters_IsValid;

	private static FFieldAddress ImportAsset_ImportAssetParameters_PropertyAddress;

	private static int ImportAsset_ImportAssetParameters_Offset;

	private static bool ImportAsset_ReturnValue_IsValid;

	private static FFieldAddress ImportAsset_ReturnValue_PropertyAddress;

	private static int ImportAsset_ReturnValue_Offset;

	private static bool GetRegisteredFactoryClass_IsValid;

	private static IntPtr GetRegisteredFactoryClass_FunctionAddress;

	private static int GetRegisteredFactoryClass_ParamsSize;

	private static bool GetRegisteredFactoryClass_ClassToMake_IsValid;

	private static FFieldAddress GetRegisteredFactoryClass_ClassToMake_PropertyAddress;

	private static int GetRegisteredFactoryClass_ClassToMake_Offset;

	private static bool GetRegisteredFactoryClass_ReturnValue_IsValid;

	private static FFieldAddress GetRegisteredFactoryClass_ReturnValue_PropertyAddress;

	private static int GetRegisteredFactoryClass_ReturnValue_Offset;

	private static bool GetInterchangeManagerScripted_IsValid;

	private static IntPtr GetInterchangeManagerScripted_FunctionAddress;

	private static int GetInterchangeManagerScripted_ParamsSize;

	private static bool GetInterchangeManagerScripted_ReturnValue_IsValid;

	private static FFieldAddress GetInterchangeManagerScripted_ReturnValue_PropertyAddress;

	private static int GetInterchangeManagerScripted_ReturnValue_Offset;

	private static bool ExportScene_IsValid;

	private static IntPtr ExportScene_FunctionAddress;

	private static int ExportScene_ParamsSize;

	private static bool ExportScene_World_IsValid;

	private static FFieldAddress ExportScene_World_PropertyAddress;

	private static int ExportScene_World_Offset;

	private static bool ExportScene_bIsAutomated_IsValid;

	private static FFieldAddress ExportScene_bIsAutomated_PropertyAddress;

	private static int ExportScene_bIsAutomated_Offset;

	private static bool ExportScene_ReturnValue_IsValid;

	private static FFieldAddress ExportScene_ReturnValue_PropertyAddress;

	private static int ExportScene_ReturnValue_Offset;

	private static bool ExportAsset_IsValid;

	private static IntPtr ExportAsset_FunctionAddress;

	private static int ExportAsset_ParamsSize;

	private static bool ExportAsset_Asset_IsValid;

	private static FFieldAddress ExportAsset_Asset_PropertyAddress;

	private static int ExportAsset_Asset_Offset;

	private static bool ExportAsset_bIsAutomated_IsValid;

	private static FFieldAddress ExportAsset_bIsAutomated_PropertyAddress;

	private static int ExportAsset_bIsAutomated_Offset;

	private static bool ExportAsset_ReturnValue_IsValid;

	private static FFieldAddress ExportAsset_ReturnValue_PropertyAddress;

	private static int ExportAsset_ReturnValue_Offset;

	private static bool CreateSourceData_IsValid;

	private static IntPtr CreateSourceData_FunctionAddress;

	private static int CreateSourceData_ParamsSize;

	private static bool CreateSourceData_InFileName_IsValid;

	private static FFieldAddress CreateSourceData_InFileName_PropertyAddress;

	private static int CreateSourceData_InFileName_Offset;

	private static bool CreateSourceData_ReturnValue_IsValid;

	private static FFieldAddress CreateSourceData_ReturnValue_PropertyAddress;

	private static int CreateSourceData_ReturnValue_Offset;

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/InterchangeEngine.InterchangeManager:ImportScene")]
	public unsafe bool ImportScene(string ContentPath, UInterchangeSourceData SourceData, FImportAssetParameters ImportAssetParameters)
	{
		CheckDestroyed();
		if (!ImportScene_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeEngine.InterchangeManager:ImportScene");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ImportScene_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ImportScene_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ImportScene_ContentPath_Offset), 0, ImportScene_ContentPath_PropertyAddress.Address, ContentPath);
		UObjectMarshaler<UInterchangeSourceData>.ToNative(IntPtr.Add(intPtr, ImportScene_SourceData_Offset), 0, ImportScene_SourceData_PropertyAddress.Address, SourceData);
		NativeReflection.InitializeValue_InContainer(ImportScene_ImportAssetParameters_PropertyAddress.Address, intPtr);
		FImportAssetParameters.ToNative(IntPtr.Add(intPtr, ImportScene_ImportAssetParameters_Offset), 0, ImportScene_ImportAssetParameters_PropertyAddress.Address, ImportAssetParameters);
		NativeReflection.InvokeFunctionOptimized(base.Address, ImportScene_FunctionAddress, intPtr, ImportScene_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ImportScene_ContentPath_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ImportScene_ImportAssetParameters_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ImportScene_ReturnValue_Offset), 0, ImportScene_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/InterchangeEngine.InterchangeManager:ImportAsset")]
	public unsafe bool ImportAsset(string ContentPath, UInterchangeSourceData SourceData, FImportAssetParameters ImportAssetParameters)
	{
		CheckDestroyed();
		if (!ImportAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeEngine.InterchangeManager:ImportAsset");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ImportAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ImportAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ImportAsset_ContentPath_Offset), 0, ImportAsset_ContentPath_PropertyAddress.Address, ContentPath);
		UObjectMarshaler<UInterchangeSourceData>.ToNative(IntPtr.Add(intPtr, ImportAsset_SourceData_Offset), 0, ImportAsset_SourceData_PropertyAddress.Address, SourceData);
		NativeReflection.InitializeValue_InContainer(ImportAsset_ImportAssetParameters_PropertyAddress.Address, intPtr);
		FImportAssetParameters.ToNative(IntPtr.Add(intPtr, ImportAsset_ImportAssetParameters_Offset), 0, ImportAsset_ImportAssetParameters_PropertyAddress.Address, ImportAssetParameters);
		NativeReflection.InvokeFunctionOptimized(base.Address, ImportAsset_FunctionAddress, intPtr, ImportAsset_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ImportAsset_ContentPath_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ImportAsset_ImportAssetParameters_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ImportAsset_ReturnValue_Offset), 0, ImportAsset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/InterchangeEngine.InterchangeManager:GetRegisteredFactoryClass")]
	public unsafe TSubclassOf<UObject> GetRegisteredFactoryClass(TSubclassOf<UObject> ClassToMake)
	{
		CheckDestroyed();
		if (!GetRegisteredFactoryClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeEngine.InterchangeManager:GetRegisteredFactoryClass");
			return default(TSubclassOf<UObject>);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRegisteredFactoryClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRegisteredFactoryClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetRegisteredFactoryClass_ClassToMake_Offset), 0, GetRegisteredFactoryClass_ClassToMake_PropertyAddress.Address, ClassToMake);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRegisteredFactoryClass_FunctionAddress, intPtr, GetRegisteredFactoryClass_ParamsSize);
		return TSubclassOfMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, GetRegisteredFactoryClass_ReturnValue_Offset), 0, GetRegisteredFactoryClass_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/InterchangeEngine.InterchangeManager:GetInterchangeManagerScripted")]
	public unsafe static UInterchangeManager GetInterchangeManagerScripted()
	{
		if (!GetInterchangeManagerScripted_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeEngine.InterchangeManager:GetInterchangeManagerScripted");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInterchangeManagerScripted_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInterchangeManagerScripted_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetInterchangeManagerScripted_FunctionAddress, intPtr, GetInterchangeManagerScripted_ParamsSize);
		return UObjectMarshaler<UInterchangeManager>.FromNative(IntPtr.Add(intPtr, GetInterchangeManagerScripted_ReturnValue_Offset), 0, GetInterchangeManagerScripted_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/InterchangeEngine.InterchangeManager:ExportScene")]
	public unsafe bool ExportScene(UObject World, bool bIsAutomated = false)
	{
		CheckDestroyed();
		if (!ExportScene_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeEngine.InterchangeManager:ExportScene");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ExportScene_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ExportScene_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ExportScene_World_Offset), 0, ExportScene_World_PropertyAddress.Address, World);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ExportScene_bIsAutomated_Offset), 0, ExportScene_bIsAutomated_PropertyAddress.Address, bIsAutomated);
		NativeReflection.InvokeFunctionOptimized(base.Address, ExportScene_FunctionAddress, intPtr, ExportScene_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ExportScene_ReturnValue_Offset), 0, ExportScene_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/InterchangeEngine.InterchangeManager:ExportAsset")]
	public unsafe bool ExportAsset(UObject Asset, bool bIsAutomated = false)
	{
		CheckDestroyed();
		if (!ExportAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeEngine.InterchangeManager:ExportAsset");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ExportAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ExportAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ExportAsset_Asset_Offset), 0, ExportAsset_Asset_PropertyAddress.Address, Asset);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ExportAsset_bIsAutomated_Offset), 0, ExportAsset_bIsAutomated_PropertyAddress.Address, bIsAutomated);
		NativeReflection.InvokeFunctionOptimized(base.Address, ExportAsset_FunctionAddress, intPtr, ExportAsset_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ExportAsset_ReturnValue_Offset), 0, ExportAsset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/InterchangeEngine.InterchangeManager:CreateSourceData")]
	public unsafe static UInterchangeSourceData CreateSourceData(string InFileName)
	{
		if (!CreateSourceData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeEngine.InterchangeManager:CreateSourceData");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateSourceData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateSourceData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CreateSourceData_InFileName_Offset), 0, CreateSourceData_InFileName_PropertyAddress.Address, InFileName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateSourceData_FunctionAddress, intPtr, CreateSourceData_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CreateSourceData_InFileName_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UInterchangeSourceData>.FromNative(IntPtr.Add(intPtr, CreateSourceData_ReturnValue_Offset), 0, CreateSourceData_ReturnValue_PropertyAddress.Address);
	}

	static UInterchangeManager()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UInterchangeManager)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UInterchangeManager));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/InterchangeEngine.InterchangeManager");
		ImportScene_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ImportScene");
		ImportScene_ParamsSize = NativeReflection.GetFunctionParamsSize(ImportScene_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ImportScene_ContentPath_PropertyAddress, ImportScene_FunctionAddress, "ContentPath");
		ImportScene_ContentPath_Offset = NativeReflectionCached.GetPropertyOffset(ImportScene_FunctionAddress, "ContentPath");
		ImportScene_ContentPath_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportScene_FunctionAddress, "ContentPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportScene_SourceData_PropertyAddress, ImportScene_FunctionAddress, "SourceData");
		ImportScene_SourceData_Offset = NativeReflectionCached.GetPropertyOffset(ImportScene_FunctionAddress, "SourceData");
		ImportScene_SourceData_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportScene_FunctionAddress, "SourceData", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportScene_ImportAssetParameters_PropertyAddress, ImportScene_FunctionAddress, "ImportAssetParameters");
		ImportScene_ImportAssetParameters_Offset = NativeReflectionCached.GetPropertyOffset(ImportScene_FunctionAddress, "ImportAssetParameters");
		ImportScene_ImportAssetParameters_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportScene_FunctionAddress, "ImportAssetParameters", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportScene_ReturnValue_PropertyAddress, ImportScene_FunctionAddress, "ReturnValue");
		ImportScene_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ImportScene_FunctionAddress, "ReturnValue");
		ImportScene_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportScene_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ImportScene_IsValid = ImportScene_FunctionAddress != IntPtr.Zero && ImportScene_ContentPath_IsValid && ImportScene_SourceData_IsValid && ImportScene_ImportAssetParameters_IsValid && ImportScene_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeEngine.InterchangeManager:ImportScene", ImportScene_IsValid);
		ImportAsset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ImportAsset");
		ImportAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(ImportAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ImportAsset_ContentPath_PropertyAddress, ImportAsset_FunctionAddress, "ContentPath");
		ImportAsset_ContentPath_Offset = NativeReflectionCached.GetPropertyOffset(ImportAsset_FunctionAddress, "ContentPath");
		ImportAsset_ContentPath_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportAsset_FunctionAddress, "ContentPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportAsset_SourceData_PropertyAddress, ImportAsset_FunctionAddress, "SourceData");
		ImportAsset_SourceData_Offset = NativeReflectionCached.GetPropertyOffset(ImportAsset_FunctionAddress, "SourceData");
		ImportAsset_SourceData_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportAsset_FunctionAddress, "SourceData", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportAsset_ImportAssetParameters_PropertyAddress, ImportAsset_FunctionAddress, "ImportAssetParameters");
		ImportAsset_ImportAssetParameters_Offset = NativeReflectionCached.GetPropertyOffset(ImportAsset_FunctionAddress, "ImportAssetParameters");
		ImportAsset_ImportAssetParameters_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportAsset_FunctionAddress, "ImportAssetParameters", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportAsset_ReturnValue_PropertyAddress, ImportAsset_FunctionAddress, "ReturnValue");
		ImportAsset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ImportAsset_FunctionAddress, "ReturnValue");
		ImportAsset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportAsset_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ImportAsset_IsValid = ImportAsset_FunctionAddress != IntPtr.Zero && ImportAsset_ContentPath_IsValid && ImportAsset_SourceData_IsValid && ImportAsset_ImportAssetParameters_IsValid && ImportAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeEngine.InterchangeManager:ImportAsset", ImportAsset_IsValid);
		GetRegisteredFactoryClass_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetRegisteredFactoryClass");
		GetRegisteredFactoryClass_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRegisteredFactoryClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRegisteredFactoryClass_ClassToMake_PropertyAddress, GetRegisteredFactoryClass_FunctionAddress, "ClassToMake");
		GetRegisteredFactoryClass_ClassToMake_Offset = NativeReflectionCached.GetPropertyOffset(GetRegisteredFactoryClass_FunctionAddress, "ClassToMake");
		GetRegisteredFactoryClass_ClassToMake_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRegisteredFactoryClass_FunctionAddress, "ClassToMake", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRegisteredFactoryClass_ReturnValue_PropertyAddress, GetRegisteredFactoryClass_FunctionAddress, "ReturnValue");
		GetRegisteredFactoryClass_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRegisteredFactoryClass_FunctionAddress, "ReturnValue");
		GetRegisteredFactoryClass_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRegisteredFactoryClass_FunctionAddress, "ReturnValue", Classes.FClassProperty);
		GetRegisteredFactoryClass_IsValid = GetRegisteredFactoryClass_FunctionAddress != IntPtr.Zero && GetRegisteredFactoryClass_ClassToMake_IsValid && GetRegisteredFactoryClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeEngine.InterchangeManager:GetRegisteredFactoryClass", GetRegisteredFactoryClass_IsValid);
		GetInterchangeManagerScripted_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetInterchangeManagerScripted");
		GetInterchangeManagerScripted_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInterchangeManagerScripted_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInterchangeManagerScripted_ReturnValue_PropertyAddress, GetInterchangeManagerScripted_FunctionAddress, "ReturnValue");
		GetInterchangeManagerScripted_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetInterchangeManagerScripted_FunctionAddress, "ReturnValue");
		GetInterchangeManagerScripted_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInterchangeManagerScripted_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetInterchangeManagerScripted_IsValid = GetInterchangeManagerScripted_FunctionAddress != IntPtr.Zero && GetInterchangeManagerScripted_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeEngine.InterchangeManager:GetInterchangeManagerScripted", GetInterchangeManagerScripted_IsValid);
		ExportScene_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ExportScene");
		ExportScene_ParamsSize = NativeReflection.GetFunctionParamsSize(ExportScene_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ExportScene_World_PropertyAddress, ExportScene_FunctionAddress, "World");
		ExportScene_World_Offset = NativeReflectionCached.GetPropertyOffset(ExportScene_FunctionAddress, "World");
		ExportScene_World_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportScene_FunctionAddress, "World", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportScene_bIsAutomated_PropertyAddress, ExportScene_FunctionAddress, "bIsAutomated");
		ExportScene_bIsAutomated_Offset = NativeReflectionCached.GetPropertyOffset(ExportScene_FunctionAddress, "bIsAutomated");
		ExportScene_bIsAutomated_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportScene_FunctionAddress, "bIsAutomated", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportScene_ReturnValue_PropertyAddress, ExportScene_FunctionAddress, "ReturnValue");
		ExportScene_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ExportScene_FunctionAddress, "ReturnValue");
		ExportScene_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportScene_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ExportScene_IsValid = ExportScene_FunctionAddress != IntPtr.Zero && ExportScene_World_IsValid && ExportScene_bIsAutomated_IsValid && ExportScene_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeEngine.InterchangeManager:ExportScene", ExportScene_IsValid);
		ExportAsset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ExportAsset");
		ExportAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(ExportAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ExportAsset_Asset_PropertyAddress, ExportAsset_FunctionAddress, "Asset");
		ExportAsset_Asset_Offset = NativeReflectionCached.GetPropertyOffset(ExportAsset_FunctionAddress, "Asset");
		ExportAsset_Asset_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportAsset_FunctionAddress, "Asset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportAsset_bIsAutomated_PropertyAddress, ExportAsset_FunctionAddress, "bIsAutomated");
		ExportAsset_bIsAutomated_Offset = NativeReflectionCached.GetPropertyOffset(ExportAsset_FunctionAddress, "bIsAutomated");
		ExportAsset_bIsAutomated_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportAsset_FunctionAddress, "bIsAutomated", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportAsset_ReturnValue_PropertyAddress, ExportAsset_FunctionAddress, "ReturnValue");
		ExportAsset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ExportAsset_FunctionAddress, "ReturnValue");
		ExportAsset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportAsset_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ExportAsset_IsValid = ExportAsset_FunctionAddress != IntPtr.Zero && ExportAsset_Asset_IsValid && ExportAsset_bIsAutomated_IsValid && ExportAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeEngine.InterchangeManager:ExportAsset", ExportAsset_IsValid);
		CreateSourceData_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateSourceData");
		CreateSourceData_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateSourceData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateSourceData_InFileName_PropertyAddress, CreateSourceData_FunctionAddress, "InFileName");
		CreateSourceData_InFileName_Offset = NativeReflectionCached.GetPropertyOffset(CreateSourceData_FunctionAddress, "InFileName");
		CreateSourceData_InFileName_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateSourceData_FunctionAddress, "InFileName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateSourceData_ReturnValue_PropertyAddress, CreateSourceData_FunctionAddress, "ReturnValue");
		CreateSourceData_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateSourceData_FunctionAddress, "ReturnValue");
		CreateSourceData_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateSourceData_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CreateSourceData_IsValid = CreateSourceData_FunctionAddress != IntPtr.Zero && CreateSourceData_InFileName_IsValid && CreateSourceData_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeEngine.InterchangeManager:CreateSourceData", CreateSourceData_IsValid);
	}
}
