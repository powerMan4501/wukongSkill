using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ModelingComponents;

[Abstract]
[UClass(Flags = (ClassFlags)810549409uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/ModelingComponents.ModelingObjectsCreationAPI", "ModelingComponents", UnrealModuleType.EnginePlugin)]
public class UModelingObjectsCreationAPI : UObject
{
	private static bool CreateTextureObject_IsValid;

	private static IntPtr CreateTextureObject_FunctionAddress;

	private static int CreateTextureObject_ParamsSize;

	private static bool CreateTextureObject_CreateTexParams_IsValid;

	private static FFieldAddress CreateTextureObject_CreateTexParams_PropertyAddress;

	private static int CreateTextureObject_CreateTexParams_Offset;

	private static bool CreateTextureObject_ReturnValue_IsValid;

	private static FFieldAddress CreateTextureObject_ReturnValue_PropertyAddress;

	private static int CreateTextureObject_ReturnValue_Offset;

	private static bool CreateMeshObject_IsValid;

	private static IntPtr CreateMeshObject_FunctionAddress;

	private static int CreateMeshObject_ParamsSize;

	private static bool CreateMeshObject_CreateMeshParams_IsValid;

	private static FFieldAddress CreateMeshObject_CreateMeshParams_PropertyAddress;

	private static int CreateMeshObject_CreateMeshParams_Offset;

	private static bool CreateMeshObject_ReturnValue_IsValid;

	private static FFieldAddress CreateMeshObject_ReturnValue_PropertyAddress;

	private static int CreateMeshObject_ReturnValue_Offset;

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/ModelingComponents.ModelingObjectsCreationAPI:CreateTextureObject")]
	public unsafe FCreateTextureObjectResult CreateTextureObject(FCreateTextureObjectParams CreateTexParams)
	{
		CheckDestroyed();
		if (!CreateTextureObject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ModelingComponents.ModelingObjectsCreationAPI:CreateTextureObject");
			return default(FCreateTextureObjectResult);
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateTextureObject_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateTextureObject_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(CreateTextureObject_CreateTexParams_PropertyAddress.Address, intPtr);
		FCreateTextureObjectParams.ToNative(IntPtr.Add(intPtr, CreateTextureObject_CreateTexParams_Offset), 0, CreateTextureObject_CreateTexParams_PropertyAddress.Address, CreateTexParams);
		NativeReflection.InvokeFunctionOptimized(base.Address, CreateTextureObject_FunctionAddress, intPtr, CreateTextureObject_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CreateTextureObject_CreateTexParams_PropertyAddress.Address, intPtr);
		return FCreateTextureObjectResult.FromNative(IntPtr.Add(intPtr, CreateTextureObject_ReturnValue_Offset), 0, CreateTextureObject_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/ModelingComponents.ModelingObjectsCreationAPI:CreateMeshObject")]
	public unsafe FCreateMeshObjectResult CreateMeshObject(FCreateMeshObjectParams CreateMeshParams)
	{
		CheckDestroyed();
		if (!CreateMeshObject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ModelingComponents.ModelingObjectsCreationAPI:CreateMeshObject");
			return default(FCreateMeshObjectResult);
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateMeshObject_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateMeshObject_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(CreateMeshObject_CreateMeshParams_PropertyAddress.Address, intPtr);
		FCreateMeshObjectParams.ToNative(IntPtr.Add(intPtr, CreateMeshObject_CreateMeshParams_Offset), 0, CreateMeshObject_CreateMeshParams_PropertyAddress.Address, CreateMeshParams);
		NativeReflection.InvokeFunctionOptimized(base.Address, CreateMeshObject_FunctionAddress, intPtr, CreateMeshObject_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CreateMeshObject_CreateMeshParams_PropertyAddress.Address, intPtr);
		return FCreateMeshObjectResult.FromNative(IntPtr.Add(intPtr, CreateMeshObject_ReturnValue_Offset), 0, CreateMeshObject_ReturnValue_PropertyAddress.Address);
	}

	static UModelingObjectsCreationAPI()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UModelingObjectsCreationAPI)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UModelingObjectsCreationAPI));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/ModelingComponents.ModelingObjectsCreationAPI");
		CreateTextureObject_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CreateTextureObject");
		CreateTextureObject_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateTextureObject_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateTextureObject_CreateTexParams_PropertyAddress, CreateTextureObject_FunctionAddress, "CreateTexParams");
		CreateTextureObject_CreateTexParams_Offset = NativeReflectionCached.GetPropertyOffset(CreateTextureObject_FunctionAddress, "CreateTexParams");
		CreateTextureObject_CreateTexParams_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateTextureObject_FunctionAddress, "CreateTexParams", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateTextureObject_ReturnValue_PropertyAddress, CreateTextureObject_FunctionAddress, "ReturnValue");
		CreateTextureObject_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateTextureObject_FunctionAddress, "ReturnValue");
		CreateTextureObject_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateTextureObject_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		CreateTextureObject_IsValid = CreateTextureObject_FunctionAddress != IntPtr.Zero && CreateTextureObject_CreateTexParams_IsValid && CreateTextureObject_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ModelingComponents.ModelingObjectsCreationAPI:CreateTextureObject", CreateTextureObject_IsValid);
		CreateMeshObject_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CreateMeshObject");
		CreateMeshObject_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateMeshObject_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateMeshObject_CreateMeshParams_PropertyAddress, CreateMeshObject_FunctionAddress, "CreateMeshParams");
		CreateMeshObject_CreateMeshParams_Offset = NativeReflectionCached.GetPropertyOffset(CreateMeshObject_FunctionAddress, "CreateMeshParams");
		CreateMeshObject_CreateMeshParams_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateMeshObject_FunctionAddress, "CreateMeshParams", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateMeshObject_ReturnValue_PropertyAddress, CreateMeshObject_FunctionAddress, "ReturnValue");
		CreateMeshObject_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateMeshObject_FunctionAddress, "ReturnValue");
		CreateMeshObject_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateMeshObject_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		CreateMeshObject_IsValid = CreateMeshObject_FunctionAddress != IntPtr.Zero && CreateMeshObject_CreateMeshParams_IsValid && CreateMeshObject_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ModelingComponents.ModelingObjectsCreationAPI:CreateMeshObject", CreateMeshObject_IsValid);
	}
}
