using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.GeometryFramework;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_SceneUtilityFunctions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public class UGeometryScript_SceneUtils : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SetComponentMaterialList_IsValid;

	private static IntPtr SetComponentMaterialList_FunctionAddress;

	private static int SetComponentMaterialList_ParamsSize;

	private static bool SetComponentMaterialList_Component_IsValid;

	private static FFieldAddress SetComponentMaterialList_Component_PropertyAddress;

	private static int SetComponentMaterialList_Component_Offset;

	private static bool SetComponentMaterialList_MaterialList_IsValid;

	private static FFieldAddress SetComponentMaterialList_MaterialList_PropertyAddress;

	private static int SetComponentMaterialList_MaterialList_Offset;

	private static bool SetComponentMaterialList_Debug_IsValid;

	private static FFieldAddress SetComponentMaterialList_Debug_PropertyAddress;

	private static int SetComponentMaterialList_Debug_Offset;

	private static bool CreateDynamicMeshPool_IsValid;

	private static IntPtr CreateDynamicMeshPool_FunctionAddress;

	private static int CreateDynamicMeshPool_ParamsSize;

	private static bool CreateDynamicMeshPool_ReturnValue_IsValid;

	private static FFieldAddress CreateDynamicMeshPool_ReturnValue_PropertyAddress;

	private static int CreateDynamicMeshPool_ReturnValue_Offset;

	private static bool CopyMeshFromComponent_IsValid;

	private static IntPtr CopyMeshFromComponent_FunctionAddress;

	private static int CopyMeshFromComponent_ParamsSize;

	private static bool CopyMeshFromComponent_Component_IsValid;

	private static FFieldAddress CopyMeshFromComponent_Component_PropertyAddress;

	private static int CopyMeshFromComponent_Component_Offset;

	private static bool CopyMeshFromComponent_ToDynamicMesh_IsValid;

	private static FFieldAddress CopyMeshFromComponent_ToDynamicMesh_PropertyAddress;

	private static int CopyMeshFromComponent_ToDynamicMesh_Offset;

	private static bool CopyMeshFromComponent_Options_IsValid;

	private static FFieldAddress CopyMeshFromComponent_Options_PropertyAddress;

	private static int CopyMeshFromComponent_Options_Offset;

	private static bool CopyMeshFromComponent_bTransformToWorld_IsValid;

	private static FFieldAddress CopyMeshFromComponent_bTransformToWorld_PropertyAddress;

	private static int CopyMeshFromComponent_bTransformToWorld_Offset;

	private static bool CopyMeshFromComponent_LocalToWorld_IsValid;

	private static FFieldAddress CopyMeshFromComponent_LocalToWorld_PropertyAddress;

	private static int CopyMeshFromComponent_LocalToWorld_Offset;

	private static bool CopyMeshFromComponent_Outcome_IsValid;

	private static FFieldAddress CopyMeshFromComponent_Outcome_PropertyAddress;

	private static int CopyMeshFromComponent_Outcome_Offset;

	private static bool CopyMeshFromComponent_Debug_IsValid;

	private static FFieldAddress CopyMeshFromComponent_Debug_PropertyAddress;

	private static int CopyMeshFromComponent_Debug_Offset;

	private static bool CopyMeshFromComponent_ReturnValue_IsValid;

	private static FFieldAddress CopyMeshFromComponent_ReturnValue_PropertyAddress;

	private static int CopyMeshFromComponent_ReturnValue_Offset;

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_SceneUtilityFunctions:SetComponentMaterialList")]
	public unsafe static void SetComponentMaterialList(UPrimitiveComponent Component, List<UMaterialInterface> MaterialList, UGeometryScriptDebug Debug)
	{
		if (!SetComponentMaterialList_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_SceneUtilityFunctions:SetComponentMaterialList");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetComponentMaterialList_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetComponentMaterialList_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(intPtr, SetComponentMaterialList_Component_Offset), 0, SetComponentMaterialList_Component_PropertyAddress.Address, Component);
		new TArrayCopyMarshaler<UMaterialInterface>(1, SetComponentMaterialList_MaterialList_PropertyAddress, CachedMarshalingDelegates<UMaterialInterface, UObjectMarshaler<UMaterialInterface>>.FromNative, CachedMarshalingDelegates<UMaterialInterface, UObjectMarshaler<UMaterialInterface>>.ToNative).ToNative(IntPtr.Add(intPtr, SetComponentMaterialList_MaterialList_Offset), MaterialList);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, SetComponentMaterialList_Debug_Offset), 0, SetComponentMaterialList_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetComponentMaterialList_FunctionAddress, intPtr, SetComponentMaterialList_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetComponentMaterialList_MaterialList_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_SceneUtilityFunctions:CreateDynamicMeshPool")]
	public unsafe static UDynamicMeshPool CreateDynamicMeshPool()
	{
		if (!CreateDynamicMeshPool_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_SceneUtilityFunctions:CreateDynamicMeshPool");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateDynamicMeshPool_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateDynamicMeshPool_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateDynamicMeshPool_FunctionAddress, intPtr, CreateDynamicMeshPool_ParamsSize);
		return UObjectMarshaler<UDynamicMeshPool>.FromNative(IntPtr.Add(intPtr, CreateDynamicMeshPool_ReturnValue_Offset), 0, CreateDynamicMeshPool_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_SceneUtilityFunctions:CopyMeshFromComponent")]
	public unsafe static UDynamicMesh CopyMeshFromComponent(USceneComponent Component, UDynamicMesh ToDynamicMesh, FGeometryScriptCopyMeshFromComponentOptions Options, bool bTransformToWorld, out FTransform LocalToWorld, out EGeometryScriptOutcomePins Outcome, UGeometryScriptDebug Debug)
	{
		if (!CopyMeshFromComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_SceneUtilityFunctions:CopyMeshFromComponent");
			LocalToWorld = default(FTransform);
			Outcome = EGeometryScriptOutcomePins.Failure;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CopyMeshFromComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CopyMeshFromComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(intPtr, CopyMeshFromComponent_Component_Offset), 0, CopyMeshFromComponent_Component_PropertyAddress.Address, Component);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, CopyMeshFromComponent_ToDynamicMesh_Offset), 0, CopyMeshFromComponent_ToDynamicMesh_PropertyAddress.Address, ToDynamicMesh);
		NativeReflection.InitializeValue_InContainer(CopyMeshFromComponent_Options_PropertyAddress.Address, intPtr);
		FGeometryScriptCopyMeshFromComponentOptions.ToNative(IntPtr.Add(intPtr, CopyMeshFromComponent_Options_Offset), 0, CopyMeshFromComponent_Options_PropertyAddress.Address, Options);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CopyMeshFromComponent_bTransformToWorld_Offset), 0, CopyMeshFromComponent_bTransformToWorld_PropertyAddress.Address, bTransformToWorld);
		NativeReflection.InitializeValue_InContainer(CopyMeshFromComponent_LocalToWorld_PropertyAddress.Address, intPtr);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, CopyMeshFromComponent_Debug_Offset), 0, CopyMeshFromComponent_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CopyMeshFromComponent_FunctionAddress, intPtr, CopyMeshFromComponent_ParamsSize);
		LocalToWorld = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, CopyMeshFromComponent_LocalToWorld_Offset), 0, CopyMeshFromComponent_LocalToWorld_PropertyAddress.Address);
		Outcome = EnumMarshaler<EGeometryScriptOutcomePins>.FromNative(IntPtr.Add(intPtr, CopyMeshFromComponent_Outcome_Offset), 0, CopyMeshFromComponent_Outcome_PropertyAddress.Address);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, CopyMeshFromComponent_ReturnValue_Offset), 0, CopyMeshFromComponent_ReturnValue_PropertyAddress.Address);
	}

	static UGeometryScript_SceneUtils()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGeometryScript_SceneUtils)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGeometryScript_SceneUtils));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/GeometryScriptingCore.GeometryScriptLibrary_SceneUtilityFunctions");
		SetComponentMaterialList_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetComponentMaterialList");
		SetComponentMaterialList_ParamsSize = NativeReflection.GetFunctionParamsSize(SetComponentMaterialList_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetComponentMaterialList_Component_PropertyAddress, SetComponentMaterialList_FunctionAddress, "Component");
		SetComponentMaterialList_Component_Offset = NativeReflectionCached.GetPropertyOffset(SetComponentMaterialList_FunctionAddress, "Component");
		SetComponentMaterialList_Component_IsValid = NativeReflectionCached.ValidatePropertyClass(SetComponentMaterialList_FunctionAddress, "Component", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetComponentMaterialList_MaterialList_PropertyAddress, SetComponentMaterialList_FunctionAddress, "MaterialList");
		SetComponentMaterialList_MaterialList_Offset = NativeReflectionCached.GetPropertyOffset(SetComponentMaterialList_FunctionAddress, "MaterialList");
		SetComponentMaterialList_MaterialList_IsValid = NativeReflectionCached.ValidatePropertyClass(SetComponentMaterialList_FunctionAddress, "MaterialList", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SetComponentMaterialList_Debug_PropertyAddress, SetComponentMaterialList_FunctionAddress, "Debug");
		SetComponentMaterialList_Debug_Offset = NativeReflectionCached.GetPropertyOffset(SetComponentMaterialList_FunctionAddress, "Debug");
		SetComponentMaterialList_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(SetComponentMaterialList_FunctionAddress, "Debug", Classes.FObjectProperty);
		SetComponentMaterialList_IsValid = SetComponentMaterialList_FunctionAddress != IntPtr.Zero && SetComponentMaterialList_Component_IsValid && SetComponentMaterialList_MaterialList_IsValid && SetComponentMaterialList_Debug_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_SceneUtilityFunctions:SetComponentMaterialList", SetComponentMaterialList_IsValid);
		CreateDynamicMeshPool_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateDynamicMeshPool");
		CreateDynamicMeshPool_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateDynamicMeshPool_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateDynamicMeshPool_ReturnValue_PropertyAddress, CreateDynamicMeshPool_FunctionAddress, "ReturnValue");
		CreateDynamicMeshPool_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateDynamicMeshPool_FunctionAddress, "ReturnValue");
		CreateDynamicMeshPool_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateDynamicMeshPool_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CreateDynamicMeshPool_IsValid = CreateDynamicMeshPool_FunctionAddress != IntPtr.Zero && CreateDynamicMeshPool_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_SceneUtilityFunctions:CreateDynamicMeshPool", CreateDynamicMeshPool_IsValid);
		CopyMeshFromComponent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CopyMeshFromComponent");
		CopyMeshFromComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(CopyMeshFromComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CopyMeshFromComponent_Component_PropertyAddress, CopyMeshFromComponent_FunctionAddress, "Component");
		CopyMeshFromComponent_Component_Offset = NativeReflectionCached.GetPropertyOffset(CopyMeshFromComponent_FunctionAddress, "Component");
		CopyMeshFromComponent_Component_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyMeshFromComponent_FunctionAddress, "Component", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyMeshFromComponent_ToDynamicMesh_PropertyAddress, CopyMeshFromComponent_FunctionAddress, "ToDynamicMesh");
		CopyMeshFromComponent_ToDynamicMesh_Offset = NativeReflectionCached.GetPropertyOffset(CopyMeshFromComponent_FunctionAddress, "ToDynamicMesh");
		CopyMeshFromComponent_ToDynamicMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyMeshFromComponent_FunctionAddress, "ToDynamicMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyMeshFromComponent_Options_PropertyAddress, CopyMeshFromComponent_FunctionAddress, "Options");
		CopyMeshFromComponent_Options_Offset = NativeReflectionCached.GetPropertyOffset(CopyMeshFromComponent_FunctionAddress, "Options");
		CopyMeshFromComponent_Options_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyMeshFromComponent_FunctionAddress, "Options", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyMeshFromComponent_bTransformToWorld_PropertyAddress, CopyMeshFromComponent_FunctionAddress, "bTransformToWorld");
		CopyMeshFromComponent_bTransformToWorld_Offset = NativeReflectionCached.GetPropertyOffset(CopyMeshFromComponent_FunctionAddress, "bTransformToWorld");
		CopyMeshFromComponent_bTransformToWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyMeshFromComponent_FunctionAddress, "bTransformToWorld", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyMeshFromComponent_LocalToWorld_PropertyAddress, CopyMeshFromComponent_FunctionAddress, "LocalToWorld");
		CopyMeshFromComponent_LocalToWorld_Offset = NativeReflectionCached.GetPropertyOffset(CopyMeshFromComponent_FunctionAddress, "LocalToWorld");
		CopyMeshFromComponent_LocalToWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyMeshFromComponent_FunctionAddress, "LocalToWorld", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyMeshFromComponent_Outcome_PropertyAddress, CopyMeshFromComponent_FunctionAddress, "Outcome");
		CopyMeshFromComponent_Outcome_Offset = NativeReflectionCached.GetPropertyOffset(CopyMeshFromComponent_FunctionAddress, "Outcome");
		CopyMeshFromComponent_Outcome_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyMeshFromComponent_FunctionAddress, "Outcome", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyMeshFromComponent_Debug_PropertyAddress, CopyMeshFromComponent_FunctionAddress, "Debug");
		CopyMeshFromComponent_Debug_Offset = NativeReflectionCached.GetPropertyOffset(CopyMeshFromComponent_FunctionAddress, "Debug");
		CopyMeshFromComponent_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyMeshFromComponent_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyMeshFromComponent_ReturnValue_PropertyAddress, CopyMeshFromComponent_FunctionAddress, "ReturnValue");
		CopyMeshFromComponent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CopyMeshFromComponent_FunctionAddress, "ReturnValue");
		CopyMeshFromComponent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyMeshFromComponent_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CopyMeshFromComponent_IsValid = CopyMeshFromComponent_FunctionAddress != IntPtr.Zero && CopyMeshFromComponent_Component_IsValid && CopyMeshFromComponent_ToDynamicMesh_IsValid && CopyMeshFromComponent_Options_IsValid && CopyMeshFromComponent_bTransformToWorld_IsValid && CopyMeshFromComponent_LocalToWorld_IsValid && CopyMeshFromComponent_Outcome_IsValid && CopyMeshFromComponent_Debug_IsValid && CopyMeshFromComponent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_SceneUtilityFunctions:CopyMeshFromComponent", CopyMeshFromComponent_IsValid);
	}
}
